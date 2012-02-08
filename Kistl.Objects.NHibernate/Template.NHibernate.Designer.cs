// <autogenerated/>

namespace Kistl.App.GUI
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
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("Template")]
    public class TemplateNHibernateImpl : Kistl.DalProvider.NHibernate.DataObjectNHibernateImpl, Template
    {
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
        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for DisplayedTypeAssembly
        // fkBackingName=this.Proxy.DisplayedTypeAssembly; fkGuidBackingName=_fk_guid_DisplayedTypeAssembly;
        // referencedInterface=Kistl.App.Base.Assembly; moduleNamespace=Kistl.App.GUI;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target not exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Assembly DisplayedTypeAssembly
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Base.AssemblyNHibernateImpl __value = (Kistl.App.Base.AssemblyNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.DisplayedTypeAssembly);

                if (OnDisplayedTypeAssembly_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.Assembly>(__value);
                    OnDisplayedTypeAssembly_Getter(this, e);
                    __value = (Kistl.App.Base.AssemblyNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.DisplayedTypeAssembly == null)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = (Kistl.App.Base.AssemblyNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.DisplayedTypeAssembly);
                var __newValue = (Kistl.App.Base.AssemblyNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
                    return;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("DisplayedTypeAssembly", __oldValue, __newValue);

                if (OnDisplayedTypeAssembly_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Assembly>(__oldValue, __newValue);
                    OnDisplayedTypeAssembly_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.AssemblyNHibernateImpl)e.Result;
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
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Assembly>(__oldValue, __newValue);
                    OnDisplayedTypeAssembly_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for DisplayedTypeAssembly's id, used on dehydration only</summary>
        private int? _fk_DisplayedTypeAssembly = null;


        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for DisplayedTypeAssembly
		public static event PropertyGetterHandler<Kistl.App.GUI.Template, Kistl.App.Base.Assembly> OnDisplayedTypeAssembly_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.Template, Kistl.App.Base.Assembly> OnDisplayedTypeAssembly_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.Template, Kistl.App.Base.Assembly> OnDisplayedTypeAssembly_PostSetter;

        /// <summary>
        /// FullName of the Type that is displayed with this Template
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
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
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.GUI.Template, string> OnDisplayedTypeFullName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.Template, string> OnDisplayedTypeFullName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.Template, string> OnDisplayedTypeFullName_PostSetter;

        /// <summary>
        /// a short name to identify this Template to the user
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
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
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.GUI.Template, string> OnDisplayName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.Template, string> OnDisplayName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.Template, string> OnDisplayName_PostSetter;

        /// <summary>
        /// The main menu for this Template
        /// </summary>
        // collection entry list property
   		// Kistl.DalProvider.NHibernate.Generator.Templates.Properties.CollectionEntryListProperty
		public ICollection<Kistl.App.GUI.Visual> Menu
		{
			get
			{
				if (_Menu == null)
				{
					_Menu 
						= new NHibernateBSideCollectionWrapper<Kistl.App.GUI.Template, Kistl.App.GUI.Visual, Kistl.App.GUI.Template_hasMenu_Visual_RelationEntryNHibernateImpl>(
							this, 
							new ProjectedCollection<Kistl.App.GUI.Template_hasMenu_Visual_RelationEntryNHibernateImpl.Template_hasMenu_Visual_RelationEntryProxy, Kistl.App.GUI.Template_hasMenu_Visual_RelationEntryNHibernateImpl>(
                                this.Proxy.Menu,
                                p => (Kistl.App.GUI.Template_hasMenu_Visual_RelationEntryNHibernateImpl)OurContext.AttachAndWrap(p),
                                ce => (Kistl.App.GUI.Template_hasMenu_Visual_RelationEntryNHibernateImpl.Template_hasMenu_Visual_RelationEntryProxy)((NHibernatePersistenceObject)ce).NHibernateProxy),
                            entry => (IRelationListSync<Kistl.App.GUI.Template_hasMenu_Visual_RelationEntryNHibernateImpl>)null);
                    if (Menu_was_eagerLoaded) { Menu_was_eagerLoaded = false; }
				}
				return (ICollection<Kistl.App.GUI.Visual>)_Menu;
			}
		}

		private NHibernateBSideCollectionWrapper<Kistl.App.GUI.Template, Kistl.App.GUI.Visual, Kistl.App.GUI.Template_hasMenu_Visual_RelationEntryNHibernateImpl> _Menu;
		// ignored, but required for Serialization
        private bool Menu_was_eagerLoaded = false;

        /// <summary>
        /// The visual representation of this Template
        /// </summary>
        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for VisualTree
        // fkBackingName=this.Proxy.VisualTree; fkGuidBackingName=_fk_guid_VisualTree;
        // referencedInterface=Kistl.App.GUI.Visual; moduleNamespace=Kistl.App.GUI;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target not exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.GUI.Visual VisualTree
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.GUI.VisualNHibernateImpl __value = (Kistl.App.GUI.VisualNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.VisualTree);

                if (OnVisualTree_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.GUI.Visual>(__value);
                    OnVisualTree_Getter(this, e);
                    __value = (Kistl.App.GUI.VisualNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.VisualTree == null)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = (Kistl.App.GUI.VisualNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.VisualTree);
                var __newValue = (Kistl.App.GUI.VisualNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
                    return;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("VisualTree", __oldValue, __newValue);

                if (OnVisualTree_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.GUI.Visual>(__oldValue, __newValue);
                    OnVisualTree_PreSetter(this, e);
                    __newValue = (Kistl.App.GUI.VisualNHibernateImpl)e.Result;
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
                    var e = new PropertyPostSetterEventArgs<Kistl.App.GUI.Visual>(__oldValue, __newValue);
                    OnVisualTree_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for VisualTree's id, used on dehydration only</summary>
        private int? _fk_VisualTree = null;


        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for VisualTree
		public static event PropertyGetterHandler<Kistl.App.GUI.Template, Kistl.App.GUI.Visual> OnVisualTree_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.Template, Kistl.App.GUI.Visual> OnVisualTree_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.Template, Kistl.App.GUI.Visual> OnVisualTree_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnPrepareDefault_Template")]
        public virtual void PrepareDefault(Kistl.App.Base.ObjectClass cls)
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
        public delegate void PrepareDefault_Handler<T>(T obj, Kistl.App.Base.ObjectClass cls);
        public static event PrepareDefault_Handler<Template> OnPrepareDefault_Template;
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
        // END Kistl.Generator.Templates.ObjectClasses.Method

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

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "DisplayedTypeAssembly":
                    {
                        var __oldValue = (Kistl.App.Base.AssemblyNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.DisplayedTypeAssembly);
                        var __newValue = (Kistl.App.Base.AssemblyNHibernateImpl)parentObj;
                        NotifyPropertyChanging("DisplayedTypeAssembly", __oldValue, __newValue);
                        this.Proxy.DisplayedTypeAssembly = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("DisplayedTypeAssembly", __oldValue, __newValue);
                    }
                    break;
                case "VisualTree":
                    {
                        var __oldValue = (Kistl.App.GUI.VisualNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.VisualTree);
                        var __newValue = (Kistl.App.GUI.VisualNHibernateImpl)parentObj;
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

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_DisplayedTypeAssembly.HasValue)
                this.Proxy.DisplayedTypeAssembly = ((Kistl.App.Base.AssemblyNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.Assembly>(_fk_DisplayedTypeAssembly.Value)).Proxy;
            else
                this.Proxy.DisplayedTypeAssembly = null;

            if (_fk_VisualTree.HasValue)
                this.Proxy.VisualTree = ((Kistl.App.GUI.VisualNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.GUI.Visual>(_fk_VisualTree.Value)).Proxy;
            else
                this.Proxy.VisualTree = null;
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
                    new PropertyDescriptorNHibernateImpl<TemplateNHibernateImpl, Kistl.App.Base.Assembly>(
                        lazyCtx,
                        new Guid("c81105da-97e4-4685-af88-792c68e55a17"),
                        "DisplayedTypeAssembly",
                        null,
                        obj => obj.DisplayedTypeAssembly,
                        (obj, val) => obj.DisplayedTypeAssembly = val),
                    // else
                    new PropertyDescriptorNHibernateImpl<TemplateNHibernateImpl, string>(
                        lazyCtx,
                        new Guid("4b683aa1-45a9-4c5e-80e7-0ff30f5b798c"),
                        "DisplayedTypeFullName",
                        null,
                        obj => obj.DisplayedTypeFullName,
                        (obj, val) => obj.DisplayedTypeFullName = val),
                    // else
                    new PropertyDescriptorNHibernateImpl<TemplateNHibernateImpl, string>(
                        lazyCtx,
                        new Guid("4fc51781-b0fe-495c-91a1-90e484345515"),
                        "DisplayName",
                        null,
                        obj => obj.DisplayName,
                        (obj, val) => obj.DisplayName = val),
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorNHibernateImpl<TemplateNHibernateImpl, ICollection<Kistl.App.GUI.Visual>>(
                        lazyCtx,
                        new Guid("5e9612d5-019a-416b-a2e2-dfc9674a50f6"),
                        "Menu",
                        null,
                        obj => obj.Menu,
                        null), // lists are read-only properties
                    // else
                    new PropertyDescriptorNHibernateImpl<TemplateNHibernateImpl, Kistl.App.GUI.Visual>(
                        lazyCtx,
                        new Guid("5d2880a4-716a-4bdc-aaa9-379c006e7ed4"),
                        "VisualTree",
                        null,
                        obj => obj.VisualTree,
                        (obj, val) => obj.VisualTree = val),
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

        [EventBasedMethod("OnPreSave_Template")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Template != null) OnPreSave_Template(this);
        }
        public static event ObjectEventHandler<Template> OnPreSave_Template;

        [EventBasedMethod("OnPostSave_Template")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Template != null) OnPostSave_Template(this);
        }
        public static event ObjectEventHandler<Template> OnPostSave_Template;

        [EventBasedMethod("OnCreated_Template")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_Template != null) OnCreated_Template(this);
        }
        public static event ObjectEventHandler<Template> OnCreated_Template;

        [EventBasedMethod("OnDeleting_Template")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Template != null) OnDeleting_Template(this);
        }
        public static event ObjectEventHandler<Template> OnDeleting_Template;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods
        public override List<NHibernatePersistenceObject> GetParentsToDelete()
        {
            var result = base.GetParentsToDelete();

            // Follow Template_has_DisplayedTypeAssembly
            if (this.DisplayedTypeAssembly != null && this.DisplayedTypeAssembly.ObjectState == DataObjectState.Deleted)
                result.Add((NHibernatePersistenceObject)this.DisplayedTypeAssembly);

            // Follow Template_has_VisualTree
            if (this.VisualTree != null && this.VisualTree.ObjectState == DataObjectState.Deleted)
                result.Add((NHibernatePersistenceObject)this.VisualTree);

            return result;
        }

        public override List<NHibernatePersistenceObject> GetChildrenToDelete()
        {
            var result = base.GetChildrenToDelete();

            return result;
        }


        public class TemplateProxy
            : IProxyObject, ISortKey<int>
        {
            public TemplateProxy()
            {
                Menu = new Collection<Kistl.App.GUI.Template_hasMenu_Visual_RelationEntryNHibernateImpl.Template_hasMenu_Visual_RelationEntryProxy>();
            }

            public virtual int ID { get; set; }

            public virtual Type ZBoxWrapper { get { return typeof(TemplateNHibernateImpl); } }
            public virtual Type ZBoxProxy { get { return typeof(TemplateProxy); } }

            public virtual Kistl.App.Base.AssemblyNHibernateImpl.AssemblyProxy DisplayedTypeAssembly { get; set; }

            public virtual string DisplayedTypeFullName { get; set; }

            public virtual string DisplayName { get; set; }

            public virtual ICollection<Kistl.App.GUI.Template_hasMenu_Visual_RelationEntryNHibernateImpl.Template_hasMenu_Visual_RelationEntryProxy> Menu { get; set; }

            public virtual Kistl.App.GUI.VisualNHibernateImpl.VisualProxy VisualTree { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this.Proxy.DisplayedTypeAssembly != null ? OurContext.GetIdFromProxy(this.Proxy.DisplayedTypeAssembly) : (int?)null, binStream);
            BinarySerializer.ToStream(this.Proxy.DisplayedTypeFullName, binStream);
            BinarySerializer.ToStream(this.Proxy.DisplayName, binStream);
            BinarySerializer.ToStream(this.Proxy.VisualTree != null ? OurContext.GetIdFromProxy(this.Proxy.VisualTree) : (int?)null, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._fk_DisplayedTypeAssembly, binStream);
            {
                string tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.DisplayedTypeFullName = tmp;
            }
            {
                string tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.DisplayName = tmp;
            }
            BinarySerializer.FromStream(out this._fk_VisualTree, binStream);
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
            XmlStreamer.ToStream(this.Proxy.DisplayedTypeAssembly != null ? OurContext.GetIdFromProxy(this.Proxy.DisplayedTypeAssembly) : (int?)null, xml, "DisplayedTypeAssembly", "Kistl.App.GUI");
            XmlStreamer.ToStream(this.Proxy.DisplayedTypeFullName, xml, "DisplayedTypeFullName", "Kistl.App.GUI");
            XmlStreamer.ToStream(this.Proxy.DisplayName, xml, "DisplayName", "Kistl.App.GUI");
            XmlStreamer.ToStream(this.Proxy.VisualTree != null ? OurContext.GetIdFromProxy(this.Proxy.VisualTree) : (int?)null, xml, "VisualTree", "Kistl.App.GUI");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._fk_DisplayedTypeAssembly, xml, "DisplayedTypeAssembly", "Kistl.App.GUI");
            {
                // yuck
                string tmp = this.Proxy.DisplayedTypeFullName;
                XmlStreamer.FromStream(ref tmp, xml, "DisplayedTypeFullName", "Kistl.App.GUI");
                this.Proxy.DisplayedTypeFullName = tmp;
            }
            {
                // yuck
                string tmp = this.Proxy.DisplayName;
                XmlStreamer.FromStream(ref tmp, xml, "DisplayName", "Kistl.App.GUI");
                this.Proxy.DisplayName = tmp;
            }
            XmlStreamer.FromStream(ref this._fk_VisualTree, xml, "VisualTree", "Kistl.App.GUI");
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        #endregion

    }
}