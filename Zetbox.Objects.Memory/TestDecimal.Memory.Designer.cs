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
    /// Testclass for Decimal DataType
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("TestDecimal")]
    public class TestDecimalMemoryImpl : Zetbox.DalProvider.Memory.DataObjectMemoryImpl, TestDecimal
    {
        private static readonly Guid _objectClassID = new Guid("9a352669-42c1-4384-b2d3-6de6d198938e");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public TestDecimalMemoryImpl()
            : base(null)
        {
        }

        public TestDecimalMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public decimal? Large
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Large;
                if (OnLarge_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<decimal?>(__result);
                    OnLarge_Getter(this, __e);
                    __result = _Large = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Large != value)
                {
                    var __oldValue = _Large;
                    var __newValue = value;
                    if (OnLarge_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<decimal?>(__oldValue, __newValue);
                        OnLarge_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Large", __oldValue, __newValue);
                    _Large = __newValue;
                    NotifyPropertyChanged("Large", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnLarge_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<decimal?>(__oldValue, __newValue);
                        OnLarge_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Large");
				}
            }
        }
        private decimal? _Large;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.TestDecimal, decimal?> OnLarge_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TestDecimal, decimal?> OnLarge_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TestDecimal, decimal?> OnLarge_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.TestDecimal> OnLarge_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public decimal? NoScale
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _NoScale;
                if (OnNoScale_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<decimal?>(__result);
                    OnNoScale_Getter(this, __e);
                    __result = _NoScale = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_NoScale != value)
                {
                    var __oldValue = _NoScale;
                    var __newValue = value;
                    if (OnNoScale_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<decimal?>(__oldValue, __newValue);
                        OnNoScale_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("NoScale", __oldValue, __newValue);
                    _NoScale = __newValue;
                    NotifyPropertyChanged("NoScale", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnNoScale_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<decimal?>(__oldValue, __newValue);
                        OnNoScale_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("NoScale");
				}
            }
        }
        private decimal? _NoScale;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.TestDecimal, decimal?> OnNoScale_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TestDecimal, decimal?> OnNoScale_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TestDecimal, decimal?> OnNoScale_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.TestDecimal> OnNoScale_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public decimal? SmallDecimal
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _SmallDecimal;
                if (OnSmallDecimal_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<decimal?>(__result);
                    OnSmallDecimal_Getter(this, __e);
                    __result = _SmallDecimal = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_SmallDecimal != value)
                {
                    var __oldValue = _SmallDecimal;
                    var __newValue = value;
                    if (OnSmallDecimal_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<decimal?>(__oldValue, __newValue);
                        OnSmallDecimal_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("SmallDecimal", __oldValue, __newValue);
                    _SmallDecimal = __newValue;
                    NotifyPropertyChanged("SmallDecimal", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnSmallDecimal_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<decimal?>(__oldValue, __newValue);
                        OnSmallDecimal_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("SmallDecimal");
				}
            }
        }
        private decimal? _SmallDecimal;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.TestDecimal, decimal?> OnSmallDecimal_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TestDecimal, decimal?> OnSmallDecimal_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TestDecimal, decimal?> OnSmallDecimal_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.TestDecimal> OnSmallDecimal_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(TestDecimal);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (TestDecimal)obj;
            var otherImpl = (TestDecimalMemoryImpl)obj;
            var me = (TestDecimal)this;

            me.Large = other.Large;
            me.NoScale = other.NoScale;
            me.SmallDecimal = other.SmallDecimal;
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
                case "Large":
                case "NoScale":
                case "SmallDecimal":
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
                    new PropertyDescriptorMemoryImpl<TestDecimal, decimal?>(
                        lazyCtx,
                        new Guid("14a1eeb9-26b1-4913-bae1-228edfd1c9de"),
                        "Large",
                        null,
                        obj => obj.Large,
                        (obj, val) => obj.Large = val,
						obj => OnLarge_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<TestDecimal, decimal?>(
                        lazyCtx,
                        new Guid("dbad0130-bfb8-4475-afb8-e26f1124395b"),
                        "NoScale",
                        null,
                        obj => obj.NoScale,
                        (obj, val) => obj.NoScale = val,
						obj => OnNoScale_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<TestDecimal, decimal?>(
                        lazyCtx,
                        new Guid("734795e4-4e0f-4175-b153-e465acafd609"),
                        "SmallDecimal",
                        null,
                        obj => obj.SmallDecimal,
                        (obj, val) => obj.SmallDecimal = val,
						obj => OnSmallDecimal_IsValid), 
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
        [EventBasedMethod("OnToString_TestDecimal")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_TestDecimal != null)
            {
                OnToString_TestDecimal(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<TestDecimal> OnToString_TestDecimal;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_TestDecimal")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_TestDecimal != null)
            {
                OnObjectIsValid_TestDecimal(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<TestDecimal> OnObjectIsValid_TestDecimal;

        [EventBasedMethod("OnNotifyPreSave_TestDecimal")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_TestDecimal != null) OnNotifyPreSave_TestDecimal(this);
        }
        public static event ObjectEventHandler<TestDecimal> OnNotifyPreSave_TestDecimal;

        [EventBasedMethod("OnNotifyPostSave_TestDecimal")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_TestDecimal != null) OnNotifyPostSave_TestDecimal(this);
        }
        public static event ObjectEventHandler<TestDecimal> OnNotifyPostSave_TestDecimal;

        [EventBasedMethod("OnNotifyCreated_TestDecimal")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Large");
            SetNotInitializedProperty("NoScale");
            SetNotInitializedProperty("SmallDecimal");
            base.NotifyCreated();
            if (OnNotifyCreated_TestDecimal != null) OnNotifyCreated_TestDecimal(this);
        }
        public static event ObjectEventHandler<TestDecimal> OnNotifyCreated_TestDecimal;

        [EventBasedMethod("OnNotifyDeleting_TestDecimal")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_TestDecimal != null) OnNotifyDeleting_TestDecimal(this);
        }
        public static event ObjectEventHandler<TestDecimal> OnNotifyDeleting_TestDecimal;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._Large);
            binStream.Write(this._NoScale);
            binStream.Write(this._SmallDecimal);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._Large = binStream.ReadNullableDecimal();
            this._NoScale = binStream.ReadNullableDecimal();
            this._SmallDecimal = binStream.ReadNullableDecimal();
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