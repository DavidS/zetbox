// <autogenerated/>

namespace Zetbox.App.Calendar
{
    using System;
    using System.Collections.Generic;

    using Zetbox.API;

    /// <summary>
    /// A calendar event
    /// </summary>
    [Zetbox.API.DefinitionGuid("fd0b9bf4-0891-4317-9d2e-d08a410d5c4c")]
    public interface Event : IDataObject, Zetbox.App.Base.IChangedBy, Zetbox.App.Base.IExportable 
    {

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("db075997-89bd-4b98-bf60-40eecebfc664")]
        string Body {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("d80b3380-9cc2-4237-960c-9cd409d793e3")]
        Zetbox.App.Calendar.Calendar Calendar {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("b8dd3910-ffaa-49dd-8e00-e80575e15cab")]
        DateTime EndDate {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("d8ddeb5c-7c5d-4780-8540-857932cb3813")]
        bool IsAllDay {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("3c517754-f4a4-459e-8a24-3b85e1949b21")]
        string Location {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("2eb0c6f4-c5bc-4b9a-8677-ec2598c74beb")]
        Zetbox.App.Base.RecurrenceRule Recurrence {
            get;
            set;
        }

        /// <summary>
        /// A attached data item
        /// </summary>
        [Zetbox.API.DefinitionGuid("086bf775-297d-49bf-be32-95b19f5eda8a")]
        Zetbox.App.Base.AnyReference Source {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("93bf17bd-4dfb-468d-84d4-75fce8214fa3")]
        DateTime StartDate {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("e0cbb876-3119-4e90-afc5-6e97b67e2005")]
        string Summary {
            get;
            set;
        }

        /// <summary>
        /// A hash used by a sync provider
        /// </summary>
        [Zetbox.API.DefinitionGuid("b9095bc6-a8cb-422e-8320-e1c07c8c6252")]
        string SyncHash {
            get;
            set;
        }
    }
}