
namespace Kistl.API.Server.Tests.BinarySerializers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;

    using NUnit.Framework;

    public interface CompoundObjectMock : ICompoundObject
    {
    }

    public class CompoundObjectMockImpl : BaseServerCompoundObject
    {
        public CompoundObjectMockImpl() : base(null) { }

        public override Type GetImplementedInterface()
        {
            return typeof(CompoundObjectMock);
        }
    }

    [TestFixture]
    public class should_work_with_BaseServerCompoundObjects
        : Kistl.API.AbstractConsumerTests.BinarySerializers.should_work_with_ICompoundObjects<CompoundObjectMockImpl>
    {
    }
}
