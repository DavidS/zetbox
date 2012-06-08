using System;
using System.Collections.Generic;
using System.Linq;
using Zetbox.API;


namespace Zetbox.DalProvider.NHibernate.Generator.Templates
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\TypeChecker.cst")]
    public partial class TypeChecker : Zetbox.Generator.ResourceTemplate
    {
		protected IZetboxContext ctx;
		protected string shortName;


        public static void Call(Arebis.CodeGeneration.IGenerationHost _host, IZetboxContext ctx, string shortName)
        {
            if (_host == null) { throw new global::System.ArgumentNullException("_host"); }

            _host.CallTemplate("TypeChecker", ctx, shortName);
        }

        public TypeChecker(Arebis.CodeGeneration.IGenerationHost _host, IZetboxContext ctx, string shortName)
            : base(_host)
        {
			this.ctx = ctx;
			this.shortName = shortName;

        }

        public override void Generate()
        {
#line 17 "P:\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\TypeChecker.cst"
this.WriteObjects("");
#line 27 "P:\zetbox\Zetbox.DalProvider.NHibernate.Generator\Templates\TypeChecker.cst"
this.WriteObjects("\n");
this.WriteObjects("    internal sealed class ",  shortName , "ImplementationTypeChecker\n");
this.WriteObjects("        : Zetbox.API.BaseTypeChecker, I",  shortName , "ImplementationTypeChecker\n");
this.WriteObjects("    {\n");
this.WriteObjects("        public ",  shortName , "ImplementationTypeChecker(Func<IEnumerable<IImplementationTypeChecker>> implTypeCheckersFactory)\n");
this.WriteObjects("            : base(implTypeCheckersFactory)\n");
this.WriteObjects("        {\n");
this.WriteObjects("        }\n");
this.WriteObjects("\n");
this.WriteObjects("        public bool IsImplementationType(Type type)\n");
this.WriteObjects("        {\n");
this.WriteObjects("            if (type == null) { throw new ArgumentNullException(\"type\"); }\n");
this.WriteObjects("\n");
this.WriteObjects("			var myAssembly = typeof(",  shortName , "ImplementationTypeChecker).Assembly;\n");
this.WriteObjects("\n");
this.WriteObjects("            // Allow all top-level types from the generated assembly\n");
this.WriteObjects("            if (type.Assembly == myAssembly && type.DeclaringType == null)\n");
this.WriteObjects("                return true;\n");
this.WriteObjects("\n");
this.WriteObjects("            // Allow all generic types which have only implementation types as arguments\n");
this.WriteObjects("            if (type.IsGenericType)\n");
this.WriteObjects("                return type.GetGenericArguments().All(t => IsImplementationType(t));\n");
this.WriteObjects("\n");
this.WriteObjects("            return false;\n");
this.WriteObjects("		}\n");
this.WriteObjects("	}\n");

        }

    }
}