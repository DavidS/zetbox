namespace $rootnamespace$
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Zetbox.API;
    using Zetbox.Client.Presentables;
    using Zetbox.Client.Presentables.GUI;
    using Zetbox.App.GUI;

    [ViewModelDescriptor]
    public class $safeitemname$ : NavigationReportScreenViewModel
    {
        public new delegate $safeitemname$ Factory(IZetboxContext dataCtx, ViewModel parent, NavigationScreen screen);

        public $safeitemname$(IViewModelDependencies appCtx, IZetboxContext dataCtx, ViewModel parent, NavigationScreen screen, IFileOpener fileOpener, ITempFileService tmpService)
            : base(appCtx, dataCtx, parent, screen, fileOpener, tmpService)
        {
        }
    }
}
