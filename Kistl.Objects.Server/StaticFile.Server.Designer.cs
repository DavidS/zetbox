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

    using Kistl.API.Server;
    using Kistl.DalProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// Static file. Content cannot be changed
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="StaticFile")]
    [System.Diagnostics.DebuggerDisplay("StaticFile")]
    public class StaticFile__Implementation__ : at.dasz.DocumentManagement.File__Implementation__, StaticFile
    {
        [Obsolete]
        public StaticFile__Implementation__()
            : base(null)
        {
        }

        public StaticFile__Implementation__(Func<IReadOnlyKistlContext> lazyCtx)
            : base(lazyCtx)
        {
        }


        /// <summary>
        /// Handles the change of the current blob
        /// </summary>
		[EventBasedMethod("OnHandleBlobChange_StaticFile")]
		public override Kistl.App.Base.Blob HandleBlobChange(Kistl.App.Base.Blob oldBlob, Kistl.App.Base.Blob newBlob) 
        {
            var e = new MethodReturnEventArgs<Kistl.App.Base.Blob>();
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



        /// <summary>
        /// Opens the Content readonly
        /// </summary>
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



        /// <summary>
        /// Uploads a new Content
        /// </summary>
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



        public override Type GetImplementedInterface()
        {
            return typeof(StaticFile);
        }

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (StaticFile)obj;
			var otherImpl = (StaticFile__Implementation__)obj;
			var me = (StaticFile)this;

		}

		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
			base.ReloadReferences();
			
			// fix direct object references
		}
        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

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

        [EventBasedMethod("OnPreSave_StaticFile")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_StaticFile != null) OnPreSave_StaticFile(this);
        }
        public static event ObjectEventHandler<StaticFile> OnPreSave_StaticFile;

        [EventBasedMethod("OnPostSave_StaticFile")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_StaticFile != null) OnPostSave_StaticFile(this);
        }
        public static event ObjectEventHandler<StaticFile> OnPostSave_StaticFile;

        [EventBasedMethod("OnCreated_StaticFile")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_StaticFile != null) OnCreated_StaticFile(this);
        }
        public static event ObjectEventHandler<StaticFile> OnCreated_StaticFile;

        [EventBasedMethod("OnDeleting_StaticFile")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_StaticFile != null) OnDeleting_StaticFile(this);
        }
        public static event ObjectEventHandler<StaticFile> OnDeleting_StaticFile;


	

#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            
            base.ToStream(binStream, auxObjects, eagerLoadLists);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            
            base.Export(xml, modules);
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            
            base.MergeImport(xml);
        }

#endregion

    }


}