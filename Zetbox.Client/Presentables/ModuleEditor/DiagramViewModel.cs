﻿
namespace Zetbox.Client.Presentables.ModuleEditor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using QuickGraph;
    using Zetbox.API;
    using Zetbox.API.Configuration;
    using Zetbox.API.Utils;
    using Zetbox.App.Base;
    using Zetbox.Client.Models;
    using Zetbox.Client.Presentables.ValueViewModels;
    using Zetbox.Client.Presentables.ZetboxBase;
    using ObjectEditorWorkspace = Zetbox.Client.Presentables.ObjectEditor.WorkspaceViewModel;
    using System.Collections.ObjectModel;
    using Zetbox.Client.GUI;
    using Zetbox.App.Extensions;
    using Autofac;

    [CLSCompliant(false)]
    public class DataTypeGraph : BidirectionalGraph<DataTypeGraphModel, IEdge<DataTypeGraphModel>>
    {
        public DataTypeGraph() { }

        public DataTypeGraph(bool allowParallelEdges)
            : base(allowParallelEdges) { }

        public DataTypeGraph(bool allowParallelEdges, int vertexCapacity)
            : base(allowParallelEdges, vertexCapacity) { }
    }

    [ViewModelDescriptor]
    public class DiagramViewModel : ViewModel, IRefreshCommandListener
    {
        public new delegate DiagramViewModel Factory(IZetboxContext dataCtx, ViewModel parent, Zetbox.App.Base.Module module);

        public DiagramViewModel(IViewModelDependencies appCtx, ViewModel parent, IZetboxContext dataCtx, Zetbox.App.Base.Module module)
            : base(appCtx, dataCtx, parent)
        {
            this.Module = module;
        }

        public Zetbox.App.Base.Module Module { get; private set; }

        public ViewModel DashboardViewModel
        {
            get
            {
                return this;
            }
        }

        #region GraphSettings
        public enum GraphTypeEnum
        {
            Relation,
            Inheritance,
        }

        private GraphTypeEnum _graphType = GraphTypeEnum.Relation;
        public GraphTypeEnum GraphType
        {
            get
            {
                return _graphType;
            }
            set
            {
                if (_graphType != value)
                {
                    _graphType = value;
                    OnPropertyChanged("GrapType");
                    RecreateGraph();
                }
            }
        }

        public IEnumerable<GraphTypeEnum> GraphTypes
        {
            get
            {
                return new GraphTypeEnum[] { GraphTypeEnum.Relation, GraphTypeEnum.Inheritance };
            }
        }
        #endregion

        #region ViewModel

        public override string Name
        {
            get { return "Class Diagram"; }
        }

        public override string ToString()
        {
            return Name;
        }

        public override System.Drawing.Image Icon
        {
            get { return IconConverter.ToImage(NamedObjects.Gui.Icons.ZetboxBase.pen_png.Find(FrozenContext)); }
        }
        #endregion

        #region Modules
        private ObservableCollection<ModuleGraphViewModel> _moduleViewModels;
        public ObservableCollection<ModuleGraphViewModel> ModuleViewModels
        {
            get
            {
                if (_moduleViewModels == null)
                {
                    _moduleViewModels = new ObservableCollection<ModuleGraphViewModel>(DataContext.GetQuery<Zetbox.App.Base.Module>()
                                    .OrderBy(m => m.Name)
                                    .ToList()
                                    .Select(m => ViewModelFactory.CreateViewModel<ModuleGraphViewModel.Factory>().Invoke(DataContext, this, m))
                                    );
                }
                return _moduleViewModels;
            }
        }
        #endregion

        #region DataTypes
        private ClassValueModel<string> _filterMdl;
        private ViewModel _filter;
        public ViewModel Filter
        {
            get
            {
                if (_filter == null)
                {
                    _filterMdl = new ClassValueModel<string>(
                        "Filter",
                        "",
                        true, false);
                    _filterMdl.PropertyChanged += (s, e) =>
                    {
                        if (e.PropertyName == "Value")
                        {
                            OnPropertyChanged("DataTypeViewModels");
                            OnPropertyChanged("FilterValue");
                        }
                    };
                    _filter = ViewModelFactory.CreateViewModel<StringValueViewModel.Factory>().Invoke(DataContext, this, _filterMdl);
                }
                return _filter;
            }
        }

        public string FilterValue
        {
            get
            {
                return _filterMdl != null ? _filterMdl.Value : null;
            }
        }

        private List<Relation> _relations = null;
        public IEnumerable<Relation> Relations
        {
            get
            {
                if (_relations == null)
                {
                    _relations = DataContext.GetQuery<Relation>().Where(i => i.Module == Module).ToList();
                }
                return _relations;
            }
        }

        public void Refresh()
        {
            _relations = null;
            _dataTypeViewModels = null;
            if (_moduleViewModels != null)
            {
                var newModules = DataContext.GetQuery<Zetbox.App.Base.Module>().ToList();
                // Add new ones, keep existing ones
                foreach (var newModule in newModules.Except(_moduleViewModels.Select(mv => mv.Module)))
                {
                    _moduleViewModels.Add(ViewModelFactory.CreateViewModel<ModuleGraphViewModel.Factory>().Invoke(DataContext, this, newModule));
                }

                _moduleViewModels.ForEach(m => m.Refresh());
            }

            OnPropertyChanged("DataTypeViewModels");
            OnPropertyChanged("Relations");
            RecreateGraph();
        }

        List<DataTypeGraphModel> _dataTypeViewModels;
        public IEnumerable<DataTypeGraphModel> DataTypeViewModels
        {
            get
            {
                if (_dataTypeViewModels == null)
                {
                    _dataTypeViewModels = ModuleViewModels.SelectMany(m => m.DataTypes).ToList();
                }
                return _dataTypeViewModels;
            }
        }

        public IEnumerable<DataTypeGraphModel> SelectedDataTypeViewModels
        {
            get
            {
                return DataTypeViewModels.Where(i => i.IsChecked);
            }
        }

        public IEnumerable<DataTypeGraphModel> SelectedGraphDataTypeViewModels
        {
            get
            {
                return DataTypeViewModels.Where(i => i.IsGraphChecked);
            }
        }

        private void SelectAllDataTypes()
        {
            DataTypeViewModels.ForEach(i => i.SetChecked(true, false));
            RecreateGraph();
        }

        private void SelectNoDataTypes()
        {
            DataTypeViewModels.ForEach(i => i.SetChecked(false, false));
            RecreateGraph();
        }

        private void AddRelatedDataTypes()
        {
            foreach (var dtm in SelectedDataTypeViewModels.ToList())
            {
                var add = new List<DataTypeGraphModel>();
                if (GraphType == GraphTypeEnum.Inheritance)
                {
                    // Add BaseClass
                    if (dtm.DataType is ObjectClass && ((ObjectClass)dtm.DataType).BaseObjectClass != null)
                    {
                        var item = DataTypeViewModels.FirstOrDefault(i => i.DataType == ((ObjectClass)dtm.DataType).BaseObjectClass);
                        if (item != null) add.Add(item);
                    }

                    // Add Inheritance
                    add.AddRange(DataTypeViewModels.Where(i => i.DataType is ObjectClass && ((ObjectClass)i.DataType).BaseObjectClass == dtm.DataType));

                }
                else if (GraphType == GraphTypeEnum.Relation)
                {
                    foreach (var rel in Relations.Where(i => i.A.Type == dtm.DataType || i.B.Type == dtm.DataType))
                    {
                        var a = DataTypeViewModels.FirstOrDefault(i => i.DataType == rel.A.Type);
                        if (a != null) add.Add(a);
                        var b = DataTypeViewModels.FirstOrDefault(i => i.DataType == rel.B.Type);
                        if (b != null) add.Add(b);
                    }
                }

                // checked = true
                add.ForEach(i => i.SetChecked(true, false));
            }

            RecreateGraph();
        }
        #endregion

        #region Graph
        public class RelationEdge
        {
            public Relation Rel { get; set; }
            public override string ToString()
            {
                return string.Format("{0} {1} {2}", Rel.A.RoleName, Rel.Verb, Rel.B.RoleName);
            }
        }

        public class InheritanceEdge
        {
            public ObjectClass ObjClass { get; set; }
            public override string ToString()
            {
                return string.Format("{0} : {1}", ObjClass.Name, ObjClass.BaseObjectClass.Name);
            }
        }

        private DataTypeGraph CreateGraph()
        {
            var g = new DataTypeGraph(true);

            if (SelectedDataTypeViewModels.Count() == 0)
            {
                return null;
            }

            Dictionary<DataType, DataTypeGraphModel> typeMdlDict = new Dictionary<DataType, DataTypeGraphModel>();
            foreach (var dt in SelectedDataTypeViewModels)
            {
                g.AddVertex(dt);
                typeMdlDict[dt.DataType] = dt;
            }

            if (GraphType == GraphTypeEnum.Relation)
            {
                foreach (var rel in Relations)
                {
                    if (typeMdlDict.ContainsKey(rel.A.Type) && typeMdlDict.ContainsKey(rel.B.Type))
                    {
                        g.AddEdge(new TaggedEdge<DataTypeGraphModel, RelationEdge>(typeMdlDict[rel.A.Type], typeMdlDict[rel.B.Type], new RelationEdge() { Rel = rel }));
                    }
                }
            }
            else if (GraphType == GraphTypeEnum.Inheritance)
            {
                foreach (var cls in SelectedDataTypeViewModels.Select(i => i.DataType).OfType<ObjectClass>())
                {
                    if (cls.BaseObjectClass != null && typeMdlDict.ContainsKey(cls) && typeMdlDict.ContainsKey(cls.BaseObjectClass))
                    {
                        g.AddEdge(new TaggedEdge<DataTypeGraphModel, InheritanceEdge>(typeMdlDict[cls.BaseObjectClass], typeMdlDict[cls], new InheritanceEdge() { ObjClass = cls }));
                    }
                }
            }

            return g;
        }

        internal void RecreateGraph()
        {
            _graph = null;
            OnPropertyChanged("Graph");
        }

        private DataTypeGraph _graph;
        public object Graph
        {
            get
            {
                if (_graph == null)
                {
                    _graph = CreateGraph();
                }
                return _graph;
            }
        }

        #endregion

        #region Commands
        private RefreshCommand _RefreshCommand = null;
        public ICommandViewModel RefreshCommand
        {
            get
            {
                if (_RefreshCommand == null)
                {
                    _RefreshCommand = ViewModelFactory.CreateViewModel<RefreshCommand.Factory>().Invoke(DataContext, this);
                }
                return _RefreshCommand;
            }
        }

        private ICommandViewModel _selectAllCommand = null;
        public ICommandViewModel SelectAllCommand
        {
            get
            {
                if (_selectAllCommand == null)
                {
                    _selectAllCommand = ViewModelFactory.CreateViewModel<SimpleCommandViewModel.Factory>().Invoke(DataContext, this, "Select all", "Selects all DataTypes", () => SelectAllDataTypes(), null, null);
                }
                return _selectAllCommand;
            }
        }

        private ICommandViewModel _selectNoneCommand = null;
        public ICommandViewModel SelectNoneCommand
        {
            get
            {
                if (_selectNoneCommand == null)
                {
                    _selectNoneCommand = ViewModelFactory.CreateViewModel<SimpleCommandViewModel.Factory>().Invoke(DataContext, this, "Select None", "Selects no DataTypes", () => SelectNoDataTypes(), null, null);
                }
                return _selectNoneCommand;
            }
        }

        private ICommandViewModel _addRelatedCommand = null;
        public ICommandViewModel AddRelatedCommand
        {
            get
            {
                if (_addRelatedCommand == null)
                {
                    _addRelatedCommand = ViewModelFactory.CreateViewModel<SimpleCommandViewModel.Factory>().Invoke(DataContext, this, "Add Related", "Add related DataTypes", () => AddRelatedDataTypes(), null, null);
                }
                return _addRelatedCommand;
            }
        }

        private NewObjectClassCommand _NewObjectClassCommand = null;
        public ICommandViewModel NewObjectClassCommand
        {
            get
            {
                if (_NewObjectClassCommand == null)
                {
                    _NewObjectClassCommand = ViewModelFactory.CreateViewModel<NewObjectClassCommand.Factory>().Invoke(DataContext, this, Module);
                    _NewObjectClassCommand.Created += (newCls) =>
                    {
                        DataTypeViewModels
                            .Single(vm => vm.DataType.ExportGuid == newCls.ExportGuid)
                            .SetChecked(true, true);
                    };
                }
                return _NewObjectClassCommand;
            }
        }

        private ICommandViewModel _NewRelationCommand = null;
        public ICommandViewModel NewRelationCommand
        {
            get
            {
                if (_NewRelationCommand == null)
                {
                    _NewRelationCommand = ViewModelFactory.CreateViewModel<SimpleCommandViewModel.Factory>().Invoke(DataContext, this, "New Relation", "Creates a new Relation", () =>
                    {
                        var newScope = ViewModelFactory.CreateNewScope();
                        var newCtx = newScope.ViewModelFactory.CreateNewContext();
                        var newWorkspace = ObjectEditorWorkspace.Create(newScope.Scope, newCtx);
                        var newRel = newCtx.Create<Relation>();

                        newRel.Module = newCtx.Find<Zetbox.App.Base.Module>(Module.ID);
                        // First() and Last() may be the same
                        newRel.A.Type = newCtx.Find<ObjectClass>(SelectedGraphDataTypeViewModels.First().ID);
                        newRel.B.Type = newCtx.Find<ObjectClass>(SelectedGraphDataTypeViewModels.Last().ID);

                        newWorkspace.ShowModel(DataObjectViewModel.Fetch(newScope.ViewModelFactory, newCtx, newWorkspace, newRel));
                        newScope.ViewModelFactory.ShowModel(newWorkspace, true);
                    },
                    () => (SelectedGraphDataTypeViewModels.Count() == 1 || SelectedGraphDataTypeViewModels.Count() == 2) && SelectedGraphDataTypeViewModels.Any(dt => dt.DataType is ObjectClass),
                    null);
                    _NewRelationCommand.Icon = IconConverter.ToImage(NamedObjects.Gui.Icons.ZetboxBase.new_png.Find(FrozenContext));
                }
                return _NewRelationCommand;
            }
        }
        #endregion
    }
}