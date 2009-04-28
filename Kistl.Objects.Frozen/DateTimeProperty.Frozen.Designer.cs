
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
    /// Metadefinition Object for DateTime Properties.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("DateTimeProperty")]
    public class DateTimeProperty__Implementation__Frozen : Kistl.App.Base.ValueTypeProperty__Implementation__Frozen, DateTimeProperty
    {
    
		public DateTimeProperty__Implementation__Frozen()
		{
        }


        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>

		public override System.Type GetPropertyType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_DateTimeProperty != null)
            {
                OnGetPropertyType_DateTimeProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
		public event GetPropertyType_Handler<DateTimeProperty> OnGetPropertyType_DateTimeProperty;



        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>

		public override string GetPropertyTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_DateTimeProperty != null)
            {
                OnGetPropertyTypeString_DateTimeProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
		public event GetPropertyTypeString_Handler<DateTimeProperty> OnGetPropertyTypeString_DateTimeProperty;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(DateTimeProperty));
		}

        // tail template

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DateTimeProperty != null)
            {
                OnToString_DateTimeProperty(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<DateTimeProperty> OnToString_DateTimeProperty;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DateTimeProperty != null) OnPreSave_DateTimeProperty(this);
        }
        public event ObjectEventHandler<DateTimeProperty> OnPreSave_DateTimeProperty;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DateTimeProperty != null) OnPostSave_DateTimeProperty(this);
        }
        public event ObjectEventHandler<DateTimeProperty> OnPostSave_DateTimeProperty;


        internal DateTimeProperty__Implementation__Frozen(int id)
            : base(id)
        { }


		internal new static Dictionary<int, DateTimeProperty__Implementation__Frozen> DataStore = new Dictionary<int, DateTimeProperty__Implementation__Frozen>(8);
		internal new static void CreateInstances()
		{
			Kistl.App.Base.Property__Implementation__Frozen.DataStore[16] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[16] = 
			DataStore[16] = new DateTimeProperty__Implementation__Frozen(16);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[17] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[17] = 
			DataStore[17] = new DateTimeProperty__Implementation__Frozen(17);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[38] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[38] = 
			DataStore[38] = new DateTimeProperty__Implementation__Frozen(38);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[133] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[133] = 
			DataStore[133] = new DateTimeProperty__Implementation__Frozen(133);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[238] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[238] = 
			DataStore[238] = new DateTimeProperty__Implementation__Frozen(238);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[239] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[239] = 
			DataStore[239] = new DateTimeProperty__Implementation__Frozen(239);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[247] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[247] = 
			DataStore[247] = new DateTimeProperty__Implementation__Frozen(247);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[248] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[248] = 
			DataStore[248] = new DateTimeProperty__Implementation__Frozen(248);

		}

		internal new static void FillDataStore() {
			DataStore[16].AltText = @"Start Datum";
			DataStore[16].CategoryTags = null;
			DataStore[16].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(0) {
});
			DataStore[16].Description = @"Start Datum";
			DataStore[16].IsIndexed = false;
			DataStore[16].IsList = false;
			DataStore[16].IsNullable = true;
			DataStore[16].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[16].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[4];
			DataStore[16].PropertyName = @"DatumVon";
			DataStore[16].ValueModelDescriptor = null;
			DataStore[16].Seal();
			DataStore[17].AltText = @"Enddatum";
			DataStore[17].CategoryTags = null;
			DataStore[17].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(0) {
});
			DataStore[17].Description = @"Enddatum";
			DataStore[17].IsIndexed = false;
			DataStore[17].IsList = false;
			DataStore[17].IsNullable = true;
			DataStore[17].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[17].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[4];
			DataStore[17].PropertyName = @"DatumBis";
			DataStore[17].ValueModelDescriptor = null;
			DataStore[17].Seal();
			DataStore[38].AltText = @"Herzlichen Glückwunsch zum Geburtstag";
			DataStore[38].CategoryTags = null;
			DataStore[38].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(0) {
});
			DataStore[38].Description = @"Herzlichen Glückwunsch zum Geburtstag";
			DataStore[38].IsIndexed = false;
			DataStore[38].IsList = false;
			DataStore[38].IsNullable = true;
			DataStore[38].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[2];
			DataStore[38].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[6];
			DataStore[38].PropertyName = @"Geburtstag";
			DataStore[38].ValueModelDescriptor = null;
			DataStore[38].Seal();
			DataStore[133].AltText = @"Happy Birthday!";
			DataStore[133].CategoryTags = null;
			DataStore[133].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(0) {
});
			DataStore[133].Description = @"Happy Birthday!";
			DataStore[133].IsIndexed = false;
			DataStore[133].IsList = false;
			DataStore[133].IsNullable = true;
			DataStore[133].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[5];
			DataStore[133].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[58];
			DataStore[133].PropertyName = @"Birthday";
			DataStore[133].ValueModelDescriptor = null;
			DataStore[133].Seal();
			DataStore[238].AltText = null;
			DataStore[238].CategoryTags = @"Summary";
			DataStore[238].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[223],
});
			DataStore[238].Description = @"Point in time when the presence started.";
			DataStore[238].IsIndexed = false;
			DataStore[238].IsList = false;
			DataStore[238].IsNullable = false;
			DataStore[238].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[3];
			DataStore[238].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[86];
			DataStore[238].PropertyName = @"From";
			DataStore[238].ValueModelDescriptor = null;
			DataStore[238].Seal();
			DataStore[239].AltText = null;
			DataStore[239].CategoryTags = @"Summary";
			DataStore[239].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(0) {
});
			DataStore[239].Description = @"Point in time (inclusive) when the presence ended.";
			DataStore[239].IsIndexed = false;
			DataStore[239].IsList = false;
			DataStore[239].IsNullable = true;
			DataStore[239].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[3];
			DataStore[239].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[86];
			DataStore[239].PropertyName = @"Thru";
			DataStore[239].ValueModelDescriptor = null;
			DataStore[239].Seal();
			DataStore[247].AltText = null;
			DataStore[247].CategoryTags = @"Summary";
			DataStore[247].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[250],
});
			DataStore[247].Description = @"Point in time when the work effort started.";
			DataStore[247].IsIndexed = false;
			DataStore[247].IsList = false;
			DataStore[247].IsNullable = false;
			DataStore[247].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[3];
			DataStore[247].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[87];
			DataStore[247].PropertyName = @"From";
			DataStore[247].ValueModelDescriptor = null;
			DataStore[247].Seal();
			DataStore[248].AltText = null;
			DataStore[248].CategoryTags = @"Summary";
			DataStore[248].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(0) {
});
			DataStore[248].Description = @"Point in time (inclusive) when the work effort ended.";
			DataStore[248].IsIndexed = false;
			DataStore[248].IsList = false;
			DataStore[248].IsNullable = true;
			DataStore[248].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[3];
			DataStore[248].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[87];
			DataStore[248].PropertyName = @"Thru";
			DataStore[248].ValueModelDescriptor = null;
			DataStore[248].Seal();
	
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
        public override void ToStream(System.Xml.XmlWriter xml, string[] modules)
        {
            throw new NotImplementedException();
        }
        public override void FromStream(System.Xml.XmlReader xml)
        {
            throw new NotImplementedException();
        }

#endregion

    }


}