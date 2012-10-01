// <autogenerated/>

namespace Zetbox.App.GUI
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
    [System.Diagnostics.DebuggerDisplay("NavigationAction")]
    public class NavigationActionMemoryImpl : Zetbox.App.GUI.NavigationEntryMemoryImpl, NavigationAction
    {
        private static readonly Guid _objectClassID = new Guid("e1415447-ccb4-4de5-aba0-9479c4472b08");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public NavigationActionMemoryImpl()
            : base(null)
        {
        }

        public NavigationActionMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDefaultViewModel_NavigationAction")]
        public override System.Object GetDefaultViewModel(Zetbox.API.IZetboxContext dataCtx, System.Object parent)
        {
            var e = new MethodReturnEventArgs<System.Object>();
            if (OnGetDefaultViewModel_NavigationAction != null)
            {
                OnGetDefaultViewModel_NavigationAction(this, e, dataCtx, parent);
            }
            else
            {
                e.Result = base.GetDefaultViewModel(dataCtx, parent);
            }
            return e.Result;
        }
        public static event GetDefaultViewModel_Handler<NavigationAction> OnGetDefaultViewModel_NavigationAction;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<NavigationAction> OnGetDefaultViewModel_NavigationAction_CanExec;

        [EventBasedMethod("OnGetDefaultViewModel_NavigationAction_CanExec")]
        public override bool GetDefaultViewModelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetDefaultViewModel_NavigationAction_CanExec != null)
				{
					OnGetDefaultViewModel_NavigationAction_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetDefaultViewModelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<NavigationAction> OnGetDefaultViewModel_NavigationAction_CanExecReason;

        [EventBasedMethod("OnGetDefaultViewModel_NavigationAction_CanExecReason")]
        public override string GetDefaultViewModelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetDefaultViewModel_NavigationAction_CanExecReason != null)
				{
					OnGetDefaultViewModel_NavigationAction_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetDefaultViewModelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(NavigationAction);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (NavigationAction)obj;
            var otherImpl = (NavigationActionMemoryImpl)obj;
            var me = (NavigationAction)this;

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
        [EventBasedMethod("OnToString_NavigationAction")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_NavigationAction != null)
            {
                OnToString_NavigationAction(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<NavigationAction> OnToString_NavigationAction;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_NavigationAction")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_NavigationAction != null)
            {
                OnObjectIsValid_NavigationAction(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<NavigationAction> OnObjectIsValid_NavigationAction;

        [EventBasedMethod("OnNotifyPreSave_NavigationAction")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_NavigationAction != null) OnNotifyPreSave_NavigationAction(this);
        }
        public static event ObjectEventHandler<NavigationAction> OnNotifyPreSave_NavigationAction;

        [EventBasedMethod("OnNotifyPostSave_NavigationAction")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_NavigationAction != null) OnNotifyPostSave_NavigationAction(this);
        }
        public static event ObjectEventHandler<NavigationAction> OnNotifyPostSave_NavigationAction;

        [EventBasedMethod("OnNotifyCreated_NavigationAction")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_NavigationAction != null) OnNotifyCreated_NavigationAction(this);
        }
        public static event ObjectEventHandler<NavigationAction> OnNotifyCreated_NavigationAction;

        [EventBasedMethod("OnNotifyDeleting_NavigationAction")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_NavigationAction != null) OnNotifyDeleting_NavigationAction(this);
        }
        public static event ObjectEventHandler<NavigationAction> OnNotifyDeleting_NavigationAction;

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