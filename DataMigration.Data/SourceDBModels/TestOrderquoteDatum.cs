using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class TestOrderquoteDatum
    {
        public string OrderCode { get; set; }
        public string ExpectedCloseDate { get; set; }
        public string ExpectedShipDate { get; set; }
        public string ProbabilityToClosePercent { get; set; }
        public string QuoteStatusCode { get; set; }
        public string CompetitorCode { get; set; }
        public string Notes { get; set; }
        public string CreateDate { get; set; }
        public string UpdateDate { get; set; }
        public string QuoteStageCode { get; set; }
        public string OwnerTypeId { get; set; }
        public string OriginalOrderCode { get; set; }
        public string OriginalInvoiceCode { get; set; }
        public string SolutionTypeId { get; set; }
        public string SolutionSubTypeId { get; set; }
        public string ScrubState { get; set; }
        public string IsTaskInternational { get; set; }
        public string DealRegistrationStatus { get; set; }
        public string UserId { get; set; }
    }
}
