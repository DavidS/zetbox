
namespace Zetbox.DalProvider.Ef.Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Autofac;
    using Zetbox.Generator;

    public sealed class EfGeneratorProvider
        : Module
    {
        protected override void Load(ContainerBuilder moduleBuilder)
        {
            base.Load(moduleBuilder);

            moduleBuilder
                .RegisterType<Generator.EntityFrameworkGenerator>()
                .As<AbstractBaseGenerator>()
                .SingleInstance();
        }
    }
}
