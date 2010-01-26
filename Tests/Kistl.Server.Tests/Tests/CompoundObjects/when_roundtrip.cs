using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using Kistl.API;
using Kistl.App.Test;

using NUnit.Framework;
using Autofac;

namespace Kistl.Server.Tests.CompoundObjects
{
    [TestFixture]
    public class when_roundtrip
        : Kistl.API.AbstractConsumerTests.CompoundObjects.when_roundtrip
    {
        private IContainer container;
        private IContainer GetContainer()
        {
            if (container == null)
            {
                container = Kistl.Server.Tests.SetUp.CreateInnerContainer();
            }
            return container;
        }

        public override void DisposeContext()
        {
            base.DisposeContext();
            if (container != null)
            {
                container.Dispose();
                container = null;
            }
        }

        public override IKistlContext GetContext()
        {
            return GetContainer().Resolve<IKistlContext>();
        }
    }
}
