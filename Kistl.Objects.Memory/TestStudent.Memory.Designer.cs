// <autogenerated/>

namespace Kistl.App.Test
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
    using Kistl.DalProvider.Base.RelationWrappers;

    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.Memory;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("TestStudent")]
    public class TestStudentMemoryImpl : Kistl.DalProvider.Memory.DataObjectMemoryImpl, TestStudent
    {
        [Obsolete]
        public TestStudentMemoryImpl()
            : base(null)
        {
        }

        public TestStudentMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public string Name
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
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
                    if (OnName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Name", __oldValue, __newValue);
                    _Name = __newValue;
                    NotifyPropertyChanged("Name", __oldValue, __newValue);
                    if (OnName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Name;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Test.TestStudent, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.TestStudent, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.TestStudent, string> OnName_PostSetter;

        public event PropertyIsValidHandler<Kistl.App.Test.TestStudent> OnName_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // collection entry list property
   		// Kistl.Generator.Templates.Properties.CollectionEntryListProperty
		public ICollection<Kistl.App.Test.Fragebogen> Testbogen
		{
			get
			{
				if (_Testbogen == null)
				{
					Context.FetchRelation<Kistl.App.Test.TestStudent_füllt_aus_Fragebogen_RelationEntryMemoryImpl>(new Guid("6819ca86-571c-4d59-bc30-cc1fb0decc9e"), RelationEndRole.A, this);
					_Testbogen 
						= new ObservableBSideCollectionWrapper<Kistl.App.Test.TestStudent, Kistl.App.Test.Fragebogen, Kistl.App.Test.TestStudent_füllt_aus_Fragebogen_RelationEntryMemoryImpl, ICollection<Kistl.App.Test.TestStudent_füllt_aus_Fragebogen_RelationEntryMemoryImpl>>(
							this, 
							new RelationshipFilterASideCollection<Kistl.App.Test.TestStudent_füllt_aus_Fragebogen_RelationEntryMemoryImpl>(this.Context, this));
				}
				return (ICollection<Kistl.App.Test.Fragebogen>)_Testbogen;
			}
		}

		private ObservableBSideCollectionWrapper<Kistl.App.Test.TestStudent, Kistl.App.Test.Fragebogen, Kistl.App.Test.TestStudent_füllt_aus_Fragebogen_RelationEntryMemoryImpl, ICollection<Kistl.App.Test.TestStudent_füllt_aus_Fragebogen_RelationEntryMemoryImpl>> _Testbogen;

        public event PropertyIsValidHandler<Kistl.App.Test.TestStudent> OnTestbogen_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(TestStudent);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (TestStudent)obj;
            var otherImpl = (TestStudentMemoryImpl)obj;
            var me = (TestStudent)this;

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
            base.ReloadReferences();

            // fix direct object references
        }
        #region Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        private static readonly object _propertiesLock = new object();
        private static System.ComponentModel.PropertyDescriptor[] _properties;

        private void _InitializePropertyDescriptors(Func<IFrozenContext> lazyCtx)
        {
            if (_properties != null) return;
            lock (_propertiesLock)
            {
                // recheck for a lost race after aquiring the lock
                if (_properties != null) return;

                _properties = new System.ComponentModel.PropertyDescriptor[] {
                    // else
                    new PropertyDescriptorMemoryImpl<TestStudent, string>(
                        lazyCtx,
                        new Guid("190b4492-c1cb-40a2-8941-84b8ff3ac141"),
                        "Name",
                        null,
                        obj => ((TestStudentMemoryImpl)obj).Name,
                        (obj, val) => obj.Name = val,
						obj => ((TestStudentMemoryImpl)obj).OnName_IsValid), 
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorMemoryImpl<TestStudent, ICollection<Kistl.App.Test.Fragebogen>>(
                        lazyCtx,
                        new Guid("f330d95b-372d-4302-b4d1-73afc5fa71de"),
                        "Testbogen",
                        null,
                        obj => obj.Testbogen,
                        null, // lists are read-only properties
                        obj => ((TestStudentMemoryImpl)obj).OnTestbogen_IsValid), 
                    // position columns
                };
            }
        }

        protected override void CollectProperties(Func<IFrozenContext> lazyCtx, List<System.ComponentModel.PropertyDescriptor> props)
        {
            base.CollectProperties(lazyCtx, props);
            _InitializePropertyDescriptors(lazyCtx);
            props.AddRange(_properties);
        }
        #endregion // Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_TestStudent")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_TestStudent != null)
            {
                OnToString_TestStudent(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<TestStudent> OnToString_TestStudent;

        [EventBasedMethod("OnPreSave_TestStudent")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_TestStudent != null) OnPreSave_TestStudent(this);
        }
        public static event ObjectEventHandler<TestStudent> OnPreSave_TestStudent;

        [EventBasedMethod("OnPostSave_TestStudent")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_TestStudent != null) OnPostSave_TestStudent(this);
        }
        public static event ObjectEventHandler<TestStudent> OnPostSave_TestStudent;

        [EventBasedMethod("OnCreated_TestStudent")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_TestStudent != null) OnCreated_TestStudent(this);
        }
        public static event ObjectEventHandler<TestStudent> OnCreated_TestStudent;

        [EventBasedMethod("OnDeleting_TestStudent")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_TestStudent != null) OnDeleting_TestStudent(this);
        }
        public static event ObjectEventHandler<TestStudent> OnDeleting_TestStudent;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this._Name, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._Name, binStream);
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.ToStream(this._Name, xml, "Name", "Kistl.App.Test");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "Kistl.App.Test");
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        #endregion

    }
}