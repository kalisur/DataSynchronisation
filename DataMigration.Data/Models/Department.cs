using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.Models
{
    public partial class Department
    {
        public Department()
        {
            AccessLevelDesignations = new HashSet<AccessLevelDesignation>();
            Feedbacks = new HashSet<Feedback>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentCode { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string DepartmentPrefix { get; set; }
        public string DepartmentDescription { get; set; }

        public virtual ICollection<AccessLevelDesignation> AccessLevelDesignations { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
