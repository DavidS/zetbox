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
    [EdmEntityType(NamespaceName="Model", Name="Template")]
    [System.Diagnostics.DebuggerDisplay("Template")]
    public class TemplateEfImpl : BaseServerDataObject_EntityFramework, Template
    {
        private static readonly Guid _objectClassID = new Guid("c677d3fe-7dfe-4ea5-91e0-d1b0df9118be");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public TemplateEfImpl()
            : base(null)
        {
        }

        public TemplateEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// Assembly of the Type that is displayed with this Template
        /// </summary>
    /*
    Relation: FK_Template_has_DisplayedTypeAssembly
    A: ZeroOrMore Template as Template
    B: ZeroOrOne Assembly as DisplayedTypeAssembly
    Preferred Storage: MergeIntoA
    */
        // object reference property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for DisplayedTypeAssembly
        // fkBackingName=_fk_DisplayedTypeAssembly; fkGuidBackingName=_fk_guid_DisplayedTypeAssembly;
        // referencedInterface=Zetbox.App.Base.Assembly; moduleNamespace=Zetbox.App.GUI;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target not exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Base.Assembly DisplayedTypeAssembly
        {
            get { return DisplayedTypeAssemblyImpl; }
            set { DisplayedTypeAssemblyImpl = (Zetbox.App.Base.AssemblyEfImpl)value; }
        }

        private int? _fk_DisplayedTypeAssembly;


        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Template_has_DisplayedTypeAssembly", "DisplayedTypeAssembly")]
        public Zetbox.App.Base.AssemblyEfImpl DisplayedTypeAssemblyImpl
        {
            get
            {
                Zetbox.App.Base.AssemblyEfImpl __value;
                EntityReference<Zetbox.App.Base.AssemblyEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.Base.AssemblyEfImpl>(
                        "Model.FK_Template_has_DisplayedTypeAssembly",
                        "DisplayedTypeAssembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                // TODO: Remove this
                if (r.Value != null) r.Value.AttachToContext(this.Context, null);
                __value = r.Value;
                if (OnDisplayedTypeAssembly_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.Assembly>(__value);
                    OnDisplayedTypeAssembly_Getter(this, e);
                    __value = (Zetbox.App.Base.AssemblyEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                EntityReference<Zetbox.App.Base.AssemblyEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.Base.AssemblyEfImpl>(
                        "Model.FK_Template_has_DisplayedTypeAssembly",
                        "DisplayedTypeAssembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Zetbox.App.Base.AssemblyEfImpl __oldValue = (Zetbox.App.Base.AssemblyEfImpl)r.Value;
                Zetbox.App.Base.AssemblyEfImpl __newValue = (Zetbox.App.Base.AssemblyEfImpl)value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("DisplayedTypeAssembly", __oldValue, __newValue);

                if (OnDisplayedTypeAssembly_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.Assembly>(__oldValue, __newValue);
                    OnDisplayedTypeAssembly_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.AssemblyEfImpl)e.Result;
                }

                r.Value = (Zetbox.App.Base.AssemblyEfImpl)__newValue;

                if (OnDisplayedTypeAssembly_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.Assembly>(__oldValue, __newValue);
                    OnDisplayedTypeAssembly_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("DisplayedTypeAssembly", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;
            }
        }

        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for DisplayedTypeAssembly
		public static event PropertyGetterHandler<Zetbox.App.GUI.Template, Zetbox.App.Base.Assembly> OnDisplayedTypeAssembly_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.Template, Zetbox.App.Base.Assembly> OnDisplayedTypeAssembly_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.Template, Zetbox.App.Base.Assembly> OnDisplayedTypeAssembly_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.Template> OnDisplayedTypeAssembly_IsValid;

        /// <summary>
        /// FullName of the Type that is displayed with this Template
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public string DisplayedTypeFullName
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _DisplayedTypeFullName;
                if (OnDisplayedTypeFullName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnDisplayedTypeFullName_Getter(this, __e);
                    __result = _DisplayedTypeFullName = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_DisplayedTypeFullName != value)
                {
                    var __oldValue = _DisplayedTypeFullName;
                    var __newValue = value;
                    if (OnDisplayedTypeFullName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnDisplayedTypeFullName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("DisplayedTypeFullName", __oldValue, __newValue);
                    _DisplayedTypeFullName = __newValue;
                    NotifyPropertyChanged("DisplayedTypeFullName", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnDisplayedTypeFullName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnDisplayedTypeFullName_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("DisplayedTypeFullName");
				}
            }
        }
        private string _DisplayedTypeFullName_store;
        private string _DisplayedTypeFullName {
            get { return _DisplayedTypeFullName_store; }
            set {
                ReportEfPropertyChanging("DisplayedTypeFullName");
                _DisplayedTypeFullName_store = value;
                ReportEfPropertyChanged("DisplayedTypeFullName");
            }
        }
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.GUI.Template, string> OnDisplayedTypeFullName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.Template, string> OnDisplayedTypeFullName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.Template, string> OnDisplayedTypeFullName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.Template> OnDisplayedTypeFullName_IsValid;

        /// <summary>
        /// a short name to identify this Template to the user
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public string DisplayName
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _DisplayName;
                if (OnDisplayName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnDisplayName_Getter(this, __e);
                    __result = _DisplayName = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_DisplayName != value)
                {
                    var __oldValue = _DisplayName;
                    var __newValue = value;
                    if (OnDisplayName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnDisplayName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("DisplayName", __oldValue, __newValue);
                    _DisplayName = __newValue;
                    NotifyPropertyChanged("DisplayName", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnDisplayName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnDisplayName_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("DisplayName");
				}
            }
        }
        private string _DisplayName_store;
        private string _DisplayName {
            get { return _DisplayName_store; }
            set {
                ReportEfPropertyChanging("DisplayName");
                _DisplayName_store = value;
                ReportEfPropertyChanged("DisplayName");
            }
        }
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.GUI.Template, string> OnDisplayName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.Template, string> OnDisplayName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.Template, string> OnDisplayName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.Template> OnDisplayName_IsValid;

        /// <summary>
        /// The main menu for this Template
        /// </summary>
    /*
    Relation: FK_Template_hasMenu_Menu
    A: ZeroOrMore Template as Template
    B: ZeroOrMore Visual as Menu
    Preferred Storage: Separate
    */
        // collection reference property
        // Zetbox.DalProvider.Ef.Generator.Templates.Properties.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Zetbox.App.GUI.Visual> Menu
        {
            get
            {
                if (_Menu == null)
                {
                    _Menu = new BSideCollectionWrapper<Zetbox.App.GUI.Template, Zetbox.App.GUI.Visual, Zetbox.App.GUI.Template_hasMenu_Visual_RelationEntryEfImpl, EntityCollection<Zetbox.App.GUI.Template_hasMenu_Visual_RelationEntryEfImpl>>(
                            this,
                            MenuImpl);
                }
                return _Menu;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Template_hasMenu_Menu_A", "CollectionEntry")]
        public EntityCollection<Zetbox.App.GUI.Template_hasMenu_Visual_RelationEntryEfImpl> MenuImpl
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Zetbox.App.GUI.Template_hasMenu_Visual_RelationEntryEfImpl>(
                        "Model.FK_Template_hasMenu_Menu_A",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                // TODO: Remove this
                c.ForEach(i => i.AttachToContext(Context, null));
                return c;
            }
        }
        private BSideCollectionWrapper<Zetbox.App.GUI.Template, Zetbox.App.GUI.Visual, Zetbox.App.GUI.Template_hasMenu_Visual_RelationEntryEfImpl, EntityCollection<Zetbox.App.GUI.Template_hasMenu_Visual_RelationEntryEfImpl>> _Menu;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.Template> OnMenu_IsValid;

        /// <summary>
        /// The visual representation of this Template
        /// </summary>
    /*
    Relation: FK_Template_has_VisualTree
    A: ZeroOrMore Template as Template
    B: ZeroOrOne Visual as VisualTree
    Preferred Storage: MergeIntoA
    */
        // object reference property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for VisualTree
        // fkBackingName=_fk_VisualTree; fkGuidBackingName=_fk_guid_VisualTree;
        // referencedInterface=Zetbox.App.GUI.Visual; moduleNamespace=Zetbox.App.GUI;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target not exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.GUI.Visual VisualTree
        {
            get { return VisualTreeImpl; }
            set { VisualTreeImpl = (Zetbox.App.GUI.VisualEfImpl)value; }
        }

        private int? _fk_VisualTree;


        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Template_has_VisualTree", "VisualTree")]
        public Zetbox.App.GUI.VisualEfImpl VisualTreeImpl
        {
            get
            {
                Zetbox.App.GUI.VisualEfImpl __value;
                EntityReference<Zetbox.App.GUI.VisualEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.GUI.VisualEfImpl>(
                        "Model.FK_Template_has_VisualTree",
                        "VisualTree");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                // TODO: Remove this
                if (r.Value != null) r.Value.AttachToContext(this.Context, null);
                __value = r.Value;
                if (OnVisualTree_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.GUI.Visual>(__value);
                    OnVisualTree_Getter(this, e);
                    __value = (Zetbox.App.GUI.VisualEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                EntityReference<Zetbox.App.GUI.VisualEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.GUI.VisualEfImpl>(
                        "Model.FK_Template_has_VisualTree",
                        "VisualTree");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Zetbox.App.GUI.VisualEfImpl __oldValue = (Zetbox.App.GUI.VisualEfImpl)r.Value;
                Zetbox.App.GUI.VisualEfImpl __newValue = (Zetbox.App.GUI.VisualEfImpl)value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("VisualTree", __oldValue, __newValue);

                if (OnVisualTree_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.GUI.Visual>(__oldValue, __newValue);
                    OnVisualTree_PreSetter(this, e);
                    __newValue = (Zetbox.App.GUI.VisualEfImpl)e.Result;
                }

                r.Value = (Zetbox.App.GUI.VisualEfImpl)__newValue;

                if (OnVisualTree_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.GUI.Visual>(__oldValue, __newValue);
                    OnVisualTree_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("VisualTree", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;
            }
        }

        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for VisualTree
		public static event PropertyGetterHandler<Zetbox.App.GUI.Template, Zetbox.App.GUI.Visual> OnVisualTree_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.Template, Zetbox.App.GUI.Visual> OnVisualTree_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.Template, Zetbox.App.GUI.Visual> OnVisualTree_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.Template> OnVisualTree_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnPrepareDefault_Template")]
        public virtual void PrepareDefault(Zetbox.App.Base.ObjectClass cls)
        {
            // base.PrepareDefault();
            if (OnPrepareDefault_Template != null)
            {
                OnPrepareDefault_Template(this, cls);
            }
            else
            {
                throw new NotImplementedException("No handler registered on method Template.PrepareDefault");
            }
        }
        public delegate void PrepareDefault_Handler<T>(T obj, Zetbox.App.Base.ObjectClass cls);
        public static event PrepareDefault_Handler<Template> OnPrepareDefault_Template;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<Template> OnPrepareDefault_Template_CanExec;

        [EventBasedMethod("OnPrepareDefault_Template_CanExec")]
        public virtual bool PrepareDefaultCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnPrepareDefault_Template_CanExec != null)
				{
					OnPrepareDefault_Template_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<Template> OnPrepareDefault_Template_CanExecReason;

        [EventBasedMethod("OnPrepareDefault_Template_CanExecReason")]
        public virtual string PrepareDefaultCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnPrepareDefault_Template_CanExecReason != null)
				{
					OnPrepareDefault_Template_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(Template);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (Template)obj;
            var otherImpl = (TemplateEfImpl)obj;
            var me = (Template)this;

            me.DisplayedTypeFullName = other.DisplayedTypeFullName;
            me.DisplayName = other.DisplayName;
            this._fk_DisplayedTypeAssembly = otherImpl._fk_DisplayedTypeAssembly;
            this._fk_VisualTree = otherImpl._fk_VisualTree;
        }

        public override void AttachToContext(IZetboxContext ctx, Func<IFrozenContext> lazyFrozenContext)
        {
            base.AttachToContext(ctx, lazyFrozenContext);
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
                case "DisplayedTypeAssembly":
                case "DisplayedTypeFullName":
                case "DisplayName":
                case "VisualTree":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }

        protected override bool ShouldSetModified(string property)
        {
            switch (property)
            {
                case "Menu":
                    return false;
                default:
                    return base.ShouldSetModified(property);
            }
        }
        #endregion // Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_DisplayedTypeAssembly.HasValue)
                DisplayedTypeAssemblyImpl = (Zetbox.App.Base.AssemblyEfImpl)Context.Find<Zetbox.App.Base.Assembly>(_fk_DisplayedTypeAssembly.Value);
            else
                DisplayedTypeAssemblyImpl = null;

            if (_fk_VisualTree.HasValue)
                VisualTreeImpl = (Zetbox.App.GUI.VisualEfImpl)Context.Find<Zetbox.App.GUI.Visual>(_fk_VisualTree.Value);
            else
                VisualTreeImpl = null;
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
                    new PropertyDescriptorEfImpl<Template, Zetbox.App.Base.Assembly>(
                        lazyCtx,
                        new Guid("c81105da-97e4-4685-af88-792c68e55a17"),
                        "DisplayedTypeAssembly",
                        null,
                        obj => obj.DisplayedTypeAssembly,
                        (obj, val) => obj.DisplayedTypeAssembly = val,
						obj => OnDisplayedTypeAssembly_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<Template, string>(
                        lazyCtx,
                        new Guid("4b683aa1-45a9-4c5e-80e7-0ff30f5b798c"),
                        "DisplayedTypeFullName",
                        null,
                        obj => obj.DisplayedTypeFullName,
                        (obj, val) => obj.DisplayedTypeFullName = val,
						obj => OnDisplayedTypeFullName_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<Template, string>(
                        lazyCtx,
                        new Guid("4fc51781-b0fe-495c-91a1-90e484345515"),
                        "DisplayName",
                        null,
                        obj => obj.DisplayName,
                        (obj, val) => obj.DisplayName = val,
						obj => OnDisplayName_IsValid), 
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorEfImpl<Template, ICollection<Zetbox.App.GUI.Visual>>(
                        lazyCtx,
                        new Guid("5e9612d5-019a-416b-a2e2-dfc9674a50f6"),
                        "Menu",
                        null,
                        obj => obj.Menu,
                        null, // lists are read-only properties
                        obj => OnMenu_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<Template, Zetbox.App.GUI.Visual>(
                        lazyCtx,
                        new Guid("5d2880a4-716a-4bdc-aaa9-379c006e7ed4"),
                        "VisualTree",
                        null,
                        obj => obj.VisualTree,
                        (obj, val) => obj.VisualTree = val,
						obj => OnVisualTree_IsValid), 
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
        [EventBasedMethod("OnToString_Template")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Template != null)
            {
                OnToString_Template(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<Template> OnToString_Template;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_Template")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_Template != null)
            {
                OnObjectIsValid_Template(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<Template> OnObjectIsValid_Template;

        [EventBasedMethod("OnNotifyPreSave_Template")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_Template != null) OnNotifyPreSave_Template(this);
        }
        public static event ObjectEventHandler<Template> OnNotifyPreSave_Template;

        [EventBasedMethod("OnNotifyPostSave_Template")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_Template != null) OnNotifyPostSave_Template(this);
        }
        public static event ObjectEventHandler<Template> OnNotifyPostSave_Template;

        [EventBasedMethod("OnNotifyCreated_Template")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("DisplayedTypeAssembly");
            SetNotInitializedProperty("DisplayedTypeFullName");
            SetNotInitializedProperty("DisplayName");
            SetNotInitializedProperty("VisualTree");
            base.NotifyCreated();
            if (OnNotifyCreated_Template != null) OnNotifyCreated_Template(this);
        }
        public static event ObjectEventHandler<Template> OnNotifyCreated_Template;

        [EventBasedMethod("OnNotifyDeleting_Template")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_Template != null) OnNotifyDeleting_Template(this);
            Menu.Clear();
            DisplayedTypeAssembly = null;
            VisualTree = null;
        }
        public static event ObjectEventHandler<Template> OnNotifyDeleting_Template;

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
            {
                var key = this.RelationshipManager.GetRelatedReference<Zetbox.App.Base.AssemblyEfImpl>("Model.FK_Template_has_DisplayedTypeAssembly", "DisplayedTypeAssembly").EntityKey;
                binStream.Write(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null);
            }
            binStream.Write(this._DisplayedTypeFullName);
            binStream.Write(this._DisplayName);
            {
                var key = this.RelationshipManager.GetRelatedReference<Zetbox.App.GUI.VisualEfImpl>("Model.FK_Template_has_VisualTree", "VisualTree").EntityKey;
                binStream.Write(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null);
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            binStream.Read(out this._fk_DisplayedTypeAssembly);
            this._DisplayedTypeFullName = binStream.ReadString();
            this._DisplayName = binStream.ReadString();
            binStream.Read(out this._fk_VisualTree);
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