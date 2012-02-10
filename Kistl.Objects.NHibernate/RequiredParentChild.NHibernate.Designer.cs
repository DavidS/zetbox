// <autogenerated/>

namespace Kistl.App.Test
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
    /// Testclass for the required_parent tests: child
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("RequiredParentChild")]
    public class RequiredParentChildNHibernateImpl : Kistl.DalProvider.NHibernate.DataObjectNHibernateImpl, RequiredParentChild
    {
        public RequiredParentChildNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public RequiredParentChildNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new RequiredParentChildProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public RequiredParentChildNHibernateImpl(Func<IFrozenContext> lazyCtx, RequiredParentChildProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly RequiredParentChildProxy Proxy;

        /// <summary>
        /// dummy property
        /// </summary>

        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string Name
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
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
                    if (OnName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PostSetter(this, __e);
                    }
                }
            }
        }
        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Kistl.App.Test.RequiredParentChild, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.RequiredParentChild, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.RequiredParentChild, string> OnName_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Test.RequiredParentChild> OnName_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Parent
        // fkBackingName=this.Proxy.Parent; fkGuidBackingName=_fk_guid_Parent;
        // referencedInterface=Kistl.App.Test.RequiredParent; moduleNamespace=Kistl.App.Test;
        // inverse Navigator=Children; is list;
        // PositionStorage=none;
        // Target not exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Test.RequiredParent Parent
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Test.RequiredParentNHibernateImpl __value = (Kistl.App.Test.RequiredParentNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Parent);

                if (OnParent_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Test.RequiredParent>(__value);
                    OnParent_Getter(this, e);
                    __value = (Kistl.App.Test.RequiredParentNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.Parent == null)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = (Kistl.App.Test.RequiredParentNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Parent);
                var __newValue = (Kistl.App.Test.RequiredParentNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
                    return;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Parent", __oldValue, __newValue);

                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanging("Children", null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanging("Children", null, null);
                }

                if (OnParent_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Test.RequiredParent>(__oldValue, __newValue);
                    OnParent_PreSetter(this, e);
                    __newValue = (Kistl.App.Test.RequiredParentNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.Parent = null;
                }
                else
                {
                    this.Proxy.Parent = __newValue.Proxy;
                }

                // now fixup redundant, inverse references
                // The inverse navigator will also fire events when changed, so should
                // only be touched after setting the local value above.
                // TODO: for complete correctness, the "other" Changing event should also fire
                //       before the local value is changed
                if (__oldValue != null)
                {
                    // remove from old list
                    (__oldValue.Children as IRelationListSync<Kistl.App.Test.RequiredParentChild>).RemoveWithoutClearParent(this);
                }

                if (__newValue != null)
                {
                    // add to new list
                    (__newValue.Children as IRelationListSync<Kistl.App.Test.RequiredParentChild>).AddWithoutSetParent(this);
                }
                // everything is done. fire the Changed event
                NotifyPropertyChanged("Parent", __oldValue, __newValue);

                if (OnParent_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Test.RequiredParent>(__oldValue, __newValue);
                    OnParent_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for Parent's id, used on dehydration only</summary>
        private int? _fk_Parent = null;


        // END Kistl.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Parent
		public static event PropertyGetterHandler<Kistl.App.Test.RequiredParentChild, Kistl.App.Test.RequiredParent> OnParent_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.RequiredParentChild, Kistl.App.Test.RequiredParent> OnParent_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.RequiredParentChild, Kistl.App.Test.RequiredParent> OnParent_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Test.RequiredParentChild> OnParent_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(RequiredParentChild);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (RequiredParentChild)obj;
            var otherImpl = (RequiredParentChildNHibernateImpl)obj;
            var me = (RequiredParentChild)this;

            me.Name = other.Name;
            this._fk_Parent = otherImpl._fk_Parent;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "Parent":
                    {
                        var __oldValue = (Kistl.App.Test.RequiredParentNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Parent);
                        var __newValue = (Kistl.App.Test.RequiredParentNHibernateImpl)parentObj;
                        NotifyPropertyChanging("Parent", __oldValue, __newValue);
                        this.Proxy.Parent = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("Parent", __oldValue, __newValue);
                    }
                    break;
                default:
                    base.UpdateParent(propertyName, parentObj);
                    break;
            }
        }

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_Parent.HasValue)
                this.Proxy.Parent = ((Kistl.App.Test.RequiredParentNHibernateImpl)OurContext.FindPersistenceObject<Kistl.App.Test.RequiredParent>(_fk_Parent.Value)).Proxy;
            else
                this.Proxy.Parent = null;
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
                    new PropertyDescriptorNHibernateImpl<RequiredParentChild, string>(
                        lazyCtx,
                        new Guid("82dc687e-3915-4f03-9a1f-75e42fcbe7cd"),
                        "Name",
                        null,
                        obj => obj.Name,
                        (obj, val) => obj.Name = val,
						obj => OnName_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<RequiredParentChild, Kistl.App.Test.RequiredParent>(
                        lazyCtx,
                        new Guid("09fb9f88-7a59-4dae-8cad-9fbab99f32c3"),
                        "Parent",
                        null,
                        obj => obj.Parent,
                        (obj, val) => obj.Parent = val,
						obj => OnParent_IsValid), 
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
        [EventBasedMethod("OnToString_RequiredParentChild")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_RequiredParentChild != null)
            {
                OnToString_RequiredParentChild(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<RequiredParentChild> OnToString_RequiredParentChild;

		[System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_RequiredParentChild")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
			var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
			e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_RequiredParentChild != null)
            {
                OnObjectIsValid_RequiredParentChild(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<RequiredParentChild> OnObjectIsValid_RequiredParentChild;

        [EventBasedMethod("OnNotifyPreSave_RequiredParentChild")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_RequiredParentChild != null) OnNotifyPreSave_RequiredParentChild(this);
        }
        public static event ObjectEventHandler<RequiredParentChild> OnNotifyPreSave_RequiredParentChild;

        [EventBasedMethod("OnNotifyPostSave_RequiredParentChild")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_RequiredParentChild != null) OnNotifyPostSave_RequiredParentChild(this);
        }
        public static event ObjectEventHandler<RequiredParentChild> OnNotifyPostSave_RequiredParentChild;

        [EventBasedMethod("OnNotifyCreated_RequiredParentChild")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_RequiredParentChild != null) OnNotifyCreated_RequiredParentChild(this);
        }
        public static event ObjectEventHandler<RequiredParentChild> OnNotifyCreated_RequiredParentChild;

        [EventBasedMethod("OnNotifyDeleting_RequiredParentChild")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_RequiredParentChild != null) OnNotifyDeleting_RequiredParentChild(this);
        }
        public static event ObjectEventHandler<RequiredParentChild> OnNotifyDeleting_RequiredParentChild;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods
        public override List<NHibernatePersistenceObject> GetParentsToDelete()
        {
            var result = base.GetParentsToDelete();

            // Follow Parent_of_Children
            if (this.Parent != null && this.Parent.ObjectState == DataObjectState.Deleted)
                result.Add((NHibernatePersistenceObject)this.Parent);

            return result;
        }

        public override List<NHibernatePersistenceObject> GetChildrenToDelete()
        {
            var result = base.GetChildrenToDelete();

            return result;
        }


        public class RequiredParentChildProxy
            : IProxyObject, ISortKey<int>
        {
            public RequiredParentChildProxy()
            {
            }

            public virtual int ID { get; set; }

            public virtual Type ZBoxWrapper { get { return typeof(RequiredParentChildNHibernateImpl); } }
            public virtual Type ZBoxProxy { get { return typeof(RequiredParentChildProxy); } }

            public virtual string Name { get; set; }

            public virtual Kistl.App.Test.RequiredParentNHibernateImpl.RequiredParentProxy Parent { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this.Proxy.Name, binStream);
            BinarySerializer.ToStream(this.Proxy.Parent != null ? OurContext.GetIdFromProxy(this.Proxy.Parent) : (int?)null, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            {
                string tmp;
                BinarySerializer.FromStream(out tmp, binStream);
                this.Proxy.Name = tmp;
            }
            BinarySerializer.FromStream(out this._fk_Parent, binStream);
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
            XmlStreamer.ToStream(this.Proxy.Name, xml, "Name", "Kistl.App.Test");
            XmlStreamer.ToStream(this.Proxy.Parent != null ? OurContext.GetIdFromProxy(this.Proxy.Parent) : (int?)null, xml, "Parent", "Kistl.App.Test");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            {
                // yuck
                string tmp = this.Proxy.Name;
                XmlStreamer.FromStream(ref tmp, xml, "Name", "Kistl.App.Test");
                this.Proxy.Name = tmp;
            }
            XmlStreamer.FromStream(ref this._fk_Parent, xml, "Parent", "Kistl.App.Test");
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        #endregion

    }
}