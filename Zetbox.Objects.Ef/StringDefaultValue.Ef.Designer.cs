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
    /// Sets an string property with the configured default value
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="StringDefaultValue")]
    [System.Diagnostics.DebuggerDisplay("StringDefaultValue")]
    public class StringDefaultValueEfImpl : Zetbox.App.Base.DefaultPropertyValueEfImpl, StringDefaultValue
    {
        private static readonly Guid _objectClassID = new Guid("7af200ea-9218-419b-9b02-33757d4b0150");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public StringDefaultValueEfImpl()
            : base(null)
        {
        }

        public StringDefaultValueEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public string DefaultValue
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _DefaultValue;
                if (OnDefaultValue_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnDefaultValue_Getter(this, __e);
                    __result = _DefaultValue = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_DefaultValue != value)
                {
                    var __oldValue = _DefaultValue;
                    var __newValue = value;
                    if (OnDefaultValue_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnDefaultValue_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("DefaultValue", __oldValue, __newValue);
                    _DefaultValue = __newValue;
                    NotifyPropertyChanged("DefaultValue", __oldValue, __newValue);

                    if (OnDefaultValue_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnDefaultValue_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("DefaultValue");
				}
            }
        }
        private string _DefaultValue_store;
        private string _DefaultValue {
            get { return _DefaultValue_store; }
            set {
                ReportEfPropertyChanging("DefaultValue");
                _DefaultValue_store = value;
                ReportEfPropertyChanged("DefaultValue");
            }
        }
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.StringDefaultValue, string> OnDefaultValue_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.StringDefaultValue, string> OnDefaultValue_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.StringDefaultValue, string> OnDefaultValue_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.StringDefaultValue> OnDefaultValue_IsValid;

        /// <summary>
        /// GetDefaultValue
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDefaultValue_StringDefaultValue")]
        public override System.Object GetDefaultValue()
        {
            var e = new MethodReturnEventArgs<System.Object>();
            if (OnGetDefaultValue_StringDefaultValue != null)
            {
                OnGetDefaultValue_StringDefaultValue(this, e);
            }
            else
            {
                e.Result = base.GetDefaultValue();
            }
            return e.Result;
        }
        public static event GetDefaultValue_Handler<StringDefaultValue> OnGetDefaultValue_StringDefaultValue;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<StringDefaultValue> OnGetDefaultValue_StringDefaultValue_CanExec;

        [EventBasedMethod("OnGetDefaultValue_StringDefaultValue_CanExec")]
        public override bool GetDefaultValueCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetDefaultValue_StringDefaultValue_CanExec != null)
				{
					OnGetDefaultValue_StringDefaultValue_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetDefaultValueCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<StringDefaultValue> OnGetDefaultValue_StringDefaultValue_CanExecReason;

        [EventBasedMethod("OnGetDefaultValue_StringDefaultValue_CanExecReason")]
        public override string GetDefaultValueCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetDefaultValue_StringDefaultValue_CanExecReason != null)
				{
					OnGetDefaultValue_StringDefaultValue_CanExecReason(this, e);
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
            return typeof(StringDefaultValue);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (StringDefaultValue)obj;
            var otherImpl = (StringDefaultValueEfImpl)obj;
            var me = (StringDefaultValue)this;

            me.DefaultValue = other.DefaultValue;
        }

        public override void AttachToContext(IZetboxContext ctx)
        {
            base.AttachToContext(ctx);
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
                case "DefaultValue":
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
                    new PropertyDescriptorEfImpl<StringDefaultValue, string>(
                        lazyCtx,
                        new Guid("88d7ba7d-6a5e-48b9-8464-c0308f6dabb6"),
                        "DefaultValue",
                        null,
                        obj => obj.DefaultValue,
                        (obj, val) => obj.DefaultValue = val,
						obj => OnDefaultValue_IsValid), 
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
        [EventBasedMethod("OnToString_StringDefaultValue")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_StringDefaultValue != null)
            {
                OnToString_StringDefaultValue(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<StringDefaultValue> OnToString_StringDefaultValue;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_StringDefaultValue")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_StringDefaultValue != null)
            {
                OnObjectIsValid_StringDefaultValue(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<StringDefaultValue> OnObjectIsValid_StringDefaultValue;

        [EventBasedMethod("OnNotifyPreSave_StringDefaultValue")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_StringDefaultValue != null) OnNotifyPreSave_StringDefaultValue(this);
        }
        public static event ObjectEventHandler<StringDefaultValue> OnNotifyPreSave_StringDefaultValue;

        [EventBasedMethod("OnNotifyPostSave_StringDefaultValue")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_StringDefaultValue != null) OnNotifyPostSave_StringDefaultValue(this);
        }
        public static event ObjectEventHandler<StringDefaultValue> OnNotifyPostSave_StringDefaultValue;

        [EventBasedMethod("OnNotifyCreated_StringDefaultValue")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("DefaultValue");
            base.NotifyCreated();
            if (OnNotifyCreated_StringDefaultValue != null) OnNotifyCreated_StringDefaultValue(this);
        }
        public static event ObjectEventHandler<StringDefaultValue> OnNotifyCreated_StringDefaultValue;

        [EventBasedMethod("OnNotifyDeleting_StringDefaultValue")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_StringDefaultValue != null) OnNotifyDeleting_StringDefaultValue(this);
        }
        public static event ObjectEventHandler<StringDefaultValue> OnNotifyDeleting_StringDefaultValue;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._DefaultValue);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._DefaultValue = binStream.ReadString();
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
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this._DefaultValue, xml, "DefaultValue", "Zetbox.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Base|DefaultValue":
                this._DefaultValue = XmlStreamer.ReadString(xml);
                break;
            }
        }

        #endregion

    }
}