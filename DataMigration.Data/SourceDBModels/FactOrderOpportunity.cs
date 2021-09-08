using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class FactOrderOpportunity
    {
        public int OrderSeq { get; set; }
        public int? ExpectedCloseDateSeq { get; set; }
        public int? ExpectedShipDateSeq { get; set; }
        public decimal? ProbabilityToClosePercent { get; set; }
        public short? QuoteStatusSeq { get; set; }
        public int? CompetitorSeq { get; set; }
        public string OrderNotes { get; set; }
        public short? QuoteStageCode { get; set; }
        public short OpportunityDistributionCenterSeq { get; set; }
        public string OpportunityAllocationToken { get; set; }
        public int? OpportunityRtaintentionCode { get; set; }
        public short OpportunityCartSubTypeSeq { get; set; }
        public short OpportunityOwnerTypeSeq { get; set; }
        public int OpportunityOriginalOrderSeq { get; set; }
        public int OpportunityOriginalInvoiceSeq { get; set; }
        public byte? OpportunitySalesMgrCallConfirm { get; set; }
        public short OpportunityPartialShipSeq { get; set; }
        public short PipeLineSolutionTypeSeq { get; set; }
        public string OpportunityDescription { get; set; }
        public short SecondaryPipelineSolutionTypeSeq { get; set; }
        public int OpportunityModifiedDateSeq { get; set; }
        public short PipelineDealRegistrationStatusSeq { get; set; }
        public int SoftwareDealGroupSeq { get; set; }
        public string ProductVendor { get; set; }
        public string SoftwareProgramS { get; set; }
        public string EaopportunityCode { get; set; }
        public byte? DealProgress { get; set; }
        public string SoftwareOrderType { get; set; }
        public string EnrollmentNumber { get; set; }
        public decimal? TotalSoftwareIncentiveDollarAmount { get; set; }
        public int? PrimarySpecialistCoworkerSeq { get; set; }
        public int? SecondarySpecialistCoworkerSeq { get; set; }
        public short CartTypeSeq { get; set; }
        public decimal? MonthlyRecurringRevenueAmount { get; set; }
        public int? SubscriptionLenghtInMonths { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
