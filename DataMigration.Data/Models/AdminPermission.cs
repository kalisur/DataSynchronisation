using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.Models
{
    public partial class AdminPermission
    {
        public int AdminPermissionId { get; set; }
        public string AdminPermissionName { get; set; }
        public int? AdminPermissionCategoryId { get; set; }
        public bool? IsView { get; set; }
        public bool? IsAdd { get; set; }
        public bool? IsEdit { get; set; }
        public bool? IsDelete { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
