// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    using Kistl.API;
    using Kistl.DalProvider.Base.RelationWrappers;

    using Kistl.API.Server;
    using Kistl.DalProvider.Ef;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="RoleMembership")]
    [System.Diagnostics.DebuggerDisplay("RoleMembership")]
    public class RoleMembershipEfImpl : Kistl.App.Base.AccessControlEfImpl, RoleMembership
    {
        private static readonly Guid _objectClassID = new Guid("3b79d759-2943-4caa-bf6f-5e89955f7f91");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public RoleMembershipEfImpl()
            : base(null)
        {
        }

        public RoleMembershipEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_RoleMembership_resolves_Relations
    A: ZeroOrMore RoleMembership as RoleMembership
    B: ZeroOrMore Relation as Relations
    Preferred Storage: Separate
    */
        // collection reference property
        // Kistl.DalProvider.Ef.Generator.Templates.Properties.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public IList<Kistl.App.Base.Relation> Relations
        {
            get
            {
                if (_Relations == null)
                {
                    _Relations = new BSideListWrapper<Kistl.App.Base.RoleMembership, Kistl.App.Base.Relation, Kistl.App.Base.RoleMembership_resolves_Relation_RelationEntryEfImpl, EntityCollection<Kistl.App.Base.RoleMembership_resolves_Relation_RelationEntryEfImpl>>(
                            this,
                            RelationsImpl);
                }
                return _Relations;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_RoleMembership_resolves_Relations_A", "CollectionEntry")]
        public EntityCollection<Kistl.App.Base.RoleMembership_resolves_Relation_RelationEntryEfImpl> RelationsImpl
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Base.RoleMembership_resolves_Relation_RelationEntryEfImpl>(
                        "Model.FK_RoleMembership_resolves_Relations_A",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                c.ForEach(i => i.AttachToContext(Context));
                return c;
            }
        }
        private BSideListWrapper<Kistl.App.Base.RoleMembership, Kistl.App.Base.Relation, Kistl.App.Base.RoleMembership_resolves_Relation_RelationEntryEfImpl, EntityCollection<Kistl.App.Base.RoleMembership_resolves_Relation_RelationEntryEfImpl>> _Relations;

        public static event PropertyIsValidHandler<Kistl.App.Base.RoleMembership> OnRelations_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(RoleMembership);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (RoleMembership)obj;
            var otherImpl = (RoleMembershipEfImpl)obj;
            var me = (RoleMembership)this;

        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        #region Kistl.Generator.Templates.ObjectClasses.OnPropertyChange


        #endregion // Kistl.Generator.Templates.ObjectClasses.OnPropertyChange

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references
        }
        #region Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        private static readonly object _propertiesLock = new object();
        private static System.ComponentModel.PropertyDescriptor[] _properties;

        private void _InitializePropertyDescriptors(Func<IFrozenContext> lazyCtx)
        {
            if (_properties != null) return;
            lock (_propertiesLock)
            {
                // recheck for a lost race after aquiring the lock
                if (_properties != null) return;

                _properties = new System.ComponentModel.PropertyDescriptor[] {
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorEfImpl<RoleMembership, IList<Kistl.App.Base.Relation>>(
                        lazyCtx,
                        new Guid("fb799900-1a5b-4b62-a445-5dae8febdd28"),
                        "Relations",
                        null,
                        obj => obj.Relations,
                        null, // lists are read-only properties
                        obj => OnRelations_IsValid), 
                    // position columns
                };
            }
        }

        protected override void CollectProperties(Func<IFrozenContext> lazyCtx, List<System.ComponentModel.PropertyDescriptor> props)
        {
            base.CollectProperties(lazyCtx, props);
            _InitializePropertyDescriptors(lazyCtx);
            props.AddRange(_properties);
        }
        #endregion // Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_RoleMembership")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_RoleMembership != null)
            {
                OnToString_RoleMembership(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<RoleMembership> OnToString_RoleMembership;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_RoleMembership")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_RoleMembership != null)
            {
                OnObjectIsValid_RoleMembership(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<RoleMembership> OnObjectIsValid_RoleMembership;

        [EventBasedMethod("OnNotifyPreSave_RoleMembership")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_RoleMembership != null) OnNotifyPreSave_RoleMembership(this);
        }
        public static event ObjectEventHandler<RoleMembership> OnNotifyPreSave_RoleMembership;

        [EventBasedMethod("OnNotifyPostSave_RoleMembership")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_RoleMembership != null) OnNotifyPostSave_RoleMembership(this);
        }
        public static event ObjectEventHandler<RoleMembership> OnNotifyPostSave_RoleMembership;

        [EventBasedMethod("OnNotifyCreated_RoleMembership")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_RoleMembership != null) OnNotifyCreated_RoleMembership(this);
        }
        public static event ObjectEventHandler<RoleMembership> OnNotifyCreated_RoleMembership;

        [EventBasedMethod("OnNotifyDeleting_RoleMembership")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_RoleMembership != null) OnNotifyDeleting_RoleMembership(this);
            Relations.Clear();
        }
        public static event ObjectEventHandler<RoleMembership> OnNotifyDeleting_RoleMembership;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
        }

        #endregion

    }
}