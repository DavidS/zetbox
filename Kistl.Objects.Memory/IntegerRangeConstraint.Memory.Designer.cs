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
    [System.Diagnostics.DebuggerDisplay("IntegerRangeConstraint")]
    public class IntegerRangeConstraint__Implementation__Memory : Kistl.App.Base.Constraint__Implementation__Memory, IntegerRangeConstraint
    {
        [Obsolete]
        public IntegerRangeConstraint__Implementation__Memory()
            : base(null)
        {
            {
            }
        }

        public IntegerRangeConstraint__Implementation__Memory(Func<IReadOnlyKistlContext> lazyCtx)
            : base(lazyCtx)
        {
            {
            }
        }


        /// <summary>
        /// The biggest value accepted by this constraint
        /// </summary>
        // value type property
           // Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual int Max
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Max;
                if (OnMax_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnMax_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Max != value)
                {
                    var __oldValue = _Max;
                    var __newValue = value;
                    if(OnMax_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnMax_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Max", __oldValue, __newValue);
                    _Max = __newValue;
                    NotifyPropertyChanged("Max", __oldValue, __newValue);
                    if(OnMax_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnMax_PostSetter(this, __e);
                    }
                }
            }
        }
        private int _Max;
		public static event PropertyGetterHandler<Kistl.App.Base.IntegerRangeConstraint, int> OnMax_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.IntegerRangeConstraint, int> OnMax_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.IntegerRangeConstraint, int> OnMax_PostSetter;

        /// <summary>
        /// The smallest value accepted by this constraint
        /// </summary>
        // value type property
           // Kistl.Server.Generators.Templates.Implementation.ObjectClasses.NotifyingDataProperty
        public virtual int Min
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Min;
                if (OnMin_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnMin_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Min != value)
                {
                    var __oldValue = _Min;
                    var __newValue = value;
                    if(OnMin_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnMin_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Min", __oldValue, __newValue);
                    _Min = __newValue;
                    NotifyPropertyChanged("Min", __oldValue, __newValue);
                    if(OnMin_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnMin_PostSetter(this, __e);
                    }
                }
            }
        }
        private int _Min;
		public static event PropertyGetterHandler<Kistl.App.Base.IntegerRangeConstraint, int> OnMin_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.IntegerRangeConstraint, int> OnMin_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.IntegerRangeConstraint, int> OnMin_PostSetter;

        /// <summary>
        /// 
        /// </summary>
		[EventBasedMethod("OnGetErrorText_IntegerRangeConstraint")]
		public override string GetErrorText(System.Object constrainedObject, System.Object constrainedValue) 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetErrorText_IntegerRangeConstraint != null)
            {
                OnGetErrorText_IntegerRangeConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.GetErrorText(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
		public static event GetErrorText_Handler<IntegerRangeConstraint> OnGetErrorText_IntegerRangeConstraint;



        /// <summary>
        /// 
        /// </summary>
		[EventBasedMethod("OnIsValid_IntegerRangeConstraint")]
		public override bool IsValid(System.Object constrainedObject, System.Object constrainedValue) 
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnIsValid_IntegerRangeConstraint != null)
            {
                OnIsValid_IntegerRangeConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.IsValid(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
		public static event IsValid_Handler<IntegerRangeConstraint> OnIsValid_IntegerRangeConstraint;



        public override Type GetImplementedInterface()
        {
            return typeof(IntegerRangeConstraint);
        }

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (IntegerRangeConstraint)obj;
			var otherImpl = (IntegerRangeConstraint__Implementation__Memory)obj;
			var me = (IntegerRangeConstraint)this;

			me.Max = other.Max;
			me.Min = other.Min;
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
        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_IntegerRangeConstraint")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_IntegerRangeConstraint != null)
            {
                OnToString_IntegerRangeConstraint(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<IntegerRangeConstraint> OnToString_IntegerRangeConstraint;

        [EventBasedMethod("OnPreSave_IntegerRangeConstraint")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_IntegerRangeConstraint != null) OnPreSave_IntegerRangeConstraint(this);
        }
        public static event ObjectEventHandler<IntegerRangeConstraint> OnPreSave_IntegerRangeConstraint;

        [EventBasedMethod("OnPostSave_IntegerRangeConstraint")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_IntegerRangeConstraint != null) OnPostSave_IntegerRangeConstraint(this);
        }
        public static event ObjectEventHandler<IntegerRangeConstraint> OnPostSave_IntegerRangeConstraint;

        [EventBasedMethod("OnCreated_IntegerRangeConstraint")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_IntegerRangeConstraint != null) OnCreated_IntegerRangeConstraint(this);
        }
        public static event ObjectEventHandler<IntegerRangeConstraint> OnCreated_IntegerRangeConstraint;

        [EventBasedMethod("OnDeleting_IntegerRangeConstraint")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_IntegerRangeConstraint != null) OnDeleting_IntegerRangeConstraint(this);
        }
        public static event ObjectEventHandler<IntegerRangeConstraint> OnDeleting_IntegerRangeConstraint;


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
					new CustomPropertyDescriptor<IntegerRangeConstraint__Implementation__Memory, int>(
						lazyCtx,
						new Guid("dff43695-5b93-4378-a01d-94a82d29dcef"),
						"Max",
						null,
						obj => obj.Max,
						(obj, val) => obj.Max = val),
					// else
					new CustomPropertyDescriptor<IntegerRangeConstraint__Implementation__Memory, int>(
						lazyCtx,
						new Guid("8afdbf66-c979-4c09-8872-1a44aa1dbf72"),
						"Min",
						null,
						obj => obj.Min,
						(obj, val) => obj.Min = val),
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
            BinarySerializer.ToStream(this._Max, binStream);
            BinarySerializer.ToStream(this._Min, binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            
            base.FromStream(binStream);
            BinarySerializer.FromStream(out this._Max, binStream);
            BinarySerializer.FromStream(out this._Min, binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            
            base.ToStream(xml);
            XmlStreamer.ToStream(this._Max, xml, "Max", "Kistl.App.Base");
            XmlStreamer.ToStream(this._Min, xml, "Min", "Kistl.App.Base");
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            
            base.FromStream(xml);
            XmlStreamer.FromStream(ref this._Max, xml, "Max", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Min, xml, "Min", "Kistl.App.Base");
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            
            base.Export(xml, modules);
    
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._Max, xml, "Max", "Kistl.App.Base");
    
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._Min, xml, "Min", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            
            base.MergeImport(xml);
            XmlStreamer.FromStream(ref this._Max, xml, "Max", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Min, xml, "Min", "Kistl.App.Base");
        }

#endregion

    }


}