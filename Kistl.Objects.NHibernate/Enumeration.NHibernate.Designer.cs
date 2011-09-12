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
    /// Metadefinition Object for Enumerations.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("Enumeration")]
    public class EnumerationNHibernateImpl : Kistl.App.Base.DataTypeNHibernateImpl, Enumeration
    {
        public EnumerationNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public EnumerationNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new EnumerationProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public EnumerationNHibernateImpl(Func<IFrozenContext> lazyCtx, EnumerationProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly EnumerationProxy Proxy;

        /// <summary>
        /// Enumeration Entries are Flags
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public bool AreFlags
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.AreFlags;
                if (OnAreFlags_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnAreFlags_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.AreFlags != value)
                {
                    var __oldValue = Proxy.AreFlags;
                    var __newValue = value;
                    if (OnAreFlags_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnAreFlags_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("AreFlags", __oldValue, __newValue);
                    Proxy.AreFlags = __newValue;
                    NotifyPropertyChanged("AreFlags", __oldValue, __newValue);
                    if (OnAreFlags_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnAreFlags_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.Enumeration, bool> OnAreFlags_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.Enumeration, bool> OnAreFlags_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.Enumeration, bool> OnAreFlags_PostSetter;

        /// <summary>
        /// Einträge der Enumeration
        /// </summary>
        // object list property

        // Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public IList<Kistl.App.Base.EnumerationEntry> EnumerationEntries
        {
            get
            {
                if (_EnumerationEntries == null)
                {
                    _EnumerationEntries = new OneNRelationList<Kistl.App.Base.EnumerationEntry>(
                        "Enumeration",
                        "EnumerationEntries_pos",
                        this,
                        () => this.NotifyPropertyChanging("EnumerationEntries", null, null),
                        () => { this.NotifyPropertyChanged("EnumerationEntries", null, null); if(OnEnumerationEntries_PostSetter != null && IsAttached) OnEnumerationEntries_PostSetter(this); },
                        new ProjectedCollection<Kistl.App.Base.EnumerationEntryNHibernateImpl.EnumerationEntryProxy, Kistl.App.Base.EnumerationEntry>(
                            Proxy.EnumerationEntries,
                            p => (Kistl.App.Base.EnumerationEntry)OurContext.AttachAndWrap(p),
                            d => (Kistl.App.Base.EnumerationEntryNHibernateImpl.EnumerationEntryProxy)((NHibernatePersistenceObject)d).NHibernateProxy));
                }
                return _EnumerationEntries;
            }
        }
    
        private OneNRelationList<Kistl.App.Base.EnumerationEntry> _EnumerationEntries;
public static event PropertyListChangedHandler<Kistl.App.Base.Enumeration> OnEnumerationEntries_PostSetter;

        /// <summary>
        /// Returns the resulting Type of this Datatype Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDataType_Enumeration")]
        public override System.Type GetDataType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetDataType_Enumeration != null)
            {
                OnGetDataType_Enumeration(this, e);
            }
            else
            {
                e.Result = base.GetDataType();
            }
            return e.Result;
        }
        public static event GetDataType_Handler<Enumeration> OnGetDataType_Enumeration;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the String representation of this Datatype Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDataTypeString_Enumeration")]
        public override string GetDataTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetDataTypeString_Enumeration != null)
            {
                OnGetDataTypeString_Enumeration(this, e);
            }
            else
            {
                e.Result = base.GetDataTypeString();
            }
            return e.Result;
        }
        public static event GetDataTypeString_Handler<Enumeration> OnGetDataTypeString_Enumeration;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetEntryByName_Enumeration")]
        public virtual Kistl.App.Base.EnumerationEntry GetEntryByName(System.String name)
        {
            var e = new MethodReturnEventArgs<Kistl.App.Base.EnumerationEntry>();
            if (OnGetEntryByName_Enumeration != null)
            {
                OnGetEntryByName_Enumeration(this, e, name);
            }
            else
            {
                throw new NotImplementedException("No handler registered on Enumeration.GetEntryByName");
            }
            return e.Result;
        }
        public delegate void GetEntryByName_Handler<T>(T obj, MethodReturnEventArgs<Kistl.App.Base.EnumerationEntry> ret, System.String name);
        public static event GetEntryByName_Handler<Enumeration> OnGetEntryByName_Enumeration;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetEntryByValue_Enumeration")]
        public virtual Kistl.App.Base.EnumerationEntry GetEntryByValue(System.Int32 val)
        {
            var e = new MethodReturnEventArgs<Kistl.App.Base.EnumerationEntry>();
            if (OnGetEntryByValue_Enumeration != null)
            {
                OnGetEntryByValue_Enumeration(this, e, val);
            }
            else
            {
                throw new NotImplementedException("No handler registered on Enumeration.GetEntryByValue");
            }
            return e.Result;
        }
        public delegate void GetEntryByValue_Handler<T>(T obj, MethodReturnEventArgs<Kistl.App.Base.EnumerationEntry> ret, System.Int32 val);
        public static event GetEntryByValue_Handler<Enumeration> OnGetEntryByValue_Enumeration;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabelByName_Enumeration")]
        public virtual string GetLabelByName(System.String name)
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabelByName_Enumeration != null)
            {
                OnGetLabelByName_Enumeration(this, e, name);
            }
            else
            {
                throw new NotImplementedException("No handler registered on Enumeration.GetLabelByName");
            }
            return e.Result;
        }
        public delegate void GetLabelByName_Handler<T>(T obj, MethodReturnEventArgs<string> ret, System.String name);
        public static event GetLabelByName_Handler<Enumeration> OnGetLabelByName_Enumeration;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabelByValue_Enumeration")]
        public virtual string GetLabelByValue(System.Int32 val)
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabelByValue_Enumeration != null)
            {
                OnGetLabelByValue_Enumeration(this, e, val);
            }
            else
            {
                throw new NotImplementedException("No handler registered on Enumeration.GetLabelByValue");
            }
            return e.Result;
        }
        public delegate void GetLabelByValue_Handler<T>(T obj, MethodReturnEventArgs<string> ret, System.Int32 val);
        public static event GetLabelByValue_Handler<Enumeration> OnGetLabelByValue_Enumeration;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(Enumeration);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (Enumeration)obj;
            var otherImpl = (EnumerationNHibernateImpl)obj;
            var me = (Enumeration)this;

            me.AreFlags = other.AreFlags;
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
                    new PropertyDescriptorNHibernateImpl<EnumerationNHibernateImpl, bool>(
                        lazyCtx,
                        new Guid("1ef92eea-d8b3-4f95-a694-9ca09ceff0e5"),
                        "AreFlags",
                        null,
                        obj => obj.AreFlags,
                        (obj, val) => obj.AreFlags = val),
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorNHibernateImpl<EnumerationNHibernateImpl, IList<Kistl.App.Base.EnumerationEntry>>(
                        lazyCtx,
                        new Guid("1619c8a7-b969-4c05-851c-7a2545cda484"),
                        "EnumerationEntries",
                        null,
                        obj => obj.EnumerationEntries,
                        null), // lists are read-only properties
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
        [EventBasedMethod("OnToString_Enumeration")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Enumeration != null)
            {
                OnToString_Enumeration(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<Enumeration> OnToString_Enumeration;

        [EventBasedMethod("OnPreSave_Enumeration")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Enumeration != null) OnPreSave_Enumeration(this);
        }
        public static event ObjectEventHandler<Enumeration> OnPreSave_Enumeration;

        [EventBasedMethod("OnPostSave_Enumeration")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Enumeration != null) OnPostSave_Enumeration(this);
        }
        public static event ObjectEventHandler<Enumeration> OnPostSave_Enumeration;

        [EventBasedMethod("OnCreated_Enumeration")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_Enumeration != null) OnCreated_Enumeration(this);
        }
        public static event ObjectEventHandler<Enumeration> OnCreated_Enumeration;

        [EventBasedMethod("OnDeleting_Enumeration")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Enumeration != null) OnDeleting_Enumeration(this);
        }
        public static event ObjectEventHandler<Enumeration> OnDeleting_Enumeration;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods
        public override List<NHibernatePersistenceObject> GetParentsToDelete()
        {
            var result = base.GetParentsToDelete();

            return result;
        }

        public override List<NHibernatePersistenceObject> GetChildrenToDelete()
        {
            var result = base.GetChildrenToDelete();

            // Follow Enumeration_has_EnumerationEntries
            result.AddRange(Context.AttachedObjects
                .OfType<Kistl.App.Base.EnumerationEntry>()
                .Where(child => child.Enumeration == this
                    && child.ObjectState == DataObjectState.Deleted)
                .Cast<NHibernatePersistenceObject>());

            // Follow EnumerationProperty_has_Enumeration
            result.AddRange(Context.AttachedObjects
                .OfType<Kistl.App.Base.EnumerationProperty>()
                .Where(child => child.Enumeration == this
                    && child.ObjectState == DataObjectState.Deleted)
                .Cast<NHibernatePersistenceObject>());

            // Follow EnumParameter_has_Enumeration
            result.AddRange(Context.AttachedObjects
                .OfType<Kistl.App.Base.EnumParameter>()
                .Where(child => child.Enumeration == this
                    && child.ObjectState == DataObjectState.Deleted)
                .Cast<NHibernatePersistenceObject>());

            return result;
        }


        public class EnumerationProxy
            : Kistl.App.Base.DataTypeNHibernateImpl.DataTypeProxy
        {
            public EnumerationProxy()
            {
                EnumerationEntries = new Collection<Kistl.App.Base.EnumerationEntryNHibernateImpl.EnumerationEntryProxy>();
            }

            public override Type ZBoxWrapper { get { return typeof(EnumerationNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(EnumerationProxy); } }

            public virtual bool AreFlags { get; set; }

            public virtual ICollection<Kistl.App.Base.EnumerationEntryNHibernateImpl.EnumerationEntryProxy> EnumerationEntries { get; set; }

        }

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this.Proxy.AreFlags, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            {
                bool tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.AreFlags = tmp;
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
            XmlStreamer.ToStream(this.Proxy.AreFlags, xml, "AreFlags", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            {
                // yuck
                bool tmp = this.Proxy.AreFlags;
                XmlStreamer.FromStream(ref tmp, xml, "AreFlags", "Kistl.App.Base");
                this.Proxy.AreFlags = tmp;
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this.Proxy.AreFlags, xml, "AreFlags", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            {
                // yuck
                bool tmp = this.Proxy.AreFlags;
                XmlStreamer.FromStream(ref tmp, xml, "AreFlags", "Kistl.App.Base");
                this.Proxy.AreFlags = tmp;
            }
        }

        #endregion

    }
}