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
    /// Metadefinition Object for Decimal Properties.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("DecimalProperty")]
    public class DecimalPropertyNHibernateImpl : Zetbox.App.Base.ValueTypePropertyNHibernateImpl, DecimalProperty
    {
        private static readonly Guid _objectClassID = new Guid("7e44265e-8d41-4f5f-bb5c-5038b55be5b2");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public DecimalPropertyNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public DecimalPropertyNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new DecimalPropertyProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public DecimalPropertyNHibernateImpl(Func<IFrozenContext> lazyCtx, DecimalPropertyProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly DecimalPropertyProxy Proxy;

        /// <summary>
        /// The maximum total number of decimal digits that can be stored, both to the left and to the right of the decimal point.
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public int Precision
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(int);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Precision;
                if (OnPrecision_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnPrecision_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Precision != value)
                {
                    var __oldValue = Proxy.Precision;
                    var __newValue = value;
                    if (OnPrecision_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnPrecision_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Precision", __oldValue, __newValue);
                    Proxy.Precision = __newValue;
                    NotifyPropertyChanged("Precision", __oldValue, __newValue);

                    if (OnPrecision_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnPrecision_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Precision");
				}
            }
        }

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.DecimalProperty, int> OnPrecision_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.DecimalProperty, int> OnPrecision_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.DecimalProperty, int> OnPrecision_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.DecimalProperty> OnPrecision_IsValid;

        /// <summary>
        /// The maximum number of decimal digits that can be stored to the right of the decimal point.
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public int Scale
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(int);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Scale;
                if (OnScale_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnScale_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Scale != value)
                {
                    var __oldValue = Proxy.Scale;
                    var __newValue = value;
                    if (OnScale_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnScale_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Scale", __oldValue, __newValue);
                    Proxy.Scale = __newValue;
                    NotifyPropertyChanged("Scale", __oldValue, __newValue);

                    if (OnScale_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnScale_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Scale");
				}
            }
        }

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.DecimalProperty, int> OnScale_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.DecimalProperty, int> OnScale_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.DecimalProperty, int> OnScale_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.DecimalProperty> OnScale_IsValid;

        /// <summary>
        /// The element type for multi-valued properties. The property type string in all other cases.
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetElementTypeString_DecimalProperty")]
        public override string GetElementTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetElementTypeString_DecimalProperty != null)
            {
                OnGetElementTypeString_DecimalProperty(this, e);
            }
            else
            {
                e.Result = base.GetElementTypeString();
            }
            return e.Result;
        }
        public static event GetElementTypeString_Handler<DecimalProperty> OnGetElementTypeString_DecimalProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<DecimalProperty> OnGetElementTypeString_DecimalProperty_CanExec;

        [EventBasedMethod("OnGetElementTypeString_DecimalProperty_CanExec")]
        public override bool GetElementTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetElementTypeString_DecimalProperty_CanExec != null)
				{
					OnGetElementTypeString_DecimalProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetElementTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<DecimalProperty> OnGetElementTypeString_DecimalProperty_CanExecReason;

        [EventBasedMethod("OnGetElementTypeString_DecimalProperty_CanExecReason")]
        public override string GetElementTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetElementTypeString_DecimalProperty_CanExecReason != null)
				{
					OnGetElementTypeString_DecimalProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetElementTypeStringCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_DecimalProperty")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_DecimalProperty != null)
            {
                OnGetLabel_DecimalProperty(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<DecimalProperty> OnGetLabel_DecimalProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<DecimalProperty> OnGetLabel_DecimalProperty_CanExec;

        [EventBasedMethod("OnGetLabel_DecimalProperty_CanExec")]
        public override bool GetLabelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabel_DecimalProperty_CanExec != null)
				{
					OnGetLabel_DecimalProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<DecimalProperty> OnGetLabel_DecimalProperty_CanExecReason;

        [EventBasedMethod("OnGetLabel_DecimalProperty_CanExecReason")]
        public override string GetLabelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabel_DecimalProperty_CanExecReason != null)
				{
					OnGetLabel_DecimalProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetName_DecimalProperty")]
        public override string GetName()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetName_DecimalProperty != null)
            {
                OnGetName_DecimalProperty(this, e);
            }
            else
            {
                e.Result = base.GetName();
            }
            return e.Result;
        }
        public static event GetName_Handler<DecimalProperty> OnGetName_DecimalProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<DecimalProperty> OnGetName_DecimalProperty_CanExec;

        [EventBasedMethod("OnGetName_DecimalProperty_CanExec")]
        public override bool GetNameCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetName_DecimalProperty_CanExec != null)
				{
					OnGetName_DecimalProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetNameCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<DecimalProperty> OnGetName_DecimalProperty_CanExecReason;

        [EventBasedMethod("OnGetName_DecimalProperty_CanExecReason")]
        public override string GetNameCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetName_DecimalProperty_CanExecReason != null)
				{
					OnGetName_DecimalProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetNameCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetPropertyType_DecimalProperty")]
        public override System.Type GetPropertyType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_DecimalProperty != null)
            {
                OnGetPropertyType_DecimalProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
        public static event GetPropertyType_Handler<DecimalProperty> OnGetPropertyType_DecimalProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<DecimalProperty> OnGetPropertyType_DecimalProperty_CanExec;

        [EventBasedMethod("OnGetPropertyType_DecimalProperty_CanExec")]
        public override bool GetPropertyTypeCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetPropertyType_DecimalProperty_CanExec != null)
				{
					OnGetPropertyType_DecimalProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<DecimalProperty> OnGetPropertyType_DecimalProperty_CanExecReason;

        [EventBasedMethod("OnGetPropertyType_DecimalProperty_CanExecReason")]
        public override string GetPropertyTypeCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetPropertyType_DecimalProperty_CanExecReason != null)
				{
					OnGetPropertyType_DecimalProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetPropertyTypeString_DecimalProperty")]
        public override string GetPropertyTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_DecimalProperty != null)
            {
                OnGetPropertyTypeString_DecimalProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
        public static event GetPropertyTypeString_Handler<DecimalProperty> OnGetPropertyTypeString_DecimalProperty;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<DecimalProperty> OnGetPropertyTypeString_DecimalProperty_CanExec;

        [EventBasedMethod("OnGetPropertyTypeString_DecimalProperty_CanExec")]
        public override bool GetPropertyTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetPropertyTypeString_DecimalProperty_CanExec != null)
				{
					OnGetPropertyTypeString_DecimalProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<DecimalProperty> OnGetPropertyTypeString_DecimalProperty_CanExecReason;

        [EventBasedMethod("OnGetPropertyTypeString_DecimalProperty_CanExecReason")]
        public override string GetPropertyTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetPropertyTypeString_DecimalProperty_CanExecReason != null)
				{
					OnGetPropertyTypeString_DecimalProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeStringCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(DecimalProperty);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (DecimalProperty)obj;
            var otherImpl = (DecimalPropertyNHibernateImpl)obj;
            var me = (DecimalProperty)this;

            me.Precision = other.Precision;
            me.Scale = other.Scale;
        }

        public override void AttachToContext(IZetboxContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
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
                case "Precision":
                case "Scale":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }
        #endregion // Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

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
                    new PropertyDescriptorNHibernateImpl<DecimalProperty, int>(
                        lazyCtx,
                        new Guid("35dd7765-0e26-4195-b687-ce814560ba34"),
                        "Precision",
                        null,
                        obj => obj.Precision,
                        (obj, val) => obj.Precision = val,
						obj => OnPrecision_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<DecimalProperty, int>(
                        lazyCtx,
                        new Guid("fba03086-8a2b-4c25-b83f-df63933b62fe"),
                        "Scale",
                        null,
                        obj => obj.Scale,
                        (obj, val) => obj.Scale = val,
						obj => OnScale_IsValid), 
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
        #region Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_DecimalProperty")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DecimalProperty != null)
            {
                OnToString_DecimalProperty(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<DecimalProperty> OnToString_DecimalProperty;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_DecimalProperty")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_DecimalProperty != null)
            {
                OnObjectIsValid_DecimalProperty(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<DecimalProperty> OnObjectIsValid_DecimalProperty;

        [EventBasedMethod("OnNotifyPreSave_DecimalProperty")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_DecimalProperty != null) OnNotifyPreSave_DecimalProperty(this);
        }
        public static event ObjectEventHandler<DecimalProperty> OnNotifyPreSave_DecimalProperty;

        [EventBasedMethod("OnNotifyPostSave_DecimalProperty")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_DecimalProperty != null) OnNotifyPostSave_DecimalProperty(this);
        }
        public static event ObjectEventHandler<DecimalProperty> OnNotifyPostSave_DecimalProperty;

        [EventBasedMethod("OnNotifyCreated_DecimalProperty")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Precision");
            SetNotInitializedProperty("Scale");
            base.NotifyCreated();
            if (OnNotifyCreated_DecimalProperty != null) OnNotifyCreated_DecimalProperty(this);
        }
        public static event ObjectEventHandler<DecimalProperty> OnNotifyCreated_DecimalProperty;

        [EventBasedMethod("OnNotifyDeleting_DecimalProperty")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_DecimalProperty != null) OnNotifyDeleting_DecimalProperty(this);


        }
        public static event ObjectEventHandler<DecimalProperty> OnNotifyDeleting_DecimalProperty;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class DecimalPropertyProxy
            : Zetbox.App.Base.ValueTypePropertyNHibernateImpl.ValueTypePropertyProxy
        {
            public DecimalPropertyProxy()
            {
            }

            public override Type ZetboxWrapper { get { return typeof(DecimalPropertyNHibernateImpl); } }

            public override Type ZetboxProxy { get { return typeof(DecimalPropertyProxy); } }

            public virtual int Precision { get; set; }

            public virtual int Scale { get; set; }

        }

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.Precision);
            binStream.Write(this.Proxy.Scale);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this.Proxy.Precision = binStream.ReadInt32();
            this.Proxy.Scale = binStream.ReadInt32();
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
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this.Proxy.Precision, xml, "Precision", "Zetbox.App.Base");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this.Proxy.Scale, xml, "Scale", "Zetbox.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Base|Precision":
                this.Proxy.Precision = XmlStreamer.ReadInt32(xml);
                break;
            case "Zetbox.App.Base|Scale":
                this.Proxy.Scale = XmlStreamer.ReadInt32(xml);
                break;
            }
        }

        #endregion

    }
}