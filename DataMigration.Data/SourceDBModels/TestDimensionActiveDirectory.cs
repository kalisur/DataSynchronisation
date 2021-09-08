using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class TestDimensionActiveDirectory
    {
        public string ActiveDirectoryGroupDescription { get; set; }
        public string ActiveDirectoryUserDescription { get; set; }
        public string DistributionTypeDescription { get; set; }
        public string Coworkercode { get; set; }
        public string CoworkerNetworkId { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
