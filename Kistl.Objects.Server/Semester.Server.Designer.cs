// <autogenerated/>


namespace at.dasz.CourseOrganiser
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
    using Kistl.DalProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="Semester")]
    [System.Diagnostics.DebuggerDisplay("Semester")]
    public class Semester__Implementation__ : BaseServerDataObject_EntityFramework, Semester
    {
        [Obsolete]
        public Semester__Implementation__()
            : base(null)
        {
        }

        public Semester__Implementation__(Func<IReadOnlyKistlContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.IdProperty
        public override int ID
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ID;
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_ID != value)
                {
                    var __oldValue = _ID;
                    var __newValue = value;
                    NotifyPropertyChanging("ID", __oldValue, __newValue);
                    _ID = __newValue;
                    NotifyPropertyChanged("ID", __oldValue, __newValue);
                }
            }
        }
        private int _ID;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string CourseName
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _CourseName;
                if (OnCourseName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnCourseName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_CourseName != value)
                {
                    var __oldValue = _CourseName;
                    var __newValue = value;
                    if(OnCourseName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnCourseName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("CourseName", __oldValue, __newValue);
                    _CourseName = __newValue;
                    NotifyPropertyChanged("CourseName", __oldValue, __newValue);
                    if(OnCourseName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnCourseName_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _CourseName;
		public static event PropertyGetterHandler<at.dasz.CourseOrganiser.Semester, string> OnCourseName_Getter;
		public static event PropertyPreSetterHandler<at.dasz.CourseOrganiser.Semester, string> OnCourseName_PreSetter;
		public static event PropertyPostSetterHandler<at.dasz.CourseOrganiser.Semester, string> OnCourseName_PostSetter;

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Exam_happens_in_Semester
    A: ZeroOrMore Exam as Exam
    B: One Semester as Semester
    Preferred Storage: MergeIntoA
    */
        // object list property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectListProperty
	    // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<at.dasz.CourseOrganiser.Exam> Exam
        {
            get
            {
                if (_ExamWrapper == null)
                {
                    _ExamWrapper = new EntityCollectionWrapper<at.dasz.CourseOrganiser.Exam, at.dasz.CourseOrganiser.Exam__Implementation__>(
                            this.Context, Exam__Implementation__);
                }
                return _ExamWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Exam_happens_in_Semester", "Exam")]
        public EntityCollection<at.dasz.CourseOrganiser.Exam__Implementation__> Exam__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<at.dasz.CourseOrganiser.Exam__Implementation__>(
                        "Model.FK_Exam_happens_in_Semester",
                        "Exam");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                c.ForEach(i => i.AttachToContext(Context));
                return c;
            }
        }
        private EntityCollectionWrapper<at.dasz.CourseOrganiser.Exam, at.dasz.CourseOrganiser.Exam__Implementation__> _ExamWrapper;



        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Excercise_happens_in_Semester
    A: ZeroOrMore Exercise as Excercise
    B: One Semester as Semester
    Preferred Storage: MergeIntoA
    */
        // object list property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectListProperty
	    // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<at.dasz.CourseOrganiser.Exercise> Excercise
        {
            get
            {
                if (_ExcerciseWrapper == null)
                {
                    _ExcerciseWrapper = new EntityCollectionWrapper<at.dasz.CourseOrganiser.Exercise, at.dasz.CourseOrganiser.Exercise__Implementation__>(
                            this.Context, Excercise__Implementation__);
                }
                return _ExcerciseWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Excercise_happens_in_Semester", "Excercise")]
        public EntityCollection<at.dasz.CourseOrganiser.Exercise__Implementation__> Excercise__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<at.dasz.CourseOrganiser.Exercise__Implementation__>(
                        "Model.FK_Excercise_happens_in_Semester",
                        "Excercise");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                c.ForEach(i => i.AttachToContext(Context));
                return c;
            }
        }
        private EntityCollectionWrapper<at.dasz.CourseOrganiser.Exercise, at.dasz.CourseOrganiser.Exercise__Implementation__> _ExcerciseWrapper;



        /// <summary>
        /// 
        /// </summary>
        // enumeration property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.EnumerationPropertyTemplate
        // implement the user-visible interface
        public at.dasz.CourseOrganiser.Periods? Period
        {
            get
            {
				var __value = _Period;
				if(OnPeriod_Getter != null)
				{
					var e = new PropertyGetterEventArgs<at.dasz.CourseOrganiser.Periods?>(__value);
					OnPeriod_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_Period != value)
                {
					var __oldValue = _Period;
					var __newValue = value;
                    if(OnPeriod_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<at.dasz.CourseOrganiser.Periods?>(__oldValue, __newValue);
						OnPeriod_PreSetter(this, e);
						__newValue = e.Result;
                    }
					
                    NotifyPropertyChanging("Period", "Period__Implementation__", __oldValue, __newValue);
                    _Period = value;
                    NotifyPropertyChanged("Period", "Period__Implementation__", __oldValue, __newValue);
                    if(OnPeriod_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<at.dasz.CourseOrganiser.Periods?>(__oldValue, __newValue);
						OnPeriod_PostSetter(this, e);
                    }
                    
                }
            }
        }
        
        /// <summary>backing store for Period</summary>
        private at.dasz.CourseOrganiser.Periods? _Period;
        
        /// <summary>EF sees only this property, for Period</summary>
        [XmlIgnore()]
        [EdmScalarProperty()]
        public int? Period__Implementation__
        {
            get
            {
                return (int?)this.Period;
            }
            set
            {
                this.Period = (at.dasz.CourseOrganiser.Periods?)value;
            }
        }
        
		public static event PropertyGetterHandler<at.dasz.CourseOrganiser.Semester, at.dasz.CourseOrganiser.Periods?> OnPeriod_Getter;
		public static event PropertyPreSetterHandler<at.dasz.CourseOrganiser.Semester, at.dasz.CourseOrganiser.Periods?> OnPeriod_PreSetter;
		public static event PropertyPostSetterHandler<at.dasz.CourseOrganiser.Semester, at.dasz.CourseOrganiser.Periods?> OnPeriod_PostSetter;

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_Students_attend_Semesters
    A: ZeroOrMore Student as Students
    B: ZeroOrMore Semester as Semesters
    Preferred Storage: Separate
    */
        // collection reference property
		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<at.dasz.CourseOrganiser.Student> Students
        {
            get
            {
                if (_StudentsWrapper == null)
                {
                    _StudentsWrapper = new EntityRelationASideCollectionWrapper<at.dasz.CourseOrganiser.Student, at.dasz.CourseOrganiser.Semester, at.dasz.CourseOrganiser.Student_attend_Semester_RelationEntry__Implementation__>(
                            this,
                            Students__Implementation__);
                }
                return _StudentsWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Students_attend_Semesters_B", "CollectionEntry")]
        public EntityCollection<at.dasz.CourseOrganiser.Student_attend_Semester_RelationEntry__Implementation__> Students__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<at.dasz.CourseOrganiser.Student_attend_Semester_RelationEntry__Implementation__>(
                        "Model.FK_Students_attend_Semesters_B",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                    c.ForEach(i => i.AttachToContext(Context));
                }
                return c;
            }
        }
        private EntityRelationASideCollectionWrapper<at.dasz.CourseOrganiser.Student, at.dasz.CourseOrganiser.Semester, at.dasz.CourseOrganiser.Student_attend_Semester_RelationEntry__Implementation__> _StudentsWrapper;


        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual int? Year
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Year;
                if (OnYear_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int?>(__result);
                    OnYear_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Year != value)
                {
                    var __oldValue = _Year;
                    var __newValue = value;
                    if(OnYear_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int?>(__oldValue, __newValue);
                        OnYear_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Year", __oldValue, __newValue);
                    _Year = __newValue;
                    NotifyPropertyChanged("Year", __oldValue, __newValue);
                    if(OnYear_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int?>(__oldValue, __newValue);
                        OnYear_PostSetter(this, __e);
                    }
                }
            }
        }
        private int? _Year;
		public static event PropertyGetterHandler<at.dasz.CourseOrganiser.Semester, int?> OnYear_Getter;
		public static event PropertyPreSetterHandler<at.dasz.CourseOrganiser.Semester, int?> OnYear_PreSetter;
		public static event PropertyPostSetterHandler<at.dasz.CourseOrganiser.Semester, int?> OnYear_PostSetter;

        public override Type GetImplementedInterface()
        {
            return typeof(Semester);
        }

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Semester)obj;
			var otherImpl = (Semester__Implementation__)obj;
			var me = (Semester)this;

			me.CourseName = other.CourseName;
			me.Period = other.Period;
			me.Year = other.Year;
		}

		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
			// fix direct object references
		}
        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_Semester")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Semester != null)
            {
                OnToString_Semester(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<Semester> OnToString_Semester;

        [EventBasedMethod("OnPreSave_Semester")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Semester != null) OnPreSave_Semester(this);
        }
        public static event ObjectEventHandler<Semester> OnPreSave_Semester;

        [EventBasedMethod("OnPostSave_Semester")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Semester != null) OnPostSave_Semester(this);
        }
        public static event ObjectEventHandler<Semester> OnPostSave_Semester;

        [EventBasedMethod("OnCreated_Semester")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_Semester != null) OnCreated_Semester(this);
        }
        public static event ObjectEventHandler<Semester> OnCreated_Semester;

        [EventBasedMethod("OnDeleting_Semester")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Semester != null) OnDeleting_Semester(this);
        }
        public static event ObjectEventHandler<Semester> OnDeleting_Semester;


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
					new CustomPropertyDescriptor<Semester__Implementation__, string>(
						lazyCtx,
						new Guid("7b0ead0e-dbd2-4474-8048-36e5e768ca54"),
						"CourseName",
						null,
						obj => obj.CourseName,
						(obj, val) => obj.CourseName = val),
					// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
					new CustomPropertyDescriptor<Semester__Implementation__, ICollection<at.dasz.CourseOrganiser.Exam>>(
						lazyCtx,
						new Guid("7f06bb42-4ec6-496e-8ff8-e4a15d21f544"),
						"Exam",
						null,
						obj => obj.Exam,
						null), // lists are read-only properties
					// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
					new CustomPropertyDescriptor<Semester__Implementation__, ICollection<at.dasz.CourseOrganiser.Exercise>>(
						lazyCtx,
						new Guid("be7c24bf-b8c9-440c-ac42-d0856a3200ac"),
						"Excercise",
						null,
						obj => obj.Excercise,
						null), // lists are read-only properties
					// else
					new CustomPropertyDescriptor<Semester__Implementation__, at.dasz.CourseOrganiser.Periods?>(
						lazyCtx,
						new Guid("0c554fc0-6f57-4b5d-a546-0fada5e11fde"),
						"Period",
						null,
						obj => obj.Period,
						(obj, val) => obj.Period = val),
					// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
					new CustomPropertyDescriptor<Semester__Implementation__, ICollection<at.dasz.CourseOrganiser.Student>>(
						lazyCtx,
						new Guid("eaefbcaa-ce9f-43cc-876d-efb6b0c5796c"),
						"Students",
						null,
						obj => obj.Students,
						null), // lists are read-only properties
					// else
					new CustomPropertyDescriptor<Semester__Implementation__, int?>(
						lazyCtx,
						new Guid("61b3a7f4-2995-4d2f-90bf-98b38deeba4b"),
						"Year",
						null,
						obj => obj.Year,
						(obj, val) => obj.Year = val),
					// rel: Exam happens_in Semester (af26d91c-68a2-4c18-aca7-4fc56d3b519a)
					// rel: Excercise happens_in Semester (719bf072-74d1-4878-8d8b-db1c92d60145)
				};
			}
		}
		
		protected override void CollectProperties(Func<IReadOnlyKistlContext> lazyCtx, List<System.ComponentModel.PropertyDescriptor> props)
		{
			base.CollectProperties(props);
			_InitializePropertyDescriptors(lazyCtx);
			props.AddRange(_properties);
		}
	

#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this._CourseName, binStream);
            BinarySerializer.ToStream((int?)((Semester)this).Period, binStream);
            BinarySerializer.ToStream(this._Year, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._CourseName, binStream);
			{
				int? baseValue;
				BinarySerializer.FromStream(out baseValue, binStream);
				((Semester)this).Period = (at.dasz.CourseOrganiser.Periods)baseValue;
			}
            BinarySerializer.FromStream(out this._Year, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(this._CourseName, xml, "CourseName", "at.dasz.CourseOrganiser");
            XmlStreamer.ToStream((int?)this.Period, xml, "Period", "at.dasz.CourseOrganiser");
            XmlStreamer.ToStream(this._Year, xml, "Year", "at.dasz.CourseOrganiser");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._CourseName, xml, "CourseName", "at.dasz.CourseOrganiser");
            XmlStreamer.FromStreamConverter(v => ((Semester)this).Period = (at.dasz.CourseOrganiser.Periods)v, xml, "Period", "at.dasz.CourseOrganiser");
            XmlStreamer.FromStream(ref this._Year, xml, "Year", "at.dasz.CourseOrganiser");
        }

#endregion

    }


}