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
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("EventTestObject")]
    public class EventTestObjectNHibernateImpl : Zetbox.DalProvider.NHibernate.DataObjectNHibernateImpl, EventTestObject
    {
        private static readonly Guid _objectClassID = new Guid("1be8e748-c714-42f9-aeb1-c9f180b2f126");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public EventTestObjectNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public EventTestObjectNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new EventTestObjectProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public EventTestObjectNHibernateImpl(Func<IFrozenContext> lazyCtx, EventTestObjectProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly EventTestObjectProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Event
        // fkBackingName=this.Proxy.Event; fkGuidBackingName=_fk_guid_Event;
        // referencedInterface=Zetbox.App.Calendar.Event; moduleNamespace=Zetbox.App.Test;
        // no inverse navigator handling
        // PositionStorage=none;
        // Target not exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
		[System.Runtime.Serialization.IgnoreDataMember]
        public Zetbox.App.Calendar.Event Event
        {
            get
            {
                Zetbox.App.Calendar.EventNHibernateImpl __value = (Zetbox.App.Calendar.EventNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Event);

                if (OnEvent_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Calendar.Event>(__value);
                    OnEvent_Getter(this, e);
                    __value = (Zetbox.App.Calendar.EventNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.Event == null)
                {
                    SetInitializedProperty("Event");
                    return;
                }

                // cache old value to remove inverse references later
                var __oldValue = (Zetbox.App.Calendar.EventNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Event);
                var __newValue = (Zetbox.App.Calendar.EventNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
                {
                    SetInitializedProperty("Event");
                    return;
                }

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Event", __oldValue, __newValue);

                if (OnEvent_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Calendar.Event>(__oldValue, __newValue);
                    OnEvent_PreSetter(this, e);
                    __newValue = (Zetbox.App.Calendar.EventNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.Event = null;
                }
                else
                {
                    this.Proxy.Event = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Event", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;

                if (OnEvent_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Calendar.Event>(__oldValue, __newValue);
                    OnEvent_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for Event's id, used on dehydration only</summary>
        private int? _fk_Event = null;

        /// <summary>ForeignKey Property for Event's id, used on APIs only</summary>
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int? FK_Event
		{
			get { return Event != null ? Event.ID : (int?)null; }
			set { _fk_Event = value; }
		}


    public Zetbox.API.Async.ZbTask TriggerFetchEventAsync()
    {
        return new Zetbox.API.Async.ZbTask<Zetbox.App.Calendar.Event>(this.Event);
    }

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Event
		public static event PropertyGetterHandler<Zetbox.App.Test.EventTestObject, Zetbox.App.Calendar.Event> OnEvent_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.EventTestObject, Zetbox.App.Calendar.Event> OnEvent_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.EventTestObject, Zetbox.App.Calendar.Event> OnEvent_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.EventTestObject> OnEvent_IsValid;

        /// <summary>
        /// 
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
		public static event PropertyGetterHandler<Zetbox.App.Test.EventTestObject, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.EventTestObject, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.EventTestObject, string> OnName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.EventTestObject> OnName_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(EventTestObject);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (EventTestObject)obj;
            var otherImpl = (EventTestObjectNHibernateImpl)obj;
            var me = (EventTestObject)this;

            me.Name = other.Name;
            this._fk_Event = otherImpl._fk_Event;
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "Event":
                    {
                        var __oldValue = (Zetbox.App.Calendar.EventNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Event);
                        var __newValue = (Zetbox.App.Calendar.EventNHibernateImpl)parentObj;
                        NotifyPropertyChanging("Event", __oldValue, __newValue);
                        this.Proxy.Event = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("Event", __oldValue, __newValue);
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
                case "Event":
                case "Name":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }
        #endregion // Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        public override Zetbox.API.Async.ZbTask TriggerFetch(string propName)
        {
            switch(propName)
            {
            case "Event":
                return TriggerFetchEventAsync();
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

            if (_fk_Event.HasValue)
                this.Event = ((Zetbox.App.Calendar.EventNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.Calendar.Event>(_fk_Event.Value));
            else
                this.Event = null;
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
                    new PropertyDescriptorNHibernateImpl<EventTestObject, Zetbox.App.Calendar.Event>(
                        lazyCtx,
                        new Guid("adf59fe9-12fe-413e-8dc7-d9190aa6bf13"),
                        "Event",
                        null,
                        obj => obj.Event,
                        (obj, val) => obj.Event = val,
						obj => OnEvent_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<EventTestObject, string>(
                        lazyCtx,
                        new Guid("57f6c265-b768-40e8-b546-bd410439d354"),
                        "Name",
                        null,
                        obj => obj.Name,
                        (obj, val) => obj.Name = val,
						obj => OnName_IsValid), 
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
        [EventBasedMethod("OnToString_EventTestObject")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_EventTestObject != null)
            {
                OnToString_EventTestObject(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<EventTestObject> OnToString_EventTestObject;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_EventTestObject")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_EventTestObject != null)
            {
                OnObjectIsValid_EventTestObject(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<EventTestObject> OnObjectIsValid_EventTestObject;

        [EventBasedMethod("OnNotifyPreSave_EventTestObject")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_EventTestObject != null) OnNotifyPreSave_EventTestObject(this);
        }
        public static event ObjectEventHandler<EventTestObject> OnNotifyPreSave_EventTestObject;

        [EventBasedMethod("OnNotifyPostSave_EventTestObject")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_EventTestObject != null) OnNotifyPostSave_EventTestObject(this);
        }
        public static event ObjectEventHandler<EventTestObject> OnNotifyPostSave_EventTestObject;

        [EventBasedMethod("OnNotifyCreated_EventTestObject")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Event");
            SetNotInitializedProperty("Name");
            base.NotifyCreated();
            if (OnNotifyCreated_EventTestObject != null) OnNotifyCreated_EventTestObject(this);
        }
        public static event ObjectEventHandler<EventTestObject> OnNotifyCreated_EventTestObject;

        [EventBasedMethod("OnNotifyDeleting_EventTestObject")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_EventTestObject != null) OnNotifyDeleting_EventTestObject(this);

            // FK_Test_of_Event
            if (Event != null) {
                ((NHibernatePersistenceObject)Event).ChildrenToDelete.Add(this);
                ParentsToDelete.Add((NHibernatePersistenceObject)Event);
            }

            Event = null;
        }
        public static event ObjectEventHandler<EventTestObject> OnNotifyDeleting_EventTestObject;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class EventTestObjectProxy
            : IProxyObject, ISortKey<int>
        {
            public EventTestObjectProxy()
            {
            }

            public virtual int ID { get; set; }

            public virtual Type ZetboxWrapper { get { return typeof(EventTestObjectNHibernateImpl); } }
            public virtual Type ZetboxProxy { get { return typeof(EventTestObjectProxy); } }

            public virtual Zetbox.App.Calendar.EventNHibernateImpl.EventProxy Event { get; set; }

            public virtual string Name { get; set; }


			[System.Runtime.Serialization.IgnoreDataMember]
			int ISortKey<int>.InternalSortKey { get { return ID; } }
        }

        // make proxy available for the provider
        [System.Runtime.Serialization.IgnoreDataMember]
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.Event != null ? OurContext.GetIdFromProxy(this.Proxy.Event) : (int?)null);
            binStream.Write(this.Proxy.Name);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            binStream.Read(out this._fk_Event);
            this.Proxy.Name = binStream.ReadString();
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