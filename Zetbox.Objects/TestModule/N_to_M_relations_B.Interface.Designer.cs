// <autogenerated/>

namespace Zetbox.App.Test
{
    using System;
    using System.Collections.Generic;

    using Zetbox.API;

    /// <summary>
    /// The B-Side class for the N_to_M_relations Tests
    /// </summary>
    [Zetbox.API.DefinitionGuid("c2af3719-d63a-4a94-9cc8-b4f94bb253ff")]
    public interface N_to_M_relations_B : IDataObject 
    {

        /// <summary>
        /// 
        /// </summary>

        [Zetbox.API.DefinitionGuid("a741d6bd-8a87-44c2-83b3-69225661f958")]
        ICollection<Zetbox.App.Test.N_to_M_relations_A> ASide { get; }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("80ec9efe-c73b-4554-a145-064a32f225b8")]
        string Name {
            get;
            set;
        }
    }
}