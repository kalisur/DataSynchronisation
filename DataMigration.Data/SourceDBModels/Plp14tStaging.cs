using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class Plp14tStaging
    {
        public string CompanyCode { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string CustomerCode { get; set; }
        public string ContractNumber { get; set; }
        public string SupplierAccountReleased { get; set; }
        public string SupplierAccountDiversed { get; set; }
    }
}
