// <autogenerated/>

namespace Kistl.App.Calendar
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
    /// This rule applies every year. This class is abstract.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("YearlyCalendarRule")]
    public abstract class YearlyCalendarRuleNHibernateImpl : Kistl.App.Calendar.CalendarRuleNHibernateImpl, YearlyCalendarRule
    {
        public YearlyCalendarRuleNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public YearlyCalendarRuleNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new YearlyCalendarRuleProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public YearlyCalendarRuleNHibernateImpl(Func<IFrozenContext> lazyCtx, YearlyCalendarRuleProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly YearlyCalendarRuleProxy Proxy;

        /// <summary>
        /// Checks if the Rule applies to the given date
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
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
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
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
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(YearlyCalendarRule);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (YearlyCalendarRule)obj;
            var otherImpl = (YearlyCalendarRuleNHibernateImpl)obj;
            var me = (YearlyCalendarRule)this;

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


        public class YearlyCalendarRuleProxy
            : Kistl.App.Calendar.CalendarRuleNHibernateImpl.CalendarRuleProxy
        {
            public YearlyCalendarRuleProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(YearlyCalendarRuleNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(YearlyCalendarRuleProxy); } }

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