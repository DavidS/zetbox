//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:2.0.50727.1433
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Collections;
    using System.Xml;
    using System.Xml.Serialization;
    using Kistl.API;
    using Kistl.API.Client;
    
    
    public class DoubleProperty : Kistl.App.Base.ValueTypeProperty, ICloneable
    {
        
        public event ToStringHandler<DoubleProperty> OnToString_DoubleProperty;
        
        public event ObjectEventHandler<DoubleProperty> OnPreSave_DoubleProperty;
        
        public event ObjectEventHandler<DoubleProperty> OnPostSave_DoubleProperty;
        
        public event GetDataType_Handler<DoubleProperty> OnGetDataType_DoubleProperty;
        
        public event GetGUIRepresentation_Handler<DoubleProperty> OnGetGUIRepresentation_DoubleProperty;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DoubleProperty != null)
            {
                OnToString_DoubleProperty(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DoubleProperty != null) OnPreSave_DoubleProperty(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DoubleProperty != null) OnPostSave_DoubleProperty(this);
        }
        
        public override object Clone()
        {
            DoubleProperty obj = new DoubleProperty();
            CopyTo(obj);
            return obj;
        }
        
        public void CopyTo(DoubleProperty obj)
        {
            base.CopyTo(obj);
        }
        
        public override string GetDataType()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.GetDataType();
            if (OnGetDataType_DoubleProperty != null)
            {
                OnGetDataType_DoubleProperty(this, e);
            }
            return e.Result;
        }
        
        public override string GetGUIRepresentation()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.GetGUIRepresentation();
            if (OnGetGUIRepresentation_DoubleProperty != null)
            {
                OnGetGUIRepresentation_DoubleProperty(this, e);
            }
            return e.Result;
        }
    }
}
