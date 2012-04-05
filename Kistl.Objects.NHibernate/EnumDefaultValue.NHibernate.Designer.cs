// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    using Kistl.API;
    using Kistl.DalProvider.Base.RelationWrappers;

    using Kistl.API.Utils;
    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.NHibernate;

    /// <summary>
    /// Sets an enumeration property with an configured default value
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("EnumDefaultValue")]
    public class EnumDefaultValueNHibernateImpl : Kistl.App.Base.DefaultPropertyValueNHibernateImpl, EnumDefaultValue
    {
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
        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for EnumValue
        // fkBackingName=this.Proxy.EnumValue; fkGuidBackingName=_fk_guid_EnumValue;
        // referencedInterface=Kistl.App.Base.EnumerationEntry; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.EnumerationEntry EnumValue
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Base.EnumerationEntryNHibernateImpl __value = (Kistl.App.Base.EnumerationEntryNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.EnumValue);

                if (OnEnumValue_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.EnumerationEntry>(__value);
                    OnEnumValue_Getter(this, e);
                    __value = (Kistl.App.Base.EnumerationEntryNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.EnumValue == null)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = (Kistl.App.Base.EnumerationEntryNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.EnumValue);
                var __newValue = (Kistl.App.Base.EnumerationEntryNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
                    return;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("EnumValue", __oldValue, __newValue);

                if (OnEnumValue_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.EnumerationEntry>(__oldValue, __newValue);
                    OnEnumValue_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.EnumerationEntryNHibernateImpl)e.Result;
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

                if (OnEnumValue_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.EnumerationEntry>(__oldValue, __newValue);
                    OnEnumValue_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for EnumValue's id, used on dehydration only</summary>
        private int? _fk_EnumValue = null;

        /// <summary>Backing store for EnumValue's guid, used on import only</summary>
        private Guid? _fk_guid_EnumValue = null;

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for EnumValue
		public static event PropertyGetterHandler<Kistl.App.Base.EnumDefaultValue, Kistl.App.Base.EnumerationEntry> OnEnumValue_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.EnumDefaultValue, Kistl.App.Base.EnumerationEntry> OnEnumValue_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.EnumDefaultValue, Kistl.App.Base.EnumerationEntry> OnEnumValue_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Base.EnumDefaultValue> OnEnumValue_IsValid;

        /// <summary>
        /// GetDefaultValue
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
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
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
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
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

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

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "EnumValue":
                    {
                        var __oldValue = (Kistl.App.Base.EnumerationEntryNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.EnumValue);
                        var __newValue = (Kistl.App.Base.EnumerationEntryNHibernateImpl)parentObj;
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

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_guid_EnumValue.HasValue)
                this.EnumValue = ((Kistl.App.Base.EnumerationEntryNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.EnumerationEntry>(_fk_guid_EnumValue.Value));
            else
            if (_fk_EnumValue.HasValue)
                this.EnumValue = ((Kistl.App.Base.EnumerationEntryNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.EnumerationEntry>(_fk_EnumValue.Value));
            else
                this.EnumValue = null;
        }
        #region Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
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
                    new PropertyDescriptorNHibernateImpl<EnumDefaultValue, Kistl.App.Base.EnumerationEntry>(
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
        #endregion // Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

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
        }
        public static event ObjectEventHandler<EnumDefaultValue> OnNotifyDeleting_EnumDefaultValue;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods
        public override List<NHibernatePersistenceObject> GetParentsToDelete()
        {
            var result = base.GetParentsToDelete();

            // Follow EnumDefaultValue_defaults_to_EnumValue
            if (this.EnumValue != null && this.EnumValue.ObjectState == DataObjectState.Deleted)
                result.Add((NHibernatePersistenceObject)this.EnumValue);

            return result;
        }

        public override List<NHibernatePersistenceObject> GetChildrenToDelete()
        {
            var result = base.GetChildrenToDelete();

            return result;
        }


        public class EnumDefaultValueProxy
            : Kistl.App.Base.DefaultPropertyValueNHibernateImpl.DefaultPropertyValueProxy
        {
            public EnumDefaultValueProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(EnumDefaultValueNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(EnumDefaultValueProxy); } }

            public virtual Kistl.App.Base.EnumerationEntryNHibernateImpl.EnumerationEntryProxy EnumValue { get; set; }

        }

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this.Proxy.EnumValue != null ? OurContext.GetIdFromProxy(this.Proxy.EnumValue) : (int?)null, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._fk_EnumValue, binStream);
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.ToStream(this.Proxy.EnumValue != null ? OurContext.GetIdFromProxy(this.Proxy.EnumValue) : (int?)null, xml, "EnumValue", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._fk_EnumValue, xml, "EnumValue", "Kistl.App.Base");
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this.Proxy.EnumValue != null ? this.Proxy.EnumValue.ExportGuid : (Guid?)null, xml, "EnumValue", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.FromStream(ref this._fk_guid_EnumValue, xml, "EnumValue", "Kistl.App.Base");
        }

        #endregion

    }
}