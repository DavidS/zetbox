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
    using Kistl.DALProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// Metadefinition Object for a MethodInvocation on a Method of a DataType.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="MethodInvocation")]
    [System.Diagnostics.DebuggerDisplay("MethodInvocation")]
    public class MethodInvocation__Implementation__ : BaseServerDataObject_EntityFramework, Kistl.API.IExportableInternal, MethodInvocation
    {
    
		public MethodInvocation__Implementation__()
		{
        }

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.IdProperty
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
        /// Export Guid
        /// </summary>
        // value type property
        private bool _isExportGuidSet = false;
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual Guid ExportGuid
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _ExportGuid;
                if (!_isExportGuidSet) {
                    var __p = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("53e7daa2-aba7-4cd0-bab6-3c0d07648b2e"));
                    if (__p != null) {
                        _isExportGuidSet = true;
                        __result = this._ExportGuid = (Guid)__p.DefaultValue.GetDefaultValue();
                    } else {
                        System.Diagnostics.Trace.TraceWarning("Unable to get default value for property 'MethodInvocation.ExportGuid'");
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
                if (_ExportGuid != value)
                {
                    var __oldValue = _ExportGuid;
                    var __newValue = value;
                    _isExportGuidSet = true;
                    if(OnExportGuid_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("ExportGuid", __oldValue, __newValue);
                    _ExportGuid = __newValue;
                    NotifyPropertyChanged("ExportGuid", __oldValue, __newValue);
                    if(OnExportGuid_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<Guid>(__oldValue, __newValue);
                        OnExportGuid_PostSetter(this, __e);
                    }
                }
            }
        }
        private Guid _ExportGuid;
		public event PropertyGetterHandler<Kistl.App.Base.MethodInvocation, Guid> OnExportGuid_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.MethodInvocation, Guid> OnExportGuid_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.MethodInvocation, Guid> OnExportGuid_PostSetter;
        /// <summary>
        /// The Type implementing this invocation
        /// </summary>
    /*
    Relation: FK_MethodInvocation_has_TypeRef
    A: ZeroOrMore MethodInvocation as MethodInvocation
    B: ZeroOrOne TypeRef as Implementor
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.TypeRef Implementor
        {
            get
            {
                return Implementor__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                Implementor__Implementation__ = (Kistl.App.Base.TypeRef__Implementation__)value;
            }
        }
        
        private int? _fk_Implementor;
        private Guid? _fk_guid_Implementor = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_MethodInvocation_has_TypeRef", "Implementor")]
        public Kistl.App.Base.TypeRef__Implementation__ Implementor__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.TypeRef__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.TypeRef__Implementation__>(
                        "Model.FK_MethodInvocation_has_TypeRef",
                        "Implementor");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnImplementor_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.TypeRef>(__value);
					OnImplementor_Getter(this, e);
					__value = (Kistl.App.Base.TypeRef__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.TypeRef__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.TypeRef__Implementation__>(
                        "Model.FK_MethodInvocation_has_TypeRef",
                        "Implementor");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.TypeRef __oldValue = (Kistl.App.Base.TypeRef)r.Value;
                Kistl.App.Base.TypeRef __newValue = (Kistl.App.Base.TypeRef)value;

                if(OnImplementor_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.TypeRef>(__oldValue, __newValue);
					OnImplementor_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.TypeRef__Implementation__)__newValue;
                if(OnImplementor_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.TypeRef>(__oldValue, __newValue);
					OnImplementor_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.Base.MethodInvocation, Kistl.App.Base.TypeRef> OnImplementor_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.MethodInvocation, Kistl.App.Base.TypeRef> OnImplementor_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.MethodInvocation, Kistl.App.Base.TypeRef> OnImplementor_PostSetter;
        /// <summary>
        /// In dieser Objektklasse implementieren
        /// </summary>
    /*
    Relation: FK_DataType_has_MethodInvocation
    A: One DataType as InvokeOnObjectClass
    B: ZeroOrMore MethodInvocation as MethodInvocations
    Preferred Storage: MergeIntoB
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.DataType InvokeOnObjectClass
        {
            get
            {
                return InvokeOnObjectClass__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                InvokeOnObjectClass__Implementation__ = (Kistl.App.Base.DataType__Implementation__)value;
            }
        }
        
        private int? _fk_InvokeOnObjectClass;
        private Guid? _fk_guid_InvokeOnObjectClass = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_DataType_has_MethodInvocation", "InvokeOnObjectClass")]
        public Kistl.App.Base.DataType__Implementation__ InvokeOnObjectClass__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.DataType__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.DataType__Implementation__>(
                        "Model.FK_DataType_has_MethodInvocation",
                        "InvokeOnObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnInvokeOnObjectClass_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.DataType>(__value);
					OnInvokeOnObjectClass_Getter(this, e);
					__value = (Kistl.App.Base.DataType__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.DataType__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.DataType__Implementation__>(
                        "Model.FK_DataType_has_MethodInvocation",
                        "InvokeOnObjectClass");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.DataType __oldValue = (Kistl.App.Base.DataType)r.Value;
                Kistl.App.Base.DataType __newValue = (Kistl.App.Base.DataType)value;

                if(OnInvokeOnObjectClass_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.DataType>(__oldValue, __newValue);
					OnInvokeOnObjectClass_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.DataType__Implementation__)__newValue;
                if(OnInvokeOnObjectClass_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.DataType>(__oldValue, __newValue);
					OnInvokeOnObjectClass_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.Base.MethodInvocation, Kistl.App.Base.DataType> OnInvokeOnObjectClass_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.MethodInvocation, Kistl.App.Base.DataType> OnInvokeOnObjectClass_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.MethodInvocation, Kistl.App.Base.DataType> OnInvokeOnObjectClass_PostSetter;
        /// <summary>
        /// Name des implementierenden Members
        /// </summary>
        // value type property
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
           // Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.NotifyingDataProperty
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
                    if(OnMemberName_PreSetter != null)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnMemberName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("MemberName", __oldValue, __newValue);
                    _MemberName = __newValue;
                    NotifyPropertyChanged("MemberName", __oldValue, __newValue);
                    if(OnMemberName_PostSetter != null)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnMemberName_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _MemberName;
		public event PropertyGetterHandler<Kistl.App.Base.MethodInvocation, string> OnMemberName_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.MethodInvocation, string> OnMemberName_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.MethodInvocation, string> OnMemberName_PostSetter;
        /// <summary>
        /// Methode, die Aufgerufen wird
        /// </summary>
    /*
    Relation: FK_Method_has_MethodInvocation
    A: One Method as Method
    B: ZeroOrMore MethodInvocation as MethodInvokations
    Preferred Storage: MergeIntoB
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Method Method
        {
            get
            {
                return Method__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                Method__Implementation__ = (Kistl.App.Base.Method__Implementation__)value;
            }
        }
        
        private int? _fk_Method;
        private Guid? _fk_guid_Method = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_Method_has_MethodInvocation", "Method")]
        public Kistl.App.Base.Method__Implementation__ Method__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Method__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Method__Implementation__>(
                        "Model.FK_Method_has_MethodInvocation",
                        "Method");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnMethod_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.Method>(__value);
					OnMethod_Getter(this, e);
					__value = (Kistl.App.Base.Method__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Method__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Method__Implementation__>(
                        "Model.FK_Method_has_MethodInvocation",
                        "Method");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.Method __oldValue = (Kistl.App.Base.Method)r.Value;
                Kistl.App.Base.Method __newValue = (Kistl.App.Base.Method)value;

                if(OnMethod_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Method>(__oldValue, __newValue);
					OnMethod_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.Method__Implementation__)__newValue;
                if(OnMethod_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Method>(__oldValue, __newValue);
					OnMethod_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.Base.MethodInvocation, Kistl.App.Base.Method> OnMethod_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.MethodInvocation, Kistl.App.Base.Method> OnMethod_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.MethodInvocation, Kistl.App.Base.Method> OnMethod_PostSetter;
        /// <summary>
        /// Zugehörig zum Modul
        /// </summary>
    /*
    Relation: FK_MethodInvocation_has_Module
    A: ZeroOrMore MethodInvocation as MethodInvocation
    B: ZeroOrOne Module as Module
    Preferred Storage: MergeIntoA
    */
        // object reference property
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.ObjectReferencePropertyTemplate
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.Module Module
        {
            get
            {
                return Module__Implementation__;
            }
            set
            {
                // TODO: NotifyPropertyChanged()
                // TODO: only accept EF objects from same Context
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                Module__Implementation__ = (Kistl.App.Base.Module__Implementation__)value;
            }
        }
        
        private int? _fk_Module;
        private Guid? _fk_guid_Module = null;
        // EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_MethodInvocation_has_Module", "Module")]
        public Kistl.App.Base.Module__Implementation__ Module__Implementation__
        {
            get
            {
                EntityReference<Kistl.App.Base.Module__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module__Implementation__>(
                        "Model.FK_MethodInvocation_has_Module",
                        "Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                    if(r.Value != null) r.Value.AttachToContext(this.Context);
                }
                var __value = r.Value;
				if(OnModule_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.Module>(__value);
					OnModule_Getter(this, e);
					__value = (Kistl.App.Base.Module__Implementation__)e.Result;
				}
                return __value;
            }
            set
            {
                EntityReference<Kistl.App.Base.Module__Implementation__> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Kistl.App.Base.Module__Implementation__>(
                        "Model.FK_MethodInvocation_has_Module",
                        "Module");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load(); 
                }
                Kistl.App.Base.Module __oldValue = (Kistl.App.Base.Module)r.Value;
                Kistl.App.Base.Module __newValue = (Kistl.App.Base.Module)value;

                if(OnModule_PreSetter != null)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Module>(__oldValue, __newValue);
					OnModule_PreSetter(this, e);
					__newValue = e.Result;
                }
                r.Value = (Kistl.App.Base.Module__Implementation__)__newValue;
                if(OnModule_PostSetter != null)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Module>(__oldValue, __newValue);
					OnModule_PostSetter(this, e);
                }
                                
            }
        }
        
        
		public event PropertyGetterHandler<Kistl.App.Base.MethodInvocation, Kistl.App.Base.Module> OnModule_Getter;
		public event PropertyPreSetterHandler<Kistl.App.Base.MethodInvocation, Kistl.App.Base.Module> OnModule_PreSetter;
		public event PropertyPostSetterHandler<Kistl.App.Base.MethodInvocation, Kistl.App.Base.Module> OnModule_PostSetter;
        /// <summary>
        /// 
        /// </summary>
		[EventBasedMethod("OnGetCodeTemplate_MethodInvocation")]
		public virtual string GetCodeTemplate() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetCodeTemplate_MethodInvocation != null)
            {
                OnGetCodeTemplate_MethodInvocation(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on MethodInvocation.GetCodeTemplate");
            }
            return e.Result;
        }
		public delegate void GetCodeTemplate_Handler<T>(T obj, MethodReturnEventArgs<string> ret);
		public event GetCodeTemplate_Handler<MethodInvocation> OnGetCodeTemplate_MethodInvocation;



        /// <summary>
        /// 
        /// </summary>
		[EventBasedMethod("OnGetMemberName_MethodInvocation")]
		public virtual string GetMemberName() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetMemberName_MethodInvocation != null)
            {
                OnGetMemberName_MethodInvocation(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on MethodInvocation.GetMemberName");
            }
            return e.Result;
        }
		public delegate void GetMemberName_Handler<T>(T obj, MethodReturnEventArgs<string> ret);
		public event GetMemberName_Handler<MethodInvocation> OnGetMemberName_MethodInvocation;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(MethodInvocation));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (MethodInvocation)obj;
			var otherImpl = (MethodInvocation__Implementation__)obj;
			var me = (MethodInvocation)this;

			me.ExportGuid = other.ExportGuid;
			me.MemberName = other.MemberName;
			this._fk_Implementor = otherImpl._fk_Implementor;
			this._fk_InvokeOnObjectClass = otherImpl._fk_InvokeOnObjectClass;
			this._fk_Method = otherImpl._fk_Method;
			this._fk_Module = otherImpl._fk_Module;
		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_MethodInvocation")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_MethodInvocation != null)
            {
                OnToString_MethodInvocation(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<MethodInvocation> OnToString_MethodInvocation;

        [EventBasedMethod("OnPreSave_MethodInvocation")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_MethodInvocation != null) OnPreSave_MethodInvocation(this);
        }
        public event ObjectEventHandler<MethodInvocation> OnPreSave_MethodInvocation;

        [EventBasedMethod("OnPostSave_MethodInvocation")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_MethodInvocation != null) OnPostSave_MethodInvocation(this);
        }
        public event ObjectEventHandler<MethodInvocation> OnPostSave_MethodInvocation;

        [EventBasedMethod("OnCreated_MethodInvocation")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_MethodInvocation != null) OnCreated_MethodInvocation(this);
        }
        public event ObjectEventHandler<MethodInvocation> OnCreated_MethodInvocation;

        [EventBasedMethod("OnDeleting_MethodInvocation")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_MethodInvocation != null) OnDeleting_MethodInvocation(this);
        }
        public event ObjectEventHandler<MethodInvocation> OnDeleting_MethodInvocation;


		protected override string GetPropertyError(string propertyName) 
		{
			switch(propertyName)
			{
				case "ExportGuid":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("53e7daa2-aba7-4cd0-bab6-3c0d07648b2e")).Constraints
						.Where(c => !c.IsValid(this, this.ExportGuid))
						.Select(c => c.GetErrorText(this, this.ExportGuid))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Implementor":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("521868ca-503c-409e-bfa5-2e9d887d0a19")).Constraints
						.Where(c => !c.IsValid(this, this.Implementor))
						.Select(c => c.GetErrorText(this, this.Implementor))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "InvokeOnObjectClass":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("94e98a50-cad2-4779-8c50-e4922d653781")).Constraints
						.Where(c => !c.IsValid(this, this.InvokeOnObjectClass))
						.Select(c => c.GetErrorText(this, this.InvokeOnObjectClass))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "MemberName":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("3282e04e-6cdd-4ba3-911c-3dd77b3eba66")).Constraints
						.Where(c => !c.IsValid(this, this.MemberName))
						.Select(c => c.GetErrorText(this, this.MemberName))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Method":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("b9db3b3b-d00d-479f-843f-6d41704eb079")).Constraints
						.Where(c => !c.IsValid(this, this.Method))
						.Select(c => c.GetErrorText(this, this.Method))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				case "Module":
				{
					var errors = FrozenContext.Single.FindPersistenceObject<Kistl.App.Base.Property>(new Guid("b959b313-2063-4391-bb97-14ac85d5dff0")).Constraints
						.Where(c => !c.IsValid(this, this.Module))
						.Select(c => c.GetErrorText(this, this.Module))
						.ToArray();
					
					return String.Join("; ", errors);
				}
				default:
					return base.GetPropertyError(propertyName);
			}
		}

		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
			// fix direct object references

			if (_fk_guid_Implementor.HasValue)
				Implementor__Implementation__ = (Kistl.App.Base.TypeRef__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.TypeRef>(_fk_guid_Implementor.Value);
			else if (_fk_Implementor.HasValue)
				Implementor__Implementation__ = (Kistl.App.Base.TypeRef__Implementation__)Context.Find<Kistl.App.Base.TypeRef>(_fk_Implementor.Value);
			else
				Implementor__Implementation__ = null;

			if (_fk_guid_InvokeOnObjectClass.HasValue)
				InvokeOnObjectClass__Implementation__ = (Kistl.App.Base.DataType__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.DataType>(_fk_guid_InvokeOnObjectClass.Value);
			else if (_fk_InvokeOnObjectClass.HasValue)
				InvokeOnObjectClass__Implementation__ = (Kistl.App.Base.DataType__Implementation__)Context.Find<Kistl.App.Base.DataType>(_fk_InvokeOnObjectClass.Value);
			else
				InvokeOnObjectClass__Implementation__ = null;

			if (_fk_guid_Method.HasValue)
				Method__Implementation__ = (Kistl.App.Base.Method__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.Method>(_fk_guid_Method.Value);
			else if (_fk_Method.HasValue)
				Method__Implementation__ = (Kistl.App.Base.Method__Implementation__)Context.Find<Kistl.App.Base.Method>(_fk_Method.Value);
			else
				Method__Implementation__ = null;

			if (_fk_guid_Module.HasValue)
				Module__Implementation__ = (Kistl.App.Base.Module__Implementation__)Context.FindPersistenceObject<Kistl.App.Base.Module>(_fk_guid_Module.Value);
			else if (_fk_Module.HasValue)
				Module__Implementation__ = (Kistl.App.Base.Module__Implementation__)Context.Find<Kistl.App.Base.Module>(_fk_Module.Value);
			else
				Module__Implementation__ = null;
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
            BinarySerializer.ToStream(this._ExportGuid, binStream);
            BinarySerializer.ToStream(Implementor != null ? Implementor.ID : (int?)null, binStream);
            BinarySerializer.ToStream(InvokeOnObjectClass != null ? InvokeOnObjectClass.ID : (int?)null, binStream);
            BinarySerializer.ToStream(this._MemberName, binStream);
            BinarySerializer.ToStream(Method != null ? Method.ID : (int?)null, binStream);
            BinarySerializer.ToStream(Module != null ? Module.ID : (int?)null, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._ExportGuid, binStream);
            BinarySerializer.FromStream(out this._fk_Implementor, binStream);
            BinarySerializer.FromStream(out this._fk_InvokeOnObjectClass, binStream);
            BinarySerializer.FromStream(out this._MemberName, binStream);
            BinarySerializer.FromStream(out this._fk_Method, binStream);
            BinarySerializer.FromStream(out this._fk_Module, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
            XmlStreamer.ToStream(this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.ToStream(Implementor != null ? Implementor.ID : (int?)null, xml, "Implementor", "Kistl.App.Base");
            XmlStreamer.ToStream(InvokeOnObjectClass != null ? InvokeOnObjectClass.ID : (int?)null, xml, "InvokeOnObjectClass", "Kistl.App.Base");
            XmlStreamer.ToStream(this._MemberName, xml, "MemberName", "Kistl.App.Base");
            XmlStreamer.ToStream(Method != null ? Method.ID : (int?)null, xml, "Method", "Kistl.App.Base");
            XmlStreamer.ToStream(Module != null ? Module.ID : (int?)null, xml, "Module", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_Implementor, xml, "Implementor", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_InvokeOnObjectClass, xml, "InvokeOnObjectClass", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._MemberName, xml, "MemberName", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_Method, xml, "Method", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_Module, xml, "Module", "Kistl.App.Base");
        }

        public virtual void Export(System.Xml.XmlWriter xml, string[] modules)
        {
			
			xml.WriteAttributeString("ExportGuid", this.ExportGuid.ToString());
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(Implementor != null ? Implementor.ExportGuid : (Guid?)null, xml, "Implementor", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(InvokeOnObjectClass != null ? InvokeOnObjectClass.ExportGuid : (Guid?)null, xml, "InvokeOnObjectClass", "Kistl.App.Base");
	
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._MemberName, xml, "MemberName", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(Method != null ? Method.ExportGuid : (Guid?)null, xml, "Method", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(Module != null ? Module.ExportGuid : (Guid?)null, xml, "Module", "Kistl.App.Base");
        }

        public virtual void MergeImport(System.Xml.XmlReader xml)
        {
            XmlStreamer.FromStream(ref this._ExportGuid, xml, "ExportGuid", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_Implementor, xml, "Implementor", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_InvokeOnObjectClass, xml, "InvokeOnObjectClass", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._MemberName, xml, "MemberName", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_Method, xml, "Method", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_Module, xml, "Module", "Kistl.App.Base");
        }

#endregion

    }


}