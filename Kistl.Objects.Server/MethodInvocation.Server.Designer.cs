//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.1433
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_MethodInvocation_ObjectClass", "A_ObjectClass", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.ObjectClass), "B_MethodInvocation", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.MethodInvocation))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_MethodInvocation_Module", "A_Module", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.Module), "B_MethodInvocation", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.MethodInvocation))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_MethodInvocation_Method", "A_Method", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.Method), "B_MethodInvocation", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.MethodInvocation))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_MethodInvocation_Assembly", "A_Assembly", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.Assembly), "B_MethodInvocation", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.MethodInvocation))]

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
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="MethodInvocation")]
    public class MethodInvocation : BaseServerDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private int _fk_InvokeOnObjectClass = Helper.INVALIDID;
        
        private int _fk_Module = Helper.INVALIDID;
        
        private int _fk_Method = Helper.INVALIDID;
        
        private int _fk_Assembly = Helper.INVALIDID;
        
        private string _FullTypeName;
        
        private string _MemberName;
        
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
                return "MethodInvocation";
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_MethodInvocation_ObjectClass", "A_ObjectClass")]
        [XmlIgnore()]
        public Kistl.App.Base.ObjectClass InvokeOnObjectClass
        {
            get
            {
                EntityReference<Kistl.App.Base.ObjectClass> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClass>("Model.FK_MethodInvocation_ObjectClass", "A_ObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.ObjectClass> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClass>("Model.FK_MethodInvocation_ObjectClass", "A_ObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public int fk_InvokeOnObjectClass
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && _fk_InvokeOnObjectClass == Helper.INVALIDID && InvokeOnObjectClass != null)
                {
                    _fk_InvokeOnObjectClass = InvokeOnObjectClass.ID;
                }
                return _fk_InvokeOnObjectClass;
            }
            set
            {
                _fk_InvokeOnObjectClass = value;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_MethodInvocation_Module", "A_Module")]
        [XmlIgnore()]
        public Kistl.App.Base.Module Module
        {
            get
            {
                EntityReference<Kistl.App.Base.Module> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module>("Model.FK_MethodInvocation_Module", "A_Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Module> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module>("Model.FK_MethodInvocation_Module", "A_Module");
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
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_MethodInvocation_Method", "A_Method")]
        [XmlIgnore()]
        public Kistl.App.Base.Method Method
        {
            get
            {
                EntityReference<Kistl.App.Base.Method> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Method>("Model.FK_MethodInvocation_Method", "A_Method");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Method> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Method>("Model.FK_MethodInvocation_Method", "A_Method");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public int fk_Method
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && _fk_Method == Helper.INVALIDID && Method != null)
                {
                    _fk_Method = Method.ID;
                }
                return _fk_Method;
            }
            set
            {
                _fk_Method = value;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_MethodInvocation_Assembly", "A_Assembly")]
        [XmlIgnore()]
        public Kistl.App.Base.Assembly Assembly
        {
            get
            {
                EntityReference<Kistl.App.Base.Assembly> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly>("Model.FK_MethodInvocation_Assembly", "A_Assembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Assembly> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly>("Model.FK_MethodInvocation_Assembly", "A_Assembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = value;
            }
        }
        
        public int fk_Assembly
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && _fk_Assembly == Helper.INVALIDID && Assembly != null)
                {
                    _fk_Assembly = Assembly.ID;
                }
                return _fk_Assembly;
            }
            set
            {
                _fk_Assembly = value;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string FullTypeName
        {
            get
            {
                return _FullTypeName;
            }
            set
            {
                _FullTypeName = value;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string MemberName
        {
            get
            {
                return _MemberName;
            }
            set
            {
                _MemberName = value;
            }
        }
        
        public event ToStringHandler<MethodInvocation> OnToString_MethodInvocation;
        
        public event ObjectEventHandler<MethodInvocation> OnPreSave_MethodInvocation;
        
        public event ObjectEventHandler<MethodInvocation> OnPostSave_MethodInvocation;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_MethodInvocation != null)
            {
                OnToString_MethodInvocation(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_MethodInvocation != null) OnPreSave_MethodInvocation(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_MethodInvocation != null) OnPostSave_MethodInvocation(this);
        }
        
        public override object Clone()
        {
            MethodInvocation obj = new MethodInvocation();
            CopyTo(obj);
            return obj;
        }
        
        public void CopyTo(MethodInvocation obj)
        {
            base.CopyTo(obj);
            obj.fk_InvokeOnObjectClass = this.fk_InvokeOnObjectClass;
            obj.fk_Module = this.fk_Module;
            obj.fk_Method = this.fk_Method;
            obj.fk_Assembly = this.fk_Assembly;
            obj.FullTypeName = this.FullTypeName;
            obj.MemberName = this.MemberName;
        }
    }
}
