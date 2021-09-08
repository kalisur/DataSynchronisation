using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionSpsFormAlias
    {
        public int? FormCategoryCode { get; set; }
        public string FormAliasDescription { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
