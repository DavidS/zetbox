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
    
    
    public class ObjectClass : BaseClientDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private string _ClassName;
        
        private string _TableName;
        
        private List<Kistl.App.Base.BaseProperty> _Properties;
        
        private int _fk_BaseObjectClass = Helper.INVALIDID;
        
        private List<Kistl.App.Base.ObjectClass> _SubClasses;
        
        private List<Kistl.App.Base.Method> _Methods;
        
        private int _fk_Module = Helper.INVALIDID;
        
        private int _fk_DefaultIcon = Helper.INVALIDID;
        
        private List<Kistl.App.Base.MethodInvocation> _MethodIvokations;
        
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
        
        public string ClassName
        {
            get
            {
                return _ClassName;
            }
            set
            {
                _ClassName = value;
            }
        }
        
        public string TableName
        {
            get
            {
                return _TableName;
            }
            set
            {
                _TableName = value;
            }
        }
        
        [System.Diagnostics.DebuggerHidden()]
        [XmlIgnore()]
        public List<Kistl.App.Base.BaseProperty> Properties
        {
            get
            {
                if(_Properties == null) _Properties = Context.GetListOf<Kistl.App.Base.BaseProperty>(this, "Properties");
                return _Properties;
            }
        }
        
        [System.Diagnostics.DebuggerHidden()]
        [XmlIgnore()]
        public Kistl.App.Base.ObjectClass BaseObjectClass
        {
            get
            {
                return Context.GetQuery<Kistl.App.Base.ObjectClass>().Single(o => o.ID == fk_BaseObjectClass);
            }
            set
            {
                _fk_BaseObjectClass = value.ID;
            }
        }
        
        public int fk_BaseObjectClass
        {
            get
            {
                return _fk_BaseObjectClass;
            }
            set
            {
                _fk_BaseObjectClass = value;
            }
        }
        
        [System.Diagnostics.DebuggerHidden()]
        [XmlIgnore()]
        public List<Kistl.App.Base.ObjectClass> SubClasses
        {
            get
            {
                if(_SubClasses == null) _SubClasses = Context.GetListOf<Kistl.App.Base.ObjectClass>(this, "SubClasses");
                return _SubClasses;
            }
        }
        
        [System.Diagnostics.DebuggerHidden()]
        [XmlIgnore()]
        public List<Kistl.App.Base.Method> Methods
        {
            get
            {
                if(_Methods == null) _Methods = Context.GetListOf<Kistl.App.Base.Method>(this, "Methods");
                return _Methods;
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
        
        [System.Diagnostics.DebuggerHidden()]
        [XmlIgnore()]
        public Kistl.App.GUI.Icon DefaultIcon
        {
            get
            {
                return Context.GetQuery<Kistl.App.GUI.Icon>().Single(o => o.ID == fk_DefaultIcon);
            }
            set
            {
                _fk_DefaultIcon = value.ID;
            }
        }
        
        public int fk_DefaultIcon
        {
            get
            {
                return _fk_DefaultIcon;
            }
            set
            {
                _fk_DefaultIcon = value;
            }
        }
        
        [System.Diagnostics.DebuggerHidden()]
        [XmlIgnore()]
        public List<Kistl.App.Base.MethodInvocation> MethodIvokations
        {
            get
            {
                if(_MethodIvokations == null) _MethodIvokations = Context.GetListOf<Kistl.App.Base.MethodInvocation>(this, "MethodIvokations");
                return _MethodIvokations;
            }
        }
        
        public event ToStringHandler<ObjectClass> OnToString_ObjectClass;
        
        public event ObjectEventHandler<ObjectClass> OnPreSave_ObjectClass;
        
        public event ObjectEventHandler<ObjectClass> OnPostSave_ObjectClass;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ObjectClass != null)
            {
                OnToString_ObjectClass(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ObjectClass != null) OnPreSave_ObjectClass(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ObjectClass != null) OnPostSave_ObjectClass(this);
        }
        
        public override object Clone()
        {
            ObjectClass obj = new ObjectClass();
            CopyTo(obj);
            return obj;
        }
        
        public void CopyTo(ObjectClass obj)
        {
            base.CopyTo(obj);
            obj.ClassName = this.ClassName;
            obj.TableName = this.TableName;
            obj.fk_BaseObjectClass = this.fk_BaseObjectClass;
            obj.fk_Module = this.fk_Module;
            obj.fk_DefaultIcon = this.fk_DefaultIcon;
        }
    }
}
