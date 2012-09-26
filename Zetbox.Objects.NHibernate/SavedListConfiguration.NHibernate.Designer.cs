// <autogenerated/>

namespace Zetbox.App.GUI
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
    /// A configuration object for instance lists
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("SavedListConfiguration")]
    public class SavedListConfigurationNHibernateImpl : Zetbox.DalProvider.NHibernate.DataObjectNHibernateImpl, SavedListConfiguration, Zetbox.API.IExportableInternal
    {
        private static readonly Guid _objectClassID = new Guid("46da717e-b6e0-4193-8580-8787fc4cf04f");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public SavedListConfigurationNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public SavedListConfigurationNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new SavedListConfigurationProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public SavedListConfigurationNHibernateImpl(Func<IFrozenContext> lazyCtx, SavedListConfigurationProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
            _isExportGuidSet = Proxy.ID > 0;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly SavedListConfigurationProxy Proxy;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string Configuration
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Configuration;
                if (OnConfiguration_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnConfiguration_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Configuration != value)
                {
                    var __oldValue = Proxy.Configuration;
                    var __newValue = value;
                    if (OnConfiguration_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnConfiguration_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Configuration", __oldValue, __newValue);
                    Proxy.Configuration = __newValue;
                    NotifyPropertyChanged("Configuration", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnConfiguration_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnConfiguration_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Configuration");
				}
            }
        }

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.GUI.SavedListConfiguration, string> OnConfiguration_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.SavedListConfiguration, string> OnConfiguration_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.SavedListConfiguration, string> OnConfiguration_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.SavedListConfiguration> OnConfiguration_IsValid;

        /// <summary>
        /// Export Guid
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public Guid ExportGuid
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = FetchExportGuidOrDefault();
                if (OnExportGuid_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<Guid>(__result);
                    OnExportGuid_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isExportGuidSet = true;
                if (Proxy.ExportGuid != value)
                {
                    var __oldValue = Proxy.ExportGuid;
                    var __newValue = value;
                    if (OnExportGuid_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ExportGuid", __oldValue, __newValue);
                    Proxy.ExportGuid = __newValue;
                    NotifyPropertyChanged("ExportGuid", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnExportGuid_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("ExportGuid");
				}
            }
        }


        private Guid FetchExportGuidOrDefault()
        {
            var __result = Proxy.ExportGuid;
                if (!_isExportGuidSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("98754493-0fcc-4874-adde-cbf27b7a53d2"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this.Proxy.ExportGuid = (Guid)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'Zetbox.App.GUI.SavedListConfiguration.ExportGuid'");
                    }
                }
            return __result;
        }

        private bool _isExportGuidSet = false;
        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.GUI.SavedListConfiguration, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.SavedListConfiguration, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.SavedListConfiguration, Guid> OnExportGuid_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.SavedListConfiguration> OnExportGuid_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Owner
        // fkBackingName=this.Proxy.Owner; fkGuidBackingName=_fk_guid_Owner;
        // referencedInterface=Zetbox.App.Base.Identity; moduleNamespace=Zetbox.App.GUI;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target not exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Base.Identity Owner
        {
            get
            {
                Zetbox.App.Base.IdentityNHibernateImpl __value = (Zetbox.App.Base.IdentityNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Owner);

                if (OnOwner_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.Identity>(__value);
                    OnOwner_Getter(this, e);
                    __value = (Zetbox.App.Base.IdentityNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.Owner == null)
				{
					SetInitializedProperty("Owner");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = (Zetbox.App.Base.IdentityNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Owner);
                var __newValue = (Zetbox.App.Base.IdentityNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
				{
					SetInitializedProperty("Owner");
                    return;
				}

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Owner", __oldValue, __newValue);

                if (OnOwner_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.Identity>(__oldValue, __newValue);
                    OnOwner_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.IdentityNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.Owner = null;
                }
                else
                {
                    this.Proxy.Owner = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Owner", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;

                if (OnOwner_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.Identity>(__oldValue, __newValue);
                    OnOwner_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for Owner's id, used on dehydration only</summary>
        private int? _fk_Owner = null;


        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Owner
		public static event PropertyGetterHandler<Zetbox.App.GUI.SavedListConfiguration, Zetbox.App.Base.Identity> OnOwner_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.SavedListConfiguration, Zetbox.App.Base.Identity> OnOwner_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.SavedListConfiguration, Zetbox.App.Base.Identity> OnOwner_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.SavedListConfiguration> OnOwner_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Type
        // fkBackingName=this.Proxy.Type; fkGuidBackingName=_fk_guid_Type;
        // referencedInterface=Zetbox.App.Base.ObjectClass; moduleNamespace=Zetbox.App.GUI;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Base.ObjectClass Type
        {
            get
            {
                Zetbox.App.Base.ObjectClassNHibernateImpl __value = (Zetbox.App.Base.ObjectClassNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Type);

                if (OnType_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.ObjectClass>(__value);
                    OnType_Getter(this, e);
                    __value = (Zetbox.App.Base.ObjectClassNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.Type == null)
				{
					SetInitializedProperty("Type");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = (Zetbox.App.Base.ObjectClassNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Type);
                var __newValue = (Zetbox.App.Base.ObjectClassNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
				{
					SetInitializedProperty("Type");
                    return;
				}

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Type", __oldValue, __newValue);

                if (OnType_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.ObjectClass>(__oldValue, __newValue);
                    OnType_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.ObjectClassNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.Type = null;
                }
                else
                {
                    this.Proxy.Type = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Type", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;

                if (OnType_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.ObjectClass>(__oldValue, __newValue);
                    OnType_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for Type's id, used on dehydration only</summary>
        private int? _fk_Type = null;

        /// <summary>Backing store for Type's guid, used on import only</summary>
        private Guid? _fk_guid_Type = null;

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Type
		public static event PropertyGetterHandler<Zetbox.App.GUI.SavedListConfiguration, Zetbox.App.Base.ObjectClass> OnType_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.SavedListConfiguration, Zetbox.App.Base.ObjectClass> OnType_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.SavedListConfiguration, Zetbox.App.Base.ObjectClass> OnType_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.SavedListConfiguration> OnType_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(SavedListConfiguration);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (SavedListConfiguration)obj;
            var otherImpl = (SavedListConfigurationNHibernateImpl)obj;
            var me = (SavedListConfiguration)this;

            me.Configuration = other.Configuration;
            me.ExportGuid = other.ExportGuid;
            this._fk_Owner = otherImpl._fk_Owner;
            this._fk_Type = otherImpl._fk_Type;
        }

        public override void AttachToContext(IZetboxContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "Owner":
                    {
                        var __oldValue = (Zetbox.App.Base.IdentityNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Owner);
                        var __newValue = (Zetbox.App.Base.IdentityNHibernateImpl)parentObj;
                        NotifyPropertyChanging("Owner", __oldValue, __newValue);
                        this.Proxy.Owner = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("Owner", __oldValue, __newValue);
                    }
                    break;
                case "Type":
                    {
                        var __oldValue = (Zetbox.App.Base.ObjectClassNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Type);
                        var __newValue = (Zetbox.App.Base.ObjectClassNHibernateImpl)parentObj;
                        NotifyPropertyChanging("Type", __oldValue, __newValue);
                        this.Proxy.Type = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("Type", __oldValue, __newValue);
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
                case "Configuration":
                case "ExportGuid":
                case "Owner":
                case "Type":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }
        #endregion // Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_Owner.HasValue)
                this.Owner = ((Zetbox.App.Base.IdentityNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.Base.Identity>(_fk_Owner.Value));
            else
                this.Owner = null;

            if (_fk_guid_Type.HasValue)
                this.Type = ((Zetbox.App.Base.ObjectClassNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.Base.ObjectClass>(_fk_guid_Type.Value));
            else
            if (_fk_Type.HasValue)
                this.Type = ((Zetbox.App.Base.ObjectClassNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.Base.ObjectClass>(_fk_Type.Value));
            else
                this.Type = null;
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
                    new PropertyDescriptorNHibernateImpl<SavedListConfiguration, string>(
                        lazyCtx,
                        new Guid("2063f89a-89c8-48de-b191-b6dd870072c3"),
                        "Configuration",
                        null,
                        obj => obj.Configuration,
                        (obj, val) => obj.Configuration = val,
						obj => OnConfiguration_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<SavedListConfiguration, Guid>(
                        lazyCtx,
                        new Guid("98754493-0fcc-4874-adde-cbf27b7a53d2"),
                        "ExportGuid",
                        null,
                        obj => obj.ExportGuid,
                        (obj, val) => obj.ExportGuid = val,
						obj => OnExportGuid_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<SavedListConfiguration, Zetbox.App.Base.Identity>(
                        lazyCtx,
                        new Guid("776c6c41-d42d-43d0-bff4-e99638a045bf"),
                        "Owner",
                        null,
                        obj => obj.Owner,
                        (obj, val) => obj.Owner = val,
						obj => OnOwner_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<SavedListConfiguration, Zetbox.App.Base.ObjectClass>(
                        lazyCtx,
                        new Guid("93775971-e361-4495-8107-3398205589ec"),
                        "Type",
                        null,
                        obj => obj.Type,
                        (obj, val) => obj.Type = val,
						obj => OnType_IsValid), 
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
        [EventBasedMethod("OnToString_SavedListConfiguration")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_SavedListConfiguration != null)
            {
                OnToString_SavedListConfiguration(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<SavedListConfiguration> OnToString_SavedListConfiguration;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_SavedListConfiguration")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_SavedListConfiguration != null)
            {
                OnObjectIsValid_SavedListConfiguration(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<SavedListConfiguration> OnObjectIsValid_SavedListConfiguration;

        [EventBasedMethod("OnNotifyPreSave_SavedListConfiguration")]
        public override void NotifyPreSave()
        {
            FetchExportGuidOrDefault();
            base.NotifyPreSave();
            if (OnNotifyPreSave_SavedListConfiguration != null) OnNotifyPreSave_SavedListConfiguration(this);
        }
        public static event ObjectEventHandler<SavedListConfiguration> OnNotifyPreSave_SavedListConfiguration;

        [EventBasedMethod("OnNotifyPostSave_SavedListConfiguration")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_SavedListConfiguration != null) OnNotifyPostSave_SavedListConfiguration(this);
        }
        public static event ObjectEventHandler<SavedListConfiguration> OnNotifyPostSave_SavedListConfiguration;

        [EventBasedMethod("OnNotifyCreated_SavedListConfiguration")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Configuration");
            SetNotInitializedProperty("Owner");
            SetNotInitializedProperty("Type");
            base.NotifyCreated();
            if (OnNotifyCreated_SavedListConfiguration != null) OnNotifyCreated_SavedListConfiguration(this);
        }
        public static event ObjectEventHandler<SavedListConfiguration> OnNotifyCreated_SavedListConfiguration;

        [EventBasedMethod("OnNotifyDeleting_SavedListConfiguration")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_SavedListConfiguration != null) OnNotifyDeleting_SavedListConfiguration(this);

            // FK_LstCfg_has_Type
            if (Type != null) {
                ((NHibernatePersistenceObject)Type).ChildrenToDelete.Add(this);
                ParentsToDelete.Add((NHibernatePersistenceObject)Type);
            }
            // FK_LstCfg_of_Owner
            if (Owner != null) {
                ((NHibernatePersistenceObject)Owner).ChildrenToDelete.Add(this);
                ParentsToDelete.Add((NHibernatePersistenceObject)Owner);
            }

            Owner = null;
        }
        public static event ObjectEventHandler<SavedListConfiguration> OnNotifyDeleting_SavedListConfiguration;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class SavedListConfigurationProxy
            : IProxyObject, ISortKey<int>
        {
            public SavedListConfigurationProxy()
            {
            }

            public virtual int ID { get; set; }

            public virtual Type ZetboxWrapper { get { return typeof(SavedListConfigurationNHibernateImpl); } }
            public virtual Type ZetboxProxy { get { return typeof(SavedListConfigurationProxy); } }

            public virtual string Configuration { get; set; }

            public virtual Guid ExportGuid { get; set; }

            public virtual Zetbox.App.Base.IdentityNHibernateImpl.IdentityProxy Owner { get; set; }

            public virtual Zetbox.App.Base.ObjectClassNHibernateImpl.ObjectClassProxy Type { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.Configuration);
            binStream.Write(this._isExportGuidSet);
            if (this._isExportGuidSet) {
                binStream.Write(this.Proxy.ExportGuid);
            }
            binStream.Write(this.Proxy.Owner != null ? OurContext.GetIdFromProxy(this.Proxy.Owner) : (int?)null);
            binStream.Write(this.Proxy.Type != null ? OurContext.GetIdFromProxy(this.Proxy.Type) : (int?)null);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this.Proxy.Configuration = binStream.ReadString();
            this._isExportGuidSet = binStream.ReadBoolean();
            if (this._isExportGuidSet) {
                this.Proxy.ExportGuid = binStream.ReadGuid();
            }
            binStream.Read(out this._fk_Owner);
            binStream.Read(out this._fk_Type);
            } // if (CurrentAccessRights != Zetbox.API.AccessRights.None)
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            xml.WriteAttributeString("ExportGuid", this.Proxy.ExportGuid.ToString());
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            if (modules.Contains("*") || modules.Contains("Zetbox.App.GUI")) XmlStreamer.ToStream(this.Proxy.Configuration, xml, "Configuration", "Zetbox.App.GUI");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.GUI")) XmlStreamer.ToStream(this.Proxy.Type != null ? this.Proxy.Type.ExportGuid : (Guid?)null, xml, "Type", "Zetbox.App.GUI");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.GUI|Configuration":
                this.Proxy.Configuration = XmlStreamer.ReadString(xml);
                break;
            case "Zetbox.App.GUI|ExportGuid":
                // Import must have default value set
                this.Proxy.ExportGuid = XmlStreamer.ReadGuid(xml);
                this._isExportGuidSet = true;
                break;
            case "Zetbox.App.GUI|Type":
                this._fk_guid_Type = XmlStreamer.ReadNullableGuid(xml);
                break;
            }
        }

        #endregion

    }
}