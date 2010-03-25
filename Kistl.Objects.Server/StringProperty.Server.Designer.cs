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
    using Kistl.DalProvider.EF;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;

    /// <summary>
    /// Metadefinition Object for String Properties.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="StringProperty")]
    [System.Diagnostics.DebuggerDisplay("StringProperty")]
    public class StringProperty__Implementation__ : Kistl.App.Base.ValueTypeProperty__Implementation__, StringProperty
    {
    
		public StringProperty__Implementation__()
		{
        }


        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetPropertyType_StringProperty")]
		public override System.Type GetPropertyType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_StringProperty != null)
            {
                OnGetPropertyType_StringProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
		public static event GetPropertyType_Handler<StringProperty> OnGetPropertyType_StringProperty;



        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>
		[EventBasedMethod("OnGetPropertyTypeString_StringProperty")]
		public override string GetPropertyTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_StringProperty != null)
            {
                OnGetPropertyTypeString_StringProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
		public static event GetPropertyTypeString_Handler<StringProperty> OnGetPropertyTypeString_StringProperty;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(StringProperty));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (StringProperty)obj;
			var otherImpl = (StringProperty__Implementation__)obj;
			var me = (StringProperty)this;

		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_StringProperty")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_StringProperty != null)
            {
                OnToString_StringProperty(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<StringProperty> OnToString_StringProperty;

        [EventBasedMethod("OnPreSave_StringProperty")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_StringProperty != null) OnPreSave_StringProperty(this);
        }
        public static event ObjectEventHandler<StringProperty> OnPreSave_StringProperty;

        [EventBasedMethod("OnPostSave_StringProperty")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_StringProperty != null) OnPostSave_StringProperty(this);
        }
        public static event ObjectEventHandler<StringProperty> OnPostSave_StringProperty;

        [EventBasedMethod("OnCreated_StringProperty")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_StringProperty != null) OnCreated_StringProperty(this);
        }
        public static event ObjectEventHandler<StringProperty> OnCreated_StringProperty;

        [EventBasedMethod("OnDeleting_StringProperty")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_StringProperty != null) OnDeleting_StringProperty(this);
        }
        public static event ObjectEventHandler<StringProperty> OnDeleting_StringProperty;


	

		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
			base.ReloadReferences();
			
			// fix direct object references
		}
#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream, HashSet<IStreamable> auxObjects, bool eagerLoadLists)
        {
            
            base.ToStream(binStream, auxObjects, eagerLoadLists);
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