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
    /// Metadefinition Object for Bool Properties.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("BoolProperty")]
    public class BoolPropertyMemoryImpl : Kistl.App.Base.ValueTypePropertyMemoryImpl, BoolProperty
    {
        [Obsolete]
        public BoolPropertyMemoryImpl()
            : base(null)
        {
        }

        public BoolPropertyMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for FalseIcon
        // fkBackingName=_fk_FalseIcon; fkGuidBackingName=_fk_guid_FalseIcon;
        // referencedInterface=Kistl.App.GUI.Icon; moduleNamespace=Kistl.App.GUI;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Kistl.Generator.Templates.Properties.DelegatingProperty
        public Kistl.App.GUI.Icon FalseIcon
        {
            get { return FalseIconImpl; }
            set { FalseIconImpl = (Kistl.App.GUI.IconMemoryImpl)value; }
        }
        // END Kistl.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_FalseIcon;

        private Guid? _fk_guid_FalseIcon = null;

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Kistl.App.GUI.IconMemoryImpl FalseIconImpl
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.GUI.IconMemoryImpl __value;
                if (_fk_FalseIcon.HasValue)
                    __value = (Kistl.App.GUI.IconMemoryImpl)Context.Find<Kistl.App.GUI.Icon>(_fk_FalseIcon.Value);
                else
                    __value = null;

                if (OnFalseIcon_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.GUI.Icon>(__value);
                    OnFalseIcon_Getter(this, e);
                    __value = (Kistl.App.GUI.IconMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noops
                if (value == null && _fk_FalseIcon == null)
                    return;
                else if (value != null && value.ID == _fk_FalseIcon)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = FalseIconImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("FalseIcon", __oldValue, __newValue);

                if (OnFalseIcon_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.GUI.Icon>(__oldValue, __newValue);
                    OnFalseIcon_PreSetter(this, e);
                    __newValue = (Kistl.App.GUI.IconMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_FalseIcon = __newValue == null ? (int?)null : __newValue.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("FalseIcon", __oldValue, __newValue);

                if (OnFalseIcon_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.GUI.Icon>(__oldValue, __newValue);
                    OnFalseIcon_PostSetter(this, e);
                }
            }
        }
        // END Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for FalseIcon
		public static event PropertyGetterHandler<Kistl.App.Base.BoolProperty, Kistl.App.GUI.Icon> OnFalseIcon_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.BoolProperty, Kistl.App.GUI.Icon> OnFalseIcon_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.BoolProperty, Kistl.App.GUI.Icon> OnFalseIcon_PostSetter;

        /// <summary>
        /// A string to describe the &quot;false&quot; value to the user.
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public string FalseLabel
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _FalseLabel;
                if (OnFalseLabel_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnFalseLabel_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_FalseLabel != value)
                {
                    var __oldValue = _FalseLabel;
                    var __newValue = value;
                    if (OnFalseLabel_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnFalseLabel_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("FalseLabel", __oldValue, __newValue);
                    _FalseLabel = __newValue;
                    NotifyPropertyChanged("FalseLabel", __oldValue, __newValue);
                    if (OnFalseLabel_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnFalseLabel_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _FalseLabel;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.BoolProperty, string> OnFalseLabel_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.BoolProperty, string> OnFalseLabel_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.BoolProperty, string> OnFalseLabel_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for NullIcon
        // fkBackingName=_fk_NullIcon; fkGuidBackingName=_fk_guid_NullIcon;
        // referencedInterface=Kistl.App.GUI.Icon; moduleNamespace=Kistl.App.GUI;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Kistl.Generator.Templates.Properties.DelegatingProperty
        public Kistl.App.GUI.Icon NullIcon
        {
            get { return NullIconImpl; }
            set { NullIconImpl = (Kistl.App.GUI.IconMemoryImpl)value; }
        }
        // END Kistl.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_NullIcon;

        private Guid? _fk_guid_NullIcon = null;

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Kistl.App.GUI.IconMemoryImpl NullIconImpl
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.GUI.IconMemoryImpl __value;
                if (_fk_NullIcon.HasValue)
                    __value = (Kistl.App.GUI.IconMemoryImpl)Context.Find<Kistl.App.GUI.Icon>(_fk_NullIcon.Value);
                else
                    __value = null;

                if (OnNullIcon_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.GUI.Icon>(__value);
                    OnNullIcon_Getter(this, e);
                    __value = (Kistl.App.GUI.IconMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noops
                if (value == null && _fk_NullIcon == null)
                    return;
                else if (value != null && value.ID == _fk_NullIcon)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = NullIconImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("NullIcon", __oldValue, __newValue);

                if (OnNullIcon_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.GUI.Icon>(__oldValue, __newValue);
                    OnNullIcon_PreSetter(this, e);
                    __newValue = (Kistl.App.GUI.IconMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_NullIcon = __newValue == null ? (int?)null : __newValue.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("NullIcon", __oldValue, __newValue);

                if (OnNullIcon_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.GUI.Icon>(__oldValue, __newValue);
                    OnNullIcon_PostSetter(this, e);
                }
            }
        }
        // END Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for NullIcon
		public static event PropertyGetterHandler<Kistl.App.Base.BoolProperty, Kistl.App.GUI.Icon> OnNullIcon_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.BoolProperty, Kistl.App.GUI.Icon> OnNullIcon_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.BoolProperty, Kistl.App.GUI.Icon> OnNullIcon_PostSetter;

        /// <summary>
        /// A string to describe the &quot;null&quot; value to the user.
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public string NullLabel
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _NullLabel;
                if (OnNullLabel_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnNullLabel_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_NullLabel != value)
                {
                    var __oldValue = _NullLabel;
                    var __newValue = value;
                    if (OnNullLabel_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnNullLabel_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("NullLabel", __oldValue, __newValue);
                    _NullLabel = __newValue;
                    NotifyPropertyChanged("NullLabel", __oldValue, __newValue);
                    if (OnNullLabel_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnNullLabel_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _NullLabel;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.BoolProperty, string> OnNullLabel_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.BoolProperty, string> OnNullLabel_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.BoolProperty, string> OnNullLabel_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for TrueIcon
        // fkBackingName=_fk_TrueIcon; fkGuidBackingName=_fk_guid_TrueIcon;
        // referencedInterface=Kistl.App.GUI.Icon; moduleNamespace=Kistl.App.GUI;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Kistl.Generator.Templates.Properties.DelegatingProperty
        public Kistl.App.GUI.Icon TrueIcon
        {
            get { return TrueIconImpl; }
            set { TrueIconImpl = (Kistl.App.GUI.IconMemoryImpl)value; }
        }
        // END Kistl.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_TrueIcon;

        private Guid? _fk_guid_TrueIcon = null;

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Kistl.App.GUI.IconMemoryImpl TrueIconImpl
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.GUI.IconMemoryImpl __value;
                if (_fk_TrueIcon.HasValue)
                    __value = (Kistl.App.GUI.IconMemoryImpl)Context.Find<Kistl.App.GUI.Icon>(_fk_TrueIcon.Value);
                else
                    __value = null;

                if (OnTrueIcon_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.GUI.Icon>(__value);
                    OnTrueIcon_Getter(this, e);
                    __value = (Kistl.App.GUI.IconMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noops
                if (value == null && _fk_TrueIcon == null)
                    return;
                else if (value != null && value.ID == _fk_TrueIcon)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = TrueIconImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("TrueIcon", __oldValue, __newValue);

                if (OnTrueIcon_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.GUI.Icon>(__oldValue, __newValue);
                    OnTrueIcon_PreSetter(this, e);
                    __newValue = (Kistl.App.GUI.IconMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_TrueIcon = __newValue == null ? (int?)null : __newValue.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("TrueIcon", __oldValue, __newValue);

                if (OnTrueIcon_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.GUI.Icon>(__oldValue, __newValue);
                    OnTrueIcon_PostSetter(this, e);
                }
            }
        }
        // END Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for TrueIcon
		public static event PropertyGetterHandler<Kistl.App.Base.BoolProperty, Kistl.App.GUI.Icon> OnTrueIcon_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.BoolProperty, Kistl.App.GUI.Icon> OnTrueIcon_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.BoolProperty, Kistl.App.GUI.Icon> OnTrueIcon_PostSetter;

        /// <summary>
        /// A string to describe the &quot;true&quot; value to the user.
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public string TrueLabel
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _TrueLabel;
                if (OnTrueLabel_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnTrueLabel_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_TrueLabel != value)
                {
                    var __oldValue = _TrueLabel;
                    var __newValue = value;
                    if (OnTrueLabel_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnTrueLabel_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("TrueLabel", __oldValue, __newValue);
                    _TrueLabel = __newValue;
                    NotifyPropertyChanged("TrueLabel", __oldValue, __newValue);
                    if (OnTrueLabel_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnTrueLabel_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _TrueLabel;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.BoolProperty, string> OnTrueLabel_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.BoolProperty, string> OnTrueLabel_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.BoolProperty, string> OnTrueLabel_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_BoolProperty")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_BoolProperty != null)
            {
                OnGetLabel_BoolProperty(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<BoolProperty> OnGetLabel_BoolProperty;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetName_BoolProperty")]
        public override string GetName()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetName_BoolProperty != null)
            {
                OnGetName_BoolProperty(this, e);
            }
            else
            {
                e.Result = base.GetName();
            }
            return e.Result;
        }
        public static event GetName_Handler<BoolProperty> OnGetName_BoolProperty;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetPropertyType_BoolProperty")]
        public override System.Type GetPropertyType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_BoolProperty != null)
            {
                OnGetPropertyType_BoolProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
        public static event GetPropertyType_Handler<BoolProperty> OnGetPropertyType_BoolProperty;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetPropertyTypeString_BoolProperty")]
        public override string GetPropertyTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_BoolProperty != null)
            {
                OnGetPropertyTypeString_BoolProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
        public static event GetPropertyTypeString_Handler<BoolProperty> OnGetPropertyTypeString_BoolProperty;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(BoolProperty);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (BoolProperty)obj;
            var otherImpl = (BoolPropertyMemoryImpl)obj;
            var me = (BoolProperty)this;

            me.FalseLabel = other.FalseLabel;
            me.NullLabel = other.NullLabel;
            me.TrueLabel = other.TrueLabel;
            this._fk_FalseIcon = otherImpl._fk_FalseIcon;
            this._fk_NullIcon = otherImpl._fk_NullIcon;
            this._fk_TrueIcon = otherImpl._fk_TrueIcon;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "FalseIcon":
                    {
                        var __oldValue = _fk_FalseIcon;
                        var __newValue = parentObj == null ? (int?)null : parentObj.ID;
                        NotifyPropertyChanging("FalseIcon", __oldValue, __newValue);
                        _fk_FalseIcon = __newValue;
                        NotifyPropertyChanged("FalseIcon", __oldValue, __newValue);
                    }
                    break;
                case "NullIcon":
                    {
                        var __oldValue = _fk_NullIcon;
                        var __newValue = parentObj == null ? (int?)null : parentObj.ID;
                        NotifyPropertyChanging("NullIcon", __oldValue, __newValue);
                        _fk_NullIcon = __newValue;
                        NotifyPropertyChanged("NullIcon", __oldValue, __newValue);
                    }
                    break;
                case "TrueIcon":
                    {
                        var __oldValue = _fk_TrueIcon;
                        var __newValue = parentObj == null ? (int?)null : parentObj.ID;
                        NotifyPropertyChanging("TrueIcon", __oldValue, __newValue);
                        _fk_TrueIcon = __newValue;
                        NotifyPropertyChanged("TrueIcon", __oldValue, __newValue);
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

            if (_fk_guid_FalseIcon.HasValue)
                FalseIconImpl = (Kistl.App.GUI.IconMemoryImpl)Context.FindPersistenceObject<Kistl.App.GUI.Icon>(_fk_guid_FalseIcon.Value);
            else
            if (_fk_FalseIcon.HasValue)
                FalseIconImpl = (Kistl.App.GUI.IconMemoryImpl)Context.Find<Kistl.App.GUI.Icon>(_fk_FalseIcon.Value);
            else
                FalseIconImpl = null;

            if (_fk_guid_NullIcon.HasValue)
                NullIconImpl = (Kistl.App.GUI.IconMemoryImpl)Context.FindPersistenceObject<Kistl.App.GUI.Icon>(_fk_guid_NullIcon.Value);
            else
            if (_fk_NullIcon.HasValue)
                NullIconImpl = (Kistl.App.GUI.IconMemoryImpl)Context.Find<Kistl.App.GUI.Icon>(_fk_NullIcon.Value);
            else
                NullIconImpl = null;

            if (_fk_guid_TrueIcon.HasValue)
                TrueIconImpl = (Kistl.App.GUI.IconMemoryImpl)Context.FindPersistenceObject<Kistl.App.GUI.Icon>(_fk_guid_TrueIcon.Value);
            else
            if (_fk_TrueIcon.HasValue)
                TrueIconImpl = (Kistl.App.GUI.IconMemoryImpl)Context.Find<Kistl.App.GUI.Icon>(_fk_TrueIcon.Value);
            else
                TrueIconImpl = null;
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
                    new PropertyDescriptorMemoryImpl<BoolPropertyMemoryImpl, Kistl.App.GUI.Icon>(
                        lazyCtx,
                        new Guid("784846d0-2eea-4966-b63d-72a0f13b418b"),
                        "FalseIcon",
                        null,
                        obj => obj.FalseIcon,
                        (obj, val) => obj.FalseIcon = val),
                    // else
                    new PropertyDescriptorMemoryImpl<BoolPropertyMemoryImpl, string>(
                        lazyCtx,
                        new Guid("09381f52-98e2-4dea-9855-7358e5f9cdae"),
                        "FalseLabel",
                        null,
                        obj => obj.FalseLabel,
                        (obj, val) => obj.FalseLabel = val),
                    // else
                    new PropertyDescriptorMemoryImpl<BoolPropertyMemoryImpl, Kistl.App.GUI.Icon>(
                        lazyCtx,
                        new Guid("62454172-467d-4c8e-8f1a-a959946d3fdb"),
                        "NullIcon",
                        null,
                        obj => obj.NullIcon,
                        (obj, val) => obj.NullIcon = val),
                    // else
                    new PropertyDescriptorMemoryImpl<BoolPropertyMemoryImpl, string>(
                        lazyCtx,
                        new Guid("55fae41e-499d-40e3-b386-9839ec8b1d0a"),
                        "NullLabel",
                        null,
                        obj => obj.NullLabel,
                        (obj, val) => obj.NullLabel = val),
                    // else
                    new PropertyDescriptorMemoryImpl<BoolPropertyMemoryImpl, Kistl.App.GUI.Icon>(
                        lazyCtx,
                        new Guid("bb8fd69f-437a-45d5-a169-64c9586bfc1d"),
                        "TrueIcon",
                        null,
                        obj => obj.TrueIcon,
                        (obj, val) => obj.TrueIcon = val),
                    // else
                    new PropertyDescriptorMemoryImpl<BoolPropertyMemoryImpl, string>(
                        lazyCtx,
                        new Guid("f7da0495-3d3f-48c5-8fba-95a317ca7949"),
                        "TrueLabel",
                        null,
                        obj => obj.TrueLabel,
                        (obj, val) => obj.TrueLabel = val),
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
        [EventBasedMethod("OnToString_BoolProperty")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_BoolProperty != null)
            {
                OnToString_BoolProperty(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<BoolProperty> OnToString_BoolProperty;

        [EventBasedMethod("OnPreSave_BoolProperty")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_BoolProperty != null) OnPreSave_BoolProperty(this);
        }
        public static event ObjectEventHandler<BoolProperty> OnPreSave_BoolProperty;

        [EventBasedMethod("OnPostSave_BoolProperty")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_BoolProperty != null) OnPostSave_BoolProperty(this);
        }
        public static event ObjectEventHandler<BoolProperty> OnPostSave_BoolProperty;

        [EventBasedMethod("OnCreated_BoolProperty")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_BoolProperty != null) OnCreated_BoolProperty(this);
        }
        public static event ObjectEventHandler<BoolProperty> OnCreated_BoolProperty;

        [EventBasedMethod("OnDeleting_BoolProperty")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_BoolProperty != null) OnDeleting_BoolProperty(this);
        }
        public static event ObjectEventHandler<BoolProperty> OnDeleting_BoolProperty;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(FalseIcon != null ? FalseIcon.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._FalseLabel, binStream);
            BinarySerializer.ToStream(NullIcon != null ? NullIcon.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._NullLabel, binStream);
            BinarySerializer.ToStream(TrueIcon != null ? TrueIcon.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._TrueLabel, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._fk_FalseIcon, binStream);
            BinarySerializer.FromStream(out this._FalseLabel, binStream);
            BinarySerializer.FromStream(out this._fk_NullIcon, binStream);
            BinarySerializer.FromStream(out this._NullLabel, binStream);
            BinarySerializer.FromStream(out this._fk_TrueIcon, binStream);
            BinarySerializer.FromStream(out this._TrueLabel, binStream);
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
            XmlStreamer.ToStream(FalseIcon != null ? FalseIcon.ID : (int?)null, xml, "FalseIcon", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._FalseLabel, xml, "FalseLabel", "Kistl.App.Base");
            XmlStreamer.ToStream(NullIcon != null ? NullIcon.ID : (int?)null, xml, "NullIcon", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._NullLabel, xml, "NullLabel", "Kistl.App.Base");
            XmlStreamer.ToStream(TrueIcon != null ? TrueIcon.ID : (int?)null, xml, "TrueIcon", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._TrueLabel, xml, "TrueLabel", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._fk_FalseIcon, xml, "FalseIcon", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._FalseLabel, xml, "FalseLabel", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_NullIcon, xml, "NullIcon", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._NullLabel, xml, "NullLabel", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_TrueIcon, xml, "TrueIcon", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._TrueLabel, xml, "TrueLabel", "Kistl.App.Base");
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(FalseIcon != null ? FalseIcon.ExportGuid : (Guid?)null, xml, "FalseIcon", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._FalseLabel, xml, "FalseLabel", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(NullIcon != null ? NullIcon.ExportGuid : (Guid?)null, xml, "NullIcon", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._NullLabel, xml, "NullLabel", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(TrueIcon != null ? TrueIcon.ExportGuid : (Guid?)null, xml, "TrueIcon", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._TrueLabel, xml, "TrueLabel", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.FromStream(ref this._fk_guid_FalseIcon, xml, "FalseIcon", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._FalseLabel, xml, "FalseLabel", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_NullIcon, xml, "NullIcon", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._NullLabel, xml, "NullLabel", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_TrueIcon, xml, "TrueIcon", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._TrueLabel, xml, "TrueLabel", "Kistl.App.Base");
        }

        #endregion

    }
}