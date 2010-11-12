using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Kistl.API;
using Kistl.App.Base;
using Kistl.App.Extensions;
using Kistl.Server.Generators.Extensions;

namespace Kistl.Server.Generators.ClientObjects.Implementation.ObjectClasses
{
    public class Template
        : Templates.Implementation.ObjectClasses.Template
    {

        public Template(Arebis.CodeGeneration.IGenerationHost _host, IKistlContext ctx, ObjectClass cls)
            : base(_host, ctx, cls)
        {
        }

        protected override string GetBaseClass()
        {
            if (this.ObjectClass.BaseObjectClass != null)
            {
                return MungeClassName(base.GetBaseClass());
            }
            else
            {
                return "BaseClientDataObject_ClientObjects";
            }
        }

        protected override void ApplyObjectReferencePropertyTemplate(ObjectReferenceProperty prop)
        {
            //var rel = RelationExtensions.Lookup(ctx, prop);

            //Debug.Assert(rel.A.Navigator.ID == prop.ID || rel.B.Navigator.ID == prop.ID);
            //var relEnd = rel.GetEnd(prop);
            //var otherEnd = rel.GetOtherEnd(relEnd);

            this.WriteLine("        // object reference property");
            Implementation.ObjectClasses.ObjectReferencePropertyTemplate.Call(
                Host, ctx, this.MembersToSerialize,
                prop, true, true);
        }

        protected override void ApplyCompoundObjectPropertyTemplate(CompoundObjectProperty prop)
        {
            this.WriteLine("        // CompoundObject property");
            Implementation.ObjectClasses.CompoundObjectPropertyTemplate.Call(Host, ctx, MembersToSerialize, prop, prop.Name);
        }
        protected override void ApplyCompoundObjectListTemplate(CompoundObjectProperty prop)
        {
            this.WriteLine("        // CompoundObject list property");
            Implementation.ObjectClasses.ValueCollectionProperty.Call(Host, ctx,
                this.MembersToSerialize,
                prop);
        }

        protected override void ApplyObjectListPropertyTemplate(Relation rel, RelationEndRole endRole)
        {
            Implementation.ObjectClasses.ObjectListProperty.Call(Host, ctx,
                 this.MembersToSerialize,
                 rel.GetEndFromRole(endRole).Navigator as ObjectReferenceProperty);
        }

        protected override void ApplyValueTypeListTemplate(ValueTypeProperty prop)
        {
            this.WriteLine("        // value list property");
            Implementation.ObjectClasses.ValueCollectionProperty.Call(Host, ctx, MembersToSerialize, prop);
        }

        protected override void ApplyConstructorTemplate()
        {
            base.ApplyConstructorTemplate();
            this.WriteObjects("            {");
            this.WriteLine();
            foreach (var prop in DataType.Properties.OfType<CompoundObjectProperty>().Where(p => !p.IsList).OrderBy(p => p.Name))
            {
                if (prop.IsNullable()) continue;

                string name = prop.Name;
                string backingName = name + ImplementationPropertySuffix;
                string coType = prop.GetPropertyTypeString();
                string coImplementationType = coType + ImplementationSuffix;
                this.WriteObjects("                ", backingName, " = new ", coImplementationType, "(this, \"", name, "\");");
                this.WriteLine();
            }
            this.WriteObjects("            }");
            this.WriteLine();
        }

        protected override void ApplyAttachToContextMethod()
        {
            base.ApplyAttachToContextMethod();
            Implementation.ObjectClasses.AttachToContextTemplate.Call(Host, ctx, ObjectClass);
        }

        protected override void ApplyClassTailTemplate()
        {
            base.ApplyClassTailTemplate();
            Implementation.ObjectClasses.UpdateParentTemplate.Call(Host, ctx, DataType);
        }
    }
}
