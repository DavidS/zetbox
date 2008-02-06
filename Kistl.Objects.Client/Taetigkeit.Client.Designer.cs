//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.1433
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kistl.App.Zeiterfassung
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
    
    
    public class Taetigkeit : BaseClientDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private int _fk_Zeitkonto = Helper.INVALIDID;
        
        private int _fk_Mitarbeiter = Helper.INVALIDID;
        
        private System.DateTime _Datum;
        
        private double _Dauer;
        
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
        public Kistl.App.Zeiterfassung.Zeitkonto Zeitkonto
        {
            get
            {
                return Context.GetQuery<Kistl.App.Zeiterfassung.Zeitkonto>().Single(o => o.ID == fk_Zeitkonto);
            }
            set
            {
                _fk_Zeitkonto = value.ID;
            }
        }
        
        public int fk_Zeitkonto
        {
            get
            {
                return _fk_Zeitkonto;
            }
            set
            {
                _fk_Zeitkonto = value;
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
        
        public System.DateTime Datum
        {
            get
            {
                return _Datum;
            }
            set
            {
                _Datum = value;
            }
        }
        
        public double Dauer
        {
            get
            {
                return _Dauer;
            }
            set
            {
                _Dauer = value;
            }
        }
        
        public event ToStringHandler<Taetigkeit> OnToString_Taetigkeit;
        
        public event ObjectEventHandler<Taetigkeit> OnPreSave_Taetigkeit;
        
        public event ObjectEventHandler<Taetigkeit> OnPostSave_Taetigkeit;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Taetigkeit != null)
            {
                OnToString_Taetigkeit(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Taetigkeit != null) OnPreSave_Taetigkeit(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Taetigkeit != null) OnPostSave_Taetigkeit(this);
        }
        
        public override object Clone()
        {
            Taetigkeit obj = new Taetigkeit();
            CopyTo(obj);
            return obj;
        }
        
        public void CopyTo(Taetigkeit obj)
        {
            base.CopyTo(obj);
            obj.fk_Zeitkonto = this.fk_Zeitkonto;
            obj.fk_Mitarbeiter = this.fk_Mitarbeiter;
            obj.Datum = this.Datum;
            obj.Dauer = this.Dauer;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Zeitkonto, sw);
            BinarySerializer.ToBinary(this.fk_Mitarbeiter, sw);
            BinarySerializer.ToBinary(this.Datum, sw);
            BinarySerializer.ToBinary(this.Dauer, sw);
        }
        
        public override void FromStream(Kistl.API.IKistlContext ctx, System.IO.BinaryReader sr)
        {
            base.FromStream(ctx, sr);
            BinarySerializer.FromBinary(out this._fk_Zeitkonto, sr);
            BinarySerializer.FromBinary(out this._fk_Mitarbeiter, sr);
            BinarySerializer.FromBinary(out this._Datum, sr);
            BinarySerializer.FromBinary(out this._Dauer, sr);
        }
    }
}
