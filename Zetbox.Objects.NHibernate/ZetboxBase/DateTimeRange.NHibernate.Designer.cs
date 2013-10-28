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
    /// A from and until DateTime Value
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("DateTimeRange")]
    public class DateTimeRangeNHibernateImpl : CompoundObjectDefaultImpl, DateTimeRange, ICompoundObject
    {
        private static readonly Guid _compoundObjectID = new Guid("0a5419ae-2acf-4c4e-b998-6fcb25dc5650");
        public override Guid CompoundObjectID { get { return _compoundObjectID; } }

        // used by NHibernate
        public DateTimeRangeNHibernateImpl()
            : this(null, null, null, null)
        {
        }

        // used by CreateUnattachedInstance
        public DateTimeRangeNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(null, null, lazyCtx, null)
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public DateTimeRangeNHibernateImpl(IPersistenceObject parent, string property, Func<IFrozenContext> lazyCtx, DateTimeRangeProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
            AttachToObject(parent, property);
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly DateTimeRangeProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public DateTime? From
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _From;
                if (OnFrom_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime?>(__result);
                    OnFrom_Getter(this, __e);
                    __result = _From = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_From != value)
                {
                    var __oldValue = _From;
                    var __newValue = value;
                    if (__newValue.HasValue && __newValue.Value.Kind == DateTimeKind.Unspecified)
                        __newValue = DateTime.SpecifyKind(__newValue.Value, DateTimeKind.Local);
                    if (OnFrom_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnFrom_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("From", __oldValue, __newValue);
                    _From = __newValue;
                    NotifyPropertyChanged("From", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnFrom_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnFrom_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("From");
                }
            }
        }
        private DateTime? _From;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.DateTimeRange, DateTime?> OnFrom_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.DateTimeRange, DateTime?> OnFrom_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.DateTimeRange, DateTime?> OnFrom_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public DateTime? Thru
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Thru;
                if (OnThru_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime?>(__result);
                    OnThru_Getter(this, __e);
                    __result = _Thru = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Thru != value)
                {
                    var __oldValue = _Thru;
                    var __newValue = value;
                    if (__newValue.HasValue && __newValue.Value.Kind == DateTimeKind.Unspecified)
                        __newValue = DateTime.SpecifyKind(__newValue.Value, DateTimeKind.Local);
                    if (OnThru_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnThru_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Thru", __oldValue, __newValue);
                    _Thru = __newValue;
                    NotifyPropertyChanged("Thru", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnThru_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnThru_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("Thru");
                }
            }
        }
        private DateTime? _Thru;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.DateTimeRange, DateTime?> OnThru_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.DateTimeRange, DateTime?> OnThru_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.DateTimeRange, DateTime?> OnThru_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public int? TotalDays
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _TotalDays;
                if (_TotalDays_IsDirty && OnTotalDays_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int?>(__result);
                    OnTotalDays_Getter(this, __e);
                    _TotalDays_IsDirty = false;
                    __result = _TotalDays = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_TotalDays != value)
                {
                    var __oldValue = _TotalDays;
                    var __newValue = value;
                    NotifyPropertyChanging("TotalDays", __oldValue, __newValue);
                    _TotalDays = __newValue;
                    NotifyPropertyChanged("TotalDays", __oldValue, __newValue);
                    _TotalDays_IsDirty = false;

                }
                else
                {
                    SetInitializedProperty("TotalDays");
                }
            }
        }
        private int? _TotalDays;
        private bool _TotalDays_IsDirty = false;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.DateTimeRange, int?> OnTotalDays_Getter;

        public override Type GetImplementedInterface()
        {
            return typeof(DateTimeRange);
        }

        public override void ApplyChangesFrom(ICompoundObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (DateTimeRange)obj;
            var otherImpl = (DateTimeRangeNHibernateImpl)obj;
            var me = (DateTimeRange)this;

            me.From = other.From;
            me.Thru = other.Thru;
        }
        #region Zetbox.Generator.Templates.CompoundObjects.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_DateTimeRange")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DateTimeRange != null)
            {
                OnToString_DateTimeRange(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<DateTimeRange> OnToString_DateTimeRange;

		[System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_DateTimeRange")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
			var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
			e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_DateTimeRange != null)
            {
                OnObjectIsValid_DateTimeRange(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<DateTimeRange> OnObjectIsValid_DateTimeRange;

        #endregion // Zetbox.Generator.Templates.CompoundObjects.DefaultMethods
public class DateTimeRangeProxy { }

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._From);
            binStream.Write(this._Thru);
            binStream.Write(this._TotalDays);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._From = binStream.ReadNullableDateTime();
            this._Thru = binStream.ReadNullableDateTime();
            this._TotalDays = binStream.ReadNullableInt32();
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
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this._From, xml, "From", "Zetbox.App.Base");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this._Thru, xml, "Thru", "Zetbox.App.Base");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this._TotalDays, xml, "TotalDays", "Zetbox.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Base|From":
                this._From = XmlStreamer.ReadNullableDateTime(xml);
                break;
            case "Zetbox.App.Base|Thru":
                this._Thru = XmlStreamer.ReadNullableDateTime(xml);
                break;
            case "Zetbox.App.Base|TotalDays":
                this._TotalDays = XmlStreamer.ReadNullableInt32(xml);
                break;
            }
        }

        #endregion

    }
}