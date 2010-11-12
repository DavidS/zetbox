using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.Server.Generators;
using Kistl.Server.Generators.Extensions;


namespace Kistl.Server.Generators.Templates.Implementation.ObjectClasses
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionEntries.cst")]
    public partial class CollectionEntries : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected IKistlContext ctx;


        public CollectionEntries(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx)
            : base(_host)
        {
			this.ctx = ctx;

        }
        
        public override void Generate()
        {
#line 15 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionEntries.cst"
this.WriteObjects("// <autogenerated/>\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("using System;\r\n");
this.WriteObjects("using System.Collections;\r\n");
this.WriteObjects("using System.Collections.Generic;\r\n");
this.WriteObjects("using System.Xml;\r\n");
this.WriteObjects("using System.Xml.Serialization;\r\n");
this.WriteObjects("using System.Linq;\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("using Kistl.API;\r\n");
#line 26 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionEntries.cst"
foreach(string ns in GetAdditionalImports().Distinct().OrderBy(s => s))
    {

#line 29 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionEntries.cst"
this.WriteObjects("    using ",  ns , ";\r\n");
#line 31 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionEntries.cst"
}

	foreach (var rel in ctx.GetQuery<Relation>()
	    .Where(r => r.Storage == StorageType.Separate)
	    .ToList()
	    .OrderBy(r => r.GetRelationClassName()))
	{


#line 40 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionEntries.cst"
this.WriteObjects("\r\n");
this.WriteObjects("namespace ",  rel.A.Type.Module.Namespace , "\r\n");
this.WriteObjects("{\r\n");
#line 44 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionEntries.cst"
if (rel.A.Type.Module.Namespace != rel.B.Type.Module.Namespace)
		{

#line 47 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionEntries.cst"
this.WriteObjects("	using ",  rel.B.Type.Module.Namespace , ";\r\n");
#line 49 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionEntries.cst"
}

		Implementation.CollectionEntries.ObjectCollectionEntry.Call(Host, ctx, rel);

#line 53 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionEntries.cst"
this.WriteObjects("}\r\n");
#line 55 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionEntries.cst"
}

#line 58 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionEntries.cst"
foreach (var prop in ctx.GetQuery<ValueTypeProperty>()
        .Where(p => p.IsList)
        .OrderBy(p => p.ObjectClass.Name)
        .ThenBy(p => p.Name))
	{


#line 65 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionEntries.cst"
this.WriteObjects("\r\n");
this.WriteObjects("namespace ",  prop.ObjectClass.Module.Namespace , "\r\n");
this.WriteObjects("{\r\n");
#line 69 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionEntries.cst"
Implementation.CollectionEntries.ValueCollectionEntry.Call(Host, ctx, prop);

#line 71 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionEntries.cst"
this.WriteObjects("}\r\n");
#line 73 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionEntries.cst"
}

#line 76 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionEntries.cst"
foreach (var prop in ctx.GetQuery<CompoundObjectProperty>()
        .Where(p => p.IsList)
        .OrderBy(p => p.ObjectClass.Name)
        .ThenBy(p => p.Name))
	{


#line 83 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionEntries.cst"
this.WriteObjects("\r\n");
this.WriteObjects("namespace ",  prop.ObjectClass.Module.Namespace , "\r\n");
this.WriteObjects("{\r\n");
#line 87 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionEntries.cst"
Implementation.CollectionEntries.ValueCollectionEntry.Call(Host, ctx, prop);

#line 89 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionEntries.cst"
this.WriteObjects("}\r\n");
#line 91 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionEntries.cst"
}


        }



    }
}