
namespace Zetbox.DalProvider.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Zetbox.API;
    using Zetbox.API.Client;
    using Zetbox.DalProvider.Base;

    public abstract class CompoundCollectionEntryClientImpl<TA, TAImpl, TB, TBImpl>
        : CompoundCollectionEntryBaseImpl<TA, TAImpl, TB, TBImpl>, IClientObject
        where TA : class, IDataObject
        where TAImpl : class, IDataObject, TA
        where TB : class, ICompoundObject
        where TBImpl : class, ICompoundObject, TB
    {
        protected CompoundCollectionEntryClientImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        #region IClientObject Members

        void IClientObject.SetUnmodified() { base.SetUnmodified(); }
        void IClientObject.SetDeleted() { base.SetDeleted(); }

        BasePersistenceObject IClientObject.UnderlyingObject
        {
            get { return this; }
        }
        void IClientObject.MakeAccessDeniedProxy()
        {
        }

        #endregion

        public abstract Guid PropertyID { get; }
    }
}