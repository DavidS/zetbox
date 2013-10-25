// <autogenerated/>

namespace Zetbox.App.GUI
{
    using System;
    using System.Collections.Generic;

    using Zetbox.API;

    /// <summary>
    /// 
    /// </summary>
    [Zetbox.API.DefinitionGuid("5d152c6f-6c1e-48b7-b03e-669e30468808")]
    public interface ViewModelDescriptor : IDataObject, Zetbox.App.Base.IExportable, Zetbox.App.Base.IModuleMember, Zetbox.App.Base.INamedObject 
    {

        /// <summary>
        /// The default ControlKind to use for displaying this Presentable readonly. Defaults to DefaultKind with editing disabled.
        /// </summary>
        [Zetbox.API.DefinitionGuid("067ed744-cd2c-4c8b-9829-cf7d0b16df60")]
        Zetbox.App.GUI.ControlKind DefaultDisplayKind {
            get;
            set;
        }

        /// <summary>
        /// The default ControlKind to use for this Presentable.
        /// </summary>
        [Zetbox.API.DefinitionGuid("b535115c-b847-479d-bdea-a7994ae6eeca")]
        Zetbox.App.GUI.ControlKind DefaultEditorKind {
            get;
            set;
        }

        /// <summary>
        /// The default ControlKind to use for displaying this Presentable readonly in a GridCell. Defaults to DefaultDisplayKind.
        /// </summary>
        [Zetbox.API.DefinitionGuid("20fb1478-5e20-48e3-b418-c101397d15d1")]
        Zetbox.App.GUI.ControlKind DefaultGridCellDisplayKind {
            get;
            set;
        }

        /// <summary>
        /// The default ControlKind for displaying this model in a GridCell in editing mode. Defaults to DefaultKind.
        /// </summary>
        [Zetbox.API.DefinitionGuid("7a093e89-a9ea-46ca-aeb6-cd3a1740714a")]
        Zetbox.App.GUI.ControlKind DefaultGridCellEditorKind {
            get;
            set;
        }

        /// <summary>
        /// .The default ControlKind for displaying this model in a GridCell befor editing starts. Defaults to DefaultGridCellDisplayKind.
        /// </summary>
        [Zetbox.API.DefinitionGuid("6c744476-35e0-4cef-a221-f02abc81566c")]
        Zetbox.App.GUI.ControlKind DefaultGridCellPreEditorKind {
            get;
            set;
        }

        /// <summary>
        /// Indicates that the referenced viewmodel type is deleted. Descriptors with this flag set require action to finally delete them and handle their users.
        /// </summary>
        [Zetbox.API.DefinitionGuid("9c3935a1-2d3f-4d43-b8af-638e323b64c6")]
        bool Deleted {
            get;
            set;
        }

        /// <summary>
        /// describe this ViewModel
        /// </summary>
        [Zetbox.API.DefinitionGuid("93e25648-50f9-40d8-8753-e5dadab68e1d")]
        string Description {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>

        [Zetbox.API.DefinitionGuid("5e2e007c-2e90-4ba6-9c9d-46e62b662ff9")]
        ICollection<Zetbox.App.GUI.ControlKind> SecondaryControlKinds { get; }

        /// <summary>
        /// The described CLR class&apos; Type
        /// </summary>
        [Zetbox.API.DefinitionGuid("b3cae453-e222-4d24-b6f5-47f47550ad7a")]
        string ViewModelTypeRef {
            get;
            set;
        }
    }
}
