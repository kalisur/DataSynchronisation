using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class TestFactPurchaseOrder
    {
        public string PurchaseOrderCode { get; set; }
        public int PurchaseOrderLineNumber { get; set; }
        public int PurchaseOrderDateInt { get; set; }
        public int PurchaseOrderDueDateInt { get; set; }
        public string PurchaseOrderTypeCode { get; set; }
        public int? PurchaseOrderStatus { get; set; }
        public string CompanyCode { get; set; }
        public string DistributionCenterCode { get; set; }
        public string PurchaseOfficerCode { get; set; }
        public string DropShipOrderCode { get; set; }
        public string PurchaseOrderFreightTermsCode { get; set; }
        public string PurchaseOrderShipMethodSeq { get; set; }
        public string CustomerCode { get; set; }
        public string ContractNumber { get; set; }
        public string SupplierAccountReleased { get; set; }
        public string SupplierAccountDiversed { get; set; }
        public string SupplierCode { get; set; }
        public string ItemCode { get; set; }
        public string PurchaseOrderSupplierPartNumber { get; set; }
        public decimal? PurchaseOrderQuantity { get; set; }
        public decimal? PurchaseOrderQuantityReceived { get; set; }
        public decimal? PurchaseOrderQuantityOutstanding { get; set; }
        public decimal? PurchaseOrderQuantityInvoiced { get; set; }
        public decimal? PurchaseOrderSupplierCost { get; set; }
        public decimal? SimCostDollarAmount { get; set; }
        public decimal? LogisticsStandardCostDollarAmount { get; set; }
        public decimal? VolumePriceAgreementCost { get; set; }
        public int? CreatedDateInt { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedByUserId { get; set; }
        public string CreatedByCoworkerCode { get; set; }
        public int? ModifiedDateInt { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedByUserId { get; set; }
        public string ModifiedByCoworkerCode { get; set; }
        public int? ConfirmedDateInt { get; set; }
        public string ConfirmedByUserId { get; set; }
        public string ConfirmedByCoworkerCode { get; set; }
        public string ConfirmedWithVendor { get; set; }
        public DateTime? AutomatedPocreatedDateTime { get; set; }
        public DateTime? DropShipPoreleaseDateTime { get; set; }
        public int? DropShipPoreleaseDateInt { get; set; }
        public int? DropShipPoprocessMinutes { get; set; }
        public int? DropShipPocancelReasonInt { get; set; }
        public string DropShipPocancelUserId { get; set; }
        public int? DropShipPocancelDateInt { get; set; }
        public DateTime? DropShipPocancelDateTime { get; set; }
        public int? DropShipPocancelMinutes { get; set; }
        public byte? TaggedByPurchaseOfficerFlag { get; set; }
        public int? DropShipPopurchaseOfficerProcessMinutes { get; set; }
        public DateTime? EdwcreatedDateTime { get; set; }
        public DateTime? EdwmodifiedDateTime { get; set; }
    }
}
