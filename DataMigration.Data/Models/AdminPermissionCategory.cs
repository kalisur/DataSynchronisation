using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.Models
{
    public partial class AdminPermissionCategory
    {
        public int AdminPermissionCategoryId { get; set; }
        public string AdminPermissionCategoryName { get; set; }
        public int? ParentCategoryId { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
