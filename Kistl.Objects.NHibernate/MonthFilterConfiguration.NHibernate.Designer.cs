// <autogenerated/>

namespace Kistl.App.GUI
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
    [System.Diagnostics.DebuggerDisplay("MonthFilterConfiguration")]
    public class MonthFilterConfigurationNHibernateImpl : Kistl.App.GUI.PropertyFilterConfigurationNHibernateImpl, MonthFilterConfiguration
    {
        public MonthFilterConfigurationNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public MonthFilterConfigurationNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new MonthFilterConfigurationProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public MonthFilterConfigurationNHibernateImpl(Func<IFrozenContext> lazyCtx, MonthFilterConfigurationProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly MonthFilterConfigurationProxy Proxy;

        /// <summary>
        /// If true, the current month will be the default value
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public bool? IsCurrentMonthDefault
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return default(bool?);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.IsCurrentMonthDefault;
                if (OnIsCurrentMonthDefault_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool?>(__result);
                    OnIsCurrentMonthDefault_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.IsCurrentMonthDefault != value)
                {
                    var __oldValue = Proxy.IsCurrentMonthDefault;
                    var __newValue = value;
                    if (OnIsCurrentMonthDefault_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnIsCurrentMonthDefault_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IsCurrentMonthDefault", __oldValue, __newValue);
                    Proxy.IsCurrentMonthDefault = __newValue;
                    NotifyPropertyChanged("IsCurrentMonthDefault", __oldValue, __newValue);
                    if (OnIsCurrentMonthDefault_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnIsCurrentMonthDefault_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.GUI.MonthFilterConfiguration, bool?> OnIsCurrentMonthDefault_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.MonthFilterConfiguration, bool?> OnIsCurrentMonthDefault_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.MonthFilterConfiguration, bool?> OnIsCurrentMonthDefault_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnCreateFilterModel_MonthFilterConfiguration")]
        public override Kistl.API.IFilterModel CreateFilterModel()
        {
            var e = new MethodReturnEventArgs<Kistl.API.IFilterModel>();
            if (OnCreateFilterModel_MonthFilterConfiguration != null)
            {
                OnCreateFilterModel_MonthFilterConfiguration(this, e);
            }
            else
            {
                e.Result = base.CreateFilterModel();
            }
            return e.Result;
        }
        public static event CreateFilterModel_Handler<MonthFilterConfiguration> OnCreateFilterModel_MonthFilterConfiguration;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_MonthFilterConfiguration")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_MonthFilterConfiguration != null)
            {
                OnGetLabel_MonthFilterConfiguration(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<MonthFilterConfiguration> OnGetLabel_MonthFilterConfiguration;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(MonthFilterConfiguration);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (MonthFilterConfiguration)obj;
            var otherImpl = (MonthFilterConfigurationNHibernateImpl)obj;
            var me = (MonthFilterConfiguration)this;

            me.IsCurrentMonthDefault = other.IsCurrentMonthDefault;
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
                    new PropertyDescriptorNHibernateImpl<MonthFilterConfigurationNHibernateImpl, bool?>(
                        lazyCtx,
                        new Guid("363661ad-85ce-4bc2-b249-c3cce65a1971"),
                        "IsCurrentMonthDefault",
                        null,
                        obj => obj.IsCurrentMonthDefault,
                        (obj, val) => obj.IsCurrentMonthDefault = val),
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
        [EventBasedMethod("OnToString_MonthFilterConfiguration")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_MonthFilterConfiguration != null)
            {
                OnToString_MonthFilterConfiguration(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<MonthFilterConfiguration> OnToString_MonthFilterConfiguration;

        [EventBasedMethod("OnPreSave_MonthFilterConfiguration")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_MonthFilterConfiguration != null) OnPreSave_MonthFilterConfiguration(this);
        }
        public static event ObjectEventHandler<MonthFilterConfiguration> OnPreSave_MonthFilterConfiguration;

        [EventBasedMethod("OnPostSave_MonthFilterConfiguration")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_MonthFilterConfiguration != null) OnPostSave_MonthFilterConfiguration(this);
        }
        public static event ObjectEventHandler<MonthFilterConfiguration> OnPostSave_MonthFilterConfiguration;

        [EventBasedMethod("OnCreated_MonthFilterConfiguration")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_MonthFilterConfiguration != null) OnCreated_MonthFilterConfiguration(this);
        }
        public static event ObjectEventHandler<MonthFilterConfiguration> OnCreated_MonthFilterConfiguration;

        [EventBasedMethod("OnDeleting_MonthFilterConfiguration")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_MonthFilterConfiguration != null) OnDeleting_MonthFilterConfiguration(this);
        }
        public static event ObjectEventHandler<MonthFilterConfiguration> OnDeleting_MonthFilterConfiguration;

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


        public class MonthFilterConfigurationProxy
            : Kistl.App.GUI.PropertyFilterConfigurationNHibernateImpl.PropertyFilterConfigurationProxy
        {
            public MonthFilterConfigurationProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(MonthFilterConfigurationNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(MonthFilterConfigurationProxy); } }

            public virtual bool? IsCurrentMonthDefault { get; set; }

        }

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this.Proxy.IsCurrentMonthDefault, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            {
                bool? tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.IsCurrentMonthDefault = tmp;
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
            XmlStreamer.ToStream(this.Proxy.IsCurrentMonthDefault, xml, "IsCurrentMonthDefault", "Kistl.App.GUI");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            {
                // yuck
                bool? tmp = this.Proxy.IsCurrentMonthDefault;
                XmlStreamer.FromStream(ref tmp, xml, "IsCurrentMonthDefault", "Kistl.App.GUI");
                this.Proxy.IsCurrentMonthDefault = tmp;
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this.Proxy.IsCurrentMonthDefault, xml, "IsCurrentMonthDefault", "Kistl.App.GUI");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            {
                // yuck
                bool? tmp = this.Proxy.IsCurrentMonthDefault;
                XmlStreamer.FromStream(ref tmp, xml, "IsCurrentMonthDefault", "Kistl.App.GUI");
                this.Proxy.IsCurrentMonthDefault = tmp;
            }
        }

        #endregion

    }
}