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
    /// Abstract base class for ObjectClass Filter
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="ObjectClassFilterConfiguration")]
    [System.Diagnostics.DebuggerDisplay("ObjectClassFilterConfiguration")]
    public abstract class ObjectClassFilterConfigurationEfImpl : Kistl.App.GUI.FilterConfigurationEfImpl, ObjectClassFilterConfiguration
    {
        [Obsolete]
        public ObjectClassFilterConfigurationEfImpl()
            : base(null)
        {
        }

        public ObjectClassFilterConfigurationEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_ObjectClass_Has_FilterConfigurations
    A: One ObjectClass as ObjectClass
    B: ZeroOrMore ObjectClassFilterConfiguration as FilterConfigurations
    Preferred Storage: MergeIntoB
    */
        // object reference property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ObjectClass
        // fkBackingName=_fk_ObjectClass; fkGuidBackingName=_fk_guid_ObjectClass;
        // referencedInterface=Kistl.App.Base.ObjectClass; moduleNamespace=Kistl.App.GUI;
        // inverse Navigator=FilterConfigurations; is list;
        // PositionStorage=none;
        // Target exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.ObjectClass ObjectClass
        {
            get { return ObjectClassImpl; }
            set { ObjectClassImpl = (Kistl.App.Base.ObjectClassEfImpl)value; }
        }

        private int? _fk_ObjectClass;

        private Guid? _fk_guid_ObjectClass = null;

        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_ObjectClass_Has_FilterConfigurations", "ObjectClass")]
        public Kistl.App.Base.ObjectClassEfImpl ObjectClassImpl
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Base.ObjectClassEfImpl __value;
                EntityReference<Kistl.App.Base.ObjectClassEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClassEfImpl>(
                        "Model.FK_ObjectClass_Has_FilterConfigurations",
                        "ObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                if (r.Value != null) r.Value.AttachToContext(this.Context);
                __value = r.Value;
                if (OnObjectClass_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.ObjectClass>(__value);
                    OnObjectClass_Getter(this, e);
                    __value = (Kistl.App.Base.ObjectClassEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                EntityReference<Kistl.App.Base.ObjectClassEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClassEfImpl>(
                        "Model.FK_ObjectClass_Has_FilterConfigurations",
                        "ObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Kistl.App.Base.ObjectClassEfImpl __oldValue = (Kistl.App.Base.ObjectClassEfImpl)r.Value;
                Kistl.App.Base.ObjectClassEfImpl __newValue = (Kistl.App.Base.ObjectClassEfImpl)value;

                // Changing Event fires before anything is touched
                // navigators may not be notified to entity framework
                NotifyPropertyChanging("ObjectClass", null, __oldValue, __newValue);
                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanging("FilterConfigurations", null, null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanging("FilterConfigurations", null, null, null);
                }

                if (OnObjectClass_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.ObjectClass>(__oldValue, __newValue);
                    OnObjectClass_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.ObjectClassEfImpl)e.Result;
                }

                r.Value = (Kistl.App.Base.ObjectClassEfImpl)__newValue;

                if (OnObjectClass_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.ObjectClass>(__oldValue, __newValue);
                    OnObjectClass_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                // navigators may not be notified to entity framework
                NotifyPropertyChanged("ObjectClass", null, __oldValue, __newValue);
                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanged("FilterConfigurations", null, null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanged("FilterConfigurations", null, null, null);
                }
            }
        }

        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ObjectClass
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
            var otherImpl = (ObjectClassFilterConfigurationEfImpl)obj;
            var me = (ObjectClassFilterConfiguration)this;

            this._fk_ObjectClass = otherImpl._fk_ObjectClass;
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

            if (_fk_guid_ObjectClass.HasValue)
                ObjectClassImpl = (Kistl.App.Base.ObjectClassEfImpl)Context.FindPersistenceObject<Kistl.App.Base.ObjectClass>(_fk_guid_ObjectClass.Value);
            else
            if (_fk_ObjectClass.HasValue)
                ObjectClassImpl = (Kistl.App.Base.ObjectClassEfImpl)Context.Find<Kistl.App.Base.ObjectClass>(_fk_ObjectClass.Value);
            else
                ObjectClassImpl = null;
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
                    new PropertyDescriptorEfImpl<ObjectClassFilterConfigurationEfImpl, Kistl.App.Base.ObjectClass>(
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
        #region Kistl.Generator.Templates.ObjectClasses.DefaultMethods

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

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClassEfImpl>("Model.FK_ObjectClass_Has_FilterConfigurations", "ObjectClass").EntityKey;
                BinarySerializer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, binStream);
            }
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
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClassEfImpl>("Model.FK_ObjectClass_Has_FilterConfigurations", "ObjectClass").EntityKey;
                XmlStreamer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, xml, "ObjectClass", "Kistl.App.GUI");
            }
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(ObjectClass != null ? ObjectClass.ExportGuid : (Guid?)null, xml, "ObjectClass", "Kistl.App.GUI");
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