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
    /// Checks whether a Navigator on a RelationEnd is consistent with the Relation's definition
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="ConsistentNavigatorConstraint")]
    [System.Diagnostics.DebuggerDisplay("ConsistentNavigatorConstraint")]
    public class ConsistentNavigatorConstraint__Implementation__ : Kistl.App.Base.Constraint__Implementation__, ConsistentNavigatorConstraint
    {
    
		public ConsistentNavigatorConstraint__Implementation__()
		{
        }


        /// <summary>
        /// 
        /// </summary>
		[EventBasedMethod("OnGetErrorText_ConsistentNavigatorConstraint")]
		public override string GetErrorText(System.Object constrainedObject, System.Object constrainedValue) 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetErrorText_ConsistentNavigatorConstraint != null)
            {
                OnGetErrorText_ConsistentNavigatorConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.GetErrorText(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
		public event GetErrorText_Handler<ConsistentNavigatorConstraint> OnGetErrorText_ConsistentNavigatorConstraint;



        /// <summary>
        /// 
        /// </summary>
		[EventBasedMethod("OnIsValid_ConsistentNavigatorConstraint")]
		public override bool IsValid(System.Object constrainedObject, System.Object constrainedValue) 
        {
            var e = new MethodReturnEventArgs<bool>();
            if (OnIsValid_ConsistentNavigatorConstraint != null)
            {
                OnIsValid_ConsistentNavigatorConstraint(this, e, constrainedObject, constrainedValue);
            }
            else
            {
                e.Result = base.IsValid(constrainedObject, constrainedValue);
            }
            return e.Result;
        }
		public event IsValid_Handler<ConsistentNavigatorConstraint> OnIsValid_ConsistentNavigatorConstraint;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(ConsistentNavigatorConstraint));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (ConsistentNavigatorConstraint)obj;
			var otherImpl = (ConsistentNavigatorConstraint__Implementation__)obj;
			var me = (ConsistentNavigatorConstraint)this;

		}

        // tail template
   		// Kistl.Server.Generators.Templates.Implementation.ObjectClasses.Tail

        [System.Diagnostics.DebuggerHidden()]
        [EventBasedMethod("OnToString_ConsistentNavigatorConstraint")]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_ConsistentNavigatorConstraint != null)
            {
                OnToString_ConsistentNavigatorConstraint(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<ConsistentNavigatorConstraint> OnToString_ConsistentNavigatorConstraint;

        [EventBasedMethod("OnPreSave_ConsistentNavigatorConstraint")]
        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_ConsistentNavigatorConstraint != null) OnPreSave_ConsistentNavigatorConstraint(this);
        }
        public event ObjectEventHandler<ConsistentNavigatorConstraint> OnPreSave_ConsistentNavigatorConstraint;

        [EventBasedMethod("OnPostSave_ConsistentNavigatorConstraint")]
        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_ConsistentNavigatorConstraint != null) OnPostSave_ConsistentNavigatorConstraint(this);
        }
        public event ObjectEventHandler<ConsistentNavigatorConstraint> OnPostSave_ConsistentNavigatorConstraint;

        [EventBasedMethod("OnCreated_ConsistentNavigatorConstraint")]
        public override void NotifyCreated()
        {
            base.NotifyCreated();
            if (OnCreated_ConsistentNavigatorConstraint != null) OnCreated_ConsistentNavigatorConstraint(this);
        }
        public event ObjectEventHandler<ConsistentNavigatorConstraint> OnCreated_ConsistentNavigatorConstraint;

        [EventBasedMethod("OnDeleting_ConsistentNavigatorConstraint")]
        public override void NotifyDeleting()
        {
            base.NotifyDeleting();
            if (OnDeleting_ConsistentNavigatorConstraint != null) OnDeleting_ConsistentNavigatorConstraint(this);
        }
        public event ObjectEventHandler<ConsistentNavigatorConstraint> OnDeleting_ConsistentNavigatorConstraint;



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