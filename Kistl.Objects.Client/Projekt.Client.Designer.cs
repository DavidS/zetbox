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
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Collections;
    using System.Xml;
    using System.Xml.Serialization;
    using Kistl.API;
    using Kistl.API.Client;
    
    
    public class Projekt : BaseClientDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private string _Name;
        
        private List<Kistl.App.Projekte.Task> _Tasks;
        
        private int _fk_Mitarbeiter = Helper.INVALIDID;
        
        private System.Nullable<double> _AufwandGes;
        
        private string _Kundenname;
        
        private List<Kistl.App.Zeiterfassung.Kostentraeger> _Kostentraeger;
        
        private List<Kistl.App.Projekte.Auftrag> _Auftraege;
        
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
        
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        
        [System.Diagnostics.DebuggerHidden()]
        [XmlIgnore()]
        public List<Kistl.App.Projekte.Task> Tasks
        {
            get
            {
                if(_Tasks == null) _Tasks = Context.GetListOf<Kistl.App.Projekte.Task>(this, "Tasks");
                return _Tasks;
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
        
        public System.Nullable<double> AufwandGes
        {
            get
            {
                return _AufwandGes;
            }
            set
            {
                _AufwandGes = value;
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
        
        [System.Diagnostics.DebuggerHidden()]
        [XmlIgnore()]
        public List<Kistl.App.Zeiterfassung.Kostentraeger> Kostentraeger
        {
            get
            {
                if(_Kostentraeger == null) _Kostentraeger = Context.GetListOf<Kistl.App.Zeiterfassung.Kostentraeger>(this, "Kostentraeger");
                return _Kostentraeger;
            }
        }
        
        [System.Diagnostics.DebuggerHidden()]
        [XmlIgnore()]
        public List<Kistl.App.Projekte.Auftrag> Auftraege
        {
            get
            {
                if(_Auftraege == null) _Auftraege = Context.GetListOf<Kistl.App.Projekte.Auftrag>(this, "Auftraege");
                return _Auftraege;
            }
        }
        
        public event ToStringHandler<Projekt> OnToString_Projekt;
        
        public event ObjectEventHandler<Projekt> OnPreSave_Projekt;
        
        public event ObjectEventHandler<Projekt> OnPostSave_Projekt;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Projekt != null)
            {
                OnToString_Projekt(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Projekt != null) OnPreSave_Projekt(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Projekt != null) OnPostSave_Projekt(this);
        }
        
        public override object Clone()
        {
            Projekt obj = new Projekt();
            CopyTo(obj);
            return obj;
        }
        
        public void CopyTo(Projekt obj)
        {
            base.CopyTo(obj);
            obj.Name = this.Name;
            obj.fk_Mitarbeiter = this.fk_Mitarbeiter;
            obj.AufwandGes = this.AufwandGes;
            obj.Kundenname = this.Kundenname;
        }
    }
}
