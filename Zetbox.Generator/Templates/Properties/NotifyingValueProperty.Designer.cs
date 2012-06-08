using System;
using Zetbox.API;
using Zetbox.API.Server;
using Zetbox.App.Base;
using Zetbox.Generator;
using Zetbox.Generator.Extensions;


namespace Zetbox.Generator.Templates.Properties
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst")]
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
#line 18 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
this.WriteObjects("        // BEGIN ",  this.GetType() , "\r\n");
#line 21 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
ApplyRequisitesTemplate();

    ApplyAttributesTemplate();


#line 26 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
this.WriteObjects("        ",  GetModifiers() , " ",  type , " ",  name , "\r\n");
this.WriteObjects("        {\r\n");
this.WriteObjects("            get\r\n");
this.WriteObjects("            {\r\n");
#line 30 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
ApplySecurityCheckTemplate(); 
#line 31 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
this.WriteObjects("                // create local variable to create single point of return\r\n");
this.WriteObjects("                // for the benefit of down-stream templates\r\n");
this.WriteObjects("                var __result = ",  backingName , ";\r\n");
#line 34 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
ApplyOnGetTemplate(); 
#line 35 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
this.WriteObjects("                return __result;\r\n");
this.WriteObjects("            }\r\n");
this.WriteObjects("            set\r\n");
this.WriteObjects("            {\r\n");
this.WriteObjects("                if (this.IsReadonly) throw new ReadOnlyObjectException();\r\n");
#line 40 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
if (!isCalculated) ApplyOnAllSetTemplate(); 
#line 41 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
this.WriteObjects("                if (",  backingName , " != value)\r\n");
this.WriteObjects("                {\r\n");
this.WriteObjects("                    var __oldValue = ",  backingName , ";\r\n");
this.WriteObjects("                    var __newValue = value;\r\n");
#line 45 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
if (!isCalculated) ApplyPreSetTemplate(); 
#line 46 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
this.WriteObjects("                    NotifyPropertyChanging(\"",  name , "\", __oldValue, __newValue);\r\n");
this.WriteObjects("                    ",  backingName , " = __newValue;\r\n");
this.WriteObjects("                    NotifyPropertyChanged(\"",  name , "\", __oldValue, __newValue);\r\n");
#line 49 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
if (isCalculated) { 
#line 50 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
this.WriteObjects("			        ",  backingName , "_IsDirty = false;\r\n");
#line 51 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
} 
#line 52 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
this.WriteObjects("\r\n");
#line 53 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
if (!isCalculated) ApplyPostSetTemplate(); 
#line 54 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
this.WriteObjects("                }\r\n");
this.WriteObjects("				else \r\n");
this.WriteObjects("				{\r\n");
this.WriteObjects("					SetInitializedProperty(\"",  name , "\");\r\n");
this.WriteObjects("				}\r\n");
this.WriteObjects("            }\r\n");
this.WriteObjects("        }\r\n");
#line 61 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
ApplyBackingStoreDefinition(); 
#line 62 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
ApplyBackingStoreIsDirtyDefinition(); 
#line 63 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
ApplyTailTemplate(); 
#line 64 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
AddSerialization(serializationList, name); 
#line 65 "P:\Zetbox\Zetbox.Generator\Templates\Properties\NotifyingValueProperty.cst"
this.WriteObjects("        // END ",  this.GetType() , "\r\n");

        }

    }
}