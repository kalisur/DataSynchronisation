using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionCoworker
    {
        public string CoworkerCode { get; set; }
        public string FirstName { get; set; }
        public string NickName { get; set; }
        public string LastName { get; set; }
        public string CompanyCode { get; set; }
        public string CoworkerName { get; set; }
        public string CoworkerDepartmentCode { get; set; }
        public string AccountManagerCode { get; set; }
        public short? PurchaseOfficerCode { get; set; }
        public string HouseAccount { get; set; }
        public string ManagerCoworkerCode { get; set; }
        public string ManagerCoworkerName { get; set; }
        public string ManagerDepartmentCode { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string TerminationDescription { get; set; }
        public DateTime? LosstartDate { get; set; }
        public int? Losmonth { get; set; }
        public string LosgroupDescription { get; set; }
        public int? LosgroupCode { get; set; }
        public string UserId { get; set; }
        public string EmailAddress { get; set; }
        public string RfiduserId { get; set; }
        public string CdwstateCode { get; set; }
        public string CdwstateDescription { get; set; }
        public string CdwcityCode { get; set; }
        public string CdwcityDescription { get; set; }
        public short? CdwneighborhoodCode { get; set; }
        public string CdwneighborhoodDescription { get; set; }
        public string CdwneighborhoodLocationCode { get; set; }
        public string CdwneighborhoodLocationDescription { get; set; }
        public string CdwneighborhoodLocationReportingDescription { get; set; }
        public string AcademyAmflagDescription { get; set; }
        public int? AcademyAmflag { get; set; }
        public string AcademyAmstateCode { get; set; }
        public string AcademyAmstateDescription { get; set; }
        public int? AcademyAmneighborhoodCode { get; set; }
        public string AcademyAmneighborhoodDescription { get; set; }
        public int? FieldOfficeSetFlag { get; set; }
        public string FieldOfficeSetFlagDescription { get; set; }
        public short? FieldOfficeSetcode { get; set; }
        public string FieldOfficeSetdescription { get; set; }
        public string CoworkerLocationCode { get; set; }
        public byte? PeopleSoftCoWorkerFlag { get; set; }
        public byte? ArspecialistFlag { get; set; }
        public byte? HouseAccountFlag { get; set; }
        public string HouseAccountDescription { get; set; }
        public string DirectPhone { get; set; }
        public string TollFreePhone { get; set; }
        public string InternalExtension { get; set; }
        public string SpecialistGroupTypeCode { get; set; }
        public string SpecialistGroupTypeDescription { get; set; }
        public string CoworkerTitleCode { get; set; }
        public string CoworkerTitleDescription { get; set; }
        public string CoworkerTitleGroupDescription { get; set; }
        public short? CoworkerPositionCode { get; set; }
        public int? OriginalServiceMonthCount { get; set; }
        public DateTime? OriginalSalesStartDateTime { get; set; }
        public int? SalesServiceMonthCount { get; set; }
        public string EmploymentLevelCode { get; set; }
        public string EmploymentLevelDescription { get; set; }
        public string ContractorVendorDescription { get; set; }
        public int? CurrentPositionLos { get; set; }
        public int? ManagerFlag { get; set; }
        public DateTime ValidFmTs { get; set; }
        public DateTime ValidToTs { get; set; }
        public DateTime? EdwcreatedDateTime { get; set; }
        public DateTime? EdwmodifiedDateTime { get; set; }
        public string CommissionCoworkerTitleGroupDescription { get; set; }
        public string NetworkUserId { get; set; }
        public string CommissionCoworkerTitleDescription { get; set; }
    }
}
