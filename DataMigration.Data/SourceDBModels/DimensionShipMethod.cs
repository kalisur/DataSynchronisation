using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionShipMethod
    {
        public string ShipMethodCode { get; set; }
        public string ShipMethodDescription { get; set; }
        public string CompanyCode { get; set; }
        public string CarrierCode { get; set; }
        public string CarrierDescription { get; set; }
        public string RoutingGroupCode { get; set; }
        public string RoutingGroupDescription { get; set; }
        public string LabelTypeCode { get; set; }
        public decimal? ShippingLabelPrintAddress { get; set; }
        public string InsuranceCode { get; set; }
        public string InsuranceRule { get; set; }
        public string OverrideToShipMethod { get; set; }
        public int? TrackNumber { get; set; }
        public string ShippingTagType { get; set; }
        public string RecordStatusCode { get; set; }
        public string PrintPriorityCode { get; set; }
        public string ChargeFreight { get; set; }
        public string StandardCarrierAlphaCode { get; set; }
        public string TransmitInsurance3rdParty { get; set; }
        public string SourceChangeUser { get; set; }
        public int? SourceChangeDate { get; set; }
        public int? SourceChangeTime { get; set; }
        public DateTime EdwcreatedDateTime { get; set; }
        public DateTime EdwmodifiedDateTime { get; set; }
    }
}
