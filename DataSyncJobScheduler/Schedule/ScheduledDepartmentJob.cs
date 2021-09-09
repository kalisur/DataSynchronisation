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
    public class ScheduledUserDepartmentJob : IJob
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<ScheduledUserJob> logger;


        public ScheduledUserDepartmentJob()
        {
           // this.logger = new Logger;
           // this.configuration = configuration;
        }

        public async Task Execute(IJobExecutionContext context)
        {

            // this.logger.LogWarning($"Hello from scheduled task {DateTime.Now.ToLongTimeString()}");

            LoadDepartments();
            await Task.CompletedTask;
            
        }

        public static void LoadDepartments()
        {
            string jsonFile = @"C:\RCOE\DataSynchronisation\DataMigration.Scheduler\Data\depatment.json";
            var json = File.ReadAllText(jsonFile);
            var jObject = JObject.Parse(json);

            var context = new ERPContext();

            try
            {


                foreach (var item in jObject["departments"])
                {
                    bool isExists = false;
                    var objDepartment = new Department();
                    objDepartment.DepartmentCode = item["GLDepartmentCode"].ToString();
                    objDepartment.DepartmentName = item["GLDepartmentDescription"].ToString();

                    objDepartment.IsActive = true;
                    objDepartment.CreatedDate = DateTime.Now;
                    objDepartment.ModifiedDate = DateTime.Now;
                    objDepartment.CreatedBy = "Kalidasu Surada";
                    objDepartment.ModifiedBy = "Ankamma B";

                    /* Update Or Add Logic*/

                    var id = objDepartment.DepartmentCode;
                    if(context.Departments.Any(e => e.DepartmentCode == id))
                    {
                        isExists = true;
                        if(context.Departments.Any(e => e.DepartmentCode == id && e.DepartmentName != objDepartment.DepartmentName))
                        {
                            Department d = context.Departments.First(i => i.DepartmentCode == id);
                            d.DepartmentName = objDepartment.DepartmentName;
                            d.CreatedDate = DateTime.Now;
                            d.ModifiedDate = DateTime.Now;
                            d.CreatedBy = "Kalidasu Surada";
                            d.ModifiedBy = "Ankamma B";
                            context.SaveChanges();
                        }
                    }
                    if (!isExists)
                    {
                        context.Departments.Add(objDepartment);
                        context.SaveChanges();

                    }

                }
                Console.WriteLine("Process Completed...!");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
