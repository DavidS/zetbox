// <autogenerated/>

namespace ZBox.App.SchemaMigration
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
    /// A log of all migration operations
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("MigrationLog")]
    public class MigrationLogNHibernateImpl : Kistl.DalProvider.NHibernate.DataObjectNHibernateImpl, MigrationLog
    {
        public MigrationLogNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public MigrationLogNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new MigrationLogProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public MigrationLogNHibernateImpl(Func<IFrozenContext> lazyCtx, MigrationLogProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly MigrationLogProxy Proxy;

        /// <summary>
        /// The destination of this migration step
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string Destination
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Destination;
                if (OnDestination_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnDestination_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Destination != value)
                {
                    var __oldValue = Proxy.Destination;
                    var __newValue = value;
                    if (OnDestination_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnDestination_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Destination", __oldValue, __newValue);
                    Proxy.Destination = __newValue;
                    NotifyPropertyChanged("Destination", __oldValue, __newValue);
                    if (OnDestination_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnDestination_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<ZBox.App.SchemaMigration.MigrationLog, string> OnDestination_Getter;
		public static event PropertyPreSetterHandler<ZBox.App.SchemaMigration.MigrationLog, string> OnDestination_PreSetter;
		public static event PropertyPostSetterHandler<ZBox.App.SchemaMigration.MigrationLog, string> OnDestination_PostSetter;

        /// <summary>
        /// The number of rows in the destination
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public int DestinationRows
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return default(int);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.DestinationRows;
                if (OnDestinationRows_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnDestinationRows_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.DestinationRows != value)
                {
                    var __oldValue = Proxy.DestinationRows;
                    var __newValue = value;
                    if (OnDestinationRows_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnDestinationRows_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("DestinationRows", __oldValue, __newValue);
                    Proxy.DestinationRows = __newValue;
                    NotifyPropertyChanged("DestinationRows", __oldValue, __newValue);
                    if (OnDestinationRows_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnDestinationRows_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<ZBox.App.SchemaMigration.MigrationLog, int> OnDestinationRows_Getter;
		public static event PropertyPreSetterHandler<ZBox.App.SchemaMigration.MigrationLog, int> OnDestinationRows_PreSetter;
		public static event PropertyPostSetterHandler<ZBox.App.SchemaMigration.MigrationLog, int> OnDestinationRows_PostSetter;

        /// <summary>
        /// The source of the migration step
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string Source
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Source;
                if (OnSource_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnSource_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Source != value)
                {
                    var __oldValue = Proxy.Source;
                    var __newValue = value;
                    if (OnSource_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnSource_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Source", __oldValue, __newValue);
                    Proxy.Source = __newValue;
                    NotifyPropertyChanged("Source", __oldValue, __newValue);
                    if (OnSource_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnSource_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<ZBox.App.SchemaMigration.MigrationLog, string> OnSource_Getter;
		public static event PropertyPreSetterHandler<ZBox.App.SchemaMigration.MigrationLog, string> OnSource_PreSetter;
		public static event PropertyPostSetterHandler<ZBox.App.SchemaMigration.MigrationLog, string> OnSource_PostSetter;

        /// <summary>
        /// The number of rows in this source
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public int SourceRows
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return default(int);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.SourceRows;
                if (OnSourceRows_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnSourceRows_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.SourceRows != value)
                {
                    var __oldValue = Proxy.SourceRows;
                    var __newValue = value;
                    if (OnSourceRows_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnSourceRows_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("SourceRows", __oldValue, __newValue);
                    Proxy.SourceRows = __newValue;
                    NotifyPropertyChanged("SourceRows", __oldValue, __newValue);
                    if (OnSourceRows_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnSourceRows_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<ZBox.App.SchemaMigration.MigrationLog, int> OnSourceRows_Getter;
		public static event PropertyPreSetterHandler<ZBox.App.SchemaMigration.MigrationLog, int> OnSourceRows_PreSetter;
		public static event PropertyPostSetterHandler<ZBox.App.SchemaMigration.MigrationLog, int> OnSourceRows_PostSetter;

        /// <summary>
        /// When the logentry was written
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public DateTime Timestamp
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return default(DateTime);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Timestamp;
                if (OnTimestamp_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime>(__result);
                    OnTimestamp_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Timestamp != value)
                {
                    var __oldValue = Proxy.Timestamp;
                    var __newValue = value;
                    if (OnTimestamp_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime>(__oldValue, __newValue);
                        OnTimestamp_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Timestamp", __oldValue, __newValue);
                    Proxy.Timestamp = __newValue;
                    NotifyPropertyChanged("Timestamp", __oldValue, __newValue);
                    if (OnTimestamp_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime>(__oldValue, __newValue);
                        OnTimestamp_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<ZBox.App.SchemaMigration.MigrationLog, DateTime> OnTimestamp_Getter;
		public static event PropertyPreSetterHandler<ZBox.App.SchemaMigration.MigrationLog, DateTime> OnTimestamp_PreSetter;
		public static event PropertyPostSetterHandler<ZBox.App.SchemaMigration.MigrationLog, DateTime> OnTimestamp_PostSetter;

        public override Type GetImplementedInterface()
        {
            return typeof(MigrationLog);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (MigrationLog)obj;
            var otherImpl = (MigrationLogNHibernateImpl)obj;
            var me = (MigrationLog)this;

            me.Destination = other.Destination;
            me.DestinationRows = other.DestinationRows;
            me.Source = other.Source;
            me.SourceRows = other.SourceRows;
            me.Timestamp = other.Timestamp;
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
                    new PropertyDescriptorNHibernateImpl<MigrationLogNHibernateImpl, string>(
                        lazyCtx,
                        new Guid("bad56a8d-e23e-47e3-8545-ee4c2689aab8"),
                        "Destination",
                        null,
                        obj => obj.Destination,
                        (obj, val) => obj.Destination = val),
                    // else
                    new PropertyDescriptorNHibernateImpl<MigrationLogNHibernateImpl, int>(
                        lazyCtx,
                        new Guid("6b2ac709-a61b-4d22-96e6-e36f4bcbce84"),
                        "DestinationRows",
                        null,
                        obj => obj.DestinationRows,
                        (obj, val) => obj.DestinationRows = val),
                    // else
                    new PropertyDescriptorNHibernateImpl<MigrationLogNHibernateImpl, string>(
                        lazyCtx,
                        new Guid("fd0e1581-c4f0-476e-af24-2905e4aa377d"),
                        "Source",
                        null,
                        obj => obj.Source,
                        (obj, val) => obj.Source = val),
                    // else
                    new PropertyDescriptorNHibernateImpl<MigrationLogNHibernateImpl, int>(
                        lazyCtx,
                        new Guid("52a3ddb3-c724-4427-a2e1-95bbf347906a"),
                        "SourceRows",
                        null,
                        obj => obj.SourceRows,
                        (obj, val) => obj.SourceRows = val),
                    // else
                    new PropertyDescriptorNHibernateImpl<MigrationLogNHibernateImpl, DateTime>(
                        lazyCtx,
                        new Guid("9e3a70c6-04f9-4464-93c9-68c1eec6b94f"),
                        "Timestamp",
                        null,
                        obj => obj.Timestamp,
                        (obj, val) => obj.Timestamp = val),
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
        [EventBasedMethod("OnToString_MigrationLog")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_MigrationLog != null)
            {
                OnToString_MigrationLog(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<MigrationLog> OnToString_MigrationLog;

        [EventBasedMethod("OnPreSave_MigrationLog")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_MigrationLog != null) OnPreSave_MigrationLog(this);
        }
        public static event ObjectEventHandler<MigrationLog> OnPreSave_MigrationLog;

        [EventBasedMethod("OnPostSave_MigrationLog")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_MigrationLog != null) OnPostSave_MigrationLog(this);
        }
        public static event ObjectEventHandler<MigrationLog> OnPostSave_MigrationLog;

        [EventBasedMethod("OnCreated_MigrationLog")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_MigrationLog != null) OnCreated_MigrationLog(this);
        }
        public static event ObjectEventHandler<MigrationLog> OnCreated_MigrationLog;

        [EventBasedMethod("OnDeleting_MigrationLog")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_MigrationLog != null) OnDeleting_MigrationLog(this);
        }
        public static event ObjectEventHandler<MigrationLog> OnDeleting_MigrationLog;

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


        public class MigrationLogProxy
            : IProxyObject, ISortKey<int>
        {
            public MigrationLogProxy()
            {
            }

            public virtual int ID { get; set; }

            public virtual Type ZBoxWrapper { get { return typeof(MigrationLogNHibernateImpl); } }
            public virtual Type ZBoxProxy { get { return typeof(MigrationLogProxy); } }

            public virtual string Destination { get; set; }

            public virtual int DestinationRows { get; set; }

            public virtual string Source { get; set; }

            public virtual int SourceRows { get; set; }

            public virtual DateTime Timestamp { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this.Proxy.Destination, binStream);
            BinarySerializer.ToStream(this.Proxy.DestinationRows, binStream);
            BinarySerializer.ToStream(this.Proxy.Source, binStream);
            BinarySerializer.ToStream(this.Proxy.SourceRows, binStream);
            BinarySerializer.ToStream(this.Proxy.Timestamp, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            {
                string tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.Destination = tmp;
            }
            {
                int tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.DestinationRows = tmp;
            }
            {
                string tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.Source = tmp;
            }
            {
                int tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.SourceRows = tmp;
            }
            {
                DateTime tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.Timestamp = tmp;
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
            XmlStreamer.ToStream(this.Proxy.Destination, xml, "Destination", "ZBox.App.SchemaMigration");
            XmlStreamer.ToStream(this.Proxy.DestinationRows, xml, "DestinationRows", "ZBox.App.SchemaMigration");
            XmlStreamer.ToStream(this.Proxy.Source, xml, "Source", "ZBox.App.SchemaMigration");
            XmlStreamer.ToStream(this.Proxy.SourceRows, xml, "SourceRows", "ZBox.App.SchemaMigration");
            XmlStreamer.ToStream(this.Proxy.Timestamp, xml, "Timestamp", "ZBox.App.SchemaMigration");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            {
                // yuck
                string tmp = this.Proxy.Destination;
                XmlStreamer.FromStream(ref tmp, xml, "Destination", "ZBox.App.SchemaMigration");
                this.Proxy.Destination = tmp;
            }
            {
                // yuck
                int tmp = this.Proxy.DestinationRows;
                XmlStreamer.FromStream(ref tmp, xml, "DestinationRows", "ZBox.App.SchemaMigration");
                this.Proxy.DestinationRows = tmp;
            }
            {
                // yuck
                string tmp = this.Proxy.Source;
                XmlStreamer.FromStream(ref tmp, xml, "Source", "ZBox.App.SchemaMigration");
                this.Proxy.Source = tmp;
            }
            {
                // yuck
                int tmp = this.Proxy.SourceRows;
                XmlStreamer.FromStream(ref tmp, xml, "SourceRows", "ZBox.App.SchemaMigration");
                this.Proxy.SourceRows = tmp;
            }
            {
                // yuck
                DateTime tmp = this.Proxy.Timestamp;
                XmlStreamer.FromStream(ref tmp, xml, "Timestamp", "ZBox.App.SchemaMigration");
                this.Proxy.Timestamp = tmp;
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