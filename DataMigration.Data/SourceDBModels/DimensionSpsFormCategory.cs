using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionSpsFormCategory
    {
        public int CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public DateTime? EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
        public DateTime ValidFmTs { get; set; }
        public DateTime ValidToTs { get; set; }
    }
}
