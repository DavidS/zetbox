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
    
    
    public class Enumeration : Kistl.App.Base.DataType, ICloneable
    {
        
        private List<Kistl.App.Base.EnumerationEntry> _EnumerationEntries;
        
        public Enumeration()
        {
        }
        
        [XmlIgnore()]
        public List<Kistl.App.Base.EnumerationEntry> EnumerationEntries
        {
            get
            {
                if(_EnumerationEntries == null) _EnumerationEntries = Context.GetListOf<Kistl.App.Base.EnumerationEntry>(this, "EnumerationEntries");
                return _EnumerationEntries;
            }
        }
        
        public event ToStringHandler<Enumeration> OnToString_Enumeration;
        
        public event ObjectEventHandler<Enumeration> OnPreSave_Enumeration;
        
        public event ObjectEventHandler<Enumeration> OnPostSave_Enumeration;
        
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
        
        public override object Clone()
        {
            Enumeration obj = new Enumeration();
            CopyTo(obj);
            return obj;
        }
        
        public override void CopyTo(Kistl.API.IDataObject obj)
        {
            base.CopyTo(obj);
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            if(_EnumerationEntries != null) _EnumerationEntries.ToList().ForEach(i => ctx.Attach(i));
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._EnumerationEntries, sr);
        }
    }
}
