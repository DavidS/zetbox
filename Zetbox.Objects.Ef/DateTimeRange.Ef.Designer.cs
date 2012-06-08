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

    using Zetbox.API.Server;
    using Zetbox.DalProvider.Ef;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// A from and until DateTime Value
    /// </summary>
    [EdmComplexType(NamespaceName="Model", Name="DateTimeRange")]
    [System.Diagnostics.DebuggerDisplay("DateTimeRange")]
    public class DateTimeRangeEfImpl : BaseServerCompoundObject_EntityFramework, DateTimeRange, ICompoundObject
    {
        private static readonly Guid _compoundObjectID = new Guid("0a5419ae-2acf-4c4e-b998-6fcb25dc5650");
        public override Guid CompoundObjectID { get { return _compoundObjectID; } }

        public DateTimeRangeEfImpl()
            : base(null) // TODO: pass parent's lazyCtx
        {
            CompoundObject_IsNull = false;

        }
        public DateTimeRangeEfImpl(bool isNull, IPersistenceObject parent, string property)
            : base(null) // TODO: pass parent's lazyCtx
        {
            AttachToObject(parent, property);
            CompoundObject_IsNull = isNull;
        }
        public DateTimeRangeEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
            CompoundObject_IsNull = false;

        }
        public DateTimeRangeEfImpl(Func<IFrozenContext> lazyCtx, bool isNull, IPersistenceObject parent, string property)
            : base(lazyCtx)
        {
            AttachToObject(parent, property);
            CompoundObject_IsNull = isNull;
        }
        [EdmScalarProperty(IsNullable = false)]
        public bool CompoundObject_IsNull { get; set; }

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public DateTime? From
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(DateTime?);
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
                    if (OnFrom_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnFrom_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("From", __oldValue, __newValue);
                    _From = __newValue;
                    NotifyPropertyChanged("From", __oldValue, __newValue);

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
        private DateTime? _From_store;
        private DateTime? _From {
            get { return _From_store; }
            set {
                ReportEfPropertyChanging("From");
                _From_store = value != null && value.Value.Kind == DateTimeKind.Unspecified ? (DateTime?)DateTime.SpecifyKind(value.Value, DateTimeKind.Local) : value;
                ReportEfPropertyChanged("From");
            }
        }
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.DateTimeRange, DateTime?> OnFrom_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.DateTimeRange, DateTime?> OnFrom_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.DateTimeRange, DateTime?> OnFrom_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public DateTime? Thru
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(DateTime?);
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
                    if (OnThru_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnThru_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Thru", __oldValue, __newValue);
                    _Thru = __newValue;
                    NotifyPropertyChanged("Thru", __oldValue, __newValue);

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
        private DateTime? _Thru_store;
        private DateTime? _Thru {
            get { return _Thru_store; }
            set {
                ReportEfPropertyChanging("Thru");
                _Thru_store = value != null && value.Value.Kind == DateTimeKind.Unspecified ? (DateTime?)DateTime.SpecifyKind(value.Value, DateTimeKind.Local) : value;
                ReportEfPropertyChanged("Thru");
            }
        }
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.DateTimeRange, DateTime?> OnThru_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.DateTimeRange, DateTime?> OnThru_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.DateTimeRange, DateTime?> OnThru_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public int? TotalDays
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(int?);
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
        private int? _TotalDays_store;
        private int? _TotalDays {
            get { return _TotalDays_store; }
            set {
                ReportEfPropertyChanging("TotalDays");
                _TotalDays_store = value;
                ReportEfPropertyChanged("TotalDays");
            }
        }
        private bool _TotalDays_IsDirty = false;
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.DateTimeRange, int?> OnTotalDays_Getter;

        public override Type GetImplementedInterface()
        {
            return typeof(DateTimeRange);
        }

        public override void ApplyChangesFrom(ICompoundObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (DateTimeRange)obj;
            var otherImpl = (DateTimeRangeEfImpl)obj;
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

        #endregion

    }
}