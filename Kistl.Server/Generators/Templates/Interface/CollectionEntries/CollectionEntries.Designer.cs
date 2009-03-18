using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.Server.Generators;
using Kistl.Server.Generators.Extensions;


namespace Kistl.Server.Generators.Templates.Interface.CollectionEntries
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Server\Generators\Templates\Interface\CollectionEntries\CollectionEntries.cst")]
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
#line 15 "P:\Kistl\Kistl.Server\Generators\Templates\Interface\CollectionEntries\CollectionEntries.cst"
this.WriteObjects("using System;\r\n");
this.WriteObjects("using System.Collections;\r\n");
this.WriteObjects("using System.Collections.Generic;\r\n");
this.WriteObjects("using System.Xml;\r\n");
this.WriteObjects("using System.Xml.Serialization;\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("using Kistl.API;\r\n");
this.WriteObjects("\r\n");
#line 24 "P:\Kistl\Kistl.Server\Generators\Templates\Interface\CollectionEntries\CollectionEntries.cst"
foreach (var rel in ctx.GetQuery<Relation>()
	    .Where(r => (int)r.Storage == (int)StorageType.Separate)
	    .ToList()
	    .OrderBy(r => r.GetCollectionEntryClassName()))
	{
		this.CallTemplate("Interface.CollectionEntries.ObjectCollectionEntry", ctx, rel);
	}


	foreach (var prop in ctx.GetQuery<ValueTypeProperty>()
        .Where(p => p.IsList)
        .OrderBy(p => p.ObjectClass.ClassName)
        .ThenBy(p => p.PropertyName))
	{

		this.CallTemplate("Interface.CollectionEntries.ValueCollectionEntry", ctx, prop);
	}


        }



    }
}