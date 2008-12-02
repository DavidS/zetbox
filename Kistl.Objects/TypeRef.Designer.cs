//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Collections;
    using System.Xml;
    using System.Xml.Serialization;
    using Kistl.API;
    
    
    /// <summary>
    /// This class models a reference to a specific, concrete Type. Generic Types have all parameters filled.
    /// </summary>
    public interface TypeRef : IDataObject
    {
        
        string FullName
        {
            get;
            set;
        }
        
        /// <summary>
        /// The assembly containing the referenced Type.
        /// </summary>
        Kistl.App.Base.Assembly Assembly
        {
            get;
            set;
        }
        
        /// <summary>
        /// list of type arguments
        /// </summary>
        IList<Kistl.App.Base.TypeRef> GenericArguments
        {
            get;
        }
        
        /// <summary>
        /// get the referenced <see cref="System.Type"/>
        /// </summary>
        /// <returns>
        /// the referenced Type
        /// </returns>
        /// <param name="throwOnError">
        /// whether to return null (false) or throw an Exception (true) on error
        /// </param>
        System.Type AsType(bool throwOnError);
    }
}
