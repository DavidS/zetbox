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
    using Kistl.DalProvider.Base.RelationWrappers;

    using Kistl.API.Server;
    using Kistl.DalProvider.Ef;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// Metadefinition Object for DateTime Properties.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="DateTimeProperty")]
    [System.Diagnostics.DebuggerDisplay("DateTimeProperty")]
    public class DateTimePropertyEfImpl : Kistl.App.Base.ValueTypePropertyEfImpl, DateTimeProperty
    {
        [Obsolete]
        public DateTimePropertyEfImpl()
            : base(null)
        {
        }

        public DateTimePropertyEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// Style of Datetime. Can be Date, Date and Time or Time
        /// </summary>
        // enumeration property
   		// Kistl.DalProvider.Ef.Generator.Templates.Properties.EnumerationPropertyTemplate
        // implement the user-visible interface
        public Kistl.App.Base.DateTimeStyles? DateTimeStyle
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(Kistl.App.Base.DateTimeStyles?);
				var __value = _DateTimeStyle;
				if(OnDateTimeStyle_Getter != null)
				{
					var e = new PropertyGetterEventArgs<Kistl.App.Base.DateTimeStyles?>(__value);
					OnDateTimeStyle_Getter(this, e);
					__value = e.Result;
				}
                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (_DateTimeStyle != value)
                {
					var __oldValue = _DateTimeStyle;
					var __newValue = value;
                    if(OnDateTimeStyle_PreSetter != null)
                    {
						var e = new PropertyPreSetterEventArgs<Kistl.App.Base.DateTimeStyles?>(__oldValue, __newValue);
						OnDateTimeStyle_PreSetter(this, e);
						__newValue = e.Result;
                    }
					
                    NotifyPropertyChanging("DateTimeStyle", "DateTimeStyleImpl", __oldValue, __newValue);
                    _DateTimeStyle = value;
                    NotifyPropertyChanged("DateTimeStyle", "DateTimeStyleImpl", __oldValue, __newValue);
                    if(OnDateTimeStyle_PostSetter != null)
                    {
						var e = new PropertyPostSetterEventArgs<Kistl.App.Base.DateTimeStyles?>(__oldValue, __newValue);
						OnDateTimeStyle_PostSetter(this, e);
                    }
                    
                }
            }
        }
        
        /// <summary>backing store for DateTimeStyle</summary>
        private Kistl.App.Base.DateTimeStyles? _DateTimeStyle;
        
        /// <summary>EF sees only this property, for DateTimeStyle</summary>
        [XmlIgnore()]
        [EdmScalarProperty()]
        public int? DateTimeStyleImpl
        {
            get
            {
                return (int?)this.DateTimeStyle;
            }
            set
            {
                this.DateTimeStyle = (Kistl.App.Base.DateTimeStyles?)value;
            }
        }
        
		public static event PropertyGetterHandler<Kistl.App.Base.DateTimeProperty, Kistl.App.Base.DateTimeStyles?> OnDateTimeStyle_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.DateTimeProperty, Kistl.App.Base.DateTimeStyles?> OnDateTimeStyle_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.DateTimeProperty, Kistl.App.Base.DateTimeStyles?> OnDateTimeStyle_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_DateTimeProperty")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_DateTimeProperty != null)
            {
                OnGetLabel_DateTimeProperty(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<DateTimeProperty> OnGetLabel_DateTimeProperty;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetName_DateTimeProperty")]
        public override string GetName()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetName_DateTimeProperty != null)
            {
                OnGetName_DateTimeProperty(this, e);
            }
            else
            {
                e.Result = base.GetName();
            }
            return e.Result;
        }
        public static event GetName_Handler<DateTimeProperty> OnGetName_DateTimeProperty;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetPropertyType_DateTimeProperty")]
        public override System.Type GetPropertyType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_DateTimeProperty != null)
            {
                OnGetPropertyType_DateTimeProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
        public static event GetPropertyType_Handler<DateTimeProperty> OnGetPropertyType_DateTimeProperty;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetPropertyTypeString_DateTimeProperty")]
        public override string GetPropertyTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_DateTimeProperty != null)
            {
                OnGetPropertyTypeString_DateTimeProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
        public static event GetPropertyTypeString_Handler<DateTimeProperty> OnGetPropertyTypeString_DateTimeProperty;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(DateTimeProperty);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (DateTimeProperty)obj;
            var otherImpl = (DateTimePropertyEfImpl)obj;
            var me = (DateTimeProperty)this;

            me.DateTimeStyle = other.DateTimeStyle;
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
                    new PropertyDescriptorEfImpl<DateTimePropertyEfImpl, Kistl.App.Base.DateTimeStyles?>(
                        lazyCtx,
                        new Guid("76b04254-3911-4753-ba11-cb1af074b056"),
                        "DateTimeStyle",
                        null,
                        obj => obj.DateTimeStyle,
                        (obj, val) => obj.DateTimeStyle = val),
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
        [EventBasedMethod("OnToString_DateTimeProperty")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DateTimeProperty != null)
            {
                OnToString_DateTimeProperty(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<DateTimeProperty> OnToString_DateTimeProperty;

        [EventBasedMethod("OnPreSave_DateTimeProperty")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DateTimeProperty != null) OnPreSave_DateTimeProperty(this);
        }
        public static event ObjectEventHandler<DateTimeProperty> OnPreSave_DateTimeProperty;

        [EventBasedMethod("OnPostSave_DateTimeProperty")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DateTimeProperty != null) OnPostSave_DateTimeProperty(this);
        }
        public static event ObjectEventHandler<DateTimeProperty> OnPostSave_DateTimeProperty;

        [EventBasedMethod("OnCreated_DateTimeProperty")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_DateTimeProperty != null) OnCreated_DateTimeProperty(this);
        }
        public static event ObjectEventHandler<DateTimeProperty> OnCreated_DateTimeProperty;

        [EventBasedMethod("OnDeleting_DateTimeProperty")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_DateTimeProperty != null) OnDeleting_DateTimeProperty(this);
        }
        public static event ObjectEventHandler<DateTimeProperty> OnDeleting_DateTimeProperty;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream((int?)((Kistl.App.Base.DateTimeProperty)this).DateTimeStyle, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            {
                int? baseValue;
                BinarySerializer.FromStream(out baseValue, binStream);
                ((Kistl.App.Base.DateTimeProperty)this).DateTimeStyle = (Kistl.App.Base.DateTimeStyles?)baseValue;
            }
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
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.ToStream((int?)((Kistl.App.Base.DateTimeProperty)this).DateTimeStyle, xml, "DateTimeStyle", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStreamConverter(v => ((Kistl.App.Base.DateTimeProperty)this).DateTimeStyle = (Kistl.App.Base.DateTimeStyles?)v, xml, "DateTimeStyle", "Kistl.App.Base");
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            if (!CurrentAccessRights.HasReadRights()) return;
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream((int?)((Kistl.App.Base.DateTimeProperty)this).DateTimeStyle, xml, "DateTimeStyle", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.FromStreamConverter(v => ((Kistl.App.Base.DateTimeProperty)this).DateTimeStyle = (Kistl.App.Base.DateTimeStyles?)v, xml, "DateTimeStyle", "Kistl.App.Base");
        }

        #endregion

    }
}