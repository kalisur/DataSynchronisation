using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class TestShortTitleToEdwroleMap
    {
        public string ShortTitle { get; set; }
        public string EdwRoleType { get; set; }
        public string Comments { get; set; }
        public string EffStart { get; set; }
        public string EffEnd { get; set; }
        public string Icmplan { get; set; }
        public string Tcplan { get; set; }
        public string Prop7 { get; set; }
        public string C7 { get; set; }
        public string C8 { get; set; }
    }
}
