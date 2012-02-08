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
    /// Abstract base class for ObjectClass Filter
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("ObjectClassFilterConfiguration")]
    public abstract class ObjectClassFilterConfigurationNHibernateImpl : Kistl.App.GUI.FilterConfigurationNHibernateImpl, ObjectClassFilterConfiguration
    {
        public ObjectClassFilterConfigurationNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public ObjectClassFilterConfigurationNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new ObjectClassFilterConfigurationProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public ObjectClassFilterConfigurationNHibernateImpl(Func<IFrozenContext> lazyCtx, ObjectClassFilterConfigurationProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly ObjectClassFilterConfigurationProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ObjectClass
        // fkBackingName=this.Proxy.ObjectClass; fkGuidBackingName=_fk_guid_ObjectClass;
        // referencedInterface=Kistl.App.Base.ObjectClass; moduleNamespace=Kistl.App.GUI;
        // inverse Navigator=FilterConfigurations; is list;
        // PositionStorage=none;
        // Target exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.ObjectClass ObjectClass
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Base.ObjectClassNHibernateImpl __value = (Kistl.App.Base.ObjectClassNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.ObjectClass);

                if (OnObjectClass_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.ObjectClass>(__value);
                    OnObjectClass_Getter(this, e);
                    __value = (Kistl.App.Base.ObjectClassNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.ObjectClass == null)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = (Kistl.App.Base.ObjectClassNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.ObjectClass);
                var __newValue = (Kistl.App.Base.ObjectClassNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
                    return;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("ObjectClass", __oldValue, __newValue);

                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanging("FilterConfigurations", null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanging("FilterConfigurations", null, null);
                }

                if (OnObjectClass_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.ObjectClass>(__oldValue, __newValue);
                    OnObjectClass_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.ObjectClassNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.ObjectClass = null;
                }
                else
                {
                    this.Proxy.ObjectClass = __newValue.Proxy;
                }

                // now fixup redundant, inverse references
                // The inverse navigator will also fire events when changed, so should
                // only be touched after setting the local value above.
                // TODO: for complete correctness, the "other" Changing event should also fire
                //       before the local value is changed
                if (__oldValue != null)
                {
                    // remove from old list
                    (__oldValue.FilterConfigurations as IRelationListSync<Kistl.App.GUI.ObjectClassFilterConfiguration>).RemoveWithoutClearParent(this);
                }

                if (__newValue != null)
                {
                    // add to new list
                    (__newValue.FilterConfigurations as IRelationListSync<Kistl.App.GUI.ObjectClassFilterConfiguration>).AddWithoutSetParent(this);
                }
                // everything is done. fire the Changed event
                NotifyPropertyChanged("ObjectClass", __oldValue, __newValue);

                if (OnObjectClass_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.ObjectClass>(__oldValue, __newValue);
                    OnObjectClass_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for ObjectClass's id, used on dehydration only</summary>
        private int? _fk_ObjectClass = null;

        /// <summary>Backing store for ObjectClass's guid, used on import only</summary>
        private Guid? _fk_guid_ObjectClass = null;

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ObjectClass
		public static event PropertyGetterHandler<Kistl.App.GUI.ObjectClassFilterConfiguration, Kistl.App.Base.ObjectClass> OnObjectClass_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.ObjectClassFilterConfiguration, Kistl.App.Base.ObjectClass> OnObjectClass_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.ObjectClassFilterConfiguration, Kistl.App.Base.ObjectClass> OnObjectClass_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnCreateFilterModel_ObjectClassFilterConfiguration")]
        public override Kistl.API.IFilterModel CreateFilterModel()
        {
            var e = new MethodReturnEventArgs<Kistl.API.IFilterModel>();
            if (OnCreateFilterModel_ObjectClassFilterConfiguration != null)
            {
                OnCreateFilterModel_ObjectClassFilterConfiguration(this, e);
            }
            else
            {
                e.Result = base.CreateFilterModel();
            }
            return e.Result;
        }
        public static event CreateFilterModel_Handler<ObjectClassFilterConfiguration> OnCreateFilterModel_ObjectClassFilterConfiguration;
		// CanExec
		public static event CanExecMethodEventHandler<ObjectClassFilterConfiguration> OnCreateFilterModel_ObjectClassFilterConfiguration_CanExec;

        [EventBasedMethod("OnCreateFilterModel_ObjectClassFilterConfiguration_CanExec")]
        public override bool CreateFilterModelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnCreateFilterModel_ObjectClassFilterConfiguration_CanExec != null)
				{
					OnCreateFilterModel_ObjectClassFilterConfiguration_CanExec(this, e);
				}
				else
				{
					e.Result = base.CreateFilterModelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ObjectClassFilterConfiguration> OnCreateFilterModel_ObjectClassFilterConfiguration_CanExecReason;

        [EventBasedMethod("OnCreateFilterModel_ObjectClassFilterConfiguration_CanExecReason")]
        public override string CreateFilterModelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnCreateFilterModel_ObjectClassFilterConfiguration_CanExecReason != null)
				{
					OnCreateFilterModel_ObjectClassFilterConfiguration_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.CreateFilterModelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_ObjectClassFilterConfiguration")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_ObjectClassFilterConfiguration != null)
            {
                OnGetLabel_ObjectClassFilterConfiguration(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<ObjectClassFilterConfiguration> OnGetLabel_ObjectClassFilterConfiguration;
		// CanExec
		public static event CanExecMethodEventHandler<ObjectClassFilterConfiguration> OnGetLabel_ObjectClassFilterConfiguration_CanExec;

        [EventBasedMethod("OnGetLabel_ObjectClassFilterConfiguration_CanExec")]
        public override bool GetLabelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabel_ObjectClassFilterConfiguration_CanExec != null)
				{
					OnGetLabel_ObjectClassFilterConfiguration_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ObjectClassFilterConfiguration> OnGetLabel_ObjectClassFilterConfiguration_CanExecReason;

        [EventBasedMethod("OnGetLabel_ObjectClassFilterConfiguration_CanExecReason")]
        public override string GetLabelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabel_ObjectClassFilterConfiguration_CanExecReason != null)
				{
					OnGetLabel_ObjectClassFilterConfiguration_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(ObjectClassFilterConfiguration);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (ObjectClassFilterConfiguration)obj;
            var otherImpl = (ObjectClassFilterConfigurationNHibernateImpl)obj;
            var me = (ObjectClassFilterConfiguration)this;

            this._fk_ObjectClass = otherImpl._fk_ObjectClass;
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
                case "ObjectClass":
                    {
                        var __oldValue = (Kistl.App.Base.ObjectClassNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.ObjectClass);
                        var __newValue = (Kistl.App.Base.ObjectClassNHibernateImpl)parentObj;
                        NotifyPropertyChanging("ObjectClass", __oldValue, __newValue);
                        this.Proxy.ObjectClass = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("ObjectClass", __oldValue, __newValue);
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

            if (_fk_guid_ObjectClass.HasValue)
                this.Proxy.ObjectClass = ((Kistl.App.Base.ObjectClassNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.ObjectClass>(_fk_guid_ObjectClass.Value)).Proxy;
            else
            if (_fk_ObjectClass.HasValue)
                this.Proxy.ObjectClass = ((Kistl.App.Base.ObjectClassNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.ObjectClass>(_fk_ObjectClass.Value)).Proxy;
            else
                this.Proxy.ObjectClass = null;
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
                    new PropertyDescriptorNHibernateImpl<ObjectClassFilterConfigurationNHibernateImpl, Kistl.App.Base.ObjectClass>(
                        lazyCtx,
                        new Guid("c7da5741-f172-4e04-b7fa-94bb1eaf2471"),
                        "ObjectClass",
                        null,
                        obj => obj.ObjectClass,
                        (obj, val) => obj.ObjectClass = val),
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
        [EventBasedMethod("OnToString_ObjectClassFilterConfiguration")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ObjectClassFilterConfiguration != null)
            {
                OnToString_ObjectClassFilterConfiguration(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<ObjectClassFilterConfiguration> OnToString_ObjectClassFilterConfiguration;

        [EventBasedMethod("OnPreSave_ObjectClassFilterConfiguration")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ObjectClassFilterConfiguration != null) OnPreSave_ObjectClassFilterConfiguration(this);
        }
        public static event ObjectEventHandler<ObjectClassFilterConfiguration> OnPreSave_ObjectClassFilterConfiguration;

        [EventBasedMethod("OnPostSave_ObjectClassFilterConfiguration")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ObjectClassFilterConfiguration != null) OnPostSave_ObjectClassFilterConfiguration(this);
        }
        public static event ObjectEventHandler<ObjectClassFilterConfiguration> OnPostSave_ObjectClassFilterConfiguration;

        [EventBasedMethod("OnCreated_ObjectClassFilterConfiguration")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_ObjectClassFilterConfiguration != null) OnCreated_ObjectClassFilterConfiguration(this);
        }
        public static event ObjectEventHandler<ObjectClassFilterConfiguration> OnCreated_ObjectClassFilterConfiguration;

        [EventBasedMethod("OnDeleting_ObjectClassFilterConfiguration")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_ObjectClassFilterConfiguration != null) OnDeleting_ObjectClassFilterConfiguration(this);
        }
        public static event ObjectEventHandler<ObjectClassFilterConfiguration> OnDeleting_ObjectClassFilterConfiguration;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods
        public override List<NHibernatePersistenceObject> GetParentsToDelete()
        {
            var result = base.GetParentsToDelete();

            // Follow ObjectClass_Has_FilterConfigurations
            if (this.ObjectClass != null && this.ObjectClass.ObjectState == DataObjectState.Deleted)
                result.Add((NHibernatePersistenceObject)this.ObjectClass);

            return result;
        }

        public override List<NHibernatePersistenceObject> GetChildrenToDelete()
        {
            var result = base.GetChildrenToDelete();

            return result;
        }


        public class ObjectClassFilterConfigurationProxy
            : Kistl.App.GUI.FilterConfigurationNHibernateImpl.FilterConfigurationProxy
        {
            public ObjectClassFilterConfigurationProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(ObjectClassFilterConfigurationNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(ObjectClassFilterConfigurationProxy); } }

            public virtual Kistl.App.Base.ObjectClassNHibernateImpl.ObjectClassProxy ObjectClass { get; set; }

        }

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this.Proxy.ObjectClass != null ? OurContext.GetIdFromProxy(this.Proxy.ObjectClass) : (int?)null, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._fk_ObjectClass, binStream);
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
            XmlStreamer.ToStream(this.Proxy.ObjectClass != null ? OurContext.GetIdFromProxy(this.Proxy.ObjectClass) : (int?)null, xml, "ObjectClass", "Kistl.App.GUI");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._fk_ObjectClass, xml, "ObjectClass", "Kistl.App.GUI");
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this.Proxy.ObjectClass != null ? this.Proxy.ObjectClass.ExportGuid : (Guid?)null, xml, "ObjectClass", "Kistl.App.GUI");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.FromStream(ref this._fk_guid_ObjectClass, xml, "ObjectClass", "Kistl.App.GUI");
        }

        #endregion

    }
}