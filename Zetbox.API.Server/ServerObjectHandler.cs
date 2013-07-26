// This file is part of zetbox.
//
// Zetbox is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation, either version 3 of
// the License, or (at your option) any later version.
//
// Zetbox is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with zetbox.  If not, see <http://www.gnu.org/licenses/>.

namespace Zetbox.API.Server
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Linq.Expressions;
    using Lucene.Net.QueryParsers;
    using Lucene.Net.Search;
    using Zetbox.API;
    using Zetbox.API.Server.Fulltext;
    using Zetbox.API.Utils;
    using Zetbox.App.Extensions;

    /// <summary>
    /// This describes the common interface from the server frontend to the provider for servicing the common "Get" operations.
    /// The actual implementation will be instantiated per-request and be passed the required type.
    /// </summary>
    public interface IServerObjectHandler
    {
        /// <summary>
        /// Return a list of objects matching the specified query.
        /// </summary>
        /// <param name="version">Current version of generated Zetbox.Objects assembly</param>
        /// <param name="ctx">The context to query.</param>
        /// <param name="query">a Linq query to execute</param>
        /// <returns>the filtered and ordered list of objects</returns>
        IEnumerable<IStreamable> GetObjects(Guid version, IReadOnlyZetboxContext ctx, Expression query);

        /// <summary>
        /// Return the list of objects referenced by the specified property.
        /// </summary>
        /// <param name="version">Current version of generated Zetbox.Objects assembly</param>
        /// <param name="ctx">the server context to use for loading the objects</param>
        /// <param name="ID">the ID of the referencing object</param>
        /// <param name="property">the name of the referencing property</param>
        /// <returns>the list of objects</returns>
        IEnumerable<IStreamable> GetListOf(Guid version, IReadOnlyZetboxContext ctx, int ID, string property);

        object InvokeServerMethod(Guid version, IZetboxContext ctx, int ID, string method, IEnumerable<Type> parameterTypes, IEnumerable<object> parameter, IEnumerable<IPersistenceObject> objects, IEnumerable<ObjectNotificationRequest> notificationRequests, out IEnumerable<IPersistenceObject> changedObjects);
    }

    public interface IServerObjectSetHandler
    {
        /// <summary>
        /// Implementiert den SetObject Befehl.
        /// </summary>
        IEnumerable<IPersistenceObject> SetObjects(Guid version, IZetboxContext ctx, IEnumerable<IPersistenceObject> objects, IEnumerable<ObjectNotificationRequest> notificationRequests);
    }

    public interface IServerCollectionHandler
    {
        IEnumerable<IRelationEntry> GetCollectionEntries(Guid version, IReadOnlyZetboxContext ctx, Guid relId, RelationEndRole endRole, int parentId);
    }

    public interface IServerDocumentHandler
    {
        Stream GetBlobStream(Guid version, IReadOnlyZetboxContext ctx, int ID);
        Zetbox.App.Base.Blob SetBlobStream(Guid version, IZetboxContext ctx, Stream blob, string filename, string mimetype);
    }

    internal sealed class FulltextDetector : ExpressionTreeVisitor
    {
        public FulltextDetector()
        {
            IsFulltext = false;
        }

        public bool IsFulltext { get; private set; }

        public string Filter { get; private set; }

        protected override void VisitMethodCall(MethodCallExpression m)
        {
            base.VisitMethodCall(m);

            if (m.IsMethodCallExpression("FulltextMatch", typeof(ZetboxContextQueryableExtensions)))
            {
                if (IsFulltext) throw new InvalidOperationException("Found two fulltext specs in a single query");

                IsFulltext = true;
                Filter = (string)(m.Arguments[1] as ConstantExpression).Value;
            }
        }
    }

    /// <summary>
    /// Basic server "business" logic. This handles mapping from the service to the actual provider.
    /// </summary>
    /// <remarks>
    /// More specific actions can be implemented by attaching actions to objects and contexts.
    /// </remarks>
    public sealed class ServerObjectHandler<T>
        : IServerObjectHandler
        where T : class, IDataObject
    {
        private readonly LuceneSearchDeps _searchDependencies;

        /// <summary>
        /// Events registrieren
        /// </summary>
        public ServerObjectHandler(LuceneSearchDeps searchDependencies = null)
        {
            _searchDependencies = searchDependencies;
        }

        public IEnumerable<IStreamable> GetObjects(Guid version, IReadOnlyZetboxContext ctx, Expression query)
        {
            if (ctx == null) { throw new ArgumentNullException("ctx"); }
            if (query == null) { throw new ArgumentNullException("query"); }
            ZetboxGeneratedVersionAttribute.Check(version);

            var isExecute = query.IsMethodCallExpression("First") || query.IsMethodCallExpression("FirstOrDefault") || query.IsMethodCallExpression("Single") || query.IsMethodCallExpression("SingleOrDefault");

            var ftDetector = new FulltextDetector();
            ftDetector.Visit(query);

            if (ftDetector.IsFulltext)
            {
                return FulltextSearch(ctx, ftDetector.Filter);
            }
            else if (isExecute)
            {
                return Execute(ctx, query);
            }
            else
            {
                return Query(ctx, query);
            }
        }

        private static IEnumerable<IStreamable> Query(IReadOnlyZetboxContext ctx, Expression query)
        {
            if (!query.IsMethodCallExpression("Take"))
            {
                return ctx.GetQuery<T>().Provider.CreateQuery<T>(query).Take(Helper.MAXLISTCOUNT).ToList().Cast<IStreamable>();
            }
            else
            {
                var takeQ = query as MethodCallExpression;
                var countExp = takeQ.Arguments[1] as ConstantExpression;
                if ((int)countExp.Value > Helper.MAXLISTCOUNT)
                {
                    return ctx.GetQuery<T>().Provider.CreateQuery<T>(query).Take(Helper.MAXLISTCOUNT).ToList().Cast<IStreamable>();
                }
                else
                {
                    return ctx.GetQuery<T>().Provider.CreateQuery<T>(query).ToList().Cast<IStreamable>();
                }
            }
        }

        private static IEnumerable<IStreamable> Execute(IReadOnlyZetboxContext ctx, Expression query)
        {
            var result = (IStreamable)ctx.GetQuery<T>().Provider.Execute<T>(query);
            if (result == null)
            {
                return Enumerable.Empty<IStreamable>();
            }
            else
            {
                return new IStreamable[] { result };
            }
        }

        private IEnumerable<IStreamable> FulltextSearch(IReadOnlyZetboxContext ctx, string query)
        {
            if (_searchDependencies == null) throw new InvalidOperationException("No Fulltext Support registered");

            var qry = _searchDependencies.Parser.Parse(query);

            var searcher = _searchDependencies.SearcherManager.Aquire();
            try
            {
                var hits = searcher.Search(qry, Helper.MAXLISTCOUNT);
                var anyRefs = hits.ScoreDocs.Select(doc => searcher.Doc(doc.Doc)).ToLookup(doc => doc.Get(Fulltext.Module.FIELD_CLASS), doc => doc.Get(Fulltext.Module.FIELD_ID));

                var result = new List<IStreamable>();

                // TODO: do batching here
                foreach (var ids in anyRefs)
                {
                    var ifType = ctx.GetInterfaceType(ids.Key);
                    foreach (var idStr in ids)
                    {
                        try
                        {
                            int id;
                            if (int.TryParse(idStr, out id))
                            {
                                var obj = ctx.Find(ifType, id);
                                result.Add(obj);
                            }
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            // TODO: mark stale lucene doc for deletion
                            continue;
                        }
                    }
                }
                return result;
            }
            finally
            {
                _searchDependencies.SearcherManager.Release(searcher);
            }
        }

        /// <summary>
        /// Since IsList properties are not automatically transferred,
        /// GetListOf can be used to get the list of values in the property 
        /// <code>property</code> of the object with the <code>ID</code>
        /// </summary>
        /// <returns>the list of values in the property</returns>
        public IEnumerable<IStreamable> GetListOf(Guid version, IReadOnlyZetboxContext ctx, int ID, string property)
        {
            if (ctx == null) throw new ArgumentNullException("ctx");
            if (ID <= API.Helper.INVALIDID) throw new ArgumentException("ID must not be invalid");
            ZetboxGeneratedVersionAttribute.Check(version);

            T obj = ctx.Find<T>(ID);
            if (obj == null) throw new ArgumentOutOfRangeException("ID", "Object not found");

            IEnumerable list = (IEnumerable)obj.GetPropertyValue<IEnumerable>(property);
            return list.Cast<IStreamable>();
        }

        public object InvokeServerMethod(Guid version, IZetboxContext ctx, int ID, string method, IEnumerable<Type> parameterTypes, IEnumerable<object> parameter, IEnumerable<IPersistenceObject> objects, IEnumerable<ObjectNotificationRequest> notificationRequests, out IEnumerable<IPersistenceObject> changedObjects)
        {
            if (ctx == null) { throw new ArgumentNullException("ctx"); }
            if (objects == null) { throw new ArgumentNullException("objects"); }
            if (notificationRequests == null) { throw new ArgumentNullException("notificationRequests"); }
            ZetboxGeneratedVersionAttribute.Check(version);

            var objList = objects.Cast<BaseServerPersistenceObject>().ToList();
            var entityObjects = new Dictionary<IPersistenceObject, IPersistenceObject>();

            BaseServerObjectSetHandler.ApplyObjectChanges(ctx, notificationRequests, objList, entityObjects);

            // Call Method
            var obj = ctx.Find<T>(ID);
            var mi = obj.GetType().FindMethod(method, parameterTypes.ToArray());
            if (mi == null)
            {
                throw new InvalidOperationException(string.Format("Method {0}.{1}({2}) not found", typeof(T).FullName, method, string.Join(", ", parameterTypes.Select(i => i.Name).ToArray())));
            }
            object result = mi.Invoke(obj, parameter.ToArray());

            var requestedObjects = BaseServerObjectSetHandler.GetRequestedObjects(ctx, notificationRequests, entityObjects);
            changedObjects = entityObjects.Values.Concat(requestedObjects);

            return result;
        }
    }

    public class BaseServerObjectSetHandler
        : IServerObjectSetHandler
    {
        /// <summary>
        /// Implements the SetObject command
        /// </summary>
        public virtual IEnumerable<IPersistenceObject> SetObjects(
            Guid version,
            IZetboxContext ctx,
            IEnumerable<IPersistenceObject> objList,
            IEnumerable<ObjectNotificationRequest> notificationRequests)
        {
            if (ctx == null) { throw new ArgumentNullException("ctx"); }
            if (objList == null) { throw new ArgumentNullException("objList"); }
            if (notificationRequests == null) { throw new ArgumentNullException("notificationRequests"); }
            ZetboxGeneratedVersionAttribute.Check(version);

            var objects = objList.Cast<BaseServerPersistenceObject>().ToList();
            var entityObjects = new Dictionary<IPersistenceObject, IPersistenceObject>();

            ApplyObjectChanges(ctx, notificationRequests, objects, entityObjects);

            ctx.SubmitChanges();

            var requestedObjects = GetRequestedObjects(ctx, notificationRequests, entityObjects);
            return entityObjects.Values.Concat(requestedObjects);
        }

        internal static IEnumerable<IPersistenceObject> GetRequestedObjects(IZetboxContext ctx, IEnumerable<ObjectNotificationRequest> notificationRequests, Dictionary<IPersistenceObject, IPersistenceObject> entityObjects)
        {
            // Send all objects that were modified + those the client wants to be notified about, but each only once
            var requestLookup = notificationRequests.ToLookup(r => r.Type.TypeName, r => r.IDs.ToLookup(i => i));
            var requestedObjects = ctx.AttachedObjects
                .Where(obj =>
                {
                    if (entityObjects.ContainsKey(obj)) return false; // only once
                    if (obj.ObjectState.In(DataObjectState.Modified, DataObjectState.New)) return true; // Changed or new

                    var ids = requestLookup[ctx.GetInterfaceType(obj).Type.FullName].FirstOrDefault();
                    if (ids != null)
                    {
                        return ids.Contains(obj.ID); // Client request
                    }
                    else
                    {
                        return false;
                    }
                });
            return requestedObjects;
        }

        internal static void ApplyObjectChanges(IZetboxContext ctx, IEnumerable<ObjectNotificationRequest> notificationRequests, List<BaseServerPersistenceObject> objects, Dictionary<IPersistenceObject, IPersistenceObject> entityObjects)
        {
            Logging.Log.InfoFormat(
                "ApplyObjectChanges for {0} objects and {1} notification requests called.",
                objects.Count(),
                notificationRequests.Sum(req => req.IDs.Length));

            // First of all, attach new Objects
            foreach (var obj in objects.Where(o => o.ClientObjectState == DataObjectState.New))
            {
                ctx.Internals().AttachAsNew(obj);
                entityObjects[obj] = obj;
            }

            var concurrencyFailed = new List<ConcurrencyExceptionDetail>();
            // then apply changes
            foreach (var obj in objects.Where(o => o.ClientObjectState == DataObjectState.Modified))
            {
                var ctxObj = ctx.FindPersistenceObject(ctx.GetInterfaceType(obj), obj.ID);
                ((BasePersistenceObject)ctxObj).RecordNotifications();
                // optimistic concurrency
                if (obj is Zetbox.App.Base.IChangedBy)
                {
                    var orig = (Zetbox.App.Base.IChangedBy)ctxObj;
                    var send = (Zetbox.App.Base.IChangedBy)obj;
                    if (Math.Abs((orig.ChangedOn - send.ChangedOn).Ticks) > 15) // postgres is only accurate down to µs (1/1000th ms), but DateTime is accurate down to 1/10th µs. Rounding errors cause invalid concurrency failures.
                    {
                        concurrencyFailed.Add(new ConcurrencyExceptionDetail(
                            Guid.Empty, // TODO: There is no frozen context here. Refactor *HanderFatories to autofac modules!
                            obj.ID,
                            send.ToString(),
                            orig.ChangedOn,
                            orig.ChangedBy != null ? orig.ChangedBy.ToString() : string.Empty));
                    }
                }
                ctxObj.ApplyChangesFrom(obj);
                entityObjects[ctxObj] = ctxObj;
            }

            if (concurrencyFailed.Count > 0)
            {
                throw new ConcurrencyException(concurrencyFailed);
            }

            // then update references
            foreach (var obj in objects.Where(o => o.ClientObjectState != DataObjectState.Deleted))
            {
                var ctxObj = ctx.FindPersistenceObject(ctx.GetInterfaceType(obj), obj.ID);
                ((BasePersistenceObject)ctxObj).RecordNotifications();
                ctxObj.ReloadReferences();
                entityObjects[ctxObj] = ctxObj;
            }

            // then delete objects
            foreach (var obj in objects.Where(o => o.ClientObjectState == DataObjectState.Deleted))
            {
                var ctxObj = ctx.FindPersistenceObject(ctx.GetInterfaceType(obj), obj.ID);
                ctx.Delete(ctxObj);
            }

            // Playback notifications
            foreach (var obj in entityObjects.Keys.Cast<BasePersistenceObject>())
            {
                obj.PlaybackNotifications();
            }
        }
    }

    public class ServerDocumentHandler : IServerDocumentHandler
    {
        public Stream GetBlobStream(Guid version, IReadOnlyZetboxContext ctx, int ID)
        {
            if (ctx == null) { throw new ArgumentNullException("ctx"); }
            ZetboxGeneratedVersionAttribute.Check(version);
            return ctx.GetStream(ID);
        }

        public Zetbox.App.Base.Blob SetBlobStream(Guid version, IZetboxContext ctx, Stream blob, string filename, string mimetype)
        {
            if (ctx == null) { throw new ArgumentNullException("ctx"); }
            if (blob == null) { throw new ArgumentNullException("blob"); }
            ZetboxGeneratedVersionAttribute.Check(version);

            var id = ctx.CreateBlob(blob, filename, mimetype);
            var obj = ctx.Find<Zetbox.App.Base.Blob>(id);
            ctx.SubmitChanges();
            return obj;
        }
    }
}
