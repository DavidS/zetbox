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
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("ANewObjectClass")]
    public class ANewObjectClassNHibernateImpl : Kistl.DalProvider.NHibernate.DataObjectNHibernateImpl, ANewObjectClass
    {
        private static readonly Guid _objectClassID = new Guid("798887f9-2d21-4d02-a143-bf1cbe07469b");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public ANewObjectClassNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public ANewObjectClassNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new ANewObjectClassProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public ANewObjectClassNHibernateImpl(Func<IFrozenContext> lazyCtx, ANewObjectClassProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly ANewObjectClassProxy Proxy;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string TestString
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.TestString;
                if (OnTestString_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnTestString_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.TestString != value)
                {
                    var __oldValue = Proxy.TestString;
                    var __newValue = value;
                    if (OnTestString_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnTestString_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("TestString", __oldValue, __newValue);
                    Proxy.TestString = __newValue;
                    NotifyPropertyChanged("TestString", __oldValue, __newValue);

                    if (OnTestString_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnTestString_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("TestString");
				}
            }
        }

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Test.ANewObjectClass, string> OnTestString_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.ANewObjectClass, string> OnTestString_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.ANewObjectClass, string> OnTestString_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Test.ANewObjectClass> OnTestString_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(ANewObjectClass);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (ANewObjectClass)obj;
            var otherImpl = (ANewObjectClassNHibernateImpl)obj;
            var me = (ANewObjectClass)this;

            me.TestString = other.TestString;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
        }

        #region Kistl.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "TestString":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }

        #endregion // Kistl.Generator.Templates.ObjectClasses.OnPropertyChange

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
                    new PropertyDescriptorNHibernateImpl<ANewObjectClass, string>(
                        lazyCtx,
                        new Guid("e7371fa9-cd18-4cdc-91c3-a73c0984a019"),
                        "TestString",
                        null,
                        obj => obj.TestString,
                        (obj, val) => obj.TestString = val,
						obj => OnTestString_IsValid), 
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
        [EventBasedMethod("OnToString_ANewObjectClass")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ANewObjectClass != null)
            {
                OnToString_ANewObjectClass(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<ANewObjectClass> OnToString_ANewObjectClass;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_ANewObjectClass")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_ANewObjectClass != null)
            {
                OnObjectIsValid_ANewObjectClass(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<ANewObjectClass> OnObjectIsValid_ANewObjectClass;

        [EventBasedMethod("OnNotifyPreSave_ANewObjectClass")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_ANewObjectClass != null) OnNotifyPreSave_ANewObjectClass(this);
        }
        public static event ObjectEventHandler<ANewObjectClass> OnNotifyPreSave_ANewObjectClass;

        [EventBasedMethod("OnNotifyPostSave_ANewObjectClass")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_ANewObjectClass != null) OnNotifyPostSave_ANewObjectClass(this);
        }
        public static event ObjectEventHandler<ANewObjectClass> OnNotifyPostSave_ANewObjectClass;

        [EventBasedMethod("OnNotifyCreated_ANewObjectClass")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("TestString");
            base.NotifyCreated();
            if (OnNotifyCreated_ANewObjectClass != null) OnNotifyCreated_ANewObjectClass(this);
        }
        public static event ObjectEventHandler<ANewObjectClass> OnNotifyCreated_ANewObjectClass;

        [EventBasedMethod("OnNotifyDeleting_ANewObjectClass")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_ANewObjectClass != null) OnNotifyDeleting_ANewObjectClass(this);


        }
        public static event ObjectEventHandler<ANewObjectClass> OnNotifyDeleting_ANewObjectClass;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class ANewObjectClassProxy
            : IProxyObject, ISortKey<int>
        {
            public ANewObjectClassProxy()
            {
            }

            public virtual int ID { get; set; }

            public virtual Type ZBoxWrapper { get { return typeof(ANewObjectClassNHibernateImpl); } }
            public virtual Type ZBoxProxy { get { return typeof(ANewObjectClassProxy); } }

            public virtual string TestString { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this.Proxy.TestString, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            {
                string tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.TestString = tmp;
            }
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.ToStream(this.Proxy.TestString, xml, "TestString", "Kistl.App.Test");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            {
                // yuck
                string tmp = this.Proxy.TestString;
                XmlStreamer.FromStream(ref tmp, xml, "TestString", "Kistl.App.Test");
                this.Proxy.TestString = tmp;
            }
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        #endregion

    }
}