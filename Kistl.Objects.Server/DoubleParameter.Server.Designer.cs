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
    using Kistl.API.Server;
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="DoubleParameter")]
    public class DoubleParameterImpl : Kistl.App.Base.BaseParameterImpl, DoubleParameter
    {
        
        public DoubleParameterImpl()
        {
        }
        
        public event ToStringHandler<DoubleParameter> OnToString_DoubleParameter;
        
        public event ObjectEventHandler<DoubleParameter> OnPreSave_DoubleParameter;
        
        public event ObjectEventHandler<DoubleParameter> OnPostSave_DoubleParameter;
        
        public event GetParameterTypeString_Handler<DoubleParameter> OnGetParameterTypeString_DoubleParameter;
        
        public event GetParameterType_Handler<DoubleParameter> OnGetParameterType_DoubleParameter;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DoubleParameter != null)
            {
                OnToString_DoubleParameter(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DoubleParameter != null) OnPreSave_DoubleParameter(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DoubleParameter != null) OnPostSave_DoubleParameter(this);
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override string GetParameterTypeString()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            e.Result = base.GetParameterTypeString();
            if (OnGetParameterTypeString_DoubleParameter != null)
            {
                OnGetParameterTypeString_DoubleParameter(this, e);
            };
            return e.Result;
        }
        
        public override System.Type GetParameterType()
        {
            MethodReturnEventArgs<System.Type> e = new MethodReturnEventArgs<System.Type>();
            e.Result = base.GetParameterType();
            if (OnGetParameterType_DoubleParameter != null)
            {
                OnGetParameterType_DoubleParameter(this, e);
            };
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
        }
    }
}
