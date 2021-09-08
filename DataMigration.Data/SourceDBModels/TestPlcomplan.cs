using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class TestPlcomplan
    {
        public string CompPlan { get; set; }
        public string Description { get; set; }
        public string MonthsToPayAfterTerm { get; set; }
        public string MonthsInPositionCalc { get; set; }
        public string ManageNegativeCreditBal { get; set; }
        public string CompStatementUsed { get; set; }
        public string SuppressAdjEmails { get; set; }
        public string EffStart { get; set; }
        public string EffEnd { get; set; }
        public string EarnType { get; set; }
        public string FieldCoverageQualified { get; set; }
        public string ManageNegativePaymentBal { get; set; }
        public string DrawSubtractedFromPay { get; set; }
        public string FincomUsed { get; set; }
        public string AccrualAccount { get; set; }
        public string SrvAllocationDesc { get; set; }
        public string RptCreditTypeMapping { get; set; }
        public string SuppressSubscrTxns { get; set; }
        public string SuppressHmstxns { get; set; }
        public string WfallowSplit { get; set; }
        public string FieldSeller { get; set; }
        public string ApplyGoalQualifier { get; set; }
    }
}
