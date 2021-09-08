using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionOrderLineStatus
    {
        public string OrderLineStatusCode { get; set; }
        public string OrderLineStatusDescription { get; set; }
        public string OrderLineStatusGroupDescription { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
