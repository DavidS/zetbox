using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kistl.API;

using NUnit.Framework;

namespace Kistl.DalProvider.EF.Tests.N_to_M_relations
{

    [TestFixture]
    public class should_synchronize 
        : Kistl.API.AbstractConsumerTests.N_to_M_relations.should_synchronize
    {
        protected override IKistlContext GetContext()
        {
            return KistlContext.GetContext();
        }
    }

}
