using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class SynonCondition
    {
        public string FileDdsname { get; set; }
        public string FileDescription { get; set; }
        public string FieldDdsname { get; set; }
        public string FieldDescription { get; set; }
        public string ConditionTest { get; set; }
        public string ConditionDescription { get; set; }
    }
}
