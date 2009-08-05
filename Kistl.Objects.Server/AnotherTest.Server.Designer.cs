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

    using Kistl.API.Server;
    using Kistl.DALProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// 
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="AnotherTest")]
    [System.Diagnostics.DebuggerDisplay("AnotherTest")]
    public class AnotherTest__Implementation__ : BaseServerDataObject_EntityFramework, AnotherTest
    {
    
		public AnotherTest__Implementation__()
		{
        }

        [EdmScalarProperty(EntityKeyProperty=true, IsNullable=false)]
   		// Kistl.Server.Generators.EntityFramework.Implementation.ObjectClasses.IdProperty
        public override int ID
        {
            get
            {
				return _ID;
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
            }
        }
        private int _ID;

		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(AnotherTest));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (AnotherTest)obj;
			var otherImpl = (AnotherTest__Implementation__)obj;
			var me = (AnotherTest)this;

		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_AnotherTest")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_AnotherTest != null)
            {
                OnToString_AnotherTest(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<AnotherTest> OnToString_AnotherTest;

        [EventBasedMethod("OnPreSave_AnotherTest")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_AnotherTest != null) OnPreSave_AnotherTest(this);
        }
        public event ObjectEventHandler<AnotherTest> OnPreSave_AnotherTest;

        [EventBasedMethod("OnPostSave_AnotherTest")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_AnotherTest != null) OnPostSave_AnotherTest(this);
        }
        public event ObjectEventHandler<AnotherTest> OnPostSave_AnotherTest;

        [EventBasedMethod("OnCreated_AnotherTest")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_AnotherTest != null) OnCreated_AnotherTest(this);
        }
        public event ObjectEventHandler<AnotherTest> OnCreated_AnotherTest;

        [EventBasedMethod("OnDeleting_AnotherTest")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_AnotherTest != null) OnDeleting_AnotherTest(this);
        }
        public event ObjectEventHandler<AnotherTest> OnDeleting_AnotherTest;



		public override void ReloadReferences()
		{
			// fix direct object references
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects)
        {
			
            base.ToStream(binStream, auxObjects);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
			
            base.FromStream(binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml)
        {
			
            base.ToStream(xml);
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
			
            base.FromStream(xml);
        }

#endregion

    }


}