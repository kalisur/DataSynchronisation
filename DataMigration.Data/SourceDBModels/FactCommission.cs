using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class FactCommission
    {
        public int CommissionSeq { get; set; }
        public int? CommissionCreditDateInt { get; set; }
        public int? CommissionPeriodStartDateInt { get; set; }
        public int? CommissionCreditInvoiceDateInt { get; set; }
        public string CommissionSalesTransactionCode { get; set; }
        public string CommissionEventTypeCode { get; set; }
        public string CommissionAdjustmentTypeCode { get; set; }
        public string CompanyCode { get; set; }
        public string InvoiceCode { get; set; }
        public int? InvoiceLineNumber { get; set; }
        public string InvoiceSourceCode { get; set; }
        public string ReturnReasonCode { get; set; }
        public string ShipMethodCode { get; set; }
        public string CommissionableCode { get; set; }
        public string MarketingSourceCode { get; set; }
        public string OrderCode { get; set; }
        public int? OrderLineNumber { get; set; }
        public string OrderSourceCode { get; set; }
        public string ItemCode { get; set; }
        public string CoworkerCode { get; set; }
        public string CustomerCode { get; set; }
        public string OriginalCustomerGldepartmentCode { get; set; }
        public string OriginalCustomerCode { get; set; }
        public int? Months { get; set; }
        public int? AdjInvoiceLineNbr { get; set; }
        public string AdjType { get; set; }
        public decimal? SalesLocalCurrencyAmount { get; set; }
        public decimal? SimcostLocalCurrencyAmount { get; set; }
        public decimal? GrossProfitLocalCurrencyAmount { get; set; }
        public decimal? AllocationPercent { get; set; }
        public string SplitType { get; set; }
        public decimal? PreSplitRevenue { get; set; }
        public decimal? PreSplitGrossProfit { get; set; }
        public decimal? PreSplitCost { get; set; }
        public int? RmareturnReasonCode { get; set; }
        public string CoworkerGldepartmentCode { get; set; }
        public string AtengagementCode { get; set; }
        public string SalesTransactionCommentText { get; set; }
        public string DataSource { get; set; }
        public int? OverlayFlag { get; set; }
        public string ProgramName { get; set; }
        public int? UpdatedBySpreadsheetLookupFlag { get; set; }
        public int? ServiceTypeBridgeSetInt { get; set; }
        public string CommissionCompensationPlanCode { get; set; }
        public int? CommissionCreditId { get; set; }
        public string CommissionSalesOrderCode { get; set; }
        public int? CommissionSalesOrderLineNumber { get; set; }
        public int? CommissionSalesOrderSubLineNumber { get; set; }
        public decimal? SalesSharePercent { get; set; }
        public decimal? GrossProfitSharePercent { get; set; }
        public int? CreditFlag { get; set; }
        public string CommissionCoworkerTitleCode { get; set; }
        public string OriginalAccountManagerCoworkerCode { get; set; }
        public string OriginalAccountManagerGldepartmentCode { get; set; }
        public string OriginalSpecialistGroupTypeCode { get; set; }
        public int? TcCustomerName { get; set; }
        public string TcCoworkerCode { get; set; }
        public string TcCoworkerGl { get; set; }
        public string TcCoworkerTitle { get; set; }
        public string OldEventTypeCode { get; set; }
        public string ProductId { get; set; }
        public string SourcedFrom { get; set; }
        public string CommissionSalesTransactionAssignmentCode { get; set; }
        public DateTime? EdwcreatedDateTime { get; set; }
        public DateTime? EdwmodifiedDateTime { get; set; }
        public string OldHash { get; set; }
        public string NewHash { get; set; }
    }
}
