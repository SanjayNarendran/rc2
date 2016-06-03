using System;
using Microsoft.AspNetCore.Hosting;

namespace corerc2firstapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();

            host.Run();
                
            Console.WriteLine("Hello World!");
        }
    }
}
