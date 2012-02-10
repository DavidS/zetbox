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

    using Kistl.API.Utils;
    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.NHibernate;

    /// <summary>
    /// Sets an integer property with the configured default value
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("IntDefaultValue")]
    public class IntDefaultValueNHibernateImpl : Kistl.App.Base.DefaultPropertyValueNHibernateImpl, IntDefaultValue
    {
        public IntDefaultValueNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public IntDefaultValueNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new IntDefaultValueProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public IntDefaultValueNHibernateImpl(Func<IFrozenContext> lazyCtx, IntDefaultValueProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly IntDefaultValueProxy Proxy;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public int IntValue
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(int);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.IntValue;
                if (OnIntValue_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnIntValue_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.IntValue != value)
                {
                    var __oldValue = Proxy.IntValue;
                    var __newValue = value;
                    if (OnIntValue_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnIntValue_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IntValue", __oldValue, __newValue);
                    Proxy.IntValue = __newValue;
                    NotifyPropertyChanged("IntValue", __oldValue, __newValue);
                    if (OnIntValue_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnIntValue_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.IntDefaultValue, int> OnIntValue_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.IntDefaultValue, int> OnIntValue_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.IntDefaultValue, int> OnIntValue_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Base.IntDefaultValue> OnIntValue_IsValid;

        /// <summary>
        /// GetDefaultValue
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDefaultValue_IntDefaultValue")]
        public override System.Object GetDefaultValue()
        {
            var e = new MethodReturnEventArgs<System.Object>();
            if (OnGetDefaultValue_IntDefaultValue != null)
            {
                OnGetDefaultValue_IntDefaultValue(this, e);
            }
            else
            {
                e.Result = base.GetDefaultValue();
            }
            return e.Result;
        }
        public static event GetDefaultValue_Handler<IntDefaultValue> OnGetDefaultValue_IntDefaultValue;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<IntDefaultValue> OnGetDefaultValue_IntDefaultValue_CanExec;

        [EventBasedMethod("OnGetDefaultValue_IntDefaultValue_CanExec")]
        public override bool GetDefaultValueCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetDefaultValue_IntDefaultValue_CanExec != null)
				{
					OnGetDefaultValue_IntDefaultValue_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetDefaultValueCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<IntDefaultValue> OnGetDefaultValue_IntDefaultValue_CanExecReason;

        [EventBasedMethod("OnGetDefaultValue_IntDefaultValue_CanExecReason")]
        public override string GetDefaultValueCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetDefaultValue_IntDefaultValue_CanExecReason != null)
				{
					OnGetDefaultValue_IntDefaultValue_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetDefaultValueCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(IntDefaultValue);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (IntDefaultValue)obj;
            var otherImpl = (IntDefaultValueNHibernateImpl)obj;
            var me = (IntDefaultValue)this;

            me.IntValue = other.IntValue;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
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
                    new PropertyDescriptorNHibernateImpl<IntDefaultValue, int>(
                        lazyCtx,
                        new Guid("c876dece-3b67-4302-88ef-313ba9ce62ae"),
                        "IntValue",
                        null,
                        obj => obj.IntValue,
                        (obj, val) => obj.IntValue = val,
						obj => OnIntValue_IsValid), 
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
        #region Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_IntDefaultValue")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_IntDefaultValue != null)
            {
                OnToString_IntDefaultValue(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<IntDefaultValue> OnToString_IntDefaultValue;

		[System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_IntDefaultValue")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
			var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
			e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_IntDefaultValue != null)
            {
                OnObjectIsValid_IntDefaultValue(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<IntDefaultValue> OnObjectIsValid_IntDefaultValue;

        [EventBasedMethod("OnNotifyPreSave_IntDefaultValue")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_IntDefaultValue != null) OnNotifyPreSave_IntDefaultValue(this);
        }
        public static event ObjectEventHandler<IntDefaultValue> OnNotifyPreSave_IntDefaultValue;

        [EventBasedMethod("OnNotifyPostSave_IntDefaultValue")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_IntDefaultValue != null) OnNotifyPostSave_IntDefaultValue(this);
        }
        public static event ObjectEventHandler<IntDefaultValue> OnNotifyPostSave_IntDefaultValue;

        [EventBasedMethod("OnNotifyCreated_IntDefaultValue")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_IntDefaultValue != null) OnNotifyCreated_IntDefaultValue(this);
        }
        public static event ObjectEventHandler<IntDefaultValue> OnNotifyCreated_IntDefaultValue;

        [EventBasedMethod("OnNotifyDeleting_IntDefaultValue")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_IntDefaultValue != null) OnNotifyDeleting_IntDefaultValue(this);
        }
        public static event ObjectEventHandler<IntDefaultValue> OnNotifyDeleting_IntDefaultValue;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods
        public override List<NHibernatePersistenceObject> GetParentsToDelete()
        {
            var result = base.GetParentsToDelete();

            return result;
        }

        public override List<NHibernatePersistenceObject> GetChildrenToDelete()
        {
            var result = base.GetChildrenToDelete();

            return result;
        }


        public class IntDefaultValueProxy
            : Kistl.App.Base.DefaultPropertyValueNHibernateImpl.DefaultPropertyValueProxy
        {
            public IntDefaultValueProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(IntDefaultValueNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(IntDefaultValueProxy); } }

            public virtual int IntValue { get; set; }

        }

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this.Proxy.IntValue, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            {
                int tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.IntValue = tmp;
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
            XmlStreamer.ToStream(this.Proxy.IntValue, xml, "IntValue", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            {
                // yuck
                int tmp = this.Proxy.IntValue;
                XmlStreamer.FromStream(ref tmp, xml, "IntValue", "Kistl.App.Base");
                this.Proxy.IntValue = tmp;
            }
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this.Proxy.IntValue, xml, "IntValue", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            {
                // yuck
                int tmp = this.Proxy.IntValue;
                XmlStreamer.FromStream(ref tmp, xml, "IntValue", "Kistl.App.Base");
                this.Proxy.IntValue = tmp;
            }
        }

        #endregion

    }
}