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

    using Zetbox.API.Utils;
    using Zetbox.DalProvider.Base;
    using Zetbox.DalProvider.NHibernate;

    /// <summary>
    /// Filter configuration for filtering on an instance with an user selectable, optional and constant predicate
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("OptionalPredicateFilterConfiguration")]
    public class OptionalPredicateFilterConfigurationNHibernateImpl : Zetbox.App.GUI.ObjectClassFilterConfigurationNHibernateImpl, OptionalPredicateFilterConfiguration
    {
        private static readonly Guid _objectClassID = new Guid("da69f553-1096-48be-8129-eff9118498f0");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public OptionalPredicateFilterConfigurationNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public OptionalPredicateFilterConfigurationNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new OptionalPredicateFilterConfigurationProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public OptionalPredicateFilterConfigurationNHibernateImpl(Func<IFrozenContext> lazyCtx, OptionalPredicateFilterConfigurationProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly OptionalPredicateFilterConfigurationProxy Proxy;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string Predicate
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Predicate;
                if (OnPredicate_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnPredicate_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Predicate != value)
                {
                    var __oldValue = Proxy.Predicate;
                    var __newValue = value;
                    if (OnPredicate_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnPredicate_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Predicate", __oldValue, __newValue);
                    Proxy.Predicate = __newValue;
                    NotifyPropertyChanged("Predicate", __oldValue, __newValue);

                    if (OnPredicate_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnPredicate_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Predicate");
				}
            }
        }

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.GUI.OptionalPredicateFilterConfiguration, string> OnPredicate_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.GUI.OptionalPredicateFilterConfiguration, string> OnPredicate_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.GUI.OptionalPredicateFilterConfiguration, string> OnPredicate_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.GUI.OptionalPredicateFilterConfiguration> OnPredicate_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnCreateFilterModel_OptionalPredicateFilterConfiguration")]
        public override Zetbox.API.IFilterModel CreateFilterModel()
        {
            var e = new MethodReturnEventArgs<Zetbox.API.IFilterModel>();
            if (OnCreateFilterModel_OptionalPredicateFilterConfiguration != null)
            {
                OnCreateFilterModel_OptionalPredicateFilterConfiguration(this, e);
            }
            else
            {
                e.Result = base.CreateFilterModel();
            }
            return e.Result;
        }
        public static event CreateFilterModel_Handler<OptionalPredicateFilterConfiguration> OnCreateFilterModel_OptionalPredicateFilterConfiguration;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<OptionalPredicateFilterConfiguration> OnCreateFilterModel_OptionalPredicateFilterConfiguration_CanExec;

        [EventBasedMethod("OnCreateFilterModel_OptionalPredicateFilterConfiguration_CanExec")]
        public override bool CreateFilterModelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnCreateFilterModel_OptionalPredicateFilterConfiguration_CanExec != null)
				{
					OnCreateFilterModel_OptionalPredicateFilterConfiguration_CanExec(this, e);
				}
				else
				{
					e.Result = base.CreateFilterModelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<OptionalPredicateFilterConfiguration> OnCreateFilterModel_OptionalPredicateFilterConfiguration_CanExecReason;

        [EventBasedMethod("OnCreateFilterModel_OptionalPredicateFilterConfiguration_CanExecReason")]
        public override string CreateFilterModelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnCreateFilterModel_OptionalPredicateFilterConfiguration_CanExecReason != null)
				{
					OnCreateFilterModel_OptionalPredicateFilterConfiguration_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.CreateFilterModelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_OptionalPredicateFilterConfiguration")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_OptionalPredicateFilterConfiguration != null)
            {
                OnGetLabel_OptionalPredicateFilterConfiguration(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<OptionalPredicateFilterConfiguration> OnGetLabel_OptionalPredicateFilterConfiguration;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<OptionalPredicateFilterConfiguration> OnGetLabel_OptionalPredicateFilterConfiguration_CanExec;

        [EventBasedMethod("OnGetLabel_OptionalPredicateFilterConfiguration_CanExec")]
        public override bool GetLabelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabel_OptionalPredicateFilterConfiguration_CanExec != null)
				{
					OnGetLabel_OptionalPredicateFilterConfiguration_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<OptionalPredicateFilterConfiguration> OnGetLabel_OptionalPredicateFilterConfiguration_CanExecReason;

        [EventBasedMethod("OnGetLabel_OptionalPredicateFilterConfiguration_CanExecReason")]
        public override string GetLabelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabel_OptionalPredicateFilterConfiguration_CanExecReason != null)
				{
					OnGetLabel_OptionalPredicateFilterConfiguration_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(OptionalPredicateFilterConfiguration);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (OptionalPredicateFilterConfiguration)obj;
            var otherImpl = (OptionalPredicateFilterConfigurationNHibernateImpl)obj;
            var me = (OptionalPredicateFilterConfiguration)this;

            me.Predicate = other.Predicate;
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

        #region Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "Predicate":
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
                    new PropertyDescriptorNHibernateImpl<OptionalPredicateFilterConfiguration, string>(
                        lazyCtx,
                        new Guid("bcc5a62f-9401-4b88-9cd9-2b33be6fa81a"),
                        "Predicate",
                        null,
                        obj => obj.Predicate,
                        (obj, val) => obj.Predicate = val,
						obj => OnPredicate_IsValid), 
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
        [EventBasedMethod("OnToString_OptionalPredicateFilterConfiguration")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_OptionalPredicateFilterConfiguration != null)
            {
                OnToString_OptionalPredicateFilterConfiguration(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<OptionalPredicateFilterConfiguration> OnToString_OptionalPredicateFilterConfiguration;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_OptionalPredicateFilterConfiguration")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_OptionalPredicateFilterConfiguration != null)
            {
                OnObjectIsValid_OptionalPredicateFilterConfiguration(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<OptionalPredicateFilterConfiguration> OnObjectIsValid_OptionalPredicateFilterConfiguration;

        [EventBasedMethod("OnNotifyPreSave_OptionalPredicateFilterConfiguration")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_OptionalPredicateFilterConfiguration != null) OnNotifyPreSave_OptionalPredicateFilterConfiguration(this);
        }
        public static event ObjectEventHandler<OptionalPredicateFilterConfiguration> OnNotifyPreSave_OptionalPredicateFilterConfiguration;

        [EventBasedMethod("OnNotifyPostSave_OptionalPredicateFilterConfiguration")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_OptionalPredicateFilterConfiguration != null) OnNotifyPostSave_OptionalPredicateFilterConfiguration(this);
        }
        public static event ObjectEventHandler<OptionalPredicateFilterConfiguration> OnNotifyPostSave_OptionalPredicateFilterConfiguration;

        [EventBasedMethod("OnNotifyCreated_OptionalPredicateFilterConfiguration")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Predicate");
            base.NotifyCreated();
            if (OnNotifyCreated_OptionalPredicateFilterConfiguration != null) OnNotifyCreated_OptionalPredicateFilterConfiguration(this);
        }
        public static event ObjectEventHandler<OptionalPredicateFilterConfiguration> OnNotifyCreated_OptionalPredicateFilterConfiguration;

        [EventBasedMethod("OnNotifyDeleting_OptionalPredicateFilterConfiguration")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_OptionalPredicateFilterConfiguration != null) OnNotifyDeleting_OptionalPredicateFilterConfiguration(this);


        }
        public static event ObjectEventHandler<OptionalPredicateFilterConfiguration> OnNotifyDeleting_OptionalPredicateFilterConfiguration;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class OptionalPredicateFilterConfigurationProxy
            : Zetbox.App.GUI.ObjectClassFilterConfigurationNHibernateImpl.ObjectClassFilterConfigurationProxy
        {
            public OptionalPredicateFilterConfigurationProxy()
            {
            }

            public override Type ZetboxWrapper { get { return typeof(OptionalPredicateFilterConfigurationNHibernateImpl); } }

            public override Type ZetboxProxy { get { return typeof(OptionalPredicateFilterConfigurationProxy); } }

            public virtual string Predicate { get; set; }

        }

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.Predicate);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this.Proxy.Predicate = binStream.ReadString();
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
            if (modules.Contains("*") || modules.Contains("Zetbox.App.GUI")) XmlStreamer.ToStream(this.Proxy.Predicate, xml, "Predicate", "Zetbox.App.GUI");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.GUI|Predicate":
                this.Proxy.Predicate = XmlStreamer.ReadString(xml);
                break;
            }
        }

        #endregion

    }
}