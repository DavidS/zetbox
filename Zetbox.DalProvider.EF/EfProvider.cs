// This file is part of zetbox.
//
// Zetbox is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation, either version 3 of
// the License, or (at your option) any later version.
//
// Zetbox is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with zetbox.  If not, see <http://www.gnu.org/licenses/>.

namespace Zetbox.DalProvider.Ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using Autofac;
    using Autofac.Core;
    using Zetbox.API;
    using Zetbox.API.Common;
    using Zetbox.API.Configuration;
    using Zetbox.API.Server;
    using Zetbox.API.Server.PerfCounter;
    using Zetbox.API.Utils;

    public interface IEfActionsManager : ICustomActionsManager { }

    [Feature]
    [Description("Entity Framework (EF) provider")]
    public class EfProvider
        : Autofac.Module
    {
        internal static readonly string ServerAssembly = "Zetbox.Objects.EfImpl";

        private static readonly object _lock = new object();

        protected override void Load(ContainerBuilder moduleBuilder)
        {
            base.Load(moduleBuilder);

            moduleBuilder
                .Register(c =>
                {
                    // EF's meta data initialization is not thread-safe
                    lock (_lock)
                    {
                        var cfg = c.Resolve<ZetboxConfig>();
                        return new EfDataContext(
                            c.Resolve<IMetaDataResolver>(),
                            null,
                            cfg,
                            c.Resolve<Func<IFrozenContext>>(),
                            c.Resolve<InterfaceType.Factory>(),
                            c.Resolve<EfImplementationType.EfFactory>(),
                            c.Resolve<IPerfCounter>(),
                            c.ResolveNamed<ISqlErrorTranslator>(cfg.Server.GetConnectionString(Zetbox.API.Helper.ZetboxConnectionStringKey).SchemaProvider),
                            c.Resolve<IEnumerable<IZetboxContextEventListener>>()
                            );
                    }
                })
                .As<IZetboxServerContext>()
                .OnActivated(args =>
                {
                    var manager = args.Context.Resolve<IEfActionsManager>();
                    manager.Init(args.Context.Resolve<IFrozenContext>());
                })
                .InstancePerDependency();

            moduleBuilder
                .Register((c, p) =>
                {
                    // EF's meta data initialization is not thread-safe
                    lock (_lock)
                    {
                        var param = p.OfType<ConstantParameter>().FirstOrDefault();
                        var cfg = c.Resolve<ZetboxConfig>();
                        return new EfDataContext(
                            c.Resolve<IMetaDataResolver>(),
                            param != null ? (Zetbox.App.Base.Identity)param.Value : c.Resolve<IIdentityResolver>().GetCurrent(),
                            cfg,
                            c.Resolve<Func<IFrozenContext>>(),
                            c.Resolve<InterfaceType.Factory>(),
                            c.Resolve<EfImplementationType.EfFactory>(),
                            c.Resolve<IPerfCounter>(),
                            c.ResolveNamed<ISqlErrorTranslator>(cfg.Server.GetConnectionString(Zetbox.API.Helper.ZetboxConnectionStringKey).SchemaProvider),
                            c.Resolve<IEnumerable<IZetboxContextEventListener>>()
                            );
                    }
                })
                .As<IZetboxContext>()
                .OnActivated(args =>
                {
                    var manager = args.Context.Resolve<IEfActionsManager>();
                    manager.Init(args.Context.Resolve<IFrozenContext>());

                    ZetboxContextEventListenerHelper.OnCreated(args.Context.Resolve<IEnumerable<IZetboxContextEventListener>>(), args.Instance);
                })
                .InstancePerDependency();

            moduleBuilder
                .Register(c =>
                {
                    // EF's meta data initialization is not thread-safe
                    lock (_lock)
                    {
                        var cfg = c.Resolve<ZetboxConfig>();
                        var result = new EfDataContext(
                            c.Resolve<CachingMetaDataResolver>(),
                            null,
                            cfg,
                            c.Resolve<Func<IFrozenContext>>(),
                            c.Resolve<InterfaceType.Factory>(),
                            c.Resolve<EfImplementationType.EfFactory>(),
                            c.Resolve<IPerfCounter>(),
                            c.ResolveNamed<ISqlErrorTranslator>(cfg.Server.GetConnectionString(Zetbox.API.Helper.ZetboxConnectionStringKey).SchemaProvider),
                            c.Resolve<IEnumerable<IZetboxContextEventListener>>()
                            );
                        return result;
                    }
                })
                .As<IReadOnlyZetboxContext>()
                .OnActivated(args =>
                {
                    var manager = args.Context.Resolve<IEfActionsManager>();
                    manager.Init(args.Context.Resolve<IFrozenContext>());

                    ZetboxContextEventListenerHelper.OnCreated(args.Context.Resolve<IEnumerable<IZetboxContextEventListener>>(), args.Instance);
                })
                .InstancePerDependency();

            moduleBuilder
                .Register(c => new EfServerObjectHandlerFactory(c.ResolveOptional<Zetbox.API.Server.Fulltext.LuceneSearchDeps>()))
                .As<IServerObjectHandlerFactory>();

            moduleBuilder.RegisterType<EfImplementationType>();

            moduleBuilder.RegisterModule((Autofac.Module)Activator.CreateInstance(Type.GetType("Zetbox.Objects.EfModule, Zetbox.Objects.EfImpl", true)));
        }
    }
}
