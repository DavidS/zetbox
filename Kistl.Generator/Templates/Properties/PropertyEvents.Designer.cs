using System;
using Kistl.API;


namespace Kistl.Generator.Templates.Properties
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.Generator\Templates\Properties\PropertyEvents.cst")]
    public partial class PropertyEvents : Kistl.Generator.ResourceTemplate
    {
		protected IKistlContext ctx;
		protected string eventName;
		protected string propType;
		protected string objType;
		protected bool hasGetters;
		protected bool hasSetters;


        public PropertyEvents(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, string eventName, string propType, string objType, bool hasGetters, bool hasSetters)
            : base(_host)
        {
			this.ctx = ctx;
			this.eventName = eventName;
			this.propType = propType;
			this.objType = objType;
			this.hasGetters = hasGetters;
			this.hasSetters = hasSetters;

        }
        
        public override void Generate()
        {
#line 13 "P:\Kistl\Kistl.Generator\Templates\Properties\PropertyEvents.cst"
if (hasGetters) { 
#line 14 "P:\Kistl\Kistl.Generator\Templates\Properties\PropertyEvents.cst"
this.WriteObjects("		public static event PropertyGetterHandler<",  objType , ", ",  propType , "> ",  eventName , "_Getter;\r\n");
#line 15 "P:\Kistl\Kistl.Generator\Templates\Properties\PropertyEvents.cst"
} 
#line 16 "P:\Kistl\Kistl.Generator\Templates\Properties\PropertyEvents.cst"
if (hasSetters) { 
#line 17 "P:\Kistl\Kistl.Generator\Templates\Properties\PropertyEvents.cst"
this.WriteObjects("		public static event PropertyPreSetterHandler<",  objType , ", ",  propType , "> ",  eventName , "_PreSetter;\r\n");
this.WriteObjects("		public static event PropertyPostSetterHandler<",  objType , ", ",  propType , "> ",  eventName , "_PostSetter;\r\n");
#line 19 "P:\Kistl\Kistl.Generator\Templates\Properties\PropertyEvents.cst"
} 

        }



    }
}