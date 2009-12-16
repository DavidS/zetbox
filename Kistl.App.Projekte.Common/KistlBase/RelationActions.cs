
namespace Kistl.App.KistlBase.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Kistl.API;
    using Kistl.App.Base;
    using Kistl.App.Extensions;
    using Kistl.API.Utils;

    public class RelationActions
    {
        private static int instance_counter = 0;
        /// <summary>
        /// TODO: Remove after measurement
        /// </summary>
        public RelationActions()
        {
            instance_counter++;
            Logging.Log.DebugFormat("{0}: {1} instances", this.GetType(), instance_counter);
        }

        public void OnGetOtherEnd(Relation rel, MethodReturnEventArgs<RelationEnd> e, RelationEnd relEnd)
        {
            if (rel.A == relEnd)
                e.Result = rel.B;
            else if (rel.B == relEnd)
                e.Result = rel.A;
            else
                e.Result = null;
        }

        public void OnGetEndFromRole(Relation rel, MethodReturnEventArgs<RelationEnd> e, RelationEndRole role)
        {
            switch (role)
            {
                case RelationEndRole.A:
                    e.Result = rel.A;
                    break;
                case RelationEndRole.B:
                    e.Result = rel.B;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("role");
            }
        }

        public void OnGetEnd(Relation rel, MethodReturnEventArgs<RelationEnd> e, ObjectReferenceProperty prop)
        {
            if (rel.A != null && rel.A.Navigator == prop)
                e.Result = rel.A;
            else if (rel.B != null && rel.B.Navigator == prop)
                e.Result = rel.B;
            else
                e.Result = null;
        }

        public void OnGetRelationType(Relation rel, MethodReturnEventArgs<RelationType> e)
        {
            if (rel == null)
            {
                throw new ArgumentNullException("rel");
            }
            if (rel.A == null)
            {
                throw new ArgumentNullException("rel", "rel.A is null");
            }
            if (rel.B == null)
            {
                throw new ArgumentNullException("rel", "rel.B is null");
            }

            if ((rel.A.Multiplicity.UpperBound() == 1 && rel.B.Multiplicity.UpperBound() > 1)
                || (rel.A.Multiplicity.UpperBound() > 1 && rel.B.Multiplicity.UpperBound() == 1))
            {
                e.Result = RelationType.one_n;
            }
            else if (rel.A.Multiplicity.UpperBound() > 1 && rel.B.Multiplicity.UpperBound() > 1)
            {
                e.Result = RelationType.n_m;
            }
            else if (rel.A.Multiplicity.UpperBound() == 1 && rel.B.Multiplicity.UpperBound() == 1)
            {
                e.Result = RelationType.one_one;
            }
            else
            {
                throw new InvalidOperationException(String.Format("Unable to find out RelationType: {0}:{1}", rel.A.Multiplicity, rel.B.Multiplicity));
            }
        }

        public void OnNeedsPositionStorage(Relation rel, MethodReturnEventArgs<bool> e, RelationEndRole endRole)
        {
            if (rel == null)
            {
                throw new ArgumentNullException("rel");
            }
            if (rel.A == null)
            {
                throw new ArgumentNullException("rel", "rel.A is null");
            }
            if (rel.B == null)
            {
                throw new ArgumentNullException("rel", "rel.B is null");
            }

            e.Result = ((rel.Storage == StorageType.MergeIntoA && RelationEndRole.A == endRole && rel.A.HasPersistentOrder)
                || (rel.Storage == StorageType.MergeIntoB && RelationEndRole.B == endRole && rel.B.HasPersistentOrder)
                || (rel.Storage == StorageType.Replicate
                    && (
                        (rel.A.HasPersistentOrder && RelationEndRole.A == endRole)
                        || (rel.B.HasPersistentOrder && RelationEndRole.B == endRole))
                    )
                || (rel.Storage == StorageType.Separate && (rel.A.HasPersistentOrder || rel.B.HasPersistentOrder))
                );
        }

    }
}
