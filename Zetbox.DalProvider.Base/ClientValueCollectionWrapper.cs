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

// TODO: move to Zetbox.DalProvider.Base.RelationWrappers namespace
namespace Zetbox.DalProvider.Base
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Linq;
    using System.Text;

    using Zetbox.API;
    using Zetbox.API.Common;
    using Zetbox.DalProvider.Base.RelationWrappers;

    public class ClientValueCollectionWrapper<TParent, TValue, TEntry, TEntryImpl, TEntryCollection>
        : ValueCollectionWrapper<TParent, TValue, TEntryImpl, TEntryCollection>, IRelationListSync<TEntry>
        where TParent : IDataObject
        where TEntry : IValueCollectionEntry<TParent, TValue>
        where TEntryImpl : class, TEntry
        where TEntryCollection : ICollection<TEntryImpl>
    {
        public ClientValueCollectionWrapper(IZetboxContext ctx, TParent parent, Action parentNotifier, TEntryCollection collection)
            : base(ctx, parent, parentNotifier, collection)
        {
            if (collection == null) throw new ArgumentNullException("collection");

            var notifier = collection as INotifyCollectionChanged;
            if (notifier != null)
                notifier.CollectionChanged += (sender, e) => this.NotifyOwner();
        }

        public ClientValueCollectionWrapper(IZetboxContext ctx, TParent parent, TEntryCollection collection)
            : this(ctx, parent, null, collection)
        {
        }

        #region IRelationListSync<TEntry> Members

        public virtual void AddWithoutSetParent(TEntry entry)
        {
            if (entry == null) { throw new ArgumentNullException("entry"); }
            var entryImpl = entry as TEntryImpl;
            if (entryImpl == null) { throw new ArgumentOutOfRangeException("entry"); }

            OnEntryAdding(entryImpl);
            collection.Add(entryImpl);
            OnEntryAdded(entryImpl);
        }

        public virtual void RemoveWithoutClearParent(TEntry entry)
        {
            if (entry == null) { throw new ArgumentNullException("entry"); }
            var entryImpl = entry as TEntryImpl;
            if (entryImpl == null) { throw new ArgumentOutOfRangeException("entry"); }

            OnEntryRemoving(entryImpl);
            collection.Remove(entryImpl);
            OnEntryRemoved(entryImpl);
        }

        #endregion
    }

    public class ClientValueCollectionAsListWrapper<TParent, TValue, TEntry, TEntryImpl, TEntryCollection>
        : ValueCollectionWrapper<TParent, TValue, TEntryImpl, TEntryCollection>, IRelationListSync<TEntry>, IList<TValue>, System.Collections.IList
        where TParent : IDataObject
        where TValue : class
        where TEntry : IValueCollectionEntry<TParent, TValue>
        where TEntryImpl : class, TEntry
        where TEntryCollection : ICollection<TEntryImpl>, IList<TEntryImpl>
    {
        public ClientValueCollectionAsListWrapper(IZetboxContext ctx, TParent parent, Action parentNotifier, TEntryCollection collection)
            : base(ctx, parent, parentNotifier, collection)
        {
            if (collection == null) throw new ArgumentNullException("collection");

            var notifier = collection as INotifyCollectionChanged;
            if (notifier != null)
                notifier.CollectionChanged += (sender, e) => this.NotifyOwner();
        }

        public ClientValueCollectionAsListWrapper(IZetboxContext ctx, TParent parent, TEntryCollection collection)
            : this(ctx, parent, null, collection)
        {
        }

        #region IRelationListSync<TEntry> Members

        public virtual void AddWithoutSetParent(TEntry entry)
        {
            if (entry == null) { throw new ArgumentNullException("entry"); }
            var entryImpl = entry as TEntryImpl;
            if (entryImpl == null) { throw new ArgumentOutOfRangeException("entry"); }

            OnEntryAdding(entryImpl);
            collection.Add(entryImpl);
            OnEntryAdded(entryImpl);
        }

        public virtual void RemoveWithoutClearParent(TEntry entry)
        {
            if (entry == null) { throw new ArgumentNullException("entry"); }
            var entryImpl = entry as TEntryImpl;
            if (entryImpl == null) { throw new ArgumentOutOfRangeException("entry"); }

            OnEntryRemoving(entryImpl);
            collection.Remove(entryImpl);
            OnEntryRemoved(entryImpl);
        }

        #endregion

        #region IList<TValue> Members

        public int IndexOf(TValue item)
        {
            var entry = FindByItem(item);
            if (entry == null)
                return -1;
            else
                return collection.IndexOf(entry);
        }

        public void Insert(int index, TValue item)
        {
            TEntryImpl entry = InitialiseEntry(CreateEntry(), item);
            OnEntryAdding(entry);
            collection.Insert(index, entry);
            OnEntryAdded(entry);
        }

        public void RemoveAt(int index)
        {
            TEntryImpl e = collection[index];
            ctx.Delete(e);
            OnEntryRemoving(e);
            collection.Remove(e);
            OnEntryRemoved(e);
        }

        public TValue this[int index]
        {
            get
            {
                return collection[index].Value;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region IList Members
        int System.Collections.IList.Add(object value)
        {
            this.Add((TValue)value);
            return this.Count - 1;
        }

        bool System.Collections.IList.Contains(object value)
        {
            var tvalue = value as TValue;
            if (value == null)
                return this.Contains(null);
            else if (tvalue == null)
                return false;
            else
                return this.Contains(tvalue);
        }

        int System.Collections.IList.IndexOf(object value)
        {
            var tvalue = value as TValue;
            if (value == null)
                return this.IndexOf(null);
            else if (tvalue == null)
                return -1;
            else
                return this.IndexOf(tvalue);
        }

        void System.Collections.IList.Insert(int index, object value)
        {
            this.Insert(index, (TValue)value);
        }

        public bool IsFixedSize
        {
            get { return false; }
        }

        void System.Collections.IList.Remove(object value)
        {
            this.Remove((TValue)value);
        }

        object System.Collections.IList.this[int index]
        {
            get
            {
                return this[index];
            }
            set
            {
                this[index] = (TValue)value;
            }
        }

        void System.Collections.ICollection.CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        bool System.Collections.ICollection.IsSynchronized
        {
            get { throw new NotImplementedException(); }
        }

        object System.Collections.ICollection.SyncRoot
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }

    public class ClientValueListWrapper<TParent, TValue, TEntry, TEntryImpl, TEntryCollection>
        : ValueListWrapper<TParent, TValue, TEntryImpl, TEntryCollection>
        where TParent : IDataObject
        where TEntry : IValueListEntry<TParent, TValue>
        where TEntryImpl : class, TEntry
        where TEntryCollection : ICollection<TEntryImpl>
    {
        public ClientValueListWrapper(IZetboxContext ctx, TParent parent, Action parentNotifier, TEntryCollection collection)
            : base(ctx, parent, parentNotifier, collection)
        {
        }

        public ClientValueListWrapper(IZetboxContext ctx, TParent parent, TEntryCollection collection)
            : base(ctx, parent, null, collection)
        {
        }

        #region IRelationListSync<TEntry> Members

        public virtual void AddWithoutSetParent(TEntry entry)
        {
            if (entry == null) { throw new ArgumentNullException("entry"); }
            var entryImpl = entry as TEntryImpl;
            if (entryImpl == null) { throw new ArgumentOutOfRangeException("entry"); }

            OnEntryAdding(entryImpl);
            collection.Add(entryImpl);
            OnEntryAdded(entryImpl);
        }

        public virtual void RemoveWithoutClearParent(TEntry entry)
        {
            if (entry == null) { throw new ArgumentNullException("entry"); }
            var entryImpl = entry as TEntryImpl;
            if (entryImpl == null) { throw new ArgumentOutOfRangeException("entry"); }

            OnEntryRemoving(entryImpl);
            collection.Remove(entryImpl);
            OnEntryRemoved(entryImpl);
        }

        #endregion
    }
}
