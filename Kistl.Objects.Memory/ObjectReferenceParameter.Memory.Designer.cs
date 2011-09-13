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

    using Kistl.DalProvider.Base;
    using Kistl.DalProvider.Memory;

    /// <summary>
    /// Metadefinition Object for Object Parameter.
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("ObjectReferenceParameter")]
    public class ObjectReferenceParameterMemoryImpl : Kistl.App.Base.BaseParameterMemoryImpl, ObjectReferenceParameter
    {
        [Obsolete]
        public ObjectReferenceParameterMemoryImpl()
            : base(null)
        {
        }

        public ObjectReferenceParameterMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// Kistl-Typ des Parameters
        /// </summary>
        // BEGIN Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ObjectClass
        // fkBackingName=_fk_ObjectClass; fkGuidBackingName=_fk_guid_ObjectClass;
        // referencedInterface=Kistl.App.Base.ObjectClass; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Kistl.Generator.Templates.Properties.DelegatingProperty
        public Kistl.App.Base.ObjectClass ObjectClass
        {
            get { return ObjectClassImpl; }
            set { ObjectClassImpl = (Kistl.App.Base.ObjectClassMemoryImpl)value; }
        }
        // END Kistl.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_ObjectClass;

        private Guid? _fk_guid_ObjectClass = null;

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Kistl.App.Base.ObjectClassMemoryImpl ObjectClassImpl
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return null;
                Kistl.App.Base.ObjectClassMemoryImpl __value;
                if (_fk_ObjectClass.HasValue)
                    __value = (Kistl.App.Base.ObjectClassMemoryImpl)Context.Find<Kistl.App.Base.ObjectClass>(_fk_ObjectClass.Value);
                else
                    __value = null;

                if (OnObjectClass_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.ObjectClass>(__value);
                    OnObjectClass_Getter(this, e);
                    __value = (Kistl.App.Base.ObjectClassMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noops
                if (value == null && _fk_ObjectClass == null)
                    return;
                else if (value != null && value.ID == _fk_ObjectClass)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = ObjectClassImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("ObjectClass", __oldValue, __newValue);

                if (OnObjectClass_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.ObjectClass>(__oldValue, __newValue);
                    OnObjectClass_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.ObjectClassMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_ObjectClass = __newValue == null ? (int?)null : __newValue.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("ObjectClass", __oldValue, __newValue);

                if (OnObjectClass_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.ObjectClass>(__oldValue, __newValue);
                    OnObjectClass_PostSetter(this, e);
                }
            }
        }
        // END Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for ObjectClass
		public static event PropertyGetterHandler<Kistl.App.Base.ObjectReferenceParameter, Kistl.App.Base.ObjectClass> OnObjectClass_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.ObjectReferenceParameter, Kistl.App.Base.ObjectClass> OnObjectClass_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.ObjectReferenceParameter, Kistl.App.Base.ObjectClass> OnObjectClass_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetLabel_ObjectReferenceParameter")]
        public override string GetLabel()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetLabel_ObjectReferenceParameter != null)
            {
                OnGetLabel_ObjectReferenceParameter(this, e);
            }
            else
            {
                e.Result = base.GetLabel();
            }
            return e.Result;
        }
        public static event GetLabel_Handler<ObjectReferenceParameter> OnGetLabel_ObjectReferenceParameter;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the resulting Type of this Method-Parameter Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetParameterType_ObjectReferenceParameter")]
        public override System.Type GetParameterType()
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetParameterType_ObjectReferenceParameter != null)
            {
                OnGetParameterType_ObjectReferenceParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterType();
            }
            return e.Result;
        }
        public static event GetParameterType_Handler<ObjectReferenceParameter> OnGetParameterType_ObjectReferenceParameter;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// Returns the String representation of this Method-Parameter Meta Object.
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetParameterTypeString_ObjectReferenceParameter")]
        public override string GetParameterTypeString()
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetParameterTypeString_ObjectReferenceParameter != null)
            {
                OnGetParameterTypeString_ObjectReferenceParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterTypeString();
            }
            return e.Result;
        }
        public static event GetParameterTypeString_Handler<ObjectReferenceParameter> OnGetParameterTypeString_ObjectReferenceParameter;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(ObjectReferenceParameter);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (ObjectReferenceParameter)obj;
            var otherImpl = (ObjectReferenceParameterMemoryImpl)obj;
            var me = (ObjectReferenceParameter)this;

            this._fk_ObjectClass = otherImpl._fk_ObjectClass;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }

		public override void UpdateParent(string propertyName, int? id)
		{
			int? __oldValue, __newValue = id;
			
			switch(propertyName)
			{
                case "ObjectClass":
                    __oldValue = _fk_ObjectClass;
                    NotifyPropertyChanging("ObjectClass", __oldValue, __newValue);
                    _fk_ObjectClass = __newValue;
                    NotifyPropertyChanged("ObjectClass", __oldValue, __newValue);
                    break;
				default:
					base.UpdateParent(propertyName, id);
					break;
			}
		}

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_guid_ObjectClass.HasValue)
                ObjectClassImpl = (Kistl.App.Base.ObjectClassMemoryImpl)Context.FindPersistenceObject<Kistl.App.Base.ObjectClass>(_fk_guid_ObjectClass.Value);
            else
            if (_fk_ObjectClass.HasValue)
                ObjectClassImpl = (Kistl.App.Base.ObjectClassMemoryImpl)Context.Find<Kistl.App.Base.ObjectClass>(_fk_ObjectClass.Value);
            else
                ObjectClassImpl = null;
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
                    new PropertyDescriptorMemoryImpl<ObjectReferenceParameterMemoryImpl, Kistl.App.Base.ObjectClass>(
                        lazyCtx,
                        new Guid("9bd64c60-7282-47f0-8069-528a175fcc92"),
                        "ObjectClass",
                        null,
                        obj => obj.ObjectClass,
                        (obj, val) => obj.ObjectClass = val),
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
        [EventBasedMethod("OnToString_ObjectReferenceParameter")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ObjectReferenceParameter != null)
            {
                OnToString_ObjectReferenceParameter(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<ObjectReferenceParameter> OnToString_ObjectReferenceParameter;

        [EventBasedMethod("OnPreSave_ObjectReferenceParameter")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ObjectReferenceParameter != null) OnPreSave_ObjectReferenceParameter(this);
        }
        public static event ObjectEventHandler<ObjectReferenceParameter> OnPreSave_ObjectReferenceParameter;

        [EventBasedMethod("OnPostSave_ObjectReferenceParameter")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ObjectReferenceParameter != null) OnPostSave_ObjectReferenceParameter(this);
        }
        public static event ObjectEventHandler<ObjectReferenceParameter> OnPostSave_ObjectReferenceParameter;

        [EventBasedMethod("OnCreated_ObjectReferenceParameter")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_ObjectReferenceParameter != null) OnCreated_ObjectReferenceParameter(this);
        }
        public static event ObjectEventHandler<ObjectReferenceParameter> OnCreated_ObjectReferenceParameter;

        [EventBasedMethod("OnDeleting_ObjectReferenceParameter")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_ObjectReferenceParameter != null) OnDeleting_ObjectReferenceParameter(this);
        }
        public static event ObjectEventHandler<ObjectReferenceParameter> OnDeleting_ObjectReferenceParameter;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(ObjectClass != null ? ObjectClass.ID : (int?)null, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            BinarySerializer.FromStream(out this._fk_ObjectClass, binStream);
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            XmlStreamer.ToStream(ObjectClass != null ? ObjectClass.ID : (int?)null, xml, "ObjectClass", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            XmlStreamer.FromStream(ref this._fk_ObjectClass, xml, "ObjectClass", "Kistl.App.Base");
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(ObjectClass != null ? ObjectClass.ExportGuid : (Guid?)null, xml, "ObjectClass", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            XmlStreamer.FromStream(ref this._fk_guid_ObjectClass, xml, "ObjectClass", "Kistl.App.Base");
        }

        #endregion

    }
}