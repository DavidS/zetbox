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

    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Zetbox.API.Server;
    using Zetbox.DalProvider.Ef;

    /// <summary>
    /// Metadefinition Object for Decimal Parameter.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="DecimalParameterEfImpl")]
    [System.Diagnostics.DebuggerDisplay("DecimalParameter")]
    public class DecimalParameterEfImpl : Zetbox.App.Base.BaseParameterEfImpl, DecimalParameter
    {
        private static readonly Guid _objectClassID = new Guid("f839cf8c-4cd4-4351-bbfe-d599a93af226");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public DecimalParameterEfImpl()
            : base(null)
        {
        }

        public DecimalParameterEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_DecimalParameter")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_DecimalParameter != null)
            {
                OnGetLabel_DecimalParameter(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<DecimalParameter> OnGetLabel_DecimalParameter;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<DecimalParameter> OnGetLabel_DecimalParameter_CanExec;

        [EventBasedMethod("OnGetLabel_DecimalParameter_CanExec")]
        public override bool GetLabelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabel_DecimalParameter_CanExec != null)
				{
					OnGetLabel_DecimalParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<DecimalParameter> OnGetLabel_DecimalParameter_CanExecReason;

        [EventBasedMethod("OnGetLabel_DecimalParameter_CanExecReason")]
        public override string GetLabelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabel_DecimalParameter_CanExecReason != null)
				{
					OnGetLabel_DecimalParameter_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Returns the resulting Type of this Method-Parameter Meta Object.
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetParameterType_DecimalParameter")]
        public override System.Type GetParameterType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetParameterType_DecimalParameter != null)
            {
                OnGetParameterType_DecimalParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterType();
            }
            return e.Result;
        }
        public static event GetParameterType_Handler<DecimalParameter> OnGetParameterType_DecimalParameter;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<DecimalParameter> OnGetParameterType_DecimalParameter_CanExec;

        [EventBasedMethod("OnGetParameterType_DecimalParameter_CanExec")]
        public override bool GetParameterTypeCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetParameterType_DecimalParameter_CanExec != null)
				{
					OnGetParameterType_DecimalParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<DecimalParameter> OnGetParameterType_DecimalParameter_CanExecReason;

        [EventBasedMethod("OnGetParameterType_DecimalParameter_CanExecReason")]
        public override string GetParameterTypeCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetParameterType_DecimalParameter_CanExecReason != null)
				{
					OnGetParameterType_DecimalParameter_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Returns the String representation of this Method-Parameter Meta Object.
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetParameterTypeString_DecimalParameter")]
        public override string GetParameterTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetParameterTypeString_DecimalParameter != null)
            {
                OnGetParameterTypeString_DecimalParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterTypeString();
            }
            return e.Result;
        }
        public static event GetParameterTypeString_Handler<DecimalParameter> OnGetParameterTypeString_DecimalParameter;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<DecimalParameter> OnGetParameterTypeString_DecimalParameter_CanExec;

        [EventBasedMethod("OnGetParameterTypeString_DecimalParameter_CanExec")]
        public override bool GetParameterTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetParameterTypeString_DecimalParameter_CanExec != null)
				{
					OnGetParameterTypeString_DecimalParameter_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<DecimalParameter> OnGetParameterTypeString_DecimalParameter_CanExecReason;

        [EventBasedMethod("OnGetParameterTypeString_DecimalParameter_CanExecReason")]
        public override string GetParameterTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetParameterTypeString_DecimalParameter_CanExecReason != null)
				{
					OnGetParameterTypeString_DecimalParameter_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetParameterTypeStringCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(DecimalParameter);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (DecimalParameter)obj;
            var otherImpl = (DecimalParameterEfImpl)obj;
            var me = (DecimalParameter)this;

        }
        public override void SetNew()
        {
            base.SetNew();
        }
        #region Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

        #endregion // Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

        public override Zetbox.API.Async.ZbTask TriggerFetch(string propName)
        {
            switch(propName)
            {
            default:
                return base.TriggerFetch(propName);
            }
        }

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
        [EventBasedMethod("OnToString_DecimalParameter")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DecimalParameter != null)
            {
                OnToString_DecimalParameter(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<DecimalParameter> OnToString_DecimalParameter;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_DecimalParameter")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_DecimalParameter != null)
            {
                OnObjectIsValid_DecimalParameter(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<DecimalParameter> OnObjectIsValid_DecimalParameter;

        [EventBasedMethod("OnNotifyPreSave_DecimalParameter")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_DecimalParameter != null) OnNotifyPreSave_DecimalParameter(this);
        }
        public static event ObjectEventHandler<DecimalParameter> OnNotifyPreSave_DecimalParameter;

        [EventBasedMethod("OnNotifyPostSave_DecimalParameter")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_DecimalParameter != null) OnNotifyPostSave_DecimalParameter(this);
        }
        public static event ObjectEventHandler<DecimalParameter> OnNotifyPostSave_DecimalParameter;

        [EventBasedMethod("OnNotifyCreated_DecimalParameter")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_DecimalParameter != null) OnNotifyCreated_DecimalParameter(this);
        }
        public static event ObjectEventHandler<DecimalParameter> OnNotifyCreated_DecimalParameter;

        [EventBasedMethod("OnNotifyDeleting_DecimalParameter")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_DecimalParameter != null) OnNotifyDeleting_DecimalParameter(this);
        }
        public static event ObjectEventHandler<DecimalParameter> OnNotifyDeleting_DecimalParameter;

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