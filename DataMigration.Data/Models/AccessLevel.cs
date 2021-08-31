using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.Models
{
    public partial class AccessLevel
    {
        public AccessLevel()
        {
            AccessLevelDesignations = new HashSet<AccessLevelDesignation>();
        }

        public int AccessLevelId { get; set; }
        public string AccessLevelName { get; set; }
        public string Description { get; set; }
        public short IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool CanView { get; set; }
        public bool CanApprove { get; set; }
        public bool CanShare { get; set; }
        public bool CanSubscribe { get; set; }

        public virtual ICollection<AccessLevelDesignation> AccessLevelDesignations { get; set; }
    }
}
