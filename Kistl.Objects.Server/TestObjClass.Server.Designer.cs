//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Objects.DataClasses.EdmRelationshipAttribute("Model", "FK_TestObjClass_Kunde_ObjectProp", "A_Kunde", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(Kistl.App.Projekte.Kunde__Implementation__), "B_TestObjClass", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Kistl.App.Test.TestObjClass__Implementation__))]

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
    
    
    [EdmEntityTypeAttribute(NamespaceName="Model", Name="TestObjClass")]
    public class TestObjClass__Implementation__ : BaseServerDataObject_EntityFramework, TestObjClass, Kistl.App.Test.ITestInterface
    {
        
        private int _ID;
        
        private string _StringProp;
        
        private Kistl.App.Test.TestEnum _TestEnumProp;
        
        private System.Nullable<int> _fk_ObjectProp = null;
        
        private System.Int32? _MyIntProperty;
        
        public TestObjClass__Implementation__()
        {
        }
        
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
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
        
        [EdmScalarPropertyAttribute()]
        public string StringProp
        {
            get
            {
                return _StringProp;
            }
            set
            {
                if (StringProp != value)
                {
                    NotifyPropertyChanging("StringProp"); 
                    _StringProp = value;
                    NotifyPropertyChanged("StringProp");;
                }
            }
        }
        
        public Kistl.App.Test.TestEnum TestEnumProp
        {
            get
            {
                return _TestEnumProp;
            }
            set
            {
                if (TestEnumProp != value)
                {
                    NotifyPropertyChanging("TestEnumProp"); 
                    _TestEnumProp = value;
                    NotifyPropertyChanged("TestEnumProp");;
                }
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public int TestEnumProp__Implementation__
        {
            get
            {
                return (int)TestEnumProp;
            }
            set
            {
                TestEnumProp = (Kistl.App.Test.TestEnum)value;
            }
        }
        
        [XmlIgnore()]
        public Kistl.App.Projekte.Kunde ObjectProp
        {
            get
            {
                return ObjectProp__Implementation__;
            }
            set
            {
                ObjectProp__Implementation__ = (Kistl.App.Projekte.Kunde__Implementation__)value;
            }
        }
        
        public System.Nullable<int> fk_ObjectProp
        {
            get
            {
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && ObjectProp != null)
                {
                    _fk_ObjectProp = ObjectProp.ID;
                }
                return _fk_ObjectProp;
            }
            set
            {
                _fk_ObjectProp = value;
            }
        }
        
        [EdmRelationshipNavigationPropertyAttribute("Model", "FK_TestObjClass_Kunde_ObjectProp", "A_Kunde")]
        public Kistl.App.Projekte.Kunde__Implementation__ ObjectProp__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Projekte.Kunde__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Kunde__Implementation__>("Model.FK_TestObjClass_Kunde_ObjectProp", "A_Kunde");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Projekte.Kunde__Implementation__> r = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Projekte.Kunde__Implementation__>("Model.FK_TestObjClass_Kunde_ObjectProp", "A_Kunde");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged) && !r.IsLoaded) r.Load(); 
                r.Value = (Kistl.App.Projekte.Kunde__Implementation__)value;
            }
        }
        
        [EdmScalarPropertyAttribute()]
        public System.Int32? MyIntProperty
        {
            get
            {
                return _MyIntProperty;
            }
            set
            {
                if (MyIntProperty != value)
                {
                    NotifyPropertyChanging("MyIntProperty"); 
                    _MyIntProperty = value;
                    NotifyPropertyChanged("MyIntProperty");;
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
        }
        
        protected override string GetPropertyError(string prop)
        {
            switch(prop)
            {
                case "StringProp":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(109).Constraints
                            .Where(c => !c.IsValid(this, this.StringProp))
                            .Select(c => c.GetErrorText(this, this.StringProp))
                            .ToArray());
                case "TestEnumProp":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(110).Constraints
                            .Where(c => !c.IsValid(this, this.TestEnumProp))
                            .Select(c => c.GetErrorText(this, this.TestEnumProp))
                            .ToArray());
                case "ObjectProp":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(112).Constraints
                            .Where(c => !c.IsValid(this, this.ObjectProp))
                            .Select(c => c.GetErrorText(this, this.ObjectProp))
                            .ToArray());
                case "MyIntProperty":
                    return string.Join("\n", 
                        Context.GetReadonlyContext().Find<Kistl.App.Base.BaseProperty>(126).Constraints
                            .Where(c => !c.IsValid(this, this.MyIntProperty))
                            .Select(c => c.GetErrorText(this, this.MyIntProperty))
                            .ToArray());
            }
            return base.GetPropertyError(prop);
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
            BinarySerializer.ToBinary((int)this._TestEnumProp, sw);
            BinarySerializer.ToBinary(this.fk_ObjectProp, sw);
            BinarySerializer.ToBinary(this._MyIntProperty, sw);
        }
        
        public override void FromStream(System.IO.BinaryReader sr)
        {
            base.FromStream(sr);
            BinarySerializer.FromBinary(out this._StringProp, sr);
            int tmpTestEnumProp; BinarySerializer.FromBinary(out tmpTestEnumProp, sr); _TestEnumProp = (Kistl.App.Test.TestEnum)tmpTestEnumProp;
            BinarySerializer.FromBinary(out this._fk_ObjectProp, sr);
            BinarySerializer.FromBinary(out this._MyIntProperty, sr);
        }
        
        public delegate void TestMethod_Handler<T>(T obj, System.DateTime DateTimeParamForTestMethod);
    }
}
