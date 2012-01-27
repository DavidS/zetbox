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
    [System.Diagnostics.DebuggerDisplay("ConstraintInvocation")]
    public class ConstraintInvocationNHibernateImpl : Kistl.DalProvider.NHibernate.DataObjectNHibernateImpl, ConstraintInvocation, Kistl.API.IExportableInternal
    {
        public ConstraintInvocationNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public ConstraintInvocationNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new ConstraintInvocationProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public ConstraintInvocationNHibernateImpl(Func<IFrozenContext> lazyCtx, ConstraintInvocationProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
            _isExportGuidSet = Proxy.ID > 0;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly ConstraintInvocationProxy Proxy;

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
            }
        }

        private Guid FetchExportGuidOrDefault()
        {
            var __result = Proxy.ExportGuid;
                if (!_isExportGuidSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("06d4a536-d9c4-487f-9861-ac15429e42de"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this.Proxy.ExportGuid = (Guid)__tmp_value;
                    } else {
                        Kistl.API.Utils.Logging.Log.Warn("Unable to get default value for property 'Kistl.App.Base.ConstraintInvocation.ExportGuid'");
                    }
                }
            return __result;
        }

        private bool _isExportGuidSet = false;
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.ConstraintInvocation, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ConstraintInvocation, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ConstraintInvocation, Guid> OnExportGuid_PostSetter;

        /// <summary>
        /// The type implementing this invocation
        /// </summary>
        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Implementor
        // fkBackingName=this.Proxy.Implementor; fkGuidBackingName=_fk_guid_Implementor;
        // referencedInterface=Kistl.App.Base.TypeRef; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.TypeRef Implementor
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Base.TypeRefNHibernateImpl __value = (Kistl.App.Base.TypeRefNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Implementor);

                if (OnImplementor_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.TypeRef>(__value);
                    OnImplementor_Getter(this, e);
                    __value = (Kistl.App.Base.TypeRefNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.Implementor == null)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = (Kistl.App.Base.TypeRefNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Implementor);
                var __newValue = (Kistl.App.Base.TypeRefNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
                    return;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Implementor", __oldValue, __newValue);

                if (OnImplementor_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.TypeRef>(__oldValue, __newValue);
                    OnImplementor_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.TypeRefNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.Implementor = null;
                }
                else
                {
                    this.Proxy.Implementor = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Implementor", __oldValue, __newValue);

                if (OnImplementor_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.TypeRef>(__oldValue, __newValue);
                    OnImplementor_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for Implementor's id, used on dehydration only</summary>
        private int? _fk_Implementor = null;

        /// <summary>Backing store for Implementor's guid, used on import only</summary>
        private Guid? _fk_guid_Implementor = null;

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Implementor
		public static event PropertyGetterHandler<Kistl.App.Base.ConstraintInvocation, Kistl.App.Base.TypeRef> OnImplementor_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ConstraintInvocation, Kistl.App.Base.TypeRef> OnImplementor_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ConstraintInvocation, Kistl.App.Base.TypeRef> OnImplementor_PostSetter;

        /// <summary>
        /// Name des implementierenden Members
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string MemberName
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.MemberName;
                if (OnMemberName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnMemberName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.MemberName != value)
                {
                    var __oldValue = Proxy.MemberName;
                    var __newValue = value;
                    if (OnMemberName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnMemberName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("MemberName", __oldValue, __newValue);
                    Proxy.MemberName = __newValue;
                    NotifyPropertyChanged("MemberName", __oldValue, __newValue);
                    if (OnMemberName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnMemberName_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.ConstraintInvocation, string> OnMemberName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ConstraintInvocation, string> OnMemberName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ConstraintInvocation, string> OnMemberName_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetCodeTemplate_ConstraintInvocation")]
        public virtual string GetCodeTemplate()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetCodeTemplate_ConstraintInvocation != null)
            {
                OnGetCodeTemplate_ConstraintInvocation(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on ConstraintInvocation.GetCodeTemplate");
            }
            return e.Result;
        }
        public delegate void GetCodeTemplate_Handler<T>(T obj, MethodReturnEventArgs<string> ret);
        public static event GetCodeTemplate_Handler<ConstraintInvocation> OnGetCodeTemplate_ConstraintInvocation;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetMemberName_ConstraintInvocation")]
        public virtual string GetMemberName()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetMemberName_ConstraintInvocation != null)
            {
                OnGetMemberName_ConstraintInvocation(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on ConstraintInvocation.GetMemberName");
            }
            return e.Result;
        }
        public delegate void GetMemberName_Handler<T>(T obj, MethodReturnEventArgs<string> ret);
        public static event GetMemberName_Handler<ConstraintInvocation> OnGetMemberName_ConstraintInvocation;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(ConstraintInvocation);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (ConstraintInvocation)obj;
            var otherImpl = (ConstraintInvocationNHibernateImpl)obj;
            var me = (ConstraintInvocation)this;

            me.ExportGuid = other.ExportGuid;
            me.MemberName = other.MemberName;
            this._fk_Implementor = otherImpl._fk_Implementor;
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
                case "Implementor":
                    {
                        var __oldValue = (Kistl.App.Base.TypeRefNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Implementor);
                        var __newValue = (Kistl.App.Base.TypeRefNHibernateImpl)parentObj;
                        NotifyPropertyChanging("Implementor", __oldValue, __newValue);
                        this.Proxy.Implementor = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("Implementor", __oldValue, __newValue);
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

            if (_fk_guid_Implementor.HasValue)
                this.Proxy.Implementor = ((Kistl.App.Base.TypeRefNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.TypeRef>(_fk_guid_Implementor.Value)).Proxy;
            else
            if (_fk_Implementor.HasValue)
                this.Proxy.Implementor = ((Kistl.App.Base.TypeRefNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.TypeRef>(_fk_Implementor.Value)).Proxy;
            else
                this.Proxy.Implementor = null;
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
                    new PropertyDescriptorNHibernateImpl<ConstraintInvocationNHibernateImpl, Guid>(
                        lazyCtx,
                        new Guid("06d4a536-d9c4-487f-9861-ac15429e42de"),
                        "ExportGuid",
                        null,
                        obj => obj.ExportGuid,
                        (obj, val) => obj.ExportGuid = val),
                    // else
                    new PropertyDescriptorNHibernateImpl<ConstraintInvocationNHibernateImpl, Kistl.App.Base.TypeRef>(
                        lazyCtx,
                        new Guid("4b8486d5-2c48-4485-9824-d0a4a8bbbbca"),
                        "Implementor",
                        null,
                        obj => obj.Implementor,
                        (obj, val) => obj.Implementor = val),
                    // else
                    new PropertyDescriptorNHibernateImpl<ConstraintInvocationNHibernateImpl, string>(
                        lazyCtx,
                        new Guid("fd6ac977-3eab-4b2c-952a-2a1ad043b99a"),
                        "MemberName",
                        null,
                        obj => obj.MemberName,
                        (obj, val) => obj.MemberName = val),
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
        [EventBasedMethod("OnToString_ConstraintInvocation")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ConstraintInvocation != null)
            {
                OnToString_ConstraintInvocation(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<ConstraintInvocation> OnToString_ConstraintInvocation;

        [EventBasedMethod("OnPreSave_ConstraintInvocation")]
        public override void NotifyPreSave()
        {
            FetchExportGuidOrDefault();
            base.NotifyPreSave();
            if (OnPreSave_ConstraintInvocation != null) OnPreSave_ConstraintInvocation(this);
        }
        public static event ObjectEventHandler<ConstraintInvocation> OnPreSave_ConstraintInvocation;

        [EventBasedMethod("OnPostSave_ConstraintInvocation")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ConstraintInvocation != null) OnPostSave_ConstraintInvocation(this);
        }
        public static event ObjectEventHandler<ConstraintInvocation> OnPostSave_ConstraintInvocation;

        [EventBasedMethod("OnCreated_ConstraintInvocation")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_ConstraintInvocation != null) OnCreated_ConstraintInvocation(this);
        }
        public static event ObjectEventHandler<ConstraintInvocation> OnCreated_ConstraintInvocation;

        [EventBasedMethod("OnDeleting_ConstraintInvocation")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_ConstraintInvocation != null) OnDeleting_ConstraintInvocation(this);
        }
        public static event ObjectEventHandler<ConstraintInvocation> OnDeleting_ConstraintInvocation;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods
        public override List<NHibernatePersistenceObject> GetParentsToDelete()
        {
            var result = base.GetParentsToDelete();

            // Follow ConstraintInvocation_has_TypeRef
            if (this.Implementor != null && this.Implementor.ObjectState == DataObjectState.Deleted)
                result.Add((NHibernatePersistenceObject)this.Implementor);

            return result;
        }

        public override List<NHibernatePersistenceObject> GetChildrenToDelete()
        {
            var result = base.GetChildrenToDelete();

            // Follow Constraint_invokes_GetErrorTextInvocation
            result.AddRange(Context.AttachedObjects
                .OfType<Kistl.App.Base.InvokingConstraint>()
                .Where(child => child.GetErrorTextInvocation == this
                    && child.ObjectState == DataObjectState.Deleted)
                .Cast<NHibernatePersistenceObject>());

            // Follow Constraint_invokes_IsValidInvocation
            result.AddRange(Context.AttachedObjects
                .OfType<Kistl.App.Base.InvokingConstraint>()
                .Where(child => child.IsValidInvocation == this
                    && child.ObjectState == DataObjectState.Deleted)
                .Cast<NHibernatePersistenceObject>());

            return result;
        }


        public class ConstraintInvocationProxy
            : IProxyObject, ISortKey<int>
        {
            public ConstraintInvocationProxy()
            {
            }

            public virtual int ID { get; set; }

            public virtual Type ZBoxWrapper { get { return typeof(ConstraintInvocationNHibernateImpl); } }
            public virtual Type ZBoxProxy { get { return typeof(ConstraintInvocationProxy); } }

            public virtual Guid ExportGuid { get; set; }

            public virtual Kistl.App.Base.TypeRefNHibernateImpl.TypeRefProxy Implementor { get; set; }

            public virtual string MemberName { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.ToStream(this.Proxy.ExportGuid, binStream);
            }
            BinarySerializer.ToStream(this.Proxy.Implementor != null ? OurContext.GetIdFromProxy(this.Proxy.Implementor) : (int?)null, binStream);
            BinarySerializer.ToStream(this.Proxy.MemberName, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                Guid tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.ExportGuid = tmp;
            }
            BinarySerializer.FromStream(out this._fk_Implementor, binStream);
            {
                string tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.MemberName = tmp;
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
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.ToStream(this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                XmlStreamer.ToStream(this.Proxy.ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            }
            XmlStreamer.ToStream(this.Proxy.Implementor != null ? OurContext.GetIdFromProxy(this.Proxy.Implementor) : (int?)null, xml, "Implementor", "Kistl.App.Base");
            XmlStreamer.ToStream(this.Proxy.MemberName, xml, "MemberName", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                // yuck
                Guid tmp = this.Proxy.ExportGuid;
                XmlStreamer.FromStream(ref tmp, xml, "ExportGuid", "Kistl.App.Base");
                this.Proxy.ExportGuid = tmp;
            }
            XmlStreamer.FromStream(ref this._fk_Implementor, xml, "Implementor", "Kistl.App.Base");
            {
                // yuck
                string tmp = this.Proxy.MemberName;
                XmlStreamer.FromStream(ref tmp, xml, "MemberName", "Kistl.App.Base");
                this.Proxy.MemberName = tmp;
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
            if (!CurrentAccessRights.HasReadRights()) return;
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this.Proxy.Implementor != null ? this.Proxy.Implementor.ExportGuid : (Guid?)null, xml, "Implementor", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this.Proxy.MemberName, xml, "MemberName", "Kistl.App.Base");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            if (!CurrentAccessRights.HasReadRights()) return;
            // Import must have default value set
            {
                // yuck
                Guid tmp = this.Proxy.ExportGuid;
                XmlStreamer.FromStream(ref tmp, xml, "ExportGuid", "Kistl.App.Base");
                this.Proxy.ExportGuid = tmp;
                this._isExportGuidSet = true;
            }
            XmlStreamer.FromStream(ref this._fk_guid_Implementor, xml, "Implementor", "Kistl.App.Base");
            {
                // yuck
                string tmp = this.Proxy.MemberName;
                XmlStreamer.FromStream(ref tmp, xml, "MemberName", "Kistl.App.Base");
                this.Proxy.MemberName = tmp;
            }
        }

        #endregion

    }
}