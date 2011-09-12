// <autogenerated/>

namespace Kistl.App.Test
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    using Kistl.API;
    using Kistl.DalProvider.Base.RelationWrappers;

    using Kistl.API.Utils;
    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.NHibernate;

    /// <summary>
    /// Testclass for Decimal DataType
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("TestDecimal")]
    public class TestDecimalNHibernateImpl : Kistl.DalProvider.NHibernate.DataObjectNHibernateImpl, TestDecimal
    {
        public TestDecimalNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public TestDecimalNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new TestDecimalProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public TestDecimalNHibernateImpl(Func<IFrozenContext> lazyCtx, TestDecimalProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly TestDecimalProxy Proxy;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public decimal? Large
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Large;
                if (OnLarge_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<decimal?>(__result);
                    OnLarge_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Large != value)
                {
                    var __oldValue = Proxy.Large;
                    var __newValue = value;
                    if (OnLarge_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<decimal?>(__oldValue, __newValue);
                        OnLarge_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Large", __oldValue, __newValue);
                    Proxy.Large = __newValue;
                    NotifyPropertyChanged("Large", __oldValue, __newValue);
                    if (OnLarge_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<decimal?>(__oldValue, __newValue);
                        OnLarge_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Test.TestDecimal, decimal?> OnLarge_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestDecimal, decimal?> OnLarge_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestDecimal, decimal?> OnLarge_PostSetter;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public decimal? NoScale
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.NoScale;
                if (OnNoScale_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<decimal?>(__result);
                    OnNoScale_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.NoScale != value)
                {
                    var __oldValue = Proxy.NoScale;
                    var __newValue = value;
                    if (OnNoScale_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<decimal?>(__oldValue, __newValue);
                        OnNoScale_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("NoScale", __oldValue, __newValue);
                    Proxy.NoScale = __newValue;
                    NotifyPropertyChanged("NoScale", __oldValue, __newValue);
                    if (OnNoScale_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<decimal?>(__oldValue, __newValue);
                        OnNoScale_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Test.TestDecimal, decimal?> OnNoScale_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestDecimal, decimal?> OnNoScale_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestDecimal, decimal?> OnNoScale_PostSetter;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public decimal? SmallDecimal
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.SmallDecimal;
                if (OnSmallDecimal_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<decimal?>(__result);
                    OnSmallDecimal_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.SmallDecimal != value)
                {
                    var __oldValue = Proxy.SmallDecimal;
                    var __newValue = value;
                    if (OnSmallDecimal_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<decimal?>(__oldValue, __newValue);
                        OnSmallDecimal_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("SmallDecimal", __oldValue, __newValue);
                    Proxy.SmallDecimal = __newValue;
                    NotifyPropertyChanged("SmallDecimal", __oldValue, __newValue);
                    if (OnSmallDecimal_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<decimal?>(__oldValue, __newValue);
                        OnSmallDecimal_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Test.TestDecimal, decimal?> OnSmallDecimal_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestDecimal, decimal?> OnSmallDecimal_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestDecimal, decimal?> OnSmallDecimal_PostSetter;

        public override Type GetImplementedInterface()
        {
            return typeof(TestDecimal);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (TestDecimal)obj;
            var otherImpl = (TestDecimalNHibernateImpl)obj;
            var me = (TestDecimal)this;

            me.Large = other.Large;
            me.NoScale = other.NoScale;
            me.SmallDecimal = other.SmallDecimal;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
        }


        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references
        }
        #region Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        private static readonly object _propertiesLock = new object();
        private static System.ComponentModel.PropertyDescriptor[] _properties;

        private void _InitializePropertyDescriptors(Func<IFrozenContext> lazyCtx)
        {
            if (_properties != null) return;
            lock (_propertiesLock)
            {
                // recheck for a lost race after aquiring the lock
                if (_properties != null) return;

                _properties = new System.ComponentModel.PropertyDescriptor[] {
                    // else
                    new PropertyDescriptorNHibernateImpl<TestDecimalNHibernateImpl, decimal?>(
                        lazyCtx,
                        new Guid("14a1eeb9-26b1-4913-bae1-228edfd1c9de"),
                        "Large",
                        null,
                        obj => obj.Large,
                        (obj, val) => obj.Large = val),
                    // else
                    new PropertyDescriptorNHibernateImpl<TestDecimalNHibernateImpl, decimal?>(
                        lazyCtx,
                        new Guid("dbad0130-bfb8-4475-afb8-e26f1124395b"),
                        "NoScale",
                        null,
                        obj => obj.NoScale,
                        (obj, val) => obj.NoScale = val),
                    // else
                    new PropertyDescriptorNHibernateImpl<TestDecimalNHibernateImpl, decimal?>(
                        lazyCtx,
                        new Guid("734795e4-4e0f-4175-b153-e465acafd609"),
                        "SmallDecimal",
                        null,
                        obj => obj.SmallDecimal,
                        (obj, val) => obj.SmallDecimal = val),
                    // position columns
                };
            }
        }

        protected override void CollectProperties(Func<IFrozenContext> lazyCtx, List<System.ComponentModel.PropertyDescriptor> props)
        {
            base.CollectProperties(lazyCtx, props);
            _InitializePropertyDescriptors(lazyCtx);
            props.AddRange(_properties);
        }
        #endregion // Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_TestDecimal")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_TestDecimal != null)
            {
                OnToString_TestDecimal(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<TestDecimal> OnToString_TestDecimal;

        [EventBasedMethod("OnPreSave_TestDecimal")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_TestDecimal != null) OnPreSave_TestDecimal(this);
        }
        public static event ObjectEventHandler<TestDecimal> OnPreSave_TestDecimal;

        [EventBasedMethod("OnPostSave_TestDecimal")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_TestDecimal != null) OnPostSave_TestDecimal(this);
        }
        public static event ObjectEventHandler<TestDecimal> OnPostSave_TestDecimal;

        [EventBasedMethod("OnCreated_TestDecimal")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_TestDecimal != null) OnCreated_TestDecimal(this);
        }
        public static event ObjectEventHandler<TestDecimal> OnCreated_TestDecimal;

        [EventBasedMethod("OnDeleting_TestDecimal")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_TestDecimal != null) OnDeleting_TestDecimal(this);
        }
        public static event ObjectEventHandler<TestDecimal> OnDeleting_TestDecimal;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods
        public override List<NHibernatePersistenceObject> GetParentsToDelete()
        {
            var result = base.GetParentsToDelete();

            return result;
        }

        public override List<NHibernatePersistenceObject> GetChildrenToDelete()
        {
            var result = base.GetChildrenToDelete();

            return result;
        }


        public class TestDecimalProxy
            : IProxyObject, ISortKey<int>
        {
            public TestDecimalProxy()
            {
            }

            public virtual int ID { get; set; }

            public virtual Type ZBoxWrapper { get { return typeof(TestDecimalNHibernateImpl); } }
            public virtual Type ZBoxProxy { get { return typeof(TestDecimalProxy); } }

            public virtual decimal? Large { get; set; }

            public virtual decimal? NoScale { get; set; }

            public virtual decimal? SmallDecimal { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this.Proxy.Large, binStream);
            BinarySerializer.ToStream(this.Proxy.NoScale, binStream);
            BinarySerializer.ToStream(this.Proxy.SmallDecimal, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            {
                decimal? tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.Large = tmp;
            }
            {
                decimal? tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.NoScale = tmp;
            }
            {
                decimal? tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.SmallDecimal = tmp;
            }
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            XmlStreamer.ToStream(this.Proxy.Large, xml, "Large", "Kistl.App.Test");
            XmlStreamer.ToStream(this.Proxy.NoScale, xml, "NoScale", "Kistl.App.Test");
            XmlStreamer.ToStream(this.Proxy.SmallDecimal, xml, "SmallDecimal", "Kistl.App.Test");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            {
                // yuck
                decimal? tmp = this.Proxy.Large;
                XmlStreamer.FromStream(ref tmp, xml, "Large", "Kistl.App.Test");
                this.Proxy.Large = tmp;
            }
            {
                // yuck
                decimal? tmp = this.Proxy.NoScale;
                XmlStreamer.FromStream(ref tmp, xml, "NoScale", "Kistl.App.Test");
                this.Proxy.NoScale = tmp;
            }
            {
                // yuck
                decimal? tmp = this.Proxy.SmallDecimal;
                XmlStreamer.FromStream(ref tmp, xml, "SmallDecimal", "Kistl.App.Test");
                this.Proxy.SmallDecimal = tmp;
            }
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        #endregion

    }
}