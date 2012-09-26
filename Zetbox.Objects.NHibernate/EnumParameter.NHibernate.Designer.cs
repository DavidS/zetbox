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
    /// Metadefinition Object for Enum Parameter.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("EnumParameter")]
    public class EnumParameterNHibernateImpl : Zetbox.App.Base.BaseParameterNHibernateImpl, EnumParameter
    {
        private static readonly Guid _objectClassID = new Guid("041eaa58-84cb-405f-a6ea-c3d77e4acd82");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public EnumParameterNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public EnumParameterNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new EnumParameterProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public EnumParameterNHibernateImpl(Func<IFrozenContext> lazyCtx, EnumParameterProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly EnumParameterProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Enumeration
        // fkBackingName=this.Proxy.Enumeration; fkGuidBackingName=_fk_guid_Enumeration;
        // referencedInterface=Zetbox.App.Base.Enumeration; moduleNamespace=Zetbox.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Base.Enumeration Enumeration
        {
            get
            {
                Zetbox.App.Base.EnumerationNHibernateImpl __value = (Zetbox.App.Base.EnumerationNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Enumeration);

                if (OnEnumeration_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Base.Enumeration>(__value);
                    OnEnumeration_Getter(this, e);
                    __value = (Zetbox.App.Base.EnumerationNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.Enumeration == null)
				{
					SetInitializedProperty("Enumeration");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = (Zetbox.App.Base.EnumerationNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Enumeration);
                var __newValue = (Zetbox.App.Base.EnumerationNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
				{
					SetInitializedProperty("Enumeration");
                    return;
				}

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Enumeration", __oldValue, __newValue);

                if (OnEnumeration_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.Enumeration>(__oldValue, __newValue);
                    OnEnumeration_PreSetter(this, e);
                    __newValue = (Zetbox.App.Base.EnumerationNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.Enumeration = null;
                }
                else
                {
                    this.Proxy.Enumeration = __newValue.Proxy;
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("Enumeration", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;

                if (OnEnumeration_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.Enumeration>(__oldValue, __newValue);
                    OnEnumeration_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for Enumeration's id, used on dehydration only</summary>
        private int? _fk_Enumeration = null;

        /// <summary>Backing store for Enumeration's guid, used on import only</summary>
        private Guid? _fk_guid_Enumeration = null;

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Enumeration
		public static event PropertyGetterHandler<Zetbox.App.Base.EnumParameter, Zetbox.App.Base.Enumeration> OnEnumeration_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.EnumParameter, Zetbox.App.Base.Enumeration> OnEnumeration_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.EnumParameter, Zetbox.App.Base.Enumeration> OnEnumeration_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.EnumParameter> OnEnumeration_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_EnumParameter")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_EnumParameter != null)
            {
                OnGetLabel_EnumParameter(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<EnumParameter> OnGetLabel_EnumParameter;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<EnumParameter> OnGetLabel_EnumParameter_CanExec;

        [EventBasedMethod("OnGetLabel_EnumParameter_CanExec")]
        public override bool GetLabelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabel_EnumParameter_CanExec != null)
				{
					OnGetLabel_EnumParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<EnumParameter> OnGetLabel_EnumParameter_CanExecReason;

        [EventBasedMethod("OnGetLabel_EnumParameter_CanExecReason")]
        public override string GetLabelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabel_EnumParameter_CanExecReason != null)
				{
					OnGetLabel_EnumParameter_CanExecReason(this, e);
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
        [EventBasedMethod("OnGetParameterType_EnumParameter")]
        public override System.Type GetParameterType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetParameterType_EnumParameter != null)
            {
                OnGetParameterType_EnumParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterType();
            }
            return e.Result;
        }
        public static event GetParameterType_Handler<EnumParameter> OnGetParameterType_EnumParameter;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<EnumParameter> OnGetParameterType_EnumParameter_CanExec;

        [EventBasedMethod("OnGetParameterType_EnumParameter_CanExec")]
        public override bool GetParameterTypeCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetParameterType_EnumParameter_CanExec != null)
				{
					OnGetParameterType_EnumParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<EnumParameter> OnGetParameterType_EnumParameter_CanExecReason;

        [EventBasedMethod("OnGetParameterType_EnumParameter_CanExecReason")]
        public override string GetParameterTypeCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetParameterType_EnumParameter_CanExecReason != null)
				{
					OnGetParameterType_EnumParameter_CanExecReason(this, e);
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
        [EventBasedMethod("OnGetParameterTypeString_EnumParameter")]
        public override string GetParameterTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetParameterTypeString_EnumParameter != null)
            {
                OnGetParameterTypeString_EnumParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterTypeString();
            }
            return e.Result;
        }
        public static event GetParameterTypeString_Handler<EnumParameter> OnGetParameterTypeString_EnumParameter;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<EnumParameter> OnGetParameterTypeString_EnumParameter_CanExec;

        [EventBasedMethod("OnGetParameterTypeString_EnumParameter_CanExec")]
        public override bool GetParameterTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetParameterTypeString_EnumParameter_CanExec != null)
				{
					OnGetParameterTypeString_EnumParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<EnumParameter> OnGetParameterTypeString_EnumParameter_CanExecReason;

        [EventBasedMethod("OnGetParameterTypeString_EnumParameter_CanExecReason")]
        public override string GetParameterTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetParameterTypeString_EnumParameter_CanExecReason != null)
				{
					OnGetParameterTypeString_EnumParameter_CanExecReason(this, e);
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
            return typeof(EnumParameter);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (EnumParameter)obj;
            var otherImpl = (EnumParameterNHibernateImpl)obj;
            var me = (EnumParameter)this;

            this._fk_Enumeration = otherImpl._fk_Enumeration;
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
                case "Enumeration":
                    {
                        var __oldValue = (Zetbox.App.Base.EnumerationNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Enumeration);
                        var __newValue = (Zetbox.App.Base.EnumerationNHibernateImpl)parentObj;
                        NotifyPropertyChanging("Enumeration", __oldValue, __newValue);
                        this.Proxy.Enumeration = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("Enumeration", __oldValue, __newValue);
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
                case "Enumeration":
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

            if (_fk_guid_Enumeration.HasValue)
                this.Enumeration = ((Zetbox.App.Base.EnumerationNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.Base.Enumeration>(_fk_guid_Enumeration.Value));
            else
            if (_fk_Enumeration.HasValue)
                this.Enumeration = ((Zetbox.App.Base.EnumerationNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.Base.Enumeration>(_fk_Enumeration.Value));
            else
                this.Enumeration = null;
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
                    new PropertyDescriptorNHibernateImpl<EnumParameter, Zetbox.App.Base.Enumeration>(
                        lazyCtx,
                        new Guid("b5212dc9-376e-4414-a400-d994779fda18"),
                        "Enumeration",
                        null,
                        obj => obj.Enumeration,
                        (obj, val) => obj.Enumeration = val,
						obj => OnEnumeration_IsValid), 
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
        [EventBasedMethod("OnToString_EnumParameter")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_EnumParameter != null)
            {
                OnToString_EnumParameter(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<EnumParameter> OnToString_EnumParameter;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_EnumParameter")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_EnumParameter != null)
            {
                OnObjectIsValid_EnumParameter(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<EnumParameter> OnObjectIsValid_EnumParameter;

        [EventBasedMethod("OnNotifyPreSave_EnumParameter")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_EnumParameter != null) OnNotifyPreSave_EnumParameter(this);
        }
        public static event ObjectEventHandler<EnumParameter> OnNotifyPreSave_EnumParameter;

        [EventBasedMethod("OnNotifyPostSave_EnumParameter")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_EnumParameter != null) OnNotifyPostSave_EnumParameter(this);
        }
        public static event ObjectEventHandler<EnumParameter> OnNotifyPostSave_EnumParameter;

        [EventBasedMethod("OnNotifyCreated_EnumParameter")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Enumeration");
            base.NotifyCreated();
            if (OnNotifyCreated_EnumParameter != null) OnNotifyCreated_EnumParameter(this);
        }
        public static event ObjectEventHandler<EnumParameter> OnNotifyCreated_EnumParameter;

        [EventBasedMethod("OnNotifyDeleting_EnumParameter")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_EnumParameter != null) OnNotifyDeleting_EnumParameter(this);

            // FK_EnumParameter_has_Enumeration
            if (Enumeration != null) {
                ((NHibernatePersistenceObject)Enumeration).ChildrenToDelete.Add(this);
                ParentsToDelete.Add((NHibernatePersistenceObject)Enumeration);
            }

        }
        public static event ObjectEventHandler<EnumParameter> OnNotifyDeleting_EnumParameter;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class EnumParameterProxy
            : Zetbox.App.Base.BaseParameterNHibernateImpl.BaseParameterProxy
        {
            public EnumParameterProxy()
            {
            }

            public override Type ZetboxWrapper { get { return typeof(EnumParameterNHibernateImpl); } }

            public override Type ZetboxProxy { get { return typeof(EnumParameterProxy); } }

            public virtual Zetbox.App.Base.EnumerationNHibernateImpl.EnumerationProxy Enumeration { get; set; }

        }

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.Enumeration != null ? OurContext.GetIdFromProxy(this.Proxy.Enumeration) : (int?)null);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            binStream.Read(out this._fk_Enumeration);
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
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this.Proxy.Enumeration != null ? this.Proxy.Enumeration.ExportGuid : (Guid?)null, xml, "Enumeration", "Zetbox.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Base|Enumeration":
                this._fk_guid_Enumeration = XmlStreamer.ReadNullableGuid(xml);
                break;
            }
        }

        #endregion

    }
}