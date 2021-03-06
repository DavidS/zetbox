// This file is part of zetbox.
//
// Zetbox is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as
// published by the Free Software Foundation, either version 3 of
// the License, or (at your option) any later version.
//
// Zetbox is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with zetbox.  If not, see <http://www.gnu.org/licenses/>.
namespace Zetbox.Client.Presentables.ZetboxBase
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Collections.Specialized;
    using System.Linq;
    using System.Text;
    using Zetbox.API;
    using Zetbox.API.Utils;
    using Zetbox.App.Base;
    using Zetbox.App.Extensions;
    using Zetbox.App.GUI;
    using Zetbox.Client.Models;
    using Zetbox.Client.Presentables;
    using Zetbox.Client.Presentables.FilterViewModels;
    using Zetbox.API.Client;

    [ViewModelDescriptor]
    public class FilterListViewModel : ViewModel
    {
        public new delegate FilterListViewModel Factory(IZetboxContext dataCtx, ViewModel parent, ObjectClass type);

        private ObjectClass _type;
        private IFulltextSupport _fulltextSupport;

        public FilterListViewModel(IViewModelDependencies appCtx, IZetboxContext dataCtx, ViewModel parent, ObjectClass type, IFulltextSupport fulltextSupport = null)
            : base(appCtx, dataCtx, parent)
        {
            if (type == null) throw new ArgumentNullException("type");

            _type = type;
            _fulltextSupport = fulltextSupport;
        }

        public override string Name
        {
            get { return FilterListViewModelResources.Name; }
        }

        private bool? _hasFulltextSupportCache;
        public bool HasFulltextSupport
        {
            get
            {
                if (_hasFulltextSupportCache == null)
                {
                    _hasFulltextSupportCache = _fulltextSupport != null && _fulltextSupport.HasIndexedFields(_type);
                }
                return _hasFulltextSupportCache.Value;
            }
        }

        private bool _enableAutoFilter = true;

        /// <summary>
        /// Enables the auto filter feature. This is the default. Setting this property will cause the filter collection to be cleared.
        /// </summary>
        public bool EnableAutoFilter
        {
            get
            {
                return _enableAutoFilter;
            }
            set
            {
                if (_enableAutoFilter != value)
                {
                    _enableAutoFilter = value;
                    _filter = null;
                    OnPropertyChanged("EnableAutoFilter");
                    OnPropertyChanged("Filter");
                    OnPropertyChanged("ShowFilter");
                }
            }
        }

        public bool ShowFilter
        {
            get
            {
                return AllowFilter && Filter.Count() > 0;
            }
        }

        private bool _RespectRequiredFilter = true;
        /// <summary>
        /// If set to false, no filter is required. Default value is true. Use this setting if a small, preselected list (query) is provides as data source.
        /// </summary>
        public bool RespectRequiredFilter
        {
            get
            {
                return !HasUserFilter && _RespectRequiredFilter;
            }
            set
            {
                if (_RespectRequiredFilter != value)
                {
                    _RespectRequiredFilter = value;
                    UpdateRespectRequieredFilter();
                    OnPropertyChanged("RespectRequiredFilter");
                }
            }
        }

        private bool _allowFilter = true;
        /// <summary>
        /// Allow the user to filter the collection
        /// </summary>
        public bool AllowFilter
        {
            get
            {
                return _allowFilter;
            }
            set
            {
                if (_allowFilter != value)
                {
                    _allowFilter = value;
                    OnPropertyChanged("AllowFilter");
                    OnPropertyChanged("ShowFilter");
                    OnPropertyChanged("AllowUserFilter");
                }
            }
        }

        private bool _allowUserFilter = true;
        /// <summary>
        /// Allow the user to modify the filter collection
        /// </summary>
        public bool AllowUserFilter
        {
            get
            {
                return _allowFilter && _allowUserFilter;
            }
            set
            {
                if (_allowUserFilter != value)
                {
                    _allowUserFilter = value;
                    OnPropertyChanged("AllowUserFilter");
                }
            }
        }

        private void UpdateRespectRequieredFilter()
        {
            if (_FilterViewModels != null)
            {
                _FilterViewModels.ForEach(i => i.RespectRequiredFilter = this.RespectRequiredFilter);
            }
        }

        private void UpdateExclusiveFilter()
        {
            if (_FilterViewModels != null)
            {
                var isExclusiveFilterActive = IsExclusiveFilterActive;
                foreach (var vm in _FilterViewModels)
                {
                    vm.IsEnabled = isExclusiveFilterActive == false // no exclusive Filter set, enable all other
                               || (vm.Filter.IsExclusiveFilter && vm.Filter.Enabled && vm.IsEnabled);
                }
            }
        }

        public bool IsExclusiveFilterActive
        {
            get
            {
                return _FilterViewModels != null && _FilterViewModels.Any(f => f.Filter.IsExclusiveFilter && f.Filter.Enabled);
            }
        }

        public bool HasUserFilter
        {
            get
            {
                if (_FilterListEntryViewModels == null) return false;
                return _FilterListEntryViewModels.Any(i => i.IsUserFilter);
            }
        }

        public bool RequiredFilterMissing
        {
            get
            {
                return RespectRequiredFilter && Filter.Any(f => !f.Enabled && f.Required);
            }
        }

        public bool IsFilterValid
        {
            get
            {
                return IsExclusiveFilterActive
                    || !RequiredFilterMissing;
            }
        }

        private ObservableCollection<IFilterModel> _filter = null;
        private ObservableCollection<FilterViewModel> _FilterViewModels = null;
        private ObservableCollection<FilterListEntryViewModel> _FilterListEntryViewModels = null;

        private ReadOnlyObservableCollection<IFilterModel> _filterRO = null;
        private ReadOnlyObservableCollection<FilterViewModel> _FilterViewModelsRO = null;
        private ReadOnlyObservableCollection<FilterListEntryViewModel> _FilterListEntryViewModelsRO = null;

        private void InitializeFilter()
        {
            if (_filter == null)
            {
                _filter = new ObservableCollection<IFilterModel>();
                _FilterViewModels = new ObservableCollection<FilterViewModel>();
                _FilterListEntryViewModels = new ObservableCollection<FilterListEntryViewModel>();

                _filterRO = new ReadOnlyObservableCollection<IFilterModel>(_filter);
                _FilterViewModelsRO = new ReadOnlyObservableCollection<FilterViewModel>(_FilterViewModels);
                _FilterListEntryViewModelsRO = new ReadOnlyObservableCollection<FilterListEntryViewModel>(_FilterListEntryViewModels);

                if (EnableAutoFilter)
                {
                    // Resolve default property filter
                    var t = _type;
                    while (t != null)
                    {
                        // Add ObjectClass filter expressions
                        foreach (var cfc in t.FilterConfigurations)
                        {
                            AddFilter(cfc.CreateFilterModel(DataContext));
                        }

                        // Add Property filter expressions
                        foreach (var prop in t.Properties.Where(p => p.FilterConfiguration != null))
                        {
                            AddFilter(prop.FilterConfiguration.CreateFilterModel(DataContext));
                        }
                        if (t is ObjectClass)
                        {
                            t = ((ObjectClass)t).BaseObjectClass;
                        }
                    }

                    if (HasFulltextSupport)
                    {
                        AddFilter(new FulltextFilterModel(FrozenContext));
                    }
                    else if (_filter.Count == 0)
                    {
                        // Add default ToString Filter only if there is no filter configuration & no fulltext filter can be applied
                        AddFilter(new ToStringFilterModel(FrozenContext));
                    }

                    if (_type.ImplementsIDeactivatable())
                    {
                        AddFilter(new WithDeactivatedFilterModel(FrozenContext));
                    }
                }
            }
        }

        public ReadOnlyObservableCollection<IFilterModel> Filter
        {
            get
            {
                InitializeFilter();
                return _filterRO;
            }
        }

        public ReadOnlyObservableCollection<FilterViewModel> FilterViewModels
        {
            get
            {
                InitializeFilter();
                return _FilterViewModelsRO;
            }
        }

        public ReadOnlyObservableCollection<FilterListEntryViewModel> FilterListEntryViewModels
        {
            get
            {
                InitializeFilter();
                return _FilterListEntryViewModelsRO;
            }
        }

        public void AddFilter(IFilterModel mdl)
        {
            AddFilter(-1, mdl, false, null);
        }
        public void AddFilter(int index, IFilterModel mdl)
        {
            AddFilter(index, mdl, false, null);
        }
        public void AddFilter(IFilterModel mdl, bool allowRemove)
        {
            AddFilter(-1, mdl, allowRemove, null);
        }
        public void AddFilter(int index, IFilterModel mdl, bool allowRemove)
        {
            AddFilter(index, mdl, allowRemove, null);
        }
        public void AddFilter(IFilterModel mdl, bool allowRemove, IEnumerable<Property> sourceProperties)
        {
            AddFilter(-1, mdl, allowRemove, sourceProperties);
        }
        public void AddFilter(int index, IFilterModel mdl, bool allowRemove, IEnumerable<Property> sourceProperties)
        {
            InitializeFilter();
            if (index >= 0)
            {
                _filter.Insert(index, mdl);
            }
            else
            {
                _filter.Add(mdl);
            }

            if (mdl is IUIFilterModel)
            {
                var uimdl = (IUIFilterModel)mdl;

                var vmdl = FilterViewModel.Fetch(ViewModelFactory, DataContext, this, uimdl);
                vmdl.RequestedKind = uimdl.RequestedKind;
                vmdl.RespectRequiredFilter = RespectRequiredFilter;

                var levmdl = FilterListEntryViewModel.Fetch(ViewModelFactory, DataContext, this, vmdl);
                levmdl.IsUserFilter = allowRemove;
                levmdl.SourceProperties = sourceProperties;

                // attach change events
                uimdl.FilterChanged += OnUIFilterChanged;

                _FilterViewModels.Add(vmdl);
                _FilterListEntryViewModels.Add(levmdl);
            }
            if (allowRemove) UpdateRespectRequieredFilter();
            UpdateExclusiveFilter();

            OnPropertyChanged("IsExclusiveFilterActive");
            OnPropertyChanged("RespectRequiredFilter");
            OnPropertyChanged("HasUserFilter");
            OnPropertyChanged("Filter");
            OnPropertyChanged("ShowFilter");
            OnPropertyChanged("FilterViewModels");
            OnPropertyChanged("FilterListEntryViewModels");
        }

        public bool RemoveFilter(IFilterModel mdl)
        {
            if (!_filter.Remove(mdl)) return false;
            if (mdl is IUIFilterModel)
            {
                var uimdl = (IUIFilterModel)mdl;
                var vmdl = FilterViewModel.Fetch(ViewModelFactory, DataContext, this, uimdl);
                var levmdl = FilterListEntryViewModel.Fetch(ViewModelFactory, DataContext, this, vmdl);

                _FilterViewModels.Remove(vmdl);
                _FilterListEntryViewModels.Remove(levmdl);
            }
            UpdateRespectRequieredFilter();
            UpdateExclusiveFilter();

            OnPropertyChanged("IsExclusiveFilterActive");
            OnPropertyChanged("RespectRequiredFilter");
            OnPropertyChanged("HasUserFilter");
            OnPropertyChanged("ShowFilter");
            OnPropertyChanged("Filter");
            OnPropertyChanged("FilterViewModels");
            OnPropertyChanged("FilterListEntryViewModels");
            return true;
        }

        private void OnUIFilterChanged(object sender, EventArgs e)
        {
            var filter = sender as FilterModel;
            if (filter == null) return;

            UpdateExclusiveFilter();
            OnPropertyChanged("IsExclusiveFilterActive");

            if (filter.RefreshOnFilterChanged)
            {
                if (filter.IsServerSideFilter)
                {
                    OnExecuteFilter();
                }
                else
                {
                    OnExecutePostFilter();
                }
            }
        }

        public event EventHandler ExecutePostFilter;
        private void OnExecutePostFilter()
        {
            var temp = ExecutePostFilter;
            if (temp != null)
            {
                temp(this, EventArgs.Empty);
            }
        }

        public event EventHandler ExecuteFilter;
        private void OnExecuteFilter()
        {
            var temp = ExecuteFilter;
            if (temp != null)
            {
                temp(this, EventArgs.Empty);
            }
        }


        private ICommandViewModel _AddFilterCommand = null;
        public ICommandViewModel AddFilterCommand
        {
            get
            {
                if (_AddFilterCommand == null)
                {
                    _AddFilterCommand = ViewModelFactory.CreateViewModel<SimpleCommandViewModel.Factory>().Invoke(DataContext, this,
                        InstanceListViewModelResources.AddFilterCommand,
                        InstanceListViewModelResources.AddFilterCommand_Tooltip,
                        AddFilter,
                        () => AllowFilter && AllowUserFilter,
                        null);
                    _AddFilterCommand.Icon = IconConverter.ToImage(Zetbox.NamedObjects.Gui.Icons.ZetboxBase.new_png.Find(FrozenContext));
                }
                return _AddFilterCommand;
            }
        }

        public void AddFilter()
        {
            var dlg = ViewModelFactory.CreateViewModel<PropertySelectionTaskViewModel.Factory>()
                .Invoke(DataContext,
                    this,
                    _type,
                    props =>
                    {
                        if (props != null)
                        {
                            AddFilter(FilterModel.FromProperty(DataContext, FrozenContext, props), true, props);
                            OnUserFilterAdded(props);
                        }
                    });
            dlg.FollowRelationsOne = true;
            dlg.FollowRelationsMany = true;
            ViewModelFactory.ShowDialog(dlg);
        }

        public void ResetUserFilter()
        {
            if (_FilterListEntryViewModels != null)
            {
                foreach (var f in _FilterListEntryViewModels.Where(i => i.IsUserFilter).ToList())
                {
                    RemoveFilter(f.FilterViewModel.Filter);
                }
            }
        }

        public event UserFilterAddedEventHander UserFilterAdded;
        protected void OnUserFilterAdded(IEnumerable<Property> props)
        {
            var temp = UserFilterAdded;
            if (temp != null)
            {
                temp(this, new UserFilterAddedEventArgs(props));
            }
        }

        public IQueryable AppendFilter(IQueryable qry)
        {
            foreach (var f in Filter.Where(f => f.Enabled))
            {
                qry = f.GetQuery(qry);
            }

            return qry;
        }

        public List<DataObjectViewModel> AppendPostFilter(List<DataObjectViewModel> result)
        {
            foreach (var f in Filter.Where(f => f.Enabled && !f.IsServerSideFilter))
            {
                result = f.GetResult(result).Cast<DataObjectViewModel>().ToList();
            }

            return result;
        }
    }

    public delegate void UserFilterAddedEventHander(object sender, UserFilterAddedEventArgs e);
    public class UserFilterAddedEventArgs : EventArgs
    {
        public UserFilterAddedEventArgs(IEnumerable<Property> props)
        {
            this.Properties = props;
        }

        public IEnumerable<Property> Properties { get; private set; }
    }
}
