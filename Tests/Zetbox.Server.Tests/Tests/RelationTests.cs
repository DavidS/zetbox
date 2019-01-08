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

using Autofac;

using Zetbox.API;
using Zetbox.API.Server;
using Zetbox.App.Projekte;

using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Zetbox.Server.Tests
{
    [TestFixture]
    public class RelationTests : AbstractServerTestFixture
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

            setupCtx.SubmitChanges();

            prj2.Mitarbeiter.Add(ma1);
            prj1.Mitarbeiter.Add(ma1);
            prj1.Mitarbeiter.Add(ma2);
            setupCtx.SubmitChanges();

            ctx = GetContext();
        }

        public override void TearDown()
        {
            var deleteCtx = GetContext();
            deleteCtx.GetQuery<Mitarbeiter>().ForEach(obj => deleteCtx.Delete(obj));
            deleteCtx.GetQuery<Projekt>().ForEach(obj => { obj.Mitarbeiter.Clear(); deleteCtx.Delete(obj); });
        }

        #region Set Relation once

        #region 1:n
        [Test]
        public void Relation_1_n_Set_1()
        {
            var prj = ctx.Create<Zetbox.App.Projekte.Projekt>();
            Assert.That(prj.Tasks, Is.Not.Null);
            Assert.That(prj.Tasks.Count, Is.EqualTo(0));

            var task = ctx.Create<Zetbox.App.Projekte.Task>();
            Assert.That(task.Projekt, Is.Null);

            task.Projekt = prj;

            Assert.That(task.Projekt, Is.Not.Null);
            Assert.That(prj.Tasks.Count, Is.EqualTo(1));
            Assert.That(prj.Tasks.First(), Is.SameAs(task));
        }

        [Test]
        public void Relation_1_n_Set_n()
        {
            var prj = ctx.Create<Zetbox.App.Projekte.Projekt>();
            Assert.That(prj.Tasks, Is.Not.Null);
            Assert.That(prj.Tasks.Count, Is.EqualTo(0));

            var task = ctx.Create<Zetbox.App.Projekte.Task>();
            Assert.That(task.Projekt, Is.Null);

            prj.Tasks.Add(task);

            Assert.That(task.Projekt, Is.Not.Null);
            Assert.That(prj.Tasks.Count, Is.EqualTo(1));
            Assert.That(prj.Tasks.First(), Is.SameAs(task));
        }
        #endregion

        #region n:m
        [Test]
        public void Relation_n_m_Set_n()
        {
            var prj = ctx.Create<Zetbox.App.Projekte.Projekt>();
            Assert.That(prj.Mitarbeiter, Is.Not.Null);
            Assert.That(prj.Mitarbeiter.Count, Is.EqualTo(0));

            var ma = ctx.Create<Zetbox.App.Projekte.Mitarbeiter>();
            Assert.That(ma.Projekte, Is.Not.Null);
            Assert.That(ma.Projekte.Count, Is.EqualTo(0));

            prj.Mitarbeiter.Add(ma);

            Assert.That(prj.Mitarbeiter.Count, Is.EqualTo(1));
            Assert.That(prj.Mitarbeiter.First(), Is.SameAs(ma));
            Assert.That(ma.Projekte.Count, Is.EqualTo(1));
            Assert.That(ma.Projekte.First(), Is.SameAs(prj));
        }

        [Test]
        public void Relation_n_m_Set_m()
        {
            var prj = ctx.Create<Zetbox.App.Projekte.Projekt>();
            Assert.That(prj.Mitarbeiter, Is.Not.Null);
            Assert.That(prj.Mitarbeiter.Count, Is.EqualTo(0));

            var ma = ctx.Create<Zetbox.App.Projekte.Mitarbeiter>();
            Assert.That(ma.Projekte, Is.Not.Null);
            Assert.That(ma.Projekte.Count, Is.EqualTo(0));

            ma.Projekte.Add(prj);

            Assert.That(prj.Mitarbeiter.Count, Is.EqualTo(1));
            Assert.That(prj.Mitarbeiter.First(), Is.SameAs(ma));
            Assert.That(ma.Projekte.Count, Is.EqualTo(1));
            Assert.That(ma.Projekte.First(), Is.SameAs(prj));
        }
        #endregion

        //#region 1:1
        //[Test]
        //public void Relation_1_1_Set_Left()
        //{
        //    using (IZetboxContext ctx = GetContext())
        //    {
        //        var rel = ctx.Create<Zetbox.App.Base.Relation>();
        //        Assert.That(rel.LeftPart, Is.Null);

        //        var prop = ctx.Create<Zetbox.App.Base.ObjectReferenceProperty>();
        //        Assert.That(prop.LeftOf, Is.Null);

        //        rel.LeftPart = prop;

        //        Assert.That(rel.LeftPart, Is.SameAs(prop));
        //        Assert.That(prop.LeftOf, Is.SameAs(rel));
        //    }
        //}

        //[Test]
        //public void Relation_1_1_Set_Right()
        //{
        //    using (IZetboxContext ctx = GetContext())
        //    {
        //        var rel = ctx.Create<Zetbox.App.Base.Relation>();
        //        Assert.That(rel.LeftPart, Is.Null);

        //        var prop = ctx.Create<Zetbox.App.Base.ObjectReferenceProperty>();
        //        Assert.That(prop.LeftOf, Is.Null);

        //        prop.LeftOf = rel;

        //        Assert.That(rel.LeftPart, Is.SameAs(prop));
        //        Assert.That(prop.LeftOf, Is.SameAs(rel));
        //    }
        //}
        //#endregion

        #endregion

        #region Change Relation

        #region 1:n
        [Test]
        public void Change_Relation_1_n_Set_1()
        {
            var prj = ctx.Create<Zetbox.App.Projekte.Projekt>();
            var prj2 = ctx.Create<Zetbox.App.Projekte.Projekt>();
            var task = ctx.Create<Zetbox.App.Projekte.Task>();

            task.Projekt = prj;

            Assert.That(task.Projekt, Is.Not.Null);
            Assert.That(prj.Tasks.Count, Is.EqualTo(1));
            Assert.That(prj.Tasks.First(), Is.SameAs(task));

            task.Projekt = prj2;

            Assert.That(task.Projekt, Is.Not.Null);
            Assert.That(prj.Tasks.Count, Is.EqualTo(0));
            Assert.That(prj2.Tasks.Count, Is.EqualTo(1));
            Assert.That(prj2.Tasks.First(), Is.SameAs(task));
        }

        [Test]
        public void Change_Relation_1_n_Set_n_With_Remove()
        {
            var prj = ctx.Create<Zetbox.App.Projekte.Projekt>();
            var task = ctx.Create<Zetbox.App.Projekte.Task>();
            var task2 = ctx.Create<Zetbox.App.Projekte.Task>();

            prj.Tasks.Add(task);

            Assert.That(task.Projekt, Is.Not.Null);
            Assert.That(prj.Tasks.Count, Is.EqualTo(1));
            Assert.That(prj.Tasks.First(), Is.SameAs(task));

            prj.Tasks.Remove(task);
            prj.Tasks.Add(task2);

            Assert.That(task.Projekt, Is.Null);
            Assert.That(task2.Projekt, Is.Not.Null);
            Assert.That(prj.Tasks.Count, Is.EqualTo(1));
            Assert.That(prj.Tasks.First(), Is.SameAs(task2));
        }

        [Test]
        public void Change_Relation_1_n_Set_n_With_Clear()
        {
            var prj = ctx.Create<Zetbox.App.Projekte.Projekt>();
            var task = ctx.Create<Zetbox.App.Projekte.Task>();
            var task2 = ctx.Create<Zetbox.App.Projekte.Task>();

            prj.Tasks.Add(task);

            Assert.That(task.Projekt, Is.Not.Null);
            Assert.That(prj.Tasks.Count, Is.EqualTo(1));
            Assert.That(prj.Tasks.First(), Is.SameAs(task));

            prj.Tasks.Clear();
            prj.Tasks.Add(task2);

            Assert.That(task.Projekt, Is.Null);
            Assert.That(task2.Projekt, Is.Not.Null);
            Assert.That(prj.Tasks.Count, Is.EqualTo(1));
            Assert.That(prj.Tasks.First(), Is.SameAs(task2));
        }
        [Test]
        public void Change_Relation_1_n_Set_n_By_Index()
        {
            var m = ctx.Create<Zetbox.App.Base.Method>();
            var p = ctx.Create<Zetbox.App.Base.StringParameter>();
            var p2 = ctx.Create<Zetbox.App.Base.BoolParameter>();

            m.Parameter.Add(p);

            Assert.That(p.Method, Is.Not.Null);
            Assert.That(m.Parameter.Count, Is.EqualTo(1));
            Assert.That(m.Parameter.First(), Is.SameAs(p));

            m.Parameter[0] = p2;

            Assert.That(p.Method, Is.Null);
            Assert.That(p2.Method, Is.Not.Null);
            Assert.That(m.Parameter.Count, Is.EqualTo(1));
            Assert.That(m.Parameter.First(), Is.SameAs(p2));
        }
        #endregion

        #region n:m
        [Test]
        public void Change_Relation_n_m_Set_n_With_Remove()
        {
            var prj = ctx.Create<Zetbox.App.Projekte.Projekt>();
            var ma = ctx.Create<Zetbox.App.Projekte.Mitarbeiter>();
            var ma2 = ctx.Create<Zetbox.App.Projekte.Mitarbeiter>();

            prj.Mitarbeiter.Add(ma);

            Assert.That(prj.Mitarbeiter.Count, Is.EqualTo(1));
            Assert.That(prj.Mitarbeiter.First(), Is.SameAs(ma));
            Assert.That(ma.Projekte.Count, Is.EqualTo(1));
            Assert.That(ma.Projekte.First(), Is.SameAs(prj));

            prj.Mitarbeiter.Remove(ma);
            prj.Mitarbeiter.Add(ma2);

            Assert.That(prj.Mitarbeiter.Count, Is.EqualTo(1));
            Assert.That(prj.Mitarbeiter.First(), Is.SameAs(ma2));
            Assert.That(ma.Projekte.Count, Is.EqualTo(0));
            Assert.That(ma2.Projekte.Count, Is.EqualTo(1));
            Assert.That(ma2.Projekte.First(), Is.SameAs(prj));
        }

        [Test]
        public void Change_Relation_n_m_Set_n_With_Clear()
        {
            var prj = ctx.Create<Zetbox.App.Projekte.Projekt>();
            var ma = ctx.Create<Zetbox.App.Projekte.Mitarbeiter>();
            var ma2 = ctx.Create<Zetbox.App.Projekte.Mitarbeiter>();

            prj.Mitarbeiter.Add(ma);

            Assert.That(prj.Mitarbeiter.Count, Is.EqualTo(1));
            Assert.That(prj.Mitarbeiter.First(), Is.SameAs(ma));
            Assert.That(ma.Projekte.Count, Is.EqualTo(1));
            Assert.That(ma.Projekte.First(), Is.SameAs(prj));

            prj.Mitarbeiter.Clear();
            prj.Mitarbeiter.Add(ma2);

            Assert.That(prj.Mitarbeiter.Count, Is.EqualTo(1));
            Assert.That(prj.Mitarbeiter.First(), Is.SameAs(ma2));
            Assert.That(ma.Projekte.Count, Is.EqualTo(0));
            Assert.That(ma2.Projekte.Count, Is.EqualTo(1));
            Assert.That(ma2.Projekte.First(), Is.SameAs(prj));
        }

        [Test]
        [Ignore("Case 2629: Using an index setter is currently not implemented in NHibernate")]
        public void Change_Relation_n_m_Set_n_By_Index()
        {
            var prj = ctx.Create<Zetbox.App.Projekte.Projekt>();
            var ma = ctx.Create<Zetbox.App.Projekte.Mitarbeiter>();
            var ma2 = ctx.Create<Zetbox.App.Projekte.Mitarbeiter>();

            prj.Mitarbeiter.Add(ma);

            Assert.That(prj.Mitarbeiter.Count, Is.EqualTo(1));
            Assert.That(prj.Mitarbeiter.First(), Is.SameAs(ma));
            Assert.That(ma.Projekte.Count, Is.EqualTo(1));
            Assert.That(ma.Projekte.First(), Is.SameAs(prj));

            prj.Mitarbeiter[0] = ma2;

            Assert.That(prj.Mitarbeiter.Count, Is.EqualTo(1));
            Assert.That(prj.Mitarbeiter.First(), Is.SameAs(ma2));
            Assert.That(ma.Projekte.Count, Is.EqualTo(0));
            Assert.That(ma2.Projekte.Count, Is.EqualTo(1));
            Assert.That(ma2.Projekte.First(), Is.SameAs(prj));
        }

        [Test]
        public void Change_Relation_n_m_Set_m_With_Remove()
        {
            var prj = ctx.Create<Zetbox.App.Projekte.Projekt>();
            var prj2 = ctx.Create<Zetbox.App.Projekte.Projekt>();
            var ma = ctx.Create<Zetbox.App.Projekte.Mitarbeiter>();

            ma.Projekte.Add(prj);

            Assert.That(prj.Mitarbeiter.Count, Is.EqualTo(1));
            Assert.That(prj.Mitarbeiter.First(), Is.SameAs(ma));
            Assert.That(ma.Projekte.Count, Is.EqualTo(1));
            Assert.That(ma.Projekte.First(), Is.SameAs(prj));

            ma.Projekte.Remove(prj);
            ma.Projekte.Add(prj2);

            Assert.That(prj.Mitarbeiter.Count, Is.EqualTo(0));
            Assert.That(prj2.Mitarbeiter.Count, Is.EqualTo(1));
            Assert.That(prj2.Mitarbeiter.First(), Is.SameAs(ma));
            Assert.That(ma.Projekte.Count, Is.EqualTo(1));
            Assert.That(ma.Projekte.First(), Is.SameAs(prj2));
        }
        [Test]
        public void Change_Relation_n_m_Set_m_With_Clear()
        {
            var prj = ctx.Create<Zetbox.App.Projekte.Projekt>();
            var prj2 = ctx.Create<Zetbox.App.Projekte.Projekt>();
            var ma = ctx.Create<Zetbox.App.Projekte.Mitarbeiter>();

            ma.Projekte.Add(prj);

            Assert.That(prj.Mitarbeiter.Count, Is.EqualTo(1));
            Assert.That(prj.Mitarbeiter.First(), Is.SameAs(ma));
            Assert.That(ma.Projekte.Count, Is.EqualTo(1));
            Assert.That(ma.Projekte.First(), Is.SameAs(prj));

            ma.Projekte.Clear();
            ma.Projekte.Add(prj2);

            Assert.That(prj.Mitarbeiter.Count, Is.EqualTo(0));
            Assert.That(prj2.Mitarbeiter.Count, Is.EqualTo(1));
            Assert.That(prj2.Mitarbeiter.First(), Is.SameAs(ma));
            Assert.That(ma.Projekte.Count, Is.EqualTo(1));
            Assert.That(ma.Projekte.First(), Is.SameAs(prj2));
        }
        [Test]
        [Ignore("Case 2629: Using an index setter is currently not implemented in NHibernate")]
        public void Change_Relation_n_m_Set_m_By_Index()
        {
            var prj = ctx.Create<Zetbox.App.Projekte.Projekt>();
            var prj2 = ctx.Create<Zetbox.App.Projekte.Projekt>();
            var ma = ctx.Create<Zetbox.App.Projekte.Mitarbeiter>();

            ma.Projekte.Add(prj);

            Assert.That(prj.Mitarbeiter.Count, Is.EqualTo(1));
            Assert.That(prj.Mitarbeiter.First(), Is.SameAs(ma));
            Assert.That(ma.Projekte.Count, Is.EqualTo(1));
            Assert.That(ma.Projekte.First(), Is.SameAs(prj));

            ma.Projekte[0] = prj2;

            Assert.That(prj.Mitarbeiter.Count, Is.EqualTo(0));
            Assert.That(prj2.Mitarbeiter.Count, Is.EqualTo(1));
            Assert.That(prj2.Mitarbeiter.First(), Is.SameAs(ma));
            Assert.That(ma.Projekte.Count, Is.EqualTo(1));
            Assert.That(ma.Projekte.First(), Is.SameAs(prj2));
        }
        #endregion

        #endregion

        #region Clear Relation
        #endregion

        #region Sort Relation
        [Test]
        public void Sort_Relation_1_n()
        {
            int methodID = 0;
            var method = ctx.GetQuery<Zetbox.App.Base.Method>().ToList().Where(m => m.Module.Name == "Projekte")
                .OrderByDescending(m => m.Parameter.Count).First();
            methodID = method.ID;

            var tmpParameter = method.Parameter.ToList();
            method.Parameter.Clear();
            foreach (Zetbox.App.Base.BaseParameter p in tmpParameter
                .OrderBy(p => p.IsReturnParameter).ThenBy(p => p.Name))
            {
                method.Parameter.Add(p);
            }

            ctx.SubmitChanges();

            var checkCtx = GetContext();
            var checkMethod = checkCtx.Find<Zetbox.App.Base.Method>(methodID);
            var checkParameter = checkMethod.Parameter.ToList();

            Assert.That(
                checkParameter
                    .OrderBy(p => p.IsReturnParameter)
                    .ThenBy(p => p.Name)
                    .ToList(),
                Is.EquivalentTo(checkParameter)
                );
        }

        [Test]
        public void Sort_Relation_n_m_n()
        {
            int prjID = 0;
            var prj = ctx.GetQuery<Zetbox.App.Projekte.Projekt>().ToList()
                .OrderByDescending(p => p.Mitarbeiter.Count).First();
            prjID = prj.ID;

            var tmpMitarbeiter = prj.Mitarbeiter.ToList();
            prj.Mitarbeiter.Clear();
            
            // TODO: Workaround! EF is inserting "newly" added MA first, then it deletes the old one. This breaks the right trigger
            ctx.SubmitChanges(); 

            foreach (Zetbox.App.Projekte.Mitarbeiter m in tmpMitarbeiter
                .OrderBy(m => m.Name))
            {
                prj.Mitarbeiter.Add(m);
            }

            ctx.SubmitChanges();

            var checkCtx = GetContext();
            var checkPrj = checkCtx.Find<Zetbox.App.Projekte.Projekt>(prjID);
            var checkMitarbeiter = checkPrj.Mitarbeiter.ToList();

            int i = 0;
            foreach (Zetbox.App.Projekte.Mitarbeiter m in checkMitarbeiter
                .OrderBy(m => m.Name))
            {
                Assert.That(m, Is.EqualTo(checkMitarbeiter[i++]));
            }
        }

        [Test]
        public void Sort_Relation_n_m_m()
        {
            int maID = 0;
            var ma = ctx.GetQuery<Zetbox.App.Projekte.Mitarbeiter>().ToList()
                .OrderByDescending(p => p.Projekte.Count).First();
            maID = ma.ID;

            var tmpProjekte = ma.Projekte.ToList();
            ma.Projekte.Clear();
            foreach (Zetbox.App.Projekte.Projekt prj in tmpProjekte
                .OrderBy(p => p.Name))
            {
                ma.Projekte.Add(prj);
            }

            ctx.SubmitChanges();

            var checkCtx = GetContext();
            var checkMitarbeiter = checkCtx.Find<Zetbox.App.Projekte.Mitarbeiter>(maID);
            var checkProjekte = checkMitarbeiter.Projekte.ToList();

            int i = 0;
            foreach (Zetbox.App.Projekte.Projekt prj in checkProjekte
                .OrderBy(p => p.Name))
            {
                Assert.That(prj, Is.EqualTo(checkProjekte[i++]));
            }
        }

        #endregion
    }
}
