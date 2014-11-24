// <autogenerated/>

namespace Zetbox.App.Base
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    using Zetbox.API;
    using Zetbox.DalProvider.Base.RelationWrappers;

    using Zetbox.DalProvider.Base;
    using Zetbox.DalProvider.Memory;

    /// <summary>
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("StringRangeConstraint")]
    public class StringRangeConstraintMemoryImpl : Zetbox.App.Base.ConstraintMemoryImpl, StringRangeConstraint
    {
        private static readonly Guid _objectClassID = new Guid("7bb90dc3-2b8c-4cff-ba8e-435ff386a4cf");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public StringRangeConstraintMemoryImpl()
            : base(null)
        {
        }

        public StringRangeConstraintMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// The maximal length of this StringProperty or null for unlimited length
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public int? MaxLength
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _MaxLength;
                if (OnMaxLength_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int?>(__result);
                    OnMaxLength_Getter(this, __e);
                    __result = _MaxLength = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_MaxLength != value)
                {
                    var __oldValue = _MaxLength;
                    var __newValue = value;
                    if (OnMaxLength_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int?>(__oldValue, __newValue);
                        OnMaxLength_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("MaxLength", __oldValue, __newValue);
                    _MaxLength = __newValue;
                    NotifyPropertyChanged("MaxLength", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnMaxLength_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int?>(__oldValue, __newValue);
                        OnMaxLength_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("MaxLength");
                }
            }
        }
        private int? _MaxLength;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.StringRangeConstraint, int?> OnMaxLength_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.StringRangeConstraint, int?> OnMaxLength_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.StringRangeConstraint, int?> OnMaxLength_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.StringRangeConstraint> OnMaxLength_IsValid;

        /// <summary>
        /// The minimal length of this StringProperty
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public int MinLength
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _MinLength;
                if (OnMinLength_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnMinLength_Getter(this, __e);
                    __result = _MinLength = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_MinLength != value)
                {
                    var __oldValue = _MinLength;
                    var __newValue = value;
                    if (OnMinLength_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnMinLength_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("MinLength", __oldValue, __newValue);
                    _MinLength = __newValue;
                    NotifyPropertyChanged("MinLength", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnMinLength_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnMinLength_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("MinLength");
                }
            }
        }
        private int _MinLength;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Base.StringRangeConstraint, int> OnMinLength_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Base.StringRangeConstraint, int> OnMinLength_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Base.StringRangeConstraint, int> OnMinLength_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Base.StringRangeConstraint> OnMinLength_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetErrorText_StringRangeConstraint")]
        public override string GetErrorText(System.Object constrainedObject, System.Object constrainedValue)
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetErrorText_StringRangeConstraint != null)
            {
                OnGetErrorText_StringRangeConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.GetErrorText(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
        public static event GetErrorText_Handler<StringRangeConstraint> OnGetErrorText_StringRangeConstraint;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<StringRangeConstraint> OnGetErrorText_StringRangeConstraint_CanExec;

        [EventBasedMethod("OnGetErrorText_StringRangeConstraint_CanExec")]
        public override bool GetErrorTextCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGetErrorText_StringRangeConstraint_CanExec != null)
				{
					OnGetErrorText_StringRangeConstraint_CanExec(this, e);
				}
				else
				{
					e.Result = base.GetErrorTextCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<StringRangeConstraint> OnGetErrorText_StringRangeConstraint_CanExecReason;

        [EventBasedMethod("OnGetErrorText_StringRangeConstraint_CanExecReason")]
        public override string GetErrorTextCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGetErrorText_StringRangeConstraint_CanExecReason != null)
				{
					OnGetErrorText_StringRangeConstraint_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.GetErrorTextCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnIsValid_StringRangeConstraint")]
        public override bool IsValid(System.Object constrainedObject, System.Object constrainedValue)
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnIsValid_StringRangeConstraint != null)
            {
                OnIsValid_StringRangeConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.IsValid(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
        public static event IsValid_Handler<StringRangeConstraint> OnIsValid_StringRangeConstraint;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<StringRangeConstraint> OnIsValid_StringRangeConstraint_CanExec;

        [EventBasedMethod("OnIsValid_StringRangeConstraint_CanExec")]
        public override bool IsValidCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnIsValid_StringRangeConstraint_CanExec != null)
				{
					OnIsValid_StringRangeConstraint_CanExec(this, e);
				}
				else
				{
					e.Result = base.IsValidCanExec;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<StringRangeConstraint> OnIsValid_StringRangeConstraint_CanExecReason;

        [EventBasedMethod("OnIsValid_StringRangeConstraint_CanExecReason")]
        public override string IsValidCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnIsValid_StringRangeConstraint_CanExecReason != null)
				{
					OnIsValid_StringRangeConstraint_CanExecReason(this, e);
				}
				else
				{
					e.Result = base.IsValidCanExecReason;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(StringRangeConstraint);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (StringRangeConstraint)obj;
            var otherImpl = (StringRangeConstraintMemoryImpl)obj;
            var me = (StringRangeConstraint)this;

            me.MaxLength = other.MaxLength;
            me.MinLength = other.MinLength;
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        #region Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "MaxLength":
                case "MinLength":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }
        #endregion // Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        public override Zetbox.API.Async.ZbTask TriggerFetch(string propName)
        {
            switch(propName)
            {
            default:
                return base.TriggerFetch(propName);
            }
        }

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references
            // fix cached lists references
        }
        #region Zetbox.Generator.Templates.ObjectClasses.CustomTypeDescriptor
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
                    new PropertyDescriptorMemoryImpl<StringRangeConstraint, int?>(
                        lazyCtx,
                        new Guid("17aa679d-72d0-480e-9bd9-b37f4eba1d68"),
                        "MaxLength",
                        null,
                        obj => obj.MaxLength,
                        (obj, val) => obj.MaxLength = val,
						obj => OnMaxLength_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<StringRangeConstraint, int>(
                        lazyCtx,
                        new Guid("8d3e24f7-c8c8-4bb3-931e-d0452e7ee5b6"),
                        "MinLength",
                        null,
                        obj => obj.MinLength,
                        (obj, val) => obj.MinLength = val,
						obj => OnMinLength_IsValid), 
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
        #endregion // Zetbox.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_StringRangeConstraint")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_StringRangeConstraint != null)
            {
                OnToString_StringRangeConstraint(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<StringRangeConstraint> OnToString_StringRangeConstraint;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_StringRangeConstraint")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_StringRangeConstraint != null)
            {
                OnObjectIsValid_StringRangeConstraint(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<StringRangeConstraint> OnObjectIsValid_StringRangeConstraint;

        [EventBasedMethod("OnNotifyPreSave_StringRangeConstraint")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_StringRangeConstraint != null) OnNotifyPreSave_StringRangeConstraint(this);
        }
        public static event ObjectEventHandler<StringRangeConstraint> OnNotifyPreSave_StringRangeConstraint;

        [EventBasedMethod("OnNotifyPostSave_StringRangeConstraint")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_StringRangeConstraint != null) OnNotifyPostSave_StringRangeConstraint(this);
        }
        public static event ObjectEventHandler<StringRangeConstraint> OnNotifyPostSave_StringRangeConstraint;

        [EventBasedMethod("OnNotifyCreated_StringRangeConstraint")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("MaxLength");
            SetNotInitializedProperty("MinLength");
            base.NotifyCreated();
            if (OnNotifyCreated_StringRangeConstraint != null) OnNotifyCreated_StringRangeConstraint(this);
        }
        public static event ObjectEventHandler<StringRangeConstraint> OnNotifyCreated_StringRangeConstraint;

        [EventBasedMethod("OnNotifyDeleting_StringRangeConstraint")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_StringRangeConstraint != null) OnNotifyDeleting_StringRangeConstraint(this);
        }
        public static event ObjectEventHandler<StringRangeConstraint> OnNotifyDeleting_StringRangeConstraint;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._MaxLength);
            binStream.Write(this._MinLength);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._MaxLength = binStream.ReadNullableInt32();
            this._MinLength = binStream.ReadInt32();
            } // if (CurrentAccessRights != Zetbox.API.AccessRights.None)
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this._MaxLength, xml, "MaxLength", "Zetbox.App.Base");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Base")) XmlStreamer.ToStream(this._MinLength, xml, "MinLength", "Zetbox.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Base|MaxLength":
                this._MaxLength = XmlStreamer.ReadNullableInt32(xml);
                break;
            case "Zetbox.App.Base|MinLength":
                this._MinLength = XmlStreamer.ReadInt32(xml);
                break;
            }
        }

        #endregion

    }
}