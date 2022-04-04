using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPark.Data;
using Microsoft.Extensions.DependencyInjection;

namespace MediaPark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*CreateHostBuilder(args).Build().Run();*/

            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {


                /*If the database is not found;
                It is created and loaded with test data. It loads test data into arrays rather than List<T> collections to optimize performance.
                If the database is found, it takes no action.*/

                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<ParkContext>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }

            host.Run();
        }
        private static void CreateDbIfNotExists(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<ParkContext>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
