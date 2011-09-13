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
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("DateRangeFilterConfiguration")]
    public class DateRangeFilterConfigurationMemoryImpl : Kistl.App.GUI.PropertyFilterConfigurationMemoryImpl, DateRangeFilterConfiguration
    {
        [Obsolete]
        public DateRangeFilterConfigurationMemoryImpl()
            : base(null)
        {
        }

        public DateRangeFilterConfigurationMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public bool? IsCurrentMonthDefault
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return default(bool?);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _IsCurrentMonthDefault;
                if (OnIsCurrentMonthDefault_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool?>(__result);
                    OnIsCurrentMonthDefault_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_IsCurrentMonthDefault != value)
                {
                    var __oldValue = _IsCurrentMonthDefault;
                    var __newValue = value;
                    if (OnIsCurrentMonthDefault_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnIsCurrentMonthDefault_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IsCurrentMonthDefault", __oldValue, __newValue);
                    _IsCurrentMonthDefault = __newValue;
                    NotifyPropertyChanged("IsCurrentMonthDefault", __oldValue, __newValue);
                    if (OnIsCurrentMonthDefault_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnIsCurrentMonthDefault_PostSetter(this, __e);
                    }
                }
            }
        }
        private bool? _IsCurrentMonthDefault;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.GUI.DateRangeFilterConfiguration, bool?> OnIsCurrentMonthDefault_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.DateRangeFilterConfiguration, bool?> OnIsCurrentMonthDefault_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.DateRangeFilterConfiguration, bool?> OnIsCurrentMonthDefault_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public bool? IsCurrentQuaterDefault
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return default(bool?);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _IsCurrentQuaterDefault;
                if (OnIsCurrentQuaterDefault_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool?>(__result);
                    OnIsCurrentQuaterDefault_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_IsCurrentQuaterDefault != value)
                {
                    var __oldValue = _IsCurrentQuaterDefault;
                    var __newValue = value;
                    if (OnIsCurrentQuaterDefault_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnIsCurrentQuaterDefault_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IsCurrentQuaterDefault", __oldValue, __newValue);
                    _IsCurrentQuaterDefault = __newValue;
                    NotifyPropertyChanged("IsCurrentQuaterDefault", __oldValue, __newValue);
                    if (OnIsCurrentQuaterDefault_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnIsCurrentQuaterDefault_PostSetter(this, __e);
                    }
                }
            }
        }
        private bool? _IsCurrentQuaterDefault;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.GUI.DateRangeFilterConfiguration, bool?> OnIsCurrentQuaterDefault_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.DateRangeFilterConfiguration, bool?> OnIsCurrentQuaterDefault_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.DateRangeFilterConfiguration, bool?> OnIsCurrentQuaterDefault_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public bool? IsCurrentYearDefault
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return default(bool?);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _IsCurrentYearDefault;
                if (OnIsCurrentYearDefault_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool?>(__result);
                    OnIsCurrentYearDefault_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_IsCurrentYearDefault != value)
                {
                    var __oldValue = _IsCurrentYearDefault;
                    var __newValue = value;
                    if (OnIsCurrentYearDefault_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnIsCurrentYearDefault_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IsCurrentYearDefault", __oldValue, __newValue);
                    _IsCurrentYearDefault = __newValue;
                    NotifyPropertyChanged("IsCurrentYearDefault", __oldValue, __newValue);
                    if (OnIsCurrentYearDefault_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool?>(__oldValue, __newValue);
                        OnIsCurrentYearDefault_PostSetter(this, __e);
                    }
                }
            }
        }
        private bool? _IsCurrentYearDefault;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.GUI.DateRangeFilterConfiguration, bool?> OnIsCurrentYearDefault_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.GUI.DateRangeFilterConfiguration, bool?> OnIsCurrentYearDefault_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.GUI.DateRangeFilterConfiguration, bool?> OnIsCurrentYearDefault_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnCreateFilterModel_DateRangeFilterConfiguration")]
        public override Kistl.API.IFilterModel CreateFilterModel()
        {
            var e = new MethodReturnEventArgs<Kistl.API.IFilterModel>();
            if (OnCreateFilterModel_DateRangeFilterConfiguration != null)
            {
                OnCreateFilterModel_DateRangeFilterConfiguration(this, e);
            }
            else
            {
                e.Result = base.CreateFilterModel();
            }
            return e.Result;
        }
        public static event CreateFilterModel_Handler<DateRangeFilterConfiguration> OnCreateFilterModel_DateRangeFilterConfiguration;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_DateRangeFilterConfiguration")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_DateRangeFilterConfiguration != null)
            {
                OnGetLabel_DateRangeFilterConfiguration(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<DateRangeFilterConfiguration> OnGetLabel_DateRangeFilterConfiguration;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(DateRangeFilterConfiguration);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (DateRangeFilterConfiguration)obj;
            var otherImpl = (DateRangeFilterConfigurationMemoryImpl)obj;
            var me = (DateRangeFilterConfiguration)this;

            me.IsCurrentMonthDefault = other.IsCurrentMonthDefault;
            me.IsCurrentQuaterDefault = other.IsCurrentQuaterDefault;
            me.IsCurrentYearDefault = other.IsCurrentYearDefault;
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
                    new PropertyDescriptorMemoryImpl<DateRangeFilterConfigurationMemoryImpl, bool?>(
                        lazyCtx,
                        new Guid("c38eda0e-59b7-4e37-9d16-5f4fb7ae0b2d"),
                        "IsCurrentMonthDefault",
                        null,
                        obj => obj.IsCurrentMonthDefault,
                        (obj, val) => obj.IsCurrentMonthDefault = val),
                    // else
                    new PropertyDescriptorMemoryImpl<DateRangeFilterConfigurationMemoryImpl, bool?>(
                        lazyCtx,
                        new Guid("edb97f39-355d-4a87-9aa1-ad9eccafb369"),
                        "IsCurrentQuaterDefault",
                        null,
                        obj => obj.IsCurrentQuaterDefault,
                        (obj, val) => obj.IsCurrentQuaterDefault = val),
                    // else
                    new PropertyDescriptorMemoryImpl<DateRangeFilterConfigurationMemoryImpl, bool?>(
                        lazyCtx,
                        new Guid("8f9bbaf8-4624-49d9-9b49-878142189cf7"),
                        "IsCurrentYearDefault",
                        null,
                        obj => obj.IsCurrentYearDefault,
                        (obj, val) => obj.IsCurrentYearDefault = val),
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
        [EventBasedMethod("OnToString_DateRangeFilterConfiguration")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DateRangeFilterConfiguration != null)
            {
                OnToString_DateRangeFilterConfiguration(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<DateRangeFilterConfiguration> OnToString_DateRangeFilterConfiguration;

        [EventBasedMethod("OnPreSave_DateRangeFilterConfiguration")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DateRangeFilterConfiguration != null) OnPreSave_DateRangeFilterConfiguration(this);
        }
        public static event ObjectEventHandler<DateRangeFilterConfiguration> OnPreSave_DateRangeFilterConfiguration;

        [EventBasedMethod("OnPostSave_DateRangeFilterConfiguration")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DateRangeFilterConfiguration != null) OnPostSave_DateRangeFilterConfiguration(this);
        }
        public static event ObjectEventHandler<DateRangeFilterConfiguration> OnPostSave_DateRangeFilterConfiguration;

        [EventBasedMethod("OnCreated_DateRangeFilterConfiguration")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_DateRangeFilterConfiguration != null) OnCreated_DateRangeFilterConfiguration(this);
        }
        public static event ObjectEventHandler<DateRangeFilterConfiguration> OnCreated_DateRangeFilterConfiguration;

        [EventBasedMethod("OnDeleting_DateRangeFilterConfiguration")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_DateRangeFilterConfiguration != null) OnDeleting_DateRangeFilterConfiguration(this);
        }
        public static event ObjectEventHandler<DateRangeFilterConfiguration> OnDeleting_DateRangeFilterConfiguration;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this._IsCurrentMonthDefault, binStream);
            BinarySerializer.ToStream(this._IsCurrentQuaterDefault, binStream);
            BinarySerializer.ToStream(this._IsCurrentYearDefault, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            BinarySerializer.FromStream(out this._IsCurrentMonthDefault, binStream);
            BinarySerializer.FromStream(out this._IsCurrentQuaterDefault, binStream);
            BinarySerializer.FromStream(out this._IsCurrentYearDefault, binStream);
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            XmlStreamer.ToStream(this._IsCurrentMonthDefault, xml, "IsCurrentMonthDefault", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._IsCurrentQuaterDefault, xml, "IsCurrentQuaterDefault", "Kistl.App.GUI");
            XmlStreamer.ToStream(this._IsCurrentYearDefault, xml, "IsCurrentYearDefault", "Kistl.App.GUI");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            XmlStreamer.FromStream(ref this._IsCurrentMonthDefault, xml, "IsCurrentMonthDefault", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._IsCurrentQuaterDefault, xml, "IsCurrentQuaterDefault", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._IsCurrentYearDefault, xml, "IsCurrentYearDefault", "Kistl.App.GUI");
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this._IsCurrentMonthDefault, xml, "IsCurrentMonthDefault", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this._IsCurrentQuaterDefault, xml, "IsCurrentQuaterDefault", "Kistl.App.GUI");
            if (modules.Contains("*") || modules.Contains("Kistl.App.GUI")) XmlStreamer.ToStream(this._IsCurrentYearDefault, xml, "IsCurrentYearDefault", "Kistl.App.GUI");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            XmlStreamer.FromStream(ref this._IsCurrentMonthDefault, xml, "IsCurrentMonthDefault", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._IsCurrentQuaterDefault, xml, "IsCurrentQuaterDefault", "Kistl.App.GUI");
            XmlStreamer.FromStream(ref this._IsCurrentYearDefault, xml, "IsCurrentYearDefault", "Kistl.App.GUI");
        }

        #endregion

    }
}