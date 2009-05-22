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

    using Kistl.API.Server;
    using Kistl.DALProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// Metadefinition Object for Properties. This class is abstract.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="Property")]
    [System.Diagnostics.DebuggerDisplay("Property")]
    public class Property__Implementation__ : BaseServerDataObject_EntityFramework, Property, Kistl.API.IExportableInternal
    {
    
		public Property__Implementation__()
		{
            {
            }
        }

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
        public override int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_ID != value)
                {
					var __oldValue = _ID;
                    NotifyPropertyChanging("ID", __oldValue, value);
                    _ID = value;
                    NotifyPropertyChanged("ID", __oldValue, value);
                }
            }
        }
        private int _ID;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public virtual string AltText
        {
            get
            {
                return _AltText;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_AltText != value)
                {
					var __oldValue = _AltText;
                    NotifyPropertyChanging("AltText", __oldValue, value);
                    _AltText = value;
                    NotifyPropertyChanged("AltText", __oldValue, value);
                }
            }
        }
        private string _AltText;

        /// <summary>
        /// A space separated list of category names containing this Property
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public virtual string CategoryTags
        {
            get
            {
                return _CategoryTags;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_CategoryTags != value)
                {
					var __oldValue = _CategoryTags;
                    NotifyPropertyChanging("CategoryTags", __oldValue, value);
                    _CategoryTags = value;
                    NotifyPropertyChanged("CategoryTags", __oldValue, value);
                }
            }
        }
        private string _CategoryTags;

        /// <summary>
        /// The list of constraints applying to this Property
        /// </summary>
    /*
    Relation: FK_Property_Constraint_ConstrainedProperty_62
    A: One Property as ConstrainedProperty
    B: ZeroOrMore Constraint as Constraints
    Preferred Storage: MergeIntoB
    */
        // object list property
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Base.Constraint> Constraints
        {
            get
            {
                if (_ConstraintsWrapper == null)
                {
                    _ConstraintsWrapper = new EntityCollectionWrapper<Kistl.App.Base.Constraint, Kistl.App.Base.Constraint__Implementation__>(
                            this.Context, Constraints__Implementation__);
                }
                return _ConstraintsWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Property_Constraint_ConstrainedProperty_62", "Constraints")]
        public EntityCollection<Kistl.App.Base.Constraint__Implementation__> Constraints__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Base.Constraint__Implementation__>(
                        "Model.FK_Property_Constraint_ConstrainedProperty_62",
                        "Constraints");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityCollectionWrapper<Kistl.App.Base.Constraint, Kistl.App.Base.Constraint__Implementation__> _ConstraintsWrapper;



        /// <summary>
        /// Description of this Property
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public virtual string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_Description != value)
                {
					var __oldValue = _Description;
                    NotifyPropertyChanging("Description", __oldValue, value);
                    _Description = value;
                    NotifyPropertyChanged("Description", __oldValue, value);
                }
            }
        }
        private string _Description;

        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public virtual Guid ExportGuid
        {
            get
            {
                return _ExportGuid;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_ExportGuid != value)
                {
					var __oldValue = _ExportGuid;
                    NotifyPropertyChanging("ExportGuid", __oldValue, value);
                    _ExportGuid = value;
                    NotifyPropertyChanged("ExportGuid", __oldValue, value);
                }
            }
        }
        private Guid _ExportGuid;

        /// <summary>
        /// Whether or not a list-valued property has a index
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public virtual bool IsIndexed
        {
            get
            {
                return _IsIndexed;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_IsIndexed != value)
                {
					var __oldValue = _IsIndexed;
                    NotifyPropertyChanging("IsIndexed", __oldValue, value);
                    _IsIndexed = value;
                    NotifyPropertyChanged("IsIndexed", __oldValue, value);
                }
            }
        }
        private bool _IsIndexed;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public virtual bool IsList
        {
            get
            {
                return _IsList;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_IsList != value)
                {
					var __oldValue = _IsList;
                    NotifyPropertyChanging("IsList", __oldValue, value);
                    _IsList = value;
                    NotifyPropertyChanged("IsList", __oldValue, value);
                }
            }
        }
        private bool _IsList;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public virtual bool IsNullable
        {
            get
            {
                return _IsNullable;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_IsNullable != value)
                {
					var __oldValue = _IsNullable;
                    NotifyPropertyChanging("IsNullable", __oldValue, value);
                    _IsNullable = value;
                    NotifyPropertyChanged("IsNullable", __oldValue, value);
                }
            }
        }
        private bool _IsNullable;

        /// <summary>
        /// Zugehörig zum Modul
        /// </summary>
    /*
    Relation: FK_Property_Module_BaseProperty_37
    A: ZeroOrMore Property as BaseProperty
    B: ZeroOrOne Module as Module
    Preferred Storage: MergeIntoA
    */
        // object reference property
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Module Module
        {
            get
            {
                return Module__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (IsReadonly) throw new ReadOnlyObjectException();
                Module__Implementation__ = (Kistl.App.Base.Module__Implementation__)value;
            }
        }
        
        private int? _fk_Module;
        private Guid? _fk_guid_Module = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Property_Module_BaseProperty_37", "Module")]
        public Kistl.App.Base.Module__Implementation__ Module__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Module__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module__Implementation__>(
                        "Model.FK_Property_Module_BaseProperty_37",
                        "Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Module__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module__Implementation__>(
                        "Model.FK_Property_Module_BaseProperty_37",
                        "Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.Base.Module__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_DataType_Property_ObjectClass_19
    A: One DataType as ObjectClass
    B: ZeroOrMore Property as Properties
    Preferred Storage: MergeIntoB
    */
        // object reference property
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.DataType ObjectClass
        {
            get
            {
                return ObjectClass__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (IsReadonly) throw new ReadOnlyObjectException();
                ObjectClass__Implementation__ = (Kistl.App.Base.DataType__Implementation__)value;
            }
        }
        
        private int? _fk_ObjectClass;
        private Guid? _fk_guid_ObjectClass = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_DataType_Property_ObjectClass_19", "ObjectClass")]
        public Kistl.App.Base.DataType__Implementation__ ObjectClass__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.DataType__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.DataType__Implementation__>(
                        "Model.FK_DataType_Property_ObjectClass_19",
                        "ObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.Base.DataType__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.DataType__Implementation__>(
                        "Model.FK_DataType_Property_ObjectClass_19",
                        "ObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.Base.DataType__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public virtual string PropertyName
        {
            get
            {
                return _PropertyName;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_PropertyName != value)
                {
					var __oldValue = _PropertyName;
                    NotifyPropertyChanging("PropertyName", __oldValue, value);
                    _PropertyName = value;
                    NotifyPropertyChanged("PropertyName", __oldValue, value);
                }
            }
        }
        private string _PropertyName;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public virtual bool ShowIconInLists
        {
            get
            {
                return _ShowIconInLists;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_ShowIconInLists != value)
                {
					var __oldValue = _ShowIconInLists;
                    NotifyPropertyChanging("ShowIconInLists", __oldValue, value);
                    _ShowIconInLists = value;
                    NotifyPropertyChanged("ShowIconInLists", __oldValue, value);
                }
            }
        }
        private bool _ShowIconInLists;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public virtual bool ShowIdInLists
        {
            get
            {
                return _ShowIdInLists;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_ShowIdInLists != value)
                {
					var __oldValue = _ShowIdInLists;
                    NotifyPropertyChanging("ShowIdInLists", __oldValue, value);
                    _ShowIdInLists = value;
                    NotifyPropertyChanged("ShowIdInLists", __oldValue, value);
                }
            }
        }
        private bool _ShowIdInLists;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public virtual bool ShowNameInLists
        {
            get
            {
                return _ShowNameInLists;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_ShowNameInLists != value)
                {
					var __oldValue = _ShowNameInLists;
                    NotifyPropertyChanging("ShowNameInLists", __oldValue, value);
                    _ShowNameInLists = value;
                    NotifyPropertyChanged("ShowNameInLists", __oldValue, value);
                }
            }
        }
        private bool _ShowNameInLists;

        /// <summary>
        /// The PresentableModel to use for values of this Property
        /// </summary>
    /*
    Relation: FK_Property_PresentableModelDescriptor_Property_80
    A: ZeroOrMore Property as Property
    B: One PresentableModelDescriptor as ValueModelDescriptor
    Preferred Storage: MergeIntoA
    */
        // object reference property
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.GUI.PresentableModelDescriptor ValueModelDescriptor
        {
            get
            {
                return ValueModelDescriptor__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (IsReadonly) throw new ReadOnlyObjectException();
                ValueModelDescriptor__Implementation__ = (Kistl.App.GUI.PresentableModelDescriptor__Implementation__)value;
            }
        }
        
        private int? _fk_ValueModelDescriptor;
        private Guid? _fk_guid_ValueModelDescriptor = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Property_PresentableModelDescriptor_Property_80", "ValueModelDescriptor")]
        public Kistl.App.GUI.PresentableModelDescriptor__Implementation__ ValueModelDescriptor__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.GUI.PresentableModelDescriptor__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.PresentableModelDescriptor__Implementation__>(
                        "Model.FK_Property_PresentableModelDescriptor_Property_80",
                        "ValueModelDescriptor");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                return r.Value;
            }
            set
            {
                EntityReference<Kistl.App.GUI.PresentableModelDescriptor__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.GUI.PresentableModelDescriptor__Implementation__>(
                        "Model.FK_Property_PresentableModelDescriptor_Property_80",
                        "ValueModelDescriptor");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.GUI.PresentableModelDescriptor__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>

		public virtual System.Type GetPropertyType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_Property != null)
            {
                OnGetPropertyType_Property(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on Property.GetPropertyType");
            }
            return e.Result;
        }
		public delegate void GetPropertyType_Handler<T>(T obj, MethodReturnEventArgs<System.Type> ret);
		public event GetPropertyType_Handler<Property> OnGetPropertyType_Property;



        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>

		public virtual string GetPropertyTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_Property != null)
            {
                OnGetPropertyTypeString_Property(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on Property.GetPropertyTypeString");
            }
            return e.Result;
        }
		public delegate void GetPropertyTypeString_Handler<T>(T obj, MethodReturnEventArgs<string> ret);
		public event GetPropertyTypeString_Handler<Property> OnGetPropertyTypeString_Property;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Property));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Property)obj;
			var otherImpl = (Property__Implementation__)obj;
			var me = (Property)this;

			me.AltText = other.AltText;
			me.CategoryTags = other.CategoryTags;
			me.Description = other.Description;
			me.ExportGuid = other.ExportGuid;
			me.IsIndexed = other.IsIndexed;
			me.IsList = other.IsList;
			me.IsNullable = other.IsNullable;
			me.PropertyName = other.PropertyName;
			me.ShowIconInLists = other.ShowIconInLists;
			me.ShowIdInLists = other.ShowIdInLists;
			me.ShowNameInLists = other.ShowNameInLists;
			this._fk_Module = otherImpl._fk_Module;
			this._fk_ObjectClass = otherImpl._fk_ObjectClass;
			this._fk_ValueModelDescriptor = otherImpl._fk_ValueModelDescriptor;
		}

        // tail template

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Property != null)
            {
                OnToString_Property(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<Property> OnToString_Property;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Property != null) OnPreSave_Property(this);
        }
        public event ObjectEventHandler<Property> OnPreSave_Property;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Property != null) OnPostSave_Property(this);
        }
        public event ObjectEventHandler<Property> OnPostSave_Property;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "AltText":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(41).Constraints
						.Where(c => !c.IsValid(this, this.AltText))
						.Select(c => c.GetErrorText(this, this.AltText))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "CategoryTags":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(225).Constraints
						.Where(c => !c.IsValid(this, this.CategoryTags))
						.Select(c => c.GetErrorText(this, this.CategoryTags))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Constraints":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(170).Constraints
						.Where(c => !c.IsValid(this, this.Constraints))
						.Select(c => c.GetErrorText(this, this.Constraints))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Description":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(176).Constraints
						.Where(c => !c.IsValid(this, this.Description))
						.Select(c => c.GetErrorText(this, this.Description))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ExportGuid":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(253).Constraints
						.Where(c => !c.IsValid(this, this.ExportGuid))
						.Select(c => c.GetErrorText(this, this.ExportGuid))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "IsIndexed":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(204).Constraints
						.Where(c => !c.IsValid(this, this.IsIndexed))
						.Select(c => c.GetErrorText(this, this.IsIndexed))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "IsList":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(11).Constraints
						.Where(c => !c.IsValid(this, this.IsList))
						.Select(c => c.GetErrorText(this, this.IsList))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "IsNullable":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(26).Constraints
						.Where(c => !c.IsValid(this, this.IsNullable))
						.Select(c => c.GetErrorText(this, this.IsNullable))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Module":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(72).Constraints
						.Where(c => !c.IsValid(this, this.Module))
						.Select(c => c.GetErrorText(this, this.Module))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ObjectClass":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(8).Constraints
						.Where(c => !c.IsValid(this, this.ObjectClass))
						.Select(c => c.GetErrorText(this, this.ObjectClass))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "PropertyName":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(9).Constraints
						.Where(c => !c.IsValid(this, this.PropertyName))
						.Select(c => c.GetErrorText(this, this.PropertyName))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ShowIconInLists":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(265).Constraints
						.Where(c => !c.IsValid(this, this.ShowIconInLists))
						.Select(c => c.GetErrorText(this, this.ShowIconInLists))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ShowIdInLists":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(266).Constraints
						.Where(c => !c.IsValid(this, this.ShowIdInLists))
						.Select(c => c.GetErrorText(this, this.ShowIdInLists))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ShowNameInLists":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(264).Constraints
						.Where(c => !c.IsValid(this, this.ShowNameInLists))
						.Select(c => c.GetErrorText(this, this.ShowNameInLists))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ValueModelDescriptor":
				{
					var errors = Context.Find<Kistl.App.Base.Property>(236).Constraints
						.Where(c => !c.IsValid(this, this.ValueModelDescriptor))
						.Select(c => c.GetErrorText(this, this.ValueModelDescriptor))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}

		public override void ReloadReferences()
		{
			// fix direct object references

			if (_fk_guid_ObjectClass.HasValue)
				ObjectClass__Implementation__ = (Kistl.App.Base.DataType__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.DataType>(_fk_guid_ObjectClass.Value);
			else if (_fk_ObjectClass.HasValue)
				ObjectClass__Implementation__ = (Kistl.App.Base.DataType__Implementation__)Context.Find<Kistl.App.Base.DataType>(_fk_ObjectClass.Value);
			else
				ObjectClass__Implementation__ = null;

			if (_fk_guid_Module.HasValue)
				Module__Implementation__ = (Kistl.App.Base.Module__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.Module>(_fk_guid_Module.Value);
			else if (_fk_Module.HasValue)
				Module__Implementation__ = (Kistl.App.Base.Module__Implementation__)Context.Find<Kistl.App.Base.Module>(_fk_Module.Value);
			else
				Module__Implementation__ = null;

			if (_fk_guid_ValueModelDescriptor.HasValue)
				ValueModelDescriptor__Implementation__ = (Kistl.App.GUI.PresentableModelDescriptor__Implementation__)Context.FindPersistenceObject<Kistl.App.GUI.PresentableModelDescriptor>(_fk_guid_ValueModelDescriptor.Value);
			else if (_fk_ValueModelDescriptor.HasValue)
				ValueModelDescriptor__Implementation__ = (Kistl.App.GUI.PresentableModelDescriptor__Implementation__)Context.Find<Kistl.App.GUI.PresentableModelDescriptor>(_fk_ValueModelDescriptor.Value);
			else
				ValueModelDescriptor__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream)
        {
			
            base.ToStream(binStream);
            BinarySerializer.ToStream(this._AltText, binStream);
            BinarySerializer.ToStream(this._CategoryTags, binStream);
            BinarySerializer.ToStream(this._Description, binStream);
            BinarySerializer.ToStream(this._ExportGuid, binStream);
            BinarySerializer.ToStream(this._IsIndexed, binStream);
            BinarySerializer.ToStream(this._IsList, binStream);
            BinarySerializer.ToStream(this._IsNullable, binStream);
            BinarySerializer.ToStream(Module != null ? Module.ID : (int?)null, binStream);
            BinarySerializer.ToStream(ObjectClass != null ? ObjectClass.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._PropertyName, binStream);
            BinarySerializer.ToStream(this._ShowIconInLists, binStream);
            BinarySerializer.ToStream(this._ShowIdInLists, binStream);
            BinarySerializer.ToStream(this._ShowNameInLists, binStream);
            BinarySerializer.ToStream(ValueModelDescriptor != null ? ValueModelDescriptor.ID : (int?)null, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._AltText, binStream);
            BinarySerializer.FromStream(out this._CategoryTags, binStream);
            BinarySerializer.FromStream(out this._Description, binStream);
            BinarySerializer.FromStream(out this._ExportGuid, binStream);
            BinarySerializer.FromStream(out this._IsIndexed, binStream);
            BinarySerializer.FromStream(out this._IsList, binStream);
            BinarySerializer.FromStream(out this._IsNullable, binStream);
            BinarySerializer.FromStream(out this._fk_Module, binStream);
            BinarySerializer.FromStream(out this._fk_ObjectClass, binStream);
            BinarySerializer.FromStream(out this._PropertyName, binStream);
            BinarySerializer.FromStream(out this._ShowIconInLists, binStream);
            BinarySerializer.FromStream(out this._ShowIdInLists, binStream);
            BinarySerializer.FromStream(out this._ShowNameInLists, binStream);
            BinarySerializer.FromStream(out this._fk_ValueModelDescriptor, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._AltText, xml, "AltText", "Kistl.App.Base");
            XmlStreamer.ToStream(this._CategoryTags, xml, "CategoryTags", "Kistl.App.Base");
            XmlStreamer.ToStream(this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.ToStream(this._IsIndexed, xml, "IsIndexed", "Kistl.App.Base");
            XmlStreamer.ToStream(this._IsList, xml, "IsList", "Kistl.App.Base");
            XmlStreamer.ToStream(this._IsNullable, xml, "IsNullable", "Kistl.App.Base");
            XmlStreamer.ToStream(Module != null ? Module.ID : (int?)null, xml, "Module", "Kistl.App.Base");
            XmlStreamer.ToStream(ObjectClass != null ? ObjectClass.ID : (int?)null, xml, "ObjectClass", "Kistl.App.Base");
            XmlStreamer.ToStream(this._PropertyName, xml, "PropertyName", "Kistl.App.Base");
            XmlStreamer.ToStream(this._ShowIconInLists, xml, "ShowIconInLists", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._ShowIdInLists, xml, "ShowIdInLists", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._ShowNameInLists, xml, "ShowNameInLists", "Kistl.App.GUI");
            XmlStreamer.ToStream(ValueModelDescriptor != null ? ValueModelDescriptor.ID : (int?)null, xml, "ValueModelDescriptor", "Kistl.App.GUI");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._AltText, xml, "AltText", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._CategoryTags, xml, "CategoryTags", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IsIndexed, xml, "IsIndexed", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IsList, xml, "IsList", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IsNullable, xml, "IsNullable", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_Module, xml, "Module", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_ObjectClass, xml, "ObjectClass", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._PropertyName, xml, "PropertyName", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ShowIconInLists, xml, "ShowIconInLists", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._ShowIdInLists, xml, "ShowIdInLists", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._ShowNameInLists, xml, "ShowNameInLists", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_ValueModelDescriptor, xml, "ValueModelDescriptor", "Kistl.App.GUI");
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
			
			xml.WriteAttributeString("ExportGuid", this.ExportGuid.ToString());
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._AltText, xml, "AltText", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._CategoryTags, xml, "CategoryTags", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._Description, xml, "Description", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._IsIndexed, xml, "IsIndexed", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._IsList, xml, "IsList", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._IsNullable, xml, "IsNullable", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(Module != null ? Module.ExportGuid : (Guid?)null, xml, "Module", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(ObjectClass != null ? ObjectClass.ExportGuid : (Guid?)null, xml, "ObjectClass", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._PropertyName, xml, "PropertyName", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this._ShowIconInLists, xml, "ShowIconInLists", "Kistl.App.GUI");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this._ShowIdInLists, xml, "ShowIdInLists", "Kistl.App.GUI");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this._ShowNameInLists, xml, "ShowNameInLists", "Kistl.App.GUI");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            XmlStreamer.FromStream(ref this._AltText, xml, "AltText", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._CategoryTags, xml, "CategoryTags", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IsIndexed, xml, "IsIndexed", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IsList, xml, "IsList", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IsNullable, xml, "IsNullable", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_Module, xml, "Module", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_ObjectClass, xml, "ObjectClass", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._PropertyName, xml, "PropertyName", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ShowIconInLists, xml, "ShowIconInLists", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._ShowIdInLists, xml, "ShowIdInLists", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._ShowNameInLists, xml, "ShowNameInLists", "Kistl.App.GUI");
        }

#endregion

    }


}