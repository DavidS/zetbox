// <autogenerated/>

namespace Zetbox.App.Test
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    using Zetbox.API;
    using Zetbox.DalProvider.Base.RelationWrappers;

    using Zetbox.API.Utils;
    using Zetbox.DalProvider.Base;
    using Zetbox.DalProvider.NHibernate;

    /// <summary>
    /// A test class for persistently ordered 1:N relations
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("OrderedOneEnd")]
    public class OrderedOneEndNHibernateImpl : Zetbox.DalProvider.NHibernate.DataObjectNHibernateImpl, OrderedOneEnd
    {
        private static readonly Guid _objectClassID = new Guid("c170405f-c29d-4d87-a4f7-a622185a94d9");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public OrderedOneEndNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public OrderedOneEndNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new OrderedOneEndProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public OrderedOneEndNHibernateImpl(Func<IFrozenContext> lazyCtx, OrderedOneEndProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly OrderedOneEndProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // object list property

        // Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public IList<Zetbox.App.Test.OrderedNEnd> NEnds
        {
            get
            {
                if (_NEnds == null)
                {
                    _NEnds = new OneNRelationList<Zetbox.App.Test.OrderedNEnd>(
                        "OneEnd",
                        "NEnds_pos",
                        this,
                        () => this.NotifyPropertyChanging("NEnds", null, null),
                        () => { this.NotifyPropertyChanged("NEnds", null, null); if(OnNEnds_PostSetter != null && IsAttached) OnNEnds_PostSetter(this); },
                        new ProjectedCollection<Zetbox.App.Test.OrderedNEndNHibernateImpl.OrderedNEndProxy, Zetbox.App.Test.OrderedNEnd>(
                            () => Proxy.NEnds,
                            p => (Zetbox.App.Test.OrderedNEnd)OurContext.AttachAndWrap(p),
                            d => (Zetbox.App.Test.OrderedNEndNHibernateImpl.OrderedNEndProxy)((NHibernatePersistenceObject)d).NHibernateProxy));
                }
                return _NEnds;
            }
        }
    
        private OneNRelationList<Zetbox.App.Test.OrderedNEnd> _NEnds;

        public Zetbox.API.Async.ZbTask TriggerFetchNEndsAsync()
        {
            return new Zetbox.API.Async.ZbTask<IList<Zetbox.App.Test.OrderedNEnd>>(this.NEnds);
        }

public static event PropertyListChangedHandler<Zetbox.App.Test.OrderedOneEnd> OnNEnds_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.OrderedOneEnd> OnNEnds_IsValid;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public int? SomeInt
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.SomeInt;
                if (OnSomeInt_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int?>(__result);
                    OnSomeInt_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.SomeInt != value)
                {
                    var __oldValue = Proxy.SomeInt;
                    var __newValue = value;
                    if (OnSomeInt_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int?>(__oldValue, __newValue);
                        OnSomeInt_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("SomeInt", __oldValue, __newValue);
                    Proxy.SomeInt = __newValue;
                    NotifyPropertyChanged("SomeInt", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnSomeInt_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int?>(__oldValue, __newValue);
                        OnSomeInt_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("SomeInt");
                }
            }
        }

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.OrderedOneEnd, int?> OnSomeInt_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.OrderedOneEnd, int?> OnSomeInt_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.OrderedOneEnd, int?> OnSomeInt_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.OrderedOneEnd> OnSomeInt_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(OrderedOneEnd);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (OrderedOneEnd)obj;
            var otherImpl = (OrderedOneEndNHibernateImpl)obj;
            var me = (OrderedOneEnd)this;

            me.SomeInt = other.SomeInt;
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        #region Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "SomeInt":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }

        protected override bool ShouldSetModified(string property)
        {
            switch (property)
            {
                case "NEnds":
                    return false;
                default:
                    return base.ShouldSetModified(property);
            }
        }
        #endregion // Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        public override Zetbox.API.Async.ZbTask TriggerFetch(string propName)
        {
            switch(propName)
            {
            case "NEnds":
                return TriggerFetchNEndsAsync();
            default:
                return base.TriggerFetch(propName);
            }
        }

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references
        }
        #region Zetbox.Generator.Templates.ObjectClasses.CustomTypeDescriptor
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
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorNHibernateImpl<OrderedOneEnd, IList<Zetbox.App.Test.OrderedNEnd>>(
                        lazyCtx,
                        new Guid("7b7a227b-462a-4923-bda6-15264f0af841"),
                        "NEnds",
                        null,
                        obj => obj.NEnds,
                        null, // lists are read-only properties
                        obj => OnNEnds_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<OrderedOneEnd, int?>(
                        lazyCtx,
                        new Guid("1062a9d3-b936-42b8-99ba-2353087cbce1"),
                        "SomeInt",
                        null,
                        obj => obj.SomeInt,
                        (obj, val) => obj.SomeInt = val,
						obj => OnSomeInt_IsValid), 
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
        #endregion // Zetbox.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_OrderedOneEnd")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_OrderedOneEnd != null)
            {
                OnToString_OrderedOneEnd(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<OrderedOneEnd> OnToString_OrderedOneEnd;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_OrderedOneEnd")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_OrderedOneEnd != null)
            {
                OnObjectIsValid_OrderedOneEnd(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<OrderedOneEnd> OnObjectIsValid_OrderedOneEnd;

        [EventBasedMethod("OnNotifyPreSave_OrderedOneEnd")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_OrderedOneEnd != null) OnNotifyPreSave_OrderedOneEnd(this);
        }
        public static event ObjectEventHandler<OrderedOneEnd> OnNotifyPreSave_OrderedOneEnd;

        [EventBasedMethod("OnNotifyPostSave_OrderedOneEnd")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_OrderedOneEnd != null) OnNotifyPostSave_OrderedOneEnd(this);
        }
        public static event ObjectEventHandler<OrderedOneEnd> OnNotifyPostSave_OrderedOneEnd;

        [EventBasedMethod("OnNotifyCreated_OrderedOneEnd")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("SomeInt");
            base.NotifyCreated();
            if (OnNotifyCreated_OrderedOneEnd != null) OnNotifyCreated_OrderedOneEnd(this);
        }
        public static event ObjectEventHandler<OrderedOneEnd> OnNotifyCreated_OrderedOneEnd;

        [EventBasedMethod("OnNotifyDeleting_OrderedOneEnd")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_OrderedOneEnd != null) OnNotifyDeleting_OrderedOneEnd(this);

            // FK_OneEnd_hasMany_NEnds ZeroOrMore
            foreach(NHibernatePersistenceObject x in NEnds) {
                x.ParentsToDelete.Add(this);
                ChildrenToDelete.Add(x);
            }

            NEnds.Clear();
        }
        public static event ObjectEventHandler<OrderedOneEnd> OnNotifyDeleting_OrderedOneEnd;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class OrderedOneEndProxy
            : IProxyObject, ISortKey<int>
        {
            public OrderedOneEndProxy()
            {
                NEnds = new Collection<Zetbox.App.Test.OrderedNEndNHibernateImpl.OrderedNEndProxy>();
            }

            public virtual int ID { get; set; }

            public virtual Type ZetboxWrapper { get { return typeof(OrderedOneEndNHibernateImpl); } }
            public virtual Type ZetboxProxy { get { return typeof(OrderedOneEndProxy); } }

            public virtual ICollection<Zetbox.App.Test.OrderedNEndNHibernateImpl.OrderedNEndProxy> NEnds { get; set; }

            public virtual int? SomeInt { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.SomeInt);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this.Proxy.SomeInt = binStream.ReadNullableInt32();
            } // if (CurrentAccessRights != Zetbox.API.AccessRights.None)
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        #endregion

    }
}