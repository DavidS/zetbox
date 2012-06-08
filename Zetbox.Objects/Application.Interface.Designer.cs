// <autogenerated/>

namespace Zetbox.App.GUI
{
    using System;
    using System.Collections.Generic;

    using Zetbox.API;

    /// <summary>
    /// Represents a Zetbox Application
    /// </summary>
    [Zetbox.API.DefinitionGuid("896187c2-2714-4430-8adb-6532612d7e0f")]
    public interface Application : IDataObject, Zetbox.App.Base.IChangedBy, Zetbox.App.Base.IExportable, Zetbox.App.Base.IModuleMember 
    {

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("24fabe2c-de1d-4b67-970d-748a73c5e17d")]
        string Description {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("70bec122-0345-457c-9426-52168e033df1")]
        string Name {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("2232a206-1192-4937-8314-701073215cdb")]
        Zetbox.App.GUI.NavigationScreen RootScreen {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("25e50509-3b29-46b1-9bdb-17a0bd2963c2")]
        Zetbox.App.GUI.ViewModelDescriptor WorkspaceViewModel {
            get;
            set;
        }
    }
}
