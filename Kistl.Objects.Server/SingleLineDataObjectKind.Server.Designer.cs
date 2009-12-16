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
    /// Presents a data object in a single line
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="SingleLineDataObjectKind")]
    [System.Diagnostics.DebuggerDisplay("SingleLineDataObjectKind")]
    public class SingleLineDataObjectKind__Implementation__ : Kistl.App.GUI.ControlKind__Implementation__, SingleLineDataObjectKind
    {
    
		public SingleLineDataObjectKind__Implementation__()
		{
        }


		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(SingleLineDataObjectKind));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (SingleLineDataObjectKind)obj;
			var otherImpl = (SingleLineDataObjectKind__Implementation__)obj;
			var me = (SingleLineDataObjectKind)this;

		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_SingleLineDataObjectKind")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_SingleLineDataObjectKind != null)
            {
                OnToString_SingleLineDataObjectKind(this, e);
            }
            return e.Result;
        }
        public static event ToStringHandler<SingleLineDataObjectKind> OnToString_SingleLineDataObjectKind;

        [EventBasedMethod("OnPreSave_SingleLineDataObjectKind")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_SingleLineDataObjectKind != null) OnPreSave_SingleLineDataObjectKind(this);
        }
        public static event ObjectEventHandler<SingleLineDataObjectKind> OnPreSave_SingleLineDataObjectKind;

        [EventBasedMethod("OnPostSave_SingleLineDataObjectKind")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_SingleLineDataObjectKind != null) OnPostSave_SingleLineDataObjectKind(this);
        }
        public static event ObjectEventHandler<SingleLineDataObjectKind> OnPostSave_SingleLineDataObjectKind;

        [EventBasedMethod("OnCreated_SingleLineDataObjectKind")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_SingleLineDataObjectKind != null) OnCreated_SingleLineDataObjectKind(this);
        }
        public static event ObjectEventHandler<SingleLineDataObjectKind> OnCreated_SingleLineDataObjectKind;

        [EventBasedMethod("OnDeleting_SingleLineDataObjectKind")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_SingleLineDataObjectKind != null) OnDeleting_SingleLineDataObjectKind(this);
        }
        public static event ObjectEventHandler<SingleLineDataObjectKind> OnDeleting_SingleLineDataObjectKind;



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