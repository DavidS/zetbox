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
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="DateTimeProperty")]
    public class DateTimeProperty : Kistl.App.Base.ValueTypeProperty, ICloneable
    {
        
        public event ToStringHandler<DateTimeProperty> OnToString_DateTimeProperty;
        
        public event ObjectEventHandler<DateTimeProperty> OnPreSave_DateTimeProperty;
        
        public event ObjectEventHandler<DateTimeProperty> OnPostSave_DateTimeProperty;
        
        public event GetDataType_Handler<DateTimeProperty> OnGetDataType_DateTimeProperty;
        
        public event GetGUIRepresentation_Handler<DateTimeProperty> OnGetGUIRepresentation_DateTimeProperty;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DateTimeProperty != null)
            {
                OnToString_DateTimeProperty(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DateTimeProperty != null) OnPreSave_DateTimeProperty(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DateTimeProperty != null) OnPostSave_DateTimeProperty(this);
        }
        
        public override object Clone()
        {
            DateTimeProperty obj = new DateTimeProperty();
            CopyTo(obj);
            return obj;
        }
        
        public void CopyTo(DateTimeProperty obj)
        {
            base.CopyTo(obj);
        }
        
        public override string GetDataType()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.GetDataType();
            if (OnGetDataType_DateTimeProperty != null)
            {
                OnGetDataType_DateTimeProperty(this, e);
            }
            return e.Result;
        }
        
        public override string GetGUIRepresentation()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.GetGUIRepresentation();
            if (OnGetGUIRepresentation_DateTimeProperty != null)
            {
                OnGetGUIRepresentation_DateTimeProperty(this, e);
            }
            return e.Result;
        }
    }
}
