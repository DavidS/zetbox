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
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="StringProperty")]
    public class StringProperty : Kistl.App.Base.ValueTypeProperty, ICloneable
    {
        
        private System.Nullable<int> _Length;
        
        [EdmScalarPropertyAttribute()]
        public System.Nullable<int> Length
        {
            get
            {
                return _Length;
            }
            set
            {
                _Length = value;
            }
        }
        
        public event ToStringHandler<StringProperty> OnToString_StringProperty;
        
        public event ObjectEventHandler<StringProperty> OnPreSave_StringProperty;
        
        public event ObjectEventHandler<StringProperty> OnPostSave_StringProperty;
        
        public event GetDataType_Handler<StringProperty> OnGetDataType_StringProperty;
        
        public event GetGUIRepresentation_Handler<StringProperty> OnGetGUIRepresentation_StringProperty;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_StringProperty != null)
            {
                OnToString_StringProperty(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_StringProperty != null) OnPreSave_StringProperty(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_StringProperty != null) OnPostSave_StringProperty(this);
        }
        
        public override object Clone()
        {
            StringProperty obj = new StringProperty();
            CopyTo(obj);
            return obj;
        }
        
        public void CopyTo(StringProperty obj)
        {
            base.CopyTo(obj);
            obj.Length = this.Length;
        }
        
        public override string GetDataType()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.GetDataType();
            if (OnGetDataType_StringProperty != null)
            {
                OnGetDataType_StringProperty(this, e);
            }
            return e.Result;
        }
        
        public override string GetGUIRepresentation()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.GetGUIRepresentation();
            if (OnGetGUIRepresentation_StringProperty != null)
            {
                OnGetGUIRepresentation_StringProperty(this, e);
            }
            return e.Result;
        }
    }
}
