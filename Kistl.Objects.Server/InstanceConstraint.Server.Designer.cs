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
    using Kistl.DalProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="InstanceConstraint")]
    [System.Diagnostics.DebuggerDisplay("InstanceConstraint")]
    public class InstanceConstraint__Implementation__ : BaseServerDataObject_EntityFramework, InstanceConstraint, Kistl.API.IExportableInternal
    {
        [Obsolete]
        public InstanceConstraint__Implementation__()
            : base(null)
        {
        }

        public InstanceConstraint__Implementation__(Func<IReadOnlyKistlContext> lazyCtx)
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
    /*
    Relation: FK_Constraint_on_Constrained
    A: ZeroOrMore InstanceConstraint as Constraint
    B: ZeroOrOne DataType as Constrained
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.DataType Constrained
        {
            get
            {
                return Constrained__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                Constrained__Implementation__ = (Kistl.App.Base.DataType__Implementation__)value;
            }
        }
        
        private int? _fk_Constrained;
        private Guid? _fk_guid_Constrained = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Constraint_on_Constrained", "Constrained")]
        public Kistl.App.Base.DataType__Implementation__ Constrained__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.DataType__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.DataType__Implementation__>(
                        "Model.FK_Constraint_on_Constrained",
                        "Constrained");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnConstrained_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.DataType>(__value);
					OnConstrained_Getter(this, e);
					__value = (Kistl.App.Base.DataType__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.DataType__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.DataType__Implementation__>(
                        "Model.FK_Constraint_on_Constrained",
                        "Constrained");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.DataType __oldValue = (Kistl.App.Base.DataType)r.Value;
                Kistl.App.Base.DataType __newValue = (Kistl.App.Base.DataType)value;

                if(OnConstrained_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.DataType>(__oldValue, __newValue);
					OnConstrained_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.DataType__Implementation__)__newValue;
                if(OnConstrained_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.DataType>(__oldValue, __newValue);
					OnConstrained_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public static event PropertyGetterHandler<Kistl.App.Base.InstanceConstraint, Kistl.App.Base.DataType> OnConstrained_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.InstanceConstraint, Kistl.App.Base.DataType> OnConstrained_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.InstanceConstraint, Kistl.App.Base.DataType> OnConstrained_PostSetter;

        /// <summary>
        /// Export Guid
        /// </summary>
        // value type property
        private bool _isExportGuidSet = false;
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual Guid ExportGuid
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ExportGuid;
                if (!_isExportGuidSet) {
                    var __p = FrozenContext.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("8ef28076-900c-4294-920c-5d0d91e925bb"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        __result = this._ExportGuid = (Guid)__p.DefaultValue.GetDefaultValue();
                    } else {
                        Kistl.API.Utils.Logging.Log.Warn("Unable to get default value for property 'InstanceConstraint.ExportGuid'");
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
		public static event PropertyGetterHandler<Kistl.App.Base.InstanceConstraint, Guid> OnExportGuid_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.InstanceConstraint, Guid> OnExportGuid_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.InstanceConstraint, Guid> OnExportGuid_PostSetter;

        /// <summary>
        /// The reason of this constraint
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.DalProvider.EF.Generator.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual string Reason
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Reason;
                if (OnReason_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnReason_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Reason != value)
                {
                    var __oldValue = _Reason;
                    var __newValue = value;
                    if(OnReason_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnReason_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Reason", __oldValue, __newValue);
                    _Reason = __newValue;
                    NotifyPropertyChanged("Reason", __oldValue, __newValue);
                    if(OnReason_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnReason_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Reason;
		public static event PropertyGetterHandler<Kistl.App.Base.InstanceConstraint, string> OnReason_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.InstanceConstraint, string> OnReason_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.InstanceConstraint, string> OnReason_PostSetter;

        /// <summary>
        /// 
        /// </summary>
		[EventBasedMethod("OnGetErrorText_InstanceConstraint")]
		public virtual string GetErrorText(Kistl.API.IDataObject constrainedObject) 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetErrorText_InstanceConstraint != null)
            {
                OnGetErrorText_InstanceConstraint(this, e, constrainedObject);
            }
            else
            {
                throw new NotImplementedException("No handler registered on InstanceConstraint.GetErrorText");
            }
            return e.Result;
        }
		public delegate void GetErrorText_Handler<T>(T obj, MethodReturnEventArgs<string> ret, Kistl.API.IDataObject constrainedObject);
		public static event GetErrorText_Handler<InstanceConstraint> OnGetErrorText_InstanceConstraint;



        /// <summary>
        /// 
        /// </summary>
		[EventBasedMethod("OnIsValid_InstanceConstraint")]
		public virtual bool IsValid(Kistl.API.IDataObject constrainedObject) 
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnIsValid_InstanceConstraint != null)
            {
                OnIsValid_InstanceConstraint(this, e, constrainedObject);
            }
            else
            {
                throw new NotImplementedException("No handler registered on InstanceConstraint.IsValid");
            }
            return e.Result;
        }
		public delegate void IsValid_Handler<T>(T obj, MethodReturnEventArgs<bool> ret, Kistl.API.IDataObject constrainedObject);
		public static event IsValid_Handler<InstanceConstraint> OnIsValid_InstanceConstraint;



        public override Type GetImplementedInterface()
        {
            return typeof(InstanceConstraint);
        }

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (InstanceConstraint)obj;
			var otherImpl = (InstanceConstraint__Implementation__)obj;
			var me = (InstanceConstraint)this;

			me.ExportGuid = other.ExportGuid;
			me.Reason = other.Reason;
			this._fk_Constrained = otherImpl._fk_Constrained;
		}

		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
			// fix direct object references

			if (_fk_guid_Constrained.HasValue)
				Constrained__Implementation__ = (Kistl.App.Base.DataType__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.DataType>(_fk_guid_Constrained.Value);
			else if (_fk_Constrained.HasValue)
				Constrained__Implementation__ = (Kistl.App.Base.DataType__Implementation__)Context.Find<Kistl.App.Base.DataType>(_fk_Constrained.Value);
			else
				Constrained__Implementation__ = null;
		}
        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_InstanceConstraint")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_InstanceConstraint != null)
            {
                OnToString_InstanceConstraint(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<InstanceConstraint> OnToString_InstanceConstraint;

        [EventBasedMethod("OnPreSave_InstanceConstraint")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_InstanceConstraint != null) OnPreSave_InstanceConstraint(this);
        }
        public static event ObjectEventHandler<InstanceConstraint> OnPreSave_InstanceConstraint;

        [EventBasedMethod("OnPostSave_InstanceConstraint")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_InstanceConstraint != null) OnPostSave_InstanceConstraint(this);
        }
        public static event ObjectEventHandler<InstanceConstraint> OnPostSave_InstanceConstraint;

        [EventBasedMethod("OnCreated_InstanceConstraint")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_InstanceConstraint != null) OnCreated_InstanceConstraint(this);
        }
        public static event ObjectEventHandler<InstanceConstraint> OnCreated_InstanceConstraint;

        [EventBasedMethod("OnDeleting_InstanceConstraint")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_InstanceConstraint != null) OnDeleting_InstanceConstraint(this);
        }
        public static event ObjectEventHandler<InstanceConstraint> OnDeleting_InstanceConstraint;


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
					new CustomPropertyDescriptor<InstanceConstraint__Implementation__, Kistl.App.Base.DataType>(
						lazyCtx,
						new Guid("d89723fc-1050-45a1-9b74-5575a677bc2b"),
						"Constrained",
						null,
						obj => obj.Constrained,
						(obj, val) => obj.Constrained = val),
					// else
					new CustomPropertyDescriptor<InstanceConstraint__Implementation__, Guid>(
						lazyCtx,
						new Guid("8ef28076-900c-4294-920c-5d0d91e925bb"),
						"ExportGuid",
						null,
						obj => obj.ExportGuid,
						(obj, val) => obj.ExportGuid = val),
					// else
					new CustomPropertyDescriptor<InstanceConstraint__Implementation__, string>(
						lazyCtx,
						new Guid("83be7495-e0e0-48fc-872a-70de9c0f7a88"),
						"Reason",
						null,
						obj => obj.Reason,
						(obj, val) => obj.Reason = val),
					// rel: Constraint on Constrained (e2b66b79-ab7a-43c0-a229-16dddf4b8934)
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
            BinarySerializer.ToStream(Constrained != null ? Constrained.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.ToStream(this._ExportGuid, binStream);
            }
            BinarySerializer.ToStream(this._Reason, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._fk_Constrained, binStream);
            BinarySerializer.FromStream(out this._isExportGuidSet, binStream);
            if (this._isExportGuidSet) {
                BinarySerializer.FromStream(out this._ExportGuid, binStream);
            }
            BinarySerializer.FromStream(out this._Reason, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(Constrained != null ? Constrained.ID : (int?)null, xml, "Constrained", "Kistl.App.Base");
            XmlStreamer.ToStream(this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            }
            XmlStreamer.ToStream(this._Reason, xml, "Reason", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._fk_Constrained, xml, "Constrained", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._isExportGuidSet, xml, "IsExportGuidSet", "Kistl.App.Base");
            if (this._isExportGuidSet) {
                XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            }
            XmlStreamer.FromStream(ref this._Reason, xml, "Reason", "Kistl.App.Base");
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            
            xml.WriteAttributeString("ExportGuid", this._ExportGuid.ToString());
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(Constrained != null ? Constrained.ExportGuid : (Guid?)null, xml, "Constrained", "Kistl.App.Base");
    
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._Reason, xml, "Reason", "Kistl.App.Base");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            XmlStreamer.FromStream(ref this._fk_guid_Constrained, xml, "Constrained", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            this._isExportGuidSet = true;
            XmlStreamer.FromStream(ref this._Reason, xml, "Reason", "Kistl.App.Base");
        }

#endregion

    }


}