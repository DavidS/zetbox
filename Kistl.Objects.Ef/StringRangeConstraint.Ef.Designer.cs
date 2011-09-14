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

    using Kistl.API.Server;
    using Kistl.DalProvider.Ef;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="StringRangeConstraint")]
    [System.Diagnostics.DebuggerDisplay("StringRangeConstraint")]
    public class StringRangeConstraintEfImpl : Kistl.App.Base.ConstraintEfImpl, StringRangeConstraint
    {
        [Obsolete]
        public StringRangeConstraintEfImpl()
            : base(null)
        {
        }

        public StringRangeConstraintEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// The maximal length of this StringProperty or null for unlimited length
        /// </summary>
        // value type property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public int? MaxLength
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(int?);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _MaxLength;
                if (OnMaxLength_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int?>(__result);
                    OnMaxLength_Getter(this, __e);
                    __result = __e.Result;
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
                    if (OnMaxLength_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int?>(__oldValue, __newValue);
                        OnMaxLength_PostSetter(this, __e);
                    }
                }
            }
        }
        private int? _MaxLength;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.StringRangeConstraint, int?> OnMaxLength_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.StringRangeConstraint, int?> OnMaxLength_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.StringRangeConstraint, int?> OnMaxLength_PostSetter;

        /// <summary>
        /// The minimal length of this StringProperty
        /// </summary>
        // value type property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public int MinLength
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(int);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _MinLength;
                if (OnMinLength_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<int>(__result);
                    OnMinLength_Getter(this, __e);
                    __result = __e.Result;
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
                    if (OnMinLength_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<int>(__oldValue, __newValue);
                        OnMinLength_PostSetter(this, __e);
                    }
                }
            }
        }
        private int _MinLength;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Base.StringRangeConstraint, int> OnMinLength_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Base.StringRangeConstraint, int> OnMinLength_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Base.StringRangeConstraint, int> OnMinLength_PostSetter;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
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
        // END Kistl.Generator.Templates.ObjectClasses.Method

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Kistl.Generator.Templates.ObjectClasses.Method
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
        // END Kistl.Generator.Templates.ObjectClasses.Method

        public override Type GetImplementedInterface()
        {
            return typeof(StringRangeConstraint);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (StringRangeConstraint)obj;
            var otherImpl = (StringRangeConstraintEfImpl)obj;
            var me = (StringRangeConstraint)this;

            me.MaxLength = other.MaxLength;
            me.MinLength = other.MinLength;
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
                    new PropertyDescriptorEfImpl<StringRangeConstraintEfImpl, int?>(
                        lazyCtx,
                        new Guid("17aa679d-72d0-480e-9bd9-b37f4eba1d68"),
                        "MaxLength",
                        null,
                        obj => obj.MaxLength,
                        (obj, val) => obj.MaxLength = val),
                    // else
                    new PropertyDescriptorEfImpl<StringRangeConstraintEfImpl, int>(
                        lazyCtx,
                        new Guid("8d3e24f7-c8c8-4bb3-931e-d0452e7ee5b6"),
                        "MinLength",
                        null,
                        obj => obj.MinLength,
                        (obj, val) => obj.MinLength = val),
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

        [EventBasedMethod("OnPreSave_StringRangeConstraint")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_StringRangeConstraint != null) OnPreSave_StringRangeConstraint(this);
        }
        public static event ObjectEventHandler<StringRangeConstraint> OnPreSave_StringRangeConstraint;

        [EventBasedMethod("OnPostSave_StringRangeConstraint")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_StringRangeConstraint != null) OnPostSave_StringRangeConstraint(this);
        }
        public static event ObjectEventHandler<StringRangeConstraint> OnPostSave_StringRangeConstraint;

        [EventBasedMethod("OnCreated_StringRangeConstraint")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_StringRangeConstraint != null) OnCreated_StringRangeConstraint(this);
        }
        public static event ObjectEventHandler<StringRangeConstraint> OnCreated_StringRangeConstraint;

        [EventBasedMethod("OnDeleting_StringRangeConstraint")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_StringRangeConstraint != null) OnDeleting_StringRangeConstraint(this);
        }
        public static event ObjectEventHandler<StringRangeConstraint> OnDeleting_StringRangeConstraint;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this._MaxLength, binStream);
            BinarySerializer.ToStream(this._MinLength, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._MaxLength, binStream);
            BinarySerializer.FromStream(out this._MinLength, binStream);
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
            XmlStreamer.ToStream(this._MaxLength, xml, "MaxLength", "Kistl.App.Base");
            XmlStreamer.ToStream(this._MinLength, xml, "MinLength", "Kistl.App.Base");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._MaxLength, xml, "MaxLength", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._MinLength, xml, "MinLength", "Kistl.App.Base");
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
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._MaxLength, xml, "MaxLength", "Kistl.App.Base");
            if (modules.Contains("*") || modules.Contains("Kistl.App.Base")) XmlStreamer.ToStream(this._MinLength, xml, "MinLength", "Kistl.App.Base");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            if (!CurrentAccessRights.HasReadRights()) return;
            XmlStreamer.FromStream(ref this._MaxLength, xml, "MaxLength", "Kistl.App.Base");
            XmlStreamer.FromStream(ref this._MinLength, xml, "MinLength", "Kistl.App.Base");
        }

        #endregion

    }
}