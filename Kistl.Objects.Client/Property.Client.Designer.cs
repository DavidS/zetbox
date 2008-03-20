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
    using Kistl.API.Client;
    
    
    public class Property : Kistl.App.Base.BaseProperty, ICloneable
    {
        
        private bool _IsList;
        
        private bool _IsNullable;
        
        public Property()
        {
        }
        
        public bool IsList
        {
            get
            {
                return _IsList;
            }
            set
            {
                NotifyPropertyChanging("IsList"); 
                _IsList = value; 
                NotifyPropertyChanged("IsList");;
            }
        }
        
        public bool IsNullable
        {
            get
            {
                return _IsNullable;
            }
            set
            {
                NotifyPropertyChanging("IsNullable"); 
                _IsNullable = value; 
                NotifyPropertyChanged("IsNullable");;
            }
        }
        
        public event ToStringHandler<Property> OnToString_Property;
        
        public event ObjectEventHandler<Property> OnPreSave_Property;
        
        public event ObjectEventHandler<Property> OnPostSave_Property;
        
        public event GetDataType_Handler<Property> OnGetDataType_Property;
        
        public event GetGUIRepresentation_Handler<Property> OnGetGUIRepresentation_Property;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Property != null)
            {
                OnToString_Property(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Property != null) OnPreSave_Property(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Property != null) OnPostSave_Property(this);
        }
        
        public override object Clone()
        {
            Property obj = new Property();
            CopyTo(obj);
            return obj;
        }
        
        public override void CopyTo(Kistl.API.IDataObject obj)
        {
            base.CopyTo(obj);
            ((Property)obj)._IsList = this._IsList;
            ((Property)obj)._IsNullable = this._IsNullable;
        }
        
        public override void AttachToContext(KistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override string GetDataType()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            e.Result = base.GetDataType();
            if (OnGetDataType_Property != null)
            {
                OnGetDataType_Property(this, e);
            };
            return e.Result;
        }
        
        public override string GetGUIRepresentation()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            e.Result = base.GetGUIRepresentation();
            if (OnGetGUIRepresentation_Property != null)
            {
                OnGetGUIRepresentation_Property(this, e);
            };
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this._IsList, sw);
            BinarySerializer.ToBinary(this._IsNullable, sw);
        }
        
        public override void FromStream(Kistl.API.IKistlContext ctx, System.IO.BinaryReader sr)
        {
            base.FromStream(ctx, sr);
            BinarySerializer.FromBinary(out this._IsList, sr);
            BinarySerializer.FromBinary(out this._IsNullable, sr);
        }
    }
}
