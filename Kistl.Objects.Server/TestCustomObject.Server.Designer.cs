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
    using Kistl.DALProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="TestCustomObject")]
    [System.Diagnostics.DebuggerDisplay("TestCustomObject")]
    public class TestCustomObject__Implementation__ : BaseServerDataObject_EntityFramework, TestCustomObject
    {
    
		public TestCustomObject__Implementation__()
		{
        }

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.IdProperty
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
        /// Happy Birthday!
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual DateTime? Birthday
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Birthday;
                if (OnBirthday_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime?>(__result);
                    OnBirthday_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Birthday != value)
                {
                    var __oldValue = _Birthday;
                    var __newValue = value;
                    if(OnBirthday_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnBirthday_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Birthday", __oldValue, __newValue);
                    _Birthday = __newValue;
                    NotifyPropertyChanged("Birthday", __oldValue, __newValue);
                    if(OnBirthday_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnBirthday_PostSetter(this, __e);
                    }
                }
            }
        }
        private DateTime? _Birthday;
		public event PropertyGetterHandler<Kistl.App.Test.TestCustomObject, DateTime?> OnBirthday_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Test.TestCustomObject, DateTime?> OnBirthday_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Test.TestCustomObject, DateTime?> OnBirthday_PostSetter;
        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_MuhBlah_List_Role_hasOther_TestCustomObjects_Role
    A: ZeroOrMore Muhblah as MuhBlah_List_Role
    B: ZeroOrOne TestCustomObject as TestCustomObjects_Role
    Preferred Storage: MergeIntoA
    */
        // object list property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectListProperty
	    // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Test.Muhblah> MubBlah_List_Nav
        {
            get
            {
                if (_MubBlah_List_NavWrapper == null)
                {
                    _MubBlah_List_NavWrapper = new EntityCollectionWrapper<Kistl.App.Test.Muhblah, Kistl.App.Test.Muhblah__Implementation__>(
                            this.Context, MubBlah_List_Nav__Implementation__);
                }
                return _MubBlah_List_NavWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_MuhBlah_List_Role_hasOther_TestCustomObjects_Role", "MuhBlah_List_Role")]
        public EntityCollection<Kistl.App.Test.Muhblah__Implementation__> MubBlah_List_Nav__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Test.Muhblah__Implementation__>(
                        "Model.FK_MuhBlah_List_Role_hasOther_TestCustomObjects_Role",
                        "MuhBlah_List_Role");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityCollectionWrapper<Kistl.App.Test.Muhblah, Kistl.App.Test.Muhblah__Implementation__> _MubBlah_List_NavWrapper;



        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_MuhBlah_Role_has_TestCustomObjects_List_Role
    A: ZeroOrOne Muhblah as MuhBlah_Role
    B: ZeroOrMore TestCustomObject as TestCustomObjects_List_Role
    Preferred Storage: MergeIntoB
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Test.Muhblah MubBlah_Nav
        {
            get
            {
                return MubBlah_Nav__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                MubBlah_Nav__Implementation__ = (Kistl.App.Test.Muhblah__Implementation__)value;
            }
        }
        
        private int? _fk_MubBlah_Nav;
        private Guid? _fk_guid_MubBlah_Nav = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_MuhBlah_Role_has_TestCustomObjects_List_Role", "MuhBlah_Role")]
        public Kistl.App.Test.Muhblah__Implementation__ MubBlah_Nav__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Test.Muhblah__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Test.Muhblah__Implementation__>(
                        "Model.FK_MuhBlah_Role_has_TestCustomObjects_List_Role",
                        "MuhBlah_Role");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnMubBlah_Nav_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Test.Muhblah>(__value);
					OnMubBlah_Nav_Getter(this, e);
					__value = (Kistl.App.Test.Muhblah__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Test.Muhblah__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Test.Muhblah__Implementation__>(
                        "Model.FK_MuhBlah_Role_has_TestCustomObjects_List_Role",
                        "MuhBlah_Role");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Test.Muhblah __oldValue = (Kistl.App.Test.Muhblah)r.Value;
                Kistl.App.Test.Muhblah __newValue = (Kistl.App.Test.Muhblah)value;

                if(OnMubBlah_Nav_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Test.Muhblah>(__oldValue, __newValue);
					OnMubBlah_Nav_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Test.Muhblah__Implementation__)__newValue;
                if(OnMubBlah_Nav_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Test.Muhblah>(__oldValue, __newValue);
					OnMubBlah_Nav_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.Test.TestCustomObject, Kistl.App.Test.Muhblah> OnMubBlah_Nav_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Test.TestCustomObject, Kistl.App.Test.Muhblah> OnMubBlah_Nav_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Test.TestCustomObject, Kistl.App.Test.Muhblah> OnMubBlah_Nav_PostSetter;
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
		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Test.Muhblah> MuhBlah_ManyList_Nav
        {
            get
            {
                if (_MuhBlah_ManyList_NavWrapper == null)
                {
                    _MuhBlah_ManyList_NavWrapper = new EntityRelationASideCollectionWrapper<Kistl.App.Test.Muhblah, Kistl.App.Test.TestCustomObject, Kistl.App.Test.Muhblah_has_TestCustomObject_RelationEntry__Implementation__>(
                            this,
                            MuhBlah_ManyList_Nav__Implementation__);
                }
                return _MuhBlah_ManyList_NavWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_MuhBlah_ManyList_Role_has_TestCustomObjects_ManyList_Role_B", "CollectionEntry")]
        public EntityCollection<Kistl.App.Test.Muhblah_has_TestCustomObject_RelationEntry__Implementation__> MuhBlah_ManyList_Nav__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Test.Muhblah_has_TestCustomObject_RelationEntry__Implementation__>(
                        "Model.FK_MuhBlah_ManyList_Role_has_TestCustomObjects_ManyList_Role_B",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityRelationASideCollectionWrapper<Kistl.App.Test.Muhblah, Kistl.App.Test.TestCustomObject, Kistl.App.Test.Muhblah_has_TestCustomObject_RelationEntry__Implementation__> _MuhBlah_ManyList_NavWrapper;


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
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Test.Muhblah MuhBlah_One_Nav
        {
            get
            {
                return MuhBlah_One_Nav__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                MuhBlah_One_Nav__Implementation__ = (Kistl.App.Test.Muhblah__Implementation__)value;
            }
        }
        
        private int? _fk_MuhBlah_One_Nav;
        private Guid? _fk_guid_MuhBlah_One_Nav = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_MuhBlah_One_Role_loves_TestCustomObjects_One_Role", "MuhBlah_One_Role")]
        public Kistl.App.Test.Muhblah__Implementation__ MuhBlah_One_Nav__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Test.Muhblah__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Test.Muhblah__Implementation__>(
                        "Model.FK_MuhBlah_One_Role_loves_TestCustomObjects_One_Role",
                        "MuhBlah_One_Role");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnMuhBlah_One_Nav_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Test.Muhblah>(__value);
					OnMuhBlah_One_Nav_Getter(this, e);
					__value = (Kistl.App.Test.Muhblah__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Test.Muhblah__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Test.Muhblah__Implementation__>(
                        "Model.FK_MuhBlah_One_Role_loves_TestCustomObjects_One_Role",
                        "MuhBlah_One_Role");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Test.Muhblah __oldValue = (Kistl.App.Test.Muhblah)r.Value;
                Kistl.App.Test.Muhblah __newValue = (Kistl.App.Test.Muhblah)value;

                if(OnMuhBlah_One_Nav_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Test.Muhblah>(__oldValue, __newValue);
					OnMuhBlah_One_Nav_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Test.Muhblah__Implementation__)__newValue;
                if(OnMuhBlah_One_Nav_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Test.Muhblah>(__oldValue, __newValue);
					OnMuhBlah_One_Nav_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.Test.TestCustomObject, Kistl.App.Test.Muhblah> OnMuhBlah_One_Nav_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Test.TestCustomObject, Kistl.App.Test.Muhblah> OnMuhBlah_One_Nav_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Test.TestCustomObject, Kistl.App.Test.Muhblah> OnMuhBlah_One_Nav_PostSetter;
        /// <summary>
        /// Person&apos;s Name
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string PersonName
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _PersonName;
                if (OnPersonName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnPersonName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_PersonName != value)
                {
                    var __oldValue = _PersonName;
                    var __newValue = value;
                    if(OnPersonName_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnPersonName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("PersonName", __oldValue, __newValue);
                    _PersonName = __newValue;
                    NotifyPropertyChanged("PersonName", __oldValue, __newValue);
                    if(OnPersonName_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnPersonName_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _PersonName;
		public event PropertyGetterHandler<Kistl.App.Test.TestCustomObject, string> OnPersonName_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Test.TestCustomObject, string> OnPersonName_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Test.TestCustomObject, string> OnPersonName_PostSetter;
		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(TestCustomObject));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (TestCustomObject)obj;
			var otherImpl = (TestCustomObject__Implementation__)obj;
			var me = (TestCustomObject)this;

			me.Birthday = other.Birthday;
			me.PersonName = other.PersonName;
			this._fk_MubBlah_Nav = otherImpl._fk_MubBlah_Nav;
			this._fk_MuhBlah_One_Nav = otherImpl._fk_MuhBlah_One_Nav;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_TestCustomObject")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_TestCustomObject != null)
            {
                OnToString_TestCustomObject(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<TestCustomObject> OnToString_TestCustomObject;

        [EventBasedMethod("OnPreSave_TestCustomObject")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_TestCustomObject != null) OnPreSave_TestCustomObject(this);
        }
        public event ObjectEventHandler<TestCustomObject> OnPreSave_TestCustomObject;

        [EventBasedMethod("OnPostSave_TestCustomObject")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_TestCustomObject != null) OnPostSave_TestCustomObject(this);
        }
        public event ObjectEventHandler<TestCustomObject> OnPostSave_TestCustomObject;

        [EventBasedMethod("OnCreated_TestCustomObject")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_TestCustomObject != null) OnCreated_TestCustomObject(this);
        }
        public event ObjectEventHandler<TestCustomObject> OnCreated_TestCustomObject;

        [EventBasedMethod("OnDeleting_TestCustomObject")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_TestCustomObject != null) OnDeleting_TestCustomObject(this);
        }
        public event ObjectEventHandler<TestCustomObject> OnDeleting_TestCustomObject;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "Birthday":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("bdcf86b8-4c47-4c50-b340-d9323344c7f0")).Constraints
						.Where(c => !c.IsValid(this, this.Birthday))
						.Select(c => c.GetErrorText(this, this.Birthday))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "MubBlah_List_Nav":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("4a929ef5-f211-47b4-92c3-4961da6d5173")).Constraints
						.Where(c => !c.IsValid(this, this.MubBlah_List_Nav))
						.Select(c => c.GetErrorText(this, this.MubBlah_List_Nav))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "MubBlah_Nav":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("3251497d-5214-4e42-976e-f36c3d9541de")).Constraints
						.Where(c => !c.IsValid(this, this.MubBlah_Nav))
						.Select(c => c.GetErrorText(this, this.MubBlah_Nav))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "MuhBlah_ManyList_Nav":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("9c4217f2-47d8-47b5-a324-7601ecabc7b0")).Constraints
						.Where(c => !c.IsValid(this, this.MuhBlah_ManyList_Nav))
						.Select(c => c.GetErrorText(this, this.MuhBlah_ManyList_Nav))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "MuhBlah_One_Nav":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("e7b207d3-5d25-4716-85b3-564f10eac210")).Constraints
						.Where(c => !c.IsValid(this, this.MuhBlah_One_Nav))
						.Select(c => c.GetErrorText(this, this.MuhBlah_One_Nav))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "PersonName":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("bd501a1f-a0a3-4ddf-b6c2-8fdc9ffdfabd")).Constraints
						.Where(c => !c.IsValid(this, this.PersonName))
						.Select(c => c.GetErrorText(this, this.PersonName))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}

		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
			// fix direct object references

			if (_fk_guid_MubBlah_Nav.HasValue)
				MubBlah_Nav__Implementation__ = (Kistl.App.Test.Muhblah__Implementation__)Context.FindPersistenceObject<Kistl.App.Test.Muhblah>(_fk_guid_MubBlah_Nav.Value);
			else if (_fk_MubBlah_Nav.HasValue)
				MubBlah_Nav__Implementation__ = (Kistl.App.Test.Muhblah__Implementation__)Context.Find<Kistl.App.Test.Muhblah>(_fk_MubBlah_Nav.Value);
			else
				MubBlah_Nav__Implementation__ = null;

			if (_fk_guid_MuhBlah_One_Nav.HasValue)
				MuhBlah_One_Nav__Implementation__ = (Kistl.App.Test.Muhblah__Implementation__)Context.FindPersistenceObject<Kistl.App.Test.Muhblah>(_fk_guid_MuhBlah_One_Nav.Value);
			else if (_fk_MuhBlah_One_Nav.HasValue)
				MuhBlah_One_Nav__Implementation__ = (Kistl.App.Test.Muhblah__Implementation__)Context.Find<Kistl.App.Test.Muhblah>(_fk_MuhBlah_One_Nav.Value);
			else
				MuhBlah_One_Nav__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
            
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._Birthday, binStream);
            BinarySerializer.ToStream(MubBlah_Nav != null ? MubBlah_Nav.ID : (int?)null, binStream);
            BinarySerializer.ToStream(MuhBlah_One_Nav != null ? MuhBlah_One_Nav.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._PersonName, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._Birthday, binStream);
            BinarySerializer.FromStream(out this._fk_MubBlah_Nav, binStream);
            BinarySerializer.FromStream(out this._fk_MuhBlah_One_Nav, binStream);
            BinarySerializer.FromStream(out this._PersonName, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(this._Birthday, xml, "Birthday", "Kistl.App.Test");
            XmlStreamer.ToStream(MubBlah_Nav != null ? MubBlah_Nav.ID : (int?)null, xml, "MubBlah_Nav", "Kistl.App.Test");
            XmlStreamer.ToStream(MuhBlah_One_Nav != null ? MuhBlah_One_Nav.ID : (int?)null, xml, "MuhBlah_One_Nav", "Kistl.App.Test");
            XmlStreamer.ToStream(this._PersonName, xml, "PersonName", "Kistl.App.Test");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._Birthday, xml, "Birthday", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._fk_MubBlah_Nav, xml, "MubBlah_Nav", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._fk_MuhBlah_One_Nav, xml, "MuhBlah_One_Nav", "Kistl.App.Test");
            XmlStreamer.FromStream(ref this._PersonName, xml, "PersonName", "Kistl.App.Test");
        }

#endregion

    }


}