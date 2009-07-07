using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kistl.API;
using Kistl.App.Base;
using Kistl.App.Projekte;

using NUnit.Framework;

namespace Kistl.API.AbstractConsumerTests
{
    public abstract class AbstractReadonlyListPropertiesTests
    {
        protected abstract IKistlContext GetContext();

        [SetUp]
        public void SetUp()
        {
            using (var ctx = GetContext())
            {
                var kunde = ctx.Create<Kunde>();
                kunde.EMails.Add("office@example.com");
                kunde.EMails.Add("privat@example.com");
                kunde.Kundenname = "com Kunde";
                kunde.PLZ = "1111";

                kunde = ctx.Create<Kunde>();
                kunde.EMails.Add("office@example.net");
                kunde.Kundenname = "net Kunde";
                kunde.PLZ = "2222";

                kunde = ctx.Create<Kunde>();
                kunde.Kundenname = "empty Kunde";
                kunde.PLZ = "3333";

                kunde = ctx.Create<Kunde>();
                kunde.EMails.Add("office@example.org");
                kunde.EMails.Add("privat@example.org");
                kunde.EMails.Add("muh@example.org");
                kunde.EMails.Add("blah@example.org");
                kunde.Kundenname = "org Kunde";
                kunde.PLZ = "4444";

                var prj = ctx.Create<Projekt>();
                prj.Name = "Kistl";

                var task1 = ctx.Create<Task>();
                task1.Projekt = prj;

                var task2 = ctx.Create<Task>();
                task2.Projekt = prj;

                ctx.SubmitChanges();
            }
        }

        [TearDown]
        public void TearDown()
        {
            using (var ctx = GetContext())
            {
                ctx.GetQuery<Kunde>().ForEach(obj => ctx.Delete(obj));
                ctx.GetQuery<Projekt>().ForEach(obj => ctx.Delete(obj));
                ctx.GetQuery<Task>().ForEach(obj => ctx.Delete(obj));
                ctx.SubmitChanges();
            }
        }

        [Test]
        public void value_lists_should_have_elements()
        {
            using (IKistlContext ctx = GetContext())
            {
                var list = ctx.GetQuery<Kunde>();
                int count = 0;
                foreach (Kunde k in list)
                {
                    count += k.EMails.Count;
                }
                Assert.That(count, Is.GreaterThan(0));
            }
        }

        [Test]
        public void object_lists_should_have_elements()
        {
            using (IKistlContext ctx = GetContext())
            {
                var list = ctx.GetQuery<ObjectClass>();
                int count = 0;
                foreach (var cls in list)
                {
                    count += cls.ImplementsInterfaces.Count;
                    foreach (var m in cls.ImplementsInterfaces)
                    {
                        Assert.That(m.ID, Is.Not.EqualTo(Kistl.API.Helper.INVALIDID));
                    }
                }
                Assert.That(count, Is.GreaterThan(0));
            }
        }

        [Test]
        public void navigating_a_fk_list_property_should_yield_related_objects()
        {
            using (IKistlContext ctx = GetContext())
            {
                var cls = ctx.GetQuery<ObjectClass>().Where(o => o.ClassName == "TestObjClass").First();
                var navigatedList = cls.Properties;

                Assume.That(navigatedList.Count, Is.GreaterThan(0));

                var manualList = ctx.GetQuery<Property>().Where(t => t.ObjectClass.ID == cls.ID).ToList();
                Assert.That(navigatedList, Is.EquivalentTo(manualList));
            }
        }

        [Test]
        [Ignore("Needs N:M relation between frozen objects with navigators in both directions")]
        public void navigating_a_nm_list_property_should_yield_related_objects()
        {
            using (IKistlContext ctx = GetContext())
            {
                var cls = ctx.GetQuery<ObjectClass>().Where(o => o.ClassName == "TestObjClass").First();
                var navigatedList = cls.ImplementsInterfaces;

                Assume.That(navigatedList.Count, Is.GreaterThan(0));

                //var manualList = ctx.GetQuery<Interface>().Where(t => t.ImplementedBy.Contains(cls)).ToList();
                //Assert.That(navigatedList, Is.EquivalentTo(manualList));
            }
        }

        [Test]
        public void retrieving_a_fk_list_twice_should_yield_same_list()
        {
            using (IKistlContext ctx = GetContext())
            {
                var prj1 = ctx.GetQuery<ObjectClass>().Where(o => o.ClassName == "TestObjClass").ToList().Single();
                var list1 = prj1.Properties;
                Assume.That(list1.Count, Is.GreaterThan(0));

                var prj2 = ctx.GetQuery<ObjectClass>().Where(o => o.ClassName == "TestObjClass").ToList().Single();
                var list2 = prj2.Properties;

                Assert.That(list2, Is.SameAs(list1));
            }
        }

        [Test]
        public void retrieving_a_nm_list_twice_should_yield_same_list()
        {
            using (IKistlContext ctx = GetContext())
            {
                var prj1 = ctx.GetQuery<ObjectClass>().Where(o => o.ClassName == "TestObjClass").ToList().Single();
                var list1 = prj1.ImplementsInterfaces;
                Assume.That(list1.Count, Is.GreaterThan(0));

                var prj2 = ctx.GetQuery<ObjectClass>().Where(o => o.ClassName == "TestObjClass").ToList().Single();
                var list2 = prj2.ImplementsInterfaces;

                Assert.That(list2, Is.SameAs(list1));
            }
        }

        [Test]
        public void list_and_query_should_yield_consistent_results()
        {
            using (IKistlContext ctx = GetContext())
            {
                var tasks = ctx.GetQuery<Task>().Where(t => t.Projekt.Name == "Kistl").ToList();
                var prj = ctx.GetQuery<Projekt>().Where(p => p.Name == "Kistl").ToList().Single();

                Assert.That(tasks, Is.EquivalentTo(prj.Tasks), "mismatch of tasks and project.tasks");
                Assert.That(tasks.Select(t => t.Projekt), Has.All.EqualTo(prj), "task has wrong parent Project");
            }
        }


        // check whether a IsOrdered list's items are ordered correctly
        // not a very "good" test due to its dependency on "real" data
        [Test]
        public void list_should_be_sorted_correctly()
        {
            using (IKistlContext ctx = GetContext())
            {
                ObjectClass cls = ctx.GetQuery<ObjectClass>().Where(c => c.ClassName == "Constraint").ToList().Single();
                Method isValid = cls.Methods.Where(m => m.MethodName == "IsValid").ToList().Single();

                AssertThatIsCorrectParameterOrder(isValid.Parameter);

                var resultOfEnumeration = isValid.Parameter.AsEnumerable().ToList();
                AssertThatIsCorrectParameterOrder(resultOfEnumeration);
            }
        }

        private static void AssertThatIsCorrectParameterOrder(IList<BaseParameter> parameter)
        {
            Assert.That(parameter[0].IsReturnParameter, Is.True, "return parameter should be first");
            Assert.That(parameter[1].ParameterName, Is.EqualTo("constrainedObject"));
            Assert.That(parameter[2].ParameterName, Is.EqualTo("constrainedValue"));
        }

    }

    public abstract class AbstractListPropertiesTests : AbstractReadonlyListPropertiesTests
    {

        [Test]
        public void AddStringListPropertyContent()
        {
            int ID = Kistl.API.Helper.INVALIDID;
            string mail = "";
            using (IKistlContext ctx = GetContext())
            {
                var k = ctx.GetQuery<Kunde>().First();
                mail = "UnitTest" + DateTime.Now + "@example.com";
                ID = k.ID;
                k.EMails.Add(mail);
                Assert.That(mail, Is.Not.EqualTo(""));
                int submitCount = ctx.SubmitChanges();
                Assert.That(submitCount, Is.GreaterThan(0));
            }

            using (IKistlContext ctx = GetContext())
            {
                var kunde = ctx.Find<Kunde>(ID);
                Assert.That(kunde, Is.Not.Null);
                Assert.That(kunde.EMails.Count, Is.GreaterThan(0));
                var result = kunde.EMails.SingleOrDefault(m => m == mail);
                Assert.That(result, Is.Not.Null);
            }
        }

        [Test]
        [Ignore("Set IsSorted on Kunde.EMails")]
        public void UpdateStringListPropertyContent()
        {
            int ID = Kistl.API.Helper.INVALIDID;
            string mail = "";
            using (IKistlContext ctx = GetContext())
            {
                var list = ctx.GetQuery<Kunde>();
                foreach (Kunde k in list)
                {
                    if (k.EMails.Count > 0)
                    {
                        mail = "UnitTest" + DateTime.Now + "@example.com";
                        //k.EMails[0] = mail;
                        ID = k.ID;
                        break;
                    }
                }
                Assert.That(mail, Is.Not.EqualTo(""));
                int submitCount = ctx.SubmitChanges();
                Assert.That(submitCount, Is.GreaterThan(0));
            }

            using (IKistlContext ctx = GetContext())
            {
                var kunde = ctx.Find<Kunde>(ID);
                Assert.That(kunde, Is.Not.Null);
                Assert.That(kunde.EMails.Count, Is.GreaterThan(0));
                var result = kunde.EMails.SingleOrDefault(m => m == mail);
                Assert.That(result, Is.Not.Null);
            }
        }

        [Test]
        public void DeleteStringListPropertyContent()
        {
            int ID = Kistl.API.Helper.INVALIDID;
            int mailCount = 0;
            string mail = "";
            using (IKistlContext ctx = GetContext())
            {
                var list = ctx.GetQuery<Kunde>();
                foreach (Kunde k in list)
                {
                    if (k.EMails.Count > 0)
                    {
                        mail = k.EMails.First();
                        k.EMails.Remove(mail);
                        mailCount = k.EMails.Count;
                        ID = k.ID;
                        break;
                    }
                }
                int submitCount = ctx.SubmitChanges();
                Assert.That(submitCount, Is.GreaterThan(0));
            }

            using (IKistlContext ctx = GetContext())
            {
                var kunde = ctx.Find<Kunde>(ID);
                Assert.That(kunde, Is.Not.Null);
                Assert.That(kunde.EMails.Count, Is.GreaterThan(0));

                var result = kunde.EMails.SingleOrDefault(m => m == mail);
                Assert.That(kunde.EMails.Count, Is.EqualTo(mailCount));
                Assert.That(result, Is.Null);
            }
        }

    }
}
