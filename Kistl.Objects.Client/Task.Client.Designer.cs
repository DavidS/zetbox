//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
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
    
    
    public class TaskImpl : BaseClientDataObject, Task
    {
        
        private System.Nullable<int> _fk_Projekt = null;
        
        private string _Name;
        
        private System.DateTime? _DatumVon;
        
        private System.DateTime? _DatumBis;
        
        private System.Double? _Aufwand;
        
        public TaskImpl()
        {
        }
        
        [XmlIgnore()]
        public Kistl.App.Projekte.Projekt Projekt
        {
            get
            {
                if (fk_Projekt == null) return null;
                return Context.Find<Kistl.App.Projekte.Projekt>(fk_Projekt.Value);
            }
            set
            {
                fk_Projekt = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_Projekt
        {
            get
            {
                return _fk_Projekt;
            }
            set
            {
                if (fk_Projekt != value)
                {
                    NotifyPropertyChanging("Projekt"); 
                    _fk_Projekt = value;
                    NotifyPropertyChanged("Projekt");;
                }
            }
        }
        
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (Name != value)
                {
                    NotifyPropertyChanging("Name"); 
                    _Name = value;
                    NotifyPropertyChanged("Name");;
                }
            }
        }
        
        public System.DateTime? DatumVon
        {
            get
            {
                return _DatumVon;
            }
            set
            {
                if (DatumVon != value)
                {
                    NotifyPropertyChanging("DatumVon"); 
                    _DatumVon = value;
                    NotifyPropertyChanged("DatumVon");;
                }
            }
        }
        
        public System.DateTime? DatumBis
        {
            get
            {
                return _DatumBis;
            }
            set
            {
                if (DatumBis != value)
                {
                    NotifyPropertyChanging("DatumBis"); 
                    _DatumBis = value;
                    NotifyPropertyChanged("DatumBis");;
                }
            }
        }
        
        public System.Double? Aufwand
        {
            get
            {
                return _Aufwand;
            }
            set
            {
                if (Aufwand != value)
                {
                    NotifyPropertyChanging("Aufwand"); 
                    _Aufwand = value;
                    NotifyPropertyChanged("Aufwand");;
                }
            }
        }
        
        public event ToStringHandler<Task> OnToString_Task;
        
        public event ObjectEventHandler<Task> OnPreSave_Task;
        
        public event ObjectEventHandler<Task> OnPostSave_Task;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Task != null)
            {
                OnToString_Task(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Task != null) OnPreSave_Task(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Task != null) OnPostSave_Task(this);
        }
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((TaskImpl)obj).fk_Projekt = this.fk_Projekt;
            ((TaskImpl)obj).Name = this.Name;
            ((TaskImpl)obj).DatumVon = this.DatumVon;
            ((TaskImpl)obj).DatumBis = this.DatumBis;
            ((TaskImpl)obj).Aufwand = this.Aufwand;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Projekt, sw);
            BinarySerializer.ToBinary(this._Name, sw);
            BinarySerializer.ToBinary(this._DatumVon, sw);
            BinarySerializer.ToBinary(this._DatumBis, sw);
            BinarySerializer.ToBinary(this._Aufwand, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Projekt, sr);
            BinarySerializer.FromBinary(out this._Name, sr);
            BinarySerializer.FromBinary(out this._DatumVon, sr);
            BinarySerializer.FromBinary(out this._DatumBis, sr);
            BinarySerializer.FromBinary(out this._Aufwand, sr);
        }
    }
}
