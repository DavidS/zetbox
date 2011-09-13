// <autogenerated/>

namespace Kistl.App.Base
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
    /// Sets an string property with the configured default value
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("StringDefaultValue")]
    public class StringDefaultValueNHibernateImpl : Kistl.App.Base.DefaultPropertyValueNHibernateImpl, StringDefaultValue
    {
        public StringDefaultValueNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public StringDefaultValueNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new StringDefaultValueProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public StringDefaultValueNHibernateImpl(Func<IFrozenContext> lazyCtx, StringDefaultValueProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly StringDefaultValueProxy Proxy;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string DefaultValue
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.DefaultValue;
                if (OnDefaultValue_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnDefaultValue_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.DefaultValue != value)
                {
                    var __oldValue = Proxy.DefaultValue;
                    var __newValue = value;
                    if (OnDefaultValue_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnDefaultValue_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("DefaultValue", __oldValue, __newValue);
                    Proxy.DefaultValue = __newValue;
                    NotifyPropertyChanged("DefaultValue", __oldValue, __newValue);
                    if (OnDefaultValue_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnDefaultValue_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.StringDefaultValue, string> OnDefaultValue_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.StringDefaultValue, string> OnDefaultValue_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.StringDefaultValue, string> OnDefaultValue_PostSetter;

        /// <summary>
        /// GetDefaultValue
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDefaultValue_StringDefaultValue")]
        public override System.Object GetDefaultValue()
        {
            var e = new MethodReturnEventArgs<System.Object>();
            if (OnGetDefaultValue_StringDefaultValue != null)
            {
                OnGetDefaultValue_StringDefaultValue(this, e);
            }
            else
            {
                e.Result = base.GetDefaultValue();
            }
            return e.Result;
        }
        public static event GetDefaultValue_Handler<StringDefaultValue> OnGetDefaultValue_StringDefaultValue;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(StringDefaultValue);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (StringDefaultValue)obj;
            var otherImpl = (StringDefaultValueNHibernateImpl)obj;
            var me = (StringDefaultValue)this;

            me.DefaultValue = other.DefaultValue;
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
                    new PropertyDescriptorNHibernateImpl<StringDefaultValueNHibernateImpl, string>(
                        lazyCtx,
                        new Guid("88d7ba7d-6a5e-48b9-8464-c0308f6dabb6"),
                        "DefaultValue",
                        null,
                        obj => obj.DefaultValue,
                        (obj, val) => obj.DefaultValue = val),
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
        [EventBasedMethod("OnToString_StringDefaultValue")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_StringDefaultValue != null)
            {
                OnToString_StringDefaultValue(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<StringDefaultValue> OnToString_StringDefaultValue;

        [EventBasedMethod("OnPreSave_StringDefaultValue")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_StringDefaultValue != null) OnPreSave_StringDefaultValue(this);
        }
        public static event ObjectEventHandler<StringDefaultValue> OnPreSave_StringDefaultValue;

        [EventBasedMethod("OnPostSave_StringDefaultValue")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_StringDefaultValue != null) OnPostSave_StringDefaultValue(this);
        }
        public static event ObjectEventHandler<StringDefaultValue> OnPostSave_StringDefaultValue;

        [EventBasedMethod("OnCreated_StringDefaultValue")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_StringDefaultValue != null) OnCreated_StringDefaultValue(this);
        }
        public static event ObjectEventHandler<StringDefaultValue> OnCreated_StringDefaultValue;

        [EventBasedMethod("OnDeleting_StringDefaultValue")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_StringDefaultValue != null) OnDeleting_StringDefaultValue(this);
        }
        public static event ObjectEventHandler<StringDefaultValue> OnDeleting_StringDefaultValue;

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


        public class StringDefaultValueProxy
            : Kistl.App.Base.DefaultPropertyValueNHibernateImpl.DefaultPropertyValueProxy
        {
            public StringDefaultValueProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(StringDefaultValueNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(StringDefaultValueProxy); } }

            public virtual string DefaultValue { get; set; }

        }

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this.Proxy.DefaultValue, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            {
                string tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.DefaultValue = tmp;
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
            XmlStreamer.ToStream(this.Proxy.DefaultValue, xml, "DefaultValue", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            {
                // yuck
                string tmp = this.Proxy.DefaultValue;
                XmlStreamer.FromStream(ref tmp, xml, "DefaultValue", "Kistl.App.Base");
                this.Proxy.DefaultValue = tmp;
            }
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this.Proxy.DefaultValue, xml, "DefaultValue", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            {
                // yuck
                string tmp = this.Proxy.DefaultValue;
                XmlStreamer.FromStream(ref tmp, xml, "DefaultValue", "Kistl.App.Base");
                this.Proxy.DefaultValue = tmp;
            }
        }

        #endregion

    }
}