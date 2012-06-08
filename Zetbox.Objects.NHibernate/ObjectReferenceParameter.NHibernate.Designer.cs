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

    using Zetbox.API.Utils;
    using Zetbox.DalProvider.Base;
    using Zetbox.DalProvider.NHibernate;

    /// <summary>
    /// Metadefinition Object for Object Parameter.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("ObjectReferenceParameter")]
    public class ObjectReferenceParameterNHibernateImpl : Zetbox.App.Base.BaseParameterNHibernateImpl, ObjectReferenceParameter
    {
        private static readonly Guid _objectClassID = new Guid("3fb8bf11-cab6-478f-b9b8-3f6d70a70d37");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public ObjectReferenceParameterNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public ObjectReferenceParameterNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new ObjectReferenceParameterProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public ObjectReferenceParameterNHibernateImpl(Func<IFrozenContext> lazyCtx, ObjectReferenceParameterProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly ObjectReferenceParameterProxy Proxy;

        /// <summary>
        /// Zetbox-Typ des Parameters
        /// </summary>
        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ObjectClass
        // fkBackingName=this.Proxy.ObjectClass; fkGuidBackingName=_fk_guid_ObjectClass;
        // referencedInterface=Zetbox.App.Base.ObjectClass; moduleNamespace=Zetbox.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Base.ObjectClass ObjectClass
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Zetbox.App.Base.ObjectClassNHibernateImpl __value = (Zetbox.App.Base.ObjectClassNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.ObjectClass);

                if (OnObjectClass_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.ObjectClass>(__value);
                    OnObjectClass_Getter(this, e);
                    __value = (Zetbox.App.Base.ObjectClassNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.ObjectClass == null)
				{
					SetInitializedProperty("ObjectClass");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = (Zetbox.App.Base.ObjectClassNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.ObjectClass);
                var __newValue = (Zetbox.App.Base.ObjectClassNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
				{
					SetInitializedProperty("ObjectClass");
                    return;
				}

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("ObjectClass", __oldValue, __newValue);

                if (OnObjectClass_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.ObjectClass>(__oldValue, __newValue);
                    OnObjectClass_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.ObjectClassNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.ObjectClass = null;
                }
                else
                {
                    this.Proxy.ObjectClass = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("ObjectClass", __oldValue, __newValue);

                if (OnObjectClass_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.ObjectClass>(__oldValue, __newValue);
                    OnObjectClass_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for ObjectClass's id, used on dehydration only</summary>
        private int? _fk_ObjectClass = null;

        /// <summary>Backing store for ObjectClass's guid, used on import only</summary>
        private Guid? _fk_guid_ObjectClass = null;

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ObjectClass
		public static event PropertyGetterHandler<Zetbox.App.Base.ObjectReferenceParameter, Zetbox.App.Base.ObjectClass> OnObjectClass_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.ObjectReferenceParameter, Zetbox.App.Base.ObjectClass> OnObjectClass_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.ObjectReferenceParameter, Zetbox.App.Base.ObjectClass> OnObjectClass_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.ObjectReferenceParameter> OnObjectClass_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_ObjectReferenceParameter")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_ObjectReferenceParameter != null)
            {
                OnGetLabel_ObjectReferenceParameter(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<ObjectReferenceParameter> OnGetLabel_ObjectReferenceParameter;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ObjectReferenceParameter> OnGetLabel_ObjectReferenceParameter_CanExec;

        [EventBasedMethod("OnGetLabel_ObjectReferenceParameter_CanExec")]
        public override bool GetLabelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabel_ObjectReferenceParameter_CanExec != null)
				{
					OnGetLabel_ObjectReferenceParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ObjectReferenceParameter> OnGetLabel_ObjectReferenceParameter_CanExecReason;

        [EventBasedMethod("OnGetLabel_ObjectReferenceParameter_CanExecReason")]
        public override string GetLabelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabel_ObjectReferenceParameter_CanExecReason != null)
				{
					OnGetLabel_ObjectReferenceParameter_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Returns the resulting Type of this Method-Parameter Meta Object.
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetParameterType_ObjectReferenceParameter")]
        public override System.Type GetParameterType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetParameterType_ObjectReferenceParameter != null)
            {
                OnGetParameterType_ObjectReferenceParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterType();
            }
            return e.Result;
        }
        public static event GetParameterType_Handler<ObjectReferenceParameter> OnGetParameterType_ObjectReferenceParameter;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ObjectReferenceParameter> OnGetParameterType_ObjectReferenceParameter_CanExec;

        [EventBasedMethod("OnGetParameterType_ObjectReferenceParameter_CanExec")]
        public override bool GetParameterTypeCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetParameterType_ObjectReferenceParameter_CanExec != null)
				{
					OnGetParameterType_ObjectReferenceParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ObjectReferenceParameter> OnGetParameterType_ObjectReferenceParameter_CanExecReason;

        [EventBasedMethod("OnGetParameterType_ObjectReferenceParameter_CanExecReason")]
        public override string GetParameterTypeCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetParameterType_ObjectReferenceParameter_CanExecReason != null)
				{
					OnGetParameterType_ObjectReferenceParameter_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Returns the String representation of this Method-Parameter Meta Object.
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetParameterTypeString_ObjectReferenceParameter")]
        public override string GetParameterTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetParameterTypeString_ObjectReferenceParameter != null)
            {
                OnGetParameterTypeString_ObjectReferenceParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterTypeString();
            }
            return e.Result;
        }
        public static event GetParameterTypeString_Handler<ObjectReferenceParameter> OnGetParameterTypeString_ObjectReferenceParameter;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ObjectReferenceParameter> OnGetParameterTypeString_ObjectReferenceParameter_CanExec;

        [EventBasedMethod("OnGetParameterTypeString_ObjectReferenceParameter_CanExec")]
        public override bool GetParameterTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetParameterTypeString_ObjectReferenceParameter_CanExec != null)
				{
					OnGetParameterTypeString_ObjectReferenceParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ObjectReferenceParameter> OnGetParameterTypeString_ObjectReferenceParameter_CanExecReason;

        [EventBasedMethod("OnGetParameterTypeString_ObjectReferenceParameter_CanExecReason")]
        public override string GetParameterTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetParameterTypeString_ObjectReferenceParameter_CanExecReason != null)
				{
					OnGetParameterTypeString_ObjectReferenceParameter_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeStringCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(ObjectReferenceParameter);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (ObjectReferenceParameter)obj;
            var otherImpl = (ObjectReferenceParameterNHibernateImpl)obj;
            var me = (ObjectReferenceParameter)this;

            this._fk_ObjectClass = otherImpl._fk_ObjectClass;
        }

        public override void AttachToContext(IZetboxContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "ObjectClass":
                    {
                        var __oldValue = (Zetbox.App.Base.ObjectClassNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.ObjectClass);
                        var __newValue = (Zetbox.App.Base.ObjectClassNHibernateImpl)parentObj;
                        NotifyPropertyChanging("ObjectClass", __oldValue, __newValue);
                        this.Proxy.ObjectClass = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("ObjectClass", __oldValue, __newValue);
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
                case "ObjectClass":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
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

            if (_fk_guid_ObjectClass.HasValue)
                this.ObjectClass = ((Zetbox.App.Base.ObjectClassNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.Base.ObjectClass>(_fk_guid_ObjectClass.Value));
            else
            if (_fk_ObjectClass.HasValue)
                this.ObjectClass = ((Zetbox.App.Base.ObjectClassNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.Base.ObjectClass>(_fk_ObjectClass.Value));
            else
                this.ObjectClass = null;
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
                    new PropertyDescriptorNHibernateImpl<ObjectReferenceParameter, Zetbox.App.Base.ObjectClass>(
                        lazyCtx,
                        new Guid("9bd64c60-7282-47f0-8069-528a175fcc92"),
                        "ObjectClass",
                        null,
                        obj => obj.ObjectClass,
                        (obj, val) => obj.ObjectClass = val,
						obj => OnObjectClass_IsValid), 
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
        #region Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_ObjectReferenceParameter")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ObjectReferenceParameter != null)
            {
                OnToString_ObjectReferenceParameter(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<ObjectReferenceParameter> OnToString_ObjectReferenceParameter;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_ObjectReferenceParameter")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_ObjectReferenceParameter != null)
            {
                OnObjectIsValid_ObjectReferenceParameter(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<ObjectReferenceParameter> OnObjectIsValid_ObjectReferenceParameter;

        [EventBasedMethod("OnNotifyPreSave_ObjectReferenceParameter")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_ObjectReferenceParameter != null) OnNotifyPreSave_ObjectReferenceParameter(this);
        }
        public static event ObjectEventHandler<ObjectReferenceParameter> OnNotifyPreSave_ObjectReferenceParameter;

        [EventBasedMethod("OnNotifyPostSave_ObjectReferenceParameter")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_ObjectReferenceParameter != null) OnNotifyPostSave_ObjectReferenceParameter(this);
        }
        public static event ObjectEventHandler<ObjectReferenceParameter> OnNotifyPostSave_ObjectReferenceParameter;

        [EventBasedMethod("OnNotifyCreated_ObjectReferenceParameter")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("ObjectClass");
            base.NotifyCreated();
            if (OnNotifyCreated_ObjectReferenceParameter != null) OnNotifyCreated_ObjectReferenceParameter(this);
        }
        public static event ObjectEventHandler<ObjectReferenceParameter> OnNotifyCreated_ObjectReferenceParameter;

        [EventBasedMethod("OnNotifyDeleting_ObjectReferenceParameter")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_ObjectReferenceParameter != null) OnNotifyDeleting_ObjectReferenceParameter(this);

            // FK_ObjectParameter_has_ObjectClass
            if (ObjectClass != null) {
                ((NHibernatePersistenceObject)ObjectClass).ChildrenToDelete.Add(this);
                ParentsToDelete.Add((NHibernatePersistenceObject)ObjectClass);
            }

        }
        public static event ObjectEventHandler<ObjectReferenceParameter> OnNotifyDeleting_ObjectReferenceParameter;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class ObjectReferenceParameterProxy
            : Zetbox.App.Base.BaseParameterNHibernateImpl.BaseParameterProxy
        {
            public ObjectReferenceParameterProxy()
            {
            }

            public override Type ZetboxWrapper { get { return typeof(ObjectReferenceParameterNHibernateImpl); } }

            public override Type ZetboxProxy { get { return typeof(ObjectReferenceParameterProxy); } }

            public virtual Zetbox.App.Base.ObjectClassNHibernateImpl.ObjectClassProxy ObjectClass { get; set; }

        }

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.ObjectClass != null ? OurContext.GetIdFromProxy(this.Proxy.ObjectClass) : (int?)null);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            binStream.Read(out this._fk_ObjectClass);
            } // if (CurrentAccessRights != Zetbox.API.AccessRights.None)
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this.Proxy.ObjectClass != null ? this.Proxy.ObjectClass.ExportGuid : (Guid?)null, xml, "ObjectClass", "Zetbox.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Base|ObjectClass":
                this._fk_guid_ObjectClass = XmlStreamer.ReadNullableGuid(xml);
                break;
            }
        }

        #endregion

    }
}