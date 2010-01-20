using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kistl.API.AbstractConsumerTests;

using NUnit.Framework;

namespace Kistl.DalProvider.EF.Tests
{
    [TestFixture]
    public class ListPropertiesTests
        : AbstractListPropertiesTests
    {
        protected override Kistl.API.IKistlContext GetContext()
        {
            return KistlContext.GetContext();
        }
    }
}
