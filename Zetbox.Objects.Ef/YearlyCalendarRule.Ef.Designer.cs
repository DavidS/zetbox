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

    using Zetbox.API.Server;
    using Zetbox.DalProvider.Ef;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// This rule applies every year. This class is abstract.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="YearlyCalendarRule")]
    [System.Diagnostics.DebuggerDisplay("YearlyCalendarRule")]
    public abstract class YearlyCalendarRuleEfImpl : Zetbox.App.Calendar.CalendarRuleEfImpl, YearlyCalendarRule
    {
        private static readonly Guid _objectClassID = new Guid("c4ba4a07-d4b7-4ae7-8621-0e9126ad18cc");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public YearlyCalendarRuleEfImpl()
            : base(null)
        {
        }

        public YearlyCalendarRuleEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// Checks if the Rule applies to the given date
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnAppliesTo_YearlyCalendarRule")]
        public override bool AppliesTo(DateTime date)
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnAppliesTo_YearlyCalendarRule != null)
            {
                OnAppliesTo_YearlyCalendarRule(this, e, date);
            }
            else
            {
                e.Result = base.AppliesTo(date);
            }
            return e.Result;
        }
        public static event AppliesTo_Handler<YearlyCalendarRule> OnAppliesTo_YearlyCalendarRule;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<YearlyCalendarRule> OnAppliesTo_YearlyCalendarRule_CanExec;

        [EventBasedMethod("OnAppliesTo_YearlyCalendarRule_CanExec")]
        public override bool AppliesToCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnAppliesTo_YearlyCalendarRule_CanExec != null)
				{
					OnAppliesTo_YearlyCalendarRule_CanExec(this, e);
				}
				else
				{
					e.Result = base.AppliesToCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<YearlyCalendarRule> OnAppliesTo_YearlyCalendarRule_CanExecReason;

        [EventBasedMethod("OnAppliesTo_YearlyCalendarRule_CanExecReason")]
        public override string AppliesToCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnAppliesTo_YearlyCalendarRule_CanExecReason != null)
				{
					OnAppliesTo_YearlyCalendarRule_CanExecReason(this, e);
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
            return typeof(YearlyCalendarRule);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (YearlyCalendarRule)obj;
            var otherImpl = (YearlyCalendarRuleEfImpl)obj;
            var me = (YearlyCalendarRule)this;

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
        [EventBasedMethod("OnToString_YearlyCalendarRule")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_YearlyCalendarRule != null)
            {
                OnToString_YearlyCalendarRule(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<YearlyCalendarRule> OnToString_YearlyCalendarRule;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_YearlyCalendarRule")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_YearlyCalendarRule != null)
            {
                OnObjectIsValid_YearlyCalendarRule(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<YearlyCalendarRule> OnObjectIsValid_YearlyCalendarRule;

        [EventBasedMethod("OnNotifyPreSave_YearlyCalendarRule")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_YearlyCalendarRule != null) OnNotifyPreSave_YearlyCalendarRule(this);
        }
        public static event ObjectEventHandler<YearlyCalendarRule> OnNotifyPreSave_YearlyCalendarRule;

        [EventBasedMethod("OnNotifyPostSave_YearlyCalendarRule")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_YearlyCalendarRule != null) OnNotifyPostSave_YearlyCalendarRule(this);
        }
        public static event ObjectEventHandler<YearlyCalendarRule> OnNotifyPostSave_YearlyCalendarRule;

        [EventBasedMethod("OnNotifyCreated_YearlyCalendarRule")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_YearlyCalendarRule != null) OnNotifyCreated_YearlyCalendarRule(this);
        }
        public static event ObjectEventHandler<YearlyCalendarRule> OnNotifyCreated_YearlyCalendarRule;

        [EventBasedMethod("OnNotifyDeleting_YearlyCalendarRule")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_YearlyCalendarRule != null) OnNotifyDeleting_YearlyCalendarRule(this);
        }
        public static event ObjectEventHandler<YearlyCalendarRule> OnNotifyDeleting_YearlyCalendarRule;

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