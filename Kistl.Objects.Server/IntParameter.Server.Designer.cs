//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
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
    using Kistl.API.Server;
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="IntParameter")]
    public class IntParameter : Kistl.App.Base.BaseParameter, ICloneable
    {
        
        public IntParameter()
        {
        }
        
        public event ToStringHandler<IntParameter> OnToString_IntParameter;
        
        public event ObjectEventHandler<IntParameter> OnPreSave_IntParameter;
        
        public event ObjectEventHandler<IntParameter> OnPostSave_IntParameter;
        
        public event GetDataType_Handler<IntParameter> OnGetDataType_IntParameter;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_IntParameter != null)
            {
                OnToString_IntParameter(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_IntParameter != null) OnPreSave_IntParameter(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_IntParameter != null) OnPostSave_IntParameter(this);
        }
        
        public override object Clone()
        {
            IntParameter obj = new IntParameter();
            CopyTo(obj);
            return obj;
        }
        
        public override void CopyTo(Kistl.API.IDataObject obj)
        {
            base.CopyTo(obj);
        }
        
        public override string GetDataType()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            e.Result = base.GetDataType();
            if (OnGetDataType_IntParameter != null)
            {
                OnGetDataType_IntParameter(this, e);
            };
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
        }
        
        public override void FromStream(Kistl.API.IKistlContext ctx, System.IO.BinaryReader sr)
        {
            base.FromStream(ctx, sr);
        }
    }
}
