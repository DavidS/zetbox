//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_Visual_ChildrenCollectionEntry_Visual_Children", "A_Visual", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.GUI.VisualImpl), "B_Visual_ChildrenCollectionEntry", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.GUI.Visual_ChildrenCollectionEntryImpl))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_Visual_BaseProperty_Property", "A_BaseProperty", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.BasePropertyImpl), "B_Visual", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.GUI.VisualImpl))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_Visual_Method_Method", "A_Method", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Base.MethodImpl), "B_Visual", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.GUI.VisualImpl))]
[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_Visual_ChildrenCollectionEntry_Visual_fk_Parent", "A_Visual", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.GUI.VisualImpl), "B_Visual_ChildrenCollectionEntry", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.GUI.Visual_ChildrenCollectionEntryImpl))]

namespace Kistl.App.GUI
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
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Visual")]
    public class VisualImpl : BaseServerDataObject, Visual
    {
        
        private int _ID;
        
        private string _Description;
        
        private Kistl.App.GUI.VisualType _ControlType;
        
        private EntityCollectionEntryValueWrapper<Kistl.App.GUI.Visual, Kistl.App.GUI.Visual, Kistl.App.GUI.Visual_ChildrenCollectionEntryImpl> ChildrenWrapper;
        
        private System.Nullable<int> _fk_Property = null;
        
        private System.Nullable<int> _fk_Method = null;
        
        public VisualImpl()
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
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                if (Description != value)
                {
                    NotifyPropertyChanging("Description"); 
                    _Description = value;
                    NotifyPropertyChanged("Description");;
                }
            }
        }
        
        public Kistl.App.GUI.VisualType ControlType
        {
            get
            {
                return _ControlType;
            }
            set
            {
                if (ControlType != value)
                {
                    NotifyPropertyChanging("ControlType"); 
                    _ControlType = value;
                    NotifyPropertyChanged("ControlType");;
                }
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public int ControlTypeImpl
        {
            get
            {
                return (int)ControlType;
            }
            set
            {
                ControlType = (Kistl.App.GUI.VisualType)value;
            }
        }
        
        public IList<Kistl.App.GUI.Visual> Children
        {
            get
            {
                if (ChildrenWrapper == null) ChildrenWrapper = new EntityCollectionEntryValueWrapper<Kistl.App.GUI.Visual, Kistl.App.GUI.Visual, Kistl.App.GUI.Visual_ChildrenCollectionEntryImpl>(this, ChildrenImpl);
                return ChildrenWrapper;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Visual_ChildrenCollectionEntry_Visual_fk_Parent", "B_Visual_ChildrenCollectionEntry")]
        public EntityCollection<Kistl.App.GUI.Visual_ChildrenCollectionEntryImpl> ChildrenImpl
        {
            get
            {
                EntityCollection<Visual_ChildrenCollectionEntryImpl> c = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Visual_ChildrenCollectionEntryImpl>("Model.FK_Visual_ChildrenCollectionEntry_Visual_fk_Parent", "B_Visual_ChildrenCollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !c.IsLoaded) c.Load(); 
                return c;
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.BaseProperty Property
        {
            get
            {
                return PropertyImpl;
            }
            set
            {
                PropertyImpl = (Kistl.App.Base.BasePropertyImpl)value;
            }
        }
        
        public System.Nullable<int> fk_Property
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && Property != null)
                {
                    _fk_Property = Property.ID;
                }
                return _fk_Property;
            }
            set
            {
                _fk_Property = value;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Visual_BaseProperty_Property", "A_BaseProperty")]
        public Kistl.App.Base.BasePropertyImpl PropertyImpl
        {
            get
            {
                EntityReference<Kistl.App.Base.BasePropertyImpl> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.BasePropertyImpl>("Model.FK_Visual_BaseProperty_Property", "A_BaseProperty");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.BasePropertyImpl> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.BasePropertyImpl>("Model.FK_Visual_BaseProperty_Property", "A_BaseProperty");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (Kistl.App.Base.BasePropertyImpl)value;
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
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Visual_Method_Method", "A_Method")]
        public Kistl.App.Base.MethodImpl MethodImpl
        {
            get
            {
                EntityReference<Kistl.App.Base.MethodImpl> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.MethodImpl>("Model.FK_Visual_Method_Method", "A_Method");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.MethodImpl> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.MethodImpl>("Model.FK_Visual_Method_Method", "A_Method");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (Kistl.App.Base.MethodImpl)value;
            }
        }
        
        public event ToStringHandler<Visual> OnToString_Visual;
        
        public event ObjectEventHandler<Visual> OnPreSave_Visual;
        
        public event ObjectEventHandler<Visual> OnPostSave_Visual;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Visual != null)
            {
                OnToString_Visual(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Visual != null) OnPreSave_Visual(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Visual != null) OnPostSave_Visual(this);
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            Children.ToList().ForEach<ICollectionEntry>(i => ctx.Attach(i));
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this._Description, sw);
            BinarySerializer.ToBinary((int)this._ControlType, sw);
            BinarySerializer.ToBinary(this.ChildrenImpl, sw);
            BinarySerializer.ToBinary(this.fk_Property, sw);
            BinarySerializer.ToBinary(this.fk_Method, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._Description, sr);
            int tmpControlType; BinarySerializer.FromBinary(out tmpControlType, sr); _ControlType = (Kistl.App.GUI.VisualType)tmpControlType;
            BinarySerializer.FromBinaryCollectionEntries(this.ChildrenImpl, sr);
            BinarySerializer.FromBinary(out this._fk_Property, sr);
            BinarySerializer.FromBinary(out this._fk_Method, sr);
        }
    }
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="Visual_ChildrenCollectionEntry")]
    public class Visual_ChildrenCollectionEntryImpl : Kistl.API.Server.BaseServerCollectionEntry, ICollectionEntry<Kistl.App.GUI.Visual, Kistl.App.GUI.Visual>
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
        public Kistl.App.GUI.Visual Value
        {
            get
            {
                return ValueImpl;
            }
            set
            {
                ValueImpl = (Kistl.App.GUI.VisualImpl)value;
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.GUI.Visual Parent
        {
            get
            {
                return ParentImpl;
            }
            set
            {
                ParentImpl = (Kistl.App.GUI.VisualImpl)value;
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
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Visual_ChildrenCollectionEntry_Visual_Children", "A_Visual")]
        public Kistl.App.GUI.VisualImpl ValueImpl
        {
            get
            {
                EntityReference<Kistl.App.GUI.VisualImpl> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.VisualImpl>("Model.FK_Visual_ChildrenCollectionEntry_Visual_Children", "A_Visual");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.GUI.VisualImpl> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.VisualImpl>("Model.FK_Visual_ChildrenCollectionEntry_Visual_Children", "A_Visual");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (Kistl.App.GUI.VisualImpl)value;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_Visual_ChildrenCollectionEntry_Visual_fk_Parent", "A_Visual")]
        public Kistl.App.GUI.VisualImpl ParentImpl
        {
            get
            {
                EntityReference<VisualImpl> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<VisualImpl>("Model.FK_Visual_ChildrenCollectionEntry_Visual_fk_Parent", "A_Visual");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<VisualImpl> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<VisualImpl>("Model.FK_Visual_ChildrenCollectionEntry_Visual_fk_Parent", "A_Visual");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (VisualImpl)value;
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
