
namespace Kistl.API.Server
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Kistl.API.Configuration;
    using Kistl.App.Base;
    using Kistl.App.Extensions;

    public delegate IKistlContext ServerKistlContextFactory(Identity identity);

    public abstract class BaseKistlDataContext
        : IKistlServerContext, IDisposable
    {
        protected readonly Identity identity;
        protected readonly IMetaDataResolver metaDataResolver;
        protected KistlConfig config;
        protected InterfaceType.Factory iftFactory;

        /// <summary>
        /// Initializes a new instance of the BaseKistlDataContext class using the specified <see cref="Identity"/>.
        /// </summary>
        /// <param name="metaDataResolver">the IMetaDataResolver for this context.</param>
        /// <param name="identity">the identity of this context. if this is null, the context does no security checks</param>
        /// <param name="config"></param>
        /// <param name="iftFactory"></param>
        protected BaseKistlDataContext(IMetaDataResolver metaDataResolver, Identity identity, KistlConfig config, InterfaceType.Factory iftFactory)
        {
            if (metaDataResolver == null) { throw new ArgumentNullException("metaDataResolver"); }
            if (config == null) { throw new ArgumentNullException("config"); }
            if (iftFactory == null) { throw new ArgumentNullException("iftFactory"); }

            this.metaDataResolver = metaDataResolver;
            this.identity = identity;
            this.config = config;
            this.iftFactory = iftFactory;
        }

        // TODO: implement proper IDisposable pattern
        public virtual void Dispose()
        {
            GC.SuppressFinalize(this);
            IsDisposed = true;
        }

        /// <summary>
        /// Is true after Dispose() was called.
        /// </summary>
        public bool IsDisposed { get; private set; }

        public bool IsReadonly { get { return false; } }

        /// <summary>
        /// Attach an IPersistenceObject. The EntityFramework guarantees the all Objects are unique. No check requiered.
        /// </summary>
        /// <param name="obj">Object to Attach</param>
        /// <returns>Object Attached</returns>
        public virtual IPersistenceObject Attach(IPersistenceObject obj)
        {
            if (obj == null) { throw new ArgumentNullException("obj"); }

            // Do not only check in IKistlContext.Create for creation rights, also here
            // Object might be created by SerializableType
            if (obj is IDataObject && obj.ObjectState == DataObjectState.New)
            {
                var ifType = GetInterfaceType(obj);
                ObjectClass cls = metaDataResolver.GetObjectClass(ifType).GetRootClass();
                if (identity != null && cls.HasAccessControlList() && (cls.GetGroupAccessRights(identity) & AccessRights.Create) != AccessRights.Create)
                {
                    throw new System.Security.SecurityException(string.Format("The current identity has no rights to create an Object of type '{0}'", ifType.Type.FullName));
                }
            }

            // call Attach on Subitems
            obj.AttachToContext(this);

            return obj;
        }

        /// <summary>
        /// Detach an IPersistenceObject.
        /// </summary>
        /// <param name="obj">IDataObject</param>
        public virtual void Detach(IPersistenceObject obj)
        {
            if (obj == null) { throw new ArgumentNullException("obj"); }

            obj.DetachFromContext(this);
        }

        /// <summary>
        /// Delete an IPersistenceObject.
        /// </summary>
        /// <param name="obj">IPersistenceObject</param>
        public virtual void Delete(IPersistenceObject obj)
        {
            if (obj == null) { throw new ArgumentNullException("obj"); }

            OnObjectDeleted(obj);
            if (obj is IDataObject)
            {
                ((IDataObject)obj).NotifyDeleting();
            }
        }

        /// <summary>
        /// Returns a Query by T
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <returns>IQueryable</returns>
        public abstract IQueryable<T> GetQuery<T>() where T : class, IDataObject;

        /// <summary>
        /// Returns a Query by System.Type.
        /// </summary>
        /// <param name="ifType">the requested type of objects</param>
        /// <returns>IQueryable</returns>
        public abstract IQueryable<IDataObject> GetQuery(InterfaceType ifType);

        /// <summary>
        /// Returns a PersistenceObject Query by T
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <returns>IQueryable</returns>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public abstract IQueryable<T> GetPersistenceObjectQuery<T>() where T : class, IPersistenceObject;
        /// <summary>
        /// Returns a PersistenceObject Query by InterfaceType
        /// </summary>
        /// <param name="ifType">the interface to look for</param>
        /// <returns>IQueryable</returns>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public abstract IQueryable<IPersistenceObject> GetPersistenceObjectQuery(InterfaceType ifType);

        /// <summary>
        /// Returns the List referenced by the given Name.
        /// </summary>
        /// <typeparam name="T">List Type of the ObjectReferenceProperty</typeparam>
        /// <param name="obj">Object which holds the ObjectReferenceProperty</param>
        /// <param name="propertyName">Propertyname which holds the ObjectReferenceProperty</param>
        /// <returns>A List of Objects</returns>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public virtual List<T> GetListOf<T>(IDataObject obj, string propertyName) where T : class, IDataObject
        {
            if (obj == null) { throw new ArgumentNullException("obj"); }

            return obj.GetPropertyValue<IEnumerable>(propertyName).Cast<T>().ToList();
        }

        /// <summary>
        /// Returns the List referenced by the given Type, ID and Name.
        /// </summary>
        /// <typeparam name="T">List Type of the ObjectReferenceProperty</typeparam>
        /// <param name="type">Type of the Object which holds the ObjectReferenceProperty</param>
        /// <param name="ID">ID of the Object which holds the ObjectReferenceProperty</param>
        /// <param name="propertyName">Propertyname which holds the ObjectReferenceProperty</param>
        /// <returns>A List of Objects</returns>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public virtual List<T> GetListOf<T>(InterfaceType type, int ID, string propertyName) where T : class, IDataObject
        {
            IDataObject obj = (IDataObject)this.Find(type, ID);
            return GetListOf<T>(obj, propertyName);
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public abstract IList<T> FetchRelation<T>(Guid relationId, RelationEndRole role, IDataObject parent) where T : class, IRelationCollectionEntry;

        /// <summary>
        /// Checks if the given Object is already in that Context.
        /// </summary>
        /// <param name="type">Type of Object</param>
        /// <param name="ID">ID</param>        /// <returns>If ID is InvalidID (Object is not inititalized) then an Exception will be thrown.
        /// If the Object is already in that Context, the Object Instace is returned.
        /// If the Object is not in that Context, null is returned.</returns>
        public abstract IPersistenceObject ContainsObject(InterfaceType type, int ID);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public abstract IEnumerable<IPersistenceObject> AttachedObjects
        {
            get;
        }

        /// <summary>
        /// Submits the changes and returns the number of affected Objects. Note: only IDataObjects are counted.
        /// </summary>
        /// <returns>Number of affected Objects</returns>
        public abstract int SubmitChanges();

        /// <summary>
        /// Submits the changes and returns the number of affected Objects.
        /// This method does not fire any events or methods on added/changed objects. 
        /// It also does not change any IChanged property.
        /// </summary>
        /// <remarks>
        /// Only IDataObjects are counded.
        /// </remarks>
        /// <returns>Number of affected Objects</returns>
        public abstract int SubmitRestore();

        Identity localIdentity = null;
        protected virtual void NotifyChanging(IEnumerable<IDataObject> changedOrAdded)
        {
            foreach (IDataObject obj in changedOrAdded)
            {
                if (obj is Kistl.App.Base.Blob && obj.ObjectState == DataObjectState.Modified)
                {
                    throw new InvalidOperationException("Modifing a Kistl.App.Base.Blob is not allowed. Upload a new Blob instead.");
                }

                if (obj is Kistl.App.Base.IChangedBy)
                {
                    var cb = (Kistl.App.Base.IChangedBy)obj;
                    var now = DateTime.Now;
                    if (obj.ObjectState == DataObjectState.New)
                    {
                        cb.CreatedOn = now;
                    }
                    cb.ChangedOn = now;

                    if (this.identity != null)
                    {
                        if(localIdentity == null)
                        {
                            localIdentity = this.identity.Context == this ? this.identity : this.GetQuery<Identity>().First(id => id.ID == this.identity.ID);
                        }

                        if (obj.ObjectState == DataObjectState.New)
                        {
                            cb.CreatedBy = localIdentity;
                        }
                        cb.ChangedBy = localIdentity;
                    }
                }

                obj.NotifyPreSave();
            }
        }

        protected virtual void NotifyChanged(IEnumerable<IDataObject> changedOrAdded)
        {
            changedOrAdded.ForEach(obj => obj.NotifyPostSave());
        }

        /// <summary>
        /// Creates an unattached instance of the specified interface type. This is used by various public methods to create objects.
        /// </summary>
        /// <param name="ifType">the requested type</param>
        /// <returns>a newly initialised provider-specific object of the specified type, which is not yet attached</returns>
        protected abstract object CreateUnattachedInstance(InterfaceType ifType);

        private IPersistenceObject CreateInternal(InterfaceType ifType)
        {
            var obj = (IPersistenceObject)CreateUnattachedInstance(ifType);
            Attach(obj);
            OnObjectCreated(obj);
            if (obj is IDataObject)
            {
                ((IDataObject)obj).NotifyCreated();
            }
            return obj;
        }

        /// <summary>
        /// Creates a new IPersistenceObject by System.Type. Note - this Method is depricated!
        /// </summary>
        /// <param name="ifType">System.Type of the new IPersistenceObject</param>
        /// <returns>A new IPersistenceObject</returns>
        public virtual IDataObject Create(InterfaceType ifType)
        {
            if (ifType == null) throw new ArgumentNullException("ifType");
            if (ifType.Type == typeof(Kistl.App.Base.Blob)) throw new InvalidOperationException("Creating a Blob is not supported. Use CreateBlob() instead");

            ObjectClass cls = metaDataResolver.GetObjectClass(ifType).GetRootClass();
            if (identity != null && cls.HasAccessControlList() && (cls.GetGroupAccessRights(identity) & AccessRights.Create) != AccessRights.Create)
            {
                throw new System.Security.SecurityException(string.Format("The current identity has no rights to create an Object of type '{0}'", ifType.Type.FullName));
            }
            return (IDataObject)CreateInternal(ifType);
        }

        /// <summary>
        /// Creates a new IDataObject.
        /// </summary>
        /// <typeparam name="T">Type of the new IDataObject</typeparam>
        /// <returns>A new IDataObject</returns>
        public virtual T Create<T>() where T : class, IDataObject
        {
            return (T)Create(iftFactory(typeof(T)));
        }

        /// <inheritdoc />
        public IPersistenceObject CreateUnattached(InterfaceType ifType)
        {
            return (IPersistenceObject)CreateUnattachedInstance(ifType);
        }

        /// <inheritdoc />
        public T CreateUnattached<T>() where T : class, IPersistenceObject
        {
            return (T)CreateUnattachedInstance(iftFactory(typeof(T)));
        }

        /// <summary>
        /// Creates a new IPersistenceObject by System.Type.
        /// </summary>
        /// <param name="ifType">Interface type of the new IPersistenceObject</param>
        /// <returns>A new IPersistenceObject</returns>
        public virtual IRelationCollectionEntry CreateRelationCollectionEntry(InterfaceType ifType)
        {
            return (IRelationCollectionEntry)CreateInternal(ifType);
        }

        /// <summary>
        /// Creates a new IPersistenceObject.
        /// </summary>
        /// <typeparam name="T">Type of the new IPersistenceObject</typeparam>
        /// <returns>A new IDataObject</returns>
        public virtual T CreateRelationCollectionEntry<T>() where T : IRelationCollectionEntry
        {
            return (T)CreateRelationCollectionEntry(iftFactory(typeof(T)));
        }

        /// <summary>
        /// Creates a new IPersistenceObject by System.Type.
        /// </summary>
        /// <param name="ifType">Interface type of the new IPersistenceObject</param>
        /// <returns>A new IPersistenceObject</returns>
        public virtual IValueCollectionEntry CreateValueCollectionEntry(InterfaceType ifType)
        {
            return (IValueCollectionEntry)CreateInternal(ifType);
        }

        /// <summary>
        /// Creates a new IPersistenceObject.
        /// </summary>
        /// <typeparam name="T">Type of the new IPersistenceObject</typeparam>
        /// <returns>A new IDataObject</returns>
        public virtual T CreateValueCollectionEntry<T>() where T : IValueCollectionEntry
        {
            return (T)CreateValueCollectionEntry(iftFactory(typeof(T)));
        }

        /// <summary>
        /// Creates a new CompoundObject by Type
        /// </summary>
        /// <param name="ifType">Type of the new CompoundObject</param>
        /// <returns>A new CompoundObject</returns>
        public virtual ICompoundObject CreateCompoundObject(InterfaceType ifType)
        {
            return (ICompoundObject)CreateUnattachedInstance(ifType);
        }

        /// <summary>
        /// Creates a new CompoundObject.
        /// </summary>
        /// <typeparam name="T">Type of the new CompoundObject</typeparam>
        /// <returns>A new CompoundObject</returns>
        public virtual T CreateCompoundObject<T>() where T : ICompoundObject
        {
            return (T)CreateCompoundObject(iftFactory(typeof(T)));
        }

        /// <summary>
        /// Find the Object of the given type by ID
        /// TODO: This is quite redundant here as it only uses other IKistlContext Methods.
        /// This could be moved to a common abstract IKistlContextBase
        /// <remarks>Entity Framework does not support queries on Interfaces. Please use GetQuery&lt;T&gt;()</remarks>
        /// </summary>
        /// <param name="type">Object Type of the Object to find.</param>
        /// <param name="ID">ID of the Object to find.</param>
        /// <returns>IDataObject. If the Object is not found, a Exception is thrown.</returns>
        public abstract IDataObject Find(InterfaceType type, int ID);

        /// <summary>
        /// Find the Object of the given type by ID
        /// TODO: This is quite redundant here as it only uses other IKistlContext Methods.
        /// This could be moved to a common abstract IKistlContextBase
        /// </summary>
        /// <typeparam name="T">Object Type of the Object to find.</typeparam>
        /// <param name="ID">ID of the Object to find.</param>
        /// <returns>IDataObject. If the Object is not found, a Exception is thrown.</returns>
        public abstract T Find<T>(int ID) where T : class, IDataObject;

        /// <summary>
        /// Find the Persistence Object of the given type by ID
        /// </summary>
        /// <param name="ifType">Object Type of the Object to find.</param>
        /// <param name="ID">ID of the Object to find.</param>
        /// <returns>IDataObject. If the Object is not found, a Exception is thrown.</returns>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public abstract IPersistenceObject FindPersistenceObject(InterfaceType ifType, int ID);
        /// <summary>
        /// Find the Persistence Object of the given type by ID
        /// </summary>
        /// <typeparam name="T">Object Type of the Object to find.</typeparam>
        /// <param name="ID">ID of the Object to find.</param>
        /// <returns>IDataObject. If the Object is not found, a Exception is thrown.</returns>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public abstract T FindPersistenceObject<T>(int ID) where T : class, IPersistenceObject;

        /// <summary>
        /// Find the Persistence Object of the given type by an ExportGuid
        /// </summary>
        /// <param name="ifType">Object Type of the Object to find.</param>
        /// <param name="exportGuid">ExportGuid of the Object to find.</param>
        /// <returns>IPersistenceObject or null if the Object was not found.</returns>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public abstract IPersistenceObject FindPersistenceObject(InterfaceType ifType, Guid exportGuid);
        /// <summary>
        /// Find the Persistence Object of the given type by an ExportGuid
        /// </summary>
        /// <typeparam name="T">Object Type of the Object to find.</typeparam>
        /// <param name="exportGuid">ExportGuid of the Object to find.</param>
        /// <returns>IPersistenceObject or null if the Object was not found.</returns>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public abstract T FindPersistenceObject<T>(Guid exportGuid) where T : class, IPersistenceObject;

        /// <summary>
        /// Find Persistence Objects of the given type by ExportGuids
        /// </summary>
        /// <param name="ifType">Object Type of the Object to find.</param>
        /// <param name="exportGuids">ExportGuids of the Objects to find.</param>
        /// <returns>A List of IPersistenceObject.</returns>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public abstract IEnumerable<IPersistenceObject> FindPersistenceObjects(InterfaceType ifType, IEnumerable<Guid> exportGuids);
        /// <summary>
        /// Find Persistence Objects of the given type by ExportGuids
        /// </summary>
        /// <typeparam name="T">Object Type of the Object to find.</typeparam>
        /// <param name="exportGuids">ExportGuids of the Objects to find.</param>
        /// <returns>A List of IPersistenceObject.</returns>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        public abstract IEnumerable<T> FindPersistenceObjects<T>(IEnumerable<Guid> exportGuids) where T : class, IPersistenceObject;

        public int CreateBlob(System.IO.Stream s, string filename, string mimetype)
        {
            if (s == null) throw new ArgumentNullException("s");
            if (string.IsNullOrEmpty(filename)) throw new ArgumentNullException("filename");
            if (string.IsNullOrEmpty(mimetype)) throw new ArgumentNullException("mimetype");

            var blob = (Kistl.App.Base.Blob)this.CreateInternal(iftFactory(typeof(Kistl.App.Base.Blob)));
            DateTime today = DateTime.Today;
            blob.StoragePath = string.Format(@"{0:0000}\{1:00}\{2:00}\({3}) - {4}", today.Year, today.Month, today.Day, Guid.NewGuid(), filename);
            blob.OriginalName = filename;
            blob.MimeType = mimetype;

            string path = System.IO.Path.Combine(config.Server.DocumentStore, blob.StoragePath);
            System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path));

            using (var file = System.IO.File.Open(path, System.IO.FileMode.Create, System.IO.FileAccess.Write))
            {
                file.SetLength(0);
                s.CopyTo(file);
            }
            System.IO.File.SetAttributes(path, System.IO.FileAttributes.ReadOnly);

            return blob.ID;
        }

        public int CreateBlob(System.IO.FileInfo fi, string mimetype)
        {
            if (fi == null) throw new ArgumentNullException("fi");
            using (var s = fi.OpenRead())
            {
                return CreateBlob(s, fi.Name, mimetype);
            }
        }

        public System.IO.Stream GetStream(int ID)
        {
            return GetFileInfo(ID).OpenRead();
        }

        public System.IO.FileInfo GetFileInfo(int ID)
        {
            var blob = this.Find<Kistl.App.Base.Blob>(ID);
            string path = System.IO.Path.Combine(config.Server.DocumentStore, blob.StoragePath);
            return new System.IO.FileInfo(path);
        }

        public event GenericEventHandler<IPersistenceObject> ObjectCreated;

        protected virtual void OnObjectCreated(IPersistenceObject obj)
        {
            if (ObjectCreated != null)
            {
                ObjectCreated(this, new GenericEventArgs<IPersistenceObject>() { Data = obj });
            }
        }

        public event GenericEventHandler<IPersistenceObject> ObjectDeleted;

        protected virtual void OnObjectDeleted(IPersistenceObject obj)
        {
            if (ObjectDeleted != null)
            {
                ObjectDeleted(this, new GenericEventArgs<IPersistenceObject>() { Data = obj });
            }
        }

        #region IReadOnlyKistlContext Members

        public InterfaceType GetInterfaceType(IPersistenceObject obj)
        {
            return iftFactory(((BasePersistenceObject)obj).GetImplementedInterface());
        }

        public InterfaceType GetInterfaceType(Type t)
        {
            return iftFactory(t);
        }

        public InterfaceType GetInterfaceType(string typeName)
        {
            return iftFactory(Type.GetType(typeName + "," + typeof(ObjectClass).Assembly.FullName));
        }

        public abstract ImplementationType GetImplementationType(Type t);
        public abstract ImplementationType ToImplementationType(InterfaceType t);

        #endregion
    }
}
