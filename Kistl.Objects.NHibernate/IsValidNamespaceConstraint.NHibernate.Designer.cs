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
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("IsValidNamespaceConstraint")]
    public class IsValidNamespaceConstraintNHibernateImpl : Kistl.App.Base.IsValidIdentifierConstraintNHibernateImpl, IsValidNamespaceConstraint
    {
        public IsValidNamespaceConstraintNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public IsValidNamespaceConstraintNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new IsValidNamespaceConstraintProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public IsValidNamespaceConstraintNHibernateImpl(Func<IFrozenContext> lazyCtx, IsValidNamespaceConstraintProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly IsValidNamespaceConstraintProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetErrorText_IsValidNamespaceConstraint")]
        public override string GetErrorText(System.Object constrainedObject, System.Object constrainedValue)
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetErrorText_IsValidNamespaceConstraint != null)
            {
                OnGetErrorText_IsValidNamespaceConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.GetErrorText(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
        public static event GetErrorText_Handler<IsValidNamespaceConstraint> OnGetErrorText_IsValidNamespaceConstraint;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<IsValidNamespaceConstraint> OnGetErrorText_IsValidNamespaceConstraint_CanExec;

        [EventBasedMethod("OnGetErrorText_IsValidNamespaceConstraint_CanExec")]
        public override bool GetErrorTextCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetErrorText_IsValidNamespaceConstraint_CanExec != null)
				{
					OnGetErrorText_IsValidNamespaceConstraint_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetErrorTextCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<IsValidNamespaceConstraint> OnGetErrorText_IsValidNamespaceConstraint_CanExecReason;

        [EventBasedMethod("OnGetErrorText_IsValidNamespaceConstraint_CanExecReason")]
        public override string GetErrorTextCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetErrorText_IsValidNamespaceConstraint_CanExecReason != null)
				{
					OnGetErrorText_IsValidNamespaceConstraint_CanExecReason(this, e);
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
        [EventBasedMethod("OnIsValid_IsValidNamespaceConstraint")]
        public override bool IsValid(System.Object constrainedObject, System.Object constrainedValue)
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnIsValid_IsValidNamespaceConstraint != null)
            {
                OnIsValid_IsValidNamespaceConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.IsValid(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
        public static event IsValid_Handler<IsValidNamespaceConstraint> OnIsValid_IsValidNamespaceConstraint;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<IsValidNamespaceConstraint> OnIsValid_IsValidNamespaceConstraint_CanExec;

        [EventBasedMethod("OnIsValid_IsValidNamespaceConstraint_CanExec")]
        public override bool IsValidCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnIsValid_IsValidNamespaceConstraint_CanExec != null)
				{
					OnIsValid_IsValidNamespaceConstraint_CanExec(this, e);
				}
				else
				{
					e.Result = base.IsValidCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<IsValidNamespaceConstraint> OnIsValid_IsValidNamespaceConstraint_CanExecReason;

        [EventBasedMethod("OnIsValid_IsValidNamespaceConstraint_CanExecReason")]
        public override string IsValidCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnIsValid_IsValidNamespaceConstraint_CanExecReason != null)
				{
					OnIsValid_IsValidNamespaceConstraint_CanExecReason(this, e);
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
            return typeof(IsValidNamespaceConstraint);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (IsValidNamespaceConstraint)obj;
            var otherImpl = (IsValidNamespaceConstraintNHibernateImpl)obj;
            var me = (IsValidNamespaceConstraint)this;

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
        [EventBasedMethod("OnToString_IsValidNamespaceConstraint")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_IsValidNamespaceConstraint != null)
            {
                OnToString_IsValidNamespaceConstraint(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<IsValidNamespaceConstraint> OnToString_IsValidNamespaceConstraint;

		[System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_IsValidNamespaceConstraint")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
			var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
			e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_IsValidNamespaceConstraint != null)
            {
                OnObjectIsValid_IsValidNamespaceConstraint(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<IsValidNamespaceConstraint> OnObjectIsValid_IsValidNamespaceConstraint;

        [EventBasedMethod("OnNotifyPreSave_IsValidNamespaceConstraint")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_IsValidNamespaceConstraint != null) OnNotifyPreSave_IsValidNamespaceConstraint(this);
        }
        public static event ObjectEventHandler<IsValidNamespaceConstraint> OnNotifyPreSave_IsValidNamespaceConstraint;

        [EventBasedMethod("OnNotifyPostSave_IsValidNamespaceConstraint")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_IsValidNamespaceConstraint != null) OnNotifyPostSave_IsValidNamespaceConstraint(this);
        }
        public static event ObjectEventHandler<IsValidNamespaceConstraint> OnNotifyPostSave_IsValidNamespaceConstraint;

        [EventBasedMethod("OnNotifyCreated_IsValidNamespaceConstraint")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_IsValidNamespaceConstraint != null) OnNotifyCreated_IsValidNamespaceConstraint(this);
        }
        public static event ObjectEventHandler<IsValidNamespaceConstraint> OnNotifyCreated_IsValidNamespaceConstraint;

        [EventBasedMethod("OnNotifyDeleting_IsValidNamespaceConstraint")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_IsValidNamespaceConstraint != null) OnNotifyDeleting_IsValidNamespaceConstraint(this);
        }
        public static event ObjectEventHandler<IsValidNamespaceConstraint> OnNotifyDeleting_IsValidNamespaceConstraint;

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


        public class IsValidNamespaceConstraintProxy
            : Kistl.App.Base.IsValidIdentifierConstraintNHibernateImpl.IsValidIdentifierConstraintProxy
        {
            public IsValidNamespaceConstraintProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(IsValidNamespaceConstraintNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(IsValidNamespaceConstraintProxy); } }

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