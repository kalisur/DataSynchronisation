using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class FactOrder
    {
        public string OrderCode { get; set; }
        public int OrderLineNumber { get; set; }
        public int OrderDateInt { get; set; }
        public string CompanyCode { get; set; }
        public string TransactionCode { get; set; }
        public string OrderStatusCode { get; set; }
        public string OrderLineStatusCode { get; set; }
        public string OrderSourceCode { get; set; }
        public string OrderingCoworkerCode { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerAddressCode { get; set; }
        public string OriginalCustomerCode { get; set; }
        public string ShipMethodCode { get; set; }
        public string MarketingSourceCode { get; set; }
        public string PriceListCode { get; set; }
        public string PaymentTypeCode { get; set; }
        public string ContractCode { get; set; }
        public string ItemCode { get; set; }
        public int? GeneratedFromQuoteFlag { get; set; }
        public decimal? QuantityOrdered { get; set; }
        public decimal? OrderDollarAmount { get; set; }
        public decimal? TotalOrderDollarAmount { get; set; }
        public decimal? QuantityOutStanding { get; set; }
        public int? CreatedDateInt { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string CreatedByCoworkerCode { get; set; }
        public int? ModifiedDateInt { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedByUserId { get; set; }
        public string ModifiedByCoworkerCode { get; set; }
        public string ContactCode { get; set; }
        public string OriginalContactCode { get; set; }
        public string ConvertedFromQuoteOrderCode { get; set; }
        public decimal? QuantityAllocated { get; set; }
        public decimal? QuantityInvoiced { get; set; }
        public string OrderSecondaryCoworkerCode { get; set; }
        public string SuspendCode { get; set; }
        public string LogisticSuspendCode { get; set; }
        public int? SpecialistOnOrderFlag { get; set; }
        public string CustomerPurchaseOrder { get; set; }
        public string OfferCouponCode { get; set; }
        public string WebTransactionOriginCode { get; set; }
        public string ProductSoftwareCode { get; set; }
        public string OrderTypeCode { get; set; }
        public string SlatypeDescription { get; set; }
        public int SladueDateInt { get; set; }
        public DateTime? EdwcreatedDateTime { get; set; }
        public DateTime? EdwmodifiedDateTime { get; set; }
        public string ProductSoftwareOriginalCode { get; set; }
        public string EaccountUserKey { get; set; }
    }
}
