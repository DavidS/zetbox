using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.App.Base;
using Kistl.API;

namespace Kistl.App.Extensions
{
    public static class PropertyExtensions
    {
        [Obsolete("Storage of a Property is defined by the containing Relation")]
        public static bool HasStorage(this Property bp)
        {
            if (bp is ObjectReferenceProperty)
            {
                return HasStorage((ObjectReferenceProperty)bp);
            }
            else
            {
                return true;
            }
        }

        private static bool HasStorage(this ObjectReferenceProperty p)
        {
            Relation rel = RelationExtensions.Lookup(p.Context, p);
            if (rel == null) return true;

            if (rel.Storage == StorageType.Replicate)
                throw new NotImplementedException();

            RelationType type = rel.GetRelationType();
            return
                (type == RelationType.one_n && p.IsList() == false)
                || (type == RelationType.one_one && rel.Storage == StorageType.Replicate)
                || (type == RelationType.one_one && rel.Storage == StorageType.MergeIntoA && rel.A.Navigator == p)
                || (type == RelationType.one_one && rel.Storage == StorageType.MergeIntoB && rel.B.Navigator == p)
                // TODO: n:m darf nicht an eine Seite gebunden sein
                || (type == RelationType.n_m && rel.A.Navigator == p);
        }

        public static bool IsNullable(this Property p)
        {
            if (p is ObjectReferenceProperty)
            {
                return IsNullable((ObjectReferenceProperty)p);
            }
            else
            {
                return p.Constraints.OfType<NotNullableConstraint>().Count() == 0;
            }
        }

        private static bool IsNullable(this ObjectReferenceProperty p)
        {
            var relEnd = p.RelationEnd;
            var rel = relEnd.GetParent();
            var otherEnd = rel.GetOtherEnd(relEnd);

            return otherEnd.IsNullable();
        }

        public static bool HasLengthConstraint(this StringProperty prop)
        {
            return prop.Constraints.OfType<StringRangeConstraint>().Count() > 0;
        }

        public static StringRangeConstraint GetLengthConstraint(this StringProperty prop)
        {
            return prop.Constraints.OfType<StringRangeConstraint>().FirstOrDefault();
        }

        public static int GetMaxLength(this StringProperty prop)
        {
            StringRangeConstraint constraint = prop.GetLengthConstraint();
            // create unconstrained maxLength if no constrain is specified
            return constraint == null ? 4000 : constraint.MaxLength;
        }

        public static bool IsList(this ObjectReferenceProperty prop)
        {
            RelationEnd relEnd = prop.RelationEnd;
            Relation rel = relEnd.GetParent();
            RelationEnd otherEnd = rel.GetOtherEnd(relEnd);

            return otherEnd.Multiplicity.UpperBound() > 1;
        }

    }
}
