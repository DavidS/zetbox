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
    /// The B-Side class for the N_to_M_relations Tests
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("N_to_M_relations_B")]
    public class N_to_M_relations_BNHibernateImpl : Kistl.DalProvider.NHibernate.DataObjectNHibernateImpl, N_to_M_relations_B
    {
        public N_to_M_relations_BNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public N_to_M_relations_BNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new N_to_M_relations_BProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public N_to_M_relations_BNHibernateImpl(Func<IFrozenContext> lazyCtx, N_to_M_relations_BProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly N_to_M_relations_BProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // collection entry list property
   		// Kistl.DalProvider.NHibernate.Generator.Templates.Properties.CollectionEntryListProperty
		public ICollection<Kistl.App.Test.N_to_M_relations_A> ASide
		{
			get
			{
				if (_ASide == null)
				{
					_ASide 
						= new NHibernateASideCollectionWrapper<Kistl.App.Test.N_to_M_relations_A, Kistl.App.Test.N_to_M_relations_B, Kistl.App.Test.N_to_M_relations_A_connectsTo_N_to_M_relations_B_RelationEntryNHibernateImpl>(
							this, 
							new ProjectedCollection<Kistl.App.Test.N_to_M_relations_A_connectsTo_N_to_M_relations_B_RelationEntryNHibernateImpl.N_to_M_relations_A_connectsTo_N_to_M_relations_B_RelationEntryProxy, Kistl.App.Test.N_to_M_relations_A_connectsTo_N_to_M_relations_B_RelationEntryNHibernateImpl>(
                                this.Proxy.ASide,
                                p => (Kistl.App.Test.N_to_M_relations_A_connectsTo_N_to_M_relations_B_RelationEntryNHibernateImpl)OurContext.AttachAndWrap(p),
                                ce => (Kistl.App.Test.N_to_M_relations_A_connectsTo_N_to_M_relations_B_RelationEntryNHibernateImpl.N_to_M_relations_A_connectsTo_N_to_M_relations_B_RelationEntryProxy)((NHibernatePersistenceObject)ce).NHibernateProxy),
                            entry => (IRelationListSync<Kistl.App.Test.N_to_M_relations_A_connectsTo_N_to_M_relations_B_RelationEntryNHibernateImpl>)entry.A.BSide);
                    if (ASide_was_eagerLoaded) { ASide_was_eagerLoaded = false; }
				}
				return (ICollection<Kistl.App.Test.N_to_M_relations_A>)_ASide;
			}
		}

		private NHibernateASideCollectionWrapper<Kistl.App.Test.N_to_M_relations_A, Kistl.App.Test.N_to_M_relations_B, Kistl.App.Test.N_to_M_relations_A_connectsTo_N_to_M_relations_B_RelationEntryNHibernateImpl> _ASide;
		// ignored, but required for Serialization
        private bool ASide_was_eagerLoaded = false;

        public event PropertyIsValidHandler<Kistl.App.Test.N_to_M_relations_B> OnASide_IsValid;

        /// <summary>
        /// 
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
		public static event PropertyGetterHandler<Kistl.App.Test.N_to_M_relations_B, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.N_to_M_relations_B, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.N_to_M_relations_B, string> OnName_PostSetter;

        public event PropertyIsValidHandler<Kistl.App.Test.N_to_M_relations_B> OnName_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(N_to_M_relations_B);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (N_to_M_relations_B)obj;
            var otherImpl = (N_to_M_relations_BNHibernateImpl)obj;
            var me = (N_to_M_relations_B)this;

            me.Name = other.Name;
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
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorNHibernateImpl<N_to_M_relations_B, ICollection<Kistl.App.Test.N_to_M_relations_A>>(
                        lazyCtx,
                        new Guid("a741d6bd-8a87-44c2-83b3-69225661f958"),
                        "ASide",
                        null,
                        obj => obj.ASide,
                        null, // lists are read-only properties
                        obj => ((N_to_M_relations_BNHibernateImpl)obj).OnASide_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<N_to_M_relations_B, string>(
                        lazyCtx,
                        new Guid("80ec9efe-c73b-4554-a145-064a32f225b8"),
                        "Name",
                        null,
                        obj => ((N_to_M_relations_BNHibernateImpl)obj).Name,
                        (obj, val) => obj.Name = val,
						obj => ((N_to_M_relations_BNHibernateImpl)obj).OnName_IsValid), 
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
        [EventBasedMethod("OnToString_N_to_M_relations_B")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_N_to_M_relations_B != null)
            {
                OnToString_N_to_M_relations_B(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<N_to_M_relations_B> OnToString_N_to_M_relations_B;

        [EventBasedMethod("OnPreSave_N_to_M_relations_B")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_N_to_M_relations_B != null) OnPreSave_N_to_M_relations_B(this);
        }
        public static event ObjectEventHandler<N_to_M_relations_B> OnPreSave_N_to_M_relations_B;

        [EventBasedMethod("OnPostSave_N_to_M_relations_B")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_N_to_M_relations_B != null) OnPostSave_N_to_M_relations_B(this);
        }
        public static event ObjectEventHandler<N_to_M_relations_B> OnPostSave_N_to_M_relations_B;

        [EventBasedMethod("OnCreated_N_to_M_relations_B")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_N_to_M_relations_B != null) OnCreated_N_to_M_relations_B(this);
        }
        public static event ObjectEventHandler<N_to_M_relations_B> OnCreated_N_to_M_relations_B;

        [EventBasedMethod("OnDeleting_N_to_M_relations_B")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_N_to_M_relations_B != null) OnDeleting_N_to_M_relations_B(this);
        }
        public static event ObjectEventHandler<N_to_M_relations_B> OnDeleting_N_to_M_relations_B;

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


        public class N_to_M_relations_BProxy
            : IProxyObject, ISortKey<int>
        {
            public N_to_M_relations_BProxy()
            {
                ASide = new Collection<Kistl.App.Test.N_to_M_relations_A_connectsTo_N_to_M_relations_B_RelationEntryNHibernateImpl.N_to_M_relations_A_connectsTo_N_to_M_relations_B_RelationEntryProxy>();
            }

            public virtual int ID { get; set; }

            public virtual Type ZBoxWrapper { get { return typeof(N_to_M_relations_BNHibernateImpl); } }
            public virtual Type ZBoxProxy { get { return typeof(N_to_M_relations_BProxy); } }

            public virtual ICollection<Kistl.App.Test.N_to_M_relations_A_connectsTo_N_to_M_relations_B_RelationEntryNHibernateImpl.N_to_M_relations_A_connectsTo_N_to_M_relations_B_RelationEntryProxy> ASide { get; set; }

            public virtual string Name { get; set; }

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