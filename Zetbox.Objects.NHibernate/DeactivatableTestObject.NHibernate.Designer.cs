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
    [System.Diagnostics.DebuggerDisplay("DeactivatableTestObject")]
    public class DeactivatableTestObjectNHibernateImpl : Zetbox.DalProvider.NHibernate.DataObjectNHibernateImpl, DeactivatableTestObject
    {
        private static readonly Guid _objectClassID = new Guid("12e49195-6ff4-49cd-b3a9-37f7bc350a5e");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public DeactivatableTestObjectNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public DeactivatableTestObjectNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new DeactivatableTestObjectProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public DeactivatableTestObjectNHibernateImpl(Func<IFrozenContext> lazyCtx, DeactivatableTestObjectProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
            _isIsDeactivatedSet = Proxy.ID > 0;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly DeactivatableTestObjectProxy Proxy;

        /// <summary>
        /// If true, the item will be hidden in any search
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public bool IsDeactivated
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = FetchIsDeactivatedOrDefault();
                if (OnIsDeactivated_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnIsDeactivated_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isIsDeactivatedSet = true;
                if (Proxy.IsDeactivated != value)
                {
                    var __oldValue = Proxy.IsDeactivated;
                    var __newValue = value;
                    if (OnIsDeactivated_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsDeactivated_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IsDeactivated", __oldValue, __newValue);
                    Proxy.IsDeactivated = __newValue;
                    NotifyPropertyChanged("IsDeactivated", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnIsDeactivated_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsDeactivated_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("IsDeactivated");
                }
            }
        }


        private bool FetchIsDeactivatedOrDefault()
        {
            var __result = Proxy.IsDeactivated;
                if (!_isIsDeactivatedSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("1d4f8d1c-e09e-47fa-a05f-2c1eb224ff16"));
                    if (__p != null) {
                        _isIsDeactivatedSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this.Proxy.IsDeactivated = (bool)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'Zetbox.App.Test.DeactivatableTestObject.IsDeactivated'");
                    }
                }
            return __result;
        }

        private bool _isIsDeactivatedSet = false;
        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.DeactivatableTestObject, bool> OnIsDeactivated_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.DeactivatableTestObject, bool> OnIsDeactivated_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.DeactivatableTestObject, bool> OnIsDeactivated_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.DeactivatableTestObject> OnIsDeactivated_IsValid;

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
		public static event PropertyGetterHandler<Zetbox.App.Test.DeactivatableTestObject, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.DeactivatableTestObject, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.DeactivatableTestObject, string> OnName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.DeactivatableTestObject> OnName_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(DeactivatableTestObject);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (DeactivatableTestObject)obj;
            var otherImpl = (DeactivatableTestObjectNHibernateImpl)obj;
            var me = (DeactivatableTestObject)this;

            me.IsDeactivated = other.IsDeactivated;
            me.Name = other.Name;
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
                case "IsDeactivated":
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
                    // else
                    new PropertyDescriptorNHibernateImpl<DeactivatableTestObject, bool>(
                        lazyCtx,
                        new Guid("1d4f8d1c-e09e-47fa-a05f-2c1eb224ff16"),
                        "IsDeactivated",
                        null,
                        obj => obj.IsDeactivated,
                        (obj, val) => obj.IsDeactivated = val,
						obj => OnIsDeactivated_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<DeactivatableTestObject, string>(
                        lazyCtx,
                        new Guid("c1a18acc-68e5-4df8-a7ed-58dc3eeb2e80"),
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
        [EventBasedMethod("OnToString_DeactivatableTestObject")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DeactivatableTestObject != null)
            {
                OnToString_DeactivatableTestObject(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<DeactivatableTestObject> OnToString_DeactivatableTestObject;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_DeactivatableTestObject")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_DeactivatableTestObject != null)
            {
                OnObjectIsValid_DeactivatableTestObject(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<DeactivatableTestObject> OnObjectIsValid_DeactivatableTestObject;

        [EventBasedMethod("OnNotifyPreSave_DeactivatableTestObject")]
        public override void NotifyPreSave()
        {
            FetchIsDeactivatedOrDefault();
            base.NotifyPreSave();
            if (OnNotifyPreSave_DeactivatableTestObject != null) OnNotifyPreSave_DeactivatableTestObject(this);
        }
        public static event ObjectEventHandler<DeactivatableTestObject> OnNotifyPreSave_DeactivatableTestObject;

        [EventBasedMethod("OnNotifyPostSave_DeactivatableTestObject")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_DeactivatableTestObject != null) OnNotifyPostSave_DeactivatableTestObject(this);
        }
        public static event ObjectEventHandler<DeactivatableTestObject> OnNotifyPostSave_DeactivatableTestObject;

        [EventBasedMethod("OnNotifyCreated_DeactivatableTestObject")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Name");
            base.NotifyCreated();
            if (OnNotifyCreated_DeactivatableTestObject != null) OnNotifyCreated_DeactivatableTestObject(this);
        }
        public static event ObjectEventHandler<DeactivatableTestObject> OnNotifyCreated_DeactivatableTestObject;

        [EventBasedMethod("OnNotifyDeleting_DeactivatableTestObject")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_DeactivatableTestObject != null) OnNotifyDeleting_DeactivatableTestObject(this);


        }
        public static event ObjectEventHandler<DeactivatableTestObject> OnNotifyDeleting_DeactivatableTestObject;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class DeactivatableTestObjectProxy
            : IProxyObject, ISortKey<int>
        {
            public DeactivatableTestObjectProxy()
            {
            }

            public virtual int ID { get; set; }

            public virtual Type ZetboxWrapper { get { return typeof(DeactivatableTestObjectNHibernateImpl); } }
            public virtual Type ZetboxProxy { get { return typeof(DeactivatableTestObjectProxy); } }

            public virtual bool IsDeactivated { get; set; }

            public virtual string Name { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._isIsDeactivatedSet);
            if (this._isIsDeactivatedSet) {
                binStream.Write(this.Proxy.IsDeactivated);
            }
            binStream.Write(this.Proxy.Name);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._isIsDeactivatedSet = binStream.ReadBoolean();
            if (this._isIsDeactivatedSet) {
                this.Proxy.IsDeactivated = binStream.ReadBoolean();
            }
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