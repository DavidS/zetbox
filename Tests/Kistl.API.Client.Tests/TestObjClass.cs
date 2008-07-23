using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Kistl.API;
using Kistl.API.Client;
using System.Xml.Serialization;

namespace Kistl.API.Client.Tests
{
    public class TestObjClass : BaseClientDataObject
    {

        private int _ID;

        private string _StringProp;

        private int _TestEnumProp;

        private BackReferenceCollection<TestObjClass> _Children;

        private int? _fk_Parent;

        private ListPropertyCollection<string, TestObjClass, TestObjClass_TestNameCollectionEntry> _TestNames;

        public TestObjClass()
        {
            _TestNames = new ListPropertyCollection<string, TestObjClass, TestObjClass_TestNameCollectionEntry>(this, "TestNames");
        }

      

        public string StringProp
        {
            get
            {
                return _StringProp;
            }
            set
            {
                NotifyPropertyChanging("StringProp");
                _StringProp = value;
                NotifyPropertyChanged("StringProp"); ;
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
                NotifyPropertyChanging("TestEnumProp");
                _TestEnumProp = value;
                NotifyPropertyChanged("TestEnumProp"); ;
            }
        }

        public IList<string> TestNames
        {
            get
            {
                return _TestNames;
            }
        }

        public ListPropertyCollection<string, TestObjClass, TestObjClass_TestNameCollectionEntry> UnitTest_TestNames
        {
            get
            {
                return _TestNames;
            }
        }

        public IList<TestObjClass> Children
        {
            get
            {
                if (_Children == null) _Children = new BackReferenceCollection<TestObjClass>("Parent", this, Context.GetListOf<TestObjClass>(this, "Children"));
                return _Children;
            }
        }

        [XmlIgnore()]
        public TestObjClass Parent
        {
            get
            {
                if (fk_Parent == null) return null;
                return Context.Find<TestObjClass>(fk_Parent.Value);
            }
            set
            {
                fk_Parent = value.ID;
            }
        }

        public int? fk_Parent
        {
            get
            {
                return _fk_Parent;
            }
            set
            {
                if (fk_Parent != value)
                {
                    NotifyPropertyChanging("Parent");
                    _fk_Parent = value;
                    NotifyPropertyChanged("Parent");
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

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            _TestNames.UnderlyingCollection.ForEach(i => ctx.Attach(i));
            if (_Children != null) _Children = new BackReferenceCollection<TestObjClass>("Parent", this, _Children.Select(i => ctx.Attach(i)).OfType<TestObjClass>());
        }

        public override void ApplyChanges(Kistl.API.IDataObject obj)
        {
            base.ApplyChanges(obj);
            ((TestObjClass)obj)._StringProp = this._StringProp;
            ((TestObjClass)obj)._TestEnumProp = this._TestEnumProp;
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
        }

        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._StringProp, sr);
            BinarySerializer.FromBinary(out this._TestEnumProp, sr);
        }

        public delegate void TestMethod_Handler<T>(T obj, System.DateTime DateTimeParamForTestMethod);
    }

}
