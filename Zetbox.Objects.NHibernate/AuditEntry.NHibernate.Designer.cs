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

    using Zetbox.API.Utils;
    using Zetbox.DalProvider.Base;
    using Zetbox.DalProvider.NHibernate;

    /// <summary>
    /// A single entry in the auditing table of a class
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("AuditEntry")]
    public class AuditEntryNHibernateImpl : CompoundObjectDefaultImpl, AuditEntry, ICompoundObject
    {
        private static readonly Guid _compoundObjectID = new Guid("84d3d914-cb79-41fe-8aae-54128e7edb87");
        public override Guid CompoundObjectID { get { return _compoundObjectID; } }

        // used by NHibernate
        public AuditEntryNHibernateImpl()
            : this(null, null, null, null)
        {
        }

        // used by CreateUnattachedInstance
        public AuditEntryNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(null, null, lazyCtx, null)
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public AuditEntryNHibernateImpl(IPersistenceObject parent, string property, Func<IFrozenContext> lazyCtx, AuditEntryProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
            AttachToObject(parent, property);
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly AuditEntryProxy Proxy;

        /// <summary>
        /// The identity that caued this audit
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public string Identity
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Identity;
                if (OnIdentity_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnIdentity_Getter(this, __e);
                    __result = _Identity = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Identity != value)
                {
                    var __oldValue = _Identity;
                    var __newValue = value;
                    if (OnIdentity_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnIdentity_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Identity", __oldValue, __newValue);
                    _Identity = __newValue;
                    NotifyPropertyChanged("Identity", __oldValue, __newValue);

                    if (OnIdentity_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnIdentity_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Identity");
				}
            }
        }
        private string _Identity;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.AuditEntry, string> OnIdentity_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.AuditEntry, string> OnIdentity_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.AuditEntry, string> OnIdentity_PostSetter;

        /// <summary>
        /// The default format to display this change to the user
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public string MessageFormat
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _MessageFormat;
                if (OnMessageFormat_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnMessageFormat_Getter(this, __e);
                    __result = _MessageFormat = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_MessageFormat != value)
                {
                    var __oldValue = _MessageFormat;
                    var __newValue = value;
                    if (OnMessageFormat_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnMessageFormat_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("MessageFormat", __oldValue, __newValue);
                    _MessageFormat = __newValue;
                    NotifyPropertyChanged("MessageFormat", __oldValue, __newValue);

                    if (OnMessageFormat_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnMessageFormat_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("MessageFormat");
				}
            }
        }
        private string _MessageFormat;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.AuditEntry, string> OnMessageFormat_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.AuditEntry, string> OnMessageFormat_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.AuditEntry, string> OnMessageFormat_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public string NewValue
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _NewValue;
                if (OnNewValue_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnNewValue_Getter(this, __e);
                    __result = _NewValue = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_NewValue != value)
                {
                    var __oldValue = _NewValue;
                    var __newValue = value;
                    if (OnNewValue_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnNewValue_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("NewValue", __oldValue, __newValue);
                    _NewValue = __newValue;
                    NotifyPropertyChanged("NewValue", __oldValue, __newValue);

                    if (OnNewValue_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnNewValue_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("NewValue");
				}
            }
        }
        private string _NewValue;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.AuditEntry, string> OnNewValue_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.AuditEntry, string> OnNewValue_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.AuditEntry, string> OnNewValue_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public string OldValue
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _OldValue;
                if (OnOldValue_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnOldValue_Getter(this, __e);
                    __result = _OldValue = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_OldValue != value)
                {
                    var __oldValue = _OldValue;
                    var __newValue = value;
                    if (OnOldValue_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnOldValue_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("OldValue", __oldValue, __newValue);
                    _OldValue = __newValue;
                    NotifyPropertyChanged("OldValue", __oldValue, __newValue);

                    if (OnOldValue_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnOldValue_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("OldValue");
				}
            }
        }
        private string _OldValue;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.AuditEntry, string> OnOldValue_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.AuditEntry, string> OnOldValue_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.AuditEntry, string> OnOldValue_PostSetter;

        /// <summary>
        /// The name of the changed property
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public string PropertyName
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _PropertyName;
                if (OnPropertyName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnPropertyName_Getter(this, __e);
                    __result = _PropertyName = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_PropertyName != value)
                {
                    var __oldValue = _PropertyName;
                    var __newValue = value;
                    if (OnPropertyName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnPropertyName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("PropertyName", __oldValue, __newValue);
                    _PropertyName = __newValue;
                    NotifyPropertyChanged("PropertyName", __oldValue, __newValue);

                    if (OnPropertyName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnPropertyName_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("PropertyName");
				}
            }
        }
        private string _PropertyName;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.AuditEntry, string> OnPropertyName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.AuditEntry, string> OnPropertyName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.AuditEntry, string> OnPropertyName_PostSetter;

        /// <summary>
        /// The time when the change was made
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public DateTime? Timestamp
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(DateTime?);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Timestamp;
                if (!_isTimestampSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("c9461d28-4594-443e-82ec-a2ddc9664742"));
                    if (__p != null) {
                        _isTimestampSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                            if (__tmp_value == null)
                                __result = this._Timestamp = null;
                            else
                            __result = this._Timestamp = (DateTime)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'AuditEntry.Timestamp'");
                    }
                }
                if (OnTimestamp_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime?>(__result);
                    OnTimestamp_Getter(this, __e);
                    __result = _Timestamp = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isTimestampSet = true;
                if (_Timestamp != value)
                {
                    var __oldValue = _Timestamp;
                    var __newValue = value;
                    if (OnTimestamp_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnTimestamp_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Timestamp", __oldValue, __newValue);
                    _Timestamp = __newValue;
                    NotifyPropertyChanged("Timestamp", __oldValue, __newValue);

                    if (OnTimestamp_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnTimestamp_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Timestamp");
				}
            }
        }
        private DateTime? _Timestamp;
        private bool _isTimestampSet = false;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.AuditEntry, DateTime?> OnTimestamp_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.AuditEntry, DateTime?> OnTimestamp_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.AuditEntry, DateTime?> OnTimestamp_PostSetter;

        public override Type GetImplementedInterface()
        {
            return typeof(AuditEntry);
        }

        public override void ApplyChangesFrom(ICompoundObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (AuditEntry)obj;
            var otherImpl = (AuditEntryNHibernateImpl)obj;
            var me = (AuditEntry)this;

            me.Identity = other.Identity;
            me.MessageFormat = other.MessageFormat;
            me.NewValue = other.NewValue;
            me.OldValue = other.OldValue;
            me.PropertyName = other.PropertyName;
            me.Timestamp = other.Timestamp;
        }
        #region Zetbox.Generator.Templates.CompoundObjects.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_AuditEntry")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_AuditEntry != null)
            {
                OnToString_AuditEntry(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<AuditEntry> OnToString_AuditEntry;

		[System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_AuditEntry")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
			var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
			e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_AuditEntry != null)
            {
                OnObjectIsValid_AuditEntry(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<AuditEntry> OnObjectIsValid_AuditEntry;

        #endregion // Zetbox.Generator.Templates.CompoundObjects.DefaultMethods
public class AuditEntryProxy { }
public bool CompoundObject_IsNull { get; set; }

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._Identity);
            binStream.Write(this._MessageFormat);
            binStream.Write(this._NewValue);
            binStream.Write(this._OldValue);
            binStream.Write(this._PropertyName);
            binStream.Write(this._isTimestampSet);
            if (this._isTimestampSet) {
                binStream.Write(this._Timestamp);
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._Identity = binStream.ReadString();
            this._MessageFormat = binStream.ReadString();
            this._NewValue = binStream.ReadString();
            this._OldValue = binStream.ReadString();
            this._PropertyName = binStream.ReadString();
            this._isTimestampSet = binStream.ReadBoolean();
            if (this._isTimestampSet) {
                this._Timestamp = binStream.ReadNullableDateTime();
            }
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