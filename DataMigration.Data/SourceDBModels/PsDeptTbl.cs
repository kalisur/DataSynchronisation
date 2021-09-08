using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class PsDeptTbl
    {
        public string Setid { get; set; }
        public string Deptid { get; set; }
        public string Descr { get; set; }
        public DateTime? Effdt { get; set; }
        public string EffStatus { get; set; }
    }
}
