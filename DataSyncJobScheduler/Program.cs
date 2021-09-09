using System;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataSyncJobScheduler
{
    //class Program
    //{
    //    static async Task Main(string[] args)
    //    {
    //        try
    //        {
    //            await Functions.ConfigureScheduler();
    //            await Functions.ExecuteAsync();

    //            while (true)
    //            {

    //            }

    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //    }
    //}

    

    namespace QuartzTest
    {
        class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    //  Common.Logging.LogManager.Adapter = new Common.Logging.Simple.ConsoleOutLoggerFactoryAdapter { Level = Common.Logging.LogLevel.Info };

                    // Grab the Scheduler instance from the Factory 
                    IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler().Result;

                    // and start it off
                    scheduler.Start();

                    // define the job and tie it to our HelloJob class
                    IJobDetail job = JobBuilder.Create<HelloJob>()
                        .WithIdentity("job1", "group1")
                        .Build();

                    // Trigger the job to run now, and then repeat every 10 seconds
                    ITrigger trigger = TriggerBuilder.Create()
                        .WithIdentity("trigger1", "group1")
                        .StartNow()
                        .WithSimpleSchedule(x => x
                            .WithIntervalInSeconds(10)
                            .RepeatForever())
                        .Build();

                    // Tell quartz to schedule the job using our trigger
                    scheduler.ScheduleJob(job, trigger);

                    Functions.ConfigureScheduler();

                    // some sleep to show what's happening
                    // Thread.Sleep(TimeSpan.FromSeconds(60));

                    // and last shut down the scheduler when you are ready to close your program
                    while(true)
                    {

                    }
                    scheduler.Shutdown();
                }
                catch (SchedulerException se)
                {
                    Console.WriteLine(se);
                }

                //Console.WriteLine("Press any key to close the application");
                //Console.ReadKey();

            }

            public class HelloJob : IJob
            {

                public async Task Execute(IJobExecutionContext context)
                {
                    Console.WriteLine("Greetings from HelloJob!");                    
                }
            }

        }
    }
}
