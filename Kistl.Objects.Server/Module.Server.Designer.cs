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
    using Kistl.API.Server;
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Module")]
    public class Module : BaseServerDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private string _Namespace;
        
        private string _ModuleName;
        
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
                return "Module";
            }
        }
        
        [EdmScalarPropertyAttribute()]
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
        
        [EdmScalarPropertyAttribute()]
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
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_ObjectClass_Module", "B_ObjectClass")]
        [XmlIgnore()]
        public EntityCollection<Kistl.App.Base.ObjectClass> ObjectClasses
        {
            get
            {
                EntityCollection<Kistl.App.Base.ObjectClass> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Kistl.App.Base.ObjectClass>("Model.FK_ObjectClass_Module", "B_ObjectClass");
                if (!c.IsLoaded) c.Load(); 
                return c;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Assembly_Module", "B_Assembly")]
        [XmlIgnore()]
        public EntityCollection<Kistl.App.Base.Assembly> Assemblies
        {
            get
            {
                EntityCollection<Kistl.App.Base.Assembly> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Kistl.App.Base.Assembly>("Model.FK_Assembly_Module", "B_Assembly");
                if (!c.IsLoaded) c.Load(); 
                return c;
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
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.Namespace, sw);
            BinarySerializer.ToBinary(this.ModuleName, sw);
        }
        
        public override void FromStream(Kistl.API.IKistlContext ctx, System.IO.BinaryReader sr)
        {
            base.FromStream(ctx, sr);
            BinarySerializer.FromBinary(out this._Namespace, sr);
            BinarySerializer.FromBinary(out this._ModuleName, sr);
        }
    }
}
