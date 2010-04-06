using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.API;
using System.Collections.ObjectModel;
using Kistl.App.Base;
using Kistl.API.Client;
using Kistl.App.GUI;

namespace Kistl.Client.Presentables.ModuleEditor
{
    public abstract class InstanceListViewModel : ViewModel
    {
        public InstanceListViewModel(
            IGuiApplicationContext appCtx,
            IKistlContext dataCtx,
            Module module)
            : base(appCtx, dataCtx)
        {
            this.module = module;
        }

        private ObservableCollection<DataObjectModel> _instances = null;
        public ObservableCollection<DataObjectModel> Instances
        {
            get
            {
                if (_instances == null)
                {
                    _instances = new ObservableCollection<DataObjectModel>();
                    LoadInstances();
                }
                return _instances;
            }
        }

        protected abstract IQueryable<IDataObject> GetQuery();
        protected void LoadInstances()
        {
            foreach (var obj in GetQuery().ToList().OrderBy(obj => obj.ToString()))
            {
                _instances.Add((DataObjectModel)Factory.CreateDefaultModel(DataContext, obj));
            }
        }

        private string _instancesSearchString = String.Empty;
        public string InstancesSearchString
        {
            get
            {
                return _instancesSearchString;
            }
            set
            {
                if (_instancesSearchString != value)
                {
                    _instancesSearchString = value;
                    OnPropertyChanged("InstancesSearchString");
                    ExecuteFilter();
                }
            }
        }

        private ReadOnlyObservableCollection<DataObjectModel> _instancesFiltered = null;
        public ReadOnlyObservableCollection<DataObjectModel> InstancesFiltered
        {
            get
            {
                if (_instancesFiltered == null)
                {
                    ExecuteFilter();
                }
                return _instancesFiltered;
            }
        }

        /// <summary>
        /// Reload instances from context.
        /// </summary>
        public void ReloadInstances()
        {
            if (_instances != null)
            {
                _instances.Clear();
                LoadInstances();
                ExecuteFilter();
            }
        }

        private void ExecuteFilter()
        {
            if (InstancesSearchString.Length == 0)
            {
                _instancesFiltered = new ReadOnlyObservableCollection<DataObjectModel>(this.Instances);
            }
            else
            {
                // poor man's full text search
                _instancesFiltered = new ReadOnlyObservableCollection<DataObjectModel>(
                    new ObservableCollection<DataObjectModel>(
                        this.Instances.Where(
                            o => o.Name.ToLowerInvariant().Contains(this.InstancesSearchString.ToLowerInvariant())
                            || o.ID.ToString().Contains(this.InstancesSearchString))));
            }
            OnPropertyChanged("InstancesFiltered");
        }

        public override string ToString()
        {
            return this.Name;
        }

        public abstract InterfaceType InterfaceType { get; }

        protected Module module;
    }

    #region *InstanceListViewModel
    public class ObjectClassInstanceListViewModel : InstanceListViewModel
    {
        public ObjectClassInstanceListViewModel(
            IGuiApplicationContext appCtx,
            IKistlContext dataCtx,
            Module module)
            : base(appCtx, dataCtx, module)
        {
        }

        protected override IQueryable<IDataObject> GetQuery()
        {
            var result = DataContext.GetQuery<ObjectClass>().Where(i => i.Module == module).ToList().AsQueryable();
            if (OnlyBaseClasses)
            {
                result = result.Where(i => i.BaseObjectClass == null);
            }
            return result.Cast<IDataObject>();
        }

        public override string Name
        {
            get
            {
                return "Object Classes";
            }
        }

        private bool _OnlyBaseClasses = false;
        public bool OnlyBaseClasses
        {
            get
            {
                return _OnlyBaseClasses;
            }
            set
            {
                if (value != _OnlyBaseClasses)
                {
                    _OnlyBaseClasses = value;
                    OnPropertyChanged("OnlyBaseClasses");
                    OnPropertyChanged("InstancesFiltered");
                }
            }
        }

        public override InterfaceType InterfaceType
        {
            get { return new InterfaceType(typeof(ObjectClass)); }
        }
    }

    public class InterfaceInstanceListViewModel : InstanceListViewModel
    {
        public InterfaceInstanceListViewModel(
            IGuiApplicationContext appCtx,
            IKistlContext dataCtx,
            Module module)
            : base(appCtx, dataCtx, module)
        {
        }

        protected override IQueryable<IDataObject> GetQuery()
        {
            return DataContext.GetQuery<Interface>().Where(i => i.Module == module).ToList().AsQueryable().Cast<IDataObject>();
        }

        public override string Name
        {
            get
            {
                return "Interfaces";
            }
        }

        public override InterfaceType InterfaceType
        {
            get { return new InterfaceType(typeof(Interface)); }
        }
    }

    public class EnumerationInstanceListViewModel : InstanceListViewModel
    {
        public EnumerationInstanceListViewModel(
            IGuiApplicationContext appCtx,
            IKistlContext dataCtx,
            Module module)
            : base(appCtx, dataCtx, module)
        {
        }
        protected override IQueryable<IDataObject> GetQuery()
        {
            return DataContext.GetQuery<Enumeration>().Where(i => i.Module == module).ToList().AsQueryable().Cast<IDataObject>();
        }

        public override string Name
        {
            get
            {
                return "Enumerations";
            }
        }

        public override InterfaceType InterfaceType
        {
            get { return new InterfaceType(typeof(Enumeration)); }
        }
    }

    public class CompoundObjectInstanceListViewModel : InstanceListViewModel
    {
        public CompoundObjectInstanceListViewModel(
            IGuiApplicationContext appCtx,
            IKistlContext dataCtx,
            Module module)
            : base(appCtx, dataCtx, module)
        {
        }

        protected override IQueryable<IDataObject> GetQuery()
        {
            return DataContext.GetQuery<CompoundObject>().Where(i => i.Module == module).ToList().AsQueryable().Cast<IDataObject>();
        }

        public override string Name
        {
            get
            {
                return "Compound Objects";
            }
        }

        public override InterfaceType InterfaceType
        {
            get { return new InterfaceType(typeof(CompoundObject)); }
        }
    }

    public class AssemblyInstanceListViewModel : InstanceListViewModel
    {
        public AssemblyInstanceListViewModel(
            IGuiApplicationContext appCtx,
            IKistlContext dataCtx,
            Module module)
            : base(appCtx, dataCtx, module)
        {
        }

        protected override IQueryable<IDataObject> GetQuery()
        {
            return DataContext.GetQuery<Assembly>().Where(i => i.Module == module).ToList().AsQueryable().Cast<IDataObject>();
        }

        public override string Name
        {
            get
            {
                return "Assemblies";
            }
        }

        public override InterfaceType InterfaceType
        {
            get { return new InterfaceType(typeof(Assembly)); }
        }
    }

    public class ViewDescriptorInstanceListViewModel : InstanceListViewModel
    {
        public ViewDescriptorInstanceListViewModel(
            IGuiApplicationContext appCtx,
            IKistlContext dataCtx,
            Module module)
            : base(appCtx, dataCtx, module)
        {
        }

        protected override IQueryable<IDataObject> GetQuery()
        {
            return DataContext.GetQuery<ViewDescriptor>().Where(i => i.Module == module).ToList().AsQueryable().Cast<IDataObject>();
        }

        public override string Name
        {
            get
            {
                return "View Descriptors";
            }
        }

        public override InterfaceType InterfaceType
        {
            get { return new InterfaceType(typeof(ViewDescriptor)); }
        }
    }

    public class ViewModelDescriptorInstanceListViewModel : InstanceListViewModel
    {
        public ViewModelDescriptorInstanceListViewModel(
            IGuiApplicationContext appCtx,
            IKistlContext dataCtx,
            Module module)
            : base(appCtx, dataCtx, module)
        {
        }

        protected override IQueryable<IDataObject> GetQuery()
        {
            return DataContext.GetQuery<ViewModelDescriptor>().Where(i => i.Module == module).ToList().AsQueryable().Cast<IDataObject>();
        }

        public override string Name
        {
            get
            {
                return "ViewModel Descriptors";
            }
        }

        public override InterfaceType InterfaceType
        {
            get { return new InterfaceType(typeof(ViewModelDescriptor)); }
        }
    }

    public class RelationInstanceListViewModel : InstanceListViewModel
    {
        public RelationInstanceListViewModel(
            IGuiApplicationContext appCtx,
            IKistlContext dataCtx,
            Module module)
            : base(appCtx, dataCtx, module)
        {
        }

        protected override IQueryable<IDataObject> GetQuery()
        {
            return DataContext.GetQuery<Relation>().Where(i => i.Module == module).ToList().AsQueryable().Cast<IDataObject>();
        }

        public override string Name
        {
            get
            {
                return "Relations";
            }
        }

        public override InterfaceType InterfaceType
        {
            get { return new InterfaceType(typeof(Relation)); }
        }
    }
    #endregion
}
