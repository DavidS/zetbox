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
    using Kistl.API.Client;
    
    
    public class TestCustomObject__Implementation__ : BaseClientDataObject, TestCustomObject
    {
        
        private string _PersonName;
        
        private Kistl.App.Test.TestPhoneStruct__Implementation__ _PhoneNumberMobile;
        
        private Kistl.App.Test.TestPhoneStruct__Implementation__ _PhoneNumberOffice;
        
        private System.DateTime? _Birthday;
        
        public TestCustomObject__Implementation__()
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
        
        public Kistl.App.Test.TestPhoneStruct PhoneNumberMobile
        {
            get
            {
                return _PhoneNumberMobile;
            }
            set
            {
                if (PhoneNumberMobile != value)
                {
                    NotifyPropertyChanging("PhoneNumberMobile"); 
                    if (_PhoneNumberMobile != null) _PhoneNumberMobile.DetachFromObject(this, "PhoneNumberMobile");
                    _PhoneNumberMobile = (Kistl.App.Test.TestPhoneStruct__Implementation__)value;
                    if (_PhoneNumberMobile != null) _PhoneNumberMobile.AttachToObject(this, "PhoneNumberMobile");
                    NotifyPropertyChanged("PhoneNumberMobile");
                };
            }
        }
        
        public Kistl.App.Test.TestPhoneStruct PhoneNumberOffice
        {
            get
            {
                return _PhoneNumberOffice;
            }
            set
            {
                if (PhoneNumberOffice != value)
                {
                    NotifyPropertyChanging("PhoneNumberOffice"); 
                    if (_PhoneNumberOffice != null) _PhoneNumberOffice.DetachFromObject(this, "PhoneNumberOffice");
                    _PhoneNumberOffice = (Kistl.App.Test.TestPhoneStruct__Implementation__)value;
                    if (_PhoneNumberOffice != null) _PhoneNumberOffice.AttachToObject(this, "PhoneNumberOffice");
                    NotifyPropertyChanged("PhoneNumberOffice");
                };
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
            ((TestCustomObject__Implementation__)obj).PersonName = this.PersonName;
            ((TestCustomObject__Implementation__)obj).Birthday = this.Birthday;
        }
        
        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        
        protected override string GetPropertyError(string prop)
        {
            switch(prop)
            {
                case "PersonName":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(130).Constraints
                            .Where(c => !c.IsValid(this, this.PersonName))
                            .Select(c => c.GetErrorText(this, this.PersonName))
                            .ToArray());
                case "PhoneNumberMobile":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(131).Constraints
                            .Where(c => !c.IsValid(this, this.PhoneNumberMobile))
                            .Select(c => c.GetErrorText(this, this.PhoneNumberMobile))
                            .ToArray());
                case "PhoneNumberOffice":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(132).Constraints
                            .Where(c => !c.IsValid(this, this.PhoneNumberOffice))
                            .Select(c => c.GetErrorText(this, this.PhoneNumberOffice))
                            .ToArray());
                case "Birthday":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(133).Constraints
                            .Where(c => !c.IsValid(this, this.Birthday))
                            .Select(c => c.GetErrorText(this, this.Birthday))
                            .ToArray());
            }
            return base.GetPropertyError(prop);
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this._PersonName, sw);
            BinarySerializer.ToBinary(this._PhoneNumberMobile, sw);
            BinarySerializer.ToBinary(this._PhoneNumberOffice, sw);
            BinarySerializer.ToBinary(this._Birthday, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._PersonName, sr);
            BinarySerializer.FromBinary(out this._PhoneNumberMobile, sr); if (_PhoneNumberMobile != null) _PhoneNumberMobile.AttachToObject(this, "PhoneNumberMobile");
            BinarySerializer.FromBinary(out this._PhoneNumberOffice, sr); if (_PhoneNumberOffice != null) _PhoneNumberOffice.AttachToObject(this, "PhoneNumberOffice");
            BinarySerializer.FromBinary(out this._Birthday, sr);
        }
    }
}
