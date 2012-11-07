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

    using Zetbox.DalProvider.Base;
    using Zetbox.DalProvider.Memory;

    /// <summary>
    /// A configuration object for instance lists
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("SavedListConfiguration")]
    public class SavedListConfigurationMemoryImpl : Zetbox.DalProvider.Memory.DataObjectMemoryImpl, SavedListConfiguration, Zetbox.API.IExportableInternal
    {
        private static readonly Guid _objectClassID = new Guid("46da717e-b6e0-4193-8580-8787fc4cf04f");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public SavedListConfigurationMemoryImpl()
            : base(null)
        {
        }

        public SavedListConfigurationMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public string Configuration
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Configuration;
                if (OnConfiguration_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnConfiguration_Getter(this, __e);
                    __result = _Configuration = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Configuration != value)
                {
                    var __oldValue = _Configuration;
                    var __newValue = value;
                    if (OnConfiguration_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnConfiguration_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Configuration", __oldValue, __newValue);
                    _Configuration = __newValue;
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
        private string _Configuration;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.GUI.SavedListConfiguration, string> OnConfiguration_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.SavedListConfiguration, string> OnConfiguration_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.SavedListConfiguration, string> OnConfiguration_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.SavedListConfiguration> OnConfiguration_IsValid;

        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public Guid ExportGuid
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ExportGuid;
                if (!_isExportGuidSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("98754493-0fcc-4874-adde-cbf27b7a53d2"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._ExportGuid = (Guid)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'SavedListConfiguration.ExportGuid'");
                    }
                }
                if (OnExportGuid_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<Guid>(__result);
                    OnExportGuid_Getter(this, __e);
                    __result = _ExportGuid = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isExportGuidSet = true;
                if (_ExportGuid != value)
                {
                    var __oldValue = _ExportGuid;
                    var __newValue = value;
                    if (OnExportGuid_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ExportGuid", __oldValue, __newValue);
                    _ExportGuid = __newValue;
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
        private Guid _ExportGuid;
        private bool _isExportGuidSet = false;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.GUI.SavedListConfiguration, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.SavedListConfiguration, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.SavedListConfiguration, Guid> OnExportGuid_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.SavedListConfiguration> OnExportGuid_IsValid;

        /// <summary>
        /// 
        /// </summary>
	        // BEGIN Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Owner
        // fkBackingName=_fk_Owner; fkGuidBackingName=_fk_guid_Owner;
        // referencedInterface=Zetbox.App.Base.Identity; moduleNamespace=Zetbox.App.GUI;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target not exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Zetbox.Generator.Templates.Properties.DelegatingProperty
        public Zetbox.App.Base.Identity Owner
        {
            get { return OwnerImpl; }
            set { OwnerImpl = (Zetbox.App.Base.IdentityMemoryImpl)value; }
        }
        // END Zetbox.Generator.Templates.Properties.DelegatingProperty

        private int? __fk_OwnerCache;

        private int? _fk_Owner {
            get
            {
                return __fk_OwnerCache;
            }
            set
            {
                __fk_OwnerCache = value;
                // Recreate task to clear it's cache
                _triggerFetchOwnerTask = null;
            }
        }


        Zetbox.API.Async.ZbTask<Zetbox.App.Base.Identity> _triggerFetchOwnerTask;
        public Zetbox.API.Async.ZbTask<Zetbox.App.Base.Identity> TriggerFetchOwnerAsync()
        {
            if (_triggerFetchOwnerTask != null) return _triggerFetchOwnerTask;

            if (_fk_Owner.HasValue)
                _triggerFetchOwnerTask = Context.FindAsync<Zetbox.App.Base.Identity>(_fk_Owner.Value);
            else
                _triggerFetchOwnerTask = new Zetbox.API.Async.ZbTask<Zetbox.App.Base.Identity>(Zetbox.API.Async.ZbTask.Synchron, () => null);

            _triggerFetchOwnerTask.OnResult(t =>
            {
                if (OnOwner_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.Identity>(t.Result);
                    OnOwner_Getter(this, e);
                    t.Result = e.Result;
                }
            });

            return _triggerFetchOwnerTask;
        }

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Zetbox.App.Base.IdentityMemoryImpl OwnerImpl
        {
            get
            {
                return (Zetbox.App.Base.IdentityMemoryImpl)TriggerFetchOwnerAsync().Result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noops
                if ((value == null && _fk_Owner == null) || (value != null && value.ID == _fk_Owner))
				{
					SetInitializedProperty("Owner");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = OwnerImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Owner", __oldValue, __newValue);

                if (OnOwner_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.Identity>(__oldValue, __newValue);
                    OnOwner_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.IdentityMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_Owner = __newValue == null ? (int?)null : __newValue.ID;

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
        // END Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Owner
		public static event PropertyGetterHandler<Zetbox.App.GUI.SavedListConfiguration, Zetbox.App.Base.Identity> OnOwner_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.SavedListConfiguration, Zetbox.App.Base.Identity> OnOwner_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.SavedListConfiguration, Zetbox.App.Base.Identity> OnOwner_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.SavedListConfiguration> OnOwner_IsValid;

        /// <summary>
        /// 
        /// </summary>
	        // BEGIN Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Type
        // fkBackingName=_fk_Type; fkGuidBackingName=_fk_guid_Type;
        // referencedInterface=Zetbox.App.Base.ObjectClass; moduleNamespace=Zetbox.App.GUI;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Zetbox.Generator.Templates.Properties.DelegatingProperty
        public Zetbox.App.Base.ObjectClass Type
        {
            get { return TypeImpl; }
            set { TypeImpl = (Zetbox.App.Base.ObjectClassMemoryImpl)value; }
        }
        // END Zetbox.Generator.Templates.Properties.DelegatingProperty

        private int? __fk_TypeCache;

        private int? _fk_Type {
            get
            {
                return __fk_TypeCache;
            }
            set
            {
                __fk_TypeCache = value;
                // Recreate task to clear it's cache
                _triggerFetchTypeTask = null;
            }
        }

        private Guid? _fk_guid_Type = null;

        Zetbox.API.Async.ZbTask<Zetbox.App.Base.ObjectClass> _triggerFetchTypeTask;
        public Zetbox.API.Async.ZbTask<Zetbox.App.Base.ObjectClass> TriggerFetchTypeAsync()
        {
            if (_triggerFetchTypeTask != null) return _triggerFetchTypeTask;

            if (_fk_Type.HasValue)
                _triggerFetchTypeTask = Context.FindAsync<Zetbox.App.Base.ObjectClass>(_fk_Type.Value);
            else
                _triggerFetchTypeTask = new Zetbox.API.Async.ZbTask<Zetbox.App.Base.ObjectClass>(Zetbox.API.Async.ZbTask.Synchron, () => null);

            _triggerFetchTypeTask.OnResult(t =>
            {
                if (OnType_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.ObjectClass>(t.Result);
                    OnType_Getter(this, e);
                    t.Result = e.Result;
                }
            });

            return _triggerFetchTypeTask;
        }

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Zetbox.App.Base.ObjectClassMemoryImpl TypeImpl
        {
            get
            {
                return (Zetbox.App.Base.ObjectClassMemoryImpl)TriggerFetchTypeAsync().Result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noops
                if ((value == null && _fk_Type == null) || (value != null && value.ID == _fk_Type))
				{
					SetInitializedProperty("Type");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = TypeImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Type", __oldValue, __newValue);

                if (OnType_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.ObjectClass>(__oldValue, __newValue);
                    OnType_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.ObjectClassMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_Type = __newValue == null ? (int?)null : __newValue.ID;

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
        // END Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Type
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
            var otherImpl = (SavedListConfigurationMemoryImpl)obj;
            var me = (SavedListConfiguration)this;

            me.Configuration = other.Configuration;
            me.ExportGuid = other.ExportGuid;
            this._fk_Owner = otherImpl._fk_Owner;
            this._fk_Type = otherImpl._fk_Type;
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
                        var __oldValue = _fk_Owner;
                        var __newValue = parentObj == null ? (int?)null : parentObj.ID;
                        NotifyPropertyChanging("Owner", __oldValue, __newValue);
                        _fk_Owner = __newValue;
                        NotifyPropertyChanged("Owner", __oldValue, __newValue);
                    }
                    break;
                case "Type":
                    {
                        var __oldValue = _fk_Type;
                        var __newValue = parentObj == null ? (int?)null : parentObj.ID;
                        NotifyPropertyChanging("Type", __oldValue, __newValue);
                        _fk_Type = __newValue;
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

        public override Zetbox.API.Async.ZbTask TriggerFetch(string propName)
        {
            switch(propName)
            {
            case "Owner":
                return TriggerFetchOwnerAsync();
            case "Type":
                return TriggerFetchTypeAsync();
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

            if (_fk_Owner.HasValue)
                OwnerImpl = (Zetbox.App.Base.IdentityMemoryImpl)Context.Find<Zetbox.App.Base.Identity>(_fk_Owner.Value);
            else
                OwnerImpl = null;

            if (_fk_guid_Type.HasValue)
                TypeImpl = (Zetbox.App.Base.ObjectClassMemoryImpl)Context.FindPersistenceObject<Zetbox.App.Base.ObjectClass>(_fk_guid_Type.Value);
            else
            if (_fk_Type.HasValue)
                TypeImpl = (Zetbox.App.Base.ObjectClassMemoryImpl)Context.Find<Zetbox.App.Base.ObjectClass>(_fk_Type.Value);
            else
                TypeImpl = null;
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
                    new PropertyDescriptorMemoryImpl<SavedListConfiguration, string>(
                        lazyCtx,
                        new Guid("2063f89a-89c8-48de-b191-b6dd870072c3"),
                        "Configuration",
                        null,
                        obj => obj.Configuration,
                        (obj, val) => obj.Configuration = val,
						obj => OnConfiguration_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<SavedListConfiguration, Guid>(
                        lazyCtx,
                        new Guid("98754493-0fcc-4874-adde-cbf27b7a53d2"),
                        "ExportGuid",
                        null,
                        obj => obj.ExportGuid,
                        (obj, val) => obj.ExportGuid = val,
						obj => OnExportGuid_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<SavedListConfiguration, Zetbox.App.Base.Identity>(
                        lazyCtx,
                        new Guid("776c6c41-d42d-43d0-bff4-e99638a045bf"),
                        "Owner",
                        null,
                        obj => obj.Owner,
                        (obj, val) => obj.Owner = val,
						obj => OnOwner_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<SavedListConfiguration, Zetbox.App.Base.ObjectClass>(
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
        #region Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

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
            Owner = null;
        }
        public static event ObjectEventHandler<SavedListConfiguration> OnNotifyDeleting_SavedListConfiguration;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._Configuration);
            binStream.Write(this._isExportGuidSet);
            if (this._isExportGuidSet) {
                binStream.Write(this._ExportGuid);
            }
            binStream.Write(Owner != null ? Owner.ID : (int?)null);
            binStream.Write(Type != null ? Type.ID : (int?)null);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._Configuration = binStream.ReadString();
            this._isExportGuidSet = binStream.ReadBoolean();
            if (this._isExportGuidSet) {
                this._ExportGuid = binStream.ReadGuid();
            }
            this._fk_Owner = binStream.ReadNullableInt32();
            this._fk_Type = binStream.ReadNullableInt32();
            } // if (CurrentAccessRights != Zetbox.API.AccessRights.None)
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            xml.WriteAttributeString("ExportGuid", this._ExportGuid.ToString());
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            if (modules.Contains("*") || modules.Contains("Zetbox.App.GUI")) XmlStreamer.ToStream(this._Configuration, xml, "Configuration", "Zetbox.App.GUI");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.GUI")) XmlStreamer.ToStream(Type != null ? Type.ExportGuid : (Guid?)null, xml, "Type", "Zetbox.App.GUI");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.GUI|Configuration":
                this._Configuration = XmlStreamer.ReadString(xml);
                break;
            case "Zetbox.App.GUI|ExportGuid":
                // Import must have default value set
                this._ExportGuid = XmlStreamer.ReadGuid(xml);
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