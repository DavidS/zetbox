// <autogenerated/>

namespace at.dasz.DocumentManagement
{
    using System;
    using System.Collections.Generic;

    using Zetbox.API;

    /// <summary>
    /// Files beeing imported by the import service.
    /// </summary>
    [Zetbox.API.DefinitionGuid("523a75bb-29c4-421c-9343-93d8658bb5f8")]
    public interface ImportedFile : at.dasz.DocumentManagement.File 
    {

        /// <summary>
        /// Converts the imported file to a document
        /// </summary>
        at.dasz.DocumentManagement.File MakeFile();

        /// <summary>
        /// Converts the imported file to a readonly file
        /// </summary>
        at.dasz.DocumentManagement.File MakeReadonlyFile();

        /// <summary>
        /// Deprecated, use MakeReadonlyFile instead
        /// </summary>
        at.dasz.DocumentManagement.StaticFile MakeStaticFile();
    }
}
