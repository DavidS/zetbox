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
    /// The basic workspace where multiple objects can be edited
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="WorkspaceKind")]
    [System.Diagnostics.DebuggerDisplay("WorkspaceKind")]
    public class WorkspaceKind__Implementation__ : Kistl.App.GUI.ControlKind__Implementation__, WorkspaceKind
    {
    
		public WorkspaceKind__Implementation__()
		{
        }


		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(WorkspaceKind));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (WorkspaceKind)obj;
			var otherImpl = (WorkspaceKind__Implementation__)obj;
			var me = (WorkspaceKind)this;

		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_WorkspaceKind")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_WorkspaceKind != null)
            {
                OnToString_WorkspaceKind(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<WorkspaceKind> OnToString_WorkspaceKind;

        [EventBasedMethod("OnPreSave_WorkspaceKind")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_WorkspaceKind != null) OnPreSave_WorkspaceKind(this);
        }
        public event ObjectEventHandler<WorkspaceKind> OnPreSave_WorkspaceKind;

        [EventBasedMethod("OnPostSave_WorkspaceKind")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_WorkspaceKind != null) OnPostSave_WorkspaceKind(this);
        }
        public event ObjectEventHandler<WorkspaceKind> OnPostSave_WorkspaceKind;

        [EventBasedMethod("OnCreated_WorkspaceKind")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_WorkspaceKind != null) OnCreated_WorkspaceKind(this);
        }
        public event ObjectEventHandler<WorkspaceKind> OnCreated_WorkspaceKind;

        [EventBasedMethod("OnDeleting_WorkspaceKind")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_WorkspaceKind != null) OnDeleting_WorkspaceKind(this);
        }
        public event ObjectEventHandler<WorkspaceKind> OnDeleting_WorkspaceKind;



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