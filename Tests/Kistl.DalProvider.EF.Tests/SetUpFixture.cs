
namespace Kistl.DalProvider.EF.Tests
{
    using System;
    using System.Collections.Generic;

    using Autofac;

    using Kistl.API;
    using Kistl.API.Configuration;
    using Kistl.App.Base;
    using Kistl.App.Projekte;
    using Kistl.DalProvider.EF.Mocks;
    using Kistl.Server;

    using NUnit.Framework;

    [SetUpFixture]
    public class SetUpFixture
        : Kistl.API.AbstractConsumerTests.DatabaseResetup
    {

        protected override void SetupBuilder(ContainerBuilder builder)
        {
            base.SetupBuilder(builder);
            builder.RegisterModule(new Kistl.API.ApiModule());
            builder.RegisterModule(new Kistl.API.Server.ServerApiModule());
            builder.RegisterModule(new Kistl.Server.ServerModule());
            builder.RegisterModule(new Kistl.DalProvider.EF.EfProvider());
            builder.RegisterModule(new Kistl.DalProvider.Memory.MemoryProvider());
            builder.RegisterModule(new Kistl.Objects.EFModule());
            builder.RegisterModule(new Kistl.Objects.MemoryModule());
        }

        protected override void SetUp(IContainer container)
        {
            base.SetUp(container);
            ResetDatabase(container.Resolve<KistlConfig>());

            Property__Implementation__.OnToString_Property
                += (obj, args) => { args.Result = String.Format("Prop, [{0}]", obj.Description); };
            Mitarbeiter__Implementation__.OnToString_Mitarbeiter
                += (obj, args) => { args.Result = String.Format("MA, [{0}]", obj.Name); };
            Projekt__Implementation__.OnToString_Projekt
                += (obj, args) => { args.Result = String.Format("Proj, [{0}]", obj.Name); };
        }

        protected override string GetConfigFile()
        {
            return "Kistl.DalProvider.EF.Tests.Config.xml";
        }

        protected override HostType GetHostType()
        {
            return HostType.Server;
        }
    }
}
