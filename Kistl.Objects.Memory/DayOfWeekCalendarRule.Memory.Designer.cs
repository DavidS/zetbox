// <autogenerated/>

namespace Kistl.App.Calendar
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
    /// This rule applies every day of week
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("DayOfWeekCalendarRule")]
    public class DayOfWeekCalendarRuleMemoryImpl : Kistl.App.Calendar.CalendarRuleMemoryImpl, DayOfWeekCalendarRule
    {
        [Obsolete]
        public DayOfWeekCalendarRuleMemoryImpl()
            : base(null)
        {
        }

        public DayOfWeekCalendarRuleMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // enumeration property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public Kistl.App.Base.DayOfWeek DayOfWeek
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return default(Kistl.App.Base.DayOfWeek);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _DayOfWeek;
                if (OnDayOfWeek_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<Kistl.App.Base.DayOfWeek>(__result);
                    OnDayOfWeek_Getter(this, __e);
                    __result = __e.Result;
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
                        var __e = new PropertyPreSetterEventArgs<Kistl.App.Base.DayOfWeek>(__oldValue, __newValue);
                        OnDayOfWeek_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("DayOfWeek", __oldValue, __newValue);
                    _DayOfWeek = __newValue;
                    NotifyPropertyChanged("DayOfWeek", __oldValue, __newValue);
                    if (OnDayOfWeek_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<Kistl.App.Base.DayOfWeek>(__oldValue, __newValue);
                        OnDayOfWeek_PostSetter(this, __e);
                    }
                }
            }
        }
        private Kistl.App.Base.DayOfWeek _DayOfWeek;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Calendar.DayOfWeekCalendarRule, Kistl.App.Base.DayOfWeek> OnDayOfWeek_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Calendar.DayOfWeekCalendarRule, Kistl.App.Base.DayOfWeek> OnDayOfWeek_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Calendar.DayOfWeekCalendarRule, Kistl.App.Base.DayOfWeek> OnDayOfWeek_PostSetter;

        /// <summary>
        /// Checks if the Rule applies to the given date
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnAppliesTo_DayOfWeekCalendarRule")]
        public override bool AppliesTo(System.DateTime date)
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
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(DayOfWeekCalendarRule);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (DayOfWeekCalendarRule)obj;
            var otherImpl = (DayOfWeekCalendarRuleMemoryImpl)obj;
            var me = (DayOfWeekCalendarRule)this;

            me.DayOfWeek = other.DayOfWeek;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }


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
                    new PropertyDescriptorMemoryImpl<DayOfWeekCalendarRuleMemoryImpl, Kistl.App.Base.DayOfWeek>(
                        lazyCtx,
                        new Guid("8755ff98-63d1-4a74-b0e3-da08a81f7f4e"),
                        "DayOfWeek",
                        null,
                        obj => obj.DayOfWeek,
                        (obj, val) => obj.DayOfWeek = val),
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

        [EventBasedMethod("OnPreSave_DayOfWeekCalendarRule")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DayOfWeekCalendarRule != null) OnPreSave_DayOfWeekCalendarRule(this);
        }
        public static event ObjectEventHandler<DayOfWeekCalendarRule> OnPreSave_DayOfWeekCalendarRule;

        [EventBasedMethod("OnPostSave_DayOfWeekCalendarRule")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DayOfWeekCalendarRule != null) OnPostSave_DayOfWeekCalendarRule(this);
        }
        public static event ObjectEventHandler<DayOfWeekCalendarRule> OnPostSave_DayOfWeekCalendarRule;

        [EventBasedMethod("OnCreated_DayOfWeekCalendarRule")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_DayOfWeekCalendarRule != null) OnCreated_DayOfWeekCalendarRule(this);
        }
        public static event ObjectEventHandler<DayOfWeekCalendarRule> OnCreated_DayOfWeekCalendarRule;

        [EventBasedMethod("OnDeleting_DayOfWeekCalendarRule")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_DayOfWeekCalendarRule != null) OnDeleting_DayOfWeekCalendarRule(this);
        }
        public static event ObjectEventHandler<DayOfWeekCalendarRule> OnDeleting_DayOfWeekCalendarRule;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream((int?)((Kistl.App.Calendar.DayOfWeekCalendarRule)this).DayOfWeek, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            {
                int? baseValue;
                BinarySerializer.FromStream(out baseValue, binStream);
                ((Kistl.App.Calendar.DayOfWeekCalendarRule)this).DayOfWeek = (Kistl.App.Base.DayOfWeek)baseValue;
            }
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            XmlStreamer.ToStream((int?)((Kistl.App.Calendar.DayOfWeekCalendarRule)this).DayOfWeek, xml, "DayOfWeek", "Kistl.App.Calendar");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            XmlStreamer.FromStreamConverter(v => ((Kistl.App.Calendar.DayOfWeekCalendarRule)this).DayOfWeek = (Kistl.App.Base.DayOfWeek)v, xml, "DayOfWeek", "Kistl.App.Calendar");
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            if (modules.Contains("*") || modules.Contains("Kistl.App.Calendar")) XmlStreamer.ToStream((int?)((Kistl.App.Calendar.DayOfWeekCalendarRule)this).DayOfWeek, xml, "DayOfWeek", "Kistl.App.Calendar");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            XmlStreamer.FromStreamConverter(v => ((Kistl.App.Calendar.DayOfWeekCalendarRule)this).DayOfWeek = (Kistl.App.Base.DayOfWeek)v, xml, "DayOfWeek", "Kistl.App.Calendar");
        }

        #endregion

    }
}