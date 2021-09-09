using Azure.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DataSyncJobs
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                //var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                // var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

                //Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(Configuration).CreateLogger();

               
                await DataSyncJobs.Functions.ConfigureScheduler();
                await DataSyncJobs.Functions.ExecuteAsync();
              


                while (!Functions.scheduler.IsShutdown)
                {
                    //waiting for shutdown to be completed
                    Thread.Sleep(10000);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
