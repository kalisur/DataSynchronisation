using DataMigration.Data.Contex;
using DataMigration.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Quartz;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DataSyncJobScheduler.Schedule
{
    public class ScheduledUserJob : IJob
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<ScheduledUserJob> logger;


        public ScheduledUserJob()
        {
           // this.logger = logger;
           // this.configuration = configuration;
        }

        public async Task Execute(IJobExecutionContext context)
        {

           // this.logger.LogWarning($"Hello from scheduled task {DateTime.Now.ToLongTimeString()}");

            LoadUsers();
            //LoadDepartments();

            await Task.CompletedTask;
            
        }

        public static void LoadUsers()
        {
            Console.WriteLine("Load user Job started !");
            //string jsonFile = @"C:\RCOE\DataSynchronisation\DataMigration.Scheduler\Data\data.json";
            //var json = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, @"Data\data.json"));
            //var jObject = JObject.Parse(json);
            //Console.WriteLine(json);
            //Console.WriteLine("coming to load users");
            //var context = new ERPContext();

            //try
            //{ 

            //    foreach (var item in jObject["coworker"])
            //    {

            //        try
            //        {
            //            bool isExists = false;
            //            var objUser = new User();
            //            objUser.Username = item["UserID"].ToString();
            //            objUser.CoworkerId = item["CoworkerCode"].ToString();
            //            objUser.FirstName = item["FirstName"].ToString();
            //            objUser.LastName = item["LastName"].ToString();
            //            objUser.Email = item["EmailAddress"].ToString();
            //            objUser.ReportingManagerId = (item["ManagerCoworkerCode"]).ToString(); ;
            //            objUser.DepartmentId = (int)item["CoworkerGLDepartmentCode"];
            //            objUser.Designation = item["CoworkerTitleDescription"].ToString();
            //            objUser.IsActive = true;
            //            objUser.CreatedDate = DateTime.Now;
            //            objUser.ModifiedDate = DateTime.Now;
            //            objUser.CreatedBy = "Kalidasu Surada";
            //            objUser.ModifiedBy = "Ankamma B";

            //            /* Update Or Add Logic*/

            //            var id = objUser.Username;
            //            if (context.Users.Any(e => e.Username == id))
            //            {
            //                isExists = true;
            //                if (context.Users.Any(e => e.Username == id && e.CoworkerId != objUser.CoworkerId || e.FirstName != objUser.FirstName ||
            //                    e.LastName != objUser.LastName || e.Email != objUser.Email || e.ReportingManagerId != objUser.ReportingManagerId ||
            //                    e.DepartmentId != objUser.DepartmentId || e.Designation != objUser.Designation))
            //                {
            //                    User d = context.Users.First(i => i.Username == id);
            //                    d.Username = objUser.Username;
            //                    d.CoworkerId = objUser.CoworkerId;
            //                    d.FirstName = objUser.FirstName;
            //                    d.LastName = objUser.LastName;
            //                    d.Email = objUser.Email;
            //                    d.ReportingManagerId = objUser.ReportingManagerId;
            //                    d.DepartmentId = objUser.DepartmentId;
            //                    d.Designation = objUser.Designation;

            //                    d.CreatedDate = DateTime.Now;
            //                    d.ModifiedDate = DateTime.Now;
            //                    d.CreatedBy = "Kalidasu Surada";
            //                    d.ModifiedBy = "Ankamma B";
            //                    context.SaveChanges();
            //                }
            //            }
            //            if (!isExists)
            //            {
            //                context.Users.Add(objUser);
            //                context.SaveChanges();

            //            }

            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine(ex.Message);
            //        }
            //    }
            //    Console.WriteLine("Process Completed...! users");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

        }

      
    }
}
