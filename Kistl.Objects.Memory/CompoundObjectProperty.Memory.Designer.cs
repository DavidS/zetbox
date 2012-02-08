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

    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.Memory;

    /// <summary>
    /// Metadefinition Object for Compound Object Properties.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("CompoundObjectProperty")]
    public class CompoundObjectPropertyMemoryImpl : Kistl.App.Base.PropertyMemoryImpl, CompoundObjectProperty
    {
        [Obsolete]
        public CompoundObjectPropertyMemoryImpl()
            : base(null)
        {
        }

        public CompoundObjectPropertyMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// Definition of this Compound Object
        /// </summary>
        // BEGIN Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for CompoundObjectDefinition
        // fkBackingName=_fk_CompoundObjectDefinition; fkGuidBackingName=_fk_guid_CompoundObjectDefinition;
        // referencedInterface=Kistl.App.Base.CompoundObject; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Kistl.Generator.Templates.Properties.DelegatingProperty
        public Kistl.App.Base.CompoundObject CompoundObjectDefinition
        {
            get { return CompoundObjectDefinitionImpl; }
            set { CompoundObjectDefinitionImpl = (Kistl.App.Base.CompoundObjectMemoryImpl)value; }
        }
        // END Kistl.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_CompoundObjectDefinition;

        private Guid? _fk_guid_CompoundObjectDefinition = null;

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Kistl.App.Base.CompoundObjectMemoryImpl CompoundObjectDefinitionImpl
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Base.CompoundObjectMemoryImpl __value;
                if (_fk_CompoundObjectDefinition.HasValue)
                    __value = (Kistl.App.Base.CompoundObjectMemoryImpl)Context.Find<Kistl.App.Base.CompoundObject>(_fk_CompoundObjectDefinition.Value);
                else
                    __value = null;

                if (OnCompoundObjectDefinition_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.CompoundObject>(__value);
                    OnCompoundObjectDefinition_Getter(this, e);
                    __value = (Kistl.App.Base.CompoundObjectMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noops
                if (value == null && _fk_CompoundObjectDefinition == null)
                    return;
                else if (value != null && value.ID == _fk_CompoundObjectDefinition)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = CompoundObjectDefinitionImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("CompoundObjectDefinition", __oldValue, __newValue);

                if (OnCompoundObjectDefinition_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.CompoundObject>(__oldValue, __newValue);
                    OnCompoundObjectDefinition_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.CompoundObjectMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_CompoundObjectDefinition = __newValue == null ? (int?)null : __newValue.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("CompoundObjectDefinition", __oldValue, __newValue);

                if (OnCompoundObjectDefinition_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.CompoundObject>(__oldValue, __newValue);
                    OnCompoundObjectDefinition_PostSetter(this, e);
                }
            }
        }
        // END Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for CompoundObjectDefinition
		public static event PropertyGetterHandler<Kistl.App.Base.CompoundObjectProperty, Kistl.App.Base.CompoundObject> OnCompoundObjectDefinition_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.CompoundObjectProperty, Kistl.App.Base.CompoundObject> OnCompoundObjectDefinition_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.CompoundObjectProperty, Kistl.App.Base.CompoundObject> OnCompoundObjectDefinition_PostSetter;

        /// <summary>
        /// Whether or not the list has a persistent ordering of elements
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public bool HasPersistentOrder
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(bool);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _HasPersistentOrder;
                if (OnHasPersistentOrder_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnHasPersistentOrder_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_HasPersistentOrder != value)
                {
                    var __oldValue = _HasPersistentOrder;
                    var __newValue = value;
                    if (OnHasPersistentOrder_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnHasPersistentOrder_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("HasPersistentOrder", __oldValue, __newValue);
                    _HasPersistentOrder = __newValue;
                    NotifyPropertyChanged("HasPersistentOrder", __oldValue, __newValue);
                    if (OnHasPersistentOrder_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnHasPersistentOrder_PostSetter(this, __e);
                    }
                }
            }
        }
        private bool _HasPersistentOrder;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.CompoundObjectProperty, bool> OnHasPersistentOrder_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.CompoundObjectProperty, bool> OnHasPersistentOrder_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.CompoundObjectProperty, bool> OnHasPersistentOrder_PostSetter;

        /// <summary>
        /// Whether or not this CompoundObject property is list valued
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public bool IsList
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(bool);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _IsList;
                if (OnIsList_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnIsList_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_IsList != value)
                {
                    var __oldValue = _IsList;
                    var __newValue = value;
                    if (OnIsList_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsList_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IsList", __oldValue, __newValue);
                    _IsList = __newValue;
                    NotifyPropertyChanged("IsList", __oldValue, __newValue);
                    if (OnIsList_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsList_PostSetter(this, __e);
                    }
                }
            }
        }
        private bool _IsList;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.CompoundObjectProperty, bool> OnIsList_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.CompoundObjectProperty, bool> OnIsList_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.CompoundObjectProperty, bool> OnIsList_PostSetter;

        /// <summary>
        /// The element type for multi-valued properties. The property type string in all other cases.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetElementTypeString_CompoundObjectProperty")]
        public override string GetElementTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetElementTypeString_CompoundObjectProperty != null)
            {
                OnGetElementTypeString_CompoundObjectProperty(this, e);
            }
            else
            {
                e.Result = base.GetElementTypeString();
            }
            return e.Result;
        }
        public static event GetElementTypeString_Handler<CompoundObjectProperty> OnGetElementTypeString_CompoundObjectProperty;
		// CanExec
		public static event CanExecMethodEventHandler<CompoundObjectProperty> OnGetElementTypeString_CompoundObjectProperty_CanExec;

        [EventBasedMethod("OnGetElementTypeString_CompoundObjectProperty_CanExec")]
        public override bool GetElementTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetElementTypeString_CompoundObjectProperty_CanExec != null)
				{
					OnGetElementTypeString_CompoundObjectProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetElementTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CompoundObjectProperty> OnGetElementTypeString_CompoundObjectProperty_CanExecReason;

        [EventBasedMethod("OnGetElementTypeString_CompoundObjectProperty_CanExecReason")]
        public override string GetElementTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetElementTypeString_CompoundObjectProperty_CanExecReason != null)
				{
					OnGetElementTypeString_CompoundObjectProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetElementTypeStringCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_CompoundObjectProperty")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_CompoundObjectProperty != null)
            {
                OnGetLabel_CompoundObjectProperty(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<CompoundObjectProperty> OnGetLabel_CompoundObjectProperty;
		// CanExec
		public static event CanExecMethodEventHandler<CompoundObjectProperty> OnGetLabel_CompoundObjectProperty_CanExec;

        [EventBasedMethod("OnGetLabel_CompoundObjectProperty_CanExec")]
        public override bool GetLabelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabel_CompoundObjectProperty_CanExec != null)
				{
					OnGetLabel_CompoundObjectProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CompoundObjectProperty> OnGetLabel_CompoundObjectProperty_CanExecReason;

        [EventBasedMethod("OnGetLabel_CompoundObjectProperty_CanExecReason")]
        public override string GetLabelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabel_CompoundObjectProperty_CanExecReason != null)
				{
					OnGetLabel_CompoundObjectProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetName_CompoundObjectProperty")]
        public override string GetName()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetName_CompoundObjectProperty != null)
            {
                OnGetName_CompoundObjectProperty(this, e);
            }
            else
            {
                e.Result = base.GetName();
            }
            return e.Result;
        }
        public static event GetName_Handler<CompoundObjectProperty> OnGetName_CompoundObjectProperty;
		// CanExec
		public static event CanExecMethodEventHandler<CompoundObjectProperty> OnGetName_CompoundObjectProperty_CanExec;

        [EventBasedMethod("OnGetName_CompoundObjectProperty_CanExec")]
        public override bool GetNameCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetName_CompoundObjectProperty_CanExec != null)
				{
					OnGetName_CompoundObjectProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetNameCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CompoundObjectProperty> OnGetName_CompoundObjectProperty_CanExecReason;

        [EventBasedMethod("OnGetName_CompoundObjectProperty_CanExecReason")]
        public override string GetNameCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetName_CompoundObjectProperty_CanExecReason != null)
				{
					OnGetName_CompoundObjectProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetNameCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetPropertyType_CompoundObjectProperty")]
        public override System.Type GetPropertyType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_CompoundObjectProperty != null)
            {
                OnGetPropertyType_CompoundObjectProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
        public static event GetPropertyType_Handler<CompoundObjectProperty> OnGetPropertyType_CompoundObjectProperty;
		// CanExec
		public static event CanExecMethodEventHandler<CompoundObjectProperty> OnGetPropertyType_CompoundObjectProperty_CanExec;

        [EventBasedMethod("OnGetPropertyType_CompoundObjectProperty_CanExec")]
        public override bool GetPropertyTypeCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetPropertyType_CompoundObjectProperty_CanExec != null)
				{
					OnGetPropertyType_CompoundObjectProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CompoundObjectProperty> OnGetPropertyType_CompoundObjectProperty_CanExecReason;

        [EventBasedMethod("OnGetPropertyType_CompoundObjectProperty_CanExecReason")]
        public override string GetPropertyTypeCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetPropertyType_CompoundObjectProperty_CanExecReason != null)
				{
					OnGetPropertyType_CompoundObjectProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetPropertyTypeString_CompoundObjectProperty")]
        public override string GetPropertyTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_CompoundObjectProperty != null)
            {
                OnGetPropertyTypeString_CompoundObjectProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
        public static event GetPropertyTypeString_Handler<CompoundObjectProperty> OnGetPropertyTypeString_CompoundObjectProperty;
		// CanExec
		public static event CanExecMethodEventHandler<CompoundObjectProperty> OnGetPropertyTypeString_CompoundObjectProperty_CanExec;

        [EventBasedMethod("OnGetPropertyTypeString_CompoundObjectProperty_CanExec")]
        public override bool GetPropertyTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetPropertyTypeString_CompoundObjectProperty_CanExec != null)
				{
					OnGetPropertyTypeString_CompoundObjectProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CompoundObjectProperty> OnGetPropertyTypeString_CompoundObjectProperty_CanExecReason;

        [EventBasedMethod("OnGetPropertyTypeString_CompoundObjectProperty_CanExecReason")]
        public override string GetPropertyTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetPropertyTypeString_CompoundObjectProperty_CanExecReason != null)
				{
					OnGetPropertyTypeString_CompoundObjectProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeStringCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(CompoundObjectProperty);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (CompoundObjectProperty)obj;
            var otherImpl = (CompoundObjectPropertyMemoryImpl)obj;
            var me = (CompoundObjectProperty)this;

            me.HasPersistentOrder = other.HasPersistentOrder;
            me.IsList = other.IsList;
            this._fk_CompoundObjectDefinition = otherImpl._fk_CompoundObjectDefinition;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "CompoundObjectDefinition":
                    {
                        var __oldValue = _fk_CompoundObjectDefinition;
                        var __newValue = parentObj == null ? (int?)null : parentObj.ID;
                        NotifyPropertyChanging("CompoundObjectDefinition", __oldValue, __newValue);
                        _fk_CompoundObjectDefinition = __newValue;
                        NotifyPropertyChanged("CompoundObjectDefinition", __oldValue, __newValue);
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

            if (_fk_guid_CompoundObjectDefinition.HasValue)
                CompoundObjectDefinitionImpl = (Kistl.App.Base.CompoundObjectMemoryImpl)Context.FindPersistenceObject<Kistl.App.Base.CompoundObject>(_fk_guid_CompoundObjectDefinition.Value);
            else
            if (_fk_CompoundObjectDefinition.HasValue)
                CompoundObjectDefinitionImpl = (Kistl.App.Base.CompoundObjectMemoryImpl)Context.Find<Kistl.App.Base.CompoundObject>(_fk_CompoundObjectDefinition.Value);
            else
                CompoundObjectDefinitionImpl = null;
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
                    new PropertyDescriptorMemoryImpl<CompoundObjectPropertyMemoryImpl, Kistl.App.Base.CompoundObject>(
                        lazyCtx,
                        new Guid("0d78c157-c106-4728-9af2-7992da7c935d"),
                        "CompoundObjectDefinition",
                        null,
                        obj => obj.CompoundObjectDefinition,
                        (obj, val) => obj.CompoundObjectDefinition = val),
                    // else
                    new PropertyDescriptorMemoryImpl<CompoundObjectPropertyMemoryImpl, bool>(
                        lazyCtx,
                        new Guid("7c806f25-d85e-4d9f-b082-0cdaa7b60790"),
                        "HasPersistentOrder",
                        null,
                        obj => obj.HasPersistentOrder,
                        (obj, val) => obj.HasPersistentOrder = val),
                    // else
                    new PropertyDescriptorMemoryImpl<CompoundObjectPropertyMemoryImpl, bool>(
                        lazyCtx,
                        new Guid("8a861113-a48a-40c5-bdec-6ceafef86f48"),
                        "IsList",
                        null,
                        obj => obj.IsList,
                        (obj, val) => obj.IsList = val),
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
        #region Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_CompoundObjectProperty")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_CompoundObjectProperty != null)
            {
                OnToString_CompoundObjectProperty(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<CompoundObjectProperty> OnToString_CompoundObjectProperty;

        [EventBasedMethod("OnPreSave_CompoundObjectProperty")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_CompoundObjectProperty != null) OnPreSave_CompoundObjectProperty(this);
        }
        public static event ObjectEventHandler<CompoundObjectProperty> OnPreSave_CompoundObjectProperty;

        [EventBasedMethod("OnPostSave_CompoundObjectProperty")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_CompoundObjectProperty != null) OnPostSave_CompoundObjectProperty(this);
        }
        public static event ObjectEventHandler<CompoundObjectProperty> OnPostSave_CompoundObjectProperty;

        [EventBasedMethod("OnCreated_CompoundObjectProperty")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_CompoundObjectProperty != null) OnCreated_CompoundObjectProperty(this);
        }
        public static event ObjectEventHandler<CompoundObjectProperty> OnCreated_CompoundObjectProperty;

        [EventBasedMethod("OnDeleting_CompoundObjectProperty")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_CompoundObjectProperty != null) OnDeleting_CompoundObjectProperty(this);
        }
        public static event ObjectEventHandler<CompoundObjectProperty> OnDeleting_CompoundObjectProperty;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(CompoundObjectDefinition != null ? CompoundObjectDefinition.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._HasPersistentOrder, binStream);
            BinarySerializer.ToStream(this._IsList, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._fk_CompoundObjectDefinition, binStream);
            BinarySerializer.FromStream(out this._HasPersistentOrder, binStream);
            BinarySerializer.FromStream(out this._IsList, binStream);
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
            XmlStreamer.ToStream(CompoundObjectDefinition != null ? CompoundObjectDefinition.ID : (int?)null, xml, "CompoundObjectDefinition", "Kistl.App.Base");
            XmlStreamer.ToStream(this._HasPersistentOrder, xml, "HasPersistentOrder", "Kistl.App.Base");
            XmlStreamer.ToStream(this._IsList, xml, "IsList", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._fk_CompoundObjectDefinition, xml, "CompoundObjectDefinition", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._HasPersistentOrder, xml, "HasPersistentOrder", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IsList, xml, "IsList", "Kistl.App.Base");
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(CompoundObjectDefinition != null ? CompoundObjectDefinition.ExportGuid : (Guid?)null, xml, "CompoundObjectDefinition", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._HasPersistentOrder, xml, "HasPersistentOrder", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._IsList, xml, "IsList", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.FromStream(ref this._fk_guid_CompoundObjectDefinition, xml, "CompoundObjectDefinition", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._HasPersistentOrder, xml, "HasPersistentOrder", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IsList, xml, "IsList", "Kistl.App.Base");
        }

        #endregion

    }
}