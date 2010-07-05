
namespace Kistl.DalProvider.EF
{
    using System;
    using System.Collections.Generic;
    using System.Data.Objects;
    using System.Linq;
    using System.Text;

    using Kistl.API.Configuration;
    using Kistl.API.Utils;

    internal sealed class EFObjectContext : ObjectContext
    {
        public EFObjectContext(KistlConfig config)
            : base(BuildConnectionString(config), "Entities")
        {
        }

        /// <summary>
        /// Creates the Connectionstring.
        /// <remarks>Format is: metadata=res://*;provider={provider};provider connection string='{Provider Connectionstring}'</remarks>
        /// </summary>
        /// <returns></returns>
        private static string BuildConnectionString(KistlConfig config)
        {
            // Build connectionString
            // metadata=res://*;provider=System.Data.SqlClient;provider connection string='Data Source=.\SQLEXPRESS;Initial Catalog=Kistl;Integrated Security=True;MultipleActiveResultSets=true;'
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("metadata=res://*/Kistl.Objects.Server.Model.csdl|res://*/Kistl.Objects.Server.Model.msl|res://*/Kistl.Objects.Server.Model.{0}.ssdl;", config.Server.SchemaProvider);
            sb.AppendFormat("provider={0};", config.Server.DatabaseProvider);
            sb.AppendFormat("provider connection string='{0}'", config.Server.ConnectionString);

            return sb.ToString();
        }
    }
}
