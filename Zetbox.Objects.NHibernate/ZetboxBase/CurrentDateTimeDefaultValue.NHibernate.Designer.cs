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

    using Zetbox.API.Utils;
    using Zetbox.DalProvider.Base;
    using Zetbox.DalProvider.NHibernate;

    /// <summary>
    /// Sets the newly created DatetTme Property to DateTime.Now
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("CurrentDateTimeDefaultValue")]
    public class CurrentDateTimeDefaultValueNHibernateImpl : Zetbox.App.Base.DefaultPropertyValueNHibernateImpl, CurrentDateTimeDefaultValue
    {
        private static readonly Guid _objectClassID = new Guid("8b202069-2dd3-470c-bb3f-956f44884298");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public CurrentDateTimeDefaultValueNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public CurrentDateTimeDefaultValueNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new CurrentDateTimeDefaultValueProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public CurrentDateTimeDefaultValueNHibernateImpl(Func<IFrozenContext> lazyCtx, CurrentDateTimeDefaultValueProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly CurrentDateTimeDefaultValueProxy Proxy;

        /// <summary>
        /// GetDefaultValue
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDefaultValue_CurrentDateTimeDefaultValue")]
        public override System.Object GetDefaultValue()
        {
            var e = new MethodReturnEventArgs<System.Object>();
            if (OnGetDefaultValue_CurrentDateTimeDefaultValue != null)
            {
                OnGetDefaultValue_CurrentDateTimeDefaultValue(this, e);
            }
            else
            {
                e.Result = base.GetDefaultValue();
            }
            return e.Result;
        }
        public static event GetDefaultValue_Handler<CurrentDateTimeDefaultValue> OnGetDefaultValue_CurrentDateTimeDefaultValue;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<CurrentDateTimeDefaultValue> OnGetDefaultValue_CurrentDateTimeDefaultValue_CanExec;

        [EventBasedMethod("OnGetDefaultValue_CurrentDateTimeDefaultValue_CanExec")]
        public override bool GetDefaultValueCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetDefaultValue_CurrentDateTimeDefaultValue_CanExec != null)
				{
					OnGetDefaultValue_CurrentDateTimeDefaultValue_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetDefaultValueCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<CurrentDateTimeDefaultValue> OnGetDefaultValue_CurrentDateTimeDefaultValue_CanExecReason;

        [EventBasedMethod("OnGetDefaultValue_CurrentDateTimeDefaultValue_CanExecReason")]
        public override string GetDefaultValueCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetDefaultValue_CurrentDateTimeDefaultValue_CanExecReason != null)
				{
					OnGetDefaultValue_CurrentDateTimeDefaultValue_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetDefaultValueCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(CurrentDateTimeDefaultValue);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (CurrentDateTimeDefaultValue)obj;
            var otherImpl = (CurrentDateTimeDefaultValueNHibernateImpl)obj;
            var me = (CurrentDateTimeDefaultValue)this;

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
        }
        #region Zetbox.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #endregion // Zetbox.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_CurrentDateTimeDefaultValue")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_CurrentDateTimeDefaultValue != null)
            {
                OnToString_CurrentDateTimeDefaultValue(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<CurrentDateTimeDefaultValue> OnToString_CurrentDateTimeDefaultValue;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_CurrentDateTimeDefaultValue")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_CurrentDateTimeDefaultValue != null)
            {
                OnObjectIsValid_CurrentDateTimeDefaultValue(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<CurrentDateTimeDefaultValue> OnObjectIsValid_CurrentDateTimeDefaultValue;

        [EventBasedMethod("OnNotifyPreSave_CurrentDateTimeDefaultValue")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_CurrentDateTimeDefaultValue != null) OnNotifyPreSave_CurrentDateTimeDefaultValue(this);
        }
        public static event ObjectEventHandler<CurrentDateTimeDefaultValue> OnNotifyPreSave_CurrentDateTimeDefaultValue;

        [EventBasedMethod("OnNotifyPostSave_CurrentDateTimeDefaultValue")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_CurrentDateTimeDefaultValue != null) OnNotifyPostSave_CurrentDateTimeDefaultValue(this);
        }
        public static event ObjectEventHandler<CurrentDateTimeDefaultValue> OnNotifyPostSave_CurrentDateTimeDefaultValue;

        [EventBasedMethod("OnNotifyCreated_CurrentDateTimeDefaultValue")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_CurrentDateTimeDefaultValue != null) OnNotifyCreated_CurrentDateTimeDefaultValue(this);
        }
        public static event ObjectEventHandler<CurrentDateTimeDefaultValue> OnNotifyCreated_CurrentDateTimeDefaultValue;

        [EventBasedMethod("OnNotifyDeleting_CurrentDateTimeDefaultValue")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_CurrentDateTimeDefaultValue != null) OnNotifyDeleting_CurrentDateTimeDefaultValue(this);


        }
        public static event ObjectEventHandler<CurrentDateTimeDefaultValue> OnNotifyDeleting_CurrentDateTimeDefaultValue;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class CurrentDateTimeDefaultValueProxy
            : Zetbox.App.Base.DefaultPropertyValueNHibernateImpl.DefaultPropertyValueProxy
        {
            public CurrentDateTimeDefaultValueProxy()
            {
            }

            public override Type ZetboxWrapper { get { return typeof(CurrentDateTimeDefaultValueNHibernateImpl); } }

            public override Type ZetboxProxy { get { return typeof(CurrentDateTimeDefaultValueProxy); } }

        }

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