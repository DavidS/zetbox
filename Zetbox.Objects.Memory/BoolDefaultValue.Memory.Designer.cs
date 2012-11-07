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

    using Zetbox.DalProvider.Base;
    using Zetbox.DalProvider.Memory;

    /// <summary>
    /// Sets an boolean property with an configured default value
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("BoolDefaultValue")]
    public class BoolDefaultValueMemoryImpl : Zetbox.App.Base.DefaultPropertyValueMemoryImpl, BoolDefaultValue
    {
        private static readonly Guid _objectClassID = new Guid("47838e25-d8f7-4d18-a913-eeb4095bb862");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public BoolDefaultValueMemoryImpl()
            : base(null)
        {
        }

        public BoolDefaultValueMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public bool BoolValue
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _BoolValue;
                if (OnBoolValue_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnBoolValue_Getter(this, __e);
                    __result = _BoolValue = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_BoolValue != value)
                {
                    var __oldValue = _BoolValue;
                    var __newValue = value;
                    if (OnBoolValue_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnBoolValue_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("BoolValue", __oldValue, __newValue);
                    _BoolValue = __newValue;
                    NotifyPropertyChanged("BoolValue", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnBoolValue_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnBoolValue_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("BoolValue");
				}
            }
        }
        private bool _BoolValue;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.BoolDefaultValue, bool> OnBoolValue_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.BoolDefaultValue, bool> OnBoolValue_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.BoolDefaultValue, bool> OnBoolValue_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.BoolDefaultValue> OnBoolValue_IsValid;

        /// <summary>
        /// GetDefaultValue
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDefaultValue_BoolDefaultValue")]
        public override System.Object GetDefaultValue()
        {
            var e = new MethodReturnEventArgs<System.Object>();
            if (OnGetDefaultValue_BoolDefaultValue != null)
            {
                OnGetDefaultValue_BoolDefaultValue(this, e);
            }
            else
            {
                e.Result = base.GetDefaultValue();
            }
            return e.Result;
        }
        public static event GetDefaultValue_Handler<BoolDefaultValue> OnGetDefaultValue_BoolDefaultValue;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<BoolDefaultValue> OnGetDefaultValue_BoolDefaultValue_CanExec;

        [EventBasedMethod("OnGetDefaultValue_BoolDefaultValue_CanExec")]
        public override bool GetDefaultValueCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetDefaultValue_BoolDefaultValue_CanExec != null)
				{
					OnGetDefaultValue_BoolDefaultValue_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetDefaultValueCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<BoolDefaultValue> OnGetDefaultValue_BoolDefaultValue_CanExecReason;

        [EventBasedMethod("OnGetDefaultValue_BoolDefaultValue_CanExecReason")]
        public override string GetDefaultValueCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetDefaultValue_BoolDefaultValue_CanExecReason != null)
				{
					OnGetDefaultValue_BoolDefaultValue_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetDefaultValueCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(BoolDefaultValue);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (BoolDefaultValue)obj;
            var otherImpl = (BoolDefaultValueMemoryImpl)obj;
            var me = (BoolDefaultValue)this;

            me.BoolValue = other.BoolValue;
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
                case "BoolValue":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }
        #endregion // Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

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
                    new PropertyDescriptorMemoryImpl<BoolDefaultValue, bool>(
                        lazyCtx,
                        new Guid("635818b4-065f-456c-b57e-4a7cdc8b3378"),
                        "BoolValue",
                        null,
                        obj => obj.BoolValue,
                        (obj, val) => obj.BoolValue = val,
						obj => OnBoolValue_IsValid), 
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
        [EventBasedMethod("OnToString_BoolDefaultValue")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_BoolDefaultValue != null)
            {
                OnToString_BoolDefaultValue(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<BoolDefaultValue> OnToString_BoolDefaultValue;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_BoolDefaultValue")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_BoolDefaultValue != null)
            {
                OnObjectIsValid_BoolDefaultValue(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<BoolDefaultValue> OnObjectIsValid_BoolDefaultValue;

        [EventBasedMethod("OnNotifyPreSave_BoolDefaultValue")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_BoolDefaultValue != null) OnNotifyPreSave_BoolDefaultValue(this);
        }
        public static event ObjectEventHandler<BoolDefaultValue> OnNotifyPreSave_BoolDefaultValue;

        [EventBasedMethod("OnNotifyPostSave_BoolDefaultValue")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_BoolDefaultValue != null) OnNotifyPostSave_BoolDefaultValue(this);
        }
        public static event ObjectEventHandler<BoolDefaultValue> OnNotifyPostSave_BoolDefaultValue;

        [EventBasedMethod("OnNotifyCreated_BoolDefaultValue")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("BoolValue");
            base.NotifyCreated();
            if (OnNotifyCreated_BoolDefaultValue != null) OnNotifyCreated_BoolDefaultValue(this);
        }
        public static event ObjectEventHandler<BoolDefaultValue> OnNotifyCreated_BoolDefaultValue;

        [EventBasedMethod("OnNotifyDeleting_BoolDefaultValue")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_BoolDefaultValue != null) OnNotifyDeleting_BoolDefaultValue(this);
        }
        public static event ObjectEventHandler<BoolDefaultValue> OnNotifyDeleting_BoolDefaultValue;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._BoolValue);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._BoolValue = binStream.ReadBoolean();
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
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this._BoolValue, xml, "BoolValue", "Zetbox.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Base|BoolValue":
                this._BoolValue = XmlStreamer.ReadBoolean(xml);
                break;
            }
        }

        #endregion

    }
}