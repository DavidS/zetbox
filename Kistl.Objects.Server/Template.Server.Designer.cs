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

    using Kistl.API.Server;
    using Kistl.DalProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="Template")]
    [System.Diagnostics.DebuggerDisplay("Template")]
    public class Template__Implementation__ : BaseServerDataObject_EntityFramework, Template
    {
    
		public Template__Implementation__()
		{
        }

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.IdProperty
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
                }
            }
        }
        private int _ID;

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
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Assembly DisplayedTypeAssembly
        {
            get
            {
                return DisplayedTypeAssembly__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                DisplayedTypeAssembly__Implementation__ = (Kistl.App.Base.Assembly__Implementation__)value;
            }
        }
        
        private int? _fk_DisplayedTypeAssembly;
        private Guid? _fk_guid_DisplayedTypeAssembly = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Template_has_DisplayedTypeAssembly", "DisplayedTypeAssembly")]
        public Kistl.App.Base.Assembly__Implementation__ DisplayedTypeAssembly__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Assembly__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly__Implementation__>(
                        "Model.FK_Template_has_DisplayedTypeAssembly",
                        "DisplayedTypeAssembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnDisplayedTypeAssembly_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.Assembly>(__value);
					OnDisplayedTypeAssembly_Getter(this, e);
					__value = (Kistl.App.Base.Assembly__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Assembly__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Assembly__Implementation__>(
                        "Model.FK_Template_has_DisplayedTypeAssembly",
                        "DisplayedTypeAssembly");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.Assembly __oldValue = (Kistl.App.Base.Assembly)r.Value;
                Kistl.App.Base.Assembly __newValue = (Kistl.App.Base.Assembly)value;

                if(OnDisplayedTypeAssembly_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Assembly>(__oldValue, __newValue);
					OnDisplayedTypeAssembly_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.Assembly__Implementation__)__newValue;
                if(OnDisplayedTypeAssembly_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Assembly>(__oldValue, __newValue);
					OnDisplayedTypeAssembly_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public static event PropertyGetterHandler<Kistl.App.GUI.Template, Kistl.App.Base.Assembly> OnDisplayedTypeAssembly_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.Template, Kistl.App.Base.Assembly> OnDisplayedTypeAssembly_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.Template, Kistl.App.Base.Assembly> OnDisplayedTypeAssembly_PostSetter;

        /// <summary>
        /// FullName of the Type that is displayed with this Template
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string DisplayedTypeFullName
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
                    __result = __e.Result;
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
                    if(OnDisplayedTypeFullName_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnDisplayedTypeFullName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("DisplayedTypeFullName", __oldValue, __newValue);
                    _DisplayedTypeFullName = __newValue;
                    NotifyPropertyChanged("DisplayedTypeFullName", __oldValue, __newValue);
                    if(OnDisplayedTypeFullName_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnDisplayedTypeFullName_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _DisplayedTypeFullName;
		public static event PropertyGetterHandler<Kistl.App.GUI.Template, string> OnDisplayedTypeFullName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.Template, string> OnDisplayedTypeFullName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.Template, string> OnDisplayedTypeFullName_PostSetter;

        /// <summary>
        /// a short name to identify this Template to the user
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string DisplayName
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
                    __result = __e.Result;
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
                    if(OnDisplayName_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnDisplayName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("DisplayName", __oldValue, __newValue);
                    _DisplayName = __newValue;
                    NotifyPropertyChanged("DisplayName", __oldValue, __newValue);
                    if(OnDisplayName_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnDisplayName_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _DisplayName;
		public static event PropertyGetterHandler<Kistl.App.GUI.Template, string> OnDisplayName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.Template, string> OnDisplayName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.Template, string> OnDisplayName_PostSetter;

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
		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.GUI.Visual> Menu
        {
            get
            {
                if (_MenuWrapper == null)
                {
                    _MenuWrapper = new EntityRelationBSideCollectionWrapper<Kistl.App.GUI.Template, Kistl.App.GUI.Visual, Kistl.App.GUI.Template_hasMenu_Visual_RelationEntry__Implementation__>(
                            this,
                            Menu__Implementation__);
                }
                return _MenuWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Template_hasMenu_Menu_A", "CollectionEntry")]
        public EntityCollection<Kistl.App.GUI.Template_hasMenu_Visual_RelationEntry__Implementation__> Menu__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.GUI.Template_hasMenu_Visual_RelationEntry__Implementation__>(
                        "Model.FK_Template_hasMenu_Menu_A",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityRelationBSideCollectionWrapper<Kistl.App.GUI.Template, Kistl.App.GUI.Visual, Kistl.App.GUI.Template_hasMenu_Visual_RelationEntry__Implementation__> _MenuWrapper;


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
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.GUI.Visual VisualTree
        {
            get
            {
                return VisualTree__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                VisualTree__Implementation__ = (Kistl.App.GUI.Visual__Implementation__)value;
            }
        }
        
        private int? _fk_VisualTree;
        private Guid? _fk_guid_VisualTree = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Template_has_VisualTree", "VisualTree")]
        public Kistl.App.GUI.Visual__Implementation__ VisualTree__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.GUI.Visual__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.Visual__Implementation__>(
                        "Model.FK_Template_has_VisualTree",
                        "VisualTree");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnVisualTree_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.GUI.Visual>(__value);
					OnVisualTree_Getter(this, e);
					__value = (Kistl.App.GUI.Visual__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.GUI.Visual__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.Visual__Implementation__>(
                        "Model.FK_Template_has_VisualTree",
                        "VisualTree");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.GUI.Visual __oldValue = (Kistl.App.GUI.Visual)r.Value;
                Kistl.App.GUI.Visual __newValue = (Kistl.App.GUI.Visual)value;

                if(OnVisualTree_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.GUI.Visual>(__oldValue, __newValue);
					OnVisualTree_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.GUI.Visual__Implementation__)__newValue;
                if(OnVisualTree_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.GUI.Visual>(__oldValue, __newValue);
					OnVisualTree_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public static event PropertyGetterHandler<Kistl.App.GUI.Template, Kistl.App.GUI.Visual> OnVisualTree_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.Template, Kistl.App.GUI.Visual> OnVisualTree_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.Template, Kistl.App.GUI.Visual> OnVisualTree_PostSetter;

        /// <summary>
        /// 
        /// </summary>
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
                throw new NotImplementedException("No handler registered on Template.PrepareDefault");
			}
        }
		public delegate void PrepareDefault_Handler<T>(T obj, Kistl.App.Base.ObjectClass cls);
		public static event PrepareDefault_Handler<Template> OnPrepareDefault_Template;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Template));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Template)obj;
			var otherImpl = (Template__Implementation__)obj;
			var me = (Template)this;

			me.DisplayedTypeFullName = other.DisplayedTypeFullName;
			me.DisplayName = other.DisplayName;
			this._fk_DisplayedTypeAssembly = otherImpl._fk_DisplayedTypeAssembly;
			this._fk_VisualTree = otherImpl._fk_VisualTree;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

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


		private static readonly System.ComponentModel.PropertyDescriptor[] _properties = new System.ComponentModel.PropertyDescriptor[] {
			// else
			new CustomPropertyDescriptor<Template__Implementation__, Kistl.App.Base.Assembly>(
				new Guid("c81105da-97e4-4685-af88-792c68e55a17"),
				"DisplayedTypeAssembly",
				null,
				obj => obj.DisplayedTypeAssembly,
				(obj, val) => obj.DisplayedTypeAssembly = val),
			// else
			new CustomPropertyDescriptor<Template__Implementation__, string>(
				new Guid("4b683aa1-45a9-4c5e-80e7-0ff30f5b798c"),
				"DisplayedTypeFullName",
				null,
				obj => obj.DisplayedTypeFullName,
				(obj, val) => obj.DisplayedTypeFullName = val),
			// else
			new CustomPropertyDescriptor<Template__Implementation__, string>(
				new Guid("4fc51781-b0fe-495c-91a1-90e484345515"),
				"DisplayName",
				null,
				obj => obj.DisplayName,
				(obj, val) => obj.DisplayName = val),
			// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
			new CustomPropertyDescriptor<Template__Implementation__, ICollection<Kistl.App.GUI.Visual>>(
				new Guid("5e9612d5-019a-416b-a2e2-dfc9674a50f6"),
				"Menu",
				null,
				obj => obj.Menu,
				null), // lists are read-only properties
			// else
			new CustomPropertyDescriptor<Template__Implementation__, Kistl.App.GUI.Visual>(
				new Guid("5d2880a4-716a-4bdc-aaa9-379c006e7ed4"),
				"VisualTree",
				null,
				obj => obj.VisualTree,
				(obj, val) => obj.VisualTree = val),
			// rel: Template has DisplayedTypeAssembly (0e64ccd9-2f72-489a-83a4-095f949fdee3)
			// rel: Template has VisualTree (299a4cf9-3f3e-4b89-b6ba-6b163b4e5dc0)
		};
		
		protected override void CollectProperties(List<System.ComponentModel.PropertyDescriptor> props)
		{
			base.CollectProperties(props);
			props.AddRange(_properties);
		}
	

		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
			// fix direct object references

			if (_fk_guid_DisplayedTypeAssembly.HasValue)
				DisplayedTypeAssembly__Implementation__ = (Kistl.App.Base.Assembly__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.Assembly>(_fk_guid_DisplayedTypeAssembly.Value);
			else if (_fk_DisplayedTypeAssembly.HasValue)
				DisplayedTypeAssembly__Implementation__ = (Kistl.App.Base.Assembly__Implementation__)Context.Find<Kistl.App.Base.Assembly>(_fk_DisplayedTypeAssembly.Value);
			else
				DisplayedTypeAssembly__Implementation__ = null;

			if (_fk_guid_VisualTree.HasValue)
				VisualTree__Implementation__ = (Kistl.App.GUI.Visual__Implementation__)Context.FindPersistenceObject<Kistl.App.GUI.Visual>(_fk_guid_VisualTree.Value);
			else if (_fk_VisualTree.HasValue)
				VisualTree__Implementation__ = (Kistl.App.GUI.Visual__Implementation__)Context.Find<Kistl.App.GUI.Visual>(_fk_VisualTree.Value);
			else
				VisualTree__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(DisplayedTypeAssembly != null ? DisplayedTypeAssembly.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._DisplayedTypeFullName, binStream);
            BinarySerializer.ToStream(this._DisplayName, binStream);
            BinarySerializer.ToStream(VisualTree != null ? VisualTree.ID : (int?)null, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._fk_DisplayedTypeAssembly, binStream);
            BinarySerializer.FromStream(out this._DisplayedTypeFullName, binStream);
            BinarySerializer.FromStream(out this._DisplayName, binStream);
            BinarySerializer.FromStream(out this._fk_VisualTree, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(DisplayedTypeAssembly != null ? DisplayedTypeAssembly.ID : (int?)null, xml, "DisplayedTypeAssembly", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._DisplayedTypeFullName, xml, "DisplayedTypeFullName", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._DisplayName, xml, "DisplayName", "Kistl.App.GUI");
            XmlStreamer.ToStream(VisualTree != null ? VisualTree.ID : (int?)null, xml, "VisualTree", "Kistl.App.GUI");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._fk_DisplayedTypeAssembly, xml, "DisplayedTypeAssembly", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._DisplayedTypeFullName, xml, "DisplayedTypeFullName", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._DisplayName, xml, "DisplayName", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_VisualTree, xml, "VisualTree", "Kistl.App.GUI");
        }

#endregion

    }


}