using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DataValidation
    {
        public string TableName { get; set; }
        public long? RowCount { get; set; }
        public string Calculation1 { get; set; }
        public string Calculation2 { get; set; }
        public string Calculation3 { get; set; }
        public string Calculation4 { get; set; }
        public string Calculation5 { get; set; }
        public DateTime? ValidationDate { get; set; }
        public decimal? ValidationThreshold { get; set; }
    }
}
