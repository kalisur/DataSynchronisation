using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class FactSalesGoalCoworker
    {
        public string SalesGoalSegmentDescription { get; set; }
        public int Month { get; set; }
        public string CoworkerCode { get; set; }
        public decimal? SalesGoalDollarAmount { get; set; }
        public decimal? ProfitGoalDollarAmount { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
