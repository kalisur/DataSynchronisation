using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class FactRenewal
    {
        public int RenewalId { get; set; }
        public int RenewalLineNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public int InvoiceLineNo { get; set; }
        public DateTime RenewalDate { get; set; }
        public int CustomerId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string ProductCode { get; set; }
        public int? SystemCoverageLengthInMonths { get; set; }
        public int? UserCoverageLengthInMonths { get; set; }
        public byte UserCoverageOverrideFlag { get; set; }
        public DateTime ExpectedStartDate { get; set; }
        public DateTime? ExpectedEndDate { get; set; }
        public byte RenewalItemBundleFlag { get; set; }
        public int? ParentRenewalLineNumber { get; set; }
        public int? SalesQuantity { get; set; }
        public decimal? SalesDollarAmount { get; set; }
        public decimal? SimCostDollarAmount { get; set; }
        public int? AdHocRenewalQuantity { get; set; }
        public decimal? AdHocRenewalSalesDollarAmount { get; set; }
        public decimal? AdHocRenewalLandedCost { get; set; }
        public decimal? AdHocRenewalLandedMargin { get; set; }
        public int ParentOrder { get; set; }
        public string RenewalTypeDescription { get; set; }
        public string RenewalReasonCode { get; set; }
        public byte RenewalStatusId { get; set; }
        public string RenewalStatus { get; set; }
        public byte RenewalSourceCode { get; set; }
        public string RenewalSourceDescription { get; set; }
        public string ModifiedByCoworkerEd { get; set; }
        public byte RenewalCancelledFlag { get; set; }
        public byte OrderLevelFlag { get; set; }
        public string PursuerCoworkerId { get; set; }
        public string DelegatedCoworkerId { get; set; }
        public DateTime? DelegatedDate { get; set; }
        public byte AdHocRenewalFlag { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
