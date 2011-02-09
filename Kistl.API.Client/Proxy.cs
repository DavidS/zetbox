#define USE_STREAMS

namespace Kistl.API.Client
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;
    using Kistl.API.Client.KistlService;
    using Kistl.API.Utils;

    /// <summary>
    /// Proxy Interface for IKistlService
    /// </summary>
    public interface IProxy
        : IDisposable
    {
        IEnumerable<IDataObject> GetList(IKistlContext ctx, InterfaceType ifType, int maxListCount, bool eagerLoadLists, IEnumerable<Expression> filter, IEnumerable<OrderBy> orderBy, out List<IStreamable> auxObjects);
        IEnumerable<IDataObject> GetListOf(IKistlContext ctx, InterfaceType ifType, int ID, string property, out List<IStreamable> auxObjects);

        IEnumerable<IPersistenceObject> SetObjects(IKistlContext ctx, IEnumerable<IPersistenceObject> objects, IEnumerable<ObjectNotificationRequest> notificationRequests);

        object InvokeServerMethod(IKistlContext ctx, InterfaceType ifType, int ID, string method, Type retValType, IEnumerable<Type> parameterTypes, IEnumerable<object> parameter, IEnumerable<IPersistenceObject> objects, IEnumerable<ObjectNotificationRequest> notificationRequests, out IEnumerable<IPersistenceObject> changedObjects);

        IEnumerable<T> FetchRelation<T>(IKistlContext ctx, Guid relationId, RelationEndRole role, IDataObject parent, out List<IStreamable> auxObjects)
            where T : class, IRelationEntry;

        Stream GetBlobStream(int ID);
        Kistl.App.Base.Blob SetBlobStream(IKistlContext ctx, Stream stream, string filename, string mimetype);
    }

    /// <summary>
    /// Proxy Implementation
    /// </summary>
    internal class ProxyImplementation
        : IProxy
    {
        private InterfaceType.Factory _iftFactory;
        private ICredentialsResolver _credentialsResolver;
        private IToolkit _toolkit;

        public ProxyImplementation(InterfaceType.Factory iftFactory, ICredentialsResolver credentialsResolver, IToolkit toolkit)
        {
            _iftFactory = iftFactory;
            _credentialsResolver = credentialsResolver;
            _toolkit = toolkit;
        }

        private readonly static object _lock = new object();

        private KistlServiceClient _service;

        /// <summary>
        /// Instantiates a WCF Proxy for KistlService, configured according 
        /// to the app.config file.
        /// </summary>        
        private KistlServiceClient Service
        {
            get
            {
                lock (_lock)
                {
                    if (_service == null || _service.State != System.ServiceModel.CommunicationState.Opened)
                    {
                        Logging.Facade.Info("Initializing Service");
                        _service = new KistlServiceClient();
                        _credentialsResolver.InitCredentials(_service.ClientCredentials);
                    }
                    return _service;
                }
            }
        }

        public IEnumerable<IDataObject> GetList(IKistlContext ctx, InterfaceType ifType, int maxListCount, bool eagerLoadLists, IEnumerable<Expression> filter, IEnumerable<OrderBy> orderBy, out List<IStreamable> auxObjects)
        {
            List<IStreamable> tmpAuxObjects = null;
            IEnumerable<IDataObject> result = null;
            _toolkit.WithWaitDialog(() =>
            {
                using (MemoryStream s = new MemoryStream(Service.GetList(
                    ifType.ToSerializableType(),
                    maxListCount,
                    eagerLoadLists,
                    filter != null ? filter.Select(f => SerializableExpression.FromExpression(f, _iftFactory)).ToArray() : null,
                    orderBy != null ? orderBy.Select(o => new OrderByContract() { Type = o.Type, Expression = SerializableExpression.FromExpression(o.Expression, _iftFactory) }).ToArray() : null)))
                {
                    using (var sr = new BinaryReader(s))
                    {
                        result = ReceiveObjects(ctx, sr, out tmpAuxObjects).Cast<IDataObject>();
                    }
                }
            });
            auxObjects = tmpAuxObjects;
            return result;
        }

        public IEnumerable<IDataObject> GetListOf(IKistlContext ctx, InterfaceType ifType, int ID, string property, out List<IStreamable> auxObjects)
        {
            List<IStreamable> tmpAuxObjects = null;
            IEnumerable<IDataObject> result = null;

            _toolkit.WithWaitDialog(() =>
            {
                using (MemoryStream s = new MemoryStream(Service.GetListOf(ifType.ToSerializableType(), ID, property)))
                {
                    using (var sr = new BinaryReader(s))
                    {
                        result = ReceiveObjects(ctx, sr, out tmpAuxObjects).Cast<IDataObject>();
                    }
                }
            });

            auxObjects = tmpAuxObjects;
            return result;
        }

        public IEnumerable<IPersistenceObject> SetObjects(IKistlContext ctx, IEnumerable<IPersistenceObject> objects, IEnumerable<ObjectNotificationRequest> notficationRequests)
        {
            IEnumerable<IPersistenceObject> result = null;

            _toolkit.WithWaitDialog(() =>
            {
                // Serialize
                using (var ms = new MemoryStream())
                {
                    using (var sw = new BinaryWriter(ms))
                    {
                        SendObjects(objects, sw);

                        using (MemoryStream s = new MemoryStream(Service.SetObjects(ms.ToArray(), notficationRequests.ToArray())))
                        {
                            using (var sr = new BinaryReader(s))
                            {
                                // merge auxiliary objects into primary set objects result
                                List<IStreamable> auxObjects;
                                var receivedObjects = ReceiveObjects(ctx, sr, out auxObjects);
                                result = receivedObjects.Concat(auxObjects).Cast<IPersistenceObject>();
                            }
                        }
                    }
                }
            });

            return result;
        }

        private static void SendObjects(IEnumerable<IPersistenceObject> objects, BinaryWriter sw)
        {
            foreach (var obj in objects)
            {
                BinarySerializer.ToStream(true, sw);
                obj.ToStream(sw, new HashSet<IStreamable>(), false);
            }
            BinarySerializer.ToStream(false, sw);
        }

        private IEnumerable<IStreamable> ReceiveObjects(IKistlContext ctx, BinaryReader sr, out List<IStreamable> auxObjects)
        {
            var result = ReceiveObjectList(ctx, sr);
            auxObjects = ReceiveObjectList(ctx, sr);
            Logging.Facade.DebugFormat("retrieved: {0} objects; {1} auxObjects", result.Count, auxObjects.Count);
            return result;
        }

        private List<IStreamable> ReceiveObjectList(IKistlContext ctx, BinaryReader sr)
        {
            List<IStreamable> result = new List<IStreamable>();
            bool cont = true;
            BinarySerializer.FromStream(out cont, sr);
            while (cont)
            {
                SerializableType objType;
                BinarySerializer.FromStream(out objType, sr);

                IStreamable obj = (IStreamable)ctx.Internals().CreateUnattached(_iftFactory(objType.GetSystemType()));
                obj.FromStream(sr);

                result.Add((IStreamable)obj);
                BinarySerializer.FromStream(out cont, sr);
            }
            return result;
        }

        public IEnumerable<T> FetchRelation<T>(IKistlContext ctx, Guid relationId, RelationEndRole role, IDataObject parent, out List<IStreamable> auxObjects)
            where T : class, IRelationEntry
        {
            // TODO: could be implemented in generated properties
            if (parent.ObjectState == DataObjectState.New)
            {
                auxObjects = new List<IStreamable>();
                return new List<T>();
            }

            IEnumerable<T> result = null;
            List<IStreamable> tmpAuxObjects = null;
            _toolkit.WithWaitDialog(() =>
            {
                using (MemoryStream s = new MemoryStream(Service.FetchRelation(relationId, (int)role, parent.ID)))
                using (var sr = new BinaryReader(s))
                {
                    result = ReceiveObjects(ctx, sr, out tmpAuxObjects).Cast<T>();
                }
            });

            auxObjects = tmpAuxObjects;
            return result;
        }

        #region IDisposable Members

        // as recommended on http://msdn2.microsoft.com/en-gb/ms182172.aspx
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                if (_service != null)
                {
                    Logging.Facade.Debug("Closing Service");
                    _service.Close();
                    ((IDisposable)_service).Dispose();
                    _service = null;
                }
            }
            // free native resources
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

        public Stream GetBlobStream(int ID)
        {
            Stream result = null;
            _toolkit.WithWaitDialog(() =>
            {
                result = Service.GetBlobStream(ID);
            });
            return result;
        }

        public Kistl.App.Base.Blob SetBlobStream(IKistlContext ctx, Stream stream, string filename, string mimetype)
        {
            Kistl.App.Base.Blob result = null;
            Stream s;
            _toolkit.WithWaitDialog(() =>
            {
                Service.SetBlobStream(filename, mimetype, stream, out s);
                try
                {
                    using (var sr = new BinaryReader(s))
                    {
                        result = ReceiveObjectList(ctx, sr).Cast<Kistl.App.Base.Blob>().Single();
                    }
                }
                finally
                {
                    s.Dispose();
                }
            });
            return result;
        }

        public object InvokeServerMethod(IKistlContext ctx, InterfaceType ifType, int ID, string method, Type retValType, IEnumerable<Type> parameterTypes, IEnumerable<object> parameter, IEnumerable<IPersistenceObject> objects, IEnumerable<ObjectNotificationRequest> notificationRequests, out IEnumerable<IPersistenceObject> changedObjects)
        {
            object result = null;
            IEnumerable<IPersistenceObject> tmpChangedObjects = null;

            _toolkit.WithWaitDialog(() =>
            {
                BinaryFormatter bf = new BinaryFormatter();
                MemoryStream parameterStream = new MemoryStream();
                bf.Serialize(parameterStream, parameter);

                MemoryStream changedObjectsStream = new MemoryStream();
                BinaryWriter sw = new BinaryWriter(changedObjectsStream);
                SendObjects(objects, sw);

                byte[] retChangedObjectsArray;
                var resultStream = new MemoryStream(Service.InvokeServerMethod(
                    out retChangedObjectsArray,
                    ifType.ToSerializableType(),
                    ID,
                    method,
                    parameterTypes.Select(t => ifType.ToSerializableType()).ToArray(),
                    parameterStream.ToArray(),
                    changedObjectsStream.ToArray(),
                    notificationRequests.ToArray()));
                {
                    MemoryStream retChangedObjects = new MemoryStream(retChangedObjectsArray);
                    BinaryReader br = new BinaryReader(retChangedObjects);
                    tmpChangedObjects = ReceiveObjectList(ctx, br).Cast<IPersistenceObject>();
                }

                resultStream.Seek(0, SeekOrigin.Begin);

                if (retValType.IsIStreamable())
                {
                    BinaryReader br = new BinaryReader(resultStream);
                    result = ReceiveObjectList(ctx, br).Cast<IPersistenceObject>().FirstOrDefault();
                }
                else if (retValType.IsIEnumerable() && retValType.FindElementTypes().First().IsIPersistenceObject())
                {
                    BinaryReader br = new BinaryReader(resultStream);
                    IList lst = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(retValType.FindElementTypes().First()));
                    foreach (object resultObj in ReceiveObjectList(ctx, br))
                    {
                        lst.Add(resultObj);
                    }
                    result = lst;
                }
                else
                {
                    result = bf.Deserialize(resultStream);
                }
            });

            changedObjects = tmpChangedObjects;
            return result;
        }
    }
}
