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
    /// Metadefinition Object for Enumeration Properties.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("EnumerationProperty")]
    public class EnumerationPropertyMemoryImpl : Zetbox.App.Base.ValueTypePropertyMemoryImpl, EnumerationProperty
    {
        private static readonly Guid _objectClassID = new Guid("19a8d9f0-4de6-4cc9-a75d-c1499e3a103b");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public EnumerationPropertyMemoryImpl()
            : base(null)
        {
        }

        public EnumerationPropertyMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// Enumeration der Eigenschaft
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Enumeration
        // fkBackingName=_fk_Enumeration; fkGuidBackingName=_fk_guid_Enumeration;
        // referencedInterface=Zetbox.App.Base.Enumeration; moduleNamespace=Zetbox.App.Base;
        // no inverse navigator handling
        // PositionStorage=none;
        // Target exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
		[System.Runtime.Serialization.IgnoreDataMember]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Zetbox.Generator.Templates.Properties.DelegatingProperty
        public Zetbox.App.Base.Enumeration Enumeration
        {
            get { return EnumerationImpl; }
            set { EnumerationImpl = (Zetbox.App.Base.EnumerationMemoryImpl)value; }
        }
        // END Zetbox.Generator.Templates.Properties.DelegatingProperty

        private int? __fk_EnumerationCache;

        private int? _fk_Enumeration {
            get
            {
                return __fk_EnumerationCache;
            }
            set
            {
                __fk_EnumerationCache = value;
                // Recreate task to clear it's cache
                _triggerFetchEnumerationTask = null;
            }
        }

        /// <summary>ForeignKey Property for Enumeration's id, used on APIs only</summary>
		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int? FK_Enumeration
		{
			get { return _fk_Enumeration; }
			set { _fk_Enumeration = value; }
		}

        private Guid? _fk_guid_Enumeration = null;

        Zetbox.API.Async.ZbTask<Zetbox.App.Base.Enumeration> _triggerFetchEnumerationTask;
        public Zetbox.API.Async.ZbTask<Zetbox.App.Base.Enumeration> TriggerFetchEnumerationAsync()
        {
            if (_triggerFetchEnumerationTask != null) return _triggerFetchEnumerationTask;

            if (_fk_Enumeration.HasValue)
                _triggerFetchEnumerationTask = Context.FindAsync<Zetbox.App.Base.Enumeration>(_fk_Enumeration.Value);
            else
                _triggerFetchEnumerationTask = new Zetbox.API.Async.ZbTask<Zetbox.App.Base.Enumeration>(Zetbox.API.Async.ZbTask.Synchron, () => null);

            _triggerFetchEnumerationTask.OnResult(t =>
            {
                if (OnEnumeration_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.Enumeration>(t.Result);
                    OnEnumeration_Getter(this, e);
                    t.Result = e.Result;
                }
            });

            return _triggerFetchEnumerationTask;
        }

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Zetbox.App.Base.EnumerationMemoryImpl EnumerationImpl
        {
            get
            {
                return (Zetbox.App.Base.EnumerationMemoryImpl)TriggerFetchEnumerationAsync().Result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noops
                if ((value == null && _fk_Enumeration == null) || (value != null && value.ID == _fk_Enumeration))
                {
                    SetInitializedProperty("Enumeration");
                    return;
                }

                // cache old value to remove inverse references later
                var __oldValue = EnumerationImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Enumeration", __oldValue, __newValue);

                if (OnEnumeration_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.Enumeration>(__oldValue, __newValue);
                    OnEnumeration_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.EnumerationMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_Enumeration = __newValue == null ? (int?)null : __newValue.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Enumeration", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;

                if (OnEnumeration_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.Enumeration>(__oldValue, __newValue);
                    OnEnumeration_PostSetter(this, e);
                }
            }
        }
        // END Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Enumeration
		public static event PropertyGetterHandler<Zetbox.App.Base.EnumerationProperty, Zetbox.App.Base.Enumeration> OnEnumeration_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.EnumerationProperty, Zetbox.App.Base.Enumeration> OnEnumeration_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.EnumerationProperty, Zetbox.App.Base.Enumeration> OnEnumeration_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.EnumerationProperty> OnEnumeration_IsValid;

        /// <summary>
        /// Returns the translated description
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDescription_EnumerationProperty")]
        public override string GetDescription()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetDescription_EnumerationProperty != null)
            {
                OnGetDescription_EnumerationProperty(this, e);
            }
            else
            {
                e.Result = base.GetDescription();
            }
            return e.Result;
        }
        public static event GetDescription_Handler<EnumerationProperty> OnGetDescription_EnumerationProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<EnumerationProperty> OnGetDescription_EnumerationProperty_CanExec;

        [EventBasedMethod("OnGetDescription_EnumerationProperty_CanExec")]
        public override bool GetDescriptionCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetDescription_EnumerationProperty_CanExec != null)
				{
					OnGetDescription_EnumerationProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetDescriptionCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<EnumerationProperty> OnGetDescription_EnumerationProperty_CanExecReason;

        [EventBasedMethod("OnGetDescription_EnumerationProperty_CanExecReason")]
        public override string GetDescriptionCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetDescription_EnumerationProperty_CanExecReason != null)
				{
					OnGetDescription_EnumerationProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetDescriptionCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// The element type for multi-valued properties. The property type string in all other cases.
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetElementTypeString_EnumerationProperty")]
        public override string GetElementTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetElementTypeString_EnumerationProperty != null)
            {
                OnGetElementTypeString_EnumerationProperty(this, e);
            }
            else
            {
                e.Result = base.GetElementTypeString();
            }
            return e.Result;
        }
        public static event GetElementTypeString_Handler<EnumerationProperty> OnGetElementTypeString_EnumerationProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<EnumerationProperty> OnGetElementTypeString_EnumerationProperty_CanExec;

        [EventBasedMethod("OnGetElementTypeString_EnumerationProperty_CanExec")]
        public override bool GetElementTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetElementTypeString_EnumerationProperty_CanExec != null)
				{
					OnGetElementTypeString_EnumerationProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetElementTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<EnumerationProperty> OnGetElementTypeString_EnumerationProperty_CanExecReason;

        [EventBasedMethod("OnGetElementTypeString_EnumerationProperty_CanExecReason")]
        public override string GetElementTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetElementTypeString_EnumerationProperty_CanExecReason != null)
				{
					OnGetElementTypeString_EnumerationProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetElementTypeStringCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_EnumerationProperty")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_EnumerationProperty != null)
            {
                OnGetLabel_EnumerationProperty(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<EnumerationProperty> OnGetLabel_EnumerationProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<EnumerationProperty> OnGetLabel_EnumerationProperty_CanExec;

        [EventBasedMethod("OnGetLabel_EnumerationProperty_CanExec")]
        public override bool GetLabelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabel_EnumerationProperty_CanExec != null)
				{
					OnGetLabel_EnumerationProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<EnumerationProperty> OnGetLabel_EnumerationProperty_CanExecReason;

        [EventBasedMethod("OnGetLabel_EnumerationProperty_CanExecReason")]
        public override string GetLabelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabel_EnumerationProperty_CanExecReason != null)
				{
					OnGetLabel_EnumerationProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetName_EnumerationProperty")]
        public override string GetName()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetName_EnumerationProperty != null)
            {
                OnGetName_EnumerationProperty(this, e);
            }
            else
            {
                e.Result = base.GetName();
            }
            return e.Result;
        }
        public static event GetName_Handler<EnumerationProperty> OnGetName_EnumerationProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<EnumerationProperty> OnGetName_EnumerationProperty_CanExec;

        [EventBasedMethod("OnGetName_EnumerationProperty_CanExec")]
        public override bool GetNameCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetName_EnumerationProperty_CanExec != null)
				{
					OnGetName_EnumerationProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetNameCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<EnumerationProperty> OnGetName_EnumerationProperty_CanExecReason;

        [EventBasedMethod("OnGetName_EnumerationProperty_CanExecReason")]
        public override string GetNameCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetName_EnumerationProperty_CanExecReason != null)
				{
					OnGetName_EnumerationProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetNameCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetPropertyType_EnumerationProperty")]
        public override System.Type GetPropertyType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_EnumerationProperty != null)
            {
                OnGetPropertyType_EnumerationProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
        public static event GetPropertyType_Handler<EnumerationProperty> OnGetPropertyType_EnumerationProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<EnumerationProperty> OnGetPropertyType_EnumerationProperty_CanExec;

        [EventBasedMethod("OnGetPropertyType_EnumerationProperty_CanExec")]
        public override bool GetPropertyTypeCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetPropertyType_EnumerationProperty_CanExec != null)
				{
					OnGetPropertyType_EnumerationProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<EnumerationProperty> OnGetPropertyType_EnumerationProperty_CanExecReason;

        [EventBasedMethod("OnGetPropertyType_EnumerationProperty_CanExecReason")]
        public override string GetPropertyTypeCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetPropertyType_EnumerationProperty_CanExecReason != null)
				{
					OnGetPropertyType_EnumerationProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetPropertyTypeString_EnumerationProperty")]
        public override string GetPropertyTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_EnumerationProperty != null)
            {
                OnGetPropertyTypeString_EnumerationProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
        public static event GetPropertyTypeString_Handler<EnumerationProperty> OnGetPropertyTypeString_EnumerationProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<EnumerationProperty> OnGetPropertyTypeString_EnumerationProperty_CanExec;

        [EventBasedMethod("OnGetPropertyTypeString_EnumerationProperty_CanExec")]
        public override bool GetPropertyTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetPropertyTypeString_EnumerationProperty_CanExec != null)
				{
					OnGetPropertyTypeString_EnumerationProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<EnumerationProperty> OnGetPropertyTypeString_EnumerationProperty_CanExecReason;

        [EventBasedMethod("OnGetPropertyTypeString_EnumerationProperty_CanExecReason")]
        public override string GetPropertyTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetPropertyTypeString_EnumerationProperty_CanExecReason != null)
				{
					OnGetPropertyTypeString_EnumerationProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeStringCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(EnumerationProperty);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (EnumerationProperty)obj;
            var otherImpl = (EnumerationPropertyMemoryImpl)obj;
            var me = (EnumerationProperty)this;

            this._fk_Enumeration = otherImpl._fk_Enumeration;
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "Enumeration":
                    {
                        var __oldValue = _fk_Enumeration;
                        var __newValue = parentObj == null ? (int?)null : parentObj.ID;
                        NotifyPropertyChanging("Enumeration", __oldValue, __newValue);
                        _fk_Enumeration = __newValue;
                        NotifyPropertyChanged("Enumeration", __oldValue, __newValue);
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
                case "Enumeration":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }
        #endregion // Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        public override Zetbox.API.Async.ZbTask TriggerFetch(string propName)
        {
            switch(propName)
            {
            case "Enumeration":
                return TriggerFetchEnumerationAsync();
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

            if (_fk_guid_Enumeration.HasValue)
                EnumerationImpl = (Zetbox.App.Base.EnumerationMemoryImpl)Context.FindPersistenceObject<Zetbox.App.Base.Enumeration>(_fk_guid_Enumeration.Value);
            else
            if (_fk_Enumeration.HasValue)
                EnumerationImpl = (Zetbox.App.Base.EnumerationMemoryImpl)Context.Find<Zetbox.App.Base.Enumeration>(_fk_Enumeration.Value);
            else
                EnumerationImpl = null;
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
                    new PropertyDescriptorMemoryImpl<EnumerationProperty, Zetbox.App.Base.Enumeration>(
                        lazyCtx,
                        new Guid("1144c061-3610-495f-b8b4-951058bb0c23"),
                        "Enumeration",
                        null,
                        obj => obj.Enumeration,
                        (obj, val) => obj.Enumeration = val,
						obj => OnEnumeration_IsValid), 
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
        [EventBasedMethod("OnToString_EnumerationProperty")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_EnumerationProperty != null)
            {
                OnToString_EnumerationProperty(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<EnumerationProperty> OnToString_EnumerationProperty;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_EnumerationProperty")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_EnumerationProperty != null)
            {
                OnObjectIsValid_EnumerationProperty(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<EnumerationProperty> OnObjectIsValid_EnumerationProperty;

        [EventBasedMethod("OnNotifyPreSave_EnumerationProperty")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_EnumerationProperty != null) OnNotifyPreSave_EnumerationProperty(this);
        }
        public static event ObjectEventHandler<EnumerationProperty> OnNotifyPreSave_EnumerationProperty;

        [EventBasedMethod("OnNotifyPostSave_EnumerationProperty")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_EnumerationProperty != null) OnNotifyPostSave_EnumerationProperty(this);
        }
        public static event ObjectEventHandler<EnumerationProperty> OnNotifyPostSave_EnumerationProperty;

        [EventBasedMethod("OnNotifyCreated_EnumerationProperty")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Enumeration");
            base.NotifyCreated();
            if (OnNotifyCreated_EnumerationProperty != null) OnNotifyCreated_EnumerationProperty(this);
        }
        public static event ObjectEventHandler<EnumerationProperty> OnNotifyCreated_EnumerationProperty;

        [EventBasedMethod("OnNotifyDeleting_EnumerationProperty")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_EnumerationProperty != null) OnNotifyDeleting_EnumerationProperty(this);
            Enumeration = null;
        }
        public static event ObjectEventHandler<EnumerationProperty> OnNotifyDeleting_EnumerationProperty;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(Enumeration != null ? Enumeration.ID : (int?)null);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._fk_Enumeration = binStream.ReadNullableInt32();
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
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(Enumeration != null ? Enumeration.ExportGuid : (Guid?)null, xml, "Enumeration", "Zetbox.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Base|Enumeration":
                this._fk_guid_Enumeration = XmlStreamer.ReadNullableGuid(xml);
                break;
            }
        }

        #endregion

    }
}