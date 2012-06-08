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

    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Zetbox.API.Server;
    using Zetbox.DalProvider.Ef;

    /// <summary>
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="NavigationScreen")]
    [System.Diagnostics.DebuggerDisplay("NavigationScreen")]
    public class NavigationScreenEfImpl : Zetbox.App.GUI.NavigationEntryEfImpl, NavigationScreen
    {
        private static readonly Guid _objectClassID = new Guid("2879e023-77e4-4601-80b0-75ef76fd4001");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public NavigationScreenEfImpl()
            : base(null)
        {
        }

        public NavigationScreenEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDefaultViewModel_NavigationScreen")]
        public override System.Object GetDefaultViewModel(Zetbox.API.IZetboxContext dataCtx, System.Object parent)
        {
            var e = new MethodReturnEventArgs<System.Object>();
            if (OnGetDefaultViewModel_NavigationScreen != null)
            {
                OnGetDefaultViewModel_NavigationScreen(this, e, dataCtx, parent);
            }
            else
            {
                e.Result = base.GetDefaultViewModel(dataCtx, parent);
            }
            return e.Result;
        }
        public static event GetDefaultViewModel_Handler<NavigationScreen> OnGetDefaultViewModel_NavigationScreen;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<NavigationScreen> OnGetDefaultViewModel_NavigationScreen_CanExec;

        [EventBasedMethod("OnGetDefaultViewModel_NavigationScreen_CanExec")]
        public override bool GetDefaultViewModelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetDefaultViewModel_NavigationScreen_CanExec != null)
				{
					OnGetDefaultViewModel_NavigationScreen_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetDefaultViewModelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<NavigationScreen> OnGetDefaultViewModel_NavigationScreen_CanExecReason;

        [EventBasedMethod("OnGetDefaultViewModel_NavigationScreen_CanExecReason")]
        public override string GetDefaultViewModelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetDefaultViewModel_NavigationScreen_CanExecReason != null)
				{
					OnGetDefaultViewModel_NavigationScreen_CanExecReason(this, e);
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
            return typeof(NavigationScreen);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (NavigationScreen)obj;
            var otherImpl = (NavigationScreenEfImpl)obj;
            var me = (NavigationScreen)this;

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
        private static readonly object _propertiesLock = new object();
        private static System.ComponentModel.PropertyDescriptor[] _properties;

        private void _InitializePropertyDescriptors(Func<IFrozenContext> lazyCtx)
        {
            if (_properties != null) return;
            lock (_propertiesLock)
            {
                // recheck for a lost race after aquiring the lock
                if (_properties != null) return;

                _properties = new System.ComponentModel.PropertyDescriptor[] {
                    // position columns
                };
            }
        }

        protected override void CollectProperties(Func<IFrozenContext> lazyCtx, List<System.ComponentModel.PropertyDescriptor> props)
        {
            base.CollectProperties(lazyCtx, props);
            _InitializePropertyDescriptors(lazyCtx);
            props.AddRange(_properties);
        }
        #endregion // Zetbox.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_NavigationScreen")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_NavigationScreen != null)
            {
                OnToString_NavigationScreen(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<NavigationScreen> OnToString_NavigationScreen;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_NavigationScreen")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_NavigationScreen != null)
            {
                OnObjectIsValid_NavigationScreen(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<NavigationScreen> OnObjectIsValid_NavigationScreen;

        [EventBasedMethod("OnNotifyPreSave_NavigationScreen")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_NavigationScreen != null) OnNotifyPreSave_NavigationScreen(this);
        }
        public static event ObjectEventHandler<NavigationScreen> OnNotifyPreSave_NavigationScreen;

        [EventBasedMethod("OnNotifyPostSave_NavigationScreen")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_NavigationScreen != null) OnNotifyPostSave_NavigationScreen(this);
        }
        public static event ObjectEventHandler<NavigationScreen> OnNotifyPostSave_NavigationScreen;

        [EventBasedMethod("OnNotifyCreated_NavigationScreen")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_NavigationScreen != null) OnNotifyCreated_NavigationScreen(this);
        }
        public static event ObjectEventHandler<NavigationScreen> OnNotifyCreated_NavigationScreen;

        [EventBasedMethod("OnNotifyDeleting_NavigationScreen")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_NavigationScreen != null) OnNotifyDeleting_NavigationScreen(this);
        }
        public static event ObjectEventHandler<NavigationScreen> OnNotifyDeleting_NavigationScreen;

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