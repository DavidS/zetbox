//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.1433
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

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
    using Kistl.API.Client;
    
    
    public class Auftrag : BaseClientDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private int _fk_Projekt = Helper.INVALIDID;
        
        private int _fk_Mitarbeiter = Helper.INVALIDID;
        
        private string _Auftragsname;
        
        private int _fk_Kunde = Helper.INVALIDID;
        
        private System.Nullable<double> _Auftragswert;
        
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
        
        [System.Diagnostics.DebuggerHidden()]
        [XmlIgnore()]
        public Kistl.App.Projekte.Projekt Projekt
        {
            get
            {
                return Context.GetQuery<Kistl.App.Projekte.Projekt>().Single(o => o.ID == fk_Projekt);
            }
            set
            {
                _fk_Projekt = value.ID;
            }
        }
        
        public int fk_Projekt
        {
            get
            {
                return _fk_Projekt;
            }
            set
            {
                _fk_Projekt = value;
            }
        }
        
        [System.Diagnostics.DebuggerHidden()]
        [XmlIgnore()]
        public Kistl.App.Projekte.Mitarbeiter Mitarbeiter
        {
            get
            {
                return Context.GetQuery<Kistl.App.Projekte.Mitarbeiter>().Single(o => o.ID == fk_Mitarbeiter);
            }
            set
            {
                _fk_Mitarbeiter = value.ID;
            }
        }
        
        public int fk_Mitarbeiter
        {
            get
            {
                return _fk_Mitarbeiter;
            }
            set
            {
                _fk_Mitarbeiter = value;
            }
        }
        
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
        
        [System.Diagnostics.DebuggerHidden()]
        [XmlIgnore()]
        public Kistl.App.Projekte.Kunde Kunde
        {
            get
            {
                return Context.GetQuery<Kistl.App.Projekte.Kunde>().Single(o => o.ID == fk_Kunde);
            }
            set
            {
                _fk_Kunde = value.ID;
            }
        }
        
        public int fk_Kunde
        {
            get
            {
                return _fk_Kunde;
            }
            set
            {
                _fk_Kunde = value;
            }
        }
        
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
        
        public delegate void RechnungErstellen_Handler<T>(T obj, MethodReturnEventArgs<string> e);
    }
}
