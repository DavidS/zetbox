// <autogenerated/>

namespace Kistl.Objects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Autofac;
    using Kistl.API;
    using Kistl.App.Extensions;
    using Kistl.DalProvider.EF;

    public class EFModule
        : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder
                .Register<EFImplementationTypeChecker>(
                    c => new EFImplementationTypeChecker(
                        c.Resolve<Func<IEnumerable<IImplementationTypeChecker>>>()))
                .As<IEFImplementationTypeChecker>()
                .As<IImplementationTypeChecker>()
                .InstancePerDependency();
                
            builder
                .Register<EFActionsManager>(
                    c => new EFActionsManager(
                        c.Resolve<IDeploymentRestrictor>()))
                .As<IEFActionsManager>()
                .InstancePerLifetimeScope();
        }
    }

    internal sealed class EFImplementationTypeChecker
        : BaseImplementationTypeChecker, IEFImplementationTypeChecker
    {
        public EFImplementationTypeChecker(Func<IEnumerable<IImplementationTypeChecker>> implTypeCheckersFactory)
            : base(implTypeCheckersFactory)
        {
        }

        protected override System.Reflection.Assembly GetAssembly()
        {
            return this.GetType().Assembly;
        }
    }

    // marker class to provide stable and correct assembly reference
    internal sealed class EFActionsManager
        : BaseCustomActionsManager, IEFActionsManager
    {
        public EFActionsManager(IDeploymentRestrictor restrictor)
            : base(restrictor, "")
        {
        }
    }
}
