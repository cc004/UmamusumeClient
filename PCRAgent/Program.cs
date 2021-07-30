using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace PCRAgent
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //webBuilder.UseKestrel(option => option.ListenAnyIP(443, o => o.UseHttps(new X509Certificate2(File.ReadAllBytes("cert.pfx")))));
                    //webBuilder.UseUrls("https://localhost/");
                    webBuilder.UseUrls("http://localhost/");
                    webBuilder.UseStartup<Startup>();
                });
    }
}
