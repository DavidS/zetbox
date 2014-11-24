// <autogenerated/>

namespace at.dasz.DocumentManagement
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
    /// Excerpt from a file
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="ExcerptEfImpl")]
    [System.Diagnostics.DebuggerDisplay("Excerpt")]
    public class ExcerptEfImpl : BaseServerDataObject_EntityFramework, Excerpt
    {
        private static readonly Guid _objectClassID = new Guid("51516bc2-b1b3-41cd-a84a-b04877ee6c14");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        [Obsolete]
        public ExcerptEfImpl()
            : base(null)
        {
        }

        public ExcerptEfImpl(Func<IFrozenContext> lazyCtx)
            : base(lazyCtx)
        {
        }

        /// <summary>
        /// 
        /// </summary>
    /*
    Relation: FK_File_has_Excerpt
    A: One File as File
    B: ZeroOrOne Excerpt as Excerpt
    Preferred Storage: MergeIntoB
    */
        // object reference property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for File
        // fkBackingName=_fk_File; fkGuidBackingName=_fk_guid_File;
        // referencedInterface=at.dasz.DocumentManagement.File; moduleNamespace=at.dasz.DocumentManagement;
        // inverse Navigator=Excerpt; is reference;
        // PositionStorage=none;
        // Target not exportable

        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public at.dasz.DocumentManagement.File File
        {
            get { return FileImpl; }
            set { FileImpl = (at.dasz.DocumentManagement.FileEfImpl)value; }
        }

        private int? _fk_File;


        // internal implementation, EF sees only this property
        [EdmRelationshipNavigationProperty("Model", "FK_File_has_Excerpt", "File")]
        public at.dasz.DocumentManagement.FileEfImpl FileImpl
        {
            get
            {
                at.dasz.DocumentManagement.FileEfImpl __value;
                EntityReference<at.dasz.DocumentManagement.FileEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<at.dasz.DocumentManagement.FileEfImpl>(
                        "Model.FK_File_has_Excerpt",
                        "File");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                __value = r.Value;
                if (OnFile_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<at.dasz.DocumentManagement.File>(__value);
                    OnFile_Getter(this, e);
                    __value = (at.dasz.DocumentManagement.FileEfImpl)e.Result;
                }
                return __value;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                EntityReference<at.dasz.DocumentManagement.FileEfImpl> r
                    = ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<at.dasz.DocumentManagement.FileEfImpl>(
                        "Model.FK_File_has_Excerpt",
                        "File");
                if (this.EntityState.In(System.Data.EntityState.Modified, System.Data.EntityState.Unchanged)
                    && !r.IsLoaded)
                {
                    r.Load();
                }
                at.dasz.DocumentManagement.FileEfImpl __oldValue = (at.dasz.DocumentManagement.FileEfImpl)r.Value;
                at.dasz.DocumentManagement.FileEfImpl __newValue = (at.dasz.DocumentManagement.FileEfImpl)value;

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("File", __oldValue, __newValue);
                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanging("Excerpt", null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanging("Excerpt", null, null);
                }

                if (OnFile_PreSetter != null)
                {
                    var e = new PropertyPreSetterEventArgs<at.dasz.DocumentManagement.File>(__oldValue, __newValue);
                    OnFile_PreSetter(this, e);
                    __newValue = (at.dasz.DocumentManagement.FileEfImpl)e.Result;
                }

                r.Value = (at.dasz.DocumentManagement.FileEfImpl)__newValue;

                if (OnFile_PostSetter != null)
                {
                    var e = new PropertyPostSetterEventArgs<at.dasz.DocumentManagement.File>(__oldValue, __newValue);
                    OnFile_PostSetter(this, e);
                }

                // everything is done. fire the Changed event
                NotifyPropertyChanged("File", __oldValue, __newValue);
                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanged("Excerpt", null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanged("Excerpt", null, null);
                }
                if(IsAttached) UpdateChangedInfo = true;
            }
        }

        public Zetbox.API.Async.ZbTask TriggerFetchFileAsync()
        {
            return new Zetbox.API.Async.ZbTask<at.dasz.DocumentManagement.File>(this.File);
        }

        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.ObjectReferencePropertyTemplate for File
		public static event PropertyGetterHandler<at.dasz.DocumentManagement.Excerpt, at.dasz.DocumentManagement.File> OnFile_Getter;
		public static event PropertyPreSetterHandler<at.dasz.DocumentManagement.Excerpt, at.dasz.DocumentManagement.File> OnFile_PreSetter;
		public static event PropertyPostSetterHandler<at.dasz.DocumentManagement.Excerpt, at.dasz.DocumentManagement.File> OnFile_PostSetter;

        public static event PropertyIsValidHandler<at.dasz.DocumentManagement.Excerpt> OnFile_IsValid;

        /// <summary>
        /// Text of the Excerpt
        /// </summary>
        // value type property
        // BEGIN Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        [EdmScalarProperty()]
        public string Text
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Text;
                if (OnText_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnText_Getter(this, __e);
                    __result = _Text = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Text != value)
                {
                    var __oldValue = _Text;
                    var __newValue = value;
                    if (OnText_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnText_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Text", __oldValue, __newValue);
                    _Text = __newValue;
                    NotifyPropertyChanged("Text", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnText_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnText_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("Text");
                }
            }
        }
        private string _Text_store;
        private string _Text {
            get { return _Text_store; }
            set {
                ReportEfPropertyChanging("Text");
                _Text_store = value;
                ReportEfPropertyChanged("Text");
            }
        }
        // END Zetbox.DalProvider.Ef.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<at.dasz.DocumentManagement.Excerpt, string> OnText_Getter;
		public static event PropertyPreSetterHandler<at.dasz.DocumentManagement.Excerpt, string> OnText_PreSetter;
		public static event PropertyPostSetterHandler<at.dasz.DocumentManagement.Excerpt, string> OnText_PostSetter;

        public static event PropertyIsValidHandler<at.dasz.DocumentManagement.Excerpt> OnText_IsValid;

        public override Type GetImplementedInterface()
        {
            return typeof(Excerpt);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (Excerpt)obj;
            var otherImpl = (ExcerptEfImpl)obj;
            var me = (Excerpt)this;

            me.Text = other.Text;
            this._fk_File = otherImpl._fk_File;
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
                case "File":
                case "Text":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }
        #endregion // Zetbox.DalProvider.Ef.Generator.Templates.ObjectClasses.OnPropertyChange

        public override Zetbox.API.Async.ZbTask TriggerFetch(string propName)
        {
            switch(propName)
            {
            case "File":
                return TriggerFetchFileAsync();
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

            if (_fk_File.HasValue)
                FileImpl = (at.dasz.DocumentManagement.FileEfImpl)Context.Find<at.dasz.DocumentManagement.File>(_fk_File.Value);
            else
                FileImpl = null;
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
                    new PropertyDescriptorEfImpl<Excerpt, at.dasz.DocumentManagement.File>(
                        lazyCtx,
                        new Guid("f36d87fe-bd2f-472c-a716-46667ab1e0bd"),
                        "File",
                        null,
                        obj => obj.File,
                        (obj, val) => obj.File = val,
						obj => OnFile_IsValid), 
                    // else
                    new PropertyDescriptorEfImpl<Excerpt, string>(
                        lazyCtx,
                        new Guid("af39fe5d-383d-40fd-a780-439727195612"),
                        "Text",
                        null,
                        obj => obj.Text,
                        (obj, val) => obj.Text = val,
						obj => OnText_IsValid), 
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
        [EventBasedMethod("OnToString_Excerpt")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_Excerpt != null)
            {
                OnToString_Excerpt(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<Excerpt> OnToString_Excerpt;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_Excerpt")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_Excerpt != null)
            {
                OnObjectIsValid_Excerpt(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<Excerpt> OnObjectIsValid_Excerpt;

        [EventBasedMethod("OnNotifyPreSave_Excerpt")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_Excerpt != null) OnNotifyPreSave_Excerpt(this);
        }
        public static event ObjectEventHandler<Excerpt> OnNotifyPreSave_Excerpt;

        [EventBasedMethod("OnNotifyPostSave_Excerpt")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_Excerpt != null) OnNotifyPostSave_Excerpt(this);
        }
        public static event ObjectEventHandler<Excerpt> OnNotifyPostSave_Excerpt;

        [EventBasedMethod("OnNotifyCreated_Excerpt")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("File");
            SetNotInitializedProperty("Text");
            base.NotifyCreated();
            if (OnNotifyCreated_Excerpt != null) OnNotifyCreated_Excerpt(this);
        }
        public static event ObjectEventHandler<Excerpt> OnNotifyCreated_Excerpt;

        [EventBasedMethod("OnNotifyDeleting_Excerpt")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_Excerpt != null) OnNotifyDeleting_Excerpt(this);
            File = null;
        }
        public static event ObjectEventHandler<Excerpt> OnNotifyDeleting_Excerpt;

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
            {
                var r = this.RelationshipManager.GetRelatedReference<at.dasz.DocumentManagement.FileEfImpl>("Model.FK_File_has_Excerpt", "File");
                var key = r.EntityKey;
                binStream.Write(r.Value != null ? r.Value.ID : (key != null ? (int?)key.EntityKeyValues.Single().Value : (int?)null));
            }
            binStream.Write(this._Text);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            binStream.Read(out this._fk_File);
            this._Text = binStream.ReadString();
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