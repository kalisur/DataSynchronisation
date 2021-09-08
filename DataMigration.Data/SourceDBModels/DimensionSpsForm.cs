using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionSpsForm
    {
        public int FormCode { get; set; }
        public string FormDescription { get; set; }
        public string FormAliasDescription { get; set; }
        public int FormCategoryCode { get; set; }
        public int ActiveFlag { get; set; }
        public int ReportingFlag { get; set; }
        public DateTime? EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
        public DateTime ValidFmTs { get; set; }
        public DateTime ValidToTs { get; set; }
    }
}
