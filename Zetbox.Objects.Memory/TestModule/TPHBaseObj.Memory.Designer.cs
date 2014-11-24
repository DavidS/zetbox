// <autogenerated/>

namespace Zetbox.App.Test
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
    /// Base object for testing TPH
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("TPHBaseObj")]
    public class TPHBaseObjMemoryImpl : Zetbox.DalProvider.Memory.DataObjectMemoryImpl, TPHBaseObj, Zetbox.API.IExportableInternal
    {
        private static readonly Guid _objectClassID = new Guid("430ba80a-a9e4-4700-a0c3-06b21f2c77fe");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public TPHBaseObjMemoryImpl()
            : base(null)
        {
        }

        public TPHBaseObjMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// Identity which changed this object
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ChangedBy
        // fkBackingName=_fk_ChangedBy; fkGuidBackingName=_fk_guid_ChangedBy;
        // referencedInterface=Zetbox.App.Base.Identity; moduleNamespace=Zetbox.App.Test;
        // no inverse navigator handling
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

        private int? __fk_ChangedByCache;

        private int? _fk_ChangedBy {
            get
            {
                return __fk_ChangedByCache;
            }
            set
            {
                __fk_ChangedByCache = value;
                // Recreate task to clear it's cache
                _triggerFetchChangedByTask = null;
            }
        }


        Zetbox.API.Async.ZbTask<Zetbox.App.Base.Identity> _triggerFetchChangedByTask;
        public Zetbox.API.Async.ZbTask<Zetbox.App.Base.Identity> TriggerFetchChangedByAsync()
        {
            if (_triggerFetchChangedByTask != null) return _triggerFetchChangedByTask;

            if (_fk_ChangedBy.HasValue)
                _triggerFetchChangedByTask = Context.FindAsync<Zetbox.App.Base.Identity>(_fk_ChangedBy.Value);
            else
                _triggerFetchChangedByTask = new Zetbox.API.Async.ZbTask<Zetbox.App.Base.Identity>(Zetbox.API.Async.ZbTask.Synchron, () => null);

            _triggerFetchChangedByTask.OnResult(t =>
            {
                if (OnChangedBy_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.Identity>(t.Result);
                    OnChangedBy_Getter(this, e);
                    t.Result = e.Result;
                }
            });

            return _triggerFetchChangedByTask;
        }

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Zetbox.App.Base.IdentityMemoryImpl ChangedByImpl
        {
            get
            {
                return (Zetbox.App.Base.IdentityMemoryImpl)TriggerFetchChangedByAsync().Result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
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
                if(IsAttached) UpdateChangedInfo = true;

                if (OnChangedBy_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.Identity>(__oldValue, __newValue);
                    OnChangedBy_PostSetter(this, e);
                }
            }
        }
        // END Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ChangedBy
		public static event PropertyGetterHandler<Zetbox.App.Test.TPHBaseObj, Zetbox.App.Base.Identity> OnChangedBy_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TPHBaseObj, Zetbox.App.Base.Identity> OnChangedBy_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TPHBaseObj, Zetbox.App.Base.Identity> OnChangedBy_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.TPHBaseObj> OnChangedBy_IsValid;

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
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("07bcf241-16d2-45e1-9d59-d1098af5ecbc"));
                    if (__p != null) {
                        _isChangedOnSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._ChangedOn = (DateTime)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'TPHBaseObj.ChangedOn'");
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
                    if (__newValue.Kind == DateTimeKind.Unspecified)
                        __newValue = DateTime.SpecifyKind(__newValue, DateTimeKind.Local);
                    if (OnChangedOn_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime>(__oldValue, __newValue);
                        OnChangedOn_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ChangedOn", __oldValue, __newValue);
                    _ChangedOn = __newValue;
                    NotifyPropertyChanged("ChangedOn", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

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
		public static event PropertyGetterHandler<Zetbox.App.Test.TPHBaseObj, DateTime> OnChangedOn_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TPHBaseObj, DateTime> OnChangedOn_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TPHBaseObj, DateTime> OnChangedOn_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.TPHBaseObj> OnChangedOn_IsValid;

        /// <summary>
        /// Identity which created this object
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for CreatedBy
        // fkBackingName=_fk_CreatedBy; fkGuidBackingName=_fk_guid_CreatedBy;
        // referencedInterface=Zetbox.App.Base.Identity; moduleNamespace=Zetbox.App.Test;
        // no inverse navigator handling
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

        private int? __fk_CreatedByCache;

        private int? _fk_CreatedBy {
            get
            {
                return __fk_CreatedByCache;
            }
            set
            {
                __fk_CreatedByCache = value;
                // Recreate task to clear it's cache
                _triggerFetchCreatedByTask = null;
            }
        }


        Zetbox.API.Async.ZbTask<Zetbox.App.Base.Identity> _triggerFetchCreatedByTask;
        public Zetbox.API.Async.ZbTask<Zetbox.App.Base.Identity> TriggerFetchCreatedByAsync()
        {
            if (_triggerFetchCreatedByTask != null) return _triggerFetchCreatedByTask;

            if (_fk_CreatedBy.HasValue)
                _triggerFetchCreatedByTask = Context.FindAsync<Zetbox.App.Base.Identity>(_fk_CreatedBy.Value);
            else
                _triggerFetchCreatedByTask = new Zetbox.API.Async.ZbTask<Zetbox.App.Base.Identity>(Zetbox.API.Async.ZbTask.Synchron, () => null);

            _triggerFetchCreatedByTask.OnResult(t =>
            {
                if (OnCreatedBy_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.Identity>(t.Result);
                    OnCreatedBy_Getter(this, e);
                    t.Result = e.Result;
                }
            });

            return _triggerFetchCreatedByTask;
        }

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Zetbox.App.Base.IdentityMemoryImpl CreatedByImpl
        {
            get
            {
                return (Zetbox.App.Base.IdentityMemoryImpl)TriggerFetchCreatedByAsync().Result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
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
                if(IsAttached) UpdateChangedInfo = true;

                if (OnCreatedBy_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.Identity>(__oldValue, __newValue);
                    OnCreatedBy_PostSetter(this, e);
                }
            }
        }
        // END Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for CreatedBy
		public static event PropertyGetterHandler<Zetbox.App.Test.TPHBaseObj, Zetbox.App.Base.Identity> OnCreatedBy_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TPHBaseObj, Zetbox.App.Base.Identity> OnCreatedBy_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TPHBaseObj, Zetbox.App.Base.Identity> OnCreatedBy_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.TPHBaseObj> OnCreatedBy_IsValid;

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
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("d51a5e63-2bcb-47bb-9c9e-46caf563e8a6"));
                    if (__p != null) {
                        _isCreatedOnSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._CreatedOn = (DateTime)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'TPHBaseObj.CreatedOn'");
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
                    if (__newValue.Kind == DateTimeKind.Unspecified)
                        __newValue = DateTime.SpecifyKind(__newValue, DateTimeKind.Local);
                    if (OnCreatedOn_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime>(__oldValue, __newValue);
                        OnCreatedOn_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("CreatedOn", __oldValue, __newValue);
                    _CreatedOn = __newValue;
                    NotifyPropertyChanged("CreatedOn", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

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
		public static event PropertyGetterHandler<Zetbox.App.Test.TPHBaseObj, DateTime> OnCreatedOn_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TPHBaseObj, DateTime> OnCreatedOn_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TPHBaseObj, DateTime> OnCreatedOn_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.TPHBaseObj> OnCreatedOn_IsValid;

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
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("73f5e7ac-1dfc-4149-9995-8e3b04a95614"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._ExportGuid = (Guid)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'TPHBaseObj.ExportGuid'");
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
        private Guid _ExportGuid;
        private bool _isExportGuidSet = false;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.TPHBaseObj, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TPHBaseObj, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TPHBaseObj, Guid> OnExportGuid_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.TPHBaseObj> OnExportGuid_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public string Name
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Name;
                if (OnName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnName_Getter(this, __e);
                    __result = _Name = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Name != value)
                {
                    var __oldValue = _Name;
                    var __newValue = value;
                    if (OnName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Name", __oldValue, __newValue);
                    _Name = __newValue;
                    NotifyPropertyChanged("Name", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("Name");
                }
            }
        }
        private string _Name;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.TPHBaseObj, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TPHBaseObj, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TPHBaseObj, string> OnName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.TPHBaseObj> OnName_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(TPHBaseObj);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (TPHBaseObj)obj;
            var otherImpl = (TPHBaseObjMemoryImpl)obj;
            var me = (TPHBaseObj)this;

            me.ChangedOn = other.ChangedOn;
            me.CreatedOn = other.CreatedOn;
            me.ExportGuid = other.ExportGuid;
            me.Name = other.Name;
            this._fk_ChangedBy = otherImpl._fk_ChangedBy;
            this._fk_CreatedBy = otherImpl._fk_CreatedBy;
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
                case "Name":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }
        #endregion // Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        public override Zetbox.API.Async.ZbTask TriggerFetch(string propName)
        {
            switch(propName)
            {
            case "ChangedBy":
                return TriggerFetchChangedByAsync();
            case "CreatedBy":
                return TriggerFetchCreatedByAsync();
            default:
                return base.TriggerFetch(propName);
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
                ChangedByImpl = (Zetbox.App.Base.IdentityMemoryImpl)Context.Find<Zetbox.App.Base.Identity>(_fk_ChangedBy.Value);
            else
                ChangedByImpl = null;

            if (_fk_CreatedBy.HasValue)
                CreatedByImpl = (Zetbox.App.Base.IdentityMemoryImpl)Context.Find<Zetbox.App.Base.Identity>(_fk_CreatedBy.Value);
            else
                CreatedByImpl = null;
            // fix cached lists references
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
                    new PropertyDescriptorMemoryImpl<TPHBaseObj, Zetbox.App.Base.Identity>(
                        lazyCtx,
                        new Guid("a8c0f966-ae75-4634-9958-612b4f8d8de0"),
                        "ChangedBy",
                        null,
                        obj => obj.ChangedBy,
                        (obj, val) => obj.ChangedBy = val,
						obj => OnChangedBy_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<TPHBaseObj, DateTime>(
                        lazyCtx,
                        new Guid("07bcf241-16d2-45e1-9d59-d1098af5ecbc"),
                        "ChangedOn",
                        null,
                        obj => obj.ChangedOn,
                        (obj, val) => obj.ChangedOn = val,
						obj => OnChangedOn_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<TPHBaseObj, Zetbox.App.Base.Identity>(
                        lazyCtx,
                        new Guid("d810d56c-0fac-4525-b0c6-cf2bfaa43e61"),
                        "CreatedBy",
                        null,
                        obj => obj.CreatedBy,
                        (obj, val) => obj.CreatedBy = val,
						obj => OnCreatedBy_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<TPHBaseObj, DateTime>(
                        lazyCtx,
                        new Guid("d51a5e63-2bcb-47bb-9c9e-46caf563e8a6"),
                        "CreatedOn",
                        null,
                        obj => obj.CreatedOn,
                        (obj, val) => obj.CreatedOn = val,
						obj => OnCreatedOn_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<TPHBaseObj, Guid>(
                        lazyCtx,
                        new Guid("73f5e7ac-1dfc-4149-9995-8e3b04a95614"),
                        "ExportGuid",
                        null,
                        obj => obj.ExportGuid,
                        (obj, val) => obj.ExportGuid = val,
						obj => OnExportGuid_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<TPHBaseObj, string>(
                        lazyCtx,
                        new Guid("ad7feae4-cbeb-4bb5-a87c-5eb24c130e6d"),
                        "Name",
                        null,
                        obj => obj.Name,
                        (obj, val) => obj.Name = val,
						obj => OnName_IsValid), 
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
        [EventBasedMethod("OnToString_TPHBaseObj")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_TPHBaseObj != null)
            {
                OnToString_TPHBaseObj(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<TPHBaseObj> OnToString_TPHBaseObj;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_TPHBaseObj")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_TPHBaseObj != null)
            {
                OnObjectIsValid_TPHBaseObj(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<TPHBaseObj> OnObjectIsValid_TPHBaseObj;

        [EventBasedMethod("OnNotifyPreSave_TPHBaseObj")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_TPHBaseObj != null) OnNotifyPreSave_TPHBaseObj(this);
        }
        public static event ObjectEventHandler<TPHBaseObj> OnNotifyPreSave_TPHBaseObj;

        [EventBasedMethod("OnNotifyPostSave_TPHBaseObj")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_TPHBaseObj != null) OnNotifyPostSave_TPHBaseObj(this);
        }
        public static event ObjectEventHandler<TPHBaseObj> OnNotifyPostSave_TPHBaseObj;

        [EventBasedMethod("OnNotifyCreated_TPHBaseObj")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("ChangedBy");
            SetNotInitializedProperty("CreatedBy");
            SetNotInitializedProperty("Name");
            base.NotifyCreated();
            if (OnNotifyCreated_TPHBaseObj != null) OnNotifyCreated_TPHBaseObj(this);
        }
        public static event ObjectEventHandler<TPHBaseObj> OnNotifyCreated_TPHBaseObj;

        [EventBasedMethod("OnNotifyDeleting_TPHBaseObj")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_TPHBaseObj != null) OnNotifyDeleting_TPHBaseObj(this);
            ChangedBy = null;
            CreatedBy = null;
        }
        public static event ObjectEventHandler<TPHBaseObj> OnNotifyDeleting_TPHBaseObj;

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
            binStream.Write(this._Name);
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
            this._Name = binStream.ReadString();
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
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Test")) XmlStreamer.ToStream(this._ChangedOn, xml, "ChangedOn", "Zetbox.App.Test");
            System.Diagnostics.Debug.Assert(this._isCreatedOnSet, "Exported objects need to have all default values evaluated");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Test")) XmlStreamer.ToStream(this._CreatedOn, xml, "CreatedOn", "Zetbox.App.Test");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Test")) XmlStreamer.ToStream(this._Name, xml, "Name", "Zetbox.App.Test");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Test|ChangedOn":
                // Import must have default value set
                this._ChangedOn = XmlStreamer.ReadDateTime(xml);
                this._isChangedOnSet = true;
                break;
            case "Zetbox.App.Test|CreatedOn":
                // Import must have default value set
                this._CreatedOn = XmlStreamer.ReadDateTime(xml);
                this._isCreatedOnSet = true;
                break;
            case "Zetbox.App.Test|ExportGuid":
                // Import must have default value set
                this._ExportGuid = XmlStreamer.ReadGuid(xml);
                this._isExportGuidSet = true;
                break;
            case "Zetbox.App.Test|Name":
                this._Name = XmlStreamer.ReadString(xml);
                break;
            }
        }

        #endregion

    }
}