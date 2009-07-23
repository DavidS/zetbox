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
    /// Metadefinition Object for ObjectReference Properties.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="ObjectReferenceProperty")]
    [System.Diagnostics.DebuggerDisplay("ObjectReferenceProperty")]
    public class ObjectReferenceProperty__Implementation__ : Kistl.App.Base.Property__Implementation__, ObjectReferenceProperty
    {
    
		public ObjectReferenceProperty__Implementation__()
		{
            {
            }
        }


        /// <summary>
        /// Whether or not this reference should be loaded eagerly
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual bool EagerLoading
        {
            get
            {
                return _EagerLoading;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_EagerLoading != value)
                {
					var __oldValue = _EagerLoading;
                    NotifyPropertyChanging("EagerLoading", __oldValue, value);
                    _EagerLoading = value;
                    NotifyPropertyChanged("EagerLoading", __oldValue, value);
                }
            }
        }
        private bool _EagerLoading;

        /// <summary>
        /// Pointer zur Objektklasse
        /// </summary>
    /*
    Relation: FK_ObjectReferenceProperty_has_ObjectClass
    A: ZeroOrMore ObjectReferenceProperty as ObjectReferenceProperty
    B: ZeroOrOne ObjectClass as ReferenceObjectClass
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.ObjectClass ReferenceObjectClass
        {
            get
            {
                return ReferenceObjectClass__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                ReferenceObjectClass__Implementation__ = (Kistl.App.Base.ObjectClass__Implementation__)value;
            }
        }
        
        private int? _fk_ReferenceObjectClass;
        private Guid? _fk_guid_ReferenceObjectClass = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_ObjectReferenceProperty_has_ObjectClass", "ReferenceObjectClass")]
        public Kistl.App.Base.ObjectClass__Implementation__ ReferenceObjectClass__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.ObjectClass__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClass__Implementation__>(
                        "Model.FK_ObjectReferenceProperty_has_ObjectClass",
                        "ReferenceObjectClass");
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
                EntityReference<Kistl.App.Base.ObjectClass__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.ObjectClass__Implementation__>(
                        "Model.FK_ObjectReferenceProperty_has_ObjectClass",
                        "ReferenceObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.Base.ObjectClass__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// The RelationEnd describing this Property
        /// </summary>
    /*
    Relation: FK_RelationEnd_has_ObjectReferenceProperty
    A: ZeroOrOne RelationEnd as RelationEnd
    B: ZeroOrOne ObjectReferenceProperty as Navigator
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.RelationEnd RelationEnd
        {
            get
            {
                return RelationEnd__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                RelationEnd__Implementation__ = (Kistl.App.Base.RelationEnd__Implementation__)value;
            }
        }
        
        private int? _fk_RelationEnd;
        private Guid? _fk_guid_RelationEnd = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_RelationEnd_has_ObjectReferenceProperty", "RelationEnd")]
        public Kistl.App.Base.RelationEnd__Implementation__ RelationEnd__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.RelationEnd__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.RelationEnd__Implementation__>(
                        "Model.FK_RelationEnd_has_ObjectReferenceProperty",
                        "RelationEnd");
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
                EntityReference<Kistl.App.Base.RelationEnd__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.RelationEnd__Implementation__>(
                        "Model.FK_RelationEnd_has_ObjectReferenceProperty",
                        "RelationEnd");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                r.Value = (Kistl.App.Base.RelationEnd__Implementation__)value;
            }
        }
        
        

        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>

		public override System.Type GetPropertyType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_ObjectReferenceProperty != null)
            {
                OnGetPropertyType_ObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
		public event GetPropertyType_Handler<ObjectReferenceProperty> OnGetPropertyType_ObjectReferenceProperty;



        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>

		public override string GetPropertyTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_ObjectReferenceProperty != null)
            {
                OnGetPropertyTypeString_ObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
		public event GetPropertyTypeString_Handler<ObjectReferenceProperty> OnGetPropertyTypeString_ObjectReferenceProperty;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(ObjectReferenceProperty));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (ObjectReferenceProperty)obj;
			var otherImpl = (ObjectReferenceProperty__Implementation__)obj;
			var me = (ObjectReferenceProperty)this;

			me.EagerLoading = other.EagerLoading;
			this._fk_ReferenceObjectClass = otherImpl._fk_ReferenceObjectClass;
			this._fk_RelationEnd = otherImpl._fk_RelationEnd;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ObjectReferenceProperty != null)
            {
                OnToString_ObjectReferenceProperty(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<ObjectReferenceProperty> OnToString_ObjectReferenceProperty;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ObjectReferenceProperty != null) OnPreSave_ObjectReferenceProperty(this);
        }
        public event ObjectEventHandler<ObjectReferenceProperty> OnPreSave_ObjectReferenceProperty;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ObjectReferenceProperty != null) OnPostSave_ObjectReferenceProperty(this);
        }
        public event ObjectEventHandler<ObjectReferenceProperty> OnPostSave_ObjectReferenceProperty;

        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_ObjectReferenceProperty != null) OnCreated_ObjectReferenceProperty(this);
        }
        public event ObjectEventHandler<ObjectReferenceProperty> OnCreated_ObjectReferenceProperty;

        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_ObjectReferenceProperty != null) OnDeleting_ObjectReferenceProperty(this);
        }
        public event ObjectEventHandler<ObjectReferenceProperty> OnDeleting_ObjectReferenceProperty;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "EagerLoading":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(57).Constraints
						.Where(c => !c.IsValid(this, this.EagerLoading))
						.Select(c => c.GetErrorText(this, this.EagerLoading))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ReferenceObjectClass":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(82).Constraints
						.Where(c => !c.IsValid(this, this.ReferenceObjectClass))
						.Select(c => c.GetErrorText(this, this.ReferenceObjectClass))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "RelationEnd":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(83).Constraints
						.Where(c => !c.IsValid(this, this.RelationEnd))
						.Select(c => c.GetErrorText(this, this.RelationEnd))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}

		public override void ReloadReferences()
		{
			base.ReloadReferences();
			
			// fix direct object references

			if (_fk_guid_ReferenceObjectClass.HasValue)
				ReferenceObjectClass__Implementation__ = (Kistl.App.Base.ObjectClass__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.ObjectClass>(_fk_guid_ReferenceObjectClass.Value);
			else if (_fk_ReferenceObjectClass.HasValue)
				ReferenceObjectClass__Implementation__ = (Kistl.App.Base.ObjectClass__Implementation__)Context.Find<Kistl.App.Base.ObjectClass>(_fk_ReferenceObjectClass.Value);
			else
				ReferenceObjectClass__Implementation__ = null;

			if (_fk_guid_RelationEnd.HasValue)
				RelationEnd__Implementation__ = (Kistl.App.Base.RelationEnd__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.RelationEnd>(_fk_guid_RelationEnd.Value);
			else if (_fk_RelationEnd.HasValue)
				RelationEnd__Implementation__ = (Kistl.App.Base.RelationEnd__Implementation__)Context.Find<Kistl.App.Base.RelationEnd>(_fk_RelationEnd.Value);
			else
				RelationEnd__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._EagerLoading, binStream);
            BinarySerializer.ToStream(ReferenceObjectClass != null ? ReferenceObjectClass.ID : (int?)null, binStream);
            BinarySerializer.ToStream(RelationEnd != null ? RelationEnd.ID : (int?)null, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._EagerLoading, binStream);
            BinarySerializer.FromStream(out this._fk_ReferenceObjectClass, binStream);
            BinarySerializer.FromStream(out this._fk_RelationEnd, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._EagerLoading, xml, "EagerLoading", "Kistl.App.Base");
            XmlStreamer.ToStream(ReferenceObjectClass != null ? ReferenceObjectClass.ID : (int?)null, xml, "ReferenceObjectClass", "Kistl.App.Base");
            XmlStreamer.ToStream(RelationEnd != null ? RelationEnd.ID : (int?)null, xml, "RelationEnd", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._EagerLoading, xml, "EagerLoading", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_ReferenceObjectClass, xml, "ReferenceObjectClass", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_RelationEnd, xml, "RelationEnd", "Kistl.App.Base");
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
			
            base.Export(xml, modules);
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._EagerLoading, xml, "EagerLoading", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(ReferenceObjectClass != null ? ReferenceObjectClass.ExportGuid : (Guid?)null, xml, "ReferenceObjectClass", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(RelationEnd != null ? RelationEnd.ExportGuid : (Guid?)null, xml, "RelationEnd", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
			
            base.MergeImport(xml);
            XmlStreamer.FromStream(ref this._EagerLoading, xml, "EagerLoading", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_ReferenceObjectClass, xml, "ReferenceObjectClass", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_RelationEnd, xml, "RelationEnd", "Kistl.App.Base");
        }

#endregion

    }


}