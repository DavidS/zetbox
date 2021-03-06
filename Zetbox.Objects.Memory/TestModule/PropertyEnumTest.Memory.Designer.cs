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
    [System.Diagnostics.DebuggerDisplay("PropertyEnumTest")]
    public class PropertyEnumTestMemoryImpl : Zetbox.App.Test.PropertyTestBaseMemoryImpl, PropertyEnumTest
    {
        private static readonly Guid _objectClassID = new Guid("253dfd7e-18f7-423e-bae1-ad8776b76f30");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public PropertyEnumTestMemoryImpl()
            : base(null)
        {
        }

        public PropertyEnumTestMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // enumeration property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public Zetbox.App.Test.TestEnum? Nullable
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Nullable;
                if (OnNullable_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<Zetbox.App.Test.TestEnum?>(__result);
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
                        var __e = new PropertyPreSetterEventArgs<Zetbox.App.Test.TestEnum?>(__oldValue, __newValue);
                        OnNullable_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Nullable", __oldValue, __newValue);
                    _Nullable = __newValue;
                    NotifyPropertyChanged("Nullable", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnNullable_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<Zetbox.App.Test.TestEnum?>(__oldValue, __newValue);
                        OnNullable_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("Nullable");
                }
            }
        }
        private Zetbox.App.Test.TestEnum? _Nullable;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.PropertyEnumTest, Zetbox.App.Test.TestEnum?> OnNullable_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.PropertyEnumTest, Zetbox.App.Test.TestEnum?> OnNullable_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.PropertyEnumTest, Zetbox.App.Test.TestEnum?> OnNullable_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.PropertyEnumTest> OnNullable_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // enumeration property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public Zetbox.App.Test.TestEnum? NullableWithDefault
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _NullableWithDefault;
                if (!_isNullableWithDefaultSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("813bed50-e879-4a9d-8baa-677a503a1d42"));
                    if (__p != null) {
                        _isNullableWithDefaultSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                            if (__tmp_value == null)
                                __result = this._NullableWithDefault = null;
                            else
                            __result = this._NullableWithDefault = (Zetbox.App.Test.TestEnum)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'PropertyEnumTest.NullableWithDefault'");
                    }
                }
                if (OnNullableWithDefault_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<Zetbox.App.Test.TestEnum?>(__result);
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
                        var __e = new PropertyPreSetterEventArgs<Zetbox.App.Test.TestEnum?>(__oldValue, __newValue);
                        OnNullableWithDefault_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("NullableWithDefault", __oldValue, __newValue);
                    _NullableWithDefault = __newValue;
                    NotifyPropertyChanged("NullableWithDefault", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnNullableWithDefault_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<Zetbox.App.Test.TestEnum?>(__oldValue, __newValue);
                        OnNullableWithDefault_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("NullableWithDefault");
                }
            }
        }
        private Zetbox.App.Test.TestEnum? _NullableWithDefault;
        private bool _isNullableWithDefaultSet = false;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.PropertyEnumTest, Zetbox.App.Test.TestEnum?> OnNullableWithDefault_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.PropertyEnumTest, Zetbox.App.Test.TestEnum?> OnNullableWithDefault_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.PropertyEnumTest, Zetbox.App.Test.TestEnum?> OnNullableWithDefault_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.PropertyEnumTest> OnNullableWithDefault_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // enumeration property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public Zetbox.App.Test.TestEnum Standard
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Standard;
                if (OnStandard_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<Zetbox.App.Test.TestEnum>(__result);
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
                        var __e = new PropertyPreSetterEventArgs<Zetbox.App.Test.TestEnum>(__oldValue, __newValue);
                        OnStandard_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Standard", __oldValue, __newValue);
                    _Standard = __newValue;
                    NotifyPropertyChanged("Standard", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnStandard_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<Zetbox.App.Test.TestEnum>(__oldValue, __newValue);
                        OnStandard_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("Standard");
                }
            }
        }
        private Zetbox.App.Test.TestEnum _Standard;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.PropertyEnumTest, Zetbox.App.Test.TestEnum> OnStandard_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.PropertyEnumTest, Zetbox.App.Test.TestEnum> OnStandard_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.PropertyEnumTest, Zetbox.App.Test.TestEnum> OnStandard_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.PropertyEnumTest> OnStandard_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // enumeration property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public Zetbox.App.Test.TestEnum StandardWithDefault
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _StandardWithDefault;
                if (!_isStandardWithDefaultSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("b2af71e1-a115-42c9-98ac-6e277afa8c24"));
                    if (__p != null) {
                        _isStandardWithDefaultSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._StandardWithDefault = (Zetbox.App.Test.TestEnum)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'PropertyEnumTest.StandardWithDefault'");
                    }
                }
                if (OnStandardWithDefault_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<Zetbox.App.Test.TestEnum>(__result);
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
                        var __e = new PropertyPreSetterEventArgs<Zetbox.App.Test.TestEnum>(__oldValue, __newValue);
                        OnStandardWithDefault_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("StandardWithDefault", __oldValue, __newValue);
                    _StandardWithDefault = __newValue;
                    NotifyPropertyChanged("StandardWithDefault", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnStandardWithDefault_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<Zetbox.App.Test.TestEnum>(__oldValue, __newValue);
                        OnStandardWithDefault_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("StandardWithDefault");
                }
            }
        }
        private Zetbox.App.Test.TestEnum _StandardWithDefault;
        private bool _isStandardWithDefaultSet = false;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.PropertyEnumTest, Zetbox.App.Test.TestEnum> OnStandardWithDefault_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.PropertyEnumTest, Zetbox.App.Test.TestEnum> OnStandardWithDefault_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.PropertyEnumTest, Zetbox.App.Test.TestEnum> OnStandardWithDefault_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.PropertyEnumTest> OnStandardWithDefault_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(PropertyEnumTest);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (PropertyEnumTest)obj;
            var otherImpl = (PropertyEnumTestMemoryImpl)obj;
            var me = (PropertyEnumTest)this;

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
                    new PropertyDescriptorMemoryImpl<PropertyEnumTest, Zetbox.App.Test.TestEnum?>(
                        lazyCtx,
                        new Guid("32836d4c-d488-4013-a74f-ac3c154658b8"),
                        "Nullable",
                        null,
                        obj => obj.Nullable,
                        (obj, val) => obj.Nullable = val,
						obj => OnNullable_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<PropertyEnumTest, Zetbox.App.Test.TestEnum?>(
                        lazyCtx,
                        new Guid("813bed50-e879-4a9d-8baa-677a503a1d42"),
                        "NullableWithDefault",
                        null,
                        obj => obj.NullableWithDefault,
                        (obj, val) => obj.NullableWithDefault = val,
						obj => OnNullableWithDefault_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<PropertyEnumTest, Zetbox.App.Test.TestEnum>(
                        lazyCtx,
                        new Guid("3db32732-17d8-4851-84dd-3e03cff00a95"),
                        "Standard",
                        null,
                        obj => obj.Standard,
                        (obj, val) => obj.Standard = val,
						obj => OnStandard_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<PropertyEnumTest, Zetbox.App.Test.TestEnum>(
                        lazyCtx,
                        new Guid("b2af71e1-a115-42c9-98ac-6e277afa8c24"),
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
        [EventBasedMethod("OnToString_PropertyEnumTest")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_PropertyEnumTest != null)
            {
                OnToString_PropertyEnumTest(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<PropertyEnumTest> OnToString_PropertyEnumTest;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_PropertyEnumTest")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_PropertyEnumTest != null)
            {
                OnObjectIsValid_PropertyEnumTest(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<PropertyEnumTest> OnObjectIsValid_PropertyEnumTest;

        [EventBasedMethod("OnNotifyPreSave_PropertyEnumTest")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_PropertyEnumTest != null) OnNotifyPreSave_PropertyEnumTest(this);
        }
        public static event ObjectEventHandler<PropertyEnumTest> OnNotifyPreSave_PropertyEnumTest;

        [EventBasedMethod("OnNotifyPostSave_PropertyEnumTest")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_PropertyEnumTest != null) OnNotifyPostSave_PropertyEnumTest(this);
        }
        public static event ObjectEventHandler<PropertyEnumTest> OnNotifyPostSave_PropertyEnumTest;

        [EventBasedMethod("OnNotifyCreated_PropertyEnumTest")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Nullable");
            SetNotInitializedProperty("Standard");
            base.NotifyCreated();
            if (OnNotifyCreated_PropertyEnumTest != null) OnNotifyCreated_PropertyEnumTest(this);
        }
        public static event ObjectEventHandler<PropertyEnumTest> OnNotifyCreated_PropertyEnumTest;

        [EventBasedMethod("OnNotifyDeleting_PropertyEnumTest")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_PropertyEnumTest != null) OnNotifyDeleting_PropertyEnumTest(this);
        }
        public static event ObjectEventHandler<PropertyEnumTest> OnNotifyDeleting_PropertyEnumTest;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write((int?)this._Nullable);
            binStream.Write(this._isNullableWithDefaultSet);
            if (this._isNullableWithDefaultSet) {
                binStream.Write((int?)this._NullableWithDefault);
            }
            binStream.Write((int?)this._Standard);
            binStream.Write(this._isStandardWithDefaultSet);
            if (this._isStandardWithDefaultSet) {
                binStream.Write((int?)this._StandardWithDefault);
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._Nullable = (Zetbox.App.Test.TestEnum?)binStream.ReadNullableInt32();
            this._isNullableWithDefaultSet = binStream.ReadBoolean();
            if (this._isNullableWithDefaultSet) {
                this._NullableWithDefault = (Zetbox.App.Test.TestEnum?)binStream.ReadNullableInt32();
            }
            this._Standard = (Zetbox.App.Test.TestEnum)binStream.ReadNullableInt32();
            this._isStandardWithDefaultSet = binStream.ReadBoolean();
            if (this._isStandardWithDefaultSet) {
                this._StandardWithDefault = (Zetbox.App.Test.TestEnum)binStream.ReadNullableInt32();
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