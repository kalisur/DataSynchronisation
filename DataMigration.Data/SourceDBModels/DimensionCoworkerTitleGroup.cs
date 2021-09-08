using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionCoworkerTitleGroup
    {
        public int CoworkerTitleGroupingId { get; set; }
        public string CoworkerTitle { get; set; }
        public string CoworkerTitleGrouping { get; set; }
        public DateTime? EdwcreatedDateTime { get; set; }
        public DateTime? EdwmodifiedDateTime { get; set; }
    }
}
