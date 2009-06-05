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

    using Kistl.API.Client;
    using Kistl.DalProvider.ClientObjects;

    /// <summary>
    /// Metadefinition Object for an Enumeration Entry.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("EnumerationEntry")]
    public class EnumerationEntry__Implementation__ : BaseClientDataObject_ClientObjects, EnumerationEntry
    {
    
		public EnumerationEntry__Implementation__()
		{
            {
            }
        }


        /// <summary>
        /// Description of this Enumeration Entry
        /// </summary>
        // value type property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_Description != value)
                {
					var __oldValue = _Description;
                    NotifyPropertyChanging("Description", __oldValue, value);
                    _Description = value;
                    NotifyPropertyChanged("Description", __oldValue, value);
                }
            }
        }
        private string _Description;

        /// <summary>
        /// Übergeordnete Enumeration
        /// </summary>
        // object reference property
		// Kistl.Server.Generators.ClientObjects.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Enumeration Enumeration
        {
            get
            {
                if (_fk_Enumeration.HasValue)
                    return Context.Find<Kistl.App.Base.Enumeration>(_fk_Enumeration.Value);
                else
                    return null;
            }
            set
            {
                // TODO: only accept objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                
                // shortcut noops
                if (value == null && _fk_Enumeration == null)
					return;
                else if (value != null && value.ID == _fk_Enumeration)
					return;
			           
	            // cache old value to remove inverse references later
                var oldValue = Enumeration;

				// Changing Event fires before anything is touched
				NotifyPropertyChanging("Enumeration", oldValue, value);
                
				// next, set the local reference
                _fk_Enumeration = value == null ? (int?)null : value.ID;
				
				// now fixup redundant, inverse references
				// The inverse navigator will also fire events when changed, so should 
				// only be touched after setting the local value above. 
				// TODO: for complete correctness, the "other" Changing event should also fire 
				//       before the local value is changed
				if (oldValue != null)
				{
					// remove from old list
					(oldValue.EnumerationEntries as OneNRelationCollection<Kistl.App.Base.EnumerationEntry>).RemoveWithoutClearParent(this);
				}

                if (value != null)
                {
					// add to new list
					(value.EnumerationEntries as OneNRelationCollection<Kistl.App.Base.EnumerationEntry>).AddWithoutSetParent(this);
                }
				// everything is done. fire the Changed event
				NotifyPropertyChanged("Enumeration", oldValue, value);
            }
        }
        
        private int? _fk_Enumeration;

        /// <summary>
        /// CLR name of this entry
        /// </summary>
        // value type property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_Name != value)
                {
					var __oldValue = _Name;
                    NotifyPropertyChanging("Name", __oldValue, value);
                    _Name = value;
                    NotifyPropertyChanged("Name", __oldValue, value);
                }
            }
        }
        private string _Name;

        /// <summary>
        /// The CLR value of this entry
        /// </summary>
        // value type property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual int Value
        {
            get
            {
                return _Value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_Value != value)
                {
					var __oldValue = _Value;
                    NotifyPropertyChanging("Value", __oldValue, value);
                    _Value = value;
                    NotifyPropertyChanged("Value", __oldValue, value);
                }
            }
        }
        private int _Value;

		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(EnumerationEntry));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (EnumerationEntry)obj;
			var otherImpl = (EnumerationEntry__Implementation__)obj;
			var me = (EnumerationEntry)this;

			me.Description = other.Description;
			me.Name = other.Name;
			me.Value = other.Value;
			this._fk_Enumeration = otherImpl._fk_Enumeration;
		}

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

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


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "Description":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(178).Constraints
						.Where(c => !c.IsValid(this, this.Description))
						.Select(c => c.GetErrorText(this, this.Description))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Enumeration":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(100).Constraints
						.Where(c => !c.IsValid(this, this.Enumeration))
						.Select(c => c.GetErrorText(this, this.Enumeration))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Name":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(136).Constraints
						.Where(c => !c.IsValid(this, this.Name))
						.Select(c => c.GetErrorText(this, this.Name))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Value":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(135).Constraints
						.Where(c => !c.IsValid(this, this.Value))
						.Select(c => c.GetErrorText(this, this.Value))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}

		public override void UpdateParent(string propertyName, int? id)
		{
			switch(propertyName)
			{
                case "Enumeration":
                    _fk_Enumeration = id;
                    break;
				default:
					base.UpdateParent(propertyName, id);
					break;
			}
		}

#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._Description, binStream);
            BinarySerializer.ToStream(this._fk_Enumeration, binStream);
            BinarySerializer.ToStream(this._Name, binStream);
            BinarySerializer.ToStream(this._Value, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._Description, binStream);
            BinarySerializer.FromStream(out this._fk_Enumeration, binStream);
            BinarySerializer.FromStream(out this._Name, binStream);
            BinarySerializer.FromStream(out this._Value, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.ToStream(this._fk_Enumeration, xml, "Enumeration", "http://dasz.at/Kistl");
            XmlStreamer.ToStream(this._Name, xml, "Name", "Kistl.App.Base");
            XmlStreamer.ToStream(this._Value, xml, "Value", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._Description, xml, "Description", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_Enumeration, xml, "Enumeration", "http://dasz.at/Kistl");
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Value, xml, "Value", "Kistl.App.Base");
        }

#endregion

    }


}