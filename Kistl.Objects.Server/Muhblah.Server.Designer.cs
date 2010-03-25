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
    [EdmEntityType(NamespaceName="Model", Name="Muhblah")]
    [System.Diagnostics.DebuggerDisplay("Muhblah")]
    public class Muhblah__Implementation__ : BaseServerDataObject_EntityFramework, Muhblah
    {
    
		public Muhblah__Implementation__()
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
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual bool? TestBool
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _TestBool;
                if (OnTestBool_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool?>(__result);
                    OnTestBool_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_TestBool != value)
                {
                    var __oldValue = _TestBool;
                    var __newValue = value;
                    if(OnTestBool_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnTestBool_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("TestBool", __oldValue, __newValue);
                    _TestBool = __newValue;
                    NotifyPropertyChanged("TestBool", __oldValue, __newValue);
                    if(OnTestBool_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnTestBool_PostSetter(this, __e);
                    }
                }
            }
        }
        private bool? _TestBool;
		public static event PropertyGetterHandler<Kistl.App.Test.Muhblah, bool?> OnTestBool_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.Muhblah, bool?> OnTestBool_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.Muhblah, bool?> OnTestBool_PostSetter;

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_MuhBlah_Role_has_TestCustomObjects_List_Role
    A: ZeroOrOne Muhblah as MuhBlah_Role
    B: ZeroOrMore TestCustomObject as TestCustomObjects_List_Role
    Preferred Storage: MergeIntoB
    */
        // object list property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectListProperty
	    // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Test.TestCustomObject> TestCustomObjects_List_Nav
        {
            get
            {
                if (_TestCustomObjects_List_NavWrapper == null)
                {
                    _TestCustomObjects_List_NavWrapper = new EntityCollectionWrapper<Kistl.App.Test.TestCustomObject, Kistl.App.Test.TestCustomObject__Implementation__>(
                            this.Context, TestCustomObjects_List_Nav__Implementation__);
                }
                return _TestCustomObjects_List_NavWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_MuhBlah_Role_has_TestCustomObjects_List_Role", "TestCustomObjects_List_Role")]
        public EntityCollection<Kistl.App.Test.TestCustomObject__Implementation__> TestCustomObjects_List_Nav__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Test.TestCustomObject__Implementation__>(
                        "Model.FK_MuhBlah_Role_has_TestCustomObjects_List_Role",
                        "TestCustomObjects_List_Role");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityCollectionWrapper<Kistl.App.Test.TestCustomObject, Kistl.App.Test.TestCustomObject__Implementation__> _TestCustomObjects_List_NavWrapper;



        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_MuhBlah_ManyList_Role_has_TestCustomObjects_ManyList_Role
    A: ZeroOrMore Muhblah as MuhBlah_ManyList_Role
    B: ZeroOrMore TestCustomObject as TestCustomObjects_ManyList_Role
    Preferred Storage: Separate
    */
        // collection reference property
		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Test.TestCustomObject> TestCustomObjects_ManyList_Nav
        {
            get
            {
                if (_TestCustomObjects_ManyList_NavWrapper == null)
                {
                    _TestCustomObjects_ManyList_NavWrapper = new EntityRelationBSideCollectionWrapper<Kistl.App.Test.Muhblah, Kistl.App.Test.TestCustomObject, Kistl.App.Test.Muhblah_has_TestCustomObject_RelationEntry__Implementation__>(
                            this,
                            TestCustomObjects_ManyList_Nav__Implementation__);
                }
                return _TestCustomObjects_ManyList_NavWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_MuhBlah_ManyList_Role_has_TestCustomObjects_ManyList_Role_A", "CollectionEntry")]
        public EntityCollection<Kistl.App.Test.Muhblah_has_TestCustomObject_RelationEntry__Implementation__> TestCustomObjects_ManyList_Nav__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Test.Muhblah_has_TestCustomObject_RelationEntry__Implementation__>(
                        "Model.FK_MuhBlah_ManyList_Role_has_TestCustomObjects_ManyList_Role_A",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityRelationBSideCollectionWrapper<Kistl.App.Test.Muhblah, Kistl.App.Test.TestCustomObject, Kistl.App.Test.Muhblah_has_TestCustomObject_RelationEntry__Implementation__> _TestCustomObjects_ManyList_NavWrapper;


        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_MuhBlah_List_Role_hasOther_TestCustomObjects_Role
    A: ZeroOrMore Muhblah as MuhBlah_List_Role
    B: ZeroOrOne TestCustomObject as TestCustomObjects_Role
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Test.TestCustomObject TestCustomObjects_Nav
        {
            get
            {
                return TestCustomObjects_Nav__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                TestCustomObjects_Nav__Implementation__ = (Kistl.App.Test.TestCustomObject__Implementation__)value;
            }
        }
        
        private int? _fk_TestCustomObjects_Nav;
        private Guid? _fk_guid_TestCustomObjects_Nav = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_MuhBlah_List_Role_hasOther_TestCustomObjects_Role", "TestCustomObjects_Role")]
        public Kistl.App.Test.TestCustomObject__Implementation__ TestCustomObjects_Nav__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Test.TestCustomObject__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Test.TestCustomObject__Implementation__>(
                        "Model.FK_MuhBlah_List_Role_hasOther_TestCustomObjects_Role",
                        "TestCustomObjects_Role");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnTestCustomObjects_Nav_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Test.TestCustomObject>(__value);
					OnTestCustomObjects_Nav_Getter(this, e);
					__value = (Kistl.App.Test.TestCustomObject__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Test.TestCustomObject__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Test.TestCustomObject__Implementation__>(
                        "Model.FK_MuhBlah_List_Role_hasOther_TestCustomObjects_Role",
                        "TestCustomObjects_Role");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Test.TestCustomObject __oldValue = (Kistl.App.Test.TestCustomObject)r.Value;
                Kistl.App.Test.TestCustomObject __newValue = (Kistl.App.Test.TestCustomObject)value;

                if(OnTestCustomObjects_Nav_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Test.TestCustomObject>(__oldValue, __newValue);
					OnTestCustomObjects_Nav_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Test.TestCustomObject__Implementation__)__newValue;
                if(OnTestCustomObjects_Nav_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Test.TestCustomObject>(__oldValue, __newValue);
					OnTestCustomObjects_Nav_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public static event PropertyGetterHandler<Kistl.App.Test.Muhblah, Kistl.App.Test.TestCustomObject> OnTestCustomObjects_Nav_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.Muhblah, Kistl.App.Test.TestCustomObject> OnTestCustomObjects_Nav_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.Muhblah, Kistl.App.Test.TestCustomObject> OnTestCustomObjects_Nav_PostSetter;

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_MuhBlah_One_Role_loves_TestCustomObjects_One_Role
    A: ZeroOrOne Muhblah as MuhBlah_One_Role
    B: ZeroOrOne TestCustomObject as TestCustomObjects_One_Role
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Test.TestCustomObject TestCustomObjects_One_Nav
        {
            get
            {
                return TestCustomObjects_One_Nav__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                TestCustomObjects_One_Nav__Implementation__ = (Kistl.App.Test.TestCustomObject__Implementation__)value;
            }
        }
        
        private int? _fk_TestCustomObjects_One_Nav;
        private Guid? _fk_guid_TestCustomObjects_One_Nav = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_MuhBlah_One_Role_loves_TestCustomObjects_One_Role", "TestCustomObjects_One_Role")]
        public Kistl.App.Test.TestCustomObject__Implementation__ TestCustomObjects_One_Nav__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Test.TestCustomObject__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Test.TestCustomObject__Implementation__>(
                        "Model.FK_MuhBlah_One_Role_loves_TestCustomObjects_One_Role",
                        "TestCustomObjects_One_Role");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnTestCustomObjects_One_Nav_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Test.TestCustomObject>(__value);
					OnTestCustomObjects_One_Nav_Getter(this, e);
					__value = (Kistl.App.Test.TestCustomObject__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Test.TestCustomObject__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Test.TestCustomObject__Implementation__>(
                        "Model.FK_MuhBlah_One_Role_loves_TestCustomObjects_One_Role",
                        "TestCustomObjects_One_Role");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Test.TestCustomObject __oldValue = (Kistl.App.Test.TestCustomObject)r.Value;
                Kistl.App.Test.TestCustomObject __newValue = (Kistl.App.Test.TestCustomObject)value;

                if(OnTestCustomObjects_One_Nav_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Test.TestCustomObject>(__oldValue, __newValue);
					OnTestCustomObjects_One_Nav_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Test.TestCustomObject__Implementation__)__newValue;
                if(OnTestCustomObjects_One_Nav_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Test.TestCustomObject>(__oldValue, __newValue);
					OnTestCustomObjects_One_Nav_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public static event PropertyGetterHandler<Kistl.App.Test.Muhblah, Kistl.App.Test.TestCustomObject> OnTestCustomObjects_One_Nav_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.Muhblah, Kistl.App.Test.TestCustomObject> OnTestCustomObjects_One_Nav_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.Muhblah, Kistl.App.Test.TestCustomObject> OnTestCustomObjects_One_Nav_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual DateTime? TestDateTime
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _TestDateTime;
                if (OnTestDateTime_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime?>(__result);
                    OnTestDateTime_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_TestDateTime != value)
                {
                    var __oldValue = _TestDateTime;
                    var __newValue = value;
                    if(OnTestDateTime_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnTestDateTime_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("TestDateTime", __oldValue, __newValue);
                    _TestDateTime = __newValue;
                    NotifyPropertyChanged("TestDateTime", __oldValue, __newValue);
                    if(OnTestDateTime_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnTestDateTime_PostSetter(this, __e);
                    }
                }
            }
        }
        private DateTime? _TestDateTime;
		public static event PropertyGetterHandler<Kistl.App.Test.Muhblah, DateTime?> OnTestDateTime_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.Muhblah, DateTime?> OnTestDateTime_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.Muhblah, DateTime?> OnTestDateTime_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // enumeration property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.EnumerationPropertyTemplate
        // implement the user-visible interface
        public Kistl.App.Test.TestEnum TestEnum
        {
            get
            {
				var __value = _TestEnum;
				if(OnTestEnum_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Test.TestEnum>(__value);
					OnTestEnum_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_TestEnum != value)
                {
					var __oldValue = _TestEnum;
					var __newValue = value;
                    if(OnTestEnum_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<Kistl.App.Test.TestEnum>(__oldValue, __newValue);
						OnTestEnum_PreSetter(this, e);
						__newValue = e.Result;
                    }
					
                    NotifyPropertyChanging("TestEnum", "TestEnum__Implementation__", __oldValue, __newValue);
                    _TestEnum = value;
                    NotifyPropertyChanged("TestEnum", "TestEnum__Implementation__", __oldValue, __newValue);
                    if(OnTestEnum_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<Kistl.App.Test.TestEnum>(__oldValue, __newValue);
						OnTestEnum_PostSetter(this, e);
                    }
                    
                }
            }
        }
        
        /// <summary>backing store for TestEnum</summary>
        private Kistl.App.Test.TestEnum _TestEnum;
        
        /// <summary>EF sees only this property, for TestEnum</summary>
        [XmlIgnore()]
        [EdmScalarProperty()]
        public int TestEnum__Implementation__
        {
            get
            {
                return (int)this.TestEnum;
            }
            set
            {
                this.TestEnum = (Kistl.App.Test.TestEnum)value;
            }
        }
        
		public static event PropertyGetterHandler<Kistl.App.Test.Muhblah, Kistl.App.Test.TestEnum> OnTestEnum_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.Muhblah, Kistl.App.Test.TestEnum> OnTestEnum_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.Muhblah, Kistl.App.Test.TestEnum> OnTestEnum_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string TestString
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _TestString;
                if (OnTestString_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnTestString_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_TestString != value)
                {
                    var __oldValue = _TestString;
                    var __newValue = value;
                    if(OnTestString_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnTestString_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("TestString", __oldValue, __newValue);
                    _TestString = __newValue;
                    NotifyPropertyChanged("TestString", __oldValue, __newValue);
                    if(OnTestString_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnTestString_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _TestString;
		public static event PropertyGetterHandler<Kistl.App.Test.Muhblah, string> OnTestString_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.Muhblah, string> OnTestString_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.Muhblah, string> OnTestString_PostSetter;

		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Muhblah));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Muhblah)obj;
			var otherImpl = (Muhblah__Implementation__)obj;
			var me = (Muhblah)this;

			me.TestBool = other.TestBool;
			me.TestDateTime = other.TestDateTime;
			me.TestEnum = other.TestEnum;
			me.TestString = other.TestString;
			this._fk_TestCustomObjects_Nav = otherImpl._fk_TestCustomObjects_Nav;
			this._fk_TestCustomObjects_One_Nav = otherImpl._fk_TestCustomObjects_One_Nav;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_Muhblah")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Muhblah != null)
            {
                OnToString_Muhblah(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<Muhblah> OnToString_Muhblah;

        [EventBasedMethod("OnPreSave_Muhblah")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Muhblah != null) OnPreSave_Muhblah(this);
        }
        public static event ObjectEventHandler<Muhblah> OnPreSave_Muhblah;

        [EventBasedMethod("OnPostSave_Muhblah")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Muhblah != null) OnPostSave_Muhblah(this);
        }
        public static event ObjectEventHandler<Muhblah> OnPostSave_Muhblah;

        [EventBasedMethod("OnCreated_Muhblah")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_Muhblah != null) OnCreated_Muhblah(this);
        }
        public static event ObjectEventHandler<Muhblah> OnCreated_Muhblah;

        [EventBasedMethod("OnDeleting_Muhblah")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Muhblah != null) OnDeleting_Muhblah(this);
        }
        public static event ObjectEventHandler<Muhblah> OnDeleting_Muhblah;


		private static readonly System.ComponentModel.PropertyDescriptor[] _properties = new System.ComponentModel.PropertyDescriptor[] {
			// else
			new CustomPropertyDescriptor<Muhblah__Implementation__, bool?>(
				new Guid("9206e71e-85ea-4d74-85ea-59ee2484ed2a"),
				"TestBool",
				null,
				obj => obj.TestBool,
				(obj, val) => obj.TestBool = val),
			// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
			new CustomPropertyDescriptor<Muhblah__Implementation__, ICollection<Kistl.App.Test.TestCustomObject>>(
				new Guid("1f944324-673f-4f14-94c8-dc570ea3022d"),
				"TestCustomObjects_List_Nav",
				null,
				obj => obj.TestCustomObjects_List_Nav,
				null), // lists are read-only properties
			// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
			new CustomPropertyDescriptor<Muhblah__Implementation__, ICollection<Kistl.App.Test.TestCustomObject>>(
				new Guid("a3ad7340-4dc1-488c-bc9a-29ac931b1f0d"),
				"TestCustomObjects_ManyList_Nav",
				null,
				obj => obj.TestCustomObjects_ManyList_Nav,
				null), // lists are read-only properties
			// else
			new CustomPropertyDescriptor<Muhblah__Implementation__, Kistl.App.Test.TestCustomObject>(
				new Guid("aabd7cb7-c45e-43c9-97fd-76e50c310ab3"),
				"TestCustomObjects_Nav",
				null,
				obj => obj.TestCustomObjects_Nav,
				(obj, val) => obj.TestCustomObjects_Nav = val),
			// else
			new CustomPropertyDescriptor<Muhblah__Implementation__, Kistl.App.Test.TestCustomObject>(
				new Guid("42c6bc2f-0428-488a-b928-539c4c6e3e65"),
				"TestCustomObjects_One_Nav",
				null,
				obj => obj.TestCustomObjects_One_Nav,
				(obj, val) => obj.TestCustomObjects_One_Nav = val),
			// else
			new CustomPropertyDescriptor<Muhblah__Implementation__, DateTime?>(
				new Guid("c5a66e0b-1fdb-45e4-b9e4-2ae4ee35a201"),
				"TestDateTime",
				null,
				obj => obj.TestDateTime,
				(obj, val) => obj.TestDateTime = val),
			// else
			new CustomPropertyDescriptor<Muhblah__Implementation__, Kistl.App.Test.TestEnum>(
				new Guid("1a5484e4-4be0-4641-9c25-1aa30d1c0e7a"),
				"TestEnum",
				null,
				obj => obj.TestEnum,
				(obj, val) => obj.TestEnum = val),
			// else
			new CustomPropertyDescriptor<Muhblah__Implementation__, string>(
				new Guid("e9516350-fa66-426b-808a-bd8a5f432427"),
				"TestString",
				null,
				obj => obj.TestString,
				(obj, val) => obj.TestString = val),
			// rel: MuhBlah_Role has TestCustomObjects_List_Role (bd379747-6864-4c4e-95a8-319ff917fd60)
			// rel: MuhBlah_List_Role hasOther TestCustomObjects_Role (804f4d1e-ca7d-45e2-b9a3-3f89a6874768)
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

			if (_fk_guid_TestCustomObjects_Nav.HasValue)
				TestCustomObjects_Nav__Implementation__ = (Kistl.App.Test.TestCustomObject__Implementation__)Context.FindPersistenceObject<Kistl.App.Test.TestCustomObject>(_fk_guid_TestCustomObjects_Nav.Value);
			else if (_fk_TestCustomObjects_Nav.HasValue)
				TestCustomObjects_Nav__Implementation__ = (Kistl.App.Test.TestCustomObject__Implementation__)Context.Find<Kistl.App.Test.TestCustomObject>(_fk_TestCustomObjects_Nav.Value);
			else
				TestCustomObjects_Nav__Implementation__ = null;

			if (_fk_guid_TestCustomObjects_One_Nav.HasValue)
				TestCustomObjects_One_Nav__Implementation__ = (Kistl.App.Test.TestCustomObject__Implementation__)Context.FindPersistenceObject<Kistl.App.Test.TestCustomObject>(_fk_guid_TestCustomObjects_One_Nav.Value);
			else if (_fk_TestCustomObjects_One_Nav.HasValue)
				TestCustomObjects_One_Nav__Implementation__ = (Kistl.App.Test.TestCustomObject__Implementation__)Context.Find<Kistl.App.Test.TestCustomObject>(_fk_TestCustomObjects_One_Nav.Value);
			else
				TestCustomObjects_One_Nav__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this._TestBool, binStream);
            BinarySerializer.ToStream(TestCustomObjects_Nav != null ? TestCustomObjects_Nav.ID : (int?)null, binStream);
            BinarySerializer.ToStream(TestCustomObjects_One_Nav != null ? TestCustomObjects_One_Nav.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._TestDateTime, binStream);
            BinarySerializer.ToStream((int?)((Muhblah)this).TestEnum, binStream);
            BinarySerializer.ToStream(this._TestString, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._TestBool, binStream);
            BinarySerializer.FromStream(out this._fk_TestCustomObjects_Nav, binStream);
            BinarySerializer.FromStream(out this._fk_TestCustomObjects_One_Nav, binStream);
            BinarySerializer.FromStream(out this._TestDateTime, binStream);
			{
				int? baseValue;
				BinarySerializer.FromStream(out baseValue, binStream);
				((Muhblah)this).TestEnum = (Kistl.App.Test.TestEnum)baseValue;
			}
            BinarySerializer.FromStream(out this._TestString, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(this._TestBool, xml, "TestBool", "Kistl.App.Test");
            XmlStreamer.ToStream(TestCustomObjects_Nav != null ? TestCustomObjects_Nav.ID : (int?)null, xml, "TestCustomObjects_Nav", "Kistl.App.Test");
            XmlStreamer.ToStream(TestCustomObjects_One_Nav != null ? TestCustomObjects_One_Nav.ID : (int?)null, xml, "TestCustomObjects_One_Nav", "Kistl.App.Test");
            XmlStreamer.ToStream(this._TestDateTime, xml, "TestDateTime", "Kistl.App.Test");
            XmlStreamer.ToStream((int?)this.TestEnum, xml, "TestEnum", "Kistl.App.Test");
            XmlStreamer.ToStream(this._TestString, xml, "TestString", "Kistl.App.Test");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._TestBool, xml, "TestBool", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._fk_TestCustomObjects_Nav, xml, "TestCustomObjects_Nav", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._fk_TestCustomObjects_One_Nav, xml, "TestCustomObjects_One_Nav", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._TestDateTime, xml, "TestDateTime", "Kistl.App.Test");
            XmlStreamer.FromStreamConverter(v => ((Muhblah)this).TestEnum = (Kistl.App.Test.TestEnum)v, xml, "TestEnum", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._TestString, xml, "TestString", "Kistl.App.Test");
        }

#endregion

    }


}