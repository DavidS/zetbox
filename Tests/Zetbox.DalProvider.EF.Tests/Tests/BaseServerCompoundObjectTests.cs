
namespace Zetbox.DalProvider.Ef.Tests
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using Zetbox.API;
    using Zetbox.API.Tests.Skeletons;
    using Zetbox.App.Test;
    using Zetbox.DalProvider.Ef;
    using Zetbox.DalProvider.Ef.Mocks;
    using NUnit.Framework;

    [TestFixture]
    public class BaseServerCompoundObjectTests
        : IStreamableTests<TestPhoneCompoundObjectEfImpl>
    {
        TestCustomObjectEfImpl parent;
        TestPhoneCompoundObjectEfImpl attachedObj;

        [SetUp]
        public void SetUpTestObject()
        {
            obj = new TestPhoneCompoundObjectEfImpl(false, null, null) { AreaCode = "ABC", Number = "123456" };

            parent = new TestCustomObjectEfImpl(null);
            attachedObj = (TestPhoneCompoundObjectEfImpl)parent.PhoneNumberOffice;
            attachedObj.AreaCode = "attachedAreaCode";
            attachedObj.Number = "attachedNumber";
        }

        [Test]
        public void should_roudtrip_members_correctly()
        {
            var result = this.SerializationRoundtrip(obj);

            Assert.That(result.AreaCode, Is.EqualTo(obj.AreaCode));
            Assert.That(result.Number, Is.EqualTo(obj.Number));
        }
    }
}
