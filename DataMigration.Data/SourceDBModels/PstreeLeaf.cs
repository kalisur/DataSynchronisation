using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class PstreeLeaf
    {
        public string Setid { get; set; }
        public string Setcntrlvalue { get; set; }
        public string TreeName { get; set; }
        public DateTime? Effdt { get; set; }
        public string TreeNodeNum { get; set; }
        public string RangeFrom { get; set; }
        public string RangeTo { get; set; }
        public string TreeBranch { get; set; }
        public string DynamicRange { get; set; }
        public string OldTreeNodeNum { get; set; }
        public string LeafImage { get; set; }
    }
}
