// <autogenerated/>


namespace at.dasz.DocumentManagement
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
    /// Abstract Baseclass for File Types
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="File")]
    [System.Diagnostics.DebuggerDisplay("File")]
    public abstract class File__Implementation__ : BaseServerDataObject_EntityFramework, File, Kistl.API.IExportableInternal
    {
    
		public File__Implementation__()
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
        /// Current File Content
        /// </summary>
    /*
    Relation: FK_File_has_Blob
    A: ZeroOrMore File as File
    B: One Blob as Blob
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Blob Blob
        {
            get
            {
                return Blob__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                Blob__Implementation__ = (Kistl.App.Base.Blob__Implementation__)value;
            }
        }
        
        private int? _fk_Blob;
        private Guid? _fk_guid_Blob = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_File_has_Blob", "Blob")]
        public Kistl.App.Base.Blob__Implementation__ Blob__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Blob__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Blob__Implementation__>(
                        "Model.FK_File_has_Blob",
                        "Blob");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnBlob_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.Blob>(__value);
					OnBlob_Getter(this, e);
					__value = (Kistl.App.Base.Blob__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Blob__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Blob__Implementation__>(
                        "Model.FK_File_has_Blob",
                        "Blob");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.Blob __oldValue = (Kistl.App.Base.Blob)r.Value;
                Kistl.App.Base.Blob __newValue = (Kistl.App.Base.Blob)value;

                if(OnBlob_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Blob>(__oldValue, __newValue);
					OnBlob_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.Blob__Implementation__)__newValue;
                if(OnBlob_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Blob>(__oldValue, __newValue);
					OnBlob_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public static event PropertyGetterHandler<at.dasz.DocumentManagement.File, Kistl.App.Base.Blob> OnBlob_Getter;
		public static event PropertyPreSetterHandler<at.dasz.DocumentManagement.File, Kistl.App.Base.Blob> OnBlob_PreSetter;
		public static event PropertyPostSetterHandler<at.dasz.DocumentManagement.File, Kistl.App.Base.Blob> OnBlob_PostSetter;

        /// <summary>
        /// Identity which changed this object
        /// </summary>
    /*
    Relation: FK_File_was_ChangedBy
    A: ZeroOrMore File as File
    B: ZeroOrOne Identity as ChangedBy
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Identity ChangedBy
        {
            get
            {
                return ChangedBy__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                ChangedBy__Implementation__ = (Kistl.App.Base.Identity__Implementation__)value;
            }
        }
        
        private int? _fk_ChangedBy;
        private Guid? _fk_guid_ChangedBy = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_File_was_ChangedBy", "ChangedBy")]
        public Kistl.App.Base.Identity__Implementation__ ChangedBy__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Identity__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Identity__Implementation__>(
                        "Model.FK_File_was_ChangedBy",
                        "ChangedBy");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnChangedBy_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.Identity>(__value);
					OnChangedBy_Getter(this, e);
					__value = (Kistl.App.Base.Identity__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Identity__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Identity__Implementation__>(
                        "Model.FK_File_was_ChangedBy",
                        "ChangedBy");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.Identity __oldValue = (Kistl.App.Base.Identity)r.Value;
                Kistl.App.Base.Identity __newValue = (Kistl.App.Base.Identity)value;

                if(OnChangedBy_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Identity>(__oldValue, __newValue);
					OnChangedBy_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.Identity__Implementation__)__newValue;
                if(OnChangedBy_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Identity>(__oldValue, __newValue);
					OnChangedBy_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public static event PropertyGetterHandler<at.dasz.DocumentManagement.File, Kistl.App.Base.Identity> OnChangedBy_Getter;
		public static event PropertyPreSetterHandler<at.dasz.DocumentManagement.File, Kistl.App.Base.Identity> OnChangedBy_PreSetter;
		public static event PropertyPostSetterHandler<at.dasz.DocumentManagement.File, Kistl.App.Base.Identity> OnChangedBy_PostSetter;

        /// <summary>
        /// Date and time where this object was changed
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual DateTime? ChangedOn
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ChangedOn;
                if (OnChangedOn_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime?>(__result);
                    OnChangedOn_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_ChangedOn != value)
                {
                    var __oldValue = _ChangedOn;
                    var __newValue = value;
                    if(OnChangedOn_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnChangedOn_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ChangedOn", __oldValue, __newValue);
                    _ChangedOn = __newValue;
                    NotifyPropertyChanged("ChangedOn", __oldValue, __newValue);
                    if(OnChangedOn_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnChangedOn_PostSetter(this, __e);
                    }
                }
            }
        }
        private DateTime? _ChangedOn;
		public static event PropertyGetterHandler<at.dasz.DocumentManagement.File, DateTime?> OnChangedOn_Getter;
		public static event PropertyPreSetterHandler<at.dasz.DocumentManagement.File, DateTime?> OnChangedOn_PreSetter;
		public static event PropertyPostSetterHandler<at.dasz.DocumentManagement.File, DateTime?> OnChangedOn_PostSetter;

        /// <summary>
        /// Identity which created this object
        /// </summary>
    /*
    Relation: FK_File_was_CreatedBy
    A: ZeroOrMore File as File
    B: ZeroOrOne Identity as CreatedBy
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Identity CreatedBy
        {
            get
            {
                return CreatedBy__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                CreatedBy__Implementation__ = (Kistl.App.Base.Identity__Implementation__)value;
            }
        }
        
        private int? _fk_CreatedBy;
        private Guid? _fk_guid_CreatedBy = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_File_was_CreatedBy", "CreatedBy")]
        public Kistl.App.Base.Identity__Implementation__ CreatedBy__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Identity__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Identity__Implementation__>(
                        "Model.FK_File_was_CreatedBy",
                        "CreatedBy");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnCreatedBy_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.Identity>(__value);
					OnCreatedBy_Getter(this, e);
					__value = (Kistl.App.Base.Identity__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Identity__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Identity__Implementation__>(
                        "Model.FK_File_was_CreatedBy",
                        "CreatedBy");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.Identity __oldValue = (Kistl.App.Base.Identity)r.Value;
                Kistl.App.Base.Identity __newValue = (Kistl.App.Base.Identity)value;

                if(OnCreatedBy_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Identity>(__oldValue, __newValue);
					OnCreatedBy_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.Identity__Implementation__)__newValue;
                if(OnCreatedBy_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Identity>(__oldValue, __newValue);
					OnCreatedBy_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public static event PropertyGetterHandler<at.dasz.DocumentManagement.File, Kistl.App.Base.Identity> OnCreatedBy_Getter;
		public static event PropertyPreSetterHandler<at.dasz.DocumentManagement.File, Kistl.App.Base.Identity> OnCreatedBy_PreSetter;
		public static event PropertyPostSetterHandler<at.dasz.DocumentManagement.File, Kistl.App.Base.Identity> OnCreatedBy_PostSetter;

        /// <summary>
        /// Date and time where this object was created
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual DateTime? CreatedOn
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _CreatedOn;
                if (OnCreatedOn_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime?>(__result);
                    OnCreatedOn_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_CreatedOn != value)
                {
                    var __oldValue = _CreatedOn;
                    var __newValue = value;
                    if(OnCreatedOn_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnCreatedOn_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("CreatedOn", __oldValue, __newValue);
                    _CreatedOn = __newValue;
                    NotifyPropertyChanged("CreatedOn", __oldValue, __newValue);
                    if(OnCreatedOn_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnCreatedOn_PostSetter(this, __e);
                    }
                }
            }
        }
        private DateTime? _CreatedOn;
		public static event PropertyGetterHandler<at.dasz.DocumentManagement.File, DateTime?> OnCreatedOn_Getter;
		public static event PropertyPreSetterHandler<at.dasz.DocumentManagement.File, DateTime?> OnCreatedOn_PreSetter;
		public static event PropertyPostSetterHandler<at.dasz.DocumentManagement.File, DateTime?> OnCreatedOn_PostSetter;

        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
        private bool _isExportGuidSet = false;
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual Guid ExportGuid
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ExportGuid;
                if (!_isExportGuidSet) {
                    var __p = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("91566b41-879d-4e72-b48b-9677cc156649"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        __result = this._ExportGuid = (Guid)__p.DefaultValue.GetDefaultValue();
                    } else {
                        Kistl.API.Utils.Logging.Log.Warn("Unable to get default value for property 'File.ExportGuid'");
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
		public static event PropertyGetterHandler<at.dasz.DocumentManagement.File, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<at.dasz.DocumentManagement.File, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<at.dasz.DocumentManagement.File, Guid> OnExportGuid_PostSetter;

        /// <summary>
        /// Filename
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string Name
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Name;
                if (OnName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Name != value)
                {
                    var __oldValue = _Name;
                    var __newValue = value;
                    if(OnName_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Name", __oldValue, __newValue);
                    _Name = __newValue;
                    NotifyPropertyChanged("Name", __oldValue, __newValue);
                    if(OnName_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Name;
		public static event PropertyGetterHandler<at.dasz.DocumentManagement.File, string> OnName_Getter;
		public static event PropertyPreSetterHandler<at.dasz.DocumentManagement.File, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<at.dasz.DocumentManagement.File, string> OnName_PostSetter;

        /// <summary>
        /// Handles the change of the current blob
        /// </summary>
		[EventBasedMethod("OnHandleBlobChange_File")]
		public virtual Kistl.App.Base.Blob HandleBlobChange(Kistl.App.Base.Blob oldBlob, Kistl.App.Base.Blob newBlob) 
        {
            var e = new MethodReturnEventArgs<Kistl.App.Base.Blob>();
            if (OnHandleBlobChange_File != null)
            {
                OnHandleBlobChange_File(this, e, oldBlob, newBlob);
            }
            else
            {
                throw new NotImplementedException("No handler registered on File.HandleBlobChange");
            }
            return e.Result;
        }
		public delegate void HandleBlobChange_Handler<T>(T obj, MethodReturnEventArgs<Kistl.App.Base.Blob> ret, Kistl.App.Base.Blob oldBlob, Kistl.App.Base.Blob newBlob);
		public static event HandleBlobChange_Handler<File> OnHandleBlobChange_File;



        /// <summary>
        /// Opens the Content readonly
        /// </summary>
		[EventBasedMethod("OnOpen_File")]
		public virtual void Open() 
		{
            // base.Open();
            if (OnOpen_File != null)
            {
				OnOpen_File(this);
			}
			else
			{
                throw new NotImplementedException("No handler registered on File.Open");
			}
        }
		public delegate void Open_Handler<T>(T obj);
		public static event Open_Handler<File> OnOpen_File;



        /// <summary>
        /// Uploads a new Content
        /// </summary>
		[EventBasedMethod("OnUpload_File")]
		public virtual void Upload() 
		{
            // base.Upload();
            if (OnUpload_File != null)
            {
				OnUpload_File(this);
			}
			else
			{
                throw new NotImplementedException("No handler registered on File.Upload");
			}
        }
		public delegate void Upload_Handler<T>(T obj);
		public static event Upload_Handler<File> OnUpload_File;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(File));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (File)obj;
			var otherImpl = (File__Implementation__)obj;
			var me = (File)this;

			me.ChangedOn = other.ChangedOn;
			me.CreatedOn = other.CreatedOn;
			me.ExportGuid = other.ExportGuid;
			me.Name = other.Name;
			this._fk_Blob = otherImpl._fk_Blob;
			this._fk_ChangedBy = otherImpl._fk_ChangedBy;
			this._fk_CreatedBy = otherImpl._fk_CreatedBy;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_File")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_File != null)
            {
                OnToString_File(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<File> OnToString_File;

        [EventBasedMethod("OnPreSave_File")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_File != null) OnPreSave_File(this);
        }
        public static event ObjectEventHandler<File> OnPreSave_File;

        [EventBasedMethod("OnPostSave_File")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_File != null) OnPostSave_File(this);
        }
        public static event ObjectEventHandler<File> OnPostSave_File;

        [EventBasedMethod("OnCreated_File")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_File != null) OnCreated_File(this);
        }
        public static event ObjectEventHandler<File> OnCreated_File;

        [EventBasedMethod("OnDeleting_File")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_File != null) OnDeleting_File(this);
        }
        public static event ObjectEventHandler<File> OnDeleting_File;


		private static readonly System.ComponentModel.PropertyDescriptor[] _properties = new System.ComponentModel.PropertyDescriptor[] {
			// else
			new CustomPropertyDescriptor<File__Implementation__, Kistl.App.Base.Blob>(
				new Guid("ef5addda-340f-4a87-83c9-3ee419519343"),
				"Blob",
				null,
				obj => obj.Blob,
				(obj, val) => obj.Blob = val),
			// else
			new CustomPropertyDescriptor<File__Implementation__, Kistl.App.Base.Identity>(
				new Guid("c22516f3-b897-4827-a025-27d1515aadcd"),
				"ChangedBy",
				null,
				obj => obj.ChangedBy,
				(obj, val) => obj.ChangedBy = val),
			// else
			new CustomPropertyDescriptor<File__Implementation__, DateTime?>(
				new Guid("c144678d-632d-4a83-8041-280d674f4453"),
				"ChangedOn",
				null,
				obj => obj.ChangedOn,
				(obj, val) => obj.ChangedOn = val),
			// else
			new CustomPropertyDescriptor<File__Implementation__, Kistl.App.Base.Identity>(
				new Guid("dc8da15a-a432-43fd-b93f-9b3530ce3144"),
				"CreatedBy",
				null,
				obj => obj.CreatedBy,
				(obj, val) => obj.CreatedBy = val),
			// else
			new CustomPropertyDescriptor<File__Implementation__, DateTime?>(
				new Guid("e1892507-375b-4b52-ab20-16095dfc3514"),
				"CreatedOn",
				null,
				obj => obj.CreatedOn,
				(obj, val) => obj.CreatedOn = val),
			// else
			new CustomPropertyDescriptor<File__Implementation__, Guid>(
				new Guid("91566b41-879d-4e72-b48b-9677cc156649"),
				"ExportGuid",
				null,
				obj => obj.ExportGuid,
				(obj, val) => obj.ExportGuid = val),
			// else
			new CustomPropertyDescriptor<File__Implementation__, string>(
				new Guid("1c5f2bea-9915-4634-8ff9-5fd6f0871704"),
				"Name",
				null,
				obj => obj.Name,
				(obj, val) => obj.Name = val),
			// rel: File has Blob (d93a4ed6-3b8b-44f7-b839-f528d1c06abd)
			// rel: File was ChangedBy (2ff68641-0051-4f2e-a8ee-5f50b9d507f3)
			// rel: File was CreatedBy (1f543299-93ce-4441-a3d7-6d95e8546350)
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

			if (_fk_guid_Blob.HasValue)
				Blob__Implementation__ = (Kistl.App.Base.Blob__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.Blob>(_fk_guid_Blob.Value);
			else if (_fk_Blob.HasValue)
				Blob__Implementation__ = (Kistl.App.Base.Blob__Implementation__)Context.Find<Kistl.App.Base.Blob>(_fk_Blob.Value);
			else
				Blob__Implementation__ = null;

			if (_fk_guid_ChangedBy.HasValue)
				ChangedBy__Implementation__ = (Kistl.App.Base.Identity__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.Identity>(_fk_guid_ChangedBy.Value);
			else if (_fk_ChangedBy.HasValue)
				ChangedBy__Implementation__ = (Kistl.App.Base.Identity__Implementation__)Context.Find<Kistl.App.Base.Identity>(_fk_ChangedBy.Value);
			else
				ChangedBy__Implementation__ = null;

			if (_fk_guid_CreatedBy.HasValue)
				CreatedBy__Implementation__ = (Kistl.App.Base.Identity__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.Identity>(_fk_guid_CreatedBy.Value);
			else if (_fk_CreatedBy.HasValue)
				CreatedBy__Implementation__ = (Kistl.App.Base.Identity__Implementation__)Context.Find<Kistl.App.Base.Identity>(_fk_CreatedBy.Value);
			else
				CreatedBy__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(Blob != null ? Blob.ID : (int?)null, binStream);
			if (auxObjects != null) {
				auxObjects.Add(Blob);
			}
            BinarySerializer.ToStream(ChangedBy != null ? ChangedBy.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._ChangedOn, binStream);
            BinarySerializer.ToStream(CreatedBy != null ? CreatedBy.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._CreatedOn, binStream);
            BinarySerializer.ToStream(this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.ToStream(this._ExportGuid, binStream);
            }
            BinarySerializer.ToStream(this._Name, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._fk_Blob, binStream);
            BinarySerializer.FromStream(out this._fk_ChangedBy, binStream);
            BinarySerializer.FromStream(out this._ChangedOn, binStream);
            BinarySerializer.FromStream(out this._fk_CreatedBy, binStream);
            BinarySerializer.FromStream(out this._CreatedOn, binStream);
            BinarySerializer.FromStream(out this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.FromStream(out this._ExportGuid, binStream);
            }
            BinarySerializer.FromStream(out this._Name, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(Blob != null ? Blob.ID : (int?)null, xml, "Blob", "at.dasz.DocumentManagement");
            XmlStreamer.ToStream(ChangedBy != null ? ChangedBy.ID : (int?)null, xml, "ChangedBy", "at.dasz.DocumentManagement");
            XmlStreamer.ToStream(this._ChangedOn, xml, "ChangedOn", "at.dasz.DocumentManagement");
            XmlStreamer.ToStream(CreatedBy != null ? CreatedBy.ID : (int?)null, xml, "CreatedBy", "at.dasz.DocumentManagement");
            XmlStreamer.ToStream(this._CreatedOn, xml, "CreatedOn", "at.dasz.DocumentManagement");
            XmlStreamer.ToStream(this._isExportGuidSet, xml, "IsExportGuidSet", "at.dasz.DocumentManagement");
            if (this._isExportGuidSet) {
                XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "at.dasz.DocumentManagement");
            }
            XmlStreamer.ToStream(this._Name, xml, "Name", "at.dasz.DocumentManagement");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._fk_Blob, xml, "Blob", "at.dasz.DocumentManagement");
            XmlStreamer.FromStream(ref this._fk_ChangedBy, xml, "ChangedBy", "at.dasz.DocumentManagement");
            XmlStreamer.FromStream(ref this._ChangedOn, xml, "ChangedOn", "at.dasz.DocumentManagement");
            XmlStreamer.FromStream(ref this._fk_CreatedBy, xml, "CreatedBy", "at.dasz.DocumentManagement");
            XmlStreamer.FromStream(ref this._CreatedOn, xml, "CreatedOn", "at.dasz.DocumentManagement");
            XmlStreamer.FromStream(ref this._isExportGuidSet, xml, "IsExportGuidSet", "at.dasz.DocumentManagement");
            if (this._isExportGuidSet) {
                XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "at.dasz.DocumentManagement");
            }
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "at.dasz.DocumentManagement");
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            
            xml.WriteAttributeString("ExportGuid", this._ExportGuid.ToString());
            if (modules.Contains("*") || modules.Contains("at.dasz.DocumentManagement")) XmlStreamer.ToStream(Blob != null ? Blob.ExportGuid : (Guid?)null, xml, "Blob", "at.dasz.DocumentManagement");
    
            if (modules.Contains("*") || modules.Contains("at.dasz.DocumentManagement")) XmlStreamer.ToStream(this._ChangedOn, xml, "ChangedOn", "at.dasz.DocumentManagement");
    
            if (modules.Contains("*") || modules.Contains("at.dasz.DocumentManagement")) XmlStreamer.ToStream(this._CreatedOn, xml, "CreatedOn", "at.dasz.DocumentManagement");
    
            if (modules.Contains("*") || modules.Contains("at.dasz.DocumentManagement")) XmlStreamer.ToStream(this._Name, xml, "Name", "at.dasz.DocumentManagement");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            XmlStreamer.FromStream(ref this._fk_guid_Blob, xml, "Blob", "at.dasz.DocumentManagement");
            XmlStreamer.FromStream(ref this._ChangedOn, xml, "ChangedOn", "at.dasz.DocumentManagement");
            XmlStreamer.FromStream(ref this._CreatedOn, xml, "CreatedOn", "at.dasz.DocumentManagement");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "at.dasz.DocumentManagement");
            this._isExportGuidSet = true;
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "at.dasz.DocumentManagement");
        }

#endregion

    }


}