// <autogenerated/>

namespace Kistl.App.GUI
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

    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.Memory;

    /// <summary>
    /// Filter configuration for filtering on an instance with an user selectable, optional and constant predicate
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("OptionalPredicateFilterConfiguration")]
    public class OptionalPredicateFilterConfigurationMemoryImpl : Kistl.App.GUI.ObjectClassFilterConfigurationMemoryImpl, OptionalPredicateFilterConfiguration
    {
        private static readonly Guid _objectClassID = new Guid("da69f553-1096-48be-8129-eff9118498f0");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public OptionalPredicateFilterConfigurationMemoryImpl()
            : base(null)
        {
        }

        public OptionalPredicateFilterConfigurationMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public string Predicate
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Predicate;
                if (OnPredicate_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnPredicate_Getter(this, __e);
                    __result = _Predicate = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Predicate != value)
                {
                    var __oldValue = _Predicate;
                    var __newValue = value;
                    if (OnPredicate_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnPredicate_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Predicate", __oldValue, __newValue);
                    _Predicate = __newValue;
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
        private string _Predicate;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.GUI.OptionalPredicateFilterConfiguration, string> OnPredicate_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.OptionalPredicateFilterConfiguration, string> OnPredicate_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.OptionalPredicateFilterConfiguration, string> OnPredicate_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.GUI.OptionalPredicateFilterConfiguration> OnPredicate_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnCreateFilterModel_OptionalPredicateFilterConfiguration")]
        public override Kistl.API.IFilterModel CreateFilterModel()
        {
            var e = new MethodReturnEventArgs<Kistl.API.IFilterModel>();
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
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
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
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
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
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
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
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(OptionalPredicateFilterConfiguration);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (OptionalPredicateFilterConfiguration)obj;
            var otherImpl = (OptionalPredicateFilterConfigurationMemoryImpl)obj;
            var me = (OptionalPredicateFilterConfiguration)this;

            me.Predicate = other.Predicate;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }

        #region Kistl.Generator.Templates.ObjectClasses.OnPropertyChange

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

        #endregion // Kistl.Generator.Templates.ObjectClasses.OnPropertyChange

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references
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
                    new PropertyDescriptorMemoryImpl<OptionalPredicateFilterConfiguration, string>(
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
        #endregion // Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Kistl.Generator.Templates.ObjectClasses.DefaultMethods

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

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this._Predicate, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._Predicate, binStream);
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
            XmlStreamer.ToStream(this._Predicate, xml, "Predicate", "Kistl.App.GUI");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._Predicate, xml, "Predicate", "Kistl.App.GUI");
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
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this._Predicate, xml, "Predicate", "Kistl.App.GUI");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.FromStream(ref this._Predicate, xml, "Predicate", "Kistl.App.GUI");
        }

        #endregion

    }
}