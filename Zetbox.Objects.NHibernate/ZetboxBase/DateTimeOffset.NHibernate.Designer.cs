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
    /// Offset from a DateTime expressed in years, months, days, etc.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("DateTimeOffset")]
    public class DateTimeOffsetNHibernateImpl : CompoundObjectDefaultImpl, DateTimeOffset, ICompoundObject
    {
        private static readonly Guid _compoundObjectID = new Guid("e6a78df4-b331-4db2-8553-afaa3af76ce2");
        public override Guid CompoundObjectID { get { return _compoundObjectID; } }

        // used by NHibernate
        public DateTimeOffsetNHibernateImpl()
            : this(null, null, null, null)
        {
        }

        // used by CreateUnattachedInstance
        public DateTimeOffsetNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(null, null, lazyCtx, null)
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public DateTimeOffsetNHibernateImpl(IPersistenceObject parent, string property, Func<IFrozenContext> lazyCtx, DateTimeOffsetProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
            AttachToObject(parent, property);
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly DateTimeOffsetProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public double? Days
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Days;
                if (OnDays_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<double?>(__result);
                    OnDays_Getter(this, __e);
                    __result = _Days = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Days != value)
                {
                    var __oldValue = _Days;
                    var __newValue = value;
                    if (OnDays_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<double?>(__oldValue, __newValue);
                        OnDays_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Days", __oldValue, __newValue);
                    _Days = __newValue;
                    NotifyPropertyChanged("Days", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnDays_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<double?>(__oldValue, __newValue);
                        OnDays_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("Days");
                }
            }
        }
        private double? _Days;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.DateTimeOffset, double?> OnDays_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.DateTimeOffset, double?> OnDays_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.DateTimeOffset, double?> OnDays_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public double? Hours
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Hours;
                if (OnHours_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<double?>(__result);
                    OnHours_Getter(this, __e);
                    __result = _Hours = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Hours != value)
                {
                    var __oldValue = _Hours;
                    var __newValue = value;
                    if (OnHours_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<double?>(__oldValue, __newValue);
                        OnHours_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Hours", __oldValue, __newValue);
                    _Hours = __newValue;
                    NotifyPropertyChanged("Hours", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnHours_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<double?>(__oldValue, __newValue);
                        OnHours_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("Hours");
                }
            }
        }
        private double? _Hours;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.DateTimeOffset, double?> OnHours_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.DateTimeOffset, double?> OnHours_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.DateTimeOffset, double?> OnHours_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public double? Minutes
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Minutes;
                if (OnMinutes_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<double?>(__result);
                    OnMinutes_Getter(this, __e);
                    __result = _Minutes = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Minutes != value)
                {
                    var __oldValue = _Minutes;
                    var __newValue = value;
                    if (OnMinutes_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<double?>(__oldValue, __newValue);
                        OnMinutes_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Minutes", __oldValue, __newValue);
                    _Minutes = __newValue;
                    NotifyPropertyChanged("Minutes", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnMinutes_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<double?>(__oldValue, __newValue);
                        OnMinutes_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("Minutes");
                }
            }
        }
        private double? _Minutes;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.DateTimeOffset, double?> OnMinutes_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.DateTimeOffset, double?> OnMinutes_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.DateTimeOffset, double?> OnMinutes_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public int? Months
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Months;
                if (OnMonths_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int?>(__result);
                    OnMonths_Getter(this, __e);
                    __result = _Months = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Months != value)
                {
                    var __oldValue = _Months;
                    var __newValue = value;
                    if (OnMonths_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int?>(__oldValue, __newValue);
                        OnMonths_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Months", __oldValue, __newValue);
                    _Months = __newValue;
                    NotifyPropertyChanged("Months", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnMonths_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int?>(__oldValue, __newValue);
                        OnMonths_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("Months");
                }
            }
        }
        private int? _Months;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.DateTimeOffset, int?> OnMonths_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.DateTimeOffset, int?> OnMonths_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.DateTimeOffset, int?> OnMonths_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public double? Seconds
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Seconds;
                if (OnSeconds_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<double?>(__result);
                    OnSeconds_Getter(this, __e);
                    __result = _Seconds = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Seconds != value)
                {
                    var __oldValue = _Seconds;
                    var __newValue = value;
                    if (OnSeconds_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<double?>(__oldValue, __newValue);
                        OnSeconds_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Seconds", __oldValue, __newValue);
                    _Seconds = __newValue;
                    NotifyPropertyChanged("Seconds", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnSeconds_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<double?>(__oldValue, __newValue);
                        OnSeconds_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("Seconds");
                }
            }
        }
        private double? _Seconds;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.DateTimeOffset, double?> OnSeconds_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.DateTimeOffset, double?> OnSeconds_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.DateTimeOffset, double?> OnSeconds_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public int? Years
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Years;
                if (OnYears_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int?>(__result);
                    OnYears_Getter(this, __e);
                    __result = _Years = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Years != value)
                {
                    var __oldValue = _Years;
                    var __newValue = value;
                    if (OnYears_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int?>(__oldValue, __newValue);
                        OnYears_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Years", __oldValue, __newValue);
                    _Years = __newValue;
                    NotifyPropertyChanged("Years", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnYears_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int?>(__oldValue, __newValue);
                        OnYears_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("Years");
                }
            }
        }
        private int? _Years;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.DateTimeOffset, int?> OnYears_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.DateTimeOffset, int?> OnYears_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.DateTimeOffset, int?> OnYears_PostSetter;

        /// <summary>
        /// Adds the actual offset to a given DateTime
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnAddTo_DateTimeOffset")]
        public virtual DateTime AddTo(DateTime dt)
        {
            var e = new MethodReturnEventArgs<DateTime>();
            if (OnAddTo_DateTimeOffset != null)
            {
                OnAddTo_DateTimeOffset(this, e, dt);
            }
            else
            {
                throw new NotImplementedException("No handler registered on DateTimeOffset.AddTo");
            }
            return e.Result;
        }
        public delegate void AddTo_Handler<T>(T obj, MethodReturnEventArgs<DateTime> ret, DateTime dt);
        public static event AddTo_Handler<DateTimeOffset> OnAddTo_DateTimeOffset;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<DateTimeOffset> OnAddTo_DateTimeOffset_CanExec;

        [EventBasedMethod("OnAddTo_DateTimeOffset_CanExec")]
        public virtual bool AddToCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnAddTo_DateTimeOffset_CanExec != null)
				{
					OnAddTo_DateTimeOffset_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<DateTimeOffset> OnAddTo_DateTimeOffset_CanExecReason;

        [EventBasedMethod("OnAddTo_DateTimeOffset_CanExecReason")]
        public virtual string AddToCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnAddTo_DateTimeOffset_CanExecReason != null)
				{
					OnAddTo_DateTimeOffset_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(DateTimeOffset);
        }

        public override void ApplyChangesFrom(ICompoundObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (DateTimeOffset)obj;
            var otherImpl = (DateTimeOffsetNHibernateImpl)obj;
            var me = (DateTimeOffset)this;

            me.Days = other.Days;
            me.Hours = other.Hours;
            me.Minutes = other.Minutes;
            me.Months = other.Months;
            me.Seconds = other.Seconds;
            me.Years = other.Years;
        }
        #region Zetbox.Generator.Templates.CompoundObjects.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_DateTimeOffset")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DateTimeOffset != null)
            {
                OnToString_DateTimeOffset(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<DateTimeOffset> OnToString_DateTimeOffset;

		[System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_DateTimeOffset")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
			var b = base.ObjectIsValid();
			e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_DateTimeOffset != null)
            {
                OnObjectIsValid_DateTimeOffset(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<DateTimeOffset> OnObjectIsValid_DateTimeOffset;

        #endregion // Zetbox.Generator.Templates.CompoundObjects.DefaultMethods
public class DateTimeOffsetProxy { }

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._Days);
            binStream.Write(this._Hours);
            binStream.Write(this._Minutes);
            binStream.Write(this._Months);
            binStream.Write(this._Seconds);
            binStream.Write(this._Years);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._Days = binStream.ReadNullableDouble();
            this._Hours = binStream.ReadNullableDouble();
            this._Minutes = binStream.ReadNullableDouble();
            this._Months = binStream.ReadNullableInt32();
            this._Seconds = binStream.ReadNullableDouble();
            this._Years = binStream.ReadNullableInt32();
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
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this._Days, xml, "Days", "Zetbox.App.Base");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this._Hours, xml, "Hours", "Zetbox.App.Base");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this._Minutes, xml, "Minutes", "Zetbox.App.Base");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this._Months, xml, "Months", "Zetbox.App.Base");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this._Seconds, xml, "Seconds", "Zetbox.App.Base");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this._Years, xml, "Years", "Zetbox.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Base|Days":
                this._Days = XmlStreamer.ReadNullableDouble(xml);
                break;
            case "Zetbox.App.Base|Hours":
                this._Hours = XmlStreamer.ReadNullableDouble(xml);
                break;
            case "Zetbox.App.Base|Minutes":
                this._Minutes = XmlStreamer.ReadNullableDouble(xml);
                break;
            case "Zetbox.App.Base|Months":
                this._Months = XmlStreamer.ReadNullableInt32(xml);
                break;
            case "Zetbox.App.Base|Seconds":
                this._Seconds = XmlStreamer.ReadNullableDouble(xml);
                break;
            case "Zetbox.App.Base|Years":
                this._Years = XmlStreamer.ReadNullableInt32(xml);
                break;
            }
        }

        #endregion

    }
}