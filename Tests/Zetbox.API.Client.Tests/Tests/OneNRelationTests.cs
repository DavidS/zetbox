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

namespace Zetbox.API.Client.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Zetbox.API;
    using Zetbox.API.Client.Mocks.OneNLists;
    using Zetbox.API.Tests;
    using Zetbox.DalProvider.Base.RelationWrappers;
    using NUnit.Framework;

    [TestFixture(0)]
    [TestFixture(1)]
    [TestFixture(10)]
    [TestFixture(50)]
    public sealed class BasicOneNRelationTests
        : BasicListTests<OneNRelationList<INSide>, INSide>
    {
        private OneSide _parent;
        private bool _hasCollectionChanged;
        private bool _hasParentChanged;
        
        private OneNRelationList<INSide> Wrapper { get { return _parent.List; } }

        public BasicOneNRelationTests(int items)
            : base(items) { }

        protected override INSide NewItem()
        {
            var id = NewItemNumber();
            return new NSide() { ID = id, Description = "item#" + id };
        }

        protected override OneNRelationList<INSide> CreateCollection(List<INSide> items)
        {
            _parent = new OneSide(items.ToList());
            for (int i = 0; i < items.Count; i++)
            {
                var item = (NSide)items[i];
                item.OneSide = _parent;
                item.OneSide_pos = i * 10;
            }

            _hasCollectionChanged = false;
            Wrapper.CollectionChanged += (sender, args) => { _hasCollectionChanged = true; };

            _hasParentChanged = false;
            _parent.PropertyChanged += (sender, args) => { if (args.PropertyName == "NSide") { _hasParentChanged = true; } };

            return Wrapper;
        }

        protected override void AssertCollectionIsChanged()
        {
            base.AssertCollectionIsChanged();
            Assert.That(_hasCollectionChanged, "Collection was not notified");
            _hasCollectionChanged = false;

            Assert.That(_hasParentChanged, "Parent was not notified");
            _hasParentChanged = false;
        }

        protected override void AssertCollectionIsUnchanged()
        {
            base.AssertCollectionIsUnchanged();
            Assert.That(!_hasCollectionChanged, "Collection was notified falsely");
            _hasCollectionChanged = false;

            Assert.That(!_hasParentChanged, "Parent was notified falsely");
            _hasParentChanged = false;
        }

        protected override void AssertInvariants(List<INSide> expectedItems)
        {
            base.AssertInvariants(expectedItems);

            // we also expect the collection to be stable, i.e. not change the order of the items
            Assert.That(collection, Is.EquivalentTo(expectedItems));

            foreach (var expected in expectedItems.Cast<NSide>())
            {
                //Assert.That(expected.OneSide, Is.SameAs(obj));
                Assert.That(expected.LastParentId, Is.EqualTo(_parent.ID));
                Assert.That(expected.OneSide_pos, Is.Not.Null);
            }

            Assert.That(collection.OfType<NSide>().Select(ns => ns.OneSide_pos).ToArray(), Is.Ordered);
        }
    }

    [TestFixture(0)]
    [TestFixture(1)]
    [TestFixture(10)]
    [TestFixture(50)]
    public sealed class GenericOneNRelationTests
        : GenericListTests<OneNRelationList<INSide>, INSide>
    {
        private OneSide _parent;
        private bool _hasCollectionChanged;
        private bool _hasParentChanged;

        private OneNRelationList<INSide> wrapper { get { return _parent.List; } }

        public GenericOneNRelationTests(int items)
            : base(items) { }

        protected override INSide NewItem()
        {
            var id = NewItemNumber();
            return new NSide() { ID = id, Description = "item#" + id };
        }

        protected override OneNRelationList<INSide> CreateCollection(List<INSide> items)
        {
            _parent = new OneSide(items.ToList());
            for (int i = 0; i < items.Count; i++)
            {
                var item = (NSide)items[i];
                item.OneSide = _parent;
                item.OneSide_pos = i * 10;
            }

            _hasCollectionChanged = false;
            wrapper.CollectionChanged += (sender, args) => { _hasCollectionChanged = true; };

            _hasParentChanged = false;
            _parent.PropertyChanged += (sender, args) => { if (args.PropertyName == "NSide") { _hasParentChanged = true; } };

            return wrapper;
        }

        protected override void AssertCollectionIsChanged()
        {
            base.AssertCollectionIsChanged();
            Assert.That(_hasCollectionChanged, "Collection was not notified");
            _hasCollectionChanged = false;

            Assert.That(_hasParentChanged, "Parent was not notified");
            _hasParentChanged = false;
        }

        protected override void AssertCollectionIsUnchanged()
        {
            base.AssertCollectionIsUnchanged();
            Assert.That(!_hasCollectionChanged, "Collection was notified falsely");
            _hasCollectionChanged = false;

            Assert.That(!_hasParentChanged, "Parent was notified falsely");
            _hasParentChanged = false;
        }

        protected override void AssertInvariants(List<INSide> expectedItems)
        {
            base.AssertInvariants(expectedItems);

            // we also expect the collection to be stable, i.e. not change the order of the items
            Assert.That(collection, Is.EquivalentTo(expectedItems));

            foreach (var expected in expectedItems.Cast<NSide>())
            {
                //Assert.That(expected.OneSide, Is.SameAs(obj));
                Assert.That(expected.LastParentId, Is.EqualTo(_parent.ID));
                Assert.That(expected.OneSide_pos, Is.Not.Null);
            }

            Assert.That(collection.OfType<NSide>().Select(ns => ns.OneSide_pos).ToArray(), Is.Ordered);
        }
    }
}
