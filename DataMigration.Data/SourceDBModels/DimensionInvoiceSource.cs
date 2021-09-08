using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionInvoiceSource
    {
        public string InvoiceSourceCode { get; set; }
        public string InvoiceSourceDescription { get; set; }
        public string InvoiceSourceShortDescription { get; set; }
        public string DefaultProductLineTypeCode { get; set; }
        public string InvoiceBillingSystemDescription { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
