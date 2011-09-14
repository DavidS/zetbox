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
    /// Metadefinition Object for Compound Objects.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("CompoundObject")]
    public class CompoundObjectNHibernateImpl : Kistl.App.Base.DataTypeNHibernateImpl, CompoundObject
    {
        public CompoundObjectNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public CompoundObjectNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new CompoundObjectProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public CompoundObjectNHibernateImpl(Func<IFrozenContext> lazyCtx, CompoundObjectProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly CompoundObjectProxy Proxy;

        /// <summary>
        /// An optional default ViewModelDescriptor for Properties of this type
        /// </summary>
        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for DefaultPropertyViewModelDescriptor
        // fkBackingName=this.Proxy.DefaultPropertyViewModelDescriptor; fkGuidBackingName=_fk_guid_DefaultPropertyViewModelDescriptor;
        // referencedInterface=Kistl.App.GUI.ViewModelDescriptor; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.GUI.ViewModelDescriptor DefaultPropertyViewModelDescriptor
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.GUI.ViewModelDescriptorNHibernateImpl __value = (Kistl.App.GUI.ViewModelDescriptorNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.DefaultPropertyViewModelDescriptor);

                if (OnDefaultPropertyViewModelDescriptor_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.GUI.ViewModelDescriptor>(__value);
                    OnDefaultPropertyViewModelDescriptor_Getter(this, e);
                    __value = (Kistl.App.GUI.ViewModelDescriptorNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.DefaultPropertyViewModelDescriptor == null)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = (Kistl.App.GUI.ViewModelDescriptorNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.DefaultPropertyViewModelDescriptor);
                var __newValue = (Kistl.App.GUI.ViewModelDescriptorNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
                    return;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("DefaultPropertyViewModelDescriptor", __oldValue, __newValue);

                if (OnDefaultPropertyViewModelDescriptor_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.GUI.ViewModelDescriptor>(__oldValue, __newValue);
                    OnDefaultPropertyViewModelDescriptor_PreSetter(this, e);
                    __newValue = (Kistl.App.GUI.ViewModelDescriptorNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.DefaultPropertyViewModelDescriptor = null;
                }
                else
                {
                    this.Proxy.DefaultPropertyViewModelDescriptor = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("DefaultPropertyViewModelDescriptor", __oldValue, __newValue);

                if (OnDefaultPropertyViewModelDescriptor_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.GUI.ViewModelDescriptor>(__oldValue, __newValue);
                    OnDefaultPropertyViewModelDescriptor_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for DefaultPropertyViewModelDescriptor's id, used on dehydration only</summary>
        private int? _fk_DefaultPropertyViewModelDescriptor = null;

        /// <summary>Backing store for DefaultPropertyViewModelDescriptor's guid, used on import only</summary>
        private Guid? _fk_guid_DefaultPropertyViewModelDescriptor = null;

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for DefaultPropertyViewModelDescriptor
		public static event PropertyGetterHandler<Kistl.App.Base.CompoundObject, Kistl.App.GUI.ViewModelDescriptor> OnDefaultPropertyViewModelDescriptor_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.CompoundObject, Kistl.App.GUI.ViewModelDescriptor> OnDefaultPropertyViewModelDescriptor_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.CompoundObject, Kistl.App.GUI.ViewModelDescriptor> OnDefaultPropertyViewModelDescriptor_PostSetter;

        /// <summary>
        /// Returns the resulting Type of this Datatype Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDataType_CompoundObject")]
        public override System.Type GetDataType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetDataType_CompoundObject != null)
            {
                OnGetDataType_CompoundObject(this, e);
            }
            else
            {
                e.Result = base.GetDataType();
            }
            return e.Result;
        }
        public static event GetDataType_Handler<CompoundObject> OnGetDataType_CompoundObject;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the String representation of this Datatype Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDataTypeString_CompoundObject")]
        public override string GetDataTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetDataTypeString_CompoundObject != null)
            {
                OnGetDataTypeString_CompoundObject(this, e);
            }
            else
            {
                e.Result = base.GetDataTypeString();
            }
            return e.Result;
        }
        public static event GetDataTypeString_Handler<CompoundObject> OnGetDataTypeString_CompoundObject;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(CompoundObject);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (CompoundObject)obj;
            var otherImpl = (CompoundObjectNHibernateImpl)obj;
            var me = (CompoundObject)this;

            this._fk_DefaultPropertyViewModelDescriptor = otherImpl._fk_DefaultPropertyViewModelDescriptor;
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
                case "DefaultPropertyViewModelDescriptor":
                    {
                        var __oldValue = (Kistl.App.GUI.ViewModelDescriptorNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.DefaultPropertyViewModelDescriptor);
                        var __newValue = (Kistl.App.GUI.ViewModelDescriptorNHibernateImpl)(id == null ? null : OurContext.Find<Kistl.App.GUI.ViewModelDescriptor>(id.Value));
                        NotifyPropertyChanging("DefaultPropertyViewModelDescriptor", __oldValue, __newValue);
                        this.Proxy.DefaultPropertyViewModelDescriptor = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("DefaultPropertyViewModelDescriptor", __oldValue, __newValue);
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

            if (_fk_guid_DefaultPropertyViewModelDescriptor.HasValue)
                this.Proxy.DefaultPropertyViewModelDescriptor = ((Kistl.App.GUI.ViewModelDescriptorNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.GUI.ViewModelDescriptor>(_fk_guid_DefaultPropertyViewModelDescriptor.Value)).Proxy;
            else
            if (_fk_DefaultPropertyViewModelDescriptor.HasValue)
                this.Proxy.DefaultPropertyViewModelDescriptor = ((Kistl.App.GUI.ViewModelDescriptorNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.GUI.ViewModelDescriptor>(_fk_DefaultPropertyViewModelDescriptor.Value)).Proxy;
            else
                this.Proxy.DefaultPropertyViewModelDescriptor = null;
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
                    new PropertyDescriptorNHibernateImpl<CompoundObjectNHibernateImpl, Kistl.App.GUI.ViewModelDescriptor>(
                        lazyCtx,
                        new Guid("908757d2-053b-40c5-89f8-9e5f79b5fe83"),
                        "DefaultPropertyViewModelDescriptor",
                        null,
                        obj => obj.DefaultPropertyViewModelDescriptor,
                        (obj, val) => obj.DefaultPropertyViewModelDescriptor = val),
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
        [EventBasedMethod("OnToString_CompoundObject")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_CompoundObject != null)
            {
                OnToString_CompoundObject(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<CompoundObject> OnToString_CompoundObject;

        [EventBasedMethod("OnPreSave_CompoundObject")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_CompoundObject != null) OnPreSave_CompoundObject(this);
        }
        public static event ObjectEventHandler<CompoundObject> OnPreSave_CompoundObject;

        [EventBasedMethod("OnPostSave_CompoundObject")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_CompoundObject != null) OnPostSave_CompoundObject(this);
        }
        public static event ObjectEventHandler<CompoundObject> OnPostSave_CompoundObject;

        [EventBasedMethod("OnCreated_CompoundObject")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_CompoundObject != null) OnCreated_CompoundObject(this);
        }
        public static event ObjectEventHandler<CompoundObject> OnCreated_CompoundObject;

        [EventBasedMethod("OnDeleting_CompoundObject")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_CompoundObject != null) OnDeleting_CompoundObject(this);
        }
        public static event ObjectEventHandler<CompoundObject> OnDeleting_CompoundObject;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods
        public override List<NHibernatePersistenceObject> GetParentsToDelete()
        {
            var result = base.GetParentsToDelete();

            // Follow Presentable_may_has_DefaultPropViewModelDescriptor
            if (this.DefaultPropertyViewModelDescriptor != null && this.DefaultPropertyViewModelDescriptor.ObjectState == DataObjectState.Deleted)
                result.Add((NHibernatePersistenceObject)this.DefaultPropertyViewModelDescriptor);

            return result;
        }

        public override List<NHibernatePersistenceObject> GetChildrenToDelete()
        {
            var result = base.GetChildrenToDelete();

            // Follow CompoundObjectProperty_has_CompoundObjectDefinition
            result.AddRange(Context.AttachedObjects
                .OfType<Kistl.App.Base.CompoundObjectProperty>()
                .Where(child => child.CompoundObjectDefinition == this
                    && child.ObjectState == DataObjectState.Deleted)
                .Cast<NHibernatePersistenceObject>());

            // Follow CPParameter_has_CompoundObject
            result.AddRange(Context.AttachedObjects
                .OfType<Kistl.App.Base.CompoundObjectParameter>()
                .Where(child => child.CompoundObject == this
                    && child.ObjectState == DataObjectState.Deleted)
                .Cast<NHibernatePersistenceObject>());

            return result;
        }


        public class CompoundObjectProxy
            : Kistl.App.Base.DataTypeNHibernateImpl.DataTypeProxy
        {
            public CompoundObjectProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(CompoundObjectNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(CompoundObjectProxy); } }

            public virtual Kistl.App.GUI.ViewModelDescriptorNHibernateImpl.ViewModelDescriptorProxy DefaultPropertyViewModelDescriptor { get; set; }

        }

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this.Proxy.DefaultPropertyViewModelDescriptor != null ? this.Proxy.DefaultPropertyViewModelDescriptor.ID : (int?)null, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._fk_DefaultPropertyViewModelDescriptor, binStream);
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
            XmlStreamer.ToStream(this.Proxy.DefaultPropertyViewModelDescriptor != null ? this.Proxy.DefaultPropertyViewModelDescriptor.ID : (int?)null, xml, "DefaultPropertyViewModelDescriptor", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._fk_DefaultPropertyViewModelDescriptor, xml, "DefaultPropertyViewModelDescriptor", "Kistl.App.Base");
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            if (!CurrentAccessRights.HasReadRights()) return;
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this.Proxy.DefaultPropertyViewModelDescriptor != null ? this.Proxy.DefaultPropertyViewModelDescriptor.ExportGuid : (Guid?)null, xml, "DefaultPropertyViewModelDescriptor", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.FromStream(ref this._fk_guid_DefaultPropertyViewModelDescriptor, xml, "DefaultPropertyViewModelDescriptor", "Kistl.App.Base");
        }

        #endregion

    }
}