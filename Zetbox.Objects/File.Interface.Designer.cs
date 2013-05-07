// <autogenerated/>

namespace at.dasz.DocumentManagement
{
    using System;
    using System.Collections.Generic;

    using Zetbox.API;

    /// <summary>
    /// Abstract Baseclass for File Types
    /// </summary>
    [Zetbox.API.DefinitionGuid("8043ccd8-6ff1-4b45-b04b-e0a0f19ce1b6")]
    public interface File : IDataObject, Zetbox.App.Base.IChangedBy, Zetbox.App.Base.IExportable 
    {

        /// <summary>
        /// Current File Content
        /// </summary>
        [Zetbox.API.DefinitionGuid("ef5addda-340f-4a87-83c9-3ee419519343")]
        Zetbox.App.Base.Blob Blob {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("76e29530-9252-4c2a-bae4-503f3b6dcd29")]
        at.dasz.DocumentManagement.Excerpt Excerpt {
            get;
            set;
        }

        /// <summary>
        /// Filename
        /// </summary>
        [Zetbox.API.DefinitionGuid("1c5f2bea-9915-4634-8ff9-5fd6f0871704")]
        string Name {
            get;
            set;
        }

        /// <summary>
        /// Creates an excerpt from the current file
        /// </summary>
        void ExtractText();

        /// <summary>
        /// Handles the change of the current blob
        /// </summary>
        Zetbox.App.Base.Blob HandleBlobChange(Zetbox.App.Base.Blob oldBlob, Zetbox.App.Base.Blob newBlob);

        /// <summary>
        /// Öffnet das Dokument schreibgeschützt
        /// </summary>
        void Open();

        /// <summary>
        /// Uploads a new Content
        /// </summary>
        void Upload();
    }
}
