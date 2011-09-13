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

    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.Memory;

    /// <summary>
    /// Abstract base class for classes (and their instances) belonging to a Module
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("AbstractModuleMember")]
    public class AbstractModuleMemberMemoryImpl : Kistl.DalProvider.Memory.DataObjectMemoryImpl, AbstractModuleMember, Kistl.API.IExportableInternal
    {
        [Obsolete]
        public AbstractModuleMemberMemoryImpl()
            : base(null)
        {
        }

        public AbstractModuleMemberMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// Identity which changed this object
        /// </summary>
        // BEGIN Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ChangedBy
        // fkBackingName=_fk_ChangedBy; fkGuidBackingName=_fk_guid_ChangedBy;
        // referencedInterface=Kistl.App.Base.Identity; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target not exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Kistl.Generator.Templates.Properties.DelegatingProperty
        public Kistl.App.Base.Identity ChangedBy
        {
            get { return ChangedByImpl; }
            set { ChangedByImpl = (Kistl.App.Base.IdentityMemoryImpl)value; }
        }
        // END Kistl.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_ChangedBy;


        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Kistl.App.Base.IdentityMemoryImpl ChangedByImpl
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return null;
                Kistl.App.Base.IdentityMemoryImpl __value;
                if (_fk_ChangedBy.HasValue)
                    __value = (Kistl.App.Base.IdentityMemoryImpl)Context.Find<Kistl.App.Base.Identity>(_fk_ChangedBy.Value);
                else
                    __value = null;

                if (OnChangedBy_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.Identity>(__value);
                    OnChangedBy_Getter(this, e);
                    __value = (Kistl.App.Base.IdentityMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noops
                if (value == null && _fk_ChangedBy == null)
                    return;
                else if (value != null && value.ID == _fk_ChangedBy)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = ChangedByImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("ChangedBy", __oldValue, __newValue);

                if (OnChangedBy_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Identity>(__oldValue, __newValue);
                    OnChangedBy_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.IdentityMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_ChangedBy = __newValue == null ? (int?)null : __newValue.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("ChangedBy", __oldValue, __newValue);

                if (OnChangedBy_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Identity>(__oldValue, __newValue);
                    OnChangedBy_PostSetter(this, e);
                }
            }
        }
        // END Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ChangedBy
		public static event PropertyGetterHandler<Kistl.App.Base.AbstractModuleMember, Kistl.App.Base.Identity> OnChangedBy_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.AbstractModuleMember, Kistl.App.Base.Identity> OnChangedBy_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.AbstractModuleMember, Kistl.App.Base.Identity> OnChangedBy_PostSetter;

        /// <summary>
        /// Date and time where this object was changed
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public DateTime ChangedOn
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return default(DateTime);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ChangedOn;
                if (!_isChangedOnSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("e97d5203-ee5e-403e-aa96-2453150fea67"));
                    if (__p != null) {
                        _isChangedOnSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._ChangedOn = (DateTime)__tmp_value;
                    } else {
                        Kistl.API.Utils.Logging.Log.Warn("Unable to get default value for property 'AbstractModuleMember.ChangedOn'");
                    }
                }
                if (OnChangedOn_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime>(__result);
                    OnChangedOn_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isChangedOnSet = true;
                if (_ChangedOn != value)
                {
                    var __oldValue = _ChangedOn;
                    var __newValue = value;
                    if (OnChangedOn_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime>(__oldValue, __newValue);
                        OnChangedOn_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ChangedOn", __oldValue, __newValue);
                    _ChangedOn = __newValue;
                    NotifyPropertyChanged("ChangedOn", __oldValue, __newValue);
                    if (OnChangedOn_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime>(__oldValue, __newValue);
                        OnChangedOn_PostSetter(this, __e);
                    }
                }
            }
        }
        private DateTime _ChangedOn;
        private bool _isChangedOnSet = false;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.AbstractModuleMember, DateTime> OnChangedOn_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.AbstractModuleMember, DateTime> OnChangedOn_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.AbstractModuleMember, DateTime> OnChangedOn_PostSetter;

        /// <summary>
        /// Identity which created this object
        /// </summary>
        // BEGIN Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for CreatedBy
        // fkBackingName=_fk_CreatedBy; fkGuidBackingName=_fk_guid_CreatedBy;
        // referencedInterface=Kistl.App.Base.Identity; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target not exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Kistl.Generator.Templates.Properties.DelegatingProperty
        public Kistl.App.Base.Identity CreatedBy
        {
            get { return CreatedByImpl; }
            set { CreatedByImpl = (Kistl.App.Base.IdentityMemoryImpl)value; }
        }
        // END Kistl.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_CreatedBy;


        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Kistl.App.Base.IdentityMemoryImpl CreatedByImpl
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return null;
                Kistl.App.Base.IdentityMemoryImpl __value;
                if (_fk_CreatedBy.HasValue)
                    __value = (Kistl.App.Base.IdentityMemoryImpl)Context.Find<Kistl.App.Base.Identity>(_fk_CreatedBy.Value);
                else
                    __value = null;

                if (OnCreatedBy_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.Identity>(__value);
                    OnCreatedBy_Getter(this, e);
                    __value = (Kistl.App.Base.IdentityMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noops
                if (value == null && _fk_CreatedBy == null)
                    return;
                else if (value != null && value.ID == _fk_CreatedBy)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = CreatedByImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("CreatedBy", __oldValue, __newValue);

                if (OnCreatedBy_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Identity>(__oldValue, __newValue);
                    OnCreatedBy_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.IdentityMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_CreatedBy = __newValue == null ? (int?)null : __newValue.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("CreatedBy", __oldValue, __newValue);

                if (OnCreatedBy_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Identity>(__oldValue, __newValue);
                    OnCreatedBy_PostSetter(this, e);
                }
            }
        }
        // END Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for CreatedBy
		public static event PropertyGetterHandler<Kistl.App.Base.AbstractModuleMember, Kistl.App.Base.Identity> OnCreatedBy_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.AbstractModuleMember, Kistl.App.Base.Identity> OnCreatedBy_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.AbstractModuleMember, Kistl.App.Base.Identity> OnCreatedBy_PostSetter;

        /// <summary>
        /// Date and time where this object was created
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public DateTime CreatedOn
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return default(DateTime);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _CreatedOn;
                if (!_isCreatedOnSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("dd92e8c6-6a54-4f25-b8ca-3b7900c8ea71"));
                    if (__p != null) {
                        _isCreatedOnSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._CreatedOn = (DateTime)__tmp_value;
                    } else {
                        Kistl.API.Utils.Logging.Log.Warn("Unable to get default value for property 'AbstractModuleMember.CreatedOn'");
                    }
                }
                if (OnCreatedOn_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime>(__result);
                    OnCreatedOn_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isCreatedOnSet = true;
                if (_CreatedOn != value)
                {
                    var __oldValue = _CreatedOn;
                    var __newValue = value;
                    if (OnCreatedOn_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime>(__oldValue, __newValue);
                        OnCreatedOn_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("CreatedOn", __oldValue, __newValue);
                    _CreatedOn = __newValue;
                    NotifyPropertyChanged("CreatedOn", __oldValue, __newValue);
                    if (OnCreatedOn_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime>(__oldValue, __newValue);
                        OnCreatedOn_PostSetter(this, __e);
                    }
                }
            }
        }
        private DateTime _CreatedOn;
        private bool _isCreatedOnSet = false;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.AbstractModuleMember, DateTime> OnCreatedOn_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.AbstractModuleMember, DateTime> OnCreatedOn_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.AbstractModuleMember, DateTime> OnCreatedOn_PostSetter;

        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public Guid ExportGuid
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return default(Guid);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ExportGuid;
                if (!_isExportGuidSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("a81fffa3-a110-4a81-bc00-c7055b4f11fe"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._ExportGuid = (Guid)__tmp_value;
                    } else {
                        Kistl.API.Utils.Logging.Log.Warn("Unable to get default value for property 'AbstractModuleMember.ExportGuid'");
                    }
                }
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
            }
        }
        private Guid _ExportGuid;
        private bool _isExportGuidSet = false;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.AbstractModuleMember, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.AbstractModuleMember, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.AbstractModuleMember, Guid> OnExportGuid_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Module
        // fkBackingName=_fk_Module; fkGuidBackingName=_fk_guid_Module;
        // referencedInterface=Kistl.App.Base.Module; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Kistl.Generator.Templates.Properties.DelegatingProperty
        public Kistl.App.Base.Module Module
        {
            get { return ModuleImpl; }
            set { ModuleImpl = (Kistl.App.Base.ModuleMemoryImpl)value; }
        }
        // END Kistl.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_Module;

        private Guid? _fk_guid_Module = null;

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Kistl.App.Base.ModuleMemoryImpl ModuleImpl
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return null;
                Kistl.App.Base.ModuleMemoryImpl __value;
                if (_fk_Module.HasValue)
                    __value = (Kistl.App.Base.ModuleMemoryImpl)Context.Find<Kistl.App.Base.Module>(_fk_Module.Value);
                else
                    __value = null;

                if (OnModule_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.Module>(__value);
                    OnModule_Getter(this, e);
                    __value = (Kistl.App.Base.ModuleMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noops
                if (value == null && _fk_Module == null)
                    return;
                else if (value != null && value.ID == _fk_Module)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = ModuleImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Module", __oldValue, __newValue);

                if (OnModule_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Module>(__oldValue, __newValue);
                    OnModule_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.ModuleMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_Module = __newValue == null ? (int?)null : __newValue.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Module", __oldValue, __newValue);

                if (OnModule_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Module>(__oldValue, __newValue);
                    OnModule_PostSetter(this, e);
                }
            }
        }
        // END Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Module
		public static event PropertyGetterHandler<Kistl.App.Base.AbstractModuleMember, Kistl.App.Base.Module> OnModule_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.AbstractModuleMember, Kistl.App.Base.Module> OnModule_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.AbstractModuleMember, Kistl.App.Base.Module> OnModule_PostSetter;

        public override Type GetImplementedInterface()
        {
            return typeof(AbstractModuleMember);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (AbstractModuleMember)obj;
            var otherImpl = (AbstractModuleMemberMemoryImpl)obj;
            var me = (AbstractModuleMember)this;

            me.ChangedOn = other.ChangedOn;
            me.CreatedOn = other.CreatedOn;
            me.ExportGuid = other.ExportGuid;
            this._fk_ChangedBy = otherImpl._fk_ChangedBy;
            this._fk_CreatedBy = otherImpl._fk_CreatedBy;
            this._fk_Module = otherImpl._fk_Module;
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
                case "ChangedBy":
                    __oldValue = _fk_ChangedBy;
                    NotifyPropertyChanging("ChangedBy", __oldValue, __newValue);
                    _fk_ChangedBy = __newValue;
                    NotifyPropertyChanged("ChangedBy", __oldValue, __newValue);
                    break;
                case "CreatedBy":
                    __oldValue = _fk_CreatedBy;
                    NotifyPropertyChanging("CreatedBy", __oldValue, __newValue);
                    _fk_CreatedBy = __newValue;
                    NotifyPropertyChanged("CreatedBy", __oldValue, __newValue);
                    break;
                case "Module":
                    __oldValue = _fk_Module;
                    NotifyPropertyChanging("Module", __oldValue, __newValue);
                    _fk_Module = __newValue;
                    NotifyPropertyChanged("Module", __oldValue, __newValue);
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

            if (_fk_ChangedBy.HasValue)
                ChangedByImpl = (Kistl.App.Base.IdentityMemoryImpl)Context.Find<Kistl.App.Base.Identity>(_fk_ChangedBy.Value);
            else
                ChangedByImpl = null;

            if (_fk_CreatedBy.HasValue)
                CreatedByImpl = (Kistl.App.Base.IdentityMemoryImpl)Context.Find<Kistl.App.Base.Identity>(_fk_CreatedBy.Value);
            else
                CreatedByImpl = null;

            if (_fk_guid_Module.HasValue)
                ModuleImpl = (Kistl.App.Base.ModuleMemoryImpl)Context.FindPersistenceObject<Kistl.App.Base.Module>(_fk_guid_Module.Value);
            else
            if (_fk_Module.HasValue)
                ModuleImpl = (Kistl.App.Base.ModuleMemoryImpl)Context.Find<Kistl.App.Base.Module>(_fk_Module.Value);
            else
                ModuleImpl = null;
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
                    new PropertyDescriptorMemoryImpl<AbstractModuleMemberMemoryImpl, Kistl.App.Base.Identity>(
                        lazyCtx,
                        new Guid("a8914567-8d6d-45d6-81a0-99b86f16da5b"),
                        "ChangedBy",
                        null,
                        obj => obj.ChangedBy,
                        (obj, val) => obj.ChangedBy = val),
                    // else
                    new PropertyDescriptorMemoryImpl<AbstractModuleMemberMemoryImpl, DateTime>(
                        lazyCtx,
                        new Guid("e97d5203-ee5e-403e-aa96-2453150fea67"),
                        "ChangedOn",
                        null,
                        obj => obj.ChangedOn,
                        (obj, val) => obj.ChangedOn = val),
                    // else
                    new PropertyDescriptorMemoryImpl<AbstractModuleMemberMemoryImpl, Kistl.App.Base.Identity>(
                        lazyCtx,
                        new Guid("b157f222-4a23-4ef6-9454-68e87168d0dc"),
                        "CreatedBy",
                        null,
                        obj => obj.CreatedBy,
                        (obj, val) => obj.CreatedBy = val),
                    // else
                    new PropertyDescriptorMemoryImpl<AbstractModuleMemberMemoryImpl, DateTime>(
                        lazyCtx,
                        new Guid("dd92e8c6-6a54-4f25-b8ca-3b7900c8ea71"),
                        "CreatedOn",
                        null,
                        obj => obj.CreatedOn,
                        (obj, val) => obj.CreatedOn = val),
                    // else
                    new PropertyDescriptorMemoryImpl<AbstractModuleMemberMemoryImpl, Guid>(
                        lazyCtx,
                        new Guid("a81fffa3-a110-4a81-bc00-c7055b4f11fe"),
                        "ExportGuid",
                        null,
                        obj => obj.ExportGuid,
                        (obj, val) => obj.ExportGuid = val),
                    // else
                    new PropertyDescriptorMemoryImpl<AbstractModuleMemberMemoryImpl, Kistl.App.Base.Module>(
                        lazyCtx,
                        new Guid("c0f5ea39-eb21-44d4-a59c-cf0e31e4543c"),
                        "Module",
                        null,
                        obj => obj.Module,
                        (obj, val) => obj.Module = val),
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
        [EventBasedMethod("OnToString_AbstractModuleMember")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_AbstractModuleMember != null)
            {
                OnToString_AbstractModuleMember(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<AbstractModuleMember> OnToString_AbstractModuleMember;

        [EventBasedMethod("OnPreSave_AbstractModuleMember")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_AbstractModuleMember != null) OnPreSave_AbstractModuleMember(this);
        }
        public static event ObjectEventHandler<AbstractModuleMember> OnPreSave_AbstractModuleMember;

        [EventBasedMethod("OnPostSave_AbstractModuleMember")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_AbstractModuleMember != null) OnPostSave_AbstractModuleMember(this);
        }
        public static event ObjectEventHandler<AbstractModuleMember> OnPostSave_AbstractModuleMember;

        [EventBasedMethod("OnCreated_AbstractModuleMember")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_AbstractModuleMember != null) OnCreated_AbstractModuleMember(this);
        }
        public static event ObjectEventHandler<AbstractModuleMember> OnCreated_AbstractModuleMember;

        [EventBasedMethod("OnDeleting_AbstractModuleMember")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_AbstractModuleMember != null) OnDeleting_AbstractModuleMember(this);
        }
        public static event ObjectEventHandler<AbstractModuleMember> OnDeleting_AbstractModuleMember;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(ChangedBy != null ? ChangedBy.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._isChangedOnSet, binStream);
            if (this._isChangedOnSet) {
                BinarySerializer.ToStream(this._ChangedOn, binStream);
            }
            BinarySerializer.ToStream(CreatedBy != null ? CreatedBy.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._isCreatedOnSet, binStream);
            if (this._isCreatedOnSet) {
                BinarySerializer.ToStream(this._CreatedOn, binStream);
            }
            BinarySerializer.ToStream(this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.ToStream(this._ExportGuid, binStream);
            }
            BinarySerializer.ToStream(Module != null ? Module.ID : (int?)null, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            BinarySerializer.FromStream(out this._fk_ChangedBy, binStream);
            BinarySerializer.FromStream(out this._isChangedOnSet, binStream);
            if (this._isChangedOnSet) {
                BinarySerializer.FromStream(out this._ChangedOn, binStream);
            }
            BinarySerializer.FromStream(out this._fk_CreatedBy, binStream);
            BinarySerializer.FromStream(out this._isCreatedOnSet, binStream);
            if (this._isCreatedOnSet) {
                BinarySerializer.FromStream(out this._CreatedOn, binStream);
            }
            BinarySerializer.FromStream(out this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.FromStream(out this._ExportGuid, binStream);
            }
            BinarySerializer.FromStream(out this._fk_Module, binStream);
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            XmlStreamer.ToStream(ChangedBy != null ? ChangedBy.ID : (int?)null, xml, "ChangedBy", "Kistl.App.Base");
            XmlStreamer.ToStream(this._isChangedOnSet, xml, "IsChangedOnSet", "Kistl.App.Base");
            if (this._isChangedOnSet) {
                XmlStreamer.ToStream(this._ChangedOn, xml, "ChangedOn", "Kistl.App.Base");
            }
            XmlStreamer.ToStream(CreatedBy != null ? CreatedBy.ID : (int?)null, xml, "CreatedBy", "Kistl.App.Base");
            XmlStreamer.ToStream(this._isCreatedOnSet, xml, "IsCreatedOnSet", "Kistl.App.Base");
            if (this._isCreatedOnSet) {
                XmlStreamer.ToStream(this._CreatedOn, xml, "CreatedOn", "Kistl.App.Base");
            }
            XmlStreamer.ToStream(this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            }
            XmlStreamer.ToStream(Module != null ? Module.ID : (int?)null, xml, "Module", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            XmlStreamer.FromStream(ref this._fk_ChangedBy, xml, "ChangedBy", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._isChangedOnSet, xml, "IsChangedOnSet", "Kistl.App.Base");
            if (this._isChangedOnSet) {
                XmlStreamer.FromStream(ref this._ChangedOn, xml, "ChangedOn", "Kistl.App.Base");
            }
            XmlStreamer.FromStream(ref this._fk_CreatedBy, xml, "CreatedBy", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._isCreatedOnSet, xml, "IsCreatedOnSet", "Kistl.App.Base");
            if (this._isCreatedOnSet) {
                XmlStreamer.FromStream(ref this._CreatedOn, xml, "CreatedOn", "Kistl.App.Base");
            }
            XmlStreamer.FromStream(ref this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            }
            XmlStreamer.FromStream(ref this._fk_Module, xml, "Module", "Kistl.App.Base");
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            xml.WriteAttributeString("ExportGuid", this._ExportGuid.ToString());
            System.Diagnostics.Debug.Assert(this._isChangedOnSet, "Exported objects need to have all default values evaluated");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._ChangedOn, xml, "ChangedOn", "Kistl.App.Base");
            System.Diagnostics.Debug.Assert(this._isCreatedOnSet, "Exported objects need to have all default values evaluated");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._CreatedOn, xml, "CreatedOn", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(Module != null ? Module.ExportGuid : (Guid?)null, xml, "Module", "Kistl.App.Base");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            // Import must have default value set
            XmlStreamer.FromStream(ref this._ChangedOn, xml, "ChangedOn", "Kistl.App.Base");
            this._isChangedOnSet = true;
            // Import must have default value set
            XmlStreamer.FromStream(ref this._CreatedOn, xml, "CreatedOn", "Kistl.App.Base");
            this._isCreatedOnSet = true;
            // Import must have default value set
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            this._isExportGuidSet = true;
            XmlStreamer.FromStream(ref this._fk_guid_Module, xml, "Module", "Kistl.App.Base");
        }

        #endregion

    }
}