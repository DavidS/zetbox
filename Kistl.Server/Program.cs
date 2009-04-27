using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading;
using System.Diagnostics;

using Kistl.API.Configuration;
using Kistl.API.Server;

namespace Kistl.Server
{
    /// <summary>
    /// Hauptprogramm
    /// </summary>
    public sealed class Program
    {
        static void Main(string[] args)
        {
            string configFilePath;
            if (args.Length > 0 && !args[0].StartsWith("-"))
            {
                configFilePath = args[0];
            }
            else
            {
                configFilePath = "";
            }
            var config = KistlConfig.FromFile(configFilePath);
            var appCtx = new ServerApplicationContext(config);

            Server server = new Server();

            if (args.Length > 0)
            {
                bool actiondone = false;

                if (!string.IsNullOrEmpty(args.FirstOrDefault(a => a.Contains("-export"))))
                {
                    actiondone = true;
                    server.Export();
                }

                if (!string.IsNullOrEmpty(args.FirstOrDefault(a => a.Contains("-import"))))
                {
                    actiondone = true;
                    server.Import();
                }

                if (!string.IsNullOrEmpty(args.FirstOrDefault(a => a.Contains("-all"))))
                {
                    actiondone = true;
                    server.GenerateAll();
                }

                if (!string.IsNullOrEmpty(args.FirstOrDefault(a => a.Contains("-generate"))))
                {
                    actiondone = true;
                    server.GenerateCode();
                }

                if (!string.IsNullOrEmpty(args.FirstOrDefault(a => a.Contains("-database"))))
                {
                    actiondone = true;
                    server.GenerateDatabase();
                }

                if (actiondone)
                {
                    Console.WriteLine("Hit the anykey to exit");
                    Console.ReadKey();
                    Console.WriteLine("Shutting down");
                    return;
                }
            }

            server.Start(config);
            Console.WriteLine("Server started, press the anykey to exit");
            Console.ReadKey();
            Console.WriteLine("Shutting down");

            server.Stop();
        }

        /// <summary>
        /// prevent this class from being instantiated
        /// </summary>
        private Program() { }
    }
}
