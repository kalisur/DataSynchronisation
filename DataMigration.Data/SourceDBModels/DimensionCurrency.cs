using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionCurrency
    {
        public string CurrencyCode { get; set; }
        public string CurrencyDescription { get; set; }
        public string CurrencySymbol { get; set; }
        public int ActiveStatus { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
