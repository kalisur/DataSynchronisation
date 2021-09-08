using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class Transaction
    {
        public string TransactionCode { get; set; }
        public string TransactionDescription { get; set; }
        public string TransactionType { get; set; }
    }
}
