// <autogenerated/>

namespace Zetbox.App.Test
{
    using System;
    using System.Collections.Generic;

    using Zetbox.API;

    /// <summary>
    /// 
    /// </summary>
    [Zetbox.API.DefinitionGuid("fd357e42-2c2c-4bef-8110-69a466d09af0")]
    public interface Muhblah : IDataObject 
    {

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("9206e71e-85ea-4d74-85ea-59ee2484ed2a")]
        bool? TestBool {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>

        [Zetbox.API.DefinitionGuid("1f944324-673f-4f14-94c8-dc570ea3022d")]
        ICollection<Zetbox.App.Test.TestCustomObject> TestCustomObjects_List_Nav { get; }

        /// <summary>
        /// 
        /// </summary>

        [Zetbox.API.DefinitionGuid("a3ad7340-4dc1-488c-bc9a-29ac931b1f0d")]
        ICollection<Zetbox.App.Test.TestCustomObject> TestCustomObjects_ManyList_Nav { get; }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("aabd7cb7-c45e-43c9-97fd-76e50c310ab3")]
        Zetbox.App.Test.TestCustomObject TestCustomObjects_Nav {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("42c6bc2f-0428-488a-b928-539c4c6e3e65")]
        Zetbox.App.Test.TestCustomObject TestCustomObjects_One_Nav {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("c5a66e0b-1fdb-45e4-b9e4-2ae4ee35a201")]
        DateTime? TestDateTime {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("1a5484e4-4be0-4641-9c25-1aa30d1c0e7a")]
        Zetbox.App.Test.TestEnum TestEnum {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("e9516350-fa66-426b-808a-bd8a5f432427")]
        string TestString {
            get;
            set;
        }
    }
}
