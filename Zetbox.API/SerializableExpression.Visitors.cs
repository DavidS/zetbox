// This file is part of zetbox.
//
// Zetbox is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation, either version 3 of
// the License, or (at your option) any later version.
//
// Zetbox is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with zetbox.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Zetbox.API
{
    public partial class SerializableExpression
    {
        public abstract class Visitor<TResult>
        {
            public TResult Visit(SerializableExpression expr)
            {
                if (expr == null)
                    return VisitNull();

                if (expr is SerializableBinaryExpression)
                    return VisitExpression((SerializableBinaryExpression)expr);
                else if (expr is SerializableConditionalExpression)
                    return VisitExpression((SerializableConditionalExpression)expr);
                else if (expr is SerializableConstantExpression)
                    return VisitExpression((SerializableConstantExpression)expr);
                else if (expr is SerializableLambdaExpression)
                    return VisitExpression((SerializableLambdaExpression)expr);
                else if (expr is SerializableMemberExpression)
                    return VisitExpression((SerializableMemberExpression)expr);
                else if (expr is SerializableMethodCallExpression)
                    return VisitExpression((SerializableMethodCallExpression)expr);
                else if (expr is SerializableNewExpression)
                    return VisitExpression((SerializableNewExpression)expr);
                else if (expr is SerializableParameterExpression)
                    return VisitExpression((SerializableParameterExpression)expr);
                else if (expr is SerializableUnaryExpression)
                    return VisitExpression((SerializableUnaryExpression)expr);
                else
                    return VisitUnknown(expr);

            }

            /// <summary>
            /// Handle a null input value. Throws a ArgumentNullException by default.
            /// </summary>
            /// <returns></returns>
            /// 
            [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Justification="used as utility function in Visit(expr), thereby throwing the right exception")]
            protected virtual TResult VisitNull()
            {
                throw new ArgumentNullException("expr");
            }

            protected abstract TResult VisitExpression(SerializableBinaryExpression expr);
            protected abstract TResult VisitExpression(SerializableConditionalExpression expr);
            protected abstract TResult VisitExpression(SerializableConstantExpression expr);
            protected abstract TResult VisitExpression(SerializableLambdaExpression expr);
            protected abstract TResult VisitExpression(SerializableMemberExpression expr);
            protected abstract TResult VisitExpression(SerializableMethodCallExpression expr);
            protected abstract TResult VisitExpression(SerializableNewExpression expr);
            protected abstract TResult VisitExpression(SerializableParameterExpression expr);
            protected abstract TResult VisitExpression(SerializableUnaryExpression expr);

            /// <summary>
            /// convert a unknown expression type. throws a NotImplementedException by default.
            /// </summary>
            protected virtual TResult VisitUnknown(SerializableExpression expr)
            {
                throw new NotSupportedException(string.Format("Type {0} is not supported: {1}", expr.GetType(), expr.ToString()));
            }
        }

    }

    // TODO use ExpressionTreeVisitor/Translator
    public abstract class ExpressionVisitor<TResult>
    {

        public TResult Visit(Expression expr)
        {
            if (expr == null)
                return VisitNull();

            if (expr is BinaryExpression)
                return VisitExpression((BinaryExpression)expr);
            else if (expr is ConditionalExpression)
                return VisitExpression((ConditionalExpression)expr);
            else if (expr is ConstantExpression)
                return VisitExpression((ConstantExpression)expr);
            else if (expr is LambdaExpression)
                return VisitExpression((LambdaExpression)expr);
            else if (expr is MemberExpression)
                return VisitExpression((MemberExpression)expr);
            else if (expr is MethodCallExpression)
                return VisitExpression((MethodCallExpression)expr);
            else if (expr is NewExpression)
                return VisitExpression((NewExpression)expr);
            else if (expr is ParameterExpression)
                return VisitExpression((ParameterExpression)expr);
            else if (expr is UnaryExpression)
                return VisitExpression((UnaryExpression)expr);
            else
                return VisitUnknown(expr);

        }

        /// <summary>
        /// Handle a null input value. Throws a ArgumentNullException by default.
        /// </summary>
        /// <returns></returns>
        [SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly", Justification="used as utility function in Visit(expr), thereby throwing the right exception")]
        protected virtual TResult VisitNull()
        {
            throw new ArgumentNullException("expr");
        }

        protected abstract TResult VisitExpression(BinaryExpression expr);
        protected abstract TResult VisitExpression(ConditionalExpression expr);
        protected abstract TResult VisitExpression(ConstantExpression expr);
        protected abstract TResult VisitExpression(LambdaExpression expr);
        protected abstract TResult VisitExpression(MemberExpression expr);
        protected abstract TResult VisitExpression(MethodCallExpression expr);
        protected abstract TResult VisitExpression(NewExpression expr);
        protected abstract TResult VisitExpression(ParameterExpression expr);
        protected abstract TResult VisitExpression(UnaryExpression expr);

        /// <summary>
        /// convert a unknown expression type. throws a NotImplementedException by default.
        /// </summary>
        protected virtual TResult VisitUnknown(Expression expr)
        {
            throw new NotSupportedException(string.Format("Type {0} is not supported: {1}", expr.GetType(), expr.ToString()));
        }
    }
}
