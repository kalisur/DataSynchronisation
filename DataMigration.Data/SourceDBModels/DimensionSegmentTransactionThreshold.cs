using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionSegmentTransactionThreshold
    {
        public int TransactionThresholdSeq { get; set; }
        public string NodeLevel { get; set; }
        public string NodeDescription { get; set; }
        public string ThresholdAmount { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
