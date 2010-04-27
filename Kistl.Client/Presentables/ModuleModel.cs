using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Kistl.API;
using Kistl.App.Base;
using Kistl.API.Configuration;

namespace Kistl.Client.Presentables
{
    public class ModuleModel : DataObjectModel
    {
        public new delegate ModuleModel Factory(IKistlContext dataCtx, Module mdl);

        public ModuleModel(
            IViewModelDependencies appCtx, KistlConfig config, IKistlContext dataCtx,
            Module mdl)
            : base(appCtx, config, dataCtx, mdl)
        {
            _module = mdl;
            _module.PropertyChanged += ModulePropertyChanged;
        }

        #region public interface

        private ObservableCollection<DataObjectModel> _objectClassesCache = null;
        public ObservableCollection<DataObjectModel> ObjectClasses
        {
            get
            {
                if (_objectClassesCache == null)
                {
                    _objectClassesCache = new ObservableCollection<DataObjectModel>();
                    LoadObjectClasses();
                }
                return _objectClassesCache;
            }
        }

        #endregion

        #region Utilities and UI callbacks

        private void LoadObjectClasses()
        {
            var datatypes = DataContext.GetQuery<ObjectClass>()
                .Where(dt => dt.Module.ID == _module.ID && !dt.IsSimpleObject)
                .OrderBy(dt => dt.Name);
            foreach (var dt in datatypes)
            {
                ObjectClasses.Add(ModelFactory.CreateViewModel<DataObjectModel.Factory>(dt).Invoke(DataContext, dt));
            }
        }

        #endregion

        #region PropertyChanged event handlers

        private void ModulePropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            switch (args.PropertyName)
            {
                case "Name": OnPropertyChanged("Name"); break;
            }
        }

        #endregion

        private Module _module;
    }
}
