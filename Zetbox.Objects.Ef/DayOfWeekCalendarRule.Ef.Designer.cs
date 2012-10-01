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
    [EdmEntityType(NamespaceName="Model", Name="DayOfWeekCalendarRule")]
    [System.Diagnostics.DebuggerDisplay("DayOfWeekCalendarRule")]
    public class DayOfWeekCalendarRuleEfImpl : Zetbox.App.Calendar.CalendarRuleEfImpl, DayOfWeekCalendarRule
    {
        private static readonly Guid _objectClassID = new Guid("9654967e-0182-409b-8765-65882785f607");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public DayOfWeekCalendarRuleEfImpl()
            : base(null)
        {
        }

        public DayOfWeekCalendarRuleEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // enumeration property
   		// Zetbox.DalProvider.Ef.Generator.Templates.Properties.EnumerationPropertyTemplate
        // implement the user-visible interface
        public Zetbox.App.Base.DayOfWeek DayOfWeek
        {
            get
            {
				var __value = _DayOfWeek;
				if(OnDayOfWeek_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Zetbox.App.Base.DayOfWeek>(__value);
					OnDayOfWeek_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_DayOfWeek != value)
                {
					var __oldValue = _DayOfWeek;
					var __newValue = value;
                    if(OnDayOfWeek_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<Zetbox.App.Base.DayOfWeek>(__oldValue, __newValue);
						OnDayOfWeek_PreSetter(this, e);
						__newValue = e.Result;
                    }
					
                    NotifyPropertyChanging("DayOfWeek", __oldValue, __newValue);
                    _DayOfWeek = value;
                    NotifyPropertyChanged("DayOfWeek", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;
                    if(OnDayOfWeek_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<Zetbox.App.Base.DayOfWeek>(__oldValue, __newValue);
						OnDayOfWeek_PostSetter(this, e);
                    }
                    
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
        
		public static event PropertyGetterHandler<Zetbox.App.Calendar.DayOfWeekCalendarRule, Zetbox.App.Base.DayOfWeek> OnDayOfWeek_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Calendar.DayOfWeekCalendarRule, Zetbox.App.Base.DayOfWeek> OnDayOfWeek_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Calendar.DayOfWeekCalendarRule, Zetbox.App.Base.DayOfWeek> OnDayOfWeek_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Calendar.DayOfWeekCalendarRule> OnDayOfWeek_IsValid;

        /// <summary>
        /// Checks if the Rule applies to the given date
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnAppliesTo_DayOfWeekCalendarRule")]
        public override bool AppliesTo(DateTime date)
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnAppliesTo_DayOfWeekCalendarRule != null)
            {
                OnAppliesTo_DayOfWeekCalendarRule(this, e, date);
            }
            else
            {
                e.Result = base.AppliesTo(date);
            }
            return e.Result;
        }
        public static event AppliesTo_Handler<DayOfWeekCalendarRule> OnAppliesTo_DayOfWeekCalendarRule;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<DayOfWeekCalendarRule> OnAppliesTo_DayOfWeekCalendarRule_CanExec;

        [EventBasedMethod("OnAppliesTo_DayOfWeekCalendarRule_CanExec")]
        public override bool AppliesToCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnAppliesTo_DayOfWeekCalendarRule_CanExec != null)
				{
					OnAppliesTo_DayOfWeekCalendarRule_CanExec(this, e);
				}
				else
				{
					e.Result = base.AppliesToCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<DayOfWeekCalendarRule> OnAppliesTo_DayOfWeekCalendarRule_CanExecReason;

        [EventBasedMethod("OnAppliesTo_DayOfWeekCalendarRule_CanExecReason")]
        public override string AppliesToCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnAppliesTo_DayOfWeekCalendarRule_CanExecReason != null)
				{
					OnAppliesTo_DayOfWeekCalendarRule_CanExecReason(this, e);
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
            return typeof(DayOfWeekCalendarRule);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (DayOfWeekCalendarRule)obj;
            var otherImpl = (DayOfWeekCalendarRuleEfImpl)obj;
            var me = (DayOfWeekCalendarRule)this;

            me.DayOfWeek = other.DayOfWeek;
        }

        public override void AttachToContext(IZetboxContext ctx, Func<IFrozenContext> lazyFrozenContext)
        {
            base.AttachToContext(ctx, lazyFrozenContext);
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
                    new PropertyDescriptorEfImpl<DayOfWeekCalendarRule, Zetbox.App.Base.DayOfWeek>(
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
        [EventBasedMethod("OnToString_DayOfWeekCalendarRule")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DayOfWeekCalendarRule != null)
            {
                OnToString_DayOfWeekCalendarRule(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<DayOfWeekCalendarRule> OnToString_DayOfWeekCalendarRule;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_DayOfWeekCalendarRule")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_DayOfWeekCalendarRule != null)
            {
                OnObjectIsValid_DayOfWeekCalendarRule(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<DayOfWeekCalendarRule> OnObjectIsValid_DayOfWeekCalendarRule;

        [EventBasedMethod("OnNotifyPreSave_DayOfWeekCalendarRule")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_DayOfWeekCalendarRule != null) OnNotifyPreSave_DayOfWeekCalendarRule(this);
        }
        public static event ObjectEventHandler<DayOfWeekCalendarRule> OnNotifyPreSave_DayOfWeekCalendarRule;

        [EventBasedMethod("OnNotifyPostSave_DayOfWeekCalendarRule")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_DayOfWeekCalendarRule != null) OnNotifyPostSave_DayOfWeekCalendarRule(this);
        }
        public static event ObjectEventHandler<DayOfWeekCalendarRule> OnNotifyPostSave_DayOfWeekCalendarRule;

        [EventBasedMethod("OnNotifyCreated_DayOfWeekCalendarRule")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("DayOfWeek");
            base.NotifyCreated();
            if (OnNotifyCreated_DayOfWeekCalendarRule != null) OnNotifyCreated_DayOfWeekCalendarRule(this);
        }
        public static event ObjectEventHandler<DayOfWeekCalendarRule> OnNotifyCreated_DayOfWeekCalendarRule;

        [EventBasedMethod("OnNotifyDeleting_DayOfWeekCalendarRule")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_DayOfWeekCalendarRule != null) OnNotifyDeleting_DayOfWeekCalendarRule(this);
        }
        public static event ObjectEventHandler<DayOfWeekCalendarRule> OnNotifyDeleting_DayOfWeekCalendarRule;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write((int?)((Zetbox.App.Calendar.DayOfWeekCalendarRule)this).DayOfWeek);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            ((Zetbox.App.Calendar.DayOfWeekCalendarRule)this).DayOfWeek = (Zetbox.App.Base.DayOfWeek)binStream.ReadNullableInt32();
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
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Calendar")) XmlStreamer.ToStream((int?)((Zetbox.App.Calendar.DayOfWeekCalendarRule)this).DayOfWeek, xml, "DayOfWeek", "Zetbox.App.Calendar");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Calendar|DayOfWeek":
                ((Zetbox.App.Calendar.DayOfWeekCalendarRule)this).DayOfWeek = (Zetbox.App.Base.DayOfWeek)XmlStreamer.ReadNullableInt32(xml);
               break;
            }
        }

        #endregion

    }
}