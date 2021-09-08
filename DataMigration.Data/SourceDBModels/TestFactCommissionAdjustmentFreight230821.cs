using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class TestFactCommissionAdjustmentFreight230821
    {
        public string CompanyCode { get; set; }
        public string CoworkerCode { get; set; }
        public int CommissionMonth { get; set; }
        public int DateAdjustment { get; set; }
        public string InvoiceCode { get; set; }
        public int InvoiceLineNumber { get; set; }
        public int FreightAdjustmentNumber { get; set; }
        public string FreightAdjustmentStatusCode { get; set; }
        public string FreightAdjustmentStatusDescription { get; set; }
        public string OrderCode { get; set; }
        public string OrderActionReason { get; set; }
        public string ItemCode { get; set; }
        public decimal? WeightTotal { get; set; }
        public decimal? WeightUnit { get; set; }
        public decimal? LineQuantity { get; set; }
        public decimal? PercentTotalWeightCost { get; set; }
        public decimal? GrossProfitAdjustmentDollarAmount { get; set; }
        public decimal? GrossProfitAdjustmentDollarAmountOriginal { get; set; }
        public int CreatedDate { get; set; }
        public string CoworkerCodeCreated { get; set; }
        public string ProgramCreated { get; set; }
        public int ModifiedDate { get; set; }
        public string CoworkerCodeModified { get; set; }
        public string AccountManagerCoworkerCode { get; set; }
        public string Cdwstate { get; set; }
        public string Cdwcity { get; set; }
        public string Cdwneighborhood { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
