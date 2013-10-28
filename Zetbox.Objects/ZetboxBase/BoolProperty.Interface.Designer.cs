// <autogenerated/>

namespace Zetbox.App.Base
{
    using System;
    using System.Collections.Generic;

    using Zetbox.API;

    /// <summary>
    /// Metadefinition Object for Bool Properties.
    /// </summary>
    [Zetbox.API.DefinitionGuid("3604a7b6-dffb-44ee-8464-5f292d7a0687")]
    public interface BoolProperty : Zetbox.App.Base.ValueTypeProperty 
    {

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("784846d0-2eea-4966-b63d-72a0f13b418b")]
        Zetbox.App.GUI.Icon FalseIcon {
            get;
            set;
        }

        /// <summary>
        /// A string to describe the &quot;false&quot; value to the user.
        /// </summary>
        [Zetbox.API.DefinitionGuid("09381f52-98e2-4dea-9855-7358e5f9cdae")]
        string FalseLabel {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("62454172-467d-4c8e-8f1a-a959946d3fdb")]
        Zetbox.App.GUI.Icon NullIcon {
            get;
            set;
        }

        /// <summary>
        /// A string to describe the &quot;null&quot; value to the user.
        /// </summary>
        [Zetbox.API.DefinitionGuid("55fae41e-499d-40e3-b386-9839ec8b1d0a")]
        string NullLabel {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("bb8fd69f-437a-45d5-a169-64c9586bfc1d")]
        Zetbox.App.GUI.Icon TrueIcon {
            get;
            set;
        }

        /// <summary>
        /// A string to describe the &quot;true&quot; value to the user.
        /// </summary>
        [Zetbox.API.DefinitionGuid("f7da0495-3d3f-48c5-8fba-95a317ca7949")]
        string TrueLabel {
            get;
            set;
        }
    }
}