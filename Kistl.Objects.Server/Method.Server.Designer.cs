//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.1433
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_Method_ObjectClass", "A_ObjectClass", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.ObjectClass), "B_Method", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.Method))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_Method_Module", "A_Module", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.Module), "B_Method", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.Method))]

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
    using Kistl.API.Server;
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Method")]
    public class Method : BaseServerDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private int _fk_ObjectClass = Helper.INVALIDID;
        
        private string _MethodName;
        
        private int _fk_Module = Helper.INVALIDID;
        
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
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
        
        public override string EntitySetName
        {
            get
            {
                return "Method";
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Method_ObjectClass", "A_ObjectClass")]
        [XmlIgnore()]
        public Kistl.App.Base.ObjectClass ObjectClass
        {
            get
            {
                EntityReference<Kistl.App.Base.ObjectClass> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClass>("Model.FK_Method_ObjectClass", "A_ObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.ObjectClass> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClass>("Model.FK_Method_ObjectClass", "A_ObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public int fk_ObjectClass
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && _fk_ObjectClass == Helper.INVALIDID && ObjectClass != null)
                {
                    _fk_ObjectClass = ObjectClass.ID;
                }
                return _fk_ObjectClass;
            }
            set
            {
                _fk_ObjectClass = value;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string MethodName
        {
            get
            {
                return _MethodName;
            }
            set
            {
                _MethodName = value;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Method_Module", "A_Module")]
        [XmlIgnore()]
        public Kistl.App.Base.Module Module
        {
            get
            {
                EntityReference<Kistl.App.Base.Module> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module>("Model.FK_Method_Module", "A_Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Module> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module>("Model.FK_Method_Module", "A_Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public int fk_Module
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && _fk_Module == Helper.INVALIDID && Module != null)
                {
                    _fk_Module = Module.ID;
                }
                return _fk_Module;
            }
            set
            {
                _fk_Module = value;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_MethodInvocation_Method", "B_MethodInvocation")]
        [XmlIgnore()]
        public EntityCollection<Kistl.App.Base.MethodInvocation> MethodIvokations
        {
            get
            {
                EntityCollection<Kistl.App.Base.MethodInvocation> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Kistl.App.Base.MethodInvocation>("Model.FK_MethodInvocation_Method", "B_MethodInvocation");
                if (!c.IsLoaded) c.Load(); 
                return c;
            }
        }
        
        public event ToStringHandler<Method> OnToString_Method;
        
        public event ObjectEventHandler<Method> OnPreSave_Method;
        
        public event ObjectEventHandler<Method> OnPostSave_Method;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Method != null)
            {
                OnToString_Method(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Method != null) OnPreSave_Method(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Method != null) OnPostSave_Method(this);
        }
        
        public override object Clone()
        {
            Method obj = new Method();
            CopyTo(obj);
            return obj;
        }
        
        public void CopyTo(Method obj)
        {
            base.CopyTo(obj);
            obj.fk_ObjectClass = this.fk_ObjectClass;
            obj.MethodName = this.MethodName;
            obj.fk_Module = this.fk_Module;
        }
    }
}
