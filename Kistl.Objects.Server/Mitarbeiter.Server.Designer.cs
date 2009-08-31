// <autogenerated/>


namespace Kistl.App.Projekte
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
    [EdmEntityType(NamespaceName="Model", Name="Mitarbeiter")]
    [System.Diagnostics.DebuggerDisplay("Mitarbeiter")]
    public class Mitarbeiter__Implementation__ : BaseServerDataObject_EntityFramework, Mitarbeiter
    {
    
		public Mitarbeiter__Implementation__()
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
        /// Herzlichen Glückwunsch zum Geburtstag
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual DateTime? Geburtstag
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Geburtstag;
                if (OnGeburtstag_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime?>(__result);
                    OnGeburtstag_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Geburtstag != value)
                {
                    var __oldValue = _Geburtstag;
                    var __newValue = value;
                    if(OnGeburtstag_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnGeburtstag_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Geburtstag", __oldValue, __newValue);
                    _Geburtstag = __newValue;
                    NotifyPropertyChanged("Geburtstag", __oldValue, __newValue);
                    if(OnGeburtstag_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnGeburtstag_PostSetter(this, __e);
                    }
                }
            }
        }
        private DateTime? _Geburtstag;
		public event PropertyGetterHandler<Kistl.App.Projekte.Mitarbeiter, DateTime?> OnGeburtstag_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Projekte.Mitarbeiter, DateTime?> OnGeburtstag_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Projekte.Mitarbeiter, DateTime?> OnGeburtstag_PostSetter;
        /// <summary>
        /// Vorname Nachname
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string Name
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
                    __result = __e.Result;
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
                    if(OnName_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Name", __oldValue, __newValue);
                    _Name = __newValue;
                    NotifyPropertyChanged("Name", __oldValue, __newValue);
                    if(OnName_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Name;
		public event PropertyGetterHandler<Kistl.App.Projekte.Mitarbeiter, string> OnName_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Projekte.Mitarbeiter, string> OnName_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Projekte.Mitarbeiter, string> OnName_PostSetter;
        /// <summary>
        /// Projekte des Mitarbeiters für die er Verantwortlich ist
        /// </summary>
    /*
    Relation: FK_Projekt_haben_Mitarbeiter
    A: ZeroOrMore Projekt as Projekte
    B: ZeroOrMore Mitarbeiter as Mitarbeiter
    Preferred Storage: Separate
    */
        // collection reference property
		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public IList<Kistl.App.Projekte.Projekt> Projekte
        {
            get
            {
                if (_ProjekteWrapper == null)
                {
                    _ProjekteWrapper = new EntityRelationASideListWrapper<Kistl.App.Projekte.Projekt, Kistl.App.Projekte.Mitarbeiter, Kistl.App.Projekte.Projekt_haben_Mitarbeiter_RelationEntry__Implementation__>(
                            this,
                            Projekte__Implementation__);
                }
                return _ProjekteWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Projekt_haben_Mitarbeiter_Mitarbeiter", "CollectionEntry")]
        public EntityCollection<Kistl.App.Projekte.Projekt_haben_Mitarbeiter_RelationEntry__Implementation__> Projekte__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Projekte.Projekt_haben_Mitarbeiter_RelationEntry__Implementation__>(
                        "Model.FK_Projekt_haben_Mitarbeiter_Mitarbeiter",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityRelationASideListWrapper<Kistl.App.Projekte.Projekt, Kistl.App.Projekte.Mitarbeiter, Kistl.App.Projekte.Projekt_haben_Mitarbeiter_RelationEntry__Implementation__> _ProjekteWrapper;


        /// <summary>
        /// NNNN TTMMYY
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string SVNr
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _SVNr;
                if (OnSVNr_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnSVNr_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_SVNr != value)
                {
                    var __oldValue = _SVNr;
                    var __newValue = value;
                    if(OnSVNr_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnSVNr_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("SVNr", __oldValue, __newValue);
                    _SVNr = __newValue;
                    NotifyPropertyChanged("SVNr", __oldValue, __newValue);
                    if(OnSVNr_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnSVNr_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _SVNr;
		public event PropertyGetterHandler<Kistl.App.Projekte.Mitarbeiter, string> OnSVNr_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Projekte.Mitarbeiter, string> OnSVNr_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Projekte.Mitarbeiter, string> OnSVNr_PostSetter;
        /// <summary>
        /// +43 123 12345678
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string TelefonNummer
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _TelefonNummer;
                if (OnTelefonNummer_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnTelefonNummer_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_TelefonNummer != value)
                {
                    var __oldValue = _TelefonNummer;
                    var __newValue = value;
                    if(OnTelefonNummer_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnTelefonNummer_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("TelefonNummer", __oldValue, __newValue);
                    _TelefonNummer = __newValue;
                    NotifyPropertyChanged("TelefonNummer", __oldValue, __newValue);
                    if(OnTelefonNummer_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnTelefonNummer_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _TelefonNummer;
		public event PropertyGetterHandler<Kistl.App.Projekte.Mitarbeiter, string> OnTelefonNummer_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Projekte.Mitarbeiter, string> OnTelefonNummer_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Projekte.Mitarbeiter, string> OnTelefonNummer_PostSetter;
        /// <summary>
        /// 
        /// </summary>
		[EventBasedMethod("OnTestMethodForParameter_Mitarbeiter")]
		public virtual DateTime TestMethodForParameter(System.Boolean TestBool, System.Guid TestCLRObjectParameter, System.DateTime TestDateTime, System.Double TestDouble, System.Int32 TestInt, Kistl.App.Projekte.Auftrag TestObjectParameter, System.String TestString) 
        {
            var e = new MethodReturnEventArgs<DateTime>();
            if (OnTestMethodForParameter_Mitarbeiter != null)
            {
                OnTestMethodForParameter_Mitarbeiter(this, e, TestBool, TestCLRObjectParameter, TestDateTime, TestDouble, TestInt, TestObjectParameter, TestString);
            }
            else
            {
                throw new NotImplementedException("No handler registered on Mitarbeiter.TestMethodForParameter");
            }
            return e.Result;
        }
		public delegate void TestMethodForParameter_Handler<T>(T obj, MethodReturnEventArgs<DateTime> ret, System.Boolean TestBool, System.Guid TestCLRObjectParameter, System.DateTime TestDateTime, System.Double TestDouble, System.Int32 TestInt, Kistl.App.Projekte.Auftrag TestObjectParameter, System.String TestString);
		public event TestMethodForParameter_Handler<Mitarbeiter> OnTestMethodForParameter_Mitarbeiter;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Mitarbeiter));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Mitarbeiter)obj;
			var otherImpl = (Mitarbeiter__Implementation__)obj;
			var me = (Mitarbeiter)this;

			me.Geburtstag = other.Geburtstag;
			me.Name = other.Name;
			me.SVNr = other.SVNr;
			me.TelefonNummer = other.TelefonNummer;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_Mitarbeiter")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Mitarbeiter != null)
            {
                OnToString_Mitarbeiter(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<Mitarbeiter> OnToString_Mitarbeiter;

        [EventBasedMethod("OnPreSave_Mitarbeiter")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Mitarbeiter != null) OnPreSave_Mitarbeiter(this);
        }
        public event ObjectEventHandler<Mitarbeiter> OnPreSave_Mitarbeiter;

        [EventBasedMethod("OnPostSave_Mitarbeiter")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Mitarbeiter != null) OnPostSave_Mitarbeiter(this);
        }
        public event ObjectEventHandler<Mitarbeiter> OnPostSave_Mitarbeiter;

        [EventBasedMethod("OnCreated_Mitarbeiter")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_Mitarbeiter != null) OnCreated_Mitarbeiter(this);
        }
        public event ObjectEventHandler<Mitarbeiter> OnCreated_Mitarbeiter;

        [EventBasedMethod("OnDeleting_Mitarbeiter")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Mitarbeiter != null) OnDeleting_Mitarbeiter(this);
        }
        public event ObjectEventHandler<Mitarbeiter> OnDeleting_Mitarbeiter;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "Geburtstag":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("b10bf288-1252-49c3-9129-cfabb1637c47")).Constraints
						.Where(c => !c.IsValid(this, this.Geburtstag))
						.Select(c => c.GetErrorText(this, this.Geburtstag))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Name":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("5aab79fd-3083-4ce1-a558-ed1449ecddce")).Constraints
						.Where(c => !c.IsValid(this, this.Name))
						.Select(c => c.GetErrorText(this, this.Name))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Projekte":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("1abb5a1b-ba9f-4b75-b6ea-3d28be877b7c")).Constraints
						.Where(c => !c.IsValid(this, this.Projekte))
						.Select(c => c.GetErrorText(this, this.Projekte))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "SVNr":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("505988c4-dd50-4a0f-be21-a360b25e7d7d")).Constraints
						.Where(c => !c.IsValid(this, this.SVNr))
						.Select(c => c.GetErrorText(this, this.SVNr))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "TelefonNummer":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("73230333-f975-4f0b-9dd3-e850b48d9c13")).Constraints
						.Where(c => !c.IsValid(this, this.TelefonNummer))
						.Select(c => c.GetErrorText(this, this.TelefonNummer))
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
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._Geburtstag, binStream);
            BinarySerializer.ToStream(this._Name, binStream);
            BinarySerializer.ToStream(this._SVNr, binStream);
            BinarySerializer.ToStream(this._TelefonNummer, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._Geburtstag, binStream);
            BinarySerializer.FromStream(out this._Name, binStream);
            BinarySerializer.FromStream(out this._SVNr, binStream);
            BinarySerializer.FromStream(out this._TelefonNummer, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._Geburtstag, xml, "Geburtstag", "Kistl.App.Projekte");
            XmlStreamer.ToStream(this._Name, xml, "Name", "Kistl.App.Projekte");
            XmlStreamer.ToStream(this._SVNr, xml, "SVNr", "Kistl.App.Projekte");
            XmlStreamer.ToStream(this._TelefonNummer, xml, "TelefonNummer", "Kistl.App.Projekte");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._Geburtstag, xml, "Geburtstag", "Kistl.App.Projekte");
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "Kistl.App.Projekte");
            XmlStreamer.FromStream(ref this._SVNr, xml, "SVNr", "Kistl.App.Projekte");
            XmlStreamer.FromStream(ref this._TelefonNummer, xml, "TelefonNummer", "Kistl.App.Projekte");
        }

#endregion

    }


}