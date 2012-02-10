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
    /// Abstract base class for read only constraints
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("ReadOnlyConstraint")]
    public abstract class ReadOnlyConstraintNHibernateImpl : Kistl.App.Base.ConstraintNHibernateImpl, ReadOnlyConstraint
    {
        public ReadOnlyConstraintNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public ReadOnlyConstraintNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new ReadOnlyConstraintProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public ReadOnlyConstraintNHibernateImpl(Func<IFrozenContext> lazyCtx, ReadOnlyConstraintProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly ReadOnlyConstraintProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetErrorText_ReadOnlyConstraint")]
        public override string GetErrorText(System.Object constrainedObject, System.Object constrainedValue)
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetErrorText_ReadOnlyConstraint != null)
            {
                OnGetErrorText_ReadOnlyConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.GetErrorText(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
        public static event GetErrorText_Handler<ReadOnlyConstraint> OnGetErrorText_ReadOnlyConstraint;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ReadOnlyConstraint> OnGetErrorText_ReadOnlyConstraint_CanExec;

        [EventBasedMethod("OnGetErrorText_ReadOnlyConstraint_CanExec")]
        public override bool GetErrorTextCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetErrorText_ReadOnlyConstraint_CanExec != null)
				{
					OnGetErrorText_ReadOnlyConstraint_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetErrorTextCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ReadOnlyConstraint> OnGetErrorText_ReadOnlyConstraint_CanExecReason;

        [EventBasedMethod("OnGetErrorText_ReadOnlyConstraint_CanExecReason")]
        public override string GetErrorTextCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetErrorText_ReadOnlyConstraint_CanExecReason != null)
				{
					OnGetErrorText_ReadOnlyConstraint_CanExecReason(this, e);
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
        [EventBasedMethod("OnIsValid_ReadOnlyConstraint")]
        public override bool IsValid(System.Object constrainedObject, System.Object constrainedValue)
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnIsValid_ReadOnlyConstraint != null)
            {
                OnIsValid_ReadOnlyConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.IsValid(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
        public static event IsValid_Handler<ReadOnlyConstraint> OnIsValid_ReadOnlyConstraint;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<ReadOnlyConstraint> OnIsValid_ReadOnlyConstraint_CanExec;

        [EventBasedMethod("OnIsValid_ReadOnlyConstraint_CanExec")]
        public override bool IsValidCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnIsValid_ReadOnlyConstraint_CanExec != null)
				{
					OnIsValid_ReadOnlyConstraint_CanExec(this, e);
				}
				else
				{
					e.Result = base.IsValidCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<ReadOnlyConstraint> OnIsValid_ReadOnlyConstraint_CanExecReason;

        [EventBasedMethod("OnIsValid_ReadOnlyConstraint_CanExecReason")]
        public override string IsValidCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnIsValid_ReadOnlyConstraint_CanExecReason != null)
				{
					OnIsValid_ReadOnlyConstraint_CanExecReason(this, e);
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
            return typeof(ReadOnlyConstraint);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (ReadOnlyConstraint)obj;
            var otherImpl = (ReadOnlyConstraintNHibernateImpl)obj;
            var me = (ReadOnlyConstraint)this;

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
        [EventBasedMethod("OnToString_ReadOnlyConstraint")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ReadOnlyConstraint != null)
            {
                OnToString_ReadOnlyConstraint(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<ReadOnlyConstraint> OnToString_ReadOnlyConstraint;

		[System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_ReadOnlyConstraint")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
			var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
			e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_ReadOnlyConstraint != null)
            {
                OnObjectIsValid_ReadOnlyConstraint(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<ReadOnlyConstraint> OnObjectIsValid_ReadOnlyConstraint;

        [EventBasedMethod("OnNotifyPreSave_ReadOnlyConstraint")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_ReadOnlyConstraint != null) OnNotifyPreSave_ReadOnlyConstraint(this);
        }
        public static event ObjectEventHandler<ReadOnlyConstraint> OnNotifyPreSave_ReadOnlyConstraint;

        [EventBasedMethod("OnNotifyPostSave_ReadOnlyConstraint")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_ReadOnlyConstraint != null) OnNotifyPostSave_ReadOnlyConstraint(this);
        }
        public static event ObjectEventHandler<ReadOnlyConstraint> OnNotifyPostSave_ReadOnlyConstraint;

        [EventBasedMethod("OnNotifyCreated_ReadOnlyConstraint")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_ReadOnlyConstraint != null) OnNotifyCreated_ReadOnlyConstraint(this);
        }
        public static event ObjectEventHandler<ReadOnlyConstraint> OnNotifyCreated_ReadOnlyConstraint;

        [EventBasedMethod("OnNotifyDeleting_ReadOnlyConstraint")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_ReadOnlyConstraint != null) OnNotifyDeleting_ReadOnlyConstraint(this);
        }
        public static event ObjectEventHandler<ReadOnlyConstraint> OnNotifyDeleting_ReadOnlyConstraint;

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


        public class ReadOnlyConstraintProxy
            : Kistl.App.Base.ConstraintNHibernateImpl.ConstraintProxy
        {
            public ReadOnlyConstraintProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(ReadOnlyConstraintNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(ReadOnlyConstraintProxy); } }

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