using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionOrderAction
    {
        public string OrderActionCode { get; set; }
        public string OrderActionDescription { get; set; }
        public string OrderActionReasonCode { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
