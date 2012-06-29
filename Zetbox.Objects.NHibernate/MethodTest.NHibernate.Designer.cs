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

    using Zetbox.API.Utils;
    using Zetbox.DalProvider.Base;
    using Zetbox.DalProvider.NHibernate;

    /// <summary>
    /// Test class for methods
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("MethodTest")]
    public class MethodTestNHibernateImpl : Zetbox.DalProvider.NHibernate.DataObjectNHibernateImpl, MethodTest
    {
        private static readonly Guid _objectClassID = new Guid("68a664ee-67e0-4ba7-a0dc-148b9dfa32a7");
        public override Guid ObjectClassID { get { return _objectClassID; } }

        public MethodTestNHibernateImpl()
            : this(null)
        {
        }

        /// <summary>Create a new unattached instance</summary>
        public MethodTestNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(lazyCtx, new MethodTestProxy())
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public MethodTestNHibernateImpl(Func<IFrozenContext> lazyCtx, MethodTestProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly MethodTestProxy Proxy;

        /// <summary>
        /// 
        /// </summary>
        // object list property

        // Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectListProperty
        // implement the user-visible interface
        [XmlIgnore()]
        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public ICollection<Zetbox.App.Test.MethodTest> Children
        {
            get
            {
                if (_Children == null)
                {
                    _Children = new OneNRelationList<Zetbox.App.Test.MethodTest>(
                        "Parent",
                        null,
                        this,
                        () => this.NotifyPropertyChanging("Children", null, null),
                        () => { this.NotifyPropertyChanged("Children", null, null); if(OnChildren_PostSetter != null && IsAttached) OnChildren_PostSetter(this); },
                        new ProjectedCollection<Zetbox.App.Test.MethodTestNHibernateImpl.MethodTestProxy, Zetbox.App.Test.MethodTest>(
                            () => Proxy.Children,
                            p => (Zetbox.App.Test.MethodTest)OurContext.AttachAndWrap(p),
                            d => (Zetbox.App.Test.MethodTestNHibernateImpl.MethodTestProxy)((NHibernatePersistenceObject)d).NHibernateProxy));
                }
                return _Children;
            }
        }
    
        private OneNRelationList<Zetbox.App.Test.MethodTest> _Children;
public static event PropertyListChangedHandler<Zetbox.App.Test.MethodTest> OnChildren_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.MethodTest> OnChildren_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Parent
        // fkBackingName=this.Proxy.Parent; fkGuidBackingName=_fk_guid_Parent;
        // referencedInterface=Zetbox.App.Test.MethodTest; moduleNamespace=Zetbox.App.Test;
        // inverse Navigator=Children; is list;
        // PositionStorage=none;
        // Target not exportable; does call events

        [System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
        public Zetbox.App.Test.MethodTest Parent
        {
            get
            {
                Zetbox.App.Test.MethodTestNHibernateImpl __value = (Zetbox.App.Test.MethodTestNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Parent);

                if (OnParent_Getter != null)
                {
                    var e = new PropertyGetterEventArgs<Zetbox.App.Test.MethodTest>(__value);
                    OnParent_Getter(this, e);
                    __value = (Zetbox.App.Test.MethodTestNHibernateImpl)e.Result;
                }

                return __value;
            }
            set
            {
                if (((IPersistenceObject)this).IsReadonly) throw new ReadOnlyObjectException();
                if (value != null && value.Context != this.Context) throw new WrongZetboxContextException();

                // shortcut noop with nulls
                if (value == null && this.Proxy.Parent == null)
				{
					SetInitializedProperty("Parent");
                    return;
				}

                // cache old value to remove inverse references later
                var __oldValue = (Zetbox.App.Test.MethodTestNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Parent);
                var __newValue = (Zetbox.App.Test.MethodTestNHibernateImpl)value;

                // shortcut noop on objects
                // can't use proxy's ID here, since that might be INVALIDID before persisting the first time.
                if (__oldValue == __newValue)
				{
					SetInitializedProperty("Parent");
                    return;
				}

                // Changing Event fires before anything is touched
                NotifyPropertyChanging("Parent", __oldValue, __newValue);

                if (__oldValue != null) {
                    __oldValue.NotifyPropertyChanging("Children", null, null);
                }
                if (__newValue != null) {
                    __newValue.NotifyPropertyChanging("Children", null, null);
                }

                if (OnParent_PreSetter != null && IsAttached)
                {
                    var e = new PropertyPreSetterEventArgs<Zetbox.App.Test.MethodTest>(__oldValue, __newValue);
                    OnParent_PreSetter(this, e);
                    __newValue = (Zetbox.App.Test.MethodTestNHibernateImpl)e.Result;
                }

                // next, set the local reference
                if (__newValue == null)
                {
                    this.Proxy.Parent = null;
                }
                else
                {
                    this.Proxy.Parent = __newValue.Proxy;
                }

                // now fixup redundant, inverse references
                // The inverse navigator will also fire events when changed, so should
                // only be touched after setting the local value above.
                // TODO: for complete correctness, the "other" Changing event should also fire
                //       before the local value is changed
                if (__oldValue != null)
                {
                    // remove from old list
                    (__oldValue.Children as IRelationListSync<Zetbox.App.Test.MethodTest>).RemoveWithoutClearParent(this);
                }

                if (__newValue != null)
                {
                    // add to new list
                    (__newValue.Children as IRelationListSync<Zetbox.App.Test.MethodTest>).AddWithoutSetParent(this);
                }
                // everything is done. fire the Changed event
                NotifyPropertyChanged("Parent", __oldValue, __newValue);

                if (OnParent_PostSetter != null && IsAttached)
                {
                    var e = new PropertyPostSetterEventArgs<Zetbox.App.Test.MethodTest>(__oldValue, __newValue);
                    OnParent_PostSetter(this, e);
                }
            }
        }

        /// <summary>Backing store for Parent's id, used on dehydration only</summary>
        private int? _fk_Parent = null;


        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ObjectReferencePropertyTemplate for Parent
		public static event PropertyGetterHandler<Zetbox.App.Test.MethodTest, Zetbox.App.Test.MethodTest> OnParent_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.MethodTest, Zetbox.App.Test.MethodTest> OnParent_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.MethodTest, Zetbox.App.Test.MethodTest> OnParent_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.MethodTest> OnParent_IsValid;

        /// <summary>
        /// 
        /// </summary>

        // BEGIN Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
        public string StringProp
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = Proxy.StringProp;
                if (OnStringProp_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnStringProp_Getter(this, __e);
                    __result = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (Proxy.StringProp != value)
                {
                    var __oldValue = Proxy.StringProp;
                    var __newValue = value;
                    if (OnStringProp_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnStringProp_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("StringProp", __oldValue, __newValue);
                    Proxy.StringProp = __newValue;
                    NotifyPropertyChanged("StringProp", __oldValue, __newValue);

                    if (OnStringProp_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnStringProp_PostSetter(this, __e);
                    }
                }
				else 
				{
					SetInitializedProperty("StringProp");
				}
            }
        }

        // END Zetbox.DalProvider.NHibernate.Generator.Templates.Properties.ProxyProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.MethodTest, string> OnStringProp_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.MethodTest, string> OnStringProp_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.MethodTest, string> OnStringProp_PostSetter;

        public static event PropertyIsValidHandler<Zetbox.App.Test.MethodTest> OnStringProp_IsValid;

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGroup1_MethodTest")]
        public virtual void Group1()
        {
            // base.Group1();
            if (OnGroup1_MethodTest != null)
            {
                OnGroup1_MethodTest(this);
            }
            else
            {
                throw new NotImplementedException("No handler registered on method MethodTest.Group1");
            }
        }
        public delegate void Group1_Handler<T>(T obj);
        public static event Group1_Handler<MethodTest> OnGroup1_MethodTest;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<MethodTest> OnGroup1_MethodTest_CanExec;

        [EventBasedMethod("OnGroup1_MethodTest_CanExec")]
        public virtual bool Group1CanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGroup1_MethodTest_CanExec != null)
				{
					OnGroup1_MethodTest_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<MethodTest> OnGroup1_MethodTest_CanExecReason;

        [EventBasedMethod("OnGroup1_MethodTest_CanExecReason")]
        public virtual string Group1CanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGroup1_MethodTest_CanExecReason != null)
				{
					OnGroup1_MethodTest_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnGroup2_MethodTest")]
        public virtual void Group2()
        {
            // base.Group2();
            if (OnGroup2_MethodTest != null)
            {
                OnGroup2_MethodTest(this);
            }
            else
            {
                throw new NotImplementedException("No handler registered on method MethodTest.Group2");
            }
        }
        public delegate void Group2_Handler<T>(T obj);
        public static event Group2_Handler<MethodTest> OnGroup2_MethodTest;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<MethodTest> OnGroup2_MethodTest_CanExec;

        [EventBasedMethod("OnGroup2_MethodTest_CanExec")]
        public virtual bool Group2CanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnGroup2_MethodTest_CanExec != null)
				{
					OnGroup2_MethodTest_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<MethodTest> OnGroup2_MethodTest_CanExecReason;

        [EventBasedMethod("OnGroup2_MethodTest_CanExecReason")]
        public virtual string Group2CanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnGroup2_MethodTest_CanExecReason != null)
				{
					OnGroup2_MethodTest_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnObjParameter_MethodTest")]
        public virtual void ObjParameter(Zetbox.App.Test.MethodTest objParam)
        {
            // base.ObjParameter();
            if (OnObjParameter_MethodTest != null)
            {
                OnObjParameter_MethodTest(this, objParam);
            }
            else
            {
                throw new NotImplementedException("No handler registered on method MethodTest.ObjParameter");
            }
        }
        public delegate void ObjParameter_Handler<T>(T obj, Zetbox.App.Test.MethodTest objParam);
        public static event ObjParameter_Handler<MethodTest> OnObjParameter_MethodTest;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<MethodTest> OnObjParameter_MethodTest_CanExec;

        [EventBasedMethod("OnObjParameter_MethodTest_CanExec")]
        public virtual bool ObjParameterCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnObjParameter_MethodTest_CanExec != null)
				{
					OnObjParameter_MethodTest_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<MethodTest> OnObjParameter_MethodTest_CanExecReason;

        [EventBasedMethod("OnObjParameter_MethodTest_CanExecReason")]
        public virtual string ObjParameterCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnObjParameter_MethodTest_CanExecReason != null)
				{
					OnObjParameter_MethodTest_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnObjRet_MethodTest")]
        public virtual Zetbox.App.Test.MethodTest ObjRet()
        {
            var e = new MethodReturnEventArgs<Zetbox.App.Test.MethodTest>();
            if (OnObjRet_MethodTest != null)
            {
                OnObjRet_MethodTest(this, e);
            }
            else
            {
                throw new NotImplementedException("No handler registered on MethodTest.ObjRet");
            }
            return e.Result;
        }
        public delegate void ObjRet_Handler<T>(T obj, MethodReturnEventArgs<Zetbox.App.Test.MethodTest> ret);
        public static event ObjRet_Handler<MethodTest> OnObjRet_MethodTest;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<MethodTest> OnObjRet_MethodTest_CanExec;

        [EventBasedMethod("OnObjRet_MethodTest_CanExec")]
        public virtual bool ObjRetCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnObjRet_MethodTest_CanExec != null)
				{
					OnObjRet_MethodTest_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<MethodTest> OnObjRet_MethodTest_CanExecReason;

        [EventBasedMethod("OnObjRet_MethodTest_CanExecReason")]
        public virtual string ObjRetCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnObjRet_MethodTest_CanExecReason != null)
				{
					OnObjRet_MethodTest_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnParameterless_MethodTest")]
        public virtual void Parameterless()
        {
            // base.Parameterless();
            if (OnParameterless_MethodTest != null)
            {
                OnParameterless_MethodTest(this);
            }
            else
            {
                throw new NotImplementedException("No handler registered on method MethodTest.Parameterless");
            }
        }
        public delegate void Parameterless_Handler<T>(T obj);
        public static event Parameterless_Handler<MethodTest> OnParameterless_MethodTest;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<MethodTest> OnParameterless_MethodTest_CanExec;

        [EventBasedMethod("OnParameterless_MethodTest_CanExec")]
        public virtual bool ParameterlessCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnParameterless_MethodTest_CanExec != null)
				{
					OnParameterless_MethodTest_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<MethodTest> OnParameterless_MethodTest_CanExecReason;

        [EventBasedMethod("OnParameterless_MethodTest_CanExecReason")]
        public virtual string ParameterlessCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnParameterless_MethodTest_CanExecReason != null)
				{
					OnParameterless_MethodTest_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnStringParameter_MethodTest")]
        public virtual void StringParameter(string str)
        {
            // base.StringParameter();
            if (OnStringParameter_MethodTest != null)
            {
                OnStringParameter_MethodTest(this, str);
            }
            else
            {
                throw new NotImplementedException("No handler registered on method MethodTest.StringParameter");
            }
        }
        public delegate void StringParameter_Handler<T>(T obj, string str);
        public static event StringParameter_Handler<MethodTest> OnStringParameter_MethodTest;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<MethodTest> OnStringParameter_MethodTest_CanExec;

        [EventBasedMethod("OnStringParameter_MethodTest_CanExec")]
        public virtual bool StringParameterCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnStringParameter_MethodTest_CanExec != null)
				{
					OnStringParameter_MethodTest_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<MethodTest> OnStringParameter_MethodTest_CanExecReason;

        [EventBasedMethod("OnStringParameter_MethodTest_CanExecReason")]
        public virtual string StringParameterCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnStringParameter_MethodTest_CanExecReason != null)
				{
					OnStringParameter_MethodTest_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        /// <summary>
        /// 
        /// </summary>
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.Method
        [EventBasedMethod("OnSummary_MethodTest")]
        public virtual void Summary()
        {
            // base.Summary();
            if (OnSummary_MethodTest != null)
            {
                OnSummary_MethodTest(this);
            }
            else
            {
                throw new NotImplementedException("No handler registered on method MethodTest.Summary");
            }
        }
        public delegate void Summary_Handler<T>(T obj);
        public static event Summary_Handler<MethodTest> OnSummary_MethodTest;
        // BEGIN Zetbox.Generator.Templates.ObjectClasses.MethodCanExec
		// CanExec
		public static event CanExecMethodEventHandler<MethodTest> OnSummary_MethodTest_CanExec;

        [EventBasedMethod("OnSummary_MethodTest_CanExec")]
        public virtual bool SummaryCanExec
        {
			get 
			{
				var e = new MethodReturnEventArgs<bool>();
				if (OnSummary_MethodTest_CanExec != null)
				{
					OnSummary_MethodTest_CanExec(this, e);
				}
				else
				{
					e.Result = true;
				}
				return e.Result;
			}
        }

		// CanExecReason
		public static event CanExecReasonMethodEventHandler<MethodTest> OnSummary_MethodTest_CanExecReason;

        [EventBasedMethod("OnSummary_MethodTest_CanExecReason")]
        public virtual string SummaryCanExecReason
        {
			get 
			{
				var e = new MethodReturnEventArgs<string>();
				if (OnSummary_MethodTest_CanExecReason != null)
				{
					OnSummary_MethodTest_CanExecReason(this, e);
				}
				else
				{
					e.Result = string.Empty;
				}
				return e.Result;
			}
        }
        // END Zetbox.Generator.Templates.ObjectClasses.MethodCanExec

        public override Type GetImplementedInterface()
        {
            return typeof(MethodTest);
        }

        public override void ApplyChangesFrom(IPersistenceObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (MethodTest)obj;
            var otherImpl = (MethodTestNHibernateImpl)obj;
            var me = (MethodTest)this;

            me.StringProp = other.StringProp;
            this._fk_Parent = otherImpl._fk_Parent;
        }

        public override void AttachToContext(IZetboxContext ctx)
        {
            base.AttachToContext(ctx);
            var nhCtx = (NHibernateContext)ctx;
        }
        public override void SetNew()
        {
            base.SetNew();
        }

        public override void UpdateParent(string propertyName, IDataObject parentObj)
        {
            switch(propertyName)
            {
                case "Parent":
                    {
                        var __oldValue = (Zetbox.App.Test.MethodTestNHibernateImpl)OurContext.AttachAndWrap(this.Proxy.Parent);
                        var __newValue = (Zetbox.App.Test.MethodTestNHibernateImpl)parentObj;
                        NotifyPropertyChanging("Parent", __oldValue, __newValue);
                        this.Proxy.Parent = __newValue == null ? null : __newValue.Proxy;
                        NotifyPropertyChanged("Parent", __oldValue, __newValue);
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
                case "Parent":
                case "StringProp":
                    AuditPropertyChange(property, oldValue, newValue);
                    break;
            }
        }

        protected override bool ShouldSetModified(string property)
        {
            switch (property)
            {
                case "Children":
                    return false;
                default:
                    return base.ShouldSetModified(property);
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

            if (_fk_Parent.HasValue)
                this.Parent = ((Zetbox.App.Test.MethodTestNHibernateImpl)OurContext.FindPersistenceObject<Zetbox.App.Test.MethodTest>(_fk_Parent.Value));
            else
                this.Parent = null;
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
                    new PropertyDescriptorNHibernateImpl<MethodTest, ICollection<Zetbox.App.Test.MethodTest>>(
                        lazyCtx,
                        new Guid("bf48b883-8821-4c4e-8509-590a72604f9e"),
                        "Children",
                        null,
                        obj => obj.Children,
                        null, // lists are read-only properties
                        obj => OnChildren_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<MethodTest, Zetbox.App.Test.MethodTest>(
                        lazyCtx,
                        new Guid("02a7d534-9325-48e5-bbc2-b61420afd940"),
                        "Parent",
                        null,
                        obj => obj.Parent,
                        (obj, val) => obj.Parent = val,
						obj => OnParent_IsValid), 
                    // else
                    new PropertyDescriptorNHibernateImpl<MethodTest, string>(
                        lazyCtx,
                        new Guid("8d226658-fecc-4139-8234-aa88a4738b4d"),
                        "StringProp",
                        null,
                        obj => obj.StringProp,
                        (obj, val) => obj.StringProp = val,
						obj => OnStringProp_IsValid), 
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
        #region Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_MethodTest")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_MethodTest != null)
            {
                OnToString_MethodTest(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<MethodTest> OnToString_MethodTest;

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_MethodTest")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
            var b = base.ObjectIsValid();
            e.IsValid = b.IsValid;
            e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_MethodTest != null)
            {
                OnObjectIsValid_MethodTest(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<MethodTest> OnObjectIsValid_MethodTest;

        [EventBasedMethod("OnNotifyPreSave_MethodTest")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnNotifyPreSave_MethodTest != null) OnNotifyPreSave_MethodTest(this);
        }
        public static event ObjectEventHandler<MethodTest> OnNotifyPreSave_MethodTest;

        [EventBasedMethod("OnNotifyPostSave_MethodTest")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnNotifyPostSave_MethodTest != null) OnNotifyPostSave_MethodTest(this);
        }
        public static event ObjectEventHandler<MethodTest> OnNotifyPostSave_MethodTest;

        [EventBasedMethod("OnNotifyCreated_MethodTest")]
        public override void NotifyCreated()
        {
            SetNotInitializedProperty("Parent");
            SetNotInitializedProperty("StringProp");
            base.NotifyCreated();
            if (OnNotifyCreated_MethodTest != null) OnNotifyCreated_MethodTest(this);
        }
        public static event ObjectEventHandler<MethodTest> OnNotifyCreated_MethodTest;

        [EventBasedMethod("OnNotifyDeleting_MethodTest")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnNotifyDeleting_MethodTest != null) OnNotifyDeleting_MethodTest(this);

            // FK_Parent_has_Children ZeroOrMore
            foreach(NHibernatePersistenceObject x in Children) {
                x.ParentsToDelete.Add(this);
                ChildrenToDelete.Add(x);
            }

            Children.Clear();
            Parent = null;
        }
        public static event ObjectEventHandler<MethodTest> OnNotifyDeleting_MethodTest;

        #endregion // Zetbox.DalProvider.NHibernate.Generator.Templates.ObjectClasses.DefaultMethods

        public class MethodTestProxy
            : IProxyObject, ISortKey<int>
        {
            public MethodTestProxy()
            {
                Children = new Collection<Zetbox.App.Test.MethodTestNHibernateImpl.MethodTestProxy>();
            }

            public virtual int ID { get; set; }

            public virtual Type ZetboxWrapper { get { return typeof(MethodTestNHibernateImpl); } }
            public virtual Type ZetboxProxy { get { return typeof(MethodTestProxy); } }

            public virtual ICollection<Zetbox.App.Test.MethodTestNHibernateImpl.MethodTestProxy> Children { get; set; }

            public virtual Zetbox.App.Test.MethodTestNHibernateImpl.MethodTestProxy Parent { get; set; }

            public virtual string StringProp { get; set; }

        }

        // make proxy available for the provider
        public override IProxyObject NHibernateProxy { get { return Proxy; } }
        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this.Proxy.Parent != null ? OurContext.GetIdFromProxy(this.Proxy.Parent) : (int?)null);
            binStream.Write(this.Proxy.StringProp);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            binStream.Read(out this._fk_Parent);
            this.Proxy.StringProp = binStream.ReadString();
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