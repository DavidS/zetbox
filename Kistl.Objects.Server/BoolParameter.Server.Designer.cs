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
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="BoolParameter")]
    public class BoolParameterImpl : Kistl.App.Base.BaseParameterImpl, BoolParameter
    {
        
        public BoolParameterImpl()
        {
        }
        
        public event ToStringHandler<BoolParameter> OnToString_BoolParameter;
        
        public event ObjectEventHandler<BoolParameter> OnPreSave_BoolParameter;
        
        public event ObjectEventHandler<BoolParameter> OnPostSave_BoolParameter;
        
        public event GetParameterTypeString_Handler<BoolParameter> OnGetParameterTypeString_BoolParameter;
        
        public event GetParameterType_Handler<BoolParameter> OnGetParameterType_BoolParameter;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_BoolParameter != null)
            {
                OnToString_BoolParameter(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_BoolParameter != null) OnPreSave_BoolParameter(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_BoolParameter != null) OnPostSave_BoolParameter(this);
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override string GetParameterTypeString()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            e.Result = base.GetParameterTypeString();
            if (OnGetParameterTypeString_BoolParameter != null)
            {
                OnGetParameterTypeString_BoolParameter(this, e);
            };
            return e.Result;
        }
        
        public override System.Type GetParameterType()
        {
            MethodReturnEventArgs<System.Type> e = new MethodReturnEventArgs<System.Type>();
            e.Result = base.GetParameterType();
            if (OnGetParameterType_BoolParameter != null)
            {
                OnGetParameterType_BoolParameter(this, e);
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
