using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class FactSpsMonitoring
    {
        public long MonitoringCode { get; set; }
        public int? CoworkerCode { get; set; }
        public int SpsformCode { get; set; }
        public string SpsmethodDescription { get; set; }
        public string SpsmonitoringTypeCode { get; set; }
        public string SpsversionBuildCode { get; set; }
        public int MonitoringDateInt { get; set; }
        public string NetworkUserId { get; set; }
        public int? ExecutionCount { get; set; }
        public int? AverageDuration { get; set; }
        public int? MinimumDuration { get; set; }
        public int? MaximumDuration { get; set; }
        public int? SigmaSd { get; set; }
        public int? ThreadCount { get; set; }
        public string Comments { get; set; }
        public string MachineName { get; set; }
        public string Url { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
