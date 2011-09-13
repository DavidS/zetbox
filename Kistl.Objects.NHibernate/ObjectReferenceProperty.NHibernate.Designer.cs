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
    /// Metadefinition Object for ObjectReference Properties.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("ObjectReferenceProperty")]
    public class ObjectReferencePropertyNHibernateImpl : Kistl.App.Base.PropertyNHibernateImpl, ObjectReferenceProperty
    {
        public ObjectReferencePropertyNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public ObjectReferencePropertyNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new ObjectReferencePropertyProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public ObjectReferencePropertyNHibernateImpl(Func<IFrozenContext> lazyCtx, ObjectReferencePropertyProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly ObjectReferencePropertyProxy Proxy;

        /// <summary>
        /// Whether or not this reference should be loaded eagerly
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public bool EagerLoading
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return default(bool);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.EagerLoading;
                if (OnEagerLoading_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnEagerLoading_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.EagerLoading != value)
                {
                    var __oldValue = Proxy.EagerLoading;
                    var __newValue = value;
                    if (OnEagerLoading_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnEagerLoading_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("EagerLoading", __oldValue, __newValue);
                    Proxy.EagerLoading = __newValue;
                    NotifyPropertyChanged("EagerLoading", __oldValue, __newValue);
                    if (OnEagerLoading_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnEagerLoading_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.ObjectReferenceProperty, bool> OnEagerLoading_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ObjectReferenceProperty, bool> OnEagerLoading_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ObjectReferenceProperty, bool> OnEagerLoading_PostSetter;

        /// <summary>
        /// Simple objects are inline editable in lists. Use this property to override this default. If true, the referenced instances are editable in lists, otherwise not.
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public bool? IsInlineEditable
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return default(bool?);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.IsInlineEditable;
                if (OnIsInlineEditable_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool?>(__result);
                    OnIsInlineEditable_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.IsInlineEditable != value)
                {
                    var __oldValue = Proxy.IsInlineEditable;
                    var __newValue = value;
                    if (OnIsInlineEditable_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnIsInlineEditable_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IsInlineEditable", __oldValue, __newValue);
                    Proxy.IsInlineEditable = __newValue;
                    NotifyPropertyChanged("IsInlineEditable", __oldValue, __newValue);
                    if (OnIsInlineEditable_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnIsInlineEditable_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.ObjectReferenceProperty, bool?> OnIsInlineEditable_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ObjectReferenceProperty, bool?> OnIsInlineEditable_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ObjectReferenceProperty, bool?> OnIsInlineEditable_PostSetter;

        /// <summary>
        /// The RelationEnd describing this Property
        /// </summary>
        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for RelationEnd
        // fkBackingName=this.Proxy.RelationEnd; fkGuidBackingName=_fk_guid_RelationEnd;
        // referencedInterface=Kistl.App.Base.RelationEnd; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=Navigator; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.RelationEnd RelationEnd
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return null;
                Kistl.App.Base.RelationEndNHibernateImpl __value = (Kistl.App.Base.RelationEndNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.RelationEnd);

                if (OnRelationEnd_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.RelationEnd>(__value);
                    OnRelationEnd_Getter(this, e);
                    __value = (Kistl.App.Base.RelationEndNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.RelationEnd == null)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = (Kistl.App.Base.RelationEndNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.RelationEnd);
                var __newValue = (Kistl.App.Base.RelationEndNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
                    return;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("RelationEnd", __oldValue, __newValue);

                if (OnRelationEnd_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.RelationEnd>(__oldValue, __newValue);
                    OnRelationEnd_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.RelationEndNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.RelationEnd = null;
                }
                else
                {
                    this.Proxy.RelationEnd = __newValue.Proxy;
                }

                // now fixup redundant, inverse references
                // The inverse navigator will also fire events when changed, so should
                // only be touched after setting the local value above.
                // TODO: for complete correctness, the "other" Changing event should also fire
                //       before the local value is changed
                if (__oldValue != null)
                {
                    // unset old reference
                    __oldValue.Navigator = null;
                }

                if (__newValue != null)
                {
                    // set new reference
                    __newValue.Navigator = this;
                }
                // everything is done. fire the Changed event
                NotifyPropertyChanged("RelationEnd", __oldValue, __newValue);

                if (OnRelationEnd_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.RelationEnd>(__oldValue, __newValue);
                    OnRelationEnd_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for RelationEnd's id, used on dehydration only</summary>
        private int? _fk_RelationEnd = null;

        /// <summary>Backing store for RelationEnd's guid, used on import only</summary>
        private Guid? _fk_guid_RelationEnd = null;

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for RelationEnd
		public static event PropertyGetterHandler<Kistl.App.Base.ObjectReferenceProperty, Kistl.App.Base.RelationEnd> OnRelationEnd_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ObjectReferenceProperty, Kistl.App.Base.RelationEnd> OnRelationEnd_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ObjectReferenceProperty, Kistl.App.Base.RelationEnd> OnRelationEnd_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetIsList_ObjectReferenceProperty")]
        public virtual bool GetIsList()
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnGetIsList_ObjectReferenceProperty != null)
            {
                OnGetIsList_ObjectReferenceProperty(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on ObjectReferenceProperty.GetIsList");
            }
            return e.Result;
        }
        public delegate void GetIsList_Handler<T>(T obj, MethodReturnEventArgs<bool> ret);
        public static event GetIsList_Handler<ObjectReferenceProperty> OnGetIsList_ObjectReferenceProperty;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_ObjectReferenceProperty")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_ObjectReferenceProperty != null)
            {
                OnGetLabel_ObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<ObjectReferenceProperty> OnGetLabel_ObjectReferenceProperty;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetPropertyType_ObjectReferenceProperty")]
        public override System.Type GetPropertyType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_ObjectReferenceProperty != null)
            {
                OnGetPropertyType_ObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
        public static event GetPropertyType_Handler<ObjectReferenceProperty> OnGetPropertyType_ObjectReferenceProperty;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetPropertyTypeString_ObjectReferenceProperty")]
        public override string GetPropertyTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_ObjectReferenceProperty != null)
            {
                OnGetPropertyTypeString_ObjectReferenceProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
        public static event GetPropertyTypeString_Handler<ObjectReferenceProperty> OnGetPropertyTypeString_ObjectReferenceProperty;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(ObjectReferenceProperty);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (ObjectReferenceProperty)obj;
            var otherImpl = (ObjectReferencePropertyNHibernateImpl)obj;
            var me = (ObjectReferenceProperty)this;

            me.EagerLoading = other.EagerLoading;
            me.IsInlineEditable = other.IsInlineEditable;
            this._fk_RelationEnd = otherImpl._fk_RelationEnd;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
        }

        public override void UpdateParent(string propertyName, int? id)
        {
            switch(propertyName)
            {
                case "RelationEnd":
                    {
                        var __oldValue = (Kistl.App.Base.RelationEndNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.RelationEnd);
                        var __newValue = (Kistl.App.Base.RelationEndNHibernateImpl)(id == null ? null : OurContext.Find<Kistl.App.Base.RelationEnd>(id.Value));
                        NotifyPropertyChanging("RelationEnd", __oldValue, __newValue);
                        this.Proxy.RelationEnd = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("RelationEnd", __oldValue, __newValue);
                    }
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

            if (_fk_guid_RelationEnd.HasValue)
                this.Proxy.RelationEnd = ((Kistl.App.Base.RelationEndNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.RelationEnd>(_fk_guid_RelationEnd.Value)).Proxy;
            else
            if (_fk_RelationEnd.HasValue)
                this.Proxy.RelationEnd = ((Kistl.App.Base.RelationEndNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.RelationEnd>(_fk_RelationEnd.Value)).Proxy;
            else
                this.Proxy.RelationEnd = null;
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
                    new PropertyDescriptorNHibernateImpl<ObjectReferencePropertyNHibernateImpl, bool>(
                        lazyCtx,
                        new Guid("373f0036-42d6-41e2-a2a4-74462537f426"),
                        "EagerLoading",
                        null,
                        obj => obj.EagerLoading,
                        (obj, val) => obj.EagerLoading = val),
                    // else
                    new PropertyDescriptorNHibernateImpl<ObjectReferencePropertyNHibernateImpl, bool?>(
                        lazyCtx,
                        new Guid("f7183d87-8cc8-4703-b148-02db9f5bf9bc"),
                        "IsInlineEditable",
                        null,
                        obj => obj.IsInlineEditable,
                        (obj, val) => obj.IsInlineEditable = val),
                    // else
                    new PropertyDescriptorNHibernateImpl<ObjectReferencePropertyNHibernateImpl, Kistl.App.Base.RelationEnd>(
                        lazyCtx,
                        new Guid("63ba109d-92c6-4ced-980b-0a52aabfaec0"),
                        "RelationEnd",
                        null,
                        obj => obj.RelationEnd,
                        (obj, val) => obj.RelationEnd = val),
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
        [EventBasedMethod("OnToString_ObjectReferenceProperty")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ObjectReferenceProperty != null)
            {
                OnToString_ObjectReferenceProperty(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<ObjectReferenceProperty> OnToString_ObjectReferenceProperty;

        [EventBasedMethod("OnPreSave_ObjectReferenceProperty")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ObjectReferenceProperty != null) OnPreSave_ObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<ObjectReferenceProperty> OnPreSave_ObjectReferenceProperty;

        [EventBasedMethod("OnPostSave_ObjectReferenceProperty")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ObjectReferenceProperty != null) OnPostSave_ObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<ObjectReferenceProperty> OnPostSave_ObjectReferenceProperty;

        [EventBasedMethod("OnCreated_ObjectReferenceProperty")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_ObjectReferenceProperty != null) OnCreated_ObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<ObjectReferenceProperty> OnCreated_ObjectReferenceProperty;

        [EventBasedMethod("OnDeleting_ObjectReferenceProperty")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_ObjectReferenceProperty != null) OnDeleting_ObjectReferenceProperty(this);
        }
        public static event ObjectEventHandler<ObjectReferenceProperty> OnDeleting_ObjectReferenceProperty;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods
        public override List<NHibernatePersistenceObject> GetParentsToDelete()
        {
            var result = base.GetParentsToDelete();

            // Follow RelationEnd_has_Navigator
            if (this.RelationEnd != null && this.RelationEnd.ObjectState == DataObjectState.Deleted)
                result.Add((NHibernatePersistenceObject)this.RelationEnd);

            return result;
        }

        public override List<NHibernatePersistenceObject> GetChildrenToDelete()
        {
            var result = base.GetChildrenToDelete();

            return result;
        }


        public class ObjectReferencePropertyProxy
            : Kistl.App.Base.PropertyNHibernateImpl.PropertyProxy
        {
            public ObjectReferencePropertyProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(ObjectReferencePropertyNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(ObjectReferencePropertyProxy); } }

            public virtual bool EagerLoading { get; set; }

            public virtual bool? IsInlineEditable { get; set; }

            public virtual Kistl.App.Base.RelationEndNHibernateImpl.RelationEndProxy RelationEnd { get; set; }

        }

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this.Proxy.EagerLoading, binStream);
            BinarySerializer.ToStream(this.Proxy.IsInlineEditable, binStream);
            BinarySerializer.ToStream(this.Proxy.RelationEnd != null ? this.Proxy.RelationEnd.ID : (int?)null, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            {
                bool tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.EagerLoading = tmp;
            }
            {
                bool? tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.IsInlineEditable = tmp;
            }
            BinarySerializer.FromStream(out this._fk_RelationEnd, binStream);
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            XmlStreamer.ToStream(this.Proxy.EagerLoading, xml, "EagerLoading", "Kistl.App.Base");
            XmlStreamer.ToStream(this.Proxy.IsInlineEditable, xml, "IsInlineEditable", "Kistl.App.GUI");
            XmlStreamer.ToStream(this.Proxy.RelationEnd != null ? this.Proxy.RelationEnd.ID : (int?)null, xml, "RelationEnd", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            {
                // yuck
                bool tmp = this.Proxy.EagerLoading;
                XmlStreamer.FromStream(ref tmp, xml, "EagerLoading", "Kistl.App.Base");
                this.Proxy.EagerLoading = tmp;
            }
            {
                // yuck
                bool? tmp = this.Proxy.IsInlineEditable;
                XmlStreamer.FromStream(ref tmp, xml, "IsInlineEditable", "Kistl.App.GUI");
                this.Proxy.IsInlineEditable = tmp;
            }
            XmlStreamer.FromStream(ref this._fk_RelationEnd, xml, "RelationEnd", "Kistl.App.Base");
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this.Proxy.EagerLoading, xml, "EagerLoading", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this.Proxy.IsInlineEditable, xml, "IsInlineEditable", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this.Proxy.RelationEnd != null ? this.Proxy.RelationEnd.ExportGuid : (Guid?)null, xml, "RelationEnd", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            {
                // yuck
                bool tmp = this.Proxy.EagerLoading;
                XmlStreamer.FromStream(ref tmp, xml, "EagerLoading", "Kistl.App.Base");
                this.Proxy.EagerLoading = tmp;
            }
            {
                // yuck
                bool? tmp = this.Proxy.IsInlineEditable;
                XmlStreamer.FromStream(ref tmp, xml, "IsInlineEditable", "Kistl.App.GUI");
                this.Proxy.IsInlineEditable = tmp;
            }
            XmlStreamer.FromStream(ref this._fk_guid_RelationEnd, xml, "RelationEnd", "Kistl.App.Base");
        }

        #endregion

    }
}