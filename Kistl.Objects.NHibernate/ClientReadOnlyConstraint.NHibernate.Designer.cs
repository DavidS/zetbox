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
    /// Item is readonly on client but changable on the server
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("ClientReadOnlyConstraint")]
    public class ClientReadOnlyConstraintNHibernateImpl : Kistl.App.Base.ReadOnlyConstraintNHibernateImpl, ClientReadOnlyConstraint
    {
        public ClientReadOnlyConstraintNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public ClientReadOnlyConstraintNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new ClientReadOnlyConstraintProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public ClientReadOnlyConstraintNHibernateImpl(Func<IFrozenContext> lazyCtx, ClientReadOnlyConstraintProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly ClientReadOnlyConstraintProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetErrorText_ClientReadOnlyConstraint")]
        public override string GetErrorText(System.Object constrainedObject, System.Object constrainedValue)
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetErrorText_ClientReadOnlyConstraint != null)
            {
                OnGetErrorText_ClientReadOnlyConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.GetErrorText(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
        public static event GetErrorText_Handler<ClientReadOnlyConstraint> OnGetErrorText_ClientReadOnlyConstraint;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ClientReadOnlyConstraint> OnGetErrorText_ClientReadOnlyConstraint_CanExec;

        [EventBasedMethod("OnGetErrorText_ClientReadOnlyConstraint_CanExec")]
        public override bool GetErrorTextCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetErrorText_ClientReadOnlyConstraint_CanExec != null)
				{
					OnGetErrorText_ClientReadOnlyConstraint_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetErrorTextCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ClientReadOnlyConstraint> OnGetErrorText_ClientReadOnlyConstraint_CanExecReason;

        [EventBasedMethod("OnGetErrorText_ClientReadOnlyConstraint_CanExecReason")]
        public override string GetErrorTextCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetErrorText_ClientReadOnlyConstraint_CanExecReason != null)
				{
					OnGetErrorText_ClientReadOnlyConstraint_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetErrorTextCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnIsValid_ClientReadOnlyConstraint")]
        public override bool IsValid(System.Object constrainedObject, System.Object constrainedValue)
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnIsValid_ClientReadOnlyConstraint != null)
            {
                OnIsValid_ClientReadOnlyConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.IsValid(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
        public static event IsValid_Handler<ClientReadOnlyConstraint> OnIsValid_ClientReadOnlyConstraint;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ClientReadOnlyConstraint> OnIsValid_ClientReadOnlyConstraint_CanExec;

        [EventBasedMethod("OnIsValid_ClientReadOnlyConstraint_CanExec")]
        public override bool IsValidCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnIsValid_ClientReadOnlyConstraint_CanExec != null)
				{
					OnIsValid_ClientReadOnlyConstraint_CanExec(this, e);
				}
				else
				{
					e.Result = base.IsValidCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ClientReadOnlyConstraint> OnIsValid_ClientReadOnlyConstraint_CanExecReason;

        [EventBasedMethod("OnIsValid_ClientReadOnlyConstraint_CanExecReason")]
        public override string IsValidCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnIsValid_ClientReadOnlyConstraint_CanExecReason != null)
				{
					OnIsValid_ClientReadOnlyConstraint_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.IsValidCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(ClientReadOnlyConstraint);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (ClientReadOnlyConstraint)obj;
            var otherImpl = (ClientReadOnlyConstraintNHibernateImpl)obj;
            var me = (ClientReadOnlyConstraint)this;

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
        [EventBasedMethod("OnToString_ClientReadOnlyConstraint")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ClientReadOnlyConstraint != null)
            {
                OnToString_ClientReadOnlyConstraint(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<ClientReadOnlyConstraint> OnToString_ClientReadOnlyConstraint;

		[System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_ClientReadOnlyConstraint")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
			var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
			e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_ClientReadOnlyConstraint != null)
            {
                OnObjectIsValid_ClientReadOnlyConstraint(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<ClientReadOnlyConstraint> OnObjectIsValid_ClientReadOnlyConstraint;

        [EventBasedMethod("OnNotifyPreSave_ClientReadOnlyConstraint")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_ClientReadOnlyConstraint != null) OnNotifyPreSave_ClientReadOnlyConstraint(this);
        }
        public static event ObjectEventHandler<ClientReadOnlyConstraint> OnNotifyPreSave_ClientReadOnlyConstraint;

        [EventBasedMethod("OnNotifyPostSave_ClientReadOnlyConstraint")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_ClientReadOnlyConstraint != null) OnNotifyPostSave_ClientReadOnlyConstraint(this);
        }
        public static event ObjectEventHandler<ClientReadOnlyConstraint> OnNotifyPostSave_ClientReadOnlyConstraint;

        [EventBasedMethod("OnNotifyCreated_ClientReadOnlyConstraint")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_ClientReadOnlyConstraint != null) OnNotifyCreated_ClientReadOnlyConstraint(this);
        }
        public static event ObjectEventHandler<ClientReadOnlyConstraint> OnNotifyCreated_ClientReadOnlyConstraint;

        [EventBasedMethod("OnNotifyDeleting_ClientReadOnlyConstraint")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_ClientReadOnlyConstraint != null) OnNotifyDeleting_ClientReadOnlyConstraint(this);
        }
        public static event ObjectEventHandler<ClientReadOnlyConstraint> OnNotifyDeleting_ClientReadOnlyConstraint;

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


        public class ClientReadOnlyConstraintProxy
            : Kistl.App.Base.ReadOnlyConstraintNHibernateImpl.ReadOnlyConstraintProxy
        {
            public ClientReadOnlyConstraintProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(ClientReadOnlyConstraintNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(ClientReadOnlyConstraintProxy); } }

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