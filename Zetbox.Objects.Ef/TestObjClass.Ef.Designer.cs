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

    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Zetbox.API.Server;
    using Zetbox.DalProvider.Ef;

    /// <summary>
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="TestObjClassEfImpl")]
    [System.Diagnostics.DebuggerDisplay("TestObjClass")]
    public class TestObjClassEfImpl : BaseServerDataObject_EntityFramework, TestObjClass
    {
        private static readonly Guid _objectClassID = new Guid("19f38f05-e88e-44c6-bfdf-d502b3632028");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public TestObjClassEfImpl()
            : base(null)
        {
        }

        public TestObjClassEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// test
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public int? MyIntProperty
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _MyIntProperty;
                if (OnMyIntProperty_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int?>(__result);
                    OnMyIntProperty_Getter(this, __e);
                    __result = _MyIntProperty = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_MyIntProperty != value)
                {
                    var __oldValue = _MyIntProperty;
                    var __newValue = value;
                    if (OnMyIntProperty_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int?>(__oldValue, __newValue);
                        OnMyIntProperty_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("MyIntProperty", __oldValue, __newValue);
                    _MyIntProperty = __newValue;
                    NotifyPropertyChanged("MyIntProperty", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnMyIntProperty_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int?>(__oldValue, __newValue);
                        OnMyIntProperty_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("MyIntProperty");
				}
            }
        }
        private int? _MyIntProperty_store;
        private int? _MyIntProperty {
            get { return _MyIntProperty_store; }
            set {
                ReportEfPropertyChanging("MyIntProperty");
                _MyIntProperty_store = value;
                ReportEfPropertyChanged("MyIntProperty");
            }
        }
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.TestObjClass, int?> OnMyIntProperty_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TestObjClass, int?> OnMyIntProperty_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TestObjClass, int?> OnMyIntProperty_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.TestObjClass> OnMyIntProperty_IsValid;

        /// <summary>
        /// testtest
        /// </summary>
    /*
    Relation: FK_TestObjClass_has_ObjectProp
    A: ZeroOrMore TestObjClass as TestObjClass
    B: ZeroOrOne Kunde as ObjectProp
    Preferred Storage: MergeIntoA
    */
        // object reference property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ObjectProp
        // fkBackingName=_fk_ObjectProp; fkGuidBackingName=_fk_guid_ObjectProp;
        // referencedInterface=Zetbox.App.Projekte.Kunde; moduleNamespace=Zetbox.App.Test;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target not exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Projekte.Kunde ObjectProp
        {
            get { return ObjectPropImpl; }
            set { ObjectPropImpl = (Zetbox.App.Projekte.KundeEfImpl)value; }
        }

        private int? _fk_ObjectProp;


        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_TestObjClass_has_ObjectProp", "ObjectProp")]
        public Zetbox.App.Projekte.KundeEfImpl ObjectPropImpl
        {
            get
            {
                Zetbox.App.Projekte.KundeEfImpl __value;
                EntityReference<Zetbox.App.Projekte.KundeEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.Projekte.KundeEfImpl>(
                        "Model.FK_TestObjClass_has_ObjectProp",
                        "ObjectProp");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                __value = r.Value;
                if (OnObjectProp_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Projekte.Kunde>(__value);
                    OnObjectProp_Getter(this, e);
                    __value = (Zetbox.App.Projekte.KundeEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                EntityReference<Zetbox.App.Projekte.KundeEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.Projekte.KundeEfImpl>(
                        "Model.FK_TestObjClass_has_ObjectProp",
                        "ObjectProp");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Zetbox.App.Projekte.KundeEfImpl __oldValue = (Zetbox.App.Projekte.KundeEfImpl)r.Value;
                Zetbox.App.Projekte.KundeEfImpl __newValue = (Zetbox.App.Projekte.KundeEfImpl)value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("ObjectProp", __oldValue, __newValue);

                if (OnObjectProp_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Projekte.Kunde>(__oldValue, __newValue);
                    OnObjectProp_PreSetter(this, e);
                    __newValue = (Zetbox.App.Projekte.KundeEfImpl)e.Result;
                }

                r.Value = (Zetbox.App.Projekte.KundeEfImpl)__newValue;

                if (OnObjectProp_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Projekte.Kunde>(__oldValue, __newValue);
                    OnObjectProp_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("ObjectProp", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;
            }
        }

        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ObjectProp
		public static event PropertyGetterHandler<Zetbox.App.Test.TestObjClass, Zetbox.App.Projekte.Kunde> OnObjectProp_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TestObjClass, Zetbox.App.Projekte.Kunde> OnObjectProp_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TestObjClass, Zetbox.App.Projekte.Kunde> OnObjectProp_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.TestObjClass> OnObjectProp_IsValid;

        /// <summary>
        /// String Property
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public string StringProp
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _StringProp;
                if (OnStringProp_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnStringProp_Getter(this, __e);
                    __result = _StringProp = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_StringProp != value)
                {
                    var __oldValue = _StringProp;
                    var __newValue = value;
                    if (OnStringProp_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnStringProp_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("StringProp", __oldValue, __newValue);
                    _StringProp = __newValue;
                    NotifyPropertyChanged("StringProp", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnStringProp_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnStringProp_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("StringProp");
				}
            }
        }
        private string _StringProp_store;
        private string _StringProp {
            get { return _StringProp_store; }
            set {
                ReportEfPropertyChanging("StringProp");
                _StringProp_store = value;
                ReportEfPropertyChanged("StringProp");
            }
        }
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.TestObjClass, string> OnStringProp_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TestObjClass, string> OnStringProp_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TestObjClass, string> OnStringProp_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.TestObjClass> OnStringProp_IsValid;

        /// <summary>
        /// Test Enumeration Property
        /// </summary>
        // enumeration property
   		// Zetbox.DalProvider.Ef.Generator.Templates.Properties.EnumerationPropertyTemplate
        // implement the user-visible interface
        public Zetbox.App.Test.TestEnum TestEnumProp
        {
            get
            {
				var __value = _TestEnumProp;
				if(OnTestEnumProp_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Zetbox.App.Test.TestEnum>(__value);
					OnTestEnumProp_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_TestEnumProp != value)
                {
					var __oldValue = _TestEnumProp;
					var __newValue = value;
                    if(OnTestEnumProp_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<Zetbox.App.Test.TestEnum>(__oldValue, __newValue);
						OnTestEnumProp_PreSetter(this, e);
						__newValue = e.Result;
                    }
					
                    NotifyPropertyChanging("TestEnumProp", __oldValue, __newValue);
                    _TestEnumProp = value;
                    NotifyPropertyChanged("TestEnumProp", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;
                    if(OnTestEnumProp_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<Zetbox.App.Test.TestEnum>(__oldValue, __newValue);
						OnTestEnumProp_PostSetter(this, e);
                    }
                    
                }
            }
        }

        private Zetbox.App.Test.TestEnum _TestEnumProp_store;
        private Zetbox.App.Test.TestEnum _TestEnumProp {
            get { return _TestEnumProp_store; }
            set {
                ReportEfPropertyChanging("TestEnumPropImpl");
                _TestEnumProp_store = value;
                ReportEfPropertyChanged("TestEnumPropImpl");
            }
        }
        
        /// <summary>EF sees only this property, for TestEnumProp</summary>
        [XmlIgnore()]
        [EdmScalarProperty()]
        public int TestEnumPropImpl
        {
            get
            {
                return (int)this.TestEnumProp;
            }
            set
            {
                this.TestEnumProp = (Zetbox.App.Test.TestEnum)value;
            }
        }
        
		public static event PropertyGetterHandler<Zetbox.App.Test.TestObjClass, Zetbox.App.Test.TestEnum> OnTestEnumProp_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TestObjClass, Zetbox.App.Test.TestEnum> OnTestEnumProp_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TestObjClass, Zetbox.App.Test.TestEnum> OnTestEnumProp_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.TestObjClass> OnTestEnumProp_IsValid;

        /// <summary>
        /// testmethod
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnTestMethod_TestObjClass")]
        public virtual void TestMethod(DateTime DateTimeParamForTestMethod)
        {
            // base.TestMethod();
            if (OnTestMethod_TestObjClass != null)
            {
                OnTestMethod_TestObjClass(this, DateTimeParamForTestMethod);
            }
            else
            {
                throw new NotImplementedException("No handler registered on method TestObjClass.TestMethod");
            }
        }
        public delegate void TestMethod_Handler<T>(T obj, DateTime DateTimeParamForTestMethod);
        public static event TestMethod_Handler<TestObjClass> OnTestMethod_TestObjClass;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<TestObjClass> OnTestMethod_TestObjClass_CanExec;

        [EventBasedMethod("OnTestMethod_TestObjClass_CanExec")]
        public virtual bool TestMethodCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnTestMethod_TestObjClass_CanExec != null)
				{
					OnTestMethod_TestObjClass_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<TestObjClass> OnTestMethod_TestObjClass_CanExecReason;

        [EventBasedMethod("OnTestMethod_TestObjClass_CanExecReason")]
        public virtual string TestMethodCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnTestMethod_TestObjClass_CanExecReason != null)
				{
					OnTestMethod_TestObjClass_CanExecReason(this, e);
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
            return typeof(TestObjClass);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (TestObjClass)obj;
            var otherImpl = (TestObjClassEfImpl)obj;
            var me = (TestObjClass)this;

            me.MyIntProperty = other.MyIntProperty;
            me.StringProp = other.StringProp;
            me.TestEnumProp = other.TestEnumProp;
            this._fk_ObjectProp = otherImpl._fk_ObjectProp;
        }
        public override void SetNew()
        {
            base.SetNew();
        }
        #region Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "MyIntProperty":
                case "ObjectProp":
                case "StringProp":
                case "TestEnumProp":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }
        #endregion // Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_ObjectProp.HasValue)
                ObjectPropImpl = (Zetbox.App.Projekte.KundeEfImpl)Context.Find<Zetbox.App.Projekte.Kunde>(_fk_ObjectProp.Value);
            else
                ObjectPropImpl = null;
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
                    new PropertyDescriptorEfImpl<TestObjClass, int?>(
                        lazyCtx,
                        new Guid("29c0242b-cd1c-42b4-8ca0-be0a209afcbf"),
                        "MyIntProperty",
                        null,
                        obj => obj.MyIntProperty,
                        (obj, val) => obj.MyIntProperty = val,
						obj => OnMyIntProperty_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<TestObjClass, Zetbox.App.Projekte.Kunde>(
                        lazyCtx,
                        new Guid("e93b3fc2-2fc9-4577-9a93-a51ed2a4190f"),
                        "ObjectProp",
                        null,
                        obj => obj.ObjectProp,
                        (obj, val) => obj.ObjectProp = val,
						obj => OnObjectProp_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<TestObjClass, string>(
                        lazyCtx,
                        new Guid("c9a3769e-7a53-4e1d-b894-72dc1b4e9aea"),
                        "StringProp",
                        null,
                        obj => obj.StringProp,
                        (obj, val) => obj.StringProp = val,
						obj => OnStringProp_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<TestObjClass, Zetbox.App.Test.TestEnum>(
                        lazyCtx,
                        new Guid("89470dda-4ac6-4bb4-9221-d16f80f8d95a"),
                        "TestEnumProp",
                        null,
                        obj => obj.TestEnumProp,
                        (obj, val) => obj.TestEnumProp = val,
						obj => OnTestEnumProp_IsValid), 
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
        [EventBasedMethod("OnToString_TestObjClass")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_TestObjClass != null)
            {
                OnToString_TestObjClass(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<TestObjClass> OnToString_TestObjClass;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_TestObjClass")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_TestObjClass != null)
            {
                OnObjectIsValid_TestObjClass(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<TestObjClass> OnObjectIsValid_TestObjClass;

        [EventBasedMethod("OnNotifyPreSave_TestObjClass")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_TestObjClass != null) OnNotifyPreSave_TestObjClass(this);
        }
        public static event ObjectEventHandler<TestObjClass> OnNotifyPreSave_TestObjClass;

        [EventBasedMethod("OnNotifyPostSave_TestObjClass")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_TestObjClass != null) OnNotifyPostSave_TestObjClass(this);
        }
        public static event ObjectEventHandler<TestObjClass> OnNotifyPostSave_TestObjClass;

        [EventBasedMethod("OnNotifyCreated_TestObjClass")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("MyIntProperty");
            SetNotInitializedProperty("ObjectProp");
            SetNotInitializedProperty("StringProp");
            SetNotInitializedProperty("TestEnumProp");
            base.NotifyCreated();
            if (OnNotifyCreated_TestObjClass != null) OnNotifyCreated_TestObjClass(this);
        }
        public static event ObjectEventHandler<TestObjClass> OnNotifyCreated_TestObjClass;

        [EventBasedMethod("OnNotifyDeleting_TestObjClass")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_TestObjClass != null) OnNotifyDeleting_TestObjClass(this);
            ObjectProp = null;
        }
        public static event ObjectEventHandler<TestObjClass> OnNotifyDeleting_TestObjClass;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.IdProperty
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        public override int ID
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ID;
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_ID != value)
                {
                    var __oldValue = _ID;
                    var __newValue = value;
                    NotifyPropertyChanging("ID", __oldValue, __newValue);
                    _ID = __newValue;
                    NotifyPropertyChanged("ID", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                }
				else 
				{
					SetInitializedProperty("ID");
				}
            }
        }
        private int _ID;
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.IdProperty

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._MyIntProperty);
            {
                var key = this.RelationshipManager.GetRelatedReference<Zetbox.App.Projekte.KundeEfImpl>("Model.FK_TestObjClass_has_ObjectProp", "ObjectProp").EntityKey;
                binStream.Write(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null);
            }
            binStream.Write(this._StringProp);
            binStream.Write((int?)((Zetbox.App.Test.TestObjClass)this).TestEnumProp);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._MyIntProperty = binStream.ReadNullableInt32();
            binStream.Read(out this._fk_ObjectProp);
            this._StringProp = binStream.ReadString();
            ((Zetbox.App.Test.TestObjClass)this).TestEnumProp = (Zetbox.App.Test.TestEnum)binStream.ReadNullableInt32();
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