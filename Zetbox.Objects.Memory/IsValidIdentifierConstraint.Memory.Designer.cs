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

    using Zetbox.DalProvider.Base;
    using Zetbox.DalProvider.Memory;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("IsValidIdentifierConstraint")]
    public class IsValidIdentifierConstraintMemoryImpl : Zetbox.App.Base.ConstraintMemoryImpl, IsValidIdentifierConstraint
    {
        private static readonly Guid _objectClassID = new Guid("ed8f30ad-186f-48ee-8dd5-a153d24dfada");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public IsValidIdentifierConstraintMemoryImpl()
            : base(null)
        {
        }

        public IsValidIdentifierConstraintMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetErrorText_IsValidIdentifierConstraint")]
        public override string GetErrorText(System.Object constrainedObject, System.Object constrainedValue)
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetErrorText_IsValidIdentifierConstraint != null)
            {
                OnGetErrorText_IsValidIdentifierConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.GetErrorText(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
        public static event GetErrorText_Handler<IsValidIdentifierConstraint> OnGetErrorText_IsValidIdentifierConstraint;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<IsValidIdentifierConstraint> OnGetErrorText_IsValidIdentifierConstraint_CanExec;

        [EventBasedMethod("OnGetErrorText_IsValidIdentifierConstraint_CanExec")]
        public override bool GetErrorTextCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetErrorText_IsValidIdentifierConstraint_CanExec != null)
				{
					OnGetErrorText_IsValidIdentifierConstraint_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetErrorTextCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<IsValidIdentifierConstraint> OnGetErrorText_IsValidIdentifierConstraint_CanExecReason;

        [EventBasedMethod("OnGetErrorText_IsValidIdentifierConstraint_CanExecReason")]
        public override string GetErrorTextCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetErrorText_IsValidIdentifierConstraint_CanExecReason != null)
				{
					OnGetErrorText_IsValidIdentifierConstraint_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetErrorTextCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnIsValid_IsValidIdentifierConstraint")]
        public override bool IsValid(System.Object constrainedObject, System.Object constrainedValue)
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnIsValid_IsValidIdentifierConstraint != null)
            {
                OnIsValid_IsValidIdentifierConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.IsValid(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
        public static event IsValid_Handler<IsValidIdentifierConstraint> OnIsValid_IsValidIdentifierConstraint;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<IsValidIdentifierConstraint> OnIsValid_IsValidIdentifierConstraint_CanExec;

        [EventBasedMethod("OnIsValid_IsValidIdentifierConstraint_CanExec")]
        public override bool IsValidCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnIsValid_IsValidIdentifierConstraint_CanExec != null)
				{
					OnIsValid_IsValidIdentifierConstraint_CanExec(this, e);
				}
				else
				{
					e.Result = base.IsValidCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<IsValidIdentifierConstraint> OnIsValid_IsValidIdentifierConstraint_CanExecReason;

        [EventBasedMethod("OnIsValid_IsValidIdentifierConstraint_CanExecReason")]
        public override string IsValidCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnIsValid_IsValidIdentifierConstraint_CanExecReason != null)
				{
					OnIsValid_IsValidIdentifierConstraint_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.IsValidCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(IsValidIdentifierConstraint);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (IsValidIdentifierConstraint)obj;
            var otherImpl = (IsValidIdentifierConstraintMemoryImpl)obj;
            var me = (IsValidIdentifierConstraint)this;

        }

        public override void AttachToContext(IZetboxContext ctx, Func<IFrozenContext> lazyFrozenContext)
        {
            base.AttachToContext(ctx, lazyFrozenContext);
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        #region Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

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
        #endregion // Zetbox.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_IsValidIdentifierConstraint")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_IsValidIdentifierConstraint != null)
            {
                OnToString_IsValidIdentifierConstraint(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<IsValidIdentifierConstraint> OnToString_IsValidIdentifierConstraint;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_IsValidIdentifierConstraint")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_IsValidIdentifierConstraint != null)
            {
                OnObjectIsValid_IsValidIdentifierConstraint(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<IsValidIdentifierConstraint> OnObjectIsValid_IsValidIdentifierConstraint;

        [EventBasedMethod("OnNotifyPreSave_IsValidIdentifierConstraint")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_IsValidIdentifierConstraint != null) OnNotifyPreSave_IsValidIdentifierConstraint(this);
        }
        public static event ObjectEventHandler<IsValidIdentifierConstraint> OnNotifyPreSave_IsValidIdentifierConstraint;

        [EventBasedMethod("OnNotifyPostSave_IsValidIdentifierConstraint")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_IsValidIdentifierConstraint != null) OnNotifyPostSave_IsValidIdentifierConstraint(this);
        }
        public static event ObjectEventHandler<IsValidIdentifierConstraint> OnNotifyPostSave_IsValidIdentifierConstraint;

        [EventBasedMethod("OnNotifyCreated_IsValidIdentifierConstraint")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_IsValidIdentifierConstraint != null) OnNotifyCreated_IsValidIdentifierConstraint(this);
        }
        public static event ObjectEventHandler<IsValidIdentifierConstraint> OnNotifyCreated_IsValidIdentifierConstraint;

        [EventBasedMethod("OnNotifyDeleting_IsValidIdentifierConstraint")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_IsValidIdentifierConstraint != null) OnNotifyDeleting_IsValidIdentifierConstraint(this);
        }
        public static event ObjectEventHandler<IsValidIdentifierConstraint> OnNotifyDeleting_IsValidIdentifierConstraint;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
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