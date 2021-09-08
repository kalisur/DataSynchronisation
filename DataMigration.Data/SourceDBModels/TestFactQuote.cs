using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class TestFactQuote
    {
        public string QuoteCode { get; set; }
        public int QuoteLineNumber { get; set; }
        public int QuoteDateInt { get; set; }
        public string CompanyCode { get; set; }
        public string TransactionCode { get; set; }
        public string QuoteOrderStatusCode { get; set; }
        public string QuoteOrderLineStatusCode { get; set; }
        public string QuoteOrderSourceCode { get; set; }
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
        public decimal? QuantityQuoted { get; set; }
        public decimal? QuoteDollarAmount { get; set; }
        public decimal? TotalQuoteDollarAmount { get; set; }
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
        public int? ConvertedFromQuoteOrderCode { get; set; }
        public decimal? QuantityAllocated { get; set; }
        public decimal? QuantityInvoiced { get; set; }
        public string OrderSecondaryCoworkerCode { get; set; }
        public string SuspendCode { get; set; }
        public string LogisticSuspendCode { get; set; }
        public int? SpecialistOnOrderFlag { get; set; }
        public string CustomerPurchaseOrder { get; set; }
        public string IngramSpecialistCallCode { get; set; }
        public string IngramSpecialistSalesImpactCode { get; set; }
        public string EaccountUserCode { get; set; }
        public string OfferCouponCode { get; set; }
        public string WebTransactionOriginCode { get; set; }
        public int? CreatedByOfferFlag { get; set; }
        public string OfferCode { get; set; }
        public int? CreatedByOfferCouponFlag { get; set; }
        public string MobileDeviceActivationRequestCode { get; set; }
        public string ProductSoftwareCode { get; set; }
        public string QuoteTypeCode { get; set; }
        public string SlatypeDescription { get; set; }
        public string SladueDateInt { get; set; }
        public string BillToStateCode { get; set; }
        public string BillToCountryCode { get; set; }
        public DateTime? EdwcreatedDateTime { get; set; }
        public DateTime? EdwmodifiedDateTime { get; set; }
    }
}
