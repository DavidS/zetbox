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
    /// Metadefinition Object for a CompoundObject Parameter.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("CompoundObjectParameter")]
    public class CompoundObjectParameterNHibernateImpl : Zetbox.App.Base.BaseParameterNHibernateImpl, CompoundObjectParameter
    {
        private static readonly Guid _objectClassID = new Guid("3915cfbf-33c4-4a25-bc5f-b2dd07a9439d");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public CompoundObjectParameterNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public CompoundObjectParameterNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new CompoundObjectParameterProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public CompoundObjectParameterNHibernateImpl(Func<IFrozenContext> lazyCtx, CompoundObjectParameterProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly CompoundObjectParameterProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for CompoundObject
        // fkBackingName=this.Proxy.CompoundObject; fkGuidBackingName=_fk_guid_CompoundObject;
        // referencedInterface=Zetbox.App.Base.CompoundObject; moduleNamespace=Zetbox.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Base.CompoundObject CompoundObject
        {
            get
            {
                Zetbox.App.Base.CompoundObjectNHibernateImpl __value = (Zetbox.App.Base.CompoundObjectNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.CompoundObject);

                if (OnCompoundObject_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.CompoundObject>(__value);
                    OnCompoundObject_Getter(this, e);
                    __value = (Zetbox.App.Base.CompoundObjectNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.CompoundObject == null)
				{
					SetInitializedProperty("CompoundObject");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = (Zetbox.App.Base.CompoundObjectNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.CompoundObject);
                var __newValue = (Zetbox.App.Base.CompoundObjectNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
				{
					SetInitializedProperty("CompoundObject");
                    return;
				}

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("CompoundObject", __oldValue, __newValue);

                if (OnCompoundObject_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.CompoundObject>(__oldValue, __newValue);
                    OnCompoundObject_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.CompoundObjectNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.CompoundObject = null;
                }
                else
                {
                    this.Proxy.CompoundObject = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("CompoundObject", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;

                if (OnCompoundObject_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.CompoundObject>(__oldValue, __newValue);
                    OnCompoundObject_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for CompoundObject's id, used on dehydration only</summary>
        private int? _fk_CompoundObject = null;

        /// <summary>Backing store for CompoundObject's guid, used on import only</summary>
        private Guid? _fk_guid_CompoundObject = null;

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for CompoundObject
		public static event PropertyGetterHandler<Zetbox.App.Base.CompoundObjectParameter, Zetbox.App.Base.CompoundObject> OnCompoundObject_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.CompoundObjectParameter, Zetbox.App.Base.CompoundObject> OnCompoundObject_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.CompoundObjectParameter, Zetbox.App.Base.CompoundObject> OnCompoundObject_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.CompoundObjectParameter> OnCompoundObject_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_CompoundObjectParameter")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_CompoundObjectParameter != null)
            {
                OnGetLabel_CompoundObjectParameter(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<CompoundObjectParameter> OnGetLabel_CompoundObjectParameter;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<CompoundObjectParameter> OnGetLabel_CompoundObjectParameter_CanExec;

        [EventBasedMethod("OnGetLabel_CompoundObjectParameter_CanExec")]
        public override bool GetLabelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabel_CompoundObjectParameter_CanExec != null)
				{
					OnGetLabel_CompoundObjectParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CompoundObjectParameter> OnGetLabel_CompoundObjectParameter_CanExecReason;

        [EventBasedMethod("OnGetLabel_CompoundObjectParameter_CanExecReason")]
        public override string GetLabelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabel_CompoundObjectParameter_CanExecReason != null)
				{
					OnGetLabel_CompoundObjectParameter_CanExecReason(this, e);
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
        [EventBasedMethod("OnGetParameterType_CompoundObjectParameter")]
        public override System.Type GetParameterType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetParameterType_CompoundObjectParameter != null)
            {
                OnGetParameterType_CompoundObjectParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterType();
            }
            return e.Result;
        }
        public static event GetParameterType_Handler<CompoundObjectParameter> OnGetParameterType_CompoundObjectParameter;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<CompoundObjectParameter> OnGetParameterType_CompoundObjectParameter_CanExec;

        [EventBasedMethod("OnGetParameterType_CompoundObjectParameter_CanExec")]
        public override bool GetParameterTypeCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetParameterType_CompoundObjectParameter_CanExec != null)
				{
					OnGetParameterType_CompoundObjectParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CompoundObjectParameter> OnGetParameterType_CompoundObjectParameter_CanExecReason;

        [EventBasedMethod("OnGetParameterType_CompoundObjectParameter_CanExecReason")]
        public override string GetParameterTypeCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetParameterType_CompoundObjectParameter_CanExecReason != null)
				{
					OnGetParameterType_CompoundObjectParameter_CanExecReason(this, e);
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
        [EventBasedMethod("OnGetParameterTypeString_CompoundObjectParameter")]
        public override string GetParameterTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetParameterTypeString_CompoundObjectParameter != null)
            {
                OnGetParameterTypeString_CompoundObjectParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterTypeString();
            }
            return e.Result;
        }
        public static event GetParameterTypeString_Handler<CompoundObjectParameter> OnGetParameterTypeString_CompoundObjectParameter;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<CompoundObjectParameter> OnGetParameterTypeString_CompoundObjectParameter_CanExec;

        [EventBasedMethod("OnGetParameterTypeString_CompoundObjectParameter_CanExec")]
        public override bool GetParameterTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetParameterTypeString_CompoundObjectParameter_CanExec != null)
				{
					OnGetParameterTypeString_CompoundObjectParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CompoundObjectParameter> OnGetParameterTypeString_CompoundObjectParameter_CanExecReason;

        [EventBasedMethod("OnGetParameterTypeString_CompoundObjectParameter_CanExecReason")]
        public override string GetParameterTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetParameterTypeString_CompoundObjectParameter_CanExecReason != null)
				{
					OnGetParameterTypeString_CompoundObjectParameter_CanExecReason(this, e);
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
            return typeof(CompoundObjectParameter);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (CompoundObjectParameter)obj;
            var otherImpl = (CompoundObjectParameterNHibernateImpl)obj;
            var me = (CompoundObjectParameter)this;

            this._fk_CompoundObject = otherImpl._fk_CompoundObject;
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
                case "CompoundObject":
                    {
                        var __oldValue = (Zetbox.App.Base.CompoundObjectNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.CompoundObject);
                        var __newValue = (Zetbox.App.Base.CompoundObjectNHibernateImpl)parentObj;
                        NotifyPropertyChanging("CompoundObject", __oldValue, __newValue);
                        this.Proxy.CompoundObject = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("CompoundObject", __oldValue, __newValue);
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
                case "CompoundObject":
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

            if (_fk_guid_CompoundObject.HasValue)
                this.CompoundObject = ((Zetbox.App.Base.CompoundObjectNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.Base.CompoundObject>(_fk_guid_CompoundObject.Value));
            else
            if (_fk_CompoundObject.HasValue)
                this.CompoundObject = ((Zetbox.App.Base.CompoundObjectNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.Base.CompoundObject>(_fk_CompoundObject.Value));
            else
                this.CompoundObject = null;
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
                    new PropertyDescriptorNHibernateImpl<CompoundObjectParameter, Zetbox.App.Base.CompoundObject>(
                        lazyCtx,
                        new Guid("43d03fec-b595-46d0-b5d5-cf4c5d21fda7"),
                        "CompoundObject",
                        null,
                        obj => obj.CompoundObject,
                        (obj, val) => obj.CompoundObject = val,
						obj => OnCompoundObject_IsValid), 
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
        [EventBasedMethod("OnToString_CompoundObjectParameter")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_CompoundObjectParameter != null)
            {
                OnToString_CompoundObjectParameter(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<CompoundObjectParameter> OnToString_CompoundObjectParameter;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_CompoundObjectParameter")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_CompoundObjectParameter != null)
            {
                OnObjectIsValid_CompoundObjectParameter(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<CompoundObjectParameter> OnObjectIsValid_CompoundObjectParameter;

        [EventBasedMethod("OnNotifyPreSave_CompoundObjectParameter")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_CompoundObjectParameter != null) OnNotifyPreSave_CompoundObjectParameter(this);
        }
        public static event ObjectEventHandler<CompoundObjectParameter> OnNotifyPreSave_CompoundObjectParameter;

        [EventBasedMethod("OnNotifyPostSave_CompoundObjectParameter")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_CompoundObjectParameter != null) OnNotifyPostSave_CompoundObjectParameter(this);
        }
        public static event ObjectEventHandler<CompoundObjectParameter> OnNotifyPostSave_CompoundObjectParameter;

        [EventBasedMethod("OnNotifyCreated_CompoundObjectParameter")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("CompoundObject");
            base.NotifyCreated();
            if (OnNotifyCreated_CompoundObjectParameter != null) OnNotifyCreated_CompoundObjectParameter(this);
        }
        public static event ObjectEventHandler<CompoundObjectParameter> OnNotifyCreated_CompoundObjectParameter;

        [EventBasedMethod("OnNotifyDeleting_CompoundObjectParameter")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_CompoundObjectParameter != null) OnNotifyDeleting_CompoundObjectParameter(this);

            // FK_CPParameter_has_CompoundObject
            if (CompoundObject != null) {
                ((NHibernatePersistenceObject)CompoundObject).ChildrenToDelete.Add(this);
                ParentsToDelete.Add((NHibernatePersistenceObject)CompoundObject);
            }

        }
        public static event ObjectEventHandler<CompoundObjectParameter> OnNotifyDeleting_CompoundObjectParameter;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class CompoundObjectParameterProxy
            : Zetbox.App.Base.BaseParameterNHibernateImpl.BaseParameterProxy
        {
            public CompoundObjectParameterProxy()
            {
            }

            public override Type ZetboxWrapper { get { return typeof(CompoundObjectParameterNHibernateImpl); } }

            public override Type ZetboxProxy { get { return typeof(CompoundObjectParameterProxy); } }

            public virtual Zetbox.App.Base.CompoundObjectNHibernateImpl.CompoundObjectProxy CompoundObject { get; set; }

        }

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.CompoundObject != null ? OurContext.GetIdFromProxy(this.Proxy.CompoundObject) : (int?)null);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            binStream.Read(out this._fk_CompoundObject);
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
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this.Proxy.CompoundObject != null ? this.Proxy.CompoundObject.ExportGuid : (Guid?)null, xml, "CompoundObject", "Zetbox.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Base|CompoundObject":
                this._fk_guid_CompoundObject = XmlStreamer.ReadNullableGuid(xml);
                break;
            }
        }

        #endregion

    }
}