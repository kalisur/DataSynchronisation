using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionCoworkerTitle
    {
        public string CoworkerTitleCode { get; set; }
        public string CoworkerTitleDescription { get; set; }
        public string CoworkerTitleShortDescription { get; set; }
        public string CoworkerTitleGroupDescription { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
