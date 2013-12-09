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
    /// a test class for ordered lists
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("One_to_N_relations_OrderedN")]
    public class One_to_N_relations_OrderedNNHibernateImpl : Zetbox.DalProvider.NHibernate.DataObjectNHibernateImpl, One_to_N_relations_OrderedN
    {
        private static readonly Guid _objectClassID = new Guid("c887def0-a835-497d-992e-ff0bb7463280");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public One_to_N_relations_OrderedNNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public One_to_N_relations_OrderedNNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new One_to_N_relations_OrderedNProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public One_to_N_relations_OrderedNNHibernateImpl(Func<IFrozenContext> lazyCtx, One_to_N_relations_OrderedNProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly One_to_N_relations_OrderedNProxy Proxy;

        /// <summary>
        /// A property to test queries across the Relation
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string Name
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Name;
                if (OnName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Name != value)
                {
                    var __oldValue = Proxy.Name;
                    var __newValue = value;
                    if (OnName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Name", __oldValue, __newValue);
                    Proxy.Name = __newValue;
                    NotifyPropertyChanged("Name", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("Name");
                }
            }
        }

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.One_to_N_relations_OrderedN, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.One_to_N_relations_OrderedN, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.One_to_N_relations_OrderedN, string> OnName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.One_to_N_relations_OrderedN> OnName_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for OneSide
        // fkBackingName=this.Proxy.OneSide; fkGuidBackingName=_fk_guid_OneSide;
        // referencedInterface=Zetbox.App.Test.One_to_N_relations_One; moduleNamespace=Zetbox.App.Test;
        // inverse Navigator=OrderedNSide; is list;
        // PositionStorage=OrderedNSide_pos;
        // Target not exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Test.One_to_N_relations_One OneSide
        {
            get
            {
                Zetbox.App.Test.One_to_N_relations_OneNHibernateImpl __value = (Zetbox.App.Test.One_to_N_relations_OneNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.OneSide);

                if (OnOneSide_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Test.One_to_N_relations_One>(__value);
                    OnOneSide_Getter(this, e);
                    __value = (Zetbox.App.Test.One_to_N_relations_OneNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.OneSide == null)
                {
                    SetInitializedProperty("OneSide");
                    return;
                }

                // cache old value to remove inverse references later
                var __oldValue = (Zetbox.App.Test.One_to_N_relations_OneNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.OneSide);
                var __newValue = (Zetbox.App.Test.One_to_N_relations_OneNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
                {
                    SetInitializedProperty("OneSide");
                    return;
                }

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("OneSide", __oldValue, __newValue);

                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanging("OrderedNSide", null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanging("OrderedNSide", null, null);
                }

                if (OnOneSide_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Test.One_to_N_relations_One>(__oldValue, __newValue);
                    OnOneSide_PreSetter(this, e);
                    __newValue = (Zetbox.App.Test.One_to_N_relations_OneNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.OneSide = null;
                }
                else
                {
                    this.Proxy.OneSide = __newValue.Proxy;
                }

                // now fixup redundant, inverse references
                // The inverse navigator will also fire events when changed, so should
                // only be touched after setting the local value above.
                // TODO: for complete correctness, the "other" Changing event should also fire
                //       before the local value is changed
                if (__oldValue != null)
                {
                    // remove from old list
                    (__oldValue.OrderedNSide as IRelationListSync<Zetbox.App.Test.One_to_N_relations_OrderedN>).RemoveWithoutClearParent(this);
                }

                if (__newValue != null)
                {
                    // add to new list
                    (__newValue.OrderedNSide as IRelationListSync<Zetbox.App.Test.One_to_N_relations_OrderedN>).AddWithoutSetParent(this);
                }
                // everything is done. fire the Changed event
                NotifyPropertyChanged("OneSide", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;

                if (OnOneSide_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Test.One_to_N_relations_One>(__oldValue, __newValue);
                    OnOneSide_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for OneSide's id, used on dehydration only</summary>
        private int? _fk_OneSide = null;


    public Zetbox.API.Async.ZbTask TriggerFetchOneSideAsync()
    {
        return new Zetbox.API.Async.ZbTask<Zetbox.App.Test.One_to_N_relations_One>(this.OneSide);
    }

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.NotifyingValueProperty
        public virtual int? OrderedNSide_pos
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.OrderedNSide_pos;
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.OrderedNSide_pos != value)
                {
                    var __oldValue = Proxy.OrderedNSide_pos;
                    var __newValue = value;
                    NotifyPropertyChanging("OrderedNSide_pos", __oldValue, __newValue);
                    Proxy.OrderedNSide_pos = __newValue;
                    NotifyPropertyChanged("OrderedNSide_pos", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                }
                else
                {
                    SetInitializedProperty("OrderedNSide_pos");
                }
            }
        }
        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.NotifyingValueProperty
        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for OneSide
		public static event PropertyGetterHandler<Zetbox.App.Test.One_to_N_relations_OrderedN, Zetbox.App.Test.One_to_N_relations_One> OnOneSide_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.One_to_N_relations_OrderedN, Zetbox.App.Test.One_to_N_relations_One> OnOneSide_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.One_to_N_relations_OrderedN, Zetbox.App.Test.One_to_N_relations_One> OnOneSide_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.One_to_N_relations_OrderedN> OnOneSide_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(One_to_N_relations_OrderedN);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (One_to_N_relations_OrderedN)obj;
            var otherImpl = (One_to_N_relations_OrderedNNHibernateImpl)obj;
            var me = (One_to_N_relations_OrderedN)this;

            me.Name = other.Name;
            this.OrderedNSide_pos = otherImpl.OrderedNSide_pos;
            this._fk_OneSide = otherImpl._fk_OneSide;
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "OneSide":
                    {
                        var __oldValue = (Zetbox.App.Test.One_to_N_relations_OneNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.OneSide);
                        var __newValue = (Zetbox.App.Test.One_to_N_relations_OneNHibernateImpl)parentObj;
                        NotifyPropertyChanging("OneSide", __oldValue, __newValue);
                        this.Proxy.OneSide = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("OneSide", __oldValue, __newValue);
                    }
                    break;
                default:
                    base.UpdateParent(propertyName, parentObj);
                    break;
            }
        }
        #region Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "Name":
                case "OneSide":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }
        #endregion // Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        public override Zetbox.API.Async.ZbTask TriggerFetch(string propName)
        {
            switch(propName)
            {
            case "OneSide":
                return TriggerFetchOneSideAsync();
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

            if (_fk_OneSide.HasValue)
                this.OneSide = ((Zetbox.App.Test.One_to_N_relations_OneNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.Test.One_to_N_relations_One>(_fk_OneSide.Value));
            else
                this.OneSide = null;
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
                    // else
                    new PropertyDescriptorNHibernateImpl<One_to_N_relations_OrderedN, string>(
                        lazyCtx,
                        new Guid("3ed99412-d4c8-44af-8ed6-dfcd28532a93"),
                        "Name",
                        null,
                        obj => obj.Name,
                        (obj, val) => obj.Name = val,
						obj => OnName_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<One_to_N_relations_OrderedN, Zetbox.App.Test.One_to_N_relations_One>(
                        lazyCtx,
                        new Guid("8073d6a1-4c8b-4789-82f4-f983ec706397"),
                        "OneSide",
                        null,
                        obj => obj.OneSide,
                        (obj, val) => obj.OneSide = val,
						obj => OnOneSide_IsValid), 
                    // position columns
                    // rel: OneSide connectsTo OrderedNSide (f225bde0-acc2-4dad-bdbc-a14d4f8ff987)
                    // rel.B.Type == cls && rel.B.HasPersistentOrder
                    new PropertyDescriptorNHibernateImpl<One_to_N_relations_OrderedNNHibernateImpl, int?>(
                        lazyCtx,
                        null,
                        "OrderedNSide_pos",
                        null,
                        obj => obj.OrderedNSide_pos,
                        (obj, val) => obj.OrderedNSide_pos = val,
						null),
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
        [EventBasedMethod("OnToString_One_to_N_relations_OrderedN")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_One_to_N_relations_OrderedN != null)
            {
                OnToString_One_to_N_relations_OrderedN(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<One_to_N_relations_OrderedN> OnToString_One_to_N_relations_OrderedN;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_One_to_N_relations_OrderedN")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_One_to_N_relations_OrderedN != null)
            {
                OnObjectIsValid_One_to_N_relations_OrderedN(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<One_to_N_relations_OrderedN> OnObjectIsValid_One_to_N_relations_OrderedN;

        [EventBasedMethod("OnNotifyPreSave_One_to_N_relations_OrderedN")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_One_to_N_relations_OrderedN != null) OnNotifyPreSave_One_to_N_relations_OrderedN(this);
        }
        public static event ObjectEventHandler<One_to_N_relations_OrderedN> OnNotifyPreSave_One_to_N_relations_OrderedN;

        [EventBasedMethod("OnNotifyPostSave_One_to_N_relations_OrderedN")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_One_to_N_relations_OrderedN != null) OnNotifyPostSave_One_to_N_relations_OrderedN(this);
        }
        public static event ObjectEventHandler<One_to_N_relations_OrderedN> OnNotifyPostSave_One_to_N_relations_OrderedN;

        [EventBasedMethod("OnNotifyCreated_One_to_N_relations_OrderedN")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Name");
            SetNotInitializedProperty("OneSide");
            base.NotifyCreated();
            if (OnNotifyCreated_One_to_N_relations_OrderedN != null) OnNotifyCreated_One_to_N_relations_OrderedN(this);
        }
        public static event ObjectEventHandler<One_to_N_relations_OrderedN> OnNotifyCreated_One_to_N_relations_OrderedN;

        [EventBasedMethod("OnNotifyDeleting_One_to_N_relations_OrderedN")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_One_to_N_relations_OrderedN != null) OnNotifyDeleting_One_to_N_relations_OrderedN(this);

            // FK_OneSide_connectsTo_OrderedNSide
            if (OneSide != null) {
                ((NHibernatePersistenceObject)OneSide).ChildrenToDelete.Add(this);
                ParentsToDelete.Add((NHibernatePersistenceObject)OneSide);
            }

            OneSide = null;
        }
        public static event ObjectEventHandler<One_to_N_relations_OrderedN> OnNotifyDeleting_One_to_N_relations_OrderedN;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class One_to_N_relations_OrderedNProxy
            : IProxyObject, ISortKey<int>
        {
            public One_to_N_relations_OrderedNProxy()
            {
            }

            public virtual int ID { get; set; }

            public virtual Type ZetboxWrapper { get { return typeof(One_to_N_relations_OrderedNNHibernateImpl); } }
            public virtual Type ZetboxProxy { get { return typeof(One_to_N_relations_OrderedNProxy); } }

            public virtual string Name { get; set; }

            public virtual Zetbox.App.Test.One_to_N_relations_OneNHibernateImpl.One_to_N_relations_OneProxy OneSide { get; set; }

            public virtual int? OrderedNSide_pos { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.Name);
            binStream.Write(this.Proxy.OneSide != null ? OurContext.GetIdFromProxy(this.Proxy.OneSide) : (int?)null);
            binStream.Write(this.Proxy.OrderedNSide_pos);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this.Proxy.Name = binStream.ReadString();
            binStream.Read(out this._fk_OneSide);
            this.Proxy.OrderedNSide_pos = binStream.ReadNullableInt32();
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