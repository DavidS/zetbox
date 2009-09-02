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
    [EdmEntityType(NamespaceName="Model", Name="Auftrag")]
    [System.Diagnostics.DebuggerDisplay("Auftrag")]
    public class Auftrag__Implementation__ : BaseServerDataObject_EntityFramework, Auftrag
    {
    
		public Auftrag__Implementation__()
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
        /// Bitte füllen Sie einen sprechenden Auftragsnamen aus
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string Auftragsname
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Auftragsname;
                if (OnAuftragsname_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnAuftragsname_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Auftragsname != value)
                {
                    var __oldValue = _Auftragsname;
                    var __newValue = value;
                    if(OnAuftragsname_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnAuftragsname_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Auftragsname", __oldValue, __newValue);
                    _Auftragsname = __newValue;
                    NotifyPropertyChanged("Auftragsname", __oldValue, __newValue);
                    if(OnAuftragsname_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnAuftragsname_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Auftragsname;
		public event PropertyGetterHandler<Kistl.App.Projekte.Auftrag, string> OnAuftragsname_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Projekte.Auftrag, string> OnAuftragsname_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Projekte.Auftrag, string> OnAuftragsname_PostSetter;
        /// <summary>
        /// Wert in EUR des Auftrages
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual double? Auftragswert
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Auftragswert;
                if (OnAuftragswert_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<double?>(__result);
                    OnAuftragswert_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Auftragswert != value)
                {
                    var __oldValue = _Auftragswert;
                    var __newValue = value;
                    if(OnAuftragswert_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<double?>(__oldValue, __newValue);
                        OnAuftragswert_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Auftragswert", __oldValue, __newValue);
                    _Auftragswert = __newValue;
                    NotifyPropertyChanged("Auftragswert", __oldValue, __newValue);
                    if(OnAuftragswert_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<double?>(__oldValue, __newValue);
                        OnAuftragswert_PostSetter(this, __e);
                    }
                }
            }
        }
        private double? _Auftragswert;
		public event PropertyGetterHandler<Kistl.App.Projekte.Auftrag, double?> OnAuftragswert_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Projekte.Auftrag, double?> OnAuftragswert_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Projekte.Auftrag, double?> OnAuftragswert_PostSetter;
        /// <summary>
        /// Kunde des Projektes
        /// </summary>
    /*
    Relation: FK_Auftrag_has_Kunde
    A: ZeroOrMore Auftrag as Auftrag
    B: ZeroOrOne Kunde as Kunde
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Projekte.Kunde Kunde
        {
            get
            {
                return Kunde__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                Kunde__Implementation__ = (Kistl.App.Projekte.Kunde__Implementation__)value;
            }
        }
        
        private int? _fk_Kunde;
        private Guid? _fk_guid_Kunde = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Auftrag_has_Kunde", "Kunde")]
        public Kistl.App.Projekte.Kunde__Implementation__ Kunde__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Projekte.Kunde__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Kunde__Implementation__>(
                        "Model.FK_Auftrag_has_Kunde",
                        "Kunde");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnKunde_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Projekte.Kunde>(__value);
					OnKunde_Getter(this, e);
					__value = (Kistl.App.Projekte.Kunde__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Projekte.Kunde__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Kunde__Implementation__>(
                        "Model.FK_Auftrag_has_Kunde",
                        "Kunde");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Projekte.Kunde __oldValue = (Kistl.App.Projekte.Kunde)r.Value;
                Kistl.App.Projekte.Kunde __newValue = (Kistl.App.Projekte.Kunde)value;

                if(OnKunde_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Projekte.Kunde>(__oldValue, __newValue);
					OnKunde_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Projekte.Kunde__Implementation__)__newValue;
                if(OnKunde_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Projekte.Kunde>(__oldValue, __newValue);
					OnKunde_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.Projekte.Auftrag, Kistl.App.Projekte.Kunde> OnKunde_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Projekte.Auftrag, Kistl.App.Projekte.Kunde> OnKunde_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Projekte.Auftrag, Kistl.App.Projekte.Kunde> OnKunde_PostSetter;
        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Auftrag_has_Mitarbeiter
    A: ZeroOrMore Auftrag as Auftrag
    B: ZeroOrOne Mitarbeiter as Mitarbeiter
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Projekte.Mitarbeiter Mitarbeiter
        {
            get
            {
                return Mitarbeiter__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                Mitarbeiter__Implementation__ = (Kistl.App.Projekte.Mitarbeiter__Implementation__)value;
            }
        }
        
        private int? _fk_Mitarbeiter;
        private Guid? _fk_guid_Mitarbeiter = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Auftrag_has_Mitarbeiter", "Mitarbeiter")]
        public Kistl.App.Projekte.Mitarbeiter__Implementation__ Mitarbeiter__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Projekte.Mitarbeiter__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Mitarbeiter__Implementation__>(
                        "Model.FK_Auftrag_has_Mitarbeiter",
                        "Mitarbeiter");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnMitarbeiter_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Projekte.Mitarbeiter>(__value);
					OnMitarbeiter_Getter(this, e);
					__value = (Kistl.App.Projekte.Mitarbeiter__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Projekte.Mitarbeiter__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Mitarbeiter__Implementation__>(
                        "Model.FK_Auftrag_has_Mitarbeiter",
                        "Mitarbeiter");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Projekte.Mitarbeiter __oldValue = (Kistl.App.Projekte.Mitarbeiter)r.Value;
                Kistl.App.Projekte.Mitarbeiter __newValue = (Kistl.App.Projekte.Mitarbeiter)value;

                if(OnMitarbeiter_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Projekte.Mitarbeiter>(__oldValue, __newValue);
					OnMitarbeiter_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Projekte.Mitarbeiter__Implementation__)__newValue;
                if(OnMitarbeiter_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Projekte.Mitarbeiter>(__oldValue, __newValue);
					OnMitarbeiter_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.Projekte.Auftrag, Kistl.App.Projekte.Mitarbeiter> OnMitarbeiter_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Projekte.Auftrag, Kistl.App.Projekte.Mitarbeiter> OnMitarbeiter_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Projekte.Auftrag, Kistl.App.Projekte.Mitarbeiter> OnMitarbeiter_PostSetter;
        /// <summary>
        /// Projekt zum Auftrag
        /// </summary>
    /*
    Relation: FK_Projekt_has_Auftrag
    A: ZeroOrOne Projekt as Projekt
    B: ZeroOrMore Auftrag as Auftraege
    Preferred Storage: MergeIntoB
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Projekte.Projekt Projekt
        {
            get
            {
                return Projekt__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                Projekt__Implementation__ = (Kistl.App.Projekte.Projekt__Implementation__)value;
            }
        }
        
        private int? _fk_Projekt;
        private Guid? _fk_guid_Projekt = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Projekt_has_Auftrag", "Projekt")]
        public Kistl.App.Projekte.Projekt__Implementation__ Projekt__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Projekte.Projekt__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Projekt__Implementation__>(
                        "Model.FK_Projekt_has_Auftrag",
                        "Projekt");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnProjekt_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Projekte.Projekt>(__value);
					OnProjekt_Getter(this, e);
					__value = (Kistl.App.Projekte.Projekt__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Projekte.Projekt__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Projekt__Implementation__>(
                        "Model.FK_Projekt_has_Auftrag",
                        "Projekt");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Projekte.Projekt __oldValue = (Kistl.App.Projekte.Projekt)r.Value;
                Kistl.App.Projekte.Projekt __newValue = (Kistl.App.Projekte.Projekt)value;

                if(OnProjekt_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Projekte.Projekt>(__oldValue, __newValue);
					OnProjekt_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Projekte.Projekt__Implementation__)__newValue;
                if(OnProjekt_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Projekte.Projekt>(__oldValue, __newValue);
					OnProjekt_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.Projekte.Auftrag, Kistl.App.Projekte.Projekt> OnProjekt_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Projekte.Auftrag, Kistl.App.Projekte.Projekt> OnProjekt_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Projekte.Auftrag, Kistl.App.Projekte.Projekt> OnProjekt_PostSetter;
        /// <summary>
        /// Testmethode zum Erstellen von Rechnungen mit Word
        /// </summary>
		[EventBasedMethod("OnRechnungErstellen_Auftrag")]
		public virtual void RechnungErstellen() 
		{
            // base.RechnungErstellen();
            if (OnRechnungErstellen_Auftrag != null)
            {
				OnRechnungErstellen_Auftrag(this);
			}
			else
			{
                throw new NotImplementedException("No handler registered on Auftrag.RechnungErstellen");
			}
        }
		public delegate void RechnungErstellen_Handler<T>(T obj);
		public event RechnungErstellen_Handler<Auftrag> OnRechnungErstellen_Auftrag;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Auftrag));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Auftrag)obj;
			var otherImpl = (Auftrag__Implementation__)obj;
			var me = (Auftrag)this;

			me.Auftragsname = other.Auftragsname;
			me.Auftragswert = other.Auftragswert;
			this._fk_Kunde = otherImpl._fk_Kunde;
			this._fk_Mitarbeiter = otherImpl._fk_Mitarbeiter;
			this._fk_Projekt = otherImpl._fk_Projekt;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_Auftrag")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Auftrag != null)
            {
                OnToString_Auftrag(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<Auftrag> OnToString_Auftrag;

        [EventBasedMethod("OnPreSave_Auftrag")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Auftrag != null) OnPreSave_Auftrag(this);
        }
        public event ObjectEventHandler<Auftrag> OnPreSave_Auftrag;

        [EventBasedMethod("OnPostSave_Auftrag")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Auftrag != null) OnPostSave_Auftrag(this);
        }
        public event ObjectEventHandler<Auftrag> OnPostSave_Auftrag;

        [EventBasedMethod("OnCreated_Auftrag")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_Auftrag != null) OnCreated_Auftrag(this);
        }
        public event ObjectEventHandler<Auftrag> OnCreated_Auftrag;

        [EventBasedMethod("OnDeleting_Auftrag")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Auftrag != null) OnDeleting_Auftrag(this);
        }
        public event ObjectEventHandler<Auftrag> OnDeleting_Auftrag;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "Auftragsname":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("aaffed82-1f4c-4c0f-a52d-3ca4dbdefe94")).Constraints
						.Where(c => !c.IsValid(this, this.Auftragsname))
						.Select(c => c.GetErrorText(this, this.Auftragsname))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Auftragswert":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("f252395f-7867-4299-9965-66f7a7b8f3c5")).Constraints
						.Where(c => !c.IsValid(this, this.Auftragswert))
						.Select(c => c.GetErrorText(this, this.Auftragswert))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Kunde":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("57c977da-c113-4ce6-9484-3828f74c4193")).Constraints
						.Where(c => !c.IsValid(this, this.Kunde))
						.Select(c => c.GetErrorText(this, this.Kunde))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Mitarbeiter":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("5b57288b-835a-459e-8532-9f47e17ab2b5")).Constraints
						.Where(c => !c.IsValid(this, this.Mitarbeiter))
						.Select(c => c.GetErrorText(this, this.Mitarbeiter))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Projekt":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("a0ad574a-356b-4962-a98d-c305b1289154")).Constraints
						.Where(c => !c.IsValid(this, this.Projekt))
						.Select(c => c.GetErrorText(this, this.Projekt))
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

			if (_fk_guid_Kunde.HasValue)
				Kunde__Implementation__ = (Kistl.App.Projekte.Kunde__Implementation__)Context.FindPersistenceObject<Kistl.App.Projekte.Kunde>(_fk_guid_Kunde.Value);
			else if (_fk_Kunde.HasValue)
				Kunde__Implementation__ = (Kistl.App.Projekte.Kunde__Implementation__)Context.Find<Kistl.App.Projekte.Kunde>(_fk_Kunde.Value);
			else
				Kunde__Implementation__ = null;

			if (_fk_guid_Mitarbeiter.HasValue)
				Mitarbeiter__Implementation__ = (Kistl.App.Projekte.Mitarbeiter__Implementation__)Context.FindPersistenceObject<Kistl.App.Projekte.Mitarbeiter>(_fk_guid_Mitarbeiter.Value);
			else if (_fk_Mitarbeiter.HasValue)
				Mitarbeiter__Implementation__ = (Kistl.App.Projekte.Mitarbeiter__Implementation__)Context.Find<Kistl.App.Projekte.Mitarbeiter>(_fk_Mitarbeiter.Value);
			else
				Mitarbeiter__Implementation__ = null;

			if (_fk_guid_Projekt.HasValue)
				Projekt__Implementation__ = (Kistl.App.Projekte.Projekt__Implementation__)Context.FindPersistenceObject<Kistl.App.Projekte.Projekt>(_fk_guid_Projekt.Value);
			else if (_fk_Projekt.HasValue)
				Projekt__Implementation__ = (Kistl.App.Projekte.Projekt__Implementation__)Context.Find<Kistl.App.Projekte.Projekt>(_fk_Projekt.Value);
			else
				Projekt__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._Auftragsname, binStream);
            BinarySerializer.ToStream(this._Auftragswert, binStream);
            BinarySerializer.ToStream(Kunde != null ? Kunde.ID : (int?)null, binStream);
            BinarySerializer.ToStream(Mitarbeiter != null ? Mitarbeiter.ID : (int?)null, binStream);
            BinarySerializer.ToStream(Projekt != null ? Projekt.ID : (int?)null, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._Auftragsname, binStream);
            BinarySerializer.FromStream(out this._Auftragswert, binStream);
            BinarySerializer.FromStream(out this._fk_Kunde, binStream);
            BinarySerializer.FromStream(out this._fk_Mitarbeiter, binStream);
            BinarySerializer.FromStream(out this._fk_Projekt, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._Auftragsname, xml, "Auftragsname", "Kistl.App.Projekte");
            XmlStreamer.ToStream(this._Auftragswert, xml, "Auftragswert", "Kistl.App.Projekte");
            XmlStreamer.ToStream(Kunde != null ? Kunde.ID : (int?)null, xml, "Kunde", "Kistl.App.Projekte");
            XmlStreamer.ToStream(Mitarbeiter != null ? Mitarbeiter.ID : (int?)null, xml, "Mitarbeiter", "Kistl.App.Projekte");
            XmlStreamer.ToStream(Projekt != null ? Projekt.ID : (int?)null, xml, "Projekt", "Kistl.App.Projekte");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._Auftragsname, xml, "Auftragsname", "Kistl.App.Projekte");
            XmlStreamer.FromStream(ref this._Auftragswert, xml, "Auftragswert", "Kistl.App.Projekte");
            XmlStreamer.FromStream(ref this._fk_Kunde, xml, "Kunde", "Kistl.App.Projekte");
            XmlStreamer.FromStream(ref this._fk_Mitarbeiter, xml, "Mitarbeiter", "Kistl.App.Projekte");
            XmlStreamer.FromStream(ref this._fk_Projekt, xml, "Projekt", "Kistl.App.Projekte");
        }

#endregion

    }


}