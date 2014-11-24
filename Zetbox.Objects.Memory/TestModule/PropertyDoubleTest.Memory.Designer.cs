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
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("PropertyDoubleTest")]
    public class PropertyDoubleTestMemoryImpl : Zetbox.App.Test.PropertyTestBaseMemoryImpl, PropertyDoubleTest
    {
        private static readonly Guid _objectClassID = new Guid("fad3a1cb-80bf-4c13-abcf-489b67493818");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public PropertyDoubleTestMemoryImpl()
            : base(null)
        {
        }

        public PropertyDoubleTestMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public double? Nullable
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Nullable;
                if (OnNullable_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<double?>(__result);
                    OnNullable_Getter(this, __e);
                    __result = _Nullable = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Nullable != value)
                {
                    var __oldValue = _Nullable;
                    var __newValue = value;
                    if (OnNullable_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<double?>(__oldValue, __newValue);
                        OnNullable_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Nullable", __oldValue, __newValue);
                    _Nullable = __newValue;
                    NotifyPropertyChanged("Nullable", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnNullable_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<double?>(__oldValue, __newValue);
                        OnNullable_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("Nullable");
                }
            }
        }
        private double? _Nullable;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.PropertyDoubleTest, double?> OnNullable_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.PropertyDoubleTest, double?> OnNullable_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.PropertyDoubleTest, double?> OnNullable_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.PropertyDoubleTest> OnNullable_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public double? NullableWithDefault
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _NullableWithDefault;
                if (!_isNullableWithDefaultSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("948713cd-e37b-49bc-b798-40c75bb88ad3"));
                    if (__p != null) {
                        _isNullableWithDefaultSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                            if (__tmp_value == null)
                                __result = this._NullableWithDefault = null;
                            else
                            __result = this._NullableWithDefault = (double)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'PropertyDoubleTest.NullableWithDefault'");
                    }
                }
                if (OnNullableWithDefault_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<double?>(__result);
                    OnNullableWithDefault_Getter(this, __e);
                    __result = _NullableWithDefault = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isNullableWithDefaultSet = true;
                if (_NullableWithDefault != value)
                {
                    var __oldValue = _NullableWithDefault;
                    var __newValue = value;
                    if (OnNullableWithDefault_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<double?>(__oldValue, __newValue);
                        OnNullableWithDefault_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("NullableWithDefault", __oldValue, __newValue);
                    _NullableWithDefault = __newValue;
                    NotifyPropertyChanged("NullableWithDefault", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnNullableWithDefault_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<double?>(__oldValue, __newValue);
                        OnNullableWithDefault_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("NullableWithDefault");
                }
            }
        }
        private double? _NullableWithDefault;
        private bool _isNullableWithDefaultSet = false;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.PropertyDoubleTest, double?> OnNullableWithDefault_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.PropertyDoubleTest, double?> OnNullableWithDefault_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.PropertyDoubleTest, double?> OnNullableWithDefault_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.PropertyDoubleTest> OnNullableWithDefault_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public double Standard
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Standard;
                if (OnStandard_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<double>(__result);
                    OnStandard_Getter(this, __e);
                    __result = _Standard = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Standard != value)
                {
                    var __oldValue = _Standard;
                    var __newValue = value;
                    if (OnStandard_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<double>(__oldValue, __newValue);
                        OnStandard_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Standard", __oldValue, __newValue);
                    _Standard = __newValue;
                    NotifyPropertyChanged("Standard", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnStandard_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<double>(__oldValue, __newValue);
                        OnStandard_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("Standard");
                }
            }
        }
        private double _Standard;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.PropertyDoubleTest, double> OnStandard_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.PropertyDoubleTest, double> OnStandard_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.PropertyDoubleTest, double> OnStandard_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.PropertyDoubleTest> OnStandard_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public double StandardWithDefault
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _StandardWithDefault;
                if (!_isStandardWithDefaultSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("fea98a15-11a2-46f6-a270-2522d24fe73c"));
                    if (__p != null) {
                        _isStandardWithDefaultSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._StandardWithDefault = (double)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'PropertyDoubleTest.StandardWithDefault'");
                    }
                }
                if (OnStandardWithDefault_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<double>(__result);
                    OnStandardWithDefault_Getter(this, __e);
                    __result = _StandardWithDefault = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isStandardWithDefaultSet = true;
                if (_StandardWithDefault != value)
                {
                    var __oldValue = _StandardWithDefault;
                    var __newValue = value;
                    if (OnStandardWithDefault_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<double>(__oldValue, __newValue);
                        OnStandardWithDefault_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("StandardWithDefault", __oldValue, __newValue);
                    _StandardWithDefault = __newValue;
                    NotifyPropertyChanged("StandardWithDefault", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnStandardWithDefault_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<double>(__oldValue, __newValue);
                        OnStandardWithDefault_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("StandardWithDefault");
                }
            }
        }
        private double _StandardWithDefault;
        private bool _isStandardWithDefaultSet = false;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.PropertyDoubleTest, double> OnStandardWithDefault_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.PropertyDoubleTest, double> OnStandardWithDefault_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.PropertyDoubleTest, double> OnStandardWithDefault_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.PropertyDoubleTest> OnStandardWithDefault_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(PropertyDoubleTest);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (PropertyDoubleTest)obj;
            var otherImpl = (PropertyDoubleTestMemoryImpl)obj;
            var me = (PropertyDoubleTest)this;

            me.Nullable = other.Nullable;
            me.NullableWithDefault = other.NullableWithDefault;
            me.Standard = other.Standard;
            me.StandardWithDefault = other.StandardWithDefault;
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
                case "Nullable":
                case "NullableWithDefault":
                case "Standard":
                case "StandardWithDefault":
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
                    new PropertyDescriptorMemoryImpl<PropertyDoubleTest, double?>(
                        lazyCtx,
                        new Guid("9c522da0-3493-4283-8957-9fd410cf61e9"),
                        "Nullable",
                        null,
                        obj => obj.Nullable,
                        (obj, val) => obj.Nullable = val,
						obj => OnNullable_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<PropertyDoubleTest, double?>(
                        lazyCtx,
                        new Guid("948713cd-e37b-49bc-b798-40c75bb88ad3"),
                        "NullableWithDefault",
                        null,
                        obj => obj.NullableWithDefault,
                        (obj, val) => obj.NullableWithDefault = val,
						obj => OnNullableWithDefault_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<PropertyDoubleTest, double>(
                        lazyCtx,
                        new Guid("9284bbb7-5967-461d-ac65-c5c31daf0518"),
                        "Standard",
                        null,
                        obj => obj.Standard,
                        (obj, val) => obj.Standard = val,
						obj => OnStandard_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<PropertyDoubleTest, double>(
                        lazyCtx,
                        new Guid("fea98a15-11a2-46f6-a270-2522d24fe73c"),
                        "StandardWithDefault",
                        null,
                        obj => obj.StandardWithDefault,
                        (obj, val) => obj.StandardWithDefault = val,
						obj => OnStandardWithDefault_IsValid), 
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
        [EventBasedMethod("OnToString_PropertyDoubleTest")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_PropertyDoubleTest != null)
            {
                OnToString_PropertyDoubleTest(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<PropertyDoubleTest> OnToString_PropertyDoubleTest;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_PropertyDoubleTest")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_PropertyDoubleTest != null)
            {
                OnObjectIsValid_PropertyDoubleTest(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<PropertyDoubleTest> OnObjectIsValid_PropertyDoubleTest;

        [EventBasedMethod("OnNotifyPreSave_PropertyDoubleTest")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_PropertyDoubleTest != null) OnNotifyPreSave_PropertyDoubleTest(this);
        }
        public static event ObjectEventHandler<PropertyDoubleTest> OnNotifyPreSave_PropertyDoubleTest;

        [EventBasedMethod("OnNotifyPostSave_PropertyDoubleTest")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_PropertyDoubleTest != null) OnNotifyPostSave_PropertyDoubleTest(this);
        }
        public static event ObjectEventHandler<PropertyDoubleTest> OnNotifyPostSave_PropertyDoubleTest;

        [EventBasedMethod("OnNotifyCreated_PropertyDoubleTest")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Nullable");
            SetNotInitializedProperty("Standard");
            base.NotifyCreated();
            if (OnNotifyCreated_PropertyDoubleTest != null) OnNotifyCreated_PropertyDoubleTest(this);
        }
        public static event ObjectEventHandler<PropertyDoubleTest> OnNotifyCreated_PropertyDoubleTest;

        [EventBasedMethod("OnNotifyDeleting_PropertyDoubleTest")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_PropertyDoubleTest != null) OnNotifyDeleting_PropertyDoubleTest(this);
        }
        public static event ObjectEventHandler<PropertyDoubleTest> OnNotifyDeleting_PropertyDoubleTest;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._Nullable);
            binStream.Write(this._isNullableWithDefaultSet);
            if (this._isNullableWithDefaultSet) {
                binStream.Write(this._NullableWithDefault);
            }
            binStream.Write(this._Standard);
            binStream.Write(this._isStandardWithDefaultSet);
            if (this._isStandardWithDefaultSet) {
                binStream.Write(this._StandardWithDefault);
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._Nullable = binStream.ReadNullableDouble();
            this._isNullableWithDefaultSet = binStream.ReadBoolean();
            if (this._isNullableWithDefaultSet) {
                this._NullableWithDefault = binStream.ReadNullableDouble();
            }
            this._Standard = binStream.ReadDouble();
            this._isStandardWithDefaultSet = binStream.ReadBoolean();
            if (this._isStandardWithDefaultSet) {
                this._StandardWithDefault = binStream.ReadDouble();
            }
            } // if (CurrentAccessRights != Zetbox.API.AccessRights.None)
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        #endregion

    }
}