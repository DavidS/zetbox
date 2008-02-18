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
    using System.Linq;
    using System.Text;
    using System.Collections;
    using System.Xml;
    using System.Xml.Serialization;
    using Kistl.API;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Kistl.API.Client;
    
    
    public class Kunde : BaseClientDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private string _Kundenname;
        
        private string _Adresse;
        
        private string _PLZ;
        
        private string _Ort;
        
        private string _Land;
        
        private List<Kunde_EMailsCollectionEntry> _EMails;
        
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
        
        public string Kundenname
        {
            get
            {
                return _Kundenname;
            }
            set
            {
                _Kundenname = value;
            }
        }
        
        public string Adresse
        {
            get
            {
                return _Adresse;
            }
            set
            {
                _Adresse = value;
            }
        }
        
        public string PLZ
        {
            get
            {
                return _PLZ;
            }
            set
            {
                _PLZ = value;
            }
        }
        
        public string Ort
        {
            get
            {
                return _Ort;
            }
            set
            {
                _Ort = value;
            }
        }
        
        public string Land
        {
            get
            {
                return _Land;
            }
            set
            {
                _Land = value;
            }
        }
        
        public List<Kunde_EMailsCollectionEntry> EMails
        {
            get
            {
                return _EMails;
            }
            set
            {
                _EMails = value;
            }
        }
        
        public event ToStringHandler<Kunde> OnToString_Kunde;
        
        public event ObjectEventHandler<Kunde> OnPreSave_Kunde;
        
        public event ObjectEventHandler<Kunde> OnPostSave_Kunde;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Kunde != null)
            {
                OnToString_Kunde(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Kunde != null) OnPreSave_Kunde(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Kunde != null) OnPostSave_Kunde(this);
        }
        
        public override object Clone()
        {
            Kunde obj = new Kunde();
            CopyTo(obj);
            return obj;
        }
        
        public override void CopyTo(Kistl.API.IDataObject obj)
        {
            base.CopyTo(obj);
            ((Kunde)obj).NotifyPropertyChanging("Kundenname");
            ((Kunde)obj).Kundenname = this.Kundenname;
            ((Kunde)obj).NotifyPropertyChanged("Kundenname");
            ((Kunde)obj).NotifyPropertyChanging("Adresse");
            ((Kunde)obj).Adresse = this.Adresse;
            ((Kunde)obj).NotifyPropertyChanged("Adresse");
            ((Kunde)obj).NotifyPropertyChanging("PLZ");
            ((Kunde)obj).PLZ = this.PLZ;
            ((Kunde)obj).NotifyPropertyChanged("PLZ");
            ((Kunde)obj).NotifyPropertyChanging("Ort");
            ((Kunde)obj).Ort = this.Ort;
            ((Kunde)obj).NotifyPropertyChanged("Ort");
            ((Kunde)obj).NotifyPropertyChanging("Land");
            ((Kunde)obj).Land = this.Land;
            ((Kunde)obj).NotifyPropertyChanged("Land");
            ((Kunde)obj).NotifyPropertyChanging("EMails");
            ((Kunde)obj)._EMails = this.EMails.Clone();
            ((Kunde)obj).NotifyPropertyChanged("EMails");
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.Kundenname, sw);
            BinarySerializer.ToBinary(this.Adresse, sw);
            BinarySerializer.ToBinary(this.PLZ, sw);
            BinarySerializer.ToBinary(this.Ort, sw);
            BinarySerializer.ToBinary(this.Land, sw);
            BinarySerializer.ToBinary(this.EMails, sw);
        }
        
        public override void FromStream(Kistl.API.IKistlContext ctx, System.IO.BinaryReader sr)
        {
            base.FromStream(ctx, sr);
            BinarySerializer.FromBinary(out this._Kundenname, sr);
            BinarySerializer.FromBinary(out this._Adresse, sr);
            BinarySerializer.FromBinary(out this._PLZ, sr);
            BinarySerializer.FromBinary(out this._Ort, sr);
            BinarySerializer.FromBinary(out this._Land, sr);
            BinarySerializer.FromBinaryCollectionEntries(out this._EMails, sr, ctx);
        }
    }
    
    public class Kunde_EMailsCollectionEntry : Kistl.API.Client.BaseClientCollectionEntry
    {
        
        private int _ID = Helper.INVALIDID;
        
        private string _Value;
        
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
        
        public string Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
            }
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.Value, sw);
        }
        
        public override void FromStream(Kistl.API.IKistlContext ctx, System.IO.BinaryReader sr)
        {
            base.FromStream(ctx, sr);
            BinarySerializer.FromBinary(out this._Value, sr);
        }
        
        public override void CopyTo(Kistl.API.ICollectionEntry obj)
        {
            base.CopyTo(obj);
            ((Kunde_EMailsCollectionEntry)obj).NotifyPropertyChanging("Value");
            ((Kunde_EMailsCollectionEntry)obj)._Value = this._Value;
            ((Kunde_EMailsCollectionEntry)obj).NotifyPropertyChanged("Value");
        }
    }
}
