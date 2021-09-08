using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionCommissionEventType
    {
        public string EventType { get; set; }
        public DateTime EffectiveStartDate { get; set; }
        public string AdjustmentIndicator { get; set; }
        public DateTime EffectiveEndDate { get; set; }
        public string AllowOverlayIndicator { get; set; }
        public string AllowSplitIndicator { get; set; }
        public string AllowRollupIndicator { get; set; }
        public string AllowReductionIndicator { get; set; }
        public string ForcedCreditType { get; set; }
        public string EventTypeComment { get; set; }
        public string SuppressCreditIndicator { get; set; }
        public string RequiresAdjustmentTypeIndicator { get; set; }
        public int CreditPushMonths { get; set; }
        public string AllowCustomerAcceleratorIndicator { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
