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
    /// a object reference that is calculated from the contents of the containing class
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("CalculatedObjectReferenceProperty")]
    public class CalculatedObjectReferencePropertyMemoryImpl : Zetbox.App.Base.PropertyMemoryImpl, CalculatedObjectReferenceProperty
    {
        private static readonly Guid _objectClassID = new Guid("8708c578-6e55-4349-ba24-ede46ca6f585");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public CalculatedObjectReferencePropertyMemoryImpl()
            : base(null)
        {
        }

        public CalculatedObjectReferencePropertyMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// The properties on which the calculation depends. This is used to propagate change notifications.
        /// </summary>
        // collection entry list property
   		// Zetbox.Generator.Templates.Properties.CollectionEntryListProperty
		public ICollection<Zetbox.App.Base.Property> Inputs
		{
			get
			{
				if (_Inputs == null)
				{
					if (!Inputs_was_eagerLoaded) Context.FetchRelation<Zetbox.App.Base.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryMemoryImpl>(new Guid("47595643-e8d0-48ef-82c7-2d24de8a784e"), RelationEndRole.A, this);
					_Inputs 
						= new ObservableBSideCollectionWrapper<Zetbox.App.Base.CalculatedObjectReferenceProperty, Zetbox.App.Base.Property, Zetbox.App.Base.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryMemoryImpl, ICollection<Zetbox.App.Base.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryMemoryImpl>>(
							this, 
							new RelationshipFilterASideCollection<Zetbox.App.Base.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryMemoryImpl>(this.Context, this));
				}
				return (ICollection<Zetbox.App.Base.Property>)_Inputs;
			}
		}

		private ObservableBSideCollectionWrapper<Zetbox.App.Base.CalculatedObjectReferenceProperty, Zetbox.App.Base.Property, Zetbox.App.Base.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryMemoryImpl, ICollection<Zetbox.App.Base.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryMemoryImpl>> _Inputs;
		
		private bool Inputs_was_eagerLoaded = false;

        public static event PropertyIsValidHandler<Zetbox.App.Base.CalculatedObjectReferenceProperty> OnInputs_IsValid;

        /// <summary>
        /// the referenced class of objects
        /// </summary>
	        // BEGIN Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ReferencedClass
        // fkBackingName=_fk_ReferencedClass; fkGuidBackingName=_fk_guid_ReferencedClass;
        // referencedInterface=Zetbox.App.Base.ObjectClass; moduleNamespace=Zetbox.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Zetbox.Generator.Templates.Properties.DelegatingProperty
        public Zetbox.App.Base.ObjectClass ReferencedClass
        {
            get { return ReferencedClassImpl; }
            set { ReferencedClassImpl = (Zetbox.App.Base.ObjectClassMemoryImpl)value; }
        }
        // END Zetbox.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_ReferencedClass;

        private Guid? _fk_guid_ReferencedClass = null;

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Zetbox.App.Base.ObjectClassMemoryImpl ReferencedClassImpl
        {
            get
            {
                Zetbox.App.Base.ObjectClassMemoryImpl __value;
                if (_fk_ReferencedClass.HasValue)
                    __value = (Zetbox.App.Base.ObjectClassMemoryImpl)Context.Find<Zetbox.App.Base.ObjectClass>(_fk_ReferencedClass.Value);
                else
                    __value = null;

                if (OnReferencedClass_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.ObjectClass>(__value);
                    OnReferencedClass_Getter(this, e);
                    __value = (Zetbox.App.Base.ObjectClassMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noops
                if ((value == null && _fk_ReferencedClass == null) || (value != null && value.ID == _fk_ReferencedClass))
				{
					SetInitializedProperty("ReferencedClass");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = ReferencedClassImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("ReferencedClass", __oldValue, __newValue);

                if (OnReferencedClass_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.ObjectClass>(__oldValue, __newValue);
                    OnReferencedClass_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.ObjectClassMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_ReferencedClass = __newValue == null ? (int?)null : __newValue.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("ReferencedClass", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;

                if (OnReferencedClass_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.ObjectClass>(__oldValue, __newValue);
                    OnReferencedClass_PostSetter(this, e);
                }
            }
        }
        // END Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ReferencedClass
		public static event PropertyGetterHandler<Zetbox.App.Base.CalculatedObjectReferenceProperty, Zetbox.App.Base.ObjectClass> OnReferencedClass_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.CalculatedObjectReferenceProperty, Zetbox.App.Base.ObjectClass> OnReferencedClass_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.CalculatedObjectReferenceProperty, Zetbox.App.Base.ObjectClass> OnReferencedClass_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.CalculatedObjectReferenceProperty> OnReferencedClass_IsValid;

        /// <summary>
        /// The element type for multi-valued properties. The property type string in all other cases.
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetElementTypeString_CalculatedObjectReferenceProperty")]
        public override string GetElementTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetElementTypeString_CalculatedObjectReferenceProperty != null)
            {
                OnGetElementTypeString_CalculatedObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetElementTypeString();
            }
            return e.Result;
        }
        public static event GetElementTypeString_Handler<CalculatedObjectReferenceProperty> OnGetElementTypeString_CalculatedObjectReferenceProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<CalculatedObjectReferenceProperty> OnGetElementTypeString_CalculatedObjectReferenceProperty_CanExec;

        [EventBasedMethod("OnGetElementTypeString_CalculatedObjectReferenceProperty_CanExec")]
        public override bool GetElementTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetElementTypeString_CalculatedObjectReferenceProperty_CanExec != null)
				{
					OnGetElementTypeString_CalculatedObjectReferenceProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetElementTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CalculatedObjectReferenceProperty> OnGetElementTypeString_CalculatedObjectReferenceProperty_CanExecReason;

        [EventBasedMethod("OnGetElementTypeString_CalculatedObjectReferenceProperty_CanExecReason")]
        public override string GetElementTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetElementTypeString_CalculatedObjectReferenceProperty_CanExecReason != null)
				{
					OnGetElementTypeString_CalculatedObjectReferenceProperty_CanExecReason(this, e);
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
        [EventBasedMethod("OnGetLabel_CalculatedObjectReferenceProperty")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_CalculatedObjectReferenceProperty != null)
            {
                OnGetLabel_CalculatedObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<CalculatedObjectReferenceProperty> OnGetLabel_CalculatedObjectReferenceProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<CalculatedObjectReferenceProperty> OnGetLabel_CalculatedObjectReferenceProperty_CanExec;

        [EventBasedMethod("OnGetLabel_CalculatedObjectReferenceProperty_CanExec")]
        public override bool GetLabelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabel_CalculatedObjectReferenceProperty_CanExec != null)
				{
					OnGetLabel_CalculatedObjectReferenceProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CalculatedObjectReferenceProperty> OnGetLabel_CalculatedObjectReferenceProperty_CanExecReason;

        [EventBasedMethod("OnGetLabel_CalculatedObjectReferenceProperty_CanExecReason")]
        public override string GetLabelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabel_CalculatedObjectReferenceProperty_CanExecReason != null)
				{
					OnGetLabel_CalculatedObjectReferenceProperty_CanExecReason(this, e);
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
        [EventBasedMethod("OnGetName_CalculatedObjectReferenceProperty")]
        public override string GetName()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetName_CalculatedObjectReferenceProperty != null)
            {
                OnGetName_CalculatedObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetName();
            }
            return e.Result;
        }
        public static event GetName_Handler<CalculatedObjectReferenceProperty> OnGetName_CalculatedObjectReferenceProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<CalculatedObjectReferenceProperty> OnGetName_CalculatedObjectReferenceProperty_CanExec;

        [EventBasedMethod("OnGetName_CalculatedObjectReferenceProperty_CanExec")]
        public override bool GetNameCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetName_CalculatedObjectReferenceProperty_CanExec != null)
				{
					OnGetName_CalculatedObjectReferenceProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetNameCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CalculatedObjectReferenceProperty> OnGetName_CalculatedObjectReferenceProperty_CanExecReason;

        [EventBasedMethod("OnGetName_CalculatedObjectReferenceProperty_CanExecReason")]
        public override string GetNameCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetName_CalculatedObjectReferenceProperty_CanExecReason != null)
				{
					OnGetName_CalculatedObjectReferenceProperty_CanExecReason(this, e);
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
        [EventBasedMethod("OnGetPropertyType_CalculatedObjectReferenceProperty")]
        public override System.Type GetPropertyType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_CalculatedObjectReferenceProperty != null)
            {
                OnGetPropertyType_CalculatedObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
        public static event GetPropertyType_Handler<CalculatedObjectReferenceProperty> OnGetPropertyType_CalculatedObjectReferenceProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<CalculatedObjectReferenceProperty> OnGetPropertyType_CalculatedObjectReferenceProperty_CanExec;

        [EventBasedMethod("OnGetPropertyType_CalculatedObjectReferenceProperty_CanExec")]
        public override bool GetPropertyTypeCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetPropertyType_CalculatedObjectReferenceProperty_CanExec != null)
				{
					OnGetPropertyType_CalculatedObjectReferenceProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CalculatedObjectReferenceProperty> OnGetPropertyType_CalculatedObjectReferenceProperty_CanExecReason;

        [EventBasedMethod("OnGetPropertyType_CalculatedObjectReferenceProperty_CanExecReason")]
        public override string GetPropertyTypeCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetPropertyType_CalculatedObjectReferenceProperty_CanExecReason != null)
				{
					OnGetPropertyType_CalculatedObjectReferenceProperty_CanExecReason(this, e);
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
        [EventBasedMethod("OnGetPropertyTypeString_CalculatedObjectReferenceProperty")]
        public override string GetPropertyTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_CalculatedObjectReferenceProperty != null)
            {
                OnGetPropertyTypeString_CalculatedObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
        public static event GetPropertyTypeString_Handler<CalculatedObjectReferenceProperty> OnGetPropertyTypeString_CalculatedObjectReferenceProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<CalculatedObjectReferenceProperty> OnGetPropertyTypeString_CalculatedObjectReferenceProperty_CanExec;

        [EventBasedMethod("OnGetPropertyTypeString_CalculatedObjectReferenceProperty_CanExec")]
        public override bool GetPropertyTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetPropertyTypeString_CalculatedObjectReferenceProperty_CanExec != null)
				{
					OnGetPropertyTypeString_CalculatedObjectReferenceProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CalculatedObjectReferenceProperty> OnGetPropertyTypeString_CalculatedObjectReferenceProperty_CanExecReason;

        [EventBasedMethod("OnGetPropertyTypeString_CalculatedObjectReferenceProperty_CanExecReason")]
        public override string GetPropertyTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetPropertyTypeString_CalculatedObjectReferenceProperty_CanExecReason != null)
				{
					OnGetPropertyTypeString_CalculatedObjectReferenceProperty_CanExecReason(this, e);
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
            return typeof(CalculatedObjectReferenceProperty);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (CalculatedObjectReferenceProperty)obj;
            var otherImpl = (CalculatedObjectReferencePropertyMemoryImpl)obj;
            var me = (CalculatedObjectReferenceProperty)this;

            this._fk_ReferencedClass = otherImpl._fk_ReferencedClass;
        }

        public override void AttachToContext(IZetboxContext ctx, Func<IFrozenContext> lazyFrozenContext)
        {
            base.AttachToContext(ctx, lazyFrozenContext);
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "ReferencedClass":
                    {
                        var __oldValue = _fk_ReferencedClass;
                        var __newValue = parentObj == null ? (int?)null : parentObj.ID;
                        NotifyPropertyChanging("ReferencedClass", __oldValue, __newValue);
                        _fk_ReferencedClass = __newValue;
                        NotifyPropertyChanged("ReferencedClass", __oldValue, __newValue);
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
                case "ReferencedClass":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }

        protected override bool ShouldSetModified(string property)
        {
            switch (property)
            {
                case "Inputs":
                    return false;
                default:
                    return base.ShouldSetModified(property);
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

            if (_fk_guid_ReferencedClass.HasValue)
                ReferencedClassImpl = (Zetbox.App.Base.ObjectClassMemoryImpl)Context.FindPersistenceObject<Zetbox.App.Base.ObjectClass>(_fk_guid_ReferencedClass.Value);
            else
            if (_fk_ReferencedClass.HasValue)
                ReferencedClassImpl = (Zetbox.App.Base.ObjectClassMemoryImpl)Context.Find<Zetbox.App.Base.ObjectClass>(_fk_ReferencedClass.Value);
            else
                ReferencedClassImpl = null;
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
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorMemoryImpl<CalculatedObjectReferenceProperty, ICollection<Zetbox.App.Base.Property>>(
                        lazyCtx,
                        new Guid("bfda6511-087d-4381-9780-1f76f3abcffe"),
                        "Inputs",
                        null,
                        obj => obj.Inputs,
                        null, // lists are read-only properties
                        obj => OnInputs_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<CalculatedObjectReferenceProperty, Zetbox.App.Base.ObjectClass>(
                        lazyCtx,
                        new Guid("cd62d769-0752-4a72-832f-5935ece1198b"),
                        "ReferencedClass",
                        null,
                        obj => obj.ReferencedClass,
                        (obj, val) => obj.ReferencedClass = val,
						obj => OnReferencedClass_IsValid), 
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
        [EventBasedMethod("OnToString_CalculatedObjectReferenceProperty")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_CalculatedObjectReferenceProperty != null)
            {
                OnToString_CalculatedObjectReferenceProperty(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<CalculatedObjectReferenceProperty> OnToString_CalculatedObjectReferenceProperty;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_CalculatedObjectReferenceProperty")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_CalculatedObjectReferenceProperty != null)
            {
                OnObjectIsValid_CalculatedObjectReferenceProperty(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<CalculatedObjectReferenceProperty> OnObjectIsValid_CalculatedObjectReferenceProperty;

        [EventBasedMethod("OnNotifyPreSave_CalculatedObjectReferenceProperty")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_CalculatedObjectReferenceProperty != null) OnNotifyPreSave_CalculatedObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<CalculatedObjectReferenceProperty> OnNotifyPreSave_CalculatedObjectReferenceProperty;

        [EventBasedMethod("OnNotifyPostSave_CalculatedObjectReferenceProperty")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_CalculatedObjectReferenceProperty != null) OnNotifyPostSave_CalculatedObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<CalculatedObjectReferenceProperty> OnNotifyPostSave_CalculatedObjectReferenceProperty;

        [EventBasedMethod("OnNotifyCreated_CalculatedObjectReferenceProperty")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("ReferencedClass");
            base.NotifyCreated();
            if (OnNotifyCreated_CalculatedObjectReferenceProperty != null) OnNotifyCreated_CalculatedObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<CalculatedObjectReferenceProperty> OnNotifyCreated_CalculatedObjectReferenceProperty;

        [EventBasedMethod("OnNotifyDeleting_CalculatedObjectReferenceProperty")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_CalculatedObjectReferenceProperty != null) OnNotifyDeleting_CalculatedObjectReferenceProperty(this);
            Inputs.Clear();
        }
        public static event ObjectEventHandler<CalculatedObjectReferenceProperty> OnNotifyDeleting_CalculatedObjectReferenceProperty;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;

            binStream.Write(eagerLoadLists);
            if (eagerLoadLists && auxObjects != null)
            {
                foreach(var obj in Inputs)
                {
                    auxObjects.Add(obj);
                }
            }
            binStream.Write(ReferencedClass != null ? ReferencedClass.ID : (int?)null);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {

            Inputs_was_eagerLoaded = binStream.ReadBoolean();
            this._fk_ReferencedClass = binStream.ReadNullableInt32();
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
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(ReferencedClass != null ? ReferencedClass.ExportGuid : (Guid?)null, xml, "ReferencedClass", "Zetbox.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Base|ReferencedClass":
                this._fk_guid_ReferencedClass = XmlStreamer.ReadNullableGuid(xml);
                break;
            }
        }

        #endregion

    }
}