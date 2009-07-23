// <autogenerated/>


namespace Kistl.App.TimeRecords
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
    /// An account of work efforts. May be used to limit the hours being expended.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="WorkEffortAccount")]
    [System.Diagnostics.DebuggerDisplay("WorkEffortAccount")]
    public class WorkEffortAccount__Implementation__ : BaseServerDataObject_EntityFramework, WorkEffortAccount
    {
    
		public WorkEffortAccount__Implementation__()
		{
            {
            }
        }

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.IdProperty
        public override int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_ID != value)
                {
					var __oldValue = _ID;
                    NotifyPropertyChanging("ID", __oldValue, value);
                    _ID = value;
                    NotifyPropertyChanged("ID", __oldValue, value);
                }
            }
        }
        private int _ID;

        /// <summary>
        /// Maximal erlaubte Stundenanzahl
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual double? BudgetHours
        {
            get
            {
                return _BudgetHours;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_BudgetHours != value)
                {
					var __oldValue = _BudgetHours;
                    NotifyPropertyChanging("BudgetHours", __oldValue, value);
                    _BudgetHours = value;
                    NotifyPropertyChanged("BudgetHours", __oldValue, value);
                }
            }
        }
        private double? _BudgetHours;

        /// <summary>
        /// Zugeordnete Mitarbeiter
        /// </summary>
    /*
    Relation: FK_WorkEffortAccount_has_Mitarbeiter
    A: ZeroOrMore WorkEffortAccount as WorkEffortAccount
    B: ZeroOrMore Mitarbeiter as Mitarbeiter
    Preferred Storage: Separate
    */
        // collection reference property
		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Projekte.Mitarbeiter> Mitarbeiter
        {
            get
            {
                if (_MitarbeiterWrapper == null)
                {
                    _MitarbeiterWrapper = new EntityRelationBSideCollectionWrapper<Kistl.App.TimeRecords.WorkEffortAccount, Kistl.App.Projekte.Mitarbeiter, Kistl.App.TimeRecords.WorkEffortAccount_has_Mitarbeiter_RelationEntry__Implementation__>(
                            this,
                            Mitarbeiter__Implementation__);
                }
                return _MitarbeiterWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_WorkEffortAccount_has_Mitarbeiter_WorkEffortAccount", "CollectionEntry")]
        public EntityCollection<Kistl.App.TimeRecords.WorkEffortAccount_has_Mitarbeiter_RelationEntry__Implementation__> Mitarbeiter__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.TimeRecords.WorkEffortAccount_has_Mitarbeiter_RelationEntry__Implementation__>(
                        "Model.FK_WorkEffortAccount_has_Mitarbeiter_WorkEffortAccount",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                return c;
            }
        }
        private EntityRelationBSideCollectionWrapper<Kistl.App.TimeRecords.WorkEffortAccount, Kistl.App.Projekte.Mitarbeiter, Kistl.App.TimeRecords.WorkEffortAccount_has_Mitarbeiter_RelationEntry__Implementation__> _MitarbeiterWrapper;


        /// <summary>
        /// Name des TimeRecordsskontos
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
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
        /// Space for notes
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual string Notes
        {
            get
            {
                return _Notes;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Notes != value)
                {
					var __oldValue = _Notes;
                    NotifyPropertyChanging("Notes", __oldValue, value);
                    _Notes = value;
                    NotifyPropertyChanged("Notes", __oldValue, value);
                }
            }
        }
        private string _Notes;

        /// <summary>
        /// Aktuell gebuchte Stunden
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingValueProperty
        public virtual double? SpentHours
        {
            get
            {
                return _SpentHours;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_SpentHours != value)
                {
					var __oldValue = _SpentHours;
                    NotifyPropertyChanging("SpentHours", __oldValue, value);
                    _SpentHours = value;
                    NotifyPropertyChanged("SpentHours", __oldValue, value);
                }
            }
        }
        private double? _SpentHours;

		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(WorkEffortAccount));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (WorkEffortAccount)obj;
			var otherImpl = (WorkEffortAccount__Implementation__)obj;
			var me = (WorkEffortAccount)this;

			me.BudgetHours = other.BudgetHours;
			me.Name = other.Name;
			me.Notes = other.Notes;
			me.SpentHours = other.SpentHours;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_WorkEffortAccount != null)
            {
                OnToString_WorkEffortAccount(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<WorkEffortAccount> OnToString_WorkEffortAccount;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_WorkEffortAccount != null) OnPreSave_WorkEffortAccount(this);
        }
        public event ObjectEventHandler<WorkEffortAccount> OnPreSave_WorkEffortAccount;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_WorkEffortAccount != null) OnPostSave_WorkEffortAccount(this);
        }
        public event ObjectEventHandler<WorkEffortAccount> OnPostSave_WorkEffortAccount;

        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_WorkEffortAccount != null) OnCreated_WorkEffortAccount(this);
        }
        public event ObjectEventHandler<WorkEffortAccount> OnCreated_WorkEffortAccount;

        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_WorkEffortAccount != null) OnDeleting_WorkEffortAccount(this);
        }
        public event ObjectEventHandler<WorkEffortAccount> OnDeleting_WorkEffortAccount;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "BudgetHours":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(52).Constraints
						.Where(c => !c.IsValid(this, this.BudgetHours))
						.Select(c => c.GetErrorText(this, this.BudgetHours))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Mitarbeiter":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(67).Constraints
						.Where(c => !c.IsValid(this, this.Mitarbeiter))
						.Select(c => c.GetErrorText(this, this.Mitarbeiter))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Name":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(151).Constraints
						.Where(c => !c.IsValid(this, this.Name))
						.Select(c => c.GetErrorText(this, this.Name))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Notes":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(134).Constraints
						.Where(c => !c.IsValid(this, this.Notes))
						.Select(c => c.GetErrorText(this, this.Notes))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "SpentHours":
				{
					var errors = FrozenContext.Single.Find<Kistl.App.Base.Property>(59).Constraints
						.Where(c => !c.IsValid(this, this.SpentHours))
						.Select(c => c.GetErrorText(this, this.SpentHours))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}

		public override void ReloadReferences()
		{
			// fix direct object references
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._BudgetHours, binStream);
            BinarySerializer.ToStream(this._Name, binStream);
            BinarySerializer.ToStream(this._Notes, binStream);
            BinarySerializer.ToStream(this._SpentHours, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._BudgetHours, binStream);
            BinarySerializer.FromStream(out this._Name, binStream);
            BinarySerializer.FromStream(out this._Notes, binStream);
            BinarySerializer.FromStream(out this._SpentHours, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._BudgetHours, xml, "BudgetHours", "Kistl.App.TimeRecords");
            XmlStreamer.ToStream(this._Name, xml, "Name", "Kistl.App.TimeRecords");
            XmlStreamer.ToStream(this._Notes, xml, "Notes", "Kistl.App.TimeRecords");
            XmlStreamer.ToStream(this._SpentHours, xml, "SpentHours", "Kistl.App.TimeRecords");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._BudgetHours, xml, "BudgetHours", "Kistl.App.TimeRecords");
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "Kistl.App.TimeRecords");
            XmlStreamer.FromStream(ref this._Notes, xml, "Notes", "Kistl.App.TimeRecords");
            XmlStreamer.FromStream(ref this._SpentHours, xml, "SpentHours", "Kistl.App.TimeRecords");
        }

#endregion

    }


}