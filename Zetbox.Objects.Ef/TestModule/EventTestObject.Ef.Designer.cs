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

    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Zetbox.API.Server;
    using Zetbox.DalProvider.Ef;

    /// <summary>
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="EventTestObjectEfImpl")]
    [System.Diagnostics.DebuggerDisplay("EventTestObject")]
    public class EventTestObjectEfImpl : BaseServerDataObject_EntityFramework, EventTestObject
    {
        private static readonly Guid _objectClassID = new Guid("1be8e748-c714-42f9-aeb1-c9f180b2f126");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public EventTestObjectEfImpl()
            : base(null)
        {
        }

        public EventTestObjectEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Test_of_Event
    A: ZeroOrMore EventTestObject as Test
    B: One Event as Event
    Preferred Storage: MergeIntoA
    */
        // object reference property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Event
        // fkBackingName=_fk_Event; fkGuidBackingName=_fk_guid_Event;
        // referencedInterface=Zetbox.App.Calendar.Event; moduleNamespace=Zetbox.App.Test;
        // no inverse navigator handling
        // PositionStorage=none;
        // Target not exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Calendar.Event Event
        {
            get { return EventImpl; }
            set { EventImpl = (Zetbox.App.Calendar.EventEfImpl)value; }
        }

        private int? _fk_Event;


        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Test_of_Event", "Event")]
        public Zetbox.App.Calendar.EventEfImpl EventImpl
        {
            get
            {
                Zetbox.App.Calendar.EventEfImpl __value;
                EntityReference<Zetbox.App.Calendar.EventEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.Calendar.EventEfImpl>(
                        "Model.FK_Test_of_Event",
                        "Event");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                __value = r.Value;
                if (OnEvent_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Calendar.Event>(__value);
                    OnEvent_Getter(this, e);
                    __value = (Zetbox.App.Calendar.EventEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                EntityReference<Zetbox.App.Calendar.EventEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.Calendar.EventEfImpl>(
                        "Model.FK_Test_of_Event",
                        "Event");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Zetbox.App.Calendar.EventEfImpl __oldValue = (Zetbox.App.Calendar.EventEfImpl)r.Value;
                Zetbox.App.Calendar.EventEfImpl __newValue = (Zetbox.App.Calendar.EventEfImpl)value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Event", __oldValue, __newValue);

                if (OnEvent_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Calendar.Event>(__oldValue, __newValue);
                    OnEvent_PreSetter(this, e);
                    __newValue = (Zetbox.App.Calendar.EventEfImpl)e.Result;
                }

                r.Value = (Zetbox.App.Calendar.EventEfImpl)__newValue;

                if (OnEvent_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Calendar.Event>(__oldValue, __newValue);
                    OnEvent_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Event", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;
            }
        }

        public Zetbox.API.Async.ZbTask TriggerFetchEventAsync()
        {
            return new Zetbox.API.Async.ZbTask<Zetbox.App.Calendar.Event>(this.Event);
        }

        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Event
		public static event PropertyGetterHandler<Zetbox.App.Test.EventTestObject, Zetbox.App.Calendar.Event> OnEvent_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.EventTestObject, Zetbox.App.Calendar.Event> OnEvent_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.EventTestObject, Zetbox.App.Calendar.Event> OnEvent_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.EventTestObject> OnEvent_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public string Name
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Name;
                if (OnName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnName_Getter(this, __e);
                    __result = _Name = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Name != value)
                {
                    var __oldValue = _Name;
                    var __newValue = value;
                    if (OnName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Name", __oldValue, __newValue);
                    _Name = __newValue;
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
        private string _Name_store;
        private string _Name {
            get { return _Name_store; }
            set {
                ReportEfPropertyChanging("Name");
                _Name_store = value;
                ReportEfPropertyChanged("Name");
            }
        }
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
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
            var otherImpl = (EventTestObjectEfImpl)obj;
            var me = (EventTestObject)this;

            me.Name = other.Name;
            this._fk_Event = otherImpl._fk_Event;
        }
        public override void SetNew()
        {
            base.SetNew();
        }
        #region Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

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
        #endregion // Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

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
                EventImpl = (Zetbox.App.Calendar.EventEfImpl)Context.Find<Zetbox.App.Calendar.Event>(_fk_Event.Value);
            else
                EventImpl = null;
            // fix cached lists references
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
                    new PropertyDescriptorEfImpl<EventTestObject, Zetbox.App.Calendar.Event>(
                        lazyCtx,
                        new Guid("adf59fe9-12fe-413e-8dc7-d9190aa6bf13"),
                        "Event",
                        null,
                        obj => obj.Event,
                        (obj, val) => obj.Event = val,
						obj => OnEvent_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<EventTestObject, string>(
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
        #region Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

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
            Event = null;
        }
        public static event ObjectEventHandler<EventTestObject> OnNotifyDeleting_EventTestObject;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.IdProperty
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        public override int ID
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ID;
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_ID != value)
                {
                    var __oldValue = _ID;
                    var __newValue = value;
                    NotifyPropertyChanging("ID", __oldValue, __newValue);
                    _ID = __newValue;
                    NotifyPropertyChanged("ID", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                }
                else
                {
                    SetInitializedProperty("ID");
                }
            }
        }
        private int _ID;
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.IdProperty

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            {
                var r = this.RelationshipManager.GetRelatedReference<Zetbox.App.Calendar.EventEfImpl>("Model.FK_Test_of_Event", "Event");
                var key = r.EntityKey;
                binStream.Write(r.Value != null ? r.Value.ID : (key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null));
            }
            binStream.Write(this._Name);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            binStream.Read(out this._fk_Event);
            this._Name = binStream.ReadString();
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