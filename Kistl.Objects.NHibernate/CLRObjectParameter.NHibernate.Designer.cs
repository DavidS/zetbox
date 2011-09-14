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
    /// Metadefinition Object for CLR Object Parameter.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("CLRObjectParameter")]
    public class CLRObjectParameterNHibernateImpl : Kistl.App.Base.BaseParameterNHibernateImpl, CLRObjectParameter
    {
        public CLRObjectParameterNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public CLRObjectParameterNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new CLRObjectParameterProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public CLRObjectParameterNHibernateImpl(Func<IFrozenContext> lazyCtx, CLRObjectParameterProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly CLRObjectParameterProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Type
        // fkBackingName=this.Proxy.Type; fkGuidBackingName=_fk_guid_Type;
        // referencedInterface=Kistl.App.Base.TypeRef; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.TypeRef Type
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Base.TypeRefNHibernateImpl __value = (Kistl.App.Base.TypeRefNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Type);

                if (OnType_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.TypeRef>(__value);
                    OnType_Getter(this, e);
                    __value = (Kistl.App.Base.TypeRefNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.Type == null)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = (Kistl.App.Base.TypeRefNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Type);
                var __newValue = (Kistl.App.Base.TypeRefNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
                    return;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Type", __oldValue, __newValue);

                if (OnType_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.TypeRef>(__oldValue, __newValue);
                    OnType_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.TypeRefNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.Type = null;
                }
                else
                {
                    this.Proxy.Type = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Type", __oldValue, __newValue);

                if (OnType_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.TypeRef>(__oldValue, __newValue);
                    OnType_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for Type's id, used on dehydration only</summary>
        private int? _fk_Type = null;

        /// <summary>Backing store for Type's guid, used on import only</summary>
        private Guid? _fk_guid_Type = null;

        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Type
		public static event PropertyGetterHandler<Kistl.App.Base.CLRObjectParameter, Kistl.App.Base.TypeRef> OnType_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.CLRObjectParameter, Kistl.App.Base.TypeRef> OnType_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.CLRObjectParameter, Kistl.App.Base.TypeRef> OnType_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_CLRObjectParameter")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_CLRObjectParameter != null)
            {
                OnGetLabel_CLRObjectParameter(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<CLRObjectParameter> OnGetLabel_CLRObjectParameter;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the resulting Type of this Method-Parameter Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetParameterType_CLRObjectParameter")]
        public override System.Type GetParameterType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetParameterType_CLRObjectParameter != null)
            {
                OnGetParameterType_CLRObjectParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterType();
            }
            return e.Result;
        }
        public static event GetParameterType_Handler<CLRObjectParameter> OnGetParameterType_CLRObjectParameter;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the String representation of this Method-Parameter Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetParameterTypeString_CLRObjectParameter")]
        public override string GetParameterTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetParameterTypeString_CLRObjectParameter != null)
            {
                OnGetParameterTypeString_CLRObjectParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterTypeString();
            }
            return e.Result;
        }
        public static event GetParameterTypeString_Handler<CLRObjectParameter> OnGetParameterTypeString_CLRObjectParameter;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(CLRObjectParameter);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (CLRObjectParameter)obj;
            var otherImpl = (CLRObjectParameterNHibernateImpl)obj;
            var me = (CLRObjectParameter)this;

            this._fk_Type = otherImpl._fk_Type;
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
                case "Type":
                    {
                        var __oldValue = (Kistl.App.Base.TypeRefNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Type);
                        var __newValue = (Kistl.App.Base.TypeRefNHibernateImpl)(id == null ? null : OurContext.Find<Kistl.App.Base.TypeRef>(id.Value));
                        NotifyPropertyChanging("Type", __oldValue, __newValue);
                        this.Proxy.Type = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("Type", __oldValue, __newValue);
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

            if (_fk_guid_Type.HasValue)
                this.Proxy.Type = ((Kistl.App.Base.TypeRefNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.TypeRef>(_fk_guid_Type.Value)).Proxy;
            else
            if (_fk_Type.HasValue)
                this.Proxy.Type = ((Kistl.App.Base.TypeRefNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Base.TypeRef>(_fk_Type.Value)).Proxy;
            else
                this.Proxy.Type = null;
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
                    new PropertyDescriptorNHibernateImpl<CLRObjectParameterNHibernateImpl, Kistl.App.Base.TypeRef>(
                        lazyCtx,
                        new Guid("137292ce-4493-451d-a7fa-1b7cc7df03dd"),
                        "Type",
                        null,
                        obj => obj.Type,
                        (obj, val) => obj.Type = val),
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
        [EventBasedMethod("OnToString_CLRObjectParameter")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_CLRObjectParameter != null)
            {
                OnToString_CLRObjectParameter(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<CLRObjectParameter> OnToString_CLRObjectParameter;

        [EventBasedMethod("OnPreSave_CLRObjectParameter")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_CLRObjectParameter != null) OnPreSave_CLRObjectParameter(this);
        }
        public static event ObjectEventHandler<CLRObjectParameter> OnPreSave_CLRObjectParameter;

        [EventBasedMethod("OnPostSave_CLRObjectParameter")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_CLRObjectParameter != null) OnPostSave_CLRObjectParameter(this);
        }
        public static event ObjectEventHandler<CLRObjectParameter> OnPostSave_CLRObjectParameter;

        [EventBasedMethod("OnCreated_CLRObjectParameter")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_CLRObjectParameter != null) OnCreated_CLRObjectParameter(this);
        }
        public static event ObjectEventHandler<CLRObjectParameter> OnCreated_CLRObjectParameter;

        [EventBasedMethod("OnDeleting_CLRObjectParameter")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_CLRObjectParameter != null) OnDeleting_CLRObjectParameter(this);
        }
        public static event ObjectEventHandler<CLRObjectParameter> OnDeleting_CLRObjectParameter;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods
        public override List<NHibernatePersistenceObject> GetParentsToDelete()
        {
            var result = base.GetParentsToDelete();

            // Follow ClrObjectParameter_isOf_Type
            if (this.Type != null && this.Type.ObjectState == DataObjectState.Deleted)
                result.Add((NHibernatePersistenceObject)this.Type);

            return result;
        }

        public override List<NHibernatePersistenceObject> GetChildrenToDelete()
        {
            var result = base.GetChildrenToDelete();

            return result;
        }


        public class CLRObjectParameterProxy
            : Kistl.App.Base.BaseParameterNHibernateImpl.BaseParameterProxy
        {
            public CLRObjectParameterProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(CLRObjectParameterNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(CLRObjectParameterProxy); } }

            public virtual Kistl.App.Base.TypeRefNHibernateImpl.TypeRefProxy Type { get; set; }

        }

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this.Proxy.Type != null ? this.Proxy.Type.ID : (int?)null, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._fk_Type, binStream);
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
            XmlStreamer.ToStream(this.Proxy.Type != null ? this.Proxy.Type.ID : (int?)null, xml, "Type", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._fk_Type, xml, "Type", "Kistl.App.Base");
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this.Proxy.Type != null ? this.Proxy.Type.ExportGuid : (Guid?)null, xml, "Type", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.FromStream(ref this._fk_guid_Type, xml, "Type", "Kistl.App.Base");
        }

        #endregion

    }
}