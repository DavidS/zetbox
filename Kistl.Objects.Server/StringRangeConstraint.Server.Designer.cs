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

    using Kistl.API.Server;
    using Kistl.DALProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="StringRangeConstraint")]
    [System.Diagnostics.DebuggerDisplay("StringRangeConstraint")]
    public class StringRangeConstraint__Implementation__ : Kistl.App.Base.Constraint__Implementation__, StringRangeConstraint
    {
    
		public StringRangeConstraint__Implementation__()
		{
        }


        /// <summary>
        /// The maximal length of this StringProperty
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual int MaxLength
        {
            get
            {
				var __value = _MaxLength;
				if(OnMaxLength_Getter != null)
				{
					var e = new PropertyGetterEventArgs<int>(__value);
					OnMaxLength_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_MaxLength != value)
                {
					var __oldValue = _MaxLength;
					var __newValue = value;
                    if(OnMaxLength_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
						OnMaxLength_PreSetter(this, e);
						__newValue = e.Result;
                    }
                    NotifyPropertyChanging("MaxLength", __oldValue, __newValue);
                    _MaxLength = __newValue;
                    NotifyPropertyChanged("MaxLength", __oldValue, __newValue);

                    if(OnMaxLength_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
						OnMaxLength_PostSetter(this, e);
                    }
                }
            }
        }
        private int _MaxLength;
		public event PropertyGetterHandler<Kistl.App.Base.StringRangeConstraint, int> OnMaxLength_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.StringRangeConstraint, int> OnMaxLength_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.StringRangeConstraint, int> OnMaxLength_PostSetter;
        /// <summary>
        /// The minimal length of this StringProperty
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual int MinLength
        {
            get
            {
				var __value = _MinLength;
				if(OnMinLength_Getter != null)
				{
					var e = new PropertyGetterEventArgs<int>(__value);
					OnMinLength_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_MinLength != value)
                {
					var __oldValue = _MinLength;
					var __newValue = value;
                    if(OnMinLength_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
						OnMinLength_PreSetter(this, e);
						__newValue = e.Result;
                    }
                    NotifyPropertyChanging("MinLength", __oldValue, __newValue);
                    _MinLength = __newValue;
                    NotifyPropertyChanged("MinLength", __oldValue, __newValue);

                    if(OnMinLength_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
						OnMinLength_PostSetter(this, e);
                    }
                }
            }
        }
        private int _MinLength;
		public event PropertyGetterHandler<Kistl.App.Base.StringRangeConstraint, int> OnMinLength_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.StringRangeConstraint, int> OnMinLength_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.StringRangeConstraint, int> OnMinLength_PostSetter;
        /// <summary>
        /// 
        /// </summary>

		public override string GetErrorText(System.Object constrainedObject, System.Object constrainedValue) 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetErrorText_StringRangeConstraint != null)
            {
                OnGetErrorText_StringRangeConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.GetErrorText(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
		public event GetErrorText_Handler<StringRangeConstraint> OnGetErrorText_StringRangeConstraint;



        /// <summary>
        /// 
        /// </summary>

		public override bool IsValid(System.Object constrainedObject, System.Object constrainedValue) 
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnIsValid_StringRangeConstraint != null)
            {
                OnIsValid_StringRangeConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.IsValid(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
		public event IsValid_Handler<StringRangeConstraint> OnIsValid_StringRangeConstraint;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(StringRangeConstraint));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (StringRangeConstraint)obj;
			var otherImpl = (StringRangeConstraint__Implementation__)obj;
			var me = (StringRangeConstraint)this;

			me.MaxLength = other.MaxLength;
			me.MinLength = other.MinLength;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_StringRangeConstraint != null)
            {
                OnToString_StringRangeConstraint(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<StringRangeConstraint> OnToString_StringRangeConstraint;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_StringRangeConstraint != null) OnPreSave_StringRangeConstraint(this);
        }
        public event ObjectEventHandler<StringRangeConstraint> OnPreSave_StringRangeConstraint;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_StringRangeConstraint != null) OnPostSave_StringRangeConstraint(this);
        }
        public event ObjectEventHandler<StringRangeConstraint> OnPostSave_StringRangeConstraint;

        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_StringRangeConstraint != null) OnCreated_StringRangeConstraint(this);
        }
        public event ObjectEventHandler<StringRangeConstraint> OnCreated_StringRangeConstraint;

        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_StringRangeConstraint != null) OnDeleting_StringRangeConstraint(this);
        }
        public event ObjectEventHandler<StringRangeConstraint> OnDeleting_StringRangeConstraint;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "MaxLength":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("17aa679d-72d0-480e-9bd9-b37f4eba1d68")).Constraints
						.Where(c => !c.IsValid(this, this.MaxLength))
						.Select(c => c.GetErrorText(this, this.MaxLength))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "MinLength":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("8d3e24f7-c8c8-4bb3-931e-d0452e7ee5b6")).Constraints
						.Where(c => !c.IsValid(this, this.MinLength))
						.Select(c => c.GetErrorText(this, this.MinLength))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}

		public override void ReloadReferences()
		{
			base.ReloadReferences();
			
			// fix direct object references
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._MaxLength, binStream);
            BinarySerializer.ToStream(this._MinLength, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._MaxLength, binStream);
            BinarySerializer.FromStream(out this._MinLength, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._MaxLength, xml, "MaxLength", "Kistl.App.Base");
            XmlStreamer.ToStream(this._MinLength, xml, "MinLength", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._MaxLength, xml, "MaxLength", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._MinLength, xml, "MinLength", "Kistl.App.Base");
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
			
            base.Export(xml, modules);
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._MaxLength, xml, "MaxLength", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._MinLength, xml, "MinLength", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
			
            base.MergeImport(xml);
            XmlStreamer.FromStream(ref this._MaxLength, xml, "MaxLength", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._MinLength, xml, "MinLength", "Kistl.App.Base");
        }

#endregion

    }


}