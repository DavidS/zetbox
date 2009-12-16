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
    /// A simple read-only label
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="LabelKind")]
    [System.Diagnostics.DebuggerDisplay("LabelKind")]
    public class LabelKind__Implementation__ : Kistl.App.GUI.ControlKind__Implementation__, LabelKind
    {
    
		public LabelKind__Implementation__()
		{
        }


		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(LabelKind));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (LabelKind)obj;
			var otherImpl = (LabelKind__Implementation__)obj;
			var me = (LabelKind)this;

		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_LabelKind")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_LabelKind != null)
            {
                OnToString_LabelKind(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<LabelKind> OnToString_LabelKind;

        [EventBasedMethod("OnPreSave_LabelKind")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_LabelKind != null) OnPreSave_LabelKind(this);
        }
        public static event ObjectEventHandler<LabelKind> OnPreSave_LabelKind;

        [EventBasedMethod("OnPostSave_LabelKind")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_LabelKind != null) OnPostSave_LabelKind(this);
        }
        public static event ObjectEventHandler<LabelKind> OnPostSave_LabelKind;

        [EventBasedMethod("OnCreated_LabelKind")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_LabelKind != null) OnCreated_LabelKind(this);
        }
        public static event ObjectEventHandler<LabelKind> OnCreated_LabelKind;

        [EventBasedMethod("OnDeleting_LabelKind")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_LabelKind != null) OnDeleting_LabelKind(this);
        }
        public static event ObjectEventHandler<LabelKind> OnDeleting_LabelKind;



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