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
    using Kistl.API.Client;
    
    
    public class BackReferenceProperty__Implementation__ : Kistl.App.Base.BaseProperty__Implementation__, BackReferenceProperty
    {
        
        private System.Nullable<int> _fk_ReferenceProperty = null;
        
        private bool _PreFetchToClient;
        
        public BackReferenceProperty__Implementation__()
        {
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.ObjectReferenceProperty ReferenceProperty
        {
            get
            {
                if (fk_ReferenceProperty == null) return null;
                return Context.Find<Kistl.App.Base.ObjectReferenceProperty>(fk_ReferenceProperty.Value);
            }
            set
            {
                fk_ReferenceProperty = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_ReferenceProperty
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
                    NotifyPropertyChanged("ReferenceProperty");;
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
                if (PreFetchToClient != value)
                {
                    NotifyPropertyChanging("PreFetchToClient"); 
                    _PreFetchToClient = value;
                    NotifyPropertyChanged("PreFetchToClient");;
                }
            }
        }
        
        public event ToStringHandler<BackReferenceProperty> OnToString_BackReferenceProperty;
        
        public event ObjectEventHandler<BackReferenceProperty> OnPreSave_BackReferenceProperty;
        
        public event ObjectEventHandler<BackReferenceProperty> OnPostSave_BackReferenceProperty;
        
        public event GetPropertyTypeString_Handler<BackReferenceProperty> OnGetPropertyTypeString_BackReferenceProperty;
        
        public event GetGUIRepresentation_Handler<BackReferenceProperty> OnGetGUIRepresentation_BackReferenceProperty;
        
        public event GetPropertyType_Handler<BackReferenceProperty> OnGetPropertyType_BackReferenceProperty;
        
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
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((BackReferenceProperty__Implementation__)obj).fk_ReferenceProperty = this.fk_ReferenceProperty;
            ((BackReferenceProperty__Implementation__)obj).PreFetchToClient = this.PreFetchToClient;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        protected override string GetPropertyError(string prop)
        {
            switch(prop)
            {
                case "ReferenceProperty":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(47).Constraints
                            .Where(c => !c.IsValid(this, this.ReferenceProperty))
                            .Select(c => c.GetErrorText(this, this.ReferenceProperty))
                            .ToArray());
                case "PreFetchToClient":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(84).Constraints
                            .Where(c => !c.IsValid(this, this.PreFetchToClient))
                            .Select(c => c.GetErrorText(this, this.PreFetchToClient))
                            .ToArray());
            }
            return base.GetPropertyError(prop);
        }
        
        public override string GetPropertyTypeString()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            e.Result = base.GetPropertyTypeString();
            if (OnGetPropertyTypeString_BackReferenceProperty != null)
            {
                OnGetPropertyTypeString_BackReferenceProperty(this, e);
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
        
        public override System.Type GetPropertyType()
        {
            MethodReturnEventArgs<System.Type> e = new MethodReturnEventArgs<System.Type>();
            e.Result = base.GetPropertyType();
            if (OnGetPropertyType_BackReferenceProperty != null)
            {
                OnGetPropertyType_BackReferenceProperty(this, e);
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
