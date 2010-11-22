
namespace Kistl.Generator.Templates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public partial class Module
    {
        protected virtual IEnumerable<string> GetAdditionalImports()
        {
            return RequiredNamespaces
                .Concat(new string[]{
                    "Kistl.App.Extensions"
                });
        }

        protected virtual void ApplyRegistrations()
        {
            Registrations.Call(Host, ctx, shortName);
        }
    }
}
