using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionPipelineQuoteStatus
    {
        public int PipelineQuoteStatusCode { get; set; }
        public string PipelineQuoteStatusDescription { get; set; }
        public int ActiveIndicator { get; set; }
        public int SortOrder { get; set; }
        public DateTime PipelineQuoteStatusCreatedDateTime { get; set; }
        public DateTime PipelineQuoteStatusModifiedDateTime { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
