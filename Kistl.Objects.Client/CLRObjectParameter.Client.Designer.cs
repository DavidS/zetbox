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
    
    
    public class CLRObjectParameter : Kistl.App.Base.BaseParameter, ICloneable
    {
        
        private int _fk_Assembly = Helper.INVALIDID;
        
        private string _FullTypeName;
        
        public CLRObjectParameter()
        {
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.Assembly Assembly
        {
            get
            {
                return Context.GetQuery<Kistl.App.Base.Assembly>().Single(o => o.ID == fk_Assembly);
            }
            set
            {
                NotifyPropertyChanging("Assembly"); 
                _fk_Assembly = value.ID;
                NotifyPropertyChanged("Assembly"); ;
            }
        }
        
        public int fk_Assembly
        {
            get
            {
                return _fk_Assembly;
            }
            set
            {
                NotifyPropertyChanging("Assembly"); 
                _fk_Assembly = value;
                NotifyPropertyChanged("Assembly"); ;
            }
        }
        
        public string FullTypeName
        {
            get
            {
                return _FullTypeName;
            }
            set
            {
                NotifyPropertyChanging("FullTypeName"); 
                _FullTypeName = value; 
                NotifyPropertyChanged("FullTypeName");;
            }
        }
        
        public event ToStringHandler<CLRObjectParameter> OnToString_CLRObjectParameter;
        
        public event ObjectEventHandler<CLRObjectParameter> OnPreSave_CLRObjectParameter;
        
        public event ObjectEventHandler<CLRObjectParameter> OnPostSave_CLRObjectParameter;
        
        public event GetDataType_Handler<CLRObjectParameter> OnGetDataType_CLRObjectParameter;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_CLRObjectParameter != null)
            {
                OnToString_CLRObjectParameter(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_CLRObjectParameter != null) OnPreSave_CLRObjectParameter(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_CLRObjectParameter != null) OnPostSave_CLRObjectParameter(this);
        }
        
        public override object Clone()
        {
            CLRObjectParameter obj = new CLRObjectParameter();
            CopyTo(obj);
            return obj;
        }
        
        public override void CopyTo(Kistl.API.IDataObject obj)
        {
            base.CopyTo(obj);
            ((CLRObjectParameter)obj)._fk_Assembly = this._fk_Assembly;
            ((CLRObjectParameter)obj)._FullTypeName = this._FullTypeName;
        }
        
        public override void AttachToContext(KistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override string GetDataType()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            e.Result = base.GetDataType();
            if (OnGetDataType_CLRObjectParameter != null)
            {
                OnGetDataType_CLRObjectParameter(this, e);
            };
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Assembly, sw);
            BinarySerializer.ToBinary(this._FullTypeName, sw);
        }
        
        public override void FromStream(Kistl.API.IKistlContext ctx, System.IO.BinaryReader sr)
        {
            base.FromStream(ctx, sr);
            BinarySerializer.FromBinary(out this._fk_Assembly, sr);
            BinarySerializer.FromBinary(out this._FullTypeName, sr);
        }
    }
}
