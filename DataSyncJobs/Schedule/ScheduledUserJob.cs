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
    public class ScheduledUserJob : IJob
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<ScheduledUserJob> logger;


        public ScheduledUserJob()
        {

        }

        public async Task Execute(IJobExecutionContext context)
        {
            LoadUsers();
            await Task.CompletedTask;
        }

        public static void LoadUsers()
        {
            Console.WriteLine("Load user Job started !");
            try
            {
                var options = new DbContextOptionsBuilder<ERPContext>().UseSqlServer(Config.reportingDBConn).Options;
                var primaryDBoptions = new DbContextOptionsBuilder<SourceDBContext>().UseSqlServer(Config.primaryDBConn).Options;
                var context = new ERPContext(options);
                var sourceDbContext = new SourceDBContext(primaryDBoptions);

                var usersObjects = from objCoworker in sourceDbContext.DimensionCoworkers
                                   select new
                                   {
                                       Username = objCoworker.UserId,
                                       CoworkerId = objCoworker.CoworkerCode,
                                       FirstName = objCoworker.FirstName,
                                       LastName = objCoworker.LastName,
                                       Email = objCoworker.EmailAddress,
                                       ReportingManagerId = objCoworker.ManagerCoworkerCode,
                                       DepartmentId = objCoworker.CoworkerDepartmentCode,
                                       Designation = ""
                                   };


                Console.WriteLine("users count: {0}", usersObjects.Count());
                usersObjects = usersObjects.Skip(6000).Take(5);
                bool isExists = false;
                foreach (var item in usersObjects)
                {

                    try
                    {
                        isExists = false;
                        var objUser = new User();
                        objUser.Username = item.Username;
                        objUser.CoworkerId = item.CoworkerId;
                        objUser.FirstName = item.FirstName;
                        objUser.LastName = item.LastName;
                        objUser.Email = item.Email;
                        objUser.ReportingManagerId = item.ReportingManagerId;
                        objUser.DepartmentId = int.Parse(item.DepartmentId);
                        objUser.Designation = item.Designation;
                        objUser.IsActive = true;
                        objUser.CreatedDate = DateTime.Now;
                        objUser.ModifiedDate = DateTime.Now;
                        objUser.CreatedBy = "Kalidasu Surada";
                        objUser.ModifiedBy = "Ankamma B";

                        /* Update Or Add Logic*/

                        var id = objUser.Username;
                        if (context.Users.Any(e => e.Username == id))
                        {
                            isExists = true;
                            if (context.Users.Any(e => e.Username == id && e.CoworkerId != objUser.CoworkerId || e.FirstName != objUser.FirstName ||
                                e.LastName != objUser.LastName || e.Email != objUser.Email || e.ReportingManagerId != objUser.ReportingManagerId ||
                                e.DepartmentId != objUser.DepartmentId || e.Designation != objUser.Designation))
                            {
                                User d = context.Users.First(i => i.Username == id);
                                d.Username = objUser.Username;
                                d.CoworkerId = objUser.CoworkerId;
                                d.FirstName = objUser.FirstName;
                                d.LastName = objUser.LastName;
                                d.Email = objUser.Email;
                                d.ReportingManagerId = objUser.ReportingManagerId;
                                d.DepartmentId = objUser.DepartmentId;
                                d.Designation = objUser.Designation;
                                d.CreatedDate = DateTime.Now;
                                d.ModifiedDate = DateTime.Now;
                                d.CreatedBy = "Kalidasu Surada";
                                d.ModifiedBy = "Ankamma B";
                                context.SaveChanges();
                                Console.WriteLine("updated [User]:  name: {0} UserId: {1} Username: {2}", objUser.FirstName, objUser.UserId, objUser.Username);

                            }
                        }
                        if (!isExists)
                        {
                            context.Users.Add(objUser);
                            context.SaveChanges();
                            Console.WriteLine("created [User]:  name: {0} UserId: {1} Username: {2}", objUser.FirstName, objUser.UserId, objUser.Username);
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("[Exception]: {3} User [{0}]:  name: {1}  Username: {2}", (isExists ? "Edit" : "Create"), item.FirstName, item.Username, ex.Message);
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
