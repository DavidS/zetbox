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

namespace Zetbox.DalProvider.Ef
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

    using Zetbox.API;
    using Zetbox.API.Server;
    using Zetbox.App.Base;
    using Zetbox.App.Extensions;

    public class ServerObjectSetHandler
        : BaseServerObjectSetHandler
    {
        /// <inheritdoc/>
        public override IEnumerable<IPersistenceObject> SetObjects(Guid version, IZetboxContext ctx, IEnumerable<IPersistenceObject> objects, IEnumerable<ObjectNotificationRequest> notificationRequests)
        {
            return base.SetObjects(version, ctx, objects, notificationRequests);
        }
    }

    public class ServerCollectionHandler<TA, TB, TParent, TChild>
        : IServerCollectionHandler
        where TA : BaseServerDataObject_EntityFramework
        where TB : BaseServerDataObject_EntityFramework
        where TParent : BaseServerDataObject_EntityFramework
        where TChild : BaseServerDataObject_EntityFramework
    {

        public IEnumerable<IRelationEntry> GetCollectionEntries(
            Guid version,
            IReadOnlyZetboxContext ctx,
            Guid relId, RelationEndRole endRole,
            int parentId)
        {
            if (ctx == null) { throw new ArgumentNullException("ctx"); }
            ZetboxGeneratedVersionAttribute.Check(version);

            var rel = ctx.FindPersistenceObject<Relation>(relId);
            var relEnd = rel.GetEndFromRole(endRole);
            var relOtherEnd = rel.GetOtherEnd(relEnd);
            var parent = ctx.Find(ctx.GetImplementationType(typeof(TParent)).ToInterfaceType(), parentId);
            var ceType = ctx.ToImplementationType(rel.GetEntryInterfaceType()).Type;

            var method = this.GetType().GetMethod("GetCollectionEntriesInternal", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            return (IEnumerable<IRelationEntry>)method
                .MakeGenericMethod(ceType)
                .Invoke(this, new object[] { parent, rel, endRole });
        }

        // Helper method which is only called by reflection from GetCollectionEntries
        private IEnumerable<IRelationEntry> GetCollectionEntriesInternal<IMPL>(TParent parent, Relation rel, RelationEndRole endRole)
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
            return c.Cast<IRelationEntry>();
        }
    }
}
