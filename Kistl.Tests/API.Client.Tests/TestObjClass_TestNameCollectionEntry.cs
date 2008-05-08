using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.API;
using Kistl.API.Client;
using System.Xml.Serialization;

namespace API.Client.Tests
{
    public class TestObjClass_TestNameCollectionEntry : BaseClientCollectionEntry
    {

        private int _ID = Helper.INVALIDID;

        private string _Value;

        private int _fk_Parent = Helper.INVALIDID;

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

        public string Value
        {
            get
            {
                return _Value;
            }
            set
            {
                base.NotifyPropertyChanging("Value");
                _Value = value;
                base.NotifyPropertyChanged("Value"); ;
            }
        }

        [XmlIgnore()]
        public TestObjClass Parent
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public int fk_Parent
        {
            get
            {
                return _fk_Parent;
            }
            set
            {
                _fk_Parent = value;
            }
        }

        public override void ToStream(System.IO.BinaryWriter sw)
        {
            base.ToStream(sw);
            BinarySerializer.ToBinary(this.Value, sw);
            BinarySerializer.ToBinary(this.fk_Parent, sw);
        }

        public override void FromStream(Kistl.API.IKistlContext ctx, System.IO.BinaryReader sr)
        {
            base.FromStream(ctx, sr);
            BinarySerializer.FromBinary(out this._Value, sr);
            BinarySerializer.FromBinary(out this._fk_Parent, sr);
        }

        public override void CopyTo(Kistl.API.ICollectionEntry obj)
        {
            base.CopyTo(obj);
            ((TestObjClass_TestNameCollectionEntry)obj)._Value = this._Value;
            ((TestObjClass_TestNameCollectionEntry)obj)._fk_Parent = this._fk_Parent;
        }
    }
}
