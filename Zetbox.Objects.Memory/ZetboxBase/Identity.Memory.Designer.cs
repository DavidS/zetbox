// <autogenerated/>

namespace Zetbox.App.Base
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

    using Zetbox.DalProvider.Base;
    using Zetbox.DalProvider.Memory;

    /// <summary>
    /// Represents an Identity
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("Identity")]
    public class IdentityMemoryImpl : Zetbox.DalProvider.Memory.DataObjectMemoryImpl, Identity
    {
        private static readonly Guid _objectClassID = new Guid("31d8890a-67fc-4a78-9d35-9ff0b9e09b4c");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public IdentityMemoryImpl()
            : base(null)
        {
            OpenIDImpl = new Zetbox.App.Base.OpenIDMemoryImpl(null, this, "OpenID");
        }

        public IdentityMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
            OpenIDImpl = new Zetbox.App.Base.OpenIDMemoryImpl(lazyCtx, this, "OpenID");
        }

        /// <summary>
        /// Storage for the users calendar configuration
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public string CalendarConfiguration
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _CalendarConfiguration;
                if (OnCalendarConfiguration_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnCalendarConfiguration_Getter(this, __e);
                    __result = _CalendarConfiguration = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_CalendarConfiguration != value)
                {
                    var __oldValue = _CalendarConfiguration;
                    var __newValue = value;
                    if (OnCalendarConfiguration_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnCalendarConfiguration_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("CalendarConfiguration", __oldValue, __newValue);
                    _CalendarConfiguration = __newValue;
                    NotifyPropertyChanged("CalendarConfiguration", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnCalendarConfiguration_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnCalendarConfiguration_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("CalendarConfiguration");
                }
            }
        }
        private string _CalendarConfiguration;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.Identity, string> OnCalendarConfiguration_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.Identity, string> OnCalendarConfiguration_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.Identity, string> OnCalendarConfiguration_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.Identity> OnCalendarConfiguration_IsValid;

        /// <summary>
        /// Displayname of this identity
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public string DisplayName
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _DisplayName;
                if (OnDisplayName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnDisplayName_Getter(this, __e);
                    __result = _DisplayName = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_DisplayName != value)
                {
                    var __oldValue = _DisplayName;
                    var __newValue = value;
                    if (OnDisplayName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnDisplayName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("DisplayName", __oldValue, __newValue);
                    _DisplayName = __newValue;
                    NotifyPropertyChanged("DisplayName", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnDisplayName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnDisplayName_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("DisplayName");
                }
            }
        }
        private string _DisplayName;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.Identity, string> OnDisplayName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.Identity, string> OnDisplayName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.Identity, string> OnDisplayName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.Identity> OnDisplayName_IsValid;

        /// <summary>
        /// Identites are member of groups
        /// </summary>
        // collection entry list property
        // BEGIN Zetbox.Generator.Templates.Properties.CollectionEntryListProperty for Groups
        public ICollection<Zetbox.App.Base.Group> Groups
        {
            get
            {
                if (_Groups == null)
                {
                    TriggerFetchGroupsAsync().Wait();
                }
                return (ICollection<Zetbox.App.Base.Group>)_Groups;
            }
        }

        Zetbox.API.Async.ZbTask _triggerFetchGroupsTask;
        public Zetbox.API.Async.ZbTask TriggerFetchGroupsAsync()
        {
            if (_triggerFetchGroupsTask != null) return _triggerFetchGroupsTask;
            _triggerFetchGroupsTask = Context.FetchRelationAsync<Zetbox.App.Base.Identity_memberOf_Group_RelationEntryMemoryImpl>(new Guid("3efb7ae8-ba6b-40e3-9482-b45d1c101743"), RelationEndRole.A, this);
            _triggerFetchGroupsTask.OnResult(r =>
            {
                _Groups
                    = new ObservableBSideCollectionWrapper<Zetbox.App.Base.Identity, Zetbox.App.Base.Group, Zetbox.App.Base.Identity_memberOf_Group_RelationEntryMemoryImpl, ICollection<Zetbox.App.Base.Identity_memberOf_Group_RelationEntryMemoryImpl>>(
                        this,
                        new RelationshipFilterASideCollection<Zetbox.App.Base.Identity_memberOf_Group_RelationEntryMemoryImpl>(this.Context, this));
                        // _Groups.CollectionChanged is managed by OnGroupsCollectionChanged() and called from the RelationEntry
            });
            return _triggerFetchGroupsTask;
        }

        internal void OnGroupsCollectionChanged()
        {
            NotifyPropertyChanged("Groups", null, null);
            if (OnGroups_PostSetter != null && IsAttached)
                OnGroups_PostSetter(this);
        }

        private ObservableBSideCollectionWrapper<Zetbox.App.Base.Identity, Zetbox.App.Base.Group, Zetbox.App.Base.Identity_memberOf_Group_RelationEntryMemoryImpl, ICollection<Zetbox.App.Base.Identity_memberOf_Group_RelationEntryMemoryImpl>> _Groups;
        // END Zetbox.Generator.Templates.Properties.CollectionEntryListProperty for Groups
public static event PropertyListChangedHandler<Zetbox.App.Base.Identity> OnGroups_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.Identity> OnGroups_IsValid;

        /// <summary>
        /// Optional Open Id
        /// </summary>
        // CompoundObject property
        // BEGIN Zetbox.Generator.Templates.Properties.CompoundObjectPropertyTemplate
        // implement the user-visible interface
        // BEGIN Zetbox.Generator.Templates.Properties.DelegatingProperty
        public Zetbox.App.Base.OpenID OpenID
        {
            get { return OpenIDImpl; }
            set { OpenIDImpl = (Zetbox.App.Base.OpenIDMemoryImpl)value; }
        }
        // END Zetbox.Generator.Templates.Properties.DelegatingProperty

        /// <summary>backing store for OpenID</summary>
        private Zetbox.App.Base.OpenIDMemoryImpl _OpenID;

        /// <summary>backing property for OpenID, takes care of attaching/detaching the values</summary>
        public Zetbox.App.Base.OpenIDMemoryImpl OpenIDImpl
        {
            get
            {
                return _OpenID;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value == null)
                    throw new ArgumentNullException("value");
                if (!object.Equals(_OpenID, value))
                {
                    var __oldValue = _OpenID;
                    var __newValue = value;

                    NotifyPropertyChanging("OpenID", __oldValue, __newValue);

                    if (_OpenID != null)
                    {
                        _OpenID.DetachFromObject(this, "OpenID");
                    }
                    __newValue = (Zetbox.App.Base.OpenIDMemoryImpl)__newValue.Clone();
                    _OpenID = __newValue;
                    _OpenID.AttachToObject(this, "OpenID");

                    NotifyPropertyChanged("OpenID", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;
                }
            }
        }
        // END Zetbox.Generator.Templates.Properties.CompoundObjectPropertyTemplate
        public static event PropertyIsValidHandler<Zetbox.App.Base.Identity> OnOpenID_IsValid;

        /// <summary>
        /// Password of a generic identity
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public string Password
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Password;
                if (OnPassword_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnPassword_Getter(this, __e);
                    __result = _Password = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Password != value)
                {
                    var __oldValue = _Password;
                    var __newValue = value;
                    if (OnPassword_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnPassword_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Password", __oldValue, __newValue);
                    _Password = __newValue;
                    NotifyPropertyChanged("Password", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnPassword_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnPassword_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("Password");
                }
            }
        }
        private string _Password;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.Identity, string> OnPassword_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.Identity, string> OnPassword_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.Identity, string> OnPassword_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.Identity> OnPassword_IsValid;

        /// <summary>
        /// Username of a generic identity
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public string UserName
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _UserName;
                if (OnUserName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnUserName_Getter(this, __e);
                    __result = _UserName = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_UserName != value)
                {
                    var __oldValue = _UserName;
                    var __newValue = value;
                    if (OnUserName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnUserName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("UserName", __oldValue, __newValue);
                    _UserName = __newValue;
                    NotifyPropertyChanged("UserName", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnUserName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnUserName_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("UserName");
                }
            }
        }
        private string _UserName;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.Identity, string> OnUserName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.Identity, string> OnUserName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.Identity, string> OnUserName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.Identity> OnUserName_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(Identity);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (Identity)obj;
            var otherImpl = (IdentityMemoryImpl)obj;
            var me = (Identity)this;

            me.CalendarConfiguration = other.CalendarConfiguration;
            me.DisplayName = other.DisplayName;
            me.Password = other.Password;
            me.UserName = other.UserName;
            if (me.OpenID == null && other.OpenID != null) {
                me.OpenID = (Zetbox.App.Base.OpenID)other.OpenID.Clone();
            } else if (me.OpenID != null && other.OpenID == null) {
                me.OpenID = null;
            } else if (me.OpenID != null && other.OpenID != null) {
                me.OpenID.ApplyChangesFrom(other.OpenID);
            }
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
                case "CalendarConfiguration":
                case "DisplayName":
                case "OpenID":
                case "Password":
                case "UserName":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }

        protected override bool ShouldSetModified(string property)
        {
            switch (property)
            {
                case "Groups":
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
            case "Groups":
                return TriggerFetchGroupsAsync();
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
                    new PropertyDescriptorMemoryImpl<Identity, string>(
                        lazyCtx,
                        new Guid("733a16fe-b741-4e7e-9b52-f306c6e1f559"),
                        "CalendarConfiguration",
                        null,
                        obj => obj.CalendarConfiguration,
                        (obj, val) => obj.CalendarConfiguration = val,
						obj => OnCalendarConfiguration_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<Identity, string>(
                        lazyCtx,
                        new Guid("f93e6dbb-a704-460c-8183-ce8b1c2c47a2"),
                        "DisplayName",
                        null,
                        obj => obj.DisplayName,
                        (obj, val) => obj.DisplayName = val,
						obj => OnDisplayName_IsValid), 
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorMemoryImpl<Identity, ICollection<Zetbox.App.Base.Group>>(
                        lazyCtx,
                        new Guid("5f534204-f0d5-4d6f-8efa-7ff248580ba3"),
                        "Groups",
                        null,
                        obj => obj.Groups,
                        null, // lists are read-only properties
                        obj => OnGroups_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<Identity, Zetbox.App.Base.OpenID>(
                        lazyCtx,
                        new Guid("9e5b1327-cb22-4442-a4b4-6cf6083e88a2"),
                        "OpenID",
                        null,
                        obj => obj.OpenID,
                        (obj, val) => obj.OpenID = val,
						obj => OnOpenID_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<Identity, string>(
                        lazyCtx,
                        new Guid("0d499610-99e3-42cc-b71b-49ed1a356355"),
                        "Password",
                        null,
                        obj => obj.Password,
                        (obj, val) => obj.Password = val,
						obj => OnPassword_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<Identity, string>(
                        lazyCtx,
                        new Guid("a4ce1f5f-311b-4510-8817-4cca40f0bf0f"),
                        "UserName",
                        null,
                        obj => obj.UserName,
                        (obj, val) => obj.UserName = val,
						obj => OnUserName_IsValid), 
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
        [EventBasedMethod("OnToString_Identity")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Identity != null)
            {
                OnToString_Identity(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<Identity> OnToString_Identity;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_Identity")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_Identity != null)
            {
                OnObjectIsValid_Identity(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<Identity> OnObjectIsValid_Identity;

        [EventBasedMethod("OnNotifyPreSave_Identity")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_Identity != null) OnNotifyPreSave_Identity(this);
        }
        public static event ObjectEventHandler<Identity> OnNotifyPreSave_Identity;

        [EventBasedMethod("OnNotifyPostSave_Identity")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_Identity != null) OnNotifyPostSave_Identity(this);
        }
        public static event ObjectEventHandler<Identity> OnNotifyPostSave_Identity;

        [EventBasedMethod("OnNotifyCreated_Identity")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("CalendarConfiguration");
            SetNotInitializedProperty("DisplayName");
            SetNotInitializedProperty("Password");
            SetNotInitializedProperty("UserName");
            base.NotifyCreated();
            if (OnNotifyCreated_Identity != null) OnNotifyCreated_Identity(this);
        }
        public static event ObjectEventHandler<Identity> OnNotifyCreated_Identity;

        [EventBasedMethod("OnNotifyDeleting_Identity")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_Identity != null) OnNotifyDeleting_Identity(this);
            Groups.Clear();
        }
        public static event ObjectEventHandler<Identity> OnNotifyDeleting_Identity;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._CalendarConfiguration);
            binStream.Write(this._DisplayName);
            binStream.Write(this.OpenID);
            binStream.Write(this._Password);
            binStream.Write(this._UserName);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._CalendarConfiguration = binStream.ReadString();
            this._DisplayName = binStream.ReadString();
            {
                // use backing store to avoid notifications
                this.OpenIDImpl = binStream.ReadCompoundObject<Zetbox.App.Base.OpenIDMemoryImpl>();
                this.OpenIDImpl.AttachToObject(this, "OpenID");
            }
            this._Password = binStream.ReadString();
            this._UserName = binStream.ReadString();
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