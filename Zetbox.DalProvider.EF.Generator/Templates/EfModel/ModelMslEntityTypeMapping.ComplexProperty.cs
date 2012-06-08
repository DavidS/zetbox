using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zetbox.API;
using Zetbox.App.Base;
using Zetbox.Generator;
using Arebis.CodeGeneration;

namespace Zetbox.DalProvider.Ef.Generator.Templates.EfModel
{
    public class ModelMslEntityTypeMappingComplexProperty : Zetbox.Generator.ResourceTemplate
    {
        protected IZetboxContext ctx;
        protected CompoundObjectProperty prop;
        protected string propertyName;
        protected string parentName;

        public static void Call(IGenerationHost host, IZetboxContext ctx, Property prop, string propertyName, string parentName)
        {
            if (host == null) { throw new ArgumentNullException("host"); }

            host.CallTemplate("EfModel.ModelMslEntityTypeMappingComplexProperty", ctx, prop, propertyName, parentName);
        }

        public ModelMslEntityTypeMappingComplexProperty(Arebis.CodeGeneration.IGenerationHost _host, IZetboxContext ctx, CompoundObjectProperty prop, string propertyName, string parentName)
            : base(_host)
        {
            this.ctx = ctx;
            this.prop = prop;
            this.propertyName = propertyName;
            this.parentName = parentName;
        }

        public override void Generate()
        {
            this.WriteLine("<ComplexProperty Name=\"{0}{1}\" TypeName=\"Model.{2}\">",
                propertyName,
                ImplementationPropertySuffix,
                prop.CompoundObjectDefinition.Name
                );

            this.WriteLine("  <ScalarProperty Name=\"CompoundObject_IsNull\" ColumnName=\"{0}\" />", Construct.NestedColumnName(prop, parentName));

            string newParent = Construct.NestedColumnName(prop, parentName);
            foreach (var subProp in prop.CompoundObjectDefinition.Properties.OfType<ValueTypeProperty>().Where(p => !p.IsList).OrderBy(p => p.Name))
            {
                ModelMslEntityTypeMappingScalarProperty.Call(Host, ctx, subProp, subProp.Name, newParent);
            }

            foreach (var subProp in prop.CompoundObjectDefinition.Properties.OfType<CompoundObjectProperty>().Where(p => !p.IsList).OrderBy(p => p.Name))
            {
                ModelMslEntityTypeMappingComplexProperty.Call(Host, ctx, subProp, subProp.Name, newParent);
            }

            this.WriteLine("</ComplexProperty>");
        }
    }
}
