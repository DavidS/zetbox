//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_ObjectClass_ObjectClass_BaseObjectClass", "A_ObjectClass", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.ObjectClass__Implementation__), "B_ObjectClass", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.ObjectClass__Implementation__))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_ObjectClass_ImplementsInterfacesCollectionEntry_Interface_ImplementsInterfaces" +
    "", "A_Interface", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.Interface__Implementation__), "B_ObjectClass_ImplementsInterfacesCollectionEntry", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.ObjectClass_ImplementsInterfacesCollectionEntry__Implementation__))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_ObjectClass_ImplementsInterfacesCollectionEntry_ObjectClass_fk_Parent", "A_ObjectClass", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.ObjectClass__Implementation__), "B_ObjectClass_ImplementsInterfacesCollectionEntry", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.ObjectClass_ImplementsInterfacesCollectionEntry__Implementation__))]

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
    using Kistl.DALProvider.EF;
    using Kistl.API.Server;
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="ObjectClass")]
    public class ObjectClass__Implementation__ : Kistl.App.Base.DataType__Implementation__, ObjectClass
    {
        
        private string _TableName;
        
        private System.Nullable<int> _fk_BaseObjectClass = null;
        
        private EntityCollectionWrapper<Kistl.App.Base.ObjectClass, Kistl.App.Base.ObjectClass__Implementation__> SubClassesWrapper;
        
        private EntityCollectionEntryValueWrapper<Kistl.App.Base.ObjectClass, Kistl.App.Base.Interface, Kistl.App.Base.ObjectClass_ImplementsInterfacesCollectionEntry__Implementation__> ImplementsInterfacesWrapper;
        
        private bool _IsSimpleObject;
        
        private bool _IsFrozenObject;
        
        public ObjectClass__Implementation__()
        {
        }
        
        [EdmScalarPropertyAttribute()]
        public string TableName
        {
            get
            {
                return _TableName;
            }
            set
            {
                if (TableName != value)
                {
                    NotifyPropertyChanging("TableName"); 
                    _TableName = value;
                    NotifyPropertyChanged("TableName");;
                }
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.ObjectClass BaseObjectClass
        {
            get
            {
                return BaseObjectClass__Implementation__;
            }
            set
            {
                BaseObjectClass__Implementation__ = (Kistl.App.Base.ObjectClass__Implementation__)value;
            }
        }
        
        public System.Nullable<int> fk_BaseObjectClass
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && BaseObjectClass != null)
                {
                    _fk_BaseObjectClass = BaseObjectClass.ID;
                }
                return _fk_BaseObjectClass;
            }
            set
            {
                _fk_BaseObjectClass = value;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_ObjectClass_ObjectClass_BaseObjectClass", "A_ObjectClass")]
        public Kistl.App.Base.ObjectClass__Implementation__ BaseObjectClass__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.ObjectClass__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClass__Implementation__>("Model.FK_ObjectClass_ObjectClass_BaseObjectClass", "A_ObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.ObjectClass__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClass__Implementation__>("Model.FK_ObjectClass_ObjectClass_BaseObjectClass", "A_ObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (Kistl.App.Base.ObjectClass__Implementation__)value;
            }
        }
        
        [XmlIgnore()]
        public ICollection<Kistl.App.Base.ObjectClass> SubClasses
        {
            get
            {
                if (SubClassesWrapper == null) SubClassesWrapper = new EntityCollectionWrapper<Kistl.App.Base.ObjectClass, Kistl.App.Base.ObjectClass__Implementation__>(SubClasses__Implementation__);
                return SubClassesWrapper;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_ObjectClass_ObjectClass_BaseObjectClass", "B_ObjectClass")]
        public EntityCollection<Kistl.App.Base.ObjectClass__Implementation__> SubClasses__Implementation__
        {
            get
            {
                EntityCollection<Kistl.App.Base.ObjectClass__Implementation__> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Kistl.App.Base.ObjectClass__Implementation__>("Model.FK_ObjectClass_ObjectClass_BaseObjectClass", "B_ObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !c.IsLoaded) c.Load(); 
                return c;
            }
        }
        
        public IList<Kistl.App.Base.Interface> ImplementsInterfaces
        {
            get
            {
                if (ImplementsInterfacesWrapper == null) ImplementsInterfacesWrapper = new EntityCollectionEntryValueWrapper<Kistl.App.Base.ObjectClass, Kistl.App.Base.Interface, Kistl.App.Base.ObjectClass_ImplementsInterfacesCollectionEntry__Implementation__>(this, ImplementsInterfaces__Implementation__);
                return ImplementsInterfacesWrapper;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_ObjectClass_ImplementsInterfacesCollectionEntry_ObjectClass_fk_Parent", "B_ObjectClass_ImplementsInterfacesCollectionEntry")]
        public EntityCollection<Kistl.App.Base.ObjectClass_ImplementsInterfacesCollectionEntry__Implementation__> ImplementsInterfaces__Implementation__
        {
            get
            {
                EntityCollection<ObjectClass_ImplementsInterfacesCollectionEntry__Implementation__> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<ObjectClass_ImplementsInterfacesCollectionEntry__Implementation__>("Model.FK_ObjectClass_ImplementsInterfacesCollectionEntry_ObjectClass_fk_Parent", "B_ObjectClass_ImplementsInterfacesCollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !c.IsLoaded) c.Load(); 
                return c;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public bool IsSimpleObject
        {
            get
            {
                return _IsSimpleObject;
            }
            set
            {
                if (IsSimpleObject != value)
                {
                    NotifyPropertyChanging("IsSimpleObject"); 
                    _IsSimpleObject = value;
                    NotifyPropertyChanged("IsSimpleObject");;
                }
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public bool IsFrozenObject
        {
            get
            {
                return _IsFrozenObject;
            }
            set
            {
                if (IsFrozenObject != value)
                {
                    NotifyPropertyChanging("IsFrozenObject"); 
                    _IsFrozenObject = value;
                    NotifyPropertyChanged("IsFrozenObject");;
                }
            }
        }
        
        public event ToStringHandler<ObjectClass> OnToString_ObjectClass;
        
        public event ObjectEventHandler<ObjectClass> OnPreSave_ObjectClass;
        
        public event ObjectEventHandler<ObjectClass> OnPostSave_ObjectClass;
        
        public event GetInheritedMethods_Handler<ObjectClass> OnGetInheritedMethods_ObjectClass;
        
        public event GetDataTypeString_Handler<ObjectClass> OnGetDataTypeString_ObjectClass;
        
        public event GetDataType_Handler<ObjectClass> OnGetDataType_ObjectClass;
        
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
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            /// Use ToList before using foreach - the collection will change in the KistContext.Attach() Method because EntityFramework will need a Trick to attach CollectionEntries correctly
            ImplementsInterfaces__Implementation__.ToList().ForEach<ICollectionEntry>(i => ctx.Attach(i));
        }
        
        protected override string GetPropertyError(string prop)
        {
            switch(prop)
            {
                case "TableName":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(3).Constraints
                            .Where(c => !c.IsValid(this, this.TableName))
                            .Select(c => c.GetErrorText(this, this.TableName))
                            .ToArray());
                case "BaseObjectClass":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(25).Constraints
                            .Where(c => !c.IsValid(this, this.BaseObjectClass))
                            .Select(c => c.GetErrorText(this, this.BaseObjectClass))
                            .ToArray());
                case "SubClasses":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(27).Constraints
                            .Where(c => !c.IsValid(this, this.SubClasses))
                            .Select(c => c.GetErrorText(this, this.SubClasses))
                            .ToArray());
                case "ImplementsInterfaces":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(105).Constraints
                            .Where(c => !c.IsValid(this, this.ImplementsInterfaces))
                            .Select(c => c.GetErrorText(this, this.ImplementsInterfaces))
                            .ToArray());
                case "IsSimpleObject":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(119).Constraints
                            .Where(c => !c.IsValid(this, this.IsSimpleObject))
                            .Select(c => c.GetErrorText(this, this.IsSimpleObject))
                            .ToArray());
                case "IsFrozenObject":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(174).Constraints
                            .Where(c => !c.IsValid(this, this.IsFrozenObject))
                            .Select(c => c.GetErrorText(this, this.IsFrozenObject))
                            .ToArray());
            }
            return base.GetPropertyError(prop);
        }
        
        public virtual IList<Kistl.App.Base.Method> GetInheritedMethods()
        {
            MethodReturnEventArgs<IList<Kistl.App.Base.Method>> e = new MethodReturnEventArgs<IList<Kistl.App.Base.Method>>();
            if (OnGetInheritedMethods_ObjectClass != null)
            {
                OnGetInheritedMethods_ObjectClass(this, e);
            };
            return e.Result;
        }
        
        public override string GetDataTypeString()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            e.Result = base.GetDataTypeString();
            if (OnGetDataTypeString_ObjectClass != null)
            {
                OnGetDataTypeString_ObjectClass(this, e);
            };
            return e.Result;
        }
        
        public override System.Type GetDataType()
        {
            MethodReturnEventArgs<System.Type> e = new MethodReturnEventArgs<System.Type>();
            e.Result = base.GetDataType();
            if (OnGetDataType_ObjectClass != null)
            {
                OnGetDataType_ObjectClass(this, e);
            };
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this._TableName, sw);
            BinarySerializer.ToBinary(this.fk_BaseObjectClass, sw);
            BinarySerializer.ToBinary(this.ImplementsInterfaces__Implementation__, sw);
            BinarySerializer.ToBinary(this._IsSimpleObject, sw);
            BinarySerializer.ToBinary(this._IsFrozenObject, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._TableName, sr);
            BinarySerializer.FromBinary(out this._fk_BaseObjectClass, sr);
            BinarySerializer.FromBinaryCollectionEntries(this.ImplementsInterfaces__Implementation__, sr);
            BinarySerializer.FromBinary(out this._IsSimpleObject, sr);
            BinarySerializer.FromBinary(out this._IsFrozenObject, sr);
        }
        
        public delegate void GetInheritedMethods_Handler<T>(T obj, MethodReturnEventArgs<IList<Kistl.App.Base.Method>> e);
    }
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="ObjectClass_ImplementsInterfacesCollectionEntry")]
    public class ObjectClass_ImplementsInterfacesCollectionEntry__Implementation__ : BaseServerCollectionEntry_EntityFramework, ICollectionEntry<Kistl.App.Base.Interface, Kistl.App.Base.ObjectClass>
    {
        
        private int _ID;
        
        private int _fk_Value;
        
        private int _fk_Parent;
        
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
        public Kistl.App.Base.Interface Value
        {
            get
            {
                return ValueImpl;
            }
            set
            {
                ValueImpl = (Kistl.App.Base.Interface__Implementation__)value;
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.ObjectClass Parent
        {
            get
            {
                return ParentImpl;
            }
            set
            {
                ParentImpl = (Kistl.App.Base.ObjectClass__Implementation__)value;
            }
        }
        
        public int fk_Value
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && Value != null)
                {
                    _fk_Value = Value.ID;
                }
                return _fk_Value;
            }
            set
            {
                _fk_Value = value;
            }
        }
        
        public int fk_Parent
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && Parent != null)
                {
                    _fk_Parent = Parent.ID;
                }
                return _fk_Parent;
            }
            set
            {
                _fk_Parent = value;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_ObjectClass_ImplementsInterfacesCollectionEntry_Interface_ImplementsInterfaces" +
            "", "A_Interface")]
        public Kistl.App.Base.Interface__Implementation__ ValueImpl
        {
            get
            {
                EntityReference<Kistl.App.Base.Interface__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Interface__Implementation__>("Model.FK_ObjectClass_ImplementsInterfacesCollectionEntry_Interface_ImplementsInterfaces", "A_Interface");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Interface__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Interface__Implementation__>("Model.FK_ObjectClass_ImplementsInterfacesCollectionEntry_Interface_ImplementsInterfaces", "A_Interface");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (Kistl.App.Base.Interface__Implementation__)value;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_ObjectClass_ImplementsInterfacesCollectionEntry_ObjectClass_fk_Parent", "A_ObjectClass")]
        public Kistl.App.Base.ObjectClass__Implementation__ ParentImpl
        {
            get
            {
                EntityReference<ObjectClass__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<ObjectClass__Implementation__>("Model.FK_ObjectClass_ImplementsInterfacesCollectionEntry_ObjectClass_fk_Parent", "A_ObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<ObjectClass__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<ObjectClass__Implementation__>("Model.FK_ObjectClass_ImplementsInterfacesCollectionEntry_ObjectClass_fk_Parent", "A_ObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (ObjectClass__Implementation__)value;
            }
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Value, sw);
            BinarySerializer.ToBinary(this.fk_Parent, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Value, sr);
            BinarySerializer.FromBinary(out this._fk_Parent, sr);
        }
    }
}
