// <autogenerated/>

namespace Zetbox.App.Base
{
    using System;
    using System.Collections.Generic;

    using Zetbox.API;

    /// <summary>
    /// 
    /// </summary>
    [Zetbox.API.DefinitionGuid("6efc1387-cffc-4cff-9af3-19365d888f4b")]
    public interface SequenceData : IDataObject 
    {

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("e557569b-1ed8-49a6-959e-0a6bc3ffa591")]
        int CurrentNumber {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("98a20549-d4ff-4caf-bae2-10951b04c6f1")]
        Zetbox.App.Base.Sequence Sequence {
            get;
            set;
        }
    }
}