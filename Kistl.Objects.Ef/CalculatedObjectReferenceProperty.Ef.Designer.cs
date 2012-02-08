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

    using Kistl.API.Server;
    using Kistl.DalProvider.Ef;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// a object reference that is calculated from the contents of the containing class
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="CalculatedObjectReferenceProperty")]
    [System.Diagnostics.DebuggerDisplay("CalculatedObjectReferenceProperty")]
    public class CalculatedObjectReferencePropertyEfImpl : Kistl.App.Base.PropertyEfImpl, CalculatedObjectReferenceProperty
    {
        [Obsolete]
        public CalculatedObjectReferencePropertyEfImpl()
            : base(null)
        {
        }

        public CalculatedObjectReferencePropertyEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// The properties on which the calculation depends. This is used to propagate change notifications.
        /// </summary>
    /*
    Relation: FK_CalculatedReference_dependsOn_InputProperties
    A: ZeroOrMore CalculatedObjectReferenceProperty as CalculatedReference
    B: ZeroOrMore Property as InputProperties
    Preferred Storage: Separate
    */
        // collection reference property
        // Kistl.DalProvider.Ef.Generator.Templates.Properties.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Base.Property> Inputs
        {
            get
            {
                if (_Inputs == null)
                {
                    _Inputs = new BSideCollectionWrapper<Kistl.App.Base.CalculatedObjectReferenceProperty, Kistl.App.Base.Property, Kistl.App.Base.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryEfImpl, EntityCollection<Kistl.App.Base.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryEfImpl>>(
                            this,
                            InputsImpl);
                }
                return _Inputs;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_CalculatedReference_dependsOn_InputProperties_A", "CollectionEntry")]
        public EntityCollection<Kistl.App.Base.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryEfImpl> InputsImpl
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Base.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryEfImpl>(
                        "Model.FK_CalculatedReference_dependsOn_InputProperties_A",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                c.ForEach(i => i.AttachToContext(Context));
                return c;
            }
        }
        private BSideCollectionWrapper<Kistl.App.Base.CalculatedObjectReferenceProperty, Kistl.App.Base.Property, Kistl.App.Base.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryEfImpl, EntityCollection<Kistl.App.Base.CalculatedObjectReferenceProperty_dependsOn_Property_RelationEntryEfImpl>> _Inputs;
        private bool Inputs_was_eagerLoaded = false;

        public event PropertyIsValidHandler<Kistl.App.Base.CalculatedObjectReferenceProperty> OnInputs_IsValid;

        /// <summary>
        /// the referenced class of objects
        /// </summary>
    /*
    Relation: FK_CalculatedReference_references_ReferencedClass
    A: ZeroOrMore CalculatedObjectReferenceProperty as CalculatedReference
    B: One ObjectClass as ReferencedClass
    Preferred Storage: MergeIntoA
    */
        // object reference property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ReferencedClass
        // fkBackingName=_fk_ReferencedClass; fkGuidBackingName=_fk_guid_ReferencedClass;
        // referencedInterface=Kistl.App.Base.ObjectClass; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.ObjectClass ReferencedClass
        {
            get { return ReferencedClassImpl; }
            set { ReferencedClassImpl = (Kistl.App.Base.ObjectClassEfImpl)value; }
        }

        private int? _fk_ReferencedClass;

        private Guid? _fk_guid_ReferencedClass = null;

        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_CalculatedReference_references_ReferencedClass", "ReferencedClass")]
        public Kistl.App.Base.ObjectClassEfImpl ReferencedClassImpl
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Base.ObjectClassEfImpl __value;
                EntityReference<Kistl.App.Base.ObjectClassEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClassEfImpl>(
                        "Model.FK_CalculatedReference_references_ReferencedClass",
                        "ReferencedClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                if (r.Value != null) r.Value.AttachToContext(this.Context);
                __value = r.Value;
                if (OnReferencedClass_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.ObjectClass>(__value);
                    OnReferencedClass_Getter(this, e);
                    __value = (Kistl.App.Base.ObjectClassEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                EntityReference<Kistl.App.Base.ObjectClassEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClassEfImpl>(
                        "Model.FK_CalculatedReference_references_ReferencedClass",
                        "ReferencedClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Kistl.App.Base.ObjectClassEfImpl __oldValue = (Kistl.App.Base.ObjectClassEfImpl)r.Value;
                Kistl.App.Base.ObjectClassEfImpl __newValue = (Kistl.App.Base.ObjectClassEfImpl)value;

                // Changing Event fires before anything is touched
                // navigators may not be notified to entity framework
                NotifyPropertyChanging("ReferencedClass", null, __oldValue, __newValue);

                if (OnReferencedClass_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.ObjectClass>(__oldValue, __newValue);
                    OnReferencedClass_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.ObjectClassEfImpl)e.Result;
                }

                r.Value = (Kistl.App.Base.ObjectClassEfImpl)__newValue;

                if (OnReferencedClass_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.ObjectClass>(__oldValue, __newValue);
                    OnReferencedClass_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                // navigators may not be notified to entity framework
                NotifyPropertyChanged("ReferencedClass", null, __oldValue, __newValue);
            }
        }

        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ReferencedClass
		public static event PropertyGetterHandler<Kistl.App.Base.CalculatedObjectReferenceProperty, Kistl.App.Base.ObjectClass> OnReferencedClass_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.CalculatedObjectReferenceProperty, Kistl.App.Base.ObjectClass> OnReferencedClass_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.CalculatedObjectReferenceProperty, Kistl.App.Base.ObjectClass> OnReferencedClass_PostSetter;

        public event PropertyIsValidHandler<Kistl.App.Base.CalculatedObjectReferenceProperty> OnReferencedClass_IsValid;

        /// <summary>
        /// The element type for multi-valued properties. The property type string in all other cases.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
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
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
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
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
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
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
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
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
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
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(CalculatedObjectReferenceProperty);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (CalculatedObjectReferenceProperty)obj;
            var otherImpl = (CalculatedObjectReferencePropertyEfImpl)obj;
            var me = (CalculatedObjectReferenceProperty)this;

            this._fk_ReferencedClass = otherImpl._fk_ReferencedClass;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_guid_ReferencedClass.HasValue)
                ReferencedClassImpl = (Kistl.App.Base.ObjectClassEfImpl)Context.FindPersistenceObject<Kistl.App.Base.ObjectClass>(_fk_guid_ReferencedClass.Value);
            else
            if (_fk_ReferencedClass.HasValue)
                ReferencedClassImpl = (Kistl.App.Base.ObjectClassEfImpl)Context.Find<Kistl.App.Base.ObjectClass>(_fk_ReferencedClass.Value);
            else
                ReferencedClassImpl = null;
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
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorEfImpl<CalculatedObjectReferenceProperty, ICollection<Kistl.App.Base.Property>>(
                        lazyCtx,
                        new Guid("bfda6511-087d-4381-9780-1f76f3abcffe"),
                        "Inputs",
                        null,
                        obj => obj.Inputs,
                        null, // lists are read-only properties
                        obj => ((CalculatedObjectReferencePropertyEfImpl)obj).OnInputs_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<CalculatedObjectReferenceProperty, Kistl.App.Base.ObjectClass>(
                        lazyCtx,
                        new Guid("cd62d769-0752-4a72-832f-5935ece1198b"),
                        "ReferencedClass",
                        null,
                        obj => ((CalculatedObjectReferencePropertyEfImpl)obj).ReferencedClass,
                        (obj, val) => obj.ReferencedClass = val,
						obj => ((CalculatedObjectReferencePropertyEfImpl)obj).OnReferencedClass_IsValid), 
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

        [EventBasedMethod("OnPreSave_CalculatedObjectReferenceProperty")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_CalculatedObjectReferenceProperty != null) OnPreSave_CalculatedObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<CalculatedObjectReferenceProperty> OnPreSave_CalculatedObjectReferenceProperty;

        [EventBasedMethod("OnPostSave_CalculatedObjectReferenceProperty")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_CalculatedObjectReferenceProperty != null) OnPostSave_CalculatedObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<CalculatedObjectReferenceProperty> OnPostSave_CalculatedObjectReferenceProperty;

        [EventBasedMethod("OnCreated_CalculatedObjectReferenceProperty")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_CalculatedObjectReferenceProperty != null) OnCreated_CalculatedObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<CalculatedObjectReferenceProperty> OnCreated_CalculatedObjectReferenceProperty;

        [EventBasedMethod("OnDeleting_CalculatedObjectReferenceProperty")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_CalculatedObjectReferenceProperty != null) OnDeleting_CalculatedObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<CalculatedObjectReferenceProperty> OnDeleting_CalculatedObjectReferenceProperty;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;

			BinarySerializer.ToStream(eagerLoadLists, binStream);
			if (eagerLoadLists && auxObjects != null)
			{
				foreach(var obj in Inputs)
				{
					auxObjects.Add(obj);
				}
				foreach(var relEntry in InputsImpl)
				{
					auxObjects.Add(relEntry);
				}
			}
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClassEfImpl>("Model.FK_CalculatedReference_references_ReferencedClass", "ReferencedClass").EntityKey;
                BinarySerializer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, binStream);
            }
			if (auxObjects != null) {
				auxObjects.Add(ReferencedClass);
			}
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {

			BinarySerializer.FromStream(out Inputs_was_eagerLoaded, binStream);
            BinarySerializer.FromStream(out this._fk_ReferencedClass, binStream);
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
            {
                var key = this.RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClassEfImpl>("Model.FK_CalculatedReference_references_ReferencedClass", "ReferencedClass").EntityKey;
                XmlStreamer.ToStream(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null, xml, "ReferencedClass", "Kistl.App.Base");
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._fk_ReferencedClass, xml, "ReferencedClass", "Kistl.App.Base");
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(ReferencedClass != null ? ReferencedClass.ExportGuid : (Guid?)null, xml, "ReferencedClass", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.FromStream(ref this._fk_guid_ReferencedClass, xml, "ReferencedClass", "Kistl.App.Base");
        }

        #endregion

    }
}