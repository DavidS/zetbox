using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.API.Client;
using Kistl.API;
using Kistl.App.Test;
using System.Linq.Expressions;

namespace Kistl.DalProvider.ClientObjects.Mocks
{
    public class ProxyMock : IProxy
    {
        private int newID = 10;

        public void Generate()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IDataObject> GetList(InterfaceType ifType, int maxListCount, Expression filter, IEnumerable<Expression> orderBy, out List<IStreamable> auxObjects)
        {
            if (ifType == null) throw new ArgumentNullException("ifType");
            if (orderBy != null) throw new ArgumentException("OrderBy is not supported yet");

            auxObjects = new List<IStreamable>();
            IEnumerable<IDataObject> result;

            if (ifType == typeof(TestObjClass))
            {
                result = GetList_TestObjClass();
            }
            else if (ifType == typeof(TestCustomObject))
            {
                result = GetList_TestCustomObject();
            }
            else if (ifType == typeof(Muhblah))
            {
                result = GetList_Muhblah();
            }
            else
            {
                throw new ArgumentOutOfRangeException("ifType", "Only TestObjClasses are allowed");
            }

            if (filter != null)
            {
                filter = filter.StripQuotes();
                return result.AsQueryable().AddCast(ifType.Type).AddFilter(filter).Cast<IDataObject>().ToList();
            }
            return result.Cast<IDataObject>();
        }

        private static T CreateInstance<T>(int id)
        {
            InterfaceType ifType = new InterfaceType(typeof(T));
            return (T)CreateInstance(ifType, id);
        }

        private static IDataObject CreateInstance(InterfaceType ifType, int id)
        {
            var result = (IDataObject)Activator.CreateInstance(ifType.ToImplementationType().Type);
            result.SetPrivatePropertyValue<int>("ID", id);
            return result;
        }

        private IEnumerable<IDataObject> GetList_Muhblah()
        {
            var result = new List<Muhblah>();
            result.Add(CreateInstance<Muhblah>(1));
            result.Add(CreateInstance<Muhblah>(2));
            result.Add(CreateInstance<Muhblah>(3));
            result.Add(CreateInstance<Muhblah>(4));
            result.Add(CreateInstance<Muhblah>(5));
            return result.Cast<IDataObject>();
        }

        private IEnumerable<IDataObject> GetList_TestCustomObject()
        {
            var result = new List<TestCustomObject>();
            result.Add(CreateInstance<TestCustomObject>(1));
            result.Add(CreateInstance<TestCustomObject>(2));
            result.Add(CreateInstance<TestCustomObject>(3));
            result.Add(CreateInstance<TestCustomObject>(4));
            result.Add(CreateInstance<TestCustomObject>(5));
            return result.Cast<IDataObject>();
        }

        private static IEnumerable<IDataObject> GetList_TestObjClass()
        {
            var result = new List<TestObjClass>();
            result.Add(CreateInstance<TestObjClass>(1));
            result.Add(CreateInstance<TestObjClass>(2));
            result.Add(CreateInstance<TestObjClass>(3));
            result.Add(CreateInstance<TestObjClass>(4));
            result.Add(CreateInstance<TestObjClass>(5));

            result[0].StringProp = "String 1";

            result[1].StringProp = "String 2";
            result[1].SetPrivatePropertyValue<int>("fk_Parent", 1);

            result[2].StringProp = "String 3";
            result[2].SetPrivatePropertyValue<int>("fk_Parent", 1);

            result[3].StringProp = "String 4";

            result[4].StringProp = "String 5";

            return result.Cast<IDataObject>();
        }

        public IEnumerable<IDataObject> GetListOf(InterfaceType ifType, int ID, string property, out List<IStreamable> auxObjects)
        {
            if (ifType == null) throw new ArgumentNullException("ifType");
            if (ifType != typeof(TestObjClass)) throw new ArgumentOutOfRangeException("type", "Only TestObjClasses are allowed");
            auxObjects = new List<IStreamable>();

            List<TestObjClass> result = new List<TestObjClass>();
            if (ID == 1)
            {
                result.Add(CreateInstance<TestObjClass>(2));
                result.Add(CreateInstance<TestObjClass>(3));

                result[0].StringProp = "String 2";
                result[0].SetPrivatePropertyValue<int>("fk_Parent", 1);

                result[1].StringProp = "String 3";
                result[1].SetPrivatePropertyValue<int>("fk_Parent", 1);
            }

            return result.Cast<IDataObject>();
        }

        public string HelloWorld(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPersistenceObject> SetObjects(IEnumerable<IPersistenceObject> objects)
        {
            var result = new List<IPersistenceObject>();
            foreach (var obj in objects)
            {
                var type = obj.GetInterfaceType();
                if (type == null) throw new ArgumentNullException("type");

                if (obj.ObjectState != DataObjectState.Deleted)
                {
                    var newObj = CreateInstance(type, 0);

                    // Copy old object to new object
                    newObj.ApplyChangesFrom(obj);
                    if (newObj.ID < Helper.INVALIDID)
                    {
                        newObj.SetPrivatePropertyValue<int>("ID", ++newID);
                    }
                    result.Add(newObj);
                    newObj.SetPrivateFieldValue<DataObjectState>("_ObjectState", DataObjectState.Unmodified);
                }
            }

            return result;
        }

        public IEnumerable<T> FetchRelation<T>(Guid relationId, RelationEndRole role, IDataObject parent, out List<IStreamable> auxObjects) where T : class, IRelationCollectionEntry
        {
            auxObjects = new List<IStreamable>();
            return new List<T>();
        }

        #region IDisposable Members

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
