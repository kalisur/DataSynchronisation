using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class TestApiTot
    {
        public string SourceSystemName { get; set; }
        public string WorkflowName { get; set; }
        public string TableSchema { get; set; }
        public string TableName { get; set; }
        public string TableFields { get; set; }
        public DateTime? DateModified { get; set; }
        public string IsActive { get; set; }
        public string IsDelta { get; set; }
        public DateTime? CurrentDate { get; set; }
        public int? DaysRetrieved { get; set; }
        public string WhereClauseFilter { get; set; }
        public string WhereClause { get; set; }
    }
}
