using System;
using Zetbox.API;
using Zetbox.API.Server;
using Zetbox.App.Base;
using Zetbox.Generator;
using Zetbox.Generator.Extensions;


namespace Zetbox.Generator.Templates.Properties
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst")]
    public partial class NotifyingValueProperty : Zetbox.Generator.MemberTemplate
    {
		protected IZetboxContext ctx;
		protected Serialization.SerializationMembersList serializationList;
		protected string type;
		protected string name;
		protected string modulenamespace;
		protected string backingName;
		protected bool isCalculated;


        public static void Call(Arebis.CodeGeneration.IGenerationHost _host, IZetboxContext ctx, Serialization.SerializationMembersList serializationList, string type, string name, string modulenamespace, string backingName, bool isCalculated)
        {
            if (_host == null) { throw new global::System.ArgumentNullException("_host"); }

            _host.CallTemplate("Properties.NotifyingValueProperty", ctx, serializationList, type, name, modulenamespace, backingName, isCalculated);
        }

        public NotifyingValueProperty(Arebis.CodeGeneration.IGenerationHost _host, IZetboxContext ctx, Serialization.SerializationMembersList serializationList, string type, string name, string modulenamespace, string backingName, bool isCalculated)
            : base(_host)
        {
			this.ctx = ctx;
			this.serializationList = serializationList;
			this.type = type;
			this.name = name;
			this.modulenamespace = modulenamespace;
			this.backingName = backingName;
			this.isCalculated = isCalculated;

        }

        public override void Generate()
        {
#line 17 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
this.WriteObjects("");
#line 34 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
this.WriteObjects("        // BEGIN ",  this.GetType() , "\n");
#line 37 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
ApplyRequisitesTemplate();

    ApplyAttributesTemplate();


#line 42 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
this.WriteObjects("        ",  GetModifiers() , " ",  type , " ",  name , "\n");
this.WriteObjects("        {\n");
this.WriteObjects("            get\n");
this.WriteObjects("            {\n");
#line 46 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
ApplySecurityCheckTemplate(); 
#line 47 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
this.WriteObjects("                // create local variable to create single point of return\n");
this.WriteObjects("                // for the benefit of down-stream templates\n");
this.WriteObjects("                var __result = ",  backingName , ";\n");
#line 50 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
ApplyOnGetTemplate(); 
#line 51 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
this.WriteObjects("                return __result;\n");
this.WriteObjects("            }\n");
this.WriteObjects("            set\n");
this.WriteObjects("            {\n");
this.WriteObjects("                if (this.IsReadonly) throw new ReadOnlyObjectException();\n");
#line 56 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
if (!isCalculated) ApplyOnAllSetTemplate(); 
#line 57 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
this.WriteObjects("                if (",  backingName , " != value)\n");
this.WriteObjects("                {\n");
this.WriteObjects("                    var __oldValue = ",  backingName , ";\n");
this.WriteObjects("                    var __newValue = value;\n");
#line 61 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
if (!isCalculated) ApplyPreSetTemplate(); 
#line 62 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
this.WriteObjects("                    NotifyPropertyChanging(\"",  name , "\", __oldValue, __newValue);\n");
this.WriteObjects("                    ",  backingName , " = __newValue;\n");
this.WriteObjects("                    NotifyPropertyChanged(\"",  name , "\", __oldValue, __newValue);\n");
#line 65 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
if (isCalculated) { 
#line 66 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
this.WriteObjects("			        ",  backingName , "_IsDirty = false;\n");
#line 67 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
} 
#line 68 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
this.WriteObjects("\n");
#line 69 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
if (!isCalculated) ApplyPostSetTemplate(); 
#line 70 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
this.WriteObjects("                }\n");
this.WriteObjects("				else \n");
this.WriteObjects("				{\n");
this.WriteObjects("					SetInitializedProperty(\"",  name , "\");\n");
this.WriteObjects("				}\n");
this.WriteObjects("            }\n");
this.WriteObjects("        }\n");
#line 77 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
ApplyBackingStoreDefinition(); 
#line 78 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
ApplyBackingStoreIsDirtyDefinition(); 
#line 79 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
ApplyTailTemplate(); 
#line 80 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
AddSerialization(serializationList, name); 
#line 81 "P:\zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
this.WriteObjects("        // END ",  this.GetType() , "\n");

        }

    }
}