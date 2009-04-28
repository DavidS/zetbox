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
            {
            }
        }

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        public override int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_ID != value)
                {
					var __oldValue = _ID;
                    NotifyPropertyChanging("ID", __oldValue, value);
                    _ID = value;
                    NotifyPropertyChanged("ID", __oldValue, value);
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
        public virtual string Auftragsname
        {
            get
            {
                return _Auftragsname;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_Auftragsname != value)
                {
					var __oldValue = _Auftragsname;
                    NotifyPropertyChanging("Auftragsname", __oldValue, value);
                    _Auftragsname = value;
                    NotifyPropertyChanged("Auftragsname", __oldValue, value);
                }
            }
        }
        private string _Auftragsname;

        /// <summary>
        /// Wert in EUR des Auftrages
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public virtual double? Auftragswert
        {
            get
            {
                return _Auftragswert;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_Auftragswert != value)
                {
					var __oldValue = _Auftragswert;
                    NotifyPropertyChanging("Auftragswert", __oldValue, value);
                    _Auftragswert = value;
                    NotifyPropertyChanged("Auftragswert", __oldValue, value);
                }
            }
        }
        private double? _Auftragswert;

        /// <summary>
        /// Kunde des Projektes
        /// </summary>
    /*
    Relation: FK_Auftrag_Kunde_Auftrag_34
    A: ZeroOrMore Auftrag as Auftrag
    B: ZeroOrOne Kunde as Kunde
    Preferred Storage: Left
    */
        // object reference property
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
                if (IsReadonly) throw new ReadOnlyObjectException();
                Kunde__Implementation__ = (Kistl.App.Projekte.Kunde__Implementation__)value;
            }
        }
        
        // provide a way to directly access the foreign key int
        public int? fk_Kunde
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) 
                    && Kunde != null)
                {
                    _fk_Kunde = Kunde.ID;
                }
                return _fk_Kunde;
            }
            set
            {
                _fk_Kunde = value;
            }
        }
        private int? _fk_Kunde;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Auftrag_Kunde_Auftrag_34", "Kunde")]
        public Kistl.App.Projekte.Kunde__Implementation__ Kunde__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Projekte.Kunde__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Kunde__Implementation__>(
                        "Model.FK_Auftrag_Kunde_Auftrag_34",
                        "Kunde");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Projekte.Kunde__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Kunde__Implementation__>(
                        "Model.FK_Auftrag_Kunde_Auftrag_34",
                        "Kunde");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.Projekte.Kunde__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Auftrag_Mitarbeiter_Auftrag_29
    A: ZeroOrMore Auftrag as Auftrag
    B: ZeroOrOne Mitarbeiter as Mitarbeiter
    Preferred Storage: Left
    */
        // object reference property
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
                if (IsReadonly) throw new ReadOnlyObjectException();
                Mitarbeiter__Implementation__ = (Kistl.App.Projekte.Mitarbeiter__Implementation__)value;
            }
        }
        
        // provide a way to directly access the foreign key int
        public int? fk_Mitarbeiter
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) 
                    && Mitarbeiter != null)
                {
                    _fk_Mitarbeiter = Mitarbeiter.ID;
                }
                return _fk_Mitarbeiter;
            }
            set
            {
                _fk_Mitarbeiter = value;
            }
        }
        private int? _fk_Mitarbeiter;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Auftrag_Mitarbeiter_Auftrag_29", "Mitarbeiter")]
        public Kistl.App.Projekte.Mitarbeiter__Implementation__ Mitarbeiter__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Projekte.Mitarbeiter__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Mitarbeiter__Implementation__>(
                        "Model.FK_Auftrag_Mitarbeiter_Auftrag_29",
                        "Mitarbeiter");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Projekte.Mitarbeiter__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Mitarbeiter__Implementation__>(
                        "Model.FK_Auftrag_Mitarbeiter_Auftrag_29",
                        "Mitarbeiter");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.Projekte.Mitarbeiter__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// Projekt zum Auftrag
        /// </summary>
    /*
    Relation: FK_Projekt_Auftrag_Projekt_30
    A: ZeroOrOne Projekt as Projekt
    B: ZeroOrMore Auftrag as Auftraege
    Preferred Storage: Right
    */
        // object reference property
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
                if (IsReadonly) throw new ReadOnlyObjectException();
                Projekt__Implementation__ = (Kistl.App.Projekte.Projekt__Implementation__)value;
            }
        }
        
        // provide a way to directly access the foreign key int
        public int? fk_Projekt
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) 
                    && Projekt != null)
                {
                    _fk_Projekt = Projekt.ID;
                }
                return _fk_Projekt;
            }
            set
            {
                _fk_Projekt = value;
            }
        }
        private int? _fk_Projekt;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Projekt_Auftrag_Projekt_30", "Projekt")]
        public Kistl.App.Projekte.Projekt__Implementation__ Projekt__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Projekte.Projekt__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Projekt__Implementation__>(
                        "Model.FK_Projekt_Auftrag_Projekt_30",
                        "Projekt");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Projekte.Projekt__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Projekt__Implementation__>(
                        "Model.FK_Projekt_Auftrag_Projekt_30",
                        "Projekt");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.Projekte.Projekt__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// Testmethode zum Erstellen von Rechnungen mit Word
        /// </summary>

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
			this.fk_Kunde = otherImpl.fk_Kunde;
			this.fk_Mitarbeiter = otherImpl.fk_Mitarbeiter;
			this.fk_Projekt = otherImpl.fk_Projekt;
		}

        // tail template

        [System.Diagnostics.DebuggerHidden()]
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

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Auftrag != null) OnPreSave_Auftrag(this);
        }
        public event ObjectEventHandler<Auftrag> OnPreSave_Auftrag;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Auftrag != null) OnPostSave_Auftrag(this);
        }
        public event ObjectEventHandler<Auftrag> OnPostSave_Auftrag;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "Auftragsname":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(50).Constraints
						.Where(c => !c.IsValid(this, this.Auftragsname))
						.Select(c => c.GetErrorText(this, this.Auftragsname))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Auftragswert":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(65).Constraints
						.Where(c => !c.IsValid(this, this.Auftragswert))
						.Select(c => c.GetErrorText(this, this.Auftragswert))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Kunde":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(64).Constraints
						.Where(c => !c.IsValid(this, this.Kunde))
						.Select(c => c.GetErrorText(this, this.Kunde))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Mitarbeiter":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(49).Constraints
						.Where(c => !c.IsValid(this, this.Mitarbeiter))
						.Select(c => c.GetErrorText(this, this.Mitarbeiter))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Projekt":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(51).Constraints
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
			// fix direct object references
			if (_fk_Mitarbeiter.HasValue)
				Mitarbeiter__Implementation__ = (Kistl.App.Projekte.Mitarbeiter__Implementation__)Context.Find<Kistl.App.Projekte.Mitarbeiter>(_fk_Mitarbeiter.Value);
			else
				Mitarbeiter__Implementation__ = null;
			if (_fk_Projekt.HasValue)
				Projekt__Implementation__ = (Kistl.App.Projekte.Projekt__Implementation__)Context.Find<Kistl.App.Projekte.Projekt>(_fk_Projekt.Value);
			else
				Projekt__Implementation__ = null;
			if (_fk_Kunde.HasValue)
				Kunde__Implementation__ = (Kistl.App.Projekte.Kunde__Implementation__)Context.Find<Kistl.App.Projekte.Kunde>(_fk_Kunde.Value);
			else
				Kunde__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream)
        {
            base.ToStream(binStream);
            BinarySerializer.ToStream(this._Auftragsname, binStream);
            BinarySerializer.ToStream(this._Auftragswert, binStream);
            BinarySerializer.ToStream(this.fk_Kunde, binStream);
            BinarySerializer.ToStream(this.fk_Mitarbeiter, binStream);
            BinarySerializer.ToStream(this.fk_Projekt, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._Auftragsname, binStream);
            BinarySerializer.FromStream(out this._Auftragswert, binStream);
            {
                var tmp = this.fk_Kunde;
                BinarySerializer.FromStream(out tmp, binStream);
                this.fk_Kunde = tmp;
            }
            {
                var tmp = this.fk_Mitarbeiter;
                BinarySerializer.FromStream(out tmp, binStream);
                this.fk_Mitarbeiter = tmp;
            }
            {
                var tmp = this.fk_Projekt;
                BinarySerializer.FromStream(out tmp, binStream);
                this.fk_Projekt = tmp;
            }
        }

        public override void ToStream(System.Xml.XmlWriter xml, string[] modules)
        {
            base.ToStream(xml, modules);
            XmlStreamer.ToStream(this._Auftragsname, xml, "Auftragsname", "Kistl.App.Projekte");
            XmlStreamer.ToStream(this._Auftragswert, xml, "Auftragswert", "Kistl.App.Projekte");
            XmlStreamer.ToStream(this.fk_Kunde, xml, "Kunde", "http://dasz.at/Kistl");
            XmlStreamer.ToStream(this.fk_Mitarbeiter, xml, "Mitarbeiter", "http://dasz.at/Kistl");
            XmlStreamer.ToStream(this.fk_Projekt, xml, "Projekt", "http://dasz.at/Kistl");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._Auftragsname, xml, "Auftragsname", "Kistl.App.Projekte");
            XmlStreamer.FromStream(ref this._Auftragswert, xml, "Auftragswert", "Kistl.App.Projekte");
            {
                var tmp = this.fk_Kunde;
                XmlStreamer.FromStream(ref tmp, xml, "Kunde", "http://dasz.at/Kistl");
                this.fk_Kunde = tmp;
            }
            {
                var tmp = this.fk_Mitarbeiter;
                XmlStreamer.FromStream(ref tmp, xml, "Mitarbeiter", "http://dasz.at/Kistl");
                this.fk_Mitarbeiter = tmp;
            }
            {
                var tmp = this.fk_Projekt;
                XmlStreamer.FromStream(ref tmp, xml, "Projekt", "http://dasz.at/Kistl");
                this.fk_Projekt = tmp;
            }
        }

#endregion

    }


}