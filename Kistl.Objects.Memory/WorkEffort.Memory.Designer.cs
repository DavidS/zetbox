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

    using Kistl.DalProvider.Memory;

    /// <summary>
    /// A defined work effort of an employee.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("WorkEffort")]
    public class WorkEffort__Implementation__Memory : BaseMemoryDataObject, WorkEffort
    {
        [Obsolete]
        public WorkEffort__Implementation__Memory()
            : base(null)
        {
            {
            }
        }

        public WorkEffort__Implementation__Memory(Func<IReadOnlyKistlContext> lazyCtx)
            : base(lazyCtx)
        {
            {
            }
        }


        /// <summary>
        /// Point in time when the work effort started.
        /// </summary>
        // value type property
           // Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual DateTime From
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _From;
                if (OnFrom_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime>(__result);
                    OnFrom_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_From != value)
                {
                    var __oldValue = _From;
                    var __newValue = value;
                    if(OnFrom_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime>(__oldValue, __newValue);
                        OnFrom_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("From", __oldValue, __newValue);
                    _From = __newValue;
                    NotifyPropertyChanged("From", __oldValue, __newValue);
                    if(OnFrom_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime>(__oldValue, __newValue);
                        OnFrom_PostSetter(this, __e);
                    }
                }
            }
        }
        private DateTime _From;
		public static event PropertyGetterHandler<Kistl.App.TimeRecords.WorkEffort, DateTime> OnFrom_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.TimeRecords.WorkEffort, DateTime> OnFrom_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.TimeRecords.WorkEffort, DateTime> OnFrom_PostSetter;

        /// <summary>
        /// Which employee effected this work effort.
        /// </summary>
        // object reference property
		// BEGIN Kistl.DalProvider.Memory.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate for Mitarbeiter
		// rel(A): WorkEffort has Mitarbeiter
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Projekte.Mitarbeiter Mitarbeiter
        {
            get
            {
				Kistl.App.Projekte.Mitarbeiter __value;
                if (_fk_Mitarbeiter.HasValue)
                    __value = Context.Find<Kistl.App.Projekte.Mitarbeiter>(_fk_Mitarbeiter.Value);
                else
                    __value = null;

				if(OnMitarbeiter_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Projekte.Mitarbeiter>(__value);
					OnMitarbeiter_Getter(this, e);
					__value = e.Result;
				}
                    
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                
                // shortcut noops
                if (value == null && _fk_Mitarbeiter == null)
					return;
                else if (value != null && value.ID == _fk_Mitarbeiter)
					return;
			           
	            // cache old value to remove inverse references later
                var __oldValue = Mitarbeiter;
				var __newValue = value;

				// Changing Event fires before anything is touched
				NotifyPropertyChanging("Mitarbeiter", __oldValue, __newValue);
				
                if(OnMitarbeiter_PreSetter != null && IsAttached)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Projekte.Mitarbeiter>(__oldValue, __newValue);
					OnMitarbeiter_PreSetter(this, e);
					__newValue = e.Result;
                }
                
				// next, set the local reference
                _fk_Mitarbeiter = __newValue == null ? (int?)null : __newValue.ID;
				
				// everything is done. fire the Changed event
				NotifyPropertyChanged("Mitarbeiter", __oldValue, __newValue);

                if(OnMitarbeiter_PostSetter != null && IsAttached)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Projekte.Mitarbeiter>(__oldValue, __newValue);
					OnMitarbeiter_PostSetter(this, e);
                }
                
            }
        }
        
        // normalize namespace for Templates
        private Kistl.App.Projekte.Mitarbeiter Mitarbeiter__Implementation__
        {
			get
			{
				return Mitarbeiter;
			}
			set
			{
				Mitarbeiter = value;
			}
		}
        
        private int? _fk_Mitarbeiter;
        private Guid? _fk_guid_Mitarbeiter = null;
		// END Kistl.DalProvider.Memory.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate for Mitarbeiter
		public static event PropertyGetterHandler<Kistl.App.TimeRecords.WorkEffort, Kistl.App.Projekte.Mitarbeiter> OnMitarbeiter_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.TimeRecords.WorkEffort, Kistl.App.Projekte.Mitarbeiter> OnMitarbeiter_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.TimeRecords.WorkEffort, Kistl.App.Projekte.Mitarbeiter> OnMitarbeiter_PostSetter;

        /// <summary>
        /// A short label describing this work effort.
        /// </summary>
        // value type property
           // Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string Name
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Name;
                if (OnName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Name != value)
                {
                    var __oldValue = _Name;
                    var __newValue = value;
                    if(OnName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Name", __oldValue, __newValue);
                    _Name = __newValue;
                    NotifyPropertyChanged("Name", __oldValue, __newValue);
                    if(OnName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Name;
		public static event PropertyGetterHandler<Kistl.App.TimeRecords.WorkEffort, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.TimeRecords.WorkEffort, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.TimeRecords.WorkEffort, string> OnName_PostSetter;

        /// <summary>
        /// Space for notes
        /// </summary>
        // value type property
           // Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string Notes
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Notes;
                if (OnNotes_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnNotes_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Notes != value)
                {
                    var __oldValue = _Notes;
                    var __newValue = value;
                    if(OnNotes_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnNotes_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Notes", __oldValue, __newValue);
                    _Notes = __newValue;
                    NotifyPropertyChanged("Notes", __oldValue, __newValue);
                    if(OnNotes_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnNotes_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Notes;
		public static event PropertyGetterHandler<Kistl.App.TimeRecords.WorkEffort, string> OnNotes_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.TimeRecords.WorkEffort, string> OnNotes_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.TimeRecords.WorkEffort, string> OnNotes_PostSetter;

        /// <summary>
        /// Point in time (inclusive) when the work effort ended.
        /// </summary>
        // value type property
           // Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual DateTime? Thru
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Thru;
                if (OnThru_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime?>(__result);
                    OnThru_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Thru != value)
                {
                    var __oldValue = _Thru;
                    var __newValue = value;
                    if(OnThru_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnThru_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Thru", __oldValue, __newValue);
                    _Thru = __newValue;
                    NotifyPropertyChanged("Thru", __oldValue, __newValue);
                    if(OnThru_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnThru_PostSetter(this, __e);
                    }
                }
            }
        }
        private DateTime? _Thru;
		public static event PropertyGetterHandler<Kistl.App.TimeRecords.WorkEffort, DateTime?> OnThru_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.TimeRecords.WorkEffort, DateTime?> OnThru_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.TimeRecords.WorkEffort, DateTime?> OnThru_PostSetter;

        public override Type GetImplementedInterface()
        {
            return typeof(WorkEffort);
        }

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (WorkEffort)obj;
			var otherImpl = (WorkEffort__Implementation__Memory)obj;
			var me = (WorkEffort)this;

			me.From = other.From;
			me.Name = other.Name;
			me.Notes = other.Notes;
			me.Thru = other.Thru;
			this._fk_Mitarbeiter = otherImpl._fk_Mitarbeiter;
		}

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
		}

		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
			// fix direct object references

			if (_fk_guid_Mitarbeiter.HasValue)
				Mitarbeiter__Implementation__ = (Kistl.App.Projekte.Mitarbeiter__Implementation__Memory)Context.FindPersistenceObject<Kistl.App.Projekte.Mitarbeiter>(_fk_guid_Mitarbeiter.Value);
			else if (_fk_Mitarbeiter.HasValue)
				Mitarbeiter__Implementation__ = (Kistl.App.Projekte.Mitarbeiter__Implementation__Memory)Context.Find<Kistl.App.Projekte.Mitarbeiter>(_fk_Mitarbeiter.Value);
			else
				Mitarbeiter__Implementation__ = null;
		}
        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_WorkEffort")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_WorkEffort != null)
            {
                OnToString_WorkEffort(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<WorkEffort> OnToString_WorkEffort;

        [EventBasedMethod("OnPreSave_WorkEffort")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_WorkEffort != null) OnPreSave_WorkEffort(this);
        }
        public static event ObjectEventHandler<WorkEffort> OnPreSave_WorkEffort;

        [EventBasedMethod("OnPostSave_WorkEffort")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_WorkEffort != null) OnPostSave_WorkEffort(this);
        }
        public static event ObjectEventHandler<WorkEffort> OnPostSave_WorkEffort;

        [EventBasedMethod("OnCreated_WorkEffort")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_WorkEffort != null) OnCreated_WorkEffort(this);
        }
        public static event ObjectEventHandler<WorkEffort> OnCreated_WorkEffort;

        [EventBasedMethod("OnDeleting_WorkEffort")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_WorkEffort != null) OnDeleting_WorkEffort(this);
        }
        public static event ObjectEventHandler<WorkEffort> OnDeleting_WorkEffort;


		private static readonly object _propertiesLock = new object();
		private static System.ComponentModel.PropertyDescriptor[] _properties;
		
		private void _InitializePropertyDescriptors(Func<IReadOnlyKistlContext> lazyCtx)
		{
			if (_properties != null) return;
			lock (_propertiesLock)
			{
				// recheck for a lost race after aquiring the lock
				if (_properties != null) return;
				
				_properties = new System.ComponentModel.PropertyDescriptor[] {
					// else
					new CustomPropertyDescriptor<WorkEffort__Implementation__Memory, DateTime>(
						lazyCtx,
						new Guid("b169f505-9b5f-4e4e-ae25-a46bc9926c87"),
						"From",
						null,
						obj => obj.From,
						(obj, val) => obj.From = val),
					// else
					new CustomPropertyDescriptor<WorkEffort__Implementation__Memory, Kistl.App.Projekte.Mitarbeiter>(
						lazyCtx,
						new Guid("720f5bcf-5654-4114-8fba-f57fb7bd48ea"),
						"Mitarbeiter",
						null,
						obj => obj.Mitarbeiter,
						(obj, val) => obj.Mitarbeiter = val),
					// else
					new CustomPropertyDescriptor<WorkEffort__Implementation__Memory, string>(
						lazyCtx,
						new Guid("a96df76c-c45c-4d21-8221-8c7deaac4814"),
						"Name",
						null,
						obj => obj.Name,
						(obj, val) => obj.Name = val),
					// else
					new CustomPropertyDescriptor<WorkEffort__Implementation__Memory, string>(
						lazyCtx,
						new Guid("1744a31b-a1c3-4e7c-834c-504521240478"),
						"Notes",
						null,
						obj => obj.Notes,
						(obj, val) => obj.Notes = val),
					// else
					new CustomPropertyDescriptor<WorkEffort__Implementation__Memory, DateTime?>(
						lazyCtx,
						new Guid("553440f1-3b22-402b-ba5b-355f21cc31d9"),
						"Thru",
						null,
						obj => obj.Thru,
						(obj, val) => obj.Thru = val),
					// rel: WorkEffort has Mitarbeiter (3963b6bc-bb5a-4615-b4db-56eecd9d3f97)
				};
			}
		}
		
		protected override void CollectProperties(Func<IReadOnlyKistlContext> lazyCtx, List<System.ComponentModel.PropertyDescriptor> props)
		{
			base.CollectProperties(props);
			_InitializePropertyDescriptors(lazyCtx);
			props.AddRange(_properties);
		}
	

		public override void UpdateParent(string propertyName, int? id)
		{
			int? __oldValue, __newValue = id;
			
			switch(propertyName)
			{
                case "Mitarbeiter":
                    __oldValue = _fk_Mitarbeiter;
                    NotifyPropertyChanging("Mitarbeiter", __oldValue, __newValue);
                    _fk_Mitarbeiter = __newValue;
                    NotifyPropertyChanged("Mitarbeiter", __oldValue, __newValue);
                    break;
				default:
					base.UpdateParent(propertyName, id);
					break;
			}
		}

#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this._From, binStream);
            BinarySerializer.ToStream(this._fk_Mitarbeiter, binStream);
            BinarySerializer.ToStream(this._Name, binStream);
            BinarySerializer.ToStream(this._Notes, binStream);
            BinarySerializer.ToStream(this._Thru, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._From, binStream);
            BinarySerializer.FromStream(out this._fk_Mitarbeiter, binStream);
            BinarySerializer.FromStream(out this._Name, binStream);
            BinarySerializer.FromStream(out this._Notes, binStream);
            BinarySerializer.FromStream(out this._Thru, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(this._From, xml, "From", "Kistl.App.TimeRecords");
            XmlStreamer.ToStream(this._fk_Mitarbeiter, xml, "Mitarbeiter", "Kistl.App.TimeRecords");
            XmlStreamer.ToStream(this._Name, xml, "Name", "Kistl.App.TimeRecords");
            XmlStreamer.ToStream(this._Notes, xml, "Notes", "Kistl.App.TimeRecords");
            XmlStreamer.ToStream(this._Thru, xml, "Thru", "Kistl.App.TimeRecords");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._From, xml, "From", "Kistl.App.TimeRecords");
            XmlStreamer.FromStream(ref this._fk_Mitarbeiter, xml, "Mitarbeiter", "Kistl.App.TimeRecords");
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "Kistl.App.TimeRecords");
            XmlStreamer.FromStream(ref this._Notes, xml, "Notes", "Kistl.App.TimeRecords");
            XmlStreamer.FromStream(ref this._Thru, xml, "Thru", "Kistl.App.TimeRecords");
        }

#endregion

    }


}