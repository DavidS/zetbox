using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Kistl.API;

namespace Kistl.DalProvider.EF.Tests.Blobs
{
    [TestFixture]
    [Ignore("This test suite does not support custom actions")]
    public class when_using
            : Kistl.API.AbstractConsumerTests.Blobs.when_using
    {
        public override IKistlContext GetContext()
        {
            return GetContext();
        }
    }
}
