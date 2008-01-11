using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Kistl.API.Client;

namespace Kistl.Client
{
    public class Client : MarshalByRefObject, Kistl.API.IKistlAppDomain
    {
        public Client()
        {
        }

        /// <summary>
        /// Das KistService
        /// </summary>
        private Kistl.API.IKistlAppDomain server = null;

        /// <summary>
        /// AppDomain, in der das KistService rennt.
        /// </summary>
        private AppDomain serverDomain = null;

        #region IKistlAppDomain Members

        public void Start()
        {
            if (Kistl.API.Configuration.KistlConfig.Current.Server.StartServer)
            {
                SplashScreen.SetInfo("Starting Server");
                // Create a new AppDomain for the Server!
                // Damit trennt man den Server schön brav vom Client & kann 
                // CustomActionsManagerFactory.Init zwei mal aufrufen :-)
                serverDomain = AppDomain.CreateDomain("ServerAppDomain");
                Kistl.API.APIInit initServer = (Kistl.API.APIInit)serverDomain.CreateInstanceAndUnwrap("Kistl.API", "Kistl.API.APIInit");
                initServer.Init(Kistl.API.Configuration.KistlConfig.Current.ConfigFilePath);
                server = (Kistl.API.IKistlAppDomain)serverDomain.CreateInstanceAndUnwrap("Kistl.Server", "Kistl.Server.Server");
                server.Start();
            }

            API.CustomActionsManagerFactory.Init(new CustomActionsManagerClient());
        }

        public void Stop()
        {
            if (server != null)
            {
                try
                {
                    server.Stop();
                }
                catch(Exception ex)
                {
                    System.Diagnostics.Trace.TraceError(ex.ToString());
                    // TODO: Bad Hack, Do Something!
                    AppDomain.Unload(serverDomain);
                }
                server = null;
            }
        }

        #endregion
    }
}
