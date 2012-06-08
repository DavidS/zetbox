
namespace Zetbox.DalProvider.Memory
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using Autofac;
    using Autofac.Core;
    using Zetbox.API;
    using Zetbox.API.Configuration;
    using Zetbox.API.Utils;
    using Zetbox.App.Extensions;
    using Zetbox.App.Packaging;

    public sealed class MemoryDatabaseProvider
        : Autofac.Module
    {
        // private readonly static log4net.ILog Log = log4net.LogManager.GetLogger("Zetbox.DalProvider.Memory");
        private readonly static object _lock = new object();

        protected override void Load(ContainerBuilder moduleBuilder)
        {
            base.Load(moduleBuilder);

            moduleBuilder
                .Register(c =>
                {
                    lock (_lock)
                    {
                        var result = new MemoryContext(
                            c.Resolve<InterfaceType.Factory>(),
                            c.Resolve<Func<IFrozenContext>>(),
                            c.Resolve<MemoryImplementationType.MemoryFactory>()
                            );

                        return result;
                    }
                })
                .As<IReadOnlyZetboxContext>()
                .As<IZetboxContext>()
                .OnActivated(args =>
                {
                    var config = args.Context.Resolve<ZetboxConfig>();
                    var connectionString = config.Server.GetConnectionString(Helper.ZetboxConnectionStringKey);
                    Importer.LoadFromXml(args.Instance, connectionString.ConnectionString);

                    var manager = args.Context.Resolve<IMemoryActionsManager>();
                    manager.Init(args.Instance);
                })
                .InstancePerDependency();
        }
    }
}
