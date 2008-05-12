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
    
    
    public class BaseParameter : BaseClientDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private int _fk_Method = Helper.INVALIDID;
        
        private string _ParameterName;
        
        private int _fk_Module = Helper.INVALIDID;
        
        private bool _IsList;
        
        private bool _IsReturnParameter;
        
        public BaseParameter()
        {
        }
        
        public override int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.Method Method
        {
            get
            {
                return Context.Find<Kistl.App.Base.Method>(fk_Method);
            }
            set
            {
                fk_Method = value.ID;
            }
        }
        
        public int fk_Method
        {
            get
            {
                return _fk_Method;
            }
            set
            {
                if (fk_Method != value)
                {
                    NotifyPropertyChanging("Method"); 
                    _fk_Method = value;
                    NotifyPropertyChanged("Method");
                }
            }
        }
        
        public string ParameterName
        {
            get
            {
                return _ParameterName;
            }
            set
            {
                NotifyPropertyChanging("ParameterName"); 
                _ParameterName = value; 
                NotifyPropertyChanged("ParameterName");;
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.Module Module
        {
            get
            {
                return Context.Find<Kistl.App.Base.Module>(fk_Module);
            }
            set
            {
                fk_Module = value.ID;
            }
        }
        
        public int fk_Module
        {
            get
            {
                return _fk_Module;
            }
            set
            {
                if (fk_Module != value)
                {
                    NotifyPropertyChanging("Module"); 
                    _fk_Module = value;
                    NotifyPropertyChanged("Module");
                }
            }
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
        
        public bool IsReturnParameter
        {
            get
            {
                return _IsReturnParameter;
            }
            set
            {
                NotifyPropertyChanging("IsReturnParameter"); 
                _IsReturnParameter = value; 
                NotifyPropertyChanged("IsReturnParameter");;
            }
        }
        
        public event ToStringHandler<BaseParameter> OnToString_BaseParameter;
        
        public event ObjectEventHandler<BaseParameter> OnPreSave_BaseParameter;
        
        public event ObjectEventHandler<BaseParameter> OnPostSave_BaseParameter;
        
        public event GetDataType_Handler<BaseParameter> OnGetDataType_BaseParameter;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_BaseParameter != null)
            {
                OnToString_BaseParameter(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_BaseParameter != null) OnPreSave_BaseParameter(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_BaseParameter != null) OnPostSave_BaseParameter(this);
        }
        
        public override object Clone()
        {
            BaseParameter obj = new BaseParameter();
            CopyTo(obj);
            return obj;
        }
        
        public override void CopyTo(Kistl.API.IDataObject obj)
        {
            base.CopyTo(obj);
            ((BaseParameter)obj)._fk_Method = this._fk_Method;
            ((BaseParameter)obj)._ParameterName = this._ParameterName;
            ((BaseParameter)obj)._fk_Module = this._fk_Module;
            ((BaseParameter)obj)._IsList = this._IsList;
            ((BaseParameter)obj)._IsReturnParameter = this._IsReturnParameter;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public virtual string GetDataType()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            if (OnGetDataType_BaseParameter != null)
            {
                OnGetDataType_BaseParameter(this, e);
            };
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_Method, sw);
            BinarySerializer.ToBinary(this._ParameterName, sw);
            BinarySerializer.ToBinary(this.fk_Module, sw);
            BinarySerializer.ToBinary(this._IsList, sw);
            BinarySerializer.ToBinary(this._IsReturnParameter, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._fk_Method, sr);
            BinarySerializer.FromBinary(out this._ParameterName, sr);
            BinarySerializer.FromBinary(out this._fk_Module, sr);
            BinarySerializer.FromBinary(out this._IsList, sr);
            BinarySerializer.FromBinary(out this._IsReturnParameter, sr);
        }
        
        public delegate void GetDataType_Handler<T>(T obj, MethodReturnEventArgs<string> e);
    }
}
