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
    using Kistl.DALProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="Icon")]
    [System.Diagnostics.DebuggerDisplay("Icon")]
    public class Icon__Implementation__ : BaseServerDataObject_EntityFramework, Icon, Kistl.API.IExportableInternal
    {
    
		public Icon__Implementation__()
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
                    var __p = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("6ce563d7-28e8-4806-bdd1-84c220a6c3ca"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        __result = this._ExportGuid = (Guid)__p.DefaultValue.GetDefaultValue();
                    } else {
                        System.Diagnostics.Trace.TraceWarning("Unable to get default value for property 'Icon.ExportGuid'");
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
                if (_ExportGuid != value)
                {
                    var __oldValue = _ExportGuid;
                    var __newValue = value;
                    _isExportGuidSet = true;
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
		public event PropertyGetterHandler<Kistl.App.GUI.Icon, Guid> OnExportGuid_Getter;
		public event PropertyPreSetterHandler<Kistl.App.GUI.Icon, Guid> OnExportGuid_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.GUI.Icon, Guid> OnExportGuid_PostSetter;
        /// <summary>
        /// Filename of the Icon
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string IconFile
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _IconFile;
                if (OnIconFile_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnIconFile_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_IconFile != value)
                {
                    var __oldValue = _IconFile;
                    var __newValue = value;
                    if(OnIconFile_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnIconFile_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IconFile", __oldValue, __newValue);
                    _IconFile = __newValue;
                    NotifyPropertyChanged("IconFile", __oldValue, __newValue);
                    if(OnIconFile_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnIconFile_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _IconFile;
		public event PropertyGetterHandler<Kistl.App.GUI.Icon, string> OnIconFile_Getter;
		public event PropertyPreSetterHandler<Kistl.App.GUI.Icon, string> OnIconFile_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.GUI.Icon, string> OnIconFile_PostSetter;
        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Icon_has_Module
    A: ZeroOrMore Icon as Icon
    B: ZeroOrOne Module as Module
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
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
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                Module__Implementation__ = (Kistl.App.Base.Module__Implementation__)value;
            }
        }
        
        private int? _fk_Module;
        private Guid? _fk_guid_Module = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Icon_has_Module", "Module")]
        public Kistl.App.Base.Module__Implementation__ Module__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Module__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module__Implementation__>(
                        "Model.FK_Icon_has_Module",
                        "Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnModule_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.Module>(__value);
					OnModule_Getter(this, e);
					__value = (Kistl.App.Base.Module__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Module__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module__Implementation__>(
                        "Model.FK_Icon_has_Module",
                        "Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.Module __oldValue = (Kistl.App.Base.Module)r.Value;
                Kistl.App.Base.Module __newValue = (Kistl.App.Base.Module)value;

                if(OnModule_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Module>(__oldValue, __newValue);
					OnModule_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.Module__Implementation__)__newValue;
                if(OnModule_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Module>(__oldValue, __newValue);
					OnModule_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.GUI.Icon, Kistl.App.Base.Module> OnModule_Getter;
		public event PropertyPreSetterHandler<Kistl.App.GUI.Icon, Kistl.App.Base.Module> OnModule_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.GUI.Icon, Kistl.App.Base.Module> OnModule_PostSetter;
		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(Icon));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Icon)obj;
			var otherImpl = (Icon__Implementation__)obj;
			var me = (Icon)this;

			me.ExportGuid = other.ExportGuid;
			me.IconFile = other.IconFile;
			this._fk_Module = otherImpl._fk_Module;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_Icon")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Icon != null)
            {
                OnToString_Icon(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<Icon> OnToString_Icon;

        [EventBasedMethod("OnPreSave_Icon")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Icon != null) OnPreSave_Icon(this);
        }
        public event ObjectEventHandler<Icon> OnPreSave_Icon;

        [EventBasedMethod("OnPostSave_Icon")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Icon != null) OnPostSave_Icon(this);
        }
        public event ObjectEventHandler<Icon> OnPostSave_Icon;

        [EventBasedMethod("OnCreated_Icon")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_Icon != null) OnCreated_Icon(this);
        }
        public event ObjectEventHandler<Icon> OnCreated_Icon;

        [EventBasedMethod("OnDeleting_Icon")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Icon != null) OnDeleting_Icon(this);
        }
        public event ObjectEventHandler<Icon> OnDeleting_Icon;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "ExportGuid":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("6ce563d7-28e8-4806-bdd1-84c220a6c3ca")).Constraints
						.Where(c => !c.IsValid(this, this.ExportGuid))
						.Select(c => c.GetErrorText(this, this.ExportGuid))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "IconFile":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("cdbdfc01-5faa-416b-960f-2eb220f268fe")).Constraints
						.Where(c => !c.IsValid(this, this.IconFile))
						.Select(c => c.GetErrorText(this, this.IconFile))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Module":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("052273ac-706a-446b-bb86-83c726ee66d6")).Constraints
						.Where(c => !c.IsValid(this, this.Module))
						.Select(c => c.GetErrorText(this, this.Module))
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

			if (_fk_guid_Module.HasValue)
				Module__Implementation__ = (Kistl.App.Base.Module__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.Module>(_fk_guid_Module.Value);
			else if (_fk_Module.HasValue)
				Module__Implementation__ = (Kistl.App.Base.Module__Implementation__)Context.Find<Kistl.App.Base.Module>(_fk_Module.Value);
			else
				Module__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._ExportGuid, binStream);
            BinarySerializer.ToStream(this._IconFile, binStream);
            BinarySerializer.ToStream(Module != null ? Module.ID : (int?)null, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._ExportGuid, binStream);
            BinarySerializer.FromStream(out this._IconFile, binStream);
            BinarySerializer.FromStream(out this._fk_Module, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.ToStream(this._IconFile, xml, "IconFile", "Kistl.App.GUI");
            XmlStreamer.ToStream(Module != null ? Module.ID : (int?)null, xml, "Module", "Kistl.App.GUI");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IconFile, xml, "IconFile", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_Module, xml, "Module", "Kistl.App.GUI");
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
			
			xml.WriteAttributeString("ExportGuid", this.ExportGuid.ToString());
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this._IconFile, xml, "IconFile", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(Module != null ? Module.ExportGuid : (Guid?)null, xml, "Module", "Kistl.App.GUI");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._IconFile, xml, "IconFile", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_guid_Module, xml, "Module", "Kistl.App.GUI");
        }

#endregion

    }


}