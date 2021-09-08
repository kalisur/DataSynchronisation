using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class PstreeNode
    {
        public string Setid { get; set; }
        public string Setcntrlvalue { get; set; }
        public string TreeName { get; set; }
        public DateTime? Effdt { get; set; }
        public string TreeNodeNum { get; set; }
        public string TreeNode { get; set; }
        public string TreeBranch { get; set; }
        public string TreeNodeNumEnd { get; set; }
        public string TreeLevelNum { get; set; }
        public string TreeNodeType { get; set; }
        public string ParentNodeNum { get; set; }
        public string ParentNodeName { get; set; }
        public string OldTreeNodeNum { get; set; }
        public string NodecolImage { get; set; }
        public string NodeexpImage { get; set; }
    }
}
