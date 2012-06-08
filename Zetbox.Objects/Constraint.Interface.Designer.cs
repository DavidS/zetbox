// <autogenerated/>

namespace Zetbox.App.Base
{
    using System;
    using System.Collections.Generic;

    using Zetbox.API;

    /// <summary>
    /// 
    /// </summary>
    [Zetbox.API.DefinitionGuid("ac1d5ac9-d909-438f-a4f5-f64ea6904944")]
    public interface Constraint : IDataObject, Zetbox.App.Base.IChangedBy, Zetbox.App.Base.IExportable 
    {

        /// <summary>
        /// The property to be constrained
        /// </summary>
        [Zetbox.API.DefinitionGuid("438b9307-fb40-4afe-a66f-a5762c41e14b")]
        Zetbox.App.Base.Property ConstrainedProperty {
            get;
            set;
        }

        /// <summary>
        /// The reason of this constraint
        /// </summary>
        [Zetbox.API.DefinitionGuid("49f759b3-de60-4cee-be06-c712e901c24e")]
        string Reason {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        string GetErrorText(System.Object constrainedObject, System.Object constrainedValue);

        /// <summary>
        /// 
        /// </summary>
        bool IsValid(System.Object constrainedObject, System.Object constrainedValue);
    }
}
