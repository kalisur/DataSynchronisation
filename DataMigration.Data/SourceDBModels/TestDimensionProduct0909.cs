using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class TestDimensionProduct0909
    {
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string CompanyCode { get; set; }
        public string ItemTypeCode { get; set; }
        public string ItemTypeDescription { get; set; }
        public string ItemClassCode { get; set; }
        public string ItemClassDescription { get; set; }
        public string ItemGroupMajorCode { get; set; }
        public string ItemGroupMajorDescription { get; set; }
        public string ItemGroupMinorCode { get; set; }
        public string ItemGroupMinorDescription { get; set; }
        public string BrandDescription { get; set; }
        public string PrimaryManufacturerCode { get; set; }
        public string PrimaryManufacturerDescription { get; set; }
        public string ManufacturerCode { get; set; }
        public string ManufacturerDescription { get; set; }
        public int? PurchaseOfficerCode { get; set; }
        public string PurchaseOfficerName { get; set; }
        public string ManufacturerSegmentDescription { get; set; }
        public int? ManufacturerSegmentRank { get; set; }
        public string ItemUvrcode { get; set; }
        public string ItemNonReturnableFlag { get; set; }
        public string ItemNonReturnableDescription { get; set; }
        public string ItemDropShipCode { get; set; }
        public string ItemDropShipDescription { get; set; }
        public string ItemTaxableFlag { get; set; }
        public string ItemTaxableDescription { get; set; }
        public string ItemBundleFlag { get; set; }
        public string ItemBundleDescription { get; set; }
        public string ItemInstallCode { get; set; }
        public string ItemInstallDescription { get; set; }
        public string ItemManufacturerPartNumber { get; set; }
        public string ItemDescriptivePartNumber { get; set; }
        public string ItemImportExportCode { get; set; }
        public string ItemImportExportDescription { get; set; }
        public string ItemHazardousMaterialsClassCode { get; set; }
        public string ItemHazardousMaterialsClassDescription { get; set; }
        public string ItemTaxRuleCode { get; set; }
        public string ItemTaxRuleDescription { get; set; }
        public string ItemMultiBoxCode { get; set; }
        public string ItemMultiBoxDescription { get; set; }
        public decimal? ItemLength { get; set; }
        public decimal? ItemWidth { get; set; }
        public decimal? ItemHeight { get; set; }
        public decimal? ItemWeight { get; set; }
        public string PrimarySupplierCode { get; set; }
        public string PrimarySupplierDescription { get; set; }
        public string QblsupplierCode { get; set; }
        public string QblsupplierDescription { get; set; }
        public string ItemRestrictSalesFlag { get; set; }
        public int? ItemSerializedFlag { get; set; }
        public string ItemOriginalManufacturerPartNumber { get; set; }
        public DateTime? EdwcreatedDateTime { get; set; }
        public DateTime? EdwmodifiedDateTime { get; set; }
    }
}
