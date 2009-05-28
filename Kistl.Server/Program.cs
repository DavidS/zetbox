using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading;
using System.Diagnostics;

using Kistl.API.Configuration;
using Kistl.API.Server;
using System.Collections;

namespace Kistl.Server
{
    /// <summary>
    /// Mainprogramm
    /// </summary>
    public static class Program
    {
        private static void PrintHelp()
        {
            Console.WriteLine("Use: Kistl.Server [<configfile.xml>]");
            Console.WriteLine("                  [-generate]");
            Console.WriteLine("                  [-export <destfile.xml> <namespace> [<namespace> ...]]");
            Console.WriteLine("                  [-import <sourcefile.xml]");
            Console.WriteLine("                  [-checkschema [meta | <schema.xml>]]");
            Console.WriteLine("                  [-updateschema [<schema.xml>]]");
            Console.WriteLine("                  [-all]");
        }

        static void Main(string[] args)
        {
            try
            {
                var config = InitApplicationContext(args);

                Server server = new Server();
                IEnumerator<string> arg = args.ToList().GetEnumerator();
                bool actiondone = false;
                while (arg.MoveNext())
                {
                    if (arg.Current == "-export")
                    {
                        if (!arg.MoveNext()) { PrintHelp(); return; }
                        string file = arg.Current;
                        List<string> namespaces = new List<string>();
                        while (arg.MoveNext())
                        {
                            if (!arg.Current.StartsWith("-"))
                            {
                                namespaces.Add(arg.Current);
                            }
                            else
                            {
                                break;
                            }
                        }
                        server.Export(file, namespaces.ToArray());
                        actiondone = true;
                    }

                    if (arg.Current == "-import")
                    {
                        if (!arg.MoveNext()) { PrintHelp(); return; }
                        string file = arg.Current;
                        server.Import(file);
                        actiondone = true;
                    }

                    if (arg.Current == "-checkschema")
                    {
                        string file = "";
                        if (arg.MoveNext())
                        {
                            if (arg.Current == "meta")
                            {
                                server.CheckSchemaFromCurrentMetaData();
                            }
                            else if (!arg.Current.StartsWith("-"))
                            {
                                file = arg.Current;
                                server.CheckSchema(file);
                            }
                            else
                            {
                                PrintHelp();
                            }
                        }
                        else
                        {
                            server.CheckSchema();
                        }
                        actiondone = true;
                    }

                    if (arg.Current == "-updateschema")
                    {
                        string file = "";
                        if (arg.MoveNext() && !arg.Current.StartsWith("-"))
                        {
                            file = arg.Current;
                            server.UpdateSchema(file);
                        }
                        else
                        {
                            server.UpdateSchema();
                        }
                        actiondone = true;
                    }

                    if (arg.Current == "-all")
                    {
                        //server.GenerateAll();
                        Console.WriteLine("Not supported yet");
                        actiondone = true;
                    }

                    if (arg.Current == "-generate")
                    {
                        server.GenerateCode();
                        actiondone = true;
                    }
                }

                if (actiondone)
                {
                    Console.WriteLine("Hit the anykey to exit");
                    Console.ReadKey();
                    Console.WriteLine("Shutting down");
                }
                else
                {
                    server.Start(config);

                    Console.WriteLine("Server started, press the anykey to exit");
                    Console.ReadKey();
                    Console.WriteLine("Shutting down");

                    server.Stop();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.TraceError("Server Application failed: \n" + ex.ToString());
            }
        }

        private static KistlConfig InitApplicationContext(string[] args)
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
            return config;
        }
    }
}
