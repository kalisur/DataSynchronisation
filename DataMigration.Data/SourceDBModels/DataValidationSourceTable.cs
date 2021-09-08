using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DataValidationSourceTable
    {
        public string SourceTables { get; set; }
        public string PreparedTable { get; set; }
        public string SourceDataBaseName { get; set; }
        public string Sql { get; set; }
        public string IsActive { get; set; }
    }
}
