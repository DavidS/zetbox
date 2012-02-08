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
    [System.Diagnostics.DebuggerDisplay("SequenceData")]
    public class SequenceDataMemoryImpl : Kistl.DalProvider.Memory.DataObjectMemoryImpl, SequenceData
    {
        [Obsolete]
        public SequenceDataMemoryImpl()
            : base(null)
        {
        }

        public SequenceDataMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public int CurrentNumber
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(int);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _CurrentNumber;
                if (OnCurrentNumber_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnCurrentNumber_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_CurrentNumber != value)
                {
                    var __oldValue = _CurrentNumber;
                    var __newValue = value;
                    if (OnCurrentNumber_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnCurrentNumber_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("CurrentNumber", __oldValue, __newValue);
                    _CurrentNumber = __newValue;
                    NotifyPropertyChanged("CurrentNumber", __oldValue, __newValue);
                    if (OnCurrentNumber_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnCurrentNumber_PostSetter(this, __e);
                    }
                }
            }
        }
        private int _CurrentNumber;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.SequenceData, int> OnCurrentNumber_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.SequenceData, int> OnCurrentNumber_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.SequenceData, int> OnCurrentNumber_PostSetter;

        public event PropertyIsValidHandler<Kistl.App.Base.SequenceData> OnCurrentNumber_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Sequence
        // fkBackingName=_fk_Sequence; fkGuidBackingName=_fk_guid_Sequence;
        // referencedInterface=Kistl.App.Base.Sequence; moduleNamespace=Kistl.App.Base;
        // inverse Navigator=Data; is reference;
        // PositionStorage=none;
        // Target not exportable; does call events

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        // BEGIN Kistl.Generator.Templates.Properties.DelegatingProperty
        public Kistl.App.Base.Sequence Sequence
        {
            get { return SequenceImpl; }
            set { SequenceImpl = (Kistl.App.Base.SequenceMemoryImpl)value; }
        }
        // END Kistl.Generator.Templates.Properties.DelegatingProperty

        private int? _fk_Sequence;


        // internal implementation
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        internal Kistl.App.Base.SequenceMemoryImpl SequenceImpl
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return null;
                Kistl.App.Base.SequenceMemoryImpl __value;
                if (_fk_Sequence.HasValue)
                    __value = (Kistl.App.Base.SequenceMemoryImpl)Context.Find<Kistl.App.Base.Sequence>(_fk_Sequence.Value);
                else
                    __value = null;

                if (OnSequence_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Kistl.App.Base.Sequence>(__value);
                    OnSequence_Getter(this, e);
                    __value = (Kistl.App.Base.SequenceMemoryImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongKistlContextException();

                // shortcut noops
                if (value == null && _fk_Sequence == null)
                    return;
                else if (value != null && value.ID == _fk_Sequence)
                    return;

                // cache old value to remove inverse references later
                var __oldValue = SequenceImpl;
                var __newValue = value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Sequence", __oldValue, __newValue);

                if (OnSequence_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Kistl.App.Base.Sequence>(__oldValue, __newValue);
                    OnSequence_PreSetter(this, e);
                    __newValue = (Kistl.App.Base.SequenceMemoryImpl)e.Result;
                }

                // next, set the local reference
                _fk_Sequence = __newValue == null ? (int?)null : __newValue.ID;

                // now fixup redundant, inverse references
                // The inverse navigator will also fire events when changed, so should
                // only be touched after setting the local value above.
                // TODO: for complete correctness, the "other" Changing event should also fire
                //       before the local value is changed
                if (__oldValue != null)
                {
                    // unset old reference
                    __oldValue.Data = null;
                }

                if (__newValue != null)
                {
                    // set new reference
                    __newValue.Data = this;
                }
                // everything is done. fire the Changed event
                NotifyPropertyChanged("Sequence", __oldValue, __newValue);

                if (OnSequence_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Kistl.App.Base.Sequence>(__oldValue, __newValue);
                    OnSequence_PostSetter(this, e);
                }
            }
        }
        // END Kistl.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Sequence
		public static event PropertyGetterHandler<Kistl.App.Base.SequenceData, Kistl.App.Base.Sequence> OnSequence_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.SequenceData, Kistl.App.Base.Sequence> OnSequence_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.SequenceData, Kistl.App.Base.Sequence> OnSequence_PostSetter;

        public event PropertyIsValidHandler<Kistl.App.Base.SequenceData> OnSequence_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(SequenceData);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (SequenceData)obj;
            var otherImpl = (SequenceDataMemoryImpl)obj;
            var me = (SequenceData)this;

            me.CurrentNumber = other.CurrentNumber;
            this._fk_Sequence = otherImpl._fk_Sequence;
        }

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "Sequence":
                    {
                        var __oldValue = _fk_Sequence;
                        var __newValue = parentObj == null ? (int?)null : parentObj.ID;
                        NotifyPropertyChanging("Sequence", __oldValue, __newValue);
                        _fk_Sequence = __newValue;
                        NotifyPropertyChanged("Sequence", __oldValue, __newValue);
                    }
                    break;
                default:
                    base.UpdateParent(propertyName, parentObj);
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

            if (_fk_Sequence.HasValue)
                SequenceImpl = (Kistl.App.Base.SequenceMemoryImpl)Context.Find<Kistl.App.Base.Sequence>(_fk_Sequence.Value);
            else
                SequenceImpl = null;
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
                    new PropertyDescriptorMemoryImpl<SequenceData, int>(
                        lazyCtx,
                        new Guid("e557569b-1ed8-49a6-959e-0a6bc3ffa591"),
                        "CurrentNumber",
                        null,
                        obj => ((SequenceDataMemoryImpl)obj).CurrentNumber,
                        (obj, val) => obj.CurrentNumber = val,
						obj => ((SequenceDataMemoryImpl)obj).OnCurrentNumber_IsValid), 
                    // else
                    new PropertyDescriptorMemoryImpl<SequenceData, Kistl.App.Base.Sequence>(
                        lazyCtx,
                        new Guid("98a20549-d4ff-4caf-bae2-10951b04c6f1"),
                        "Sequence",
                        null,
                        obj => ((SequenceDataMemoryImpl)obj).Sequence,
                        (obj, val) => obj.Sequence = val,
						obj => ((SequenceDataMemoryImpl)obj).OnSequence_IsValid), 
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
        [EventBasedMethod("OnToString_SequenceData")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_SequenceData != null)
            {
                OnToString_SequenceData(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<SequenceData> OnToString_SequenceData;

        [EventBasedMethod("OnPreSave_SequenceData")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_SequenceData != null) OnPreSave_SequenceData(this);
        }
        public static event ObjectEventHandler<SequenceData> OnPreSave_SequenceData;

        [EventBasedMethod("OnPostSave_SequenceData")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_SequenceData != null) OnPostSave_SequenceData(this);
        }
        public static event ObjectEventHandler<SequenceData> OnPostSave_SequenceData;

        [EventBasedMethod("OnCreated_SequenceData")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_SequenceData != null) OnCreated_SequenceData(this);
        }
        public static event ObjectEventHandler<SequenceData> OnCreated_SequenceData;

        [EventBasedMethod("OnDeleting_SequenceData")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_SequenceData != null) OnDeleting_SequenceData(this);
        }
        public static event ObjectEventHandler<SequenceData> OnDeleting_SequenceData;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this._CurrentNumber, binStream);
            BinarySerializer.ToStream(Sequence != null ? Sequence.ID : (int?)null, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._CurrentNumber, binStream);
            BinarySerializer.FromStream(out this._fk_Sequence, binStream);
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
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.ToStream(this._CurrentNumber, xml, "CurrentNumber", "Kistl.App.Base");
            XmlStreamer.ToStream(Sequence != null ? Sequence.ID : (int?)null, xml, "Sequence", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._CurrentNumber, xml, "CurrentNumber", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._fk_Sequence, xml, "Sequence", "Kistl.App.Base");
            } // if (CurrentAccessRights != Kistl.API.AccessRights.None)
			return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        #endregion

    }
}