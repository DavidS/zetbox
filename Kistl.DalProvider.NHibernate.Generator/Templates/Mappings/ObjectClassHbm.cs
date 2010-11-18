
namespace Kistl.DalProvider.NHibernate.Generator.Templates.Mappings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Arebis.CodeGeneration;
    using Kistl.API;
    using Kistl.App.Base;

    public partial class ObjectClassHbm
    {
        public static string GetAssemblyQualifiedImplementation(ObjectClass cls, string extraSuffix)
        {
            if (cls == null) { throw new ArgumentNullException("cls"); }
            if (extraSuffix == null) { extraSuffix = String.Empty; }

            return cls.Module.Namespace + "."
                + cls.Name + extraSuffix + Kistl.API.Helper.ImplementationSuffix
                + ", Kistl.Objects." + extraSuffix + Kistl.API.Helper.ImplementationSuffix;
        }

        public static object[] MakeArgs(IKistlContext ctx, ObjectClass cls, string extraSuffix)
        {
            if (ctx == null) { throw new ArgumentNullException("ctx"); }
            if (cls == null) { throw new ArgumentNullException("cls"); }
            if (extraSuffix == null) { throw new ArgumentNullException("extraSuffix"); }

            string interfaceName = cls.Name;
            string implementationName = cls.Name + extraSuffix + Kistl.API.Helper.ImplementationSuffix;
            string tableName = cls.TableName;

            string qualifiedInterfaceName = cls.Module.Namespace + "." + interfaceName + ", Kistl.Objects";
            string qualifiedImplementationName = GetAssemblyQualifiedImplementation(cls, extraSuffix);

            bool isAbstract = cls.IsAbstract;

            List<Property> properties = cls.Properties.ToList();
            List<ObjectClass> subClasses = cls.SubClasses.ToList();

            return new object[] { interfaceName, implementationName, tableName, qualifiedInterfaceName, qualifiedImplementationName, isAbstract, properties, subClasses };
        }

        protected virtual void ApplyPropertyDefinitions(List<Property> properties)
        {
            PropertiesHbm.Call(Host, ctx, String.Empty, properties);
        }

        protected virtual void ApplyJoinedSubclasses(List<ObjectClass> subClasses)
        {
            foreach (var subClass in subClasses)
            {
                JoinedSubclassHbm.Call(Host, ctx, subClass);
            }
        }
    }
}
