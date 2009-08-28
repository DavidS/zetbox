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
    /// Displays a complete DataObject with all its properties
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="DataObjectKind")]
    [System.Diagnostics.DebuggerDisplay("DataObjectKind")]
    public class DataObjectKind__Implementation__ : Kistl.App.GUI.ControlKind__Implementation__, DataObjectKind
    {
    
		public DataObjectKind__Implementation__()
		{
        }


		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(DataObjectKind));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (DataObjectKind)obj;
			var otherImpl = (DataObjectKind__Implementation__)obj;
			var me = (DataObjectKind)this;

		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_DataObjectKind")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_DataObjectKind != null)
            {
                OnToString_DataObjectKind(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<DataObjectKind> OnToString_DataObjectKind;

        [EventBasedMethod("OnPreSave_DataObjectKind")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_DataObjectKind != null) OnPreSave_DataObjectKind(this);
        }
        public event ObjectEventHandler<DataObjectKind> OnPreSave_DataObjectKind;

        [EventBasedMethod("OnPostSave_DataObjectKind")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_DataObjectKind != null) OnPostSave_DataObjectKind(this);
        }
        public event ObjectEventHandler<DataObjectKind> OnPostSave_DataObjectKind;

        [EventBasedMethod("OnCreated_DataObjectKind")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_DataObjectKind != null) OnCreated_DataObjectKind(this);
        }
        public event ObjectEventHandler<DataObjectKind> OnCreated_DataObjectKind;

        [EventBasedMethod("OnDeleting_DataObjectKind")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_DataObjectKind != null) OnDeleting_DataObjectKind(this);
        }
        public event ObjectEventHandler<DataObjectKind> OnDeleting_DataObjectKind;



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