using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimCustomer
    {
        public int DimCustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerDescription { get; set; }
        public string CompanyCode { get; set; }
        public string PrimaryCoworkerCode { get; set; }
        public string SecondaryCoworkerCode { get; set; }
        public int? AccountCreatedDateInt { get; set; }
        public string CustomerTypeCode { get; set; }
        public string CustomerSubTypeCode { get; set; }
        public string CustomerAgencyCode { get; set; }
        public string CustomerSubAgencyCode { get; set; }
        public string CustomerGldepartmentCode { get; set; }
        public string CustomerCodingCode { get; set; }
        public decimal? CreditLimit { get; set; }
        public byte? CreditHoldFlag { get; set; }
        public string CreditHoldDescription { get; set; }
        public string PaymentTypeCode { get; set; }
        public byte? CashFlowProblemFlag { get; set; }
        public string CashFlowProblemDescription { get; set; }
        public byte? EdwactiveFlag { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
        public byte? NamedAccountFlag { get; set; }
        public short? CustomerAtRisk { get; set; }
        public int? CustomerCodeInt { get; set; }
        public int? FirstInvoiceDateInt { get; set; }
        public int? LastInvoiceDateInt { get; set; }
        public int? FirstOrderDateInt { get; set; }
        public int? LastOrderDateInt { get; set; }
        public string SalesStrategySegmentCode { get; set; }
        public int? CustomerSic { get; set; }
        public int? CustomerEmployeeCount { get; set; }
        public decimal? AnnualItbudgetDollarAmount { get; set; }
        public int? LastExtranetOrderDateSeq { get; set; }
        public int? LastExtranetAccessDateSeq { get; set; }
        public string CustomerCompetitorCode { get; set; }
        public string CustomerResellerCode { get; set; }
        public string Mailable { get; set; }
        public string CustomerLeasingCode { get; set; }
        public string NamedAccountCode { get; set; }
        public string FieldOfficeGldepartmentCode { get; set; }
        public byte? ExtranetExistsFlag { get; set; }
        public string MarketingSiteCode { get; set; }
        public int? WebCustomerCreateDateInt { get; set; }
        public string MobilityStrategicSalesTerritoryCode { get; set; }
        public string SecurityStrategicSalesTerritoryCode { get; set; }
        public string SsvstrategicSalesTerritoryCode { get; set; }
        public string NetworkingStrategicSalesTerritoryCode { get; set; }
        public string UcommStrategicSalesTerritoryCode { get; set; }
        public string CustomerSalesTrendCode { get; set; }
        public string CustomerAccountStatusCode { get; set; }
        public string PriorYearCustomerSalesTrendCode { get; set; }
        public decimal? RemainingCreditLimitDollarAmount { get; set; }
        public string ArspecialistCoworkerCode { get; set; }
        public int? FirstQuoteDateInt { get; set; }
        public int? LastQuoteDateInt { get; set; }
        public string EstimatedEmployeeCountRange { get; set; }
        public string MarketingCustomerSegmentCode { get; set; }
        public string MarketingEntityCode { get; set; }
        public string SalesChannelCode { get; set; }
        public string SalesStrategySegmentTypeCode { get; set; }
        public int? LastInvoicedOrderDateCode { get; set; }
        public short? AverageOrderIntervalValue { get; set; }
        public byte TaxExemptFlag { get; set; }
        public string PriceListCode { get; set; }
        public int AccountCreatedByCoworkerCode { get; set; }
        public DateTime? DescriptionModifiedDateTime { get; set; }
        public byte? BidCostAdderOverrideFlag { get; set; }
        public string NcesinstitutionCode { get; set; }
        public byte? Sohoflag { get; set; }
        public string RelatedProductCustomerCode { get; set; }
        public byte? IngramSpecialistCallFlag { get; set; }
        public string CustomerCreatedByOfferFlag { get; set; }
        public string PriorYearPurchaseStatusCode { get; set; }
        public string PreviousPriorYearPurchaseStatusCode { get; set; }
        public string AmproductivityCode { get; set; }
        public string CreatedByOfferCouponCode { get; set; }
        public string CreatedByOfferCode { get; set; }
        public string CustomerClassificationNodeCode { get; set; }
        public string CustomerSourceGroup { get; set; }
        public string LinkedParentCustomerCode { get; set; }
        public string AdvancedTechnologyAccountTypeCode { get; set; }
        public byte? Ediflag { get; set; }
        public byte? Eproflag { get; set; }
    }
}
