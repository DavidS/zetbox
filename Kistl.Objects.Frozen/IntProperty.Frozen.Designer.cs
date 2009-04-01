
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
    /// Metadefinition Object for Int Properties.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("IntProperty")]
    public class IntProperty__Implementation__Frozen : Kistl.App.Base.ValueTypeProperty__Implementation__Frozen, IntProperty
    {
    
		public IntProperty__Implementation__Frozen()
		{
        }


        /// <summary>
        /// 
        /// </summary>

		public override string GetGUIRepresentation() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetGUIRepresentation_IntProperty != null)
            {
                OnGetGUIRepresentation_IntProperty(this, e);
            }
            else
            {
                e.Result = base.GetGUIRepresentation();
            }
            return e.Result;
        }
		public event GetGUIRepresentation_Handler<IntProperty> OnGetGUIRepresentation_IntProperty;



        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>

		public override System.Type GetPropertyType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_IntProperty != null)
            {
                OnGetPropertyType_IntProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
		public event GetPropertyType_Handler<IntProperty> OnGetPropertyType_IntProperty;



        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>

		public override string GetPropertyTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_IntProperty != null)
            {
                OnGetPropertyTypeString_IntProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
		public event GetPropertyTypeString_Handler<IntProperty> OnGetPropertyTypeString_IntProperty;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(IntProperty));
		}

        // tail template

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_IntProperty != null)
            {
                OnToString_IntProperty(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<IntProperty> OnToString_IntProperty;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_IntProperty != null) OnPreSave_IntProperty(this);
        }
        public event ObjectEventHandler<IntProperty> OnPreSave_IntProperty;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_IntProperty != null) OnPostSave_IntProperty(this);
        }
        public event ObjectEventHandler<IntProperty> OnPostSave_IntProperty;


        internal IntProperty__Implementation__Frozen(int id)
            : base(id)
        { }


		internal new static Dictionary<int, IntProperty__Implementation__Frozen> DataStore = new Dictionary<int, IntProperty__Implementation__Frozen>(8);
		internal new static void CreateInstances()
		{
			Kistl.App.Base.Property__Implementation__Frozen.DataStore[28] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[28] = 
			DataStore[28] = new IntProperty__Implementation__Frozen(28);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[126] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[126] = 
			DataStore[126] = new IntProperty__Implementation__Frozen(126);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[135] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[135] = 
			DataStore[135] = new IntProperty__Implementation__Frozen(135);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[168] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[168] = 
			DataStore[168] = new IntProperty__Implementation__Frozen(168);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[169] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[169] = 
			DataStore[169] = new IntProperty__Implementation__Frozen(169);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[172] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[172] = 
			DataStore[172] = new IntProperty__Implementation__Frozen(172);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[173] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[173] = 
			DataStore[173] = new IntProperty__Implementation__Frozen(173);

			Kistl.App.Base.Property__Implementation__Frozen.DataStore[217] = 
			Kistl.App.Base.ValueTypeProperty__Implementation__Frozen.DataStore[217] = 
			DataStore[217] = new IntProperty__Implementation__Frozen(217);

		}

		internal new static void FillDataStore() {
			DataStore[28].AltText = null;
			DataStore[28].CategoryTags = @"DataModel";
			DataStore[28].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(2) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[147],
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[212],
});
			DataStore[28].Description = null;
			DataStore[28].IsIndexed = false;
			DataStore[28].IsList = false;
			DataStore[28].IsNullable = false;
			DataStore[28].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[28].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[9];
			DataStore[28].PropertyName = @"Length";
			DataStore[28].Seal();
			DataStore[126].AltText = @"test";
			DataStore[126].CategoryTags = null;
			DataStore[126].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(0) {
});
			DataStore[126].Description = @"test";
			DataStore[126].IsIndexed = false;
			DataStore[126].IsList = false;
			DataStore[126].IsNullable = true;
			DataStore[126].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[5];
			DataStore[126].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[51];
			DataStore[126].PropertyName = @"MyIntProperty";
			DataStore[126].Seal();
			DataStore[135].AltText = @"The CLR value of this entry";
			DataStore[135].CategoryTags = null;
			DataStore[135].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[89],
});
			DataStore[135].Description = @"The CLR value of this entry";
			DataStore[135].IsIndexed = false;
			DataStore[135].IsList = false;
			DataStore[135].IsNullable = false;
			DataStore[135].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[135].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[46];
			DataStore[135].PropertyName = @"Value";
			DataStore[135].Seal();
			DataStore[168].AltText = @"The biggest value accepted by this constraint";
			DataStore[168].CategoryTags = null;
			DataStore[168].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[76],
});
			DataStore[168].Description = @"The biggest value accepted by this constraint";
			DataStore[168].IsIndexed = false;
			DataStore[168].IsList = false;
			DataStore[168].IsNullable = false;
			DataStore[168].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[168].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[71];
			DataStore[168].PropertyName = @"Max";
			DataStore[168].Seal();
			DataStore[169].AltText = @"The smallest value accepted by this constraint";
			DataStore[169].CategoryTags = null;
			DataStore[169].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[75],
});
			DataStore[169].Description = @"The smallest value accepted by this constraint";
			DataStore[169].IsIndexed = false;
			DataStore[169].IsList = false;
			DataStore[169].IsNullable = false;
			DataStore[169].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[169].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[71];
			DataStore[169].PropertyName = @"Min";
			DataStore[169].Seal();
			DataStore[172].AltText = @"The maximal length of this StringProperty";
			DataStore[172].CategoryTags = null;
			DataStore[172].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(2) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[148],
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[151],
});
			DataStore[172].Description = @"The maximal length of this StringProperty";
			DataStore[172].IsIndexed = false;
			DataStore[172].IsList = false;
			DataStore[172].IsNullable = false;
			DataStore[172].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[172].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[73];
			DataStore[172].PropertyName = @"MaxLength";
			DataStore[172].Seal();
			DataStore[173].AltText = @"The minimal length of this StringProperty";
			DataStore[173].CategoryTags = null;
			DataStore[173].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(2) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[149],
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[150],
});
			DataStore[173].Description = @"The minimal length of this StringProperty";
			DataStore[173].IsIndexed = false;
			DataStore[173].IsList = false;
			DataStore[173].IsNullable = false;
			DataStore[173].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[173].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[73];
			DataStore[173].PropertyName = @"MinLength";
			DataStore[173].Seal();
			DataStore[217].AltText = @"Which RelationEndRole this End has";
			DataStore[217].CategoryTags = null;
			DataStore[217].Constraints = new System.Collections.ObjectModel.ReadOnlyCollection<Kistl.App.Base.Constraint>(new List<Kistl.App.Base.Constraint>(1) {
Kistl.App.Base.Constraint__Implementation__Frozen.DataStore[216],
});
			DataStore[217].Description = @"Which RelationEndRole this End has";
			DataStore[217].IsIndexed = false;
			DataStore[217].IsList = false;
			DataStore[217].IsNullable = false;
			DataStore[217].Module = Kistl.App.Base.Module__Implementation__Frozen.DataStore[1];
			DataStore[217].ObjectClass = Kistl.App.Base.DataType__Implementation__Frozen.DataStore[82];
			DataStore[217].PropertyName = @"Role";
			DataStore[217].Seal();
	
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