using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class FactOrderSuspendAndActionLog
    {
        public int IdentitySeqNumber { get; set; }
        public string SalesOrderCode { get; set; }
        public int? SalesOrderDateInt { get; set; }
        public string SalesOrderCompanyCode { get; set; }
        public string SalesOrderCustomerCode { get; set; }
        public string SalesOrderTransactionCode { get; set; }
        public string SalesOrderStatusCode { get; set; }
        public string TransactionOrderCode { get; set; }
        public int? TransactionOrderDateInt { get; set; }
        public string TransactionOrderCompanyCode { get; set; }
        public string TransactionOrderCustomerCode { get; set; }
        public string OrderType { get; set; }
        public string Program { get; set; }
        public string OldSuspendCode { get; set; }
        public string NewSuspendCode { get; set; }
        public string OrderActionCode { get; set; }
        public string ActionByCoworkerCode { get; set; }
        public DateTime ActionDateTime { get; set; }
        public int ActionDateInt { get; set; }
        public int ActionTimeInt { get; set; }
        public int? ActioniSeriesDateInt { get; set; }
        public int? ActioniSeriesTimeInt { get; set; }
        public int? ActionQuarterInt { get; set; }
        public int ActionMonthInt { get; set; }
        public int ActionYearInt { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public decimal? DurationInSeconds { get; set; }
        public decimal? DurationInMinutes { get; set; }
        public decimal? DurationInHours { get; set; }
        public decimal? DurationInDays { get; set; }
        public bool? InvoicedFlag { get; set; }
        public int? SalesOrderCloseDateInt { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
