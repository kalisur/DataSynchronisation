using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionServiceType
    {
        public string ServiceTypeCode { get; set; }
        public string ServiceTypeDescription { get; set; }
        public int BitwiseNumber { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
