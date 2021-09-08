using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionPipelineQuoteStage
    {
        public int PipelineQuoteStageCode { get; set; }
        public string PipelineQuoteStageDescription { get; set; }
        public int ActiveIndicator { get; set; }
        public int SortOrder { get; set; }
        public DateTime PipelineQuoteStageCreatedDateTime { get; set; }
        public DateTime PipelineQuoteStageModifiedDateTime { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
