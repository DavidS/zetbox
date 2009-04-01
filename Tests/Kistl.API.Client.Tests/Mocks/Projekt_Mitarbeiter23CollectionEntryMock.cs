using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.API.Client;
using System.Xml.Serialization;
using Kistl.API;

namespace Kistl.App.Projekte
{
    [System.Diagnostics.DebuggerDisplay("Projekt_Mitarbeiter23CollectionEntry__Implementation__")]
    public class Projekt_Mitarbeiter23CollectionEntry__Implementation__ : BaseClientCollectionEntry, Projekt_Mitarbeiter23CollectionEntry
    {

        // ID is inherited
        public override int RelationID { get { return 23; } }


        /// <summary>
        /// Reference to the A-Side member of this CollectionEntry
        /// </summary>
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Projekte.Projekt A
        {
            get
            {
                if (fk_A.HasValue)
                    return Context.Find<Kistl.App.Projekte.Projekt>(fk_A.Value);
                else
                    return null;
            }
            set
            {
                // TODO: only accept objects from same Context
                if (IsReadonly) throw new ReadOnlyObjectException();

                // shortcut noops
                if (value == null && _fk_A == null)
                    return;
                else if (value != null && value.ID == _fk_A)
                    return;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("A");

                // next, set the local reference
                _fk_A = value == null ? (int?)null : value.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("A");
            }
        }

        // provide a way to directly access the foreign key int
        public int? fk_A
        {
            get
            {
                return _fk_A;
            }
            private set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_fk_A != value)
                {
                    NotifyPropertyChanging("A");
                    _fk_A = value;
                    NotifyPropertyChanged("A");
                }
            }
        }
        private int? _fk_A;
        public virtual int? A_pos
        {
            get
            {
                return _A_pos;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_A_pos != value)
                {
                    NotifyPropertyChanging("A_pos");
                    _A_pos = value;
                    NotifyPropertyChanged("A_pos");
                }
            }
        }
        private int? _A_pos;
        /// <summary>
        /// the B-side value of this CollectionEntry
        /// </summary>
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Projekte.Mitarbeiter B
        {
            get
            {
                if (fk_B.HasValue)
                    return Context.Find<Kistl.App.Projekte.Mitarbeiter>(fk_B.Value);
                else
                    return null;
            }
            set
            {
                // TODO: only accept objects from same Context
                if (IsReadonly) throw new ReadOnlyObjectException();

                // shortcut noops
                if (value == null && _fk_B == null)
                    return;
                else if (value != null && value.ID == _fk_B)
                    return;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("B");

                // next, set the local reference
                _fk_B = value == null ? (int?)null : value.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("B");
            }
        }

        // provide a way to directly access the foreign key int
        public int? fk_B
        {
            get
            {
                return _fk_B;
            }
            private set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_fk_B != value)
                {
                    NotifyPropertyChanging("B");
                    _fk_B = value;
                    NotifyPropertyChanged("B");
                }
            }
        }
        private int? _fk_B;
        public virtual int? B_pos
        {
            get
            {
                return _B_pos;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_B_pos != value)
                {
                    NotifyPropertyChanging("B_pos");
                    _B_pos = value;
                    NotifyPropertyChanged("B_pos");
                }
            }
        }
        private int? _B_pos;



        /// <summary>
        /// Index into the A-side list of this relation
        /// </summary>
        public int? AIndex { get { return A_pos; } set { A_pos = value; } }
        /// <summary>
        /// Index into the B-side list of this relation
        /// </summary>
        public int? BIndex { get { return B_pos; } set { B_pos = value; } }

        public override Kistl.API.InterfaceType GetInterfaceType()
        {
            return new InterfaceType(typeof(Projekt_Mitarbeiter23CollectionEntry));
        }
    }
}
