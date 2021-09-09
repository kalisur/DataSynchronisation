using DataSyncJobs.Schedule;
using Quartz;
using Quartz.Impl;
using Quartz.Spi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSyncJobs
{
    public class Functions
    {
        public static IScheduler scheduler = new StdSchedulerFactory().GetScheduler().Result;
        public static async Task ConfigureScheduler()
        {

            // Departments

            //var deptJob = JobBuilder.Create<ScheduledUserDepartmentJob>().WithIdentity("Departments.job", "group2")
            //     .Build(); ;

            //var deptJobTrigger = TriggerBuilder.Create()
            //  .WithIdentity($"Departmenta.trigger", "group2")
            //  .StartNow()
            //  .WithSimpleSchedule
            //   (s =>
            //      s.WithInterval(TimeSpan.FromSeconds(60))
            //   )
            //   .Build();

            //await scheduler.ScheduleJob(deptJob, deptJobTrigger);


            // Users


            var usersJob = JobBuilder.Create<ScheduledUserJob>().WithIdentity("Users.job", "group1")
                  .Build(); ;

            var userJobTrigger = TriggerBuilder.Create()
                .WithIdentity($"Users.trigger", "group1")
                .StartNow()
                .WithSimpleSchedule
                 (s =>
                    s.WithInterval(TimeSpan.FromSeconds(10))
                 )
                 .Build();

            await scheduler.ScheduleJob(usersJob, userJobTrigger);


        }
        public static async Task ExecuteAsync()
        {
            await scheduler.Start();
        }

    }
}
