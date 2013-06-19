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

    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Zetbox.API.Server;
    using Zetbox.DalProvider.Ef;

    /// <summary>
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="VisualEfImpl")]
    [System.Diagnostics.DebuggerDisplay("Visual")]
    public class VisualEfImpl : BaseServerDataObject_EntityFramework, Visual
    {
        private static readonly Guid _objectClassID = new Guid("98790e5d-808f-4e0b-8a1a-b304839f07ab");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public VisualEfImpl()
            : base(null)
        {
        }

        public VisualEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// if this is a container, here are the visually contained/controlled children of this Visual
        /// </summary>
    /*
    Relation: FK_Visual_contains_Children
    A: ZeroOrMore Visual as Visual
    B: ZeroOrMore Visual as Children
    Preferred Storage: Separate
    */
        // collection reference property
        // Zetbox.DalProvider.Ef.Generator.Templates.Properties.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Zetbox.App.GUI.Visual> Children
        {
            get
            {
                if (_Children == null)
                {
                    _Children = new BSideCollectionWrapper<Zetbox.App.GUI.Visual, Zetbox.App.GUI.Visual, Zetbox.App.GUI.Visual_contains_Visual_RelationEntryEfImpl, EntityCollection<Zetbox.App.GUI.Visual_contains_Visual_RelationEntryEfImpl>>(
                            this,
                            ChildrenImpl);
                }
                return _Children;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Visual_contains_Children_A", "CollectionEntry")]
        public EntityCollection<Zetbox.App.GUI.Visual_contains_Visual_RelationEntryEfImpl> ChildrenImpl
        {
            get
            {
                var c = GetChildrenImplCollection();
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }

        private EntityCollection<Zetbox.App.GUI.Visual_contains_Visual_RelationEntryEfImpl> _ChildrenImplEntityCollection;
        internal EntityCollection<Zetbox.App.GUI.Visual_contains_Visual_RelationEntryEfImpl> GetChildrenImplCollection()
        {
            if (_ChildrenImplEntityCollection == null)
            {
                _ChildrenImplEntityCollection
                    = ((IEntityWithRelationships)(this)).RelationshipManager
                        .GetRelatedCollection<Zetbox.App.GUI.Visual_contains_Visual_RelationEntryEfImpl>(
                            "Model.FK_Visual_contains_Children_A",
                            "CollectionEntry");
                _ChildrenImplEntityCollection.AssociationChanged += (s, e) => { this.NotifyPropertyChanged("Children", null, null); if(OnChildren_PostSetter != null && IsAttached) OnChildren_PostSetter(this); };
            }
            return _ChildrenImplEntityCollection;
        }
        private BSideCollectionWrapper<Zetbox.App.GUI.Visual, Zetbox.App.GUI.Visual, Zetbox.App.GUI.Visual_contains_Visual_RelationEntryEfImpl, EntityCollection<Zetbox.App.GUI.Visual_contains_Visual_RelationEntryEfImpl>> _Children;

        public Zetbox.API.Async.ZbTask TriggerFetchChildrenAsync()
        {
            return new Zetbox.API.Async.ZbTask<ICollection<Zetbox.App.GUI.Visual>>(this.Children);
        }

public static event PropertyListChangedHandler<Zetbox.App.GUI.Visual> OnChildren_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.Visual> OnChildren_IsValid;

        /// <summary>
        /// The context menu for this Visual
        /// </summary>
    /*
    Relation: FK_Visual_hasContextMenu_ContextMenu
    A: ZeroOrMore Visual as Visual
    B: ZeroOrMore Visual as ContextMenu
    Preferred Storage: Separate
    */
        // collection reference property
        // Zetbox.DalProvider.Ef.Generator.Templates.Properties.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Zetbox.App.GUI.Visual> ContextMenu
        {
            get
            {
                if (_ContextMenu == null)
                {
                    _ContextMenu = new BSideCollectionWrapper<Zetbox.App.GUI.Visual, Zetbox.App.GUI.Visual, Zetbox.App.GUI.Visual_hasContextMenu_Visual_RelationEntryEfImpl, EntityCollection<Zetbox.App.GUI.Visual_hasContextMenu_Visual_RelationEntryEfImpl>>(
                            this,
                            ContextMenuImpl);
                }
                return _ContextMenu;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Visual_hasContextMenu_ContextMenu_A", "CollectionEntry")]
        public EntityCollection<Zetbox.App.GUI.Visual_hasContextMenu_Visual_RelationEntryEfImpl> ContextMenuImpl
        {
            get
            {
                var c = GetContextMenuImplCollection();
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }

        private EntityCollection<Zetbox.App.GUI.Visual_hasContextMenu_Visual_RelationEntryEfImpl> _ContextMenuImplEntityCollection;
        internal EntityCollection<Zetbox.App.GUI.Visual_hasContextMenu_Visual_RelationEntryEfImpl> GetContextMenuImplCollection()
        {
            if (_ContextMenuImplEntityCollection == null)
            {
                _ContextMenuImplEntityCollection
                    = ((IEntityWithRelationships)(this)).RelationshipManager
                        .GetRelatedCollection<Zetbox.App.GUI.Visual_hasContextMenu_Visual_RelationEntryEfImpl>(
                            "Model.FK_Visual_hasContextMenu_ContextMenu_A",
                            "CollectionEntry");
                _ContextMenuImplEntityCollection.AssociationChanged += (s, e) => { this.NotifyPropertyChanged("ContextMenu", null, null); if(OnContextMenu_PostSetter != null && IsAttached) OnContextMenu_PostSetter(this); };
            }
            return _ContextMenuImplEntityCollection;
        }
        private BSideCollectionWrapper<Zetbox.App.GUI.Visual, Zetbox.App.GUI.Visual, Zetbox.App.GUI.Visual_hasContextMenu_Visual_RelationEntryEfImpl, EntityCollection<Zetbox.App.GUI.Visual_hasContextMenu_Visual_RelationEntryEfImpl>> _ContextMenu;

        public Zetbox.API.Async.ZbTask TriggerFetchContextMenuAsync()
        {
            return new Zetbox.API.Async.ZbTask<ICollection<Zetbox.App.GUI.Visual>>(this.ContextMenu);
        }

public static event PropertyListChangedHandler<Zetbox.App.GUI.Visual> OnContextMenu_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.Visual> OnContextMenu_IsValid;

        /// <summary>
        /// A short description of the utility of this visual
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public string Description
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Description;
                if (OnDescription_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnDescription_Getter(this, __e);
                    __result = _Description = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Description != value)
                {
                    var __oldValue = _Description;
                    var __newValue = value;
                    if (OnDescription_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnDescription_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Description", __oldValue, __newValue);
                    _Description = __newValue;
                    NotifyPropertyChanged("Description", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnDescription_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnDescription_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("Description");
                }
            }
        }
        private string _Description_store;
        private string _Description {
            get { return _Description_store; }
            set {
                ReportEfPropertyChanging("Description");
                _Description_store = value;
                ReportEfPropertyChanged("Description");
            }
        }
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.GUI.Visual, string> OnDescription_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.Visual, string> OnDescription_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.Visual, string> OnDescription_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.Visual> OnDescription_IsValid;

        /// <summary>
        /// The Method whose return value shoud be displayed
        /// </summary>
    /*
    Relation: FK_Visual_has_Method
    A: ZeroOrMore Visual as Visual
    B: ZeroOrOne Method as Method
    Preferred Storage: MergeIntoA
    */
        // object reference property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Method
        // fkBackingName=_fk_Method; fkGuidBackingName=_fk_guid_Method;
        // referencedInterface=Zetbox.App.Base.Method; moduleNamespace=Zetbox.App.GUI;
        // no inverse navigator handling
        // PositionStorage=none;
        // Target not exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Base.Method Method
        {
            get { return MethodImpl; }
            set { MethodImpl = (Zetbox.App.Base.MethodEfImpl)value; }
        }

        private int? _fk_Method;


        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Visual_has_Method", "Method")]
        public Zetbox.App.Base.MethodEfImpl MethodImpl
        {
            get
            {
                Zetbox.App.Base.MethodEfImpl __value;
                EntityReference<Zetbox.App.Base.MethodEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.Base.MethodEfImpl>(
                        "Model.FK_Visual_has_Method",
                        "Method");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                __value = r.Value;
                if (OnMethod_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.Method>(__value);
                    OnMethod_Getter(this, e);
                    __value = (Zetbox.App.Base.MethodEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                EntityReference<Zetbox.App.Base.MethodEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.Base.MethodEfImpl>(
                        "Model.FK_Visual_has_Method",
                        "Method");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Zetbox.App.Base.MethodEfImpl __oldValue = (Zetbox.App.Base.MethodEfImpl)r.Value;
                Zetbox.App.Base.MethodEfImpl __newValue = (Zetbox.App.Base.MethodEfImpl)value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Method", __oldValue, __newValue);

                if (OnMethod_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.Method>(__oldValue, __newValue);
                    OnMethod_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.MethodEfImpl)e.Result;
                }

                r.Value = (Zetbox.App.Base.MethodEfImpl)__newValue;

                if (OnMethod_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.Method>(__oldValue, __newValue);
                    OnMethod_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Method", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;
            }
        }

        public Zetbox.API.Async.ZbTask TriggerFetchMethodAsync()
        {
            return new Zetbox.API.Async.ZbTask<Zetbox.App.Base.Method>(this.Method);
        }

        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Method
		public static event PropertyGetterHandler<Zetbox.App.GUI.Visual, Zetbox.App.Base.Method> OnMethod_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.Visual, Zetbox.App.Base.Method> OnMethod_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.Visual, Zetbox.App.Base.Method> OnMethod_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.Visual> OnMethod_IsValid;

        /// <summary>
        /// The Property to display
        /// </summary>
    /*
    Relation: FK_Visual_has_Property
    A: ZeroOrMore Visual as Visual
    B: ZeroOrOne Property as Property
    Preferred Storage: MergeIntoA
    */
        // object reference property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Property
        // fkBackingName=_fk_Property; fkGuidBackingName=_fk_guid_Property;
        // referencedInterface=Zetbox.App.Base.Property; moduleNamespace=Zetbox.App.GUI;
        // no inverse navigator handling
        // PositionStorage=none;
        // Target not exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Base.Property Property
        {
            get { return PropertyImpl; }
            set { PropertyImpl = (Zetbox.App.Base.PropertyEfImpl)value; }
        }

        private int? _fk_Property;


        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Visual_has_Property", "Property")]
        public Zetbox.App.Base.PropertyEfImpl PropertyImpl
        {
            get
            {
                Zetbox.App.Base.PropertyEfImpl __value;
                EntityReference<Zetbox.App.Base.PropertyEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.Base.PropertyEfImpl>(
                        "Model.FK_Visual_has_Property",
                        "Property");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                __value = r.Value;
                if (OnProperty_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.Property>(__value);
                    OnProperty_Getter(this, e);
                    __value = (Zetbox.App.Base.PropertyEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                EntityReference<Zetbox.App.Base.PropertyEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.Base.PropertyEfImpl>(
                        "Model.FK_Visual_has_Property",
                        "Property");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Zetbox.App.Base.PropertyEfImpl __oldValue = (Zetbox.App.Base.PropertyEfImpl)r.Value;
                Zetbox.App.Base.PropertyEfImpl __newValue = (Zetbox.App.Base.PropertyEfImpl)value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Property", __oldValue, __newValue);

                if (OnProperty_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.Property>(__oldValue, __newValue);
                    OnProperty_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.PropertyEfImpl)e.Result;
                }

                r.Value = (Zetbox.App.Base.PropertyEfImpl)__newValue;

                if (OnProperty_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.Property>(__oldValue, __newValue);
                    OnProperty_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Property", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;
            }
        }

        public Zetbox.API.Async.ZbTask TriggerFetchPropertyAsync()
        {
            return new Zetbox.API.Async.ZbTask<Zetbox.App.Base.Property>(this.Property);
        }

        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Property
		public static event PropertyGetterHandler<Zetbox.App.GUI.Visual, Zetbox.App.Base.Property> OnProperty_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.Visual, Zetbox.App.Base.Property> OnProperty_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.Visual, Zetbox.App.Base.Property> OnProperty_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.Visual> OnProperty_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(Visual);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (Visual)obj;
            var otherImpl = (VisualEfImpl)obj;
            var me = (Visual)this;

            me.Description = other.Description;
            this._fk_Method = otherImpl._fk_Method;
            this._fk_Property = otherImpl._fk_Property;
        }
        public override void SetNew()
        {
            base.SetNew();
        }
        #region Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "Description":
                case "Method":
                case "Property":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }

        protected override bool ShouldSetModified(string property)
        {
            switch (property)
            {
                case "Children":
                case "ContextMenu":
                    return false;
                default:
                    return base.ShouldSetModified(property);
            }
        }
        #endregion // Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

        public override Zetbox.API.Async.ZbTask TriggerFetch(string propName)
        {
            switch(propName)
            {
            case "Children":
                return TriggerFetchChildrenAsync();
            case "ContextMenu":
                return TriggerFetchContextMenuAsync();
            case "Method":
                return TriggerFetchMethodAsync();
            case "Property":
                return TriggerFetchPropertyAsync();
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

            if (_fk_Method.HasValue)
                MethodImpl = (Zetbox.App.Base.MethodEfImpl)Context.Find<Zetbox.App.Base.Method>(_fk_Method.Value);
            else
                MethodImpl = null;

            if (_fk_Property.HasValue)
                PropertyImpl = (Zetbox.App.Base.PropertyEfImpl)Context.Find<Zetbox.App.Base.Property>(_fk_Property.Value);
            else
                PropertyImpl = null;
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
                    new PropertyDescriptorEfImpl<Visual, ICollection<Zetbox.App.GUI.Visual>>(
                        lazyCtx,
                        new Guid("9f69c3bd-e274-4639-b30c-8d2a9599917b"),
                        "Children",
                        null,
                        obj => obj.Children,
                        null, // lists are read-only properties
                        obj => OnChildren_IsValid), 
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorEfImpl<Visual, ICollection<Zetbox.App.GUI.Visual>>(
                        lazyCtx,
                        new Guid("7b18f26e-0f3f-4554-b469-1029bd4ca10b"),
                        "ContextMenu",
                        null,
                        obj => obj.ContextMenu,
                        null, // lists are read-only properties
                        obj => OnContextMenu_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<Visual, string>(
                        lazyCtx,
                        new Guid("8d3b7c91-2bbf-4dcf-bc37-318dc0fda92d"),
                        "Description",
                        null,
                        obj => obj.Description,
                        (obj, val) => obj.Description = val,
						obj => OnDescription_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<Visual, Zetbox.App.Base.Method>(
                        lazyCtx,
                        new Guid("0b55b2ba-3ac0-4631-8a73-1e8846c8e9b1"),
                        "Method",
                        null,
                        obj => obj.Method,
                        (obj, val) => obj.Method = val,
						obj => OnMethod_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<Visual, Zetbox.App.Base.Property>(
                        lazyCtx,
                        new Guid("a432e3ff-61ed-4726-8559-f34516181065"),
                        "Property",
                        null,
                        obj => obj.Property,
                        (obj, val) => obj.Property = val,
						obj => OnProperty_IsValid), 
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
        [EventBasedMethod("OnToString_Visual")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Visual != null)
            {
                OnToString_Visual(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<Visual> OnToString_Visual;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_Visual")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_Visual != null)
            {
                OnObjectIsValid_Visual(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<Visual> OnObjectIsValid_Visual;

        [EventBasedMethod("OnNotifyPreSave_Visual")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_Visual != null) OnNotifyPreSave_Visual(this);
        }
        public static event ObjectEventHandler<Visual> OnNotifyPreSave_Visual;

        [EventBasedMethod("OnNotifyPostSave_Visual")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_Visual != null) OnNotifyPostSave_Visual(this);
        }
        public static event ObjectEventHandler<Visual> OnNotifyPostSave_Visual;

        [EventBasedMethod("OnNotifyCreated_Visual")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Description");
            SetNotInitializedProperty("Method");
            SetNotInitializedProperty("Property");
            base.NotifyCreated();
            if (OnNotifyCreated_Visual != null) OnNotifyCreated_Visual(this);
        }
        public static event ObjectEventHandler<Visual> OnNotifyCreated_Visual;

        [EventBasedMethod("OnNotifyDeleting_Visual")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_Visual != null) OnNotifyDeleting_Visual(this);
            Children.Clear();
            ContextMenu.Clear();
            Method = null;
            Property = null;
        }
        public static event ObjectEventHandler<Visual> OnNotifyDeleting_Visual;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.IdProperty
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        public override int ID
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ID;
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_ID != value)
                {
                    var __oldValue = _ID;
                    var __newValue = value;
                    NotifyPropertyChanging("ID", __oldValue, __newValue);
                    _ID = __newValue;
                    NotifyPropertyChanged("ID", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                }
                else
                {
                    SetInitializedProperty("ID");
                }
            }
        }
        private int _ID;
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.IdProperty

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._Description);
            {
                var r = this.RelationshipManager.GetRelatedReference<Zetbox.App.Base.MethodEfImpl>("Model.FK_Visual_has_Method", "Method");
                var key = r.EntityKey;
                binStream.Write(r.Value != null ? r.Value.ID : (key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null));
            }
            {
                var r = this.RelationshipManager.GetRelatedReference<Zetbox.App.Base.PropertyEfImpl>("Model.FK_Visual_has_Property", "Property");
                var key = r.EntityKey;
                binStream.Write(r.Value != null ? r.Value.ID : (key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null));
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._Description = binStream.ReadString();
            binStream.Read(out this._fk_Method);
            binStream.Read(out this._fk_Property);
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