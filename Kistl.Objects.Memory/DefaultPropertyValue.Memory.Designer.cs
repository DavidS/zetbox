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

    using Kistl.DalProvider.Memory;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("DefaultPropertyValue")]
    public class DefaultPropertyValue__Implementation__Memory : BaseMemoryDataObject, DefaultPropertyValue, Kistl.API.IExportableInternal
    {
        [Obsolete]
        public DefaultPropertyValue__Implementation__Memory()
            : base(null)
        {
            {
            }
        }

        public DefaultPropertyValue__Implementation__Memory(Func<IReadOnlyKistlContext> lazyCtx)
            : base(lazyCtx)
        {
            {
            }
        }


        /// <summary>
        /// Identity which changed this object
        /// </summary>
        // object reference property
		// BEGIN Kistl.DalProvider.Memory.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate for ChangedBy
		// rel(A): DefaultPropertyValue was ChangedBy
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Identity ChangedBy
        {
            get
            {
				Kistl.App.Base.Identity __value;
                if (_fk_ChangedBy.HasValue)
                    __value = Context.Find<Kistl.App.Base.Identity>(_fk_ChangedBy.Value);
                else
                    __value = null;

				if(OnChangedBy_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.Identity>(__value);
					OnChangedBy_Getter(this, e);
					__value = e.Result;
				}
                    
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                
                // shortcut noops
                if (value == null && _fk_ChangedBy == null)
					return;
                else if (value != null && value.ID == _fk_ChangedBy)
					return;
			           
	            // cache old value to remove inverse references later
                var __oldValue = ChangedBy;
				var __newValue = value;

				// Changing Event fires before anything is touched
				NotifyPropertyChanging("ChangedBy", __oldValue, __newValue);
				
                if(OnChangedBy_PreSetter != null && IsAttached)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Identity>(__oldValue, __newValue);
					OnChangedBy_PreSetter(this, e);
					__newValue = e.Result;
                }
                
				// next, set the local reference
                _fk_ChangedBy = __newValue == null ? (int?)null : __newValue.ID;
				
				// everything is done. fire the Changed event
				NotifyPropertyChanged("ChangedBy", __oldValue, __newValue);

                if(OnChangedBy_PostSetter != null && IsAttached)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Identity>(__oldValue, __newValue);
					OnChangedBy_PostSetter(this, e);
                }
                
            }
        }
        
        // normalize namespace for Templates
        private Kistl.App.Base.Identity ChangedBy__Implementation__
        {
			get
			{
				return ChangedBy;
			}
			set
			{
				ChangedBy = value;
			}
		}
        
        private int? _fk_ChangedBy;
        private Guid? _fk_guid_ChangedBy = null;
		// END Kistl.DalProvider.Memory.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate for ChangedBy
		public static event PropertyGetterHandler<Kistl.App.Base.DefaultPropertyValue, Kistl.App.Base.Identity> OnChangedBy_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.DefaultPropertyValue, Kistl.App.Base.Identity> OnChangedBy_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.DefaultPropertyValue, Kistl.App.Base.Identity> OnChangedBy_PostSetter;

        /// <summary>
        /// Date and time where this object was changed
        /// </summary>
        // value type property
           // Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual DateTime? ChangedOn
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ChangedOn;
                if (OnChangedOn_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime?>(__result);
                    OnChangedOn_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_ChangedOn != value)
                {
                    var __oldValue = _ChangedOn;
                    var __newValue = value;
                    if(OnChangedOn_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnChangedOn_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ChangedOn", __oldValue, __newValue);
                    _ChangedOn = __newValue;
                    NotifyPropertyChanged("ChangedOn", __oldValue, __newValue);
                    if(OnChangedOn_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnChangedOn_PostSetter(this, __e);
                    }
                }
            }
        }
        private DateTime? _ChangedOn;
		public static event PropertyGetterHandler<Kistl.App.Base.DefaultPropertyValue, DateTime?> OnChangedOn_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.DefaultPropertyValue, DateTime?> OnChangedOn_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.DefaultPropertyValue, DateTime?> OnChangedOn_PostSetter;

        /// <summary>
        /// Identity which created this object
        /// </summary>
        // object reference property
		// BEGIN Kistl.DalProvider.Memory.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate for CreatedBy
		// rel(A): DefaultPropertyValue was CreatedBy
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Identity CreatedBy
        {
            get
            {
				Kistl.App.Base.Identity __value;
                if (_fk_CreatedBy.HasValue)
                    __value = Context.Find<Kistl.App.Base.Identity>(_fk_CreatedBy.Value);
                else
                    __value = null;

				if(OnCreatedBy_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.Identity>(__value);
					OnCreatedBy_Getter(this, e);
					__value = e.Result;
				}
                    
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                
                // shortcut noops
                if (value == null && _fk_CreatedBy == null)
					return;
                else if (value != null && value.ID == _fk_CreatedBy)
					return;
			           
	            // cache old value to remove inverse references later
                var __oldValue = CreatedBy;
				var __newValue = value;

				// Changing Event fires before anything is touched
				NotifyPropertyChanging("CreatedBy", __oldValue, __newValue);
				
                if(OnCreatedBy_PreSetter != null && IsAttached)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Identity>(__oldValue, __newValue);
					OnCreatedBy_PreSetter(this, e);
					__newValue = e.Result;
                }
                
				// next, set the local reference
                _fk_CreatedBy = __newValue == null ? (int?)null : __newValue.ID;
				
				// everything is done. fire the Changed event
				NotifyPropertyChanged("CreatedBy", __oldValue, __newValue);

                if(OnCreatedBy_PostSetter != null && IsAttached)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Identity>(__oldValue, __newValue);
					OnCreatedBy_PostSetter(this, e);
                }
                
            }
        }
        
        // normalize namespace for Templates
        private Kistl.App.Base.Identity CreatedBy__Implementation__
        {
			get
			{
				return CreatedBy;
			}
			set
			{
				CreatedBy = value;
			}
		}
        
        private int? _fk_CreatedBy;
        private Guid? _fk_guid_CreatedBy = null;
		// END Kistl.DalProvider.Memory.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate for CreatedBy
		public static event PropertyGetterHandler<Kistl.App.Base.DefaultPropertyValue, Kistl.App.Base.Identity> OnCreatedBy_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.DefaultPropertyValue, Kistl.App.Base.Identity> OnCreatedBy_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.DefaultPropertyValue, Kistl.App.Base.Identity> OnCreatedBy_PostSetter;

        /// <summary>
        /// Date and time where this object was created
        /// </summary>
        // value type property
           // Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual DateTime? CreatedOn
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _CreatedOn;
                if (OnCreatedOn_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<DateTime?>(__result);
                    OnCreatedOn_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_CreatedOn != value)
                {
                    var __oldValue = _CreatedOn;
                    var __newValue = value;
                    if(OnCreatedOn_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnCreatedOn_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("CreatedOn", __oldValue, __newValue);
                    _CreatedOn = __newValue;
                    NotifyPropertyChanged("CreatedOn", __oldValue, __newValue);
                    if(OnCreatedOn_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<DateTime?>(__oldValue, __newValue);
                        OnCreatedOn_PostSetter(this, __e);
                    }
                }
            }
        }
        private DateTime? _CreatedOn;
		public static event PropertyGetterHandler<Kistl.App.Base.DefaultPropertyValue, DateTime?> OnCreatedOn_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.DefaultPropertyValue, DateTime?> OnCreatedOn_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.DefaultPropertyValue, DateTime?> OnCreatedOn_PostSetter;

        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
        private bool _isExportGuidSet = false;
           // Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual Guid ExportGuid
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ExportGuid;
                if (!_isExportGuidSet) {
                    var __p = FrozenContext.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("e672de1a-e0f4-4613-9d1f-121ba543c2ec"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        __result = this._ExportGuid = (Guid)__p.DefaultValue.GetDefaultValue();
                    } else {
                        Kistl.API.Utils.Logging.Log.Warn("Unable to get default value for property 'DefaultPropertyValue.ExportGuid'");
                    }
                }
                if (OnExportGuid_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<Guid>(__result);
                    OnExportGuid_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isExportGuidSet = true;
                if (_ExportGuid != value)
                {
                    var __oldValue = _ExportGuid;
                    var __newValue = value;
                    if(OnExportGuid_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ExportGuid", __oldValue, __newValue);
                    _ExportGuid = __newValue;
                    NotifyPropertyChanged("ExportGuid", __oldValue, __newValue);
                    if(OnExportGuid_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PostSetter(this, __e);
                    }
                }
            }
        }
        private Guid _ExportGuid;
		public static event PropertyGetterHandler<Kistl.App.Base.DefaultPropertyValue, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.DefaultPropertyValue, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.DefaultPropertyValue, Guid> OnExportGuid_PostSetter;

        /// <summary>
        /// Property where the default value is set
        /// </summary>
        // object reference property
		// BEGIN Kistl.DalProvider.Memory.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate for Property
		// rel(B): Property has DefaultValue
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Property Property
        {
            get
            {
				Kistl.App.Base.Property __value;
                if (_fk_Property.HasValue)
                    __value = Context.Find<Kistl.App.Base.Property>(_fk_Property.Value);
                else
                    __value = null;

				if(OnProperty_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.Property>(__value);
					OnProperty_Getter(this, e);
					__value = e.Result;
				}
                    
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                
                // shortcut noops
                if (value == null && _fk_Property == null)
					return;
                else if (value != null && value.ID == _fk_Property)
					return;
			           
	            // cache old value to remove inverse references later
                var __oldValue = Property;
				var __newValue = value;

				// Changing Event fires before anything is touched
				NotifyPropertyChanging("Property", __oldValue, __newValue);
				
                if(OnProperty_PreSetter != null && IsAttached)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Property>(__oldValue, __newValue);
					OnProperty_PreSetter(this, e);
					__newValue = e.Result;
                }
                
				// next, set the local reference
                _fk_Property = __newValue == null ? (int?)null : __newValue.ID;
				
				// now fixup redundant, inverse references
				// The inverse navigator will also fire events when changed, so should 
				// only be touched after setting the local value above. 
				// TODO: for complete correctness, the "other" Changing event should also fire 
				//       before the local value is changed
				if (__oldValue != null)
				{
					// unset old reference
					__oldValue.DefaultValue = null;
				}

                if (__newValue != null)
                {
					// set new reference
                    __newValue.DefaultValue = this;
                }
				// everything is done. fire the Changed event
				NotifyPropertyChanged("Property", __oldValue, __newValue);

                if(OnProperty_PostSetter != null && IsAttached)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Property>(__oldValue, __newValue);
					OnProperty_PostSetter(this, e);
                }
                
            }
        }
        
        // normalize namespace for Templates
        private Kistl.App.Base.Property Property__Implementation__
        {
			get
			{
				return Property;
			}
			set
			{
				Property = value;
			}
		}
        
        private int? _fk_Property;
        private Guid? _fk_guid_Property = null;
		// END Kistl.DalProvider.Memory.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate for Property
		public static event PropertyGetterHandler<Kistl.App.Base.DefaultPropertyValue, Kistl.App.Base.Property> OnProperty_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.DefaultPropertyValue, Kistl.App.Base.Property> OnProperty_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.DefaultPropertyValue, Kistl.App.Base.Property> OnProperty_PostSetter;

        /// <summary>
        /// GetDefaultValue
        /// </summary>
		[EventBasedMethod("OnGetDefaultValue_DefaultPropertyValue")]
		public virtual System.Object GetDefaultValue() 
        {
            var e = new MethodReturnEventArgs<System.Object>();
            if (OnGetDefaultValue_DefaultPropertyValue != null)
            {
                OnGetDefaultValue_DefaultPropertyValue(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on DefaultPropertyValue.GetDefaultValue");
            }
            return e.Result;
        }
		public delegate void GetDefaultValue_Handler<T>(T obj, MethodReturnEventArgs<System.Object> ret);
		public static event GetDefaultValue_Handler<DefaultPropertyValue> OnGetDefaultValue_DefaultPropertyValue;



        public override Type GetImplementedInterface()
        {
            return typeof(DefaultPropertyValue);
        }

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (DefaultPropertyValue)obj;
			var otherImpl = (DefaultPropertyValue__Implementation__Memory)obj;
			var me = (DefaultPropertyValue)this;

			me.ChangedOn = other.ChangedOn;
			me.CreatedOn = other.CreatedOn;
			me.ExportGuid = other.ExportGuid;
			this._fk_ChangedBy = otherImpl._fk_ChangedBy;
			this._fk_CreatedBy = otherImpl._fk_CreatedBy;
			this._fk_Property = otherImpl._fk_Property;
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

			if (_fk_guid_ChangedBy.HasValue)
				ChangedBy__Implementation__ = (Kistl.App.Base.Identity__Implementation__Memory)Context.FindPersistenceObject<Kistl.App.Base.Identity>(_fk_guid_ChangedBy.Value);
			else if (_fk_ChangedBy.HasValue)
				ChangedBy__Implementation__ = (Kistl.App.Base.Identity__Implementation__Memory)Context.Find<Kistl.App.Base.Identity>(_fk_ChangedBy.Value);
			else
				ChangedBy__Implementation__ = null;

			if (_fk_guid_CreatedBy.HasValue)
				CreatedBy__Implementation__ = (Kistl.App.Base.Identity__Implementation__Memory)Context.FindPersistenceObject<Kistl.App.Base.Identity>(_fk_guid_CreatedBy.Value);
			else if (_fk_CreatedBy.HasValue)
				CreatedBy__Implementation__ = (Kistl.App.Base.Identity__Implementation__Memory)Context.Find<Kistl.App.Base.Identity>(_fk_CreatedBy.Value);
			else
				CreatedBy__Implementation__ = null;

			if (_fk_guid_Property.HasValue)
				Property__Implementation__ = (Kistl.App.Base.Property__Implementation__Memory)Context.FindPersistenceObject<Kistl.App.Base.Property>(_fk_guid_Property.Value);
			else if (_fk_Property.HasValue)
				Property__Implementation__ = (Kistl.App.Base.Property__Implementation__Memory)Context.Find<Kistl.App.Base.Property>(_fk_Property.Value);
			else
				Property__Implementation__ = null;
		}
        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_DefaultPropertyValue")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DefaultPropertyValue != null)
            {
                OnToString_DefaultPropertyValue(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<DefaultPropertyValue> OnToString_DefaultPropertyValue;

        [EventBasedMethod("OnPreSave_DefaultPropertyValue")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DefaultPropertyValue != null) OnPreSave_DefaultPropertyValue(this);
        }
        public static event ObjectEventHandler<DefaultPropertyValue> OnPreSave_DefaultPropertyValue;

        [EventBasedMethod("OnPostSave_DefaultPropertyValue")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DefaultPropertyValue != null) OnPostSave_DefaultPropertyValue(this);
        }
        public static event ObjectEventHandler<DefaultPropertyValue> OnPostSave_DefaultPropertyValue;

        [EventBasedMethod("OnCreated_DefaultPropertyValue")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_DefaultPropertyValue != null) OnCreated_DefaultPropertyValue(this);
        }
        public static event ObjectEventHandler<DefaultPropertyValue> OnCreated_DefaultPropertyValue;

        [EventBasedMethod("OnDeleting_DefaultPropertyValue")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_DefaultPropertyValue != null) OnDeleting_DefaultPropertyValue(this);
        }
        public static event ObjectEventHandler<DefaultPropertyValue> OnDeleting_DefaultPropertyValue;


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
					new CustomPropertyDescriptor<DefaultPropertyValue__Implementation__Memory, Kistl.App.Base.Identity>(
						lazyCtx,
						new Guid("c33da8b7-beba-43e5-a9e8-a8d51c6a3443"),
						"ChangedBy",
						null,
						obj => obj.ChangedBy,
						(obj, val) => obj.ChangedBy = val),
					// else
					new CustomPropertyDescriptor<DefaultPropertyValue__Implementation__Memory, DateTime?>(
						lazyCtx,
						new Guid("0f199917-c51d-4f4e-9c59-663a274c79a0"),
						"ChangedOn",
						null,
						obj => obj.ChangedOn,
						(obj, val) => obj.ChangedOn = val),
					// else
					new CustomPropertyDescriptor<DefaultPropertyValue__Implementation__Memory, Kistl.App.Base.Identity>(
						lazyCtx,
						new Guid("68c4fa75-42bd-4d51-b74d-a074ea17e242"),
						"CreatedBy",
						null,
						obj => obj.CreatedBy,
						(obj, val) => obj.CreatedBy = val),
					// else
					new CustomPropertyDescriptor<DefaultPropertyValue__Implementation__Memory, DateTime?>(
						lazyCtx,
						new Guid("4ace0c4f-58d7-4656-b263-9adae69a6b06"),
						"CreatedOn",
						null,
						obj => obj.CreatedOn,
						(obj, val) => obj.CreatedOn = val),
					// else
					new CustomPropertyDescriptor<DefaultPropertyValue__Implementation__Memory, Guid>(
						lazyCtx,
						new Guid("e672de1a-e0f4-4613-9d1f-121ba543c2ec"),
						"ExportGuid",
						null,
						obj => obj.ExportGuid,
						(obj, val) => obj.ExportGuid = val),
					// else
					new CustomPropertyDescriptor<DefaultPropertyValue__Implementation__Memory, Kistl.App.Base.Property>(
						lazyCtx,
						new Guid("a2451b2f-2430-4de4-81a6-3d5ac9f0138f"),
						"Property",
						null,
						obj => obj.Property,
						(obj, val) => obj.Property = val),
					// rel: DefaultPropertyValue was CreatedBy (2cec73a2-76e5-4b98-bf49-16e873d4bf67)
					// rel: DefaultPropertyValue was ChangedBy (7f9ecbb7-c962-4f95-9d89-3cb86857886f)
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
                case "ChangedBy":
                    __oldValue = _fk_ChangedBy;
                    NotifyPropertyChanging("ChangedBy", __oldValue, __newValue);
                    _fk_ChangedBy = __newValue;
                    NotifyPropertyChanged("ChangedBy", __oldValue, __newValue);
                    break;
                case "CreatedBy":
                    __oldValue = _fk_CreatedBy;
                    NotifyPropertyChanging("CreatedBy", __oldValue, __newValue);
                    _fk_CreatedBy = __newValue;
                    NotifyPropertyChanged("CreatedBy", __oldValue, __newValue);
                    break;
                case "Property":
                    __oldValue = _fk_Property;
                    NotifyPropertyChanging("Property", __oldValue, __newValue);
                    _fk_Property = __newValue;
                    NotifyPropertyChanged("Property", __oldValue, __newValue);
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
            BinarySerializer.ToStream(this._fk_ChangedBy, binStream);
            BinarySerializer.ToStream(this._ChangedOn, binStream);
            BinarySerializer.ToStream(this._fk_CreatedBy, binStream);
            BinarySerializer.ToStream(this._CreatedOn, binStream);
            BinarySerializer.ToStream(this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.ToStream(this._ExportGuid, binStream);
            }
            BinarySerializer.ToStream(this._fk_Property, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._fk_ChangedBy, binStream);
            BinarySerializer.FromStream(out this._ChangedOn, binStream);
            BinarySerializer.FromStream(out this._fk_CreatedBy, binStream);
            BinarySerializer.FromStream(out this._CreatedOn, binStream);
            BinarySerializer.FromStream(out this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.FromStream(out this._ExportGuid, binStream);
            }
            BinarySerializer.FromStream(out this._fk_Property, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(this._fk_ChangedBy, xml, "ChangedBy", "Kistl.App.Base");
            XmlStreamer.ToStream(this._ChangedOn, xml, "ChangedOn", "Kistl.App.Base");
            XmlStreamer.ToStream(this._fk_CreatedBy, xml, "CreatedBy", "Kistl.App.Base");
            XmlStreamer.ToStream(this._CreatedOn, xml, "CreatedOn", "Kistl.App.Base");
            XmlStreamer.ToStream(this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            }
            XmlStreamer.ToStream(this._fk_Property, xml, "Property", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._fk_ChangedBy, xml, "ChangedBy", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ChangedOn, xml, "ChangedOn", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_CreatedBy, xml, "CreatedBy", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._CreatedOn, xml, "CreatedOn", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            }
            XmlStreamer.FromStream(ref this._fk_Property, xml, "Property", "Kistl.App.Base");
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            
            xml.WriteAttributeString("ExportGuid", this._ExportGuid.ToString());
    
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._ChangedOn, xml, "ChangedOn", "Kistl.App.Base");
    
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._CreatedOn, xml, "CreatedOn", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(Property != null ? Property.ExportGuid : (Guid?)null, xml, "Property", "Kistl.App.Base");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            XmlStreamer.FromStream(ref this._ChangedOn, xml, "ChangedOn", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._CreatedOn, xml, "CreatedOn", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            this._isExportGuidSet = true;
            XmlStreamer.FromStream(ref this._fk_guid_Property, xml, "Property", "Kistl.App.Base");
        }

#endregion

    }


}