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

    using Kistl.API;
    using Kistl.DalProvider.Base.RelationWrappers;

    using Kistl.API.Server;
    using Kistl.DalProvider.Ef;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// File with changeable content
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="DynamicFile")]
    [System.Diagnostics.DebuggerDisplay("DynamicFile")]
    public class DynamicFileEfImpl : at.dasz.DocumentManagement.FileEfImpl, DynamicFile
    {
        [Obsolete]
        public DynamicFileEfImpl()
            : base(null)
        {
        }

        public DynamicFileEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// Handles the change of the current blob
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnHandleBlobChange_DynamicFile")]
        public override Kistl.App.Base.Blob HandleBlobChange(Kistl.App.Base.Blob oldBlob, Kistl.App.Base.Blob newBlob)
        {
            var e = new MethodReturnEventArgs<Kistl.App.Base.Blob>();
            if (OnHandleBlobChange_DynamicFile != null)
            {
                OnHandleBlobChange_DynamicFile(this, e, oldBlob, newBlob);
            }
            else
            {
                e.Result = base.HandleBlobChange(oldBlob, newBlob);
            }
            return e.Result;
        }
        public static event HandleBlobChange_Handler<DynamicFile> OnHandleBlobChange_DynamicFile;
		// CanExec
		public static event CanExecMethodEventHandler<DynamicFile> OnHandleBlobChange_DynamicFile_CanExec;

        [EventBasedMethod("OnHandleBlobChange_DynamicFile_CanExec")]
        public override bool HandleBlobChangeCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnHandleBlobChange_DynamicFile_CanExec != null)
				{
					OnHandleBlobChange_DynamicFile_CanExec(this, e);
				}
				else
				{
					e.Result = base.HandleBlobChangeCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<DynamicFile> OnHandleBlobChange_DynamicFile_CanExecReason;

        [EventBasedMethod("OnHandleBlobChange_DynamicFile_CanExecReason")]
        public override string HandleBlobChangeCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnHandleBlobChange_DynamicFile_CanExecReason != null)
				{
					OnHandleBlobChange_DynamicFile_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.HandleBlobChangeCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Öffnet das Dokument schreibgeschützt
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnOpen_DynamicFile")]
        public override void Open()
        {
            // base.Open();
            if (OnOpen_DynamicFile != null)
            {
                OnOpen_DynamicFile(this);
            }
            else
            {
                base.Open();
            }
        }
        public static event Open_Handler<DynamicFile> OnOpen_DynamicFile;
		// CanExec
		public static event CanExecMethodEventHandler<DynamicFile> OnOpen_DynamicFile_CanExec;

        [EventBasedMethod("OnOpen_DynamicFile_CanExec")]
        public override bool OpenCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnOpen_DynamicFile_CanExec != null)
				{
					OnOpen_DynamicFile_CanExec(this, e);
				}
				else
				{
					e.Result = base.OpenCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<DynamicFile> OnOpen_DynamicFile_CanExecReason;

        [EventBasedMethod("OnOpen_DynamicFile_CanExecReason")]
        public override string OpenCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnOpen_DynamicFile_CanExecReason != null)
				{
					OnOpen_DynamicFile_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.OpenCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Uploads a new Content
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnUpload_DynamicFile")]
        public override void Upload()
        {
            // base.Upload();
            if (OnUpload_DynamicFile != null)
            {
                OnUpload_DynamicFile(this);
            }
            else
            {
                base.Upload();
            }
        }
        public static event Upload_Handler<DynamicFile> OnUpload_DynamicFile;
		// CanExec
		public static event CanExecMethodEventHandler<DynamicFile> OnUpload_DynamicFile_CanExec;

        [EventBasedMethod("OnUpload_DynamicFile_CanExec")]
        public override bool UploadCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnUpload_DynamicFile_CanExec != null)
				{
					OnUpload_DynamicFile_CanExec(this, e);
				}
				else
				{
					e.Result = base.UploadCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<DynamicFile> OnUpload_DynamicFile_CanExecReason;

        [EventBasedMethod("OnUpload_DynamicFile_CanExecReason")]
        public override string UploadCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnUpload_DynamicFile_CanExecReason != null)
				{
					OnUpload_DynamicFile_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.UploadCanExecReason;
				}
				return e.Result;
			}
        }
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(DynamicFile);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (DynamicFile)obj;
            var otherImpl = (DynamicFileEfImpl)obj;
            var me = (DynamicFile)this;

        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
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
        #region Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_DynamicFile")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DynamicFile != null)
            {
                OnToString_DynamicFile(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<DynamicFile> OnToString_DynamicFile;

        [EventBasedMethod("OnPreSave_DynamicFile")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DynamicFile != null) OnPreSave_DynamicFile(this);
        }
        public static event ObjectEventHandler<DynamicFile> OnPreSave_DynamicFile;

        [EventBasedMethod("OnPostSave_DynamicFile")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DynamicFile != null) OnPostSave_DynamicFile(this);
        }
        public static event ObjectEventHandler<DynamicFile> OnPostSave_DynamicFile;

        [EventBasedMethod("OnCreated_DynamicFile")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_DynamicFile != null) OnCreated_DynamicFile(this);
        }
        public static event ObjectEventHandler<DynamicFile> OnCreated_DynamicFile;

        [EventBasedMethod("OnDeleting_DynamicFile")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_DynamicFile != null) OnDeleting_DynamicFile(this);
        }
        public static event ObjectEventHandler<DynamicFile> OnDeleting_DynamicFile;

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