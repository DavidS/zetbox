// <autogenerated/>

namespace Zetbox.App.Base
{
    using System;
    using System.Collections.Generic;

    using Zetbox.API;

    /// <summary>
    /// Metadefinition Object for DateTime Properties.
    /// </summary>
    [Zetbox.API.DefinitionGuid("1caadf11-7b95-4c68-8b42-87ac51b01ea0")]
    public interface DateTimeProperty : Zetbox.App.Base.ValueTypeProperty 
    {

        /// <summary>
        /// Style of Datetime. Can be Date, Date and Time or Time
        /// </summary>
        [Zetbox.API.DefinitionGuid("76b04254-3911-4753-ba11-cb1af074b056")]
        Zetbox.App.Base.DateTimeStyles? DateTimeStyle {
            get;
            set;
        }

    }
}
