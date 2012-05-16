
namespace Kistl.DalProvider.Memory.Generator
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using Kistl.API;
    using Kistl.API.Server;
    using Kistl.API.Utils;
    using Kistl.App.Base;
    using Kistl.App.Extensions;
    using Kistl.Generator;

    public class MemoryGenerator
        : AbstractBaseGenerator
    {
        private readonly IServer _server;

        public MemoryGenerator(IEnumerable<ISchemaProvider> schemaProviders, IServer server)
            : base(schemaProviders)
        {
            _server = server;
        }

        // TODO: #1569 Why not using const Suffix?
        public override string ExtraSuffix { get { return "Memory"; } }
        public override string Description { get { return ExtraSuffix; } }
        public override string TargetNameSpace { get { return "Kistl.Objects." + ExtraSuffix; } }
        public override string BaseName { get { return ExtraSuffix; } }
        public override string ProjectGuid { get { return "{01E60FD5-CD96-466A-83B1-8EFC7452B47C}"; } }
        public override int CompileOrder { get { return COMPILE_ORDER_Implementation; } }

        public override IEnumerable<string> RequiredNamespaces
        {
            get
            {
                return new string[] {
                    "Kistl.DalProvider.Base", "Kistl.DalProvider.Memory",
                };
            }
        }

        protected override IEnumerable<string> Generate_Other(IKistlContext ctx)
        {
            var files = base.Generate_Other(ctx);

            // This file is manually included in ProjectFile.cs
            // TODO: only export frozen stuff
            // This is realy bad, frozen objects has nothing to do with objects beeing published
            // Currently both subsets are the same - by chance
            _server.Publish(Path.Combine(CodeBasePath, "FrozenObjects.xml"), new[] { "*" });

            return files;
        }
    }
}
