using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;
using Kistl.API;
using Kistl.API.Client;

namespace API.Client.Tests.Tests
{
    [TestFixture]
    public class KistlContextTests
    {
        private IKistlContext ctx;
        private CustomActionsManagerAPITest currentCustomActionsManager;

        [SetUp]
        public void SetUp()
        {
            System.Diagnostics.Trace.WriteLine("KistlContextTests.SetUp() is called");
            currentCustomActionsManager = (CustomActionsManagerAPITest)CustomActionsManagerFactory.Current;
            currentCustomActionsManager.Reset();

            // Set Proxy
            Proxy.SetProxy(new TestProxy());
            ctx = KistlContext.GetContext();
            CacheController<Kistl.API.IDataObject>.Current.Clear();
        }

        [Test]
        public void GetQuery_ObjectType()
        {
            IQueryable<IDataObject> query = ctx.GetQuery(new ObjectType(typeof(TestObjClass)));
            Assert.That(query, Is.Not.Null);
            Assert.That(query.ElementType, Is.EqualTo(typeof(IDataObject)));
        }

        [Test]
        public void GetQuery_T()
        {
            IQueryable<TestObjClass> query = ctx.GetQuery<TestObjClass>();
            Assert.That(query, Is.Not.Null);
            Assert.That(query.ElementType, Is.EqualTo(typeof(TestObjClass)));
        }

        [Test]
        public void GetObject()
        {
            TestObjClass obj = ctx.Find<TestObjClass>(1);
            Assert.That(obj, Is.Not.Null);
            Assert.That(obj.ID, Is.EqualTo(1));
            Assert.That(obj.ObjectState, Is.EqualTo(DataObjectState.Unmodified));
            Assert.That(obj.Context, Is.EqualTo(ctx));
        }

        [Test]
        public void GetObject_Twice()
        {
            TestObjClass obj1 = ctx.Find<TestObjClass>(1);
            Assert.That(obj1, Is.Not.Null);
            Assert.That(obj1.ID, Is.EqualTo(1));

            TestObjClass obj2 = ctx.Find<TestObjClass>(1);
            Assert.That(obj2, Is.Not.Null);
            Assert.That(obj2.ID, Is.EqualTo(1));
            Assert.That(object.ReferenceEquals(obj1, obj2), "Obj1 & Obj2 are different Objects");
        }

        [Test]
        public void GetList()
        {
            List<TestObjClass> list = ctx.GetQuery<TestObjClass>().ToList();
            Assert.That(list, Is.Not.Null);
            Assert.That(list.Count, Is.AtLeast(2));
            list.ForEach(obj => Assert.That(obj, Is.Not.Null));
            list.ForEach(obj => Assert.That(obj.ObjectState, Is.EqualTo(DataObjectState.Unmodified)));
            list.ForEach(obj => Assert.That(obj.Context, Is.EqualTo(ctx)));
        }

        [Test]
        public void GetList_Twice()
        {
            List<TestObjClass> list1 = ctx.GetQuery<TestObjClass>().ToList();
            Assert.That(list1, Is.Not.Null);
            Assert.That(list1.Count, Is.AtLeast(2));
            list1.ForEach(obj => Assert.That(obj, Is.Not.Null));

            List<TestObjClass> list2 = ctx.GetQuery<TestObjClass>().ToList();
            Assert.That(list2, Is.Not.Null);
            Assert.That(list2.Count, Is.EqualTo(list1.Count));
            list2.ForEach(obj => Assert.That(obj, Is.Not.Null));

            for (int i = 0; i < list1.Count; i++)
            {
                Assert.That(list1[i], Is.EqualTo(list2[i]));
            }
        }

        [Test]
        public void GetListOf()
        {
            List<TestObjClass> list = ctx.GetListOf<TestObjClass>(new ObjectType(typeof(TestObjClass)), 1, "Children");
            Assert.That(list, Is.Not.Null);
            Assert.That(list.Count, Is.AtLeast(2));
            list.ForEach(obj => Assert.That(obj, Is.Not.Null));
            list.ForEach(obj => Assert.That(obj.ObjectState, Is.EqualTo(DataObjectState.Unmodified)));
            list.ForEach(obj => Assert.That(obj.Context, Is.EqualTo(ctx)));
        }

        [Test]
        public void GetListOf_Twice()
        {
            List<TestObjClass> list1 = ctx.GetListOf<TestObjClass>(new ObjectType(typeof(TestObjClass)), 1, "Children");
            Assert.That(list1, Is.Not.Null);
            Assert.That(list1.Count, Is.AtLeast(2));
            list1.ForEach(obj => Assert.That(obj, Is.Not.Null));

            List<TestObjClass> list2 = ctx.GetListOf<TestObjClass>(new ObjectType(typeof(TestObjClass)), 1, "Children");
            Assert.That(list2, Is.Not.Null);
            Assert.That(list2.Count, Is.EqualTo(list1.Count));
            list2.ForEach(obj => Assert.That(obj, Is.Not.Null));

            for (int i = 0; i < list1.Count; i++)
            {
                Assert.That(list1[i], Is.EqualTo(list2[i]));
            }
        }

        [Test]
        public void Create_T()
        {
            TestObjClass obj = ctx.Create<TestObjClass>();
            Assert.That(obj, Is.Not.Null);
            Assert.That(obj.ID, Is.EqualTo(Helper.INVALIDID));
            Assert.That(obj.ObjectState, Is.EqualTo(DataObjectState.New));
            Assert.That(obj.Context, Is.EqualTo(ctx));
        }

        [Test]
        public void Create_Type()
        {
            TestObjClass obj = ctx.Create(typeof(TestObjClass)) as TestObjClass;
            Assert.That(obj, Is.Not.Null);
            Assert.That(obj.ID, Is.EqualTo(Helper.INVALIDID));
            Assert.That(obj.ObjectState, Is.EqualTo(DataObjectState.New));
            Assert.That(obj.Context, Is.EqualTo(ctx));
        }

        [Test]
        public void Create_ObjectType()
        {
            TestObjClass obj = ctx.Create(new ObjectType(typeof(TestObjClass))) as TestObjClass;
            Assert.That(obj, Is.Not.Null);
            Assert.That(obj.ID, Is.EqualTo(Helper.INVALIDID));
            Assert.That(obj.ObjectState, Is.EqualTo(DataObjectState.New));
            Assert.That(obj.Context, Is.EqualTo(ctx));
        }

        [Test]
        public void Create_T_Twice()
        {
            TestObjClass obj1 = ctx.Create<TestObjClass>();
            Assert.That(obj1, Is.Not.Null);
            Assert.That(obj1.ID, Is.EqualTo(Helper.INVALIDID));
            Assert.That(obj1.Context, Is.EqualTo(ctx));

            TestObjClass obj2 = ctx.Create<TestObjClass>();
            Assert.That(obj2, Is.Not.Null);
            Assert.That(obj2.ID, Is.EqualTo(Helper.INVALIDID));
            Assert.That(obj2.Context, Is.EqualTo(ctx));

            Assert.That(obj1, Is.Not.EqualTo(obj2));
        }

        [Test]
        public void Attach()
        {
            TestObjClass obj = new TestObjClass();
            ctx.Attach(obj);
            Assert.That(obj.Context, Is.EqualTo(ctx));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Attach_Twice()
        {
            TestObjClass obj = new TestObjClass();
            ctx.Attach(obj);
            Assert.That(obj.Context, Is.EqualTo(ctx));

            ctx.Attach(obj);
            Assert.That(obj.Context, Is.EqualTo(ctx));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Attach_Twice_But_Different()
        {
            TestObjClass obj1 = new TestObjClass() { ID = 1 };
            ctx.Attach(obj1);
            Assert.That(obj1.Context, Is.EqualTo(ctx));

            TestObjClass obj2 = new TestObjClass() { ID = 1 };
            ctx.Attach(obj2);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Attach_Null()
        {
            ctx.Attach((IDataObject)null);
        }

        [Test]
        public void Detach()
        {
            TestObjClass obj = new TestObjClass() { ID = 1 };
            ctx.Attach(obj);
            Assert.That(obj.Context, Is.EqualTo(ctx));

            ctx.Detach(obj);
            Assert.That(obj.Context, Is.Null);
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Detach_NotAttached()
        {
            TestObjClass obj = new TestObjClass() { ID = 1 };

            ctx.Detach(obj);
            Assert.That(obj.Context, Is.Null);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Detach_Null()
        {
            ctx.Detach((IDataObject)null);
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Detach_Twice()
        {
            TestObjClass obj = new TestObjClass() { ID = 1 };
            ctx.Attach(obj);
            Assert.That(obj.Context, Is.EqualTo(ctx));

            ctx.Detach(obj);
            Assert.That(obj.Context, Is.Null);

            ctx.Detach(obj);
        }

        [Test]
        public void Delete()
        {
            TestObjClass obj = ctx.Find<TestObjClass>(1);
            Assert.That(obj.ObjectState, Is.EqualTo(DataObjectState.Unmodified));
            ctx.Delete(obj);
            Assert.That(obj.ObjectState, Is.EqualTo(DataObjectState.Deleted));
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Delete_Null()
        {
            ctx.Delete((IDataObject)null);
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Delete_Not_Attached()
        {
            TestObjClass obj = new TestObjClass();
            ctx.Delete(obj);
            Assert.That(obj.ObjectState, Is.EqualTo(DataObjectState.Deleted));
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Delete_Wrong_Context()
        {
            TestObjClass obj = KistlContext.GetContext().Find<TestObjClass>(1);
            ctx.Delete(obj);
            Assert.That(obj.ObjectState, Is.EqualTo(DataObjectState.Deleted));
        }

        [Test]
        public void SubmitChanges()
        {
            TestObjClass obj = ctx.Find<TestObjClass>(1);
            obj.StringProp = "Test";
            Assert.That(obj.ObjectState, Is.EqualTo(DataObjectState.Modified));

            int result = ctx.SubmitChanges();
            Assert.That(result, Is.EqualTo(1));
            Assert.That(obj.ObjectState, Is.EqualTo(DataObjectState.Unmodified));
            Assert.That(obj.Context, Is.EqualTo(ctx));
        }

        [Test]
        public void SubmitChanges_Nothing()
        {
            TestObjClass obj = ctx.Find<TestObjClass>(1);
            Assert.That(obj.ObjectState, Is.EqualTo(DataObjectState.Unmodified));

            int result = ctx.SubmitChanges();
            Assert.That(result, Is.EqualTo(0));
            Assert.That(obj.ObjectState, Is.EqualTo(DataObjectState.Unmodified));
            Assert.That(obj.Context, Is.EqualTo(ctx));
        }

        [Test]
        public void SubmitChanges_Delete()
        {
            TestObjClass obj = ctx.Find<TestObjClass>(1);
            Assert.That(obj.ObjectState, Is.EqualTo(DataObjectState.Unmodified));
            ctx.Delete(obj);
            Assert.That(obj.ObjectState, Is.EqualTo(DataObjectState.Deleted));

            int result = ctx.SubmitChanges();
            Assert.That(result, Is.EqualTo(1));
            Assert.That(obj.ObjectState, Is.EqualTo(DataObjectState.Deleted));
            Assert.That(obj.Context, Is.Null);
        }
    }
}