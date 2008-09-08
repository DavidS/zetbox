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
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Kistl.API.Client;
    
    
    public class ObjectParameterImpl : Kistl.App.Base.BaseParameterImpl, ObjectParameter
    {
        
        private System.Nullable<int> _fk_DataType = null;
        
        public ObjectParameterImpl()
        {
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.DataType DataType
        {
            get
            {
                if (fk_DataType == null) return null;
                return Context.Find<Kistl.App.Base.DataType>(fk_DataType.Value);
            }
            set
            {
                fk_DataType = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_DataType
        {
            get
            {
                return _fk_DataType;
            }
            set
            {
                if (fk_DataType != value)
                {
                    NotifyPropertyChanging("DataType"); 
                    _fk_DataType = value;
                    NotifyPropertyChanged("DataType");;
                }
            }
        }
        
        public event ToStringHandler<ObjectParameter> OnToString_ObjectParameter;
        
        public event ObjectEventHandler<ObjectParameter> OnPreSave_ObjectParameter;
        
        public event ObjectEventHandler<ObjectParameter> OnPostSave_ObjectParameter;
        
        public event GetParameterTypeString_Handler<ObjectParameter> OnGetParameterTypeString_ObjectParameter;
        
        public event GetParameterType_Handler<ObjectParameter> OnGetParameterType_ObjectParameter;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ObjectParameter != null)
            {
                OnToString_ObjectParameter(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ObjectParameter != null) OnPreSave_ObjectParameter(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ObjectParameter != null) OnPostSave_ObjectParameter(this);
        }
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((ObjectParameterImpl)obj).fk_DataType = this.fk_DataType;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override string GetParameterTypeString()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            e.Result = base.GetParameterTypeString();
            if (OnGetParameterTypeString_ObjectParameter != null)
            {
                OnGetParameterTypeString_ObjectParameter(this, e);
            };
            return e.Result;
        }
        
        public override System.Type GetParameterType()
        {
            MethodReturnEventArgs<System.Type> e = new MethodReturnEventArgs<System.Type>();
            e.Result = base.GetParameterType();
            if (OnGetParameterType_ObjectParameter != null)
            {
                OnGetParameterType_ObjectParameter(this, e);
            };
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_DataType, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_DataType, sr);
        }
    }
}
