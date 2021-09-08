using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class FactOpportunityTangible
    {
        public string OrderCode { get; set; }
        public int? ExpectedCloseDateInt { get; set; }
        public int? ExpectedShipDateInt { get; set; }
        public decimal? ProbabilityToClosePercent { get; set; }
        public short? QuoteStatusCode { get; set; }
        public int? CompetitorCode { get; set; }
        public string OrderNotes { get; set; }
        public short? QuoteStageCode { get; set; }
        public string OpportunityDistributionCenterCode { get; set; }
        public string OpportunityAllocationToken { get; set; }
        public int? OpportunityRtaintentionCode { get; set; }
        public int OpportunityCartSubTypeCode { get; set; }
        public short OpportunityOwnerTypeCode { get; set; }
        public string OpportunityOriginalOrderCode { get; set; }
        public string OpportunityOriginalInvoiceCode { get; set; }
        public bool? OpportunitySalesMgrCallConfirm { get; set; }
        public string OpportunityPartialShipCode { get; set; }
        public short PipeLineSolutionTypeCode { get; set; }
        public string OpportunityDescription { get; set; }
        public short SecondaryPipelineSolutionTypeCode { get; set; }
        public int OpportunityModifiedDateInt { get; set; }
        public short PipelineDealRegistrationStatus { get; set; }
        public int SoftwareDealGroupCode { get; set; }
        public string PrimarySpecialistCoworkerCode { get; set; }
        public string SecondarySpecialistCoworkerCode { get; set; }
        public int CartTypeCode { get; set; }
        public decimal? TotalSoftwareIncentiveDollarAmount { get; set; }
        public decimal? MonthlyRecurringRevenueDollarAmount { get; set; }
        public int? SubscriptionLenghtInMonths { get; set; }
        public string ProductVendor { get; set; }
        public string SoftwareProgramS { get; set; }
        public string EaopportunityCode { get; set; }
        public byte? DealProgress { get; set; }
        public string SoftwareOrderType { get; set; }
        public string EnrollmentNumber { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
