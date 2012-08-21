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
    [System.Diagnostics.DebuggerDisplay("ConstraintInvocation")]
    public class ConstraintInvocationNHibernateImpl : Zetbox.DalProvider.NHibernate.DataObjectNHibernateImpl, ConstraintInvocation, Zetbox.API.IExportableInternal
    {
        private static readonly Guid _objectClassID = new Guid("038230c3-ee0b-4a04-b89b-fe342ac8f069");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public ConstraintInvocationNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public ConstraintInvocationNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new ConstraintInvocationProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public ConstraintInvocationNHibernateImpl(Func<IFrozenContext> lazyCtx, ConstraintInvocationProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
            _isExportGuidSet = Proxy.ID > 0;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly ConstraintInvocationProxy Proxy;

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
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("06d4a536-d9c4-487f-9861-ac15429e42de"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this.Proxy.ExportGuid = (Guid)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'Zetbox.App.Base.ConstraintInvocation.ExportGuid'");
                    }
                }
            return __result;
        }

        private bool _isExportGuidSet = false;
        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.ConstraintInvocation, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.ConstraintInvocation, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.ConstraintInvocation, Guid> OnExportGuid_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.ConstraintInvocation> OnExportGuid_IsValid;

        /// <summary>
        /// The type implementing this invocation
        /// </summary>
        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Implementor
        // fkBackingName=this.Proxy.Implementor; fkGuidBackingName=_fk_guid_Implementor;
        // referencedInterface=Zetbox.App.Base.TypeRef; moduleNamespace=Zetbox.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Base.TypeRef Implementor
        {
            get
            {
                Zetbox.App.Base.TypeRefNHibernateImpl __value = (Zetbox.App.Base.TypeRefNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Implementor);

                if (OnImplementor_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.TypeRef>(__value);
                    OnImplementor_Getter(this, e);
                    __value = (Zetbox.App.Base.TypeRefNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.Implementor == null)
				{
					SetInitializedProperty("Implementor");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = (Zetbox.App.Base.TypeRefNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Implementor);
                var __newValue = (Zetbox.App.Base.TypeRefNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
				{
					SetInitializedProperty("Implementor");
                    return;
				}

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Implementor", __oldValue, __newValue);

                if (OnImplementor_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.TypeRef>(__oldValue, __newValue);
                    OnImplementor_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.TypeRefNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.Implementor = null;
                }
                else
                {
                    this.Proxy.Implementor = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Implementor", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;

                if (OnImplementor_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.TypeRef>(__oldValue, __newValue);
                    OnImplementor_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for Implementor's id, used on dehydration only</summary>
        private int? _fk_Implementor = null;

        /// <summary>Backing store for Implementor's guid, used on import only</summary>
        private Guid? _fk_guid_Implementor = null;

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Implementor
		public static event PropertyGetterHandler<Zetbox.App.Base.ConstraintInvocation, Zetbox.App.Base.TypeRef> OnImplementor_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.ConstraintInvocation, Zetbox.App.Base.TypeRef> OnImplementor_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.ConstraintInvocation, Zetbox.App.Base.TypeRef> OnImplementor_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.ConstraintInvocation> OnImplementor_IsValid;

        /// <summary>
        /// Name des implementierenden Members
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string MemberName
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.MemberName;
                if (OnMemberName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnMemberName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.MemberName != value)
                {
                    var __oldValue = Proxy.MemberName;
                    var __newValue = value;
                    if (OnMemberName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnMemberName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("MemberName", __oldValue, __newValue);
                    Proxy.MemberName = __newValue;
                    NotifyPropertyChanged("MemberName", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnMemberName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnMemberName_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("MemberName");
				}
            }
        }

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.ConstraintInvocation, string> OnMemberName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.ConstraintInvocation, string> OnMemberName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.ConstraintInvocation, string> OnMemberName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.ConstraintInvocation> OnMemberName_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetCodeTemplate_ConstraintInvocation")]
        public virtual string GetCodeTemplate()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetCodeTemplate_ConstraintInvocation != null)
            {
                OnGetCodeTemplate_ConstraintInvocation(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on ConstraintInvocation.GetCodeTemplate");
            }
            return e.Result;
        }
        public delegate void GetCodeTemplate_Handler<T>(T obj, MethodReturnEventArgs<string> ret);
        public static event GetCodeTemplate_Handler<ConstraintInvocation> OnGetCodeTemplate_ConstraintInvocation;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ConstraintInvocation> OnGetCodeTemplate_ConstraintInvocation_CanExec;

        [EventBasedMethod("OnGetCodeTemplate_ConstraintInvocation_CanExec")]
        public virtual bool GetCodeTemplateCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetCodeTemplate_ConstraintInvocation_CanExec != null)
				{
					OnGetCodeTemplate_ConstraintInvocation_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ConstraintInvocation> OnGetCodeTemplate_ConstraintInvocation_CanExecReason;

        [EventBasedMethod("OnGetCodeTemplate_ConstraintInvocation_CanExecReason")]
        public virtual string GetCodeTemplateCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetCodeTemplate_ConstraintInvocation_CanExecReason != null)
				{
					OnGetCodeTemplate_ConstraintInvocation_CanExecReason(this, e);
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
        [EventBasedMethod("OnGetMemberName_ConstraintInvocation")]
        public virtual string GetMemberName()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetMemberName_ConstraintInvocation != null)
            {
                OnGetMemberName_ConstraintInvocation(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on ConstraintInvocation.GetMemberName");
            }
            return e.Result;
        }
        public delegate void GetMemberName_Handler<T>(T obj, MethodReturnEventArgs<string> ret);
        public static event GetMemberName_Handler<ConstraintInvocation> OnGetMemberName_ConstraintInvocation;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ConstraintInvocation> OnGetMemberName_ConstraintInvocation_CanExec;

        [EventBasedMethod("OnGetMemberName_ConstraintInvocation_CanExec")]
        public virtual bool GetMemberNameCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetMemberName_ConstraintInvocation_CanExec != null)
				{
					OnGetMemberName_ConstraintInvocation_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ConstraintInvocation> OnGetMemberName_ConstraintInvocation_CanExecReason;

        [EventBasedMethod("OnGetMemberName_ConstraintInvocation_CanExecReason")]
        public virtual string GetMemberNameCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetMemberName_ConstraintInvocation_CanExecReason != null)
				{
					OnGetMemberName_ConstraintInvocation_CanExecReason(this, e);
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
            return typeof(ConstraintInvocation);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (ConstraintInvocation)obj;
            var otherImpl = (ConstraintInvocationNHibernateImpl)obj;
            var me = (ConstraintInvocation)this;

            me.ExportGuid = other.ExportGuid;
            me.MemberName = other.MemberName;
            this._fk_Implementor = otherImpl._fk_Implementor;
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
                case "Implementor":
                    {
                        var __oldValue = (Zetbox.App.Base.TypeRefNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Implementor);
                        var __newValue = (Zetbox.App.Base.TypeRefNHibernateImpl)parentObj;
                        NotifyPropertyChanging("Implementor", __oldValue, __newValue);
                        this.Proxy.Implementor = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("Implementor", __oldValue, __newValue);
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
                case "ExportGuid":
                case "Implementor":
                case "MemberName":
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

            if (_fk_guid_Implementor.HasValue)
                this.Implementor = ((Zetbox.App.Base.TypeRefNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.Base.TypeRef>(_fk_guid_Implementor.Value));
            else
            if (_fk_Implementor.HasValue)
                this.Implementor = ((Zetbox.App.Base.TypeRefNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.Base.TypeRef>(_fk_Implementor.Value));
            else
                this.Implementor = null;
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
                    new PropertyDescriptorNHibernateImpl<ConstraintInvocation, Guid>(
                        lazyCtx,
                        new Guid("06d4a536-d9c4-487f-9861-ac15429e42de"),
                        "ExportGuid",
                        null,
                        obj => obj.ExportGuid,
                        (obj, val) => obj.ExportGuid = val,
						obj => OnExportGuid_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<ConstraintInvocation, Zetbox.App.Base.TypeRef>(
                        lazyCtx,
                        new Guid("4b8486d5-2c48-4485-9824-d0a4a8bbbbca"),
                        "Implementor",
                        null,
                        obj => obj.Implementor,
                        (obj, val) => obj.Implementor = val,
						obj => OnImplementor_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<ConstraintInvocation, string>(
                        lazyCtx,
                        new Guid("fd6ac977-3eab-4b2c-952a-2a1ad043b99a"),
                        "MemberName",
                        null,
                        obj => obj.MemberName,
                        (obj, val) => obj.MemberName = val,
						obj => OnMemberName_IsValid), 
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
        [EventBasedMethod("OnToString_ConstraintInvocation")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ConstraintInvocation != null)
            {
                OnToString_ConstraintInvocation(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<ConstraintInvocation> OnToString_ConstraintInvocation;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_ConstraintInvocation")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_ConstraintInvocation != null)
            {
                OnObjectIsValid_ConstraintInvocation(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<ConstraintInvocation> OnObjectIsValid_ConstraintInvocation;

        [EventBasedMethod("OnNotifyPreSave_ConstraintInvocation")]
        public override void NotifyPreSave()
        {
            FetchExportGuidOrDefault();
            base.NotifyPreSave();
            if (OnNotifyPreSave_ConstraintInvocation != null) OnNotifyPreSave_ConstraintInvocation(this);
        }
        public static event ObjectEventHandler<ConstraintInvocation> OnNotifyPreSave_ConstraintInvocation;

        [EventBasedMethod("OnNotifyPostSave_ConstraintInvocation")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_ConstraintInvocation != null) OnNotifyPostSave_ConstraintInvocation(this);
        }
        public static event ObjectEventHandler<ConstraintInvocation> OnNotifyPostSave_ConstraintInvocation;

        [EventBasedMethod("OnNotifyCreated_ConstraintInvocation")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Implementor");
            SetNotInitializedProperty("MemberName");
            base.NotifyCreated();
            if (OnNotifyCreated_ConstraintInvocation != null) OnNotifyCreated_ConstraintInvocation(this);
        }
        public static event ObjectEventHandler<ConstraintInvocation> OnNotifyCreated_ConstraintInvocation;

        [EventBasedMethod("OnNotifyDeleting_ConstraintInvocation")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_ConstraintInvocation != null) OnNotifyDeleting_ConstraintInvocation(this);

            // should fetch && remember children for InvokingConstraint_invokes_ConstraintInvocation_RelationEntry
            // should fetch && remember children for InvokingConstraint_invokes_ConstraintInvocation_RelationEntry
            // FK_ConstraintInvocation_has_TypeRef
            if (Implementor != null) {
                ((NHibernatePersistenceObject)Implementor).ChildrenToDelete.Add(this);
                ParentsToDelete.Add((NHibernatePersistenceObject)Implementor);
            }

            Implementor = null;
        }
        public static event ObjectEventHandler<ConstraintInvocation> OnNotifyDeleting_ConstraintInvocation;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class ConstraintInvocationProxy
            : IProxyObject, ISortKey<int>
        {
            public ConstraintInvocationProxy()
            {
            }

            public virtual int ID { get; set; }

            public virtual Type ZetboxWrapper { get { return typeof(ConstraintInvocationNHibernateImpl); } }
            public virtual Type ZetboxProxy { get { return typeof(ConstraintInvocationProxy); } }

            public virtual Guid ExportGuid { get; set; }

            public virtual Zetbox.App.Base.TypeRefNHibernateImpl.TypeRefProxy Implementor { get; set; }

            public virtual string MemberName { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._isExportGuidSet);
            if (this._isExportGuidSet) {
                binStream.Write(this.Proxy.ExportGuid);
            }
            binStream.Write(this.Proxy.Implementor != null ? OurContext.GetIdFromProxy(this.Proxy.Implementor) : (int?)null);
            binStream.Write(this.Proxy.MemberName);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._isExportGuidSet = binStream.ReadBoolean();
            if (this._isExportGuidSet) {
                this.Proxy.ExportGuid = binStream.ReadGuid();
            }
            binStream.Read(out this._fk_Implementor);
            this.Proxy.MemberName = binStream.ReadString();
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
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this.Proxy.Implementor != null ? this.Proxy.Implementor.ExportGuid : (Guid?)null, xml, "Implementor", "Zetbox.App.Base");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this.Proxy.MemberName, xml, "MemberName", "Zetbox.App.Base");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Base|ExportGuid":
                // Import must have default value set
                this.Proxy.ExportGuid = XmlStreamer.ReadGuid(xml);
                this._isExportGuidSet = true;
                break;
            case "Zetbox.App.Base|Implementor":
                this._fk_guid_Implementor = XmlStreamer.ReadNullableGuid(xml);
                break;
            case "Zetbox.App.Base|MemberName":
                this.Proxy.MemberName = XmlStreamer.ReadString(xml);
                break;
            }
        }

        #endregion

    }
}