

namespace Zetbox.Generator.Templates
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Zetbox\Zetbox.Generator\Templates\AssemblyInfoTemplate.cst")]
    public partial class AssemblyInfoTemplate : Zetbox.Generator.ResourceTemplate
    {
		protected Zetbox.API.IZetboxContext ctx;


        public static void Call(Arebis.CodeGeneration.IGenerationHost _host, Zetbox.API.IZetboxContext ctx)
        {
            if (_host == null) { throw new global::System.ArgumentNullException("_host"); }

            _host.CallTemplate("AssemblyInfoTemplate", ctx);
        }

        public AssemblyInfoTemplate(Arebis.CodeGeneration.IGenerationHost _host, Zetbox.API.IZetboxContext ctx)
            : base(_host)
        {
			this.ctx = ctx;

        }

        public override void Generate()
        {
#line 6 "P:\Zetbox\Zetbox.Generator\Templates\AssemblyInfoTemplate.cst"
this.WriteObjects("// <autogenerated/>\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("[assembly: System.Reflection.AssemblyTitleAttribute(\"",  GetAssemblyTitle() , "\")]\r\n");
this.WriteObjects("[assembly: System.Reflection.AssemblyCompanyAttribute(\"dasz.at\")]\r\n");
this.WriteObjects("[assembly: System.Reflection.AssemblyProductAttribute(\"Zetbox\")]\r\n");
this.WriteObjects("[assembly: System.Reflection.AssemblyCopyrightAttribute(\"Copyright © dasz.at 2008-2009\")]\r\n");
this.WriteObjects("[assembly: System.Reflection.AssemblyVersionAttribute(\"1.0.0.0\")]\r\n");
this.WriteObjects("[assembly: System.Reflection.AssemblyFileVersionAttribute(\"1.0.0.0\")]\r\n");
this.WriteObjects("[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]\r\n");
this.WriteObjects("// [assembly: System.CLSCompliantAttribute(true)] // TODO: needs PositionSuffix without underscore and naming columns differently\r\n");
#line 17 "P:\Zetbox\Zetbox.Generator\Templates\AssemblyInfoTemplate.cst"
ApplyAdditionalAssemblyInfo();


        }

    }
}