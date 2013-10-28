// <autogenerated/>

namespace Zetbox.App.Test
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

    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using Zetbox.API.Server;
    using Zetbox.DalProvider.Ef;

    /// <summary>
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="DeactivatableTestObjectEfImpl")]
    [System.Diagnostics.DebuggerDisplay("DeactivatableTestObject")]
    public class DeactivatableTestObjectEfImpl : BaseServerDataObject_EntityFramework, DeactivatableTestObject
    {
        private static readonly Guid _objectClassID = new Guid("12e49195-6ff4-49cd-b3a9-37f7bc350a5e");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public DeactivatableTestObjectEfImpl()
            : base(null)
        {
        }

        public DeactivatableTestObjectEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// If true, the item will be hidden in any search
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public bool IsDeactivated
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _IsDeactivated;
                if (!_isIsDeactivatedSet && ObjectState == DataObjectState.New) {
                    var __p = FrozenContext.FindPersistenceObject<Zetbox.App.Base.Property>(new Guid("1d4f8d1c-e09e-47fa-a05f-2c1eb224ff16"));
                    if (__p != null) {
                        _isIsDeactivatedSet = true;
                        // http://connect.microsoft.com/VisualStudio/feedback/details/593117/cannot-directly-cast-boxed-int-to-nullable-enum
                        object __tmp_value = __p.DefaultValue.GetDefaultValue();
                        __result = this._IsDeactivated = (bool)__tmp_value;
                    } else {
                        Zetbox.API.Utils.Logging.Log.Warn("Unable to get default value for property 'DeactivatableTestObject.IsDeactivated'");
                    }
                }
                if (OnIsDeactivated_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<bool>(__result);
                    OnIsDeactivated_Getter(this, __e);
                    __result = _IsDeactivated = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                _isIsDeactivatedSet = true;
                if (_IsDeactivated != value)
                {
                    var __oldValue = _IsDeactivated;
                    var __newValue = value;
                    if (OnIsDeactivated_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsDeactivated_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IsDeactivated", __oldValue, __newValue);
                    _IsDeactivated = __newValue;
                    NotifyPropertyChanged("IsDeactivated", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnIsDeactivated_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<bool>(__oldValue, __newValue);
                        OnIsDeactivated_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("IsDeactivated");
                }
            }
        }
        private bool _IsDeactivated_store;
        private bool _IsDeactivated {
            get { return _IsDeactivated_store; }
            set {
                ReportEfPropertyChanging("IsDeactivated");
                _IsDeactivated_store = value;
                ReportEfPropertyChanged("IsDeactivated");
            }
        }
        private bool _isIsDeactivatedSet = false;
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.DeactivatableTestObject, bool> OnIsDeactivated_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.DeactivatableTestObject, bool> OnIsDeactivated_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.DeactivatableTestObject, bool> OnIsDeactivated_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.DeactivatableTestObject> OnIsDeactivated_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public string Name
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Name;
                if (OnName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnName_Getter(this, __e);
                    __result = _Name = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Name != value)
                {
                    var __oldValue = _Name;
                    var __newValue = value;
                    if (OnName_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Name", __oldValue, __newValue);
                    _Name = __newValue;
                    NotifyPropertyChanged("Name", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnName_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnName_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("Name");
                }
            }
        }
        private string _Name_store;
        private string _Name {
            get { return _Name_store; }
            set {
                ReportEfPropertyChanging("Name");
                _Name_store = value;
                ReportEfPropertyChanged("Name");
            }
        }
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.DeactivatableTestObject, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.DeactivatableTestObject, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.DeactivatableTestObject, string> OnName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.DeactivatableTestObject> OnName_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(DeactivatableTestObject);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (DeactivatableTestObject)obj;
            var otherImpl = (DeactivatableTestObjectEfImpl)obj;
            var me = (DeactivatableTestObject)this;

            me.IsDeactivated = other.IsDeactivated;
            me.Name = other.Name;
        }
        public override void SetNew()
        {
            base.SetNew();
        }
        #region Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

        protected override void OnPropertyChanged(string property, object oldValue, object newValue)
        {
            base.OnPropertyChanged(property, oldValue, newValue);

            // Do not audit calculated properties
            switch (property)
            {
                case "IsDeactivated":
                case "Name":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }
        #endregion // Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

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
                    new PropertyDescriptorEfImpl<DeactivatableTestObject, bool>(
                        lazyCtx,
                        new Guid("1d4f8d1c-e09e-47fa-a05f-2c1eb224ff16"),
                        "IsDeactivated",
                        null,
                        obj => obj.IsDeactivated,
                        (obj, val) => obj.IsDeactivated = val,
						obj => OnIsDeactivated_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<DeactivatableTestObject, string>(
                        lazyCtx,
                        new Guid("c1a18acc-68e5-4df8-a7ed-58dc3eeb2e80"),
                        "Name",
                        null,
                        obj => obj.Name,
                        (obj, val) => obj.Name = val,
						obj => OnName_IsValid), 
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
        [EventBasedMethod("OnToString_DeactivatableTestObject")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DeactivatableTestObject != null)
            {
                OnToString_DeactivatableTestObject(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<DeactivatableTestObject> OnToString_DeactivatableTestObject;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_DeactivatableTestObject")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_DeactivatableTestObject != null)
            {
                OnObjectIsValid_DeactivatableTestObject(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<DeactivatableTestObject> OnObjectIsValid_DeactivatableTestObject;

        [EventBasedMethod("OnNotifyPreSave_DeactivatableTestObject")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_DeactivatableTestObject != null) OnNotifyPreSave_DeactivatableTestObject(this);
        }
        public static event ObjectEventHandler<DeactivatableTestObject> OnNotifyPreSave_DeactivatableTestObject;

        [EventBasedMethod("OnNotifyPostSave_DeactivatableTestObject")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_DeactivatableTestObject != null) OnNotifyPostSave_DeactivatableTestObject(this);
        }
        public static event ObjectEventHandler<DeactivatableTestObject> OnNotifyPostSave_DeactivatableTestObject;

        [EventBasedMethod("OnNotifyCreated_DeactivatableTestObject")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Name");
            base.NotifyCreated();
            if (OnNotifyCreated_DeactivatableTestObject != null) OnNotifyCreated_DeactivatableTestObject(this);
        }
        public static event ObjectEventHandler<DeactivatableTestObject> OnNotifyCreated_DeactivatableTestObject;

        [EventBasedMethod("OnNotifyDeleting_DeactivatableTestObject")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_DeactivatableTestObject != null) OnNotifyDeleting_DeactivatableTestObject(this);
        }
        public static event ObjectEventHandler<DeactivatableTestObject> OnNotifyDeleting_DeactivatableTestObject;

        #endregion // Zetbox.Generator.Templates.ObjectClasses.DefaultMethods
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.IdProperty
        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
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
                    if(IsAttached) UpdateChangedInfo = true;

                }
                else
                {
                    SetInitializedProperty("ID");
                }
            }
        }
        private int _ID;
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.IdProperty

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._isIsDeactivatedSet);
            if (this._isIsDeactivatedSet) {
                binStream.Write(this._IsDeactivated);
            }
            binStream.Write(this._Name);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._isIsDeactivatedSet = binStream.ReadBoolean();
            if (this._isIsDeactivatedSet) {
                this._IsDeactivated = binStream.ReadBoolean();
            }
            this._Name = binStream.ReadString();
            } // if (CurrentAccessRights != Zetbox.API.AccessRights.None)
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        #endregion

    }
}