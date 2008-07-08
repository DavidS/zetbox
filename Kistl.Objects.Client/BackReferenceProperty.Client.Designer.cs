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
    
    
    public class BackReferenceProperty : Kistl.App.Base.BaseProperty, ICloneable
    {
        
        private int _fk_ReferenceProperty = Helper.INVALIDID;
        
        private bool _PreFetchToClient;
        
        public BackReferenceProperty()
        {
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.ObjectReferenceProperty ReferenceProperty
        {
            get
            {
                return Context.Find<Kistl.App.Base.ObjectReferenceProperty>(fk_ReferenceProperty);
            }
            set
            {
                fk_ReferenceProperty = value != null ? value.ID : Helper.INVALIDID;
            }
        }
        
        public int fk_ReferenceProperty
        {
            get
            {
                return _fk_ReferenceProperty;
            }
            set
            {
                if (fk_ReferenceProperty != value)
                {
                    NotifyPropertyChanging("ReferenceProperty"); 
                    _fk_ReferenceProperty = value;
                    NotifyPropertyChanged("ReferenceProperty");
                }
            }
        }
        
        public bool PreFetchToClient
        {
            get
            {
                return _PreFetchToClient;
            }
            set
            {
                NotifyPropertyChanging("PreFetchToClient"); 
                _PreFetchToClient = value; 
                NotifyPropertyChanged("PreFetchToClient");;
            }
        }
        
        public event ToStringHandler<BackReferenceProperty> OnToString_BackReferenceProperty;
        
        public event ObjectEventHandler<BackReferenceProperty> OnPreSave_BackReferenceProperty;
        
        public event ObjectEventHandler<BackReferenceProperty> OnPostSave_BackReferenceProperty;
        
        public event GetDataType_Handler<BackReferenceProperty> OnGetDataType_BackReferenceProperty;
        
        public event GetGUIRepresentation_Handler<BackReferenceProperty> OnGetGUIRepresentation_BackReferenceProperty;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_BackReferenceProperty != null)
            {
                OnToString_BackReferenceProperty(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_BackReferenceProperty != null) OnPreSave_BackReferenceProperty(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_BackReferenceProperty != null) OnPostSave_BackReferenceProperty(this);
        }
        
        public override object Clone()
        {
            BackReferenceProperty obj = new BackReferenceProperty();
            CopyTo(obj);
            return obj;
        }
        
        public override void CopyTo(Kistl.API.IDataObject obj)
        {
            base.CopyTo(obj);
            ((BackReferenceProperty)obj)._fk_ReferenceProperty = this._fk_ReferenceProperty;
            ((BackReferenceProperty)obj)._PreFetchToClient = this._PreFetchToClient;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override string GetDataType()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            e.Result = base.GetDataType();
            if (OnGetDataType_BackReferenceProperty != null)
            {
                OnGetDataType_BackReferenceProperty(this, e);
            };
            return e.Result;
        }
        
        public override string GetGUIRepresentation()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            e.Result = base.GetGUIRepresentation();
            if (OnGetGUIRepresentation_BackReferenceProperty != null)
            {
                OnGetGUIRepresentation_BackReferenceProperty(this, e);
            };
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_ReferenceProperty, sw);
            BinarySerializer.ToBinary(this._PreFetchToClient, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_ReferenceProperty, sr);
            BinarySerializer.FromBinary(out this._PreFetchToClient, sr);
        }
    }
}
