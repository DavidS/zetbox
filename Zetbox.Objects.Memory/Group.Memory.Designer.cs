// <autogenerated/>

namespace Zetbox.App.Base
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
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("Group")]
    public class GroupMemoryImpl : Zetbox.DalProvider.Memory.DataObjectMemoryImpl, Group, Zetbox.API.IExportableInternal
    {
        private static readonly Guid _objectClassID = new Guid("01a06aef-8fe4-4cb6-b348-ee4bcd11f5af");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public GroupMemoryImpl()
            : base(null)
        {
        }

        public GroupMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

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
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("c776e87f-2b95-466e-848e-0ce195f4bd73"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._ExportGuid = (Guid)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'Group.ExportGuid'");
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
		public static event PropertyGetterHandler<Zetbox.App.Base.Group, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.Group, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.Group, Guid> OnExportGuid_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.Group> OnExportGuid_IsValid;

        /// <summary>
        /// Identities are member of this group
        /// </summary>
        // collection entry list property
        // BEGIN Zetbox.Generator.Templates.Properties.CollectionEntryListProperty for Member
        public ICollection<Zetbox.App.Base.Identity> Member
        {
            get
            {
                if (_Member == null)
                {
                    TriggerFetchMemberAsync().Wait();
                }
                return (ICollection<Zetbox.App.Base.Identity>)_Member;
            }
        }

        Zetbox.API.Async.ZbTask _triggerFetchMemberTask;
        public Zetbox.API.Async.ZbTask TriggerFetchMemberAsync()
        {
            if (_triggerFetchMemberTask != null) return _triggerFetchMemberTask;
            _triggerFetchMemberTask = Context.FetchRelationAsync<Zetbox.App.Base.Identity_memberOf_Group_RelationEntryMemoryImpl>(new Guid("3efb7ae8-ba6b-40e3-9482-b45d1c101743"), RelationEndRole.B, this);
            _triggerFetchMemberTask.OnResult(r =>
            {
                _Member
                    = new ObservableASideCollectionWrapper<Zetbox.App.Base.Identity, Zetbox.App.Base.Group, Zetbox.App.Base.Identity_memberOf_Group_RelationEntryMemoryImpl, ICollection<Zetbox.App.Base.Identity_memberOf_Group_RelationEntryMemoryImpl>>(
                        this,
                        new RelationshipFilterBSideCollection<Zetbox.App.Base.Identity_memberOf_Group_RelationEntryMemoryImpl>(this.Context, this));
                        // _Member.CollectionChanged is managed by OnMemberCollectionChanged() and called from the RelationEntry
            });
            return _triggerFetchMemberTask;
        }

        internal void OnMemberCollectionChanged()
        {
            NotifyPropertyChanged("Member", null, null);
            if (OnMember_PostSetter != null && IsAttached)
                OnMember_PostSetter(this);
        }

        private ObservableASideCollectionWrapper<Zetbox.App.Base.Identity, Zetbox.App.Base.Group, Zetbox.App.Base.Identity_memberOf_Group_RelationEntryMemoryImpl, ICollection<Zetbox.App.Base.Identity_memberOf_Group_RelationEntryMemoryImpl>> _Member;
        // END Zetbox.Generator.Templates.Properties.CollectionEntryListProperty for Member
public static event PropertyListChangedHandler<Zetbox.App.Base.Group> OnMember_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.Group> OnMember_IsValid;

        /// <summary>
        /// Module is optional. Use it only when you need a Group to be exportable
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Module
        // fkBackingName=_fk_Module; fkGuidBackingName=_fk_guid_Module;
        // referencedInterface=Zetbox.App.Base.Module; moduleNamespace=Zetbox.App.Base;
        // no inverse navigator handling
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

        private int? __fk_ModuleCache;

        private int? _fk_Module {
            get
            {
                return __fk_ModuleCache;
            }
            set
            {
                __fk_ModuleCache = value;
                // Recreate task to clear it's cache
                _triggerFetchModuleTask = null;
            }
        }

        private Guid? _fk_guid_Module = null;

        Zetbox.API.Async.ZbTask<Zetbox.App.Base.Module> _triggerFetchModuleTask;
        public Zetbox.API.Async.ZbTask<Zetbox.App.Base.Module> TriggerFetchModuleAsync()
        {
            if (_triggerFetchModuleTask != null) return _triggerFetchModuleTask;

            if (_fk_Module.HasValue)
                _triggerFetchModuleTask = Context.FindAsync<Zetbox.App.Base.Module>(_fk_Module.Value);
            else
                _triggerFetchModuleTask = new Zetbox.API.Async.ZbTask<Zetbox.App.Base.Module>(Zetbox.API.Async.ZbTask.Synchron, () => null);

            _triggerFetchModuleTask.OnResult(t =>
            {
                if (OnModule_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.Module>(t.Result);
                    OnModule_Getter(this, e);
                    t.Result = e.Result;
                }
            });

            return _triggerFetchModuleTask;
        }

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Zetbox.App.Base.ModuleMemoryImpl ModuleImpl
        {
            get
            {
                return (Zetbox.App.Base.ModuleMemoryImpl)TriggerFetchModuleAsync().Result;
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
		public static event PropertyGetterHandler<Zetbox.App.Base.Group, Zetbox.App.Base.Module> OnModule_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.Group, Zetbox.App.Base.Module> OnModule_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.Group, Zetbox.App.Base.Module> OnModule_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.Group> OnModule_IsValid;

        /// <summary>
        /// 
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
		public static event PropertyGetterHandler<Zetbox.App.Base.Group, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.Group, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.Group, string> OnName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.Group> OnName_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetName_Group")]
        public virtual string GetName()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetName_Group != null)
            {
                OnGetName_Group(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on Group.GetName");
            }
            return e.Result;
        }
        public delegate void GetName_Handler<T>(T obj, MethodReturnEventArgs<string> ret);
        public static event GetName_Handler<Group> OnGetName_Group;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<Group> OnGetName_Group_CanExec;

        [EventBasedMethod("OnGetName_Group_CanExec")]
        public virtual bool GetNameCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetName_Group_CanExec != null)
				{
					OnGetName_Group_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<Group> OnGetName_Group_CanExecReason;

        [EventBasedMethod("OnGetName_Group_CanExecReason")]
        public virtual string GetNameCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetName_Group_CanExecReason != null)
				{
					OnGetName_Group_CanExecReason(this, e);
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
            return typeof(Group);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (Group)obj;
            var otherImpl = (GroupMemoryImpl)obj;
            var me = (Group)this;

            me.ExportGuid = other.ExportGuid;
            me.Name = other.Name;
            this._fk_Module = otherImpl._fk_Module;
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
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }

        protected override bool ShouldSetModified(string property)
        {
            switch (property)
            {
                case "Member":
                    return false;
                default:
                    return base.ShouldSetModified(property);
            }
        }
        #endregion // Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        public override Zetbox.API.Async.ZbTask TriggerFetch(string propName)
        {
            switch(propName)
            {
            case "Member":
                return TriggerFetchMemberAsync();
            case "Module":
                return TriggerFetchModuleAsync();
            default:
                return base.TriggerFetch(propName);
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
                ModuleImpl = (Zetbox.App.Base.ModuleMemoryImpl)Context.FindPersistenceObject<Zetbox.App.Base.Module>(_fk_guid_Module.Value);
            else
            if (_fk_Module.HasValue)
                ModuleImpl = (Zetbox.App.Base.ModuleMemoryImpl)Context.Find<Zetbox.App.Base.Module>(_fk_Module.Value);
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
                    new PropertyDescriptorMemoryImpl<Group, Guid>(
                        lazyCtx,
                        new Guid("c776e87f-2b95-466e-848e-0ce195f4bd73"),
                        "ExportGuid",
                        null,
                        obj => obj.ExportGuid,
                        (obj, val) => obj.ExportGuid = val,
						obj => OnExportGuid_IsValid), 
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorMemoryImpl<Group, ICollection<Zetbox.App.Base.Identity>>(
                        lazyCtx,
                        new Guid("f60308a5-a502-4641-aa19-f895e701778c"),
                        "Member",
                        null,
                        obj => obj.Member,
                        null, // lists are read-only properties
                        obj => OnMember_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<Group, Zetbox.App.Base.Module>(
                        lazyCtx,
                        new Guid("8da2dab4-81c9-4659-9f25-c6b5177ba26d"),
                        "Module",
                        null,
                        obj => obj.Module,
                        (obj, val) => obj.Module = val,
						obj => OnModule_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<Group, string>(
                        lazyCtx,
                        new Guid("99c320b1-0003-4e2d-aa98-9a215d80988b"),
                        "Name",
                        null,
                        obj => obj.Name,
                        (obj, val) => obj.Name = val,
						obj => OnName_IsValid), 
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
        [EventBasedMethod("OnToString_Group")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Group != null)
            {
                OnToString_Group(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<Group> OnToString_Group;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_Group")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_Group != null)
            {
                OnObjectIsValid_Group(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<Group> OnObjectIsValid_Group;

        [EventBasedMethod("OnNotifyPreSave_Group")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_Group != null) OnNotifyPreSave_Group(this);
        }
        public static event ObjectEventHandler<Group> OnNotifyPreSave_Group;

        [EventBasedMethod("OnNotifyPostSave_Group")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_Group != null) OnNotifyPostSave_Group(this);
        }
        public static event ObjectEventHandler<Group> OnNotifyPostSave_Group;

        [EventBasedMethod("OnNotifyCreated_Group")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Module");
            SetNotInitializedProperty("Name");
            base.NotifyCreated();
            if (OnNotifyCreated_Group != null) OnNotifyCreated_Group(this);
        }
        public static event ObjectEventHandler<Group> OnNotifyCreated_Group;

        [EventBasedMethod("OnNotifyDeleting_Group")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_Group != null) OnNotifyDeleting_Group(this);
            Member.Clear();
            Module = null;
        }
        public static event ObjectEventHandler<Group> OnNotifyDeleting_Group;

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
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(Module != null ? Module.ExportGuid : (Guid?)null, xml, "Module", "Zetbox.App.Base");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this._Name, xml, "Name", "Zetbox.App.Base");
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
            case "Zetbox.App.Base|Module":
                this._fk_guid_Module = XmlStreamer.ReadNullableGuid(xml);
                break;
            case "Zetbox.App.Base|Name":
                this._Name = XmlStreamer.ReadString(xml);
                break;
            }
        }

        #endregion

    }
}