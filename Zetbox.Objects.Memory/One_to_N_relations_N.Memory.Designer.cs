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

    using Zetbox.DalProvider.Base;
    using Zetbox.DalProvider.Memory;

    /// <summary>
    /// The N-Side of the classes for the One_to_N_relations Tests
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("One_to_N_relations_N")]
    public class One_to_N_relations_NMemoryImpl : Zetbox.DalProvider.Memory.DataObjectMemoryImpl, One_to_N_relations_N
    {
        private static readonly Guid _objectClassID = new Guid("1d828b85-c122-4aeb-8b88-06d5d27d0c06");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public One_to_N_relations_NMemoryImpl()
            : base(null)
        {
        }

        public One_to_N_relations_NMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// A property to test queries across the Relation
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
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
        private string _Name;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.One_to_N_relations_N, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.One_to_N_relations_N, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.One_to_N_relations_N, string> OnName_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.One_to_N_relations_N> OnName_IsValid;

        /// <summary>
        /// 
        /// </summary>
	        // BEGIN Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for OneSide
        // fkBackingName=_fk_OneSide; fkGuidBackingName=_fk_guid_OneSide;
        // referencedInterface=Zetbox.App.Test.One_to_N_relations_One; moduleNamespace=Zetbox.App.Test;
        // inverse Navigator=NSide; is list;
        // PositionStorage=none;
        // Target not exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Zetbox.Generator.Templates.Properties.DelegatingProperty
        public Zetbox.App.Test.One_to_N_relations_One OneSide
        {
            get { return OneSideImpl; }
            set { OneSideImpl = (Zetbox.App.Test.One_to_N_relations_OneMemoryImpl)value; }
        }
        // END Zetbox.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_OneSide;


        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Zetbox.App.Test.One_to_N_relations_OneMemoryImpl OneSideImpl
        {
            get
            {
                Zetbox.App.Test.One_to_N_relations_OneMemoryImpl __value;
                if (_fk_OneSide.HasValue)
                    __value = (Zetbox.App.Test.One_to_N_relations_OneMemoryImpl)Context.Find<Zetbox.App.Test.One_to_N_relations_One>(_fk_OneSide.Value);
                else
                    __value = null;

                if (OnOneSide_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Test.One_to_N_relations_One>(__value);
                    OnOneSide_Getter(this, e);
                    __value = (Zetbox.App.Test.One_to_N_relations_OneMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noops
                if ((value == null && _fk_OneSide == null) || (value != null && value.ID == _fk_OneSide))
				{
					SetInitializedProperty("OneSide");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = OneSideImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("OneSide", __oldValue, __newValue);

                if (OnOneSide_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Test.One_to_N_relations_One>(__oldValue, __newValue);
                    OnOneSide_PreSetter(this, e);
                    __newValue = (Zetbox.App.Test.One_to_N_relations_OneMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_OneSide = __newValue == null ? (int?)null : __newValue.ID;

                // now fixup redundant, inverse references
                // The inverse navigator will also fire events when changed, so should
                // only be touched after setting the local value above.
                // TODO: for complete correctness, the "other" Changing event should also fire
                //       before the local value is changed
                if (__oldValue != null)
                {
                    // remove from old list
                    (__oldValue.NSide as IRelationListSync<Zetbox.App.Test.One_to_N_relations_N>).RemoveWithoutClearParent(this);
                }

                if (__newValue != null)
                {
                    // add to new list
                    (__newValue.NSide as IRelationListSync<Zetbox.App.Test.One_to_N_relations_N>).AddWithoutSetParent(this);
                }
                // everything is done. fire the Changed event
                NotifyPropertyChanged("OneSide", __oldValue, __newValue);
                if(IsAttached) UpdateChangedInfo = true;

                if (OnOneSide_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Test.One_to_N_relations_One>(__oldValue, __newValue);
                    OnOneSide_PostSetter(this, e);
                }
            }
        }
        // END Zetbox.Generator.Templates.Properties.ObjectReferencePropertyTemplate for OneSide
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
            var otherImpl = (One_to_N_relations_NMemoryImpl)obj;
            var me = (One_to_N_relations_N)this;

            me.Name = other.Name;
            this._fk_OneSide = otherImpl._fk_OneSide;
        }

        public override void AttachToContext(IZetboxContext ctx)
        {
            base.AttachToContext(ctx);
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "OneSide":
                    {
                        var __oldValue = _fk_OneSide;
                        var __newValue = parentObj == null ? (int?)null : parentObj.ID;
                        NotifyPropertyChanging("OneSide", __oldValue, __newValue);
                        _fk_OneSide = __newValue;
                        NotifyPropertyChanged("OneSide", __oldValue, __newValue);
                    }
                    break;
                default:
                    base.UpdateParent(propertyName, parentObj);
                    break;
            }
        }
        #region Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

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
        #endregion // Zetbox.Generator.Templates.ObjectClasses.OnPropertyChange

        public override void ReloadReferences()
        {
            // Do not reload references if the current object has been deleted.
            // TODO: enable when MemoryContext uses MemoryDataObjects
            //if (this.ObjectState == DataObjectState.Deleted) return;
            base.ReloadReferences();

            // fix direct object references

            if (_fk_OneSide.HasValue)
                OneSideImpl = (Zetbox.App.Test.One_to_N_relations_OneMemoryImpl)Context.Find<Zetbox.App.Test.One_to_N_relations_One>(_fk_OneSide.Value);
            else
                OneSideImpl = null;
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
                    new PropertyDescriptorMemoryImpl<One_to_N_relations_N, string>(
                        lazyCtx,
                        new Guid("1b96dcd0-bf73-4855-84e5-7f8b1621672a"),
                        "Name",
                        null,
                        obj => obj.Name,
                        (obj, val) => obj.Name = val,
						obj => OnName_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<One_to_N_relations_N, Zetbox.App.Test.One_to_N_relations_One>(
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
            e.IsValid = b.IsValid;
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

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._Name);
            binStream.Write(OneSide != null ? OneSide.ID : (int?)null);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._Name = binStream.ReadString();
            this._fk_OneSide = binStream.ReadNullableInt32();
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