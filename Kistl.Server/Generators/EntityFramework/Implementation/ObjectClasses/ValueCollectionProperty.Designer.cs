using System;
using System.Collections.Generic;
using System.Diagnostics;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.Server.Generators;
using Kistl.Server.Generators.Extensions;


namespace Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionProperty.cst")]
    public partial class ValueCollectionProperty : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected IKistlContext ctx;
		protected Templates.Implementation.SerializationMembersList serializationList;
		protected ValueTypeProperty prop;


        public ValueCollectionProperty(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, Templates.Implementation.SerializationMembersList serializationList, ValueTypeProperty prop)
            : base(_host)
        {
			this.ctx = ctx;
			this.serializationList = serializationList;
			this.prop = prop;

        }
        
        public override void Generate()
        {
#line 18 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionProperty.cst"
Debug.Assert(prop.IsList);


	// the name of the property to create
	string name = prop.PropertyName;
	// the ef-visible property's name
	string efName = name + Kistl.API.Helper.ImplementationSuffix;
	// the name of the private backing store for the conversion wrapper list
	string wrapperName = "_" + name + "Wrapper";
	// the name of the wrapper class for wrapping the EntityCollection
	string wrapperClass = (prop.HasPersistentOrder ? "EFValueListWrapper" : "EFValueCollectionWrapper");
	
	// the name of the EF association
	string assocName = prop.GetAssociationName();
	string targetRoleName = "CollectionEntry";

	// which generic interface to use for the collection
	string exposedListType = prop.HasPersistentOrder ? "IList" : "ICollection";

	// which Kistl interface this is 
	string thisInterface = prop.ObjectClass.ClassName;
	// which type this list contains
	string referencedType = prop.ReferencedTypeAsCSharp();
	// collection entries in this list
	string referencedCollectionEntry = prop.GetCollectionEntryClassName() + Kistl.API.Helper.ImplementationSuffix;

    AddSerialization(serializationList, efName);


#line 47 "P:\Kistl\Kistl.Server\Generators\EntityFramework\Implementation\ObjectClasses\ValueCollectionProperty.cst"
this.WriteObjects("   		// ",  this.GetType() , "\r\n");
this.WriteObjects("        // implement the user-visible interface\r\n");
this.WriteObjects("        [XmlIgnore()]\r\n");
this.WriteObjects("        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]\r\n");
this.WriteObjects("        public ",  exposedListType , "<",  referencedType , "> ",  name , "\r\n");
this.WriteObjects("        {\r\n");
this.WriteObjects("            get\r\n");
this.WriteObjects("            {\r\n");
this.WriteObjects("                if (",  wrapperName , " == null)\r\n");
this.WriteObjects("                {\r\n");
this.WriteObjects("                    ",  wrapperName , " = new ",  wrapperClass , "<",  thisInterface , ", ",  referencedType , ", ",  referencedCollectionEntry , ", EntityCollection<",  referencedCollectionEntry , ">>(\r\n");
this.WriteObjects("						this.Context,\r\n");
this.WriteObjects("                        this,\r\n");
this.WriteObjects("                        ",  efName , ");\r\n");
this.WriteObjects("                }\r\n");
this.WriteObjects("                return ",  wrapperName , ";\r\n");
this.WriteObjects("            }\r\n");
this.WriteObjects("        }\r\n");
this.WriteObjects("        \r\n");
this.WriteObjects("        [EdmRelationshipNavigationProperty(\"Model\", \"",  assocName , "\", \"",  targetRoleName , "\")]\r\n");
this.WriteObjects("        public EntityCollection<",  referencedCollectionEntry , "> ",  efName , "\r\n");
this.WriteObjects("        {\r\n");
this.WriteObjects("            get\r\n");
this.WriteObjects("            {\r\n");
this.WriteObjects("                var c = ((IEntityWithRelationships)(this)).RelationshipManager\r\n");
this.WriteObjects("                    .GetRelatedCollection<",  referencedCollectionEntry , ">(\r\n");
this.WriteObjects("                        \"Model.",  assocName , "\",\r\n");
this.WriteObjects("                        \"",  targetRoleName , "\");\r\n");
this.WriteObjects("                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)\r\n");
this.WriteObjects("                    && !c.IsLoaded)\r\n");
this.WriteObjects("                {\r\n");
this.WriteObjects("                    c.Load();\r\n");
this.WriteObjects("                }\r\n");
this.WriteObjects("                return c;\r\n");
this.WriteObjects("            }\r\n");
this.WriteObjects("        }\r\n");
this.WriteObjects("        private ",  wrapperClass , "<",  thisInterface , ", ",  referencedType , ", ",  referencedCollectionEntry , ", EntityCollection<",  referencedCollectionEntry , ">> ",  wrapperName , ";\r\n");

        }



    }
}