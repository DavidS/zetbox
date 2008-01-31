//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.1433
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kistl.App.Base
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
    
    
    public class Assembly : BaseClientDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private int _fk_Module = Helper.INVALIDID;
        
        private string _AssemblyName;
        
        private bool _IsClientAssembly;
        
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
        public Kistl.App.Base.Module Module
        {
            get
            {
                return Context.GetQuery<Kistl.App.Base.Module>().Single(o => o.ID == fk_Module);
            }
            set
            {
                _fk_Module = value.ID;
            }
        }
        
        public int fk_Module
        {
            get
            {
                return _fk_Module;
            }
            set
            {
                _fk_Module = value;
            }
        }
        
        public string AssemblyName
        {
            get
            {
                return _AssemblyName;
            }
            set
            {
                _AssemblyName = value;
            }
        }
        
        public bool IsClientAssembly
        {
            get
            {
                return _IsClientAssembly;
            }
            set
            {
                _IsClientAssembly = value;
            }
        }
        
        public event ToStringHandler<Assembly> OnToString_Assembly;
        
        public event ObjectEventHandler<Assembly> OnPreSave_Assembly;
        
        public event ObjectEventHandler<Assembly> OnPostSave_Assembly;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Assembly != null)
            {
                OnToString_Assembly(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Assembly != null) OnPreSave_Assembly(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Assembly != null) OnPostSave_Assembly(this);
        }
        
        public override object Clone()
        {
            Assembly obj = new Assembly();
            CopyTo(obj);
            return obj;
        }
        
        public void CopyTo(Assembly obj)
        {
            base.CopyTo(obj);
            obj.fk_Module = this.fk_Module;
            obj.AssemblyName = this.AssemblyName;
            obj.IsClientAssembly = this.IsClientAssembly;
        }
    }
}
