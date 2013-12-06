// <autogenerated/>

namespace Zetbox.App.Test
{
    using System;
    using System.Collections.Generic;

    using Zetbox.API;

    /// <summary>
    /// a test class for ordered lists
    /// </summary>
    [Zetbox.API.DefinitionGuid("c887def0-a835-497d-992e-ff0bb7463280")]
    public interface One_to_N_relations_OrderedN : IDataObject 
    {

        /// <summary>
        /// A property to test queries across the Relation
        /// </summary>
        [Zetbox.API.DefinitionGuid("3ed99412-d4c8-44af-8ed6-dfcd28532a93")]
        string Name {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("8073d6a1-4c8b-4789-82f4-f983ec706397")]
        Zetbox.App.Test.One_to_N_relations_One OneSide {
            get;
            set;
        }
    }
}
