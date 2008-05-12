using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kistl.API;
using Kistl.API.Server;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;
using System.Data;

namespace API.Server.Tests.Tests
{
    [TestFixture]
    public class KistlDataContextTests
    {
        [SetUp]
        public void SetUp()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                var result = ctx.GetQuery<TestObjClass>();
                var list = result.ToList();

                list[0].StringProp = "First";
                list[0].TestEnumProp = 1;

                list[1].StringProp = "Second";
                list[1].TestEnumProp = 2;

                ctx.SubmitChanges();
            }
        }

        [Test]
        public void GetContext()
        {
            IKistlContext ctx = KistlDataContext.GetContext();
            Assert.That(ctx, Is.Not.Null);
        }

        [Test]
        public void InitSession()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                Assert.That(ctx, Is.Not.Null);
                Assert.That(KistlDataContext.Current, Is.Not.Null);
            }
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InitSessionTwice()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                Assert.That(ctx, Is.Not.Null);
                Assert.That(KistlDataContext.Current, Is.Not.Null);
                using (IKistlContext ctx2 = KistlDataContext.InitSession())
                {
                    Assert.That(ctx2, Is.Not.Null);
                    Assert.That(KistlDataContext.Current, Is.Not.Null);
                }
            }
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NoSession()
        {
            Assert.That(KistlDataContext.Current, Is.Null);
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CleanUpSession()
        {
            Assert.That(KistlDataContext.Current, Is.Null);
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                Assert.That(ctx, Is.Not.Null);
                Assert.That(KistlDataContext.Current, Is.Not.Null);
            }
            Assert.That(KistlDataContext.Current, Is.Null);
        }

        [Test]
        public void GetQuery()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                var result = ctx.GetQuery<TestObjClass>();
                Assert.That(result, Is.Not.Null);
            }
        }

        [Test]
        [ExpectedException(typeof(NotSupportedException))]
        public void GetQuery_ObjType()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                var result = ctx.GetQuery(new ObjectType(typeof(TestObjClass)));
                Assert.That(result, Is.Not.Null);
            }
        }

        [Test]
        [ExpectedException(typeof(NotSupportedException))]
        public void Find_T()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                TestObjClass obj = ctx.Find<TestObjClass>(1);
                Assert.That(obj, Is.Not.Null);
            }
        }

        [Test]
        [ExpectedException(typeof(NotSupportedException))]
        public void Find_ObjectType()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                TestObjClass obj = (TestObjClass)ctx.Find(new ObjectType(typeof(TestObjClass)), 1);
                Assert.That(obj, Is.Not.Null);
            }
        }

        [Test]
        public void GetListOf()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                var obj = ctx.GetQuery<TestObjClass>().First(o => o.ID == 1);
                var result = ctx.GetListOf<TestObjClass>(obj, "SubClasses").ToList();
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Count, Is.EqualTo(2));
            }
        }

        [Test]
        [ExpectedException(typeof(NotSupportedException))]
        public void GetListOf_ObjType()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                var result = ctx.GetListOf<TestObjClass>(new ObjectType(typeof(TestObjClass)), 1, "SubClasses").ToList();
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Count, Is.EqualTo(2));
            }
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetListOf_WrongPropertyName()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                var obj = ctx.GetQuery<TestObjClass>().First(o => o.ID == 1);
                var result = ctx.GetListOf<TestObjClass>(obj, "NotAProperty");
            }
        }

        [Test]
        public void SelectSomeData()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                var result = ctx.GetQuery<TestObjClass>();
                Assert.That(result.ToList().Count, Is.EqualTo(4));
            }
        }

        [Test]
        public void SelectSomeData_Collection()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                var result = ctx.GetQuery<TestObjClass>();
                Assert.That(result.ToList().Count, Is.EqualTo(4));

                Assert.That(result.ToList()[0].TestNames.Count, Is.EqualTo(2));
                Assert.That(result.ToList()[1].TestNames.Count, Is.EqualTo(2));
            }
        }

        [Test]
        public void SelectSomeData_Parent()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                var result = ctx.GetQuery<TestObjClass>().ToList();
                Assert.That(result.Count, Is.EqualTo(4));

                Assert.That(result[2].BaseTestObjClass.ID, Is.EqualTo(1));
                Assert.That(result[3].BaseTestObjClass.ID, Is.EqualTo(1));
            }
        }

        [Test]
        public void SelectSomeData_Children()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                var result = ctx.GetQuery<TestObjClass>().ToList();
                Assert.That(result.Count, Is.EqualTo(4));

                Assert.That(result[0].SubClasses.Count, Is.EqualTo(2));
                Assert.That(result[0].SubClasses.ToList()[0].ID, Is.EqualTo(3));
                Assert.That(result[0].SubClasses.ToList()[1].ID, Is.EqualTo(4));
            }
        }


        [Test]
        public void UpdateSomeData_SubmitChanges()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                TestObjClass obj = ctx.GetQuery<TestObjClass>().Where(o => o.ID == 1).First();
                Assert.That(obj, Is.Not.Null);
                Assert.That(obj.StringProp, Is.EqualTo("First"));

                obj.StringProp = "Test";
                ctx.SubmitChanges();
            }

            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                TestObjClass obj = ctx.GetQuery<TestObjClass>().Where(o => o.ID == 1).First();
                Assert.That(obj, Is.Not.Null);
                Assert.That(obj.StringProp, Is.EqualTo("Test"));
            }
        }

        [Test]
        public void UpdateLists_SubmitChanges()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                TestObjClass obj = ctx.GetQuery<TestObjClass>().Where(o => o.ID == 1).First();
                Assert.That(obj.TestNames.Count, Is.EqualTo(2));

                obj.TestNames.ToList()[1].Value = "MuhBlah";

                ctx.SubmitChanges();
            }
            
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                TestObjClass obj = ctx.GetQuery<TestObjClass>().Where(o => o.ID == 1).First();
                Assert.That(obj.TestNames.Count, Is.EqualTo(2));

                Assert.That(obj.TestNames.ToList()[1].Value, Is.EqualTo("MuhBlah"));
            }
        }

        [Test]
        public void Attach_IDataObject_New()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                TestObjClass obj = new TestObjClass();
                Assert.That(obj.EntityState, Is.EqualTo(EntityState.Detached));
                ctx.Attach(obj);
                Assert.That(obj.EntityState, Is.EqualTo(EntityState.Added));
            }
        }

        [Test]
        public void Attach_IDataObject_Existing()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                TestObjClass obj = new TestObjClass() { ID = 3 };
                Assert.That(obj.EntityState, Is.EqualTo(EntityState.Detached));
                ctx.Attach(obj);
                Assert.That(obj.EntityState, Is.EqualTo(EntityState.Unchanged));
            }
        }

        [Test]
        public void Attach_IDataObject_Existing_Twice()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                TestObjClass obj = new TestObjClass() { ID = 3 };
                Assert.That(obj.EntityState, Is.EqualTo(EntityState.Detached));
                ctx.Attach(obj);
                Assert.That(obj.EntityState, Is.EqualTo(EntityState.Unchanged));
                ctx.Attach(obj);
                Assert.That(obj.EntityState, Is.EqualTo(EntityState.Unchanged));
            }
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Attach_IDataObject_Existing_Twice_But_Different()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                TestObjClass obj1 = new TestObjClass() { ID = 3 };
                Assert.That(obj1.EntityState, Is.EqualTo(EntityState.Detached));
                ctx.Attach(obj1);
                Assert.That(obj1.EntityState, Is.EqualTo(EntityState.Unchanged));

                TestObjClass obj2 = new TestObjClass() { ID = 3 };
                Assert.That(obj2.EntityState, Is.EqualTo(EntityState.Detached));
                ctx.Attach(obj2);
                Assert.That(obj2.EntityState, Is.EqualTo(EntityState.Unchanged));
            }
        }

        [Test]
        public void Attach_ICollectionEntry_New()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                TestObjClass_TestNameCollectionEntry obj = new TestObjClass_TestNameCollectionEntry();
                Assert.That(obj.EntityState, Is.EqualTo(EntityState.Detached));
                ctx.Attach(obj);
                Assert.That(obj.EntityState, Is.EqualTo(EntityState.Added));
            }
        }

        [Test]
        public void Attach_ICollectionEntry_Existing()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                TestObjClass_TestNameCollectionEntry obj = new TestObjClass_TestNameCollectionEntry() { ID = 15 };
                Assert.That(obj.EntityState, Is.EqualTo(EntityState.Detached));
                ctx.Attach(obj);
                Assert.That(obj.EntityState, Is.EqualTo(EntityState.Unchanged));
            }
        }

        [Test]
        public void Attach_ICollectionEntry_Existing_Twice()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                TestObjClass_TestNameCollectionEntry obj = new TestObjClass_TestNameCollectionEntry() { ID = 3 };
                Assert.That(obj.EntityState, Is.EqualTo(EntityState.Detached));
                ctx.Attach(obj);
                Assert.That(obj.EntityState, Is.EqualTo(EntityState.Unchanged));
                ctx.Attach(obj);
                Assert.That(obj.EntityState, Is.EqualTo(EntityState.Unchanged));
            }
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Attach_ICollectionEntry_Existing_Twice_But_Different()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                TestObjClass_TestNameCollectionEntry obj1 = new TestObjClass_TestNameCollectionEntry() { ID = 3 };
                Assert.That(obj1.EntityState, Is.EqualTo(EntityState.Detached));
                ctx.Attach(obj1);
                Assert.That(obj1.EntityState, Is.EqualTo(EntityState.Unchanged));

                TestObjClass_TestNameCollectionEntry obj2 = new TestObjClass_TestNameCollectionEntry() { ID = 3 };
                Assert.That(obj2.EntityState, Is.EqualTo(EntityState.Detached));
                ctx.Attach(obj2);
                Assert.That(obj2.EntityState, Is.EqualTo(EntityState.Unchanged));
            }
        }


        [Test]
        public void Create_Generic()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                TestObjClass newObj = ctx.Create<TestObjClass>();
                Assert.That(newObj, Is.Not.Null);
                Assert.That(newObj.Context, Is.Not.Null);
            }
        }

        [Test]
        public void Create_Type()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                TestObjClass newObj = ctx.Create(typeof(TestObjClass)) as TestObjClass;
                Assert.That(newObj, Is.Not.Null);
                Assert.That(newObj.Context, Is.Not.Null);
            }
        }

        [Test]
        public void Create_ObjectType()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                TestObjClass newObj = ctx.Create(new ObjectType(typeof(TestObjClass))) as TestObjClass;
                Assert.That(newObj, Is.Not.Null);
                Assert.That(newObj.Context, Is.Not.Null);
            }
        }


        [Test]
        public void Delete_IDataObject()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                var result = ctx.GetQuery<TestObjClass>();
                Assert.That(result.ToList().Count, Is.EqualTo(4));

                result.ForEach<TestObjClass>(
                    o => ctx.Delete(o));
            }
        }

        [Test]
        public void Delete_ICollectionEntry()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                var result = ctx.GetQuery<TestObjClass>();
                Assert.That(result.ToList().Count, Is.EqualTo(4));

                foreach (TestObjClass obj in result)
                {
                    obj.TestNames.ToList().ForEach<TestObjClass_TestNameCollectionEntry>(c => ctx.Delete(c));
                    Assert.That(obj.TestNames.Count, Is.EqualTo(0));
                }
            }
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Detach_IDataObject_Failed()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                ctx.Detach(new TestObjClass());
            }
        }

        [Test]
        public void Detach_IDataObject()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                TestObjClass obj = ctx.GetQuery<TestObjClass>().First();
                ctx.Detach(obj);
                Assert.That(obj.EntityState, Is.EqualTo(EntityState.Detached));
            }
        }


        [Test]
        [ExpectedException(typeof(NotSupportedException))]
        public void Detach_ICollectionEntry()
        {
            using (IKistlContext ctx = KistlDataContext.InitSession())
            {
                var obj = ctx.GetQuery<TestObjClass>().Single(o => o.ID == 1);
                Assert.That(obj, Is.Not.Null);
                Assert.That(obj.TestNames.Count, Is.EqualTo(2));

                TestObjClass_TestNameCollectionEntry c = obj.TestNames.First();
                ctx.Detach(c);
                Assert.That(c.EntityState, Is.EqualTo(EntityState.Detached));
                Assert.That(obj.TestNames.Count, Is.EqualTo(1));
            }
        }

    }
}
