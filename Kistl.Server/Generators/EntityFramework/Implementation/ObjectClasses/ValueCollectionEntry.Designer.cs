using System;
using System.Collections.Generic;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.Server.Generators;
using Kistl.Server.Generators.Extensions;


namespace Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionEntry.cst")]
    public partial class ValueCollectionEntry : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected IKistlContext ctx;
		protected ValueTypeProperty prop;


        public ValueCollectionEntry(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, ValueTypeProperty prop)
            : base(_host)
        {
			this.ctx = ctx;
			this.prop = prop;

        }
        
        public override void Generate()
        {
#line 17 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionEntry.cst"
bool isList = prop.IsIndexed;
	string ceInterface = isList ? "INewListEntry" : "INewCollectionEntry";
	string ceInterfaceFullName = String.Format("{0}<{1}, {2}>", 
		ceInterface, 
		prop.ObjectClass.ClassName,
		prop.GetPropertyTypeString());
	string ceName = prop.GetCollectionEntryClassName() + Kistl.API.Helper.ImplementationSuffix;
	
	string assocName = prop.GetAssociationName();
	
	List <string> fields = new List<string>();

#line 29 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionEntry.cst"
this.WriteObjects("\r\n");
this.WriteObjects("    [System.Diagnostics.DebuggerDisplay(\"",  prop.GetCollectionEntryClassName() , "\")]\r\n");
this.WriteObjects("    [EdmEntityType(NamespaceName=\"Model\", Name=\"",  prop.GetCollectionEntryClassName() , "\")]\r\n");
this.WriteObjects("    public class ",  ceName , "\r\n");
this.WriteObjects("        : BaseServerCollectionEntry_EntityFramework, ",  ceInterfaceFullName , "\r\n");
this.WriteObjects("    {\r\n");
this.WriteObjects("    \r\n");
#line 37 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionEntry.cst"
CallTemplate("Implementation.ObjectClasses.IdProperty", ctx);

#line 39 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionEntry.cst"
this.WriteObjects("\r\n");
this.WriteObjects("		/// <summary>\r\n");
this.WriteObjects("		/// Reference to the container of this CollectionEntry\r\n");
this.WriteObjects("		/// </summary>\r\n");
#line 44 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionEntry.cst"
CallTemplate("Implementation.ObjectClasses.ObjectReferencePropertyTemplate", ctx,
			"A", assocName, prop.ObjectClass.ClassName,
			prop.ObjectClass.ClassName, prop.ObjectClass.ClassName + Kistl.API.Helper.ImplementationSuffix,
			false);
		
		fields.Add("_fk_A");
		
		if (isList)
		{

#line 54 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionEntry.cst"
this.WriteObjects("\r\n");
this.WriteObjects("		/// <summary>\r\n");
this.WriteObjects("		/// Index on the A-side list of this relation, always ignored because \r\n");
this.WriteObjects("		/// the other side cannot have a navigator and therefore no order\r\n");
this.WriteObjects("		/// </summary>\r\n");
this.WriteObjects("		int? ",  ceInterfaceFullName , ".AIndex { get { return null; } set { } }\r\n");
this.WriteObjects("		\r\n");
#line 62 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionEntry.cst"
}

#line 64 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionEntry.cst"
this.WriteObjects("		/// <summary>\r\n");
this.WriteObjects("		/// the value\r\n");
this.WriteObjects("		/// </summary>\r\n");
#line 68 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionEntry.cst"
CallTemplate("Implementation.ObjectClasses.NotifyingValueProperty", ctx,
			prop.GetPropertyTypeString(), prop.PropertyName);
		
		fields.Add("_" + prop.PropertyName);


		if (isList)
		{

#line 77 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionEntry.cst"
this.WriteObjects("\r\n");
this.WriteObjects("		/// <summary>\r\n");
this.WriteObjects("		/// Index for ordering Values\r\n");
this.WriteObjects("		/// </summary>\r\n");
#line 82 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionEntry.cst"
CallTemplate("Implementation.ObjectClasses.NotifyingValueProperty", ctx,
				"int?", prop.PropertyName + Kistl.API.Helper.PositionSuffix);
		
			fields.Add("_" + prop.PropertyName + Kistl.API.Helper.PositionSuffix);
		}

#line 88 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionEntry.cst"
this.WriteObjects("\r\n");
this.WriteObjects("		// TODO: implement by redirecting with EF instead\r\n");
this.WriteObjects("		/// <summary>\r\n");
this.WriteObjects("		/// Implement interface by forwarding to actual property\r\n");
this.WriteObjects("		/// </summary>\r\n");
this.WriteObjects("		",  prop.ReferencedTypeAsCSharp() , " ",  ceInterfaceFullName , ".B {\r\n");
this.WriteObjects("			get { return ",  prop.PropertyName , "; } \r\n");
this.WriteObjects("			set { ",  prop.PropertyName , " = value; }\r\n");
this.WriteObjects("		}\r\n");
#line 99 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionEntry.cst"
if (isList)
		{

#line 102 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionEntry.cst"
this.WriteObjects("		/// <summary>\r\n");
this.WriteObjects("		/// Implement interface by forwarding to actual property\r\n");
this.WriteObjects("		/// </summary>\r\n");
this.WriteObjects("		int? ",  ceInterfaceFullName , ".BIndex {\r\n");
this.WriteObjects("			get { return ",  prop.PropertyName , "",  Kistl.API.Helper.PositionSuffix , "; } \r\n");
this.WriteObjects("			set { ",  prop.PropertyName , "",  Kistl.API.Helper.PositionSuffix , " = value; }\r\n");
this.WriteObjects("		}\r\n");
#line 110 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionEntry.cst"
}

#line 112 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionEntry.cst"
this.WriteObjects("\r\n");
this.WriteObjects("#region Serializer\r\n");
this.WriteObjects("\r\n");
#line 116 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionEntry.cst"
CallTemplate("Implementation.ObjectClasses.SerializerTemplate", ctx,
			SerializerDirection.ToStream, fields);
		
		CallTemplate("Implementation.ObjectClasses.SerializerTemplate", ctx,
			SerializerDirection.FromStream, fields);

#line 122 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionEntry.cst"
this.WriteObjects("\r\n");
this.WriteObjects("#endregion\r\n");
this.WriteObjects("        \r\n");
this.WriteObjects("    }\r\n");

        }



    }
}