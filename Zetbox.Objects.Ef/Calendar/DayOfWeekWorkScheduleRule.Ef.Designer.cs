// <autogenerated/>

namespace Zetbox.App.Calendar
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

    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Zetbox.API.Server;
    using Zetbox.DalProvider.Ef;

    /// <summary>
    /// This rule applies every day of week
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="DayOfWeekWorkScheduleRuleEfImpl")]
    [System.Diagnostics.DebuggerDisplay("DayOfWeekWorkScheduleRule")]
    public class DayOfWeekWorkScheduleRuleEfImpl : Zetbox.App.Calendar.WorkScheduleRuleEfImpl, DayOfWeekWorkScheduleRule
    {
        private static readonly Guid _objectClassID = new Guid("9654967e-0182-409b-8765-65882785f607");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public DayOfWeekWorkScheduleRuleEfImpl()
            : base(null)
        {
        }

        public DayOfWeekWorkScheduleRuleEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // enumeration property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingEnumProperty
        public Zetbox.App.Base.DayOfWeek DayOfWeek
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _DayOfWeek;
                if (OnDayOfWeek_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<Zetbox.App.Base.DayOfWeek>(__result);
                    OnDayOfWeek_Getter(this, __e);
                    __result = _DayOfWeek = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_DayOfWeek != value)
                {
                    var __oldValue = _DayOfWeek;
                    var __newValue = value;
                    if (OnDayOfWeek_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<Zetbox.App.Base.DayOfWeek>(__oldValue, __newValue);
                        OnDayOfWeek_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("DayOfWeek", __oldValue, __newValue);
                    _DayOfWeek = __newValue;
                    NotifyPropertyChanged("DayOfWeek", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnDayOfWeek_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<Zetbox.App.Base.DayOfWeek>(__oldValue, __newValue);
                        OnDayOfWeek_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("DayOfWeek");
                }
            }
        }
        private Zetbox.App.Base.DayOfWeek _DayOfWeek_store;
        private Zetbox.App.Base.DayOfWeek _DayOfWeek {
            get { return _DayOfWeek_store; }
            set {
                ReportEfPropertyChanging("DayOfWeekImpl");
                _DayOfWeek_store = value;
                ReportEfPropertyChanged("DayOfWeekImpl");
            }
        }

        /// <summary>EF sees only this property, for DayOfWeek</summary>
        [XmlIgnore()]
        [EdmScalarProperty()]
        public int DayOfWeekImpl
        {
            get
            {
                return (int)this.DayOfWeek;
            }
            set
            {
                this.DayOfWeek = (Zetbox.App.Base.DayOfWeek)value;
            }
        }
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingEnumProperty
		public static event PropertyGetterHandler<Zetbox.App.Calendar.DayOfWeekWorkScheduleRule, Zetbox.App.Base.DayOfWeek> OnDayOfWeek_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Calendar.DayOfWeekWorkScheduleRule, Zetbox.App.Base.DayOfWeek> OnDayOfWeek_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Calendar.DayOfWeekWorkScheduleRule, Zetbox.App.Base.DayOfWeek> OnDayOfWeek_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Calendar.DayOfWeekWorkScheduleRule> OnDayOfWeek_IsValid;

        /// <summary>
        /// Checks if the Rule applies to the given date
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnAppliesTo_DayOfWeekWorkScheduleRule")]
        public override bool AppliesTo(DateTime date)
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnAppliesTo_DayOfWeekWorkScheduleRule != null)
            {
                OnAppliesTo_DayOfWeekWorkScheduleRule(this, e, date);
            }
            else
            {
                e.Result = base.AppliesTo(date);
            }
            return e.Result;
        }
        public static event AppliesTo_Handler<DayOfWeekWorkScheduleRule> OnAppliesTo_DayOfWeekWorkScheduleRule;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<DayOfWeekWorkScheduleRule> OnAppliesTo_DayOfWeekWorkScheduleRule_CanExec;

        [EventBasedMethod("OnAppliesTo_DayOfWeekWorkScheduleRule_CanExec")]
        public override bool AppliesToCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnAppliesTo_DayOfWeekWorkScheduleRule_CanExec != null)
				{
					OnAppliesTo_DayOfWeekWorkScheduleRule_CanExec(this, e);
				}
				else
				{
					e.Result = base.AppliesToCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<DayOfWeekWorkScheduleRule> OnAppliesTo_DayOfWeekWorkScheduleRule_CanExecReason;

        [EventBasedMethod("OnAppliesTo_DayOfWeekWorkScheduleRule_CanExecReason")]
        public override string AppliesToCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnAppliesTo_DayOfWeekWorkScheduleRule_CanExecReason != null)
				{
					OnAppliesTo_DayOfWeekWorkScheduleRule_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.AppliesToCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(DayOfWeekWorkScheduleRule);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (DayOfWeekWorkScheduleRule)obj;
            var otherImpl = (DayOfWeekWorkScheduleRuleEfImpl)obj;
            var me = (DayOfWeekWorkScheduleRule)this;

            me.DayOfWeek = other.DayOfWeek;
        }
        public override void SetNew()
        {
            base.SetNew();
        }
        #region Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "DayOfWeek":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }
        #endregion // Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

        public override Zetbox.API.Async.ZbTask TriggerFetch(string propName)
        {
            switch(propName)
            {
            default:
                return base.TriggerFetch(propName);
            }
        }

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references
            // fix cached lists references
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
                    new PropertyDescriptorEfImpl<DayOfWeekWorkScheduleRule, Zetbox.App.Base.DayOfWeek>(
                        lazyCtx,
                        new Guid("8755ff98-63d1-4a74-b0e3-da08a81f7f4e"),
                        "DayOfWeek",
                        null,
                        obj => obj.DayOfWeek,
                        (obj, val) => obj.DayOfWeek = val,
						obj => OnDayOfWeek_IsValid), 
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
        #region Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_DayOfWeekWorkScheduleRule")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DayOfWeekWorkScheduleRule != null)
            {
                OnToString_DayOfWeekWorkScheduleRule(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<DayOfWeekWorkScheduleRule> OnToString_DayOfWeekWorkScheduleRule;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_DayOfWeekWorkScheduleRule")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_DayOfWeekWorkScheduleRule != null)
            {
                OnObjectIsValid_DayOfWeekWorkScheduleRule(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<DayOfWeekWorkScheduleRule> OnObjectIsValid_DayOfWeekWorkScheduleRule;

        [EventBasedMethod("OnNotifyPreSave_DayOfWeekWorkScheduleRule")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_DayOfWeekWorkScheduleRule != null) OnNotifyPreSave_DayOfWeekWorkScheduleRule(this);
        }
        public static event ObjectEventHandler<DayOfWeekWorkScheduleRule> OnNotifyPreSave_DayOfWeekWorkScheduleRule;

        [EventBasedMethod("OnNotifyPostSave_DayOfWeekWorkScheduleRule")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_DayOfWeekWorkScheduleRule != null) OnNotifyPostSave_DayOfWeekWorkScheduleRule(this);
        }
        public static event ObjectEventHandler<DayOfWeekWorkScheduleRule> OnNotifyPostSave_DayOfWeekWorkScheduleRule;

        [EventBasedMethod("OnNotifyCreated_DayOfWeekWorkScheduleRule")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("DayOfWeek");
            base.NotifyCreated();
            if (OnNotifyCreated_DayOfWeekWorkScheduleRule != null) OnNotifyCreated_DayOfWeekWorkScheduleRule(this);
        }
        public static event ObjectEventHandler<DayOfWeekWorkScheduleRule> OnNotifyCreated_DayOfWeekWorkScheduleRule;

        [EventBasedMethod("OnNotifyDeleting_DayOfWeekWorkScheduleRule")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_DayOfWeekWorkScheduleRule != null) OnNotifyDeleting_DayOfWeekWorkScheduleRule(this);
        }
        public static event ObjectEventHandler<DayOfWeekWorkScheduleRule> OnNotifyDeleting_DayOfWeekWorkScheduleRule;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write((int?)_DayOfWeek);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            _DayOfWeek = (Zetbox.App.Base.DayOfWeek)binStream.ReadNullableInt32();
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
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Calendar")) XmlStreamer.ToStream((int?)_DayOfWeek, xml, "DayOfWeek", "Zetbox.App.Calendar");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Calendar|DayOfWeek":
                _DayOfWeek = (Zetbox.App.Base.DayOfWeek)XmlStreamer.ReadNullableInt32(xml);
               break;
            }
        }

        #endregion

    }
}