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
    
    
    public class BaseProperty : BaseClientDataObject, ICloneable
    {
        
        private int _ID = Helper.INVALIDID;
        
        private int _fk_ObjectClass = Helper.INVALIDID;
        
        private string _PropertyName;
        
        private string _AltText;
        
        private int _fk_Module = Helper.INVALIDID;
        
        public BaseProperty()
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
        public Kistl.App.Base.DataType ObjectClass
        {
            get
            {
                return Context.GetQuery<Kistl.App.Base.DataType>().Single(o => o.ID == fk_ObjectClass);
            }
            set
            {
                NotifyPropertyChanging("ObjectClass"); 
                _fk_ObjectClass = value.ID;
                NotifyPropertyChanged("ObjectClass"); ;
            }
        }
        
        public int fk_ObjectClass
        {
            get
            {
                return _fk_ObjectClass;
            }
            set
            {
                NotifyPropertyChanging("ObjectClass"); 
                _fk_ObjectClass = value;
                NotifyPropertyChanged("ObjectClass"); ;
            }
        }
        
        public string PropertyName
        {
            get
            {
                return _PropertyName;
            }
            set
            {
                NotifyPropertyChanging("PropertyName"); 
                _PropertyName = value; 
                NotifyPropertyChanged("PropertyName");;
            }
        }
        
        public string AltText
        {
            get
            {
                return _AltText;
            }
            set
            {
                NotifyPropertyChanging("AltText"); 
                _AltText = value; 
                NotifyPropertyChanged("AltText");;
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Base.Module Module
        {
            get
            {
                return Context.GetQuery<Kistl.App.Base.Module>().Single(o => o.ID == fk_Module);
            }
            set
            {
                NotifyPropertyChanging("Module"); 
                _fk_Module = value.ID;
                NotifyPropertyChanged("Module"); ;
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
                NotifyPropertyChanging("Module"); 
                _fk_Module = value;
                NotifyPropertyChanged("Module"); ;
            }
        }
        
        public event ToStringHandler<BaseProperty> OnToString_BaseProperty;
        
        public event ObjectEventHandler<BaseProperty> OnPreSave_BaseProperty;
        
        public event ObjectEventHandler<BaseProperty> OnPostSave_BaseProperty;
        
        public event GetDataType_Handler<BaseProperty> OnGetDataType_BaseProperty;
        
        public event GetGUIRepresentation_Handler<BaseProperty> OnGetGUIRepresentation_BaseProperty;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_BaseProperty != null)
            {
                OnToString_BaseProperty(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_BaseProperty != null) OnPreSave_BaseProperty(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_BaseProperty != null) OnPostSave_BaseProperty(this);
        }
        
        public override object Clone()
        {
            BaseProperty obj = new BaseProperty();
            CopyTo(obj);
            return obj;
        }
        
        public override void CopyTo(Kistl.API.IDataObject obj)
        {
            base.CopyTo(obj);
            ((BaseProperty)obj)._fk_ObjectClass = this._fk_ObjectClass;
            ((BaseProperty)obj)._PropertyName = this._PropertyName;
            ((BaseProperty)obj)._AltText = this._AltText;
            ((BaseProperty)obj)._fk_Module = this._fk_Module;
        }
        
        public override void AttachToContext(KistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public virtual string GetDataType()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            if (OnGetDataType_BaseProperty != null)
            {
                OnGetDataType_BaseProperty(this, e);
            };
            return e.Result;
        }
        
        public virtual string GetGUIRepresentation()
        {
            MethodReturnEventArgs<System.String> e = new MethodReturnEventArgs<System.String>();
            if (OnGetGUIRepresentation_BaseProperty != null)
            {
                OnGetGUIRepresentation_BaseProperty(this, e);
            };
            return e.Result;
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.fk_ObjectClass, sw);
            BinarySerializer.ToBinary(this._PropertyName, sw);
            BinarySerializer.ToBinary(this._AltText, sw);
            BinarySerializer.ToBinary(this.fk_Module, sw);
        }
        
        public override void FromStream(Kistl.API.IKistlContext ctx, System.IO.BinaryReader sr)
        {
            base.FromStream(ctx, sr);
            BinarySerializer.FromBinary(out this._fk_ObjectClass, sr);
            BinarySerializer.FromBinary(out this._PropertyName, sr);
            BinarySerializer.FromBinary(out this._AltText, sr);
            BinarySerializer.FromBinary(out this._fk_Module, sr);
        }
        
        public delegate void GetDataType_Handler<T>(T obj, MethodReturnEventArgs<string> e);
        
        public delegate void GetGUIRepresentation_Handler<T>(T obj, MethodReturnEventArgs<string> e);
    }
}
