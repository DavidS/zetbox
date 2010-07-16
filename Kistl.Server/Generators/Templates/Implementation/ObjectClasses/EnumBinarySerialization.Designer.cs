using System;
using System.Collections.Generic;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.App.Extensions;
using Kistl.Server.Generators;
using Kistl.Server.Generators.Extensions;


namespace Kistl.Server.Generators.Templates.Implementation.ObjectClasses
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\EnumBinarySerialization.cst")]
    public partial class EnumBinarySerialization : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected IKistlContext ctx;
		protected SerializerDirection direction;
		protected string streamName;
		protected string xmlnamespace;
		protected string xmlname;
		protected EnumerationProperty prop;


        public EnumBinarySerialization(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, SerializerDirection direction, string streamName, string xmlnamespace, string xmlname, EnumerationProperty prop)
            : base(_host)
        {
			this.ctx = ctx;
			this.direction = direction;
			this.streamName = streamName;
			this.xmlnamespace = xmlnamespace;
			this.xmlname = xmlname;
			this.prop = prop;

        }
        
        public override void Generate()
        {
#line 20 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\EnumBinarySerialization.cst"
// always use the interface to get the "right" property
	string interfaceName = prop.ObjectClass.Name;
    string memberName = prop.Name;
    string enumName =  prop.Enumeration.Module.Namespace + "." +  prop.Enumeration.Name;
    if(prop.IsNullable()) enumName += "?";
	string methodName = direction.ToString();
	
	////
	////  This class always serializes as int? to avoid complicating the code
	////
	
	switch(direction){
		case SerializerDirection.ToStream:

#line 34 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\EnumBinarySerialization.cst"
this.WriteObjects("            BinarySerializer.",  methodName , "((int?)((",  interfaceName , ")this).",  memberName , ", ",  streamName , ");\r\n");
#line 36 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\EnumBinarySerialization.cst"
break;
		case SerializerDirection.FromStream:

#line 39 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\EnumBinarySerialization.cst"
this.WriteObjects("			{\r\n");
this.WriteObjects("				int? baseValue;\r\n");
this.WriteObjects("				BinarySerializer.",  methodName , "(out baseValue, ",  streamName , ");\r\n");
this.WriteObjects("				((",  interfaceName , ")this).",  memberName , " = (",  enumName , ")baseValue;\r\n");
this.WriteObjects("			}\r\n");
#line 45 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\EnumBinarySerialization.cst"
break;
		case SerializerDirection.ToXmlStream:

#line 48 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\EnumBinarySerialization.cst"
this.WriteObjects("            XmlStreamer.ToStream((int?)this.",  memberName , ", ",  streamName , ", \"",  xmlname , "\", \"",  xmlnamespace , "\");\r\n");
#line 50 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\EnumBinarySerialization.cst"
break;
		case SerializerDirection.FromXmlStream:
		case SerializerDirection.MergeImport:

#line 54 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\EnumBinarySerialization.cst"
this.WriteObjects("            XmlStreamer.FromStreamConverter(v => ((",  interfaceName , ")this).",  memberName , " = (",  enumName , ")v, ",  streamName , ", \"",  xmlname , "\", \"",  xmlnamespace , "\");\r\n");
#line 56 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\EnumBinarySerialization.cst"
break;
		case SerializerDirection.Export:

#line 59 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\EnumBinarySerialization.cst"
this.WriteObjects("            if (modules.Contains(\"*\") || modules.Contains(\"",  xmlnamespace , "\")) XmlStreamer.ToStream((int?)this.",  memberName , ", ",  streamName , ", \"",  xmlname , "\", \"",  xmlnamespace , "\");\r\n");
#line 61 "P:\Kistl\Kistl.Server\Generators\Templates\Implementation\ObjectClasses\EnumBinarySerialization.cst"
break;
		default:
			throw new ArgumentOutOfRangeException("direction");
	}


        }



    }
}