using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionCustomerAccountContact
    {
        public string CustomerAccount { get; set; }
        public string ContactId { get; set; }
        public string CompanyCode { get; set; }
        public short? ContactDepartmentId { get; set; }
        public string ContactDepartmentDescription { get; set; }
        public short? ContactJobTitleId { get; set; }
        public string ContactJobTitle { get; set; }
        public string ContactTypeCode { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string ZipCode { get; set; }
        public string CountryCode { get; set; }
        public string ContactActualFunctionTitle { get; set; }
        public string ContactPhone { get; set; }
        public string ContactExtension { get; set; }
        public string ContactFax { get; set; }
        public string ContactCellPhone { get; set; }
        public string ContactHomePhone { get; set; }
        public string ContactPager { get; set; }
        public byte? MailableFlag { get; set; }
        public byte? ShipmentConfirmEmailFlag { get; set; }
        public byte? ShipmentConfirmFaxFlag { get; set; }
        public string EaccountNumber { get; set; }
        public string EmailAddress { get; set; }
        public string EmailContactPromotionCode { get; set; }
        public string FaxContactPromotionCode { get; set; }
        public string BuyingAuthorityCode { get; set; }
        public byte? ActiveStatusFlag { get; set; }
        public string MailingCatalogTypeCode { get; set; }
        public string EmailTypeCode { get; set; }
        public DateTime? ContactCreatedDate { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
        public DateTime ValidFmTs { get; set; }
        public DateTime ValidToTs { get; set; }
    }
}
