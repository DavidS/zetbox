// <autogenerated/>

namespace at.dasz.DocumentManagement
{
    using System;
    using System.Collections.Generic;

    using Kistl.API;

    /// <summary>
    /// 
    /// </summary>
    public interface FileImportConfiguration : IDataObject, Kistl.App.Base.IChangedBy, Kistl.App.Base.IExportable 
    {

        /// <summary>
        /// Restricts this configuration to a specific identity
        /// </summary>
        Kistl.App.Base.Identity Identity {
            get;
            set;
        }

        /// <summary>
        /// Restricts this configuration to a specific machine
        /// </summary>
        string MachineName {
            get;
            set;
        }

        /// <summary>
        /// Pickup directory for the file import service. Env Variables can be used with %VARIABLE%. e.g. %HOMEPATH%\MyPickupDir
        /// </summary>
        string PickupDirectory {
            get;
            set;
        }
    }
}