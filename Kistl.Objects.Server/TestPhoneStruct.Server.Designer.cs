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
    using Kistl.DALProvider.EF;
    using Kistl.API.Server;
    
    
    [System.Data.Objects.DataClasses.EdmComplexTypeAttribute(NamespaceName="Model", Name="TestPhoneStruct")]
    public class TestPhoneStruct__Implementation__ : BaseServerStructObject_EntityFramework, TestPhoneStruct
    {
        
        private string _Number;
        
        private string _AreaCode;
        
        [EdmScalarPropertyAttribute()]
        public string Number
        {
            get
            {
                return _Number;
            }
            set
            {
                if (Number != value)
                {
                    NotifyPropertyChanging("Number"); 
                    _Number = value;
                    NotifyPropertyChanged("Number");;
                }
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public string AreaCode
        {
            get
            {
                return _AreaCode;
            }
            set
            {
                if (AreaCode != value)
                {
                    NotifyPropertyChanging("AreaCode"); 
                    _AreaCode = value;
                    NotifyPropertyChanged("AreaCode");;
                }
            }
        }
        
        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this._Number, sw);
            BinarySerializer.ToBinary(this._AreaCode, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._Number, sr);
            BinarySerializer.FromBinary(out this._AreaCode, sr);
        }
    }
    
    public class TestPhoneStruct__Implementation____NULL : TestPhoneStruct__Implementation__
    {
    }
}
