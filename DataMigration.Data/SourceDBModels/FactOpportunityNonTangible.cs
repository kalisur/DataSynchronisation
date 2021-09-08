using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class FactOpportunityNonTangible
    {
        public int CartCode { get; set; }
        public string OrderCode { get; set; }
        public int SoftwarePipelineCartItemCode { get; set; }
        public int CartTypeCode { get; set; }
        public int PipelineCartExtCode { get; set; }
        public int VendorProductCode { get; set; }
        public int? IsOptionalFlag { get; set; }
        public int? PurchasePeriodCode { get; set; }
        public int? IsmonthlyFlag { get; set; }
        public int? IncentiveCode { get; set; }
        public int? SubscriptionTerm { get; set; }
        public int? Quantity { get; set; }
        public decimal? SellPriceDollarAmount { get; set; }
        public decimal? TotalIncentiveDollarAmount { get; set; }
        public int NoLongerExistsInWinSalesFlag { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
