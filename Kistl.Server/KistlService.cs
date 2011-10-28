
namespace Kistl.Server
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.ServiceModel;
    using Kistl.API;
    using Kistl.API.Server;
    using Kistl.API.Server.PerfCounter;
    using Kistl.API.Utils;
    using Kistl.App.Base;

    /// <summary>
    /// Implements the main service interface.
    /// </summary>
    public class KistlService
        : IKistlService, IDisposable
    {
        private readonly IServerObjectHandlerFactory _sohFactory;
        private readonly Func<IKistlContext> _ctxFactory;
        private readonly InterfaceType.Factory _iftFactory;
        private readonly IPerfCounter _perfCounter;


        public KistlService(IServerObjectHandlerFactory sohFactory, Func<IKistlContext> ctxFactory, InterfaceType.Factory iftFactory, IPerfCounter perfCounter)
        {
            Logging.Facade.Info("Creating new KistlService instance");
            _sohFactory = sohFactory;
            _ctxFactory = ctxFactory;
            _iftFactory = iftFactory;
            _perfCounter = perfCounter;
        }

        private static void DebugLogIdentity()
        {
            Logging.Facade.DebugFormat("Called IsAuthenticated = {0}, Identity = {1}", System.Threading.Thread.CurrentPrincipal.Identity.IsAuthenticated, System.Threading.Thread.CurrentPrincipal.Identity.Name);
        }

        /// <summary>
        /// Puts a number of changed objects into the database. The resultant objects are sent back to the client.
        /// </summary>
        /// <param name="msgArray">a streamable list of <see cref="IPersistenceObject"/>s</param>
        /// <param name="notificationRequests">A list of objects the client wants to be notified about, if they change.</param>
        /// <returns>a streamable list of <see cref="IPersistenceObject"/>s</returns>
        public byte[] SetObjects(byte[] msgArray, ObjectNotificationRequest[] notificationRequests)
        {
            using (Logging.Facade.DebugTraceMethodCall("SetObjects"))
            {
                DebugLogIdentity();
                int resultCount = 0;
                var ticks = _perfCounter.IncrementSetObjects();
                try
                {
                    if (msgArray == null) { throw new ArgumentNullException("msgArray"); }
                    MemoryStream msg = new MemoryStream(msgArray);

                    msg.Seek(0, SeekOrigin.Begin);

                    using (IKistlContext ctx = _ctxFactory())
                    {
                        var objects = ReadObjects(msg, ctx);

                        // Set Operation
                        var changedObjects = _sohFactory
                            .GetServerObjectSetHandler()
                            .SetObjects(ctx, objects, notificationRequests ?? new ObjectNotificationRequest[0])
                            .Cast<IStreamable>();
                        resultCount = objects.Count;
                        return SendObjects(changedObjects, true).ToArray();
                    }

                }
                catch (ConcurrencyException cex)
                {
                    throw new FaultException<ConcurrencyException>(cex);
                }
                catch (Exception ex)
                {
                    Helper.ThrowFaultException(ex);
                    // Never called, Handle errors throws an Exception
                    return null;
                }
                finally
                {
                    _perfCounter.DecrementSetObjects(resultCount, ticks);
                }
            }
        }

        /// <summary>
        /// Returns a list of objects from the datastore, matching the specified filters.
        /// </summary>
        /// <param name="type">Type of Objects</param>
        /// <param name="maxListCount">Max. ammount of objects</param>
        /// <param name="eagerLoadLists">If true list properties will be eager loaded</param>
        /// <param name="filter">Serializable linq expression used a filter</param>
        /// <param name="orderBy">List of derializable linq expressions used as orderby</param>
        /// <returns>the found objects</returns>
        public byte[] GetList(SerializableType type, int maxListCount, bool eagerLoadLists, SerializableExpression[] filter, OrderByContract[] orderBy)
        {
            using (Logging.Facade.DebugTraceMethodCallFormat("GetList", "type={0}", type))
            {
                DebugLogIdentity();
                try
                {
                    if (type == null) { throw new ArgumentNullException("type"); }
                    var ifType = _iftFactory(type.GetSystemType());
                    int resultCount = 0;
                    var ticks = _perfCounter.IncrementGetList(ifType);
                    try
                    {
                        using (IKistlContext ctx = _ctxFactory())
                        {
                            var filterExpresstions = filter != null ? filter.Select(f => SerializableExpression.ToExpression(f)).ToList() : null;
                            IEnumerable<IStreamable> lst = _sohFactory
                                .GetServerObjectHandler(ifType)
                                .GetList(ctx, maxListCount,
                                    filterExpresstions,
                                    orderBy != null ? orderBy.Select(o => new OrderBy(o.Type, SerializableExpression.ToExpression(o.Expression))).ToList() : null);
                            resultCount = lst.Count();
                            return SendObjects(lst, eagerLoadLists).ToArray();
                        }
                    }
                    finally
                    {
                        _perfCounter.DecrementGetList(ifType, resultCount, ticks);
                    }
                }
                catch (Exception ex)
                {
                    Helper.ThrowFaultException(ex);
                    // Never called, Handle errors throws an Exception
                    return null;
                }
            }
        }

        /// <summary>
        /// Sends a list of auxiliary objects to the specified BinaryWriter while avoiding to send objects twice.
        /// </summary>
        /// <param name="sw">the stream to write to</param>
        /// <param name="auxObjects">a set of objects to send; will not be modified by this call</param>
        /// <param name="sentObjects">a set objects already sent; receives all newly sent objects too</param>
        /// <param name="eagerLoadLists">True if Lists should be eager loaded</param>
        private static void SendAuxiliaryObjects(BinaryWriter sw, HashSet<IStreamable> auxObjects, HashSet<IStreamable> sentObjects, bool eagerLoadLists)
        {
            // clone auxObjects to avoid modification
            auxObjects = new HashSet<IStreamable>(auxObjects);
            auxObjects.ExceptWith(sentObjects);
            // send all eagerly loaded objects
            while (auxObjects.Count > 0)
            {
                HashSet<IStreamable> secondTierAuxObjects = new HashSet<IStreamable>();
                foreach (var aux in auxObjects.Where(o => o != null))
                {
                    BinarySerializer.ToStream(true, sw);
                    aux.ToStream(sw, secondTierAuxObjects, eagerLoadLists);
                    sentObjects.Add(aux);
                }
                // check whether new objects where eagerly loaded
                secondTierAuxObjects.ExceptWith(sentObjects);
                auxObjects = secondTierAuxObjects;
            }
            // finish list
            BinarySerializer.ToStream(false, sw);
        }

        /// <summary>
        /// Serializes a list of objects onto a <see cref="MemoryStream"/>.
        /// </summary>
        /// <param name="lst">the list of objects to send</param>
        /// <param name="eagerLoadLists">True if Lists should be eager loaded</param>
        /// <returns>a memory stream containing all objects and all eagerly loaded auxiliary objects</returns>
        private static MemoryStream SendObjects(IEnumerable<IStreamable> lst, bool eagerLoadLists)
        {
            HashSet<IStreamable> sentObjects = new HashSet<IStreamable>();
            HashSet<IStreamable> auxObjects = new HashSet<IStreamable>();

            MemoryStream result = new MemoryStream();
            BinaryWriter sw = new BinaryWriter(result);
            foreach (IStreamable obj in lst)
            {
                BinarySerializer.ToStream(true, sw);
                // don't check sentObjects here, because a list might contain items twice
                obj.ToStream(sw, auxObjects, eagerLoadLists);
                sentObjects.Add(obj);
            }
            BinarySerializer.ToStream(false, sw);

            SendAuxiliaryObjects(sw, auxObjects, sentObjects, eagerLoadLists);

            // https://connect.microsoft.com/VisualStudio/feedback/details/541494/wcf-streaming-issue
            BinarySerializer.ToStream(false, sw);
            BinarySerializer.ToStream(false, sw);
            BinarySerializer.ToStream(false, sw);

            Logging.Facade.DebugFormat("Sending {0} Objects with {1} with AuxObjects and EagerLoadLists = {2}", sentObjects.Count, auxObjects.Count, eagerLoadLists);

            result.Seek(0, SeekOrigin.Begin);
            return result;
        }

        private List<IPersistenceObject> ReadObjects(Stream msg, IKistlContext ctx)
        {
            var objects = new List<IPersistenceObject>();
            BinaryReader sr = new BinaryReader(msg);
            bool @continue;
            BinarySerializer.FromStream(out @continue, sr);
            while (@continue)
            {
                // Deserialize
                SerializableType objType;
                BinarySerializer.FromStream(out objType, sr);

                var obj = ctx.Internals().CreateUnattached(_iftFactory(objType.GetSystemType()));
                objects.Add(obj);
                obj.FromStream(sr);
                BinarySerializer.FromStream(out @continue, sr);
            }
            return objects;
        }

        /// <summary>
        /// returns a list of objects referenced by a specified Property. Use an equivalent query in GetList() instead.
        /// </summary>
        /// <param name="type">Type of Object</param>
        /// <param name="ID">Object id</param>
        /// <param name="property">Property</param>
        /// <returns>the referenced objects</returns>
        [Obsolete]
        public byte[] GetListOf(SerializableType type, int ID, string property)
        {
            using (Logging.Facade.DebugTraceMethodCallFormat("GetListOf", "type={0}", type))
            {
                DebugLogIdentity();
                try
                {
                    if (type == null) { throw new ArgumentNullException("type"); }


                    using (IKistlContext ctx = _ctxFactory())
                    {
                        var ifType = _iftFactory(type.GetSystemType());
                        int resultCount = 0;
                        var ticks = _perfCounter.IncrementGetListOf(ifType);
                        try
                        {
                            IEnumerable<IStreamable> lst = _sohFactory
                                .GetServerObjectHandler(ifType)
                                .GetListOf(ctx, ID, property);
                            resultCount = lst.Count();
                            return SendObjects(lst, false /*true*/).ToArray();
                        }
                        finally
                        {
                            _perfCounter.DecrementGetListOf(ifType, resultCount, ticks);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Helper.ThrowFaultException(ex);
                    // Never called, Handle errors throws an Exception
                    return null;
                }
            }
        }

        /// <summary>
        /// Fetches a list of CollectionEntry objects of the Relation 
        /// <paramref name="relId"/> which are owned by the object with the 
        /// ID <paramref name="parentObjID"/> in the role <paramref name="serializableRole"/>.
        /// </summary>
        /// <param name="relId">the requested Relation</param>
        /// <param name="serializableRole">the parent role (1 == A, 2 == B)</param>
        /// <param name="parentObjID">the ID of the parent object</param>
        /// <returns>the requested collection entries</returns>
        public byte[] FetchRelation(Guid relId, int serializableRole, int parentObjID)
        {
            using (Logging.Facade.DebugTraceMethodCallFormat("FetchRelation", "relId = [{0}], role = [{1}], parentObjID = [{2}]", relId, serializableRole, parentObjID))
            {
                try
                {
                    DebugLogIdentity();

                    using (IKistlContext ctx = _ctxFactory())
                    {
                        var endRole = (RelationEndRole)serializableRole;
                        // TODO: Use FrozenContext
                        Relation rel = ctx.FindPersistenceObject<Relation>(relId);
                        var ifTypeA = _iftFactory(rel.A.Type.GetDataType());
                        var ifTypeB = _iftFactory(rel.B.Type.GetDataType());
                        var ifType = endRole == RelationEndRole.A ? ifTypeA : ifTypeB;
                        int resultCount = 0;
                        var ticks = _perfCounter.IncrementFetchRelation(ifType);
                        try
                        {
                            var lst = _sohFactory
                                .GetServerCollectionHandler(
                                    ctx,
                                    ifTypeA,
                                    ifTypeB,
                                    endRole)
                                .GetCollectionEntries(ctx, relId, endRole, parentObjID);
                            resultCount = lst.Count();
                            return SendObjects(lst.Cast<IStreamable>(), true).ToArray();
                        }
                        finally
                        {
                            _perfCounter.DecrementFetchRelation(ifType, resultCount, ticks);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Helper.ThrowFaultException(ex);
                    // Never called, Handle errors throws an Exception
                    return null;
                }
            }
        }

        /// <summary>
        /// Gets the content stream of the given Document instance ID
        /// </summary>
        /// <param name="ID">ID of an valid Document instance</param>
        /// <returns>Stream containing the Document content</returns>
        public Stream GetBlobStream(int ID)
        {
            using (Logging.Facade.DebugTraceMethodCallFormat("GetBlobStream", "ID={0}", ID))
            {
                try
                {

                    DebugLogIdentity();

                    using (IKistlContext ctx = _ctxFactory())
                    {
                        return _sohFactory
                            .GetServerDocumentHandler()
                            .GetBlobStream(ctx, ID);
                    }
                }
                catch (Exception ex)
                {
                    Helper.ThrowFaultException(ex);
                    // Never called, Handle errors throws an Exception
                    return null;
                }
            }
        }

        /// <summary>
        /// Sets the content stream of the given Document instance ID
        /// </summary>
        /// <param name="blob">Information about the given blob</param>
        /// <returns>the newly created Blob instance</returns>
        public BlobResponse SetBlobStream(BlobMessage blob)
        {
            using (Logging.Facade.DebugTraceMethodCall("SetBlobStream"))
            {
                if (blob == null)
                    throw new ArgumentNullException("blob");
                try
                {

                    DebugLogIdentity();

                    using (IKistlContext ctx = _ctxFactory())
                    {
                        var result = _sohFactory
                            .GetServerDocumentHandler()
                            .SetBlobStream(ctx, blob.Stream, blob.FileName, blob.MimeType);
                        BlobResponse resp = new BlobResponse();
                        resp.ID = result.ID;
                        resp.BlobInstance = SendObjects(new IDataObject[] { result }, true);
                        return resp;
                    }
                }
                catch (Exception ex)
                {
                    Helper.ThrowFaultException(ex);
                    // Never called, Handle errors throws an Exception
                    return null;
                }
            }
        }

        public byte[] InvokeServerMethod(SerializableType type, int ID, string method, SerializableType[] parameterTypes, byte[] parameterArray, byte[] changedObjectsArray, ObjectNotificationRequest[] notificationRequests, out byte[] retChangedObjects)
        {
            using (Logging.Facade.DebugTraceMethodCallFormat("InvokeServerMethod", "method={0}, ID={1}", method, ID))
            {
                if (type == null)
                    throw new ArgumentNullException("type");
                if (string.IsNullOrEmpty(method))
                    throw new ArgumentNullException("method");
                if (parameterTypes == null)
                    throw new ArgumentNullException("parameterTypes");
                if (parameterArray == null)
                    throw new ArgumentNullException("parameterArray");
                if (changedObjectsArray == null)
                    throw new ArgumentNullException("changedObjectsArray");

                _perfCounter.IncrementServerMethodInvocation();
                retChangedObjects = null;

                try
                {

                    DebugLogIdentity();

                    using (IKistlContext ctx = _ctxFactory())
                    {
                        var parameter = new MemoryStream(parameterArray);
                        parameter.Seek(0, SeekOrigin.Begin);
                        List<object> parameterList = new List<object>(); 
                        var parameterReader = new BinaryReader(parameter);
                        foreach (var t in parameterTypes)
                        { 
                            object val;
                            BinarySerializer.FromStream(out val, 
                                ctx.ToImplementationType(ctx.GetInterfaceType(t.GetSystemType())).Type, 
                                parameterReader);
                            parameterList.Add(val);
                        }

                        var changedObjects = new MemoryStream(changedObjectsArray);
                        changedObjects.Seek(0, SeekOrigin.Begin);

                        IEnumerable<IPersistenceObject> changedObjectsList;
                        var result = _sohFactory
                            .GetServerObjectHandler(_iftFactory(type.GetSystemType()))
                            .InvokeServerMethod(ctx, ID, method,
                                parameterTypes.Select(t => t.GetSystemType()),
                                parameterList,
                                ReadObjects(changedObjects, ctx),
                                notificationRequests ?? new ObjectNotificationRequest[0],
                                out changedObjectsList);

                        retChangedObjects = SendObjects(changedObjectsList.Cast<IStreamable>(), true).ToArray();

                        if (result != null && result.GetType() == typeof(string))
                        {
                            // string is also a IEnumerable, but FindElementTypes returns nothing
                            MemoryStream resultStream = new MemoryStream();
                            new BinaryFormatter().Serialize(resultStream, result);
                            return resultStream.ToArray();
                        }
                        else if (result != null && result.GetType().IsIStreamable())
                        {
                            IStreamable resultObj = (IStreamable)result;
                            return SendObjects(new IStreamable[] { resultObj }, false).ToArray();
                        }
                        else if (result != null && result.GetType().IsIEnumerable() && result.GetType().FindElementTypes().First().IsIStreamable())
                        {
                            var lst = ((IEnumerable)result).AsQueryable().Cast<IStreamable>().Take(Kistl.API.Helper.MAXLISTCOUNT);
                            return SendObjects(lst, false).ToArray();
                        }
                        else if (result != null)
                        {
                            MemoryStream resultStream = new MemoryStream();
                            new BinaryFormatter().Serialize(resultStream, result);
                            return resultStream.ToArray();
                        }
                        else
                        {
                            return new byte[] { };
                        }
                    }
                }
                catch (Exception ex)
                {
                    Helper.ThrowFaultException(ex);
                    // Never called, Handle errors throws an Exception
                    return null;
                }
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            Logging.Facade.Info("Disposing KistlService instance");
        }

        #endregion
    }
}