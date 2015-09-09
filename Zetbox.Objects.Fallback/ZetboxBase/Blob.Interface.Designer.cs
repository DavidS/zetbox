// <autogenerated/>

namespace Zetbox.App.Base
{
    using System;
    using System.Collections.Generic;

    using Zetbox.API;

    /// <summary>
    /// Represents a Document
    /// </summary>
    [Zetbox.API.DefinitionGuid("afd99ba6-f150-4ed4-ad1f-4ef57b14728b")]
    public interface Blob : IDataObject, Zetbox.App.Base.IChangedBy, Zetbox.App.Base.IExportable 
    {

        /// <summary>
        /// MimeType of this Blob
        /// </summary>
        [Zetbox.API.DefinitionGuid("182a7118-5123-4d5f-b623-205e38573e8e")]
        string MimeType {
            get;
            set;
        }

        /// <summary>
        /// Original file name of this blob
        /// </summary>
        [Zetbox.API.DefinitionGuid("c1f449e2-9532-4093-8667-6ba5f7372892")]
        string OriginalName {
            get;
            set;
        }

        /// <summary>
        /// Relative Path + Filename to the client/server document storage location. Readonly on client side.
        /// </summary>
        [Zetbox.API.DefinitionGuid("bd8eaefd-0684-4c05-a6b5-6f4d97017e6c")]
        string StoragePath {
            get;
            set;
        }

        /// <summary>
        /// Returnes the document stream
        /// </summary>
        System.IO.Stream GetStream();

        /// <summary>
        /// Opens the document
        /// </summary>
        void Open();
    }
}