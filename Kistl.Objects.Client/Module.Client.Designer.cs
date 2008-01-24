//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
    
    
    public class Module : BaseClientDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private string _Namespace;
        
        private string _ModuleName;
        
        private List<Kistl.App.Base.ObjectClass> _ObjectClasses;
        
        private List<Kistl.App.Base.Assembly> _Assemblies;
        
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
        
        public string Namespace
        {
            get
            {
                return _Namespace;
            }
            set
            {
                _Namespace = value;
            }
        }
        
        public string ModuleName
        {
            get
            {
                return _ModuleName;
            }
            set
            {
                _ModuleName = value;
            }
        }
        
        [System.Diagnostics.DebuggerHidden()]
        [XmlIgnore()]
        public List<Kistl.App.Base.ObjectClass> ObjectClasses
        {
            get
            {
                if(_ObjectClasses == null) _ObjectClasses = Context.GetListOf<Kistl.App.Base.ObjectClass>(this, "ObjectClasses");
                return _ObjectClasses;
            }
        }
        
        [System.Diagnostics.DebuggerHidden()]
        [XmlIgnore()]
        public List<Kistl.App.Base.Assembly> Assemblies
        {
            get
            {
                if(_Assemblies == null) _Assemblies = Context.GetListOf<Kistl.App.Base.Assembly>(this, "Assemblies");
                return _Assemblies;
            }
        }
        
        public event ToStringHandler<Module> OnToString_Module;
        
        public event ObjectEventHandler<Module> OnPreSave_Module;
        
        public event ObjectEventHandler<Module> OnPostSave_Module;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Module != null)
            {
                OnToString_Module(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Module != null) OnPreSave_Module(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Module != null) OnPostSave_Module(this);
        }
        
        public override object Clone()
        {
            Module obj = new Module();
            CopyTo(obj);
            return obj;
        }
        
        public void CopyTo(Module obj)
        {
            base.CopyTo(obj);
            obj.Namespace = this.Namespace;
            obj.ModuleName = this.ModuleName;
        }
    }
}
