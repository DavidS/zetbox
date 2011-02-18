
namespace Kistl.Generator.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Kistl.API;
    using Kistl.App.Base;
    using Kistl.App.Extensions;

    public static class PropertyChecks
    {
        public static bool IsAssociation(this Property prop)
        {
            if (prop == null) { throw new ArgumentNullException("prop"); }
            return prop.IsObjectReferencePropertyList()
                || prop.IsObjectReferencePropertySingle()
                || prop.IsValueTypePropertyList()
                || prop.IsCompoundObjectPropertyList();
        }

        public static bool IsValueTypePropertySingle(this Property prop)
        {
            return prop is ValueTypeProperty && !((ValueTypeProperty)prop).IsList;
        }

        public static bool IsValueTypePropertyList(this Property prop)
        {
            return prop is ValueTypeProperty && ((ValueTypeProperty)prop).IsList;
        }

        public static bool IsEnumerationPropertySingle(this Property prop)
        {
            return prop is EnumerationProperty && !((ValueTypeProperty)prop).IsList;
        }

        public static bool IsEnumerationPropertyList(this Property prop)
        {
            return prop is EnumerationProperty && ((ValueTypeProperty)prop).IsList;
        }

        public static bool IsObjectReferencePropertySingle(this Property prop)
        {
            return prop is ObjectReferenceProperty && !((ObjectReferenceProperty)prop).IsList();
        }

        public static bool IsObjectReferencePropertyList(this Property prop)
        {
            return prop is ObjectReferenceProperty && ((ObjectReferenceProperty)prop).IsList();
        }

        public static bool IsCompoundObjectPropertySingle(this Property prop)
        {
            return prop is CompoundObjectProperty && !((CompoundObjectProperty)prop).IsList;
        }

        public static bool IsCompoundObjectPropertyList(this Property prop)
        {
            return prop is CompoundObjectProperty && ((CompoundObjectProperty)prop).IsList;
        }

        public static string GetCollectionTypeString(this Property prop)
        {
            if (prop == null) { throw new ArgumentNullException("prop"); }

            if (prop.HasPersistentOrder())
            {
                return string.Format("IList<{0}>", prop.ReferencedTypeAsCSharp());
            }
            else
            {
                return string.Format("ICollection<{0}>", prop.ReferencedTypeAsCSharp());
            }
        }

        public static bool HasPersistentOrder(this Property prop)
        {
            if (prop == null) { throw new ArgumentNullException("prop"); }

            bool result = false;

            if (prop is ObjectReferenceProperty)
            {
                var p = (ObjectReferenceProperty)prop;
                var rel = RelationExtensions.Lookup(p.Context, p);
                var relEnd = rel.GetEnd(p);
                var otherEnd = rel.GetOtherEnd(relEnd);

                if (rel.NeedsPositionStorage(otherEnd.GetRole()))
                {
                    result = true;
                }
            }
            else if (prop is ValueTypeProperty)
            {
                result = ((ValueTypeProperty)prop).HasPersistentOrder;
            }
            else if (prop is CompoundObjectProperty)
            {
                result = ((CompoundObjectProperty)prop).HasPersistentOrder;
            }

            return result;
        }

        public static bool IsList(this ObjectReferenceProperty prop)
        {
            if (prop == null) { throw new ArgumentNullException("prop"); }
            if(prop.RelationEnd == null) throw new InvalidOperationException(string.Format("Error: object reference property {0} on ObjectClass {1} has no relation end", prop.Name, prop.ObjectClass));

            RelationEnd relEnd = prop.RelationEnd;
            Relation rel = relEnd.GetParent();
            RelationEnd otherEnd = rel.GetOtherEnd(relEnd);

            return otherEnd.Multiplicity.UpperBound() > 1;
        }

        // TODO: convert to class method 
        public static string GetCSharpTypeDef(this Property prop)
        {
            if (prop is ValueTypeProperty)
            {
                var vtp = (ValueTypeProperty)prop;
                if (vtp.IsList && vtp.HasPersistentOrder)
                {
                    return String.Format("IList<{0}>", vtp.GetPropertyTypeString());
                }
                else if (vtp.IsList && !vtp.HasPersistentOrder)
                {
                    return String.Format("ICollection<{0}>", vtp.GetPropertyTypeString());
                }
                else if (!vtp.IsList)
                {
                    return String.Format("{0}{1}", vtp.GetPropertyTypeString(), vtp.IsNullable() ? "?" : String.Empty);
                }
                else
                {
                    throw new NotImplementedException(prop.ToString());
                }
            }
            else if (prop is ObjectReferenceProperty)
            {
                var orp = (ObjectReferenceProperty)prop;
                if (orp.IsList())
                {
                    return orp.GetCollectionTypeString();
                }
                else if (!orp.IsList())
                {
                    return String.Format("{0}{1}", orp.GetPropertyTypeString(), orp.IsNullable() ? "?" : String.Empty);
                }
                else
                {
                    throw new NotImplementedException(prop.ToString());
                }
            }
            else
            {
                throw new NotImplementedException(prop.ToString());
            }
        }
    }
}
