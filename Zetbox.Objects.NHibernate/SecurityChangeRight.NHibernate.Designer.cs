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
    /// Test if a user has only change rights
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("SecurityChangeRight")]
    public class SecurityChangeRightNHibernateImpl : Zetbox.DalProvider.NHibernate.DataObjectNHibernateImpl, SecurityChangeRight
    {
        private static readonly Guid _objectClassID = new Guid("76098519-a5b2-42fb-b3a8-19a4779f8122");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public SecurityChangeRightNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public SecurityChangeRightNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new SecurityChangeRightProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public SecurityChangeRightNHibernateImpl(Func<IFrozenContext> lazyCtx, SecurityChangeRightProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly SecurityChangeRightProxy Proxy;

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
		public static event PropertyGetterHandler<Zetbox.App.Test.SecurityChangeRight, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.SecurityChangeRight, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.SecurityChangeRight, string> OnName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.SecurityChangeRight> OnName_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(SecurityChangeRight);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (SecurityChangeRight)obj;
            var otherImpl = (SecurityChangeRightNHibernateImpl)obj;
            var me = (SecurityChangeRight)this;

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
                    new PropertyDescriptorNHibernateImpl<SecurityChangeRight, string>(
                        lazyCtx,
                        new Guid("99a5dc49-9fe5-4b51-b0a4-0b0fe3e2e654"),
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
        [EventBasedMethod("OnToString_SecurityChangeRight")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_SecurityChangeRight != null)
            {
                OnToString_SecurityChangeRight(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<SecurityChangeRight> OnToString_SecurityChangeRight;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_SecurityChangeRight")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_SecurityChangeRight != null)
            {
                OnObjectIsValid_SecurityChangeRight(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<SecurityChangeRight> OnObjectIsValid_SecurityChangeRight;

        [EventBasedMethod("OnNotifyPreSave_SecurityChangeRight")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_SecurityChangeRight != null) OnNotifyPreSave_SecurityChangeRight(this);
        }
        public static event ObjectEventHandler<SecurityChangeRight> OnNotifyPreSave_SecurityChangeRight;

        [EventBasedMethod("OnNotifyPostSave_SecurityChangeRight")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_SecurityChangeRight != null) OnNotifyPostSave_SecurityChangeRight(this);
        }
        public static event ObjectEventHandler<SecurityChangeRight> OnNotifyPostSave_SecurityChangeRight;

        [EventBasedMethod("OnNotifyCreated_SecurityChangeRight")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Name");
            base.NotifyCreated();
            if (OnNotifyCreated_SecurityChangeRight != null) OnNotifyCreated_SecurityChangeRight(this);
        }
        public static event ObjectEventHandler<SecurityChangeRight> OnNotifyCreated_SecurityChangeRight;

        [EventBasedMethod("OnNotifyDeleting_SecurityChangeRight")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_SecurityChangeRight != null) OnNotifyDeleting_SecurityChangeRight(this);


        }
        public static event ObjectEventHandler<SecurityChangeRight> OnNotifyDeleting_SecurityChangeRight;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class SecurityChangeRightProxy
            : IProxyObject, ISortKey<int>
        {
            public SecurityChangeRightProxy()
            {
            }

            public virtual int ID { get; set; }

            public virtual Type ZetboxWrapper { get { return typeof(SecurityChangeRightNHibernateImpl); } }
            public virtual Type ZetboxProxy { get { return typeof(SecurityChangeRightProxy); } }

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
            binStream.Write(this.Proxy.Name);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
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