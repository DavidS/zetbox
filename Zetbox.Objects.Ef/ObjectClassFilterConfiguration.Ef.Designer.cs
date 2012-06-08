// <autogenerated/>

namespace Zetbox.App.GUI
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    using Zetbox.API;
    using Zetbox.DalProvider.Base.RelationWrappers;

    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Zetbox.API.Server;
    using Zetbox.DalProvider.Ef;

    /// <summary>
    /// Abstract base class for ObjectClass Filter
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="ObjectClassFilterConfiguration")]
    [System.Diagnostics.DebuggerDisplay("ObjectClassFilterConfiguration")]
    public abstract class ObjectClassFilterConfigurationEfImpl : Zetbox.App.GUI.FilterConfigurationEfImpl, ObjectClassFilterConfiguration
    {
        private static readonly Guid _objectClassID = new Guid("ed9c2055-9ebb-4be1-9adf-36e0391a982e");
        public override Guid ObjectClassID { get { return _objectClassID; } }

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
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ObjectClass
        // fkBackingName=_fk_ObjectClass; fkGuidBackingName=_fk_guid_ObjectClass;
        // referencedInterface=Zetbox.App.Base.ObjectClass; moduleNamespace=Zetbox.App.GUI;
        // inverse Navigator=FilterConfigurations; is list;
        // PositionStorage=none;
        // Target exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Base.ObjectClass ObjectClass
        {
            get { return ObjectClassImpl; }
            set { ObjectClassImpl = (Zetbox.App.Base.ObjectClassEfImpl)value; }
        }

        private int? _fk_ObjectClass;

        private Guid? _fk_guid_ObjectClass = null;

        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_ObjectClass_Has_FilterConfigurations", "ObjectClass")]
        public Zetbox.App.Base.ObjectClassEfImpl ObjectClassImpl
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Zetbox.App.Base.ObjectClassEfImpl __value;
                EntityReference<Zetbox.App.Base.ObjectClassEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.Base.ObjectClassEfImpl>(
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
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.ObjectClass>(__value);
                    OnObjectClass_Getter(this, e);
                    __value = (Zetbox.App.Base.ObjectClassEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                EntityReference<Zetbox.App.Base.ObjectClassEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.Base.ObjectClassEfImpl>(
                        "Model.FK_ObjectClass_Has_FilterConfigurations",
                        "ObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Zetbox.App.Base.ObjectClassEfImpl __oldValue = (Zetbox.App.Base.ObjectClassEfImpl)r.Value;
                Zetbox.App.Base.ObjectClassEfImpl __newValue = (Zetbox.App.Base.ObjectClassEfImpl)value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("ObjectClass", __oldValue, __newValue);
                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanging("FilterConfigurations", null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanging("FilterConfigurations", null, null);
                }

                if (OnObjectClass_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.ObjectClass>(__oldValue, __newValue);
                    OnObjectClass_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.ObjectClassEfImpl)e.Result;
                }

                r.Value = (Zetbox.App.Base.ObjectClassEfImpl)__newValue;

                if (OnObjectClass_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.ObjectClass>(__oldValue, __newValue);
                    OnObjectClass_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("ObjectClass", __oldValue, __newValue);
                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanged("FilterConfigurations", null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanged("FilterConfigurations", null, null);
                }
            }
        }

        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ObjectClass
		public static event PropertyGetterHandler<Zetbox.App.GUI.ObjectClassFilterConfiguration, Zetbox.App.Base.ObjectClass> OnObjectClass_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.ObjectClassFilterConfiguration, Zetbox.App.Base.ObjectClass> OnObjectClass_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.ObjectClassFilterConfiguration, Zetbox.App.Base.ObjectClass> OnObjectClass_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.ObjectClassFilterConfiguration> OnObjectClass_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnCreateFilterModel_ObjectClassFilterConfiguration")]
        public override Zetbox.API.IFilterModel CreateFilterModel()
        {
            var e = new MethodReturnEventArgs<Zetbox.API.IFilterModel>();
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
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
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
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
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
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
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
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

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

        public override void AttachToContext(IZetboxContext ctx)
        {
            base.AttachToContext(ctx);
        }
        public override void SetNew()
        {
            base.SetNew();
        }
        #region Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "ObjectClass":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }
        #endregion // Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_guid_ObjectClass.HasValue)
                ObjectClassImpl = (Zetbox.App.Base.ObjectClassEfImpl)Context.FindPersistenceObject<Zetbox.App.Base.ObjectClass>(_fk_guid_ObjectClass.Value);
            else
            if (_fk_ObjectClass.HasValue)
                ObjectClassImpl = (Zetbox.App.Base.ObjectClassEfImpl)Context.Find<Zetbox.App.Base.ObjectClass>(_fk_ObjectClass.Value);
            else
                ObjectClassImpl = null;
        }
        #region Zetbox.Generator.Templates.ObjectClasses.CustomTypeDescriptor
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
                    new PropertyDescriptorEfImpl<ObjectClassFilterConfiguration, Zetbox.App.Base.ObjectClass>(
                        lazyCtx,
                        new Guid("c7da5741-f172-4e04-b7fa-94bb1eaf2471"),
                        "ObjectClass",
                        null,
                        obj => obj.ObjectClass,
                        (obj, val) => obj.ObjectClass = val,
						obj => OnObjectClass_IsValid), 
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
        #endregion // Zetbox.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

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

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_ObjectClassFilterConfiguration")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_ObjectClassFilterConfiguration != null)
            {
                OnObjectIsValid_ObjectClassFilterConfiguration(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<ObjectClassFilterConfiguration> OnObjectIsValid_ObjectClassFilterConfiguration;

        [EventBasedMethod("OnNotifyPreSave_ObjectClassFilterConfiguration")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_ObjectClassFilterConfiguration != null) OnNotifyPreSave_ObjectClassFilterConfiguration(this);
        }
        public static event ObjectEventHandler<ObjectClassFilterConfiguration> OnNotifyPreSave_ObjectClassFilterConfiguration;

        [EventBasedMethod("OnNotifyPostSave_ObjectClassFilterConfiguration")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_ObjectClassFilterConfiguration != null) OnNotifyPostSave_ObjectClassFilterConfiguration(this);
        }
        public static event ObjectEventHandler<ObjectClassFilterConfiguration> OnNotifyPostSave_ObjectClassFilterConfiguration;

        [EventBasedMethod("OnNotifyCreated_ObjectClassFilterConfiguration")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("ObjectClass");
            base.NotifyCreated();
            if (OnNotifyCreated_ObjectClassFilterConfiguration != null) OnNotifyCreated_ObjectClassFilterConfiguration(this);
        }
        public static event ObjectEventHandler<ObjectClassFilterConfiguration> OnNotifyCreated_ObjectClassFilterConfiguration;

        [EventBasedMethod("OnNotifyDeleting_ObjectClassFilterConfiguration")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_ObjectClassFilterConfiguration != null) OnNotifyDeleting_ObjectClassFilterConfiguration(this);
        }
        public static event ObjectEventHandler<ObjectClassFilterConfiguration> OnNotifyDeleting_ObjectClassFilterConfiguration;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            {
                var key = this.RelationshipManager.GetRelatedReference<Zetbox.App.Base.ObjectClassEfImpl>("Model.FK_ObjectClass_Has_FilterConfigurations", "ObjectClass").EntityKey;
                binStream.Write(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null);
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            binStream.Read(out this._fk_ObjectClass);
            } // if (CurrentAccessRights != Zetbox.API.AccessRights.None)
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
            if (modules.Contains("*") || modules.Contains("Zetbox.App.GUI")) XmlStreamer.ToStream(ObjectClass != null ? ObjectClass.ExportGuid : (Guid?)null, xml, "ObjectClass", "Zetbox.App.GUI");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.GUI|ObjectClass":
                this._fk_guid_ObjectClass = XmlStreamer.ReadNullableGuid(xml);
                break;
            }
        }

        #endregion

    }
}