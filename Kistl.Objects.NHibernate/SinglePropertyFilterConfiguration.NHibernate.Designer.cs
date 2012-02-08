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

    using Kistl.API.Utils;
    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.NHibernate;

    /// <summary>
    /// Filter configuration for filtering on a single value of a Property 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("SinglePropertyFilterConfiguration")]
    public class SinglePropertyFilterConfigurationNHibernateImpl : Kistl.App.GUI.PropertyFilterConfigurationNHibernateImpl, SinglePropertyFilterConfiguration
    {
        public SinglePropertyFilterConfigurationNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public SinglePropertyFilterConfigurationNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new SinglePropertyFilterConfigurationProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public SinglePropertyFilterConfigurationNHibernateImpl(Func<IFrozenContext> lazyCtx, SinglePropertyFilterConfigurationProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly SinglePropertyFilterConfigurationProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnCreateFilterModel_SinglePropertyFilterConfiguration")]
        public override Kistl.API.IFilterModel CreateFilterModel()
        {
            var e = new MethodReturnEventArgs<Kistl.API.IFilterModel>();
            if (OnCreateFilterModel_SinglePropertyFilterConfiguration != null)
            {
                OnCreateFilterModel_SinglePropertyFilterConfiguration(this, e);
            }
            else
            {
                e.Result = base.CreateFilterModel();
            }
            return e.Result;
        }
        public static event CreateFilterModel_Handler<SinglePropertyFilterConfiguration> OnCreateFilterModel_SinglePropertyFilterConfiguration;
		// CanExec
		public static event CanExecMethodEventHandler<SinglePropertyFilterConfiguration> OnCreateFilterModel_SinglePropertyFilterConfiguration_CanExec;

        [EventBasedMethod("OnCreateFilterModel_SinglePropertyFilterConfiguration_CanExec")]
        public override bool CreateFilterModelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnCreateFilterModel_SinglePropertyFilterConfiguration_CanExec != null)
				{
					OnCreateFilterModel_SinglePropertyFilterConfiguration_CanExec(this, e);
				}
				else
				{
					e.Result = base.CreateFilterModelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<SinglePropertyFilterConfiguration> OnCreateFilterModel_SinglePropertyFilterConfiguration_CanExecReason;

        [EventBasedMethod("OnCreateFilterModel_SinglePropertyFilterConfiguration_CanExecReason")]
        public override string CreateFilterModelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnCreateFilterModel_SinglePropertyFilterConfiguration_CanExecReason != null)
				{
					OnCreateFilterModel_SinglePropertyFilterConfiguration_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.CreateFilterModelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_SinglePropertyFilterConfiguration")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_SinglePropertyFilterConfiguration != null)
            {
                OnGetLabel_SinglePropertyFilterConfiguration(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<SinglePropertyFilterConfiguration> OnGetLabel_SinglePropertyFilterConfiguration;
		// CanExec
		public static event CanExecMethodEventHandler<SinglePropertyFilterConfiguration> OnGetLabel_SinglePropertyFilterConfiguration_CanExec;

        [EventBasedMethod("OnGetLabel_SinglePropertyFilterConfiguration_CanExec")]
        public override bool GetLabelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabel_SinglePropertyFilterConfiguration_CanExec != null)
				{
					OnGetLabel_SinglePropertyFilterConfiguration_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<SinglePropertyFilterConfiguration> OnGetLabel_SinglePropertyFilterConfiguration_CanExecReason;

        [EventBasedMethod("OnGetLabel_SinglePropertyFilterConfiguration_CanExecReason")]
        public override string GetLabelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabel_SinglePropertyFilterConfiguration_CanExecReason != null)
				{
					OnGetLabel_SinglePropertyFilterConfiguration_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(SinglePropertyFilterConfiguration);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (SinglePropertyFilterConfiguration)obj;
            var otherImpl = (SinglePropertyFilterConfigurationNHibernateImpl)obj;
            var me = (SinglePropertyFilterConfiguration)this;

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
        #endregion // Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_SinglePropertyFilterConfiguration")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_SinglePropertyFilterConfiguration != null)
            {
                OnToString_SinglePropertyFilterConfiguration(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<SinglePropertyFilterConfiguration> OnToString_SinglePropertyFilterConfiguration;

        [EventBasedMethod("OnPreSave_SinglePropertyFilterConfiguration")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_SinglePropertyFilterConfiguration != null) OnPreSave_SinglePropertyFilterConfiguration(this);
        }
        public static event ObjectEventHandler<SinglePropertyFilterConfiguration> OnPreSave_SinglePropertyFilterConfiguration;

        [EventBasedMethod("OnPostSave_SinglePropertyFilterConfiguration")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_SinglePropertyFilterConfiguration != null) OnPostSave_SinglePropertyFilterConfiguration(this);
        }
        public static event ObjectEventHandler<SinglePropertyFilterConfiguration> OnPostSave_SinglePropertyFilterConfiguration;

        [EventBasedMethod("OnCreated_SinglePropertyFilterConfiguration")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_SinglePropertyFilterConfiguration != null) OnCreated_SinglePropertyFilterConfiguration(this);
        }
        public static event ObjectEventHandler<SinglePropertyFilterConfiguration> OnCreated_SinglePropertyFilterConfiguration;

        [EventBasedMethod("OnDeleting_SinglePropertyFilterConfiguration")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_SinglePropertyFilterConfiguration != null) OnDeleting_SinglePropertyFilterConfiguration(this);
        }
        public static event ObjectEventHandler<SinglePropertyFilterConfiguration> OnDeleting_SinglePropertyFilterConfiguration;

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


        public class SinglePropertyFilterConfigurationProxy
            : Kistl.App.GUI.PropertyFilterConfigurationNHibernateImpl.PropertyFilterConfigurationProxy
        {
            public SinglePropertyFilterConfigurationProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(SinglePropertyFilterConfigurationNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(SinglePropertyFilterConfigurationProxy); } }

        }

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
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
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
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
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
        }

        #endregion

    }
}