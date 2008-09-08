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
    using Kistl.API.Client;
    
    
    public class EnumerationImpl : Kistl.App.Base.DataTypeImpl, Enumeration
    {
        
        private BackReferenceCollection<Kistl.App.Base.EnumerationEntry> _EnumerationEntries;
        
        public EnumerationImpl()
        {
        }
        
        [XmlIgnore()]
        public ICollection<Kistl.App.Base.EnumerationEntry> EnumerationEntries
        {
            get
            {
                if (_EnumerationEntries == null)
                {
                    List<Kistl.App.Base.EnumerationEntry> serverList;
                    if (Helper.IsPersistedObject(this))
                        serverList = Context.GetListOf<Kistl.App.Base.EnumerationEntry>(this, "EnumerationEntries");
                    else
                        serverList = new List<Kistl.App.Base.EnumerationEntry>();

                    _EnumerationEntries = new BackReferenceCollection<Kistl.App.Base.EnumerationEntry>(
                         "Enumeration", this, serverList);
                }
                return _EnumerationEntries;
            }
        }
        
        public event ToStringHandler<Enumeration> OnToString_Enumeration;
        
        public event ObjectEventHandler<Enumeration> OnPreSave_Enumeration;
        
        public event ObjectEventHandler<Enumeration> OnPostSave_Enumeration;
        
        public event GetDataTypeString_Handler<Enumeration> OnGetDataTypeString_Enumeration;
        
        public event GetDataType_Handler<Enumeration> OnGetDataType_Enumeration;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Enumeration != null)
            {
                OnToString_Enumeration(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Enumeration != null) OnPreSave_Enumeration(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Enumeration != null) OnPostSave_Enumeration(this);
        }
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            if(this._EnumerationEntries != null) this._EnumerationEntries.ApplyChanges(((EnumerationImpl)obj)._EnumerationEntries); else ((EnumerationImpl)obj)._EnumerationEntries = null; ((EnumerationImpl)obj).NotifyPropertyChanged("EnumerationEntries");
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            if(_EnumerationEntries != null) _EnumerationEntries.AttachToContext(ctx);
        }
        
        public override string GetDataTypeString()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            e.Result = base.GetDataTypeString();
            if (OnGetDataTypeString_Enumeration != null)
            {
                OnGetDataTypeString_Enumeration(this, e);
            };
            return e.Result;
        }
        
        public override System.Type GetDataType()
        {
            MethodReturnEventArgs<System.Type> e = new MethodReturnEventArgs<System.Type>();
            e.Result = base.GetDataType();
            if (OnGetDataType_Enumeration != null)
            {
                OnGetDataType_Enumeration(this, e);
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
            this._EnumerationEntries = new BackReferenceCollection<Kistl.App.Base.EnumerationEntry>("Enumeration", this); BinarySerializer.FromBinary(this._EnumerationEntries, sr);
        }
    }
}
