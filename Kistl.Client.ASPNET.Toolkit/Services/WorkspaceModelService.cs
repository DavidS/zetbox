using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

using Kistl.API;
using Kistl.API.Client;
using Kistl.App.Base;
using Kistl.App.Extensions;
using Kistl.Client.Presentables;
using Kistl.Client.Presentables.ObjectBrowser;

namespace Kistl.Client.ASPNET.Toolkit
{
    [ServiceContract(Namespace = "Kistl.Client.ASPNET")] // Client side namespace
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class WorkspaceModelService
    {
        [OperationContract]
        public List<JavaScriptObjectMoniker> GetModules()
        {
            var workspace = KistlContextManagerModule.ModelFactory
                .CreateViewModel<WorkspaceViewModel.Factory>().Invoke(KistlContextManagerModule.KistlContext);

            return workspace.Modules.Select(i => new JavaScriptObjectMoniker(i)).ToList();
        }

        [OperationContract]
        public List<JavaScriptObjectMoniker> GetObjectClasses(int moduleID)
        {
            var workspace = KistlContextManagerModule.ModelFactory
                .CreateViewModel<WorkspaceViewModel.Factory>().Invoke(KistlContextManagerModule.KistlContext);

            return workspace.Modules.Single(m => m.ID == moduleID).ObjectClasses
                .Select(i => new JavaScriptObjectMoniker(i)).ToList();
        }

        [OperationContract]
        public List<JavaScriptObjectMoniker> GetInstances(int objectClassID)
        {
            // Dont use model - directly selecting is faster
            var objClass = KistlContextManagerModule.KistlContext.Find<ObjectClass>(objectClassID);
            return KistlContextManagerModule.KistlContext.GetQuery(objClass.GetDescribedInterfaceType())
                    .Select(i => new JavaScriptObjectMoniker(KistlContextManagerModule.KistlContext, i)).ToList();
        }
    }
}
