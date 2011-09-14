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
    [EdmEntityType(NamespaceName="Model", Name="IndexConstraint")]
    [System.Diagnostics.DebuggerDisplay("IndexConstraint")]
    public class IndexConstraintEfImpl : Kistl.App.Base.InstanceConstraintEfImpl, IndexConstraint
    {
        [Obsolete]
        public IndexConstraintEfImpl()
            : base(null)
        {
        }

        public IndexConstraintEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// Index is created as a Unique Index
        /// </summary>
        // value type property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public bool IsUnique
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(bool);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _IsUnique;
                if (!_isIsUniqueSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("2cc6e028-e01f-4879-bda8-78d459c0eaf4"));
                    if (__p != null) {
                        _isIsUniqueSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._IsUnique = (bool)__tmp_value;
                    } else {
                        Kistl.API.Utils.Logging.Log.Warn("Unable to get default value for property 'IndexConstraint.IsUnique'");
                    }
                }
                if (OnIsUnique_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnIsUnique_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isIsUniqueSet = true;
                if (_IsUnique != value)
                {
                    var __oldValue = _IsUnique;
                    var __newValue = value;
                    if (OnIsUnique_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsUnique_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IsUnique", __oldValue, __newValue);
                    _IsUnique = __newValue;
                    NotifyPropertyChanged("IsUnique", __oldValue, __newValue);
                    if (OnIsUnique_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsUnique_PostSetter(this, __e);
                    }
                }
            }
        }
        private bool _IsUnique;
        private bool _isIsUniqueSet = false;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.IndexConstraint, bool> OnIsUnique_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.IndexConstraint, bool> OnIsUnique_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.IndexConstraint, bool> OnIsUnique_PostSetter;

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_UniqueContraints_ensures_unique_on_Properties
    A: ZeroOrMore IndexConstraint as UniqueContraints
    B: ZeroOrMore Property as Properties
    Preferred Storage: Separate
    */
        // collection reference property
        // Kistl.DalProvider.Ef.Generator.Templates.Properties.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Base.Property> Properties
        {
            get
            {
                if (_Properties == null)
                {
                    _Properties = new BSideCollectionWrapper<Kistl.App.Base.IndexConstraint, Kistl.App.Base.Property, Kistl.App.Base.IndexConstraint_ensures_unique_on_Property_RelationEntryEfImpl, EntityCollection<Kistl.App.Base.IndexConstraint_ensures_unique_on_Property_RelationEntryEfImpl>>(
                            this,
                            PropertiesImpl);
                }
                return _Properties;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_UniqueContraints_ensures_unique_on_Properties_A", "CollectionEntry")]
        public EntityCollection<Kistl.App.Base.IndexConstraint_ensures_unique_on_Property_RelationEntryEfImpl> PropertiesImpl
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Base.IndexConstraint_ensures_unique_on_Property_RelationEntryEfImpl>(
                        "Model.FK_UniqueContraints_ensures_unique_on_Properties_A",
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
        private BSideCollectionWrapper<Kistl.App.Base.IndexConstraint, Kistl.App.Base.Property, Kistl.App.Base.IndexConstraint_ensures_unique_on_Property_RelationEntryEfImpl, EntityCollection<Kistl.App.Base.IndexConstraint_ensures_unique_on_Property_RelationEntryEfImpl>> _Properties;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetErrorText_IndexConstraint")]
        public override string GetErrorText(Kistl.API.IDataObject constrainedObject)
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetErrorText_IndexConstraint != null)
            {
                OnGetErrorText_IndexConstraint(this, e, constrainedObject);
            }
            else
            {
                e.Result = base.GetErrorText(constrainedObject);
            }
            return e.Result;
        }
        public static event GetErrorText_Handler<IndexConstraint> OnGetErrorText_IndexConstraint;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnIsValid_IndexConstraint")]
        public override bool IsValid(Kistl.API.IDataObject constrainedObject)
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnIsValid_IndexConstraint != null)
            {
                OnIsValid_IndexConstraint(this, e, constrainedObject);
            }
            else
            {
                e.Result = base.IsValid(constrainedObject);
            }
            return e.Result;
        }
        public static event IsValid_Handler<IndexConstraint> OnIsValid_IndexConstraint;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(IndexConstraint);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (IndexConstraint)obj;
            var otherImpl = (IndexConstraintEfImpl)obj;
            var me = (IndexConstraint)this;

            me.IsUnique = other.IsUnique;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }


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
                    // else
                    new PropertyDescriptorEfImpl<IndexConstraintEfImpl, bool>(
                        lazyCtx,
                        new Guid("2cc6e028-e01f-4879-bda8-78d459c0eaf4"),
                        "IsUnique",
                        null,
                        obj => obj.IsUnique,
                        (obj, val) => obj.IsUnique = val),
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorEfImpl<IndexConstraintEfImpl, ICollection<Kistl.App.Base.Property>>(
                        lazyCtx,
                        new Guid("3e4bfd37-1037-472b-a5d7-2c20a777e6fd"),
                        "Properties",
                        null,
                        obj => obj.Properties,
                        null), // lists are read-only properties
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
        [EventBasedMethod("OnToString_IndexConstraint")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_IndexConstraint != null)
            {
                OnToString_IndexConstraint(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<IndexConstraint> OnToString_IndexConstraint;

        [EventBasedMethod("OnPreSave_IndexConstraint")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_IndexConstraint != null) OnPreSave_IndexConstraint(this);
        }
        public static event ObjectEventHandler<IndexConstraint> OnPreSave_IndexConstraint;

        [EventBasedMethod("OnPostSave_IndexConstraint")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_IndexConstraint != null) OnPostSave_IndexConstraint(this);
        }
        public static event ObjectEventHandler<IndexConstraint> OnPostSave_IndexConstraint;

        [EventBasedMethod("OnCreated_IndexConstraint")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_IndexConstraint != null) OnCreated_IndexConstraint(this);
        }
        public static event ObjectEventHandler<IndexConstraint> OnCreated_IndexConstraint;

        [EventBasedMethod("OnDeleting_IndexConstraint")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_IndexConstraint != null) OnDeleting_IndexConstraint(this);
        }
        public static event ObjectEventHandler<IndexConstraint> OnDeleting_IndexConstraint;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this._isIsUniqueSet, binStream);
            if (this._isIsUniqueSet) {
                BinarySerializer.ToStream(this._IsUnique, binStream);
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._isIsUniqueSet, binStream);
            if (this._isIsUniqueSet) {
                BinarySerializer.FromStream(out this._IsUnique, binStream);
            }
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
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.ToStream(this._isIsUniqueSet, xml, "IsIsUniqueSet", "Kistl.App.Base");
            if (this._isIsUniqueSet) {
                XmlStreamer.ToStream(this._IsUnique, xml, "IsUnique", "Kistl.App.Base");
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._isIsUniqueSet, xml, "IsIsUniqueSet", "Kistl.App.Base");
            if (this._isIsUniqueSet) {
                XmlStreamer.FromStream(ref this._IsUnique, xml, "IsUnique", "Kistl.App.Base");
            }
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
            if (!CurrentAccessRights.HasReadRights()) return;
            System.Diagnostics.Debug.Assert(this._isIsUniqueSet, "Exported objects need to have all default values evaluated");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._IsUnique, xml, "IsUnique", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            if (!CurrentAccessRights.HasReadRights()) return;
            // Import must have default value set
            XmlStreamer.FromStream(ref this._IsUnique, xml, "IsUnique", "Kistl.App.Base");
            this._isIsUniqueSet = true;
        }

        #endregion

    }
}