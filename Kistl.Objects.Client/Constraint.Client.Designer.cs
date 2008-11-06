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
    
    
    public class Constraint__Implementation__ : BaseClientDataObject, Constraint
    {
        
        private System.Nullable<int> _fk_ConstrainedProperty = null;
        
        private string _Reason;
        
        public Constraint__Implementation__()
        {
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.BaseProperty ConstrainedProperty
        {
            get
            {
                if (fk_ConstrainedProperty == null) return null;
                return Context.Find<Kistl.App.Base.BaseProperty>(fk_ConstrainedProperty.Value);
            }
            set
            {
                fk_ConstrainedProperty = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_ConstrainedProperty
        {
            get
            {
                return _fk_ConstrainedProperty;
            }
            set
            {
                if (fk_ConstrainedProperty != value)
                {
                    NotifyPropertyChanging("ConstrainedProperty"); 
                    _fk_ConstrainedProperty = value;
                    NotifyPropertyChanged("ConstrainedProperty");;
                }
            }
        }
        
        public string Reason
        {
            get
            {
                return _Reason;
            }
            set
            {
                if (Reason != value)
                {
                    NotifyPropertyChanging("Reason"); 
                    _Reason = value;
                    NotifyPropertyChanged("Reason");;
                }
            }
        }
        
        public event ToStringHandler<Constraint> OnToString_Constraint;
        
        public event ObjectEventHandler<Constraint> OnPreSave_Constraint;
        
        public event ObjectEventHandler<Constraint> OnPostSave_Constraint;
        
        public event IsValid_Handler<Constraint> OnIsValid_Constraint;
        
        public event GetErrorText_Handler<Constraint> OnGetErrorText_Constraint;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Constraint != null)
            {
                OnToString_Constraint(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Constraint != null) OnPreSave_Constraint(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Constraint != null) OnPostSave_Constraint(this);
        }
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((Constraint__Implementation__)obj).fk_ConstrainedProperty = this.fk_ConstrainedProperty;
            ((Constraint__Implementation__)obj).Reason = this.Reason;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        protected override string GetPropertyError(string prop)
        {
            switch(prop)
            {
                case "ConstrainedProperty":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(171).Constraints
                            .Where(c => !c.IsValid(this, this.ConstrainedProperty))
                            .Select(c => c.GetErrorText(this, this.ConstrainedProperty))
                            .ToArray());
                case "Reason":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(167).Constraints
                            .Where(c => !c.IsValid(this, this.Reason))
                            .Select(c => c.GetErrorText(this, this.Reason))
                            .ToArray());
            }
            return base.GetPropertyError(prop);
        }
        
        public virtual bool IsValid(object constrainedObj, object constrainedValue)
        {
            MethodReturnEventArgs<System.Boolean> e = new MethodReturnEventArgs<System.Boolean>();
            if (OnIsValid_Constraint != null)
            {
                OnIsValid_Constraint(this, e, constrainedObj, constrainedValue);
            };
            return e.Result;
        }
        
        public virtual string GetErrorText(object constrainedObject, object constrainedValue)
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            if (OnGetErrorText_Constraint != null)
            {
                OnGetErrorText_Constraint(this, e, constrainedObject, constrainedValue);
            };
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_ConstrainedProperty, sw);
            BinarySerializer.ToBinary(this._Reason, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_ConstrainedProperty, sr);
            BinarySerializer.FromBinary(out this._Reason, sr);
        }
        
        public delegate void IsValid_Handler<T>(T obj, MethodReturnEventArgs<bool> e, object constrainedObj, object constrainedValue);
        
        public delegate void GetErrorText_Handler<T>(T obj, MethodReturnEventArgs<string> e, object constrainedObject, object constrainedValue);
    }
}
