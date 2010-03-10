// <autogenerated/>

namespace at.dasz.DocumentManagement
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// Abstract Baseclass for File Types
    /// </summary>
    public interface File : IDataObject, Kistl.App.Base.IChangedBy, Kistl.App.Base.IExportable 
    {

        /// <summary>
        /// Current File Content
        /// </summary>
		Kistl.App.Base.Blob Blob {
			get;
			set;
		}
        /// <summary>
        /// Filename
        /// </summary>
		string Name {
			get;
			set;
		}
        /// <summary>
        /// Opens the Content readonly
        /// </summary>
		 void Open() ;
        /// <summary>
        /// Uploads a new Content
        /// </summary>
		 void Upload() ;
    }
}