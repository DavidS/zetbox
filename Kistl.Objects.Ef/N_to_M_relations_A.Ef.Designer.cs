// <autogenerated/>

namespace Kistl.App.Test
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
    /// The A-Side of the classes for the N_to_M_relations Tests
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="N_to_M_relations_A")]
    [System.Diagnostics.DebuggerDisplay("N_to_M_relations_A")]
    public class N_to_M_relations_AEfImpl : BaseServerDataObject_EntityFramework, N_to_M_relations_A
    {
        [Obsolete]
        public N_to_M_relations_AEfImpl()
            : base(null)
        {
        }

        public N_to_M_relations_AEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_ASide_connectsTo_BSide
    A: ZeroOrMore N_to_M_relations_A as ASide
    B: ZeroOrMore N_to_M_relations_B as BSide
    Preferred Storage: Separate
    */
        // collection reference property
        // Kistl.DalProvider.Ef.Generator.Templates.Properties.CollectionEntryListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Kistl.App.Test.N_to_M_relations_B> BSide
        {
            get
            {
                if (_BSide == null)
                {
                    _BSide = new BSideCollectionWrapper<Kistl.App.Test.N_to_M_relations_A, Kistl.App.Test.N_to_M_relations_B, Kistl.App.Test.N_to_M_relations_A_connectsTo_N_to_M_relations_B_RelationEntryEfImpl, EntityCollection<Kistl.App.Test.N_to_M_relations_A_connectsTo_N_to_M_relations_B_RelationEntryEfImpl>>(
                            this,
                            BSideImpl);
                }
                return _BSide;
            }
        }
        
        [EdmRelationshipNavigationProperty("Model", "FK_ASide_connectsTo_BSide_A", "CollectionEntry")]
        public EntityCollection<Kistl.App.Test.N_to_M_relations_A_connectsTo_N_to_M_relations_B_RelationEntryEfImpl> BSideImpl
        {
            get
            {
                var c = ((IEntityWithRelationships)(this)).RelationshipManager
                    .GetRelatedCollection<Kistl.App.Test.N_to_M_relations_A_connectsTo_N_to_M_relations_B_RelationEntryEfImpl>(
                        "Model.FK_ASide_connectsTo_BSide_A",
                        "CollectionEntry");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !c.IsLoaded)
                {
                    c.Load();
                }
                c.ForEach(i => i.AttachToContext(Context));
                return c;
            }
        }
        private BSideCollectionWrapper<Kistl.App.Test.N_to_M_relations_A, Kistl.App.Test.N_to_M_relations_B, Kistl.App.Test.N_to_M_relations_A_connectsTo_N_to_M_relations_B_RelationEntryEfImpl, EntityCollection<Kistl.App.Test.N_to_M_relations_A_connectsTo_N_to_M_relations_B_RelationEntryEfImpl>> _BSide;

        public static event PropertyIsValidHandler<Kistl.App.Test.N_to_M_relations_A> OnBSide_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // value type property
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public string Name
        {
            get
            {
                if (!CurrentAccessRights.HasReadRights()) return default(string);
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Name;
                if (OnName_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnName_Getter(this, __e);
                    __result = __e.Result;
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
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Kistl.App.Test.N_to_M_relations_A, string> OnName_Getter;
		public static event PropertyPreSetterHandler<Kistl.App.Test.N_to_M_relations_A, string> OnName_PreSetter;
		public static event PropertyPostSetterHandler<Kistl.App.Test.N_to_M_relations_A, string> OnName_PostSetter;

        public static event PropertyIsValidHandler<Kistl.App.Test.N_to_M_relations_A> OnName_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(N_to_M_relations_A);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (N_to_M_relations_A)obj;
            var otherImpl = (N_to_M_relations_AEfImpl)obj;
            var me = (N_to_M_relations_A)this;

            me.Name = other.Name;
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
                    // property.IsAssociation() && !property.IsObjectReferencePropertySingle()
                    new PropertyDescriptorEfImpl<N_to_M_relations_A, ICollection<Kistl.App.Test.N_to_M_relations_B>>(
                        lazyCtx,
                        new Guid("3afe0378-20f3-46f9-8391-da25414716ff"),
                        "BSide",
                        null,
                        obj => obj.BSide,
                        null, // lists are read-only properties
                        obj => OnBSide_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<N_to_M_relations_A, string>(
                        lazyCtx,
                        new Guid("084ec7c9-1623-43f1-9afc-e61f934df963"),
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
        #endregion // Kistl.Generator.Templates.ObjectClasses.CustomTypeDescriptor
        #region Kistl.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_N_to_M_relations_A")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_N_to_M_relations_A != null)
            {
                OnToString_N_to_M_relations_A(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<N_to_M_relations_A> OnToString_N_to_M_relations_A;

		[System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_N_to_M_relations_A")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
			var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
			e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_N_to_M_relations_A != null)
            {
                OnObjectIsValid_N_to_M_relations_A(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<N_to_M_relations_A> OnObjectIsValid_N_to_M_relations_A;

        [EventBasedMethod("OnNotifyPreSave_N_to_M_relations_A")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_N_to_M_relations_A != null) OnNotifyPreSave_N_to_M_relations_A(this);
        }
        public static event ObjectEventHandler<N_to_M_relations_A> OnNotifyPreSave_N_to_M_relations_A;

        [EventBasedMethod("OnNotifyPostSave_N_to_M_relations_A")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_N_to_M_relations_A != null) OnNotifyPostSave_N_to_M_relations_A(this);
        }
        public static event ObjectEventHandler<N_to_M_relations_A> OnNotifyPostSave_N_to_M_relations_A;

        [EventBasedMethod("OnNotifyCreated_N_to_M_relations_A")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Name");
            base.NotifyCreated();
            if (OnNotifyCreated_N_to_M_relations_A != null) OnNotifyCreated_N_to_M_relations_A(this);
        }
        public static event ObjectEventHandler<N_to_M_relations_A> OnNotifyCreated_N_to_M_relations_A;

        [EventBasedMethod("OnNotifyDeleting_N_to_M_relations_A")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_N_to_M_relations_A != null) OnNotifyDeleting_N_to_M_relations_A(this);
        }
        public static event ObjectEventHandler<N_to_M_relations_A> OnNotifyDeleting_N_to_M_relations_A;

        #endregion // Kistl.Generator.Templates.ObjectClasses.DefaultMethods
        // BEGIN Kistl.DalProvider.Ef.Generator.Templates.Properties.IdProperty
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
                }
				else 
				{
					SetInitializedProperty("ID");
				}
            }
        }
        private int _ID;
        // END Kistl.DalProvider.Ef.Generator.Templates.Properties.IdProperty

        #region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            BinarySerializer.ToStream(this._Name, binStream);
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.IO.BinaryReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            BinarySerializer.FromStream(out this._Name, binStream);
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
            XmlStreamer.ToStream(this._Name, xml, "Name", "Kistl.App.Test");
        }

        public override IEnumerable<IPersistenceObject> FromStream(System.Xml.XmlReader xml)
        {
            var baseResult = base.FromStream(xml);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Kistl.API.AccessRights.None) {
            XmlStreamer.FromStream(ref this._Name, xml, "Name", "Kistl.App.Test");
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