using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionOrderSuspend
    {
        public string SuspendCode { get; set; }
        public string SuspendCodeDescription { get; set; }
        public byte? SuspendCreditApproved { get; set; }
        public bool? SuspendQuoteFlag { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
