using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class FactCommissionAdjustment1
    {
        public int? CommissionMonthInt { get; set; }
        public int? AdjustmentDateInt { get; set; }
        public string CompanyCode { get; set; }
        public string CoworkerCode { get; set; }
        public string CustomerCode { get; set; }
        public string AdjustmentTypeCode { get; set; }
        public string AdjustmentReasonDescription { get; set; }
        public decimal? AdjustmentGrossProfitDollarAmount { get; set; }
        public decimal? AdjustmentSalesDollarAmount { get; set; }
    }
}
