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

    using Zetbox.API.Utils;
    using Zetbox.DalProvider.Base;
    using Zetbox.DalProvider.NHibernate;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("Template")]
    public class TemplateNHibernateImpl : Zetbox.DalProvider.NHibernate.DataObjectNHibernateImpl, Template
    {
        private static readonly Guid _objectClassID = new Guid("c677d3fe-7dfe-4ea5-91e0-d1b0df9118be");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public TemplateNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public TemplateNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new TemplateProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public TemplateNHibernateImpl(Func<IFrozenContext> lazyCtx, TemplateProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly TemplateProxy Proxy;

        /// <summary>
        /// Assembly of the Type that is displayed with this Template
        /// </summary>
        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for DisplayedTypeAssembly
        // fkBackingName=this.Proxy.DisplayedTypeAssembly; fkGuidBackingName=_fk_guid_DisplayedTypeAssembly;
        // referencedInterface=Zetbox.App.Base.Assembly; moduleNamespace=Zetbox.App.GUI;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target not exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Base.Assembly DisplayedTypeAssembly
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Zetbox.App.Base.AssemblyNHibernateImpl __value = (Zetbox.App.Base.AssemblyNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.DisplayedTypeAssembly);

                if (OnDisplayedTypeAssembly_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.Assembly>(__value);
                    OnDisplayedTypeAssembly_Getter(this, e);
                    __value = (Zetbox.App.Base.AssemblyNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.DisplayedTypeAssembly == null)
				{
					SetInitializedProperty("DisplayedTypeAssembly");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = (Zetbox.App.Base.AssemblyNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.DisplayedTypeAssembly);
                var __newValue = (Zetbox.App.Base.AssemblyNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
				{
					SetInitializedProperty("DisplayedTypeAssembly");
                    return;
				}

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("DisplayedTypeAssembly", __oldValue, __newValue);

                if (OnDisplayedTypeAssembly_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.Assembly>(__oldValue, __newValue);
                    OnDisplayedTypeAssembly_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.AssemblyNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.DisplayedTypeAssembly = null;
                }
                else
                {
                    this.Proxy.DisplayedTypeAssembly = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("DisplayedTypeAssembly", __oldValue, __newValue);

                if (OnDisplayedTypeAssembly_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.Assembly>(__oldValue, __newValue);
                    OnDisplayedTypeAssembly_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for DisplayedTypeAssembly's id, used on dehydration only</summary>
        private int? _fk_DisplayedTypeAssembly = null;


        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for DisplayedTypeAssembly
		public static event PropertyGetterHandler<Zetbox.App.GUI.Template, Zetbox.App.Base.Assembly> OnDisplayedTypeAssembly_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.Template, Zetbox.App.Base.Assembly> OnDisplayedTypeAssembly_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.Template, Zetbox.App.Base.Assembly> OnDisplayedTypeAssembly_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.Template> OnDisplayedTypeAssembly_IsValid;

        /// <summary>
        /// FullName of the Type that is displayed with this Template
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string DisplayedTypeFullName
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.DisplayedTypeFullName;
                if (OnDisplayedTypeFullName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnDisplayedTypeFullName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.DisplayedTypeFullName != value)
                {
                    var __oldValue = Proxy.DisplayedTypeFullName;
                    var __newValue = value;
                    if (OnDisplayedTypeFullName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnDisplayedTypeFullName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("DisplayedTypeFullName", __oldValue, __newValue);
                    Proxy.DisplayedTypeFullName = __newValue;
                    NotifyPropertyChanged("DisplayedTypeFullName", __oldValue, __newValue);

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

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.GUI.Template, string> OnDisplayedTypeFullName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.Template, string> OnDisplayedTypeFullName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.Template, string> OnDisplayedTypeFullName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.Template> OnDisplayedTypeFullName_IsValid;

        /// <summary>
        /// a short name to identify this Template to the user
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string DisplayName
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.DisplayName;
                if (OnDisplayName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnDisplayName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.DisplayName != value)
                {
                    var __oldValue = Proxy.DisplayName;
                    var __newValue = value;
                    if (OnDisplayName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnDisplayName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("DisplayName", __oldValue, __newValue);
                    Proxy.DisplayName = __newValue;
                    NotifyPropertyChanged("DisplayName", __oldValue, __newValue);

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

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.GUI.Template, string> OnDisplayName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.Template, string> OnDisplayName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.Template, string> OnDisplayName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.Template> OnDisplayName_IsValid;

        /// <summary>
        /// The main menu for this Template
        /// </summary>
        // collection entry list property
   		// Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.CollectionEntryListProperty
		public ICollection<Zetbox.App.GUI.Visual> Menu
		{
			get
			{
				if (_Menu == null)
				{
					_Menu 
						= new NHibernateBSideCollectionWrapper<Zetbox.App.GUI.Template, Zetbox.App.GUI.Visual, Zetbox.App.GUI.Template_hasMenu_Visual_RelationEntryNHibernateImpl>(
							this, 
							new ProjectedCollection<Zetbox.App.GUI.Template_hasMenu_Visual_RelationEntryNHibernateImpl.Template_hasMenu_Visual_RelationEntryProxy, Zetbox.App.GUI.Template_hasMenu_Visual_RelationEntryNHibernateImpl>(
                                () => this.Proxy.Menu,
                                p => (Zetbox.App.GUI.Template_hasMenu_Visual_RelationEntryNHibernateImpl)OurContext.AttachAndWrap(p),
                                ce => (Zetbox.App.GUI.Template_hasMenu_Visual_RelationEntryNHibernateImpl.Template_hasMenu_Visual_RelationEntryProxy)((NHibernatePersistenceObject)ce).NHibernateProxy),
                            entry => (IRelationListSync<Zetbox.App.GUI.Template_hasMenu_Visual_RelationEntryNHibernateImpl>)null);
                    if (Menu_was_eagerLoaded) { Menu_was_eagerLoaded = false; }
				}
				return (ICollection<Zetbox.App.GUI.Visual>)_Menu;
			}
		}

		private NHibernateBSideCollectionWrapper<Zetbox.App.GUI.Template, Zetbox.App.GUI.Visual, Zetbox.App.GUI.Template_hasMenu_Visual_RelationEntryNHibernateImpl> _Menu;
		// ignored, but required for Serialization
        private bool Menu_was_eagerLoaded = false;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.Template> OnMenu_IsValid;

        /// <summary>
        /// The visual representation of this Template
        /// </summary>
        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for VisualTree
        // fkBackingName=this.Proxy.VisualTree; fkGuidBackingName=_fk_guid_VisualTree;
        // referencedInterface=Zetbox.App.GUI.Visual; moduleNamespace=Zetbox.App.GUI;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target not exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.GUI.Visual VisualTree
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Zetbox.App.GUI.VisualNHibernateImpl __value = (Zetbox.App.GUI.VisualNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.VisualTree);

                if (OnVisualTree_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.GUI.Visual>(__value);
                    OnVisualTree_Getter(this, e);
                    __value = (Zetbox.App.GUI.VisualNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.VisualTree == null)
				{
					SetInitializedProperty("VisualTree");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = (Zetbox.App.GUI.VisualNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.VisualTree);
                var __newValue = (Zetbox.App.GUI.VisualNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
				{
					SetInitializedProperty("VisualTree");
                    return;
				}

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("VisualTree", __oldValue, __newValue);

                if (OnVisualTree_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.GUI.Visual>(__oldValue, __newValue);
                    OnVisualTree_PreSetter(this, e);
                    __newValue = (Zetbox.App.GUI.VisualNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.VisualTree = null;
                }
                else
                {
                    this.Proxy.VisualTree = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("VisualTree", __oldValue, __newValue);

                if (OnVisualTree_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.GUI.Visual>(__oldValue, __newValue);
                    OnVisualTree_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for VisualTree's id, used on dehydration only</summary>
        private int? _fk_VisualTree = null;


        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for VisualTree
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
            var otherImpl = (TemplateNHibernateImpl)obj;
            var me = (Template)this;

            me.DisplayedTypeFullName = other.DisplayedTypeFullName;
            me.DisplayName = other.DisplayName;
            this._fk_DisplayedTypeAssembly = otherImpl._fk_DisplayedTypeAssembly;
            this._fk_VisualTree = otherImpl._fk_VisualTree;
        }

        public override void AttachToContext(IZetboxContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "DisplayedTypeAssembly":
                    {
                        var __oldValue = (Zetbox.App.Base.AssemblyNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.DisplayedTypeAssembly);
                        var __newValue = (Zetbox.App.Base.AssemblyNHibernateImpl)parentObj;
                        NotifyPropertyChanging("DisplayedTypeAssembly", __oldValue, __newValue);
                        this.Proxy.DisplayedTypeAssembly = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("DisplayedTypeAssembly", __oldValue, __newValue);
                    }
                    break;
                case "VisualTree":
                    {
                        var __oldValue = (Zetbox.App.GUI.VisualNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.VisualTree);
                        var __newValue = (Zetbox.App.GUI.VisualNHibernateImpl)parentObj;
                        NotifyPropertyChanging("VisualTree", __oldValue, __newValue);
                        this.Proxy.VisualTree = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("VisualTree", __oldValue, __newValue);
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
        #endregion // Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_DisplayedTypeAssembly.HasValue)
                this.DisplayedTypeAssembly = ((Zetbox.App.Base.AssemblyNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.Base.Assembly>(_fk_DisplayedTypeAssembly.Value));
            else
                this.DisplayedTypeAssembly = null;

            if (_fk_VisualTree.HasValue)
                this.VisualTree = ((Zetbox.App.GUI.VisualNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.GUI.Visual>(_fk_VisualTree.Value));
            else
                this.VisualTree = null;
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
                    new PropertyDescriptorNHibernateImpl<Template, Zetbox.App.Base.Assembly>(
                        lazyCtx,
                        new Guid("c81105da-97e4-4685-af88-792c68e55a17"),
                        "DisplayedTypeAssembly",
                        null,
                        obj => obj.DisplayedTypeAssembly,
                        (obj, val) => obj.DisplayedTypeAssembly = val,
						obj => OnDisplayedTypeAssembly_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<Template, string>(
                        lazyCtx,
                        new Guid("4b683aa1-45a9-4c5e-80e7-0ff30f5b798c"),
                        "DisplayedTypeFullName",
                        null,
                        obj => obj.DisplayedTypeFullName,
                        (obj, val) => obj.DisplayedTypeFullName = val,
						obj => OnDisplayedTypeFullName_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<Template, string>(
                        lazyCtx,
                        new Guid("4fc51781-b0fe-495c-91a1-90e484345515"),
                        "DisplayName",
                        null,
                        obj => obj.DisplayName,
                        (obj, val) => obj.DisplayName = val,
						obj => OnDisplayName_IsValid), 
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorNHibernateImpl<Template, ICollection<Zetbox.App.GUI.Visual>>(
                        lazyCtx,
                        new Guid("5e9612d5-019a-416b-a2e2-dfc9674a50f6"),
                        "Menu",
                        null,
                        obj => obj.Menu,
                        null, // lists are read-only properties
                        obj => OnMenu_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<Template, Zetbox.App.GUI.Visual>(
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
        #region Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

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

            // FK_Template_has_DisplayedTypeAssembly
            if (DisplayedTypeAssembly != null) {
                ((NHibernatePersistenceObject)DisplayedTypeAssembly).ChildrenToDelete.Add(this);
                ParentsToDelete.Add((NHibernatePersistenceObject)DisplayedTypeAssembly);
            }
            // FK_Template_has_VisualTree
            if (VisualTree != null) {
                ((NHibernatePersistenceObject)VisualTree).ChildrenToDelete.Add(this);
                ParentsToDelete.Add((NHibernatePersistenceObject)VisualTree);
            }

            Menu.Clear();
            DisplayedTypeAssembly = null;
            VisualTree = null;
        }
        public static event ObjectEventHandler<Template> OnNotifyDeleting_Template;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class TemplateProxy
            : IProxyObject, ISortKey<int>
        {
            public TemplateProxy()
            {
                Menu = new Collection<Zetbox.App.GUI.Template_hasMenu_Visual_RelationEntryNHibernateImpl.Template_hasMenu_Visual_RelationEntryProxy>();
            }

            public virtual int ID { get; set; }

            public virtual Type ZetboxWrapper { get { return typeof(TemplateNHibernateImpl); } }
            public virtual Type ZetboxProxy { get { return typeof(TemplateProxy); } }

            public virtual Zetbox.App.Base.AssemblyNHibernateImpl.AssemblyProxy DisplayedTypeAssembly { get; set; }

            public virtual string DisplayedTypeFullName { get; set; }

            public virtual string DisplayName { get; set; }

            public virtual ICollection<Zetbox.App.GUI.Template_hasMenu_Visual_RelationEntryNHibernateImpl.Template_hasMenu_Visual_RelationEntryProxy> Menu { get; set; }

            public virtual Zetbox.App.GUI.VisualNHibernateImpl.VisualProxy VisualTree { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.DisplayedTypeAssembly != null ? OurContext.GetIdFromProxy(this.Proxy.DisplayedTypeAssembly) : (int?)null);
            binStream.Write(this.Proxy.DisplayedTypeFullName);
            binStream.Write(this.Proxy.DisplayName);
            binStream.Write(this.Proxy.VisualTree != null ? OurContext.GetIdFromProxy(this.Proxy.VisualTree) : (int?)null);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            binStream.Read(out this._fk_DisplayedTypeAssembly);
            this.Proxy.DisplayedTypeFullName = binStream.ReadString();
            this.Proxy.DisplayName = binStream.ReadString();
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