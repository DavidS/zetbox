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
    using System.ServiceModel;
    using System.Text;
    using Kistl.API.Client.KistlService;
    using Kistl.API.Client.PerfCounter;
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

        object InvokeServerMethod(IKistlContext ctx, InterfaceType ifType, int ID, string method, Type retValType, IEnumerable<Type> parameterTypes, IEnumerable<object> parameter, IEnumerable<IPersistenceObject> objects, IEnumerable<ObjectNotificationRequest> notificationRequests, out IEnumerable<IPersistenceObject> changedObjects, out List<IStreamable> auxObjects);

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
        private const int MAX_RETRY_COUNT = 2;

        private InterfaceType.Factory _iftFactory;
        private KistlService.IKistlService _service;
        private readonly IPerfCounter _perfCounter;
        private readonly KistlStreamReader.Factory _readerFactory;
        private readonly KistlStreamWriter.Factory _writerFactory;

        public ProxyImplementation(InterfaceType.Factory iftFactory, Kistl.API.Client.KistlService.IKistlService service, IPerfCounter perfCounter, KistlStreamReader.Factory readerFactory, KistlStreamWriter.Factory writerFactory)
        {
            if (perfCounter == null) throw new ArgumentNullException("perfCounter");
            if (readerFactory == null) throw new ArgumentNullException("readerFactory");
            if (writerFactory == null) throw new ArgumentNullException("writerFactory");

            _iftFactory = iftFactory;
            _service = service;
            _perfCounter = perfCounter;
            _readerFactory = readerFactory;
            _writerFactory = writerFactory;
        }

        private void MakeRequest(Action request)
        {
            Exception fault = null;
            for (int i = 0; i < MAX_RETRY_COUNT; i++)
            {
                fault = null;
                try
                {
                    request();
                    break;
                }
                catch (FaultException<ConcurrencyException> cex)
                {
                    throw cex.Detail;
                }
                catch (FaultException<InvalidKistlGeneratedVersionException> vex)
                {
                    throw vex.Detail;
                }
                catch (FaultException)
                {
                    throw;
                }
                catch (ConcurrencyException)
                {
                    throw;
                }
                catch (InvalidKistlGeneratedVersionException)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    // Retry
                    fault = ex;
                }
            }

            if (fault != null) throw new IOException("Error when accessing server", fault);
        }

        public IEnumerable<IDataObject> GetList(IKistlContext ctx, InterfaceType ifType, int maxListCount, bool eagerLoadLists, IEnumerable<Expression> filter, IEnumerable<OrderBy> orderBy, out List<IStreamable> auxObjects)
        {
            int resultCount = 0;
            List<IStreamable> tmpAuxObjects = null;
            var _ifType = ifType.ToSerializableType();
            var ticks = _perfCounter.IncrementGetList(ifType);
            try
            {
                var _filter = filter != null ? filter.Select(f => SerializableExpression.FromExpression(f, _iftFactory)).ToArray() : null;
                var _orderBy = orderBy != null ? orderBy.Select(o => new OrderByContract() { Type = o.Type, Expression = SerializableExpression.FromExpression(o.Expression, _iftFactory) }).ToArray() : null;
                byte[] bytes = null;

                MakeRequest(() =>
                {
                    bytes = _service.GetList(
                        KistlGeneratedVersionAttribute.Current,
                        _ifType,
                        maxListCount,
                        eagerLoadLists,
                        _filter,
                        _orderBy);
                });

                Logging.Facade.DebugFormat("GetList retrieved: {0:n0} bytes", bytes.Length);

                IEnumerable<IDataObject> result = null;
                using (var sr = _readerFactory(new BinaryReader(new MemoryStream(bytes))))
                {
                    result = ReceiveObjects(ctx, sr, out tmpAuxObjects).Cast<IDataObject>();
                }
                resultCount = result.Count();
                auxObjects = tmpAuxObjects;
                return result;
            }
            finally
            {
                _perfCounter.DecrementGetList(ifType, resultCount, ticks);
            }
        }

        public IEnumerable<IDataObject> GetListOf(IKistlContext ctx, InterfaceType ifType, int ID, string property, out List<IStreamable> auxObjects)
        {
            List<IStreamable> tmpAuxObjects = null;
            int resultCount = 0;
            var _ifType = ifType.ToSerializableType();
            var ticks = _perfCounter.IncrementGetListOf(ifType);
            try
            {
                byte[] bytes = null;

                MakeRequest(() =>
                {
                    bytes = _service.GetListOf(KistlGeneratedVersionAttribute.Current, _ifType, ID, property);
                });

                IEnumerable<IDataObject> result = null;
                using (var sr = _readerFactory(new BinaryReader(new MemoryStream(bytes))))
                {
                    result = ReceiveObjects(ctx, sr, out tmpAuxObjects).Cast<IDataObject>();
                }
                resultCount = result.Count();

                auxObjects = tmpAuxObjects;
                return result;
            }
            finally
            {
                _perfCounter.DecrementGetListOf(ifType, resultCount, ticks);
            }
        }

        public IEnumerable<IPersistenceObject> SetObjects(IKistlContext ctx, IEnumerable<IPersistenceObject> objects, IEnumerable<ObjectNotificationRequest> notficationRequests)
        {
            var ticks = _perfCounter.IncrementSetObjects();
            try
            {
                IEnumerable<IPersistenceObject> result = null;
                // Serialize
                using (var ms = new MemoryStream())
                using (var sw = _writerFactory(new BinaryWriter(ms)))
                {
                    SendObjects(objects, sw);
                    byte[] bytes = null;
                    var _ms = ms.ToArray();
                    var _nReq = notficationRequests.ToArray();

                    MakeRequest(() =>
                    {
                        bytes = _service.SetObjects(KistlGeneratedVersionAttribute.Current, _ms, _nReq);
                    });

                    using (var sr = _readerFactory(new BinaryReader(new MemoryStream(bytes))))
                    {
                        // merge auxiliary objects into primary set objects result
                        List<IStreamable> auxObjects;
                        var receivedObjects = ReceiveObjects(ctx, sr, out auxObjects);
                        result = receivedObjects.Concat(auxObjects).Cast<IPersistenceObject>();
                    }
                }

                return result;
            }
            finally
            {
                _perfCounter.DecrementSetObjects(objects.Count(), ticks);
            }
        }

        private static void SendObjects(IEnumerable<IPersistenceObject> objects, KistlStreamWriter sw)
        {
            foreach (var obj in objects)
            {
                sw.Write(true);
                obj.ToStream(sw, new HashSet<IStreamable>(), false);
            }
            sw.Write(false);
        }

        private IEnumerable<IStreamable> ReceiveObjects(IKistlContext ctx, KistlStreamReader sr, out List<IStreamable> auxObjects)
        {
            var result = ReceiveObjectList(ctx, sr);
            auxObjects = ReceiveObjectList(ctx, sr);
            Logging.Facade.DebugFormat("retrieved: {0} objects; {1} auxObjects", result.Count, auxObjects.Count);
            return result;
        }

        private List<IStreamable> ReceiveObjectList(IKistlContext ctx, KistlStreamReader sr)
        {
            List<IStreamable> result = new List<IStreamable>();
            bool cont = sr.ReadBoolean();
            long dbgByteCounter = 0;
            long dbgObjTypeByteCounter = 0;
            while (cont)
            {
                long dbgCurrentPos = sr.BaseStream.Position;
                var objType = sr.ReadSerializableType();
                dbgObjTypeByteCounter += sr.BaseStream.Position - dbgCurrentPos;

                IStreamable obj = (IStreamable)ctx.Internals().CreateUnattached(_iftFactory(objType.GetSystemType()));
                obj.FromStream(sr);
                result.Add((IStreamable)obj);

                cont = sr.ReadBoolean();
                long dbgSize = sr.BaseStream.Position - dbgCurrentPos;
                dbgByteCounter += dbgSize;
            }
            Logging.Facade.DebugFormat("ReceiveObjectList: {0:n0} objects; {1:n0} bytes total size; {2:n0} bytes avg. size / object; Total ObjType size: {3:n0}; {4:n2}% of total", result.Count, dbgByteCounter, (double)dbgByteCounter / (double)result.Count, dbgObjTypeByteCounter, (double)dbgObjTypeByteCounter / (double)dbgByteCounter * 100.0);
            return result;
        }

        public IEnumerable<T> FetchRelation<T>(IKistlContext ctx, Guid relationId, RelationEndRole role, IDataObject parent, out List<IStreamable> auxObjects)
            where T : class, IRelationEntry
        {
            var ifType = ctx.GetInterfaceType(parent);
            var ticks = _perfCounter.IncrementFetchRelation(ifType);
            int resultCount = 0;
            try
            {
                // TODO: could be implemented in generated properties
                if (parent.ObjectState == DataObjectState.New)
                {
                    auxObjects = new List<IStreamable>();
                    return new List<T>();
                }

                IEnumerable<T> result = null;
                List<IStreamable> tmpAuxObjects = null;
                byte[] bytes = null;

                MakeRequest(() =>
                {
                    bytes = _service.FetchRelation(KistlGeneratedVersionAttribute.Current, relationId, (int)role, parent.ID);
                });
                using (MemoryStream s = new MemoryStream(bytes))
                using (var sr = _readerFactory(new BinaryReader(s)))
                {
                    result = ReceiveObjects(ctx, sr, out tmpAuxObjects).Cast<T>();
                }
                resultCount = result.Count();

                auxObjects = tmpAuxObjects;
                return result;
            }
            finally
            {
                _perfCounter.DecrementFetchRelation(ifType, resultCount, ticks);
            }
        }

        public Stream GetBlobStream(int ID)
        {
            Stream result = null;
            MakeRequest(() =>
            {
                result = _service.GetBlobStream(KistlGeneratedVersionAttribute.Current, ID);
            });
            return result;
        }

        public Kistl.App.Base.Blob SetBlobStream(IKistlContext ctx, Stream stream, string filename, string mimetype)
        {
            Kistl.App.Base.Blob result = null;
            BlobResponse response = null;
            BlobMessage msg = new BlobMessage() { Version = KistlGeneratedVersionAttribute.Current, FileName = filename, MimeType = mimetype, Stream = stream };

            MakeRequest(() =>
            {
                // Rewind stream to ensure complete files, e.g. after a fault
                if (msg.Stream.Position != 0)
                    msg.Stream.Seek(0, SeekOrigin.Begin);
                response = _service.SetBlobStream(msg);
            });

            using (var sr = _readerFactory(new BinaryReader(response.BlobInstance)))
            {
                // ignore auxObjects for blobs, which should not have them
                result = ReceiveObjectList(ctx, sr).Cast<Kistl.App.Base.Blob>().Single();
            }
            return result;
        }

        public object InvokeServerMethod(IKistlContext ctx, InterfaceType ifType, int ID, string method, Type retValType, IEnumerable<Type> parameterTypes, IEnumerable<object> parameter, IEnumerable<IPersistenceObject> objects, IEnumerable<ObjectNotificationRequest> notificationRequests, out IEnumerable<IPersistenceObject> changedObjects, out List<IStreamable> auxObjects)
        {
            _perfCounter.IncrementServerMethodInvocation();

            object result = null;
            auxObjects = null;

            byte[] retChangedObjectsArray = null;
            byte[] bytes = null;

            using (var parameterStream = new MemoryStream())
            using (var parameterWriter = _writerFactory(new BinaryWriter(parameterStream)))
            {
                foreach (var paramVal in parameter)
                {
                    parameterWriter.Write(paramVal);
                }

                using (var changedObjectsStream = new MemoryStream())
                using (var sw = _writerFactory(new BinaryWriter(changedObjectsStream)))
                {
                    SendObjects(objects, sw);

                    var _ifType = ifType.ToSerializableType();
                    var _parameterTypes = parameterTypes.Select(t => _iftFactory(t).ToSerializableType()).ToArray();
                    var _parameterStream = parameterStream.ToArray();
                    var _changedObjStream = changedObjectsStream.ToArray();
                    var _nReq = notificationRequests.ToArray();

                    MakeRequest(() =>
                    {
                        bytes = _service.InvokeServerMethod(
                             out retChangedObjectsArray,
                             KistlGeneratedVersionAttribute.Current,
                             _ifType,
                             ID,
                             method,
                             _parameterTypes,
                             _parameterStream,
                             _changedObjStream,
                             _nReq);
                    });
                }
            }

            IEnumerable<IPersistenceObject> tmpChangedObjects = null;

            using (var resultStream = new MemoryStream(bytes))
            {
                using (var retChangedObjects = new MemoryStream(retChangedObjectsArray))
                using (var br = _readerFactory(new BinaryReader(retChangedObjects)))
                {
                    tmpChangedObjects = ReceiveObjectList(ctx, br).Cast<IPersistenceObject>();
                }

                resultStream.Seek(0, SeekOrigin.Begin);

                if (retValType.IsIStreamable())
                {
                    var br = _readerFactory(new BinaryReader(resultStream));
                    result = ReceiveObjects(ctx, br, out auxObjects).Cast<IPersistenceObject>().FirstOrDefault();
                }
                else if (retValType.IsIEnumerable() && retValType.FindElementTypes().Any(t => t.IsIPersistenceObject()))
                {
                    var br = _readerFactory(new BinaryReader(resultStream));
                    IList lst = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(retValType.FindElementTypes().Single(t => t.IsIPersistenceObject())));
                    foreach (object resultObj in ReceiveObjects(ctx, br, out auxObjects))
                    {
                        lst.Add(resultObj);
                    }
                    result = lst;
                }
                else if (resultStream.Length > 0)
                {
                    result = new BinaryFormatter().Deserialize(resultStream);
                }
                else
                {
                    result = null;
                }

                changedObjects = tmpChangedObjects;
                return result;
            }
        }

        public void Dispose()
        {
        }
    }
}
