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

    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Zetbox.API.Server;
    using Zetbox.DalProvider.Ef;

    /// <summary>
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="Icon")]
    [System.Diagnostics.DebuggerDisplay("Icon")]
    public class IconEfImpl : BaseServerDataObject_EntityFramework, Icon, Zetbox.API.IExportableInternal
    {
        private static readonly Guid _objectClassID = new Guid("78b6f354-013b-4129-a390-7f3a5a5e28e9");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public IconEfImpl()
            : base(null)
        {
        }

        public IconEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Icon_has_Blob
    A: ZeroOrOne Icon as Icon
    B: One Blob as Blob
    Preferred Storage: MergeIntoA
    */
        // object reference property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Blob
        // fkBackingName=_fk_Blob; fkGuidBackingName=_fk_guid_Blob;
        // referencedInterface=Zetbox.App.Base.Blob; moduleNamespace=Zetbox.App.GUI;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Base.Blob Blob
        {
            get { return BlobImpl; }
            set { BlobImpl = (Zetbox.App.Base.BlobEfImpl)value; }
        }

        private int? _fk_Blob;

        private Guid? _fk_guid_Blob = null;

        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Icon_has_Blob", "Blob")]
        public Zetbox.App.Base.BlobEfImpl BlobImpl
        {
            get
            {
                Zetbox.App.Base.BlobEfImpl __value;
                EntityReference<Zetbox.App.Base.BlobEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.Base.BlobEfImpl>(
                        "Model.FK_Icon_has_Blob",
                        "Blob");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                if (r.Value != null) r.Value.AttachToContext(this.Context);
                __value = r.Value;
                if (OnBlob_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.Blob>(__value);
                    OnBlob_Getter(this, e);
                    __value = (Zetbox.App.Base.BlobEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                EntityReference<Zetbox.App.Base.BlobEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.Base.BlobEfImpl>(
                        "Model.FK_Icon_has_Blob",
                        "Blob");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Zetbox.App.Base.BlobEfImpl __oldValue = (Zetbox.App.Base.BlobEfImpl)r.Value;
                Zetbox.App.Base.BlobEfImpl __newValue = (Zetbox.App.Base.BlobEfImpl)value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Blob", __oldValue, __newValue);

                if (OnBlob_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.Blob>(__oldValue, __newValue);
                    OnBlob_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.BlobEfImpl)e.Result;
                }

                r.Value = (Zetbox.App.Base.BlobEfImpl)__newValue;

                if (OnBlob_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.Blob>(__oldValue, __newValue);
                    OnBlob_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Blob", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;
            }
        }

        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Blob
		public static event PropertyGetterHandler<Zetbox.App.GUI.Icon, Zetbox.App.Base.Blob> OnBlob_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.Icon, Zetbox.App.Base.Blob> OnBlob_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.Icon, Zetbox.App.Base.Blob> OnBlob_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.Icon> OnBlob_IsValid;

        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public Guid ExportGuid
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ExportGuid;
                if (!_isExportGuidSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("6ce563d7-28e8-4806-bdd1-84c220a6c3ca"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._ExportGuid = (Guid)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'Icon.ExportGuid'");
                    }
                }
                if (OnExportGuid_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<Guid>(__result);
                    OnExportGuid_Getter(this, __e);
                    __result = _ExportGuid = __e.Result;
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
                    if (OnExportGuid_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ExportGuid", __oldValue, __newValue);
                    _ExportGuid = __newValue;
                    NotifyPropertyChanged("ExportGuid", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnExportGuid_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("ExportGuid");
				}
            }
        }
        private Guid _ExportGuid_store;
        private Guid _ExportGuid {
            get { return _ExportGuid_store; }
            set {
                ReportEfPropertyChanging("ExportGuid");
                _ExportGuid_store = value;
                ReportEfPropertyChanged("ExportGuid");
            }
        }
        private bool _isExportGuidSet = false;
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.GUI.Icon, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.Icon, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.Icon, Guid> OnExportGuid_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.Icon> OnExportGuid_IsValid;

        /// <summary>
        /// Filename of the Icon
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public string IconFile
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
                    __result = _IconFile = __e.Result;
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
                    if (OnIconFile_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnIconFile_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IconFile", __oldValue, __newValue);
                    _IconFile = __newValue;
                    NotifyPropertyChanged("IconFile", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnIconFile_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnIconFile_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("IconFile");
				}
            }
        }
        private string _IconFile_store;
        private string _IconFile {
            get { return _IconFile_store; }
            set {
                ReportEfPropertyChanging("IconFile");
                _IconFile_store = value;
                ReportEfPropertyChanged("IconFile");
            }
        }
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.GUI.Icon, string> OnIconFile_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.Icon, string> OnIconFile_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.Icon, string> OnIconFile_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.Icon> OnIconFile_IsValid;

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Icon_has_Module
    A: ZeroOrMore Icon as Icon
    B: One Module as Module
    Preferred Storage: MergeIntoA
    */
        // object reference property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Module
        // fkBackingName=_fk_Module; fkGuidBackingName=_fk_guid_Module;
        // referencedInterface=Zetbox.App.Base.Module; moduleNamespace=Zetbox.App.GUI;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Base.Module Module
        {
            get { return ModuleImpl; }
            set { ModuleImpl = (Zetbox.App.Base.ModuleEfImpl)value; }
        }

        private int? _fk_Module;

        private Guid? _fk_guid_Module = null;

        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Icon_has_Module", "Module")]
        public Zetbox.App.Base.ModuleEfImpl ModuleImpl
        {
            get
            {
                Zetbox.App.Base.ModuleEfImpl __value;
                EntityReference<Zetbox.App.Base.ModuleEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.Base.ModuleEfImpl>(
                        "Model.FK_Icon_has_Module",
                        "Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                if (r.Value != null) r.Value.AttachToContext(this.Context);
                __value = r.Value;
                if (OnModule_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.Module>(__value);
                    OnModule_Getter(this, e);
                    __value = (Zetbox.App.Base.ModuleEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                EntityReference<Zetbox.App.Base.ModuleEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.Base.ModuleEfImpl>(
                        "Model.FK_Icon_has_Module",
                        "Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Zetbox.App.Base.ModuleEfImpl __oldValue = (Zetbox.App.Base.ModuleEfImpl)r.Value;
                Zetbox.App.Base.ModuleEfImpl __newValue = (Zetbox.App.Base.ModuleEfImpl)value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Module", __oldValue, __newValue);

                if (OnModule_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.Module>(__oldValue, __newValue);
                    OnModule_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.ModuleEfImpl)e.Result;
                }

                r.Value = (Zetbox.App.Base.ModuleEfImpl)__newValue;

                if (OnModule_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.Module>(__oldValue, __newValue);
                    OnModule_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Module", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;
            }
        }

        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Module
		public static event PropertyGetterHandler<Zetbox.App.GUI.Icon, Zetbox.App.Base.Module> OnModule_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.Icon, Zetbox.App.Base.Module> OnModule_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.Icon, Zetbox.App.Base.Module> OnModule_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.Icon> OnModule_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetName_Icon")]
        public virtual string GetName()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetName_Icon != null)
            {
                OnGetName_Icon(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on Icon.GetName");
            }
            return e.Result;
        }
        public delegate void GetName_Handler<T>(T obj, MethodReturnEventArgs<string> ret);
        public static event GetName_Handler<Icon> OnGetName_Icon;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<Icon> OnGetName_Icon_CanExec;

        [EventBasedMethod("OnGetName_Icon_CanExec")]
        public virtual bool GetNameCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetName_Icon_CanExec != null)
				{
					OnGetName_Icon_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<Icon> OnGetName_Icon_CanExecReason;

        [EventBasedMethod("OnGetName_Icon_CanExecReason")]
        public virtual string GetNameCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetName_Icon_CanExecReason != null)
				{
					OnGetName_Icon_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnOpen_Icon")]
        public virtual void Open()
        {
            // base.Open();
            if (OnOpen_Icon != null)
            {
                OnOpen_Icon(this);
            }
            else
            {
                throw new NotImplementedException("No handler registered on method Icon.Open");
            }
        }
        public delegate void Open_Handler<T>(T obj);
        public static event Open_Handler<Icon> OnOpen_Icon;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<Icon> OnOpen_Icon_CanExec;

        [EventBasedMethod("OnOpen_Icon_CanExec")]
        public virtual bool OpenCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnOpen_Icon_CanExec != null)
				{
					OnOpen_Icon_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<Icon> OnOpen_Icon_CanExecReason;

        [EventBasedMethod("OnOpen_Icon_CanExecReason")]
        public virtual string OpenCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnOpen_Icon_CanExecReason != null)
				{
					OnOpen_Icon_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnUpload_Icon")]
        public virtual void Upload()
        {
            // base.Upload();
            if (OnUpload_Icon != null)
            {
                OnUpload_Icon(this);
            }
            else
            {
                throw new NotImplementedException("No handler registered on method Icon.Upload");
            }
        }
        public delegate void Upload_Handler<T>(T obj);
        public static event Upload_Handler<Icon> OnUpload_Icon;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<Icon> OnUpload_Icon_CanExec;

        [EventBasedMethod("OnUpload_Icon_CanExec")]
        public virtual bool UploadCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnUpload_Icon_CanExec != null)
				{
					OnUpload_Icon_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<Icon> OnUpload_Icon_CanExecReason;

        [EventBasedMethod("OnUpload_Icon_CanExecReason")]
        public virtual string UploadCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnUpload_Icon_CanExecReason != null)
				{
					OnUpload_Icon_CanExecReason(this, e);
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
            return typeof(Icon);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (Icon)obj;
            var otherImpl = (IconEfImpl)obj;
            var me = (Icon)this;

            me.ExportGuid = other.ExportGuid;
            me.IconFile = other.IconFile;
            this._fk_Blob = otherImpl._fk_Blob;
            this._fk_Module = otherImpl._fk_Module;
        }

        public override void AttachToContext(IZetboxContext ctx)
        {
            base.AttachToContext(ctx);
        }
        public override void SetNew()
        {
            base.SetNew();
        }
        #region Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "Blob":
                case "ExportGuid":
                case "IconFile":
                case "Module":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }
        #endregion // Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_guid_Blob.HasValue)
                BlobImpl = (Zetbox.App.Base.BlobEfImpl)Context.FindPersistenceObject<Zetbox.App.Base.Blob>(_fk_guid_Blob.Value);
            else
            if (_fk_Blob.HasValue)
                BlobImpl = (Zetbox.App.Base.BlobEfImpl)Context.Find<Zetbox.App.Base.Blob>(_fk_Blob.Value);
            else
                BlobImpl = null;

            if (_fk_guid_Module.HasValue)
                ModuleImpl = (Zetbox.App.Base.ModuleEfImpl)Context.FindPersistenceObject<Zetbox.App.Base.Module>(_fk_guid_Module.Value);
            else
            if (_fk_Module.HasValue)
                ModuleImpl = (Zetbox.App.Base.ModuleEfImpl)Context.Find<Zetbox.App.Base.Module>(_fk_Module.Value);
            else
                ModuleImpl = null;
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
                    new PropertyDescriptorEfImpl<Icon, Zetbox.App.Base.Blob>(
                        lazyCtx,
                        new Guid("f4dfb868-260d-450b-84b8-833dac4d25ee"),
                        "Blob",
                        null,
                        obj => obj.Blob,
                        (obj, val) => obj.Blob = val,
						obj => OnBlob_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<Icon, Guid>(
                        lazyCtx,
                        new Guid("6ce563d7-28e8-4806-bdd1-84c220a6c3ca"),
                        "ExportGuid",
                        null,
                        obj => obj.ExportGuid,
                        (obj, val) => obj.ExportGuid = val,
						obj => OnExportGuid_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<Icon, string>(
                        lazyCtx,
                        new Guid("cdbdfc01-5faa-416b-960f-2eb220f268fe"),
                        "IconFile",
                        null,
                        obj => obj.IconFile,
                        (obj, val) => obj.IconFile = val,
						obj => OnIconFile_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<Icon, Zetbox.App.Base.Module>(
                        lazyCtx,
                        new Guid("052273ac-706a-446b-bb86-83c726ee66d6"),
                        "Module",
                        null,
                        obj => obj.Module,
                        (obj, val) => obj.Module = val,
						obj => OnModule_IsValid), 
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
        #region Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

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
        public static event ToStringHandler<Icon> OnToString_Icon;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_Icon")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_Icon != null)
            {
                OnObjectIsValid_Icon(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<Icon> OnObjectIsValid_Icon;

        [EventBasedMethod("OnNotifyPreSave_Icon")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_Icon != null) OnNotifyPreSave_Icon(this);
        }
        public static event ObjectEventHandler<Icon> OnNotifyPreSave_Icon;

        [EventBasedMethod("OnNotifyPostSave_Icon")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_Icon != null) OnNotifyPostSave_Icon(this);
        }
        public static event ObjectEventHandler<Icon> OnNotifyPostSave_Icon;

        [EventBasedMethod("OnNotifyCreated_Icon")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Blob");
            SetNotInitializedProperty("IconFile");
            SetNotInitializedProperty("Module");
            base.NotifyCreated();
            if (OnNotifyCreated_Icon != null) OnNotifyCreated_Icon(this);
        }
        public static event ObjectEventHandler<Icon> OnNotifyCreated_Icon;

        [EventBasedMethod("OnNotifyDeleting_Icon")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_Icon != null) OnNotifyDeleting_Icon(this);
        }
        public static event ObjectEventHandler<Icon> OnNotifyDeleting_Icon;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.IdProperty
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
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
                    if(IsAttached) UpdateChangedInfo = true;

                }
				else 
				{
					SetInitializedProperty("ID");
				}
            }
        }
        private int _ID;
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.IdProperty

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            {
                var key = this.RelationshipManager.GetRelatedReference<Zetbox.App.Base.BlobEfImpl>("Model.FK_Icon_has_Blob", "Blob").EntityKey;
                binStream.Write(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null);
            }
            binStream.Write(this._isExportGuidSet);
            if (this._isExportGuidSet) {
                binStream.Write(this._ExportGuid);
            }
            binStream.Write(this._IconFile);
            {
                var key = this.RelationshipManager.GetRelatedReference<Zetbox.App.Base.ModuleEfImpl>("Model.FK_Icon_has_Module", "Module").EntityKey;
                binStream.Write(key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null);
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            binStream.Read(out this._fk_Blob);
            this._isExportGuidSet = binStream.ReadBoolean();
            if (this._isExportGuidSet) {
                this._ExportGuid = binStream.ReadGuid();
            }
            this._IconFile = binStream.ReadString();
            binStream.Read(out this._fk_Module);
            } // if (CurrentAccessRights != Zetbox.API.AccessRights.None)
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            xml.WriteAttributeString("ExportGuid", this._ExportGuid.ToString());
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            if (modules.Contains("*") || modules.Contains("Zetbox.App.GUI")) XmlStreamer.ToStream(Blob != null ? Blob.ExportGuid : (Guid?)null, xml, "Blob", "Zetbox.App.GUI");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.GUI")) XmlStreamer.ToStream(this._IconFile, xml, "IconFile", "Zetbox.App.GUI");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.GUI")) XmlStreamer.ToStream(Module != null ? Module.ExportGuid : (Guid?)null, xml, "Module", "Zetbox.App.GUI");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.GUI|Blob":
                this._fk_guid_Blob = XmlStreamer.ReadNullableGuid(xml);
                break;
            case "Zetbox.App.Base|ExportGuid":
                // Import must have default value set
                this._ExportGuid = XmlStreamer.ReadGuid(xml);
                this._isExportGuidSet = true;
                break;
            case "Zetbox.App.GUI|IconFile":
                this._IconFile = XmlStreamer.ReadString(xml);
                break;
            case "Zetbox.App.GUI|Module":
                this._fk_guid_Module = XmlStreamer.ReadNullableGuid(xml);
                break;
            }
        }

        #endregion

    }
}