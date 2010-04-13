using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;

using Autofac;
using Kistl.API;
using Kistl.API.Configuration;
using Kistl.API.Utils;
using Kistl.App.Extensions;

namespace Kistl.Client.ASPNET.Toolkit
{
    public class KistlContextManagerModule : IHttpModule, IDisposable
    {
        public static IKistlContext KistlContext
        {
            get
            {
                return (IKistlContext)HttpContext.Current.Items["__Current_KistlContextManagerModule_KistlContext"];
            }
            private set
            {
                HttpContext.Current.Items["__Current_KistlContextManagerModule_KistlContext"] = value;
            }
        }

        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            if (context == null) { throw new ArgumentNullException("context"); }

            context.BeginRequest += new EventHandler(context_BeginRequest);
            context.EndRequest += new EventHandler(context_EndRequest);
        }

        void context_EndRequest(object sender, EventArgs e)
        {
            if (KistlContext != null)
            {
                KistlContext.Dispose();
                KistlContext = null;
            }
        }

        void context_BeginRequest(object sender, EventArgs e)
        {
            if (GuiApplicationContext.Current == null)
            {
                Logging.Configure();

                var config = KistlConfig.FromFile(HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings["configFile"]));
                AssemblyLoader.Bootstrap(AppDomain.CurrentDomain, config);

                var builder = Kistl.API.Utils.AutoFacBuilder.CreateContainerBuilder(config, config.Client.Modules);
                var container = builder.Build();

                // initialise custom actions manager
                var cams = container.Resolve<BaseCustomActionsManager>();

            }
            KistlContext = Kistl.API.Client.KistlContext.GetContext();
        }
    }
}
