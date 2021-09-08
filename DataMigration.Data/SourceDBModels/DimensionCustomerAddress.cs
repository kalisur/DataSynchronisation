using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionCustomerAddress
    {
        public string CustomerAddressCode { get; set; }
        public string CustomerCode { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
        public string GlobalLocationNumber { get; set; }
        public string CustomerAddressStatusCode { get; set; }
        public byte EdiinvoiceFlag { get; set; }
        public Guid? CountryPaid { get; set; }
        public Guid? StatePaid { get; set; }
        public Guid? CityPaid { get; set; }
        public Guid? ZipPaid { get; set; }
        public string GismappedStateCode { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
