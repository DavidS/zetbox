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
    
    
    public class Method__Implementation__ : BaseClientDataObject, Method
    {
        
        private System.Nullable<int> _fk_ObjectClass = null;
        
        private string _MethodName;
        
        private System.Nullable<int> _fk_Module = null;
        
        private BackReferenceCollection<Kistl.App.Base.MethodInvocation> _MethodInvokations;
        
        private BackReferenceCollection<Kistl.App.Base.BaseParameter> _Parameter;
        
        private bool _IsDisplayable;
        
        private string _Description;
        
        public Method__Implementation__()
        {
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.DataType ObjectClass
        {
            get
            {
                if (fk_ObjectClass == null) return null;
                return Context.Find<Kistl.App.Base.DataType>(fk_ObjectClass.Value);
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (value != null)
                {
                    if (fk_ObjectClass != value.ID && fk_ObjectClass != null) ObjectClass.Methods.Remove(this);
                    fk_ObjectClass = value.ID;
                    if (!value.Methods.Contains(this)) value.Methods.Add(this);
                }
                else
                {
                    if (ObjectClass != null && ObjectClass.Methods.Contains(this)) ObjectClass.Methods.Remove(this);
                    fk_ObjectClass = null;
                };
            }
        }
        
        public System.Nullable<int> fk_ObjectClass
        {
            get
            {
                return _fk_ObjectClass;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (fk_ObjectClass != value)
                {
                    NotifyPropertyChanging("ObjectClass"); 
                    _fk_ObjectClass = value;
                    NotifyPropertyChanged("ObjectClass");;
                }
            }
        }
        
        public string MethodName
        {
            get
            {
                return _MethodName;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (MethodName != value)
                {
                    NotifyPropertyChanging("MethodName"); 
                    _MethodName = value;
                    NotifyPropertyChanged("MethodName");;
                }
            }
        }
        
        [XmlIgnore()]
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
        public ICollection<Kistl.App.Base.MethodInvocation> MethodInvokations
        {
            get
            {
                if (_MethodInvokations == null)
                {
                    List<Kistl.App.Base.MethodInvocation> serverList;
                    if (Helper.IsPersistedObject(this))
                        serverList = Context.GetListOf<Kistl.App.Base.MethodInvocation>(this, "MethodInvokations");
                    else
                        serverList = new List<Kistl.App.Base.MethodInvocation>();

                    _MethodInvokations = new BackReferenceCollection<Kistl.App.Base.MethodInvocation>(
                         "Method", this, serverList);
                }
                return _MethodInvokations;
            }
        }
        
        [XmlIgnore()]
        public ICollection<Kistl.App.Base.BaseParameter> Parameter
        {
            get
            {
                if (_Parameter == null)
                {
                    List<Kistl.App.Base.BaseParameter> serverList;
                    if (Helper.IsPersistedObject(this))
                        serverList = Context.GetListOf<Kistl.App.Base.BaseParameter>(this, "Parameter");
                    else
                        serverList = new List<Kistl.App.Base.BaseParameter>();

                    _Parameter = new BackReferenceCollection<Kistl.App.Base.BaseParameter>(
                         "Method", this, serverList);
                }
                return _Parameter;
            }
        }
        
        public bool IsDisplayable
        {
            get
            {
                return _IsDisplayable;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (IsDisplayable != value)
                {
                    NotifyPropertyChanging("IsDisplayable"); 
                    _IsDisplayable = value;
                    NotifyPropertyChanged("IsDisplayable");;
                }
            }
        }
        
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (Description != value)
                {
                    NotifyPropertyChanging("Description"); 
                    _Description = value;
                    NotifyPropertyChanged("Description");;
                }
            }
        }
        
        public event ToStringHandler<Method> OnToString_Method;
        
        public event ObjectEventHandler<Method> OnPreSave_Method;
        
        public event ObjectEventHandler<Method> OnPostSave_Method;
        
        public event GetReturnParameter_Handler<Method> OnGetReturnParameter_Method;
        
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
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((Method__Implementation__)obj).fk_ObjectClass = this.fk_ObjectClass;
            ((Method__Implementation__)obj).MethodName = this.MethodName;
            ((Method__Implementation__)obj).fk_Module = this.fk_Module;
            if(this._MethodInvokations != null) this._MethodInvokations.ApplyChanges(((Method__Implementation__)obj)._MethodInvokations); else ((Method__Implementation__)obj)._MethodInvokations = null; ((Method__Implementation__)obj).NotifyPropertyChanged("MethodInvokations");
            if(this._Parameter != null) this._Parameter.ApplyChanges(((Method__Implementation__)obj)._Parameter); else ((Method__Implementation__)obj)._Parameter = null; ((Method__Implementation__)obj).NotifyPropertyChanged("Parameter");
            ((Method__Implementation__)obj).IsDisplayable = this.IsDisplayable;
            ((Method__Implementation__)obj).Description = this.Description;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            if(_MethodInvokations != null) _MethodInvokations.AttachToContext(ctx);
            if(_Parameter != null) _Parameter.AttachToContext(ctx);
        }
        
        protected override string GetPropertyError(string prop)
        {
            switch(prop)
            {
                case "ObjectClass":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(29).Constraints
                            .Where(c => !c.IsValid(this, this.ObjectClass))
                            .Select(c => c.GetErrorText(this, this.ObjectClass))
                            .ToArray());
                case "MethodName":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(30).Constraints
                            .Where(c => !c.IsValid(this, this.MethodName))
                            .Select(c => c.GetErrorText(this, this.MethodName))
                            .ToArray());
                case "Module":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(73).Constraints
                            .Where(c => !c.IsValid(this, this.Module))
                            .Select(c => c.GetErrorText(this, this.Module))
                            .ToArray());
                case "MethodInvokations":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(81).Constraints
                            .Where(c => !c.IsValid(this, this.MethodInvokations))
                            .Select(c => c.GetErrorText(this, this.MethodInvokations))
                            .ToArray());
                case "Parameter":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(96).Constraints
                            .Where(c => !c.IsValid(this, this.Parameter))
                            .Select(c => c.GetErrorText(this, this.Parameter))
                            .ToArray());
                case "IsDisplayable":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(124).Constraints
                            .Where(c => !c.IsValid(this, this.IsDisplayable))
                            .Select(c => c.GetErrorText(this, this.IsDisplayable))
                            .ToArray());
                case "Description":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(180).Constraints
                            .Where(c => !c.IsValid(this, this.Description))
                            .Select(c => c.GetErrorText(this, this.Description))
                            .ToArray());
            }
            return base.GetPropertyError(prop);
        }
        
        public virtual Kistl.App.Base.BaseParameter GetReturnParameter()
        {
            MethodReturnEventArgs<Kistl.App.Base.BaseParameter> e = new MethodReturnEventArgs<Kistl.App.Base.BaseParameter>();
            if (OnGetReturnParameter_Method != null)
            {
                OnGetReturnParameter_Method(this, e);
            };
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_ObjectClass, sw);
            BinarySerializer.ToBinary(this._MethodName, sw);
            BinarySerializer.ToBinary(this.fk_Module, sw);
            BinarySerializer.ToBinary(this._IsDisplayable, sw);
            BinarySerializer.ToBinary(this._Description, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_ObjectClass, sr);
            BinarySerializer.FromBinary(out this._MethodName, sr);
            BinarySerializer.FromBinary(out this._fk_Module, sr);
            BinarySerializer.FromBinary(out this._IsDisplayable, sr);
            BinarySerializer.FromBinary(out this._Description, sr);
        }
        
        public delegate void GetReturnParameter_Handler<T>(T obj, MethodReturnEventArgs<Kistl.App.Base.BaseParameter> e);
    }
}
