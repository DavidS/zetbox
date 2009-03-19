using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

using Kistl.API.Mocks;

using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Kistl.API.Tests
{
    [TestFixture]
    public class HelperTest
    {
        TestDataObject obj;

        [SetUp]
        public void SetUp()
        {
            obj = new TestDataObject__Implementation__() { BoolProperty = true, IntProperty = 1, StringProperty = "test" };
        }

        [Test]
        public void IsFloatingObjectTest()
        {
            Assert.That(Helper.IsFloatingObject(obj), Is.EqualTo(true));
            ((TestDataObject__Implementation__)obj).ID = 1;
            obj.AttachToContext(new TestKistlContext());
            Assert.That(Helper.IsFloatingObject(obj), Is.EqualTo(false));
        }

        [Test]
        public void IsPersistedObject()
        {
            Assert.That(Helper.IsPersistedObject(obj), Is.EqualTo(false));
            ((TestDataObject__Implementation__)obj).ID = 1;
            obj.AttachToContext(new TestKistlContext());
            Assert.That(Helper.IsPersistedObject(obj), Is.EqualTo(true));
        }
    }
}
