using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class LoadLogging
    {
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string SourceSystemName { get; set; }
        public string LoadWorkflow { get; set; }
        public string LoadSchema { get; set; }
        public string LoadSourceTable { get; set; }
        public string LoadType { get; set; }
        public string PipelineName { get; set; }
        public string CopyTaskName { get; set; }
        public int? RowCount { get; set; }
        public string Result { get; set; }
        public TimeSpan? TimeElapsed { get; set; }
    }
}
