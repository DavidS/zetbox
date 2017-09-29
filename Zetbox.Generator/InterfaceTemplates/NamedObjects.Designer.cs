using System;
using System.Collections.Generic;
using System.Linq;
using Zetbox.API;


namespace Zetbox.Generator.InterfaceTemplates
{
    [Arebis.CodeGeneration.TemplateInfo(@"C:\Projects\zetbox\Zetbox.Generator\InterfaceTemplates\NamedObjects.cst")]
    public partial class NamedObjects : Zetbox.Generator.ResourceTemplate
    {
		protected IZetboxContext ctx;


        public static void Call(Arebis.CodeGeneration.IGenerationHost _host, IZetboxContext ctx)
        {
            if (_host == null) { throw new global::System.ArgumentNullException("_host"); }

            _host.CallTemplate("NamedObjects", ctx);
        }

        public NamedObjects(Arebis.CodeGeneration.IGenerationHost _host, IZetboxContext ctx)
            : base(_host)
        {
			this.ctx = ctx;

        }

        public override void Generate()
        {
#line 26 "C:\Projects\zetbox\Zetbox.Generator\InterfaceTemplates\NamedObjects.cst"
this.WriteObjects("// <autogenerated/>\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("namespace Zetbox {\r\n");
this.WriteObjects("    using System;\r\n");
this.WriteObjects("    using Zetbox.API.Utils;\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("    public static class NamedObjects\r\n");
this.WriteObjects("    {\r\n");
#line 34 "C:\Projects\zetbox\Zetbox.Generator\InterfaceTemplates\NamedObjects.cst"
RenderNamedObjects(); 
#line 35 "C:\Projects\zetbox\Zetbox.Generator\InterfaceTemplates\NamedObjects.cst"
this.WriteObjects("    }\r\n");
this.WriteObjects("}\r\n");

        }

    }
}