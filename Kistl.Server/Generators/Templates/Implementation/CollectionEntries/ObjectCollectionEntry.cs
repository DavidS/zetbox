using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kistl.API;
using Kistl.Server.Generators.Extensions;
using Kistl.Server.Movables;

namespace Kistl.Server.Generators.Templates.Implementation.CollectionEntries
{
    public abstract partial class ObjectCollectionEntry
        : Template
    {
        protected NewRelation rel { get; private set; }

        public ObjectCollectionEntry(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, NewRelation rel)
            : base(_host, ctx)
        {
            this.rel = rel;
        }

        protected override string GetCeClassName()
        {
            return rel.GetCollectionEntryClassName() + Kistl.API.Helper.ImplementationSuffix;
        }

        protected override string GetCeInterface()
        {
            return String.Format("{0}<{1}, {2}>",
                IsOrdered() ? "INewListEntry" : "INewCollectionEntry",
                rel.A.Type.ClassName,
                rel.B.Type.ClassName);
        }

        protected override bool IsOrdered()
        {
            return rel.A.HasPersistentOrder || rel.B.HasPersistentOrder;
        }
    }
}
