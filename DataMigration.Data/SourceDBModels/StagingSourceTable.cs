using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class StagingSourceTable
    {
        public string SourceSystemName { get; set; }
        public string WorkflowName { get; set; }
        public string TableSchema { get; set; }
        public string TableName { get; set; }
        public string TableFields { get; set; }
        public DateTime? DateModified { get; set; }
        public string IsActive { get; set; }
        public string UpdateDateField { get; set; }
        public string UpdateDateField2 { get; set; }
        public string UpdateDateField3 { get; set; }
        public string IsDelta { get; set; }
        public string WhereClause { get; set; }
        public DateTime? DateAddedToT { get; set; }
        public string ProcessGroup { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public string InsertSql { get; set; }
    }
}
