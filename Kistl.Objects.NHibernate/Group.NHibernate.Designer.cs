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
    using Kistl.DalProvider.Base.RelationWrappers;

    using Kistl.API.Utils;
    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.NHibernate;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("Group")]
    public class GroupNHibernateImpl : Kistl.DalProvider.NHibernate.DataObjectNHibernateImpl, Group, Kistl.API.IExportableInternal
    {
        public GroupNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public GroupNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new GroupProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public GroupNHibernateImpl(Func<IFrozenContext> lazyCtx, GroupProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
            _isExportGuidSet = Proxy.ID > 0;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly GroupProxy Proxy;

        /// <summary>
        /// Export Guid
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public Guid ExportGuid
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(Guid);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = FetchExportGuidOrDefault();
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
                if (Proxy.ExportGuid != value)
                {
                    var __oldValue = Proxy.ExportGuid;
                    var __newValue = value;
                    if (OnExportGuid_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ExportGuid", __oldValue, __newValue);
                    Proxy.ExportGuid = __newValue;
                    NotifyPropertyChanged("ExportGuid", __oldValue, __newValue);
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

        private Guid FetchExportGuidOrDefault()
        {
            var __result = Proxy.ExportGuid;
                if (!_isExportGuidSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("c776e87f-2b95-466e-848e-0ce195f4bd73"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this.Proxy.ExportGuid = (Guid)__tmp_value;
                    } else {
                        Kistl.API.Utils.Logging.Log.Warn("Unable to get default value for property 'Kistl.App.Base.Group.ExportGuid'");
                    }
                }
            return __result;
        }

        private bool _isExportGuidSet = false;
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.Group, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.Group, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.Group, Guid> OnExportGuid_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Base.Group> OnExportGuid_IsValid;

        /// <summary>
        /// Identities are member of this group
        /// </summary>
        // collection entry list property
   		// Kistl.DalProvider.NHibernate.Generator.Templates.Properties.CollectionEntryListProperty
		public ICollection<Kistl.App.Base.Identity> Member
		{
			get
			{
				if (_Member == null)
				{
					_Member 
						= new NHibernateASideCollectionWrapper<Kistl.App.Base.Identity, Kistl.App.Base.Group, Kistl.App.Base.Identity_memberOf_Group_RelationEntryNHibernateImpl>(
							this, 
							new ProjectedCollection<Kistl.App.Base.Identity_memberOf_Group_RelationEntryNHibernateImpl.Identity_memberOf_Group_RelationEntryProxy, Kistl.App.Base.Identity_memberOf_Group_RelationEntryNHibernateImpl>(
                                this.Proxy.Member,
                                p => (Kistl.App.Base.Identity_memberOf_Group_RelationEntryNHibernateImpl)OurContext.AttachAndWrap(p),
                                ce => (Kistl.App.Base.Identity_memberOf_Group_RelationEntryNHibernateImpl.Identity_memberOf_Group_RelationEntryProxy)((NHibernatePersistenceObject)ce).NHibernateProxy),
                            entry => (IRelationListSync<Kistl.App.Base.Identity_memberOf_Group_RelationEntryNHibernateImpl>)entry.A.Groups);
                    if (Member_was_eagerLoaded) { Member_was_eagerLoaded = false; }
				}
				return (ICollection<Kistl.App.Base.Identity>)_Member;
			}
		}

		private NHibernateASideCollectionWrapper<Kistl.App.Base.Identity, Kistl.App.Base.Group, Kistl.App.Base.Identity_memberOf_Group_RelationEntryNHibernateImpl> _Member;
		// ignored, but required for Serialization
        private bool Member_was_eagerLoaded = false;

        public static event PropertyIsValidHandler<Kistl.App.Base.Group> OnMember_IsValid;

        /// <summary>
        /// Module is optional. Use it only when you need a Group to be exportable
        /// </summary>
        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Module
        // fkBackingName=this.Proxy.Module; fkGuidBackingName=_fk_guid_Module;
        // referencedInterface=Kistl.App.Base.Module; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Module Module
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Base.ModuleNHibernateImpl __value = (Kistl.App.Base.ModuleNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Module);

                if (OnModule_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.Module>(__value);
                    OnModule_Getter(this, e);
                    __value = (Kistl.App.Base.ModuleNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.Module == null)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = (Kistl.App.Base.ModuleNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Module);
                var __newValue = (Kistl.App.Base.ModuleNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
                    return;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Module", __oldValue, __newValue);

                if (OnModule_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Module>(__oldValue, __newValue);
                    OnModule_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.ModuleNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.Module = null;
                }
                else
                {
                    this.Proxy.Module = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Module", __oldValue, __newValue);

                if (OnModule_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Module>(__oldValue, __newValue);
                    OnModule_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for Module's id, used on dehydration only</summary>
        private int? _fk_Module = null;

        /// <summary>Backing store for Module's guid, used on import only</summary>
        private Guid? _fk_guid_Module = null;

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Module
		public static event PropertyGetterHandler<Kistl.App.Base.Group, Kistl.App.Base.Module> OnModule_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.Group, Kistl.App.Base.Module> OnModule_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.Group, Kistl.App.Base.Module> OnModule_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Base.Group> OnModule_IsValid;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string Name
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Name;
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
                if (Proxy.Name != value)
                {
                    var __oldValue = Proxy.Name;
                    var __newValue = value;
                    if (OnName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Name", __oldValue, __newValue);
                    Proxy.Name = __newValue;
                    NotifyPropertyChanged("Name", __oldValue, __newValue);
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
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.Group, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.Group, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.Group, string> OnName_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Base.Group> OnName_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
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
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
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
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(Group);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (Group)obj;
            var otherImpl = (GroupNHibernateImpl)obj;
            var me = (Group)this;

            me.ExportGuid = other.ExportGuid;
            me.Name = other.Name;
            this._fk_Module = otherImpl._fk_Module;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "Module":
                    {
                        var __oldValue = (Kistl.App.Base.ModuleNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Module);
                        var __newValue = (Kistl.App.Base.ModuleNHibernateImpl)parentObj;
                        NotifyPropertyChanging("Module", __oldValue, __newValue);
                        this.Proxy.Module = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("Module", __oldValue, __newValue);
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
                this.Proxy.Module = ((Kistl.App.Base.ModuleNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.Module>(_fk_guid_Module.Value)).Proxy;
            else
            if (_fk_Module.HasValue)
                this.Proxy.Module = ((Kistl.App.Base.ModuleNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.Module>(_fk_Module.Value)).Proxy;
            else
                this.Proxy.Module = null;
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
                    new PropertyDescriptorNHibernateImpl<Group, Guid>(
                        lazyCtx,
                        new Guid("c776e87f-2b95-466e-848e-0ce195f4bd73"),
                        "ExportGuid",
                        null,
                        obj => obj.ExportGuid,
                        (obj, val) => obj.ExportGuid = val,
						obj => OnExportGuid_IsValid), 
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorNHibernateImpl<Group, ICollection<Kistl.App.Base.Identity>>(
                        lazyCtx,
                        new Guid("f60308a5-a502-4641-aa19-f895e701778c"),
                        "Member",
                        null,
                        obj => obj.Member,
                        null, // lists are read-only properties
                        obj => OnMember_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<Group, Kistl.App.Base.Module>(
                        lazyCtx,
                        new Guid("8da2dab4-81c9-4659-9f25-c6b5177ba26d"),
                        "Module",
                        null,
                        obj => obj.Module,
                        (obj, val) => obj.Module = val,
						obj => OnModule_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<Group, string>(
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
        #endregion // Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

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
            FetchExportGuidOrDefault();
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
        }
        public static event ObjectEventHandler<Group> OnNotifyDeleting_Group;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods
        public override List<NHibernatePersistenceObject> GetParentsToDelete()
        {
            var result = base.GetParentsToDelete();

            // Follow Group_has_Module
            if (this.Module != null && this.Module.ObjectState == DataObjectState.Deleted)
                result.Add((NHibernatePersistenceObject)this.Module);

            return result;
        }

        public override List<NHibernatePersistenceObject> GetChildrenToDelete()
        {
            var result = base.GetChildrenToDelete();

            // Follow GroupMembership_has_Group
            result.AddRange(Context.AttachedObjects
                .OfType<Kistl.App.Base.GroupMembership>()
                .Where(child => child.Group == this
                    && child.ObjectState == DataObjectState.Deleted)
                .Cast<NHibernatePersistenceObject>());

            return result;
        }


        public class GroupProxy
            : IProxyObject, ISortKey<int>
        {
            public GroupProxy()
            {
                Member = new Collection<Kistl.App.Base.Identity_memberOf_Group_RelationEntryNHibernateImpl.Identity_memberOf_Group_RelationEntryProxy>();
            }

            public virtual int ID { get; set; }

            public virtual Type ZBoxWrapper { get { return typeof(GroupNHibernateImpl); } }
            public virtual Type ZBoxProxy { get { return typeof(GroupProxy); } }

            public virtual Guid ExportGuid { get; set; }

            public virtual ICollection<Kistl.App.Base.Identity_memberOf_Group_RelationEntryNHibernateImpl.Identity_memberOf_Group_RelationEntryProxy> Member { get; set; }

            public virtual Kistl.App.Base.ModuleNHibernateImpl.ModuleProxy Module { get; set; }

            public virtual string Name { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.ToStream(this.Proxy.ExportGuid, binStream);
            }
            BinarySerializer.ToStream(this.Proxy.Module != null ? OurContext.GetIdFromProxy(this.Proxy.Module) : (int?)null, binStream);
            BinarySerializer.ToStream(this.Proxy.Name, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                Guid tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.ExportGuid = tmp;
            }
            BinarySerializer.FromStream(out this._fk_Module, binStream);
            {
                string tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.Name = tmp;
            }
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
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.ToStream(this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                XmlStreamer.ToStream(this.Proxy.ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            }
            XmlStreamer.ToStream(this.Proxy.Module != null ? OurContext.GetIdFromProxy(this.Proxy.Module) : (int?)null, xml, "Module", "Kistl.App.Base");
            XmlStreamer.ToStream(this.Proxy.Name, xml, "Name", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                // yuck
                Guid tmp = this.Proxy.ExportGuid;
                XmlStreamer.FromStream(ref tmp, xml, "ExportGuid", "Kistl.App.Base");
                this.Proxy.ExportGuid = tmp;
            }
            XmlStreamer.FromStream(ref this._fk_Module, xml, "Module", "Kistl.App.Base");
            {
                // yuck
                string tmp = this.Proxy.Name;
                XmlStreamer.FromStream(ref tmp, xml, "Name", "Kistl.App.Base");
                this.Proxy.Name = tmp;
            }
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            xml.WriteAttributeString("ExportGuid", this.Proxy.ExportGuid.ToString());
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this.Proxy.Module != null ? this.Proxy.Module.ExportGuid : (Guid?)null, xml, "Module", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this.Proxy.Name, xml, "Name", "Kistl.App.Base");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            // Import must have default value set
            {
                // yuck
                Guid tmp = this.Proxy.ExportGuid;
                XmlStreamer.FromStream(ref tmp, xml, "ExportGuid", "Kistl.App.Base");
                this.Proxy.ExportGuid = tmp;
                this._isExportGuidSet = true;
            }
            XmlStreamer.FromStream(ref this._fk_guid_Module, xml, "Module", "Kistl.App.Base");
            {
                // yuck
                string tmp = this.Proxy.Name;
                XmlStreamer.FromStream(ref tmp, xml, "Name", "Kistl.App.Base");
                this.Proxy.Name = tmp;
            }
        }

        #endregion

    }
}