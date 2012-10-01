using System;
using System.Linq;
using Zetbox.API;
using Zetbox.API.Server;
using Zetbox.App.Base;
using Zetbox.Generator;
using Zetbox.Generator.Extensions;


namespace Zetbox.Generator.Templates.ObjectClasses
{
    [Arebis.CodeGeneration.TemplateInfo(@"P:\zetbox\Zetbox.Generator\Templates\ObjectClasses\AttachToContextTemplate.cst")]
    public partial class AttachToContextTemplate : Zetbox.Generator.ResourceTemplate
    {
		protected IZetboxContext ctx;
		protected ObjectClass cls;


        public static void Call(Arebis.CodeGeneration.IGenerationHost _host, IZetboxContext ctx, ObjectClass cls)
        {
            if (_host == null) { throw new global::System.ArgumentNullException("_host"); }

            _host.CallTemplate("ObjectClasses.AttachToContextTemplate", ctx, cls);
        }

        public AttachToContextTemplate(Arebis.CodeGeneration.IGenerationHost _host, IZetboxContext ctx, ObjectClass cls)
            : base(_host)
        {
			this.ctx = ctx;
			this.cls = cls;

        }

        public override void Generate()
        {
#line 30 "P:\zetbox\Zetbox.Generator\Templates\ObjectClasses\AttachToContextTemplate.cst"
this.WriteObjects("\r\n");
this.WriteObjects("        public override void AttachToContext(IZetboxContext ctx, Func<IFrozenContext> lazyFrozenContext)\r\n");
this.WriteObjects("        {\r\n");
this.WriteObjects("            base.AttachToContext(ctx, lazyFrozenContext);\r\n");
#line 35 "P:\zetbox\Zetbox.Generator\Templates\ObjectClasses\AttachToContextTemplate.cst"
// TODO: Remove this
            foreach(var prop in cls.Properties.OfType<ValueTypeProperty>().Where(p => p.IsList).OrderBy(p => p.Name))
            {

#line 39 "P:\zetbox\Zetbox.Generator\Templates\ObjectClasses\AttachToContextTemplate.cst"
this.WriteObjects("            if (_",  prop.Name , "Collection != null)\r\n");
this.WriteObjects("                _",  prop.Name , "Collection.ForEach<IPersistenceObject>(i => ctx.Attach(i));\r\n");
#line 42 "P:\zetbox\Zetbox.Generator\Templates\ObjectClasses\AttachToContextTemplate.cst"
}

            foreach(var prop in cls.Properties.OfType<CompoundObjectProperty>().Where(p => p.IsList).OrderBy(p => p.Name))
            {

#line 47 "P:\zetbox\Zetbox.Generator\Templates\ObjectClasses\AttachToContextTemplate.cst"
this.WriteObjects("            if (_",  prop.Name , "Collection != null)\r\n");
this.WriteObjects("                _",  prop.Name , "Collection.ForEach<IPersistenceObject>(i => ctx.Attach(i));\r\n");
#line 50 "P:\zetbox\Zetbox.Generator\Templates\ObjectClasses\AttachToContextTemplate.cst"
}

#line 52 "P:\zetbox\Zetbox.Generator\Templates\ObjectClasses\AttachToContextTemplate.cst"
this.WriteObjects("        }\r\n");

        }

    }
}