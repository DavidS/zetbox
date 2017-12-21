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
    /// Metadefinition Object for ValueType Properties. This class is abstract.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("ValueTypeProperty")]
    public abstract class ValueTypePropertyMemoryImpl : Zetbox.App.Base.PropertyMemoryImpl, ValueTypeProperty
    {
        private static readonly Guid _objectClassID = new Guid("b0c23c07-950f-47a0-af23-a925dc691b3e");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public ValueTypePropertyMemoryImpl()
            : base(null)
        {
        }

        public ValueTypePropertyMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// Whether or not a list-valued property has a index
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public bool HasPersistentOrder
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _HasPersistentOrder;
                if (!_isHasPersistentOrderSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("b62c7fee-bb67-46a6-b481-81554e788aa0"));
                    if (__p != null) {
                        _isHasPersistentOrderSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._HasPersistentOrder = (bool)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'ValueTypeProperty.HasPersistentOrder'");
                    }
                }
                if (OnHasPersistentOrder_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnHasPersistentOrder_Getter(this, __e);
                    __result = _HasPersistentOrder = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isHasPersistentOrderSet = true;
                if (_HasPersistentOrder != value)
                {
                    var __oldValue = _HasPersistentOrder;
                    var __newValue = value;
                    if (OnHasPersistentOrder_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnHasPersistentOrder_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("HasPersistentOrder", __oldValue, __newValue);
                    _HasPersistentOrder = __newValue;
                    NotifyPropertyChanged("HasPersistentOrder", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnHasPersistentOrder_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnHasPersistentOrder_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("HasPersistentOrder");
                }
            }
        }
        private bool _HasPersistentOrder;
        private bool _isHasPersistentOrderSet = false;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.ValueTypeProperty, bool> OnHasPersistentOrder_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.ValueTypeProperty, bool> OnHasPersistentOrder_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.ValueTypeProperty, bool> OnHasPersistentOrder_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.ValueTypeProperty> OnHasPersistentOrder_IsValid;

        /// <summary>
        /// If true, a property getter will be invoked to get the properties value. No Backingstore is generated, thus there is no setter.
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public bool IsCalculated
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _IsCalculated;
                if (!_isIsCalculatedSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("2eed845e-887d-4230-8410-0b442ba7724b"));
                    if (__p != null) {
                        _isIsCalculatedSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._IsCalculated = (bool)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'ValueTypeProperty.IsCalculated'");
                    }
                }
                if (OnIsCalculated_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnIsCalculated_Getter(this, __e);
                    __result = _IsCalculated = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isIsCalculatedSet = true;
                if (_IsCalculated != value)
                {
                    var __oldValue = _IsCalculated;
                    var __newValue = value;
                    if (OnIsCalculated_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsCalculated_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IsCalculated", __oldValue, __newValue);
                    _IsCalculated = __newValue;
                    NotifyPropertyChanged("IsCalculated", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnIsCalculated_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsCalculated_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("IsCalculated");
                }
            }
        }
        private bool _IsCalculated;
        private bool _isIsCalculatedSet = false;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.ValueTypeProperty, bool> OnIsCalculated_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.ValueTypeProperty, bool> OnIsCalculated_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.ValueTypeProperty, bool> OnIsCalculated_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.ValueTypeProperty> OnIsCalculated_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public bool IsList
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _IsList;
                if (!_isIsListSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("b2bd1528-c22f-4e12-b80f-f8234a2c0831"));
                    if (__p != null) {
                        _isIsListSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._IsList = (bool)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'ValueTypeProperty.IsList'");
                    }
                }
                if (OnIsList_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnIsList_Getter(this, __e);
                    __result = _IsList = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isIsListSet = true;
                if (_IsList != value)
                {
                    var __oldValue = _IsList;
                    var __newValue = value;
                    if (OnIsList_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsList_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IsList", __oldValue, __newValue);
                    _IsList = __newValue;
                    NotifyPropertyChanged("IsList", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnIsList_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsList_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("IsList");
                }
            }
        }
        private bool _IsList;
        private bool _isIsListSet = false;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.ValueTypeProperty, bool> OnIsList_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.ValueTypeProperty, bool> OnIsList_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.ValueTypeProperty, bool> OnIsList_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.ValueTypeProperty> OnIsList_IsValid;

        /// <summary>
        /// Returns the translated description
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDescription_ValueTypeProperty")]
        public override string GetDescription()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetDescription_ValueTypeProperty != null)
            {
                OnGetDescription_ValueTypeProperty(this, e);
            }
            else
            {
                e.Result = base.GetDescription();
            }
            return e.Result;
        }
        public static event GetDescription_Handler<ValueTypeProperty> OnGetDescription_ValueTypeProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ValueTypeProperty> OnGetDescription_ValueTypeProperty_CanExec;

        [EventBasedMethod("OnGetDescription_ValueTypeProperty_CanExec")]
        public override bool GetDescriptionCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetDescription_ValueTypeProperty_CanExec != null)
				{
					OnGetDescription_ValueTypeProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetDescriptionCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ValueTypeProperty> OnGetDescription_ValueTypeProperty_CanExecReason;

        [EventBasedMethod("OnGetDescription_ValueTypeProperty_CanExecReason")]
        public override string GetDescriptionCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetDescription_ValueTypeProperty_CanExecReason != null)
				{
					OnGetDescription_ValueTypeProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetDescriptionCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// The element type for multi-valued properties. The property type string in all other cases.
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetElementTypeString_ValueTypeProperty")]
        public override string GetElementTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetElementTypeString_ValueTypeProperty != null)
            {
                OnGetElementTypeString_ValueTypeProperty(this, e);
            }
            else
            {
                e.Result = base.GetElementTypeString();
            }
            return e.Result;
        }
        public static event GetElementTypeString_Handler<ValueTypeProperty> OnGetElementTypeString_ValueTypeProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ValueTypeProperty> OnGetElementTypeString_ValueTypeProperty_CanExec;

        [EventBasedMethod("OnGetElementTypeString_ValueTypeProperty_CanExec")]
        public override bool GetElementTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetElementTypeString_ValueTypeProperty_CanExec != null)
				{
					OnGetElementTypeString_ValueTypeProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetElementTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ValueTypeProperty> OnGetElementTypeString_ValueTypeProperty_CanExecReason;

        [EventBasedMethod("OnGetElementTypeString_ValueTypeProperty_CanExecReason")]
        public override string GetElementTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetElementTypeString_ValueTypeProperty_CanExecReason != null)
				{
					OnGetElementTypeString_ValueTypeProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetElementTypeStringCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_ValueTypeProperty")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_ValueTypeProperty != null)
            {
                OnGetLabel_ValueTypeProperty(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<ValueTypeProperty> OnGetLabel_ValueTypeProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ValueTypeProperty> OnGetLabel_ValueTypeProperty_CanExec;

        [EventBasedMethod("OnGetLabel_ValueTypeProperty_CanExec")]
        public override bool GetLabelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabel_ValueTypeProperty_CanExec != null)
				{
					OnGetLabel_ValueTypeProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ValueTypeProperty> OnGetLabel_ValueTypeProperty_CanExecReason;

        [EventBasedMethod("OnGetLabel_ValueTypeProperty_CanExecReason")]
        public override string GetLabelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabel_ValueTypeProperty_CanExecReason != null)
				{
					OnGetLabel_ValueTypeProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetName_ValueTypeProperty")]
        public override string GetName()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetName_ValueTypeProperty != null)
            {
                OnGetName_ValueTypeProperty(this, e);
            }
            else
            {
                e.Result = base.GetName();
            }
            return e.Result;
        }
        public static event GetName_Handler<ValueTypeProperty> OnGetName_ValueTypeProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ValueTypeProperty> OnGetName_ValueTypeProperty_CanExec;

        [EventBasedMethod("OnGetName_ValueTypeProperty_CanExec")]
        public override bool GetNameCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetName_ValueTypeProperty_CanExec != null)
				{
					OnGetName_ValueTypeProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetNameCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ValueTypeProperty> OnGetName_ValueTypeProperty_CanExecReason;

        [EventBasedMethod("OnGetName_ValueTypeProperty_CanExecReason")]
        public override string GetNameCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetName_ValueTypeProperty_CanExecReason != null)
				{
					OnGetName_ValueTypeProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetNameCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetPropertyType_ValueTypeProperty")]
        public override System.Type GetPropertyType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_ValueTypeProperty != null)
            {
                OnGetPropertyType_ValueTypeProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
        public static event GetPropertyType_Handler<ValueTypeProperty> OnGetPropertyType_ValueTypeProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ValueTypeProperty> OnGetPropertyType_ValueTypeProperty_CanExec;

        [EventBasedMethod("OnGetPropertyType_ValueTypeProperty_CanExec")]
        public override bool GetPropertyTypeCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetPropertyType_ValueTypeProperty_CanExec != null)
				{
					OnGetPropertyType_ValueTypeProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ValueTypeProperty> OnGetPropertyType_ValueTypeProperty_CanExecReason;

        [EventBasedMethod("OnGetPropertyType_ValueTypeProperty_CanExecReason")]
        public override string GetPropertyTypeCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetPropertyType_ValueTypeProperty_CanExecReason != null)
				{
					OnGetPropertyType_ValueTypeProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetPropertyTypeString_ValueTypeProperty")]
        public override string GetPropertyTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_ValueTypeProperty != null)
            {
                OnGetPropertyTypeString_ValueTypeProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
        public static event GetPropertyTypeString_Handler<ValueTypeProperty> OnGetPropertyTypeString_ValueTypeProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ValueTypeProperty> OnGetPropertyTypeString_ValueTypeProperty_CanExec;

        [EventBasedMethod("OnGetPropertyTypeString_ValueTypeProperty_CanExec")]
        public override bool GetPropertyTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetPropertyTypeString_ValueTypeProperty_CanExec != null)
				{
					OnGetPropertyTypeString_ValueTypeProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ValueTypeProperty> OnGetPropertyTypeString_ValueTypeProperty_CanExecReason;

        [EventBasedMethod("OnGetPropertyTypeString_ValueTypeProperty_CanExecReason")]
        public override string GetPropertyTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetPropertyTypeString_ValueTypeProperty_CanExecReason != null)
				{
					OnGetPropertyTypeString_ValueTypeProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeStringCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(ValueTypeProperty);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (ValueTypeProperty)obj;
            var otherImpl = (ValueTypePropertyMemoryImpl)obj;
            var me = (ValueTypeProperty)this;

            me.HasPersistentOrder = other.HasPersistentOrder;
            me.IsCalculated = other.IsCalculated;
            me.IsList = other.IsList;
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        #region Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "HasPersistentOrder":
                case "IsCalculated":
                case "IsList":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }
        #endregion // Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        public override Zetbox.API.Async.ZbTask TriggerFetch(string propName)
        {
            switch(propName)
            {
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
                    new PropertyDescriptorMemoryImpl<ValueTypeProperty, bool>(
                        lazyCtx,
                        new Guid("b62c7fee-bb67-46a6-b481-81554e788aa0"),
                        "HasPersistentOrder",
                        null,
                        obj => obj.HasPersistentOrder,
                        (obj, val) => obj.HasPersistentOrder = val,
						obj => OnHasPersistentOrder_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<ValueTypeProperty, bool>(
                        lazyCtx,
                        new Guid("2eed845e-887d-4230-8410-0b442ba7724b"),
                        "IsCalculated",
                        null,
                        obj => obj.IsCalculated,
                        (obj, val) => obj.IsCalculated = val,
						obj => OnIsCalculated_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<ValueTypeProperty, bool>(
                        lazyCtx,
                        new Guid("b2bd1528-c22f-4e12-b80f-f8234a2c0831"),
                        "IsList",
                        null,
                        obj => obj.IsList,
                        (obj, val) => obj.IsList = val,
						obj => OnIsList_IsValid), 
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
        [EventBasedMethod("OnToString_ValueTypeProperty")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ValueTypeProperty != null)
            {
                OnToString_ValueTypeProperty(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<ValueTypeProperty> OnToString_ValueTypeProperty;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_ValueTypeProperty")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_ValueTypeProperty != null)
            {
                OnObjectIsValid_ValueTypeProperty(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<ValueTypeProperty> OnObjectIsValid_ValueTypeProperty;

        [EventBasedMethod("OnNotifyPreSave_ValueTypeProperty")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_ValueTypeProperty != null) OnNotifyPreSave_ValueTypeProperty(this);
        }
        public static event ObjectEventHandler<ValueTypeProperty> OnNotifyPreSave_ValueTypeProperty;

        [EventBasedMethod("OnNotifyPostSave_ValueTypeProperty")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_ValueTypeProperty != null) OnNotifyPostSave_ValueTypeProperty(this);
        }
        public static event ObjectEventHandler<ValueTypeProperty> OnNotifyPostSave_ValueTypeProperty;

        [EventBasedMethod("OnNotifyCreated_ValueTypeProperty")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_ValueTypeProperty != null) OnNotifyCreated_ValueTypeProperty(this);
        }
        public static event ObjectEventHandler<ValueTypeProperty> OnNotifyCreated_ValueTypeProperty;

        [EventBasedMethod("OnNotifyDeleting_ValueTypeProperty")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_ValueTypeProperty != null) OnNotifyDeleting_ValueTypeProperty(this);
        }
        public static event ObjectEventHandler<ValueTypeProperty> OnNotifyDeleting_ValueTypeProperty;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._isHasPersistentOrderSet);
            if (this._isHasPersistentOrderSet) {
                binStream.Write(this._HasPersistentOrder);
            }
            binStream.Write(this._isIsCalculatedSet);
            if (this._isIsCalculatedSet) {
                binStream.Write(this._IsCalculated);
            }
            binStream.Write(this._isIsListSet);
            if (this._isIsListSet) {
                binStream.Write(this._IsList);
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._isHasPersistentOrderSet = binStream.ReadBoolean();
            if (this._isHasPersistentOrderSet) {
                this._HasPersistentOrder = binStream.ReadBoolean();
            }
            this._isIsCalculatedSet = binStream.ReadBoolean();
            if (this._isIsCalculatedSet) {
                this._IsCalculated = binStream.ReadBoolean();
            }
            this._isIsListSet = binStream.ReadBoolean();
            if (this._isIsListSet) {
                this._IsList = binStream.ReadBoolean();
            }
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
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this._HasPersistentOrder, xml, "HasPersistentOrder", "Zetbox.App.Base");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this._IsCalculated, xml, "IsCalculated", "Zetbox.App.Base");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this._IsList, xml, "IsList", "Zetbox.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Base|HasPersistentOrder":
                // Import must have default value set
                this._HasPersistentOrder = XmlStreamer.ReadBoolean(xml);
                this._isHasPersistentOrderSet = true;
                break;
            case "Zetbox.App.Base|IsCalculated":
                // Import must have default value set
                this._IsCalculated = XmlStreamer.ReadBoolean(xml);
                this._isIsCalculatedSet = true;
                break;
            case "Zetbox.App.Base|IsList":
                // Import must have default value set
                this._IsList = XmlStreamer.ReadBoolean(xml);
                this._isIsListSet = true;
                break;
            }
        }

        #endregion

    }
}