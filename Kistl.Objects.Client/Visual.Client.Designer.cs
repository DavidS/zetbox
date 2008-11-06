//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    using Kistl.API.Client;
    
    
    public class Visual__Implementation__ : BaseClientDataObject, Visual
    {
        
        private string _Description;
        
        private Kistl.App.GUI.VisualType _ControlType;
        
        private ListPropertyCollection<Kistl.App.GUI.Visual, Kistl.App.GUI.Visual, Visual_ChildrenCollectionEntry__Implementation__> _Children;
        
        private System.Nullable<int> _fk_Property = null;
        
        private System.Nullable<int> _fk_Method = null;
        
        private ListPropertyCollection<Kistl.App.GUI.Visual, Kistl.App.GUI.Visual, Visual_ContextMenuCollectionEntry__Implementation__> _ContextMenu;
        
        public Visual__Implementation__()
        {
            _Children = new ListPropertyCollection<Kistl.App.GUI.Visual, Kistl.App.GUI.Visual, Visual_ChildrenCollectionEntry__Implementation__>(this, "Children");
            _ContextMenu = new ListPropertyCollection<Kistl.App.GUI.Visual, Kistl.App.GUI.Visual, Visual_ContextMenuCollectionEntry__Implementation__>(this, "ContextMenu");
        }
        
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
        
        public IList<Kistl.App.GUI.Visual> Children
        {
            get
            {
                return _Children;
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.BaseProperty Property
        {
            get
            {
                if (fk_Property == null) return null;
                return Context.Find<Kistl.App.Base.BaseProperty>(fk_Property.Value);
            }
            set
            {
                fk_Property = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_Property
        {
            get
            {
                return _fk_Property;
            }
            set
            {
                if (fk_Property != value)
                {
                    NotifyPropertyChanging("Property"); 
                    _fk_Property = value;
                    NotifyPropertyChanged("Property");;
                }
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.Method Method
        {
            get
            {
                if (fk_Method == null) return null;
                return Context.Find<Kistl.App.Base.Method>(fk_Method.Value);
            }
            set
            {
                fk_Method = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_Method
        {
            get
            {
                return _fk_Method;
            }
            set
            {
                if (fk_Method != value)
                {
                    NotifyPropertyChanging("Method"); 
                    _fk_Method = value;
                    NotifyPropertyChanged("Method");;
                }
            }
        }
        
        public IList<Kistl.App.GUI.Visual> ContextMenu
        {
            get
            {
                return _ContextMenu;
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
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((Visual__Implementation__)obj).Description = this.Description;
            ((Visual__Implementation__)obj).ControlType = this.ControlType;
            this._Children.ApplyChanges(((Visual__Implementation__)obj)._Children);
            ((Visual__Implementation__)obj).fk_Property = this.fk_Property;
            ((Visual__Implementation__)obj).fk_Method = this.fk_Method;
            this._ContextMenu.ApplyChanges(((Visual__Implementation__)obj)._ContextMenu);
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            _Children.AttachToContext(ctx);
            _ContextMenu.AttachToContext(ctx);
        }
        
        protected override string GetPropertyError(string prop)
        {
            switch(prop)
            {
                case "Description":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(149).Constraints
                            .Where(c => !c.IsValid(this, this.Description))
                            .Select(c => c.GetErrorText(this, this.Description))
                            .ToArray());
                case "ControlType":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(150).Constraints
                            .Where(c => !c.IsValid(this, this.ControlType))
                            .Select(c => c.GetErrorText(this, this.ControlType))
                            .ToArray());
                case "Children":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(151).Constraints
                            .Where(c => !c.IsValid(this, this.Children))
                            .Select(c => c.GetErrorText(this, this.Children))
                            .ToArray());
                case "Property":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(152).Constraints
                            .Where(c => !c.IsValid(this, this.Property))
                            .Select(c => c.GetErrorText(this, this.Property))
                            .ToArray());
                case "Method":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(153).Constraints
                            .Where(c => !c.IsValid(this, this.Method))
                            .Select(c => c.GetErrorText(this, this.Method))
                            .ToArray());
                case "ContextMenu":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(164).Constraints
                            .Where(c => !c.IsValid(this, this.ContextMenu))
                            .Select(c => c.GetErrorText(this, this.ContextMenu))
                            .ToArray());
            }
            return base.GetPropertyError(prop);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this._Description, sw);
            BinarySerializer.ToBinary((int)this._ControlType, sw);
            this._Children.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Property, sw);
            BinarySerializer.ToBinary(this.fk_Method, sw);
            this._ContextMenu.ToStream(sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._Description, sr);
            int tmpControlType; BinarySerializer.FromBinary(out tmpControlType, sr); _ControlType = (Kistl.App.GUI.VisualType)tmpControlType;
            this._Children.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Property, sr);
            BinarySerializer.FromBinary(out this._fk_Method, sr);
            this._ContextMenu.FromStream(sr);
        }
    }
    
    public class Visual_ChildrenCollectionEntry__Implementation__ : Kistl.API.Client.BaseClientCollectionEntry, ICollectionEntry<Kistl.App.GUI.Visual, Kistl.App.GUI.Visual>
    {
        
        private int _fk_Value;
        
        private int _fk_Parent;
        
        [XmlIgnore()]
        public Kistl.App.GUI.Visual Value
        {
            get
            {
                return Context.GetQuery<Kistl.App.GUI.Visual>().Single(o => o.ID == fk_Value);
            }
            set
            {
                fk_Value = value.ID;;
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.GUI.Visual Parent
        {
            get
            {
                return Context.GetQuery<Visual>().Single(o => o.ID == fk_Parent);
            }
            set
            {
                _fk_Parent = value.ID;
            }
        }
        
        public int fk_Value
        {
            get
            {
                return _fk_Value;
            }
            set
            {
                if(_fk_Value != value)
                {
                    base.NotifyPropertyChanging("Value");
                    _fk_Value = value;
                    base.NotifyPropertyChanged("Value");
                };
            }
        }
        
        public int fk_Parent
        {
            get
            {
                return _fk_Parent;
            }
            set
            {
                _fk_Parent = value;
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
        
        public override void ApplyChanges(Kistl.API.ICollectionEntry obj)
        {
            base.ApplyChanges(obj);
            ((Visual_ChildrenCollectionEntry__Implementation__)obj)._fk_Value = this.fk_Value;
            ((Visual_ChildrenCollectionEntry__Implementation__)obj)._fk_Parent = this.fk_Parent;
        }
    }
    
    public class Visual_ContextMenuCollectionEntry__Implementation__ : Kistl.API.Client.BaseClientCollectionEntry, ICollectionEntry<Kistl.App.GUI.Visual, Kistl.App.GUI.Visual>
    {
        
        private int _fk_Value;
        
        private int _fk_Parent;
        
        [XmlIgnore()]
        public Kistl.App.GUI.Visual Value
        {
            get
            {
                return Context.GetQuery<Kistl.App.GUI.Visual>().Single(o => o.ID == fk_Value);
            }
            set
            {
                fk_Value = value.ID;;
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.GUI.Visual Parent
        {
            get
            {
                return Context.GetQuery<Visual>().Single(o => o.ID == fk_Parent);
            }
            set
            {
                _fk_Parent = value.ID;
            }
        }
        
        public int fk_Value
        {
            get
            {
                return _fk_Value;
            }
            set
            {
                if(_fk_Value != value)
                {
                    base.NotifyPropertyChanging("Value");
                    _fk_Value = value;
                    base.NotifyPropertyChanged("Value");
                };
            }
        }
        
        public int fk_Parent
        {
            get
            {
                return _fk_Parent;
            }
            set
            {
                _fk_Parent = value;
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
        
        public override void ApplyChanges(Kistl.API.ICollectionEntry obj)
        {
            base.ApplyChanges(obj);
            ((Visual_ContextMenuCollectionEntry__Implementation__)obj)._fk_Value = this.fk_Value;
            ((Visual_ContextMenuCollectionEntry__Implementation__)obj)._fk_Parent = this.fk_Parent;
        }
    }
}
