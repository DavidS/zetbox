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
    /// The ControlKind specifies the toolkit-independent kind or type of control that should display a given Presentable.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("ControlKind")]
    public class ControlKindMemoryImpl : Kistl.DalProvider.Memory.DataObjectMemoryImpl, ControlKind, Kistl.API.IExportableInternal
    {
        [Obsolete]
        public ControlKindMemoryImpl()
            : base(null)
        {
        }

        public ControlKindMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // object list property
        // Kistl.Generator.Templates.Properties.ObjectListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.GUI.ControlKind> ChildControlKinds
        {
            get
            {
                if (_ChildControlKinds == null)
                {
                    List<Kistl.App.GUI.ControlKind> serverList;
                    if (Helper.IsPersistedObject(this))
                    {
                        serverList = Context.GetListOf<Kistl.App.GUI.ControlKind>(this, "ChildControlKinds");
                    }
                    else
                    {
                        serverList = new List<Kistl.App.GUI.ControlKind>();
                    }
    
                    _ChildControlKinds = new OneNRelationList<Kistl.App.GUI.ControlKind>(
                        "Parent",
                        null,
                        this,
                        () => { this.NotifyPropertyChanged("ChildControlKinds", null, null); if(OnChildControlKinds_PostSetter != null && IsAttached) OnChildControlKinds_PostSetter(this); },
                        serverList);
                }
                return _ChildControlKinds;
            }
        }
    
        private OneNRelationList<Kistl.App.GUI.ControlKind> _ChildControlKinds;

public static event PropertyListChangedHandler<Kistl.App.GUI.ControlKind> OnChildControlKinds_PostSetter;

        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public Guid ExportGuid
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(Guid);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ExportGuid;
                if (!_isExportGuidSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("758d8eba-b458-4cd4-98a8-e08713912654"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._ExportGuid = (Guid)__tmp_value;
                    } else {
                        Kistl.API.Utils.Logging.Log.Warn("Unable to get default value for property 'ControlKind.ExportGuid'");
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
		public static event PropertyGetterHandler<Kistl.App.GUI.ControlKind, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.ControlKind, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.ControlKind, Guid> OnExportGuid_PostSetter;

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
                if (!CurrentAccessRights.HasReadRights()) return null;
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
		public static event PropertyGetterHandler<Kistl.App.GUI.ControlKind, Kistl.App.Base.Module> OnModule_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.ControlKind, Kistl.App.Base.Module> OnModule_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.ControlKind, Kistl.App.Base.Module> OnModule_PostSetter;

        /// <summary>
        /// Name of this ControlKind
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public string Name
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
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
                    if (OnName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Name", __oldValue, __newValue);
                    _Name = __newValue;
                    NotifyPropertyChanged("Name", __oldValue, __newValue);
                    if (OnName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Name;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.GUI.ControlKind, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.ControlKind, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.ControlKind, string> OnName_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Parent
        // fkBackingName=_fk_Parent; fkGuidBackingName=_fk_guid_Parent;
        // referencedInterface=Kistl.App.GUI.ControlKind; moduleNamespace=Kistl.App.GUI;
        // inverse Navigator=ChildControlKinds; is list;
        // PositionStorage=none;
        // Target exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Kistl.Generator.Templates.Properties.DelegatingProperty
        public Kistl.App.GUI.ControlKind Parent
        {
            get { return ParentImpl; }
            set { ParentImpl = (Kistl.App.GUI.ControlKindMemoryImpl)value; }
        }
        // END Kistl.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_Parent;

        private Guid? _fk_guid_Parent = null;

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Kistl.App.GUI.ControlKindMemoryImpl ParentImpl
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.GUI.ControlKindMemoryImpl __value;
                if (_fk_Parent.HasValue)
                    __value = (Kistl.App.GUI.ControlKindMemoryImpl)Context.Find<Kistl.App.GUI.ControlKind>(_fk_Parent.Value);
                else
                    __value = null;

                if (OnParent_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.GUI.ControlKind>(__value);
                    OnParent_Getter(this, e);
                    __value = (Kistl.App.GUI.ControlKindMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noops
                if (value == null && _fk_Parent == null)
                    return;
                else if (value != null && value.ID == _fk_Parent)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = ParentImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Parent", __oldValue, __newValue);

                if (OnParent_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.GUI.ControlKind>(__oldValue, __newValue);
                    OnParent_PreSetter(this, e);
                    __newValue = (Kistl.App.GUI.ControlKindMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_Parent = __newValue == null ? (int?)null : __newValue.ID;

                // now fixup redundant, inverse references
                // The inverse navigator will also fire events when changed, so should
                // only be touched after setting the local value above.
                // TODO: for complete correctness, the "other" Changing event should also fire
                //       before the local value is changed
                if (__oldValue != null)
                {
                    // remove from old list
                    (__oldValue.ChildControlKinds as IRelationListSync<Kistl.App.GUI.ControlKind>).RemoveWithoutClearParent(this);
                }

                if (__newValue != null)
                {
                    // add to new list
                    (__newValue.ChildControlKinds as IRelationListSync<Kistl.App.GUI.ControlKind>).AddWithoutSetParent(this);
                }
                // everything is done. fire the Changed event
                NotifyPropertyChanged("Parent", __oldValue, __newValue);

                if (OnParent_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.GUI.ControlKind>(__oldValue, __newValue);
                    OnParent_PostSetter(this, e);
                }
            }
        }
        // END Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Parent
		public static event PropertyGetterHandler<Kistl.App.GUI.ControlKind, Kistl.App.GUI.ControlKind> OnParent_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.ControlKind, Kistl.App.GUI.ControlKind> OnParent_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.ControlKind, Kistl.App.GUI.ControlKind> OnParent_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetName_ControlKind")]
        public virtual string GetName()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetName_ControlKind != null)
            {
                OnGetName_ControlKind(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on ControlKind.GetName");
            }
            return e.Result;
        }
        public delegate void GetName_Handler<T>(T obj, MethodReturnEventArgs<string> ret);
        public static event GetName_Handler<ControlKind> OnGetName_ControlKind;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(ControlKind);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (ControlKind)obj;
            var otherImpl = (ControlKindMemoryImpl)obj;
            var me = (ControlKind)this;

            me.ExportGuid = other.ExportGuid;
            me.Name = other.Name;
            this._fk_Module = otherImpl._fk_Module;
            this._fk_Parent = otherImpl._fk_Parent;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "Module":
                    {
                        var __oldValue = _fk_Module;
                        var __newValue = parentObj == null ? (int?)null : parentObj.ID;
                        NotifyPropertyChanging("Module", __oldValue, __newValue);
                        _fk_Module = __newValue;
                        NotifyPropertyChanged("Module", __oldValue, __newValue);
                    }
                    break;
                case "Parent":
                    {
                        var __oldValue = _fk_Parent;
                        var __newValue = parentObj == null ? (int?)null : parentObj.ID;
                        NotifyPropertyChanging("Parent", __oldValue, __newValue);
                        _fk_Parent = __newValue;
                        NotifyPropertyChanged("Parent", __oldValue, __newValue);
                    }
                    break;
                default:
                    base.UpdateParent(propertyName, parentObj);
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

            if (_fk_guid_Module.HasValue)
                ModuleImpl = (Kistl.App.Base.ModuleMemoryImpl)Context.FindPersistenceObject<Kistl.App.Base.Module>(_fk_guid_Module.Value);
            else
            if (_fk_Module.HasValue)
                ModuleImpl = (Kistl.App.Base.ModuleMemoryImpl)Context.Find<Kistl.App.Base.Module>(_fk_Module.Value);
            else
                ModuleImpl = null;

            if (_fk_guid_Parent.HasValue)
                ParentImpl = (Kistl.App.GUI.ControlKindMemoryImpl)Context.FindPersistenceObject<Kistl.App.GUI.ControlKind>(_fk_guid_Parent.Value);
            else
            if (_fk_Parent.HasValue)
                ParentImpl = (Kistl.App.GUI.ControlKindMemoryImpl)Context.Find<Kistl.App.GUI.ControlKind>(_fk_Parent.Value);
            else
                ParentImpl = null;
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
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorMemoryImpl<ControlKindMemoryImpl, ICollection<Kistl.App.GUI.ControlKind>>(
                        lazyCtx,
                        new Guid("bf073bb5-eaa8-4e3d-b019-60b47ba6a088"),
                        "ChildControlKinds",
                        null,
                        obj => obj.ChildControlKinds,
                        null), // lists are read-only properties
                    // else
                    new PropertyDescriptorMemoryImpl<ControlKindMemoryImpl, Guid>(
                        lazyCtx,
                        new Guid("758d8eba-b458-4cd4-98a8-e08713912654"),
                        "ExportGuid",
                        null,
                        obj => obj.ExportGuid,
                        (obj, val) => obj.ExportGuid = val),
                    // else
                    new PropertyDescriptorMemoryImpl<ControlKindMemoryImpl, Kistl.App.Base.Module>(
                        lazyCtx,
                        new Guid("e4cf2c2d-be50-4954-a43c-b8df2dedecec"),
                        "Module",
                        null,
                        obj => obj.Module,
                        (obj, val) => obj.Module = val),
                    // else
                    new PropertyDescriptorMemoryImpl<ControlKindMemoryImpl, string>(
                        lazyCtx,
                        new Guid("438ab847-c5d1-4072-9449-96e3d4e92b1f"),
                        "Name",
                        null,
                        obj => obj.Name,
                        (obj, val) => obj.Name = val),
                    // else
                    new PropertyDescriptorMemoryImpl<ControlKindMemoryImpl, Kistl.App.GUI.ControlKind>(
                        lazyCtx,
                        new Guid("5d75bf4f-29dd-4d00-8e4f-b40a1b9ad92c"),
                        "Parent",
                        null,
                        obj => obj.Parent,
                        (obj, val) => obj.Parent = val),
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
        [EventBasedMethod("OnToString_ControlKind")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ControlKind != null)
            {
                OnToString_ControlKind(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<ControlKind> OnToString_ControlKind;

        [EventBasedMethod("OnPreSave_ControlKind")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ControlKind != null) OnPreSave_ControlKind(this);
        }
        public static event ObjectEventHandler<ControlKind> OnPreSave_ControlKind;

        [EventBasedMethod("OnPostSave_ControlKind")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ControlKind != null) OnPostSave_ControlKind(this);
        }
        public static event ObjectEventHandler<ControlKind> OnPostSave_ControlKind;

        [EventBasedMethod("OnCreated_ControlKind")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_ControlKind != null) OnCreated_ControlKind(this);
        }
        public static event ObjectEventHandler<ControlKind> OnCreated_ControlKind;

        [EventBasedMethod("OnDeleting_ControlKind")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_ControlKind != null) OnDeleting_ControlKind(this);
        }
        public static event ObjectEventHandler<ControlKind> OnDeleting_ControlKind;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.ToStream(this._ExportGuid, binStream);
            }
            BinarySerializer.ToStream(Module != null ? Module.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._Name, binStream);
            BinarySerializer.ToStream(Parent != null ? Parent.ID : (int?)null, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.FromStream(out this._ExportGuid, binStream);
            }
            BinarySerializer.FromStream(out this._fk_Module, binStream);
            BinarySerializer.FromStream(out this._Name, binStream);
            BinarySerializer.FromStream(out this._fk_Parent, binStream);
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.ToStream(this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            }
            XmlStreamer.ToStream(Module != null ? Module.ID : (int?)null, xml, "Module", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._Name, xml, "Name", "Kistl.App.GUI");
            XmlStreamer.ToStream(Parent != null ? Parent.ID : (int?)null, xml, "Parent", "Kistl.App.GUI");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            }
            XmlStreamer.FromStream(ref this._fk_Module, xml, "Module", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_Parent, xml, "Parent", "Kistl.App.GUI");
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            xml.WriteAttributeString("ExportGuid", this._ExportGuid.ToString());
            if (!CurrentAccessRights.HasReadRights()) return;
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(Module != null ? Module.ExportGuid : (Guid?)null, xml, "Module", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this._Name, xml, "Name", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(Parent != null ? Parent.ExportGuid : (Guid?)null, xml, "Parent", "Kistl.App.GUI");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            if (!CurrentAccessRights.HasReadRights()) return;
            // Import must have default value set
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            this._isExportGuidSet = true;
            XmlStreamer.FromStream(ref this._fk_guid_Module, xml, "Module", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._fk_guid_Parent, xml, "Parent", "Kistl.App.GUI");
        }

        #endregion

    }
}