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
    /// A test class for persistently ordered 1:N relations
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="OrderedOneEndEfImpl")]
    [System.Diagnostics.DebuggerDisplay("OrderedOneEnd")]
    public class OrderedOneEndEfImpl : BaseServerDataObject_EntityFramework, OrderedOneEnd
    {
        private static readonly Guid _objectClassID = new Guid("c170405f-c29d-4d87-a4f7-a622185a94d9");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public OrderedOneEndEfImpl()
            : base(null)
        {
        }

        public OrderedOneEndEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_OneEnd_hasMany_NEnds
    A: ZeroOrOne OrderedOneEnd as OneEnd
    B: ZeroOrMore OrderedNEnd as NEnds
    Preferred Storage: MergeIntoB
    */
        // object list property
        // object list property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public IList<Zetbox.App.Test.OrderedNEnd> NEnds
        {
            get
            {
                if (_NEnds == null)
                {
                    _NEnds = new EntityListWrapper<Zetbox.App.Test.OrderedNEnd, Zetbox.App.Test.OrderedNEndEfImpl>(
                            this.Context, NEndsImpl,
                            () => this.NotifyPropertyChanging("NEnds", null, null),
                            null, // see GetNEndsImplCollection()
                            (item) => item.NotifyPropertyChanging("OneEnd", null, null),
                            (item) => item.NotifyPropertyChanged("OneEnd", null, null), "OneEnd", "NEnds_pos");
                }
                return _NEnds;
            }
        }
    
        [EdmRelationshipNavigationProperty("Model", "FK_OneEnd_hasMany_NEnds", "NEnds")]
        public EntityCollection<Zetbox.App.Test.OrderedNEndEfImpl> NEndsImpl
        {
            get
            {
                return GetNEndsImplCollection();
            }
        }
        private EntityListWrapper<Zetbox.App.Test.OrderedNEnd, Zetbox.App.Test.OrderedNEndEfImpl> _NEnds;

        private EntityCollection<Zetbox.App.Test.OrderedNEndEfImpl> _NEndsImplEntityCollection;
        internal EntityCollection<Zetbox.App.Test.OrderedNEndEfImpl> GetNEndsImplCollection()
        {
            if (_NEndsImplEntityCollection == null)
            {
                _NEndsImplEntityCollection = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Zetbox.App.Test.OrderedNEndEfImpl>(
                        "Model.FK_OneEnd_hasMany_NEnds",
                        "NEnds");
                // the EntityCollection has to be loaded before attaching the AssociationChanged event
                // because the event is triggered while relation entries are loaded from the database
                // although that does not require notification of the business logic.
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !_NEndsImplEntityCollection.IsLoaded)
                {
                    _NEndsImplEntityCollection.Load();
                }
                _NEndsImplEntityCollection.AssociationChanged += (s, e) => { this.NotifyPropertyChanged("NEnds", null, null); if (OnNEnds_PostSetter != null && IsAttached) OnNEnds_PostSetter(this); };
            }
            return _NEndsImplEntityCollection;
        }

        public Zetbox.API.Async.ZbTask TriggerFetchNEndsAsync()
        {
            return new Zetbox.API.Async.ZbTask<IList<Zetbox.App.Test.OrderedNEnd>>(this.NEnds);
        }

        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectListProperty
public static event PropertyListChangedHandler<Zetbox.App.Test.OrderedOneEnd> OnNEnds_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.OrderedOneEnd> OnNEnds_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public int? SomeInt
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _SomeInt;
                if (OnSomeInt_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int?>(__result);
                    OnSomeInt_Getter(this, __e);
                    __result = _SomeInt = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_SomeInt != value)
                {
                    var __oldValue = _SomeInt;
                    var __newValue = value;
                    if (OnSomeInt_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int?>(__oldValue, __newValue);
                        OnSomeInt_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("SomeInt", __oldValue, __newValue);
                    _SomeInt = __newValue;
                    NotifyPropertyChanged("SomeInt", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnSomeInt_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int?>(__oldValue, __newValue);
                        OnSomeInt_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("SomeInt");
                }
            }
        }
        private int? _SomeInt_store;
        private int? _SomeInt {
            get { return _SomeInt_store; }
            set {
                ReportEfPropertyChanging("SomeInt");
                _SomeInt_store = value;
                ReportEfPropertyChanged("SomeInt");
            }
        }
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.OrderedOneEnd, int?> OnSomeInt_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.OrderedOneEnd, int?> OnSomeInt_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.OrderedOneEnd, int?> OnSomeInt_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.OrderedOneEnd> OnSomeInt_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(OrderedOneEnd);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (OrderedOneEnd)obj;
            var otherImpl = (OrderedOneEndEfImpl)obj;
            var me = (OrderedOneEnd)this;

            me.SomeInt = other.SomeInt;
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
                case "SomeInt":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }

        protected override bool ShouldSetModified(string property)
        {
            switch (property)
            {
                case "NEnds":
                    return false;
                default:
                    return base.ShouldSetModified(property);
            }
        }
        #endregion // Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

        public override Zetbox.API.Async.ZbTask TriggerFetch(string propName)
        {
            switch(propName)
            {
            case "NEnds":
                return TriggerFetchNEndsAsync();
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
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorEfImpl<OrderedOneEnd, IList<Zetbox.App.Test.OrderedNEnd>>(
                        lazyCtx,
                        new Guid("7b7a227b-462a-4923-bda6-15264f0af841"),
                        "NEnds",
                        null,
                        obj => obj.NEnds,
                        null, // lists are read-only properties
                        obj => OnNEnds_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<OrderedOneEnd, int?>(
                        lazyCtx,
                        new Guid("1062a9d3-b936-42b8-99ba-2353087cbce1"),
                        "SomeInt",
                        null,
                        obj => obj.SomeInt,
                        (obj, val) => obj.SomeInt = val,
						obj => OnSomeInt_IsValid), 
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
        [EventBasedMethod("OnToString_OrderedOneEnd")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_OrderedOneEnd != null)
            {
                OnToString_OrderedOneEnd(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<OrderedOneEnd> OnToString_OrderedOneEnd;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_OrderedOneEnd")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_OrderedOneEnd != null)
            {
                OnObjectIsValid_OrderedOneEnd(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<OrderedOneEnd> OnObjectIsValid_OrderedOneEnd;

        [EventBasedMethod("OnNotifyPreSave_OrderedOneEnd")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_OrderedOneEnd != null) OnNotifyPreSave_OrderedOneEnd(this);
        }
        public static event ObjectEventHandler<OrderedOneEnd> OnNotifyPreSave_OrderedOneEnd;

        [EventBasedMethod("OnNotifyPostSave_OrderedOneEnd")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_OrderedOneEnd != null) OnNotifyPostSave_OrderedOneEnd(this);
        }
        public static event ObjectEventHandler<OrderedOneEnd> OnNotifyPostSave_OrderedOneEnd;

        [EventBasedMethod("OnNotifyCreated_OrderedOneEnd")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("SomeInt");
            base.NotifyCreated();
            if (OnNotifyCreated_OrderedOneEnd != null) OnNotifyCreated_OrderedOneEnd(this);
        }
        public static event ObjectEventHandler<OrderedOneEnd> OnNotifyCreated_OrderedOneEnd;

        [EventBasedMethod("OnNotifyDeleting_OrderedOneEnd")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_OrderedOneEnd != null) OnNotifyDeleting_OrderedOneEnd(this);
            NEnds.Clear();
        }
        public static event ObjectEventHandler<OrderedOneEnd> OnNotifyDeleting_OrderedOneEnd;

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
            binStream.Write(this._SomeInt);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._SomeInt = binStream.ReadNullableInt32();
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