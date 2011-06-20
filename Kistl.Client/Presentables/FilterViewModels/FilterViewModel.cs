
namespace Kistl.Client.Presentables.FilterViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using Kistl.API;
    using Kistl.Client.Models;
    using Kistl.Client.Presentables.ValueViewModels;

    /// <summary>
    /// Not a real view model
    /// Used to display internal enum FilterOperators
    /// </summary>
    public class OperatorViewModel
    {
        public OperatorViewModel()
        {
            _Operator = FilterOperators.Equals;
            Name = FilterViewModelResources.OperatorEquals;
        }

        public OperatorViewModel(FilterOperators op)
            : this()
        {
            Operator = op;
        }

        private FilterOperators _Operator;
        public FilterOperators Operator
        {
            get
            {
                return _Operator;
            }
            set
            {
                if (_Operator != value)
                {
                    _Operator = value;
                    switch (_Operator)
                    {
                        case FilterOperators.Equals:
                            Name = FilterViewModelResources.OperatorEquals;
                            break;
                        case FilterOperators.Contains:
                            Name = FilterViewModelResources.OperatorContains;
                            break;
                        case FilterOperators.Less:
                            Name = FilterViewModelResources.OperatorLess;
                            break;
                        case FilterOperators.LessOrEqual:
                            Name = FilterViewModelResources.OperatorLessOrEqual;
                            break;
                        case FilterOperators.Greater:
                            Name = FilterViewModelResources.OperatorGreater;
                            break;
                        case FilterOperators.GreaterOrEqual:
                            Name = FilterViewModelResources.OperatorGreaterOrEqual;
                            break;
                        case FilterOperators.Not:
                            Name = FilterViewModelResources.OperatorNot;
                            break;
                        case FilterOperators.IsNull:
                            Name = FilterViewModelResources.OperatorIsNull;
                            break;
                        case FilterOperators.IsNotNull:
                            Name = FilterViewModelResources.OperatorIsNotNull;
                            break;
                        default:
                            Name = _Operator.ToString();
                            break;
                    }
                }
            }
        }
        public string Name { get; set; }
    }

    public abstract class FilterViewModel : ViewModel
    {
        public new delegate FilterViewModel Factory(IKistlContext dataCtx, ViewModel parent, IUIFilterModel mdl);

        public FilterViewModel(IViewModelDependencies dependencies, IKistlContext dataCtx, ViewModel parent, IUIFilterModel mdl)
            : base(dependencies, dataCtx, parent)
        {
            this.Filter = mdl;
            this._label = mdl.Label;
        }

        public IUIFilterModel Filter { get; private set; }

        private ObservableCollection<IValueViewModel> _Arguments = null;
        public ObservableCollection<IValueViewModel> Arguments
        {
            get
            {
                if (_Arguments == null)
                {
                    _Arguments = new ObservableCollection<IValueViewModel>(
                        Filter.FilterArguments
                            .Select(f =>
                            {
                                var mdl = BaseValueViewModel.Fetch(ViewModelFactory, DataContext, this, f.ViewModelType, f.Value);
                                // I know, a hack, but better then allowing user to create new objects during a search
                                if (mdl is ObjectReferenceViewModel)
                                {
                                    var objRefMdl = (ObjectReferenceViewModel)mdl;
                                    objRefMdl.AllowCreateNewItem = false;
                                    objRefMdl.AllowDelete = false;
                                }
                                return mdl;
                            })
                            .Cast<IValueViewModel>()
                    );
                }
                return _Arguments;
            }
        }

        public IValueViewModel Argument
        {
            get
            {
                return Arguments.Single();
            }
        }

        public override string Name
        {
            get { return FilterViewModelResources.Name; }
        }

        private string _label;
        public string Label
        {
            get
            {
                return _label;
            }
            set
            {
                if (_label != value)
                {
                    _label = value;
                    OnPropertyChanged("Label");
                }
            }
        }

        public bool Required
        {
            get
            {
                return Filter.Required;
            }
        }
    }
}
