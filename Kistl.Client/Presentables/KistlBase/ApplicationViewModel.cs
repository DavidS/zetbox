using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kistl.API;
using Kistl.API.Client;

namespace Kistl.Client.Presentables.KistlBase
{
    public class ApplicationViewModel : ViewModel
    {
        public ApplicationViewModel(
            IGuiApplicationContext appCtx, IKistlContext dataCtx,
            string name, Type wndMdlType)
            : base(appCtx, dataCtx)
        {
            _name = name;
            _wndMdlType = wndMdlType;
        }

        private Type _wndMdlType;
        public Type WindowModelType
        {
            get
            {
                return _wndMdlType;
            }
        }

        private string _name;
        public override string Name
        {
            get { return _name; }
        }

        #region Open Applicaton

        private static OpenApplicatonCommand _openApplicatonCommand = null;
        public ICommand OpenApplicatonCommand
        {
            get
            {
                if (_openApplicatonCommand == null)
                {
                    _openApplicatonCommand = new OpenApplicatonCommand(AppContext, DataContext);
                }
                return _openApplicatonCommand;
            }
        }

        #endregion
    }


    internal class OpenApplicatonCommand : CommandModel
    {
        public OpenApplicatonCommand(IGuiApplicationContext appCtx, IKistlContext dataCtx)
            : base(appCtx, dataCtx, "Open Application", "Opens an Application in a new window")
        {
        }

        public override bool CanExecute(object data)
        {
            return data != null
                && data is ApplicationViewModel;
        }

        protected override void DoExecute(object data)
        {
            if (CanExecute(data))
            {
                var externalCtx = KistlContext.GetContext();
                var appMdl = data as ApplicationViewModel;

                // responsibility to externalCtx's disposal passes to newWorkspace
                var newWorkspace = ModelFactory.CreateModel(appMdl.WindowModelType, externalCtx, new object[] { });
                ModelFactory.ShowModel(newWorkspace, true);
            }
        }
    }
}
