// <autogenerated/>

namespace Kistl.App.Base
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
    /// Guid Property
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("GuidProperty")]
    public class GuidPropertyNHibernateImpl : Kistl.App.Base.ValueTypePropertyNHibernateImpl, GuidProperty
    {
        private static readonly Guid _objectClassID = new Guid("bd34d049-2b64-47f4-8d79-932008d0cf72");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public GuidPropertyNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public GuidPropertyNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new GuidPropertyProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public GuidPropertyNHibernateImpl(Func<IFrozenContext> lazyCtx, GuidPropertyProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly GuidPropertyProxy Proxy;

        /// <summary>
        /// The element type for multi-valued properties. The property type string in all other cases.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetElementTypeString_GuidProperty")]
        public override string GetElementTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetElementTypeString_GuidProperty != null)
            {
                OnGetElementTypeString_GuidProperty(this, e);
            }
            else
            {
                e.Result = base.GetElementTypeString();
            }
            return e.Result;
        }
        public static event GetElementTypeString_Handler<GuidProperty> OnGetElementTypeString_GuidProperty;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<GuidProperty> OnGetElementTypeString_GuidProperty_CanExec;

        [EventBasedMethod("OnGetElementTypeString_GuidProperty_CanExec")]
        public override bool GetElementTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetElementTypeString_GuidProperty_CanExec != null)
				{
					OnGetElementTypeString_GuidProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetElementTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<GuidProperty> OnGetElementTypeString_GuidProperty_CanExecReason;

        [EventBasedMethod("OnGetElementTypeString_GuidProperty_CanExecReason")]
        public override string GetElementTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetElementTypeString_GuidProperty_CanExecReason != null)
				{
					OnGetElementTypeString_GuidProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetElementTypeStringCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_GuidProperty")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_GuidProperty != null)
            {
                OnGetLabel_GuidProperty(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<GuidProperty> OnGetLabel_GuidProperty;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<GuidProperty> OnGetLabel_GuidProperty_CanExec;

        [EventBasedMethod("OnGetLabel_GuidProperty_CanExec")]
        public override bool GetLabelCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetLabel_GuidProperty_CanExec != null)
				{
					OnGetLabel_GuidProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<GuidProperty> OnGetLabel_GuidProperty_CanExecReason;

        [EventBasedMethod("OnGetLabel_GuidProperty_CanExecReason")]
        public override string GetLabelCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetLabel_GuidProperty_CanExecReason != null)
				{
					OnGetLabel_GuidProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetLabelCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetName_GuidProperty")]
        public override string GetName()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetName_GuidProperty != null)
            {
                OnGetName_GuidProperty(this, e);
            }
            else
            {
                e.Result = base.GetName();
            }
            return e.Result;
        }
        public static event GetName_Handler<GuidProperty> OnGetName_GuidProperty;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<GuidProperty> OnGetName_GuidProperty_CanExec;

        [EventBasedMethod("OnGetName_GuidProperty_CanExec")]
        public override bool GetNameCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetName_GuidProperty_CanExec != null)
				{
					OnGetName_GuidProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetNameCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<GuidProperty> OnGetName_GuidProperty_CanExecReason;

        [EventBasedMethod("OnGetName_GuidProperty_CanExecReason")]
        public override string GetNameCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetName_GuidProperty_CanExecReason != null)
				{
					OnGetName_GuidProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetNameCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetPropertyType_GuidProperty")]
        public override System.Type GetPropertyType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_GuidProperty != null)
            {
                OnGetPropertyType_GuidProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
        public static event GetPropertyType_Handler<GuidProperty> OnGetPropertyType_GuidProperty;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<GuidProperty> OnGetPropertyType_GuidProperty_CanExec;

        [EventBasedMethod("OnGetPropertyType_GuidProperty_CanExec")]
        public override bool GetPropertyTypeCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetPropertyType_GuidProperty_CanExec != null)
				{
					OnGetPropertyType_GuidProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<GuidProperty> OnGetPropertyType_GuidProperty_CanExecReason;

        [EventBasedMethod("OnGetPropertyType_GuidProperty_CanExecReason")]
        public override string GetPropertyTypeCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetPropertyType_GuidProperty_CanExecReason != null)
				{
					OnGetPropertyType_GuidProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetPropertyTypeString_GuidProperty")]
        public override string GetPropertyTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_GuidProperty != null)
            {
                OnGetPropertyTypeString_GuidProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
        public static event GetPropertyTypeString_Handler<GuidProperty> OnGetPropertyTypeString_GuidProperty;
        // BEGIN Kistl.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<GuidProperty> OnGetPropertyTypeString_GuidProperty_CanExec;

        [EventBasedMethod("OnGetPropertyTypeString_GuidProperty_CanExec")]
        public override bool GetPropertyTypeStringCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetPropertyTypeString_GuidProperty_CanExec != null)
				{
					OnGetPropertyTypeString_GuidProperty_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeStringCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<GuidProperty> OnGetPropertyTypeString_GuidProperty_CanExecReason;

        [EventBasedMethod("OnGetPropertyTypeString_GuidProperty_CanExecReason")]
        public override string GetPropertyTypeStringCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetPropertyTypeString_GuidProperty_CanExecReason != null)
				{
					OnGetPropertyTypeString_GuidProperty_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetPropertyTypeStringCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(GuidProperty);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (GuidProperty)obj;
            var otherImpl = (GuidPropertyNHibernateImpl)obj;
            var me = (GuidProperty)this;

        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
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
        #region Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_GuidProperty")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_GuidProperty != null)
            {
                OnToString_GuidProperty(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<GuidProperty> OnToString_GuidProperty;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_GuidProperty")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_GuidProperty != null)
            {
                OnObjectIsValid_GuidProperty(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<GuidProperty> OnObjectIsValid_GuidProperty;

        [EventBasedMethod("OnNotifyPreSave_GuidProperty")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_GuidProperty != null) OnNotifyPreSave_GuidProperty(this);
        }
        public static event ObjectEventHandler<GuidProperty> OnNotifyPreSave_GuidProperty;

        [EventBasedMethod("OnNotifyPostSave_GuidProperty")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_GuidProperty != null) OnNotifyPostSave_GuidProperty(this);
        }
        public static event ObjectEventHandler<GuidProperty> OnNotifyPostSave_GuidProperty;

        [EventBasedMethod("OnNotifyCreated_GuidProperty")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_GuidProperty != null) OnNotifyCreated_GuidProperty(this);
        }
        public static event ObjectEventHandler<GuidProperty> OnNotifyCreated_GuidProperty;

        [EventBasedMethod("OnNotifyDeleting_GuidProperty")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_GuidProperty != null) OnNotifyDeleting_GuidProperty(this);


        }
        public static event ObjectEventHandler<GuidProperty> OnNotifyDeleting_GuidProperty;

        #endregion // Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class GuidPropertyProxy
            : Kistl.App.Base.ValueTypePropertyNHibernateImpl.ValueTypePropertyProxy
        {
            public GuidPropertyProxy()
            {
            }

            public override Type ZBoxWrapper { get { return typeof(GuidPropertyNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(GuidPropertyProxy); } }

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