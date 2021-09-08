using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class XrefBidRequestOrderDetail
    {
        public string CompanyCode { get; set; }
        public int BidRequestCode { get; set; }
        public int BidRequestLineNumber { get; set; }
        public string OrderCode { get; set; }
        public int OrderLineNumber { get; set; }
        public string CreatedByUserId { get; set; }
        public int CreatedDate { get; set; }
        public int? CreatedTime { get; set; }
        public int PurchaseOrderActionCode { get; set; }
        public string PurchaseOrderActionCompanyCode { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
