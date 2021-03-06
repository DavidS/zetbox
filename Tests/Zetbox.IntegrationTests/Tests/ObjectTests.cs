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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Zetbox.API;
using Zetbox.API.Client;
using Zetbox.App.Base;
using Zetbox.App.Projekte;
using Zetbox.Client;

using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Zetbox.IntegrationTests
{
    [TestFixture]
    public class ObjectTests : AbstractIntegrationTestFixture
    {
        private const string ProjectName1 = "Project 1";
        private const string ProjectName2 = "Project 2";
        private const int Project1TaskCount = 10;
        private const int Project2TaskCount = 5;
        private const int TaskCount = Project1TaskCount + Project2TaskCount;

        private int Project1ID = -1;
        private int Project2ID = -1;

        public override void SetUp()
        {
            base.SetUp();
            DeleteObjects();

            using (IZetboxContext ctx = GetContext())
            {
                Projekt prj1 = ctx.Create<Projekt>();
                prj1.Name = ProjectName1;

                Projekt prj2 = ctx.Create<Projekt>();
                prj2.Name = ProjectName2;

                for (int i = 0; i < Project1TaskCount; i++)
                {
                    SetUpCreateTask(ctx, prj1, i);
                }

                for (int i = 0; i < Project2TaskCount; i++)
                {
                    SetUpCreateTask(ctx, prj2, i);
                }

                ctx.SubmitChanges();

                Project1ID = prj1.ID;
                Project2ID = prj2.ID;
                Console.WriteLine("Workaround for mono: {0}, {1}", Project1ID, Project2ID);
            }
        }

        private void SetUpCreateTask(IZetboxContext ctx, Projekt prj, int i)
        {
            Task t = ctx.Create<Task>();
            t.Name = prj.Name + " - Task " + (i + 1);
            t.DatumVon = DateTime.Today.AddDays(i);
            t.DatumBis = DateTime.Today.AddDays(2 * i);
            t.Aufwand = (i + 1);
            prj.Tasks.Add(t);
        }


        public override void TearDown()
        {
            DeleteObjects();
            base.TearDown();
        }

        private void DeleteObjects()
        {
            using (IZetboxContext ctx = GetContext())
            {
                // TODO: remove obj.Mitarbeiter.Clear() after fixing Case 1369 and marking the Mitarbeiter RelationEnd properly
                ctx.GetQuery<Projekt>().ForEach(obj => { obj.Mitarbeiter.Clear(); ctx.Delete(obj); });
                ctx.GetQuery<Task>().ForEach(obj => ctx.Delete(obj));
                ctx.SubmitChanges();
            }
        }

        [Test]
        public void GetOneObject()
        {
            using (IZetboxContext ctx = GetContext())
            {
                var obj = ctx.GetQuery<Projekt>().Single(o => o.ID == Project1ID);
                Assert.That(obj.Name, Is.EqualTo(ProjectName1));
            }
        }

        [Test]
        public void GetObject_Twice()
        {
            using (IZetboxContext ctx = GetContext())
            {
                var obj1a = ctx.GetQuery<Projekt>().Single(o => o.ID == Project1ID);
                Assert.That(obj1a.Name, Is.EqualTo(ProjectName1));

                var obj1b = ctx.GetQuery<Projekt>().Single(o => o.ID == Project1ID);
                Assert.That(obj1b.Name, Is.EqualTo(ProjectName1));

                var obj2 = ctx.GetQuery<Projekt>().Single(o => o.ID == Project2ID);
                Assert.That(obj2.Name, Is.EqualTo(ProjectName2));

                Assert.That(obj1a, Is.SameAs(obj1b), "Context return two Objects for one thing");
                Assert.That(obj1a, Is.Not.SameAs(obj2), "Context return one Object for different things");
                Assert.That(obj1b, Is.Not.SameAs(obj2), "Context return one Object for different things");
            }
        }

        [Test]
        public void GetListOf()
        {
            using (IZetboxContext ctx = GetContext())
            {
                var list = ctx.GetQuery<Projekt>();
                int count = 0;
                foreach (Projekt prj in list)
                {
                    count += prj.Tasks.Count;
                }
                Assert.That(count, Is.EqualTo(TaskCount));
            }
        }

        [Test]
        public void SetObject()
        {
            double aufwand;
            int ID;
            using (IZetboxContext ctx = GetContext())
            {
                var list = ctx.GetQuery<Task>().ToList();
                Assert.That(list.Count, Is.GreaterThan(0));
                var obj = list[0];

                ID = obj.ID;
                aufwand = (obj.Aufwand ?? 0.0) + 1.0;

                obj.Aufwand = aufwand;

                ctx.SubmitChanges();
            }

            using (IZetboxContext checkctx = GetContext())
            {
                var obj = checkctx.GetQuery<Task>().Single(o => o.ID == ID);
                Assert.That(obj, Is.Not.Null);
                Assert.That(obj.Aufwand, Is.EqualTo(aufwand));
            }
        }

        [Test]
        public void NewObject()
        {
            int ID;
            double aufwand = 1.0;
            DateTime datum = DateTime.Now;
            Projekt p;
            using (IZetboxContext ctx = GetContext())
            {
                p = ctx.GetQuery<Projekt>().First(prj => prj.Name == ProjectName1);
                var obj = ctx.Create<Task>();

                obj.Name = "NUnit Test Task";
                obj.Aufwand = aufwand;
                obj.DatumVon = datum;
                obj.DatumBis = datum.AddDays(1);
                obj.Projekt = p;

                ctx.SubmitChanges();
                ID = obj.ID;
                Assert.That(ID, Is.Not.EqualTo(Zetbox.API.Helper.INVALIDID));
            }

            using (IZetboxContext checkctx = GetContext())
            {
                var obj = checkctx.GetQuery<Task>().Single(o => o.ID == ID);
                Assert.That(obj, Is.Not.Null);
                Assert.That(obj.Aufwand, Is.EqualTo(aufwand));
                Assert.That(obj.Projekt.ID, Is.EqualTo(p.ID));
            }
        }
    }
}
