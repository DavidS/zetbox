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

    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.Memory;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("Icon")]
    public class IconMemoryImpl : Kistl.DalProvider.Memory.DataObjectMemoryImpl, Icon, Kistl.API.IExportableInternal
    {
        [Obsolete]
        public IconMemoryImpl()
            : base(null)
        {
        }

        public IconMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Blob
        // fkBackingName=_fk_Blob; fkGuidBackingName=_fk_guid_Blob;
        // referencedInterface=Kistl.App.Base.Blob; moduleNamespace=Kistl.App.GUI;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Kistl.Generator.Templates.Properties.DelegatingProperty
        public Kistl.App.Base.Blob Blob
        {
            get { return BlobImpl; }
            set { BlobImpl = (Kistl.App.Base.BlobMemoryImpl)value; }
        }
        // END Kistl.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_Blob;

        private Guid? _fk_guid_Blob = null;

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Kistl.App.Base.BlobMemoryImpl BlobImpl
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return null;
                Kistl.App.Base.BlobMemoryImpl __value;
                if (_fk_Blob.HasValue)
                    __value = (Kistl.App.Base.BlobMemoryImpl)Context.Find<Kistl.App.Base.Blob>(_fk_Blob.Value);
                else
                    __value = null;

                if (OnBlob_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.Blob>(__value);
                    OnBlob_Getter(this, e);
                    __value = (Kistl.App.Base.BlobMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noops
                if (value == null && _fk_Blob == null)
                    return;
                else if (value != null && value.ID == _fk_Blob)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = BlobImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Blob", __oldValue, __newValue);

                if (OnBlob_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Blob>(__oldValue, __newValue);
                    OnBlob_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.BlobMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_Blob = __newValue == null ? (int?)null : __newValue.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Blob", __oldValue, __newValue);

                if (OnBlob_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Blob>(__oldValue, __newValue);
                    OnBlob_PostSetter(this, e);
                }
            }
        }
        // END Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Blob
		public static event PropertyGetterHandler<Kistl.App.GUI.Icon, Kistl.App.Base.Blob> OnBlob_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.Icon, Kistl.App.Base.Blob> OnBlob_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.Icon, Kistl.App.Base.Blob> OnBlob_PostSetter;

        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public Guid ExportGuid
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return default(Guid);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ExportGuid;
                if (!_isExportGuidSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("6ce563d7-28e8-4806-bdd1-84c220a6c3ca"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._ExportGuid = (Guid)__tmp_value;
                    } else {
                        Kistl.API.Utils.Logging.Log.Warn("Unable to get default value for property 'Icon.ExportGuid'");
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
                    if (OnExportGuid_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ExportGuid", __oldValue, __newValue);
                    _ExportGuid = __newValue;
                    NotifyPropertyChanged("ExportGuid", __oldValue, __newValue);
                    if (OnExportGuid_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PostSetter(this, __e);
                    }
                }
            }
        }
        private Guid _ExportGuid;
        private bool _isExportGuidSet = false;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.GUI.Icon, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.Icon, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.Icon, Guid> OnExportGuid_PostSetter;

        /// <summary>
        /// Filename of the Icon
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public string IconFile
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return default(string);
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
                    if (OnIconFile_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnIconFile_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IconFile", __oldValue, __newValue);
                    _IconFile = __newValue;
                    NotifyPropertyChanged("IconFile", __oldValue, __newValue);
                    if (OnIconFile_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnIconFile_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _IconFile;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.GUI.Icon, string> OnIconFile_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.Icon, string> OnIconFile_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.Icon, string> OnIconFile_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Module
        // fkBackingName=_fk_Module; fkGuidBackingName=_fk_guid_Module;
        // referencedInterface=Kistl.App.Base.Module; moduleNamespace=Kistl.App.GUI;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Kistl.Generator.Templates.Properties.DelegatingProperty
        public Kistl.App.Base.Module Module
        {
            get { return ModuleImpl; }
            set { ModuleImpl = (Kistl.App.Base.ModuleMemoryImpl)value; }
        }
        // END Kistl.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_Module;

        private Guid? _fk_guid_Module = null;

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Kistl.App.Base.ModuleMemoryImpl ModuleImpl
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return null;
                Kistl.App.Base.ModuleMemoryImpl __value;
                if (_fk_Module.HasValue)
                    __value = (Kistl.App.Base.ModuleMemoryImpl)Context.Find<Kistl.App.Base.Module>(_fk_Module.Value);
                else
                    __value = null;

                if (OnModule_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.Module>(__value);
                    OnModule_Getter(this, e);
                    __value = (Kistl.App.Base.ModuleMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noops
                if (value == null && _fk_Module == null)
                    return;
                else if (value != null && value.ID == _fk_Module)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = ModuleImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Module", __oldValue, __newValue);

                if (OnModule_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Module>(__oldValue, __newValue);
                    OnModule_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.ModuleMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_Module = __newValue == null ? (int?)null : __newValue.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Module", __oldValue, __newValue);

                if (OnModule_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Module>(__oldValue, __newValue);
                    OnModule_PostSetter(this, e);
                }
            }
        }
        // END Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Module
		public static event PropertyGetterHandler<Kistl.App.GUI.Icon, Kistl.App.Base.Module> OnModule_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.Icon, Kistl.App.Base.Module> OnModule_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.Icon, Kistl.App.Base.Module> OnModule_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
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
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
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
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(Icon);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (Icon)obj;
            var otherImpl = (IconMemoryImpl)obj;
            var me = (Icon)this;

            me.ExportGuid = other.ExportGuid;
            me.IconFile = other.IconFile;
            this._fk_Blob = otherImpl._fk_Blob;
            this._fk_Module = otherImpl._fk_Module;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }

		public override void UpdateParent(string propertyName, int? id)
		{
			int? __oldValue, __newValue = id;
			
			switch(propertyName)
			{
                case "Blob":
                    __oldValue = _fk_Blob;
                    NotifyPropertyChanging("Blob", __oldValue, __newValue);
                    _fk_Blob = __newValue;
                    NotifyPropertyChanged("Blob", __oldValue, __newValue);
                    break;
                case "Module":
                    __oldValue = _fk_Module;
                    NotifyPropertyChanging("Module", __oldValue, __newValue);
                    _fk_Module = __newValue;
                    NotifyPropertyChanged("Module", __oldValue, __newValue);
                    break;
				default:
					base.UpdateParent(propertyName, id);
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

            if (_fk_guid_Blob.HasValue)
                BlobImpl = (Kistl.App.Base.BlobMemoryImpl)Context.FindPersistenceObject<Kistl.App.Base.Blob>(_fk_guid_Blob.Value);
            else
            if (_fk_Blob.HasValue)
                BlobImpl = (Kistl.App.Base.BlobMemoryImpl)Context.Find<Kistl.App.Base.Blob>(_fk_Blob.Value);
            else
                BlobImpl = null;

            if (_fk_guid_Module.HasValue)
                ModuleImpl = (Kistl.App.Base.ModuleMemoryImpl)Context.FindPersistenceObject<Kistl.App.Base.Module>(_fk_guid_Module.Value);
            else
            if (_fk_Module.HasValue)
                ModuleImpl = (Kistl.App.Base.ModuleMemoryImpl)Context.Find<Kistl.App.Base.Module>(_fk_Module.Value);
            else
                ModuleImpl = null;
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
                    new PropertyDescriptorMemoryImpl<IconMemoryImpl, Kistl.App.Base.Blob>(
                        lazyCtx,
                        new Guid("f4dfb868-260d-450b-84b8-833dac4d25ee"),
                        "Blob",
                        null,
                        obj => obj.Blob,
                        (obj, val) => obj.Blob = val),
                    // else
                    new PropertyDescriptorMemoryImpl<IconMemoryImpl, Guid>(
                        lazyCtx,
                        new Guid("6ce563d7-28e8-4806-bdd1-84c220a6c3ca"),
                        "ExportGuid",
                        null,
                        obj => obj.ExportGuid,
                        (obj, val) => obj.ExportGuid = val),
                    // else
                    new PropertyDescriptorMemoryImpl<IconMemoryImpl, string>(
                        lazyCtx,
                        new Guid("cdbdfc01-5faa-416b-960f-2eb220f268fe"),
                        "IconFile",
                        null,
                        obj => obj.IconFile,
                        (obj, val) => obj.IconFile = val),
                    // else
                    new PropertyDescriptorMemoryImpl<IconMemoryImpl, Kistl.App.Base.Module>(
                        lazyCtx,
                        new Guid("052273ac-706a-446b-bb86-83c726ee66d6"),
                        "Module",
                        null,
                        obj => obj.Module,
                        (obj, val) => obj.Module = val),
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
        #region Kistl.Generator.Templates.ObjectClasses.DefaultMethods

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

        [EventBasedMethod("OnPreSave_Icon")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Icon != null) OnPreSave_Icon(this);
        }
        public static event ObjectEventHandler<Icon> OnPreSave_Icon;

        [EventBasedMethod("OnPostSave_Icon")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Icon != null) OnPostSave_Icon(this);
        }
        public static event ObjectEventHandler<Icon> OnPostSave_Icon;

        [EventBasedMethod("OnCreated_Icon")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_Icon != null) OnCreated_Icon(this);
        }
        public static event ObjectEventHandler<Icon> OnCreated_Icon;

        [EventBasedMethod("OnDeleting_Icon")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Icon != null) OnDeleting_Icon(this);
        }
        public static event ObjectEventHandler<Icon> OnDeleting_Icon;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(Blob != null ? Blob.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.ToStream(this._ExportGuid, binStream);
            }
            BinarySerializer.ToStream(this._IconFile, binStream);
            BinarySerializer.ToStream(Module != null ? Module.ID : (int?)null, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            BinarySerializer.FromStream(out this._fk_Blob, binStream);
            BinarySerializer.FromStream(out this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.FromStream(out this._ExportGuid, binStream);
            }
            BinarySerializer.FromStream(out this._IconFile, binStream);
            BinarySerializer.FromStream(out this._fk_Module, binStream);
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            XmlStreamer.ToStream(Blob != null ? Blob.ID : (int?)null, xml, "Blob", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            }
            XmlStreamer.ToStream(this._IconFile, xml, "IconFile", "Kistl.App.GUI");
            XmlStreamer.ToStream(Module != null ? Module.ID : (int?)null, xml, "Module", "Kistl.App.GUI");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            XmlStreamer.FromStream(ref this._fk_Blob, xml, "Blob", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            }
            XmlStreamer.FromStream(ref this._IconFile, xml, "IconFile", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_Module, xml, "Module", "Kistl.App.GUI");
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            xml.WriteAttributeString("ExportGuid", this._ExportGuid.ToString());
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(Blob != null ? Blob.ExportGuid : (Guid?)null, xml, "Blob", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this._IconFile, xml, "IconFile", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(Module != null ? Module.ExportGuid : (Guid?)null, xml, "Module", "Kistl.App.GUI");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            XmlStreamer.FromStream(ref this._fk_guid_Blob, xml, "Blob", "Kistl.App.GUI");
            // Import must have default value set
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            this._isExportGuidSet = true;
            XmlStreamer.FromStream(ref this._IconFile, xml, "IconFile", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_guid_Module, xml, "Module", "Kistl.App.GUI");
        }

        #endregion

    }
}