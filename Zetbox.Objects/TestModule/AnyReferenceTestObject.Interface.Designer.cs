// <autogenerated/>

namespace Zetbox.App.Test
{
    using System;
    using System.Collections.Generic;

    using Zetbox.API;

    /// <summary>
    /// 
    /// </summary>
    [Zetbox.API.DefinitionGuid("3a8d152e-b8d1-4439-bfe4-367731218ce9")]
    public interface AnyReferenceTestObject : IDataObject, Zetbox.App.Base.IExportable 
    {

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("de93b394-d1e8-4c17-a1df-30aaff7f27f5")]
        Zetbox.App.Base.AnyReference Any {
            get;
            set;
        }


        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("3e806c0f-5ef0-47d1-b504-47b5d2dd59fb")]
        string DisplayName {
            get;
            set;
        }

    }
}
