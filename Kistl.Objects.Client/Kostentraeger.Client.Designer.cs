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
    
    
    public class Kostentraeger : Kistl.App.Zeiterfassung.Zeitkonto, ICloneable
    {
        
        private int _fk_Projekt = Helper.INVALIDID;
        
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
        
        public event ToStringHandler<Kostentraeger> OnToString_Kostentraeger;
        
        public event ObjectEventHandler<Kostentraeger> OnPreSave_Kostentraeger;
        
        public event ObjectEventHandler<Kostentraeger> OnPostSave_Kostentraeger;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Kostentraeger != null)
            {
                OnToString_Kostentraeger(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Kostentraeger != null) OnPreSave_Kostentraeger(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Kostentraeger != null) OnPostSave_Kostentraeger(this);
        }
        
        public override object Clone()
        {
            Kostentraeger obj = new Kostentraeger();
            CopyTo(obj);
            return obj;
        }
        
        public void CopyTo(Kostentraeger obj)
        {
            base.CopyTo(obj);
            obj.fk_Projekt = this.fk_Projekt;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Projekt, sw);
        }
        
        public override void FromStream(Kistl.API.IKistlContext ctx, System.IO.BinaryReader sr)
        {
            base.FromStream(ctx, sr);
            BinarySerializer.FromBinary(out this._fk_Projekt, sr);
        }
    }
}
