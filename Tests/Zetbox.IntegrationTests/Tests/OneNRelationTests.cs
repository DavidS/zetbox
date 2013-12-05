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

namespace Zetbox.IntegrationTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Zetbox.API;
    using Zetbox.API.Client;
    using Zetbox.API.Tests;
    using Zetbox.App.Base;
    using Zetbox.App.GUI;
    using Zetbox.DalProvider.Base.RelationWrappers;
    using NUnit.Framework;

    [TestFixture(0)]
    [TestFixture(1)]
    [TestFixture(5)]
    public sealed class BasicOneNRelationTests
        : BasicListTests<OneNRelationList<Property>, Property>
    {
        private Guid _fixtureGuid;
        private Guid _moduleGuid;
        private Guid _valueDescGuid;
        private Guid _otherClassGuid;

        private ObjectClass _parent;
        private bool _hasCollectionChanged;
        private bool _hasParentChanged;

        public BasicOneNRelationTests(int items)
            : base(items) { }

        private void SetupFixtureObject()
        {
            using (var initCtx = GetContext())
            {
                _moduleGuid = initCtx.GetQuery<Module>().Single(m => m.Name == "ZetboxBase").ExportGuid;
                _valueDescGuid = initCtx.GetQuery<ViewModelDescriptor>().First().ExportGuid;

                var fixtureOC = initCtx.GetQuery<ObjectClass>().FirstOrDefault(oc => oc.Properties.Count == items)
                    ?? initCtx.GetQuery<ObjectClass>().FirstOrDefault(oc => oc.Properties.Count > items)
                    ?? (ObjectClass)Zetbox.NamedObjects.Base.Classes.Zetbox.App.Test.TestObjClass.Find(initCtx);

                _fixtureGuid = fixtureOC.ExportGuid;
                var otherClass = initCtx.GetQuery<ObjectClass>().First(oc => oc.ExportGuid != _fixtureGuid);
                _otherClassGuid = otherClass.ExportGuid;

                while (fixtureOC.Properties.Count < items)
                {
                    fixtureOC.Properties.Add(CreateProperty(initCtx, NewItemNumber()));
                }

                while (fixtureOC.Properties.Count > items)
                {
                    fixtureOC.Properties[fixtureOC.Properties.Count - 1].ObjectClass = otherClass;
                }

                Assert.That(fixtureOC.Properties.Count, Is.EqualTo(items));
                initCtx.SubmitChanges();
            }
        }

        protected override void PreSetup()
        {
            SetupFixtureObject();

            _parent = ctx.FindPersistenceObject<ObjectClass>(_fixtureGuid);
            Assert.That(_parent.Properties.Count, Is.EqualTo(items));

            base.PreSetup();
        }

        protected override void PostTeardown()
        {
            base.PostTeardown();
        }

        protected override Property NewItem()
        {
            return CreateProperty(ctx, NewItemNumber());
        }

        private Property CreateProperty(IZetboxContext ctx, int unique)
        {
            var result = ctx.Create<IntProperty>();
            result.Module = ctx.FindPersistenceObject<Module>(_moduleGuid);
            result.Name = "property" + unique;
            result.ValueModelDescriptor = ctx.FindPersistenceObject<ViewModelDescriptor>(_valueDescGuid);
            return result;
        }

        protected override OneNRelationList<Property> CreateCollection(List<Property> items)
        {
            var result = (OneNRelationList<Property>)_parent.Properties;

            _hasCollectionChanged = false;
            result.CollectionChanged += (sender, args) => { _hasCollectionChanged = true; };

            _hasParentChanged = false;
            _parent.PropertyChanged += (sender, args) => { if (args.PropertyName == "Properties") { _hasParentChanged = true; } };

            // nothing should have changed yet!
            Assert.That(ctx.AttachedObjects.Select(p => p.ObjectState).Distinct().ToArray(), Is.All.EqualTo(DataObjectState.Unmodified));

            return result;
        }

        protected override List<Property> InitialItems()
        {
            return _parent.Properties.ToList();
        }

        protected override void AssertCollectionIsChanged()
        {
            base.AssertCollectionIsChanged();
            Assert.That(_hasCollectionChanged, "Collection was not notified");
            _hasCollectionChanged = false;

            Assert.That(_hasParentChanged, "Parent was not notified");
            _hasParentChanged = false;

            Assert.That(_parent.ObjectState, Is.EqualTo(DataObjectState.Unmodified).Or.EqualTo(DataObjectState.New));
            Assert.That(ctx.AttachedObjects.OfType<Property>().Select(p => p.ObjectState).Distinct().ToArray(), Is.Empty.Or.Member(DataObjectState.Modified).Or.Member(DataObjectState.New));
        }

        protected override void AssertCollectionIsUnchanged()
        {
            base.AssertCollectionIsUnchanged();
            Assert.That(!_hasCollectionChanged, "Collection was notified falsely");
            _hasCollectionChanged = false;

            Assert.That(!_hasParentChanged, "Parent was notified falsely");
            _hasParentChanged = false;
        }

        protected override void AssertInvariants(List<Property> expectedItems)
        {
            base.AssertInvariants(expectedItems);

            // we also expect the collection to be stable, i.e. not change the order of the items
            Assert.That(collection, Is.EquivalentTo(expectedItems));

            foreach (var expected in expectedItems)
            {
                //Assert.That(expected.OneSide, Is.SameAs(obj));
                Assert.That(expected.GetPrivateFieldValue<int?>("__fk_ObjectClassCache"), Is.EqualTo(_parent.ID), "__fk_ObjectClassCache");
                Assert.That(expected.GetPrivateFieldValue<int?>("_Properties_pos"), Is.Not.Null, "_Properties_pos");
            }

            Assert.That(collection.Select(p => p.GetPrivateFieldValue<int?>("_Properties_pos")).ToArray(), Is.Ordered, "_Properties_pos Is.Ordered");

            ////////////////////// test roundtripping //////////////////////////////////

            var otherClass = ctx.FindPersistenceObject<ObjectClass>(_otherClassGuid);
            // first shunt unattached properties to another object class to get a valid data model
            foreach (var prop in ctx.AttachedObjects.OfType<Property>().Where(p => p.ObjectClass == null))
            {
                prop.ObjectClass = otherClass;
            }

            // then, save the stuff to the database
            ctx.SubmitChanges();

            // finally, check remaining properties for them being properly roundtripped
            var propertyNames = collection.Select(p => p.Name).ToArray();
            using (var checkCtx = GetContext())
            {
                var checkParent = checkCtx.FindPersistenceObject<ObjectClass>(_fixtureGuid);
                Assert.That(checkParent.Properties.Select(p => p.Name).ToArray(), Is.EquivalentTo(propertyNames));
            }
        }
    }

    [TestFixture(0)]
    [TestFixture(1)]
    [TestFixture(5)]
    public sealed class GenericOneNRelationTests
        : GenericListTests<OneNRelationList<Property>, Property>
    {
        private Guid _fixtureGuid;
        private Guid _moduleGuid;
        private Guid _valueDescGuid;
        private Guid _otherClassGuid;

        private ObjectClass _parent;
        private bool _hasCollectionChanged;
        private bool _hasParentChanged;

        public GenericOneNRelationTests(int items)
            : base(items) { }

        private void SetupFixtureObject()
        {
            using (var initCtx = GetContext())
            {
                _moduleGuid = initCtx.GetQuery<Module>().Single(m => m.Name == "ZetboxBase").ExportGuid;
                _valueDescGuid = initCtx.GetQuery<ViewModelDescriptor>().First().ExportGuid;

                var fixtureOC = initCtx.GetQuery<ObjectClass>().FirstOrDefault(oc => oc.Properties.Count == items);
                if (fixtureOC == null)
                {
                    fixtureOC = (ObjectClass)Zetbox.NamedObjects.Base.Classes.Zetbox.App.Test.TestObjClass.Find(initCtx);
                }

                while (fixtureOC.Properties.Count < items)
                {
                    fixtureOC.Properties.Add(CreateProperty(initCtx, NewItemNumber()));
                }

                while (fixtureOC.Properties.Count > items)
                {
                    var propToDelete = fixtureOC.Properties[fixtureOC.Properties.Count - 1];
                    fixtureOC.Properties.Remove(propToDelete);
                    initCtx.Delete(propToDelete);
                }

                Assert.That(fixtureOC.Properties.Count, Is.EqualTo(items));
                initCtx.SubmitChanges();

                _fixtureGuid = fixtureOC.ExportGuid;
                _otherClassGuid = initCtx.GetQuery<ObjectClass>().First(oc => oc.ExportGuid != _fixtureGuid).ExportGuid;
            }
        }

        protected override void PreSetup()
        {
            SetupFixtureObject();

            _parent = ctx.FindPersistenceObject<ObjectClass>(_fixtureGuid);
            Assert.That(_parent.Properties.Count, Is.EqualTo(items));

            base.PreSetup();
        }

        protected override void PostTeardown()
        {
            base.PostTeardown();
        }

        protected override Property NewItem()
        {
            return CreateProperty(ctx, NewItemNumber());
        }

        private Property CreateProperty(IZetboxContext ctx, int unique)
        {
            var result = ctx.Create<IntProperty>();
            result.Module = ctx.FindPersistenceObject<Module>(_moduleGuid);
            result.Name = "property" + unique;
            result.ValueModelDescriptor = ctx.FindPersistenceObject<ViewModelDescriptor>(_valueDescGuid);
            return result;
        }

        protected override OneNRelationList<Property> CreateCollection(List<Property> items)
        {
            var result = (OneNRelationList<Property>)_parent.Properties;

            _hasCollectionChanged = false;
            result.CollectionChanged += (sender, args) => { _hasCollectionChanged = true; };

            _hasParentChanged = false;
            _parent.PropertyChanged += (sender, args) => { if (args.PropertyName == "Properties") { _hasParentChanged = true; } };

            // nothing should have changed yet!
            Assert.That(ctx.AttachedObjects.Select(p => p.ObjectState).Distinct().ToArray(), Is.All.EqualTo(DataObjectState.Unmodified));

            return result;
        }

        protected override List<Property> InitialItems()
        {
            return _parent.Properties.ToList();
        }

        protected override void AssertCollectionIsChanged()
        {
            base.AssertCollectionIsChanged();
            Assert.That(_hasCollectionChanged, "Collection was not notified");
            _hasCollectionChanged = false;

            Assert.That(_hasParentChanged, "Parent was not notified");
            _hasParentChanged = false;

            Assert.That(_parent.ObjectState, Is.EqualTo(DataObjectState.Unmodified).Or.EqualTo(DataObjectState.New));
            Assert.That(ctx.AttachedObjects.OfType<Property>().Select(p => p.ObjectState).Distinct().ToArray(), Is.Empty.Or.Member(DataObjectState.Modified).Or.Member(DataObjectState.New));
        }

        protected override void AssertCollectionIsUnchanged()
        {
            base.AssertCollectionIsUnchanged();
            Assert.That(!_hasCollectionChanged, "Collection was notified falsely");
            _hasCollectionChanged = false;

            Assert.That(!_hasParentChanged, "Parent was notified falsely");
            _hasParentChanged = false;
        }

        protected override void AssertInvariants(List<Property> expectedItems)
        {
            base.AssertInvariants(expectedItems);

            // we also expect the collection to be stable, i.e. not change the order of the items
            Assert.That(collection, Is.EquivalentTo(expectedItems));

            foreach (var expected in expectedItems)
            {
                //Assert.That(expected.OneSide, Is.SameAs(obj));
                Assert.That(expected.GetPrivateFieldValue<int?>("__fk_ObjectClassCache"), Is.EqualTo(_parent.ID), "__fk_ObjectClassCache");
                Assert.That(expected.GetPrivateFieldValue<int?>("_Properties_pos"), Is.Not.Null, "_Properties_pos");
            }

            Assert.That(collection.Select(p => p.GetPrivateFieldValue<int?>("_Properties_pos")).ToArray(), Is.Ordered, "_Properties_pos Is.Ordered");

            ////////////////////// test roundtripping //////////////////////////////////

            var otherClass = ctx.FindPersistenceObject<ObjectClass>(_otherClassGuid);
            // first shunt unattached properties to another object class to get a valid data model
            foreach (var prop in ctx.AttachedObjects.OfType<Property>().Where(p => p.ObjectClass == null))
            {
                prop.ObjectClass = otherClass;
            }

            // then, save the stuff to the database
            ctx.SubmitChanges();

            // finally, check remaining properties for them being properly roundtripped
            var propertyNames = collection.Select(p => p.Name).ToArray();
            using (var checkCtx = GetContext())
            {
                var checkParent = checkCtx.FindPersistenceObject<ObjectClass>(_fixtureGuid);
                Assert.That(checkParent.Properties.Select(p => p.Name).ToArray(), Is.EquivalentTo(propertyNames));
            }
        }
    }
}