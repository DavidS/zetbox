using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Zetbox.DalProvider.Base.RelationWrappers;

namespace Zetbox.API.Server.Mocks
{

    public class TestNameCollectionWrapper
        : ValueCollectionWrapper<TestObjClass, string, TestObjClass_TestNameCollectionEntryImpl, List<TestObjClass_TestNameCollectionEntryImpl>>
    {
        public TestNameCollectionWrapper(IZetboxContext ctx, TestObjClassImpl parent, List<TestObjClass_TestNameCollectionEntryImpl> baselist)
            : base(ctx, parent, null, baselist)
        {
        }

        protected override TestObjClass_TestNameCollectionEntryImpl CreateEntry()
        {
            return new TestObjClass_TestNameCollectionEntryImpl();
        }
    }

    public interface TestObjClass_TestNameCollectionEntry
        : IValueCollectionEntry<TestObjClass, string>
    {
    }

    public class TestObjClass_TestNameCollectionEntryImpl
        : BaseServerCollectionEntry, TestObjClass_TestNameCollectionEntry
    {
        public TestObjClass_TestNameCollectionEntryImpl()
            : base(null)
        {
        }

        /// <summary>
        /// returns the most specific implemented data object interface
        /// </summary>
        /// <returns></returns>
        public override Type GetImplementedInterface()
        {
            return typeof(IValueCollectionEntry<TestObjClass, string>);
        }

        public override int ID { get; set; }

        public override bool IsAttached { get { return _IsAttached; } }
        private bool _IsAttached = false;

        public override void AttachToContext(IZetboxContext ctx)
        {
            base.AttachToContext(ctx);
            _IsAttached = true;
        }

        public override void DetachFromContext(IZetboxContext ctx)
        {
            base.DetachFromContext(ctx);
            _IsAttached = false;
        }

        #region IValueCollectionEntry<TestObjClass,string> Members

        public TestObjClass Parent { get; set; }
        public IDataObject ParentObject { get; set; }

        public string Value { get; set; }
        public object ValueObject { get; set; }

        #endregion

        public override void ToStream(ZetboxStreamWriter sw, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(sw, auxObjects, eagerLoadLists);
            sw.Write(Value);
        }

        public override IEnumerable<IPersistenceObject> FromStream(ZetboxStreamReader sr)
        {
            var baseResult = base.FromStream(sr);
            Value = sr.ReadString();
            return baseResult;
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch (propertyName)
            {
                case "Parent":
                    Parent = (TestObjClass)parentObj;
                    ParentObject = parentObj;
                    break;
                default:
                    base.UpdateParent(propertyName, parentObj);
                    break;
            }
        }
        public virtual Guid PropertyID { get { return Guid.Empty; } }
    }
}
