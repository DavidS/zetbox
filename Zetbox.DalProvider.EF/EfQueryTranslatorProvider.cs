
namespace Zetbox.DalProvider.Ef
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using Zetbox.API;
    using Zetbox.API.Common;
    using Zetbox.API.Server;
    using Zetbox.App.Base;
    using Zetbox.API.Server.PerfCounter;

    internal sealed class EfQueryTranslatorProvider<T>
        : QueryTranslatorProvider<T>
    {
        internal EfQueryTranslatorProvider(IMetaDataResolver metaDataResolver, Identity identity, IQueryable source, IZetboxContext ctx, InterfaceType.Factory iftFactory, IPerfCounter perfCounter)
            : base(metaDataResolver, identity, source, ctx, iftFactory, perfCounter)
        {
        }

        protected override QueryTranslatorProvider<TElement> GetSubProvider<TElement>()
        {
            return new EfQueryTranslatorProvider<TElement>(MetaDataResolver, Identity, Source, Ctx, IftFactory, perfCounter);
        }

        protected override string ImplementationSuffix
        {
            get { return "Ef" + Zetbox.API.Helper.ImplementationSuffix; }
        }

        protected override System.Linq.Expressions.Expression VisitConstant(System.Linq.Expressions.ConstantExpression c)
        {
            // Ef cannot map enumerations to the database, we need to use ints instead
            if (c.Value != null && c.Type.IsEnum) // Handle Enums
            {
                return Expression.Constant((int)c.Value, typeof(int));
            }
            else if (c.Value != null && c.Type.IsGenericType && c.Type.GetGenericTypeDefinition() == typeof(Nullable<>) && c.Type.GetGenericArguments().Single().IsEnum)
            {
                return Expression.Constant((int)c.Value, typeof(int?)); // You can't extract a int? from an enum value
            }
            else
            {
                return base.VisitConstant(c);
            }
        }
    }
}
