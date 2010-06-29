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
    /// Metadefinition Object for CLR Object Parameter.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("CLRObjectParameter")]
    public class CLRObjectParameter__Implementation__Memory : Kistl.App.Base.BaseParameter__Implementation__Memory, CLRObjectParameter
    {
        [Obsolete]
        public CLRObjectParameter__Implementation__Memory()
            : base(null)
        {
            {
            }
        }

        public CLRObjectParameter__Implementation__Memory(Func<IReadOnlyKistlContext> lazyCtx)
            : base(lazyCtx)
        {
            {
            }
        }


        /// <summary>
        /// 
        /// </summary>
        // object reference property
		// BEGIN Kistl.DalProvider.Memory.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate for Type
		// rel(A): ClrObjectParameter isOf Type
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Kistl.App.Base.TypeRef Type
        {
            get
            {
				Kistl.App.Base.TypeRef __value;
                if (_fk_Type.HasValue)
                    __value = Context.Find<Kistl.App.Base.TypeRef>(_fk_Type.Value);
                else
                    __value = null;

				if(OnType_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.TypeRef>(__value);
					OnType_Getter(this, e);
					__value = e.Result;
				}
                    
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if(value != null && value.Context != this.Context) throw new WrongKistlContextException();
                
                // shortcut noops
                if (value == null && _fk_Type == null)
					return;
                else if (value != null && value.ID == _fk_Type)
					return;
			           
	            // cache old value to remove inverse references later
                var __oldValue = Type;
				var __newValue = value;

				// Changing Event fires before anything is touched
				NotifyPropertyChanging("Type", __oldValue, __newValue);
				
                if(OnType_PreSetter != null && IsAttached)
                {
					var e = new PropertyPreSetterEventArgs<Kistl.App.Base.TypeRef>(__oldValue, __newValue);
					OnType_PreSetter(this, e);
					__newValue = e.Result;
                }
                
				// next, set the local reference
                _fk_Type = __newValue == null ? (int?)null : __newValue.ID;
				
				// everything is done. fire the Changed event
				NotifyPropertyChanged("Type", __oldValue, __newValue);

                if(OnType_PostSetter != null && IsAttached)
                {
					var e = new PropertyPostSetterEventArgs<Kistl.App.Base.TypeRef>(__oldValue, __newValue);
					OnType_PostSetter(this, e);
                }
                
            }
        }
        
        // normalize namespace for Templates
        private Kistl.App.Base.TypeRef Type__Implementation__
        {
			get
			{
				return Type;
			}
			set
			{
				Type = value;
			}
		}
        
        private int? _fk_Type;
        private Guid? _fk_guid_Type = null;
		// END Kistl.DalProvider.Memory.Generator.Implementation.ObjectClasses.ObjectReferencePropertyTemplate for Type
		public static event PropertyGetterHandler<Kistl.App.Base.CLRObjectParameter, Kistl.App.Base.TypeRef> OnType_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.CLRObjectParameter, Kistl.App.Base.TypeRef> OnType_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.CLRObjectParameter, Kistl.App.Base.TypeRef> OnType_PostSetter;

        /// <summary>
        /// Returns the resulting Type of this Method-Parameter Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetParameterType_CLRObjectParameter")]
		public override System.Type GetParameterType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetParameterType_CLRObjectParameter != null)
            {
                OnGetParameterType_CLRObjectParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterType();
            }
            return e.Result;
        }
		public static event GetParameterType_Handler<CLRObjectParameter> OnGetParameterType_CLRObjectParameter;



        /// <summary>
        /// Returns the String representation of this Method-Parameter Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetParameterTypeString_CLRObjectParameter")]
		public override string GetParameterTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetParameterTypeString_CLRObjectParameter != null)
            {
                OnGetParameterTypeString_CLRObjectParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterTypeString();
            }
            return e.Result;
        }
		public static event GetParameterTypeString_Handler<CLRObjectParameter> OnGetParameterTypeString_CLRObjectParameter;



        public override Type GetImplementedInterface()
        {
            return typeof(CLRObjectParameter);
        }

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (CLRObjectParameter)obj;
			var otherImpl = (CLRObjectParameter__Implementation__Memory)obj;
			var me = (CLRObjectParameter)this;

			this._fk_Type = otherImpl._fk_Type;
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

			if (_fk_guid_Type.HasValue)
				Type__Implementation__ = (Kistl.App.Base.TypeRef__Implementation__Memory)Context.FindPersistenceObject<Kistl.App.Base.TypeRef>(_fk_guid_Type.Value);
			else if (_fk_Type.HasValue)
				Type__Implementation__ = (Kistl.App.Base.TypeRef__Implementation__Memory)Context.Find<Kistl.App.Base.TypeRef>(_fk_Type.Value);
			else
				Type__Implementation__ = null;
		}
        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_CLRObjectParameter")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_CLRObjectParameter != null)
            {
                OnToString_CLRObjectParameter(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<CLRObjectParameter> OnToString_CLRObjectParameter;

        [EventBasedMethod("OnPreSave_CLRObjectParameter")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_CLRObjectParameter != null) OnPreSave_CLRObjectParameter(this);
        }
        public static event ObjectEventHandler<CLRObjectParameter> OnPreSave_CLRObjectParameter;

        [EventBasedMethod("OnPostSave_CLRObjectParameter")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_CLRObjectParameter != null) OnPostSave_CLRObjectParameter(this);
        }
        public static event ObjectEventHandler<CLRObjectParameter> OnPostSave_CLRObjectParameter;

        [EventBasedMethod("OnCreated_CLRObjectParameter")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_CLRObjectParameter != null) OnCreated_CLRObjectParameter(this);
        }
        public static event ObjectEventHandler<CLRObjectParameter> OnCreated_CLRObjectParameter;

        [EventBasedMethod("OnDeleting_CLRObjectParameter")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_CLRObjectParameter != null) OnDeleting_CLRObjectParameter(this);
        }
        public static event ObjectEventHandler<CLRObjectParameter> OnDeleting_CLRObjectParameter;


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
					new CustomPropertyDescriptor<CLRObjectParameter__Implementation__Memory, Kistl.App.Base.TypeRef>(
						lazyCtx,
						new Guid("137292ce-4493-451d-a7fa-1b7cc7df03dd"),
						"Type",
						null,
						obj => obj.Type,
						(obj, val) => obj.Type = val),
					// rel: ClrObjectParameter isOf Type (4c7e0ac7-eb8a-4304-85e7-fcc358cb639c)
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
                case "Type":
                    __oldValue = _fk_Type;
                    NotifyPropertyChanging("Type", __oldValue, __newValue);
                    _fk_Type = __newValue;
                    NotifyPropertyChanged("Type", __oldValue, __newValue);
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
            BinarySerializer.ToStream(this._fk_Type, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._fk_Type, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(this._fk_Type, xml, "Type", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._fk_Type, xml, "Type", "Kistl.App.Base");
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            
            base.Export(xml, modules);
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(Type != null ? Type.ExportGuid : (Guid?)null, xml, "Type", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            
            base.MergeImport(xml);
            XmlStreamer.FromStream(ref this._fk_guid_Type, xml, "Type", "Kistl.App.Base");
        }

#endregion

    }


}