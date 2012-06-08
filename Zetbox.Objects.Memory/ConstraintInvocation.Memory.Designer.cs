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

    using Zetbox.DalProvider.Base;
    using Zetbox.DalProvider.Memory;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("ConstraintInvocation")]
    public class ConstraintInvocationMemoryImpl : Zetbox.DalProvider.Memory.DataObjectMemoryImpl, ConstraintInvocation, Zetbox.API.IExportableInternal
    {
        private static readonly Guid _objectClassID = new Guid("038230c3-ee0b-4a04-b89b-fe342ac8f069");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public ConstraintInvocationMemoryImpl()
            : base(null)
        {
        }

        public ConstraintInvocationMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public Guid ExportGuid
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(Guid);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ExportGuid;
                if (!_isExportGuidSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("06d4a536-d9c4-487f-9861-ac15429e42de"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._ExportGuid = (Guid)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'ConstraintInvocation.ExportGuid'");
                    }
                }
                if (OnExportGuid_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<Guid>(__result);
                    OnExportGuid_Getter(this, __e);
                    __result = _ExportGuid = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isExportGuidSet = true;
                if (_ExportGuid != value)
                {
                    var __oldValue = _ExportGuid;
                    var __newValue = value;
                    if (OnExportGuid_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ExportGuid", __oldValue, __newValue);
                    _ExportGuid = __newValue;
                    NotifyPropertyChanged("ExportGuid", __oldValue, __newValue);

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
        private Guid _ExportGuid;
        private bool _isExportGuidSet = false;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.ConstraintInvocation, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.ConstraintInvocation, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.ConstraintInvocation, Guid> OnExportGuid_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.ConstraintInvocation> OnExportGuid_IsValid;

        /// <summary>
        /// The type implementing this invocation
        /// </summary>
	        // BEGIN Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Implementor
        // fkBackingName=_fk_Implementor; fkGuidBackingName=_fk_guid_Implementor;
        // referencedInterface=Zetbox.App.Base.TypeRef; moduleNamespace=Zetbox.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Zetbox.Generator.Templates.Properties.DelegatingProperty
        public Zetbox.App.Base.TypeRef Implementor
        {
            get { return ImplementorImpl; }
            set { ImplementorImpl = (Zetbox.App.Base.TypeRefMemoryImpl)value; }
        }
        // END Zetbox.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_Implementor;

        private Guid? _fk_guid_Implementor = null;

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Zetbox.App.Base.TypeRefMemoryImpl ImplementorImpl
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Zetbox.App.Base.TypeRefMemoryImpl __value;
                if (_fk_Implementor.HasValue)
                    __value = (Zetbox.App.Base.TypeRefMemoryImpl)Context.Find<Zetbox.App.Base.TypeRef>(_fk_Implementor.Value);
                else
                    __value = null;

                if (OnImplementor_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.TypeRef>(__value);
                    OnImplementor_Getter(this, e);
                    __value = (Zetbox.App.Base.TypeRefMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noops
                if ((value == null && _fk_Implementor == null) || (value != null && value.ID == _fk_Implementor))
				{
					SetInitializedProperty("Implementor");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = ImplementorImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Implementor", __oldValue, __newValue);

                if (OnImplementor_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.TypeRef>(__oldValue, __newValue);
                    OnImplementor_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.TypeRefMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_Implementor = __newValue == null ? (int?)null : __newValue.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Implementor", __oldValue, __newValue);

                if (OnImplementor_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.TypeRef>(__oldValue, __newValue);
                    OnImplementor_PostSetter(this, e);
                }
            }
        }
        // END Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Implementor
		public static event PropertyGetterHandler<Zetbox.App.Base.ConstraintInvocation, Zetbox.App.Base.TypeRef> OnImplementor_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.ConstraintInvocation, Zetbox.App.Base.TypeRef> OnImplementor_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.ConstraintInvocation, Zetbox.App.Base.TypeRef> OnImplementor_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.ConstraintInvocation> OnImplementor_IsValid;

        /// <summary>
        /// Name des implementierenden Members
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public string MemberName
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _MemberName;
                if (OnMemberName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnMemberName_Getter(this, __e);
                    __result = _MemberName = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_MemberName != value)
                {
                    var __oldValue = _MemberName;
                    var __newValue = value;
                    if (OnMemberName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnMemberName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("MemberName", __oldValue, __newValue);
                    _MemberName = __newValue;
                    NotifyPropertyChanged("MemberName", __oldValue, __newValue);

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
        private string _MemberName;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
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
            var otherImpl = (ConstraintInvocationMemoryImpl)obj;
            var me = (ConstraintInvocation)this;

            me.ExportGuid = other.ExportGuid;
            me.MemberName = other.MemberName;
            this._fk_Implementor = otherImpl._fk_Implementor;
        }

        public override void AttachToContext(IZetboxContext ctx)
        {
            base.AttachToContext(ctx);
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
                        var __oldValue = _fk_Implementor;
                        var __newValue = parentObj == null ? (int?)null : parentObj.ID;
                        NotifyPropertyChanging("Implementor", __oldValue, __newValue);
                        _fk_Implementor = __newValue;
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
                ImplementorImpl = (Zetbox.App.Base.TypeRefMemoryImpl)Context.FindPersistenceObject<Zetbox.App.Base.TypeRef>(_fk_guid_Implementor.Value);
            else
            if (_fk_Implementor.HasValue)
                ImplementorImpl = (Zetbox.App.Base.TypeRefMemoryImpl)Context.Find<Zetbox.App.Base.TypeRef>(_fk_Implementor.Value);
            else
                ImplementorImpl = null;
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
                    new PropertyDescriptorMemoryImpl<ConstraintInvocation, Guid>(
                        lazyCtx,
                        new Guid("06d4a536-d9c4-487f-9861-ac15429e42de"),
                        "ExportGuid",
                        null,
                        obj => obj.ExportGuid,
                        (obj, val) => obj.ExportGuid = val,
						obj => OnExportGuid_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<ConstraintInvocation, Zetbox.App.Base.TypeRef>(
                        lazyCtx,
                        new Guid("4b8486d5-2c48-4485-9824-d0a4a8bbbbca"),
                        "Implementor",
                        null,
                        obj => obj.Implementor,
                        (obj, val) => obj.Implementor = val,
						obj => OnImplementor_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<ConstraintInvocation, string>(
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
        #region Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

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
            Implementor = null;
        }
        public static event ObjectEventHandler<ConstraintInvocation> OnNotifyDeleting_ConstraintInvocation;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._isExportGuidSet);
            if (this._isExportGuidSet) {
                binStream.Write(this._ExportGuid);
            }
            binStream.Write(Implementor != null ? Implementor.ID : (int?)null);
            binStream.Write(this._MemberName);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._isExportGuidSet = binStream.ReadBoolean();
            if (this._isExportGuidSet) {
                this._ExportGuid = binStream.ReadGuid();
            }
            this._fk_Implementor = binStream.ReadNullableInt32();
            this._MemberName = binStream.ReadString();
            } // if (CurrentAccessRights != Zetbox.API.AccessRights.None)
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            xml.WriteAttributeString("ExportGuid", this._ExportGuid.ToString());
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(Implementor != null ? Implementor.ExportGuid : (Guid?)null, xml, "Implementor", "Zetbox.App.Base");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this._MemberName, xml, "MemberName", "Zetbox.App.Base");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Base|ExportGuid":
                // Import must have default value set
                this._ExportGuid = XmlStreamer.ReadGuid(xml);
                this._isExportGuidSet = true;
                break;
            case "Zetbox.App.Base|Implementor":
                this._fk_guid_Implementor = XmlStreamer.ReadNullableGuid(xml);
                break;
            case "Zetbox.App.Base|MemberName":
                this._MemberName = XmlStreamer.ReadString(xml);
                break;
            }
        }

        #endregion

    }
}