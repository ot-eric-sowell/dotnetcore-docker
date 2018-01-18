using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace dotnetdock
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls(GetUrlsFromEnvironment())
                .Build();


        private static string GetUrlsFromEnvironment()
        {
            int port;

            if (!int.TryParse(Environment.GetEnvironmentVariable("PORT"), out port))
                port = 3000;
            
            return $"http://0.0.0.0:{port}";
        }
    }
}
