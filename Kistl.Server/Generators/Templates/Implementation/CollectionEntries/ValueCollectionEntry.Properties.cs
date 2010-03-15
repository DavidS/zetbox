using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kistl.API;
using Kistl.App.Base;
using Kistl.Server.Generators.Extensions;

namespace Kistl.Server.Generators.Templates.Implementation.CollectionEntries
{
    public partial class ValueCollectionEntry
    {
        protected override void ApplyAPropertyTemplate()
        {
            ApplyParentReferencePropertyTemplate(this.prop, "A");

            // TODO: Move to implementation
            this.WriteLine("public {0} Parent {{ get {{ return A; }} set {{ A = value; }} }}", this.prop.ObjectClass.Name);
        }

        protected override void ApplyBPropertyTemplate()
        {
            ApplyValuePropertyTemplate(this.prop, "B");

            // TODO: Move to implementation
            this.WriteLine("public {0} Value {{ get {{ return B; }} set {{ B = value; }} }}", this.prop.ReferencedTypeAsCSharp());
        }

        protected abstract void ApplyParentReferencePropertyTemplate(Property prop, string propertyName);

        protected virtual void ApplyValuePropertyTemplate(Property p, string propertyName)
        {
            if (p is EnumerationProperty)
            {
                ApplyEnumerationPropertyTemplate((EnumerationProperty)p, propertyName);
            }
            else if (p is CompoundObjectProperty)
            {
                ApplyCompoundObjectPropertyTemplate((CompoundObjectProperty)p, propertyName);
            }
            else if (p is ValueTypeProperty)
            {
                ApplyValueTypePropertyTemplate((ValueTypeProperty)p, propertyName);
            }
        }

        protected virtual void ApplyEnumerationPropertyTemplate(EnumerationProperty prop, string propertyName)
        {
            this.WriteLine("        // enumeration property");
            ApplyNotifyingValueProperty(this.MembersToSerialize, prop.ReferencedTypeAsCSharp(), propertyName);
        }

        protected virtual void ApplyCompoundObjectPropertyTemplate(CompoundObjectProperty prop, string propertyName)
        {
            this.WriteLine("        // CompoundObject property");
            ApplyNotifyingValueProperty(this.MembersToSerialize, prop.ReferencedTypeAsCSharp(), propertyName);
        }

        protected virtual void ApplyValueTypePropertyTemplate(ValueTypeProperty prop, string propertyName)
        {
            this.WriteLine("        // value type property");
            ApplyNotifyingValueProperty(this.MembersToSerialize, prop.ReferencedTypeAsCSharp(), propertyName);
        }

        protected virtual void ApplyNotifyingValueProperty(SerializationMembersList serList, string typeRef, string propertyName)
        {
            Templates.Implementation.ObjectClasses.NotifyingValueProperty.Call(Host, ctx,
                serList,
                typeRef,
                propertyName, this.prop.Module.Namespace);
        }

        protected override void ApplyAIndexPropertyTemplate()
        {
            this.WriteLine("/// always ignored because the other side (a value) cannot have a navigator and therefore no order");
            this.WriteObjects("int? ", GetCeInterface(), ".AIndex { get { return null; } set { } }");
            this.WriteLine();
        }

    }
}
