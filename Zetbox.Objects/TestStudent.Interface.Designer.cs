// <autogenerated/>

namespace Zetbox.App.Test
{
    using System;
    using System.Collections.Generic;

    using Zetbox.API;

    /// <summary>
    /// 
    /// </summary>
    [Zetbox.API.DefinitionGuid("9efc763c-9cdf-41e3-930c-7505fc4ac840")]
    public interface TestStudent : IDataObject 
    {

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("190b4492-c1cb-40a2-8941-84b8ff3ac141")]
        string Name {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>

        [Zetbox.API.DefinitionGuid("f330d95b-372d-4302-b4d1-73afc5fa71de")]
        ICollection<Zetbox.App.Test.Fragebogen> Testbogen { get; }
    }
}
