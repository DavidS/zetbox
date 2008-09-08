//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
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
    
    
    public class TestCustomObjectImpl : BaseClientDataObject, TestCustomObject
    {
        
        private string _PersonName;
        
        private Kistl.App.Test.TestPhoneStructImpl _PhoneNumberMobileImpl;
        
        private Kistl.App.Test.TestPhoneStructImpl _PhoneNumberOfficeImpl;
        
        private System.DateTime? _Birthday;
        
        public TestCustomObjectImpl()
        {
        }
        
        public string PersonName
        {
            get
            {
                return _PersonName;
            }
            set
            {
                if (PersonName != value)
                {
                    NotifyPropertyChanging("PersonName"); 
                    _PersonName = value;
                    NotifyPropertyChanged("PersonName");;
                }
            }
        }
        
        public Kistl.App.Test.TestPhoneStructImpl PhoneNumberMobileImpl
        {
            get
            {
                return _PhoneNumberMobileImpl;
            }
            set
            {
                if (PhoneNumberMobileImpl != value)
                {
                    NotifyPropertyChanging("PhoneNumberMobileImpl"); 
                    _PhoneNumberMobileImpl = value;
                    NotifyPropertyChanged("PhoneNumberMobileImpl");;
                }
            }
        }
        
        public Kistl.App.Test.TestPhoneStruct PhoneNumberMobile
        {
            get
            {
                return PhoneNumberMobileImpl;
            }
            set
            {
                PhoneNumberMobileImpl = (Kistl.App.Test.TestPhoneStructImpl)value;
            }
        }
        
        public Kistl.App.Test.TestPhoneStructImpl PhoneNumberOfficeImpl
        {
            get
            {
                return _PhoneNumberOfficeImpl;
            }
            set
            {
                if (PhoneNumberOfficeImpl != value)
                {
                    NotifyPropertyChanging("PhoneNumberOfficeImpl"); 
                    _PhoneNumberOfficeImpl = value;
                    NotifyPropertyChanged("PhoneNumberOfficeImpl");;
                }
            }
        }
        
        public Kistl.App.Test.TestPhoneStruct PhoneNumberOffice
        {
            get
            {
                return PhoneNumberOfficeImpl;
            }
            set
            {
                PhoneNumberOfficeImpl = (Kistl.App.Test.TestPhoneStructImpl)value;
            }
        }
        
        public System.DateTime? Birthday
        {
            get
            {
                return _Birthday;
            }
            set
            {
                if (Birthday != value)
                {
                    NotifyPropertyChanging("Birthday"); 
                    _Birthday = value;
                    NotifyPropertyChanged("Birthday");;
                }
            }
        }
        
        public event ToStringHandler<TestCustomObject> OnToString_TestCustomObject;
        
        public event ObjectEventHandler<TestCustomObject> OnPreSave_TestCustomObject;
        
        public event ObjectEventHandler<TestCustomObject> OnPostSave_TestCustomObject;
        
        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_TestCustomObject != null)
            {
                OnToString_TestCustomObject(this, e);
            }
            return e.Result;
        }
        
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_TestCustomObject != null) OnPreSave_TestCustomObject(this);
        }
        
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_TestCustomObject != null) OnPostSave_TestCustomObject(this);
        }
        
        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((TestCustomObjectImpl)obj).PersonName = this.PersonName;
            ((TestCustomObjectImpl)obj).Birthday = this.Birthday;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this._PersonName, sw);
            BinarySerializer.ToBinary(this._PhoneNumberMobileImpl, sw);
            BinarySerializer.ToBinary(this._PhoneNumberOfficeImpl, sw);
            BinarySerializer.ToBinary(this._Birthday, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._PersonName, sr);
            BinarySerializer.FromBinary(out this._PhoneNumberMobileImpl, sr);
            BinarySerializer.FromBinary(out this._PhoneNumberOfficeImpl, sr);
            BinarySerializer.FromBinary(out this._Birthday, sr);
        }
    }
}
