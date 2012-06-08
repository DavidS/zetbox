using System;
using System.Linq;
using Zetbox.API;
using Zetbox.API.Server;
using Zetbox.App.Base;
using Zetbox.Generator;
using Zetbox.Generator.Extensions;


namespace Zetbox.Generator.Templates.ObjectClasses
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst")]
    public partial class Method : Zetbox.Generator.MemberTemplate
    {
		protected IZetboxContext ctx;
		protected Zetbox.App.Base.DataType dt;
		protected Zetbox.App.Base.Method m;
		protected int index;
		protected string indexSuffix;
		protected string eventName;


        public static void Call(Arebis.CodeGeneration.IGenerationHost _host, IZetboxContext ctx, Zetbox.App.Base.DataType dt, Zetbox.App.Base.Method m, int index, string indexSuffix, string eventName)
        {
            if (_host == null) { throw new global::System.ArgumentNullException("_host"); }

            _host.CallTemplate("ObjectClasses.Method", ctx, dt, m, index, indexSuffix, eventName);
        }

        public Method(Arebis.CodeGeneration.IGenerationHost _host, IZetboxContext ctx, Zetbox.App.Base.DataType dt, Zetbox.App.Base.Method m, int index, string indexSuffix, string eventName)
            : base(_host)
        {
			this.ctx = ctx;
			this.dt = dt;
			this.m = m;
			this.index = index;
			this.indexSuffix = indexSuffix;
			this.eventName = eventName;

        }

        public override void Generate()
        {
#line 18 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
this.WriteObjects("        // BEGIN ",  this.GetType() , "\r\n");
#line 20 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
foreach(var attr in GetMethodAttributes())
    {

#line 23 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
this.WriteObjects("        ",  attr , "\r\n");
#line 25 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
}

#line 27 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
this.WriteObjects("        ",  GetModifiers() , " ",  GetReturnType() , " ",  m.Name , "(",  GetParameterDefinitions() , ")\r\n");
#line 30 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
string delegateName = m.Name + indexSuffix + "_Handler";
    var returnParam = m.Parameter.SingleOrDefault(parameter => parameter.IsReturnParameter);

    string parameterDefs = m.GetParameterDefinitions();
    if (!String.IsNullOrEmpty(parameterDefs))
    {
        // add leading comma for later usage
        parameterDefs = ", " + parameterDefs;
    }

    string argumentDefs = m.GetArguments();
    if (!String.IsNullOrEmpty(argumentDefs))
    {
        // add leading comma for later usage
        argumentDefs = ", " + argumentDefs;
    }

    if (returnParam == null)
    {

#line 50 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
this.WriteObjects("        {\r\n");
this.WriteObjects("            // base.",  m.Name , "();\r\n");
this.WriteObjects("            if (",  eventName , " != null)\r\n");
this.WriteObjects("            {\r\n");
this.WriteObjects("                ",  eventName , "(this",  argumentDefs , ");\r\n");
this.WriteObjects("            }\r\n");
this.WriteObjects("            else\r\n");
this.WriteObjects("            {\r\n");
#line 59 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
if (m.ObjectClass == dt || !(dt is ObjectClass))
        {

#line 62 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
this.WriteObjects("                throw new NotImplementedException(\"No handler registered on method ",  m.ObjectClass.Name , ".",  m.Name , "\");\r\n");
#line 64 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
}
        else
        {

#line 68 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
this.WriteObjects("                base.",  m.Name , "(",  m.GetArguments() , ");\r\n");
#line 70 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
}

#line 72 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
this.WriteObjects("            }\r\n");
this.WriteObjects("        }\r\n");
#line 75 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
// define delegate type only on base class
        if (this.m.ObjectClass == this.dt)
        {

#line 79 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
this.WriteObjects("        public delegate void ",  delegateName , "<T>(T obj",  parameterDefs , ");\r\n");
#line 81 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
}
    }
    else
    {

        string returnArgsType = String.Format("MethodReturnEventArgs<{0}>", returnParam.GetParameterTypeString());

#line 88 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
this.WriteObjects("        {\r\n");
this.WriteObjects("            var e = new ",  returnArgsType , "();\r\n");
this.WriteObjects("            if (",  eventName , " != null)\r\n");
this.WriteObjects("            {\r\n");
this.WriteObjects("                ",  eventName , "(this, e",  argumentDefs , ");\r\n");
this.WriteObjects("            }\r\n");
this.WriteObjects("            else\r\n");
this.WriteObjects("            {\r\n");
#line 97 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
if (m.ObjectClass == dt || !(dt is ObjectClass))
        {

#line 100 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
this.WriteObjects("                throw new NotImplementedException(\"No handler registered on ",  m.ObjectClass.Name , ".",  m.Name , "\");\r\n");
#line 102 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
}
        else
        {

#line 106 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
this.WriteObjects("                e.Result = base.",  m.Name , "(",  m.GetArguments() , ");\r\n");
#line 108 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
}

#line 110 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
this.WriteObjects("            }\r\n");
this.WriteObjects("            return e.Result;\r\n");
this.WriteObjects("        }\r\n");
#line 115 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
// define delegate type only on base class
        if (this.m.ObjectClass == this.dt)
        {

#line 119 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
this.WriteObjects("        public delegate void ",  delegateName , "<T>(T obj, ",  returnArgsType , " ret",  parameterDefs , ");\r\n");
#line 121 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
}
    }


#line 125 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
this.WriteObjects("        public static event ",  delegateName , "<",  dt.Name , "> ",  eventName , ";\r\n");
#line 127 "P:\Zetbox\Zetbox.Generator\Templates\ObjectClasses\Method.cst"
if(index == 0) {
	// Only for first overload
	MethodCanExec.Call(Host, ctx, dt, m, eventName);
} 
        // END <%= this.GetType() 

        }

    }
}