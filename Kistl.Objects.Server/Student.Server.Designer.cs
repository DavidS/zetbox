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
    [EdmEntityType(NamespaceName="Model", Name="Student")]
    [System.Diagnostics.DebuggerDisplay("Student")]
    public class Student__Implementation__ : BaseServerDataObject_EntityFramework, Student
    {
    
		public Student__Implementation__()
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
    /*
    Relation: FK_GroupExcercise_accomplished_by_Students
    A: ZeroOrMore GroupExcercise as GroupExcercise
    B: ZeroOrMore Student as Students
    Preferred Storage: Separate
    */
        // collection reference property
		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<at.dasz.CourseOrganiser.GroupExcercise> GroupExcercise
        {
            get
            {
                if (_GroupExcerciseWrapper == null)
                {
                    _GroupExcerciseWrapper = new EntityRelationASideCollectionWrapper<at.dasz.CourseOrganiser.GroupExcercise, at.dasz.CourseOrganiser.Student, at.dasz.CourseOrganiser.GroupExcercise_accomplished_by_Student_RelationEntry__Implementation__>(
                            this,
                            GroupExcercise__Implementation__);
                }
                return _GroupExcerciseWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_GroupExcercise_accomplished_by_Students_B", "CollectionEntry")]
        public EntityCollection<at.dasz.CourseOrganiser.GroupExcercise_accomplished_by_Student_RelationEntry__Implementation__> GroupExcercise__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<at.dasz.CourseOrganiser.GroupExcercise_accomplished_by_Student_RelationEntry__Implementation__>(
                        "Model.FK_GroupExcercise_accomplished_by_Students_B",
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
        private EntityRelationASideCollectionWrapper<at.dasz.CourseOrganiser.GroupExcercise, at.dasz.CourseOrganiser.Student, at.dasz.CourseOrganiser.GroupExcercise_accomplished_by_Student_RelationEntry__Implementation__> _GroupExcerciseWrapper;


        /// <summary>
        /// 
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
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
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
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
        public ICollection<at.dasz.CourseOrganiser.Semester> Semesters
        {
            get
            {
                if (_SemestersWrapper == null)
                {
                    _SemestersWrapper = new EntityRelationBSideCollectionWrapper<at.dasz.CourseOrganiser.Student, at.dasz.CourseOrganiser.Semester, at.dasz.CourseOrganiser.Student_attend_Semester_RelationEntry__Implementation__>(
                            this,
                            Semesters__Implementation__);
                }
                return _SemestersWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_Students_attend_Semesters_A", "CollectionEntry")]
        public EntityCollection<at.dasz.CourseOrganiser.Student_attend_Semester_RelationEntry__Implementation__> Semesters__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<at.dasz.CourseOrganiser.Student_attend_Semester_RelationEntry__Implementation__>(
                        "Model.FK_Students_attend_Semesters_A",
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
        private EntityRelationBSideCollectionWrapper<at.dasz.CourseOrganiser.Student, at.dasz.CourseOrganiser.Semester, at.dasz.CourseOrganiser.Student_attend_Semester_RelationEntry__Implementation__> _SemestersWrapper;


        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_StudentExam_writtenby_Student
    A: ZeroOrMore StudentExam as StudentExam
    B: One Student as Student
    Preferred Storage: MergeIntoA
    */
        // object list property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectListProperty
	    // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<at.dasz.CourseOrganiser.StudentExam> StudentExam
        {
            get
            {
                if (_StudentExamWrapper == null)
                {
                    _StudentExamWrapper = new EntityCollectionWrapper<at.dasz.CourseOrganiser.StudentExam, at.dasz.CourseOrganiser.StudentExam__Implementation__>(
                            this.Context, StudentExam__Implementation__);
                }
                return _StudentExamWrapper;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_StudentExam_writtenby_Student", "StudentExam")]
        public EntityCollection<at.dasz.CourseOrganiser.StudentExam__Implementation__> StudentExam__Implementation__
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<at.dasz.CourseOrganiser.StudentExam__Implementation__>(
                        "Model.FK_StudentExam_writtenby_Student",
                        "StudentExam");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                c.ForEach(i => i.AttachToContext(Context));
                return c;
            }
        }
        private EntityCollectionWrapper<at.dasz.CourseOrganiser.StudentExam, at.dasz.CourseOrganiser.StudentExam__Implementation__> _StudentExamWrapper;



		public override Type GetImplementedInterface()
		{
			return typeof(Student);
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (Student)obj;
			var otherImpl = (Student__Implementation__)obj;
			var me = (Student)this;

			me.MatriculationNumber = other.MatriculationNumber;
			me.Name = other.Name;
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


		private static readonly System.ComponentModel.PropertyDescriptor[] _properties = new System.ComponentModel.PropertyDescriptor[] {
			// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
			new CustomPropertyDescriptor<Student__Implementation__, ICollection<at.dasz.CourseOrganiser.GroupExcercise>>(
				new Guid("6c9bed6d-1ce1-4260-8e25-d864ffb85463"),
				"GroupExcercise",
				null,
				obj => obj.GroupExcercise,
				null), // lists are read-only properties
			// else
			new CustomPropertyDescriptor<Student__Implementation__, string>(
				new Guid("d65a724a-85eb-49f4-89ce-a050aec5d7f8"),
				"MatriculationNumber",
				null,
				obj => obj.MatriculationNumber,
				(obj, val) => obj.MatriculationNumber = val),
			// else
			new CustomPropertyDescriptor<Student__Implementation__, string>(
				new Guid("0090bd59-0e0e-49cb-be92-935eae1276ca"),
				"Name",
				null,
				obj => obj.Name,
				(obj, val) => obj.Name = val),
			// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
			new CustomPropertyDescriptor<Student__Implementation__, ICollection<at.dasz.CourseOrganiser.Semester>>(
				new Guid("f95b44bb-edd0-4e81-82b6-4e1b2476190e"),
				"Semesters",
				null,
				obj => obj.Semesters,
				null), // lists are read-only properties
			// property.IsAssociation() && !property.IsObjectReferencePropertySingle()
			new CustomPropertyDescriptor<Student__Implementation__, ICollection<at.dasz.CourseOrganiser.StudentExam>>(
				new Guid("b99355b0-540a-4585-9453-bbe16255b164"),
				"StudentExam",
				null,
				obj => obj.StudentExam,
				null), // lists are read-only properties
			// rel: StudentExam writtenby Student (da365b25-b8d4-43dd-91c7-f30cad09d600)
		};
		
		protected override void CollectProperties(List<System.ComponentModel.PropertyDescriptor> props)
		{
			base.CollectProperties(props);
			props.AddRange(_properties);
		}
	

		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
			// fix direct object references
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