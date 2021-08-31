using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.Models
{
    public partial class AdminUser
    {
        public int AdminUserId { get; set; }
        public int UserId { get; set; }
        public int AdminRoleId { get; set; }
        public int? DepartmentId { get; set; }
        public int? UserGroupId { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
