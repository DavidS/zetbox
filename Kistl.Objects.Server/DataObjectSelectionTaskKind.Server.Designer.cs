// <autogenerated/>


namespace Kistl.App.GUI
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
    /// Choose a data object from a set of values
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="DataObjectSelectionTaskKind")]
    [System.Diagnostics.DebuggerDisplay("DataObjectSelectionTaskKind")]
    public class DataObjectSelectionTaskKind__Implementation__ : Kistl.App.GUI.ControlKind__Implementation__, DataObjectSelectionTaskKind
    {
    
		public DataObjectSelectionTaskKind__Implementation__()
		{
        }


		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(DataObjectSelectionTaskKind));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (DataObjectSelectionTaskKind)obj;
			var otherImpl = (DataObjectSelectionTaskKind__Implementation__)obj;
			var me = (DataObjectSelectionTaskKind)this;

		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_DataObjectSelectionTaskKind")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DataObjectSelectionTaskKind != null)
            {
                OnToString_DataObjectSelectionTaskKind(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<DataObjectSelectionTaskKind> OnToString_DataObjectSelectionTaskKind;

        [EventBasedMethod("OnPreSave_DataObjectSelectionTaskKind")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DataObjectSelectionTaskKind != null) OnPreSave_DataObjectSelectionTaskKind(this);
        }
        public static event ObjectEventHandler<DataObjectSelectionTaskKind> OnPreSave_DataObjectSelectionTaskKind;

        [EventBasedMethod("OnPostSave_DataObjectSelectionTaskKind")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DataObjectSelectionTaskKind != null) OnPostSave_DataObjectSelectionTaskKind(this);
        }
        public static event ObjectEventHandler<DataObjectSelectionTaskKind> OnPostSave_DataObjectSelectionTaskKind;

        [EventBasedMethod("OnCreated_DataObjectSelectionTaskKind")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_DataObjectSelectionTaskKind != null) OnCreated_DataObjectSelectionTaskKind(this);
        }
        public static event ObjectEventHandler<DataObjectSelectionTaskKind> OnCreated_DataObjectSelectionTaskKind;

        [EventBasedMethod("OnDeleting_DataObjectSelectionTaskKind")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_DataObjectSelectionTaskKind != null) OnDeleting_DataObjectSelectionTaskKind(this);
        }
        public static event ObjectEventHandler<DataObjectSelectionTaskKind> OnDeleting_DataObjectSelectionTaskKind;



		public override void ReloadReferences()
		{
			// Do not reload references if the current object has been deleted.
			// TODO: enable when MemoryContext uses MemoryDataObjects
			//if (this.ObjectState == DataObjectState.Deleted) return;
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