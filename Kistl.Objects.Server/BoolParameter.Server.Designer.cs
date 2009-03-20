
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
    /// Metadefinition Object for Bool Parameter.
    /// </summary>
    [EdmEntityType(NamespaceName="Model", Name="BoolParameter")]
    [System.Diagnostics.DebuggerDisplay("BoolParameter")]
    public class BoolParameter__Implementation__ : Kistl.App.Base.BaseParameter__Implementation__, BoolParameter
    {


        /// <summary>
        /// Returns the resulting Type of this Method-Parameter Meta Object.
        /// </summary>

		public override System.Type GetParameterType() 
        {
            var e = new MethodReturnEventArgs<System.Type>();
            if (OnGetParameterType_BoolParameter != null)
            {
                OnGetParameterType_BoolParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterType();
            }
            return e.Result;
        }
		public event GetParameterType_Handler<BoolParameter> OnGetParameterType_BoolParameter;



        /// <summary>
        /// Returns the String representation of this Method-Parameter Meta Object.
        /// </summary>

		public override string GetParameterTypeString() 
        {
            var e = new MethodReturnEventArgs<string>();
            if (OnGetParameterTypeString_BoolParameter != null)
            {
                OnGetParameterTypeString_BoolParameter(this, e);
            }
            else
            {
                e.Result = base.GetParameterTypeString();
            }
            return e.Result;
        }
		public event GetParameterTypeString_Handler<BoolParameter> OnGetParameterTypeString_BoolParameter;



		public override InterfaceType GetInterfaceType()
		{
			return new InterfaceType(typeof(BoolParameter));
		}

        // tail template

        [System.Diagnostics.DebuggerHidden()]
        public override string ToString()
        {
            MethodReturnEventArgs<string> e = new MethodReturnEventArgs<string>();
            e.Result = base.ToString();
            if (OnToString_BoolParameter != null)
            {
                OnToString_BoolParameter(this, e);
            }
            return e.Result;
        }
        public event ToStringHandler<BoolParameter> OnToString_BoolParameter;

        public override void NotifyPreSave()
        {
            base.NotifyPreSave();
            if (OnPreSave_BoolParameter != null) OnPreSave_BoolParameter(this);
        }
        public event ObjectEventHandler<BoolParameter> OnPreSave_BoolParameter;

        public override void NotifyPostSave()
        {
            base.NotifyPostSave();
            if (OnPostSave_BoolParameter != null) OnPostSave_BoolParameter(this);
        }
        public event ObjectEventHandler<BoolParameter> OnPostSave_BoolParameter;



		public override void ReloadReferences()
		{
			base.ReloadReferences();
			
			// fix direct object references
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

#endregion

    }


}