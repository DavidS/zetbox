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

    using Kistl.API.Utils;
    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.NHibernate;

    /// <summary>
    /// Document with revisions
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("Document")]
    public class DocumentNHibernateImpl : at.dasz.DocumentManagement.FileNHibernateImpl, Document
    {
        public DocumentNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public DocumentNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new DocumentProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public DocumentNHibernateImpl(Func<IFrozenContext> lazyCtx, DocumentProxy proxy)
            : base(lazyCtx, proxy) // pass proxy to parent
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal new readonly DocumentProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // collection entry list property
   		// Kistl.DalProvider.NHibernate.Generator.Templates.Properties.CollectionEntryListProperty
		public IList<Kistl.App.Base.Blob> Revisions
		{
			get
			{
				if (_Revisions == null)
				{
					_Revisions 
						= new NHibernateBSideListWrapper<at.dasz.DocumentManagement.Document, Kistl.App.Base.Blob, Document_has_Blob_RelationEntryNHibernateImpl>(
							this, 
							new ProjectedCollection<Document_has_Blob_RelationEntryNHibernateImpl.Document_has_Blob_RelationEntryProxy, Document_has_Blob_RelationEntryNHibernateImpl>(
                                this.Proxy.Revisions,
                                p => (Document_has_Blob_RelationEntryNHibernateImpl)OurContext.AttachAndWrap(p),
                                ce => (Document_has_Blob_RelationEntryNHibernateImpl.Document_has_Blob_RelationEntryProxy)((NHibernatePersistenceObject)ce).NHibernateProxy),
                            entry => (IRelationListSync<Document_has_Blob_RelationEntryNHibernateImpl>)null);
                    if (Revisions_was_eagerLoaded) { Revisions_was_eagerLoaded = false; }
				}
				return (IList<Kistl.App.Base.Blob>)_Revisions;
			}
		}

		private NHibernateBSideListWrapper<at.dasz.DocumentManagement.Document, Kistl.App.Base.Blob, Document_has_Blob_RelationEntryNHibernateImpl> _Revisions;
		// ignored, but required for Serialization
        private bool Revisions_was_eagerLoaded = false;

        /// <summary>
        /// Handles the change of the current blob
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnHandleBlobChange_Document")]
        public override Kistl.App.Base.Blob HandleBlobChange(Kistl.App.Base.Blob oldBlob, Kistl.App.Base.Blob newBlob)
        {
            var e = new MethodReturnEventArgs<Kistl.App.Base.Blob>();
            if (OnHandleBlobChange_Document != null)
            {
                OnHandleBlobChange_Document(this, e, oldBlob, newBlob);
            }
            else
            {
                e.Result = base.HandleBlobChange(oldBlob, newBlob);
            }
            return e.Result;
        }
        public static event HandleBlobChange_Handler<Document> OnHandleBlobChange_Document;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Öffnet das Dokument schreibgeschützt
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnOpen_Document")]
        public override void Open()
        {
            // base.Open();
            if (OnOpen_Document != null)
            {
                OnOpen_Document(this);
            }
            else
            {
                base.Open();
            }
        }
        public static event Open_Handler<Document> OnOpen_Document;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Uploads a new Content
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnUpload_Document")]
        public override void Upload()
        {
            // base.Upload();
            if (OnUpload_Document != null)
            {
                OnUpload_Document(this);
            }
            else
            {
                base.Upload();
            }
        }
        public static event Upload_Handler<Document> OnUpload_Document;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(Document);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (Document)obj;
            var otherImpl = (DocumentNHibernateImpl)obj;
            var me = (Document)this;

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
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorNHibernateImpl<DocumentNHibernateImpl, IList<Kistl.App.Base.Blob>>(
                        lazyCtx,
                        new Guid("ec544fe0-8189-4bb2-a3d1-3cb61d815aa5"),
                        "Revisions",
                        null,
                        obj => obj.Revisions,
                        null), // lists are read-only properties
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
        #endregion // Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Kistl.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_Document")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Document != null)
            {
                OnToString_Document(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<Document> OnToString_Document;

        [EventBasedMethod("OnPreSave_Document")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Document != null) OnPreSave_Document(this);
        }
        public static event ObjectEventHandler<Document> OnPreSave_Document;

        [EventBasedMethod("OnPostSave_Document")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Document != null) OnPostSave_Document(this);
        }
        public static event ObjectEventHandler<Document> OnPostSave_Document;

        [EventBasedMethod("OnCreated_Document")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_Document != null) OnCreated_Document(this);
        }
        public static event ObjectEventHandler<Document> OnCreated_Document;

        [EventBasedMethod("OnDeleting_Document")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Document != null) OnDeleting_Document(this);
        }
        public static event ObjectEventHandler<Document> OnDeleting_Document;

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


        public class DocumentProxy
            : at.dasz.DocumentManagement.FileNHibernateImpl.FileProxy
        {
            public DocumentProxy()
            {
                Revisions = new Collection<at.dasz.DocumentManagement.Document_has_Blob_RelationEntryNHibernateImpl.Document_has_Blob_RelationEntryProxy>();
            }

            public override Type ZBoxWrapper { get { return typeof(DocumentNHibernateImpl); } }

            public override Type ZBoxProxy { get { return typeof(DocumentProxy); } }

            public virtual int? Document_pos { get; set; }

            public virtual ICollection<at.dasz.DocumentManagement.Document_has_Blob_RelationEntryNHibernateImpl.Document_has_Blob_RelationEntryProxy> Revisions { get; set; }

        }

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
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