using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.App.Base;
using Kistl.App.Extensions;
using Kistl.Server.Generators.Extensions;

namespace Kistl.Server.Generators
{
    /// <summary>
    /// TODO: Rename and move to Kistl.API.Server
    /// When Provider are seperated it will help
    /// </summary>
    internal static class Construct
    {

        #region Association Names

        private static string InheritanceAssociationName(string parentClass, string childClass)
        {
            return "FK_" + childClass + "_" + parentClass + "_ID";
        }

        public static string InheritanceAssociationName(TypeMoniker parentClass, TypeMoniker childClass)
        {
            return InheritanceAssociationName(parentClass.ClassName, childClass.ClassName);
        }

        public static string InheritanceAssociationName(ObjectClass parentClass, ObjectClass childClass)
        {
            return InheritanceAssociationName(parentClass.ClassName, childClass.ClassName);
        }

        #endregion

        #region AssociationParentRoleName

        private static string AssociationParentRoleName(string obj)
        {
            return "A_" + obj;
        }

        public static string AssociationParentRoleName(TypeMoniker obj)
        {
            return AssociationParentRoleName(obj.ClassName);
        }

        #endregion

        #region AssociationChildRoleName

        private static string AssociationChildRoleName(string obj)
        {
            return "B_" + obj;
        }

        public static string AssociationChildRoleName(TypeMoniker obj)
        {
            return AssociationChildRoleName(obj.ClassName);
        }

        #endregion

        #region Column Names

        // internal use only. Implement and use a proper overload in/from this region.
        private static string ForeignKeyColumnName(string colName)
        {
            return "fk_" + colName;
        }

        public static string ForeignKeyColumnName(RelationEnd otherEnd)
        {
            return ForeignKeyColumnName(otherEnd, string.Empty);
        }

        public static string ForeignKeyColumnName(RelationEnd otherEnd, string prefix)
        {
            return ForeignKeyColumnName(NestedColumnName(otherEnd.RoleName, prefix));
        }

        public static string NestedColumnName(string prop, string parentPropName)
        {
            if (String.IsNullOrEmpty(parentPropName))
                return prop;

            return parentPropName + "_" + prop;
        }

        public static string NestedColumnName(Property prop, string parentPropName)
        {
            return NestedColumnName(prop.PropertyName, parentPropName);
        }

        public static string ListPositionColumnName(RelationEnd otherEnd)
        {
            return ListPositionColumnName(otherEnd, string.Empty);
        }

        public static string ListPositionColumnName(RelationEnd otherEnd, string parentPropName)
        {
            return ForeignKeyColumnName(Construct.NestedColumnName(otherEnd.RoleName, parentPropName)) + "_pos";
        }
        #endregion

    }
}
