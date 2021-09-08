using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class XrefSalesLogisticsOrder
    {
        public int XrefSalesLogisticsOrdersId { get; set; }
        public string LogisticsOrderCode { get; set; }
        public string SalesOrderCode { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
