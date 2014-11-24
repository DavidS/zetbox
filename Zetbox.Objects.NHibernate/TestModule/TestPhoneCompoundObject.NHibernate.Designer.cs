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
    /// 
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("TestPhoneCompoundObject")]
    public class TestPhoneCompoundObjectNHibernateImpl : CompoundObjectDefaultImpl, ICompoundObject, TestPhoneCompoundObject
    {
        private static readonly Guid _compoundObjectID = new Guid("2510af08-089f-4252-8a98-ec84cb67bcb9");
        public override Guid CompoundObjectID { get { return _compoundObjectID; } }

        // used by NHibernate
        public TestPhoneCompoundObjectNHibernateImpl()
            : this(null, null, null, null)
        {
        }

        // used by CreateUnattachedInstance
        public TestPhoneCompoundObjectNHibernateImpl(Func<IFrozenContext> lazyCtx)
            : this(null, null, lazyCtx, null)
        {
        }

        /// <summary>Create a instance, wrapping the specified proxy</summary>
        public TestPhoneCompoundObjectNHibernateImpl(IPersistenceObject parent, string property, Func<IFrozenContext> lazyCtx, TestPhoneCompoundObjectProxy proxy)
            : base(lazyCtx) // do not pass proxy to base data object
        {
            this.Proxy = proxy;
            AttachToObject(parent, property);
        }

        /// <summary>the NHibernate proxy of the represented entity</summary>
        internal readonly TestPhoneCompoundObjectProxy Proxy;

        /// <summary>
        /// Enter Area Code
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public string AreaCode
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _AreaCode;
                if (OnAreaCode_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnAreaCode_Getter(this, __e);
                    __result = _AreaCode = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_AreaCode != value)
                {
                    var __oldValue = _AreaCode;
                    var __newValue = value;
                    if (OnAreaCode_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnAreaCode_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("AreaCode", __oldValue, __newValue);
                    _AreaCode = __newValue;
                    NotifyPropertyChanged("AreaCode", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnAreaCode_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnAreaCode_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("AreaCode");
                }
            }
        }
        private string _AreaCode;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.TestPhoneCompoundObject, string> OnAreaCode_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TestPhoneCompoundObject, string> OnAreaCode_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TestPhoneCompoundObject, string> OnAreaCode_PostSetter;

        /// <summary>
        /// Enter a Number
        /// </summary>
        // value type property
        // BEGIN Zetbox.Generator.Templates.Properties.NotifyingDataProperty
        public string Number
        {
            get
            {
                // create local variable to create single point of return
                // for the benefit of down-stream templates
                var __result = _Number;
                if (OnNumber_Getter != null)
                {
                    var __e = new PropertyGetterEventArgs<string>(__result);
                    OnNumber_Getter(this, __e);
                    __result = _Number = __e.Result;
                }
                return __result;
            }
            set
            {
                if (this.IsReadonly) throw new ReadOnlyObjectException();
                if (_Number != value)
                {
                    var __oldValue = _Number;
                    var __newValue = value;
                    if (OnNumber_PreSetter != null && IsAttached)
                    {
                        var __e = new PropertyPreSetterEventArgs<string>(__oldValue, __newValue);
                        OnNumber_PreSetter(this, __e);
                        __newValue = __e.Result;
                    }
                    NotifyPropertyChanging("Number", __oldValue, __newValue);
                    _Number = __newValue;
                    NotifyPropertyChanged("Number", __oldValue, __newValue);
                    if(IsAttached) UpdateChangedInfo = true;

                    if (OnNumber_PostSetter != null && IsAttached)
                    {
                        var __e = new PropertyPostSetterEventArgs<string>(__oldValue, __newValue);
                        OnNumber_PostSetter(this, __e);
                    }
                }
                else
                {
                    SetInitializedProperty("Number");
                }
            }
        }
        private string _Number;
        // END Zetbox.Generator.Templates.Properties.NotifyingDataProperty
		public static event PropertyGetterHandler<Zetbox.App.Test.TestPhoneCompoundObject, string> OnNumber_Getter;
		public static event PropertyPreSetterHandler<Zetbox.App.Test.TestPhoneCompoundObject, string> OnNumber_PreSetter;
		public static event PropertyPostSetterHandler<Zetbox.App.Test.TestPhoneCompoundObject, string> OnNumber_PostSetter;

        public override Type GetImplementedInterface()
        {
            return typeof(TestPhoneCompoundObject);
        }

        public override void ApplyChangesFrom(ICompoundObject obj)
        {
            base.ApplyChangesFrom(obj);
            var other = (TestPhoneCompoundObject)obj;
            var otherImpl = (TestPhoneCompoundObjectNHibernateImpl)obj;
            var me = (TestPhoneCompoundObject)this;

            me.AreaCode = other.AreaCode;
            me.Number = other.Number;
        }
        #region Zetbox.Generator.Templates.CompoundObjects.DefaultMethods

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_TestPhoneCompoundObject")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_TestPhoneCompoundObject != null)
            {
                OnToString_TestPhoneCompoundObject(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<TestPhoneCompoundObject> OnToString_TestPhoneCompoundObject;

		[System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnObjectIsValid_TestPhoneCompoundObject")]
        protected override ObjectIsValidResult ObjectIsValid()
        {
            ObjectIsValidEventArgs e = new ObjectIsValidEventArgs();
			var b = base.ObjectIsValid();
			e.Errors.AddRange(b.Errors);
            if (OnObjectIsValid_TestPhoneCompoundObject != null)
            {
                OnObjectIsValid_TestPhoneCompoundObject(this, e);
            }
            return new ObjectIsValidResult(e.IsValid, e.Errors);
        }
        public static event ObjectIsValidHandler<TestPhoneCompoundObject> OnObjectIsValid_TestPhoneCompoundObject;

        #endregion // Zetbox.Generator.Templates.CompoundObjects.DefaultMethods
public class TestPhoneCompoundObjectProxy { }

        #region Serializer


        public override void ToStream(Zetbox.API.ZetboxStreamWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            base.ToStream(binStream, auxObjects, eagerLoadLists);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            binStream.Write(this._AreaCode);
            binStream.Write(this._Number);
        }

        public override IEnumerable<IPersistenceObject> FromStream(Zetbox.API.ZetboxStreamReader binStream)
        {
            var baseResult = base.FromStream(binStream);
            var result = new List<IPersistenceObject>();
            // it may be only an empty shell to stand-in for unreadable data
            if (CurrentAccessRights != Zetbox.API.AccessRights.None) {
            this._AreaCode = binStream.ReadString();
            this._Number = binStream.ReadString();
            } // if (CurrentAccessRights != Zetbox.API.AccessRights.None)
            return baseResult == null
                ? result.Count == 0
                    ? null
                    : result
                : baseResult.Concat(result);
        }

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
            base.Export(xml, modules);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Test")) XmlStreamer.ToStream(this._AreaCode, xml, "AreaCode", "Zetbox.App.Test");
            if (modules.Contains("*") || modules.Contains("Zetbox.App.Test")) XmlStreamer.ToStream(this._Number, xml, "Number", "Zetbox.App.Test");
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
            base.MergeImport(xml);
            // it may be only an empty shell to stand-in for unreadable data
            if (!CurrentAccessRights.HasReadRights()) return;
            switch (xml.NamespaceURI + "|" + xml.LocalName) {
            case "Zetbox.App.Test|AreaCode":
                this._AreaCode = XmlStreamer.ReadString(xml);
                break;
            case "Zetbox.App.Test|Number":
                this._Number = XmlStreamer.ReadString(xml);
                break;
            }
        }

        #endregion

    }
}