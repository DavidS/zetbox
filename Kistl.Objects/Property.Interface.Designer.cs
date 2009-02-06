
namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Metadefinition Object for Properties. This class is abstract.
    /// </summary>
    public interface Property : Kistl.App.Base.BaseProperty 
    {

        /// <summary>
        /// 
        /// </summary>

		bool IsList { get; set; }
        /// <summary>
        /// 
        /// </summary>

		bool IsNullable { get; set; }
        /// <summary>
        /// Whether or not a list-valued property has a index
        /// </summary>

		bool IsIndexed { get; set; }
    }
}