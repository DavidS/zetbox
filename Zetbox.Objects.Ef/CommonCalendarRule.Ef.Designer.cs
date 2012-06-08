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

    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Zetbox.API.Server;
    using Zetbox.DalProvider.Ef;

    /// <summary>
    /// This rule applies every day
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="CommonCalendarRule")]
    [System.Diagnostics.DebuggerDisplay("CommonCalendarRule")]
    public class CommonCalendarRuleEfImpl : Zetbox.App.Calendar.CalendarRuleEfImpl, CommonCalendarRule
    {
        private static readonly Guid _objectClassID = new Guid("198bab3d-85a9-4d11-99e1-5e3f9420bdae");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public CommonCalendarRuleEfImpl()
            : base(null)
        {
        }

        public CommonCalendarRuleEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// Checks if the Rule applies to the given date
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnAppliesTo_CommonCalendarRule")]
        public override bool AppliesTo(DateTime date)
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnAppliesTo_CommonCalendarRule != null)
            {
                OnAppliesTo_CommonCalendarRule(this, e, date);
            }
            else
            {
                e.Result = base.AppliesTo(date);
            }
            return e.Result;
        }
        public static event AppliesTo_Handler<CommonCalendarRule> OnAppliesTo_CommonCalendarRule;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<CommonCalendarRule> OnAppliesTo_CommonCalendarRule_CanExec;

        [EventBasedMethod("OnAppliesTo_CommonCalendarRule_CanExec")]
        public override bool AppliesToCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnAppliesTo_CommonCalendarRule_CanExec != null)
				{
					OnAppliesTo_CommonCalendarRule_CanExec(this, e);
				}
				else
				{
					e.Result = base.AppliesToCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CommonCalendarRule> OnAppliesTo_CommonCalendarRule_CanExecReason;

        [EventBasedMethod("OnAppliesTo_CommonCalendarRule_CanExecReason")]
        public override string AppliesToCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnAppliesTo_CommonCalendarRule_CanExecReason != null)
				{
					OnAppliesTo_CommonCalendarRule_CanExecReason(this, e);
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
            return typeof(CommonCalendarRule);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (CommonCalendarRule)obj;
            var otherImpl = (CommonCalendarRuleEfImpl)obj;
            var me = (CommonCalendarRule)this;

        }

        public override void AttachToContext(IZetboxContext ctx)
        {
            base.AttachToContext(ctx);
        }
        public override void SetNew()
        {
            base.SetNew();
        }
        #region Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

        #endregion // Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

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
        [EventBasedMethod("OnToString_CommonCalendarRule")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_CommonCalendarRule != null)
            {
                OnToString_CommonCalendarRule(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<CommonCalendarRule> OnToString_CommonCalendarRule;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_CommonCalendarRule")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_CommonCalendarRule != null)
            {
                OnObjectIsValid_CommonCalendarRule(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<CommonCalendarRule> OnObjectIsValid_CommonCalendarRule;

        [EventBasedMethod("OnNotifyPreSave_CommonCalendarRule")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_CommonCalendarRule != null) OnNotifyPreSave_CommonCalendarRule(this);
        }
        public static event ObjectEventHandler<CommonCalendarRule> OnNotifyPreSave_CommonCalendarRule;

        [EventBasedMethod("OnNotifyPostSave_CommonCalendarRule")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_CommonCalendarRule != null) OnNotifyPostSave_CommonCalendarRule(this);
        }
        public static event ObjectEventHandler<CommonCalendarRule> OnNotifyPostSave_CommonCalendarRule;

        [EventBasedMethod("OnNotifyCreated_CommonCalendarRule")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_CommonCalendarRule != null) OnNotifyCreated_CommonCalendarRule(this);
        }
        public static event ObjectEventHandler<CommonCalendarRule> OnNotifyCreated_CommonCalendarRule;

        [EventBasedMethod("OnNotifyDeleting_CommonCalendarRule")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_CommonCalendarRule != null) OnNotifyDeleting_CommonCalendarRule(this);
        }
        public static event ObjectEventHandler<CommonCalendarRule> OnNotifyDeleting_CommonCalendarRule;

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