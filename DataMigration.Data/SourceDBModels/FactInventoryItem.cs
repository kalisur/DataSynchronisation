using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class FactInventoryItem
    {
        public DateTime InventoryDate { get; set; }
        public string CompanyCode { get; set; }
        public string ItemCode { get; set; }
        public string WarehouseCode { get; set; }
        public string DistributionCenterZone { get; set; }
        public string PrimaryBin { get; set; }
        public decimal? QuantityPhysical { get; set; }
        public decimal? QuantityOnOrder { get; set; }
        public decimal? QuantityAllocated { get; set; }
        public decimal? QuantityOnBackOrder { get; set; }
        public decimal? QuantityAvailable { get; set; }
        public decimal? QuantityInTransit { get; set; }
        public decimal? QuantityInPicking { get; set; }
        public decimal? QuantityCreditBackOrder { get; set; }
        public decimal? SimCostDollarAmount { get; set; }
        public decimal? ItemLogisticsCostOfGoods { get; set; }
        public decimal? LogisticsLast30DayShippedQuantity { get; set; }
        public decimal? LogisticsLast30DayDollarAmount { get; set; }
        public DateTime? LogisticsLastInvoiceDate { get; set; }
        public decimal? SupplierStock { get; set; }
        public decimal? BidWinnerStock { get; set; }
        public int? DecliningRunRate { get; set; }
        public decimal? ConsignmentCatalogUnitDollarAmount { get; set; }
        public string ConsignmentSupplierCode { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
