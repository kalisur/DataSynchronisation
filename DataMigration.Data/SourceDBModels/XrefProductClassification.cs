using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class XrefProductClassification
    {
        public string ItemCode { get; set; }
        public short ItemClassification { get; set; }
        public short SecondaryItemClassification { get; set; }
        public DateTime? SourceModifiedDateTime { get; set; }
        public string SourceModifiedUserId { get; set; }
        public string ModifiedByCoworkerCode { get; set; }
        public short RootItemClassification { get; set; }
        public string GlaccountClassification { get; set; }
        public decimal RevenueRecognitionPercent { get; set; }
        public string ItemTaxRuleCode { get; set; }
        public decimal? ItemTaxRulePercent { get; set; }
        public byte? ActiveFlag { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
        public string ItemGroupMajorCode { get; set; }
    }
}
