//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kistl.App.Projekte
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Collections;
    using System.Xml;
    using System.Xml.Serialization;
    using Kistl.API;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Kistl.API.Client;
    
    
    public class Auftrag : BaseClientDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private int _fk_Projekt = Helper.INVALIDID;
        
        private int _fk_Mitarbeiter = Helper.INVALIDID;
        
        private string _Auftragsname;
        
        private int _fk_Kunde = Helper.INVALIDID;
        
        private System.Double? _Auftragswert;
        
        public Auftrag()
        {
        }
        
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
        
        [XmlIgnore()]
        public Kistl.App.Projekte.Projekt Projekt
        {
            get
            {
                return Context.GetQuery<Kistl.App.Projekte.Projekt>().Single(o => o.ID == fk_Projekt);
            }
            set
            {
                NotifyPropertyChanging("Projekt"); 
                _fk_Projekt = value.ID;
                NotifyPropertyChanged("Projekt"); ;
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
                NotifyPropertyChanging("Projekt"); 
                _fk_Projekt = value;
                NotifyPropertyChanged("Projekt"); ;
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Projekte.Mitarbeiter Mitarbeiter
        {
            get
            {
                return Context.GetQuery<Kistl.App.Projekte.Mitarbeiter>().Single(o => o.ID == fk_Mitarbeiter);
            }
            set
            {
                NotifyPropertyChanging("Mitarbeiter"); 
                _fk_Mitarbeiter = value.ID;
                NotifyPropertyChanged("Mitarbeiter"); ;
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
                NotifyPropertyChanging("Mitarbeiter"); 
                _fk_Mitarbeiter = value;
                NotifyPropertyChanged("Mitarbeiter"); ;
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
                NotifyPropertyChanging("Auftragsname"); 
                _Auftragsname = value; 
                NotifyPropertyChanged("Auftragsname");;
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Projekte.Kunde Kunde
        {
            get
            {
                return Context.GetQuery<Kistl.App.Projekte.Kunde>().Single(o => o.ID == fk_Kunde);
            }
            set
            {
                NotifyPropertyChanging("Kunde"); 
                _fk_Kunde = value.ID;
                NotifyPropertyChanged("Kunde"); ;
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
                NotifyPropertyChanging("Kunde"); 
                _fk_Kunde = value;
                NotifyPropertyChanged("Kunde"); ;
            }
        }
        
        public System.Double? Auftragswert
        {
            get
            {
                return _Auftragswert;
            }
            set
            {
                NotifyPropertyChanging("Auftragswert"); 
                _Auftragswert = value; 
                NotifyPropertyChanged("Auftragswert");;
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
        
        public override void CopyTo(Kistl.API.IDataObject obj)
        {
            base.CopyTo(obj);
            ((Auftrag)obj)._fk_Projekt = this._fk_Projekt;
            ((Auftrag)obj)._fk_Mitarbeiter = this._fk_Mitarbeiter;
            ((Auftrag)obj)._Auftragsname = this._Auftragsname;
            ((Auftrag)obj)._fk_Kunde = this._fk_Kunde;
            ((Auftrag)obj)._Auftragswert = this._Auftragswert;
        }
        
        public override void AttachToContext(KistlContext ctx)
        {
            base.AttachToContext(ctx);
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
            BinarySerializer.ToBinary(this._Auftragsname, sw);
            BinarySerializer.ToBinary(this.fk_Kunde, sw);
            BinarySerializer.ToBinary(this._Auftragswert, sw);
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
