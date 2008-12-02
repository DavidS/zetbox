//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    using Kistl.API.Client;
    
    
    [System.Diagnostics.DebuggerDisplay("Kistl.App.Base.TypeRef")]
    public class TypeRef__Implementation__ : BaseClientDataObject, TypeRef
    {
        
        private string _FullName;
        
        private System.Nullable<int> _fk_Assembly = null;
        
        private ListPropertyCollection<Kistl.App.Base.TypeRef, Kistl.App.Base.TypeRef, TypeRef_GenericArgumentsCollectionEntry__Implementation__> _GenericArguments;
        
        public TypeRef__Implementation__()
        {
            _GenericArguments = new ListPropertyCollection<Kistl.App.Base.TypeRef, Kistl.App.Base.TypeRef, TypeRef_GenericArgumentsCollectionEntry__Implementation__>(this, "GenericArguments");
        }
        
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
                if (fk_Assembly == null) return null;
                return Context.Find<Kistl.App.Base.Assembly>(fk_Assembly.Value);
            }
            set
            {
                fk_Assembly = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_Assembly
        {
            get
            {
                return _fk_Assembly;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (fk_Assembly != value)
                {
                    NotifyPropertyChanging("Assembly"); 
                    _fk_Assembly = value;
                    NotifyPropertyChanged("Assembly");;
                }
            }
        }
        
        public IList<Kistl.App.Base.TypeRef> GenericArguments
        {
            get
            {
                return _GenericArguments;
            }
        }
        
        public event ToStringHandler<TypeRef> OnToString_TypeRef;
        
        public event ObjectEventHandler<TypeRef> OnPreSave_TypeRef;
        
        public event ObjectEventHandler<TypeRef> OnPostSave_TypeRef;
        
        public event AsType_Handler<TypeRef> OnAsType_TypeRef;
        
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
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((TypeRef__Implementation__)obj).FullName = this.FullName;
            ((TypeRef__Implementation__)obj).fk_Assembly = this.fk_Assembly;
            this._GenericArguments.ApplyChanges(((TypeRef__Implementation__)obj)._GenericArguments);
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            if(_GenericArguments != null) _GenericArguments.AttachToContext(ctx);
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
        
        public virtual System.Type AsType(bool throwOnError)
        {
            MethodReturnEventArgs<System.Type> e = new MethodReturnEventArgs<System.Type>();
            if (OnAsType_TypeRef != null)
            {
                OnAsType_TypeRef(this, e, throwOnError);
            };
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this._FullName, sw);
            BinarySerializer.ToBinary(this.fk_Assembly, sw);
            this._GenericArguments.ToStream(sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._FullName, sr);
            BinarySerializer.FromBinary(out this._fk_Assembly, sr);
            this._GenericArguments.FromStream(sr);
        }
        
        public delegate void AsType_Handler<T>(T obj, MethodReturnEventArgs<System.Type> e, bool throwOnError);
    }
    
    [System.Diagnostics.DebuggerDisplay("Kistl.App.Base.TypeRef_GenericArgumentsCollectionEntry")]
    public class TypeRef_GenericArgumentsCollectionEntry__Implementation__ : Kistl.API.Client.BaseClientCollectionEntry, ICollectionEntrySorted<Kistl.App.Base.TypeRef, Kistl.App.Base.TypeRef>
    {
        
        private int _fk_Value;
        
        private int _fk_Parent;
        
        private System.Nullable<int> _ValueIndex;
        
        private System.Nullable<int> _ParentIndex;
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.TypeRef Value
        {
            get
            {
                return Context != null && fk_Value != Kistl.API.Helper.INVALIDID ? Context.GetQuery<Kistl.App.Base.TypeRef>().Single(o => o.ID == fk_Value) : null;
            }
            set
            {
                fk_Value = value.ID;
            }
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.TypeRef Parent
        {
            get
            {
                return Context != null && fk_Parent != Kistl.API.Helper.INVALIDID ? Context.GetQuery<TypeRef>().Single(o => o.ID == fk_Parent) : null;
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
        
        public System.Nullable<int> ValueIndex
        {
            get
            {
                return _ValueIndex;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (ValueIndex != value)
                {
                    NotifyPropertyChanging("ValueIndex"); 
                    _ValueIndex = value;
                    NotifyPropertyChanged("ValueIndex");;
                }
            }
        }
        
        public System.Nullable<int> ParentIndex
        {
            get
            {
                return _ParentIndex;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (ParentIndex != value)
                {
                    NotifyPropertyChanging("ParentIndex"); 
                    _ParentIndex = value;
                    NotifyPropertyChanged("ParentIndex");;
                }
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
            ((TypeRef_GenericArgumentsCollectionEntry__Implementation__)obj)._fk_Value = this.fk_Value;
            ((TypeRef_GenericArgumentsCollectionEntry__Implementation__)obj)._fk_Parent = this.fk_Parent;
        }
    }
}
