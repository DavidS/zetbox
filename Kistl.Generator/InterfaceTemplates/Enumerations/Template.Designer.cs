using System;
using System.Linq;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.Generator;
using Kistl.Generator.Extensions;


namespace Kistl.Generator.InterfaceTemplates.Enumerations
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Generator\InterfaceTemplates\Enumerations\Template.cst")]
    public partial class Template : Kistl.Generator.ResourceTemplate
    {
		protected IKistlContext ctx;
		protected Enumeration e;


        public Template(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, Enumeration e)
            : base(_host)
        {
			this.ctx = ctx;
			this.e = e;

        }
        
        public override void Generate()
        {
#line 14 "P:\Kistl\Kistl.Generator\InterfaceTemplates\Enumerations\Template.cst"
this.WriteObjects("// <autogenerated/>\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("namespace ",  e.Module.Namespace , "\r\n");
this.WriteObjects("{\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("    /// <summary>\r\n");
this.WriteObjects("    /// ",  e.Description , "\r\n");
this.WriteObjects("    /// </summary>\r\n");
#line 23 "P:\Kistl\Kistl.Generator\InterfaceTemplates\Enumerations\Template.cst"
if(e.AreFlags)
	{	

#line 26 "P:\Kistl\Kistl.Generator\InterfaceTemplates\Enumerations\Template.cst"
this.WriteObjects("    [System.Flags]\r\n");
#line 28 "P:\Kistl\Kistl.Generator\InterfaceTemplates\Enumerations\Template.cst"
}

#line 30 "P:\Kistl\Kistl.Generator\InterfaceTemplates\Enumerations\Template.cst"
this.WriteObjects("    public enum ",  e.Name , "\r\n");
this.WriteObjects("    {\r\n");
#line 33 "P:\Kistl\Kistl.Generator\InterfaceTemplates\Enumerations\Template.cst"
foreach(EnumerationEntry entry in e.EnumerationEntries.OrderBy(ee => ee.Value))
    {

#line 36 "P:\Kistl\Kistl.Generator\InterfaceTemplates\Enumerations\Template.cst"
this.WriteObjects("		/// <summary>\r\n");
this.WriteObjects("		/// ",  entry.Description , "\r\n");
this.WriteObjects("		/// </summary>\r\n");
this.WriteObjects("		",  entry.Name , " = ",  entry.Value , ",\r\n");
this.WriteObjects("\r\n");
#line 42 "P:\Kistl\Kistl.Generator\InterfaceTemplates\Enumerations\Template.cst"
}

#line 44 "P:\Kistl\Kistl.Generator\InterfaceTemplates\Enumerations\Template.cst"
this.WriteObjects("	}\r\n");
this.WriteObjects("}");

        }



    }
}