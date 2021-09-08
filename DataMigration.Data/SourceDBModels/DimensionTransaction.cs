using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionTransaction
    {
        public string TransactionCode { get; set; }
        public string TransactionDescription { get; set; }
        public string TransactionTypeCode { get; set; }
        public bool? IsPartnerDirectRevenue { get; set; }
        public bool? HasCdwinternalSoftwareProgram { get; set; }
        public bool? DetailShowHeaderNonEdcrevenue { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
