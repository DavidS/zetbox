// <autogenerated/>

namespace at.dasz.DocumentManagement
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
    /// Static file. Content cannot be changed
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("StaticFile")]
    public class StaticFileNHibernateImpl : at.dasz.DocumentManagement.FileNHibernateImpl, StaticFile
    {
        private static readonly Guid _objectClassID = new Guid("5aaabfe9-081d-445d-a543-53e0253feeb8");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public StaticFileNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public StaticFileNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new StaticFileProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public StaticFileNHibernateImpl(Func<IFrozenContext> lazyCtx, StaticFileProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly StaticFileProxy Proxy;

        /// <summary>
        /// Handles the change of the current blob
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnHandleBlobChange_StaticFile")]
        public override Zetbox.App.Base.Blob HandleBlobChange(Zetbox.App.Base.Blob oldBlob, Zetbox.App.Base.Blob newBlob)
        {
            var e = new MethodReturnEventArgs<Zetbox.App.Base.Blob>();
            if (OnHandleBlobChange_StaticFile != null)
            {
                OnHandleBlobChange_StaticFile(this, e, oldBlob, newBlob);
            }
            else
            {
                e.Result = base.HandleBlobChange(oldBlob, newBlob);
            }
            return e.Result;
        }
        public static event HandleBlobChange_Handler<StaticFile> OnHandleBlobChange_StaticFile;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<StaticFile> OnHandleBlobChange_StaticFile_CanExec;

        [EventBasedMethod("OnHandleBlobChange_StaticFile_CanExec")]
        public override bool HandleBlobChangeCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnHandleBlobChange_StaticFile_CanExec != null)
				{
					OnHandleBlobChange_StaticFile_CanExec(this, e);
				}
				else
				{
					e.Result = base.HandleBlobChangeCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<StaticFile> OnHandleBlobChange_StaticFile_CanExecReason;

        [EventBasedMethod("OnHandleBlobChange_StaticFile_CanExecReason")]
        public override string HandleBlobChangeCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnHandleBlobChange_StaticFile_CanExecReason != null)
				{
					OnHandleBlobChange_StaticFile_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.HandleBlobChangeCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Öffnet das Dokument schreibgeschützt
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnOpen_StaticFile")]
        public override void Open()
        {
            // base.Open();
            if (OnOpen_StaticFile != null)
            {
                OnOpen_StaticFile(this);
            }
            else
            {
                base.Open();
            }
        }
        public static event Open_Handler<StaticFile> OnOpen_StaticFile;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<StaticFile> OnOpen_StaticFile_CanExec;

        [EventBasedMethod("OnOpen_StaticFile_CanExec")]
        public override bool OpenCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnOpen_StaticFile_CanExec != null)
				{
					OnOpen_StaticFile_CanExec(this, e);
				}
				else
				{
					e.Result = base.OpenCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<StaticFile> OnOpen_StaticFile_CanExecReason;

        [EventBasedMethod("OnOpen_StaticFile_CanExecReason")]
        public override string OpenCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnOpen_StaticFile_CanExecReason != null)
				{
					OnOpen_StaticFile_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.OpenCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// Uploads a new Content
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnUpload_StaticFile")]
        public override void Upload()
        {
            // base.Upload();
            if (OnUpload_StaticFile != null)
            {
                OnUpload_StaticFile(this);
            }
            else
            {
                base.Upload();
            }
        }
        public static event Upload_Handler<StaticFile> OnUpload_StaticFile;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<StaticFile> OnUpload_StaticFile_CanExec;

        [EventBasedMethod("OnUpload_StaticFile_CanExec")]
        public override bool UploadCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnUpload_StaticFile_CanExec != null)
				{
					OnUpload_StaticFile_CanExec(this, e);
				}
				else
				{
					e.Result = base.UploadCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<StaticFile> OnUpload_StaticFile_CanExecReason;

        [EventBasedMethod("OnUpload_StaticFile_CanExecReason")]
        public override string UploadCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnUpload_StaticFile_CanExecReason != null)
				{
					OnUpload_StaticFile_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.UploadCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(StaticFile);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (StaticFile)obj;
            var otherImpl = (StaticFileNHibernateImpl)obj;
            var me = (StaticFile)this;

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
        #region Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_StaticFile")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_StaticFile != null)
            {
                OnToString_StaticFile(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<StaticFile> OnToString_StaticFile;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_StaticFile")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_StaticFile != null)
            {
                OnObjectIsValid_StaticFile(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<StaticFile> OnObjectIsValid_StaticFile;

        [EventBasedMethod("OnNotifyPreSave_StaticFile")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_StaticFile != null) OnNotifyPreSave_StaticFile(this);
        }
        public static event ObjectEventHandler<StaticFile> OnNotifyPreSave_StaticFile;

        [EventBasedMethod("OnNotifyPostSave_StaticFile")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_StaticFile != null) OnNotifyPostSave_StaticFile(this);
        }
        public static event ObjectEventHandler<StaticFile> OnNotifyPostSave_StaticFile;

        [EventBasedMethod("OnNotifyCreated_StaticFile")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnNotifyCreated_StaticFile != null) OnNotifyCreated_StaticFile(this);
        }
        public static event ObjectEventHandler<StaticFile> OnNotifyCreated_StaticFile;

        [EventBasedMethod("OnNotifyDeleting_StaticFile")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_StaticFile != null) OnNotifyDeleting_StaticFile(this);


        }
        public static event ObjectEventHandler<StaticFile> OnNotifyDeleting_StaticFile;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class StaticFileProxy
            : at.dasz.DocumentManagement.FileNHibernateImpl.FileProxy
        {
            public StaticFileProxy()
            {
            }

            public override Type ZetboxWrapper { get { return typeof(StaticFileNHibernateImpl); } }

            public override Type ZetboxProxy { get { return typeof(StaticFileProxy); } }

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