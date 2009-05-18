using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kistl.App.Base;

namespace Kistl.Server.Generators.EntityFramework.Implementation.EfModel
{
    public partial class ModelSsdl
    {
        protected virtual void ApplyEntityTypeColumnDefs(IEnumerable<Property> properties)
        {
            Implementation.EfModel.ModelSsdlEntityTypeColumns.Call(Host, ctx, properties, "");
        }
    }
}
