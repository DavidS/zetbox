// This file is part of zetbox.
//
// Zetbox is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation, either version 3 of
// the License, or (at your option) any later version.
//
// Zetbox is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with zetbox.  If not, see <http://www.gnu.org/licenses/>.

namespace Zetbox.API.Server.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using NUnit.Framework;
    using NUnit.Framework.Constraints;

    public class DboRefTests
    {
        [Datapoints]
        public static readonly DboRef[] testValues = new DboRef[] {
            null,
            
            new TableRef("db", null, null),
            new TableRef(null, "schema", null),
            new TableRef(null, null, "tbl"),
            new TableRef(null, "schema", "tbl"),
            new TableRef("db", null, "tbl"),
            new TableRef("db", "schema", null),
            new TableRef("db", "schema", "tbl"),

            new ProcRef("db", null, null),
            new ProcRef(null, "schema", null),
            new ProcRef(null, null, "proc"),
            new ProcRef(null, "schema", "proc"),
            new ProcRef("db", null, "proc"),
            new ProcRef("db", "schema", null),
            new ProcRef("db", "schema", "proc"),

            new ConstraintRef("db", null, null),
            new ConstraintRef(null, "schema", null),
            new ConstraintRef(null, null, "cstr"),
            new ConstraintRef(null, "schema", "cstr"),
            new ConstraintRef("db", null, "cstr"),
            new ConstraintRef("db", "schema", null),
            new ConstraintRef("db", "schema", "cstr"),

            new TriggerRef("db", null, null),
            new TriggerRef(null, "schema", null),
            new TriggerRef(null, null, "trg"),
            new TriggerRef(null, "schema", "trg"),
            new TriggerRef("db", null, "trg"),
            new TriggerRef("db", "schema", null),
            new TriggerRef("db", "schema", "trg"),
        };

        [Theory]
        public void EqualsIsReflective(DboRef name)
        {
            Assert.That(name, Is.EqualTo(name), "Doesn't equal self");
            if (name != null)
            {
                Assert.That(name, Is.EqualTo((DboRef)((ICloneable)name).Clone()), "Doesn't equal cloned instance");
            }
        }

        [Theory]
        public void DoubleEqualsIsReflectiveAndSymmetric(DboRef name)
        {
            var same = name;
            Assert.That(name == same, Is.True, "Failed name == same comparison1: {0}", name);
            Assert.That(same == name, Is.True, "Failed same == name comparison2: {0}", name);
            if (name != null)
            {
                var clone = (DboRef)((ICloneable)name).Clone();
                Assert.That(name == clone, Is.True, "Failed name == clone comparison1: {0}", name);
                Assert.That(clone == name, Is.True, "Failed clone == name comparison2: {0}", name);
            }
        }

        [Theory]
        public void CompareToIsReflective(DboRef name)
        {
            Assume.That(name, Is.Not.Null);
            
            var clone = (DboRef)((ICloneable)name).Clone();

            Assert.That(((IComparable<DboRef>)name).CompareTo(name), Is.EqualTo(0));
            Assert.That(((IComparable<DboRef>)name).CompareTo(clone), Is.EqualTo(0), "name.CompareTo(clone) failed");
            Assert.That(((IComparable<DboRef>)clone).CompareTo(name), Is.EqualTo(0), "clone.CompareTo(name) failed");
        }

        /// <summary>
        /// A < B
        /// </summary>
        public class LessThanComparison
        {
            public LessThanComparison(DboRef a, DboRef b)
            {
                _a = a;
                _b = b;
            }
            private readonly DboRef _a;
            public DboRef A { get { return _a; } }
            private readonly DboRef _b;
            public DboRef B { get { return _b; } }
            public override string ToString()
            {
                return String.Format("A={0} should be less than B={1}", A, B);
            }
        }

        public static readonly TableRef[] ascendingValues = new TableRef[] {
            new TableRef(null, null, null),
            new TableRef(null, null, "tbl"),
            new TableRef(null, "schema", null),
            new TableRef(null, "schema", "tbl"),
            new TableRef("dbo", null, null),
            new TableRef("dbo", null, "tbl"),
            new TableRef("dbo", "schema", null),
            new TableRef("dbo", "schema", "tbl"),
            new TableRef("dbo", "schema", "z"),
            new TableRef("dbo", "y", "z"),
            new TableRef("x", "y", "z"),
        };

        public static IEnumerable<LessThanComparison> DboRefTestCases()
        {
            var pos = 0;
            foreach (var first in ascendingValues)
            {
                pos += 1;
                foreach (var second in ascendingValues.Skip(pos))
                {
                    yield return new LessThanComparison(first, second);
                }
            }
        }

        [Test]
        [TestCaseSource("DboRefTestCases")]
        public void ComparisonsA(LessThanComparison test)
        {
            Assume.That(test.A, Is.Not.Null);
            Assert.That(test.A, Is.LessThan(test.B));
            Assert.That(test.A, Is.Not.EqualTo(test.B));
        }

        [Test]
        [TestCaseSource("DboRefTestCases")]
        public void ComparisonsB(LessThanComparison test)
        {
            Assume.That(test.B, Is.Not.Null);
            Assert.That(test.B, Is.GreaterThan(test.A));
            Assert.That(test.B, Is.Not.EqualTo(test.A));
        }
    }
}
