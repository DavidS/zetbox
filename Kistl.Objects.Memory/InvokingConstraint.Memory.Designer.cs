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
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("InvokingConstraint")]
    public class InvokingConstraintMemoryImpl : Kistl.App.Base.ConstraintMemoryImpl, InvokingConstraint
    {
        [Obsolete]
        public InvokingConstraintMemoryImpl()
            : base(null)
        {
        }

        public InvokingConstraintMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for GetErrorTextInvocation
        // fkBackingName=_fk_GetErrorTextInvocation; fkGuidBackingName=_fk_guid_GetErrorTextInvocation;
        // referencedInterface=Kistl.App.Base.ConstraintInvocation; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Kistl.Generator.Templates.Properties.DelegatingProperty
        public Kistl.App.Base.ConstraintInvocation GetErrorTextInvocation
        {
            get { return GetErrorTextInvocationImpl; }
            set { GetErrorTextInvocationImpl = (Kistl.App.Base.ConstraintInvocationMemoryImpl)value; }
        }
        // END Kistl.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_GetErrorTextInvocation;

        private Guid? _fk_guid_GetErrorTextInvocation = null;

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Kistl.App.Base.ConstraintInvocationMemoryImpl GetErrorTextInvocationImpl
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return null;
                Kistl.App.Base.ConstraintInvocationMemoryImpl __value;
                if (_fk_GetErrorTextInvocation.HasValue)
                    __value = (Kistl.App.Base.ConstraintInvocationMemoryImpl)Context.Find<Kistl.App.Base.ConstraintInvocation>(_fk_GetErrorTextInvocation.Value);
                else
                    __value = null;

                if (OnGetErrorTextInvocation_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.ConstraintInvocation>(__value);
                    OnGetErrorTextInvocation_Getter(this, e);
                    __value = (Kistl.App.Base.ConstraintInvocationMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noops
                if (value == null && _fk_GetErrorTextInvocation == null)
                    return;
                else if (value != null && value.ID == _fk_GetErrorTextInvocation)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = GetErrorTextInvocationImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("GetErrorTextInvocation", __oldValue, __newValue);

                if (OnGetErrorTextInvocation_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.ConstraintInvocation>(__oldValue, __newValue);
                    OnGetErrorTextInvocation_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.ConstraintInvocationMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_GetErrorTextInvocation = __newValue == null ? (int?)null : __newValue.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("GetErrorTextInvocation", __oldValue, __newValue);

                if (OnGetErrorTextInvocation_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.ConstraintInvocation>(__oldValue, __newValue);
                    OnGetErrorTextInvocation_PostSetter(this, e);
                }
            }
        }
        // END Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for GetErrorTextInvocation
		public static event PropertyGetterHandler<Kistl.App.Base.InvokingConstraint, Kistl.App.Base.ConstraintInvocation> OnGetErrorTextInvocation_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.InvokingConstraint, Kistl.App.Base.ConstraintInvocation> OnGetErrorTextInvocation_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.InvokingConstraint, Kistl.App.Base.ConstraintInvocation> OnGetErrorTextInvocation_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for IsValidInvocation
        // fkBackingName=_fk_IsValidInvocation; fkGuidBackingName=_fk_guid_IsValidInvocation;
        // referencedInterface=Kistl.App.Base.ConstraintInvocation; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=none; is reference;
        // PositionStorage=none;
        // Target exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Kistl.Generator.Templates.Properties.DelegatingProperty
        public Kistl.App.Base.ConstraintInvocation IsValidInvocation
        {
            get { return IsValidInvocationImpl; }
            set { IsValidInvocationImpl = (Kistl.App.Base.ConstraintInvocationMemoryImpl)value; }
        }
        // END Kistl.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_IsValidInvocation;

        private Guid? _fk_guid_IsValidInvocation = null;

        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Kistl.App.Base.ConstraintInvocationMemoryImpl IsValidInvocationImpl
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return null;
                Kistl.App.Base.ConstraintInvocationMemoryImpl __value;
                if (_fk_IsValidInvocation.HasValue)
                    __value = (Kistl.App.Base.ConstraintInvocationMemoryImpl)Context.Find<Kistl.App.Base.ConstraintInvocation>(_fk_IsValidInvocation.Value);
                else
                    __value = null;

                if (OnIsValidInvocation_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.ConstraintInvocation>(__value);
                    OnIsValidInvocation_Getter(this, e);
                    __value = (Kistl.App.Base.ConstraintInvocationMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noops
                if (value == null && _fk_IsValidInvocation == null)
                    return;
                else if (value != null && value.ID == _fk_IsValidInvocation)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = IsValidInvocationImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("IsValidInvocation", __oldValue, __newValue);

                if (OnIsValidInvocation_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.ConstraintInvocation>(__oldValue, __newValue);
                    OnIsValidInvocation_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.ConstraintInvocationMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_IsValidInvocation = __newValue == null ? (int?)null : __newValue.ID;

                // everything is done. fire the Changed event
                NotifyPropertyChanged("IsValidInvocation", __oldValue, __newValue);

                if (OnIsValidInvocation_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.ConstraintInvocation>(__oldValue, __newValue);
                    OnIsValidInvocation_PostSetter(this, e);
                }
            }
        }
        // END Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for IsValidInvocation
		public static event PropertyGetterHandler<Kistl.App.Base.InvokingConstraint, Kistl.App.Base.ConstraintInvocation> OnIsValidInvocation_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.InvokingConstraint, Kistl.App.Base.ConstraintInvocation> OnIsValidInvocation_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.InvokingConstraint, Kistl.App.Base.ConstraintInvocation> OnIsValidInvocation_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetErrorText_InvokingConstraint")]
        public override string GetErrorText(System.Object constrainedObject, System.Object constrainedValue)
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetErrorText_InvokingConstraint != null)
            {
                OnGetErrorText_InvokingConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.GetErrorText(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
        public static event GetErrorText_Handler<InvokingConstraint> OnGetErrorText_InvokingConstraint;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnIsValid_InvokingConstraint")]
        public override bool IsValid(System.Object constrainedObject, System.Object constrainedValue)
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnIsValid_InvokingConstraint != null)
            {
                OnIsValid_InvokingConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.IsValid(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
        public static event IsValid_Handler<InvokingConstraint> OnIsValid_InvokingConstraint;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(InvokingConstraint);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (InvokingConstraint)obj;
            var otherImpl = (InvokingConstraintMemoryImpl)obj;
            var me = (InvokingConstraint)this;

            this._fk_GetErrorTextInvocation = otherImpl._fk_GetErrorTextInvocation;
            this._fk_IsValidInvocation = otherImpl._fk_IsValidInvocation;
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
                case "GetErrorTextInvocation":
                    __oldValue = _fk_GetErrorTextInvocation;
                    NotifyPropertyChanging("GetErrorTextInvocation", __oldValue, __newValue);
                    _fk_GetErrorTextInvocation = __newValue;
                    NotifyPropertyChanged("GetErrorTextInvocation", __oldValue, __newValue);
                    break;
                case "IsValidInvocation":
                    __oldValue = _fk_IsValidInvocation;
                    NotifyPropertyChanging("IsValidInvocation", __oldValue, __newValue);
                    _fk_IsValidInvocation = __newValue;
                    NotifyPropertyChanged("IsValidInvocation", __oldValue, __newValue);
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

            if (_fk_guid_GetErrorTextInvocation.HasValue)
                GetErrorTextInvocationImpl = (Kistl.App.Base.ConstraintInvocationMemoryImpl)Context.FindPersistenceObject<Kistl.App.Base.ConstraintInvocation>(_fk_guid_GetErrorTextInvocation.Value);
            else
            if (_fk_GetErrorTextInvocation.HasValue)
                GetErrorTextInvocationImpl = (Kistl.App.Base.ConstraintInvocationMemoryImpl)Context.Find<Kistl.App.Base.ConstraintInvocation>(_fk_GetErrorTextInvocation.Value);
            else
                GetErrorTextInvocationImpl = null;

            if (_fk_guid_IsValidInvocation.HasValue)
                IsValidInvocationImpl = (Kistl.App.Base.ConstraintInvocationMemoryImpl)Context.FindPersistenceObject<Kistl.App.Base.ConstraintInvocation>(_fk_guid_IsValidInvocation.Value);
            else
            if (_fk_IsValidInvocation.HasValue)
                IsValidInvocationImpl = (Kistl.App.Base.ConstraintInvocationMemoryImpl)Context.Find<Kistl.App.Base.ConstraintInvocation>(_fk_IsValidInvocation.Value);
            else
                IsValidInvocationImpl = null;
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
                    new PropertyDescriptorMemoryImpl<InvokingConstraintMemoryImpl, Kistl.App.Base.ConstraintInvocation>(
                        lazyCtx,
                        new Guid("3b5d70f7-b6fd-4e39-b912-5a644a5de716"),
                        "GetErrorTextInvocation",
                        null,
                        obj => obj.GetErrorTextInvocation,
                        (obj, val) => obj.GetErrorTextInvocation = val),
                    // else
                    new PropertyDescriptorMemoryImpl<InvokingConstraintMemoryImpl, Kistl.App.Base.ConstraintInvocation>(
                        lazyCtx,
                        new Guid("3c98da56-1c21-4849-87b1-81bf72d17e70"),
                        "IsValidInvocation",
                        null,
                        obj => obj.IsValidInvocation,
                        (obj, val) => obj.IsValidInvocation = val),
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
        [EventBasedMethod("OnToString_InvokingConstraint")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_InvokingConstraint != null)
            {
                OnToString_InvokingConstraint(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<InvokingConstraint> OnToString_InvokingConstraint;

        [EventBasedMethod("OnPreSave_InvokingConstraint")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_InvokingConstraint != null) OnPreSave_InvokingConstraint(this);
        }
        public static event ObjectEventHandler<InvokingConstraint> OnPreSave_InvokingConstraint;

        [EventBasedMethod("OnPostSave_InvokingConstraint")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_InvokingConstraint != null) OnPostSave_InvokingConstraint(this);
        }
        public static event ObjectEventHandler<InvokingConstraint> OnPostSave_InvokingConstraint;

        [EventBasedMethod("OnCreated_InvokingConstraint")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_InvokingConstraint != null) OnCreated_InvokingConstraint(this);
        }
        public static event ObjectEventHandler<InvokingConstraint> OnCreated_InvokingConstraint;

        [EventBasedMethod("OnDeleting_InvokingConstraint")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_InvokingConstraint != null) OnDeleting_InvokingConstraint(this);
        }
        public static event ObjectEventHandler<InvokingConstraint> OnDeleting_InvokingConstraint;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(GetErrorTextInvocation != null ? GetErrorTextInvocation.ID : (int?)null, binStream);
            BinarySerializer.ToStream(IsValidInvocation != null ? IsValidInvocation.ID : (int?)null, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            BinarySerializer.FromStream(out this._fk_GetErrorTextInvocation, binStream);
            BinarySerializer.FromStream(out this._fk_IsValidInvocation, binStream);
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            XmlStreamer.ToStream(GetErrorTextInvocation != null ? GetErrorTextInvocation.ID : (int?)null, xml, "GetErrorTextInvocation", "Kistl.App.Base");
            XmlStreamer.ToStream(IsValidInvocation != null ? IsValidInvocation.ID : (int?)null, xml, "IsValidInvocation", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            XmlStreamer.FromStream(ref this._fk_GetErrorTextInvocation, xml, "GetErrorTextInvocation", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_IsValidInvocation, xml, "IsValidInvocation", "Kistl.App.Base");
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(GetErrorTextInvocation != null ? GetErrorTextInvocation.ExportGuid : (Guid?)null, xml, "GetErrorTextInvocation", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(IsValidInvocation != null ? IsValidInvocation.ExportGuid : (Guid?)null, xml, "IsValidInvocation", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            XmlStreamer.FromStream(ref this._fk_guid_GetErrorTextInvocation, xml, "GetErrorTextInvocation", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_guid_IsValidInvocation, xml, "IsValidInvocation", "Kistl.App.Base");
        }

        #endregion

    }
}