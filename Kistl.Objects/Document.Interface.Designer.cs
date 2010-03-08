// <autogenerated/>

namespace Kistl.App.Base
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Represents a Document
    /// </summary>
    public interface Document : IDataObject, Kistl.App.Base.IChangedBy, Kistl.App.Base.IExportable 
    {

        /// <summary>
        /// Document name
        /// </summary>
		string Name {
			get;
			set;
		}
        /// <summary>
        /// Relative Path + Filename to the client/server document storage location. Readonly on client side.
        /// </summary>
		string StoragePath {
			get;
			set;
		}
        /// <summary>
        /// Returnes the document stream
        /// </summary>
		 System.IO.Stream GetStream() ;
        /// <summary>
        /// 
        /// </summary>
		 void IntializeStoragePath() ;
        /// <summary>
        /// Save the given stream
        /// </summary>
		 void SaveStream(System.IO.Stream stream) ;
    }
}