using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.App.Extensions;
using Kistl.Server.Generators;
using Kistl.Server.Generators.Extensions;


namespace Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst")]
    public partial class AssociationSetAttributes : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected IKistlContext ctx;


        public AssociationSetAttributes(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx)
            : base(_host)
        {
			this.ctx = ctx;

        }
        
        public override void Generate()
        {
#line 17 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
this.WriteObjects("using System.Data.Metadata.Edm;\r\n");
this.WriteObjects("using System.Data.Objects.DataClasses;\r\n");
this.WriteObjects("using System.Xml;\r\n");
this.WriteObjects("using System.Xml.Serialization;\r\n");
this.WriteObjects("\r\n");
this.WriteObjects("using Kistl.API;\r\n");
this.WriteObjects("using Kistl.DalProvider.EF;\r\n");
this.WriteObjects("\r\n");
#line 26 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
foreach (var rel in ctx.GetQuery<Relation>().ToList().OrderBy(r => r.GetAssociationName()))
	{

#line 29 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
this.WriteObjects("\r\n");
this.WriteObjects("	/*\r\n");
#line 32 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
Implementation.RelationDebugTemplate.Call(Host, ctx, rel);

#line 34 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
this.WriteObjects("	*/\r\n");
#line 36 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
switch (rel.Storage)
		{
			case StorageType.MergeIntoA:
			case StorageType.MergeIntoB:
			case StorageType.Replicate:

#line 42 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
this.WriteObjects("\r\n");
this.WriteObjects("// basic association\r\n");
this.WriteObjects("[assembly: EdmRelationship(\r\n");
this.WriteObjects("    \"Model\", \"",  rel.GetAssociationName() , "\",\r\n");
this.WriteObjects("    \"",  rel.A.RoleName , "\", RelationshipMultiplicity.",  rel.A.Multiplicity.ToCsdlRelationshipMultiplicity() , ", typeof(",  rel.A.Type.GetDataTypeString() + Kistl.API.Helper.ImplementationSuffix , "),\r\n");
this.WriteObjects("    \"",  rel.B.RoleName , "\", RelationshipMultiplicity.",  rel.B.Multiplicity.ToCsdlRelationshipMultiplicity() , ", typeof(",  rel.B.Type.GetDataTypeString() + Kistl.API.Helper.ImplementationSuffix , ")\r\n");
this.WriteObjects("    )]\r\n");
this.WriteObjects("\r\n");
#line 51 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
break;
			case StorageType.Separate:

#line 54 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
this.WriteObjects("\r\n");
this.WriteObjects("// The association from A to the CollectionEntry\r\n");
this.WriteObjects("[assembly: EdmRelationship(\"Model\", \"",  rel.GetRelationAssociationName(RelationEndRole.A) , "\",\r\n");
this.WriteObjects("    \"",  rel.A.RoleName , "\", RelationshipMultiplicity.ZeroOrOne, typeof(",  rel.A.Type.GetDataTypeString() + Kistl.API.Helper.ImplementationSuffix , "),\r\n");
this.WriteObjects("    \"CollectionEntry\", RelationshipMultiplicity.Many, typeof(",  rel.GetRelationFullName() + Kistl.API.Helper.ImplementationSuffix , ")\r\n");
this.WriteObjects("    )]\r\n");
this.WriteObjects("// The association from B to the CollectionEntry\r\n");
this.WriteObjects("[assembly: EdmRelationship(\"Model\", \"",  rel.GetRelationAssociationName(RelationEndRole.B) , "\",\r\n");
this.WriteObjects("    \"",  rel.B.RoleName , "\", RelationshipMultiplicity.ZeroOrOne, typeof(",  rel.B.Type.GetDataTypeString() + Kistl.API.Helper.ImplementationSuffix , "),\r\n");
this.WriteObjects("    \"CollectionEntry\", RelationshipMultiplicity.Many, typeof(",  rel.GetRelationFullName() + Kistl.API.Helper.ImplementationSuffix , ")\r\n");
this.WriteObjects("    )]\r\n");
#line 66 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
break;
			default:
				throw new NotImplementedException(String.Format("Unknown StorageHint.{0} preference", rel.Storage));
		}
	}


#line 73 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
this.WriteObjects("\r\n");
#line 75 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
foreach (var prop in ctx.GetQuery<ValueTypeProperty>()
		.Where(p => p.IsList)
		.OrderBy(p => p.ObjectClass.Name)
		.ThenBy(p => p.PropertyName))
	{

#line 81 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
this.WriteObjects("\r\n");
this.WriteObjects("// object-value association\r\n");
this.WriteObjects("[assembly: EdmRelationship(\r\n");
this.WriteObjects("    \"Model\", \"",  prop.GetAssociationName() , "\",\r\n");
this.WriteObjects("    \"",  prop.ObjectClass.Name , "\", RelationshipMultiplicity.ZeroOrOne, typeof(",  prop.ObjectClass.Module.Namespace + "." + prop.ObjectClass.Name + Kistl.API.Helper.ImplementationSuffix , "),\r\n");
this.WriteObjects("    \"CollectionEntry\", RelationshipMultiplicity.Many, typeof(",  prop.GetCollectionEntryFullName() + Kistl.API.Helper.ImplementationSuffix , ")\r\n");
this.WriteObjects("    )]\r\n");
this.WriteObjects("\r\n");
#line 90 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
}

#line 92 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
this.WriteObjects("\r\n");
#line 94 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
foreach (var prop in ctx.GetQuery<CompoundObjectProperty>()
		.Where(p => p.IsList)
		.OrderBy(p => p.ObjectClass.Name)
		.ThenBy(p => p.PropertyName))
	{

#line 100 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
this.WriteObjects("\r\n");
this.WriteObjects("// object-struct association\r\n");
this.WriteObjects("[assembly: EdmRelationship(\r\n");
this.WriteObjects("    \"Model\", \"",  prop.GetAssociationName() , "\",\r\n");
this.WriteObjects("    \"",  prop.ObjectClass.Name , "\", RelationshipMultiplicity.ZeroOrOne, typeof(",  prop.ObjectClass.Module.Namespace + "." + prop.ObjectClass.Name + Kistl.API.Helper.ImplementationSuffix , "),\r\n");
this.WriteObjects("    \"CollectionEntry\", RelationshipMultiplicity.Many, typeof(",  prop.GetCollectionEntryFullName() + Kistl.API.Helper.ImplementationSuffix , ")\r\n");
this.WriteObjects("    )]\r\n");
this.WriteObjects("\r\n");
#line 109 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
}

#line 111 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
this.WriteObjects("\r\n");
#line 113 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
foreach (var cls in ctx.GetQuery<ObjectClass>().Where(c => c.BaseObjectClass == null)
		.OrderBy(c => c.Name))
	{
		if(cls.NeedsRightsTable())
		{

#line 119 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
this.WriteObjects("[assembly: global::System.Data.Objects.DataClasses.EdmRelationshipAttribute(\"Model\", \"",  Construct.SecurityRulesFKName(cls) , "\", \r\n");
this.WriteObjects("	\"",  cls.Name , "\", \r\n");
this.WriteObjects("	global::System.Data.Metadata.Edm.RelationshipMultiplicity.One, \r\n");
this.WriteObjects("	typeof(",  cls.Module.Namespace + "." + cls.Name + Kistl.API.Helper.ImplementationSuffix , "), \r\n");
this.WriteObjects("	\"",  Construct.SecurityRulesClassName(cls) , "\", \r\n");
this.WriteObjects("	global::System.Data.Metadata.Edm.RelationshipMultiplicity.Many, \r\n");
this.WriteObjects("	typeof(",  cls.Module.Namespace + "." + Construct.SecurityRulesClassName(cls) + Kistl.API.Helper.ImplementationSuffix , "))]\r\n");
#line 127 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\AssociationSetAttributes.cst"
}
	}


        }



    }
}