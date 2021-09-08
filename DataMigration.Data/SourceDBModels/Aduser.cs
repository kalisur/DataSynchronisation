using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class Aduser
    {
        public int Id { get; set; }
        public string Dn { get; set; }
        public string Cn { get; set; }
        public string MemberOf { get; set; }
        public string Sn { get; set; }
        public string Givenname { get; set; }
        public string Displayname { get; set; }
        public string Name { get; set; }
        public string Samaccountname { get; set; }
        public string Mail { get; set; }
        public string Employeenumber { get; set; }
        public string EmployeeId { get; set; }
        public string GroupName { get; set; }
        public string DistributionTypeDescription { get; set; }
    }
}
