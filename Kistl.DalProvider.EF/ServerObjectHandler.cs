
namespace Kistl.DalProvider.EF
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Metadata.Edm;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    using Kistl.API;
    using Kistl.API.Server;
    using Kistl.App.Base;
    using Kistl.App.Extensions;

    public class ServerObjectHandler<T>
        : BaseServerObjectHandler<T>
        where T : class, IDataObject
    {
        /// <summary>
        /// Gibt eine typisierte Objektinstanz zurück.
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        protected override T GetObjectInstance(IKistlContext ctx, int ID)
        {
            if (ID < Kistl.API.Helper.INVALIDID)
            {
                // new object -> look in current context
                ObjectContext efCtx = ((KistlDataContext)ctx).ObjectContext;
                return (T)efCtx.ObjectStateManager.GetObjectStateEntries(System.Data.EntityState.Added)
                    .FirstOrDefault(e => e.Entity is IDataObject && ((IDataObject)e.Entity).ID == ID).Entity;
            }
            else
            {
                return ctx.GetQuery<T>().FirstOrDefault<T>(a => a.ID == ID);
            }
        }
    }

    public class ServerObjectSetHandler
        : BaseServerObjectSetHandler
    {
        /// <inheritdoc/>
        public override IEnumerable<IPersistenceObject> SetObjects(IKistlContext ctx, IEnumerable<IPersistenceObject> objects, IEnumerable<ObjectNotificationRequest> notificationRequests)
        {
            return base.SetObjects(ctx, objects, notificationRequests);
        }
    }

    public class ServerCollectionHandler<TA, TB, TParent, TChild>
        : IServerCollectionHandler
        where TA : BaseServerDataObject_EntityFramework
        where TB : BaseServerDataObject_EntityFramework
        where TParent : BaseServerDataObject_EntityFramework
        where TChild : BaseServerDataObject_EntityFramework
    {

        public IEnumerable<IRelationCollectionEntry> GetCollectionEntries(
            IKistlContext ctx,
            Guid relId, RelationEndRole endRole,
            int parentId)
        {
            if (ctx == null) { throw new ArgumentNullException("ctx"); }

            var rel = ctx.FindPersistenceObject<Relation>(relId);
            var relEnd = rel.GetEndFromRole(endRole);
            var relOtherEnd = rel.GetOtherEnd(relEnd);
            var parent = ctx.Find(ctx.GetImplementationType(typeof(TParent)).ToInterfaceType(), parentId);
            var ceType = ctx.ToImplementationType(rel.GetEntryInterfaceType()).Type;

            var method = this.GetType().GetMethod("GetCollectionEntriesInternal", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            return (IEnumerable<IRelationCollectionEntry>)method
                .MakeGenericMethod(ceType)
                .Invoke(this, new object[] { parent, rel, endRole });
        }

        // Helper method which is only called by reflection from GetCollectionEntries
        private IEnumerable<IRelationCollectionEntry> GetCollectionEntriesInternal<IMPL>(TParent parent, Relation rel, RelationEndRole endRole)
            where IMPL : class, IEntityWithRelationships
        {
            var c = ((IEntityWithRelationships)(parent)).RelationshipManager
                    .GetRelatedCollection<IMPL>(
                        "Model." + rel.GetRelationAssociationName(endRole),
                        "CollectionEntry");
            if (parent.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                && !c.IsLoaded)
            {
                c.Load();
            }
            c.Cast<IRelationCollectionEntry>().ForEach(i=> i.AttachToContext(parent.Context));
            return c.Cast<IRelationCollectionEntry>();
        }
    }
}
