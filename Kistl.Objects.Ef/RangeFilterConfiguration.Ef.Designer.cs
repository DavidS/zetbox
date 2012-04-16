// <autogenerated/>

namespace Kistl.App.GUI
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

    using Kistl.API.Server;
    using Kistl.DalProvider.Ef;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// Filter configuration for filtering on a range of a Property 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="RangeFilterConfiguration")]
    [System.Diagnostics.DebuggerDisplay("RangeFilterConfiguration")]
    public class RangeFilterConfigurationEfImpl : Kistl.App.GUI.PropertyFilterConfigurationEfImpl, RangeFilterConfiguration
    {
        private static readonly Guid _objectClassID = new Guid("549efe2c-9dc7-4458-a0ff-b7c0710ae84c");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public RangeFilterConfigurationEfImpl()
            : base(null)
        {
        }

        public RangeFilterConfigurationEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnCreateFilterModel_RangeFilterConfiguration")]
        public override Kistl.API.IFilterModel CreateFilterModel()
        {
            var e = new MethodReturnEventArgs<Kistl.API.IFilterModel>();
            if (OnCreateFilterModel_RangeFilterConfiguration != null)
            {
                OnCreateFilterModel_RangeFilterConfiguration(this, e);
            }
            else
            {
                e.Result = base.CreateFilterModel();
            }
            return e.Result;
        }
        public static event CreateFilterModel_Handler<RangeFilterConfiguration> OnCreateFilterModel_RangeFilterConfiguration;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<RangeFilterConfiguration> OnCreateFilterModel_RangeFilterConfiguration_CanExec;

        [EventBasedMethod("OnCreateFilterModel_RangeFilterConfiguration_CanExec")]
        public override bool CreateFilterModelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnCreateFilterModel_RangeFilterConfiguration_CanExec != null)
				{
					OnCreateFilterModel_RangeFilterConfiguration_CanExec(this, e);
				}
				else
				{
					e.Result = base.CreateFilterModelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<RangeFilterConfiguration> OnCreateFilterModel_RangeFilterConfiguration_CanExecReason;

        [EventBasedMethod("OnCreateFilterModel_RangeFilterConfiguration_CanExecReason")]
        public override string CreateFilterModelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnCreateFilterModel_RangeFilterConfiguration_CanExecReason != null)
				{
					OnCreateFilterModel_RangeFilterConfiguration_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.CreateFilterModelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_RangeFilterConfiguration")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_RangeFilterConfiguration != null)
            {
                OnGetLabel_RangeFilterConfiguration(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<RangeFilterConfiguration> OnGetLabel_RangeFilterConfiguration;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<RangeFilterConfiguration> OnGetLabel_RangeFilterConfiguration_CanExec;

        [EventBasedMethod("OnGetLabel_RangeFilterConfiguration_CanExec")]
        public override bool GetLabelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabel_RangeFilterConfiguration_CanExec != null)
				{
					OnGetLabel_RangeFilterConfiguration_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<RangeFilterConfiguration> OnGetLabel_RangeFilterConfiguration_CanExecReason;

        [EventBasedMethod("OnGetLabel_RangeFilterConfiguration_CanExecReason")]
        public override string GetLabelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabel_RangeFilterConfiguration_CanExecReason != null)
				{
					OnGetLabel_RangeFilterConfiguration_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(RangeFilterConfiguration);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (RangeFilterConfiguration)obj;
            var otherImpl = (RangeFilterConfigurationEfImpl)obj;
            var me = (RangeFilterConfiguration)this;

        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }
        #region Kistl.Generator.Templates.ObjectClasses.OnPropertyChange


        #endregion // Kistl.Generator.Templates.ObjectClasses.OnPropertyChange

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
        #region Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_RangeFilterConfiguration")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_RangeFilterConfiguration != null)
            {
                OnToString_RangeFilterConfiguration(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<RangeFilterConfiguration> OnToString_RangeFilterConfiguration;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_RangeFilterConfiguration")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_RangeFilterConfiguration != null)
            {
                OnObjectIsValid_RangeFilterConfiguration(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<RangeFilterConfiguration> OnObjectIsValid_RangeFilterConfiguration;

        [EventBasedMethod("OnNotifyPreSave_RangeFilterConfiguration")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_RangeFilterConfiguration != null) OnNotifyPreSave_RangeFilterConfiguration(this);
        }
        public static event ObjectEventHandler<RangeFilterConfiguration> OnNotifyPreSave_RangeFilterConfiguration;

        [EventBasedMethod("OnNotifyPostSave_RangeFilterConfiguration")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_RangeFilterConfiguration != null) OnNotifyPostSave_RangeFilterConfiguration(this);
        }
        public static event ObjectEventHandler<RangeFilterConfiguration> OnNotifyPostSave_RangeFilterConfiguration;

        [EventBasedMethod("OnNotifyCreated_RangeFilterConfiguration")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_RangeFilterConfiguration != null) OnNotifyCreated_RangeFilterConfiguration(this);
        }
        public static event ObjectEventHandler<RangeFilterConfiguration> OnNotifyCreated_RangeFilterConfiguration;

        [EventBasedMethod("OnNotifyDeleting_RangeFilterConfiguration")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_RangeFilterConfiguration != null) OnNotifyDeleting_RangeFilterConfiguration(this);
        }
        public static event ObjectEventHandler<RangeFilterConfiguration> OnNotifyDeleting_RangeFilterConfiguration;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

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