using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimCustomerAssignmentAccountManager
    {
        public int DimCustomerAssignmentAccountManagerId { get; set; }
        public string CustomerCode { get; set; }
        public string CoWorkerCode { get; set; }
        public short? AccountManagerOrdinal { get; set; }
        public decimal AccountManagerAllocationPercent { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
        public DateTime ValidFmTs { get; set; }
        public DateTime ValidToTs { get; set; }
    }
}
