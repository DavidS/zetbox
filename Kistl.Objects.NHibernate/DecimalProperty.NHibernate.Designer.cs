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
    /// Metadefinition Object for Decimal Properties.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("DecimalProperty")]
    public class DecimalPropertyNHibernateImpl : Kistl.App.Base.ValueTypePropertyNHibernateImpl, DecimalProperty
    {
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

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
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
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.DecimalProperty, int> OnPrecision_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.DecimalProperty, int> OnPrecision_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.DecimalProperty, int> OnPrecision_PostSetter;

        /// <summary>
        /// The maximum number of decimal digits that can be stored to the right of the decimal point.
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
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
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Base.DecimalProperty, int> OnScale_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.DecimalProperty, int> OnScale_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.DecimalProperty, int> OnScale_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
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
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
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
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
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
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
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
        // END Kistl.Generator.Templates.ObjectClasses.Method

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
                    new PropertyDescriptorNHibernateImpl<DecimalPropertyNHibernateImpl, int>(
                        lazyCtx,
                        new Guid("35dd7765-0e26-4195-b687-ce814560ba34"),
                        "Precision",
                        null,
                        obj => obj.Precision,
                        (obj, val) => obj.Precision = val),
                    // else
                    new PropertyDescriptorNHibernateImpl<DecimalPropertyNHibernateImpl, int>(
                        lazyCtx,
                        new Guid("fba03086-8a2b-4c25-b83f-df63933b62fe"),
                        "Scale",
                        null,
                        obj => obj.Scale,
                        (obj, val) => obj.Scale = val),
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

        [EventBasedMethod("OnPreSave_DecimalProperty")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DecimalProperty != null) OnPreSave_DecimalProperty(this);
        }
        public static event ObjectEventHandler<DecimalProperty> OnPreSave_DecimalProperty;

        [EventBasedMethod("OnPostSave_DecimalProperty")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DecimalProperty != null) OnPostSave_DecimalProperty(this);
        }
        public static event ObjectEventHandler<DecimalProperty> OnPostSave_DecimalProperty;

        [EventBasedMethod("OnCreated_DecimalProperty")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_DecimalProperty != null) OnCreated_DecimalProperty(this);
        }
        public static event ObjectEventHandler<DecimalProperty> OnCreated_DecimalProperty;

        [EventBasedMethod("OnDeleting_DecimalProperty")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_DecimalProperty != null) OnDeleting_DecimalProperty(this);
        }
        public static event ObjectEventHandler<DecimalProperty> OnDeleting_DecimalProperty;

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


        public class DecimalPropertyProxy
            : Kistl.App.Base.ValueTypePropertyNHibernateImpl.ValueTypePropertyProxy
        {
            public DecimalPropertyProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(DecimalPropertyNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(DecimalPropertyProxy); } }

            public virtual int Precision { get; set; }

            public virtual int Scale { get; set; }

        }

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this.Proxy.Precision, binStream);
            BinarySerializer.ToStream(this.Proxy.Scale, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            {
                int tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.Precision = tmp;
            }
            {
                int tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.Scale = tmp;
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
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.ToStream(this.Proxy.Precision, xml, "Precision", "Kistl.App.Base");
            XmlStreamer.ToStream(this.Proxy.Scale, xml, "Scale", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            {
                // yuck
                int tmp = this.Proxy.Precision;
                XmlStreamer.FromStream(ref tmp, xml, "Precision", "Kistl.App.Base");
                this.Proxy.Precision = tmp;
            }
            {
                // yuck
                int tmp = this.Proxy.Scale;
                XmlStreamer.FromStream(ref tmp, xml, "Scale", "Kistl.App.Base");
                this.Proxy.Scale = tmp;
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
            if (!CurrentAccessRights.HasReadRights()) return;
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this.Proxy.Precision, xml, "Precision", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this.Proxy.Scale, xml, "Scale", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            if (!CurrentAccessRights.HasReadRights()) return;
            {
                // yuck
                int tmp = this.Proxy.Precision;
                XmlStreamer.FromStream(ref tmp, xml, "Precision", "Kistl.App.Base");
                this.Proxy.Precision = tmp;
            }
            {
                // yuck
                int tmp = this.Proxy.Scale;
                XmlStreamer.FromStream(ref tmp, xml, "Scale", "Kistl.App.Base");
                this.Proxy.Scale = tmp;
            }
        }

        #endregion

    }
}