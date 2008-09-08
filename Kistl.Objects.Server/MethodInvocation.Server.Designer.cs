//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_MethodInvocation_Method_Method", "A_Method", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.MethodImpl), "B_MethodInvocation", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.MethodInvocationImpl))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_MethodInvocation_Assembly_Assembly", "A_Assembly", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.AssemblyImpl), "B_MethodInvocation", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.MethodInvocationImpl))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_MethodInvocation_Module_Module", "A_Module", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.ModuleImpl), "B_MethodInvocation", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.MethodInvocationImpl))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_MethodInvocation_DataType_InvokeOnObjectClass", "A_DataType", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.DataTypeImpl), "B_MethodInvocation", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.MethodInvocationImpl))]

namespace Kistl.App.Base
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
    using Kistl.API.Server;
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="MethodInvocation")]
    public class MethodInvocationImpl : BaseServerDataObject, MethodInvocation
    {
        
        private int _ID;
        
        private System.Nullable<int> _fk_Method = null;
        
        private System.Nullable<int> _fk_Assembly = null;
        
        private string _FullTypeName;
        
        private string _MemberName;
        
        private System.Nullable<int> _fk_Module = null;
        
        private System.Nullable<int> _fk_InvokeOnObjectClass = null;
        
        public MethodInvocationImpl()
        {
        }
        
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
        
        [XmlIgnore()]
        public Kistl.App.Base.Method Method
        {
            get
            {
                return MethodImpl;
            }
            set
            {
                MethodImpl = (Kistl.App.Base.MethodImpl)value;
            }
        }
        
        public System.Nullable<int> fk_Method
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && Method != null)
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
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_MethodInvocation_Method_Method", "A_Method")]
        public Kistl.App.Base.MethodImpl MethodImpl
        {
            get
            {
                EntityReference<Kistl.App.Base.MethodImpl> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.MethodImpl>("Model.FK_MethodInvocation_Method_Method", "A_Method");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.MethodImpl> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.MethodImpl>("Model.FK_MethodInvocation_Method_Method", "A_Method");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (Kistl.App.Base.MethodImpl)value;
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.Assembly Assembly
        {
            get
            {
                return AssemblyImpl;
            }
            set
            {
                AssemblyImpl = (Kistl.App.Base.AssemblyImpl)value;
            }
        }
        
        public System.Nullable<int> fk_Assembly
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && Assembly != null)
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
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_MethodInvocation_Assembly_Assembly", "A_Assembly")]
        public Kistl.App.Base.AssemblyImpl AssemblyImpl
        {
            get
            {
                EntityReference<Kistl.App.Base.AssemblyImpl> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.AssemblyImpl>("Model.FK_MethodInvocation_Assembly_Assembly", "A_Assembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.AssemblyImpl> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.AssemblyImpl>("Model.FK_MethodInvocation_Assembly_Assembly", "A_Assembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (Kistl.App.Base.AssemblyImpl)value;
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
                if (FullTypeName != value)
                {
                    NotifyPropertyChanging("FullTypeName"); 
                    _FullTypeName = value;
                    NotifyPropertyChanged("FullTypeName");;
                }
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
                if (MemberName != value)
                {
                    NotifyPropertyChanging("MemberName"); 
                    _MemberName = value;
                    NotifyPropertyChanged("MemberName");;
                }
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.Module Module
        {
            get
            {
                return ModuleImpl;
            }
            set
            {
                ModuleImpl = (Kistl.App.Base.ModuleImpl)value;
            }
        }
        
        public System.Nullable<int> fk_Module
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && Module != null)
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
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_MethodInvocation_Module_Module", "A_Module")]
        public Kistl.App.Base.ModuleImpl ModuleImpl
        {
            get
            {
                EntityReference<Kistl.App.Base.ModuleImpl> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ModuleImpl>("Model.FK_MethodInvocation_Module_Module", "A_Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.ModuleImpl> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ModuleImpl>("Model.FK_MethodInvocation_Module_Module", "A_Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (Kistl.App.Base.ModuleImpl)value;
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.DataType InvokeOnObjectClass
        {
            get
            {
                return InvokeOnObjectClassImpl;
            }
            set
            {
                InvokeOnObjectClassImpl = (Kistl.App.Base.DataTypeImpl)value;
            }
        }
        
        public System.Nullable<int> fk_InvokeOnObjectClass
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && InvokeOnObjectClass != null)
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
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_MethodInvocation_DataType_InvokeOnObjectClass", "A_DataType")]
        public Kistl.App.Base.DataTypeImpl InvokeOnObjectClassImpl
        {
            get
            {
                EntityReference<Kistl.App.Base.DataTypeImpl> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.DataTypeImpl>("Model.FK_MethodInvocation_DataType_InvokeOnObjectClass", "A_DataType");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.DataTypeImpl> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.DataTypeImpl>("Model.FK_MethodInvocation_DataType_InvokeOnObjectClass", "A_DataType");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (Kistl.App.Base.DataTypeImpl)value;
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
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Method, sw);
            BinarySerializer.ToBinary(this.fk_Assembly, sw);
            BinarySerializer.ToBinary(this._FullTypeName, sw);
            BinarySerializer.ToBinary(this._MemberName, sw);
            BinarySerializer.ToBinary(this.fk_Module, sw);
            BinarySerializer.ToBinary(this.fk_InvokeOnObjectClass, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Method, sr);
            BinarySerializer.FromBinary(out this._fk_Assembly, sr);
            BinarySerializer.FromBinary(out this._FullTypeName, sr);
            BinarySerializer.FromBinary(out this._MemberName, sr);
            BinarySerializer.FromBinary(out this._fk_Module, sr);
            BinarySerializer.FromBinary(out this._fk_InvokeOnObjectClass, sr);
        }
    }
}
