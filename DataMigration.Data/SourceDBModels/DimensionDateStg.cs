using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionDateStg
    {
        public int DateInt { get; set; }
        public DateTime CalendarDate { get; set; }
    }
}
