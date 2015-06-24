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

// TODO: move to Zetbox.DalProvider.Base project
namespace Zetbox.DalProvider.Base.RelationWrappers
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Linq;
    using System.Text;
    using Zetbox.API;

    public abstract class ValueCollectionWrapper<TParent, TValue, TEntry, TEntryCollection>
        : ICollection<TValue>, INotifyCollectionChanged
        where TParent : IDataObject
        where TEntry : class, IValueCollectionEntry<TParent, TValue>
        where TEntryCollection : ICollection<TEntry>
    {
        protected readonly TParent parent;
        protected readonly Action parentNotifier;
        protected readonly TEntryCollection collection;
        protected readonly IZetboxContext ctx;
        protected readonly ImplementationType tEntryImplementation;
        protected readonly InterfaceType tEntryInterface;

        protected ValueCollectionWrapper(IZetboxContext ctx, TParent parent, Action parentNotifier, TEntryCollection collection)
        {
            if (ctx == null) { throw new ArgumentNullException("ctx"); }
            if (parent == null) { throw new ArgumentNullException("parent"); }
            // may be null: if (parentNotifier == null) { throw new ArgumentNullException("parentNotifier"); }
            if (collection == null) { throw new ArgumentNullException("collection"); }

            this.ctx = ctx;
            this.parent = parent;
            this.parentNotifier = parentNotifier;
            this.collection = collection;
            this.tEntryImplementation = ctx.GetImplementationType(typeof(TEntry));
            this.tEntryInterface = tEntryImplementation.ToInterfaceType();

            // may be necessary on (lazy) initialisation
            foreach (var item in this.collection)
            {
                if (item.Context != this.ctx)
                {
                    ctx.Attach(item);
                }
            }
        }

        #region Notifications
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        protected void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            if (CollectionChanged != null)
            {
                CollectionChanged(this, e);
            }
        }

        protected void NotifyOwner()
        {
            if (parentNotifier != null)
            {
                parentNotifier();
            }
        }


        /// <summary>
        /// called before an entry is added to the list
        /// </summary>
        /// <param name="entry">the new entry</param>
        protected virtual void OnEntryAdding(TEntry entry) { }

        /// <summary>
        /// called after an entry is added to the list
        /// </summary>
        /// <param name="entry">the new entry</param>
        protected virtual void OnEntryAdded(TEntry entry)
        {
            NotifyOwner();
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, entry.Value));
        }

        /// <summary>
        /// called before an entry is removed from the list
        /// </summary>
        /// <param name="entry">the removed entry</param>
        protected virtual void OnEntryRemoving(TEntry entry) { }

        /// <summary>
        /// called after an entry is removed from the list
        /// </summary>
        /// <param name="entry">the removed entry</param>
        protected virtual void OnEntryRemoved(TEntry entry)
        {
            NotifyOwner();
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, entry.Value));
        }

        #endregion

        protected virtual TEntry CreateEntry()
        {
            return (TEntry)ctx.Internals().CreateValueCollectionEntry(tEntryInterface);
        }

        protected virtual TEntry InitialiseEntry(TEntry e, TValue value)
        {
            e.UpdateParent("Parent", parent);
            e.Value = value;
            ctx.Attach(e);
            return e;
        }

        protected TEntry FindByItem(TValue item)
        {
            foreach (var e in collection)
            {
                if (object.Equals(e.Value, item))
                    return e;
            }
            return null;
        }

        #region ICollection<TValue> Members

        public void Add(TValue item)
        {
            TEntry entry = InitialiseEntry(CreateEntry(), item);
            OnEntryAdding(entry);
            collection.Add(entry);
            OnEntryAdded(entry);
        }

        public void Clear()
        {
            var entries = collection.ToList();
            foreach (var e in entries)
            {
                ctx.Delete(e);
                OnEntryRemoving(e);
            }
            collection.Clear();
            foreach (var e in entries)
            {
                OnEntryRemoved(e);
            }
        }

        public bool Contains(TValue item)
        {
            return FindByItem(item) != null;
        }

        public void CopyTo(TValue[] array, int arrayIndex)
        {
            foreach (var i in collection)
            {
                array[arrayIndex++] = i.Value;
            }
        }

        public int Count
        {
            get { return collection.Count; }
        }

        public bool IsReadOnly
        {
            get { return collection.IsReadOnly; }
        }

        public bool Remove(TValue item)
        {
            TEntry e = FindByItem(item);
            if (e == null)
                return false;
            ctx.Delete(e);
            OnEntryRemoving(e);
            collection.Remove(e);
            OnEntryRemoved(e);
            return true;
        }

        #endregion

        #region IEnumerable<TValue> Members

        public IEnumerator<TValue> GetEnumerator()
        {
            return collection.Select(e => e.Value).GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return collection.Select(e => e.Value).GetEnumerator();
        }

        #endregion
    }

    public abstract class ValueListWrapper<TParent, TValue, TEntry, TEntryCollection>
        : ValueCollectionWrapper<TParent, TValue, TEntry, TEntryCollection>, IList<TValue>
        where TParent : IDataObject
        where TEntry : class, IValueListEntry<TParent, TValue>
        where TEntryCollection : ICollection<TEntry>
    {
        protected ValueListWrapper(IZetboxContext ctx, TParent parent, Action parentNotifier, TEntryCollection collection)
            : base(ctx, parent, parentNotifier, collection)
        {
        }

        #region Index Management

        protected TEntry GetAt(int index)
        {
            RepairIndexes();
            return collection.SingleOrDefault(e => { var idx = e.Index; return idx.HasValue && idx.Value == index; });
        }

        /// <summary>
        /// Repairs all index values on the entries. This is currently needed sometimes, 
        /// because entries could have been added/modified/removed by the "other" side, without us knowing.
        /// Then the IndexFromEntry() is set to LASTINDEXPOSITION or holes exist which confuse the rest.
        /// </summary>
        protected void RepairIndexes()
        {
            int i = 0;
            foreach (var entry in collection.OrderBy(e => e.Index ?? Zetbox.API.Helper.LASTINDEXPOSITION))
            {
                entry.Index = i++;
            }
            Zetbox.API.Utils.Logging.Log.Warn("RepairIndexes");
        }

        protected override void OnEntryAdded(TEntry entry)
        {
            base.OnEntryAdded(entry);
            RepairIndexes();
        }

        #endregion

        #region IList<TValue> Members

        public int IndexOf(TValue item)
        {
            TEntry entry = FindByItem(item);
            if (entry == null)
                return -1;

            int? result = entry.Index;
            if (result == null || result.Value == Zetbox.API.Helper.LASTINDEXPOSITION)
                throw new InvalidOperationException("Collection is not sorted");

            return result.Value;
        }

        public void Insert(int index, TValue item)
        {
            // allow index==-1 and index==Collection.Count for prepending or appending to list
            if (-1 < index || index > collection.Count)
                throw new ArgumentOutOfRangeException("index", "is not a valid index");

            if (IsReadOnly)
                throw new NotSupportedException("List is ReadOnly");

            // TODO: Optimize
            foreach (TEntry entry in collection)
            {
                int idx = entry.Index ?? Zetbox.API.Helper.LASTINDEXPOSITION;
                if (idx >= index)
                {
                    entry.Index = idx + 1;
                }
            }

            TEntry newEntry = InitialiseEntry(CreateEntry(), item);
            newEntry.Index = index;

            OnEntryAdding(newEntry);
            collection.Add(newEntry);
            OnEntryAdded(newEntry);
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= collection.Count)
                throw new ArgumentOutOfRangeException("index", "is not a valid index");

            if (IsReadOnly)
                throw new NotSupportedException("List is ReadOnly");

            TEntry oldEntry = GetAt(index);
            base.Remove(oldEntry.Value);

            // not really needed when removing items.
            // TODO: Optimize, check whether other parts can live with holes 
            // in the Position; when inserting exploit holes to shortcut 
            // Position updating
            foreach (TEntry entry in collection)
            {
                int idx = entry.Index ?? Zetbox.API.Helper.LASTINDEXPOSITION;
                if (idx >= index)
                {
                    entry.Index = idx - 1;
                }
            }
        }

        public TValue this[int index]
        {
            get
            {
                TEntry entry = GetAt(index);
                if (entry == null)
                    throw new ArgumentOutOfRangeException("index", String.Format("Index {0} not found in collection", index));
                return entry.Value;
            }
            set
            {
                TEntry entry = GetAt(index);
                if (entry == null)
                    throw new ArgumentOutOfRangeException("index", String.Format("Index {0} not found in collection", index));

                if (!Object.Equals(entry.Value, value))
                {
                    entry.Value = value;
                }
            }
        }

        #endregion
    }
}
