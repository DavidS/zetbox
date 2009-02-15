
namespace Kistl.App.Base
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    using Kistl.API;

    using Kistl.DalProvider.Frozen;

    /// <summary>
    /// Metadefinition Object for an Enumeration Entry.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("EnumerationEntry")]
    public class EnumerationEntry__Implementation__Frozen : BaseFrozenDataObject, EnumerationEntry
    {


        /// <summary>
        /// Übergeordnete Enumeration
        /// </summary>
        // object reference property
        public virtual Kistl.App.Base.Enumeration Enumeration
        {
            get
            {
                return _Enumeration;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_Enumeration != value)
                {
                    NotifyPropertyChanging("Enumeration");
                    _Enumeration = value;
                    NotifyPropertyChanged("Enumeration");;
                }
            }
        }
        private Kistl.App.Base.Enumeration _Enumeration;

        /// <summary>
        /// The CLR value of this entry
        /// </summary>
        // value type property
        public virtual int Value
        {
            get
            {
                return _Value;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_Value != value)
                {
                    NotifyPropertyChanging("Value");
                    _Value = value;
                    NotifyPropertyChanged("Value");;
                }
            }
        }
        private int _Value;

        /// <summary>
        /// CLR name of this entry
        /// </summary>
        // value type property
        public virtual string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_Name != value)
                {
                    NotifyPropertyChanging("Name");
                    _Name = value;
                    NotifyPropertyChanged("Name");;
                }
            }
        }
        private string _Name;

        /// <summary>
        /// Description of this Enumeration Entry
        /// </summary>
        // value type property
        public virtual string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                if (IsReadonly) throw new ReadOnlyObjectException();
                if (_Description != value)
                {
                    NotifyPropertyChanging("Description");
                    _Description = value;
                    NotifyPropertyChanged("Description");;
                }
            }
        }
        private string _Description;

        // tail template

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_EnumerationEntry != null)
            {
                OnToString_EnumerationEntry(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<EnumerationEntry> OnToString_EnumerationEntry;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_EnumerationEntry != null) OnPreSave_EnumerationEntry(this);
        }
        public event ObjectEventHandler<EnumerationEntry> OnPreSave_EnumerationEntry;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_EnumerationEntry != null) OnPostSave_EnumerationEntry(this);
        }
        public event ObjectEventHandler<EnumerationEntry> OnPostSave_EnumerationEntry;


        internal EnumerationEntry__Implementation__Frozen(FrozenContext ctx, int id)
            : base(ctx, id)
        { }


		internal static Dictionary<int, EnumerationEntry__Implementation__Frozen> DataStore = new Dictionary<int, EnumerationEntry__Implementation__Frozen>(28);
		static EnumerationEntry__Implementation__Frozen()
		{
			DataStore[2] = new EnumerationEntry__Implementation__Frozen(null, 2);

			DataStore[3] = new EnumerationEntry__Implementation__Frozen(null, 3);

			DataStore[5] = new EnumerationEntry__Implementation__Frozen(null, 5);

			DataStore[6] = new EnumerationEntry__Implementation__Frozen(null, 6);

			DataStore[7] = new EnumerationEntry__Implementation__Frozen(null, 7);

			DataStore[40] = new EnumerationEntry__Implementation__Frozen(null, 40);

			DataStore[41] = new EnumerationEntry__Implementation__Frozen(null, 41);

			DataStore[42] = new EnumerationEntry__Implementation__Frozen(null, 42);

			DataStore[43] = new EnumerationEntry__Implementation__Frozen(null, 43);

			DataStore[44] = new EnumerationEntry__Implementation__Frozen(null, 44);

			DataStore[45] = new EnumerationEntry__Implementation__Frozen(null, 45);

			DataStore[46] = new EnumerationEntry__Implementation__Frozen(null, 46);

			DataStore[47] = new EnumerationEntry__Implementation__Frozen(null, 47);

			DataStore[48] = new EnumerationEntry__Implementation__Frozen(null, 48);

			DataStore[49] = new EnumerationEntry__Implementation__Frozen(null, 49);

			DataStore[50] = new EnumerationEntry__Implementation__Frozen(null, 50);

			DataStore[51] = new EnumerationEntry__Implementation__Frozen(null, 51);

			DataStore[52] = new EnumerationEntry__Implementation__Frozen(null, 52);

			DataStore[53] = new EnumerationEntry__Implementation__Frozen(null, 53);

			DataStore[54] = new EnumerationEntry__Implementation__Frozen(null, 54);

			DataStore[55] = new EnumerationEntry__Implementation__Frozen(null, 55);

			DataStore[56] = new EnumerationEntry__Implementation__Frozen(null, 56);

			DataStore[57] = new EnumerationEntry__Implementation__Frozen(null, 57);

			DataStore[58] = new EnumerationEntry__Implementation__Frozen(null, 58);

			DataStore[59] = new EnumerationEntry__Implementation__Frozen(null, 59);

			DataStore[60] = new EnumerationEntry__Implementation__Frozen(null, 60);

			DataStore[61] = new EnumerationEntry__Implementation__Frozen(null, 61);

			DataStore[62] = new EnumerationEntry__Implementation__Frozen(null, 62);

		}

		internal static void FillDataStore() {
			DataStore[2].Value = 0;
			DataStore[2].Name = @"First";
			DataStore[2].Description = @"First Test Entry";
			DataStore[3].Value = 1;
			DataStore[3].Name = @"Second";
			DataStore[3].Description = @"Second Test Entry";
			DataStore[5].Value = 0;
			DataStore[5].Name = @"WPF";
			DataStore[5].Description = @"WPF Toolkit";
			DataStore[6].Value = 1;
			DataStore[6].Name = @"ASPNET";
			DataStore[6].Description = @"ASPNET Toolkit";
			DataStore[7].Value = 2;
			DataStore[7].Name = @"TEST";
			DataStore[7].Description = @"TEST Toolkit";
			DataStore[40].Value = 16;
			DataStore[40].Name = @"SimpleObjectList";
			DataStore[40].Description = null;
			DataStore[41].Value = 15;
			DataStore[41].Name = @"Enumeration";
			DataStore[41].Description = null;
			DataStore[42].Value = 14;
			DataStore[42].Name = @"StringList";
			DataStore[42].Description = null;
			DataStore[43].Value = 13;
			DataStore[43].Name = @"String";
			DataStore[43].Description = null;
			DataStore[44].Value = 12;
			DataStore[44].Name = @"IntegerList";
			DataStore[44].Description = null;
			DataStore[45].Value = 11;
			DataStore[45].Name = @"Integer";
			DataStore[45].Description = null;
			DataStore[46].Value = 10;
			DataStore[46].Name = @"DoubleList";
			DataStore[46].Description = null;
			DataStore[47].Value = 9;
			DataStore[47].Name = @"Double";
			DataStore[47].Description = null;
			DataStore[48].Value = 8;
			DataStore[48].Name = @"DateTimeList";
			DataStore[48].Description = null;
			DataStore[49].Value = 7;
			DataStore[49].Name = @"DateTime";
			DataStore[49].Description = null;
			DataStore[50].Value = 6;
			DataStore[50].Name = @"BooleanList";
			DataStore[50].Description = null;
			DataStore[51].Value = 5;
			DataStore[51].Name = @"Boolean";
			DataStore[51].Description = null;
			DataStore[52].Value = 4;
			DataStore[52].Name = @"ObjectReference";
			DataStore[52].Description = null;
			DataStore[53].Value = 3;
			DataStore[53].Name = @"ObjectList";
			DataStore[53].Description = null;
			DataStore[54].Value = 2;
			DataStore[54].Name = @"PropertyGroup";
			DataStore[54].Description = null;
			DataStore[55].Value = 1;
			DataStore[55].Name = @"Object";
			DataStore[55].Description = null;
			DataStore[56].Value = 0;
			DataStore[56].Name = @"Renderer";
			DataStore[56].Description = null;
			DataStore[57].Value = 18;
			DataStore[57].Name = @"MenuGroup";
			DataStore[57].Description = null;
			DataStore[58].Value = 17;
			DataStore[58].Name = @"MenuItem";
			DataStore[58].Description = null;
			DataStore[59].Value = 19;
			DataStore[59].Name = @"TemplateEditor";
			DataStore[59].Description = null;
			DataStore[60].Value = 3;
			DataStore[60].Name = @"Replicate";
			DataStore[60].Description = null;
			DataStore[61].Value = 2;
			DataStore[61].Name = @"Right";
			DataStore[61].Description = null;
			DataStore[62].Value = 1;
			DataStore[62].Name = @"Left";
			DataStore[62].Description = null;
	
		}

#region Serializer

        public override void ToStream(System.IO.BinaryWriter binStream)
        {
            throw new NotImplementedException();
        }
        public override void FromStream(System.IO.BinaryReader binStream)
        {
            throw new NotImplementedException();
        }

#endregion

    }


}