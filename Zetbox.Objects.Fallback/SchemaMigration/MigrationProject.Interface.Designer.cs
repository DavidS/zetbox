// <autogenerated/>

namespace Zetbox.App.SchemaMigration
{
    using System;
    using System.Collections.Generic;

    using Zetbox.API;

    /// <summary>
    /// Defines a Schema Migration Project
    /// </summary>
    [Zetbox.API.DefinitionGuid("f2b4fe26-9d57-47c7-88b2-b30a38ebbd97")]
    public interface MigrationProject : IDataObject, Zetbox.App.Base.IChangedBy, Zetbox.App.Base.IExportable 
    {

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("17634aec-04e4-40f8-a585-51989e5cd95f")]
        string Description {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [Zetbox.API.DefinitionGuid("ed7a3291-b69b-42f3-9b60-dd06e374f856")]
        Zetbox.App.Base.Module DestinationModule {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>

        [Zetbox.API.DefinitionGuid("3750005b-3850-4697-8b80-b5a7854fc344")]
        ICollection<Zetbox.App.SchemaMigration.StagingDatabase> StagingDatabases { get; }

        /// <summary>
        /// Creates a mapping report
        /// </summary>
        void CreateMappingReport();

        /// <summary>
        /// 
        /// </summary>
        void UpdateFromSourceSchema();
    }
}
