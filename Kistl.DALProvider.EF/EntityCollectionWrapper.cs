using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Text;

using Kistl.API;
using Kistl.DALProvider.EF;

namespace Kistl.DALProvider.EF
{

    public class EntityCollectionWrapper<INTERFACE, IMPL> : ICollection<INTERFACE>, ICollection
        where IMPL : class, System.Data.Objects.DataClasses.IEntityWithRelationships, INTERFACE, IDataObject
        where INTERFACE : class, IDataObject
    {
        protected EntityCollection<IMPL> _ec;

        public EntityCollectionWrapper(EntityCollection<IMPL> ec)
        {
            _ec = ec;
        }

        public virtual void Add(INTERFACE item)
        {
            _ec.Add((IMPL)item);
        }

        public virtual void Clear()
        {
            _ec.Clear();
        }

        public virtual bool Contains(INTERFACE item)
        {
            return _ec.Contains((IMPL)item);
        }

        public virtual void CopyTo(INTERFACE[] array, int arrayIndex)
        {
            foreach (INTERFACE i in GetEnumerable())
            {
                array[arrayIndex++] = i;
            }
        }

        public virtual int Count
        {
            get { return _ec.Count; }
        }

        public virtual bool IsReadOnly
        {
            get { return _ec.IsReadOnly; }
        }

        public virtual bool Remove(INTERFACE item)
        {
            return _ec.Remove(item as IMPL);
        }

        public virtual IEnumerator<INTERFACE> GetEnumerator()
        {
            return GetEnumerable().GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerable().GetEnumerator();
        }

        protected virtual IEnumerable<INTERFACE> GetEnumerable()
        {
            return _ec.Cast<INTERFACE>();
        }

        #region ICollection Members

        public void CopyTo(Array array, int arrayIndex)
        {
            foreach (var i in GetEnumerable())
            {
                array.SetValue(i, arrayIndex++);
            }
        }

        public bool IsSynchronized { get { return false; } }

        public object SyncRoot { get { return this; } }

        #endregion
    }

    public class EntityCollectionWrapperSorted<INTERFACE, IMPL>
        : EntityCollectionWrapper<INTERFACE, IMPL>, IList<INTERFACE>
        where IMPL : class, System.Data.Objects.DataClasses.IEntityWithRelationships, INTERFACE, IDataObject
        where INTERFACE : class, IDataObject
    {
        private string _pointerProperty = "";
        public EntityCollectionWrapperSorted(EntityCollection<IMPL> ec, string pointerProperty)
            : base(ec)
        {
            _pointerProperty = pointerProperty;
        }

        #region Index Management
        protected void UpdateIndex(INTERFACE item, int? index)
        {
            // Sets the position Property for a 1:n Relation
            // eg. Method 1-n Parameter
            // Sets Parameter.Method__Position__
            item.SetPropertyValue<int?>(_pointerProperty + Helper.PositionSuffix, index);
        }

        protected int? GetIndex(INTERFACE item)
        {
            return item.GetPropertyValue<int?>(_pointerProperty + Helper.PositionSuffix);
        }

        protected INTERFACE GetAt(int index)
        {
            foreach (INTERFACE i in _ec)
            {
                int? idx = GetIndex(i);
                if (idx == null) continue;
                if (idx.Value == index)
                {
                    return i;
                }
            }
            return null;
        }
        #endregion

        #region ICollection Overrides
        public override void Add(INTERFACE item)
        {
            base.Add(item);
            UpdateIndex(item, _ec.Count - 1);
        }

        public override void Clear()
        {
            foreach (INTERFACE i in _ec)
            {
                UpdateIndex(i, null);
            }
            base.Clear();
        }

        public override bool Remove(INTERFACE item)
        {
            UpdateIndex(item, null);
            return base.Remove(item);
        }
        #endregion

        #region IList<INTERFACE> Members

        public int IndexOf(INTERFACE item)
        {
            int? result = GetIndex(item);
            if (result == null) throw new InvalidOperationException("Collection is not sorted");
            return result.Value;
        }

        public void Insert(int index, INTERFACE item)
        {
            UpdateIndex(item, index);
            // TODO: Optimize
            foreach (INTERFACE i in _ec)
            {
                int idx = GetIndex(i) ?? Kistl.API.Helper.LASTINDEXPOSITION;
                if (idx >= index)
                {
                    UpdateIndex(i, idx + 1);
                }
            }
            _ec.Add((IMPL)item);
        }

        public void RemoveAt(int index)
        {
            INTERFACE item = GetAt(index);
            if (item == null) throw new ArgumentOutOfRangeException(string.Format("Index {0} not found in collection", index));
            base.Remove(item);

            // TODO: Optimize
            foreach (INTERFACE i in _ec)
            {
                int idx = GetIndex(i) ?? Kistl.API.Helper.LASTINDEXPOSITION;
                if (idx >= index)
                {
                    UpdateIndex(i, idx - 1);
                }
            }
        }

        public INTERFACE this[int index]
        {
            get
            {
                INTERFACE i = GetAt(index);
                if (i == null) throw new ArgumentOutOfRangeException(string.Format("Index {0} not found in collection", index));
                return i;
            }
            set
            {
                INTERFACE i = GetAt(index);
                if (i == null) throw new ArgumentOutOfRangeException(string.Format("Index {0} not found in collection", index));

                if (i != value)
                {
                    RemoveAt(index);
                    Insert(index, value);
                }
            }
        }

        #endregion
    }

    public class EntityListWrapper<INTERFACE, IMPL>
        : EntityCollectionWrapper<INTERFACE, IMPL>, IList<INTERFACE>
        where IMPL : class, System.Data.Objects.DataClasses.IEntityWithRelationships, INTERFACE, IDataObject
        where INTERFACE : class, IDataObject
    {
        private string _pointerProperty = "";
        public EntityListWrapper(EntityCollection<IMPL> ec, string pointerProperty)
            : base(ec)
        {
            _pointerProperty = pointerProperty;
        }

        #region Index Management
        protected void UpdateIndex(INTERFACE item, int? index)
        {
            // Sets the position Property for a 1:n Relation
            // eg. Method 1-n Parameter
            // Sets Parameter.Method__Position__
            item.SetPropertyValue<int?>(_pointerProperty + Helper.PositionSuffix, index);
        }

        protected int? GetIndex(INTERFACE item)
        {
            return item.GetPropertyValue<int?>(_pointerProperty + Helper.PositionSuffix);
        }

        protected INTERFACE GetAt(int index)
        {
            foreach (INTERFACE i in _ec)
            {
                int? idx = GetIndex(i);
                if (idx == null) continue;
                if (idx.Value == index)
                {
                    return i;
                }
            }
            return null;
        }
        #endregion

        #region ICollection Overrides
        public override void Add(INTERFACE item)
        {
            base.Add(item);
            UpdateIndex(item, _ec.Count - 1);
        }

        public override void Clear()
        {
            foreach (INTERFACE i in _ec)
            {
                UpdateIndex(i, null);
            }
            base.Clear();
        }

        public override bool Remove(INTERFACE item)
        {
            UpdateIndex(item, null);
            return base.Remove(item);
        }
        #endregion

        #region IList<INTERFACE> Members

        public int IndexOf(INTERFACE item)
        {
            int? result = GetIndex(item);
            if (result == null) throw new InvalidOperationException("Collection is not sorted");
            return result.Value;
        }

        public void Insert(int index, INTERFACE item)
        {
            UpdateIndex(item, index);
            // TODO: Optimize
            foreach (INTERFACE i in _ec)
            {
                int idx = GetIndex(i) ?? Kistl.API.Helper.LASTINDEXPOSITION;
                if (idx >= index)
                {
                    UpdateIndex(i, idx + 1);
                }
            }
            _ec.Add((IMPL)item);
        }

        public void RemoveAt(int index)
        {
            INTERFACE item = GetAt(index);
            if (item == null) throw new ArgumentOutOfRangeException(string.Format("Index {0} not found in collection", index));
            base.Remove(item);

            // TODO: Optimize
            foreach (INTERFACE i in _ec)
            {
                int idx = GetIndex(i) ?? Kistl.API.Helper.LASTINDEXPOSITION;
                if (idx >= index)
                {
                    UpdateIndex(i, idx - 1);
                }
            }
        }

        public INTERFACE this[int index]
        {
            get
            {
                INTERFACE i = GetAt(index);
                if (i == null) throw new ArgumentOutOfRangeException(string.Format("Index {0} not found in collection", index));
                return i;
            }
            set
            {
                INTERFACE i = GetAt(index);
                if (i == null) throw new ArgumentOutOfRangeException(string.Format("Index {0} not found in collection", index));

                if (i != value)
                {
                    RemoveAt(index);
                    Insert(index, value);
                }
            }
        }

        #endregion
    }

}
