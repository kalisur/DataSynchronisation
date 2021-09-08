using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionDistributionCenter
    {
        public string BinCode { get; set; }
        public string WarehouseCode { get; set; }
        public string BinSectionCode { get; set; }
        public string BinLocationCode { get; set; }
        public string BinShelfCode { get; set; }
        public string BinPickableFlag { get; set; }
        public string BinSize { get; set; }
        public string DivertZone { get; set; }
        public byte ExcludeFromOnHandFlag { get; set; }
        public byte? VirtualFlag { get; set; }
        public string BinPriorityRank { get; set; }
        public string PickingType { get; set; }
        public short? RackLevelNumber { get; set; }
        public short? BinAltitudeFeet { get; set; }
        public short? BinPickingHeightFeet { get; set; }
        public string BarcodedFlag { get; set; }
        public decimal? BinHeight { get; set; }
        public decimal? BinWidth { get; set; }
        public decimal? BinDepth { get; set; }
        public string DistributionCenterZoneCode { get; set; }
        public string DistributionCenterZoneDescription { get; set; }
        public string DistributionCenterZoneTypeCode { get; set; }
        public string DistributionCenterZoneTypeDescription { get; set; }
        public string DistributionCenterCode { get; set; }
        public string DistributionCenterDescription { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public DateTime? EdwcreatedDateTime { get; set; }
        public DateTime? EdwmodifiedDateTime { get; set; }
    }
}
