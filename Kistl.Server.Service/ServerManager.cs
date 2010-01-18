using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Autofac;
using Kistl.API;
using Kistl.API.Configuration;
using Kistl.API.Utils;

namespace Kistl.Server.Service
{
    /// <summary>
    /// Manages starting a WCF Server in a new AppDomain which has only the AssemblyLoader initialized.
    /// </summary>
    public class ServerManager
        : MarshalByRefObject, IKistlAppDomain, IDisposable
    {
        private IContainer container;
        private IKistlAppDomain wcfServer;

        public void Start(KistlConfig config)
        {
            if (container != null) { throw new InvalidOperationException("already started"); }
            
            Logging.Configure();

            container = Program.CreateMasterContainer(config);

            var appCtx = new ServerApplicationContext(config);

            Program.DefaultInitialisation();

            wcfServer = container.Resolve<IKistlAppDomain>();
            wcfServer.Start(config);
        }

        public void Stop()
        {
            if (wcfServer != null) { throw new InvalidOperationException("not yet started"); }
            wcfServer.Stop();
            if (container != null) { container.Dispose(); }
        }

        public void Dispose()
        {
            Stop();
        }
    }
}
