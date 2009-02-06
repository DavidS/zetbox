using System;
using System.Collections.Generic;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.Server.Generators;
using Kistl.Server.Generators.Extensions;
using Kistl.Server.Movables;


namespace Kistl.Server.Generators.Templates.Implementation.ObjectClasses
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionSerialization.cst")]
    public partial class CollectionSerialization : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected IKistlContext ctx;
		protected Templates.Implementation.SerializerDirection direction;
		protected string streamName;
		protected string collectionName;


        public CollectionSerialization(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, Templates.Implementation.SerializerDirection direction, string streamName, string collectionName)
            : base(_host)
        {
			this.ctx = ctx;
			this.direction = direction;
			this.streamName = streamName;
			this.collectionName = collectionName;

        }
        
        public override void Generate()
        {
#line 19 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionSerialization.cst"
string methodName = direction.ToString();


#line 22 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\CollectionSerialization.cst"
this.WriteObjects("            BinarySerializer.",  methodName , "CollectionEntries(this.",  collectionName , ", ",  streamName , ");\r\n");

        }



    }
}