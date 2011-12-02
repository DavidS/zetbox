// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Objects implementing this interface can be accessed as named objects.
    /// </summary>
    public interface INamedObject : Kistl.App.Base.IExportable 
    {

        /// <summary>
        /// Returns a name where this instance can be found in the NamedObjects space
        /// </summary>
        string GetName();
    }
}
