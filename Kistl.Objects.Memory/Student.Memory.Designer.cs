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

    using Kistl.DalProvider.Memory;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("Student")]
    public class Student__Implementation__Memory : BaseMemoryDataObject, Student
    {
        [Obsolete]
        public Student__Implementation__Memory()
            : base(null)
        {
            {
            }
        }

        public Student__Implementation__Memory(Func<IReadOnlyKistlContext> lazyCtx)
            : base(lazyCtx)
        {
            {
            }
        }


        /// <summary>
        /// 
        /// </summary>
        // collection reference property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.CollectionEntryListProperty
		public ICollection<at.dasz.CourseOrganiser.GroupExcercise> GroupExcercise
		{
			get
			{
				if (_GroupExcercise == null)
				{
					Context.FetchRelation<GroupExcercise_accomplished_by_Student_RelationEntry__Implementation__Memory>(new Guid("464d1407-fbdb-44f1-896e-b6dedad82ce2"), RelationEndRole.B, this);
					_GroupExcercise 
						= new ClientRelationASideCollectionWrapper<at.dasz.CourseOrganiser.GroupExcercise, at.dasz.CourseOrganiser.Student, GroupExcercise_accomplished_by_Student_RelationEntry__Implementation__Memory>(
							this, 
							new RelationshipFilterBSideCollection<GroupExcercise_accomplished_by_Student_RelationEntry__Implementation__Memory>(this.Context, this));
				}
				return _GroupExcercise;
			}
		}

		private ClientRelationASideCollectionWrapper<at.dasz.CourseOrganiser.GroupExcercise, at.dasz.CourseOrganiser.Student, GroupExcercise_accomplished_by_Student_RelationEntry__Implementation__Memory> _GroupExcercise;

        /// <summary>
        /// 
        /// </summary>
        // value type property
           // Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string MatriculationNumber
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _MatriculationNumber;
                if (OnMatriculationNumber_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnMatriculationNumber_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_MatriculationNumber != value)
                {
                    var __oldValue = _MatriculationNumber;
                    var __newValue = value;
                    if(OnMatriculationNumber_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnMatriculationNumber_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("MatriculationNumber", __oldValue, __newValue);
                    _MatriculationNumber = __newValue;
                    NotifyPropertyChanged("MatriculationNumber", __oldValue, __newValue);
                    if(OnMatriculationNumber_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnMatriculationNumber_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _MatriculationNumber;
		public static event PropertyGetterHandler<at.dasz.CourseOrganiser.Student, string> OnMatriculationNumber_Getter;
		public static event PropertyPreSetterHandler<at.dasz.CourseOrganiser.Student, string> OnMatriculationNumber_PreSetter;
		public static event PropertyPostSetterHandler<at.dasz.CourseOrganiser.Student, string> OnMatriculationNumber_PostSetter;

        /// <summary>
        /// 
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
		public static event PropertyGetterHandler<at.dasz.CourseOrganiser.Student, string> OnName_Getter;
		public static event PropertyPreSetterHandler<at.dasz.CourseOrganiser.Student, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<at.dasz.CourseOrganiser.Student, string> OnName_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // collection reference property
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.CollectionEntryListProperty
		public ICollection<at.dasz.CourseOrganiser.Semester> Semesters
		{
			get
			{
				if (_Semesters == null)
				{
					Context.FetchRelation<Student_attend_Semester_RelationEntry__Implementation__Memory>(new Guid("e10ddd77-ead7-41f8-8ef7-20ebaaeee705"), RelationEndRole.A, this);
					_Semesters 
						= new ClientRelationBSideCollectionWrapper<at.dasz.CourseOrganiser.Student, at.dasz.CourseOrganiser.Semester, Student_attend_Semester_RelationEntry__Implementation__Memory>(
							this, 
							new RelationshipFilterASideCollection<Student_attend_Semester_RelationEntry__Implementation__Memory>(this.Context, this));
				}
				return _Semesters;
			}
		}

		private ClientRelationBSideCollectionWrapper<at.dasz.CourseOrganiser.Student, at.dasz.CourseOrganiser.Semester, Student_attend_Semester_RelationEntry__Implementation__Memory> _Semesters;

        /// <summary>
        /// 
        /// </summary>
        // object list property
        // ApplyObjectListPropertyTemplate
		// Kistl.DalProvider.Memory.Generator.Implementation.ObjectClasses.ObjectListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<at.dasz.CourseOrganiser.StudentExam> StudentExam
        {
            get
            {
                if (_StudentExamWrapper == null)
                {
                    List<at.dasz.CourseOrganiser.StudentExam> serverList;
                    if (Helper.IsPersistedObject(this))
                    {
						serverList = Context.GetListOf<at.dasz.CourseOrganiser.StudentExam>(this, "StudentExam");
					}
                    else
                    {
                        serverList = new List<at.dasz.CourseOrganiser.StudentExam>();
                    }
                        
                    _StudentExamWrapper = new OneNRelationList<at.dasz.CourseOrganiser.StudentExam>(
                        "Student",
                        null,
                        this,
                        () => this.NotifyPropertyChanged("StudentExam", null, null),
                        serverList);
                }
                return _StudentExamWrapper;
            }
        }
        
        private OneNRelationList<at.dasz.CourseOrganiser.StudentExam> _StudentExamWrapper;


        public override Type GetImplementedInterface()
        {
            return typeof(Student);
        }

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Student)obj;
			var otherImpl = (Student__Implementation__Memory)obj;
			var me = (Student)this;

			me.MatriculationNumber = other.MatriculationNumber;
			me.Name = other.Name;
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
		}
        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_Student")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Student != null)
            {
                OnToString_Student(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<Student> OnToString_Student;

        [EventBasedMethod("OnPreSave_Student")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_Student != null) OnPreSave_Student(this);
        }
        public static event ObjectEventHandler<Student> OnPreSave_Student;

        [EventBasedMethod("OnPostSave_Student")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_Student != null) OnPostSave_Student(this);
        }
        public static event ObjectEventHandler<Student> OnPostSave_Student;

        [EventBasedMethod("OnCreated_Student")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_Student != null) OnCreated_Student(this);
        }
        public static event ObjectEventHandler<Student> OnCreated_Student;

        [EventBasedMethod("OnDeleting_Student")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_Student != null) OnDeleting_Student(this);
        }
        public static event ObjectEventHandler<Student> OnDeleting_Student;


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
					// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
					new CustomPropertyDescriptor<Student__Implementation__Memory, ICollection<at.dasz.CourseOrganiser.GroupExcercise>>(
						lazyCtx,
						new Guid("6c9bed6d-1ce1-4260-8e25-d864ffb85463"),
						"GroupExcercise",
						null,
						obj => obj.GroupExcercise,
						null), // lists are read-only properties
					// else
					new CustomPropertyDescriptor<Student__Implementation__Memory, string>(
						lazyCtx,
						new Guid("d65a724a-85eb-49f4-89ce-a050aec5d7f8"),
						"MatriculationNumber",
						null,
						obj => obj.MatriculationNumber,
						(obj, val) => obj.MatriculationNumber = val),
					// else
					new CustomPropertyDescriptor<Student__Implementation__Memory, string>(
						lazyCtx,
						new Guid("0090bd59-0e0e-49cb-be92-935eae1276ca"),
						"Name",
						null,
						obj => obj.Name,
						(obj, val) => obj.Name = val),
					// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
					new CustomPropertyDescriptor<Student__Implementation__Memory, ICollection<at.dasz.CourseOrganiser.Semester>>(
						lazyCtx,
						new Guid("f95b44bb-edd0-4e81-82b6-4e1b2476190e"),
						"Semesters",
						null,
						obj => obj.Semesters,
						null), // lists are read-only properties
					// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
					new CustomPropertyDescriptor<Student__Implementation__Memory, ICollection<at.dasz.CourseOrganiser.StudentExam>>(
						lazyCtx,
						new Guid("b99355b0-540a-4585-9453-bbe16255b164"),
						"StudentExam",
						null,
						obj => obj.StudentExam,
						null), // lists are read-only properties
					// rel: StudentExam writtenby Student (da365b25-b8d4-43dd-91c7-f30cad09d600)
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
            BinarySerializer.ToStream(this._MatriculationNumber, binStream);
            BinarySerializer.ToStream(this._Name, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._MatriculationNumber, binStream);
            BinarySerializer.FromStream(out this._Name, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(this._MatriculationNumber, xml, "MatriculationNumber", "at.dasz.CourseOrganiser");
            XmlStreamer.ToStream(this._Name, xml, "Name", "at.dasz.CourseOrganiser");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._MatriculationNumber, xml, "MatriculationNumber", "at.dasz.CourseOrganiser");
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "at.dasz.CourseOrganiser");
        }

#endregion

    }


}