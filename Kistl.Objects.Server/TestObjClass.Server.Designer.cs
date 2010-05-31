// <autogenerated/>


namespace Kistl.App.Test
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

    using Kistl.API.Server;
    using Kistl.DalProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="TestObjClass")]
    [System.Diagnostics.DebuggerDisplay("TestObjClass")]
    public class TestObjClass__Implementation__ : BaseServerDataObject_EntityFramework, TestObjClass
    {
    
		public TestObjClass__Implementation__()
		{
        }

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.IdProperty
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
                }
            }
        }
        private int _ID;

        /// <summary>
        /// test
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual int? MyIntProperty
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
                    __result = __e.Result;
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
                    if(OnMyIntProperty_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int?>(__oldValue, __newValue);
                        OnMyIntProperty_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("MyIntProperty", __oldValue, __newValue);
                    _MyIntProperty = __newValue;
                    NotifyPropertyChanged("MyIntProperty", __oldValue, __newValue);
                    if(OnMyIntProperty_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int?>(__oldValue, __newValue);
                        OnMyIntProperty_PostSetter(this, __e);
                    }
                }
            }
        }
        private int? _MyIntProperty;
		public static event PropertyGetterHandler<Kistl.App.Test.TestObjClass, int?> OnMyIntProperty_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestObjClass, int?> OnMyIntProperty_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestObjClass, int?> OnMyIntProperty_PostSetter;

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
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Projekte.Kunde ObjectProp
        {
            get
            {
                return ObjectProp__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                ObjectProp__Implementation__ = (Kistl.App.Projekte.Kunde__Implementation__)value;
            }
        }
        
        private int? _fk_ObjectProp;
        private Guid? _fk_guid_ObjectProp = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_TestObjClass_has_ObjectProp", "ObjectProp")]
        public Kistl.App.Projekte.Kunde__Implementation__ ObjectProp__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Projekte.Kunde__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Kunde__Implementation__>(
                        "Model.FK_TestObjClass_has_ObjectProp",
                        "ObjectProp");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnObjectProp_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Projekte.Kunde>(__value);
					OnObjectProp_Getter(this, e);
					__value = (Kistl.App.Projekte.Kunde__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Projekte.Kunde__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Kunde__Implementation__>(
                        "Model.FK_TestObjClass_has_ObjectProp",
                        "ObjectProp");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Projekte.Kunde __oldValue = (Kistl.App.Projekte.Kunde)r.Value;
                Kistl.App.Projekte.Kunde __newValue = (Kistl.App.Projekte.Kunde)value;

                if(OnObjectProp_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Projekte.Kunde>(__oldValue, __newValue);
					OnObjectProp_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Projekte.Kunde__Implementation__)__newValue;
                if(OnObjectProp_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Projekte.Kunde>(__oldValue, __newValue);
					OnObjectProp_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public static event PropertyGetterHandler<Kistl.App.Test.TestObjClass, Kistl.App.Projekte.Kunde> OnObjectProp_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestObjClass, Kistl.App.Projekte.Kunde> OnObjectProp_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestObjClass, Kistl.App.Projekte.Kunde> OnObjectProp_PostSetter;

        /// <summary>
        /// String Property
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string StringProp
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
                    __result = __e.Result;
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
                    if(OnStringProp_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnStringProp_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("StringProp", __oldValue, __newValue);
                    _StringProp = __newValue;
                    NotifyPropertyChanged("StringProp", __oldValue, __newValue);
                    if(OnStringProp_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnStringProp_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _StringProp;
		public static event PropertyGetterHandler<Kistl.App.Test.TestObjClass, string> OnStringProp_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestObjClass, string> OnStringProp_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestObjClass, string> OnStringProp_PostSetter;

        /// <summary>
        /// Test Enumeration Property
        /// </summary>
        // enumeration property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.EnumerationPropertyTemplate
        // implement the user-visible interface
        public Kistl.App.Test.TestEnum TestEnumProp
        {
            get
            {
				var __value = _TestEnumProp;
				if(OnTestEnumProp_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Test.TestEnum>(__value);
					OnTestEnumProp_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_TestEnumProp != value)
                {
					var __oldValue = _TestEnumProp;
					var __newValue = value;
                    if(OnTestEnumProp_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<Kistl.App.Test.TestEnum>(__oldValue, __newValue);
						OnTestEnumProp_PreSetter(this, e);
						__newValue = e.Result;
                    }
					
                    NotifyPropertyChanging("TestEnumProp", "TestEnumProp__Implementation__", __oldValue, __newValue);
                    _TestEnumProp = value;
                    NotifyPropertyChanged("TestEnumProp", "TestEnumProp__Implementation__", __oldValue, __newValue);
                    if(OnTestEnumProp_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<Kistl.App.Test.TestEnum>(__oldValue, __newValue);
						OnTestEnumProp_PostSetter(this, e);
                    }
                    
                }
            }
        }
        
        /// <summary>backing store for TestEnumProp</summary>
        private Kistl.App.Test.TestEnum _TestEnumProp;
        
        /// <summary>EF sees only this property, for TestEnumProp</summary>
        [XmlIgnore()]
        [EdmScalarProperty()]
        public int TestEnumProp__Implementation__
        {
            get
            {
                return (int)this.TestEnumProp;
            }
            set
            {
                this.TestEnumProp = (Kistl.App.Test.TestEnum)value;
            }
        }
        
		public static event PropertyGetterHandler<Kistl.App.Test.TestObjClass, Kistl.App.Test.TestEnum> OnTestEnumProp_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestObjClass, Kistl.App.Test.TestEnum> OnTestEnumProp_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestObjClass, Kistl.App.Test.TestEnum> OnTestEnumProp_PostSetter;

        /// <summary>
        /// testmethod
        /// </summary>
		[EventBasedMethod("OnTestMethod_TestObjClass")]
		public virtual void TestMethod(System.DateTime DateTimeParamForTestMethod) 
		{
            // base.TestMethod();
            if (OnTestMethod_TestObjClass != null)
            {
				OnTestMethod_TestObjClass(this, DateTimeParamForTestMethod);
			}
			else
			{
                throw new NotImplementedException("No handler registered on TestObjClass.TestMethod");
			}
        }
		public delegate void TestMethod_Handler<T>(T obj, System.DateTime DateTimeParamForTestMethod);
		public static event TestMethod_Handler<TestObjClass> OnTestMethod_TestObjClass;



		public override Type GetImplementedInterface()
		{
			return typeof(TestObjClass);
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (TestObjClass)obj;
			var otherImpl = (TestObjClass__Implementation__)obj;
			var me = (TestObjClass)this;

			me.MyIntProperty = other.MyIntProperty;
			me.StringProp = other.StringProp;
			me.TestEnumProp = other.TestEnumProp;
			this._fk_ObjectProp = otherImpl._fk_ObjectProp;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

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

        [EventBasedMethod("OnPreSave_TestObjClass")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_TestObjClass != null) OnPreSave_TestObjClass(this);
        }
        public static event ObjectEventHandler<TestObjClass> OnPreSave_TestObjClass;

        [EventBasedMethod("OnPostSave_TestObjClass")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_TestObjClass != null) OnPostSave_TestObjClass(this);
        }
        public static event ObjectEventHandler<TestObjClass> OnPostSave_TestObjClass;

        [EventBasedMethod("OnCreated_TestObjClass")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_TestObjClass != null) OnCreated_TestObjClass(this);
        }
        public static event ObjectEventHandler<TestObjClass> OnCreated_TestObjClass;

        [EventBasedMethod("OnDeleting_TestObjClass")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_TestObjClass != null) OnDeleting_TestObjClass(this);
        }
        public static event ObjectEventHandler<TestObjClass> OnDeleting_TestObjClass;


		private static readonly System.ComponentModel.PropertyDescriptor[] _properties = new System.ComponentModel.PropertyDescriptor[] {
			// else
			new CustomPropertyDescriptor<TestObjClass__Implementation__, int?>(
				new Guid("29c0242b-cd1c-42b4-8ca0-be0a209afcbf"),
				"MyIntProperty",
				null,
				obj => obj.MyIntProperty,
				(obj, val) => obj.MyIntProperty = val),
			// else
			new CustomPropertyDescriptor<TestObjClass__Implementation__, Kistl.App.Projekte.Kunde>(
				new Guid("e93b3fc2-2fc9-4577-9a93-a51ed2a4190f"),
				"ObjectProp",
				null,
				obj => obj.ObjectProp,
				(obj, val) => obj.ObjectProp = val),
			// else
			new CustomPropertyDescriptor<TestObjClass__Implementation__, string>(
				new Guid("c9a3769e-7a53-4e1d-b894-72dc1b4e9aea"),
				"StringProp",
				null,
				obj => obj.StringProp,
				(obj, val) => obj.StringProp = val),
			// else
			new CustomPropertyDescriptor<TestObjClass__Implementation__, Kistl.App.Test.TestEnum>(
				new Guid("89470dda-4ac6-4bb4-9221-d16f80f8d95a"),
				"TestEnumProp",
				null,
				obj => obj.TestEnumProp,
				(obj, val) => obj.TestEnumProp = val),
			// rel: TestObjClass has ObjectProp (9d44eac8-2470-4373-a2bf-df3bc16d3454)
		};
		
		protected override void CollectProperties(List<System.ComponentModel.PropertyDescriptor> props)
		{
			base.CollectProperties(props);
			props.AddRange(_properties);
		}
	

		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
			// fix direct object references

			if (_fk_guid_ObjectProp.HasValue)
				ObjectProp__Implementation__ = (Kistl.App.Projekte.Kunde__Implementation__)Context.FindPersistenceObject<Kistl.App.Projekte.Kunde>(_fk_guid_ObjectProp.Value);
			else if (_fk_ObjectProp.HasValue)
				ObjectProp__Implementation__ = (Kistl.App.Projekte.Kunde__Implementation__)Context.Find<Kistl.App.Projekte.Kunde>(_fk_ObjectProp.Value);
			else
				ObjectProp__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this._MyIntProperty, binStream);
            BinarySerializer.ToStream(ObjectProp != null ? ObjectProp.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._StringProp, binStream);
            BinarySerializer.ToStream((int?)((TestObjClass)this).TestEnumProp, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._MyIntProperty, binStream);
            BinarySerializer.FromStream(out this._fk_ObjectProp, binStream);
            BinarySerializer.FromStream(out this._StringProp, binStream);
			{
				int? baseValue;
				BinarySerializer.FromStream(out baseValue, binStream);
				((TestObjClass)this).TestEnumProp = (Kistl.App.Test.TestEnum)baseValue;
			}
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(this._MyIntProperty, xml, "MyIntProperty", "Kistl.App.Test");
            XmlStreamer.ToStream(ObjectProp != null ? ObjectProp.ID : (int?)null, xml, "ObjectProp", "Kistl.App.Test");
            XmlStreamer.ToStream(this._StringProp, xml, "StringProp", "Kistl.App.Test");
            XmlStreamer.ToStream((int?)this.TestEnumProp, xml, "TestEnumProp", "Kistl.App.Test");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._MyIntProperty, xml, "MyIntProperty", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._fk_ObjectProp, xml, "ObjectProp", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._StringProp, xml, "StringProp", "Kistl.App.Test");
            XmlStreamer.FromStreamConverter(v => ((TestObjClass)this).TestEnumProp = (Kistl.App.Test.TestEnum)v, xml, "TestEnumProp", "Kistl.App.Test");
        }

#endregion

    }


}