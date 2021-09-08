using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class FactInvoice
    {
        public int FactInvoiceId { get; set; }
        public string InvoiceCode { get; set; }
        public int? InvoiceLineNumber { get; set; }
        public int? InvoiceDateInt { get; set; }
        public string OrderCode { get; set; }
        public int? OrderLineNumber { get; set; }
        public int? OrderDateInt { get; set; }
        public string TransactionCode { get; set; }
        public string InvoiceStatusCode { get; set; }
        public string CompanyCode { get; set; }
        public string InvoiceSourceCode { get; set; }
        public string OrderSourceCode { get; set; }
        public string DistributionCenterCode { get; set; }
        public string DistributionCenterZoneCode { get; set; }
        public string ReferenceCode { get; set; }
        public string AccountManagerCoworkerCode { get; set; }
        public string SecondaryAccountManagerCoworkerCode { get; set; }
        public string CustomerCode { get; set; }
        public string OriginalCustomerCode { get; set; }
        public string CustomerAddressCode { get; set; }
        public string MarketingSourceCode { get; set; }
        public string ContractCode { get; set; }
        public string PriceListCode { get; set; }
        public string PaymentTypeCode { get; set; }
        public string ReturnReasonCode { get; set; }
        public string CustomerPurchaseOrder { get; set; }
        public string ShipMethodCode { get; set; }
        public int? CommissionableFlag { get; set; }
        public string ItemCode { get; set; }
        public string ConvertedFromQuoteOrderCode { get; set; }
        public string ReturnReasonGlpostingCode { get; set; }
        public string InvoiceTypeCode { get; set; }
        public string InvoiceGldepartmentCode { get; set; }
        public string OrderSizeRange { get; set; }
        public int SpecialistOnOrderFlag { get; set; }
        public int? InvoiceLineRebateFlag { get; set; }
        public string SoftwareAgrrementCode { get; set; }
        public int? RebateStackingFlag { get; set; }
        public string InvoiceLineTypeCode { get; set; }
        public string OfferCouponCode { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? SalesQuantity { get; set; }
        public decimal? SalesLocalCurrencyAmount { get; set; }
        public decimal? TotalSalesLocalCurrencyAmount { get; set; }
        public decimal? SimCostLocalCurrencyAmount { get; set; }
        public decimal? SalesCogslocalCurrencyAmount { get; set; }
        public decimal? LandedCostLocalCurrencyAmount { get; set; }
        public decimal? LogisticsCogslocalCurrencyAmount { get; set; }
        public decimal? DropShipPosupplierCostLocalCurrencyAmount { get; set; }
        public decimal? FreightChargeLocalCurrencyAmount { get; set; }
        public decimal? InsuranceChargeLocalCurrencyAmount { get; set; }
        public decimal? HandlingChargeLocalCurrencyAmount { get; set; }
        public decimal? IncurredFreightLocalCurrencyAmount { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
