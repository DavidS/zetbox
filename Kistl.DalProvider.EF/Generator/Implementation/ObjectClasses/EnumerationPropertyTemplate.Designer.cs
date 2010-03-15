using System;
using System.Linq;
using Kistl.API;
using Kistl.API.Server;
using Kistl.App.Base;
using Kistl.Server.Generators;
using Kistl.Server.Generators.Extensions;


namespace Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\EnumerationPropertyTemplate.cst")]
    public partial class EnumerationPropertyTemplate : Kistl.Server.Generators.KistlCodeTemplate
    {
		protected IKistlContext ctx;
		protected Kistl.Server.Generators.Templates.Implementation.SerializationMembersList serializationList;
		protected EnumerationProperty prop;
		protected bool callGetterSetterEvents;


        public EnumerationPropertyTemplate(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, Kistl.Server.Generators.Templates.Implementation.SerializationMembersList serializationList, EnumerationProperty prop, bool callGetterSetterEvents)
            : base(_host)
        {
			this.ctx = ctx;
			this.serializationList = serializationList;
			this.prop = prop;
			this.callGetterSetterEvents = callGetterSetterEvents;

        }
        
        public override void Generate()
        {
#line 18 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\EnumerationPropertyTemplate.cst"
string interfaceName = prop.ObjectClass.Name;

	string name = prop.PropertyName;
	string efName = name + Kistl.API.Helper.ImplementationSuffix;
	string backingName = "_" + name;

	bool isNullable = prop.Constraints.OfType<NotNullableConstraint>().Count() == 0;
	string enumType = prop.ReferencedTypeAsCSharp();
	string eventName = "On" + name;


#line 29 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\EnumerationPropertyTemplate.cst"
this.WriteObjects("   		// ",  this.GetType() , "\r\n");
this.WriteObjects("        // implement the user-visible interface\r\n");
this.WriteObjects("        public ",  enumType , " ",  name , "\r\n");
this.WriteObjects("        {\r\n");
this.WriteObjects("            get\r\n");
this.WriteObjects("            {\r\n");
#line 36 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\EnumerationPropertyTemplate.cst"
if(callGetterSetterEvents)
				{

#line 39 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\EnumerationPropertyTemplate.cst"
this.WriteObjects("				var __value = ",  backingName , ";\r\n");
this.WriteObjects("				if(",  eventName , "_Getter != null)\r\n");
this.WriteObjects("				{\r\n");
this.WriteObjects("					var e = new PropertyGetterEventArgs<",  enumType , ">(__value);\r\n");
this.WriteObjects("					",  eventName , "_Getter(this, e);\r\n");
this.WriteObjects("					__value = e.Result;\r\n");
this.WriteObjects("				}\r\n");
this.WriteObjects("                return __value;\r\n");
#line 48 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\EnumerationPropertyTemplate.cst"
}
				else
				{

#line 52 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\EnumerationPropertyTemplate.cst"
this.WriteObjects("				return ",  backingName , ";\r\n");
#line 54 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\EnumerationPropertyTemplate.cst"
}

#line 55 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\EnumerationPropertyTemplate.cst"
this.WriteObjects("            }\r\n");
this.WriteObjects("            set\r\n");
this.WriteObjects("            {\r\n");
this.WriteObjects("                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();\r\n");
this.WriteObjects("                if (",  backingName , " != value)\r\n");
this.WriteObjects("                {\r\n");
this.WriteObjects("					var __oldValue = ",  backingName , ";\r\n");
this.WriteObjects("					var __newValue = value;\r\n");
#line 64 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\EnumerationPropertyTemplate.cst"
if(callGetterSetterEvents)
					{

#line 67 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\EnumerationPropertyTemplate.cst"
this.WriteObjects("                    if(",  eventName , "_PreSetter != null)\r\n");
this.WriteObjects("                    {\r\n");
this.WriteObjects("						var e = new PropertyPreSetterEventArgs<",  enumType , ">(__oldValue, __newValue);\r\n");
this.WriteObjects("						",  eventName , "_PreSetter(this, e);\r\n");
this.WriteObjects("						__newValue = e.Result;\r\n");
this.WriteObjects("                    }\r\n");
#line 74 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\EnumerationPropertyTemplate.cst"
}

#line 75 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\EnumerationPropertyTemplate.cst"
this.WriteObjects("					\r\n");
this.WriteObjects("                    NotifyPropertyChanging(\"",  name , "\", \"",  efName , "\", __oldValue, __newValue);\r\n");
this.WriteObjects("                    ",  backingName , " = value;\r\n");
this.WriteObjects("                    NotifyPropertyChanged(\"",  name , "\", \"",  efName , "\", __oldValue, __newValue);\r\n");
#line 80 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\EnumerationPropertyTemplate.cst"
if(callGetterSetterEvents)
					{

#line 83 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\EnumerationPropertyTemplate.cst"
this.WriteObjects("                    if(",  eventName , "_PostSetter != null)\r\n");
this.WriteObjects("                    {\r\n");
this.WriteObjects("						var e = new PropertyPostSetterEventArgs<",  enumType , ">(__oldValue, __newValue);\r\n");
this.WriteObjects("						",  eventName , "_PostSetter(this, e);\r\n");
this.WriteObjects("                    }\r\n");
#line 89 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\EnumerationPropertyTemplate.cst"
}

#line 90 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\EnumerationPropertyTemplate.cst"
this.WriteObjects("                    \r\n");
this.WriteObjects("                }\r\n");
this.WriteObjects("            }\r\n");
this.WriteObjects("        }\r\n");
this.WriteObjects("        \r\n");
this.WriteObjects("        /// <summary>backing store for ",  name , "</summary>\r\n");
this.WriteObjects("        private ",  enumType , " ",  backingName , ";\r\n");
this.WriteObjects("        \r\n");
this.WriteObjects("        /// <summary>EF sees only this property, for ",  name , "</summary>\r\n");
this.WriteObjects("        [XmlIgnore()]\r\n");
this.WriteObjects("        [EdmScalarProperty()]\r\n");
this.WriteObjects("        public int",  isNullable ? "?" : String.Empty , " ",  efName , "\r\n");
this.WriteObjects("        {\r\n");
this.WriteObjects("            get\r\n");
this.WriteObjects("            {\r\n");
this.WriteObjects("                return (int",  isNullable ? "?" : String.Empty , ")this.",  name , ";\r\n");
this.WriteObjects("            }\r\n");
this.WriteObjects("            set\r\n");
this.WriteObjects("            {\r\n");
this.WriteObjects("                this.",  name , " = (",  enumType , ")value;\r\n");
this.WriteObjects("            }\r\n");
this.WriteObjects("        }\r\n");
this.WriteObjects("        \r\n");
#line 114 "P:\Kistl\Kistl.DalProvider.EF\Generator\Implementation\ObjectClasses\EnumerationPropertyTemplate.cst"
AddSerialization(serializationList);


        }



    }
}