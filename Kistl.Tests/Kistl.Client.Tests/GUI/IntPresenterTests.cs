using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

using Kistl.Client.Mocks;
using Kistl.GUI.DB;
using Kistl.GUI.Mocks;

namespace Kistl.GUI.Tests
{
    [TestFixture]
    public class IntPresenterTests : NullablePresenterTests<TestObject, int, TestIntControl, IntPresenter>
    {
        public IntPresenterTests()
            : base(
                new PresenterHarness<TestObject, TestIntControl, IntPresenter>(
                    new TestObjectHarness(),
                    new ControlHarness<TestIntControl>(TestObject.TestIntVisual, Toolkit.TEST)))
        { }

        protected override int? GetObjectValue() { return Object.TestInt; }
        protected override int? GetWidgetValue() { return Widget.Value; }
        protected override void SetObjectValue(int? v) { Object.TestInt = v; }
        protected override void UserInput(int? v) { Widget.SimulateUserInput(v); }
        protected override IEnumerable<int> SomeValues()
        {
            return new List<int>(new[] {
                Int16.MinValue, Int16.MaxValue,
                Int32.MinValue, Int32.MaxValue,
                Int16.MinValue + 1, Int16.MaxValue + 1,
                Int16.MinValue - 1, Int16.MaxValue - 1,
                Int32.MinValue + 1, Int32.MaxValue - 1,
                0, +1, -1, 100, 123, 200, 6000
            });
        }
    }
}
