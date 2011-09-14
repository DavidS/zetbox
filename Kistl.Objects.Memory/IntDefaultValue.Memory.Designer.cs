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
    /// Sets an integer property with the configured default value
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("IntDefaultValue")]
    public class IntDefaultValueMemoryImpl : Kistl.App.Base.DefaultPropertyValueMemoryImpl, IntDefaultValue
    {
        [Obsolete]
        public IntDefaultValueMemoryImpl()
            : base(null)
        {
        }

        public IntDefaultValueMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public int IntValue
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(int);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _IntValue;
                if (OnIntValue_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnIntValue_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_IntValue != value)
                {
                    var __oldValue = _IntValue;
                    var __newValue = value;
                    if (OnIntValue_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnIntValue_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("IntValue", __oldValue, __newValue);
                    _IntValue = __newValue;
                    NotifyPropertyChanged("IntValue", __oldValue, __newValue);
                    if (OnIntValue_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnIntValue_PostSetter(this, __e);
                    }
                }
            }
        }
        private int _IntValue;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.IntDefaultValue, int> OnIntValue_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.IntDefaultValue, int> OnIntValue_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.IntDefaultValue, int> OnIntValue_PostSetter;

        /// <summary>
        /// GetDefaultValue
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGetDefaultValue_IntDefaultValue")]
        public override System.Object GetDefaultValue()
        {
            var e = new MethodReturnEventArgs<System.Object>();
            if (OnGetDefaultValue_IntDefaultValue != null)
            {
                OnGetDefaultValue_IntDefaultValue(this, e);
            }
            else
            {
                e.Result = base.GetDefaultValue();
            }
            return e.Result;
        }
        public static event GetDefaultValue_Handler<IntDefaultValue> OnGetDefaultValue_IntDefaultValue;
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(IntDefaultValue);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (IntDefaultValue)obj;
            var otherImpl = (IntDefaultValueMemoryImpl)obj;
            var me = (IntDefaultValue)this;

            me.IntValue = other.IntValue;
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
                    new PropertyDescriptorMemoryImpl<IntDefaultValueMemoryImpl, int>(
                        lazyCtx,
                        new Guid("c876dece-3b67-4302-88ef-313ba9ce62ae"),
                        "IntValue",
                        null,
                        obj => obj.IntValue,
                        (obj, val) => obj.IntValue = val),
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
        [EventBasedMethod("OnToString_IntDefaultValue")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_IntDefaultValue != null)
            {
                OnToString_IntDefaultValue(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<IntDefaultValue> OnToString_IntDefaultValue;

        [EventBasedMethod("OnPreSave_IntDefaultValue")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_IntDefaultValue != null) OnPreSave_IntDefaultValue(this);
        }
        public static event ObjectEventHandler<IntDefaultValue> OnPreSave_IntDefaultValue;

        [EventBasedMethod("OnPostSave_IntDefaultValue")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_IntDefaultValue != null) OnPostSave_IntDefaultValue(this);
        }
        public static event ObjectEventHandler<IntDefaultValue> OnPostSave_IntDefaultValue;

        [EventBasedMethod("OnCreated_IntDefaultValue")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_IntDefaultValue != null) OnCreated_IntDefaultValue(this);
        }
        public static event ObjectEventHandler<IntDefaultValue> OnCreated_IntDefaultValue;

        [EventBasedMethod("OnDeleting_IntDefaultValue")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_IntDefaultValue != null) OnDeleting_IntDefaultValue(this);
        }
        public static event ObjectEventHandler<IntDefaultValue> OnDeleting_IntDefaultValue;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this._IntValue, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._IntValue, binStream);
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
            XmlStreamer.ToStream(this._IntValue, xml, "IntValue", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._IntValue, xml, "IntValue", "Kistl.App.Base");
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._IntValue, xml, "IntValue", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.FromStream(ref this._IntValue, xml, "IntValue", "Kistl.App.Base");
        }

        #endregion

    }
}