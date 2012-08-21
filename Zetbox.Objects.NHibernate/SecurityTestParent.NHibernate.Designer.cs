// <autogenerated/>

namespace Zetbox.App.Test
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
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("SecurityTestParent")]
    public class SecurityTestParentNHibernateImpl : Zetbox.DalProvider.NHibernate.DataObjectNHibernateImpl, SecurityTestParent
    {
        private static readonly Guid _objectClassID = new Guid("779f8526-3f7f-41be-8186-f22062c302a2");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public SecurityTestParentNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public SecurityTestParentNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new SecurityTestParentProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public SecurityTestParentNHibernateImpl(Func<IFrozenContext> lazyCtx, SecurityTestParentProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly SecurityTestParentProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // object list property

        // Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Zetbox.App.Test.SecurityTestChild> Children
        {
            get
            {
                if (_Children == null)
                {
                    _Children = new OneNRelationList<Zetbox.App.Test.SecurityTestChild>(
                        "Parent",
                        null,
                        this,
                        () => this.NotifyPropertyChanging("Children", null, null),
                        () => { this.NotifyPropertyChanged("Children", null, null); if(OnChildren_PostSetter != null && IsAttached) OnChildren_PostSetter(this); },
                        new ProjectedCollection<Zetbox.App.Test.SecurityTestChildNHibernateImpl.SecurityTestChildProxy, Zetbox.App.Test.SecurityTestChild>(
                            () => Proxy.Children,
                            p => (Zetbox.App.Test.SecurityTestChild)OurContext.AttachAndWrap(p),
                            d => (Zetbox.App.Test.SecurityTestChildNHibernateImpl.SecurityTestChildProxy)((NHibernatePersistenceObject)d).NHibernateProxy));
                }
                return _Children;
            }
        }
    
        private OneNRelationList<Zetbox.App.Test.SecurityTestChild> _Children;
public static event PropertyListChangedHandler<Zetbox.App.Test.SecurityTestParent> OnChildren_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.SecurityTestParent> OnChildren_IsValid;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string Name
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.Name;
                if (OnName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.Name != value)
                {
                    var __oldValue = Proxy.Name;
                    var __newValue = value;
                    if (OnName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Name", __oldValue, __newValue);
                    Proxy.Name = __newValue;
                    NotifyPropertyChanged("Name", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("Name");
				}
            }
        }

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.SecurityTestParent, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.SecurityTestParent, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.SecurityTestParent, string> OnName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.SecurityTestParent> OnName_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(SecurityTestParent);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (SecurityTestParent)obj;
            var otherImpl = (SecurityTestParentNHibernateImpl)obj;
            var me = (SecurityTestParent)this;

            me.Name = other.Name;
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
                case "Name":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }

        protected override bool ShouldSetModified(string property)
        {
            switch (property)
            {
                case "Children":
                    return false;
                default:
                    return base.ShouldSetModified(property);
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
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorNHibernateImpl<SecurityTestParent, ICollection<Zetbox.App.Test.SecurityTestChild>>(
                        lazyCtx,
                        new Guid("d4c5c1e6-1dab-4287-9a64-bd31b1c3923f"),
                        "Children",
                        null,
                        obj => obj.Children,
                        null, // lists are read-only properties
                        obj => OnChildren_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<SecurityTestParent, string>(
                        lazyCtx,
                        new Guid("0f8291ef-2a35-4d8e-bc17-761c0a1cfe88"),
                        "Name",
                        null,
                        obj => obj.Name,
                        (obj, val) => obj.Name = val,
						obj => OnName_IsValid), 
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
        [EventBasedMethod("OnToString_SecurityTestParent")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_SecurityTestParent != null)
            {
                OnToString_SecurityTestParent(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<SecurityTestParent> OnToString_SecurityTestParent;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_SecurityTestParent")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_SecurityTestParent != null)
            {
                OnObjectIsValid_SecurityTestParent(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<SecurityTestParent> OnObjectIsValid_SecurityTestParent;

        [EventBasedMethod("OnNotifyPreSave_SecurityTestParent")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_SecurityTestParent != null) OnNotifyPreSave_SecurityTestParent(this);
        }
        public static event ObjectEventHandler<SecurityTestParent> OnNotifyPreSave_SecurityTestParent;

        [EventBasedMethod("OnNotifyPostSave_SecurityTestParent")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_SecurityTestParent != null) OnNotifyPostSave_SecurityTestParent(this);
        }
        public static event ObjectEventHandler<SecurityTestParent> OnNotifyPostSave_SecurityTestParent;

        [EventBasedMethod("OnNotifyCreated_SecurityTestParent")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Name");
            base.NotifyCreated();
            if (OnNotifyCreated_SecurityTestParent != null) OnNotifyCreated_SecurityTestParent(this);
        }
        public static event ObjectEventHandler<SecurityTestParent> OnNotifyCreated_SecurityTestParent;

        [EventBasedMethod("OnNotifyDeleting_SecurityTestParent")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_SecurityTestParent != null) OnNotifyDeleting_SecurityTestParent(this);

            // FK_Parent_has_Children2 ZeroOrMore
            foreach(NHibernatePersistenceObject x in Children) {
                x.ParentsToDelete.Add(this);
                ChildrenToDelete.Add(x);
            }

            Children.Clear();
        }
        public static event ObjectEventHandler<SecurityTestParent> OnNotifyDeleting_SecurityTestParent;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class SecurityTestParentProxy
            : IProxyObject, ISortKey<int>
        {
            public SecurityTestParentProxy()
            {
                Children = new Collection<Zetbox.App.Test.SecurityTestChildNHibernateImpl.SecurityTestChildProxy>();
            }

            public virtual int ID { get; set; }

            public virtual Type ZetboxWrapper { get { return typeof(SecurityTestParentNHibernateImpl); } }
            public virtual Type ZetboxProxy { get { return typeof(SecurityTestParentProxy); } }

            public virtual ICollection<Zetbox.App.Test.SecurityTestChildNHibernateImpl.SecurityTestChildProxy> Children { get; set; }

            public virtual string Name { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.Name);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this.Proxy.Name = binStream.ReadString();
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