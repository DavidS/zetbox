using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects.DataClasses;
using System.Collections;

namespace Kistl.API.Server
{
    #region EntityCollectionWrapper
    public class EntityCollectionWrapper<INTERFACE, IMPL> : ICollection<INTERFACE>
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
    }
    #endregion

    #region EntityCollectionWrapperSorted
    public class EntityCollectionWrapperSorted<INTERFACE, IMPL> : 
        EntityCollectionWrapper<INTERFACE, IMPL>, 
        IList<INTERFACE>
        where IMPL : class, System.Data.Objects.DataClasses.IEntityWithRelationships, INTERFACE, IDataObject
        where INTERFACE : class, IDataObject
    {
        private string _pointerProperty = "";
        public EntityCollectionWrapperSorted(EntityCollection<IMPL> ec, string pointerProperty) : base(ec)
        {
            _pointerProperty = pointerProperty;
        }

        protected void UpdateIndex(INTERFACE item, int? index)
        {
            // Sets the position Property for a 1:n Relation
            // eg. Method 1-n Parameter
            // Sets Parameter.Method__Position__
            item.SetPropertyValue<int?>(_pointerProperty + Helper.PositonSuffix, index);
        }

        protected int? GetIndex(INTERFACE item)
        {
            return item.GetPropertyValue<int?>(_pointerProperty + Helper.PositonSuffix);
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
                int idx = GetIndex(i) ?? -1;
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
                int idx = GetIndex(i) ?? -1;
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
    #endregion

    #region EntityCollectionEntryValueWrapper
    // List
    public class EntityCollectionEntryValueWrapper<PARENT, VALUE, IMPL> : ICollection<VALUE>
        where IMPL : class, System.Data.Objects.DataClasses.IEntityWithRelationships, ICollectionEntry<VALUE, PARENT>, new()
        where PARENT : class, IDataObject
    {
        private EntityCollection<IMPL> _ec;
        private PARENT _parentObject;

        public EntityCollectionEntryValueWrapper(PARENT parentObject, EntityCollection<IMPL> ec)
        {
            _ec = ec;
            _parentObject = parentObject;
        }

        private void Clear(IMPL entry)
        {
            entry.Value = default(VALUE);
            entry.Parent = null;
            // TODO: Warum ist der Context leer?
            if (entry.Context != null) entry.Context.Delete(entry);
        }

        #region ICollection<VALUE> Members

        public void Add(VALUE item)
        {
            IMPL entry = new IMPL();
            entry.Parent = _parentObject;
            entry.Value = item;
            _ec.Add(entry);
        }

        public void Clear()
        {
            // Must be cleared by hand
            // EF will drop the Value on the CollectionEntry - that's right and OK
            // But we want the CollectionEntry to be deleted in that case
            foreach (IMPL entry in _ec.ToList())
            {
                Clear(entry);
            }
            _ec.Clear();
        }

        public bool Contains(VALUE item)
        {
            return _ec.Select(e => e.Value).Contains(item);
        }

        public void CopyTo(VALUE[] array, int arrayIndex)
        {
            foreach (var i in _ec.Select(i => i.Value))
            {
                array[arrayIndex++] = i;
            }
        }

        public int Count
        {
            get { return _ec.Count; }
        }

        public bool IsReadOnly
        {
            get { return _ec.IsReadOnly; }
        }

        public bool Remove(VALUE item)
        {
            IMPL e = _ec.Single(i => i.Value.Equals(item));
            Clear(e);
            return _ec.Remove(e);
        }

        #endregion

        #region IEnumerable<VALUE> Members

        public IEnumerator<VALUE> GetEnumerator()
        {
            return _ec.Select(i => i.Value).GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _ec.Select(i => i.Value).GetEnumerator();
        }

        #endregion
    }
    #endregion

    #region EntityCollectionEntryParentWrapper
    // Backreference List
    public class EntityCollectionEntryParentWrapper<PARENT, VALUE, IMPL> : ICollection<PARENT>
        where IMPL : class, System.Data.Objects.DataClasses.IEntityWithRelationships, ICollectionEntry<VALUE, PARENT>, new()
        where PARENT : class, IDataObject
    {
        private EntityCollection<IMPL> _ec;
        private VALUE _parentObject;

        public EntityCollectionEntryParentWrapper(VALUE parentObject, EntityCollection<IMPL> ec)
        {
            _ec = ec;
            _parentObject = parentObject;
        }

        private void Clear(IMPL entry)
        {
            entry.Value = default(VALUE);
            entry.Parent = null;
            // TODO: Warum ist der Context leer?
            if (entry.Context != null) entry.Context.Delete(entry);
        }

        #region ICollection<PARENT> Members

        public void Add(PARENT item)
        {
            IMPL entry = new IMPL();
            entry.Value = _parentObject;
            entry.Parent = item;
            _ec.Add(entry);
        }

        public void Clear()
        {
            // Must be cleared by hand
            // EF will drop the Value on the CollectionEntry - that's right and OK
            // But we want the CollectionEntry to be deleted in that case
            foreach (IMPL entry in _ec.ToList())
            {
                Clear(entry);
            }
            _ec.Clear();
        }

        public bool Contains(PARENT item)
        {
            return _ec.Select(e => e.Parent).Contains(item);
        }

        public void CopyTo(PARENT[] array, int arrayIndex)
        {
            foreach(var i in _ec.Select(i => i.Parent))
            {
                array[arrayIndex++] = i;
            }
        }

        public int Count
        {
            get { return _ec.Count; }
        }

        public bool IsReadOnly
        {
            get { return _ec.IsReadOnly; }
        }

        public bool Remove(PARENT item)
        {
            IMPL e = _ec.Single(i => i.Parent.Equals(item));
            Clear(e);
            return _ec.Remove(e);
        }

        #endregion

        #region IEnumerable<PARENT> Members

        public IEnumerator<PARENT> GetEnumerator()
        {
            return _ec.Select(i => i.Parent).GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _ec.Select(i => i.Parent).GetEnumerator();
        }

        #endregion
    }
    #endregion
}
