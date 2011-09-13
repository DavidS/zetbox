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
    /// Describes the currently loaded physical database schema
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("CurrentSchema")]
    public class CurrentSchemaMemoryImpl : Kistl.DalProvider.Memory.DataObjectMemoryImpl, CurrentSchema
    {
        [Obsolete]
        public CurrentSchemaMemoryImpl()
            : base(null)
        {
        }

        public CurrentSchemaMemoryImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// XML descriptor of the current schema
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public string Schema
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Schema;
                if (OnSchema_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnSchema_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Schema != value)
                {
                    var __oldValue = _Schema;
                    var __newValue = value;
                    if (OnSchema_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnSchema_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Schema", __oldValue, __newValue);
                    _Schema = __newValue;
                    NotifyPropertyChanged("Schema", __oldValue, __newValue);
                    if (OnSchema_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnSchema_PostSetter(this, __e);
                    }
                }
            }
        }
        private string _Schema;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.CurrentSchema, string> OnSchema_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.CurrentSchema, string> OnSchema_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.CurrentSchema, string> OnSchema_PostSetter;

        /// <summary>
        /// Version number of this schema
        /// </summary>
        // value type property
        // BEGIN Kistl.Generator.Templates.Properties.NotifyingDataProperty
        public int Version
        {
            get
            {
                if (CurrentAccessRights == Kistl.API.AccessRights.None) return default(int);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Version;
                if (OnVersion_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnVersion_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Version != value)
                {
                    var __oldValue = _Version;
                    var __newValue = value;
                    if (OnVersion_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<int>(__oldValue, __newValue);
                        OnVersion_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Version", __oldValue, __newValue);
                    _Version = __newValue;
                    NotifyPropertyChanged("Version", __oldValue, __newValue);
                    if (OnVersion_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnVersion_PostSetter(this, __e);
                    }
                }
            }
        }
        private int _Version;
        // END Kistl.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.CurrentSchema, int> OnVersion_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.CurrentSchema, int> OnVersion_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.CurrentSchema, int> OnVersion_PostSetter;

        public override Type GetImplementedInterface()
        {
            return typeof(CurrentSchema);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (CurrentSchema)obj;
            var otherImpl = (CurrentSchemaMemoryImpl)obj;
            var me = (CurrentSchema)this;

            me.Schema = other.Schema;
            me.Version = other.Version;
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
                    new PropertyDescriptorMemoryImpl<CurrentSchemaMemoryImpl, string>(
                        lazyCtx,
                        new Guid("175143b9-dd09-4b49-a633-e9cdb508c4c5"),
                        "Schema",
                        null,
                        obj => obj.Schema,
                        (obj, val) => obj.Schema = val),
                    // else
                    new PropertyDescriptorMemoryImpl<CurrentSchemaMemoryImpl, int>(
                        lazyCtx,
                        new Guid("193c24c4-5a42-418e-8ed8-6e1689beca50"),
                        "Version",
                        null,
                        obj => obj.Version,
                        (obj, val) => obj.Version = val),
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
        [EventBasedMethod("OnToString_CurrentSchema")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_CurrentSchema != null)
            {
                OnToString_CurrentSchema(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<CurrentSchema> OnToString_CurrentSchema;

        [EventBasedMethod("OnPreSave_CurrentSchema")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_CurrentSchema != null) OnPreSave_CurrentSchema(this);
        }
        public static event ObjectEventHandler<CurrentSchema> OnPreSave_CurrentSchema;

        [EventBasedMethod("OnPostSave_CurrentSchema")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_CurrentSchema != null) OnPostSave_CurrentSchema(this);
        }
        public static event ObjectEventHandler<CurrentSchema> OnPostSave_CurrentSchema;

        [EventBasedMethod("OnCreated_CurrentSchema")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_CurrentSchema != null) OnCreated_CurrentSchema(this);
        }
        public static event ObjectEventHandler<CurrentSchema> OnCreated_CurrentSchema;

        [EventBasedMethod("OnDeleting_CurrentSchema")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_CurrentSchema != null) OnDeleting_CurrentSchema(this);
        }
        public static event ObjectEventHandler<CurrentSchema> OnDeleting_CurrentSchema;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            BinarySerializer.ToStream(this._Schema, binStream);
            BinarySerializer.ToStream(this._Version, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            BinarySerializer.FromStream(out this._Schema, binStream);
            BinarySerializer.FromStream(out this._Version, binStream);
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
            base.ToStream(xml);
            XmlStreamer.ToStream(this._Schema, xml, "Schema", "Kistl.App.Base");
            XmlStreamer.ToStream(this._Version, xml, "Version", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            XmlStreamer.FromStream(ref this._Schema, xml, "Schema", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._Version, xml, "Version", "Kistl.App.Base");
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        #endregion

    }
}