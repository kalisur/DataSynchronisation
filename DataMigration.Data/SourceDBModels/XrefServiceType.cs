using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class XrefServiceType
    {
        public int XrefServiceTypeId { get; set; }
        public string ServiceTypeCode { get; set; }
        public string ItemGroupMajorCode { get; set; }
        public int Active { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
