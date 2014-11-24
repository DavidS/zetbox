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
    /// The N-Side of the classes for the One_to_N_relations Tests
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="One_to_N_relations_NEfImpl")]
    [System.Diagnostics.DebuggerDisplay("One_to_N_relations_N")]
    public class One_to_N_relations_NEfImpl : BaseServerDataObject_EntityFramework, One_to_N_relations_N
    {
        private static readonly Guid _objectClassID = new Guid("1d828b85-c122-4aeb-8b88-06d5d27d0c06");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public One_to_N_relations_NEfImpl()
            : base(null)
        {
        }

        public One_to_N_relations_NEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// A property to test queries across the Relation
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
		public static event PropertyGetterHandler<Zetbox.App.Test.One_to_N_relations_N, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.One_to_N_relations_N, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.One_to_N_relations_N, string> OnName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.One_to_N_relations_N> OnName_IsValid;

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_OneSide_connectsTo_NSide
    A: ZeroOrOne One_to_N_relations_One as OneSide
    B: ZeroOrMore One_to_N_relations_N as NSide
    Preferred Storage: MergeIntoB
    */
        // object reference property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for OneSide
        // fkBackingName=_fk_OneSide; fkGuidBackingName=_fk_guid_OneSide;
        // referencedInterface=Zetbox.App.Test.One_to_N_relations_One; moduleNamespace=Zetbox.App.Test;
        // inverse Navigator=NSide; is list;
        // PositionStorage=none;
        // Target not exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Test.One_to_N_relations_One OneSide
        {
            get { return OneSideImpl; }
            set { OneSideImpl = (Zetbox.App.Test.One_to_N_relations_OneEfImpl)value; }
        }

        private int? _fk_OneSide;


        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_OneSide_connectsTo_NSide", "OneSide")]
        public Zetbox.App.Test.One_to_N_relations_OneEfImpl OneSideImpl
        {
            get
            {
                Zetbox.App.Test.One_to_N_relations_OneEfImpl __value;
                EntityReference<Zetbox.App.Test.One_to_N_relations_OneEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.Test.One_to_N_relations_OneEfImpl>(
                        "Model.FK_OneSide_connectsTo_NSide",
                        "OneSide");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                __value = r.Value;
                if (OnOneSide_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Test.One_to_N_relations_One>(__value);
                    OnOneSide_Getter(this, e);
                    __value = (Zetbox.App.Test.One_to_N_relations_OneEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                EntityReference<Zetbox.App.Test.One_to_N_relations_OneEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Zetbox.App.Test.One_to_N_relations_OneEfImpl>(
                        "Model.FK_OneSide_connectsTo_NSide",
                        "OneSide");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                Zetbox.App.Test.One_to_N_relations_OneEfImpl __oldValue = (Zetbox.App.Test.One_to_N_relations_OneEfImpl)r.Value;
                Zetbox.App.Test.One_to_N_relations_OneEfImpl __newValue = (Zetbox.App.Test.One_to_N_relations_OneEfImpl)value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("OneSide", __oldValue, __newValue);
                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanging("NSide", null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanging("NSide", null, null);
                }

                if (OnOneSide_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Test.One_to_N_relations_One>(__oldValue, __newValue);
                    OnOneSide_PreSetter(this, e);
                    __newValue = (Zetbox.App.Test.One_to_N_relations_OneEfImpl)e.Result;
                }

                r.Value = (Zetbox.App.Test.One_to_N_relations_OneEfImpl)__newValue;

                if (OnOneSide_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Test.One_to_N_relations_One>(__oldValue, __newValue);
                    OnOneSide_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("OneSide", __oldValue, __newValue);
                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanged("NSide", null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanged("NSide", null, null);
                }
                if(IsAttached) UpdateChangedInfo = true;
            }
        }

        public Zetbox.API.Async.ZbTask TriggerFetchOneSideAsync()
        {
            return new Zetbox.API.Async.ZbTask<Zetbox.App.Test.One_to_N_relations_One>(this.OneSide);
        }

        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for OneSide
		public static event PropertyGetterHandler<Zetbox.App.Test.One_to_N_relations_N, Zetbox.App.Test.One_to_N_relations_One> OnOneSide_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.One_to_N_relations_N, Zetbox.App.Test.One_to_N_relations_One> OnOneSide_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.One_to_N_relations_N, Zetbox.App.Test.One_to_N_relations_One> OnOneSide_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.One_to_N_relations_N> OnOneSide_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(One_to_N_relations_N);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (One_to_N_relations_N)obj;
            var otherImpl = (One_to_N_relations_NEfImpl)obj;
            var me = (One_to_N_relations_N)this;

            me.Name = other.Name;
            this._fk_OneSide = otherImpl._fk_OneSide;
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
                case "Name":
                case "OneSide":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }
        #endregion // Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

        public override Zetbox.API.Async.ZbTask TriggerFetch(string propName)
        {
            switch(propName)
            {
            case "OneSide":
                return TriggerFetchOneSideAsync();
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

            if (_fk_OneSide.HasValue)
                OneSideImpl = (Zetbox.App.Test.One_to_N_relations_OneEfImpl)Context.Find<Zetbox.App.Test.One_to_N_relations_One>(_fk_OneSide.Value);
            else
                OneSideImpl = null;
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
                    new PropertyDescriptorEfImpl<One_to_N_relations_N, string>(
                        lazyCtx,
                        new Guid("1b96dcd0-bf73-4855-84e5-7f8b1621672a"),
                        "Name",
                        null,
                        obj => obj.Name,
                        (obj, val) => obj.Name = val,
						obj => OnName_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<One_to_N_relations_N, Zetbox.App.Test.One_to_N_relations_One>(
                        lazyCtx,
                        new Guid("598a1fc0-442e-436f-8dab-c04112c1709e"),
                        "OneSide",
                        null,
                        obj => obj.OneSide,
                        (obj, val) => obj.OneSide = val,
						obj => OnOneSide_IsValid), 
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
        [EventBasedMethod("OnToString_One_to_N_relations_N")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_One_to_N_relations_N != null)
            {
                OnToString_One_to_N_relations_N(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<One_to_N_relations_N> OnToString_One_to_N_relations_N;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_One_to_N_relations_N")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_One_to_N_relations_N != null)
            {
                OnObjectIsValid_One_to_N_relations_N(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<One_to_N_relations_N> OnObjectIsValid_One_to_N_relations_N;

        [EventBasedMethod("OnNotifyPreSave_One_to_N_relations_N")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_One_to_N_relations_N != null) OnNotifyPreSave_One_to_N_relations_N(this);
        }
        public static event ObjectEventHandler<One_to_N_relations_N> OnNotifyPreSave_One_to_N_relations_N;

        [EventBasedMethod("OnNotifyPostSave_One_to_N_relations_N")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_One_to_N_relations_N != null) OnNotifyPostSave_One_to_N_relations_N(this);
        }
        public static event ObjectEventHandler<One_to_N_relations_N> OnNotifyPostSave_One_to_N_relations_N;

        [EventBasedMethod("OnNotifyCreated_One_to_N_relations_N")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Name");
            SetNotInitializedProperty("OneSide");
            base.NotifyCreated();
            if (OnNotifyCreated_One_to_N_relations_N != null) OnNotifyCreated_One_to_N_relations_N(this);
        }
        public static event ObjectEventHandler<One_to_N_relations_N> OnNotifyCreated_One_to_N_relations_N;

        [EventBasedMethod("OnNotifyDeleting_One_to_N_relations_N")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_One_to_N_relations_N != null) OnNotifyDeleting_One_to_N_relations_N(this);
            OneSide = null;
        }
        public static event ObjectEventHandler<One_to_N_relations_N> OnNotifyDeleting_One_to_N_relations_N;

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
            binStream.Write(this._Name);
            {
                var r = this.RelationshipManager.GetRelatedReference<Zetbox.App.Test.One_to_N_relations_OneEfImpl>("Model.FK_OneSide_connectsTo_NSide", "OneSide");
                var key = r.EntityKey;
                binStream.Write(r.Value != null ? r.Value.ID : (key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null));
            }
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._Name = binStream.ReadString();
            binStream.Read(out this._fk_OneSide);
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