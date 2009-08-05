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
    /// Metadefinition Object for Struct Properties.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="StructProperty")]
    [System.Diagnostics.DebuggerDisplay("StructProperty")]
    public class StructProperty__Implementation__ : Kistl.App.Base.Property__Implementation__, StructProperty
    {
    
		public StructProperty__Implementation__()
		{
        }


        /// <summary>
        /// Definition of this Struct
        /// </summary>
    /*
    Relation: FK_StructProperty_has_Struct
    A: ZeroOrMore StructProperty as StructProperty
    B: ZeroOrOne Struct as StructDefinition
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Struct StructDefinition
        {
            get
            {
                return StructDefinition__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                StructDefinition__Implementation__ = (Kistl.App.Base.Struct__Implementation__)value;
            }
        }
        
        private int? _fk_StructDefinition;
        private Guid? _fk_guid_StructDefinition = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_StructProperty_has_Struct", "StructDefinition")]
        public Kistl.App.Base.Struct__Implementation__ StructDefinition__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Struct__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Struct__Implementation__>(
                        "Model.FK_StructProperty_has_Struct",
                        "StructDefinition");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnStructDefinition_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.Struct>(__value);
					OnStructDefinition_Getter(this, e);
					__value = (Kistl.App.Base.Struct__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Struct__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Struct__Implementation__>(
                        "Model.FK_StructProperty_has_Struct",
                        "StructDefinition");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.Struct __oldValue = (Kistl.App.Base.Struct)r.Value;
                Kistl.App.Base.Struct __newValue = (Kistl.App.Base.Struct)value;

                if(OnStructDefinition_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Struct>(__oldValue, __newValue);
					OnStructDefinition_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.Struct__Implementation__)__newValue;
                if(OnStructDefinition_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Struct>(__oldValue, __newValue);
					OnStructDefinition_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.Base.StructProperty, Kistl.App.Base.Struct> OnStructDefinition_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.StructProperty, Kistl.App.Base.Struct> OnStructDefinition_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.StructProperty, Kistl.App.Base.Struct> OnStructDefinition_PostSetter;
        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>

		public override System.Type GetPropertyType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_StructProperty != null)
            {
                OnGetPropertyType_StructProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
		public event GetPropertyType_Handler<StructProperty> OnGetPropertyType_StructProperty;



        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>

		public override string GetPropertyTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_StructProperty != null)
            {
                OnGetPropertyTypeString_StructProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
		public event GetPropertyTypeString_Handler<StructProperty> OnGetPropertyTypeString_StructProperty;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(StructProperty));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (StructProperty)obj;
			var otherImpl = (StructProperty__Implementation__)obj;
			var me = (StructProperty)this;

			this._fk_StructDefinition = otherImpl._fk_StructDefinition;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_StructProperty != null)
            {
                OnToString_StructProperty(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<StructProperty> OnToString_StructProperty;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_StructProperty != null) OnPreSave_StructProperty(this);
        }
        public event ObjectEventHandler<StructProperty> OnPreSave_StructProperty;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_StructProperty != null) OnPostSave_StructProperty(this);
        }
        public event ObjectEventHandler<StructProperty> OnPostSave_StructProperty;

        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_StructProperty != null) OnCreated_StructProperty(this);
        }
        public event ObjectEventHandler<StructProperty> OnCreated_StructProperty;

        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_StructProperty != null) OnDeleting_StructProperty(this);
        }
        public event ObjectEventHandler<StructProperty> OnDeleting_StructProperty;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "StructDefinition":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("0d78c157-c106-4728-9af2-7992da7c935d")).Constraints
						.Where(c => !c.IsValid(this, this.StructDefinition))
						.Select(c => c.GetErrorText(this, this.StructDefinition))
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

			if (_fk_guid_StructDefinition.HasValue)
				StructDefinition__Implementation__ = (Kistl.App.Base.Struct__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.Struct>(_fk_guid_StructDefinition.Value);
			else if (_fk_StructDefinition.HasValue)
				StructDefinition__Implementation__ = (Kistl.App.Base.Struct__Implementation__)Context.Find<Kistl.App.Base.Struct>(_fk_StructDefinition.Value);
			else
				StructDefinition__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(StructDefinition != null ? StructDefinition.ID : (int?)null, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._fk_StructDefinition, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(StructDefinition != null ? StructDefinition.ID : (int?)null, xml, "StructDefinition", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._fk_StructDefinition, xml, "StructDefinition", "Kistl.App.Base");
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
			
            base.Export(xml, modules);
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(StructDefinition != null ? StructDefinition.ExportGuid : (Guid?)null, xml, "StructDefinition", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
			
            base.MergeImport(xml);
            XmlStreamer.FromStream(ref this._fk_guid_StructDefinition, xml, "StructDefinition", "Kistl.App.Base");
        }

#endregion

    }


}