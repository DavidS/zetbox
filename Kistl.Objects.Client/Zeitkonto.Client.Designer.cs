//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kistl.App.Zeiterfassung
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
    
    
    public class Zeitkonto : BaseClientDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private string _Kontoname;
        
        private BackReferenceCollection<Kistl.App.Zeiterfassung.Taetigkeit> _Taetigkeiten;
        
        private ListPropertyCollection<Kistl.App.Projekte.Mitarbeiter, Zeitkonto, Zeitkonto_MitarbeiterCollectionEntry> _Mitarbeiter;
        
        private System.Double? _MaxStunden;
        
        private System.Double? _AktuelleStunden;
        
        public Zeitkonto()
        {
            _Mitarbeiter = new ListPropertyCollection<Kistl.App.Projekte.Mitarbeiter, Zeitkonto, Zeitkonto_MitarbeiterCollectionEntry>(this, "Mitarbeiter");
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
        
        public string Kontoname
        {
            get
            {
                return _Kontoname;
            }
            set
            {
                NotifyPropertyChanging("Kontoname"); 
                _Kontoname = value; 
                NotifyPropertyChanged("Kontoname");;
            }
        }
        
        [XmlIgnore()]
        public IList<Kistl.App.Zeiterfassung.Taetigkeit> Taetigkeiten
        {
            get
            {
                if(_Taetigkeiten == null) _Taetigkeiten = new BackReferenceCollection<Kistl.App.Zeiterfassung.Taetigkeit>("Zeitkonto", this, Context.GetListOf<Kistl.App.Zeiterfassung.Taetigkeit>(this, "Taetigkeiten"));
                return _Taetigkeiten;
            }
        }
        
        public IList<Kistl.App.Projekte.Mitarbeiter> Mitarbeiter
        {
            get
            {
                return _Mitarbeiter;
            }
        }
        
        public System.Double? MaxStunden
        {
            get
            {
                return _MaxStunden;
            }
            set
            {
                NotifyPropertyChanging("MaxStunden"); 
                _MaxStunden = value; 
                NotifyPropertyChanged("MaxStunden");;
            }
        }
        
        public System.Double? AktuelleStunden
        {
            get
            {
                return _AktuelleStunden;
            }
            set
            {
                NotifyPropertyChanging("AktuelleStunden"); 
                _AktuelleStunden = value; 
                NotifyPropertyChanged("AktuelleStunden");;
            }
        }
        
        public event ToStringHandler<Zeitkonto> OnToString_Zeitkonto;
        
        public event ObjectEventHandler<Zeitkonto> OnPreSave_Zeitkonto;
        
        public event ObjectEventHandler<Zeitkonto> OnPostSave_Zeitkonto;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Zeitkonto != null)
            {
                OnToString_Zeitkonto(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Zeitkonto != null) OnPreSave_Zeitkonto(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Zeitkonto != null) OnPostSave_Zeitkonto(this);
        }
        
        public override object Clone()
        {
            Zeitkonto obj = new Zeitkonto();
            CopyTo(obj);
            return obj;
        }
        
        public override void CopyTo(Kistl.API.IDataObject obj)
        {
            base.CopyTo(obj);
            ((Zeitkonto)obj)._Kontoname = this._Kontoname;
            this._Mitarbeiter.CopyTo(((Zeitkonto)obj)._Mitarbeiter);
            ((Zeitkonto)obj)._MaxStunden = this._MaxStunden;
            ((Zeitkonto)obj)._AktuelleStunden = this._AktuelleStunden;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            _Mitarbeiter.UnderlyingCollection.ForEach(i => ctx.Attach(i));
            if(_Taetigkeiten != null) _Taetigkeiten = new BackReferenceCollection<Kistl.App.Zeiterfassung.Taetigkeit>("Zeitkonto", this, _Taetigkeiten.Select(i => ctx.Attach(i)).OfType<Kistl.App.Zeiterfassung.Taetigkeit>());
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this._Kontoname, sw);
            this._Mitarbeiter.ToStream(sw);
            BinarySerializer.ToBinary(this._MaxStunden, sw);
            BinarySerializer.ToBinary(this._AktuelleStunden, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._Kontoname, sr);
            this._Mitarbeiter.FromStream(sr);
            BinarySerializer.FromBinary(out this._MaxStunden, sr);
            BinarySerializer.FromBinary(out this._AktuelleStunden, sr);
        }
    }
    
    internal class Zeitkonto_MitarbeiterCollectionEntry : Kistl.API.Client.BaseClientCollectionEntry, ICollectionEntry<Kistl.App.Projekte.Mitarbeiter, Zeitkonto>
    {
        
        private int _ID = Helper.INVALIDID;
        
        private int _fk_Value = Helper.INVALIDID;
        
        private int _fk_Parent = Helper.INVALIDID;
        
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
        public Kistl.App.Projekte.Mitarbeiter Value
        {
            get
            {
                return Context.GetQuery<Kistl.App.Projekte.Mitarbeiter>().Single(o => o.ID == fk_Value);
            }
            set
            {
                base.NotifyPropertyChanging("Value");
                _fk_Value = value.ID;
                base.NotifyPropertyChanged("Value");
            }
        }
        
        [XmlIgnore()]
        public Zeitkonto Parent
        {
            get
            {
                return Context.GetQuery<Zeitkonto>().Single(o => o.ID == fk_Parent);
            }
            set
            {
                _fk_Parent = value.ID;
            }
        }
        
        public int fk_Value
        {
            get
            {
                return _fk_Value;
            }
            set
            {
                base.NotifyPropertyChanging("Value");
                _fk_Value = value;
                base.NotifyPropertyChanged("Value");
            }
        }
        
        public int fk_Parent
        {
            get
            {
                return _fk_Parent;
            }
            set
            {
                _fk_Parent = value;
            }
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Value, sw);
            BinarySerializer.ToBinary(this.fk_Parent, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Value, sr);
            BinarySerializer.FromBinary(out this._fk_Parent, sr);
        }
        
        public override void CopyTo(Kistl.API.ICollectionEntry obj)
        {
            base.CopyTo(obj);
            ((Zeitkonto_MitarbeiterCollectionEntry)obj)._fk_Value = this.fk_Value;
            ((Zeitkonto_MitarbeiterCollectionEntry)obj)._fk_Parent = this.fk_Parent;
        }
    }
}
