using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.Server.Movables;
using Kistl.Server.Generators.Extensions;
using System.Data.Metadata.Edm;
using System.Diagnostics;

namespace Kistl.Server.Generators.EntityFramework.Implementation
{
    public class AssemblyInfoTemplate : Kistl.Server.Generators.Templates.Implementation.AssemblyInfoTemplate
    {

        public AssemblyInfoTemplate(Arebis.CodeGeneration.IGenerationHost _host, Kistl.API.IKistlContext ctx)
            : base(_host, ctx)
        {
        }

        public override string GetAssemblyTitle()
        {
            return "Kistl.Server.Objects";
        }

        public override void ApplyAdditionalAssemblyInfo()
        {
            WriteLine("[assembly: System.Data.Objects.DataClasses.EdmSchema]");
        }

    }
}


