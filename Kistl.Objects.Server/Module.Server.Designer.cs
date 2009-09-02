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
    /// Metadefinition Object for Modules.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="Module")]
    [System.Diagnostics.DebuggerDisplay("Module")]
    public class Module__Implementation__ : BaseServerDataObject_EntityFramework, Kistl.API.IExportableInternal, Module
    {
    
		public Module__Implementation__()
		{
        }

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.IdProperty
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
        /// Assemblies des Moduls
        /// </summary>
    /*
    Relation: FK_Module_has_Assembly
    A: One Module as Module
    B: ZeroOrMore Assembly as Assemblies
    Preferred Storage: MergeIntoB
    */
        // object list property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectListProperty
	    // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Base.Assembly> Assemblies
        {
            get
            {
                if (_AssembliesWrapper == null)
                {
                    _AssembliesWrapper = new EntityCollectionWrapper<Kistl.App.Base.Assembly, Kistl.App.Base.Assembly__Implementation__>(
                            this.Context, Assemblies__Implementation__);
                }
                return _AssembliesWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Module_has_Assembly", "Assemblies")]
        public EntityCollection<Kistl.App.Base.Assembly__Implementation__> Assemblies__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Base.Assembly__Implementation__>(
                        "Model.FK_Module_has_Assembly",
                        "Assemblies");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityCollectionWrapper<Kistl.App.Base.Assembly, Kistl.App.Base.Assembly__Implementation__> _AssembliesWrapper;



        /// <summary>
        /// Datentypendes Modules
        /// </summary>
    /*
    Relation: FK_Module_has_DataType
    A: One Module as Module
    B: ZeroOrMore DataType as DataTypes
    Preferred Storage: MergeIntoB
    */
        // object list property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectListProperty
	    // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Base.DataType> DataTypes
        {
            get
            {
                if (_DataTypesWrapper == null)
                {
                    _DataTypesWrapper = new EntityCollectionWrapper<Kistl.App.Base.DataType, Kistl.App.Base.DataType__Implementation__>(
                            this.Context, DataTypes__Implementation__);
                }
                return _DataTypesWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Module_has_DataType", "DataTypes")]
        public EntityCollection<Kistl.App.Base.DataType__Implementation__> DataTypes__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Base.DataType__Implementation__>(
                        "Model.FK_Module_has_DataType",
                        "DataTypes");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityCollectionWrapper<Kistl.App.Base.DataType, Kistl.App.Base.DataType__Implementation__> _DataTypesWrapper;



        /// <summary>
        /// Description of this Module
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
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
		public event PropertyGetterHandler<Kistl.App.Base.Module, string> OnDescription_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.Module, string> OnDescription_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.Module, string> OnDescription_PostSetter;
        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
        private bool _isExportGuidSet = false;
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual Guid ExportGuid
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ExportGuid;
                if (!_isExportGuidSet) {
                    var __p = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("75e3db82-220c-474e-973a-ceb65fd8386d"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        __result = this._ExportGuid = (Guid)__p.DefaultValue.GetDefaultValue();
                    } else {
                        System.Diagnostics.Trace.TraceWarning("Unable to get default value for property 'Module.ExportGuid'");
                    }
                }
                if (OnExportGuid_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<Guid>(__result);
                    OnExportGuid_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                    _isExportGuidSet = true;
                if (_ExportGuid != value)
                {
                    var __oldValue = _ExportGuid;
                    var __newValue = value;
                    if(OnExportGuid_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ExportGuid", __oldValue, __newValue);
                    _ExportGuid = __newValue;
                    NotifyPropertyChanged("ExportGuid", __oldValue, __newValue);
                    if(OnExportGuid_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PostSetter(this, __e);
                    }
                }
            }
        }
        private Guid _ExportGuid;
		public event PropertyGetterHandler<Kistl.App.Base.Module, Guid> OnExportGuid_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.Module, Guid> OnExportGuid_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.Module, Guid> OnExportGuid_PostSetter;
        /// <summary>
        /// Name des Moduls
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string ModuleName
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ModuleName;
                if (OnModuleName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnModuleName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_ModuleName != value)
                {
                    var __oldValue = _ModuleName;
                    var __newValue = value;
                    if(OnModuleName_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnModuleName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ModuleName", __oldValue, __newValue);
                    _ModuleName = __newValue;
                    NotifyPropertyChanged("ModuleName", __oldValue, __newValue);
                    if(OnModuleName_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnModuleName_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _ModuleName;
		public event PropertyGetterHandler<Kistl.App.Base.Module, string> OnModuleName_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.Module, string> OnModuleName_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.Module, string> OnModuleName_PostSetter;
        /// <summary>
        /// CLR Namespace des Moduls
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string Namespace
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Namespace;
                if (OnNamespace_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnNamespace_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Namespace != value)
                {
                    var __oldValue = _Namespace;
                    var __newValue = value;
                    if(OnNamespace_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnNamespace_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Namespace", __oldValue, __newValue);
                    _Namespace = __newValue;
                    NotifyPropertyChanged("Namespace", __oldValue, __newValue);
                    if(OnNamespace_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnNamespace_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Namespace;
		public event PropertyGetterHandler<Kistl.App.Base.Module, string> OnNamespace_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.Module, string> OnNamespace_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.Module, string> OnNamespace_PostSetter;
		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Module));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Module)obj;
			var otherImpl = (Module__Implementation__)obj;
			var me = (Module)this;

			me.Description = other.Description;
			me.ExportGuid = other.ExportGuid;
			me.ModuleName = other.ModuleName;
			me.Namespace = other.Namespace;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_Module")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Module != null)
            {
                OnToString_Module(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<Module> OnToString_Module;

        [EventBasedMethod("OnPreSave_Module")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Module != null) OnPreSave_Module(this);
        }
        public event ObjectEventHandler<Module> OnPreSave_Module;

        [EventBasedMethod("OnPostSave_Module")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Module != null) OnPostSave_Module(this);
        }
        public event ObjectEventHandler<Module> OnPostSave_Module;

        [EventBasedMethod("OnCreated_Module")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_Module != null) OnCreated_Module(this);
        }
        public event ObjectEventHandler<Module> OnCreated_Module;

        [EventBasedMethod("OnDeleting_Module")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Module != null) OnDeleting_Module(this);
        }
        public event ObjectEventHandler<Module> OnDeleting_Module;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "Assemblies":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("cab23a85-a179-475c-a70f-77789e2a2907")).Constraints
						.Where(c => !c.IsValid(this, this.Assemblies))
						.Select(c => c.GetErrorText(this, this.Assemblies))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "DataTypes":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("a1711984-5263-4407-ac67-6e4123954976")).Constraints
						.Where(c => !c.IsValid(this, this.DataTypes))
						.Select(c => c.GetErrorText(this, this.DataTypes))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Description":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("79408b86-1731-42ad-89b2-ed5c567fbf8a")).Constraints
						.Where(c => !c.IsValid(this, this.Description))
						.Select(c => c.GetErrorText(this, this.Description))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ExportGuid":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("75e3db82-220c-474e-973a-ceb65fd8386d")).Constraints
						.Where(c => !c.IsValid(this, this.ExportGuid))
						.Select(c => c.GetErrorText(this, this.ExportGuid))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "ModuleName":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("63facb30-d8f7-42f6-8c14-85933d5f94b8")).Constraints
						.Where(c => !c.IsValid(this, this.ModuleName))
						.Select(c => c.GetErrorText(this, this.ModuleName))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Namespace":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("36d2b9e7-d6b9-4a9c-a363-7e059a637919")).Constraints
						.Where(c => !c.IsValid(this, this.Namespace))
						.Select(c => c.GetErrorText(this, this.Namespace))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}

		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
			// fix direct object references
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._Description, binStream);
            BinarySerializer.ToStream(this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
				BinarySerializer.ToStream(this._ExportGuid, binStream);
			}
            BinarySerializer.ToStream(this._ModuleName, binStream);
            BinarySerializer.ToStream(this._Namespace, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._Description, binStream);
            BinarySerializer.FromStream(out this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
				BinarySerializer.FromStream(out this._ExportGuid, binStream);
			}
            BinarySerializer.FromStream(out this._ModuleName, binStream);
            BinarySerializer.FromStream(out this._Namespace, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.ToStream(this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
				XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
			}
            XmlStreamer.ToStream(this._ModuleName, xml, "ModuleName", "Kistl.App.Base");
            XmlStreamer.ToStream(this._Namespace, xml, "Namespace", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
				XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
			}
            XmlStreamer.FromStream(ref this._ModuleName, xml, "ModuleName", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Namespace, xml, "Namespace", "Kistl.App.Base");
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
			
			xml.WriteAttributeString("ExportGuid", this.ExportGuid.ToString());
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._Description, xml, "Description", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._ModuleName, xml, "ModuleName", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._Namespace, xml, "Namespace", "Kistl.App.Base");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            XmlStreamer.FromStream(ref this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            this._isExportGuidSet = true;
            XmlStreamer.FromStream(ref this._ModuleName, xml, "ModuleName", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Namespace, xml, "Namespace", "Kistl.App.Base");
        }

#endregion

    }


}