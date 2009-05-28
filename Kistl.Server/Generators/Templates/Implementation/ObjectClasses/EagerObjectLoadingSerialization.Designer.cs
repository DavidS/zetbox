using System;
using System.Collections.Generic;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.Server.Generators;
using Kistl.Server.Generators.Extensions;


namespace Kistl.Server.Generators.Templates.Implementation.ObjectClasses
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\EagerObjectLoadingSerialization.cst")]
    public partial class EagerObjectLoadingSerialization : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected IKistlContext ctx;
		protected Templates.Implementation.SerializerDirection direction;
		protected string streamName;
		protected string xmlnamespace;
		protected string xmlname;
		protected string propertyName;


        public EagerObjectLoadingSerialization(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, Templates.Implementation.SerializerDirection direction, string streamName, string xmlnamespace, string xmlname, string propertyName)
            : base(_host)
        {
			this.ctx = ctx;
			this.direction = direction;
			this.streamName = streamName;
			this.xmlnamespace = xmlnamespace;
			this.xmlname = xmlname;
			this.propertyName = propertyName;

        }
        
        public override void Generate()
        {
#line 20 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\EagerObjectLoadingSerialization.cst"
switch(direction)
	{
		case SerializerDirection.ToStream:

#line 24 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\EagerObjectLoadingSerialization.cst"
this.WriteObjects("			auxObjects.Add(",  propertyName , ");\r\n");
#line 26 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\EagerObjectLoadingSerialization.cst"
break;
		case SerializerDirection.FromStream:
			break;
		default:
			throw new ArgumentOutOfRangeException("direction");
	}


        }



    }
}