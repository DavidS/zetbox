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

namespace Zetbox.Server.Wcf
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ServiceModel;
    using System.ServiceModel.Activation;
    using System.ServiceModel.Web;
    using System.Text;
    using System.Threading;
    using Autofac.Integration.Wcf;
    using Zetbox.API;
    using Zetbox.API.Configuration;
    using Zetbox.API.Utils;

    public class WcfServer
        : MarshalByRefObject, IZetboxAppDomain, IService, IDisposable
    {
        private readonly static log4net.ILog Log = log4net.LogManager.GetLogger("Zetbox.Server.Wcf");

        /// <summary>
        /// WCF Service Host
        /// </summary>
        private readonly ServiceHostBase _mainHost = null;

        private readonly ZetboxConfig _defaultConfig = null;

        /// <summary>
        /// WCF Service Thread
        /// </summary>
        private Thread serviceThread = null;

        /// <summary>
        /// Only to signal the server start
        /// </summary>
        private AutoResetEvent serverStarted = new AutoResetEvent(false);

        public WcfServer(AutofacServiceHostFactory factory, AutofacWebServiceHostFactory webFactory, ZetboxConfig config)
        {
            if (factory == null) { throw new ArgumentNullException("factory"); }
            if (webFactory == null) { throw new ArgumentNullException("webFactory"); }
            if (config == null) throw new ArgumentNullException("config");

            _defaultConfig = config;

            _mainHost = factory.CreateServiceHost(typeof(ZetboxService).AssemblyQualifiedName, new Uri[] { });
            _mainHost.UnknownMessageReceived += new EventHandler<UnknownMessageReceivedEventArgs>(host_UnknownMessageReceived);
            _mainHost.Faulted += host_Faulted;
            _mainHost.Closed += host_Closed;
            _mainHost.Opened += host_Opened;
        }

        void host_Opened(object sender, EventArgs e)
        {
            Log.Info("Host opened");
        }

        void host_Closed(object sender, EventArgs e)
        {
            Log.Info("Host closed");
        }

        public void Start()
        {
            this.Start(_defaultConfig);
        }

        /// <summary>
        /// Starts the WCF Server in the background. If the server hasn't 
        /// started successfully within 40 seconds, it is aborted and an 
        /// <see cref="InvalidOperationException"/> is thrown.
        /// </summary>
        /// <param name="config">the loaded configuration for the Server</param>
        public void Start(ZetboxConfig config)
        {
            if (config == null) throw new ArgumentNullException("config");

            if (config.AdditionalCommandlineOptions.ContainsKey(WcfModule.NoWcfKey))
            {
                Log.Info("Not starting embedded WCF Server. As requested by -nowcf.");
            }
            else
            {
                using (Log.InfoTraceMethodCall("Starting Server"))
                {
                    serviceThread = new Thread(new ThreadStart(this.RunWCFServer));
                    serviceThread.Start();

                    if (!serverStarted.WaitOne(40 * 1000, false))
                    {
                        throw new InvalidOperationException("Server did not start within 40 sec.");
                    }
                }
            }
        }

        /// <summary>
        /// Stops the WCF Server.
        /// </summary>
        public void Stop()
        {
            Log.Info("Stopping Server");

            if (_mainHost != null)
                _mainHost.Close();

            if (serviceThread != null && !serviceThread.Join(5000))
            {
                Log.Info("Server did not stop after 5s, aborting");
                serviceThread.Abort();
            }
            serviceThread = null;

            // Work around AppDomainUnloadedException due to Race with WCF's _host.Close()
            // See https://bugs.launchpad.net/nunitv2/+bug/423611
            Log.Info("Waiting for WCF to disappear");
            Thread.Sleep(3000);

            serverStarted.Close();

            Log.Info("Server stopped");
        }

        public string DisplayName { get { return "WCF-Service"; } }
        public string Description { get { return "A WCF-based method to access the service"; } }

        /// <summary>
        /// Executes the actual WcfHost in a separate thread and waits until shutdown.
        /// </summary>
        private void RunWCFServer()
        {
            try
            {
                using (Log.DebugTraceMethodCall("Starting WCF Server"))
                {
                    _mainHost.Open();
                    serverStarted.Set();
                }

                Log.Info("WCF Server started");

                while (_mainHost.State == CommunicationState.Opened)
                {
                    Thread.Sleep(100);
                }

                Log.Info("WCF Server: Hosts closed, exiting WCF thread");
            }
            catch (Exception error)
            {
                Log.Error("Unhandled exception while running WCF Server", error);
                throw;
            }
        }

        private void host_Faulted(object sender, EventArgs e)
        {
            Log.Warn("Host faulted: " + e);
        }

        private void host_UnknownMessageReceived(object sender, UnknownMessageReceivedEventArgs e)
        {
            Log.WarnFormat("UnknownMessageReceived: {0}", e.Message);
        }

        #region IDisposable Members

        // TODO: implement Dispose Pattern after 
        // http://msdn2.microsoft.com/en-us/library/ms244737.aspx
        public void Dispose()
        {
            Log.Info("Disposing WcfServer");

            if (_mainHost != null && _mainHost.State != CommunicationState.Closed)
            {
                _mainHost.Close();
                ((IDisposable)_mainHost).Dispose();
            }

            if (serverStarted != null)
            {
                serverStarted.Close();
                ((IDisposable)serverStarted).Dispose();
                serverStarted = null;
            }
        }

        #endregion
    }
}
