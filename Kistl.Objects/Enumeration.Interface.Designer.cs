
namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Metadefinition Object for Enumerations.
    /// </summary>
    public interface Enumeration : Kistl.App.Base.DataType 
    {

        /// <summary>
        /// Einträge der Enumeration
        /// </summary>

        ICollection<Kistl.App.Base.EnumerationEntry> EnumerationEntries { get; }
    }
}