using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.IO;
using Kistl.API.Mocks;

namespace Kistl.API.Tests.BaseStructObjects
{

    [TestFixture]
    public class should_serialize
    {

        MemoryStream ms;
        BinaryWriter sw;
        BinaryReader sr;

        TestStruct__Implementation__ test;

        [SetUp]
        public void SetUp()
        {
            ms = new MemoryStream();
            sw = new BinaryWriter(ms);
            sr = new BinaryReader(ms);
            var testCtx = new TestApplicationContext();

            test = new TestStruct__Implementation__();
        }

        /// <summary>
        /// Rewinds all streams to their start
        /// </summary>
        private void RewindStreams()
        {
            ms.Seek(0, SeekOrigin.Begin);
        }

        [Test]
        public void without_exceptions()
        {
            test.ToStream(sw);
            RewindStreams();
            Assert.DoesNotThrow(() =>
            {
                test.FromStream(sr);
            });
        }

        // just test the mock
        [Test]
        public void and_keep_TestProperty()
        {
            const string val = "muh";
            test.TestProperty = val;
            test.ToStream(sw);
            test.TestProperty = null;
            
            RewindStreams();

            test.FromStream(sr);

            Assert.That(test.TestProperty, Is.EqualTo(val), "To/FromStream of the mock didn't transport TestProperty");
        }

    }

}
