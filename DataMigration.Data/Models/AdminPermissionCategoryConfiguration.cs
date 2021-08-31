using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.Models
{
    public partial class AdminPermissionCategoryConfiguration
    {
        public int AdminPermissionCategoryConfigurationId { get; set; }
        public int? AdminRoleTypeId { get; set; }
        public int? AdminPermissionCategoryId { get; set; }
        public int? AdminPermissionId { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
