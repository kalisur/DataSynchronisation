using DataMigration.Data;
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

namespace DataSyncJobs.Schedule
{
    public class ScheduledUserDepartmentJob : IJob
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<ScheduledUserJob> logger;


        public ScheduledUserDepartmentJob()
        {

        }

        public async Task Execute(IJobExecutionContext context)
        {

            LoadDepartments();
            await Task.CompletedTask;

        }



        public static void LoadDepartments()
        {
            //var jsonFile = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, @"Data\depatment.json"));
            //var jObject = JObject.Parse(jsonFile);


            var options = new DbContextOptionsBuilder<ERPContext>().UseSqlServer(Config.reportingDBConn).Options;
            var primaryDBoptions = new DbContextOptionsBuilder<SourceDBContext>().UseSqlServer(Config.primaryDBConn).Options;
            var context = new ERPContext(options);
            var sourceDbContext = new SourceDBContext(primaryDBoptions);

            var departmentObject = from dp in sourceDbContext.DimensionDepartments
                                   select new
                                   {
                                       DepartmentCode = dp.DepartmentCode,
                                       DepartmentName = dp.DepartmentDescription
                                   };

            try
            {
                foreach (var item in departmentObject)
                {
                    bool isExists = false;
                    var objDepartment = new Department();
                    objDepartment.DepartmentCode = item.DepartmentCode;
                    objDepartment.DepartmentName = item.DepartmentName;



                    /* Update Or Add Logic*/

                    var id = objDepartment.DepartmentCode;
                    if (context.Departments.Any(e => e.DepartmentCode == id))
                    {
                        isExists = true;
                        if (context.Departments.Any(e => e.DepartmentCode == id && e.DepartmentName != objDepartment.DepartmentName))
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
