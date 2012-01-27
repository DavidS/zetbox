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

    using Kistl.API.Utils;
    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.NHibernate;

    /// <summary>
    /// Abstract base class for Property Filter
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("PropertyFilterConfiguration")]
    public abstract class PropertyFilterConfigurationNHibernateImpl : Kistl.App.GUI.FilterConfigurationNHibernateImpl, PropertyFilterConfiguration
    {
        public PropertyFilterConfigurationNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public PropertyFilterConfigurationNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new PropertyFilterConfigurationProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public PropertyFilterConfigurationNHibernateImpl(Func<IFrozenContext> lazyCtx, PropertyFilterConfigurationProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly PropertyFilterConfigurationProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Property
        // fkBackingName=this.Proxy.Property; fkGuidBackingName=_fk_guid_Property;
        // referencedInterface=Kistl.App.Base.Property; moduleNamespace=Kistl.App.GUI;
        // inverse Navigator=FilterConfiguration; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Property Property
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Base.PropertyNHibernateImpl __value = (Kistl.App.Base.PropertyNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Property);

                if (OnProperty_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.Property>(__value);
                    OnProperty_Getter(this, e);
                    __value = (Kistl.App.Base.PropertyNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.Property == null)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = (Kistl.App.Base.PropertyNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Property);
                var __newValue = (Kistl.App.Base.PropertyNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
                    return;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Property", __oldValue, __newValue);

                if (OnProperty_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Property>(__oldValue, __newValue);
                    OnProperty_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.PropertyNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.Property = null;
                }
                else
                {
                    this.Proxy.Property = __newValue.Proxy;
                }

                // now fixup redundant, inverse references
                // The inverse navigator will also fire events when changed, so should
                // only be touched after setting the local value above.
                // TODO: for complete correctness, the "other" Changing event should also fire
                //       before the local value is changed
                if (__oldValue != null)
                {
                    // unset old reference
                    __oldValue.FilterConfiguration = null;
                }

                if (__newValue != null)
                {
                    // set new reference
                    __newValue.FilterConfiguration = this;
                }
                // everything is done. fire the Changed event
                NotifyPropertyChanged("Property", __oldValue, __newValue);

                if (OnProperty_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Property>(__oldValue, __newValue);
                    OnProperty_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for Property's id, used on dehydration only</summary>
        private int? _fk_Property = null;

        /// <summary>Backing store for Property's guid, used on import only</summary>
        private Guid? _fk_guid_Property = null;

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Property
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
            var otherImpl = (PropertyFilterConfigurationNHibernateImpl)obj;
            var me = (PropertyFilterConfiguration)this;

            this._fk_Property = otherImpl._fk_Property;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "Property":
                    {
                        var __oldValue = (Kistl.App.Base.PropertyNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Property);
                        var __newValue = (Kistl.App.Base.PropertyNHibernateImpl)parentObj;
                        NotifyPropertyChanging("Property", __oldValue, __newValue);
                        this.Proxy.Property = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("Property", __oldValue, __newValue);
                    }
                    break;
                default:
                    base.UpdateParent(propertyName, parentObj);
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
                this.Proxy.Property = ((Kistl.App.Base.PropertyNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.Property>(_fk_guid_Property.Value)).Proxy;
            else
            if (_fk_Property.HasValue)
                this.Proxy.Property = ((Kistl.App.Base.PropertyNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.Property>(_fk_Property.Value)).Proxy;
            else
                this.Proxy.Property = null;
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
                    new PropertyDescriptorNHibernateImpl<PropertyFilterConfigurationNHibernateImpl, Kistl.App.Base.Property>(
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
        #region Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

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

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods
        public override List<NHibernatePersistenceObject> GetParentsToDelete()
        {
            var result = base.GetParentsToDelete();

            // Follow Property_Has_PropertyFilterConfiguration
            if (this.Property != null && this.Property.ObjectState == DataObjectState.Deleted)
                result.Add((NHibernatePersistenceObject)this.Property);

            return result;
        }

        public override List<NHibernatePersistenceObject> GetChildrenToDelete()
        {
            var result = base.GetChildrenToDelete();

            return result;
        }


        public class PropertyFilterConfigurationProxy
            : Kistl.App.GUI.FilterConfigurationNHibernateImpl.FilterConfigurationProxy
        {
            public PropertyFilterConfigurationProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(PropertyFilterConfigurationNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(PropertyFilterConfigurationProxy); } }

            public virtual Kistl.App.Base.PropertyNHibernateImpl.PropertyProxy Property { get; set; }

        }

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this.Proxy.Property != null ? OurContext.GetIdFromProxy(this.Proxy.Property) : (int?)null, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._fk_Property, binStream);
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
            XmlStreamer.ToStream(this.Proxy.Property != null ? OurContext.GetIdFromProxy(this.Proxy.Property) : (int?)null, xml, "Property", "Kistl.App.GUI");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._fk_Property, xml, "Property", "Kistl.App.GUI");
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this.Proxy.Property != null ? this.Proxy.Property.ExportGuid : (Guid?)null, xml, "Property", "Kistl.App.GUI");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.FromStream(ref this._fk_guid_Property, xml, "Property", "Kistl.App.GUI");
        }

        #endregion

    }
}