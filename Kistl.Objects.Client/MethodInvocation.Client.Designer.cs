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
    
    
    [System.Diagnostics.DebuggerDisplay("Kistl.App.Base.MethodInvocation")]
    public class MethodInvocation__Implementation__ : BaseClientDataObject, MethodInvocation
    {
        
        private System.Nullable<int> _fk_Method = null;
        
        private string _MemberName;
        
        private System.Nullable<int> _fk_Module = null;
        
        private System.Nullable<int> _fk_InvokeOnObjectClass = null;
        
        private System.Nullable<int> _fk_Implementor = null;
        
        public MethodInvocation__Implementation__()
        {
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Method Method
        {
            get
            {
                if (fk_Method == null) return null;
                return Context.Find<Kistl.App.Base.Method>(fk_Method.Value);
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (value != null)
                {
                    if (fk_Method != value.ID && fk_Method != null) Method.MethodInvokations.Remove(this);
                    fk_Method = value.ID;
                    if (!value.MethodInvokations.Contains(this)) value.MethodInvokations.Add(this);
                }
                else
                {
                    if (Method != null && Method.MethodInvokations.Contains(this)) Method.MethodInvokations.Remove(this);
                    fk_Method = null;
                };
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
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (fk_Method != value)
                {
                    NotifyPropertyChanging("Method"); 
                    _fk_Method = value;
                    NotifyPropertyChanged("Method");;
                }
            }
        }
        
        public string MemberName
        {
            get
            {
                return _MemberName;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (MemberName != value)
                {
                    NotifyPropertyChanging("MemberName"); 
                    _MemberName = value;
                    NotifyPropertyChanged("MemberName");;
                }
            }
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Module Module
        {
            get
            {
                if (fk_Module == null) return null;
                return Context.Find<Kistl.App.Base.Module>(fk_Module.Value);
            }
            set
            {
                fk_Module = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_Module
        {
            get
            {
                return _fk_Module;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (fk_Module != value)
                {
                    NotifyPropertyChanging("Module"); 
                    _fk_Module = value;
                    NotifyPropertyChanged("Module");;
                }
            }
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.DataType InvokeOnObjectClass
        {
            get
            {
                if (fk_InvokeOnObjectClass == null) return null;
                return Context.Find<Kistl.App.Base.DataType>(fk_InvokeOnObjectClass.Value);
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (value != null)
                {
                    if (fk_InvokeOnObjectClass != value.ID && fk_InvokeOnObjectClass != null) InvokeOnObjectClass.MethodInvocations.Remove(this);
                    fk_InvokeOnObjectClass = value.ID;
                    if (!value.MethodInvocations.Contains(this)) value.MethodInvocations.Add(this);
                }
                else
                {
                    if (InvokeOnObjectClass != null && InvokeOnObjectClass.MethodInvocations.Contains(this)) InvokeOnObjectClass.MethodInvocations.Remove(this);
                    fk_InvokeOnObjectClass = null;
                };
            }
        }
        
        public System.Nullable<int> fk_InvokeOnObjectClass
        {
            get
            {
                return _fk_InvokeOnObjectClass;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (fk_InvokeOnObjectClass != value)
                {
                    NotifyPropertyChanging("InvokeOnObjectClass"); 
                    _fk_InvokeOnObjectClass = value;
                    NotifyPropertyChanged("InvokeOnObjectClass");;
                }
            }
        }
        
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.TypeRef Implementor
        {
            get
            {
                if (fk_Implementor == null) return null;
                return Context.Find<Kistl.App.Base.TypeRef>(fk_Implementor.Value);
            }
            set
            {
                fk_Implementor = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_Implementor
        {
            get
            {
                return _fk_Implementor;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (fk_Implementor != value)
                {
                    NotifyPropertyChanging("Implementor"); 
                    _fk_Implementor = value;
                    NotifyPropertyChanged("Implementor");;
                }
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
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((MethodInvocation__Implementation__)obj).fk_Method = this.fk_Method;
            ((MethodInvocation__Implementation__)obj).MemberName = this.MemberName;
            ((MethodInvocation__Implementation__)obj).fk_Module = this.fk_Module;
            ((MethodInvocation__Implementation__)obj).fk_InvokeOnObjectClass = this.fk_InvokeOnObjectClass;
            ((MethodInvocation__Implementation__)obj).fk_Implementor = this.fk_Implementor;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        protected override string GetPropertyError(string prop)
        {
            switch(prop)
            {
                case "Method":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(74).Constraints
                            .Where(c => !c.IsValid(this, this.Method))
                            .Select(c => c.GetErrorText(this, this.Method))
                            .ToArray());
                case "MemberName":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(77).Constraints
                            .Where(c => !c.IsValid(this, this.MemberName))
                            .Select(c => c.GetErrorText(this, this.MemberName))
                            .ToArray());
                case "Module":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(78).Constraints
                            .Where(c => !c.IsValid(this, this.Module))
                            .Select(c => c.GetErrorText(this, this.Module))
                            .ToArray());
                case "InvokeOnObjectClass":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(79).Constraints
                            .Where(c => !c.IsValid(this, this.InvokeOnObjectClass))
                            .Select(c => c.GetErrorText(this, this.InvokeOnObjectClass))
                            .ToArray());
                case "Implementor":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(208).Constraints
                            .Where(c => !c.IsValid(this, this.Implementor))
                            .Select(c => c.GetErrorText(this, this.Implementor))
                            .ToArray());
            }
            return base.GetPropertyError(prop);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Method, sw);
            BinarySerializer.ToBinary(this._MemberName, sw);
            BinarySerializer.ToBinary(this.fk_Module, sw);
            BinarySerializer.ToBinary(this.fk_InvokeOnObjectClass, sw);
            BinarySerializer.ToBinary(this.fk_Implementor, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Method, sr);
            BinarySerializer.FromBinary(out this._MemberName, sr);
            BinarySerializer.FromBinary(out this._fk_Module, sr);
            BinarySerializer.FromBinary(out this._fk_InvokeOnObjectClass, sr);
            BinarySerializer.FromBinary(out this._fk_Implementor, sr);
        }
    }
}
