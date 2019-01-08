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

namespace Zetbox.Server.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Autofac;

    using Zetbox.API;
    using Zetbox.API.Server;
    using Zetbox.App.Projekte;
    using Zetbox.Server;

    using NUnit.Framework;
    using NUnit.Framework.Constraints;

    [TestFixture]
    public class ObjectTests : AbstractServerTestFixture
    {
        private IZetboxContext ctx;

        public override void SetUp()
        {
            base.SetUp();
            var setupCtx = GetContext();

            var ma1 = setupCtx.Create<Mitarbeiter>();
            ma1.Geburtstag = new DateTime(1970, 10, 22);
            ma1.Name = "Testmitarbeiter Blaha";

            var ma2 = setupCtx.Create<Mitarbeiter>();
            ma2.Geburtstag = new DateTime(1971, 9, 23);
            ma2.Name = "Testmitarbeiter Foobar";

            var prj1 = setupCtx.Create<Projekt>();
            prj1.Name = "blubb";
            prj1.KickOffAm = DateTime.Today;
            prj1.Von = DateTime.Today;

            var prj2 = setupCtx.Create<Projekt>();
            prj2.Name = "flubb";
            prj2.KickOffAm = DateTime.Today;
            prj2.Von = DateTime.Today;
            var task1 = setupCtx.Create<Task>();
            task1.Projekt = prj2;
            task1.Name = "Task1";
            task1.Aufwand = 1;
            task1.DatumVon = DateTime.Today;

            var task2 = setupCtx.Create<Task>();
            task2.Projekt = prj2;
            task2.Name = "Task2";
            task2.Aufwand = 1;
            task2.DatumVon = DateTime.Today;

            setupCtx.SubmitChanges();

            prj1.Mitarbeiter.Add(ma1);
            prj1.Mitarbeiter.Add(ma2);
            prj2.Mitarbeiter.Add(ma1);

            setupCtx.SubmitChanges();

            ctx = GetContext();
        }

        public override void TearDown()
        {
            var deleteCtx = GetContext();
            deleteCtx.GetQuery<Task>().ForEach(obj => deleteCtx.Delete(obj));
            deleteCtx.SubmitChanges();

            deleteCtx = GetContext();
            deleteCtx.GetQuery<Projekt>().ForEach(obj => { obj.Mitarbeiter.Clear(); obj.Tasks.Clear(); deleteCtx.Delete(obj); });
            deleteCtx.SubmitChanges();
            
            deleteCtx = GetContext();
            deleteCtx.GetQuery<Mitarbeiter>().ForEach(obj => deleteCtx.Delete(obj));
            deleteCtx.SubmitChanges();
        }

        [Test]
        public void GetObject()
        {
            var obj = ctx.GetQuery<Zetbox.App.Projekte.Projekt>().First(o => o.Name == "blubb");
            Assert.That(obj.Name, Is.EqualTo("blubb"));
        }

        [Test]
        public void GetObject_Twice()
        {
            var obj1 = ctx.GetQuery<Zetbox.App.Projekte.Projekt>().First(o => o.Name == "blubb");
            Assert.That(obj1.Name, Is.EqualTo("blubb"));

            var obj2 = ctx.GetQuery<Zetbox.App.Projekte.Projekt>().First(o => o.Name == "blubb");
            Assert.That(obj2.Name, Is.EqualTo("blubb"));

            Assert.That(object.ReferenceEquals(obj1, obj2), "Obj1 & Obj2 are different Objects");
        }

        [Test]
        public void GetListOf()
        {
            var list = ctx.GetQuery<Zetbox.App.Projekte.Projekt>();
            int count = 0;
            foreach (Zetbox.App.Projekte.Projekt prj in list)
            {
                count += prj.Tasks.Count;
            }
            Assert.That(count, Is.GreaterThan(0));
        }

        [Test]
        public void GetListOf_List()
        {
            var list = ctx.GetQuery<Zetbox.App.Projekte.Mitarbeiter>();
            int count = 0;
            foreach (Zetbox.App.Projekte.Mitarbeiter ma in list)
            {
                count += ma.Projekte.Count;
            }
            Assert.That(count, Is.GreaterThan(0));
        }

        [Test]
        public void SetObject()
        {
            double aufwand;
            int ID;
            var list = ctx.GetQuery<Zetbox.App.Projekte.Task>().ToList();
            Assert.That(list.Count, Is.GreaterThan(0));
            var obj = list[0];

            ID = obj.ID;
            aufwand = (obj.Aufwand ?? 0.0) + 1.0;

            obj.Aufwand = aufwand;

            ctx.SubmitChanges();

            IZetboxContext checkctx = GetContext();
            var checkObj = checkctx.GetQuery<Zetbox.App.Projekte.Task>().First(o => o.ID == ID);
            Assert.That(checkObj, Is.Not.Null);
            Assert.That(checkObj.Aufwand, Is.EqualTo(aufwand));
        }

        [Test]
        public void NewObject()
        {
            int ID;
            double aufwand = 1.0;
            DateTime datum = DateTime.Now;
            Zetbox.App.Projekte.Projekt p;
            p = ctx.GetQuery<Zetbox.App.Projekte.Projekt>().ToList()[0];
            var obj = ctx.Create<Zetbox.App.Projekte.Task>();

            obj.Name = "NUnit Test Task";
            obj.Aufwand = aufwand;
            obj.DatumVon = datum;
            obj.DatumBis = datum.AddDays(1);
            obj.Projekt = p;

            ctx.SubmitChanges();
            ID = obj.ID;
            Assert.That(ID, Is.Not.EqualTo(Zetbox.API.Helper.INVALIDID));

            IZetboxContext checkctx = GetContext();
            var checkObj = checkctx.GetQuery<Zetbox.App.Projekte.Task>().First(o => o.ID == ID);
            Assert.That(checkObj, Is.Not.Null);
            Assert.That(checkObj.Aufwand, Is.EqualTo(aufwand));
            Assert.That(checkObj.Projekt.ID, Is.EqualTo(p.ID));
        }
    }
}
