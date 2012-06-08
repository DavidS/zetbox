namespace Zetbox.Client.Presentables.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Zetbox.API;
    using Zetbox.Client.Presentables;
    using Zetbox.Client.Presentables.GUI;
    using Zetbox.App.GUI;
    using Zetbox.Client.Models;
    using Zetbox.Client.Presentables.FilterViewModels;
    using Zetbox.Client.Presentables.DtoViewModels;

    [ViewModelDescriptor]
    public abstract class NavigationReportScreenViewModel : NavigationScreenViewModel
    {
        public new delegate NavigationReportScreenViewModel Factory(IZetboxContext dataCtx, ViewModel parent, NavigationScreen screen);

        private readonly IViewModelDependencies _appCtx;
        private readonly IFileOpener _fileOpener;
        private readonly ITempFileService _tmpService;

        public NavigationReportScreenViewModel(IViewModelDependencies appCtx,
            IZetboxContext dataCtx, ViewModel parent, NavigationScreen screen, IFileOpener fileOpener, ITempFileService tmpService)
            : base(appCtx, dataCtx, parent, screen)
        {
            _appCtx = appCtx;
            _fileOpener = fileOpener;
            _tmpService = tmpService;
        }

        private DateRangeFilterModel _rangeMdl;
        private DateRangeFilterViewModel _berichtszeitraumVM;
        public DateRangeFilterViewModel Range
        {
            get
            {
                if (_berichtszeitraumVM == null)
                {
                    _rangeMdl = DateRangeFilterModel.Create(FrozenContext, "Report range", null, null, true, false, false);
                    _berichtszeitraumVM = ViewModelFactory.CreateViewModel<DateRangeFilterViewModel.Factory>()
                        .Invoke(DataContext, this, _rangeMdl);
                    _rangeMdl.FilterChanged += (s, e) => Refresh();
                }

                return _berichtszeitraumVM;
            }
        }

        public void Refresh()
        {
            _statistic = null;
            OnPropertyChanged("Statistic");
        }

        private object _statistic;
        private DtoBaseViewModel _statisticModel;
        public DtoBaseViewModel Statistic
        {
            get
            {
                if (_statistic == null)
                {
                    ViewModelFactory.CreateDelayedTask(Displayer, () =>
                    {
                        if (_rangeMdl != null && _rangeMdl.From.Value.HasValue && _rangeMdl.To.Value.HasValue)
                        {
                            _statistic = LoadStatistic(_rangeMdl.From.Value.Value, _rangeMdl.To.Value.Value);
                            if (_statistic != null)
                            {
                                var tmp = DtoBuilder.BuildFrom(_statistic, _appCtx, DataContext, this, _fileOpener, _tmpService);

                                if (_statisticModel == null)
                                {
                                    _statisticModel = tmp;
                                }
                                else
                                {
                                    tmp = DtoBuilder.Combine(_statisticModel, tmp);
                                    if (tmp != _statisticModel)
                                    {
                                        _statisticModel = tmp;
                                    }
                                }
                            }
                        }
                        OnPropertyChanged("Statistic");
                    }).Trigger();
                }
                return _statisticModel;
            }
        }

        protected abstract object LoadStatistic(DateTime from, DateTime until);
    }
}
