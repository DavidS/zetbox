//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.1433
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_Auftrag_Projekt", "A_Projekt", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Projekte.Projekt), "B_Auftrag", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Projekte.Auftrag))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_Auftrag_Mitarbeiter", "A_Mitarbeiter", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Projekte.Mitarbeiter), "B_Auftrag", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Projekte.Auftrag))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_Auftrag_Kunde", "A_Kunde", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Projekte.Kunde), "B_Auftrag", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Projekte.Auftrag))]

namespace Kistl.App.Projekte
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Collections;
    using System.Xml;
    using System.Xml.Serialization;
    using Kistl.API;
    using Kistl.API.Server;
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Auftrag")]
    public class Auftrag : BaseServerDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private int _fk_Projekt = Helper.INVALIDID;
        
        private int _fk_Mitarbeiter = Helper.INVALIDID;
        
        private string _Auftragsname;
        
        private int _fk_Kunde = Helper.INVALIDID;
        
        private System.Nullable<double> _Auftragswert;
        
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        public override int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }
        
        public override string EntitySetName
        {
            get
            {
                return "Auftrag";
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Auftrag_Projekt", "A_Projekt")]
        [XmlIgnore()]
        public Kistl.App.Projekte.Projekt Projekt
        {
            get
            {
                EntityReference<Kistl.App.Projekte.Projekt> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Projekt>("Model.FK_Auftrag_Projekt", "A_Projekt");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Projekte.Projekt> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Projekt>("Model.FK_Auftrag_Projekt", "A_Projekt");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public int fk_Projekt
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && _fk_Projekt == Helper.INVALIDID && Projekt != null)
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
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Auftrag_Mitarbeiter", "A_Mitarbeiter")]
        [XmlIgnore()]
        public Kistl.App.Projekte.Mitarbeiter Mitarbeiter
        {
            get
            {
                EntityReference<Kistl.App.Projekte.Mitarbeiter> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Mitarbeiter>("Model.FK_Auftrag_Mitarbeiter", "A_Mitarbeiter");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Projekte.Mitarbeiter> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Mitarbeiter>("Model.FK_Auftrag_Mitarbeiter", "A_Mitarbeiter");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public int fk_Mitarbeiter
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && _fk_Mitarbeiter == Helper.INVALIDID && Mitarbeiter != null)
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
        
        [EdmScalarPropertyAttribute()]
        public string Auftragsname
        {
            get
            {
                return _Auftragsname;
            }
            set
            {
                _Auftragsname = value;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Auftrag_Kunde", "A_Kunde")]
        [XmlIgnore()]
        public Kistl.App.Projekte.Kunde Kunde
        {
            get
            {
                EntityReference<Kistl.App.Projekte.Kunde> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Kunde>("Model.FK_Auftrag_Kunde", "A_Kunde");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Projekte.Kunde> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Kunde>("Model.FK_Auftrag_Kunde", "A_Kunde");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public int fk_Kunde
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && _fk_Kunde == Helper.INVALIDID && Kunde != null)
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
        
        [EdmScalarPropertyAttribute()]
        public System.Nullable<double> Auftragswert
        {
            get
            {
                return _Auftragswert;
            }
            set
            {
                _Auftragswert = value;
            }
        }
        
        public event ToStringHandler<Auftrag> OnToString_Auftrag;
        
        public event ObjectEventHandler<Auftrag> OnPreSave_Auftrag;
        
        public event ObjectEventHandler<Auftrag> OnPostSave_Auftrag;
        
        public event RechnungErstellen_Handler<Auftrag> OnRechnungErstellen_Auftrag;
        
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
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Auftrag != null) OnPreSave_Auftrag(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Auftrag != null) OnPostSave_Auftrag(this);
        }
        
        public override object Clone()
        {
            Auftrag obj = new Auftrag();
            CopyTo(obj);
            return obj;
        }
        
        public void CopyTo(Auftrag obj)
        {
            base.CopyTo(obj);
            obj.fk_Projekt = this.fk_Projekt;
            obj.fk_Mitarbeiter = this.fk_Mitarbeiter;
            obj.Auftragsname = this.Auftragsname;
            obj.fk_Kunde = this.fk_Kunde;
            obj.Auftragswert = this.Auftragswert;
        }
        
        public virtual string RechnungErstellen()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            if (OnRechnungErstellen_Auftrag != null)
            {
                OnRechnungErstellen_Auftrag(this, e);
            }
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Projekt, sw);
            BinarySerializer.ToBinary(this.fk_Mitarbeiter, sw);
            BinarySerializer.ToBinary(this.Auftragsname, sw);
            BinarySerializer.ToBinary(this.fk_Kunde, sw);
            BinarySerializer.ToBinary(this.Auftragswert, sw);
        }
        
        public override void FromStream(Kistl.API.IKistlContext ctx, System.IO.BinaryReader sr)
        {
            base.FromStream(ctx, sr);
            BinarySerializer.FromBinary(out this._fk_Projekt, sr);
            BinarySerializer.FromBinary(out this._fk_Mitarbeiter, sr);
            BinarySerializer.FromBinary(out this._Auftragsname, sr);
            BinarySerializer.FromBinary(out this._fk_Kunde, sr);
            BinarySerializer.FromBinary(out this._Auftragswert, sr);
        }
        
        public delegate void RechnungErstellen_Handler<T>(T obj, MethodReturnEventArgs<string> e);
    }
}
