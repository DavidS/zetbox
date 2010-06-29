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
    [System.Diagnostics.DebuggerDisplay("ConstraintInvocation")]
    public class ConstraintInvocation__Implementation__Memory : BaseMemoryDataObject, ConstraintInvocation, Kistl.API.IExportableInternal
    {
        [Obsolete]
        public ConstraintInvocation__Implementation__Memory()
            : base(null)
        {
            {
            }
        }

        public ConstraintInvocation__Implementation__Memory(Func<IReadOnlyKistlContext> lazyCtx)
            : base(lazyCtx)
        {
            {
            }
        }


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
                    var __p = FrozenContext.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("06d4a536-d9c4-487f-9861-ac15429e42de"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        __result = this._ExportGuid = (Guid)__p.DefaultValue.GetDefaultValue();
                    } else {
                        Kistl.API.Utils.Logging.Log.Warn("Unable to get default value for property 'ConstraintInvocation.ExportGuid'");
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
		public static event PropertyGetterHandler<Kistl.App.Base.ConstraintInvocation, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ConstraintInvocation, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ConstraintInvocation, Guid> OnExportGuid_PostSetter;

        /// <summary>
        /// The type implementing this invocation
        /// </summary>
        // object reference property
		// BEGIN Kistl.DalProvider.Memory.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate for Implementor
		// rel(A): ConstraintInvocation has TypeRef
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.TypeRef Implementor
        {
            get
            {
				Kistl.App.Base.TypeRef __value;
                if (_fk_Implementor.HasValue)
                    __value = Context.Find<Kistl.App.Base.TypeRef>(_fk_Implementor.Value);
                else
                    __value = null;

				if(OnImplementor_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.TypeRef>(__value);
					OnImplementor_Getter(this, e);
					__value = e.Result;
				}
                    
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                
                // shortcut noops
                if (value == null && _fk_Implementor == null)
					return;
                else if (value != null && value.ID == _fk_Implementor)
					return;
			           
	            // cache old value to remove inverse references later
                var __oldValue = Implementor;
				var __newValue = value;

				// Changing Event fires before anything is touched
				NotifyPropertyChanging("Implementor", __oldValue, __newValue);
				
                if(OnImplementor_PreSetter != null && IsAttached)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.TypeRef>(__oldValue, __newValue);
					OnImplementor_PreSetter(this, e);
					__newValue = e.Result;
                }
                
				// next, set the local reference
                _fk_Implementor = __newValue == null ? (int?)null : __newValue.ID;
				
				// everything is done. fire the Changed event
				NotifyPropertyChanged("Implementor", __oldValue, __newValue);

                if(OnImplementor_PostSetter != null && IsAttached)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.TypeRef>(__oldValue, __newValue);
					OnImplementor_PostSetter(this, e);
                }
                
            }
        }
        
        // normalize namespace for Templates
        private Kistl.App.Base.TypeRef Implementor__Implementation__
        {
			get
			{
				return Implementor;
			}
			set
			{
				Implementor = value;
			}
		}
        
        private int? _fk_Implementor;
        private Guid? _fk_guid_Implementor = null;
		// END Kistl.DalProvider.Memory.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate for Implementor
		public static event PropertyGetterHandler<Kistl.App.Base.ConstraintInvocation, Kistl.App.Base.TypeRef> OnImplementor_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ConstraintInvocation, Kistl.App.Base.TypeRef> OnImplementor_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ConstraintInvocation, Kistl.App.Base.TypeRef> OnImplementor_PostSetter;

        /// <summary>
        /// Name des implementierenden Members
        /// </summary>
        // value type property
           // Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string MemberName
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _MemberName;
                if (OnMemberName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnMemberName_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_MemberName != value)
                {
                    var __oldValue = _MemberName;
                    var __newValue = value;
                    if(OnMemberName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnMemberName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("MemberName", __oldValue, __newValue);
                    _MemberName = __newValue;
                    NotifyPropertyChanged("MemberName", __oldValue, __newValue);
                    if(OnMemberName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnMemberName_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _MemberName;
		public static event PropertyGetterHandler<Kistl.App.Base.ConstraintInvocation, string> OnMemberName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ConstraintInvocation, string> OnMemberName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ConstraintInvocation, string> OnMemberName_PostSetter;

        /// <summary>
        /// 
        /// </summary>
		[EventBasedMethod("OnGetCodeTemplate_ConstraintInvocation")]
		public virtual string GetCodeTemplate() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetCodeTemplate_ConstraintInvocation != null)
            {
                OnGetCodeTemplate_ConstraintInvocation(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on ConstraintInvocation.GetCodeTemplate");
            }
            return e.Result;
        }
		public delegate void GetCodeTemplate_Handler<T>(T obj, MethodReturnEventArgs<string> ret);
		public static event GetCodeTemplate_Handler<ConstraintInvocation> OnGetCodeTemplate_ConstraintInvocation;



        /// <summary>
        /// 
        /// </summary>
		[EventBasedMethod("OnGetMemberName_ConstraintInvocation")]
		public virtual string GetMemberName() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetMemberName_ConstraintInvocation != null)
            {
                OnGetMemberName_ConstraintInvocation(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on ConstraintInvocation.GetMemberName");
            }
            return e.Result;
        }
		public delegate void GetMemberName_Handler<T>(T obj, MethodReturnEventArgs<string> ret);
		public static event GetMemberName_Handler<ConstraintInvocation> OnGetMemberName_ConstraintInvocation;



        public override Type GetImplementedInterface()
        {
            return typeof(ConstraintInvocation);
        }

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (ConstraintInvocation)obj;
			var otherImpl = (ConstraintInvocation__Implementation__Memory)obj;
			var me = (ConstraintInvocation)this;

			me.ExportGuid = other.ExportGuid;
			me.MemberName = other.MemberName;
			this._fk_Implementor = otherImpl._fk_Implementor;
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

			if (_fk_guid_Implementor.HasValue)
				Implementor__Implementation__ = (Kistl.App.Base.TypeRef__Implementation__Memory)Context.FindPersistenceObject<Kistl.App.Base.TypeRef>(_fk_guid_Implementor.Value);
			else if (_fk_Implementor.HasValue)
				Implementor__Implementation__ = (Kistl.App.Base.TypeRef__Implementation__Memory)Context.Find<Kistl.App.Base.TypeRef>(_fk_Implementor.Value);
			else
				Implementor__Implementation__ = null;
		}
        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_ConstraintInvocation")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ConstraintInvocation != null)
            {
                OnToString_ConstraintInvocation(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<ConstraintInvocation> OnToString_ConstraintInvocation;

        [EventBasedMethod("OnPreSave_ConstraintInvocation")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ConstraintInvocation != null) OnPreSave_ConstraintInvocation(this);
        }
        public static event ObjectEventHandler<ConstraintInvocation> OnPreSave_ConstraintInvocation;

        [EventBasedMethod("OnPostSave_ConstraintInvocation")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ConstraintInvocation != null) OnPostSave_ConstraintInvocation(this);
        }
        public static event ObjectEventHandler<ConstraintInvocation> OnPostSave_ConstraintInvocation;

        [EventBasedMethod("OnCreated_ConstraintInvocation")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_ConstraintInvocation != null) OnCreated_ConstraintInvocation(this);
        }
        public static event ObjectEventHandler<ConstraintInvocation> OnCreated_ConstraintInvocation;

        [EventBasedMethod("OnDeleting_ConstraintInvocation")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_ConstraintInvocation != null) OnDeleting_ConstraintInvocation(this);
        }
        public static event ObjectEventHandler<ConstraintInvocation> OnDeleting_ConstraintInvocation;


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
					new CustomPropertyDescriptor<ConstraintInvocation__Implementation__Memory, Guid>(
						lazyCtx,
						new Guid("06d4a536-d9c4-487f-9861-ac15429e42de"),
						"ExportGuid",
						null,
						obj => obj.ExportGuid,
						(obj, val) => obj.ExportGuid = val),
					// else
					new CustomPropertyDescriptor<ConstraintInvocation__Implementation__Memory, Kistl.App.Base.TypeRef>(
						lazyCtx,
						new Guid("4b8486d5-2c48-4485-9824-d0a4a8bbbbca"),
						"Implementor",
						null,
						obj => obj.Implementor,
						(obj, val) => obj.Implementor = val),
					// else
					new CustomPropertyDescriptor<ConstraintInvocation__Implementation__Memory, string>(
						lazyCtx,
						new Guid("fd6ac977-3eab-4b2c-952a-2a1ad043b99a"),
						"MemberName",
						null,
						obj => obj.MemberName,
						(obj, val) => obj.MemberName = val),
					// rel: ConstraintInvocation has TypeRef (ed423e87-e04d-4753-ba99-c186a7a12242)
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
                case "Implementor":
                    __oldValue = _fk_Implementor;
                    NotifyPropertyChanging("Implementor", __oldValue, __newValue);
                    _fk_Implementor = __newValue;
                    NotifyPropertyChanged("Implementor", __oldValue, __newValue);
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
            BinarySerializer.ToStream(this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.ToStream(this._ExportGuid, binStream);
            }
            BinarySerializer.ToStream(this._fk_Implementor, binStream);
            BinarySerializer.ToStream(this._MemberName, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.FromStream(out this._ExportGuid, binStream);
            }
            BinarySerializer.FromStream(out this._fk_Implementor, binStream);
            BinarySerializer.FromStream(out this._MemberName, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            }
            XmlStreamer.ToStream(this._fk_Implementor, xml, "Implementor", "Kistl.App.Base");
            XmlStreamer.ToStream(this._MemberName, xml, "MemberName", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            }
            XmlStreamer.FromStream(ref this._fk_Implementor, xml, "Implementor", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._MemberName, xml, "MemberName", "Kistl.App.Base");
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            
            xml.WriteAttributeString("ExportGuid", this._ExportGuid.ToString());
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(Implementor != null ? Implementor.ExportGuid : (Guid?)null, xml, "Implementor", "Kistl.App.Base");
    
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._MemberName, xml, "MemberName", "Kistl.App.Base");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            this._isExportGuidSet = true;
            XmlStreamer.FromStream(ref this._fk_guid_Implementor, xml, "Implementor", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._MemberName, xml, "MemberName", "Kistl.App.Base");
        }

#endregion

    }


}