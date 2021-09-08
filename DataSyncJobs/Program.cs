using System;
using System.Threading.Tasks;

namespace DataSyncJobs
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                await DataSyncJobs.Functions.ConfigureScheduler();
                await DataSyncJobs.Functions.ExecuteAsync();
              
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
