using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Neo;
using Neo.Persistence.LevelDB;

namespace NeoHub
{
    public class Program
    {
        public static NeoSystem NeoSystem;

        public static void Main(string[] args)
        {
            InitializeNeoSystem(args);
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        private static void InitializeNeoSystem(string[] args)
        {
            LevelDBStore store = new LevelDBStore(NeoSettings.Default.DataDirectoryPath);
            NeoSystem = new NeoSystem(store);
            NeoSystem.StartNode(NeoSettings.Default.NodePort, NeoSettings.Default.WsPort);

            CreateWebHostBuilder(args).Build().Run();
        }
    }
}
