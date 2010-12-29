using System;
using System.Collections.Generic;
using System.Linq;
using Kistl.API;


namespace Kistl.Generator.InterfaceTemplates
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Generator\InterfaceTemplates\Module.cst")]
    public partial class Module : Kistl.Generator.ResourceTemplate
    {
		protected IKistlContext ctx;
		protected string shortName;


        public static void Call(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, string shortName)
        {
            if (_host == null) { throw new global::System.ArgumentNullException("_host"); }

            _host.CallTemplate("Module", ctx, shortName);
        }

        public Module(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, string shortName)
            : base(_host)
        {
			this.ctx = ctx;
			this.shortName = shortName;

        }

        public override void Generate()
        {
#line 11 "P:\Kistl\Kistl.Generator\InterfaceTemplates\Module.cst"
this.WriteObjects("// <autogenerated/>\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("namespace Kistl.Objects\r\n");
this.WriteObjects("{\r\n");
this.WriteObjects("    using System;\r\n");
this.WriteObjects("    using System.Collections.Generic;\r\n");
this.WriteObjects("    using System.Linq;\r\n");
this.WriteObjects("    using System.Text;\r\n");
this.WriteObjects("    using Autofac;\r\n");
this.WriteObjects("    using Kistl.API;\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("    public sealed class InterfaceModule\r\n");
this.WriteObjects("        : Autofac.Module\r\n");
this.WriteObjects("    {\r\n");
this.WriteObjects("        protected override void Load(ContainerBuilder builder)\r\n");
this.WriteObjects("        {\r\n");
this.WriteObjects("            base.Load(builder);\r\n");
this.WriteObjects("            builder\r\n");
this.WriteObjects("                .Register<InterfaceTypeChecker>(c => new InterfaceTypeChecker(c.Resolve<Func<IEnumerable<IImplementationTypeChecker>>>()))\r\n");
this.WriteObjects("                .As<IInterfaceTypeChecker>()\r\n");
this.WriteObjects("                .SingleInstance();\r\n");
this.WriteObjects("        }\r\n");
this.WriteObjects("    }\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("    internal sealed class InterfaceTypeChecker \r\n");
this.WriteObjects("        : BaseInterfaceTypeChecker, IInterfaceTypeChecker\r\n");
this.WriteObjects("    {\r\n");
this.WriteObjects("        internal InterfaceTypeChecker(Func<IEnumerable<IImplementationTypeChecker>> implTypeCheckersFactory)\r\n");
this.WriteObjects("            : base(implTypeCheckersFactory)\r\n");
this.WriteObjects("        {\r\n");
this.WriteObjects("        }\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("        protected override System.Reflection.Assembly GetAssembly()\r\n");
this.WriteObjects("        {\r\n");
this.WriteObjects("            return typeof(InterfaceTypeChecker).Assembly;\r\n");
this.WriteObjects("        }\r\n");
this.WriteObjects("    }\r\n");
this.WriteObjects("}\r\n");
this.WriteObjects("\r\n");

        }

    }
}