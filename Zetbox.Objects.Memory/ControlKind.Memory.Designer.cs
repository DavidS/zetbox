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

    using Zetbox.DalProvider.Base;
    using Zetbox.DalProvider.Memory;

    /// <summary>
    /// The ControlKind specifies the toolkit-independent kind or type of control that should display a given Presentable.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("ControlKind")]
    public class ControlKindMemoryImpl : Zetbox.DalProvider.Memory.DataObjectMemoryImpl, ControlKind, Zetbox.API.IExportableInternal
    {
        private static readonly Guid _objectClassID = new Guid("a9166f1e-9233-4d2d-8eb6-be71d724ea14");
        public override Guid ObjectClassID { get { return _objectClassID; } }

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
        // Zetbox.Generator.Templates.Properties.ObjectListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Zetbox.App.GUI.ControlKind> ChildControlKinds
        {
            get
            {
                if (_ChildControlKinds == null)
                {
                    List<Zetbox.App.GUI.ControlKind> serverList;
                    if (Helper.IsPersistedObject(this))
                    {
                        serverList = Context.GetListOf<Zetbox.App.GUI.ControlKind>(this, "ChildControlKinds");
                    }
                    else
                    {
                        serverList = new List<Zetbox.App.GUI.ControlKind>();
                    }
    
                    _ChildControlKinds = new OneNRelationList<Zetbox.App.GUI.ControlKind>(
                        "Parent",
                        null,
                        this,
                        () => { this.NotifyPropertyChanged("ChildControlKinds", null, null); if(OnChildControlKinds_PostSetter != null && IsAttached) OnChildControlKinds_PostSetter(this); },
                        serverList);
                }
                return _ChildControlKinds;
            }
        }
    
        private OneNRelationList<Zetbox.App.GUI.ControlKind> _ChildControlKinds;

public static event PropertyListChangedHandler<Zetbox.App.GUI.ControlKind> OnChildControlKinds_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.ControlKind> OnChildControlKinds_IsValid;

        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public Guid ExportGuid
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ExportGuid;
                if (!_isExportGuidSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("758d8eba-b458-4cd4-98a8-e08713912654"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._ExportGuid = (Guid)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'ControlKind.ExportGuid'");
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
        private Guid _ExportGuid;
        private bool _isExportGuidSet = false;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.GUI.ControlKind, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.ControlKind, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.ControlKind, Guid> OnExportGuid_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.ControlKind> OnExportGuid_IsValid;

        /// <summary>
        /// 
        /// </summary>
	        // BEGIN Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Module
        // fkBackingName=_fk_Module; fkGuidBackingName=_fk_guid_Module;
        // referencedInterface=Zetbox.App.Base.Module; moduleNamespace=Zetbox.App.GUI;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Zetbox.Generator.Templates.Properties.DelegatingProperty
        public Zetbox.App.Base.Module Module
        {
            get { return ModuleImpl; }
            set { ModuleImpl = (Zetbox.App.Base.ModuleMemoryImpl)value; }
        }
        // END Zetbox.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_Module;

        private Guid? _fk_guid_Module = null;

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Zetbox.App.Base.ModuleMemoryImpl ModuleImpl
        {
            get
            {
                Zetbox.App.Base.ModuleMemoryImpl __value;
                if (_fk_Module.HasValue)
                    __value = (Zetbox.App.Base.ModuleMemoryImpl)Context.Find<Zetbox.App.Base.Module>(_fk_Module.Value);
                else
                    __value = null;

                if (OnModule_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.Module>(__value);
                    OnModule_Getter(this, e);
                    __value = (Zetbox.App.Base.ModuleMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noops
                if ((value == null && _fk_Module == null) || (value != null && value.ID == _fk_Module))
				{
					SetInitializedProperty("Module");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = ModuleImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Module", __oldValue, __newValue);

                if (OnModule_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.Module>(__oldValue, __newValue);
                    OnModule_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.ModuleMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_Module = __newValue == null ? (int?)null : __newValue.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Module", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;

                if (OnModule_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.Module>(__oldValue, __newValue);
                    OnModule_PostSetter(this, e);
                }
            }
        }
        // END Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Module
		public static event PropertyGetterHandler<Zetbox.App.GUI.ControlKind, Zetbox.App.Base.Module> OnModule_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.ControlKind, Zetbox.App.Base.Module> OnModule_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.ControlKind, Zetbox.App.Base.Module> OnModule_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.ControlKind> OnModule_IsValid;

        /// <summary>
        /// Name of this ControlKind
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public string Name
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
                    __result = _Name = __e.Result;
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
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Name");
				}
            }
        }
        private string _Name;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.GUI.ControlKind, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.ControlKind, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.ControlKind, string> OnName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.ControlKind> OnName_IsValid;

        /// <summary>
        /// 
        /// </summary>
	        // BEGIN Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Parent
        // fkBackingName=_fk_Parent; fkGuidBackingName=_fk_guid_Parent;
        // referencedInterface=Zetbox.App.GUI.ControlKind; moduleNamespace=Zetbox.App.GUI;
        // inverse Navigator=ChildControlKinds; is list;
        // PositionStorage=none;
        // Target exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Zetbox.Generator.Templates.Properties.DelegatingProperty
        public Zetbox.App.GUI.ControlKind Parent
        {
            get { return ParentImpl; }
            set { ParentImpl = (Zetbox.App.GUI.ControlKindMemoryImpl)value; }
        }
        // END Zetbox.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_Parent;

        private Guid? _fk_guid_Parent = null;

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Zetbox.App.GUI.ControlKindMemoryImpl ParentImpl
        {
            get
            {
                Zetbox.App.GUI.ControlKindMemoryImpl __value;
                if (_fk_Parent.HasValue)
                    __value = (Zetbox.App.GUI.ControlKindMemoryImpl)Context.Find<Zetbox.App.GUI.ControlKind>(_fk_Parent.Value);
                else
                    __value = null;

                if (OnParent_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.GUI.ControlKind>(__value);
                    OnParent_Getter(this, e);
                    __value = (Zetbox.App.GUI.ControlKindMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noops
                if ((value == null && _fk_Parent == null) || (value != null && value.ID == _fk_Parent))
				{
					SetInitializedProperty("Parent");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = ParentImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Parent", __oldValue, __newValue);

                if (OnParent_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.GUI.ControlKind>(__oldValue, __newValue);
                    OnParent_PreSetter(this, e);
                    __newValue = (Zetbox.App.GUI.ControlKindMemoryImpl)e.Result;
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
                    (__oldValue.ChildControlKinds as IRelationListSync<Zetbox.App.GUI.ControlKind>).RemoveWithoutClearParent(this);
                }

                if (__newValue != null)
                {
                    // add to new list
                    (__newValue.ChildControlKinds as IRelationListSync<Zetbox.App.GUI.ControlKind>).AddWithoutSetParent(this);
                }
                // everything is done. fire the Changed event
                NotifyPropertyChanged("Parent", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;

                if (OnParent_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.GUI.ControlKind>(__oldValue, __newValue);
                    OnParent_PostSetter(this, e);
                }
            }
        }
        // END Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Parent
		public static event PropertyGetterHandler<Zetbox.App.GUI.ControlKind, Zetbox.App.GUI.ControlKind> OnParent_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.ControlKind, Zetbox.App.GUI.ControlKind> OnParent_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.ControlKind, Zetbox.App.GUI.ControlKind> OnParent_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.ControlKind> OnParent_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
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
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ControlKind> OnGetName_ControlKind_CanExec;

        [EventBasedMethod("OnGetName_ControlKind_CanExec")]
        public virtual bool GetNameCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetName_ControlKind_CanExec != null)
				{
					OnGetName_ControlKind_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ControlKind> OnGetName_ControlKind_CanExecReason;

        [EventBasedMethod("OnGetName_ControlKind_CanExecReason")]
        public virtual string GetNameCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetName_ControlKind_CanExecReason != null)
				{
					OnGetName_ControlKind_CanExecReason(this, e);
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
        public override void SetNew()
        {
            base.SetNew();
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
        #region Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "ExportGuid":
                case "Module":
                case "Name":
                case "Parent":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }

        protected override bool ShouldSetModified(string property)
        {
            switch (property)
            {
                case "ChildControlKinds":
                    return false;
                default:
                    return base.ShouldSetModified(property);
            }
        }
        #endregion // Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_guid_Module.HasValue)
                ModuleImpl = (Zetbox.App.Base.ModuleMemoryImpl)Context.FindPersistenceObject<Zetbox.App.Base.Module>(_fk_guid_Module.Value);
            else
            if (_fk_Module.HasValue)
                ModuleImpl = (Zetbox.App.Base.ModuleMemoryImpl)Context.Find<Zetbox.App.Base.Module>(_fk_Module.Value);
            else
                ModuleImpl = null;

            if (_fk_guid_Parent.HasValue)
                ParentImpl = (Zetbox.App.GUI.ControlKindMemoryImpl)Context.FindPersistenceObject<Zetbox.App.GUI.ControlKind>(_fk_guid_Parent.Value);
            else
            if (_fk_Parent.HasValue)
                ParentImpl = (Zetbox.App.GUI.ControlKindMemoryImpl)Context.Find<Zetbox.App.GUI.ControlKind>(_fk_Parent.Value);
            else
                ParentImpl = null;
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
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorMemoryImpl<ControlKind, ICollection<Zetbox.App.GUI.ControlKind>>(
                        lazyCtx,
                        new Guid("bf073bb5-eaa8-4e3d-b019-60b47ba6a088"),
                        "ChildControlKinds",
                        null,
                        obj => obj.ChildControlKinds,
                        null, // lists are read-only properties
                        obj => OnChildControlKinds_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<ControlKind, Guid>(
                        lazyCtx,
                        new Guid("758d8eba-b458-4cd4-98a8-e08713912654"),
                        "ExportGuid",
                        null,
                        obj => obj.ExportGuid,
                        (obj, val) => obj.ExportGuid = val,
						obj => OnExportGuid_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<ControlKind, Zetbox.App.Base.Module>(
                        lazyCtx,
                        new Guid("e4cf2c2d-be50-4954-a43c-b8df2dedecec"),
                        "Module",
                        null,
                        obj => obj.Module,
                        (obj, val) => obj.Module = val,
						obj => OnModule_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<ControlKind, string>(
                        lazyCtx,
                        new Guid("438ab847-c5d1-4072-9449-96e3d4e92b1f"),
                        "Name",
                        null,
                        obj => obj.Name,
                        (obj, val) => obj.Name = val,
						obj => OnName_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<ControlKind, Zetbox.App.GUI.ControlKind>(
                        lazyCtx,
                        new Guid("5d75bf4f-29dd-4d00-8e4f-b40a1b9ad92c"),
                        "Parent",
                        null,
                        obj => obj.Parent,
                        (obj, val) => obj.Parent = val,
						obj => OnParent_IsValid), 
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

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_ControlKind")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_ControlKind != null)
            {
                OnObjectIsValid_ControlKind(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<ControlKind> OnObjectIsValid_ControlKind;

        [EventBasedMethod("OnNotifyPreSave_ControlKind")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_ControlKind != null) OnNotifyPreSave_ControlKind(this);
        }
        public static event ObjectEventHandler<ControlKind> OnNotifyPreSave_ControlKind;

        [EventBasedMethod("OnNotifyPostSave_ControlKind")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_ControlKind != null) OnNotifyPostSave_ControlKind(this);
        }
        public static event ObjectEventHandler<ControlKind> OnNotifyPostSave_ControlKind;

        [EventBasedMethod("OnNotifyCreated_ControlKind")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Module");
            SetNotInitializedProperty("Name");
            SetNotInitializedProperty("Parent");
            base.NotifyCreated();
            if (OnNotifyCreated_ControlKind != null) OnNotifyCreated_ControlKind(this);
        }
        public static event ObjectEventHandler<ControlKind> OnNotifyCreated_ControlKind;

        [EventBasedMethod("OnNotifyDeleting_ControlKind")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_ControlKind != null) OnNotifyDeleting_ControlKind(this);
            ChildControlKinds.Clear();
            Parent = null;
        }
        public static event ObjectEventHandler<ControlKind> OnNotifyDeleting_ControlKind;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._isExportGuidSet);
            if (this._isExportGuidSet) {
                binStream.Write(this._ExportGuid);
            }
            binStream.Write(Module != null ? Module.ID : (int?)null);
            binStream.Write(this._Name);
            binStream.Write(Parent != null ? Parent.ID : (int?)null);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._isExportGuidSet = binStream.ReadBoolean();
            if (this._isExportGuidSet) {
                this._ExportGuid = binStream.ReadGuid();
            }
            this._fk_Module = binStream.ReadNullableInt32();
            this._Name = binStream.ReadString();
            this._fk_Parent = binStream.ReadNullableInt32();
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
            if (modules.Contains("*") || modules.Contains("Zetbox.App.GUI")) XmlStreamer.ToStream(Module != null ? Module.ExportGuid : (Guid?)null, xml, "Module", "Zetbox.App.GUI");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.GUI")) XmlStreamer.ToStream(this._Name, xml, "Name", "Zetbox.App.GUI");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.GUI")) XmlStreamer.ToStream(Parent != null ? Parent.ExportGuid : (Guid?)null, xml, "Parent", "Zetbox.App.GUI");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Base|ExportGuid":
                // Import must have default value set
                this._ExportGuid = XmlStreamer.ReadGuid(xml);
                this._isExportGuidSet = true;
                break;
            case "Zetbox.App.GUI|Module":
                this._fk_guid_Module = XmlStreamer.ReadNullableGuid(xml);
                break;
            case "Zetbox.App.GUI|Name":
                this._Name = XmlStreamer.ReadString(xml);
                break;
            case "Zetbox.App.GUI|Parent":
                this._fk_guid_Parent = XmlStreamer.ReadNullableGuid(xml);
                break;
            }
        }

        #endregion

    }
}