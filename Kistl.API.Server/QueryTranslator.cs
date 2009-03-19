using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Collections;
using System.Reflection;
using System.Collections.ObjectModel;
using Kistl.API;

namespace Kistl.API.Server
{
    // http://msdn.microsoft.com/en-us/library/bb549414.aspx
    // The Execute method executes queries that return a single value 
    // (instead of an enumerable sequence of values). Expression trees that represent queries 
    // that return enumerable results are executed when the IQueryable<(Of <(T>)>) object that 
    // contains the expression tree is enumerated. 
    // The Queryable standard query operator methods that return singleton results call Execute. 
    // They pass it a MethodCallExpression that represents a LINQ query. 
    // http://blogs.msdn.com/mattwar/archive/2007/07/30/linq-building-an-iqueryable-provider-part-i.aspx

    #region QueryTranslator
    public class QueryTranslator<T> : IOrderedQueryable<T>
    {
        private Expression _expression = null;
        private QueryTranslatorProvider<T> _provider = null;

        public QueryTranslator(IQueryable source, IKistlContext ctx)
        {
            _expression = Expression.Constant(this);
            _provider = new QueryTranslatorProvider<T>(source, ctx);
        }

        public QueryTranslator(IQueryable source, IKistlContext ctx, Expression e)
        {
            if (e == null) throw new ArgumentNullException("e");
            _expression = e;
            _provider = new QueryTranslatorProvider<T>(source, ctx);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_provider.ExecuteEnumerable(this._expression)).GetEnumerator();
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _provider.ExecuteEnumerable(this._expression).GetEnumerator();
        }

        public Type ElementType
        {
            get { return typeof(T); }
        }

        public Expression Expression
        {
            get { return _expression; }
        }

        public IQueryProvider Provider
        {
            get { return _provider; }
        }
    }
    #endregion

    #region QueryTranslatorProvider
    public class QueryTranslatorProvider<T> : ExpressionTreeTranslator, IQueryProvider
    {
        IQueryable _source;
        IKistlContext _ctx = null;
        Expression _filter = null;

        public QueryTranslatorProvider(IQueryable source, IKistlContext ctx)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (ctx == null) throw new ArgumentNullException("ctx");
            _source = source;
            _ctx = ctx;
        }

        #region IQueryProvider Members

        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            if (expression == null) throw new ArgumentNullException("expression");
            return new QueryTranslator<TElement>(_source, _ctx, expression) as IQueryable<TElement>;
        }

        public IQueryable CreateQuery(Expression expression)
        {
            if (expression == null) throw new ArgumentNullException("expression");

            Type elementType = expression.Type.GetCollectionElementType();
            IQueryable result = (IQueryable)Activator.CreateInstance(typeof(QueryTranslator<>).MakeGenericType(elementType),
                new object[] { _source, _ctx, expression });
            return result;
        }

        public TResult Execute<TResult>(Expression expression)
        {
            if (expression == null) throw new ArgumentNullException("expression");
            object result = (this as IQueryProvider).Execute(expression);
            return (TResult)result;
        }

        public object Execute(Expression expression)
        {
            if (expression == null) throw new ArgumentNullException("expression");

            Expression translated = this.Visit(expression);

            object result = _source.Provider.Execute(translated);
            if (result != null && result is IPersistenceObject)
            {
                ((IPersistenceObject)result).AttachToContext(_ctx);
            }
            return result;
        }

        internal IEnumerable ExecuteEnumerable(Expression expression)
        {
            if (expression == null) throw new ArgumentNullException("expression");
            Expression translated = this.Visit(expression);

            IQueryable newQuery = _source.Provider.CreateQuery(translated);
            List<T> result = new List<T>();
            foreach (T item in newQuery)
            {
                if (item is IPersistenceObject) ((IPersistenceObject)item).AttachToContext(_ctx);
                result.Add(item);
            }
            return result;
        }

        #endregion

        #region MethodHelper
        public MethodInfo GetMethodInfo(MethodInfo input)
        {
            Type MethodType = input.DeclaringType.ToImplementationType();
            string MethodName = input.Name;

            List<Type> ParameterTypes = new List<Type>();
            ParameterTypes.AddRange(input.GetParameters().Select(p => p.ParameterType.ToImplementationType()));

            List<Type> GenericArguments = new List<Type>();
            GenericArguments.AddRange(input.GetGenericArguments().Select(p => p.ToImplementationType()));


            MethodInfo mi;
            if (GenericArguments != null && GenericArguments.Count > 0)
            {
                mi = MethodType.FindGenericMethod(MethodName,
                        GenericArguments.ToArray(),
                        ParameterTypes.ToArray());
            }
            else
            {
                mi = MethodType.GetMethod(MethodName, ParameterTypes.ToArray());
            }

            if (mi == null)
            {
                throw new MissingMethodException(MethodType.FullName, MethodName);
            }
            return mi;
        }
        #endregion

        #region Visits
        protected override MethodCallExpression VisitMethodCall(MethodCallExpression m)
        {
            Expression objExp = base.Visit(m.Object);
            MethodInfo newMethod = GetMethodInfo(m.Method);
            ReadOnlyCollection<Expression> args = base.VisitExpressionList(m.Arguments);
            m = Expression.Call(
                objExp,
                newMethod,
                args);

            return m;
        }

        protected override Expression VisitUnary(UnaryExpression u)
        {
            if (u.NodeType == ExpressionType.Convert)
            {
                // TODO: Only for IDataObjects, primitive Types should be allowed
                return base.Visit(u.Operand);
            }
            else
            {
                return Expression.MakeUnary(u.NodeType, base.Visit(u.Operand), u.Type.ToImplementationType(), u.Method);
            }
        }

        protected override LambdaExpression VisitLambda(LambdaExpression lambda)
        {
            try
            {
                Type t = lambda.Type.ToImplementationType();
                Expression body = base.Visit(lambda.Body);
                var parameters = base.VisitParameterList(lambda.Parameters);
                return Expression.Lambda(t, body, parameters);
            }
            catch
            {
                throw;
            }
        }

        protected override TypeBinaryExpression VisitTypeIs(TypeBinaryExpression b)
        {
            b = base.VisitTypeIs(b);
            return Expression.TypeIs(b.Expression, b.TypeOperand.ToImplementationType());
        }

        protected override ConstantExpression VisitConstant(ConstantExpression c)
        {
            c = base.VisitConstant(c);
            if (c.Type.IsGenericType && c.Type.GetGenericTypeDefinition() == typeof(QueryTranslator<>))
            {
                ConstantExpression s = (ConstantExpression)_source.Expression;
                return Expression.Constant(s.Value, s.Type);
            }
            else
            {
                return Expression.Constant(c.Value);
            }
        }

        private Dictionary<string, ParameterExpression> _Parameter = new Dictionary<string, ParameterExpression>();
        protected override ParameterExpression VisitParameter(ParameterExpression p)
        {
            if (!_Parameter.ContainsKey(p.Name))
            {
                _Parameter[p.Name] = Expression.Parameter(p.Type.ToImplementationType(), p.Name);
            }
            return _Parameter[p.Name];
        }

        protected override MemberExpression VisitMemberAccess(MemberExpression m)
        {
            Expression e = base.Visit(m.Expression);
            string memberName = m.Member.Name;
            Type declaringType = m.Member.DeclaringType.ToImplementationType();
            MemberExpression result;
            if (declaringType.GetMember(memberName).Length > 0 && declaringType.GetMember(memberName + Kistl.API.Helper.ImplementationSuffix).Length > 0)
            {
                result = Expression.PropertyOrField(e, memberName + Kistl.API.Helper.ImplementationSuffix);
            }
            else
            {
                result = Expression.MakeMemberAccess(e, m.Member);
            }
            return result;
        }

        protected override NewExpression VisitNew(NewExpression newExpression)
        {
            var args = VisitExpressionList(newExpression.Arguments);
            Type declaringType = newExpression.Constructor.DeclaringType.ToImplementationType();
            ConstructorInfo c = declaringType.GetConstructor(
                newExpression.Constructor.GetParameters().Select(p => p.ParameterType.ToImplementationType()).ToArray());

            if (newExpression.Members != null)
            {
                List<MemberInfo> members = new List<MemberInfo>();
                foreach (MemberInfo mi in newExpression.Members)
                {
                    declaringType = mi.DeclaringType.ToImplementationType();
                    if (declaringType.GetMember(mi.Name).Length > 0 && declaringType.GetMember(mi.Name + Kistl.API.Helper.ImplementationSuffix).Length > 0)
                    {
                        members.Add(declaringType.GetMember(mi.Name + Kistl.API.Helper.ImplementationSuffix)[0]);
                    }
                    else
                    {
                        members.Add(declaringType.GetMember(mi.Name)[0]);
                    }
                }
                return Expression.New(c, args, members);
            }
            else
            {
                return Expression.New(c, args);
            }
        }
        #endregion
    }
    #endregion
}
