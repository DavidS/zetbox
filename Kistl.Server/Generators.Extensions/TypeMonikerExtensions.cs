using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kistl.App.Base;

namespace Kistl.Server.Generators.Extensions
{
    public static class TypeMonikerExtensions
    {
        public static TypeMoniker GetTypeMoniker(this DataType objClass)
        {
            return new TypeMoniker(objClass.Module.Namespace, objClass.ClassName);
        }

        public static TypeMoniker GetTypeMonikerImplementation(this DataType objClass)
        {
            return new TypeMoniker(objClass.Module.Namespace, objClass.ClassName + Kistl.API.Helper.ImplementationSuffix);
        }
    }
}
