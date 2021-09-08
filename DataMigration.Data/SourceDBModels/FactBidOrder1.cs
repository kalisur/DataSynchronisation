using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class FactBidOrder1
    {
        public int FactBidOrderId { get; set; }
        public int? BidRequestCode { get; set; }
        public int? BidRequestLineNumber { get; set; }
        public int? BidRequestDateInt { get; set; }
        public string CompanyCode { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerAddressCode { get; set; }
        public string AccountManagerCoworkerCode { get; set; }
        public string ConvertedOrderCode { get; set; }
        public int? OrderLineNumber { get; set; }
        public string BidTypeCode { get; set; }
        public string BidHeaderStatusCode { get; set; }
        public string BidDetailStatusCode { get; set; }
        public string SupplierCode { get; set; }
        public string ItemCode { get; set; }
        public int? BidQuantity { get; set; }
        public int? BidMaxOrderQuantity { get; set; }
        public int? BidMinOrderQuantity { get; set; }
        public int? CreatedDateInt { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public int? ModifiedDateInt { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public int? ApprovedDateInt { get; set; }
        public DateTime? ApprovedDateTime { get; set; }
        public int? DeniedDateInt { get; set; }
        public DateTime? DeniedDateTime { get; set; }
        public string BidDeniedReasonCode { get; set; }
        public int? ExpiredDateInt { get; set; }
        public int? ResubmittedDateInt { get; set; }
        public int? ConvertedDateInt { get; set; }
        public DateTime? ConvertedDateTime { get; set; }
        public decimal? SupplierPurchaseOrderCostLocalCurrencyAmount { get; set; }
        public decimal? RebateDiscountPercent { get; set; }
        public decimal? RebateLocalCurrencyAmount { get; set; }
        public decimal? DiscountedPurchaseOrderCostLocalCurrencyAmount { get; set; }
        public decimal? SpecialBidPriceLocalCurrencyAmount { get; set; }
        public decimal? ManufacturerUnitListPriceLocalCurrencyAmount { get; set; }
        public decimal? CustomerSellingPriceLocalCurrencyAmount { get; set; }
        public byte? SystemCostAdjustmentApprovalFlag { get; set; }
        public string ManufacturerAuthorizationCode { get; set; }
        public string ContractCode { get; set; }
        public int? RevisionCode { get; set; }
        public string VendorReferenceCode { get; set; }
        public string BackEndRebateFlag { get; set; }
        public string ManufacturerPartNumber { get; set; }
        public int? SalesContractStartDate { get; set; }
        public string DestinationGroup { get; set; }
        public string ManufacturerCode { get; set; }
        public string DeliveryAddress { get; set; }
        public string CompetitorId { get; set; }
        public string CompetitorModelNumber { get; set; }
        public decimal? CompetitorUnitPrice { get; set; }
        public string WaitStatusUser { get; set; }
        public int? PreviousBidNumber { get; set; }
        public int? BtoparentEdc { get; set; }
        public int? SupplierContactReferenceCode { get; set; }
        public int? BtoparentLineNumber { get; set; }
        public string ProgramthatWroteRecord { get; set; }
        public string ProgramthatChgdRecord { get; set; }
        public decimal? FixedRebateAmountperUnit { get; set; }
        public decimal? RebateClaimAmountperUnit { get; set; }
        public string AttainmentSourceCdFlg { get; set; }
        public string RebateBasisCode { get; set; }
        public int? ContractHeaderReferenceCode { get; set; }
        public DateTime? EdwcreatedDateTime { get; set; }
        public DateTime? EdwmodifiedDateTime { get; set; }
    }
}
