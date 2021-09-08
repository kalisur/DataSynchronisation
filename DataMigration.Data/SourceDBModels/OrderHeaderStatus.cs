using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class OrderHeaderStatus
    {
        public string OrderStatusCode { get; set; }
        public string OrderStatusDescription { get; set; }
        public string OrderStatusGroupDescription { get; set; }
    }
}
