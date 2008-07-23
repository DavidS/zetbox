//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kistl.App.Test
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
    
    
    public class TestObjClass : BaseClientDataObject, Kistl.App.Test.ITestInterface
    {
        
        private string _StringProp;
        
        private int _TestEnumProp;
        
        private System.Nullable<int> _fk_ObjectProp = null;
        
        public TestObjClass()
        {
        }
        
        public string StringProp
        {
            get
            {
                return _StringProp;
            }
            set
            {
                if(_StringProp != value)
                {
                    NotifyPropertyChanging("StringProp"); 
                    _StringProp = value; 
                    NotifyPropertyChanged("StringProp");
                };
            }
        }
        
        public int TestEnumProp
        {
            get
            {
                return _TestEnumProp;
            }
            set
            {
                if(_TestEnumProp != value)
                {
                    NotifyPropertyChanging("TestEnumProp"); 
                    _TestEnumProp = value; 
                    NotifyPropertyChanged("TestEnumProp");
                };
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Projekte.Kunde ObjectProp
        {
            get
            {
                if (fk_ObjectProp == null) return null;
                return Context.Find<Kistl.App.Projekte.Kunde>(fk_ObjectProp.Value);
            }
            set
            {
                fk_ObjectProp = value != null ? (int?)value.ID : null;
            }
        }
        
        public System.Nullable<int> fk_ObjectProp
        {
            get
            {
                return _fk_ObjectProp;
            }
            set
            {
                if (fk_ObjectProp != value)
                {
                    NotifyPropertyChanging("ObjectProp"); 
                    _fk_ObjectProp = value;
                    NotifyPropertyChanged("ObjectProp");;
                }
            }
        }
        
        public event ToStringHandler<TestObjClass> OnToString_TestObjClass;
        
        public event ObjectEventHandler<TestObjClass> OnPreSave_TestObjClass;
        
        public event ObjectEventHandler<TestObjClass> OnPostSave_TestObjClass;
        
        public event TestMethod_Handler<TestObjClass> OnTestMethod_TestObjClass;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_TestObjClass != null)
            {
                OnToString_TestObjClass(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_TestObjClass != null) OnPreSave_TestObjClass(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_TestObjClass != null) OnPostSave_TestObjClass(this);
        }
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((TestObjClass)obj).StringProp = this.StringProp;
            ((TestObjClass)obj).TestEnumProp = this.TestEnumProp;
            ((TestObjClass)obj).fk_ObjectProp = this.fk_ObjectProp;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public virtual void TestMethod(System.DateTime DateTimeParamForTestMethod)
        {
            if (OnTestMethod_TestObjClass != null)
            {
                OnTestMethod_TestObjClass(this, DateTimeParamForTestMethod);
            };
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this._StringProp, sw);
            BinarySerializer.ToBinary(this._TestEnumProp, sw);
            BinarySerializer.ToBinary(this.fk_ObjectProp, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._StringProp, sr);
            BinarySerializer.FromBinary(out this._TestEnumProp, sr);
            BinarySerializer.FromBinary(out this._fk_ObjectProp, sr);
        }
        
        public delegate void TestMethod_Handler<T>(T obj, System.DateTime DateTimeParamForTestMethod);
    }
}
