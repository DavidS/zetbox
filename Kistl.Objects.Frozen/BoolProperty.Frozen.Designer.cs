// <autogenerated/>


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
    /// Metadefinition Object for Bool Properties.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("BoolProperty")]
    public class BoolProperty__Implementation__Frozen : Kistl.App.Base.ValueTypeProperty__Implementation__Frozen, BoolProperty
    {
    
		public BoolProperty__Implementation__Frozen()
		{
        }


        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>

		public override System.Type GetPropertyType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_BoolProperty != null)
            {
                OnGetPropertyType_BoolProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
		public event GetPropertyType_Handler<BoolProperty> OnGetPropertyType_BoolProperty;



        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>

		public override string GetPropertyTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_BoolProperty != null)
            {
                OnGetPropertyTypeString_BoolProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
		public event GetPropertyTypeString_Handler<BoolProperty> OnGetPropertyTypeString_BoolProperty;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(BoolProperty));
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_BoolProperty != null)
            {
                OnToString_BoolProperty(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<BoolProperty> OnToString_BoolProperty;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_BoolProperty != null) OnPreSave_BoolProperty(this);
        }
        public event ObjectEventHandler<BoolProperty> OnPreSave_BoolProperty;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_BoolProperty != null) OnPostSave_BoolProperty(this);
        }
        public event ObjectEventHandler<BoolProperty> OnPostSave_BoolProperty;


        internal BoolProperty__Implementation__Frozen(int id)
            : base(id)
        { }


		internal new static Dictionary<int, BoolProperty__Implementation__Frozen> DataStore = new Dictionary<int, BoolProperty__Implementation__Frozen>(16);
		internal new static void CreateInstances()
		{
			Kistl.App.Base.Property__Implementation__Frozen.DataStore[11] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[11] = 
			DataStore[11] = new BoolProperty__Implementation__Frozen(11);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[26] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[26] = 
			DataStore[26] = new BoolProperty__Implementation__Frozen(26);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[83] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[83] = 
			DataStore[83] = new BoolProperty__Implementation__Frozen(83);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[94] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[94] = 
			DataStore[94] = new BoolProperty__Implementation__Frozen(94);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[95] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[95] = 
			DataStore[95] = new BoolProperty__Implementation__Frozen(95);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[116] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[116] = 
			DataStore[116] = new BoolProperty__Implementation__Frozen(116);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[119] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[119] = 
			DataStore[119] = new BoolProperty__Implementation__Frozen(119);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[124] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[124] = 
			DataStore[124] = new BoolProperty__Implementation__Frozen(124);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[174] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[174] = 
			DataStore[174] = new BoolProperty__Implementation__Frozen(174);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[204] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[204] = 
			DataStore[204] = new BoolProperty__Implementation__Frozen(204);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[220] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[220] = 
			DataStore[220] = new BoolProperty__Implementation__Frozen(220);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[264] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[264] = 
			DataStore[264] = new BoolProperty__Implementation__Frozen(264);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[265] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[265] = 
			DataStore[265] = new BoolProperty__Implementation__Frozen(265);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[266] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[266] = 
			DataStore[266] = new BoolProperty__Implementation__Frozen(266);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[269] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[269] = 
			DataStore[269] = new BoolProperty__Implementation__Frozen(269);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[274] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[274] = 
			DataStore[274] = new BoolProperty__Implementation__Frozen(274);

		}

		internal new static void FillDataStore() {
			DataStore[11].AltText = null;
			DataStore[11].CategoryTags = @"DataModel,Summary";
			DataStore[11].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[143],
});
			DataStore[11].Description = @"";
			DataStore[11].ExportGuid = new Guid("b2bd1528-c22f-4e12-b80f-f8234a2c0831");
			DataStore[11].IsIndexed = false;
			DataStore[11].IsList = false;
			DataStore[11].IsNullable = false;
			DataStore[11].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[11].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[7];
			DataStore[11].PropertyName = @"IsList";
			DataStore[11].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[13];
			DataStore[11].Seal();
			DataStore[26].AltText = null;
			DataStore[26].CategoryTags = @"DataModel,Summary";
			DataStore[26].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[142],
});
			DataStore[26].Description = @"";
			DataStore[26].ExportGuid = new Guid("6aa68dc6-d7f3-4809-89bb-e7474df0bde4");
			DataStore[26].IsIndexed = false;
			DataStore[26].IsList = false;
			DataStore[26].IsNullable = false;
			DataStore[26].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[26].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[7];
			DataStore[26].PropertyName = @"IsNullable";
			DataStore[26].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[13];
			DataStore[26].Seal();
			DataStore[83].AltText = @"Legt fest, ob es sich um ein Client-Assembly handelt.";
			DataStore[83].CategoryTags = null;
			DataStore[83].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[117],
});
			DataStore[83].Description = @"Legt fest, ob es sich um ein Client-Assembly handelt.";
			DataStore[83].ExportGuid = new Guid("d6b0af6c-b0ed-40be-b8dd-76d2379989f5");
			DataStore[83].IsIndexed = false;
			DataStore[83].IsList = false;
			DataStore[83].IsNullable = false;
			DataStore[83].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[83].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[29];
			DataStore[83].PropertyName = @"IsClientAssembly";
			DataStore[83].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[13];
			DataStore[83].Seal();
			DataStore[94].AltText = @"Parameter wird als List<> generiert";
			DataStore[94].CategoryTags = null;
			DataStore[94].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[111],
});
			DataStore[94].Description = @"Parameter wird als List&lt;&gt; generiert";
			DataStore[94].ExportGuid = new Guid("ec4d5dbc-f738-4eb3-a663-2328d0baa79c");
			DataStore[94].IsIndexed = false;
			DataStore[94].IsList = false;
			DataStore[94].IsNullable = false;
			DataStore[94].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[94].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[36];
			DataStore[94].PropertyName = @"IsList";
			DataStore[94].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[13];
			DataStore[94].Seal();
			DataStore[95].AltText = @"Es darf nur ein Return Parameter angegeben werden";
			DataStore[95].CategoryTags = null;
			DataStore[95].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[110],
});
			DataStore[95].Description = @"Es darf nur ein Return Parameter angegeben werden";
			DataStore[95].ExportGuid = new Guid("ba5bfb2e-f679-41b2-93ef-fc795e2e92d4");
			DataStore[95].IsIndexed = false;
			DataStore[95].IsList = false;
			DataStore[95].IsNullable = false;
			DataStore[95].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[95].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[36];
			DataStore[95].PropertyName = @"IsReturnParameter";
			DataStore[95].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[13];
			DataStore[95].Seal();
			DataStore[116].AltText = @"Whether or not this Control can contain other Controls";
			DataStore[116].CategoryTags = null;
			DataStore[116].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[96],
});
			DataStore[116].Description = @"Whether or not this Control can contain other Controls";
			DataStore[116].ExportGuid = new Guid("90f6cf7e-2da3-4d73-9684-157f6a614bf3");
			DataStore[116].IsIndexed = false;
			DataStore[116].IsList = false;
			DataStore[116].IsNullable = false;
			DataStore[116].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[4];
			DataStore[116].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[54];
			DataStore[116].PropertyName = @"IsContainer";
			DataStore[116].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[13];
			DataStore[116].Seal();
			DataStore[119].AltText = @"Setting this to true marks the instances of this class as ""simple."" At first this will only mean that they'll be displayed inline.";
			DataStore[119].CategoryTags = @"DataModel";
			DataStore[119].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[93],
});
			DataStore[119].Description = @"Setting this to true marks the instances of this class as &quot;simple.&quot; At first this will only mean that they'll be displayed inline.";
			DataStore[119].ExportGuid = new Guid("edc853d3-0d02-4492-9159-c548c7713e9b");
			DataStore[119].IsIndexed = false;
			DataStore[119].IsList = false;
			DataStore[119].IsNullable = false;
			DataStore[119].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[4];
			DataStore[119].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[2];
			DataStore[119].PropertyName = @"IsSimpleObject";
			DataStore[119].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[13];
			DataStore[119].Seal();
			DataStore[124].AltText = @"Shows this Method in th GUI";
			DataStore[124].CategoryTags = @"Summary";
			DataStore[124].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[92],
});
			DataStore[124].Description = @"Shows this Method in th GUI";
			DataStore[124].ExportGuid = new Guid("5ac29d6a-9dec-4d88-8f66-59ee7a139f4d");
			DataStore[124].IsIndexed = false;
			DataStore[124].IsList = false;
			DataStore[124].IsNullable = false;
			DataStore[124].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[4];
			DataStore[124].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[10];
			DataStore[124].PropertyName = @"IsDisplayable";
			DataStore[124].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[13];
			DataStore[124].Seal();
			DataStore[174].AltText = @"if true then all Instances appear in FozenContext.";
			DataStore[174].CategoryTags = @"Physical";
			DataStore[174].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[202],
});
			DataStore[174].Description = @"if true then all Instances appear in FozenContext.";
			DataStore[174].ExportGuid = new Guid("13c33710-ea02-4621-ad50-294a1f36b07d");
			DataStore[174].IsIndexed = false;
			DataStore[174].IsList = false;
			DataStore[174].IsNullable = false;
			DataStore[174].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[174].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[2];
			DataStore[174].PropertyName = @"IsFrozenObject";
			DataStore[174].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[13];
			DataStore[174].Seal();
			DataStore[204].AltText = @"Whether or not a list-valued property has a index";
			DataStore[204].CategoryTags = @"DataModel";
			DataStore[204].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[244],
});
			DataStore[204].Description = @"Whether or not a list-valued property has a index";
			DataStore[204].ExportGuid = new Guid("b62c7fee-bb67-46a6-b481-81554e788aa0");
			DataStore[204].IsIndexed = false;
			DataStore[204].IsList = false;
			DataStore[204].IsNullable = false;
			DataStore[204].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[204].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[7];
			DataStore[204].PropertyName = @"IsIndexed";
			DataStore[204].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[13];
			DataStore[204].Seal();
			DataStore[220].AltText = @"Is true, if this RelationEnd persists the order of its elements";
			DataStore[220].CategoryTags = null;
			DataStore[220].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[236],
});
			DataStore[220].Description = @"Is true, if this RelationEnd persists the order of its elements";
			DataStore[220].ExportGuid = new Guid("edd8d122-7b58-4bbb-bf00-33caa8b69cc2");
			DataStore[220].IsIndexed = false;
			DataStore[220].IsList = false;
			DataStore[220].IsNullable = false;
			DataStore[220].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[220].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[82];
			DataStore[220].PropertyName = @"HasPersistentOrder";
			DataStore[220].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[13];
			DataStore[220].Seal();
			DataStore[264].AltText = null;
			DataStore[264].CategoryTags = @"Summary,GUI";
			DataStore[264].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(0) {
});
			DataStore[264].Description = null;
			DataStore[264].ExportGuid = new Guid("60e64ab1-830d-4c20-9d2e-17049738e9c4");
			DataStore[264].IsIndexed = false;
			DataStore[264].IsList = false;
			DataStore[264].IsNullable = false;
			DataStore[264].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[4];
			DataStore[264].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[33];
			DataStore[264].PropertyName = @"ShowNameInLists";
			DataStore[264].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[13];
			DataStore[264].Seal();
			DataStore[265].AltText = null;
			DataStore[265].CategoryTags = @"Summary,GUI";
			DataStore[265].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(0) {
});
			DataStore[265].Description = null;
			DataStore[265].ExportGuid = new Guid("d5b0ff20-10c1-40ce-b18e-9846dc5d0b60");
			DataStore[265].IsIndexed = false;
			DataStore[265].IsList = false;
			DataStore[265].IsNullable = false;
			DataStore[265].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[4];
			DataStore[265].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[33];
			DataStore[265].PropertyName = @"ShowIconInLists";
			DataStore[265].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[13];
			DataStore[265].Seal();
			DataStore[266].AltText = null;
			DataStore[266].CategoryTags = @"Summary,GUI";
			DataStore[266].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(0) {
});
			DataStore[266].Description = null;
			DataStore[266].ExportGuid = new Guid("220925a1-ed82-4b08-a3fa-af31bda7f40e");
			DataStore[266].IsIndexed = false;
			DataStore[266].IsList = false;
			DataStore[266].IsNullable = false;
			DataStore[266].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[4];
			DataStore[266].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[33];
			DataStore[266].PropertyName = @"ShowIdInLists";
			DataStore[266].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[13];
			DataStore[266].Seal();
			DataStore[269].AltText = null;
			DataStore[269].CategoryTags = @"Main";
			DataStore[269].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(0) {
});
			DataStore[269].Description = @"Whether or not this reference should be loaded eagerly";
			DataStore[269].ExportGuid = new Guid("373f0036-42d6-41e2-a2a4-74462537f426");
			DataStore[269].IsIndexed = false;
			DataStore[269].IsList = false;
			DataStore[269].IsNullable = false;
			DataStore[269].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[269].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[14];
			DataStore[269].PropertyName = @"EagerLoading";
			DataStore[269].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[13];
			DataStore[269].Seal();
			DataStore[274].AltText = null;
			DataStore[274].CategoryTags = null;
			DataStore[274].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(0) {
});
			DataStore[274].Description = @"Indicates whether or not the described control is read-only or allows editing.";
			DataStore[274].ExportGuid = new Guid("00000000-0000-0000-0000-000000000000");
			DataStore[274].IsIndexed = false;
			DataStore[274].IsList = false;
			DataStore[274].IsNullable = false;
			DataStore[274].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[4];
			DataStore[274].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[83];
			DataStore[274].PropertyName = @"IsReadOnly";
			DataStore[274].ValueModelDescriptor = Kistl.App.GUI.PresentableModelDescriptor__Implementation__Frozen.DataStore[13];
			DataStore[274].Seal();
	
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
        public override void ToStream(System.Xml.XmlWriter xml)
        {
            throw new NotImplementedException();
        }
        public override void FromStream(System.Xml.XmlReader xml)
        {
            throw new NotImplementedException();
        }
        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            throw new NotImplementedException();
        }
        public override void MergeImport(System.Xml.XmlReader xml)
        {
            throw new NotImplementedException();
        }

#endregion

    }


}