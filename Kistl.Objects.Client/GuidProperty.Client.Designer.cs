
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

    using Kistl.API.Client;
    using Kistl.DalProvider.ClientObjects;

    /// <summary>
    /// Guid Property
    /// </summary>
    [System.Diagnostics.DebuggerDisplay("GuidProperty")]
    public class GuidProperty__Implementation__ : Kistl.App.Base.ValueTypeProperty__Implementation__, GuidProperty
    {
    
		public GuidProperty__Implementation__()
		{
            {
            }
        }


        /// <summary>
        /// Returns the resulting Type of this Property Meta Object.
        /// </summary>

		public override System.Type GetPropertyType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetPropertyType_GuidProperty != null)
            {
                OnGetPropertyType_GuidProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyType();
            }
            return e.Result;
        }
		public event GetPropertyType_Handler<GuidProperty> OnGetPropertyType_GuidProperty;



        /// <summary>
        /// Returns the String representation of this Property Meta Object.
        /// </summary>

		public override string GetPropertyTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetPropertyTypeString_GuidProperty != null)
            {
                OnGetPropertyTypeString_GuidProperty(this, e);
            }
            else
            {
                e.Result = base.GetPropertyTypeString();
            }
            return e.Result;
        }
		public event GetPropertyTypeString_Handler<GuidProperty> OnGetPropertyTypeString_GuidProperty;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(GuidProperty));
		}

		public override void ApplyChangesFrom(IPersistenceObject obj)
		{
			base.ApplyChangesFrom(obj);
			var other = (GuidProperty)obj;
			var otherImpl = (GuidProperty__Implementation__)obj;
			var me = (GuidProperty)this;

		}

        public override void AttachToContext(IKistlContext ctx)
        {
            base.AttachToContext(ctx);
		}

        // tail template

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_GuidProperty != null)
            {
                OnToString_GuidProperty(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<GuidProperty> OnToString_GuidProperty;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_GuidProperty != null) OnPreSave_GuidProperty(this);
        }
        public event ObjectEventHandler<GuidProperty> OnPreSave_GuidProperty;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_GuidProperty != null) OnPostSave_GuidProperty(this);
        }
        public event ObjectEventHandler<GuidProperty> OnPostSave_GuidProperty;



		public override void UpdateParent(string propertyName, int? id)
		{
			switch(propertyName)
			{
				default:
					base.UpdateParent(propertyName, id);
					break;
			}
		}

#region Serializer


        public override void ToStream(System.IO.BinaryWriter binStream)
        {
            base.ToStream(binStream);
        }

        public override void FromStream(System.IO.BinaryReader binStream)
        {
            base.FromStream(binStream);
        }

        public override void ToStream(System.Xml.XmlWriter xml, string[] modules)
        {
            base.ToStream(xml, modules);
        }

        public override void FromStream(System.Xml.XmlReader xml)
        {
            base.FromStream(xml);
        }

#endregion

    }


}