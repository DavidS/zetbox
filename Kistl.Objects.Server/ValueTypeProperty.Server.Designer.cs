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
    using Kistl.API.Server;
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="ValueTypeProperty")]
    public class ValueTypeProperty : Kistl.App.Base.Property, ICloneable
    {
        
        public event ToStringHandler<ValueTypeProperty> OnToString_ValueTypeProperty;
        
        public event ObjectEventHandler<ValueTypeProperty> OnPreSave_ValueTypeProperty;
        
        public event ObjectEventHandler<ValueTypeProperty> OnPostSave_ValueTypeProperty;
        
        public event GetDataType_Handler<ValueTypeProperty> OnGetDataType_ValueTypeProperty;
        
        public event GetGUIRepresentation_Handler<ValueTypeProperty> OnGetGUIRepresentation_ValueTypeProperty;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ValueTypeProperty != null)
            {
                OnToString_ValueTypeProperty(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ValueTypeProperty != null) OnPreSave_ValueTypeProperty(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ValueTypeProperty != null) OnPostSave_ValueTypeProperty(this);
        }
        
        public override object Clone()
        {
            ValueTypeProperty obj = new ValueTypeProperty();
            CopyTo(obj);
            return obj;
        }
        
        public void CopyTo(ValueTypeProperty obj)
        {
            base.CopyTo(obj);
        }
        
        public override string GetDataType()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.GetDataType();
            if (OnGetDataType_ValueTypeProperty != null)
            {
                OnGetDataType_ValueTypeProperty(this, e);
            }
            return e.Result;
        }
        
        public override string GetGUIRepresentation()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.GetGUIRepresentation();
            if (OnGetGUIRepresentation_ValueTypeProperty != null)
            {
                OnGetGUIRepresentation_ValueTypeProperty(this, e);
            }
            return e.Result;
        }
    }
}
