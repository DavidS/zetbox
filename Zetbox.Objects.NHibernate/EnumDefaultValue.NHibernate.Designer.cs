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
    /// Sets an enumeration property with an configured default value
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("EnumDefaultValue")]
    public class EnumDefaultValueNHibernateImpl : Zetbox.App.Base.DefaultPropertyValueNHibernateImpl, EnumDefaultValue
    {
        private static readonly Guid _objectClassID = new Guid("4f35c5da-924c-4114-a011-4d736faa3ae2");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public EnumDefaultValueNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public EnumDefaultValueNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new EnumDefaultValueProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public EnumDefaultValueNHibernateImpl(Func<IFrozenContext> lazyCtx, EnumDefaultValueProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly EnumDefaultValueProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for EnumValue
        // fkBackingName=this.Proxy.EnumValue; fkGuidBackingName=_fk_guid_EnumValue;
        // referencedInterface=Zetbox.App.Base.EnumerationEntry; moduleNamespace=Zetbox.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Base.EnumerationEntry EnumValue
        {
            get
            {
                Zetbox.App.Base.EnumerationEntryNHibernateImpl __value = (Zetbox.App.Base.EnumerationEntryNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.EnumValue);

                if (OnEnumValue_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.EnumerationEntry>(__value);
                    OnEnumValue_Getter(this, e);
                    __value = (Zetbox.App.Base.EnumerationEntryNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.EnumValue == null)
				{
					SetInitializedProperty("EnumValue");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = (Zetbox.App.Base.EnumerationEntryNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.EnumValue);
                var __newValue = (Zetbox.App.Base.EnumerationEntryNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
				{
					SetInitializedProperty("EnumValue");
                    return;
				}

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("EnumValue", __oldValue, __newValue);

                if (OnEnumValue_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.EnumerationEntry>(__oldValue, __newValue);
                    OnEnumValue_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.EnumerationEntryNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.EnumValue = null;
                }
                else
                {
                    this.Proxy.EnumValue = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("EnumValue", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;

                if (OnEnumValue_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.EnumerationEntry>(__oldValue, __newValue);
                    OnEnumValue_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for EnumValue's id, used on dehydration only</summary>
        private int? _fk_EnumValue = null;

        /// <summary>Backing store for EnumValue's guid, used on import only</summary>
        private Guid? _fk_guid_EnumValue = null;

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for EnumValue
		public static event PropertyGetterHandler<Zetbox.App.Base.EnumDefaultValue, Zetbox.App.Base.EnumerationEntry> OnEnumValue_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.EnumDefaultValue, Zetbox.App.Base.EnumerationEntry> OnEnumValue_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.EnumDefaultValue, Zetbox.App.Base.EnumerationEntry> OnEnumValue_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.EnumDefaultValue> OnEnumValue_IsValid;

        /// <summary>
        /// GetDefaultValue
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDefaultValue_EnumDefaultValue")]
        public override System.Object GetDefaultValue()
        {
            var e = new MethodReturnEventArgs<System.Object>();
            if (OnGetDefaultValue_EnumDefaultValue != null)
            {
                OnGetDefaultValue_EnumDefaultValue(this, e);
            }
            else
            {
                e.Result = base.GetDefaultValue();
            }
            return e.Result;
        }
        public static event GetDefaultValue_Handler<EnumDefaultValue> OnGetDefaultValue_EnumDefaultValue;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<EnumDefaultValue> OnGetDefaultValue_EnumDefaultValue_CanExec;

        [EventBasedMethod("OnGetDefaultValue_EnumDefaultValue_CanExec")]
        public override bool GetDefaultValueCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetDefaultValue_EnumDefaultValue_CanExec != null)
				{
					OnGetDefaultValue_EnumDefaultValue_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetDefaultValueCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<EnumDefaultValue> OnGetDefaultValue_EnumDefaultValue_CanExecReason;

        [EventBasedMethod("OnGetDefaultValue_EnumDefaultValue_CanExecReason")]
        public override string GetDefaultValueCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetDefaultValue_EnumDefaultValue_CanExecReason != null)
				{
					OnGetDefaultValue_EnumDefaultValue_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetDefaultValueCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(EnumDefaultValue);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (EnumDefaultValue)obj;
            var otherImpl = (EnumDefaultValueNHibernateImpl)obj;
            var me = (EnumDefaultValue)this;

            this._fk_EnumValue = otherImpl._fk_EnumValue;
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "EnumValue":
                    {
                        var __oldValue = (Zetbox.App.Base.EnumerationEntryNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.EnumValue);
                        var __newValue = (Zetbox.App.Base.EnumerationEntryNHibernateImpl)parentObj;
                        NotifyPropertyChanging("EnumValue", __oldValue, __newValue);
                        this.Proxy.EnumValue = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("EnumValue", __oldValue, __newValue);
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
                case "EnumValue":
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

            if (_fk_guid_EnumValue.HasValue)
                this.EnumValue = ((Zetbox.App.Base.EnumerationEntryNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.Base.EnumerationEntry>(_fk_guid_EnumValue.Value));
            else
            if (_fk_EnumValue.HasValue)
                this.EnumValue = ((Zetbox.App.Base.EnumerationEntryNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.Base.EnumerationEntry>(_fk_EnumValue.Value));
            else
                this.EnumValue = null;
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
                    new PropertyDescriptorNHibernateImpl<EnumDefaultValue, Zetbox.App.Base.EnumerationEntry>(
                        lazyCtx,
                        new Guid("d072423b-f723-4342-8111-79fb563c8ab4"),
                        "EnumValue",
                        null,
                        obj => obj.EnumValue,
                        (obj, val) => obj.EnumValue = val,
						obj => OnEnumValue_IsValid), 
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
        [EventBasedMethod("OnToString_EnumDefaultValue")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_EnumDefaultValue != null)
            {
                OnToString_EnumDefaultValue(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<EnumDefaultValue> OnToString_EnumDefaultValue;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_EnumDefaultValue")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_EnumDefaultValue != null)
            {
                OnObjectIsValid_EnumDefaultValue(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<EnumDefaultValue> OnObjectIsValid_EnumDefaultValue;

        [EventBasedMethod("OnNotifyPreSave_EnumDefaultValue")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_EnumDefaultValue != null) OnNotifyPreSave_EnumDefaultValue(this);
        }
        public static event ObjectEventHandler<EnumDefaultValue> OnNotifyPreSave_EnumDefaultValue;

        [EventBasedMethod("OnNotifyPostSave_EnumDefaultValue")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_EnumDefaultValue != null) OnNotifyPostSave_EnumDefaultValue(this);
        }
        public static event ObjectEventHandler<EnumDefaultValue> OnNotifyPostSave_EnumDefaultValue;

        [EventBasedMethod("OnNotifyCreated_EnumDefaultValue")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("EnumValue");
            base.NotifyCreated();
            if (OnNotifyCreated_EnumDefaultValue != null) OnNotifyCreated_EnumDefaultValue(this);
        }
        public static event ObjectEventHandler<EnumDefaultValue> OnNotifyCreated_EnumDefaultValue;

        [EventBasedMethod("OnNotifyDeleting_EnumDefaultValue")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_EnumDefaultValue != null) OnNotifyDeleting_EnumDefaultValue(this);

            // FK_EnumDefaultValue_defaults_to_EnumValue
            if (EnumValue != null) {
                ((NHibernatePersistenceObject)EnumValue).ChildrenToDelete.Add(this);
                ParentsToDelete.Add((NHibernatePersistenceObject)EnumValue);
            }

        }
        public static event ObjectEventHandler<EnumDefaultValue> OnNotifyDeleting_EnumDefaultValue;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class EnumDefaultValueProxy
            : Zetbox.App.Base.DefaultPropertyValueNHibernateImpl.DefaultPropertyValueProxy
        {
            public EnumDefaultValueProxy()
            {
            }

            public override Type ZetboxWrapper { get { return typeof(EnumDefaultValueNHibernateImpl); } }

            public override Type ZetboxProxy { get { return typeof(EnumDefaultValueProxy); } }

            public virtual Zetbox.App.Base.EnumerationEntryNHibernateImpl.EnumerationEntryProxy EnumValue { get; set; }

        }

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.EnumValue != null ? OurContext.GetIdFromProxy(this.Proxy.EnumValue) : (int?)null);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            binStream.Read(out this._fk_EnumValue);
            } // if (CurrentAccessRights != Zetbox.API.AccessRights.None)
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this.Proxy.EnumValue != null ? this.Proxy.EnumValue.ExportGuid : (Guid?)null, xml, "EnumValue", "Zetbox.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Base|EnumValue":
                this._fk_guid_EnumValue = XmlStreamer.ReadNullableGuid(xml);
                break;
            }
        }

        #endregion

    }
}