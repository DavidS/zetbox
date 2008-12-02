//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_TypeRef_Assembly_Assembly", "A_Assembly", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.Assembly__Implementation__), "B_TypeRef", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.TypeRef__Implementation__))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_GenericArguments", "A_TypeRef", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.TypeRef__Implementation__), "B_TypeRef_GenericArgumentsCollectionEntry", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.TypeRef_GenericArgumentsCollectionEntry__Implementation__))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_Parent", "A_TypeRef", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.TypeRef__Implementation__), "B_TypeRef_GenericArgumentsCollectionEntry", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Base.TypeRef_GenericArgumentsCollectionEntry__Implementation__))]

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
    
    
    [System.Diagnostics.DebuggerDisplay("Kistl.App.Base.TypeRef")]
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="TypeRef")]
    public class TypeRef__Implementation__ : BaseServerDataObject_EntityFramework, TypeRef
    {
        
        private int _ID;
        
        private string _FullName;
        
        private System.Nullable<int> _fk_Assembly = null;
        
        private EntityCollectionEntryValueWrapper<Kistl.App.Base.TypeRef, Kistl.App.Base.TypeRef, Kistl.App.Base.TypeRef_GenericArgumentsCollectionEntry__Implementation__> GenericArgumentsWrapper;
        
        public TypeRef__Implementation__()
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
        
        [EdmScalarPropertyAttribute()]
        public string FullName
        {
            get
            {
                return _FullName;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (FullName != value)
                {
                    NotifyPropertyChanging("FullName"); 
                    _FullName = value;
                    NotifyPropertyChanged("FullName");;
                }
            }
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Assembly Assembly
        {
            get
            {
                return Assembly__Implementation__;
            }
            set
            {
                Assembly__Implementation__ = (Kistl.App.Base.Assembly__Implementation__)value;
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
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_TypeRef_Assembly_Assembly", "A_Assembly")]
        public Kistl.App.Base.Assembly__Implementation__ Assembly__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Assembly__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly__Implementation__>("Model.FK_TypeRef_Assembly_Assembly", "A_Assembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Assembly__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly__Implementation__>("Model.FK_TypeRef_Assembly_Assembly", "A_Assembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (Kistl.App.Base.Assembly__Implementation__)value;
            }
        }
        
        public ICollection<Kistl.App.Base.TypeRef> GenericArguments
        {
            get
            {
                if (GenericArgumentsWrapper == null) GenericArgumentsWrapper = new EntityCollectionEntryValueWrapper<Kistl.App.Base.TypeRef, Kistl.App.Base.TypeRef, Kistl.App.Base.TypeRef_GenericArgumentsCollectionEntry__Implementation__>(this, GenericArguments__Implementation__);
                return GenericArgumentsWrapper;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_Parent", "B_TypeRef_GenericArgumentsCollectionEntry")]
        public EntityCollection<Kistl.App.Base.TypeRef_GenericArgumentsCollectionEntry__Implementation__> GenericArguments__Implementation__
        {
            get
            {
                EntityCollection<TypeRef_GenericArgumentsCollectionEntry__Implementation__> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<TypeRef_GenericArgumentsCollectionEntry__Implementation__>("Model.FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_Parent", "B_TypeRef_GenericArgumentsCollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !c.IsLoaded) c.Load(); 
                return c;
            }
        }
        
        public event ToStringHandler<TypeRef> OnToString_TypeRef;
        
        public event ObjectEventHandler<TypeRef> OnPreSave_TypeRef;
        
        public event ObjectEventHandler<TypeRef> OnPostSave_TypeRef;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_TypeRef != null)
            {
                OnToString_TypeRef(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_TypeRef != null) OnPreSave_TypeRef(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_TypeRef != null) OnPostSave_TypeRef(this);
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            /// Use ToList before using foreach - the collection will change in the KistContext.Attach() Method because EntityFramework will need a Trick to attach CollectionEntries correctly
            GenericArguments__Implementation__.ToList().ForEach<ICollectionEntry>(i => ctx.Attach(i));
        }
        
        protected override string GetPropertyError(string prop)
        {
            switch(prop)
            {
                case "FullName":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(205).Constraints
                            .Where(c => !c.IsValid(this, this.FullName))
                            .Select(c => c.GetErrorText(this, this.FullName))
                            .ToArray());
                case "Assembly":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(206).Constraints
                            .Where(c => !c.IsValid(this, this.Assembly))
                            .Select(c => c.GetErrorText(this, this.Assembly))
                            .ToArray());
                case "GenericArguments":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(207).Constraints
                            .Where(c => !c.IsValid(this, this.GenericArguments))
                            .Select(c => c.GetErrorText(this, this.GenericArguments))
                            .ToArray());
            }
            return base.GetPropertyError(prop);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this._FullName, sw);
            BinarySerializer.ToBinary(this.fk_Assembly, sw);
            BinarySerializer.ToBinary(this.GenericArguments__Implementation__, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._FullName, sr);
            BinarySerializer.FromBinary(out this._fk_Assembly, sr);
            BinarySerializer.FromBinaryCollectionEntries(this.GenericArguments__Implementation__, sr);
        }
    }
    
    [System.Diagnostics.DebuggerDisplay("Kistl.App.Base.TypeRef_GenericArgumentsCollectionEntry")]
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="TypeRef_GenericArgumentsCollectionEntry")]
    public class TypeRef_GenericArgumentsCollectionEntry__Implementation__ : BaseServerCollectionEntry_EntityFramework, ICollectionEntry<Kistl.App.Base.TypeRef, Kistl.App.Base.TypeRef>
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
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.TypeRef Value
        {
            get
            {
                return ValueImpl;
            }
            set
            {
                ValueImpl = (Kistl.App.Base.TypeRef__Implementation__)value;
            }
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.TypeRef Parent
        {
            get
            {
                return ParentImpl;
            }
            set
            {
                ParentImpl = (Kistl.App.Base.TypeRef__Implementation__)value;
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
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_GenericArguments", "A_TypeRef")]
        public Kistl.App.Base.TypeRef__Implementation__ ValueImpl
        {
            get
            {
                EntityReference<Kistl.App.Base.TypeRef__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.TypeRef__Implementation__>("Model.FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_GenericArguments", "A_TypeRef");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.TypeRef__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.TypeRef__Implementation__>("Model.FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_GenericArguments", "A_TypeRef");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (Kistl.App.Base.TypeRef__Implementation__)value;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_Parent", "A_TypeRef")]
        public Kistl.App.Base.TypeRef__Implementation__ ParentImpl
        {
            get
            {
                EntityReference<TypeRef__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<TypeRef__Implementation__>("Model.FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_Parent", "A_TypeRef");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<TypeRef__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<TypeRef__Implementation__>("Model.FK_TypeRef_GenericArgumentsCollectionEntry_TypeRef_fk_Parent", "A_TypeRef");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (TypeRef__Implementation__)value;
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
