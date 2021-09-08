using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionCompany
    {
        public string CompanyCode { get; set; }
        public string CompanyDescription { get; set; }
        public string CompanyShortDescription { get; set; }
        public string CompanyTypeDescription { get; set; }
        public string CountryCode { get; set; }
        public string CountryDescription { get; set; }
        public string CompanyGroupCode { get; set; }
        public string LogisticsCompanyCode { get; set; }
        public string DefaultCurrencyCode { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
