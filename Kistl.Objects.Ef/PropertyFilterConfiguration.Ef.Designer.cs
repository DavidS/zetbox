// <autogenerated/>

namespace Kistl.App.GUI
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
    /// Abstract base class for Property Filter
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="PropertyFilterConfiguration")]
    [System.Diagnostics.DebuggerDisplay("PropertyFilterConfiguration")]
    public abstract class PropertyFilterConfigurationEfImpl : Kistl.App.GUI.FilterConfigurationEfImpl, PropertyFilterConfiguration
    {
        [Obsolete]
        public PropertyFilterConfigurationEfImpl()
            : base(null)
        {
        }

        public PropertyFilterConfigurationEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Property_Has_PropertyFilterConfiguration
    A: One Property as Property
    B: ZeroOrOne PropertyFilterConfiguration as PropertyFilterConfiguration
    Preferred Storage: MergeIntoB
    */
        // object reference property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Property
        // fkBackingName=_fk_Property; fkGuidBackingName=_fk_guid_Property;
        // referencedInterface=Kistl.App.Base.Property; moduleNamespace=Kistl.App.GUI;
        // inverse Navigator=FilterConfiguration; is reference;
        // PositionStorage=none;
        // Target exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Property Property
        {
            get { return PropertyImpl; }
            set { PropertyImpl = (Kistl.App.Base.PropertyEfImpl)value; }
        }

        private int? _fk_Property;

        private Guid? _fk_guid_Property = null;

        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Property_Has_PropertyFilterConfiguration", "Property")]
        public Kistl.App.Base.PropertyEfImpl PropertyImpl
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return null;
                Kistl.App.Base.PropertyEfImpl __value;
                EntityReference<Kistl.App.Base.PropertyEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.PropertyEfImpl>(
                        "Model.FK_Property_Has_PropertyFilterConfiguration",
                        "Property");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                if (r.Value != null) r.Value.AttachToContext(this.Context);
                __value = r.Value;
                if (OnProperty_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.Property>(__value);
                    OnProperty_Getter(this, e);
                    __value = (Kistl.App.Base.PropertyEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                EntityReference<Kistl.App.Base.PropertyEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.PropertyEfImpl>(
                        "Model.FK_Property_Has_PropertyFilterConfiguration",
                        "Property");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Kistl.App.Base.PropertyEfImpl __oldValue = (Kistl.App.Base.PropertyEfImpl)r.Value;
                Kistl.App.Base.PropertyEfImpl __newValue = (Kistl.App.Base.PropertyEfImpl)value;

                // Changing Event fires before anything is touched
                // navigators may not be notified to entity framework
                NotifyPropertyChanging("Property", null, __oldValue, __newValue);
                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanging("FilterConfiguration", null, null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanging("FilterConfiguration", null, null, null);
                }

                if (OnProperty_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Property>(__oldValue, __newValue);
                    OnProperty_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.PropertyEfImpl)e.Result;
                }

                r.Value = (Kistl.App.Base.PropertyEfImpl)__newValue;

                if (OnProperty_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Property>(__oldValue, __newValue);
                    OnProperty_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                // navigators may not be notified to entity framework
                NotifyPropertyChanged("Property", null, __oldValue, __newValue);
                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanged("FilterConfiguration", null, null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanged("FilterConfiguration", null, null, null);
                }
            }
        }

        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Property
		public static event PropertyGetterHandler<Kistl.App.GUI.PropertyFilterConfiguration, Kistl.App.Base.Property> OnProperty_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.PropertyFilterConfiguration, Kistl.App.Base.Property> OnProperty_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.PropertyFilterConfiguration, Kistl.App.Base.Property> OnProperty_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnCreateFilterModel_PropertyFilterConfiguration")]
        public override Kistl.API.IFilterModel CreateFilterModel()
        {
            var e = new MethodReturnEventArgs<Kistl.API.IFilterModel>();
            if (OnCreateFilterModel_PropertyFilterConfiguration != null)
            {
                OnCreateFilterModel_PropertyFilterConfiguration(this, e);
            }
            else
            {
                e.Result = base.CreateFilterModel();
            }
            return e.Result;
        }
        public static event CreateFilterModel_Handler<PropertyFilterConfiguration> OnCreateFilterModel_PropertyFilterConfiguration;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_PropertyFilterConfiguration")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_PropertyFilterConfiguration != null)
            {
                OnGetLabel_PropertyFilterConfiguration(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<PropertyFilterConfiguration> OnGetLabel_PropertyFilterConfiguration;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(PropertyFilterConfiguration);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (PropertyFilterConfiguration)obj;
            var otherImpl = (PropertyFilterConfigurationEfImpl)obj;
            var me = (PropertyFilterConfiguration)this;

            this._fk_Property = otherImpl._fk_Property;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }

		public override void UpdateParent(string propertyName, int? id)
		{
			int? __oldValue, __newValue = id;
			
			switch(propertyName)
			{
                case "Property":
                    __oldValue = _fk_Property;
                    NotifyPropertyChanging("Property", __oldValue, __newValue);
                    _fk_Property = __newValue;
                    NotifyPropertyChanged("Property", __oldValue, __newValue);
                    break;
				default:
					base.UpdateParent(propertyName, id);
					break;
			}
		}

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_guid_Property.HasValue)
                PropertyImpl = (Kistl.App.Base.PropertyEfImpl)Context.FindPersistenceObject<Kistl.App.Base.Property>(_fk_guid_Property.Value);
            else
            if (_fk_Property.HasValue)
                PropertyImpl = (Kistl.App.Base.PropertyEfImpl)Context.Find<Kistl.App.Base.Property>(_fk_Property.Value);
            else
                PropertyImpl = null;
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
                    new PropertyDescriptorEfImpl<PropertyFilterConfigurationEfImpl, Kistl.App.Base.Property>(
                        lazyCtx,
                        new Guid("384208e7-eb27-41f1-ac12-b05822c0a2ad"),
                        "Property",
                        null,
                        obj => obj.Property,
                        (obj, val) => obj.Property = val),
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
        [EventBasedMethod("OnToString_PropertyFilterConfiguration")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_PropertyFilterConfiguration != null)
            {
                OnToString_PropertyFilterConfiguration(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<PropertyFilterConfiguration> OnToString_PropertyFilterConfiguration;

        [EventBasedMethod("OnPreSave_PropertyFilterConfiguration")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_PropertyFilterConfiguration != null) OnPreSave_PropertyFilterConfiguration(this);
        }
        public static event ObjectEventHandler<PropertyFilterConfiguration> OnPreSave_PropertyFilterConfiguration;

        [EventBasedMethod("OnPostSave_PropertyFilterConfiguration")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_PropertyFilterConfiguration != null) OnPostSave_PropertyFilterConfiguration(this);
        }
        public static event ObjectEventHandler<PropertyFilterConfiguration> OnPostSave_PropertyFilterConfiguration;

        [EventBasedMethod("OnCreated_PropertyFilterConfiguration")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_PropertyFilterConfiguration != null) OnCreated_PropertyFilterConfiguration(this);
        }
        public static event ObjectEventHandler<PropertyFilterConfiguration> OnCreated_PropertyFilterConfiguration;

        [EventBasedMethod("OnDeleting_PropertyFilterConfiguration")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_PropertyFilterConfiguration != null) OnDeleting_PropertyFilterConfiguration(this);
        }
        public static event ObjectEventHandler<PropertyFilterConfiguration> OnDeleting_PropertyFilterConfiguration;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.Base.PropertyEfImpl>("Model.FK_Property_Has_PropertyFilterConfiguration", "Property").EntityKey;
                BinarySerializer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, binStream);
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            BinarySerializer.FromStream(out this._fk_Property, binStream);
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.Base.PropertyEfImpl>("Model.FK_Property_Has_PropertyFilterConfiguration", "Property").EntityKey;
                XmlStreamer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, xml, "Property", "Kistl.App.GUI");
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            XmlStreamer.FromStream(ref this._fk_Property, xml, "Property", "Kistl.App.GUI");
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(Property != null ? Property.ExportGuid : (Guid?)null, xml, "Property", "Kistl.App.GUI");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            XmlStreamer.FromStream(ref this._fk_guid_Property, xml, "Property", "Kistl.App.GUI");
        }

        #endregion

    }
}