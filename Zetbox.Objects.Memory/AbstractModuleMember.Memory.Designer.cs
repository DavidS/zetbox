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
    /// Abstract base class for classes (and their instances) belonging to a Module
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("AbstractModuleMember")]
    public class AbstractModuleMemberMemoryImpl : Zetbox.DalProvider.Memory.DataObjectMemoryImpl, AbstractModuleMember, Zetbox.API.IExportableInternal
    {
        private static readonly Guid _objectClassID = new Guid("d833bf36-29ab-47fa-ba49-bfb820fcf83c");
        public override Guid ObjectClassID { get { return _objectClassID; } }

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
	        // BEGIN Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ChangedBy
        // fkBackingName=_fk_ChangedBy; fkGuidBackingName=_fk_guid_ChangedBy;
        // referencedInterface=Zetbox.App.Base.Identity; moduleNamespace=Zetbox.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target not exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Zetbox.Generator.Templates.Properties.DelegatingProperty
        public Zetbox.App.Base.Identity ChangedBy
        {
            get { return ChangedByImpl; }
            set { ChangedByImpl = (Zetbox.App.Base.IdentityMemoryImpl)value; }
        }
        // END Zetbox.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_ChangedBy;


        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Zetbox.App.Base.IdentityMemoryImpl ChangedByImpl
        {
            get
            {
                Zetbox.App.Base.IdentityMemoryImpl __value;
                if (_fk_ChangedBy.HasValue)
                    __value = (Zetbox.App.Base.IdentityMemoryImpl)Context.Find<Zetbox.App.Base.Identity>(_fk_ChangedBy.Value);
                else
                    __value = null;

                if (OnChangedBy_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.Identity>(__value);
                    OnChangedBy_Getter(this, e);
                    __value = (Zetbox.App.Base.IdentityMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noops
                if ((value == null && _fk_ChangedBy == null) || (value != null && value.ID == _fk_ChangedBy))
				{
					SetInitializedProperty("ChangedBy");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = ChangedByImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("ChangedBy", __oldValue, __newValue);

                if (OnChangedBy_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.Identity>(__oldValue, __newValue);
                    OnChangedBy_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.IdentityMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_ChangedBy = __newValue == null ? (int?)null : __newValue.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("ChangedBy", __oldValue, __newValue);

                if (OnChangedBy_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.Identity>(__oldValue, __newValue);
                    OnChangedBy_PostSetter(this, e);
                }
            }
        }
        // END Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ChangedBy
		public static event PropertyGetterHandler<Zetbox.App.Base.AbstractModuleMember, Zetbox.App.Base.Identity> OnChangedBy_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.AbstractModuleMember, Zetbox.App.Base.Identity> OnChangedBy_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.AbstractModuleMember, Zetbox.App.Base.Identity> OnChangedBy_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.AbstractModuleMember> OnChangedBy_IsValid;

        /// <summary>
        /// Date and time where this object was changed
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public DateTime ChangedOn
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ChangedOn;
                if (!_isChangedOnSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("e97d5203-ee5e-403e-aa96-2453150fea67"));
                    if (__p != null) {
                        _isChangedOnSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._ChangedOn = (DateTime)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'AbstractModuleMember.ChangedOn'");
                    }
                }
                if (OnChangedOn_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime>(__result);
                    OnChangedOn_Getter(this, __e);
                    __result = _ChangedOn = __e.Result;
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
				else 
				{
					SetInitializedProperty("ChangedOn");
				}
            }
        }
        private DateTime _ChangedOn;
        private bool _isChangedOnSet = false;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.AbstractModuleMember, DateTime> OnChangedOn_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.AbstractModuleMember, DateTime> OnChangedOn_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.AbstractModuleMember, DateTime> OnChangedOn_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.AbstractModuleMember> OnChangedOn_IsValid;

        /// <summary>
        /// Identity which created this object
        /// </summary>
	        // BEGIN Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for CreatedBy
        // fkBackingName=_fk_CreatedBy; fkGuidBackingName=_fk_guid_CreatedBy;
        // referencedInterface=Zetbox.App.Base.Identity; moduleNamespace=Zetbox.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target not exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Zetbox.Generator.Templates.Properties.DelegatingProperty
        public Zetbox.App.Base.Identity CreatedBy
        {
            get { return CreatedByImpl; }
            set { CreatedByImpl = (Zetbox.App.Base.IdentityMemoryImpl)value; }
        }
        // END Zetbox.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_CreatedBy;


        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Zetbox.App.Base.IdentityMemoryImpl CreatedByImpl
        {
            get
            {
                Zetbox.App.Base.IdentityMemoryImpl __value;
                if (_fk_CreatedBy.HasValue)
                    __value = (Zetbox.App.Base.IdentityMemoryImpl)Context.Find<Zetbox.App.Base.Identity>(_fk_CreatedBy.Value);
                else
                    __value = null;

                if (OnCreatedBy_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.Identity>(__value);
                    OnCreatedBy_Getter(this, e);
                    __value = (Zetbox.App.Base.IdentityMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noops
                if ((value == null && _fk_CreatedBy == null) || (value != null && value.ID == _fk_CreatedBy))
				{
					SetInitializedProperty("CreatedBy");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = CreatedByImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("CreatedBy", __oldValue, __newValue);

                if (OnCreatedBy_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.Identity>(__oldValue, __newValue);
                    OnCreatedBy_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.IdentityMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_CreatedBy = __newValue == null ? (int?)null : __newValue.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("CreatedBy", __oldValue, __newValue);

                if (OnCreatedBy_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.Identity>(__oldValue, __newValue);
                    OnCreatedBy_PostSetter(this, e);
                }
            }
        }
        // END Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for CreatedBy
		public static event PropertyGetterHandler<Zetbox.App.Base.AbstractModuleMember, Zetbox.App.Base.Identity> OnCreatedBy_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.AbstractModuleMember, Zetbox.App.Base.Identity> OnCreatedBy_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.AbstractModuleMember, Zetbox.App.Base.Identity> OnCreatedBy_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.AbstractModuleMember> OnCreatedBy_IsValid;

        /// <summary>
        /// Date and time where this object was created
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public DateTime CreatedOn
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _CreatedOn;
                if (!_isCreatedOnSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("dd92e8c6-6a54-4f25-b8ca-3b7900c8ea71"));
                    if (__p != null) {
                        _isCreatedOnSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._CreatedOn = (DateTime)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'AbstractModuleMember.CreatedOn'");
                    }
                }
                if (OnCreatedOn_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime>(__result);
                    OnCreatedOn_Getter(this, __e);
                    __result = _CreatedOn = __e.Result;
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
				else 
				{
					SetInitializedProperty("CreatedOn");
				}
            }
        }
        private DateTime _CreatedOn;
        private bool _isCreatedOnSet = false;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.AbstractModuleMember, DateTime> OnCreatedOn_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.AbstractModuleMember, DateTime> OnCreatedOn_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.AbstractModuleMember, DateTime> OnCreatedOn_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.AbstractModuleMember> OnCreatedOn_IsValid;

        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public Guid ExportGuid
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ExportGuid;
                if (!_isExportGuidSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("a81fffa3-a110-4a81-bc00-c7055b4f11fe"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._ExportGuid = (Guid)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'AbstractModuleMember.ExportGuid'");
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
		public static event PropertyGetterHandler<Zetbox.App.Base.AbstractModuleMember, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.AbstractModuleMember, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.AbstractModuleMember, Guid> OnExportGuid_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.AbstractModuleMember> OnExportGuid_IsValid;

        /// <summary>
        /// 
        /// </summary>
	        // BEGIN Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Module
        // fkBackingName=_fk_Module; fkGuidBackingName=_fk_guid_Module;
        // referencedInterface=Zetbox.App.Base.Module; moduleNamespace=Zetbox.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Zetbox.Generator.Templates.Properties.DelegatingProperty
        public Zetbox.App.Base.Module Module
        {
            get { return ModuleImpl; }
            set { ModuleImpl = (Zetbox.App.Base.ModuleMemoryImpl)value; }
        }
        // END Zetbox.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_Module;

        private Guid? _fk_guid_Module = null;

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Zetbox.App.Base.ModuleMemoryImpl ModuleImpl
        {
            get
            {
                Zetbox.App.Base.ModuleMemoryImpl __value;
                if (_fk_Module.HasValue)
                    __value = (Zetbox.App.Base.ModuleMemoryImpl)Context.Find<Zetbox.App.Base.Module>(_fk_Module.Value);
                else
                    __value = null;

                if (OnModule_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.Module>(__value);
                    OnModule_Getter(this, e);
                    __value = (Zetbox.App.Base.ModuleMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noops
                if ((value == null && _fk_Module == null) || (value != null && value.ID == _fk_Module))
				{
					SetInitializedProperty("Module");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = ModuleImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Module", __oldValue, __newValue);

                if (OnModule_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.Module>(__oldValue, __newValue);
                    OnModule_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.ModuleMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_Module = __newValue == null ? (int?)null : __newValue.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Module", __oldValue, __newValue);

                if (OnModule_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.Module>(__oldValue, __newValue);
                    OnModule_PostSetter(this, e);
                }
            }
        }
        // END Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Module
		public static event PropertyGetterHandler<Zetbox.App.Base.AbstractModuleMember, Zetbox.App.Base.Module> OnModule_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.AbstractModuleMember, Zetbox.App.Base.Module> OnModule_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.AbstractModuleMember, Zetbox.App.Base.Module> OnModule_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.AbstractModuleMember> OnModule_IsValid;

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
                case "ChangedBy":
                    {
                        var __oldValue = _fk_ChangedBy;
                        var __newValue = parentObj == null ? (int?)null : parentObj.ID;
                        NotifyPropertyChanging("ChangedBy", __oldValue, __newValue);
                        _fk_ChangedBy = __newValue;
                        NotifyPropertyChanged("ChangedBy", __oldValue, __newValue);
                    }
                    break;
                case "CreatedBy":
                    {
                        var __oldValue = _fk_CreatedBy;
                        var __newValue = parentObj == null ? (int?)null : parentObj.ID;
                        NotifyPropertyChanging("CreatedBy", __oldValue, __newValue);
                        _fk_CreatedBy = __newValue;
                        NotifyPropertyChanged("CreatedBy", __oldValue, __newValue);
                    }
                    break;
                case "Module":
                    {
                        var __oldValue = _fk_Module;
                        var __newValue = parentObj == null ? (int?)null : parentObj.ID;
                        NotifyPropertyChanging("Module", __oldValue, __newValue);
                        _fk_Module = __newValue;
                        NotifyPropertyChanged("Module", __oldValue, __newValue);
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
                case "ChangedBy":
                case "ChangedOn":
                case "CreatedBy":
                case "CreatedOn":
                case "ExportGuid":
                case "Module":
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

            if (_fk_ChangedBy.HasValue)
                ChangedByImpl = (Zetbox.App.Base.IdentityMemoryImpl)Context.Find<Zetbox.App.Base.Identity>(_fk_ChangedBy.Value);
            else
                ChangedByImpl = null;

            if (_fk_CreatedBy.HasValue)
                CreatedByImpl = (Zetbox.App.Base.IdentityMemoryImpl)Context.Find<Zetbox.App.Base.Identity>(_fk_CreatedBy.Value);
            else
                CreatedByImpl = null;

            if (_fk_guid_Module.HasValue)
                ModuleImpl = (Zetbox.App.Base.ModuleMemoryImpl)Context.FindPersistenceObject<Zetbox.App.Base.Module>(_fk_guid_Module.Value);
            else
            if (_fk_Module.HasValue)
                ModuleImpl = (Zetbox.App.Base.ModuleMemoryImpl)Context.Find<Zetbox.App.Base.Module>(_fk_Module.Value);
            else
                ModuleImpl = null;
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
                    new PropertyDescriptorMemoryImpl<AbstractModuleMember, Zetbox.App.Base.Identity>(
                        lazyCtx,
                        new Guid("a8914567-8d6d-45d6-81a0-99b86f16da5b"),
                        "ChangedBy",
                        null,
                        obj => obj.ChangedBy,
                        (obj, val) => obj.ChangedBy = val,
						obj => OnChangedBy_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<AbstractModuleMember, DateTime>(
                        lazyCtx,
                        new Guid("e97d5203-ee5e-403e-aa96-2453150fea67"),
                        "ChangedOn",
                        null,
                        obj => obj.ChangedOn,
                        (obj, val) => obj.ChangedOn = val,
						obj => OnChangedOn_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<AbstractModuleMember, Zetbox.App.Base.Identity>(
                        lazyCtx,
                        new Guid("b157f222-4a23-4ef6-9454-68e87168d0dc"),
                        "CreatedBy",
                        null,
                        obj => obj.CreatedBy,
                        (obj, val) => obj.CreatedBy = val,
						obj => OnCreatedBy_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<AbstractModuleMember, DateTime>(
                        lazyCtx,
                        new Guid("dd92e8c6-6a54-4f25-b8ca-3b7900c8ea71"),
                        "CreatedOn",
                        null,
                        obj => obj.CreatedOn,
                        (obj, val) => obj.CreatedOn = val,
						obj => OnCreatedOn_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<AbstractModuleMember, Guid>(
                        lazyCtx,
                        new Guid("a81fffa3-a110-4a81-bc00-c7055b4f11fe"),
                        "ExportGuid",
                        null,
                        obj => obj.ExportGuid,
                        (obj, val) => obj.ExportGuid = val,
						obj => OnExportGuid_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<AbstractModuleMember, Zetbox.App.Base.Module>(
                        lazyCtx,
                        new Guid("c0f5ea39-eb21-44d4-a59c-cf0e31e4543c"),
                        "Module",
                        null,
                        obj => obj.Module,
                        (obj, val) => obj.Module = val,
						obj => OnModule_IsValid), 
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

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_AbstractModuleMember")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_AbstractModuleMember != null)
            {
                OnObjectIsValid_AbstractModuleMember(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<AbstractModuleMember> OnObjectIsValid_AbstractModuleMember;

        [EventBasedMethod("OnNotifyPreSave_AbstractModuleMember")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_AbstractModuleMember != null) OnNotifyPreSave_AbstractModuleMember(this);
        }
        public static event ObjectEventHandler<AbstractModuleMember> OnNotifyPreSave_AbstractModuleMember;

        [EventBasedMethod("OnNotifyPostSave_AbstractModuleMember")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_AbstractModuleMember != null) OnNotifyPostSave_AbstractModuleMember(this);
        }
        public static event ObjectEventHandler<AbstractModuleMember> OnNotifyPostSave_AbstractModuleMember;

        [EventBasedMethod("OnNotifyCreated_AbstractModuleMember")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("ChangedBy");
            SetNotInitializedProperty("CreatedBy");
            SetNotInitializedProperty("Module");
            base.NotifyCreated();
            if (OnNotifyCreated_AbstractModuleMember != null) OnNotifyCreated_AbstractModuleMember(this);
        }
        public static event ObjectEventHandler<AbstractModuleMember> OnNotifyCreated_AbstractModuleMember;

        [EventBasedMethod("OnNotifyDeleting_AbstractModuleMember")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_AbstractModuleMember != null) OnNotifyDeleting_AbstractModuleMember(this);
            ChangedBy = null;
            CreatedBy = null;
        }
        public static event ObjectEventHandler<AbstractModuleMember> OnNotifyDeleting_AbstractModuleMember;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(ChangedBy != null ? ChangedBy.ID : (int?)null);
            binStream.Write(this._isChangedOnSet);
            if (this._isChangedOnSet) {
                binStream.Write(this._ChangedOn);
            }
            binStream.Write(CreatedBy != null ? CreatedBy.ID : (int?)null);
            binStream.Write(this._isCreatedOnSet);
            if (this._isCreatedOnSet) {
                binStream.Write(this._CreatedOn);
            }
            binStream.Write(this._isExportGuidSet);
            if (this._isExportGuidSet) {
                binStream.Write(this._ExportGuid);
            }
            binStream.Write(Module != null ? Module.ID : (int?)null);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._fk_ChangedBy = binStream.ReadNullableInt32();
            this._isChangedOnSet = binStream.ReadBoolean();
            if (this._isChangedOnSet) {
                this._ChangedOn = binStream.ReadDateTime();
            }
            this._fk_CreatedBy = binStream.ReadNullableInt32();
            this._isCreatedOnSet = binStream.ReadBoolean();
            if (this._isCreatedOnSet) {
                this._CreatedOn = binStream.ReadDateTime();
            }
            this._isExportGuidSet = binStream.ReadBoolean();
            if (this._isExportGuidSet) {
                this._ExportGuid = binStream.ReadGuid();
            }
            this._fk_Module = binStream.ReadNullableInt32();
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
            System.Diagnostics.Debug.Assert(this._isChangedOnSet, "Exported objects need to have all default values evaluated");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this._ChangedOn, xml, "ChangedOn", "Zetbox.App.Base");
            System.Diagnostics.Debug.Assert(this._isCreatedOnSet, "Exported objects need to have all default values evaluated");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this._CreatedOn, xml, "CreatedOn", "Zetbox.App.Base");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(Module != null ? Module.ExportGuid : (Guid?)null, xml, "Module", "Zetbox.App.Base");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Base|ChangedOn":
                // Import must have default value set
                this._ChangedOn = XmlStreamer.ReadDateTime(xml);
                this._isChangedOnSet = true;
                break;
            case "Zetbox.App.Base|CreatedOn":
                // Import must have default value set
                this._CreatedOn = XmlStreamer.ReadDateTime(xml);
                this._isCreatedOnSet = true;
                break;
            case "Zetbox.App.Base|ExportGuid":
                // Import must have default value set
                this._ExportGuid = XmlStreamer.ReadGuid(xml);
                this._isExportGuidSet = true;
                break;
            case "Zetbox.App.Base|Module":
                this._fk_guid_Module = XmlStreamer.ReadNullableGuid(xml);
                break;
            }
        }

        #endregion

    }
}