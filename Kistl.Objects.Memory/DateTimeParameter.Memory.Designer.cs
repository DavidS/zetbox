// <autogenerated/>

namespace Kistl.App.Base
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
    /// Metadefinition Object for DateTime Parameter.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("DateTimeParameter")]
    public class DateTimeParameterMemoryImpl : Kistl.App.Base.BaseParameterMemoryImpl, DateTimeParameter
    {
        [Obsolete]
        public DateTimeParameterMemoryImpl()
            : base(null)
        {
        }

        public DateTimeParameterMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// Style of Datetime. Can be Date, Time, or Date and Time.
        /// </summary>
        // enumeration property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public Kistl.App.Base.DateTimeStyles? DateTimeStyle
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(Kistl.App.Base.DateTimeStyles?);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _DateTimeStyle;
                if (OnDateTimeStyle_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<Kistl.App.Base.DateTimeStyles?>(__result);
                    OnDateTimeStyle_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_DateTimeStyle != value)
                {
                    var __oldValue = _DateTimeStyle;
                    var __newValue = value;
                    if (OnDateTimeStyle_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<Kistl.App.Base.DateTimeStyles?>(__oldValue, __newValue);
                        OnDateTimeStyle_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("DateTimeStyle", __oldValue, __newValue);
                    _DateTimeStyle = __newValue;
                    NotifyPropertyChanged("DateTimeStyle", __oldValue, __newValue);
                    if (OnDateTimeStyle_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<Kistl.App.Base.DateTimeStyles?>(__oldValue, __newValue);
                        OnDateTimeStyle_PostSetter(this, __e);
                    }
                }
            }
        }
        private Kistl.App.Base.DateTimeStyles? _DateTimeStyle;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.DateTimeParameter, Kistl.App.Base.DateTimeStyles?> OnDateTimeStyle_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.DateTimeParameter, Kistl.App.Base.DateTimeStyles?> OnDateTimeStyle_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.DateTimeParameter, Kistl.App.Base.DateTimeStyles?> OnDateTimeStyle_PostSetter;

        public event PropertyIsValidHandler<Kistl.App.Base.DateTimeParameter> OnDateTimeStyle_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_DateTimeParameter")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_DateTimeParameter != null)
            {
                OnGetLabel_DateTimeParameter(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<DateTimeParameter> OnGetLabel_DateTimeParameter;
		// CanExec
		public static event CanExecMethodEventHandler<DateTimeParameter> OnGetLabel_DateTimeParameter_CanExec;

        [EventBasedMethod("OnGetLabel_DateTimeParameter_CanExec")]
        public override bool GetLabelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabel_DateTimeParameter_CanExec != null)
				{
					OnGetLabel_DateTimeParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<DateTimeParameter> OnGetLabel_DateTimeParameter_CanExecReason;

        [EventBasedMethod("OnGetLabel_DateTimeParameter_CanExecReason")]
        public override string GetLabelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabel_DateTimeParameter_CanExecReason != null)
				{
					OnGetLabel_DateTimeParameter_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the resulting Type of this Method-Parameter Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetParameterType_DateTimeParameter")]
        public override System.Type GetParameterType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetParameterType_DateTimeParameter != null)
            {
                OnGetParameterType_DateTimeParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterType();
            }
            return e.Result;
        }
        public static event GetParameterType_Handler<DateTimeParameter> OnGetParameterType_DateTimeParameter;
		// CanExec
		public static event CanExecMethodEventHandler<DateTimeParameter> OnGetParameterType_DateTimeParameter_CanExec;

        [EventBasedMethod("OnGetParameterType_DateTimeParameter_CanExec")]
        public override bool GetParameterTypeCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetParameterType_DateTimeParameter_CanExec != null)
				{
					OnGetParameterType_DateTimeParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<DateTimeParameter> OnGetParameterType_DateTimeParameter_CanExecReason;

        [EventBasedMethod("OnGetParameterType_DateTimeParameter_CanExecReason")]
        public override string GetParameterTypeCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetParameterType_DateTimeParameter_CanExecReason != null)
				{
					OnGetParameterType_DateTimeParameter_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the String representation of this Method-Parameter Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetParameterTypeString_DateTimeParameter")]
        public override string GetParameterTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetParameterTypeString_DateTimeParameter != null)
            {
                OnGetParameterTypeString_DateTimeParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterTypeString();
            }
            return e.Result;
        }
        public static event GetParameterTypeString_Handler<DateTimeParameter> OnGetParameterTypeString_DateTimeParameter;
		// CanExec
		public static event CanExecMethodEventHandler<DateTimeParameter> OnGetParameterTypeString_DateTimeParameter_CanExec;

        [EventBasedMethod("OnGetParameterTypeString_DateTimeParameter_CanExec")]
        public override bool GetParameterTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetParameterTypeString_DateTimeParameter_CanExec != null)
				{
					OnGetParameterTypeString_DateTimeParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<DateTimeParameter> OnGetParameterTypeString_DateTimeParameter_CanExecReason;

        [EventBasedMethod("OnGetParameterTypeString_DateTimeParameter_CanExecReason")]
        public override string GetParameterTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetParameterTypeString_DateTimeParameter_CanExecReason != null)
				{
					OnGetParameterTypeString_DateTimeParameter_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeStringCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(DateTimeParameter);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (DateTimeParameter)obj;
            var otherImpl = (DateTimeParameterMemoryImpl)obj;
            var me = (DateTimeParameter)this;

            me.DateTimeStyle = other.DateTimeStyle;
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
                    new PropertyDescriptorMemoryImpl<DateTimeParameter, Kistl.App.Base.DateTimeStyles?>(
                        lazyCtx,
                        new Guid("0d0f2e67-cfa2-4463-aaf2-2ce0e6d11fa0"),
                        "DateTimeStyle",
                        null,
                        obj => ((DateTimeParameterMemoryImpl)obj).DateTimeStyle,
                        (obj, val) => obj.DateTimeStyle = val,
						obj => ((DateTimeParameterMemoryImpl)obj).OnDateTimeStyle_IsValid), 
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
        [EventBasedMethod("OnToString_DateTimeParameter")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DateTimeParameter != null)
            {
                OnToString_DateTimeParameter(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<DateTimeParameter> OnToString_DateTimeParameter;

        [EventBasedMethod("OnPreSave_DateTimeParameter")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DateTimeParameter != null) OnPreSave_DateTimeParameter(this);
        }
        public static event ObjectEventHandler<DateTimeParameter> OnPreSave_DateTimeParameter;

        [EventBasedMethod("OnPostSave_DateTimeParameter")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DateTimeParameter != null) OnPostSave_DateTimeParameter(this);
        }
        public static event ObjectEventHandler<DateTimeParameter> OnPostSave_DateTimeParameter;

        [EventBasedMethod("OnCreated_DateTimeParameter")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_DateTimeParameter != null) OnCreated_DateTimeParameter(this);
        }
        public static event ObjectEventHandler<DateTimeParameter> OnCreated_DateTimeParameter;

        [EventBasedMethod("OnDeleting_DateTimeParameter")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_DateTimeParameter != null) OnDeleting_DateTimeParameter(this);
        }
        public static event ObjectEventHandler<DateTimeParameter> OnDeleting_DateTimeParameter;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream((int?)((Kistl.App.Base.DateTimeParameter)this).DateTimeStyle, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            {
                int? baseValue;
                BinarySerializer.FromStream(out baseValue, binStream);
                ((Kistl.App.Base.DateTimeParameter)this).DateTimeStyle = (Kistl.App.Base.DateTimeStyles?)baseValue;
            }
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
            XmlStreamer.ToStream((int?)((Kistl.App.Base.DateTimeParameter)this).DateTimeStyle, xml, "DateTimeStyle", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStreamConverter(v => ((Kistl.App.Base.DateTimeParameter)this).DateTimeStyle = (Kistl.App.Base.DateTimeStyles?)v, xml, "DateTimeStyle", "Kistl.App.Base");
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream((int?)((Kistl.App.Base.DateTimeParameter)this).DateTimeStyle, xml, "DateTimeStyle", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.FromStreamConverter(v => ((Kistl.App.Base.DateTimeParameter)this).DateTimeStyle = (Kistl.App.Base.DateTimeStyles?)v, xml, "DateTimeStyle", "Kistl.App.Base");
        }

        #endregion

    }
}