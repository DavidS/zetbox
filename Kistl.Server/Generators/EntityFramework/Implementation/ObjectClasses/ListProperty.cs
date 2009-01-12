using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kistl.App.Base;
using Kistl.Server.Generators.Extensions;

namespace Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses
{
    public class ListProperty : Kistl.Server.Generators.Templates.Implementation.ObjectClasses.ListProperty
    {
        public ListProperty(Arebis.CodeGeneration.IGenerationHost _host, DataType containingType, Type type, String name, Property property)
            : base(_host, containingType, type, name, property)
        {
        }

        protected override void ApplyRequisitesTemplate()
        {
            base.ApplyRequisitesTemplate();
            CallTemplate("Implementation.ObjectClasses.EfListWrapper", containingType, type, name, property);
        }

        protected override void ApplyAttributesTemplate()
        {
            base.ApplyAttributesTemplate();

            // duplicate code from Model.csdl.EntityTypeFields.cst
        }
    }
}
