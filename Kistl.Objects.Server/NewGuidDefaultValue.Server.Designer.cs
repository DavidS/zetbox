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

    using Kistl.API.Server;
    using Kistl.DALProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// Creates a new Guid
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="NewGuidDefaultValue")]
    [System.Diagnostics.DebuggerDisplay("NewGuidDefaultValue")]
    public class NewGuidDefaultValue__Implementation__ : Kistl.App.Base.DefaultPropertyValue__Implementation__, NewGuidDefaultValue
    {
    
		public NewGuidDefaultValue__Implementation__()
		{
        }


        /// <summary>
        /// GetDefaultValue
        /// </summary>

		public override System.Object GetDefaultValue() 
        {
            var e = new MethodReturnEventArgs<System.Object>();
            if (OnGetDefaultValue_NewGuidDefaultValue != null)
            {
                OnGetDefaultValue_NewGuidDefaultValue(this, e);
            }
            else
            {
                e.Result = base.GetDefaultValue();
            }
            return e.Result;
        }
		public event GetDefaultValue_Handler<NewGuidDefaultValue> OnGetDefaultValue_NewGuidDefaultValue;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(NewGuidDefaultValue));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (NewGuidDefaultValue)obj;
			var otherImpl = (NewGuidDefaultValue__Implementation__)obj;
			var me = (NewGuidDefaultValue)this;

		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_NewGuidDefaultValue != null)
            {
                OnToString_NewGuidDefaultValue(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<NewGuidDefaultValue> OnToString_NewGuidDefaultValue;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_NewGuidDefaultValue != null) OnPreSave_NewGuidDefaultValue(this);
        }
        public event ObjectEventHandler<NewGuidDefaultValue> OnPreSave_NewGuidDefaultValue;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_NewGuidDefaultValue != null) OnPostSave_NewGuidDefaultValue(this);
        }
        public event ObjectEventHandler<NewGuidDefaultValue> OnPostSave_NewGuidDefaultValue;

        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_NewGuidDefaultValue != null) OnCreated_NewGuidDefaultValue(this);
        }
        public event ObjectEventHandler<NewGuidDefaultValue> OnCreated_NewGuidDefaultValue;

        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_NewGuidDefaultValue != null) OnDeleting_NewGuidDefaultValue(this);
        }
        public event ObjectEventHandler<NewGuidDefaultValue> OnDeleting_NewGuidDefaultValue;



		public override void ReloadReferences()
		{
			base.ReloadReferences();
			
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

        public override void Export(System.Xml.XmlWriter xml, string[] modules)
        {
			
            base.Export(xml, modules);
        }

        public override void MergeImport(System.Xml.XmlReader xml)
        {
			
            base.MergeImport(xml);
        }

#endregion

    }


}