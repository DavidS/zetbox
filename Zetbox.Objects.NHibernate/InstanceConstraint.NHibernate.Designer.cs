// <autogenerated/>

namespace Zetbox.App.Base
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

    using Zetbox.API.Utils;
    using Zetbox.DalProvider.Base;
    using Zetbox.DalProvider.NHibernate;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("InstanceConstraint")]
    public class InstanceConstraintNHibernateImpl : Zetbox.DalProvider.NHibernate.DataObjectNHibernateImpl, InstanceConstraint, Zetbox.API.IExportableInternal
    {
        private static readonly Guid _objectClassID = new Guid("25a83f49-3cff-4baf-850d-8d185bb329ec");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public InstanceConstraintNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public InstanceConstraintNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new InstanceConstraintProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public InstanceConstraintNHibernateImpl(Func<IFrozenContext> lazyCtx, InstanceConstraintProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
            _isExportGuidSet = Proxy.ID > 0;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly InstanceConstraintProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Constrained
        // fkBackingName=this.Proxy.Constrained; fkGuidBackingName=_fk_guid_Constrained;
        // referencedInterface=Zetbox.App.Base.DataType; moduleNamespace=Zetbox.App.Base;
        // inverse Navigator=Constraints; is list;
        // PositionStorage=none;
        // Target exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Base.DataType Constrained
        {
            get
            {
                Zetbox.App.Base.DataTypeNHibernateImpl __value = (Zetbox.App.Base.DataTypeNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Constrained);

                if (OnConstrained_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.DataType>(__value);
                    OnConstrained_Getter(this, e);
                    __value = (Zetbox.App.Base.DataTypeNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.Constrained == null)
				{
					SetInitializedProperty("Constrained");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = (Zetbox.App.Base.DataTypeNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Constrained);
                var __newValue = (Zetbox.App.Base.DataTypeNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
				{
					SetInitializedProperty("Constrained");
                    return;
				}

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Constrained", __oldValue, __newValue);

                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanging("Constraints", null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanging("Constraints", null, null);
                }

                if (OnConstrained_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.DataType>(__oldValue, __newValue);
                    OnConstrained_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.DataTypeNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.Constrained = null;
                }
                else
                {
                    this.Proxy.Constrained = __newValue.Proxy;
                }

                // now fixup redundant, inverse references
                // The inverse navigator will also fire events when changed, so should
                // only be touched after setting the local value above.
                // TODO: for complete correctness, the "other" Changing event should also fire
                //       before the local value is changed
                if (__oldValue != null)
                {
                    // remove from old list
                    (__oldValue.Constraints as IRelationListSync<Zetbox.App.Base.InstanceConstraint>).RemoveWithoutClearParent(this);
                }

                if (__newValue != null)
                {
                    // add to new list
                    (__newValue.Constraints as IRelationListSync<Zetbox.App.Base.InstanceConstraint>).AddWithoutSetParent(this);
                }
                // everything is done. fire the Changed event
                NotifyPropertyChanged("Constrained", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;

                if (OnConstrained_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.DataType>(__oldValue, __newValue);
                    OnConstrained_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for Constrained's id, used on dehydration only</summary>
        private int? _fk_Constrained = null;

        /// <summary>Backing store for Constrained's guid, used on import only</summary>
        private Guid? _fk_guid_Constrained = null;

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Constrained
		public static event PropertyGetterHandler<Zetbox.App.Base.InstanceConstraint, Zetbox.App.Base.DataType> OnConstrained_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.InstanceConstraint, Zetbox.App.Base.DataType> OnConstrained_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.InstanceConstraint, Zetbox.App.Base.DataType> OnConstrained_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.InstanceConstraint> OnConstrained_IsValid;

        /// <summary>
        /// Export Guid
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public Guid ExportGuid
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = FetchExportGuidOrDefault();
                if (OnExportGuid_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<Guid>(__result);
                    OnExportGuid_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isExportGuidSet = true;
                if (Proxy.ExportGuid != value)
                {
                    var __oldValue = Proxy.ExportGuid;
                    var __newValue = value;
                    if (OnExportGuid_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ExportGuid", __oldValue, __newValue);
                    Proxy.ExportGuid = __newValue;
                    NotifyPropertyChanged("ExportGuid", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnExportGuid_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("ExportGuid");
				}
            }
        }


        private Guid FetchExportGuidOrDefault()
        {
            var __result = Proxy.ExportGuid;
                if (!_isExportGuidSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("8ef28076-900c-4294-920c-5d0d91e925bb"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this.Proxy.ExportGuid = (Guid)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'Zetbox.App.Base.InstanceConstraint.ExportGuid'");
                    }
                }
            return __result;
        }

        private bool _isExportGuidSet = false;
        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.InstanceConstraint, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.InstanceConstraint, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.InstanceConstraint, Guid> OnExportGuid_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.InstanceConstraint> OnExportGuid_IsValid;

        /// <summary>
        /// The reason of this constraint
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string Reason
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Reason;
                if (OnReason_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnReason_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Reason != value)
                {
                    var __oldValue = Proxy.Reason;
                    var __newValue = value;
                    if (OnReason_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnReason_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Reason", __oldValue, __newValue);
                    Proxy.Reason = __newValue;
                    NotifyPropertyChanged("Reason", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnReason_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnReason_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Reason");
				}
            }
        }

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.InstanceConstraint, string> OnReason_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.InstanceConstraint, string> OnReason_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.InstanceConstraint, string> OnReason_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.InstanceConstraint> OnReason_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetErrorText_InstanceConstraint")]
        public virtual string GetErrorText(Zetbox.API.IDataObject constrainedObject)
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetErrorText_InstanceConstraint != null)
            {
                OnGetErrorText_InstanceConstraint(this, e, constrainedObject);
            }
            else
            {
                throw new NotImplementedException("No handler registered on InstanceConstraint.GetErrorText");
            }
            return e.Result;
        }
        public delegate void GetErrorText_Handler<T>(T obj, MethodReturnEventArgs<string> ret, Zetbox.API.IDataObject constrainedObject);
        public static event GetErrorText_Handler<InstanceConstraint> OnGetErrorText_InstanceConstraint;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<InstanceConstraint> OnGetErrorText_InstanceConstraint_CanExec;

        [EventBasedMethod("OnGetErrorText_InstanceConstraint_CanExec")]
        public virtual bool GetErrorTextCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetErrorText_InstanceConstraint_CanExec != null)
				{
					OnGetErrorText_InstanceConstraint_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<InstanceConstraint> OnGetErrorText_InstanceConstraint_CanExecReason;

        [EventBasedMethod("OnGetErrorText_InstanceConstraint_CanExecReason")]
        public virtual string GetErrorTextCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetErrorText_InstanceConstraint_CanExecReason != null)
				{
					OnGetErrorText_InstanceConstraint_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnIsValid_InstanceConstraint")]
        public virtual bool IsValid(Zetbox.API.IDataObject constrainedObject)
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnIsValid_InstanceConstraint != null)
            {
                OnIsValid_InstanceConstraint(this, e, constrainedObject);
            }
            else
            {
                throw new NotImplementedException("No handler registered on InstanceConstraint.IsValid");
            }
            return e.Result;
        }
        public delegate void IsValid_Handler<T>(T obj, MethodReturnEventArgs<bool> ret, Zetbox.API.IDataObject constrainedObject);
        public static event IsValid_Handler<InstanceConstraint> OnIsValid_InstanceConstraint;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<InstanceConstraint> OnIsValid_InstanceConstraint_CanExec;

        [EventBasedMethod("OnIsValid_InstanceConstraint_CanExec")]
        public virtual bool IsValidCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnIsValid_InstanceConstraint_CanExec != null)
				{
					OnIsValid_InstanceConstraint_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<InstanceConstraint> OnIsValid_InstanceConstraint_CanExecReason;

        [EventBasedMethod("OnIsValid_InstanceConstraint_CanExecReason")]
        public virtual string IsValidCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnIsValid_InstanceConstraint_CanExecReason != null)
				{
					OnIsValid_InstanceConstraint_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(InstanceConstraint);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (InstanceConstraint)obj;
            var otherImpl = (InstanceConstraintNHibernateImpl)obj;
            var me = (InstanceConstraint)this;

            me.ExportGuid = other.ExportGuid;
            me.Reason = other.Reason;
            this._fk_Constrained = otherImpl._fk_Constrained;
        }

        public override void AttachToContext(IZetboxContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "Constrained":
                    {
                        var __oldValue = (Zetbox.App.Base.DataTypeNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Constrained);
                        var __newValue = (Zetbox.App.Base.DataTypeNHibernateImpl)parentObj;
                        NotifyPropertyChanging("Constrained", __oldValue, __newValue);
                        this.Proxy.Constrained = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("Constrained", __oldValue, __newValue);
                    }
                    break;
                default:
                    base.UpdateParent(propertyName, parentObj);
                    break;
            }
        }
        #region Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "Constrained":
                case "ExportGuid":
                case "Reason":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }
        #endregion // Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_guid_Constrained.HasValue)
                this.Constrained = ((Zetbox.App.Base.DataTypeNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.Base.DataType>(_fk_guid_Constrained.Value));
            else
            if (_fk_Constrained.HasValue)
                this.Constrained = ((Zetbox.App.Base.DataTypeNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.Base.DataType>(_fk_Constrained.Value));
            else
                this.Constrained = null;
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
                    new PropertyDescriptorNHibernateImpl<InstanceConstraint, Zetbox.App.Base.DataType>(
                        lazyCtx,
                        new Guid("d89723fc-1050-45a1-9b74-5575a677bc2b"),
                        "Constrained",
                        null,
                        obj => obj.Constrained,
                        (obj, val) => obj.Constrained = val,
						obj => OnConstrained_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<InstanceConstraint, Guid>(
                        lazyCtx,
                        new Guid("8ef28076-900c-4294-920c-5d0d91e925bb"),
                        "ExportGuid",
                        null,
                        obj => obj.ExportGuid,
                        (obj, val) => obj.ExportGuid = val,
						obj => OnExportGuid_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<InstanceConstraint, string>(
                        lazyCtx,
                        new Guid("83be7495-e0e0-48fc-872a-70de9c0f7a88"),
                        "Reason",
                        null,
                        obj => obj.Reason,
                        (obj, val) => obj.Reason = val,
						obj => OnReason_IsValid), 
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
        #region Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_InstanceConstraint")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_InstanceConstraint != null)
            {
                OnToString_InstanceConstraint(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<InstanceConstraint> OnToString_InstanceConstraint;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_InstanceConstraint")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_InstanceConstraint != null)
            {
                OnObjectIsValid_InstanceConstraint(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<InstanceConstraint> OnObjectIsValid_InstanceConstraint;

        [EventBasedMethod("OnNotifyPreSave_InstanceConstraint")]
        public override void NotifyPreSave()
        {
            FetchExportGuidOrDefault();
            base.NotifyPreSave();
            if (OnNotifyPreSave_InstanceConstraint != null) OnNotifyPreSave_InstanceConstraint(this);
        }
        public static event ObjectEventHandler<InstanceConstraint> OnNotifyPreSave_InstanceConstraint;

        [EventBasedMethod("OnNotifyPostSave_InstanceConstraint")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_InstanceConstraint != null) OnNotifyPostSave_InstanceConstraint(this);
        }
        public static event ObjectEventHandler<InstanceConstraint> OnNotifyPostSave_InstanceConstraint;

        [EventBasedMethod("OnNotifyCreated_InstanceConstraint")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Constrained");
            SetNotInitializedProperty("Reason");
            base.NotifyCreated();
            if (OnNotifyCreated_InstanceConstraint != null) OnNotifyCreated_InstanceConstraint(this);
        }
        public static event ObjectEventHandler<InstanceConstraint> OnNotifyCreated_InstanceConstraint;

        [EventBasedMethod("OnNotifyDeleting_InstanceConstraint")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_InstanceConstraint != null) OnNotifyDeleting_InstanceConstraint(this);

            // FK_Constraint_on_Constrained
            if (Constrained != null) {
                ((NHibernatePersistenceObject)Constrained).ChildrenToDelete.Add(this);
                ParentsToDelete.Add((NHibernatePersistenceObject)Constrained);
            }

            Constrained = null;
        }
        public static event ObjectEventHandler<InstanceConstraint> OnNotifyDeleting_InstanceConstraint;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class InstanceConstraintProxy
            : IProxyObject, ISortKey<int>
        {
            public InstanceConstraintProxy()
            {
            }

            public virtual int ID { get; set; }

            public virtual Type ZetboxWrapper { get { return typeof(InstanceConstraintNHibernateImpl); } }
            public virtual Type ZetboxProxy { get { return typeof(InstanceConstraintProxy); } }

            public virtual Zetbox.App.Base.DataTypeNHibernateImpl.DataTypeProxy Constrained { get; set; }

            public virtual Guid ExportGuid { get; set; }

            public virtual string Reason { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.Constrained != null ? OurContext.GetIdFromProxy(this.Proxy.Constrained) : (int?)null);
            binStream.Write(this._isExportGuidSet);
            if (this._isExportGuidSet) {
                binStream.Write(this.Proxy.ExportGuid);
            }
            binStream.Write(this.Proxy.Reason);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            binStream.Read(out this._fk_Constrained);
            this._isExportGuidSet = binStream.ReadBoolean();
            if (this._isExportGuidSet) {
                this.Proxy.ExportGuid = binStream.ReadGuid();
            }
            this.Proxy.Reason = binStream.ReadString();
            } // if (CurrentAccessRights != Zetbox.API.AccessRights.None)
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            xml.WriteAttributeString("ExportGuid", this.Proxy.ExportGuid.ToString());
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this.Proxy.Constrained != null ? this.Proxy.Constrained.ExportGuid : (Guid?)null, xml, "Constrained", "Zetbox.App.Base");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this.Proxy.Reason, xml, "Reason", "Zetbox.App.Base");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Base|Constrained":
                this._fk_guid_Constrained = XmlStreamer.ReadNullableGuid(xml);
                break;
            case "Zetbox.App.Base|ExportGuid":
                // Import must have default value set
                this.Proxy.ExportGuid = XmlStreamer.ReadGuid(xml);
                this._isExportGuidSet = true;
                break;
            case "Zetbox.App.Base|Reason":
                this.Proxy.Reason = XmlStreamer.ReadString(xml);
                break;
            }
        }

        #endregion

    }
}