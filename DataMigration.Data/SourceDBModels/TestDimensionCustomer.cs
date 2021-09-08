using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class TestDimensionCustomer
    {
        public string CustomerCode { get; set; }
        public string CustomerDescription { get; set; }
        public string CompanyCode { get; set; }
        public string PrimaryCoworkerCode { get; set; }
        public string SecondaryCoworkerCode { get; set; }
        public string AccountCreatedByCoworkerCode { get; set; }
        public int? AccountCreatedDateInt { get; set; }
        public string CustomerTypeCode { get; set; }
        public string CustomerSubTypeCode { get; set; }
        public string CustomerAgencyCode { get; set; }
        public string CustomerSubAgencyCode { get; set; }
        public string CustomerCodingCode { get; set; }
        public decimal? CreditLimit { get; set; }
        public byte? CreditHoldFlag { get; set; }
        public string CreditHoldDescription { get; set; }
        public string PaymentTypeCode { get; set; }
        public byte? CashFlowProblemFlag { get; set; }
        public string CashFlowProblemDescription { get; set; }
        public int? CustomerCodeInt { get; set; }
        public string CustomerCompetitorCode { get; set; }
        public string CustomerResellerCode { get; set; }
        public string Mailable { get; set; }
        public string CustomerLeasingCode { get; set; }
        public string CustomerAccountStatusCode { get; set; }
        public byte? TaxExemptFlag { get; set; }
        public string CustomerSourceGroup { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
