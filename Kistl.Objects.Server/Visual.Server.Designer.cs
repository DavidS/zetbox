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
    [EdmEntityType(NamespaceName="Model", Name="Visual")]
    [System.Diagnostics.DebuggerDisplay("Visual")]
    public class Visual__Implementation__ : BaseServerDataObject_EntityFramework, Visual
    {
    
		public Visual__Implementation__()
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
        /// if this is a container, here are the visually contained/controlled children of this Visual
        /// </summary>
    /*
    Relation: FK_Visual_contains_Children
    A: ZeroOrMore Visual as Visual
    B: ZeroOrMore Visual as Children
    Preferred Storage: Separate
    */
        // collection reference property
		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.GUI.Visual> Children
        {
            get
            {
                if (_ChildrenWrapper == null)
                {
                    _ChildrenWrapper = new EntityRelationBSideCollectionWrapper<Kistl.App.GUI.Visual, Kistl.App.GUI.Visual, Kistl.App.GUI.Visual_contains_Visual_RelationEntry__Implementation__>(
                            this,
                            Children__Implementation__);
                }
                return _ChildrenWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Visual_contains_Children_A", "CollectionEntry")]
        public EntityCollection<Kistl.App.GUI.Visual_contains_Visual_RelationEntry__Implementation__> Children__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.GUI.Visual_contains_Visual_RelationEntry__Implementation__>(
                        "Model.FK_Visual_contains_Children_A",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityRelationBSideCollectionWrapper<Kistl.App.GUI.Visual, Kistl.App.GUI.Visual, Kistl.App.GUI.Visual_contains_Visual_RelationEntry__Implementation__> _ChildrenWrapper;


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
		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.GUI.Visual> ContextMenu
        {
            get
            {
                if (_ContextMenuWrapper == null)
                {
                    _ContextMenuWrapper = new EntityRelationBSideCollectionWrapper<Kistl.App.GUI.Visual, Kistl.App.GUI.Visual, Kistl.App.GUI.Visual_hasContextMenu_Visual_RelationEntry__Implementation__>(
                            this,
                            ContextMenu__Implementation__);
                }
                return _ContextMenuWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Visual_hasContextMenu_ContextMenu_A", "CollectionEntry")]
        public EntityCollection<Kistl.App.GUI.Visual_hasContextMenu_Visual_RelationEntry__Implementation__> ContextMenu__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.GUI.Visual_hasContextMenu_Visual_RelationEntry__Implementation__>(
                        "Model.FK_Visual_hasContextMenu_ContextMenu_A",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityRelationBSideCollectionWrapper<Kistl.App.GUI.Visual, Kistl.App.GUI.Visual, Kistl.App.GUI.Visual_hasContextMenu_Visual_RelationEntry__Implementation__> _ContextMenuWrapper;


        /// <summary>
        /// A short description of the utility of this visual
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string Description
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
                    __result = __e.Result;
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
                    if(OnDescription_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnDescription_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Description", __oldValue, __newValue);
                    _Description = __newValue;
                    NotifyPropertyChanged("Description", __oldValue, __newValue);
                    if(OnDescription_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnDescription_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Description;
		public static event PropertyGetterHandler<Kistl.App.GUI.Visual, string> OnDescription_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.Visual, string> OnDescription_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.Visual, string> OnDescription_PostSetter;

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
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Method Method
        {
            get
            {
                return Method__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                Method__Implementation__ = (Kistl.App.Base.Method__Implementation__)value;
            }
        }
        
        private int? _fk_Method;
        private Guid? _fk_guid_Method = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Visual_has_Method", "Method")]
        public Kistl.App.Base.Method__Implementation__ Method__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Method__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Method__Implementation__>(
                        "Model.FK_Visual_has_Method",
                        "Method");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnMethod_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.Method>(__value);
					OnMethod_Getter(this, e);
					__value = (Kistl.App.Base.Method__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Method__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Method__Implementation__>(
                        "Model.FK_Visual_has_Method",
                        "Method");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.Method __oldValue = (Kistl.App.Base.Method)r.Value;
                Kistl.App.Base.Method __newValue = (Kistl.App.Base.Method)value;

                if(OnMethod_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Method>(__oldValue, __newValue);
					OnMethod_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.Method__Implementation__)__newValue;
                if(OnMethod_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Method>(__oldValue, __newValue);
					OnMethod_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public static event PropertyGetterHandler<Kistl.App.GUI.Visual, Kistl.App.Base.Method> OnMethod_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.Visual, Kistl.App.Base.Method> OnMethod_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.Visual, Kistl.App.Base.Method> OnMethod_PostSetter;

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
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Property Property
        {
            get
            {
                return Property__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                Property__Implementation__ = (Kistl.App.Base.Property__Implementation__)value;
            }
        }
        
        private int? _fk_Property;
        private Guid? _fk_guid_Property = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Visual_has_Property", "Property")]
        public Kistl.App.Base.Property__Implementation__ Property__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Property__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Property__Implementation__>(
                        "Model.FK_Visual_has_Property",
                        "Property");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnProperty_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.Property>(__value);
					OnProperty_Getter(this, e);
					__value = (Kistl.App.Base.Property__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Property__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Property__Implementation__>(
                        "Model.FK_Visual_has_Property",
                        "Property");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.Property __oldValue = (Kistl.App.Base.Property)r.Value;
                Kistl.App.Base.Property __newValue = (Kistl.App.Base.Property)value;

                if(OnProperty_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Property>(__oldValue, __newValue);
					OnProperty_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.Property__Implementation__)__newValue;
                if(OnProperty_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Property>(__oldValue, __newValue);
					OnProperty_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public static event PropertyGetterHandler<Kistl.App.GUI.Visual, Kistl.App.Base.Property> OnProperty_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.Visual, Kistl.App.Base.Property> OnProperty_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.Visual, Kistl.App.Base.Property> OnProperty_PostSetter;

		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Visual));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Visual)obj;
			var otherImpl = (Visual__Implementation__)obj;
			var me = (Visual)this;

			me.Description = other.Description;
			this._fk_Method = otherImpl._fk_Method;
			this._fk_Property = otherImpl._fk_Property;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

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

        [EventBasedMethod("OnPreSave_Visual")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Visual != null) OnPreSave_Visual(this);
        }
        public static event ObjectEventHandler<Visual> OnPreSave_Visual;

        [EventBasedMethod("OnPostSave_Visual")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Visual != null) OnPostSave_Visual(this);
        }
        public static event ObjectEventHandler<Visual> OnPostSave_Visual;

        [EventBasedMethod("OnCreated_Visual")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_Visual != null) OnCreated_Visual(this);
        }
        public static event ObjectEventHandler<Visual> OnCreated_Visual;

        [EventBasedMethod("OnDeleting_Visual")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Visual != null) OnDeleting_Visual(this);
        }
        public static event ObjectEventHandler<Visual> OnDeleting_Visual;


		private static readonly System.ComponentModel.PropertyDescriptor[] _properties = new System.ComponentModel.PropertyDescriptor[] {
			// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
			new CustomPropertyDescriptor<Visual__Implementation__, ICollection<Kistl.App.GUI.Visual>>(
				new Guid("9f69c3bd-e274-4639-b30c-8d2a9599917b"),
				"Children",
				null,
				obj => obj.Children,
				null), // lists are read-only properties
			// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
			new CustomPropertyDescriptor<Visual__Implementation__, ICollection<Kistl.App.GUI.Visual>>(
				new Guid("7b18f26e-0f3f-4554-b469-1029bd4ca10b"),
				"ContextMenu",
				null,
				obj => obj.ContextMenu,
				null), // lists are read-only properties
			// else
			new CustomPropertyDescriptor<Visual__Implementation__, string>(
				new Guid("8d3b7c91-2bbf-4dcf-bc37-318dc0fda92d"),
				"Description",
				null,
				obj => obj.Description,
				(obj, val) => obj.Description = val),
			// else
			new CustomPropertyDescriptor<Visual__Implementation__, Kistl.App.Base.Method>(
				new Guid("0b55b2ba-3ac0-4631-8a73-1e8846c8e9b1"),
				"Method",
				null,
				obj => obj.Method,
				(obj, val) => obj.Method = val),
			// else
			new CustomPropertyDescriptor<Visual__Implementation__, Kistl.App.Base.Property>(
				new Guid("a432e3ff-61ed-4726-8559-f34516181065"),
				"Property",
				null,
				obj => obj.Property,
				(obj, val) => obj.Property = val),
			// rel: Template has VisualTree (299a4cf9-3f3e-4b89-b6ba-6b163b4e5dc0)
			// rel: Visual has Method (304c9a1e-7365-45ee-a685-348fd76f10e7)
			// rel: Visual has Property (73178882-7f93-444b-bf93-75db193904cf)
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

			if (_fk_guid_Method.HasValue)
				Method__Implementation__ = (Kistl.App.Base.Method__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.Method>(_fk_guid_Method.Value);
			else if (_fk_Method.HasValue)
				Method__Implementation__ = (Kistl.App.Base.Method__Implementation__)Context.Find<Kistl.App.Base.Method>(_fk_Method.Value);
			else
				Method__Implementation__ = null;

			if (_fk_guid_Property.HasValue)
				Property__Implementation__ = (Kistl.App.Base.Property__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.Property>(_fk_guid_Property.Value);
			else if (_fk_Property.HasValue)
				Property__Implementation__ = (Kistl.App.Base.Property__Implementation__)Context.Find<Kistl.App.Base.Property>(_fk_Property.Value);
			else
				Property__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this._Description, binStream);
            BinarySerializer.ToStream(Method != null ? Method.ID : (int?)null, binStream);
            BinarySerializer.ToStream(Property != null ? Property.ID : (int?)null, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._Description, binStream);
            BinarySerializer.FromStream(out this._fk_Method, binStream);
            BinarySerializer.FromStream(out this._fk_Property, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(this._Description, xml, "Description", "Kistl.App.GUI");
            XmlStreamer.ToStream(Method != null ? Method.ID : (int?)null, xml, "Method", "Kistl.App.GUI");
            XmlStreamer.ToStream(Property != null ? Property.ID : (int?)null, xml, "Property", "Kistl.App.GUI");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._Description, xml, "Description", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_Method, xml, "Method", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_Property, xml, "Property", "Kistl.App.GUI");
        }

#endregion

    }


}