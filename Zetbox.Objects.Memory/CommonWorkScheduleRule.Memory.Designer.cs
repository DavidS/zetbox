// <autogenerated/>

namespace Zetbox.App.Calendar
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
    /// This rule applies every day
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("CommonWorkScheduleRule")]
    public class CommonWorkScheduleRuleMemoryImpl : Zetbox.App.Calendar.WorkScheduleRuleMemoryImpl, CommonWorkScheduleRule
    {
        private static readonly Guid _objectClassID = new Guid("198bab3d-85a9-4d11-99e1-5e3f9420bdae");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public CommonWorkScheduleRuleMemoryImpl()
            : base(null)
        {
        }

        public CommonWorkScheduleRuleMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// Checks if the Rule applies to the given date
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnAppliesTo_CommonWorkScheduleRule")]
        public override bool AppliesTo(DateTime date)
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnAppliesTo_CommonWorkScheduleRule != null)
            {
                OnAppliesTo_CommonWorkScheduleRule(this, e, date);
            }
            else
            {
                e.Result = base.AppliesTo(date);
            }
            return e.Result;
        }
        public static event AppliesTo_Handler<CommonWorkScheduleRule> OnAppliesTo_CommonWorkScheduleRule;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<CommonWorkScheduleRule> OnAppliesTo_CommonWorkScheduleRule_CanExec;

        [EventBasedMethod("OnAppliesTo_CommonWorkScheduleRule_CanExec")]
        public override bool AppliesToCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnAppliesTo_CommonWorkScheduleRule_CanExec != null)
				{
					OnAppliesTo_CommonWorkScheduleRule_CanExec(this, e);
				}
				else
				{
					e.Result = base.AppliesToCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CommonWorkScheduleRule> OnAppliesTo_CommonWorkScheduleRule_CanExecReason;

        [EventBasedMethod("OnAppliesTo_CommonWorkScheduleRule_CanExecReason")]
        public override string AppliesToCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnAppliesTo_CommonWorkScheduleRule_CanExecReason != null)
				{
					OnAppliesTo_CommonWorkScheduleRule_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.AppliesToCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(CommonWorkScheduleRule);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (CommonWorkScheduleRule)obj;
            var otherImpl = (CommonWorkScheduleRuleMemoryImpl)obj;
            var me = (CommonWorkScheduleRule)this;

        }
        public override void SetNew()
        {
            base.SetNew();
        }

        #region Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        #endregion // Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

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
            // fix cached lists references
        }
        #region Zetbox.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #endregion // Zetbox.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_CommonWorkScheduleRule")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_CommonWorkScheduleRule != null)
            {
                OnToString_CommonWorkScheduleRule(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<CommonWorkScheduleRule> OnToString_CommonWorkScheduleRule;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_CommonWorkScheduleRule")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_CommonWorkScheduleRule != null)
            {
                OnObjectIsValid_CommonWorkScheduleRule(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<CommonWorkScheduleRule> OnObjectIsValid_CommonWorkScheduleRule;

        [EventBasedMethod("OnNotifyPreSave_CommonWorkScheduleRule")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_CommonWorkScheduleRule != null) OnNotifyPreSave_CommonWorkScheduleRule(this);
        }
        public static event ObjectEventHandler<CommonWorkScheduleRule> OnNotifyPreSave_CommonWorkScheduleRule;

        [EventBasedMethod("OnNotifyPostSave_CommonWorkScheduleRule")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_CommonWorkScheduleRule != null) OnNotifyPostSave_CommonWorkScheduleRule(this);
        }
        public static event ObjectEventHandler<CommonWorkScheduleRule> OnNotifyPostSave_CommonWorkScheduleRule;

        [EventBasedMethod("OnNotifyCreated_CommonWorkScheduleRule")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_CommonWorkScheduleRule != null) OnNotifyCreated_CommonWorkScheduleRule(this);
        }
        public static event ObjectEventHandler<CommonWorkScheduleRule> OnNotifyCreated_CommonWorkScheduleRule;

        [EventBasedMethod("OnNotifyDeleting_CommonWorkScheduleRule")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_CommonWorkScheduleRule != null) OnNotifyDeleting_CommonWorkScheduleRule(this);
        }
        public static event ObjectEventHandler<CommonWorkScheduleRule> OnNotifyDeleting_CommonWorkScheduleRule;

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