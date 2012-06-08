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
    public class ModelMslEntityTypeMappingScalarProperty : Zetbox.Generator.ResourceTemplate
    {
        protected IZetboxContext ctx;
        protected Property prop;
        protected string propertyName;
        protected string parentName;

        public static void Call(IGenerationHost host, IZetboxContext ctx, Property prop, string propertyName, string parentName)
        {
            if (host == null) { throw new ArgumentNullException("host"); }

            host.CallTemplate("EfModel.ModelMslEntityTypeMappingScalarProperty", ctx, prop, propertyName, parentName);
        }

        public ModelMslEntityTypeMappingScalarProperty(Arebis.CodeGeneration.IGenerationHost _host, IZetboxContext ctx, Property prop, string propertyName, string parentName)
            : base(_host)
        {
            this.ctx = ctx;
            this.prop = prop;
            this.propertyName = propertyName;
            this.parentName = parentName;
        }

        public override void Generate()
        {
            string columnName;
            string name = propertyName;

            if (prop is EnumerationProperty)
            {
                columnName = Construct.NestedColumnName(prop, parentName);
                name += ImplementationPropertySuffix;
            }
            else if (prop is ValueTypeProperty)
            {
                columnName = Construct.NestedColumnName(prop, parentName);
            }
            else if (prop is ObjectReferenceProperty)
            {
                throw new ArgumentOutOfRangeException("prop", "cannot apply ObjectReferenceProperty as scalar");
            }
            else
            {
                return;
            }

            this.WriteLine("<ScalarProperty Name=\"{0}\" ColumnName=\"{1}\" />", name, columnName);
        }
    }
}
