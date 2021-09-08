using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class XrefDepartmentNodeCoworker
    {
        public int DepartmentTreeNode { get; set; }
        public string DepartmentNodeDescription { get; set; }
        public string DepartmentCoworkerCode { get; set; }
        public int DepartmentNodeLevel { get; set; }
        public string ModifiedByUserId { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
