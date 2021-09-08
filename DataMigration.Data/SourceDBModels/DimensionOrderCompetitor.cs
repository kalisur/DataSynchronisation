using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionOrderCompetitor
    {
        public int CompetitorCode { get; set; }
        public string CompetitorDescription { get; set; }
        public bool CompetitorActive { get; set; }
        public int CompetitorSortOrder { get; set; }
        public DateTime CompetitorCreatedDateTime { get; set; }
        public DateTime CompetitorModifiedDateTime { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
        public DateTime ValidFmTs { get; set; }
        public DateTime ValidToTs { get; set; }
    }
}
