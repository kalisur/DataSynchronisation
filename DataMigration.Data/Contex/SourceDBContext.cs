using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DataMigration.Data.SourceDBModels;
using Azure.Identity;
#nullable disable

namespace DataMigration.Data.Contex
{
    public partial class SourceDBContext : DbContext
    {
        public SourceDBContext()
        {
        }

        public SourceDBContext(DbContextOptions<SourceDBContext> options)
            : base(options)
        {
            var conn = (Microsoft.Data.SqlClient.SqlConnection)Database.GetDbConnection();
            conn.ConnectionString = Config.primaryDBConn; //  Configuration.GetConnectionString(Config.reportingDBConn);
            var credential = new DefaultAzureCredential();
            var token = credential
                .GetToken(
                    new Azure.Core.TokenRequestContext(new[] { "https://database.windows.net/.default" })
                );
            conn.AccessToken = token.Token;
        }

        public virtual DbSet<Aduser> Adusers { get; set; }
        public virtual DbSet<AdusersRawDatum> AdusersRawData { get; set; }
        public virtual DbSet<DataValidation> DataValidations { get; set; }
        public virtual DbSet<DataValidationSourceTable> DataValidationSourceTables { get; set; }
        public virtual DbSet<DimCoworker> DimCoworkers { get; set; }
        public virtual DbSet<DimCoworkerHistory> DimCoworkerHistories { get; set; }
        public virtual DbSet<DimCoworkerPoc> DimCoworkerPocs { get; set; }
        public virtual DbSet<DimCustomer> DimCustomers { get; set; }
        public virtual DbSet<DimCustomerAssignmentAccountManager> DimCustomerAssignmentAccountManagers { get; set; }
        public virtual DbSet<DimensionActiveDirectory> DimensionActiveDirectories { get; set; }
        public virtual DbSet<DimensionCalendarDate> DimensionCalendarDates { get; set; }
        public virtual DbSet<DimensionCartType> DimensionCartTypes { get; set; }
        public virtual DbSet<DimensionCommissionEventType> DimensionCommissionEventTypes { get; set; }
        public virtual DbSet<DimensionCompany> DimensionCompanies { get; set; }
        public virtual DbSet<DimensionCoworker> DimensionCoworkers { get; set; }
        public virtual DbSet<DimensionCoworkerTitle> DimensionCoworkerTitles { get; set; }
        public virtual DbSet<DimensionCoworkerTitleGroup> DimensionCoworkerTitleGroups { get; set; }
        public virtual DbSet<DimensionCurrency> DimensionCurrencies { get; set; }
        public virtual DbSet<DimensionCustomer> DimensionCustomers { get; set; }
        public virtual DbSet<DimensionCustomerAccountContact> DimensionCustomerAccountContacts { get; set; }
        public virtual DbSet<DimensionCustomerAddress> DimensionCustomerAddresses { get; set; }
        public virtual DbSet<DimensionDateStg> DimensionDateStgs { get; set; }
        public virtual DbSet<DimensionDepartment> DimensionDepartments { get; set; }
        public virtual DbSet<DimensionDistributionCenter> DimensionDistributionCenters { get; set; }
        public virtual DbSet<DimensionInvoiceSource> DimensionInvoiceSources { get; set; }
        public virtual DbSet<DimensionOrderAction> DimensionOrderActions { get; set; }
        public virtual DbSet<DimensionOrderCompetitor> DimensionOrderCompetitors { get; set; }
        public virtual DbSet<DimensionOrderLineStatus> DimensionOrderLineStatuses { get; set; }
        public virtual DbSet<DimensionOrderSuspend> DimensionOrderSuspends { get; set; }
        public virtual DbSet<DimensionPipelineQuoteStage> DimensionPipelineQuoteStages { get; set; }
        public virtual DbSet<DimensionPipelineQuoteStatus> DimensionPipelineQuoteStatuses { get; set; }
        public virtual DbSet<DimensionProduct> DimensionProducts { get; set; }
        public virtual DbSet<DimensionRenewalStatus> DimensionRenewalStatuses { get; set; }
        public virtual DbSet<DimensionSegmentTransactionThreshold> DimensionSegmentTransactionThresholds { get; set; }
        public virtual DbSet<DimensionServiceType> DimensionServiceTypes { get; set; }
        public virtual DbSet<DimensionShipMethod> DimensionShipMethods { get; set; }
        public virtual DbSet<DimensionSpsForm> DimensionSpsForms { get; set; }
        public virtual DbSet<DimensionSpsFormAlias> DimensionSpsFormAliases { get; set; }
        public virtual DbSet<DimensionSpsFormCategory> DimensionSpsFormCategories { get; set; }
        public virtual DbSet<DimensionSpsMethod> DimensionSpsMethods { get; set; }
        public virtual DbSet<DimensionTransaction> DimensionTransactions { get; set; }
        public virtual DbSet<Emp05Staging> Emp05Stagings { get; set; }
        public virtual DbSet<FactBidOrder> FactBidOrders { get; set; }
        public virtual DbSet<FactBidOrder1> FactBidOrders1 { get; set; }
        public virtual DbSet<FactCommission> FactCommissions { get; set; }
        public virtual DbSet<FactCommissionAdjustment> FactCommissionAdjustments { get; set; }
        public virtual DbSet<FactCommissionAdjustment1> FactCommissionAdjustments1 { get; set; }
        public virtual DbSet<FactCommissionAdjustmentFreight> FactCommissionAdjustmentFreights { get; set; }
        public virtual DbSet<FactInventoryItem> FactInventoryItems { get; set; }
        public virtual DbSet<FactInvoice> FactInvoices { get; set; }
        public virtual DbSet<FactOpportunityNonTangible> FactOpportunityNonTangibles { get; set; }
        public virtual DbSet<FactOpportunityTangible> FactOpportunityTangibles { get; set; }
        public virtual DbSet<FactOrder> FactOrders { get; set; }
        public virtual DbSet<FactOrderOpportunity> FactOrderOpportunities { get; set; }
        public virtual DbSet<FactOrderSuspendAndActionLog> FactOrderSuspendAndActionLogs { get; set; }
        public virtual DbSet<FactPurchaseOrder> FactPurchaseOrders { get; set; }
        public virtual DbSet<FactQuote> FactQuotes { get; set; }
        public virtual DbSet<FactRenewal> FactRenewals { get; set; }
        public virtual DbSet<FactSalesGoalCoworker> FactSalesGoalCoworkers { get; set; }
        public virtual DbSet<FactSpsMonitoring> FactSpsMonitorings { get; set; }
        public virtual DbSet<LoadLogging> LoadLoggings { get; set; }
        public virtual DbSet<Oep20Staging> Oep20Stagings { get; set; }
        public virtual DbSet<Oep87Staging> Oep87Stagings { get; set; }
        public virtual DbSet<OrderHeaderStatus> OrderHeaderStatuses { get; set; }
        public virtual DbSet<OrderLineStatus> OrderLineStatuses { get; set; }
        public virtual DbSet<Plp14tStaging> Plp14tStagings { get; set; }
        public virtual DbSet<Pmp02Staging> Pmp02Stagings { get; set; }
        public virtual DbSet<Pmp03Staging> Pmp03Stagings { get; set; }
        public virtual DbSet<Pmp06Staging> Pmp06Stagings { get; set; }
        public virtual DbSet<PsDeptTbl> PsDeptTbls { get; set; }
        public virtual DbSet<PsHoliday> PsHolidays { get; set; }
        public virtual DbSet<PsTreeNodeTbl> PsTreeNodeTbls { get; set; }
        public virtual DbSet<PstreeLeaf> PstreeLeaves { get; set; }
        public virtual DbSet<PstreeNode> PstreeNodes { get; set; }
        public virtual DbSet<Sl05Staging> Sl05Stagings { get; set; }
        public virtual DbSet<Slp05Staging> Slp05Stagings { get; set; }
        public virtual DbSet<SourceTable> SourceTables { get; set; }
        public virtual DbSet<SourceTablesSampleTable> SourceTablesSampleTables { get; set; }
        public virtual DbSet<StagingSourceTable> StagingSourceTables { get; set; }
        public virtual DbSet<SynonCondition> SynonConditions { get; set; }
        public virtual DbSet<Test1FreightCommAdj> Test1FreightCommAdjs { get; set; }
        public virtual DbSet<TestApiTot> TestApiTots { get; set; }
        public virtual DbSet<TestCm21> TestCm21s { get; set; }
        public virtual DbSet<TestCm80> TestCm80s { get; set; }
        public virtual DbSet<TestCm87> TestCm87s { get; set; }
        public virtual DbSet<TestCm87a> TestCm87as { get; set; }
        public virtual DbSet<TestCm87d> TestCm87ds { get; set; }
        public virtual DbSet<TestCommCwc> TestCommCwcs { get; set; }
        public virtual DbSet<TestCommissionCoworkerTitleTrueComp> TestCommissionCoworkerTitleTrueComps { get; set; }
        public virtual DbSet<TestCwcfinalfield> TestCwcfinalfields { get; set; }
        public virtual DbSet<TestCwcnetwork1> TestCwcnetwork1s { get; set; }
        public virtual DbSet<TestCwctitle> TestCwctitles { get; set; }
        public virtual DbSet<TestDimensionActiveDirectory> TestDimensionActiveDirectories { get; set; }
        public virtual DbSet<TestDimensionCompany> TestDimensionCompanies { get; set; }
        public virtual DbSet<TestDimensionCoworker> TestDimensionCoworkers { get; set; }
        public virtual DbSet<TestDimensionCustomer> TestDimensionCustomers { get; set; }
        public virtual DbSet<TestDimensionOrderAction> TestDimensionOrderActions { get; set; }
        public virtual DbSet<TestEmp05Cwc> TestEmp05Cwcs { get; set; }
        public virtual DbSet<TestEmp05andPeoplesoft> TestEmp05andPeoplesofts { get; set; }
        public virtual DbSet<TestEmp05cow> TestEmp05cows { get; set; }
        public virtual DbSet<TestEmp10andP> TestEmp10andPs { get; set; }
        public virtual DbSet<TestEmp15> TestEmp15s { get; set; }
        public virtual DbSet<TestEmp25> TestEmp25s { get; set; }
        public virtual DbSet<TestEmp40> TestEmp40s { get; set; }
        public virtual DbSet<TestFactCommissionAdjustmentFreight> TestFactCommissionAdjustmentFreights { get; set; }
        public virtual DbSet<TestFactCommissionAdjustmentFreight230821> TestFactCommissionAdjustmentFreight230821s { get; set; }
        public virtual DbSet<TestFactCommissionAdjustmentFreight250821> TestFactCommissionAdjustmentFreight250821s { get; set; }
        public virtual DbSet<TestFactCommissionAdjustmentFreight270821> TestFactCommissionAdjustmentFreight270821s { get; set; }
        public virtual DbSet<TestFactCommissionAdjustmentFreight300821> TestFactCommissionAdjustmentFreight300821s { get; set; }
        public virtual DbSet<TestFactOrder> TestFactOrders { get; set; }
        public virtual DbSet<TestFactQuote> TestFactQuotes { get; set; }
        public virtual DbSet<TestJobCodeAdl> TestJobCodeAdls { get; set; }
        public virtual DbSet<TestJobcodetbl> TestJobcodetbls { get; set; }
        public virtual DbSet<TestNetwork123> TestNetwork123s { get; set; }
        public virtual DbSet<TestNetworkAgg> TestNetworkAggs { get; set; }
        public virtual DbSet<TestNetworkCwc> TestNetworkCwcs { get; set; }
        public virtual DbSet<TestOep47u> TestOep47us { get; set; }
        public virtual DbSet<TestOrderquoteDatum> TestOrderquoteData { get; set; }
        public virtual DbSet<TestPlcomplan> TestPlcomplans { get; set; }
        public virtual DbSet<TestPsJobcodeTbl> TestPsJobcodeTbls { get; set; }
        public virtual DbSet<TestPscdwj1> TestPscdwj1s { get; set; }
        public virtual DbSet<TestSelfjoinemp05andP> TestSelfjoinemp05andPs { get; set; }
        public virtual DbSet<TestShortTitleToEdwroleMap> TestShortTitleToEdwroleMaps { get; set; }
        public virtual DbSet<TestVwEdwod> TestVwEdwods { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<XrefBidRequestOrderDetail> XrefBidRequestOrderDetails { get; set; }
        public virtual DbSet<XrefDepartmentNodeCoworker> XrefDepartmentNodeCoworkers { get; set; }
        public virtual DbSet<XrefProductClassification> XrefProductClassifications { get; set; }
        public virtual DbSet<XrefSalesLogisticsOrder> XrefSalesLogisticsOrders { get; set; }
        public virtual DbSet<XrefServiceType> XrefServiceTypes { get; set; }
        public virtual DbSet<Ycnddtarfp> Ycnddtarfps { get; set; }
        public virtual DbSet<Ycondtarfp> Ycondtarfps { get; set; }
        public virtual DbSet<Yentdtarfp> Yentdtarfps { get; set; }
        public virtual DbSet<Yfildtarfp> Yfildtarfps { get; set; }
        public virtual DbSet<Yflddtarfp> Yflddtarfps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.

            //var conn = (Microsoft.Data.SqlClient.SqlConnection)Database.GetDbConnection();
            //var opt = new DefaultAzureCredentialOptions() { ExcludeSharedTokenCacheCredential = true };
            //var credential = new DefaultAzureCredential(opt);
            //var token = credential
            //        .GetToken(new Azure.Core.TokenRequestContext(
            //            new[] { "https://database.windows.net/.default" }));
            //conn.AccessToken = token.Token;

            //optionsBuilder.UseSqlServer(conn);
           // optionsBuilder.UseSqlServer(Config.primaryDBConn);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Aduser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ADUsers", "staging");

                entity.Property(e => e.Cn).HasColumnName("CN");

                entity.Property(e => e.Displayname).HasColumnName("displayname");

                entity.Property(e => e.Dn).HasColumnName("DN");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.Employeenumber).HasColumnName("employeenumber");

                entity.Property(e => e.Givenname).HasColumnName("givenname");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Mail).HasColumnName("mail");

                entity.Property(e => e.MemberOf).HasColumnName("memberOf");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Samaccountname).HasColumnName("samaccountname");

                entity.Property(e => e.Sn).HasColumnName("sn");
            });

            modelBuilder.Entity<AdusersRawDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ADUsers_RawData", "staging");

                entity.Property(e => e.Cn).HasColumnName("CN");

                entity.Property(e => e.Displayname).HasColumnName("displayname");

                entity.Property(e => e.Dn).HasColumnName("DN");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.Employeenumber).HasColumnName("employeenumber");

                entity.Property(e => e.Givenname).HasColumnName("givenname");

                entity.Property(e => e.Mail).HasColumnName("mail");

                entity.Property(e => e.MemberOf).HasColumnName("memberOf");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Samaccountname).HasColumnName("samaccountname");

                entity.Property(e => e.Sn).HasColumnName("sn");
            });

            modelBuilder.Entity<DataValidation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DataValidation", "logging");

                entity.Property(e => e.Calculation1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Calculation 1");

                entity.Property(e => e.Calculation2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Calculation 2");

                entity.Property(e => e.Calculation3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Calculation 3");

                entity.Property(e => e.Calculation4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Calculation 4");

                entity.Property(e => e.Calculation5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Calculation 5");

                entity.Property(e => e.TableName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValidationThreshold).HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<DataValidationSourceTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DataValidationSourceTables", "logging");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PreparedTable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceDataBaseName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SourceTables)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sql)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SQL");
            });

            modelBuilder.Entity<DimCoworker>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DimCoworker", "dbo");

                entity.Property(e => e.AcademyAmflag).HasColumnName("AcademyAMFlag");

                entity.Property(e => e.AcademyAmflagDescription)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("AcademyAMFlagDescription");

                entity.Property(e => e.AcademyAmneighborhoodCode).HasColumnName("AcademyAMNeighborhoodCode");

                entity.Property(e => e.AcademyAmneighborhoodDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AcademyAMNeighborhoodDescription");

                entity.Property(e => e.AcademyAmstateCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AcademyAMStateCode");

                entity.Property(e => e.AcademyAmstateDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AcademyAMStateDescription");

                entity.Property(e => e.AccountManagerCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ArspecialistFlag).HasColumnName("ARSpecialistFlag");

                entity.Property(e => e.CdwcityCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CDWCityCode");

                entity.Property(e => e.CdwcityDescription)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("CDWCityDescription");

                entity.Property(e => e.CdwneighborhoodCode).HasColumnName("CDWNeighborhoodCode");

                entity.Property(e => e.CdwneighborhoodDescription)
                    .HasMaxLength(83)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhoodDescription");

                entity.Property(e => e.CdwneighborhoodLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhoodLocationCode");

                entity.Property(e => e.CdwneighborhoodLocationDescription)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhoodLocationDescription");

                entity.Property(e => e.CdwneighborhoodLocationReportingDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhoodLocationReportingDescription");

                entity.Property(e => e.CdwstateCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CDWStateCode");

                entity.Property(e => e.CdwstateDescription)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("CDWStateDescription");

                entity.Property(e => e.CertificationCiscoDescription)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CertificationMicrosoftDescription)
                    .HasMaxLength(23)
                    .IsUnicode(false);

                entity.Property(e => e.CertificationOtherDescription)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CertificationSpsdescription)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("CertificationSPSDescription");

                entity.Property(e => e.CertificationSpsflag).HasColumnName("CertificationSPSFlag");

                entity.Property(e => e.CommissionCompensationPlanDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ContractorVendorDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerGldepartmentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CoworkerGLDepartmentCode");

                entity.Property(e => e.CoworkerLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerLocationDescription)
                    .HasMaxLength(83)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerName)
                    .HasMaxLength(74)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerPositionDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerReportingDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerTitleCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerTitleDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerTitleGroupDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerTitleShortDescription)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentPositionLos).HasColumnName("CurrentPositionLOS");

                entity.Property(e => e.DimCoworkerId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DimCoworkerID");

                entity.Property(e => e.DirectPhone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentLevelCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentLevelDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldOfficeSetFlagDescription)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.FieldOfficeSetcode).HasColumnName("FieldOfficeSETCode");

                entity.Property(e => e.FieldOfficeSetdescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FieldOfficeSETDescription");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.HouseAccount)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HouseAccountDescription)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.InternalCourseworkEffectivePresentationsDescription)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.InternalCourseworkWiredDescription)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.InternalExtension)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LosgroupCode).HasColumnName("LOSGroupCode");

                entity.Property(e => e.LosgroupDescription)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LOSGroupDescription");

                entity.Property(e => e.Losmonth).HasColumnName("LOSMonth");

                entity.Property(e => e.LosstartDate)
                    .HasColumnType("date")
                    .HasColumnName("LOSStartDate");

                entity.Property(e => e.ManagerCoworkerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerCoworkerName)
                    .HasMaxLength(74)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerGldepartmentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ManagerGLDepartmentCode");

                entity.Property(e => e.MigratorDescription)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NetworkUserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NetworkUserID");

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeopleSoftCoworkerDescription)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.RfiduserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RFIDUserID");

                entity.Property(e => e.SalesLosbandDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("SalesLOSBandDescription");

                entity.Property(e => e.SalesLosbandGroupDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("SalesLOSBandGroupDescription");

                entity.Property(e => e.SalesStartDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.SpecialistGroupTypeCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialistGroupTypeDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerminationDate).HasColumnType("date");

                entity.Property(e => e.TerminationDescription)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TollFreePhone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.ValidFmTs).HasColumnName("ValidFmTS");

                entity.Property(e => e.ValidToTs).HasColumnName("ValidToTS");
            });

            modelBuilder.Entity<DimCoworkerHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DimCoworkerHistory", "dbo");

                entity.HasIndex(e => new { e.ValidToTs, e.ValidFmTs }, "ix_DimCoworkerHistory")
                    .IsClustered();

                entity.Property(e => e.AcademyAmflag).HasColumnName("AcademyAMFlag");

                entity.Property(e => e.AcademyAmflagDescription)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("AcademyAMFlagDescription");

                entity.Property(e => e.AcademyAmneighborhoodCode).HasColumnName("AcademyAMNeighborhoodCode");

                entity.Property(e => e.AcademyAmneighborhoodDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AcademyAMNeighborhoodDescription");

                entity.Property(e => e.AcademyAmstateCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AcademyAMStateCode");

                entity.Property(e => e.AcademyAmstateDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AcademyAMStateDescription");

                entity.Property(e => e.AccountManagerCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ArspecialistFlag).HasColumnName("ARSpecialistFlag");

                entity.Property(e => e.CdwcityCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CDWCityCode");

                entity.Property(e => e.CdwcityDescription)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("CDWCityDescription");

                entity.Property(e => e.CdwneighborhoodCode).HasColumnName("CDWNeighborhoodCode");

                entity.Property(e => e.CdwneighborhoodDescription)
                    .HasMaxLength(83)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhoodDescription");

                entity.Property(e => e.CdwneighborhoodLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhoodLocationCode");

                entity.Property(e => e.CdwneighborhoodLocationDescription)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhoodLocationDescription");

                entity.Property(e => e.CdwneighborhoodLocationReportingDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhoodLocationReportingDescription");

                entity.Property(e => e.CdwstateCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CDWStateCode");

                entity.Property(e => e.CdwstateDescription)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("CDWStateDescription");

                entity.Property(e => e.CertificationCiscoDescription)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CertificationMicrosoftDescription)
                    .HasMaxLength(23)
                    .IsUnicode(false);

                entity.Property(e => e.CertificationOtherDescription)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CertificationSpsdescription)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("CertificationSPSDescription");

                entity.Property(e => e.CertificationSpsflag).HasColumnName("CertificationSPSFlag");

                entity.Property(e => e.CommissionCompensationPlanDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ContractorVendorDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerGldepartmentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CoworkerGLDepartmentCode");

                entity.Property(e => e.CoworkerLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerLocationDescription)
                    .HasMaxLength(83)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerName)
                    .HasMaxLength(74)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerPositionDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerReportingDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerTitleCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerTitleDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerTitleGroupDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerTitleShortDescription)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentPositionLos).HasColumnName("CurrentPositionLOS");

                entity.Property(e => e.DimCoworkerId).HasColumnName("DimCoworkerID");

                entity.Property(e => e.DirectPhone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentLevelCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentLevelDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldOfficeSetFlagDescription)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.FieldOfficeSetcode).HasColumnName("FieldOfficeSETCode");

                entity.Property(e => e.FieldOfficeSetdescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FieldOfficeSETDescription");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate).HasColumnType("smalldatetime");

                entity.Property(e => e.HouseAccount)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HouseAccountDescription)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.InternalCourseworkEffectivePresentationsDescription)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.InternalCourseworkWiredDescription)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.InternalExtension)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LosgroupCode).HasColumnName("LOSGroupCode");

                entity.Property(e => e.LosgroupDescription)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LOSGroupDescription");

                entity.Property(e => e.Losmonth).HasColumnName("LOSMonth");

                entity.Property(e => e.LosstartDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("LOSStartDate");

                entity.Property(e => e.ManagerCoworkerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerCoworkerName)
                    .HasMaxLength(74)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerGldepartmentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ManagerGLDepartmentCode");

                entity.Property(e => e.MigratorDescription)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NetworkUserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NetworkUserID");

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeopleSoftCoworkerDescription)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.RfiduserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RFIDUserID");

                entity.Property(e => e.SalesLosbandDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("SalesLOSBandDescription");

                entity.Property(e => e.SalesLosbandGroupDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("SalesLOSBandGroupDescription");

                entity.Property(e => e.SalesStartDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.SpecialistGroupTypeCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialistGroupTypeDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerminationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TerminationDescription)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TollFreePhone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.ValidFmTs).HasColumnName("ValidFmTS");

                entity.Property(e => e.ValidToTs).HasColumnName("ValidToTS");
            });

            modelBuilder.Entity<DimCoworkerPoc>(entity =>
            {
                entity.ToTable("DimCoworkerPOC", "metadata");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(101)
                    .IsUnicode(false);

                entity.Property(e => e.Gldepartment)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GLDepartment");

                entity.Property(e => e.HireDate).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerminationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DimCustomer>(entity =>
            {
                entity.ToTable("DimCustomer", "dbo");

                entity.Property(e => e.AdvancedTechnologyAccountTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AmproductivityCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AMProductivityCode");

                entity.Property(e => e.AnnualItbudgetDollarAmount)
                    .HasColumnType("money")
                    .HasColumnName("AnnualITBudgetDollarAmount");

                entity.Property(e => e.ArspecialistCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ARSpecialistCoworkerCode");

                entity.Property(e => e.CashFlowProblemDescription)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByOfferCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByOfferCouponCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreditHoldDescription)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CreditLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerAccountStatusCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAgencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerClassificationNodeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCodeInt).HasColumnName("CustomerCodeINT");

                entity.Property(e => e.CustomerCodingCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCompetitorCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCreatedByOfferFlag)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerGldepartmentCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CustomerGLDepartmentCode");

                entity.Property(e => e.CustomerLeasingCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerResellerCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSalesTrendCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSic).HasColumnName("CustomerSIC");

                entity.Property(e => e.CustomerSourceGroup)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSubAgencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSubTypeCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerTypeCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionModifiedDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Ediflag).HasColumnName("EDIFlag");

                entity.Property(e => e.EdwactiveFlag).HasColumnName("EDWActiveFlag");

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.Eproflag).HasColumnName("EPROFlag");

                entity.Property(e => e.EstimatedEmployeeCountRange)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FieldOfficeGldepartmentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FieldOfficeGLDepartmentCode");

                entity.Property(e => e.LinkedParentCustomerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Mailable)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingCustomerSegmentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingEntityCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingSiteCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobilityStrategicSalesTerritoryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NamedAccountCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NcesinstitutionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NCESInstitutionCode");

                entity.Property(e => e.NetworkingStrategicSalesTerritoryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PreviousPriorYearPurchaseStatusCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PriceListCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryCoworkerCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PriorYearCustomerSalesTrendCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PriorYearPurchaseStatusCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RelatedProductCustomerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingCreditLimitDollarAmount).HasColumnType("money");

                entity.Property(e => e.SalesChannelCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalesStrategySegmentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalesStrategySegmentTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryCoworkerCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityStrategicSalesTerritoryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Sohoflag).HasColumnName("SOHOFlag");

                entity.Property(e => e.SsvstrategicSalesTerritoryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SSVStrategicSalesTerritoryCode");

                entity.Property(e => e.UcommStrategicSalesTerritoryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UCommStrategicSalesTerritoryCode");
            });

            modelBuilder.Entity<DimCustomerAssignmentAccountManager>(entity =>
            {
                entity.ToTable("DimCustomerAssignmentAccountManager", "dbo");

                entity.Property(e => e.AccountManagerAllocationPercent).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CoWorkerCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.ValidFmTs).HasColumnName("ValidFmTS");

                entity.Property(e => e.ValidToTs).HasColumnName("ValidToTS");
            });

            modelBuilder.Entity<DimensionActiveDirectory>(entity =>
            {
                entity.HasKey(e => new { e.ActiveDirectoryGroupDescription, e.ActiveDirectoryUserDescription, e.DistributionTypeDescription, e.CoworkerNetworkId });

                entity.ToTable("Dimension_ActiveDirectory", "dbo");

                entity.Property(e => e.ActiveDirectoryGroupDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ActiveDirectoryUserDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DistributionTypeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerNetworkId)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("CoworkerNetworkID");

                entity.Property(e => e.Coworkercode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");
            });

            modelBuilder.Entity<DimensionCalendarDate>(entity =>
            {
                entity.HasKey(e => e.DateInt)
                    .HasName("PK__Dimensio__415EEF7069AFB481");

                entity.ToTable("Dimension_CalendarDate", "dbo");

                entity.Property(e => e.DateInt).ValueGeneratedNever();

                entity.Property(e => e.CalendarDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CalendarMonth)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CalendarQuarter)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CalendarWeek).HasColumnType("smalldatetime");

                entity.Property(e => e.CanadaWorkingDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ISeriesDateInt).HasColumnName("iSeriesDateInt");

                entity.Property(e => e.UstotalWorkingDaysOfMonth).HasColumnName("USTotalWorkingDaysOfMonth");

                entity.Property(e => e.UstotalWorkingDaysOfQuarter).HasColumnName("USTotalWorkingDaysOfQuarter");

                entity.Property(e => e.UstotalWorkingDaysOfYear).HasColumnName("USTotalWorkingDaysOfYear");

                entity.Property(e => e.UsworkingDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("USWorkingDate");

                entity.Property(e => e.UsworkingDateInt).HasColumnName("USWorkingDateInt");

                entity.Property(e => e.UsworkingDayOfMonth).HasColumnName("USWorkingDayOfMonth");

                entity.Property(e => e.UsworkingDayOfQuarter).HasColumnName("USWorkingDayOfQuarter");

                entity.Property(e => e.UsworkingDayOfYear).HasColumnName("USWorkingDayOfYear");
            });

            modelBuilder.Entity<DimensionCartType>(entity =>
            {
                entity.HasKey(e => e.CartTypeCode)
                    .HasName("PK__Dimensio__04540073FF9AC655");

                entity.ToTable("Dimension_Cart_Type", "dbo");

                entity.Property(e => e.CartTypeCode).ValueGeneratedNever();

                entity.Property(e => e.CartTypeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");
            });

            modelBuilder.Entity<DimensionCommissionEventType>(entity =>
            {
                entity.HasKey(e => new { e.EventType, e.EffectiveStartDate })
                    .HasName("PK__Dimensio__8E454825319BC8B3");

                entity.ToTable("Dimension_Commission_EventType", "dbo");

                entity.Property(e => e.EventType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveStartDate).HasColumnType("date");

                entity.Property(e => e.AdjustmentIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AllowCustomerAcceleratorIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AllowOverlayIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AllowReductionIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AllowRollupIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AllowSplitIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.EffectiveEndDate).HasColumnType("date");

                entity.Property(e => e.EventTypeComment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ForcedCreditType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequiresAdjustmentTypeIndicator)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SuppressCreditIndicator)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DimensionCompany>(entity =>
            {
                entity.HasKey(e => e.CompanyCode);

                entity.ToTable("Dimension_Company", "dbo");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyGroupCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyShortDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyTypeDescription)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CountryDescription)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultCurrencyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.LogisticsCompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DimensionCoworker>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dimension_Coworker", "dbo");

                entity.Property(e => e.AcademyAmflag).HasColumnName("AcademyAMFlag");

                entity.Property(e => e.AcademyAmflagDescription)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("AcademyAMFlagDescription");

                entity.Property(e => e.AcademyAmneighborhoodCode).HasColumnName("AcademyAMNeighborhoodCode");

                entity.Property(e => e.AcademyAmneighborhoodDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AcademyAMNeighborhoodDescription");

                entity.Property(e => e.AcademyAmstateCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AcademyAMStateCode");

                entity.Property(e => e.AcademyAmstateDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AcademyAMStateDescription");

                entity.Property(e => e.AccountManagerCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ArspecialistFlag).HasColumnName("ARSpecialistFlag");

                entity.Property(e => e.CdwcityCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CDWCityCode");

                entity.Property(e => e.CdwcityDescription)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("CDWCityDescription");

                entity.Property(e => e.CdwneighborhoodCode).HasColumnName("CDWNeighborhoodCode");

                entity.Property(e => e.CdwneighborhoodDescription)
                    .HasMaxLength(83)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhoodDescription");

                entity.Property(e => e.CdwneighborhoodLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhoodLocationCode");

                entity.Property(e => e.CdwneighborhoodLocationDescription)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhoodLocationDescription");

                entity.Property(e => e.CdwneighborhoodLocationReportingDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhoodLocationReportingDescription");

                entity.Property(e => e.CdwstateCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CDWStateCode");

                entity.Property(e => e.CdwstateDescription)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("CDWStateDescription");

                entity.Property(e => e.CertificationCiscoDescription)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CertificationMicrosoftDescription)
                    .HasMaxLength(23)
                    .IsUnicode(false);

                entity.Property(e => e.CertificationOtherDescription)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.CertificationSpsdescription)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("CertificationSPSDescription");

                entity.Property(e => e.CertificationSpsflag).HasColumnName("CertificationSPSFlag");

                entity.Property(e => e.CommissionCompensationPlanDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CommissionCoworkerTitleDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CommissionCoworkerTitleGroupDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ContractorVendorDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerGldepartmentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CoworkerGLDepartmentCode");

                entity.Property(e => e.CoworkerLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerLocationDescription)
                    .HasMaxLength(83)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerName)
                    .HasMaxLength(74)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerPositionDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerReportingDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerSeq).ValueGeneratedOnAdd();

                entity.Property(e => e.CoworkerTitleCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerTitleDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerTitleGroupDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerTitleShortDescription)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentPositionLos).HasColumnName("CurrentPositionLOS");

                entity.Property(e => e.DirectPhone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentLevelCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentLevelDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldOfficeSetFlagDescription)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.FieldOfficeSetcode).HasColumnName("FieldOfficeSETCode");

                entity.Property(e => e.FieldOfficeSetdescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FieldOfficeSETDescription");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.HouseAccount)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HouseAccountDescription)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.InternalCourseworkEffectivePresentationsDescription)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.InternalCourseworkWiredDescription)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.InternalExtension)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LosgroupCode).HasColumnName("LOSGroupCode");

                entity.Property(e => e.LosgroupDescription)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LOSGroupDescription");

                entity.Property(e => e.Losmonth).HasColumnName("LOSMonth");

                entity.Property(e => e.LosstartDate)
                    .HasColumnType("date")
                    .HasColumnName("LOSStartDate");

                entity.Property(e => e.ManagerCoworkerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerCoworkerName)
                    .HasMaxLength(74)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerGldepartmentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ManagerGLDepartmentCode");

                entity.Property(e => e.MigratorDescription)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NetworkUserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NetworkUserID");

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeopleSoftCoworkerDescription)
                    .HasMaxLength(19)
                    .IsUnicode(false);

                entity.Property(e => e.RfiduserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RFIDUserID");

                entity.Property(e => e.SalesLosbandDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("SalesLOSBandDescription");

                entity.Property(e => e.SalesLosbandGroupDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("SalesLOSBandGroupDescription");

                entity.Property(e => e.SalesStartDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.SpecialistGroupTypeCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialistGroupTypeDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerminationDate).HasColumnType("date");

                entity.Property(e => e.TerminationDescription)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TollFreePhone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.ValidFmTs).HasColumnName("ValidFmTS");

                entity.Property(e => e.ValidToTs).HasColumnName("ValidToTS");
            });

            modelBuilder.Entity<DimensionCoworkerTitle>(entity =>
            {
                entity.HasKey(e => new { e.CoworkerTitleCode, e.CoworkerTitleDescription })
                    .HasName("PK__Dimensio__6CB1A18A39D6E539");

                entity.ToTable("Dimension_Coworker_Title", "dbo");

                entity.Property(e => e.CoworkerTitleCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerTitleDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerTitleGroupDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerTitleShortDescription)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");
            });

            modelBuilder.Entity<DimensionCoworkerTitleGroup>(entity =>
            {
                entity.HasKey(e => e.CoworkerTitleGroupingId)
                    .HasName("PK__Dimensio__5187C64B16A16264");

                entity.ToTable("Dimension_Coworker_TitleGroup", "dbo");

                entity.Property(e => e.CoworkerTitleGroupingId).HasColumnName("CoworkerTitleGroupingID");

                entity.Property(e => e.CoworkerTitle)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerTitleGrouping)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");
            });

            modelBuilder.Entity<DimensionCurrency>(entity =>
            {
                entity.HasKey(e => e.CurrencyCode)
                    .HasName("PK__Dimensio__408426BE32BA0A8F");

                entity.ToTable("Dimension_Currency", "dbo");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyDescription)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencySymbol)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");
            });

            modelBuilder.Entity<DimensionCustomer>(entity =>
            {
                entity.HasKey(e => new { e.CustomerCode, e.CompanyCode });

                entity.ToTable("Dimension_Customer", "dbo");

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AccountCreatedByCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CashFlowProblemDescription)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CreditHoldDescription)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CreditLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerAccountStatusCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAgencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCodeInt).HasColumnName("CustomerCodeINT");

                entity.Property(e => e.CustomerCodingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCompetitorCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerLeasingCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerResellerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSourceGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSubAgencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSubTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.Mailable)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DimensionCustomerAccountContact>(entity =>
            {
                entity.HasKey(e => new { e.CustomerAccount, e.ContactId, e.CompanyCode });

                entity.ToTable("Dimension_CustomerAccount_Contact", "dbo");

                entity.Property(e => e.CustomerAccount)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ContactID");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyingAuthorityCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactActualFunctionTitle)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCellPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCreatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ContactDepartmentDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactDepartmentId).HasColumnName("ContactDepartmentID");

                entity.Property(e => e.ContactExtension)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ContactFax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactHomePhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactJobTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactJobTitleId).HasColumnName("ContactJobTitleID");

                entity.Property(e => e.ContactPager)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTypeCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EaccountNumber)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("EAccountNumber");

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.EmailContactPromotionCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EmailTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EMailTypeCode");

                entity.Property(e => e.FaxContactPromotionCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MailingCatalogTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleInitial)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StateCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ValidFmTs).HasColumnName("ValidFmTS");

                entity.Property(e => e.ValidToTs).HasColumnName("ValidToTS");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DimensionCustomerAddress>(entity =>
            {
                entity.HasKey(e => new { e.CustomerAddressCode, e.CustomerCode })
                    .HasName("PK__Dimensio__1C614D9D22F24F47");

                entity.ToTable("Dimension_Customer_Address", "dbo");

                entity.Property(e => e.CustomerAddressCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityPaid).HasColumnName("CityPAID");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CountryPaid).HasColumnName("CountryPAID");

                entity.Property(e => e.CustomerAddressStatusCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EdiinvoiceFlag).HasColumnName("EDIInvoiceFlag");

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.GismappedStateCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GISMappedStateCode");

                entity.Property(e => e.GlobalLocationNumber)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StateCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StatePaid).HasColumnName("StatePAID");

                entity.Property(e => e.ZipPaid).HasColumnName("ZipPAID");
            });

            modelBuilder.Entity<DimensionDateStg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dimension_Date_Stg", "staging");

                entity.Property(e => e.CalendarDate).HasColumnType("date");
            });

            modelBuilder.Entity<DimensionDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentCode);

                entity.ToTable("Dimension_Department", "dbo");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentNodeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.Level10DepartmentManagingCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Level10NodeLongDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Level10NodeShortDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Level11DepartmentManagingCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Level11NodeLongDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Level11NodeShortDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Level12DepartmentManagingCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Level12NodeLongDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Level12NodeShortDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Level13DepartmentManagingCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Level13NodeLongDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Level13NodeShortDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Level14DepartmentManagingCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Level14NodeLongDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Level14NodeShortDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Level15DepartmentManagingCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Level15NodeLongDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Level15NodeShortDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Level16DepartmentManagingCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Level16NodeLongDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Level16NodeShortDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Level1DepartmentManagingCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Level1NodeLongDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Level1NodeShortDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Level2DepartmentManagingCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Level2NodeLongDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Level2NodeShortDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Level3DepartmentManagingCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Level3NodeLongDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Level3NodeShortDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Level4DepartmentManagingCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Level4NodeLongDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Level4NodeShortDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Level5DepartmentManagingCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Level5NodeLongDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Level5NodeShortDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Level6DepartmentManagingCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Level6NodeLongDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Level6NodeShortDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Level7DepartmentManagingCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Level7NodeLongDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Level7NodeShortDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Level8DepartmentManagingCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Level8NodeLongDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Level8NodeShortDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Level9DepartmentManagingCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Level9NodeLongDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Level9NodeShortDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DimensionDistributionCenter>(entity =>
            {
                entity.HasKey(e => new { e.BinCode, e.WarehouseCode, e.DistributionCenterZoneCode, e.DistributionCenterCode, e.ExcludeFromOnHandFlag })
                    .HasName("PK__Dimensio__F59C938D2D5B4439");

                entity.ToTable("Dimension_DistributionCenter", "dbo");

                entity.Property(e => e.BinCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DistributionCenterZoneCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DistributionCenterCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BarcodedFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BinDepth).HasColumnType("decimal(9, 3)");

                entity.Property(e => e.BinHeight).HasColumnType("decimal(9, 3)");

                entity.Property(e => e.BinLocationCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BinPickableFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BinPriorityRank)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BinSectionCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BinShelfCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BinSize)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BinWidth).HasColumnType("decimal(9, 3)");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DistributionCenterDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributionCenterZoneDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributionCenterZoneTypeCode)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.DistributionCenterZoneTypeDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DivertZone)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.PickingType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DimensionInvoiceSource>(entity =>
            {
                entity.HasKey(e => e.InvoiceSourceCode);

                entity.ToTable("Dimension_Invoice_Source", "dbo");

                entity.Property(e => e.InvoiceSourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultProductLineTypeCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.InvoiceBillingSystemDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceSourceDescription)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceSourceShortDescription)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DimensionOrderAction>(entity =>
            {
                entity.HasKey(e => e.OrderActionCode);

                entity.ToTable("Dimension_OrderAction", "dbo");

                entity.Property(e => e.OrderActionCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.OrderActionDescription)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OrderActionReasonCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DimensionOrderCompetitor>(entity =>
            {
                entity.HasKey(e => e.CompetitorCode)
                    .HasName("PK__Dimensio__EA3C2AAE852DB4E8");

                entity.ToTable("Dimension_Order_Competitor", "dbo");

                entity.Property(e => e.CompetitorCode).ValueGeneratedNever();

                entity.Property(e => e.CompetitorCreatedDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.CompetitorDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompetitorModifiedDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.ValidFmTs).HasColumnName("ValidFmTS");

                entity.Property(e => e.ValidToTs).HasColumnName("ValidToTS");
            });

            modelBuilder.Entity<DimensionOrderLineStatus>(entity =>
            {
                entity.HasKey(e => e.OrderLineStatusCode);

                entity.ToTable("Dimension_OrderLine_Status", "dbo");

                entity.Property(e => e.OrderLineStatusCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.OrderLineStatusDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrderLineStatusGroupDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DimensionOrderSuspend>(entity =>
            {
                entity.HasKey(e => e.SuspendCode)
                    .HasName("PK__Dimensio__A8B4D030AAB669A0");

                entity.ToTable("Dimension_OrderSuspend", "dbo");

                entity.Property(e => e.SuspendCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.SuspendCodeDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DimensionPipelineQuoteStage>(entity =>
            {
                entity.HasKey(e => e.PipelineQuoteStageCode)
                    .HasName("PK__Dimensio__64D9EE181C0E51F6");

                entity.ToTable("Dimension_Pipeline_QuoteStage", "dbo");

                entity.Property(e => e.PipelineQuoteStageCode).ValueGeneratedNever();

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.PipelineQuoteStageCreatedDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.PipelineQuoteStageDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PipelineQuoteStageModifiedDateTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<DimensionPipelineQuoteStatus>(entity =>
            {
                entity.HasKey(e => e.PipelineQuoteStatusCode)
                    .HasName("PK__Dimensio__80FC9FCDD444F843");

                entity.ToTable("Dimension_Pipeline_QuoteStatus", "dbo");

                entity.Property(e => e.PipelineQuoteStatusCode).ValueGeneratedNever();

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.PipelineQuoteStatusCreatedDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.PipelineQuoteStatusDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PipelineQuoteStatusModifiedDateTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<DimensionProduct>(entity =>
            {
                entity.HasKey(e => e.ItemSeq)
                    .HasName("PK__Dimensio__257CBBF8CDB60391");

                entity.ToTable("Dimension_Product", "dbo");

                entity.Property(e => e.BrandDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.ItemBundleDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ItemBundleFlag)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ItemClassCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ItemClassDescription)
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDescriptivePartNumber)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDropShipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemDropShipDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ItemGroupMajorCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemGroupMajorDescription)
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.ItemGroupMinorCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemGroupMinorDescription)
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.ItemHazardousMaterialsClassCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemHazardousMaterialsClassDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ItemHeight).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.ItemImportExportCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemImportExportDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ItemInstallCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemInstallDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemLength).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.ItemManufacturerPartNumber)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMultiBoxCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemMultiBoxDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNonReturnableDescription)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNonReturnableFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ItemOriginalManufacturerPartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemPlatformCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ItemPlatformDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ItemRestrictSalesFlag)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTaxRuleCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTaxRuleDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTaxableDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTaxableFlag)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTypeCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTypeDescription)
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.ItemUvrcode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ItemUVRCode");

                entity.Property(e => e.ItemUvrdescription)
                    .HasMaxLength(56)
                    .IsUnicode(false)
                    .HasColumnName("ItemUVRDescription");

                entity.Property(e => e.ItemWeight).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.ItemWidth).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.ManufacturerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerDescription)
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerSegmentDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityMatrixCategoryCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityMatrixCategoryDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryManufacturerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryManufacturerDescription)
                    .HasMaxLength(85)
                    .IsUnicode(false);

                entity.Property(e => e.PrimarySupplierCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimarySupplierDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOfficerName)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.QblsupplierCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QBLSupplierCode");

                entity.Property(e => e.QblsupplierDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("QBLSupplierDescription");
            });

            modelBuilder.Entity<DimensionRenewalStatus>(entity =>
            {
                entity.HasKey(e => e.RenewalStatusCode)
                    .HasName("PK__Dimensio__43699799CBFD9442");

                entity.ToTable("Dimension_Renewal_Status", "dbo");

                entity.Property(e => e.RenewalStatusCode).ValueGeneratedNever();

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.RenewalStatusDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DimensionSegmentTransactionThreshold>(entity =>
            {
                entity.HasKey(e => e.TransactionThresholdSeq)
                    .HasName("PK__Dimensio__1CF407E6F9C320AD");

                entity.ToTable("Dimension_Segment_TransactionThreshold", "dbo");

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.NodeDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NodeLevel)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ThresholdAmount)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DimensionServiceType>(entity =>
            {
                entity.HasKey(e => e.ServiceTypeCode);

                entity.ToTable("Dimension_ServiceType", "dbo");

                entity.Property(e => e.ServiceTypeCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.ServiceTypeDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DimensionShipMethod>(entity =>
            {
                entity.HasKey(e => e.ShipMethodCode);

                entity.ToTable("Dimension_ShipMethod", "dbo");

                entity.Property(e => e.ShipMethodCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CarrierCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CarrierDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeFreight)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.InsuranceCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.InsuranceRule)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.LabelTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OverrideToShipMethod)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PrintPriorityCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatusCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingGroupCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingGroupDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipMethodDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingLabelPrintAddress).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ShippingTagType)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SourceChangeUser)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StandardCarrierAlphaCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TransmitInsurance3rdParty)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DimensionSpsForm>(entity =>
            {
                entity.HasKey(e => e.FormCode);

                entity.ToTable("Dimension_SPS_Form", "dbo");

                entity.Property(e => e.FormCode).ValueGeneratedNever();

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.FormAliasDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FormDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValidFmTs).HasColumnName("ValidFmTS");

                entity.Property(e => e.ValidToTs).HasColumnName("ValidToTS");
            });

            modelBuilder.Entity<DimensionSpsFormAlias>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dimension_SPS_FormAlias", "dbo");

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.FormAliasDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DimensionSpsFormCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryCode)
                    .HasName("PK__Dimensio__371BA954509418C6");

                entity.ToTable("Dimension_SPS_FormCategory", "dbo");

                entity.Property(e => e.CategoryCode).ValueGeneratedNever();

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.ValidFmTs).HasColumnName("ValidFmTS");

                entity.Property(e => e.ValidToTs).HasColumnName("ValidToTS");
            });

            modelBuilder.Entity<DimensionSpsMethod>(entity =>
            {
                entity.HasKey(e => e.SpsmethodCode)
                    .HasName("PK__Dimensio__C0F5D5BA70268920");

                entity.ToTable("Dimension_SPS_Method", "dbo");

                entity.Property(e => e.SpsmethodCode)
                    .ValueGeneratedNever()
                    .HasColumnName("SPSMethodCode");

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.SpsmethodDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SPSMethodDescription");
            });

            modelBuilder.Entity<DimensionTransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionCode)
                    .HasName("PK__Dimensio__D85E702722FDF0E7");

                entity.ToTable("Dimension_Transaction", "dbo");

                entity.Property(e => e.TransactionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DetailShowHeaderNonEdcrevenue).HasColumnName("DetailShowHeaderNonEDCRevenue");

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.HasCdwinternalSoftwareProgram).HasColumnName("HasCDWInternalSoftwareProgram");

                entity.Property(e => e.TransactionDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionTypeCode)
                    .IsRequired()
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Emp05Staging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EMP05_Staging", "idw01");

                entity.Property(e => e.Tya4nb)
                    .HasMaxLength(50)
                    .HasColumnName("TYA4NB");

                entity.Property(e => e.Tyaavn)
                    .HasMaxLength(50)
                    .HasColumnName("TYAAVN");

                entity.Property(e => e.Tyabvn)
                    .HasMaxLength(50)
                    .HasColumnName("TYABVN");

                entity.Property(e => e.Tyatnb)
                    .HasMaxLength(50)
                    .HasColumnName("TYATNB");

                entity.Property(e => e.Tybdvn)
                    .HasMaxLength(50)
                    .HasColumnName("TYBDVN");

                entity.Property(e => e.Tybjvn)
                    .HasMaxLength(50)
                    .HasColumnName("TYBJVN");

                entity.Property(e => e.Tybkvn)
                    .HasMaxLength(50)
                    .HasColumnName("TYBKVN");

                entity.Property(e => e.Tyc1tt)
                    .HasMaxLength(50)
                    .HasColumnName("TYC1TT");

                entity.Property(e => e.Tyc2tt)
                    .HasMaxLength(50)
                    .HasColumnName("TYC2TT");

                entity.Property(e => e.Tyc3tt)
                    .HasMaxLength(50)
                    .HasColumnName("TYC3TT");

                entity.Property(e => e.Tyc4tt)
                    .HasMaxLength(50)
                    .HasColumnName("TYC4TT");

                entity.Property(e => e.Tyc5tt)
                    .HasMaxLength(50)
                    .HasColumnName("TYC5TT");

                entity.Property(e => e.Tyc6tt)
                    .HasMaxLength(50)
                    .HasColumnName("TYC6TT");

                entity.Property(e => e.Tyc7tt)
                    .HasMaxLength(50)
                    .HasColumnName("TYC7TT");

                entity.Property(e => e.Tycono)
                    .HasMaxLength(50)
                    .HasColumnName("TYCONO");

                entity.Property(e => e.Tydbtt)
                    .HasMaxLength(50)
                    .HasColumnName("TYDBTT");

                entity.Property(e => e.Tydstg)
                    .HasMaxLength(50)
                    .HasColumnName("TYDSTG");

                entity.Property(e => e.Tydtcr)
                    .HasMaxLength(50)
                    .HasColumnName("TYDTCR");

                entity.Property(e => e.Tyejst)
                    .HasMaxLength(50)
                    .HasColumnName("TYEJST");

                entity.Property(e => e.Tyemad)
                    .HasMaxLength(100)
                    .HasColumnName("TYEMAD");

                entity.Property(e => e.Tyfadt)
                    .HasMaxLength(50)
                    .HasColumnName("TYFADT");

                entity.Property(e => e.Tyfqss)
                    .HasMaxLength(50)
                    .HasColumnName("TYFQSS");

                entity.Property(e => e.Tyfsss)
                    .HasMaxLength(50)
                    .HasColumnName("TYFSSS");

                entity.Property(e => e.Tyftss)
                    .HasMaxLength(50)
                    .HasColumnName("TYFTSS");

                entity.Property(e => e.Tyi9tx)
                    .HasMaxLength(50)
                    .HasColumnName("TYI9TX");

                entity.Property(e => e.Tyjatx)
                    .HasMaxLength(50)
                    .HasColumnName("TYJATX");

                entity.Property(e => e.Tykfva)
                    .HasMaxLength(50)
                    .HasColumnName("TYKFVA");

                entity.Property(e => e.Tyl8cd)
                    .HasMaxLength(50)
                    .HasColumnName("TYL8CD");

                entity.Property(e => e.Tyl8ss)
                    .HasMaxLength(50)
                    .HasColumnName("TYL8SS");

                entity.Property(e => e.Tyl9ss)
                    .HasMaxLength(50)
                    .HasColumnName("TYL9SS");

                entity.Property(e => e.Tymass)
                    .HasMaxLength(50)
                    .HasColumnName("TYMASS");

                entity.Property(e => e.Tymbss)
                    .HasMaxLength(50)
                    .HasColumnName("TYMBSS");

                entity.Property(e => e.Tymdin)
                    .HasMaxLength(50)
                    .HasColumnName("TYMDIN");

                entity.Property(e => e.Tyn6xt)
                    .HasMaxLength(50)
                    .HasColumnName("TYN6XT");

                entity.Property(e => e.Tyn7xt)
                    .HasMaxLength(50)
                    .HasColumnName("TYN7XT");

                entity.Property(e => e.Tys7st)
                    .HasMaxLength(50)
                    .HasColumnName("TYS7ST");

                entity.Property(e => e.Tys8st)
                    .HasMaxLength(50)
                    .HasColumnName("TYS8ST");

                entity.Property(e => e.Tys9st)
                    .HasMaxLength(50)
                    .HasColumnName("TYS9ST");

                entity.Property(e => e.Tysrep)
                    .HasMaxLength(50)
                    .HasColumnName("TYSREP");

                entity.Property(e => e.Tytast)
                    .HasMaxLength(50)
                    .HasColumnName("TYTAST");

                entity.Property(e => e.Tytbst)
                    .HasMaxLength(50)
                    .HasColumnName("TYTBST");

                entity.Property(e => e.Tytcst)
                    .HasMaxLength(50)
                    .HasColumnName("TYTCST");

                entity.Property(e => e.Tytdst)
                    .HasMaxLength(50)
                    .HasColumnName("TYTDST");

                entity.Property(e => e.Tytfst)
                    .HasMaxLength(50)
                    .HasColumnName("TYTFST");

                entity.Property(e => e.Tytist)
                    .HasMaxLength(50)
                    .HasColumnName("TYTIST");

                entity.Property(e => e.Tytjst)
                    .HasMaxLength(50)
                    .HasColumnName("TYTJST");

                entity.Property(e => e.Tytkst)
                    .HasMaxLength(50)
                    .HasColumnName("TYTKST");

                entity.Property(e => e.Tytlst)
                    .HasMaxLength(50)
                    .HasColumnName("TYTLST");

                entity.Property(e => e.Tytmst)
                    .HasMaxLength(50)
                    .HasColumnName("TYTMST");

                entity.Property(e => e.Tytnst)
                    .HasMaxLength(50)
                    .HasColumnName("TYTNST");

                entity.Property(e => e.Tytost)
                    .HasMaxLength(50)
                    .HasColumnName("TYTOST");

                entity.Property(e => e.Tytpst)
                    .HasMaxLength(50)
                    .HasColumnName("TYTPST");

                entity.Property(e => e.Tytrmd)
                    .HasMaxLength(50)
                    .HasColumnName("TYTRMD");

                entity.Property(e => e.Tyurid)
                    .HasMaxLength(50)
                    .HasColumnName("TYURID");

                entity.Property(e => e.Tyxjtx)
                    .HasMaxLength(50)
                    .HasColumnName("TYXJTX");

                entity.Property(e => e.Tyyptt)
                    .HasMaxLength(50)
                    .HasColumnName("TYYPTT");
            });

            modelBuilder.Entity<FactBidOrder>(entity =>
            {
                entity.HasKey(e => new { e.BidRequestCode, e.BidRequestLineNumber });

                entity.ToTable("Fact_BidOrder", "dbo");

                entity.Property(e => e.AccountManagerCoworkerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDateTime).HasColumnType("datetime");

                entity.Property(e => e.AttainmentSourceCdFlg)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BackEndRebateFlag)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BidDeniedReasonCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BidDetailStatusCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BidHeaderStatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BidTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BtoparentEdc).HasColumnName("BTOParentEDC");

                entity.Property(e => e.BtoparentLineNumber).HasColumnName("BTOParentLineNumber");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CompetitorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CompetitorID");

                entity.Property(e => e.CompetitorModelNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CompetitorUnitPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ContractCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConvertedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ConvertedOrderCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerAddressCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSellingPriceLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.DeliveryAddress)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DeniedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DestinationGroup)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountedPurchaseOrderCostLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EdwcreatedDateTime).HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime).HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.FixedRebateAmountperUnit).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerAuthorizationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerPartNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerUnitListPriceLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ProgramthatChgdRecord)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramthatWroteRecord)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RebateBasisCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RebateClaimAmountperUnit).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RebateDiscountPercent).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.RebateLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SpecialBidPriceLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SupplierCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierPurchaseOrderCostLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.VendorReferenceCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WaitStatusUser)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FactBidOrder1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FactBidOrder", "dbo");

                entity.Property(e => e.AccountManagerCoworkerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDateTime).HasColumnType("datetime");

                entity.Property(e => e.AttainmentSourceCdFlg)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BackEndRebateFlag)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BidDeniedReasonCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BidDetailStatusCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BidHeaderStatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BidTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BtoparentEdc).HasColumnName("BTOParentEDC");

                entity.Property(e => e.BtoparentLineNumber).HasColumnName("BTOParentLineNumber");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CompetitorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CompetitorID");

                entity.Property(e => e.CompetitorModelNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CompetitorUnitPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ContractCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConvertedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ConvertedOrderCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerAddressCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSellingPriceLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.DeliveryAddress)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DeniedDateTime).HasColumnType("datetime");

                entity.Property(e => e.DestinationGroup)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountedPurchaseOrderCostLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EdwcreatedDateTime).HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime).HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.FactBidOrderId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FactBidOrderID");

                entity.Property(e => e.FixedRebateAmountperUnit).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerAuthorizationCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerPartNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerUnitListPriceLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.ProgramthatChgdRecord)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramthatWroteRecord)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RebateBasisCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RebateClaimAmountperUnit).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RebateDiscountPercent).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.RebateLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SpecialBidPriceLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SupplierCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierPurchaseOrderCostLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.VendorReferenceCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WaitStatusUser)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FactCommission>(entity =>
            {
                entity.HasKey(e => e.CommissionSeq)
                    .HasName("PK__Fact_Com__77CAEDA75666298B");

                entity.ToTable("Fact_Commission", "dbo");

                entity.Property(e => e.AdjInvoiceLineNbr).HasColumnName("adjInvoiceLineNbr");

                entity.Property(e => e.AdjType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("adjType");

                entity.Property(e => e.AllocationPercent).HasColumnType("decimal(10, 4)");

                entity.Property(e => e.AtengagementCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ATEngagementCode");

                entity.Property(e => e.CommissionAdjustmentTypeCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CommissionCompensationPlanCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CommissionCoworkerTitleCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CommissionCreditId).HasColumnName("CommissionCreditID");

                entity.Property(e => e.CommissionEventTypeCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CommissionSalesOrderCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CommissionSalesTransactionAssignmentCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CommissionSalesTransactionCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CommissionableCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerGldepartmentCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CoworkerGLDepartmentCode");

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DataSource)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.GrossProfitLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.GrossProfitSharePercent).HasColumnType("decimal(5, 4)");

                entity.Property(e => e.InvoiceCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceSourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingSourceCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.NewHash)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OldEventTypeCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OldHash)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OrderCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSourceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalAccountManagerCoworkerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalAccountManagerGldepartmentCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OriginalAccountManagerGLDepartmentCode");

                entity.Property(e => e.OriginalCustomerCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalCustomerGldepartmentCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OriginalCustomerGLDepartmentCode");

                entity.Property(e => e.OriginalSpecialistGroupTypeCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PreSplitCost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PreSplitGrossProfit).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PreSplitRevenue).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(127)
                    .IsUnicode(false)
                    .HasColumnName("ProductID");

                entity.Property(e => e.ProgramName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnReasonCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RmareturnReasonCode).HasColumnName("RMAReturnReasonCode");

                entity.Property(e => e.SalesLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SalesSharePercent).HasColumnType("decimal(5, 4)");

                entity.Property(e => e.SalesTransactionCommentText)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ShipMethodCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SimcostLocalCurrencyAmount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("SIMCostLocalCurrencyAmount");

                entity.Property(e => e.SourcedFrom)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SplitType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TcCoworkerCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TC_CoworkerCode");

                entity.Property(e => e.TcCoworkerGl)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("TC_CoworkerGL");

                entity.Property(e => e.TcCoworkerTitle)
                    .HasMaxLength(127)
                    .IsUnicode(false)
                    .HasColumnName("TC_CoworkerTitle");

                entity.Property(e => e.TcCustomerName).HasColumnName("TC_CustomerName");
            });

            modelBuilder.Entity<FactCommissionAdjustment>(entity =>
            {
                entity.HasKey(e => new { e.CommissionMonthInt, e.AdjustmentDateInt, e.AdjustmentReferenceCode, e.AdjustmentReferenceLineNumber, e.CompanyCode, e.CoworkerCode })
                    .HasName("PK__Fact_Com__2EA5A25972EEA8E0");

                entity.ToTable("Fact_Commission_Adjustment", "dbo");

                entity.Property(e => e.AdjustmentReferenceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdjustmentGrossProfitDollarAmount).HasColumnType("money");

                entity.Property(e => e.AdjustmentReasonDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdjustmentSalesDollarAmount).HasColumnType("money");

                entity.Property(e => e.AdjustmentTypeCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");
            });

            modelBuilder.Entity<FactCommissionAdjustment1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Fact_Commission_Adjustments", "dbo");

                entity.Property(e => e.AdjustmentGrossProfitDollarAmount).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AdjustmentSalesDollarAmount).HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<FactCommissionAdjustmentFreight>(entity =>
            {
                entity.HasKey(e => new { e.CompanyCode, e.CoworkerCode, e.CommissionMonth, e.DateAdjustment, e.InvoiceCode, e.InvoiceLineNumber, e.FreightAdjustmentNumber })
                    .HasName("PK__Fact_Com__B33C3E213B3DF784");

                entity.ToTable("Fact_Commission_Adjustment_Freight", "dbo");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccountManagerCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cdwcity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWCity");

                entity.Property(e => e.Cdwneighborhood)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhood");

                entity.Property(e => e.Cdwstate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWState");

                entity.Property(e => e.CoworkerCodeCreated)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerCodeModified)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.FreightAdjustmentStatusCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FreightAdjustmentStatusDescription)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GrossProfitAdjustmentDollarAmount).HasColumnType("money");

                entity.Property(e => e.GrossProfitAdjustmentDollarAmountOriginal).HasColumnType("money");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LineQuantity).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.OrderActionReason)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OrderCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PercentTotalWeightCost).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProgramCreated)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WeightTotal).HasColumnType("decimal(13, 4)");

                entity.Property(e => e.WeightUnit).HasColumnType("decimal(11, 4)");
            });

            modelBuilder.Entity<FactInventoryItem>(entity =>
            {
                entity.HasKey(e => new { e.InventoryDate, e.CompanyCode, e.ItemCode, e.DistributionCenterZone });

                entity.ToTable("Fact_Inventory_Item", "dbo");

                entity.Property(e => e.InventoryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DistributionCenterZone)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BidWinnerStock).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ConsignmentCatalogUnitDollarAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ConsignmentSupplierCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.ItemLogisticsCostOfGoods).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LogisticsLast30DayDollarAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LogisticsLast30DayShippedQuantity).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.LogisticsLastInvoiceDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PrimaryBin)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.QuantityAllocated).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.QuantityAvailable).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.QuantityCreditBackOrder).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.QuantityInPicking).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.QuantityInTransit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.QuantityOnBackOrder).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.QuantityOnOrder).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.QuantityPhysical).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.SimCostDollarAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SupplierStock).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.WarehouseCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FactInvoice>(entity =>
            {
                entity.ToTable("Fact_Invoice", "dbo");

                entity.Property(e => e.FactInvoiceId).HasColumnName("FactInvoiceID");

                entity.Property(e => e.AccountManagerCoworkerCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ContractCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConvertedFromQuoteOrderCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAddressCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPurchaseOrder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistributionCenterCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DistributionCenterZoneCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DropShipPosupplierCostLocalCurrencyAmount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("DropShipPOSupplierCostLocalCurrencyAmount");

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.FreightChargeLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.HandlingChargeLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.IncurredFreightLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.InsuranceChargeLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.InvoiceCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceGldepartmentCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceGLDepartmentCode");

                entity.Property(e => e.InvoiceLineTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceSourceCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceStatusCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LandedCostLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LogisticsCogslocalCurrencyAmount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("LogisticsCOGSLocalCurrencyAmount");

                entity.Property(e => e.MarketingSourceCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OfferCouponCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSizeRange)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSourceCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalCustomerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PriceListCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnReasonCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnReasonGlpostingCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ReturnReasonGLPostingCode");

                entity.Property(e => e.SalesCogslocalCurrencyAmount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("SalesCOGSLocalCurrencyAmount");

                entity.Property(e => e.SalesLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SalesQuantity).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.SecondaryAccountManagerCoworkerCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ShipMethodCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SimCostLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SoftwareAgrrementCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialistOnOrderFlag).HasColumnName("SpecialistOnORderFlag");

                entity.Property(e => e.TotalSalesLocalCurrencyAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TransactionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FactOpportunityNonTangible>(entity =>
            {
                entity.HasKey(e => new { e.CartCode, e.OrderCode, e.SoftwarePipelineCartItemCode })
                    .HasName("PK__Fact_Opp__C0C6D269E2C4742F");

                entity.ToTable("Fact_Opportunity_NonTangible", "dbo");

                entity.Property(e => e.OrderCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.IsmonthlyFlag).HasColumnName("ISMonthlyFlag");

                entity.Property(e => e.SellPriceDollarAmount).HasColumnType("money");

                entity.Property(e => e.TotalIncentiveDollarAmount).HasColumnType("money");
            });

            modelBuilder.Entity<FactOpportunityTangible>(entity =>
            {
                entity.HasKey(e => e.OrderCode);

                entity.ToTable("Fact_Opportunity_Tangible", "dbo");

                entity.Property(e => e.OrderCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EaopportunityCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EAOpportunityCode");

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.EnrollmentNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MonthlyRecurringRevenueDollarAmount).HasColumnType("money");

                entity.Property(e => e.OpportunityAllocationToken)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityDistributionCenterCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OpportunityOriginalInvoiceCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityOriginalOrderCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityPartialShipCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OpportunityRtaintentionCode).HasColumnName("OpportunityRTAIntentionCode");

                entity.Property(e => e.OrderNotes)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.PrimarySpecialistCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProbabilityToClosePercent).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductVendor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondarySpecialistCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SoftwareOrderType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoftwareProgramS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalSoftwareIncentiveDollarAmount).HasColumnType("money");
            });

            modelBuilder.Entity<FactOrder>(entity =>
            {
                entity.HasKey(e => new { e.OrderCode, e.OrderLineNumber, e.OrderDateInt, e.CompanyCode });

                entity.ToTable("Fact_Order", "dbo");

                entity.Property(e => e.OrderCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContractCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConvertedFromQuoteOrderCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByCoworkerCode)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerAddressCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPurchaseOrder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EaccountUserKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LogisticSuspendCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingSourceCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByCoworkerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ModifiedByUserID");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OfferCouponCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDollarAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.OrderLineStatusCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSecondaryCoworkerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSourceCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatusCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderingCoworkerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalContactCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalCustomerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PriceListCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductSoftwareCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductSoftwareOriginalCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuantityAllocated).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QuantityInvoiced).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QuantityOrdered).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QuantityOutStanding).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.ShipMethodCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SladueDateInt).HasColumnName("SLADueDateInt");

                entity.Property(e => e.SlatypeDescription)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SLATypeDescription");

                entity.Property(e => e.SuspendCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TotalOrderDollarAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TransactionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WebTransactionOriginCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FactOrderOpportunity>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FactOrderOpportunity", "dbo");

                entity.Property(e => e.EaopportunityCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EAOpportunityCode");

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.EnrollmentNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MonthlyRecurringRevenueAmount).HasColumnType("money");

                entity.Property(e => e.OpportunityAllocationToken)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OpportunityRtaintentionCode).HasColumnName("OpportunityRTAIntentionCode");

                entity.Property(e => e.OrderNotes).IsUnicode(false);

                entity.Property(e => e.ProbabilityToClosePercent).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductVendor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoftwareOrderType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoftwareProgramS)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalSoftwareIncentiveDollarAmount).HasColumnType("money");
            });

            modelBuilder.Entity<FactOrderSuspendAndActionLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Fact_Order_SuspendAndAction_Log", "dbo");

                entity.Property(e => e.ActionByCoworkerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ActionDateTime).HasColumnType("datetime");

                entity.Property(e => e.DurationInDays).HasColumnType("numeric(14, 6)");

                entity.Property(e => e.DurationInHours).HasColumnType("numeric(14, 6)");

                entity.Property(e => e.DurationInMinutes).HasColumnType("numeric(14, 6)");

                entity.Property(e => e.DurationInSeconds).HasColumnType("numeric(14, 6)");

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.IdentitySeqNumber).ValueGeneratedOnAdd();

                entity.Property(e => e.NewSuspendCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldSuspendCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderActionCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OrderType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Program)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOrderCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOrderCompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOrderCustomerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOrderStatusCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOrderTransactionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.TransactionOrderCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionOrderCompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionOrderCustomerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FactPurchaseOrder>(entity =>
            {
                entity.HasKey(e => new { e.PurchaseOrderCode, e.PurchaseOrderLineNumber });

                entity.ToTable("Fact_PurchaseOrder", "dbo");

                entity.Property(e => e.PurchaseOrderCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AutomatedPocreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("AutomatedPOCreatedDateTime");

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmedByCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmedByUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ConfirmedByUserID");

                entity.Property(e => e.ConfirmedWithVendor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DistributionCenterCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DropShipOrderCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DropShipPocancelDateInt).HasColumnName("DropShipPOCancelDateInt");

                entity.Property(e => e.DropShipPocancelDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("DropShipPOCancelDateTime");

                entity.Property(e => e.DropShipPocancelMinutes).HasColumnName("DropShipPOCancelMinutes");

                entity.Property(e => e.DropShipPocancelReasonInt).HasColumnName("DropShipPOCancelReasonInt");

                entity.Property(e => e.DropShipPocancelUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DropShipPOCancelUserID");

                entity.Property(e => e.DropShipPoprocessMinutes).HasColumnName("DropShipPOProcessMinutes");

                entity.Property(e => e.DropShipPopurchaseOfficerProcessMinutes).HasColumnName("DropShipPOPurchaseOfficerProcessMinutes");

                entity.Property(e => e.DropShipPoreleaseDateInt).HasColumnName("DropShipPOReleaseDateInt");

                entity.Property(e => e.DropShipPoreleaseDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DropShipPOReleaseDateTime");

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LogisticsStandardCostDollarAmount).HasColumnType("money");

                entity.Property(e => e.ModifiedByCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ModifiedByUserID");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.PurchaseOfficerCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderFreightTermsCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderQuantity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PurchaseOrderQuantityInvoiced).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PurchaseOrderQuantityOutstanding).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PurchaseOrderQuantityReceived).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PurchaseOrderShipMethodSeq)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderSupplierCost).HasColumnType("money");

                entity.Property(e => e.PurchaseOrderSupplierPartNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderTypeCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SimCostDollarAmount).HasColumnType("money");

                entity.Property(e => e.SupplierAccountDiversed)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierAccountReleased)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.VolumePriceAgreementCost).HasColumnType("money");
            });

            modelBuilder.Entity<FactQuote>(entity =>
            {
                entity.HasKey(e => new { e.QuoteCode, e.QuoteLineNumber, e.QuoteDateInt, e.CompanyCode });

                entity.ToTable("Fact_Quote", "dbo");

                entity.Property(e => e.QuoteCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCountryCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BillToStateCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContractCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByCoworkerCode)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerAddressCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPurchaseOrder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EaccountUserCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.IngramSpecialistCallCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IngramSpecialistSalesImpactCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LogisticSuspendCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingSourceCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MobileDeviceActivationRequestCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByCoworkerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ModifiedByUserID");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OfferCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OfferCouponCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSecondaryCoworkerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderingCoworkerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalContactCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalCustomerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PriceListCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductSoftwareCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuantityAllocated).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QuantityInvoiced).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QuantityOutStanding).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QuantityQuoted).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QuoteDollarAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.QuoteOrderLineStatusCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteOrderSourceCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteOrderStatusCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipMethodCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SladueDateInt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SLADueDateInt");

                entity.Property(e => e.SlatypeDescription)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SLATypeDescription");

                entity.Property(e => e.SuspendCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TotalQuoteDollarAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TransactionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WebTransactionOriginCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FactRenewal>(entity =>
            {
                entity.HasKey(e => new { e.RenewalId, e.RenewalLineNumber, e.InvoiceNumber })
                    .HasName("PK__Fact_Ren__5E12AF1F4BB885FE");

                entity.ToTable("Fact_Renewal", "dbo");

                entity.Property(e => e.RenewalId).HasColumnName("RenewalID");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdHocRenewalLandedCost).HasColumnType("money");

                entity.Property(e => e.AdHocRenewalLandedMargin).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AdHocRenewalSalesDollarAmount).HasColumnType("money");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DelegatedCoworkerId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("DelegatedCoworkerID");

                entity.Property(e => e.DelegatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.ExpectedEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ExpectedStartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ModifiedByCoworkerEd)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ModifiedByCoworkerED");

                entity.Property(e => e.ProductCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PursuerCoworkerId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PursuerCoworkerID");

                entity.Property(e => e.RenewalDate).HasColumnType("smalldatetime");

                entity.Property(e => e.RenewalReasonCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RenewalSourceDescription)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RenewalStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RenewalStatusId).HasColumnName("RenewalStatusID");

                entity.Property(e => e.RenewalTypeDescription)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesDollarAmount).HasColumnType("money");

                entity.Property(e => e.SimCostDollarAmount).HasColumnType("money");
            });

            modelBuilder.Entity<FactSalesGoalCoworker>(entity =>
            {
                entity.HasKey(e => new { e.SalesGoalSegmentDescription, e.Month, e.CoworkerCode });

                entity.ToTable("Fact_SalesGoal_Coworker", "dbo");

                entity.Property(e => e.SalesGoalSegmentDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.ProfitGoalDollarAmount).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.SalesGoalDollarAmount).HasColumnType("decimal(20, 5)");
            });

            modelBuilder.Entity<FactSpsMonitoring>(entity =>
            {
                entity.HasKey(e => e.MonitoringCode)
                    .HasName("PK__Fact_SPS__066B70D1FF3AAC58");

                entity.ToTable("Fact_SPS_Monitoring", "dbo");

                entity.Property(e => e.MonitoringCode).ValueGeneratedNever();

                entity.Property(e => e.Comments)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.MachineName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NetworkUserId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NetworkUserID");

                entity.Property(e => e.SigmaSd).HasColumnName("SigmaSD");

                entity.Property(e => e.SpsformCode).HasColumnName("SPSFormCode");

                entity.Property(e => e.SpsmethodDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SPSMethodDescription");

                entity.Property(e => e.SpsmonitoringTypeCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SPSMonitoringTypeCode");

                entity.Property(e => e.SpsversionBuildCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SPSVersionBuildCode");

                entity.Property(e => e.Url)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<LoadLogging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LoadLogging", "logging");

                entity.Property(e => e.CopyTaskName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LoadSchema)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoadSourceTable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoadType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoadWorkflow)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PipelineName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceSystemName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Oep20Staging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OEP20_Staging", "idw01");

                entity.Property(e => e.Ackn20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACKN20");

                entity.Property(e => e.Actf20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTF20");

                entity.Property(e => e.Bord20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BORD20");

                entity.Property(e => e.Brch20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BRCH20");

                entity.Property(e => e.Carg20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CARG20");

                entity.Property(e => e.Ccls20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCLS20");

                entity.Property(e => e.Comb20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COMB20");

                entity.Property(e => e.Cono20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONO20");

                entity.Property(e => e.Cons20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONS20");

                entity.Property(e => e.Corp20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CORP20");

                entity.Property(e => e.Curc20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CURC20");

                entity.Property(e => e.Cusn20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CUSN20");

                entity.Property(e => e.Dgrp20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DGRP20");

                entity.Property(e => e.Disc20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISC20");

                entity.Property(e => e.Divn20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DIVN20");

                entity.Property(e => e.Dseq20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DSEQ20");

                entity.Property(e => e.Dtlc20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DTLC20");

                entity.Property(e => e.Inpp20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INPP20");

                entity.Property(e => e.List20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LIST20");

                entity.Property(e => e.Locd20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOCD20");

                entity.Property(e => e.Malp20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MALP20");

                entity.Property(e => e.Pdlv20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PDLV20");

                entity.Property(e => e.Prty20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRTY20");

                entity.Property(e => e.Refr20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REFR20");

                entity.Property(e => e.Regn20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REGN20");

                entity.Property(e => e.Sdiv20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SDIV20");

                entity.Property(e => e.Slm220)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SLM220");

                entity.Property(e => e.Slmn20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SLMN20");

                entity.Property(e => e.Sosg20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SOSG20");

                entity.Property(e => e.Spac20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SPAC20");

                entity.Property(e => e.Stat20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STAT20");

                entity.Property(e => e.Stte20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STTE20");

                entity.Property(e => e.Trty20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TRTY20");
            });

            modelBuilder.Entity<Oep87Staging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OEP87_Staging", "idw01");

                entity.Property(e => e.Actn87)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACTN87");

                entity.Property(e => e.Date87).HasColumnName("DATE87");

                entity.Property(e => e.Prgm87)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PRGM87");
            });

            modelBuilder.Entity<OrderHeaderStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrderHeaderStatus", "metadata");

                entity.Property(e => e.OrderStatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatusDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatusGroupDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderLineStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrderLineStatus", "metadata");

                entity.Property(e => e.ConditionDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionTest)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FieldDdsname)
                    .IsRequired()
                    .HasMaxLength(510)
                    .IsUnicode(false)
                    .HasColumnName("FieldDDSName");

                entity.Property(e => e.FieldDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileDdsname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FileDDSName");

                entity.Property(e => e.FileDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Plp14tStaging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PLP14T_Staging", "idw01");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContractNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierAccountDiversed)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierAccountReleased)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pmp02Staging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PMP02_Staging", "idw01");

                entity.Property(e => e.Cfby02)
                    .HasMaxLength(50)
                    .HasColumnName("CFBY02");

                entity.Property(e => e.Cfdt02).HasColumnName("CFDT02");

                entity.Property(e => e.Cfwh02)
                    .HasMaxLength(50)
                    .HasColumnName("CFWH02");

                entity.Property(e => e.Cono02)
                    .HasMaxLength(50)
                    .HasColumnName("CONO02");

                entity.Property(e => e.Ftcd02)
                    .HasMaxLength(50)
                    .HasColumnName("FTCD02");

                entity.Property(e => e.Jobn02)
                    .HasMaxLength(50)
                    .HasColumnName("JOBN02");

                entity.Property(e => e.Ordn02)
                    .HasMaxLength(50)
                    .HasColumnName("ORDN02");

                entity.Property(e => e.Ordt02).HasColumnName("ORDT02");

                entity.Property(e => e.Plan02).HasColumnName("PLAN02");

                entity.Property(e => e.Shpm02)
                    .HasMaxLength(50)
                    .HasColumnName("SHPM02");
            });

            modelBuilder.Entity<Pmp03Staging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PMP03_Staging", "idw01");

                entity.Property(e => e.A0tm03)
                    .HasColumnType("date")
                    .HasColumnName("A0TM03");

                entity.Property(e => e.Acrc03).HasColumnName("ACRC03");

                entity.Property(e => e.Bmvn03)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BMVN03");

                entity.Property(e => e.Bovn03)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BOVN03");

                entity.Property(e => e.Cono03)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONO03");

                entity.Property(e => e.Crtm03)
                    .HasColumnType("date")
                    .HasColumnName("CRTM03");

                entity.Property(e => e.D6dt03).HasColumnName("D6DT03");

                entity.Property(e => e.Dued03).HasColumnName("DUED03");

                entity.Property(e => e.Flg103)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FLG103");

                entity.Property(e => e.Item03)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ITEM03");

                entity.Property(e => e.Line03).HasColumnName("LINE03");

                entity.Property(e => e.Oqty03)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("OQTY03");

                entity.Property(e => e.Ordn03)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORDN03");

                entity.Property(e => e.Plan03)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PLAN03");

                entity.Property(e => e.Pric03)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PRIC03");

                entity.Property(e => e.Q5nb03).HasColumnName("Q5NB03");

                entity.Property(e => e.Qinv03)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("QINV03");

                entity.Property(e => e.Qrec03)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("QREC03");

                entity.Property(e => e.Qtos03)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("QTOS03");

                entity.Property(e => e.Vndr03)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VNDR03");

                entity.Property(e => e.Whse03)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WHSE03");
            });

            modelBuilder.Entity<Pmp06Staging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PMP06_Staging", "idw01");

                entity.Property(e => e.Cono06)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CONO06");

                entity.Property(e => e.Plan06).HasColumnName("PLAN06");

                entity.Property(e => e.Plnn06)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PLNN06");
            });

            modelBuilder.Entity<PsDeptTbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PS_Dept_Tbl", "staging");

                entity.Property(e => e.Deptid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEPTID");

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCR");

                entity.Property(e => e.EffStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EFF_STATUS");

                entity.Property(e => e.Effdt).HasColumnName("EFFDT");

                entity.Property(e => e.Setid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SETID");
            });

            modelBuilder.Entity<PsHoliday>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PS_Holidays", "staging");

                entity.Property(e => e.Descr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESCR");

                entity.Property(e => e.HolTimeEnd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HOL_TIME_END");

                entity.Property(e => e.HolTimeStart)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HOL_TIME_START");

                entity.Property(e => e.Holiday)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HOLIDAY");

                entity.Property(e => e.HolidayHrs)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HOLIDAY_HRS");

                entity.Property(e => e.HolidaySchedule)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("HOLIDAY_SCHEDULE");

                entity.Property(e => e.HolidayType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("HOLIDAY_TYPE");
            });

            modelBuilder.Entity<PsTreeNodeTbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PS_Tree_Node_Tbl", "staging");

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCR");

                entity.Property(e => e.EffStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EFF_STATUS");

                entity.Property(e => e.Effdt).HasColumnName("EFFDT");

                entity.Property(e => e.Setid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SETID");

                entity.Property(e => e.TreeNode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TREE_NODE");
            });

            modelBuilder.Entity<PstreeLeaf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PSTreeLeaf", "staging");

                entity.Property(e => e.DynamicRange)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DYNAMIC_RANGE");

                entity.Property(e => e.Effdt).HasColumnName("EFFDT");

                entity.Property(e => e.LeafImage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LEAF_IMAGE");

                entity.Property(e => e.OldTreeNodeNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OLD_TREE_NODE_NUM");

                entity.Property(e => e.RangeFrom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RANGE_FROM");

                entity.Property(e => e.RangeTo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RANGE_TO");

                entity.Property(e => e.Setcntrlvalue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SETCNTRLVALUE");

                entity.Property(e => e.Setid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SETID");

                entity.Property(e => e.TreeBranch)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TREE_BRANCH");

                entity.Property(e => e.TreeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TREE_NAME");

                entity.Property(e => e.TreeNodeNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TREE_NODE_NUM");
            });

            modelBuilder.Entity<PstreeNode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PSTreeNode", "staging");

                entity.Property(e => e.Effdt).HasColumnName("EFFDT");

                entity.Property(e => e.NodecolImage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NODECOL_IMAGE");

                entity.Property(e => e.NodeexpImage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NODEEXP_IMAGE");

                entity.Property(e => e.OldTreeNodeNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OLD_TREE_NODE_NUM");

                entity.Property(e => e.ParentNodeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_NODE_NAME");

                entity.Property(e => e.ParentNodeNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PARENT_NODE_NUM");

                entity.Property(e => e.Setcntrlvalue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SETCNTRLVALUE");

                entity.Property(e => e.Setid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SETID");

                entity.Property(e => e.TreeBranch)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TREE_BRANCH");

                entity.Property(e => e.TreeLevelNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TREE_LEVEL_NUM");

                entity.Property(e => e.TreeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TREE_NAME");

                entity.Property(e => e.TreeNode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TREE_NODE");

                entity.Property(e => e.TreeNodeNum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TREE_NODE_NUM");

                entity.Property(e => e.TreeNodeNumEnd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TREE_NODE_NUM_END");

                entity.Property(e => e.TreeNodeType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TREE_NODE_TYPE");
            });

            modelBuilder.Entity<Sl05Staging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SL05_Staging", "idw01");

                entity.Property(e => e.Aya0tm)
                    .HasMaxLength(50)
                    .HasColumnName("AYA0TM");

                entity.Property(e => e.Aya4nb)
                    .HasMaxLength(50)
                    .HasColumnName("AYA4NB");

                entity.Property(e => e.Ayacfl)
                    .HasMaxLength(50)
                    .HasColumnName("AYACFL");

                entity.Property(e => e.Aybmvn)
                    .HasMaxLength(50)
                    .HasColumnName("AYBMVN");

                entity.Property(e => e.Aycsac)
                    .HasMaxLength(50)
                    .HasColumnName("AYCSAC");

                entity.Property(e => e.Aycusn)
                    .HasMaxLength(50)
                    .HasColumnName("AYCUSN");

                entity.Property(e => e.Aycwst)
                    .HasMaxLength(50)
                    .HasColumnName("AYCWST");

                entity.Property(e => e.Ayd6dt)
                    .HasMaxLength(50)
                    .HasColumnName("AYD6DT");

                entity.Property(e => e.Aydacn)
                    .HasMaxLength(50)
                    .HasColumnName("AYDACN");

                entity.Property(e => e.Aydshm)
                    .HasMaxLength(50)
                    .HasColumnName("AYDSHM");

                entity.Property(e => e.Aydtcr)
                    .HasMaxLength(50)
                    .HasColumnName("AYDTCR");

                entity.Property(e => e.Aydupf)
                    .HasMaxLength(50)
                    .HasColumnName("AYDUPF");

                entity.Property(e => e.Ayexdy)
                    .HasMaxLength(50)
                    .HasColumnName("AYEXDY");

                entity.Property(e => e.Ayfkss)
                    .HasMaxLength(50)
                    .HasColumnName("AYFKSS");

                entity.Property(e => e.Ayfldr)
                    .HasMaxLength(50)
                    .HasColumnName("AYFLDR");

                entity.Property(e => e.Ayfulf)
                    .HasMaxLength(50)
                    .HasColumnName("AYFULF");

                entity.Property(e => e.Aygjss)
                    .HasMaxLength(50)
                    .HasColumnName("AYGJSS");

                entity.Property(e => e.Ayhcom)
                    .HasMaxLength(50)
                    .HasColumnName("AYHCOM");

                entity.Property(e => e.Ayj2dt)
                    .HasMaxLength(50)
                    .HasColumnName("AYJ2DT");

                entity.Property(e => e.Ayj3dt)
                    .HasMaxLength(50)
                    .HasColumnName("AYJ3DT");

                entity.Property(e => e.Ayj8st)
                    .HasMaxLength(50)
                    .HasColumnName("AYJ8ST");

                entity.Property(e => e.Ayk2cd)
                    .HasMaxLength(50)
                    .HasColumnName("AYK2CD");

                entity.Property(e => e.Ayk3cd)
                    .HasMaxLength(50)
                    .HasColumnName("AYK3CD");

                entity.Property(e => e.Ayk4cd)
                    .HasMaxLength(50)
                    .HasColumnName("AYK4CD");

                entity.Property(e => e.Ayl8cd)
                    .HasMaxLength(50)
                    .HasColumnName("AYL8CD");

                entity.Property(e => e.Aylnne)
                    .HasMaxLength(50)
                    .HasColumnName("AYLNNE");

                entity.Property(e => e.Aylsxt)
                    .HasMaxLength(50)
                    .HasColumnName("AYLSXT");

                entity.Property(e => e.Ayltxt)
                    .HasMaxLength(50)
                    .HasColumnName("AYLTXT");

                entity.Property(e => e.Aym3ss)
                    .HasMaxLength(50)
                    .HasColumnName("AYM3SS");

                entity.Property(e => e.Aymcom)
                    .HasMaxLength(50)
                    .HasColumnName("AYMCOM");

                entity.Property(e => e.Ayprss)
                    .HasMaxLength(50)
                    .HasColumnName("AYPRSS");

                entity.Property(e => e.Aypsss)
                    .HasMaxLength(50)
                    .HasColumnName("AYPSSS");

                entity.Property(e => e.Ayptss)
                    .HasMaxLength(50)
                    .HasColumnName("AYPTSS");

                entity.Property(e => e.Aypuss)
                    .HasMaxLength(50)
                    .HasColumnName("AYPUSS");

                entity.Property(e => e.Aypvss)
                    .HasMaxLength(50)
                    .HasColumnName("AYPVSS");

                entity.Property(e => e.Ayrall)
                    .HasMaxLength(50)
                    .HasColumnName("AYRALL");

                entity.Property(e => e.Ayrrce)
                    .HasMaxLength(50)
                    .HasColumnName("AYRRCE");

                entity.Property(e => e.Ays5sw)
                    .HasMaxLength(50)
                    .HasColumnName("AYS5SW");

                entity.Property(e => e.Aysdlp)
                    .HasMaxLength(50)
                    .HasColumnName("AYSDLP");

                entity.Property(e => e.Ayusch)
                    .HasMaxLength(50)
                    .HasColumnName("AYUSCH");

                entity.Property(e => e.Ayuscr)
                    .HasMaxLength(50)
                    .HasColumnName("AYUSCR");

                entity.Property(e => e.Ayv3ss)
                    .HasMaxLength(50)
                    .HasColumnName("AYV3SS");

                entity.Property(e => e.Ayv4ss)
                    .HasMaxLength(50)
                    .HasColumnName("AYV4SS");

                entity.Property(e => e.Ayv6ss)
                    .HasMaxLength(50)
                    .HasColumnName("AYV6SS");

                entity.Property(e => e.Ayvlvl)
                    .HasMaxLength(50)
                    .HasColumnName("AYVLVL");

                entity.Property(e => e.Ayxsce)
                    .HasMaxLength(50)
                    .HasColumnName("AYXSCE");
            });

            modelBuilder.Entity<Slp05Staging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SLP05_Staging", "idw01");

                entity.Property(e => e.A4nb05)
                    .HasMaxLength(50)
                    .HasColumnName("A4NB05");

                entity.Property(e => e.Acdt05)
                    .HasMaxLength(50)
                    .HasColumnName("ACDT05");

                entity.Property(e => e.Alph05)
                    .HasMaxLength(50)
                    .HasColumnName("ALPH05");

                entity.Property(e => e.Amnd05)
                    .HasMaxLength(50)
                    .HasColumnName("AMND05");

                entity.Property(e => e.Apun05)
                    .HasMaxLength(50)
                    .HasColumnName("APUN05");

                entity.Property(e => e.Atln05)
                    .HasMaxLength(50)
                    .HasColumnName("ATLN05");

                entity.Property(e => e.Cad105)
                    .HasMaxLength(50)
                    .HasColumnName("CAD105");

                entity.Property(e => e.Cad205)
                    .HasMaxLength(50)
                    .HasColumnName("CAD205");

                entity.Property(e => e.Cad305)
                    .HasMaxLength(50)
                    .HasColumnName("CAD305");

                entity.Property(e => e.Cad405)
                    .HasMaxLength(50)
                    .HasColumnName("CAD405");

                entity.Property(e => e.Cad505)
                    .HasMaxLength(50)
                    .HasColumnName("CAD505");

                entity.Property(e => e.Carp05)
                    .HasMaxLength(50)
                    .HasColumnName("CARP05");

                entity.Property(e => e.Caty05)
                    .HasMaxLength(50)
                    .HasColumnName("CATY05");

                entity.Property(e => e.Cgp105)
                    .HasMaxLength(50)
                    .HasColumnName("CGP105");

                entity.Property(e => e.Cgp205)
                    .HasMaxLength(50)
                    .HasColumnName("CGP205");

                entity.Property(e => e.Cgp305)
                    .HasMaxLength(50)
                    .HasColumnName("CGP305");

                entity.Property(e => e.Cgp405)
                    .HasMaxLength(50)
                    .HasColumnName("CGP405");

                entity.Property(e => e.City05)
                    .HasMaxLength(50)
                    .HasColumnName("CITY05");

                entity.Property(e => e.Cldt05)
                    .HasMaxLength(50)
                    .HasColumnName("CLDT05");

                entity.Property(e => e.Cnam05)
                    .HasMaxLength(75)
                    .HasColumnName("CNAM05");

                entity.Property(e => e.Cnod05)
                    .HasMaxLength(50)
                    .HasColumnName("CNOD05");

                entity.Property(e => e.Cntn05)
                    .HasMaxLength(50)
                    .HasColumnName("CNTN05");

                entity.Property(e => e.Conf05)
                    .HasMaxLength(50)
                    .HasColumnName("CONF05");

                entity.Property(e => e.Cono05)
                    .HasMaxLength(50)
                    .HasColumnName("CONO05");

                entity.Property(e => e.Crlc05)
                    .HasMaxLength(50)
                    .HasColumnName("CRLC05");

                entity.Property(e => e.Crli05)
                    .HasMaxLength(50)
                    .HasColumnName("CRLI05");

                entity.Property(e => e.Crlm05)
                    .HasMaxLength(50)
                    .HasColumnName("CRLM05");

                entity.Property(e => e.Crsp05)
                    .HasMaxLength(50)
                    .HasColumnName("CRSP05");

                entity.Property(e => e.Crtf05)
                    .HasMaxLength(50)
                    .HasColumnName("CRTF05");

                entity.Property(e => e.Cstp05)
                    .HasMaxLength(50)
                    .HasColumnName("CSTP05");

                entity.Property(e => e.Curn05)
                    .HasMaxLength(50)
                    .HasColumnName("CURN05");

                entity.Property(e => e.Cusn05)
                    .HasMaxLength(50)
                    .HasColumnName("CUSN05");

                entity.Property(e => e.Dseq05)
                    .HasMaxLength(50)
                    .HasColumnName("DSEQ05");

                entity.Property(e => e.Dtcr05)
                    .HasMaxLength(50)
                    .HasColumnName("DTCR05");

                entity.Property(e => e.E3q9st)
                    .HasMaxLength(50)
                    .HasColumnName("E3Q9ST");

                entity.Property(e => e.E3rbst)
                    .HasMaxLength(50)
                    .HasColumnName("E3RBST");

                entity.Property(e => e.E3rcst)
                    .HasMaxLength(50)
                    .HasColumnName("E3RCST");

                entity.Property(e => e.E3rgst)
                    .HasMaxLength(50)
                    .HasColumnName("E3RGST");

                entity.Property(e => e.E3rhst)
                    .HasMaxLength(50)
                    .HasColumnName("E3RHST");

                entity.Property(e => e.Faxn05)
                    .HasMaxLength(50)
                    .HasColumnName("FAXN05");

                entity.Property(e => e.Gbnk05)
                    .HasMaxLength(50)
                    .HasColumnName("GBNK05");

                entity.Property(e => e.Gctl05)
                    .HasMaxLength(50)
                    .HasColumnName("GCTL05");

                entity.Property(e => e.Glco05)
                    .HasMaxLength(50)
                    .HasColumnName("GLCO05");

                entity.Property(e => e.H2cd05)
                    .HasMaxLength(50)
                    .HasColumnName("H2CD05");

                entity.Property(e => e.I9tx05)
                    .HasMaxLength(50)
                    .HasColumnName("I9TX05");

                entity.Property(e => e.Incd05)
                    .HasMaxLength(50)
                    .HasColumnName("INCD05");

                entity.Property(e => e.Inus05)
                    .HasMaxLength(50)
                    .HasColumnName("INUS05");

                entity.Property(e => e.Ixst05)
                    .HasMaxLength(50)
                    .HasColumnName("IXST05");

                entity.Property(e => e.Jatx05)
                    .HasMaxLength(50)
                    .HasColumnName("JATX05");

                entity.Property(e => e.Ltyp05)
                    .HasMaxLength(50)
                    .HasColumnName("LTYP05");

                entity.Property(e => e.Mcus05)
                    .HasMaxLength(50)
                    .HasColumnName("MCUS05");

                entity.Property(e => e.Mdin05)
                    .HasMaxLength(50)
                    .HasColumnName("MDIN05");

                entity.Property(e => e.Mseq05)
                    .HasMaxLength(50)
                    .HasColumnName("MSEQ05");

                entity.Property(e => e.Nqtx05)
                    .HasMaxLength(50)
                    .HasColumnName("NQTX05");

                entity.Property(e => e.Payr05)
                    .HasMaxLength(50)
                    .HasColumnName("PAYR05");

                entity.Property(e => e.Pcd105)
                    .HasMaxLength(50)
                    .HasColumnName("PCD105");

                entity.Property(e => e.Pcd205)
                    .HasMaxLength(50)
                    .HasColumnName("PCD205");

                entity.Property(e => e.Phon05)
                    .HasMaxLength(50)
                    .HasColumnName("PHON05");

                entity.Property(e => e.Prtf05)
                    .HasMaxLength(50)
                    .HasColumnName("PRTF05");

                entity.Property(e => e.Ptpr05)
                    .HasMaxLength(50)
                    .HasColumnName("PTPR05");

                entity.Property(e => e.Ptrm05)
                    .HasMaxLength(50)
                    .HasColumnName("PTRM05");

                entity.Property(e => e.Pttd05)
                    .HasMaxLength(50)
                    .HasColumnName("PTTD05");

                entity.Property(e => e.Pttp05)
                    .HasMaxLength(50)
                    .HasColumnName("PTTP05");

                entity.Property(e => e.Regn05)
                    .HasMaxLength(50)
                    .HasColumnName("REGN05");

                entity.Property(e => e.Rsts05)
                    .HasMaxLength(50)
                    .HasColumnName("RSTS05");

                entity.Property(e => e.Slmn05)
                    .HasMaxLength(50)
                    .HasColumnName("SLMN05");

                entity.Property(e => e.Spin05)
                    .HasMaxLength(100)
                    .HasColumnName("SPIN05");

                entity.Property(e => e.Sqlf05)
                    .HasMaxLength(50)
                    .HasColumnName("SQLF05");

                entity.Property(e => e.Stad05)
                    .HasMaxLength(50)
                    .HasColumnName("STAD05");

                entity.Property(e => e.Stam05)
                    .HasMaxLength(50)
                    .HasColumnName("STAM05");

                entity.Property(e => e.Stcp05)
                    .HasMaxLength(50)
                    .HasColumnName("STCP05");

                entity.Property(e => e.Stpc05)
                    .HasMaxLength(50)
                    .HasColumnName("STPC05");

                entity.Property(e => e.Stra05)
                    .HasMaxLength(50)
                    .HasColumnName("STRA05");

                entity.Property(e => e.Usch05)
                    .HasMaxLength(50)
                    .HasColumnName("USCH05");

                entity.Property(e => e.Uscr05)
                    .HasMaxLength(50)
                    .HasColumnName("USCR05");

                entity.Property(e => e.Vatn05)
                    .HasMaxLength(50)
                    .HasColumnName("VATN05");

                entity.Property(e => e.Vcod05)
                    .HasMaxLength(50)
                    .HasColumnName("VCOD05");

                entity.Property(e => e.Zipc05)
                    .HasMaxLength(50)
                    .HasColumnName("ZIPC05");
            });

            modelBuilder.Entity<SourceTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SourceTables", "metadata");

                entity.Property(e => e.CurrentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Current_Date");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasColumnName("Date Modified");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IsDelta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Is_Delta");

                entity.Property(e => e.SourceSystemName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Source_System_Name");

                entity.Property(e => e.TableFields)
                    .HasMaxLength(4000)
                    .HasColumnName("Table_Fields");

                entity.Property(e => e.TableName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Table_Name");

                entity.Property(e => e.TableSchema)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Table_Schema");

                entity.Property(e => e.WhereClause)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Where_Clause");

                entity.Property(e => e.WhereClauseFilter)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Where_Clause_Filter");

                entity.Property(e => e.WorkflowName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Workflow_Name");
            });

            modelBuilder.Entity<SourceTablesSampleTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SourceTables_SampleTables", "metadata");

                entity.Property(e => e.CurrentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Current_Date");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasColumnName("Date Modified");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IsDelta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Is_Delta");

                entity.Property(e => e.SourceSystemName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Source_System_Name");

                entity.Property(e => e.TableFields)
                    .HasMaxLength(4000)
                    .HasColumnName("Table_Fields");

                entity.Property(e => e.TableName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Table_Name");

                entity.Property(e => e.TableSchema)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Table_Schema");

                entity.Property(e => e.WhereClause)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Where_Clause");

                entity.Property(e => e.WhereClauseFilter)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Where_Clause_Filter");

                entity.Property(e => e.WorkflowName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Workflow_Name");
            });

            modelBuilder.Entity<StagingSourceTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StagingSourceTable", "metadata");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.DateAddedToT).HasColumnType("datetime");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasColumnName("Date Modified");

                entity.Property(e => e.InsertSql).HasColumnName("Insert SQL");

                entity.Property(e => e.IsActive).HasMaxLength(255);

                entity.Property(e => e.IsDelta)
                    .HasMaxLength(255)
                    .HasColumnName("Is_Delta");

                entity.Property(e => e.ProcessGroup)
                    .HasMaxLength(255)
                    .HasColumnName("Process Group");

                entity.Property(e => e.SourceSystemName)
                    .HasMaxLength(255)
                    .HasColumnName("Source_System_Name");

                entity.Property(e => e.Status).HasMaxLength(255);

                entity.Property(e => e.TableFields).HasColumnName("Table_Fields");

                entity.Property(e => e.TableName)
                    .HasMaxLength(255)
                    .HasColumnName("Table_Name");

                entity.Property(e => e.TableSchema)
                    .HasMaxLength(255)
                    .HasColumnName("Table_Schema");

                entity.Property(e => e.UpdateDateField)
                    .HasMaxLength(255)
                    .HasColumnName("Update_Date_Field");

                entity.Property(e => e.UpdateDateField2)
                    .HasMaxLength(255)
                    .HasColumnName("Update_Date_Field2");

                entity.Property(e => e.UpdateDateField3)
                    .HasMaxLength(255)
                    .HasColumnName("Update_Date_Field3");

                entity.Property(e => e.WhereClause)
                    .HasMaxLength(255)
                    .HasColumnName("Where_Clause");

                entity.Property(e => e.WorkflowName)
                    .HasMaxLength(255)
                    .HasColumnName("Workflow_Name");
            });

            modelBuilder.Entity<SynonCondition>(entity =>
            {
                entity.HasKey(e => new { e.FileDdsname, e.FieldDdsname, e.ConditionTest });

                entity.ToTable("Synon_Conditions", "staging");

                entity.Property(e => e.FileDdsname)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FileDDSName");

                entity.Property(e => e.FieldDdsname)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FieldDDSName");

                entity.Property(e => e.ConditionTest)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Test1FreightCommAdj>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test1_Freight_comm_Adj", "dbo");

                entity.Property(e => e.AccountManagerCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cdwcity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWCity");

                entity.Property(e => e.Cdwneighborhood)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhood");

                entity.Property(e => e.Cdwstate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWState");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerCodeCreated)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerCodeModified)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FreightAdjustmentStatusCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FreightAdjustmentStatusDescription)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GrossProfitAdjustmentDollarAmount).HasColumnType("money");

                entity.Property(e => e.GrossProfitAdjustmentDollarAmountOriginal).HasColumnType("money");

                entity.Property(e => e.InvoiceCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LineQuantity).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.OrderActionReason)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OrderCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PercentTotalWeightCost).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProgramCreated)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WeightTotal).HasColumnType("decimal(13, 4)");

                entity.Property(e => e.WeightUnit).HasColumnType("decimal(11, 4)");
            });

            modelBuilder.Entity<TestApiTot>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_API_TOT", "dbo");

                entity.Property(e => e.CurrentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Current_Date");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasColumnName("Date Modified");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IsDelta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Is_Delta");

                entity.Property(e => e.SourceSystemName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Source_System_Name");

                entity.Property(e => e.TableFields)
                    .HasMaxLength(4000)
                    .HasColumnName("Table_Fields");

                entity.Property(e => e.TableName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Table_Name");

                entity.Property(e => e.TableSchema)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Table_Schema");

                entity.Property(e => e.WhereClause)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Where_Clause");

                entity.Property(e => e.WhereClauseFilter)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Where_Clause_Filter");

                entity.Property(e => e.WorkflowName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Workflow_Name");
            });

            modelBuilder.Entity<TestCm21>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_CM21", "dbo");

                entity.Property(e => e.Bbordn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BBORDN");
            });

            modelBuilder.Entity<TestCm80>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_CM80", "dbo");

                entity.Property(e => e.Sha4nb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHA4NB");

                entity.Property(e => e.Sha5nb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHA5NB");

                entity.Property(e => e.Shaavn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHAAVN");

                entity.Property(e => e.Shabvn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHABVN");

                entity.Property(e => e.Shbctm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHBCTM");

                entity.Property(e => e.Shbnvn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHBNVN");

                entity.Property(e => e.Shbpvn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHBPVN");

                entity.Property(e => e.Shcard)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHCARD");

                entity.Property(e => e.Shcmpr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHCMPR");

                entity.Property(e => e.Shcmyr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHCMYR");

                entity.Property(e => e.Shcono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHCONO");

                entity.Property(e => e.Shcusn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHCUSN");

                entity.Property(e => e.Shdtcr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHDTCR");

                entity.Property(e => e.Shdtky)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHDTKY");

                entity.Property(e => e.Shf4dt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHF4DT");

                entity.Property(e => e.Shgbce)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHGBCE");

                entity.Property(e => e.Shgpam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHGPAM");

                entity.Property(e => e.Shinvl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHINVL");

                entity.Property(e => e.Shitma)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHITMA");

                entity.Property(e => e.Shl8cd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHL8CD");

                entity.Property(e => e.Shref)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHREF#");

                entity.Property(e => e.Shsaam)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHSAAM");

                entity.Property(e => e.Shseq)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHSEQ#");

                entity.Property(e => e.Shtmcr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHTMCR");

                entity.Property(e => e.Shvust)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHVUST");

                entity.Property(e => e.Shvvst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SHVVST");
            });

            modelBuilder.Entity<TestCm87>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_CM87", "dbo");

                entity.Property(e => e.Cna0tm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNA0TM");

                entity.Property(e => e.Cna2nb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNA2NB");

                entity.Property(e => e.Cnaavn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNAAVN");

                entity.Property(e => e.Cnabvn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNABVN");

                entity.Property(e => e.Cncgce)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNCGCE");

                entity.Property(e => e.Cncjce)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNCJCE");

                entity.Property(e => e.Cncmpr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNCMPR");

                entity.Property(e => e.Cncmyr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNCMYR");

                entity.Property(e => e.Cncono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNCONO");

                entity.Property(e => e.Cnd6dt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CND6DT");

                entity.Property(e => e.Cndtcr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNDTCR");

                entity.Property(e => e.Cndtky)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNDTKY");

                entity.Property(e => e.Cnhcvl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNHCVL");

                entity.Property(e => e.Cninvn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNINVN");

                entity.Property(e => e.Cnl8cd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNL8CD");

                entity.Property(e => e.Cnlhva)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNLHVA");

                entity.Property(e => e.Cnmhst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNMHST");

                entity.Property(e => e.Cnn3st)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNN3ST");

                entity.Property(e => e.Cnnt25)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNNT25");

                entity.Property(e => e.Cnordn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNORDN");

                entity.Property(e => e.Cnslmn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNSLMN");

                entity.Property(e => e.Cnsqad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNSQAD");

                entity.Property(e => e.Cntmcr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CNTMCR");
            });

            modelBuilder.Entity<TestCm87a>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_CM87A", "dbo");

                entity.Property(e => e.Cja0tm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CJA0TM");

                entity.Property(e => e.Cja2nb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CJA2NB");

                entity.Property(e => e.Cjaavn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CJAAVN");

                entity.Property(e => e.Cjabvn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CJABVN");

                entity.Property(e => e.Cjcmpr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CJCMPR");

                entity.Property(e => e.Cjcmyr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CJCMYR");

                entity.Property(e => e.Cjcono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CJCONO");

                entity.Property(e => e.Cjd6dt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CJD6DT");

                entity.Property(e => e.Cjdtcr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CJDTCR");

                entity.Property(e => e.Cjdtky)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CJDTKY");

                entity.Property(e => e.Cjinvn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CJINVN");

                entity.Property(e => e.Cjl8cd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CJL8CD");

                entity.Property(e => e.Cjpicd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CJPICD");

                entity.Property(e => e.Cjtmcr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CJTMCR");
            });

            modelBuilder.Entity<TestCm87d>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_CM87D", "dbo");

                entity.Property(e => e.Bia0tm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIA0TM");

                entity.Property(e => e.Bia2nb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIA2NB");

                entity.Property(e => e.Bibmvn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIBMVN");

                entity.Property(e => e.Bibnvn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIBNVN");

                entity.Property(e => e.Bibovn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIBOVN");

                entity.Property(e => e.Bibpvn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIBPVN");

                entity.Property(e => e.Bicmpr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BICMPR");

                entity.Property(e => e.Bicmyr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BICMYR");

                entity.Property(e => e.Bicono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BICONO");

                entity.Property(e => e.Bicrtm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BICRTM");

                entity.Property(e => e.Bid6dt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BID6DT");

                entity.Property(e => e.Bidtky)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIDTKY");

                entity.Property(e => e.Bigpnc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIGPNC");

                entity.Property(e => e.Bihcvl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIHCVL");

                entity.Property(e => e.Biinvl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIINVL");

                entity.Property(e => e.Biinvn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIINVN");

                entity.Property(e => e.Bil8cd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIL8CD");

                entity.Property(e => e.Bilhva)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BILHVA");

                entity.Property(e => e.Bilqty)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BILQTY");

                entity.Property(e => e.Bimhst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIMHST");

                entity.Property(e => e.Bipnum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIPNUM");

                entity.Property(e => e.Bipttw)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIPTTW");

                entity.Property(e => e.Biq5nb)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIQ5NB");

                entity.Property(e => e.Biwtsu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BIWTSU");
            });

            modelBuilder.Entity<TestCommCwc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_comm_cwc", "dbo");

                entity.Property(e => e.CdwcityCode).HasColumnName("CDWCityCode");

                entity.Property(e => e.CdwneighborhoodCode).HasColumnName("CDWNeighborhoodCode");

                entity.Property(e => e.CdwneighborhoodLocationCode).HasColumnName("CDWNeighborhoodLocationCode");

                entity.Property(e => e.CdwstateCode).HasColumnName("CDWStateCode");

                entity.Property(e => e.CoworkerGldepartmentCode).HasColumnName("CoworkerGLDepartmentCode");

                entity.Property(e => e.Descr).HasColumnName("DESCR");

                entity.Property(e => e.Descrshort).HasColumnName("DESCRSHORT");

                entity.Property(e => e.Emp05terminationDescription).HasColumnName("EMP05TerminationDescription");

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.Jobcode).HasColumnName("JOBCODE");

                entity.Property(e => e.LosgroupCode).HasColumnName("LOSGroupCode");

                entity.Property(e => e.LosgroupDescription).HasColumnName("LOSGroupDescription");

                entity.Property(e => e.Losmonth).HasColumnName("LOSMonth");

                entity.Property(e => e.LosstartDate)
                    .HasColumnType("date")
                    .HasColumnName("LOSStartDate");

                entity.Property(e => e.PsgldepartmentCode).HasColumnName("PSGLDepartmentCode");

                entity.Property(e => e.RfiduserId).HasColumnName("RFIDUserID");

                entity.Property(e => e.TerminationDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TestCommissionCoworkerTitleTrueComp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_Commission_CoworkerTitle_TrueComp", "dbo");

                entity.Property(e => e.C10).HasColumnName("_c10");

                entity.Property(e => e.C11).HasColumnName("_c11");

                entity.Property(e => e.C12).HasColumnName("_c12");

                entity.Property(e => e.C13).HasColumnName("_c13");

                entity.Property(e => e.C14).HasColumnName("_c14");

                entity.Property(e => e.C15).HasColumnName("_c15");

                entity.Property(e => e.C16).HasColumnName("_c16");

                entity.Property(e => e.C17).HasColumnName("_c17");

                entity.Property(e => e.C18).HasColumnName("_c18");

                entity.Property(e => e.C19).HasColumnName("_c19");

                entity.Property(e => e.C2).HasColumnName("_c2");

                entity.Property(e => e.C20).HasColumnName("_c20");

                entity.Property(e => e.C21).HasColumnName("_c21");

                entity.Property(e => e.C22).HasColumnName("_c22");

                entity.Property(e => e.C23).HasColumnName("_c23");

                entity.Property(e => e.C24).HasColumnName("_c24");

                entity.Property(e => e.C25).HasColumnName("_c25");

                entity.Property(e => e.C26).HasColumnName("_c26");

                entity.Property(e => e.C27).HasColumnName("_c27");

                entity.Property(e => e.C28).HasColumnName("_c28");

                entity.Property(e => e.C3).HasColumnName("_c3");

                entity.Property(e => e.C4).HasColumnName("_c4");

                entity.Property(e => e.C5).HasColumnName("_c5");

                entity.Property(e => e.C6).HasColumnName("_c6");

                entity.Property(e => e.C7).HasColumnName("_c7");

                entity.Property(e => e.C8).HasColumnName("_c8");

                entity.Property(e => e.C9).HasColumnName("_c9");
            });

            modelBuilder.Entity<TestCwcfinalfield>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_cwcfinalfields", "dbo");

                entity.Property(e => e.CdwcityCode).HasColumnName("CDWCityCode");

                entity.Property(e => e.CdwneighborhoodCode).HasColumnName("CDWNeighborhoodCode");

                entity.Property(e => e.CdwneighborhoodLocationCode).HasColumnName("CDWNeighborhoodLocationCode");

                entity.Property(e => e.CdwstateCode).HasColumnName("CDWStateCode");

                entity.Property(e => e.CoworkerGldepartmentCode).HasColumnName("CoworkerGLDepartmentCode");

                entity.Property(e => e.Emp05terminationDescription).HasColumnName("EMP05TerminationDescription");

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.LosgroupCode).HasColumnName("LOSGroupCode");

                entity.Property(e => e.LosgroupDescription).HasColumnName("LOSGroupDescription");

                entity.Property(e => e.Losmonth).HasColumnName("LOSMonth");

                entity.Property(e => e.LosstartDate)
                    .HasColumnType("date")
                    .HasColumnName("LOSStartDate");

                entity.Property(e => e.ManagerGldepartmentCode).HasColumnName("ManagerGLDepartmentCode");

                entity.Property(e => e.NetworkUserId).HasColumnName("NetworkUserID");

                entity.Property(e => e.OldHashId).HasColumnName("OldHashID");

                entity.Property(e => e.RfiduserId).HasColumnName("RFIDUserID");

                entity.Property(e => e.TerminationDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TestCwcnetwork1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_cwcnetwork1", "dbo");

                entity.Property(e => e.NetworkUserId).HasColumnName("NetworkUserID");
            });

            modelBuilder.Entity<TestCwctitle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_cwctitle", "dbo");
            });

            modelBuilder.Entity<TestDimensionActiveDirectory>(entity =>
            {
                entity.HasKey(e => new { e.ActiveDirectoryGroupDescription, e.ActiveDirectoryUserDescription, e.DistributionTypeDescription, e.CoworkerNetworkId });

                entity.ToTable("Test_Dimension_ActiveDirectory", "dbo");

                entity.Property(e => e.ActiveDirectoryGroupDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ActiveDirectoryUserDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DistributionTypeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerNetworkId)
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("CoworkerNetworkID");

                entity.Property(e => e.Coworkercode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");
            });

            modelBuilder.Entity<TestDimensionCompany>(entity =>
            {
                entity.HasKey(e => e.PkDimensionCompany)
                    .HasName("PK__Test_Dim__1D657A40E902EAAC");

                entity.ToTable("Test_Dimension_Company", "dbo");

                entity.Property(e => e.PkDimensionCompany)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("PK_Dimension_Company");

                entity.Property(e => e.CompanyDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyGroupCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyShortDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyTypeDescription)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CountryDescription)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultCurrencyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.LogisticsCompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestDimensionCoworker>(entity =>
            {
                entity.HasKey(e => e.CoworkerCode);

                entity.ToTable("Test_Dimension_Coworker", "dbo");

                entity.Property(e => e.CoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AcademyAmflag).HasColumnName("AcademyAMFlag");

                entity.Property(e => e.AcademyAmflagDescription)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("AcademyAMFlagDescription");

                entity.Property(e => e.AcademyAmneighborhoodCode).HasColumnName("AcademyAMNeighborhoodCode");

                entity.Property(e => e.AcademyAmneighborhoodDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AcademyAMNeighborhoodDescription");

                entity.Property(e => e.AcademyAmstateCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("AcademyAMStateCode");

                entity.Property(e => e.AcademyAmstateDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AcademyAMStateDescription");

                entity.Property(e => e.AccountManagerCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ArspecialistFlag).HasColumnName("ARSpecialistFlag");

                entity.Property(e => e.CdwcityCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CDWCityCode");

                entity.Property(e => e.CdwcityDescription)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("CDWCityDescription");

                entity.Property(e => e.CdwneighborhoodCode).HasColumnName("CDWNeighborhoodCode");

                entity.Property(e => e.CdwneighborhoodDescription)
                    .HasMaxLength(83)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhoodDescription");

                entity.Property(e => e.CdwneighborhoodLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhoodLocationCode");

                entity.Property(e => e.CdwneighborhoodLocationDescription)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhoodLocationDescription");

                entity.Property(e => e.CdwneighborhoodLocationReportingDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhoodLocationReportingDescription");

                entity.Property(e => e.CdwstateCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("CDWStateCode");

                entity.Property(e => e.CdwstateDescription)
                    .HasMaxLength(58)
                    .IsUnicode(false)
                    .HasColumnName("CDWStateDescription");

                entity.Property(e => e.CommissionCoworkerTitleDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CommissionCoworkerTitleGroupDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ContractorVendorDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerDepartmentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerName)
                    .HasMaxLength(74)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerTitleCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerTitleDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerTitleGroupDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentPositionLos).HasColumnName("CurrentPositionLOS");

                entity.Property(e => e.DirectPhone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentLevelCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EmploymentLevelDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FieldOfficeSetFlagDescription)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.FieldOfficeSetcode).HasColumnName("FieldOfficeSETCode");

                entity.Property(e => e.FieldOfficeSetdescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FieldOfficeSETDescription");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.HouseAccount)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HouseAccountDescription)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.InternalExtension)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LosgroupCode).HasColumnName("LOSGroupCode");

                entity.Property(e => e.LosgroupDescription)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("LOSGroupDescription");

                entity.Property(e => e.Losmonth).HasColumnName("LOSMonth");

                entity.Property(e => e.LosstartDate)
                    .HasColumnType("date")
                    .HasColumnName("LOSStartDate");

                entity.Property(e => e.ManagerCoworkerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerCoworkerName)
                    .HasMaxLength(74)
                    .IsUnicode(false);

                entity.Property(e => e.ManagerDepartmentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NetworkUserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NetworkUserID");

                entity.Property(e => e.NickName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RfiduserId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RFIDUserID");

                entity.Property(e => e.SpecialistGroupTypeCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialistGroupTypeDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerminationDate).HasColumnType("date");

                entity.Property(e => e.TerminationDescription)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TollFreePhone)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.ValidFmTs).HasColumnName("ValidFmTS");

                entity.Property(e => e.ValidToTs).HasColumnName("ValidToTS");
            });

            modelBuilder.Entity<TestDimensionCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerCode)
                    .HasName("PK__Test_Dim__0667852029D9B96A");

                entity.ToTable("Test_Dimension_Customer", "dbo");

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccountCreatedByCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CashFlowProblemDescription)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreditHoldDescription)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CreditLimit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerAccountStatusCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerAgencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCodeInt).HasColumnName("CustomerCodeINT");

                entity.Property(e => e.CustomerCodingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCompetitorCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerDescription)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerLeasingCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerResellerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSourceGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSubAgencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSubTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.Mailable)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestDimensionOrderAction>(entity =>
            {
                entity.HasKey(e => e.OrderActionCode)
                    .HasName("PK__Test_Dim__D30510141CA2AB61");

                entity.ToTable("Test_Dimension_OrderAction", "dbo");

                entity.Property(e => e.OrderActionCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.OrderActionDescription)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OrderActionReasonCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestEmp05Cwc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_emp05CWC", "dbo");

                entity.Property(e => e.Countthrowaway).HasColumnName("countthrowaway");

                entity.Property(e => e.UnionCoworkerCode).HasColumnName("unionCoworkerCode");
            });

            modelBuilder.Entity<TestEmp05andPeoplesoft>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_EMP05andPeoplesoft", "dbo");

                entity.Property(e => e.CdwVendorName).HasColumnName("CDW_VENDOR_NAME");

                entity.Property(e => e.CdwneighborhoodLocationCode).HasColumnName("CDWNeighborhoodLocationCode");

                entity.Property(e => e.Emp05terminationDescription).HasColumnName("EMP05TerminationDescription");

                entity.Property(e => e.Emplid).HasColumnName("EMPLID");

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.LosgroupCode).HasColumnName("LOSGroupCode");

                entity.Property(e => e.LosgroupDescription).HasColumnName("LOSGroupDescription");

                entity.Property(e => e.Losmonth).HasColumnName("LOSMonth");

                entity.Property(e => e.LosstartDate)
                    .HasColumnType("date")
                    .HasColumnName("LOSStartDate");

                entity.Property(e => e.PerOrg).HasColumnName("PER_ORG");

                entity.Property(e => e.PsgldepartmentCode).HasColumnName("PSGLDepartmentCode");

                entity.Property(e => e.ReportsTo).HasColumnName("REPORTS_TO");

                entity.Property(e => e.SupervisorId).HasColumnName("SUPERVISOR_ID");

                entity.Property(e => e.SupervisorName).HasColumnName("SUPERVISOR_NAME");

                entity.Property(e => e.TerminationDate).HasColumnType("date");

                entity.Property(e => e.Tya4nb).HasColumnName("TYA4NB");

                entity.Property(e => e.Tyaavn).HasColumnName("TYAAVN");

                entity.Property(e => e.Tyabvn).HasColumnName("TYABVN");

                entity.Property(e => e.Tyatnb).HasColumnName("TYATNB");

                entity.Property(e => e.Tybdvn).HasColumnName("TYBDVN");

                entity.Property(e => e.Tybjvn).HasColumnName("TYBJVN");

                entity.Property(e => e.Tybkvn).HasColumnName("TYBKVN");

                entity.Property(e => e.Tyc1tt).HasColumnName("TYC1TT");

                entity.Property(e => e.Tyc2tt).HasColumnName("TYC2TT");

                entity.Property(e => e.Tyc3tt).HasColumnName("TYC3TT");

                entity.Property(e => e.Tyc4tt).HasColumnName("TYC4TT");

                entity.Property(e => e.Tyc5tt).HasColumnName("TYC5TT");

                entity.Property(e => e.Tyc6tt).HasColumnName("TYC6TT");

                entity.Property(e => e.Tyc7tt).HasColumnName("TYC7TT");

                entity.Property(e => e.Tycono).HasColumnName("TYCONO");

                entity.Property(e => e.Tydbtt).HasColumnName("TYDBTT");

                entity.Property(e => e.Tydstg).HasColumnName("TYDSTG");

                entity.Property(e => e.Tydtcr).HasColumnName("TYDTCR");

                entity.Property(e => e.Tyejst).HasColumnName("TYEJST");

                entity.Property(e => e.Tyemad).HasColumnName("TYEMAD");

                entity.Property(e => e.Tyfadt).HasColumnName("TYFADT");

                entity.Property(e => e.Tyfqss).HasColumnName("TYFQSS");

                entity.Property(e => e.Tyfsss).HasColumnName("TYFSSS");

                entity.Property(e => e.Tyftss).HasColumnName("TYFTSS");

                entity.Property(e => e.Tyi9tx).HasColumnName("TYI9TX");

                entity.Property(e => e.Tyjatx).HasColumnName("TYJATX");

                entity.Property(e => e.Tykfva).HasColumnName("TYKFVA");

                entity.Property(e => e.Tyl8cd).HasColumnName("TYL8CD");

                entity.Property(e => e.Tyl8ss).HasColumnName("TYL8SS");

                entity.Property(e => e.Tyl9ss).HasColumnName("TYL9SS");

                entity.Property(e => e.Tymass).HasColumnName("TYMASS");

                entity.Property(e => e.Tymbss).HasColumnName("TYMBSS");

                entity.Property(e => e.Tymdin).HasColumnName("TYMDIN");

                entity.Property(e => e.Tyn6xt).HasColumnName("TYN6XT");

                entity.Property(e => e.Tyn7xt).HasColumnName("TYN7XT");

                entity.Property(e => e.Tys7st).HasColumnName("TYS7ST");

                entity.Property(e => e.Tys8st).HasColumnName("TYS8ST");

                entity.Property(e => e.Tys9st).HasColumnName("TYS9ST");

                entity.Property(e => e.Tysrep).HasColumnName("TYSREP");

                entity.Property(e => e.Tytast).HasColumnName("TYTAST");

                entity.Property(e => e.Tytbst).HasColumnName("TYTBST");

                entity.Property(e => e.Tytcst).HasColumnName("TYTCST");

                entity.Property(e => e.Tytdst).HasColumnName("TYTDST");

                entity.Property(e => e.Tytfst).HasColumnName("TYTFST");

                entity.Property(e => e.Tytist).HasColumnName("TYTIST");

                entity.Property(e => e.Tytjst).HasColumnName("TYTJST");

                entity.Property(e => e.Tytkst).HasColumnName("TYTKST");

                entity.Property(e => e.Tytlst).HasColumnName("TYTLST");

                entity.Property(e => e.Tytmst).HasColumnName("TYTMST");

                entity.Property(e => e.Tytnst).HasColumnName("TYTNST");

                entity.Property(e => e.Tytost).HasColumnName("TYTOST");

                entity.Property(e => e.Tytpst).HasColumnName("TYTPST");

                entity.Property(e => e.Tytrmd).HasColumnName("TYTRMD");

                entity.Property(e => e.Tyurid).HasColumnName("TYURID");

                entity.Property(e => e.Tyxjtx).HasColumnName("TYXJTX");

                entity.Property(e => e.Tyyptt).HasColumnName("TYYPTT");
            });

            modelBuilder.Entity<TestEmp05cow>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_emp05cow", "dbo");

                entity.Property(e => e.Emp05terminationDescription).HasColumnName("EMP05TerminationDescription");

                entity.Property(e => e.Tya4nb).HasColumnName("TYA4NB");

                entity.Property(e => e.Tyaavn).HasColumnName("TYAAVN");

                entity.Property(e => e.Tyabvn).HasColumnName("TYABVN");

                entity.Property(e => e.Tyatnb).HasColumnName("TYATNB");

                entity.Property(e => e.Tybdvn).HasColumnName("TYBDVN");

                entity.Property(e => e.Tybjvn).HasColumnName("TYBJVN");

                entity.Property(e => e.Tybkvn).HasColumnName("TYBKVN");

                entity.Property(e => e.Tyc1tt).HasColumnName("TYC1TT");

                entity.Property(e => e.Tyc2tt).HasColumnName("TYC2TT");

                entity.Property(e => e.Tyc3tt).HasColumnName("TYC3TT");

                entity.Property(e => e.Tyc4tt).HasColumnName("TYC4TT");

                entity.Property(e => e.Tyc5tt).HasColumnName("TYC5TT");

                entity.Property(e => e.Tyc6tt).HasColumnName("TYC6TT");

                entity.Property(e => e.Tyc7tt).HasColumnName("TYC7TT");

                entity.Property(e => e.Tycono).HasColumnName("TYCONO");

                entity.Property(e => e.Tydbtt).HasColumnName("TYDBTT");

                entity.Property(e => e.Tydstg).HasColumnName("TYDSTG");

                entity.Property(e => e.Tydtcr).HasColumnName("TYDTCR");

                entity.Property(e => e.Tyejst).HasColumnName("TYEJST");

                entity.Property(e => e.Tyemad).HasColumnName("TYEMAD");

                entity.Property(e => e.Tyfadt).HasColumnName("TYFADT");

                entity.Property(e => e.Tyfqss).HasColumnName("TYFQSS");

                entity.Property(e => e.Tyfsss).HasColumnName("TYFSSS");

                entity.Property(e => e.Tyftss).HasColumnName("TYFTSS");

                entity.Property(e => e.Tyi9tx).HasColumnName("TYI9TX");

                entity.Property(e => e.Tyjatx).HasColumnName("TYJATX");

                entity.Property(e => e.Tykfva).HasColumnName("TYKFVA");

                entity.Property(e => e.Tyl8cd).HasColumnName("TYL8CD");

                entity.Property(e => e.Tyl8ss).HasColumnName("TYL8SS");

                entity.Property(e => e.Tyl9ss).HasColumnName("TYL9SS");

                entity.Property(e => e.Tymass).HasColumnName("TYMASS");

                entity.Property(e => e.Tymbss).HasColumnName("TYMBSS");

                entity.Property(e => e.Tymdin).HasColumnName("TYMDIN");

                entity.Property(e => e.Tyn6xt).HasColumnName("TYN6XT");

                entity.Property(e => e.Tyn7xt).HasColumnName("TYN7XT");

                entity.Property(e => e.Tys7st).HasColumnName("TYS7ST");

                entity.Property(e => e.Tys8st).HasColumnName("TYS8ST");

                entity.Property(e => e.Tys9st).HasColumnName("TYS9ST");

                entity.Property(e => e.Tysrep).HasColumnName("TYSREP");

                entity.Property(e => e.Tytast).HasColumnName("TYTAST");

                entity.Property(e => e.Tytbst).HasColumnName("TYTBST");

                entity.Property(e => e.Tytcst).HasColumnName("TYTCST");

                entity.Property(e => e.Tytdst).HasColumnName("TYTDST");

                entity.Property(e => e.Tytfst).HasColumnName("TYTFST");

                entity.Property(e => e.Tytist).HasColumnName("TYTIST");

                entity.Property(e => e.Tytjst).HasColumnName("TYTJST");

                entity.Property(e => e.Tytkst).HasColumnName("TYTKST");

                entity.Property(e => e.Tytlst).HasColumnName("TYTLST");

                entity.Property(e => e.Tytmst).HasColumnName("TYTMST");

                entity.Property(e => e.Tytnst).HasColumnName("TYTNST");

                entity.Property(e => e.Tytost).HasColumnName("TYTOST");

                entity.Property(e => e.Tytpst).HasColumnName("TYTPST");

                entity.Property(e => e.Tytrmd).HasColumnName("TYTRMD");

                entity.Property(e => e.Tyurid).HasColumnName("TYURID");

                entity.Property(e => e.Tyxjtx).HasColumnName("TYXJTX");

                entity.Property(e => e.Tyyptt).HasColumnName("TYYPTT");
            });

            modelBuilder.Entity<TestEmp10andP>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_Emp10andPS", "dbo");

                entity.Property(e => e.CdwneighborhoodLocationCode).HasColumnName("CDWNeighborhoodLocationCode");

                entity.Property(e => e.Emp05terminationDescription).HasColumnName("EMP05TerminationDescription");

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.LosgroupCode).HasColumnName("LOSGroupCode");

                entity.Property(e => e.LosgroupDescription).HasColumnName("LOSGroupDescription");

                entity.Property(e => e.Losmonth).HasColumnName("LOSMonth");

                entity.Property(e => e.LosstartDate)
                    .HasColumnType("date")
                    .HasColumnName("LOSStartDate");

                entity.Property(e => e.ManagerGldepartmentCode).HasColumnName("ManagerGLDepartmentCode");

                entity.Property(e => e.PsgldepartmentCode).HasColumnName("PSGLDepartmentCode");

                entity.Property(e => e.RfiduserId).HasColumnName("RFIDUserID");

                entity.Property(e => e.TerminationDate).HasColumnType("date");

                entity.Property(e => e.Tzcgce).HasColumnName("TZCGCE");

                entity.Property(e => e.Tzcjce).HasColumnName("TZCJCE");

                entity.Property(e => e.Tzclce).HasColumnName("TZCLCE");

                entity.Property(e => e.Tzcono).HasColumnName("TZCONO");

                entity.Property(e => e.Tzl6cd).HasColumnName("TZL6CD");

                entity.Property(e => e.Tzl8cd).HasColumnName("TZL8CD");

                entity.Property(e => e.Tzsqad).HasColumnName("TZSQAD");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TestEmp15>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_EMP15", "dbo");

                entity.Property(e => e.Tcccna)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TCCCNA");

                entity.Property(e => e.Tccgce)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TCCGCE");

                entity.Property(e => e.Tccono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TCCONO");

                entity.Property(e => e.Tcs6st)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TCS6ST");
            });

            modelBuilder.Entity<TestEmp25>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_Emp25", "dbo");

                entity.Property(e => e.T0cgce)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("T0CGCE");

                entity.Property(e => e.T0cjce)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("T0CJCE");

                entity.Property(e => e.T0cjna)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("T0CJNA");

                entity.Property(e => e.T0cono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("T0CONO");

                entity.Property(e => e.T0s6st)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("T0S6ST");
            });

            modelBuilder.Entity<TestEmp40>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_Emp40", "dbo");

                entity.Property(e => e.Cdcgce)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CDCGCE");

                entity.Property(e => e.Cdcjce)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CDCJCE");

                entity.Property(e => e.Cdcono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CDCONO");

                entity.Property(e => e.Cddqna)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CDDQNA");

                entity.Property(e => e.Cdpvcr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CDPVCR");

                entity.Property(e => e.Cdsqad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CDSQAD");
            });

            modelBuilder.Entity<TestFactCommissionAdjustmentFreight>(entity =>
            {
                entity.HasKey(e => new { e.CompanyCode, e.CoworkerCode, e.CommissionMonth, e.DateAdjustment, e.InvoiceCode, e.InvoiceLineNumber, e.FreightAdjustmentNumber })
                    .HasName("PK__Test_Fac__B33C3E213010B646");

                entity.ToTable("Test_Fact_Commission_Adjustment_Freight", "dbo");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccountManagerCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cdwcity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWCity");

                entity.Property(e => e.Cdwneighborhood)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhood");

                entity.Property(e => e.Cdwstate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWState");

                entity.Property(e => e.CoworkerCodeCreated)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerCodeModified)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FreightAdjustmentStatusCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FreightAdjustmentStatusDescription)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GrossProfitAdjustmentDollarAmount).HasColumnType("money");

                entity.Property(e => e.GrossProfitAdjustmentDollarAmountOriginal).HasColumnType("money");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LineQuantity).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.OrderActionReason)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OrderCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PercentTotalWeightCost).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProgramCreated)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WeightTotal).HasColumnType("decimal(13, 4)");

                entity.Property(e => e.WeightUnit).HasColumnType("decimal(11, 4)");
            });

            modelBuilder.Entity<TestFactCommissionAdjustmentFreight230821>(entity =>
            {
                entity.HasKey(e => new { e.CompanyCode, e.CoworkerCode, e.CommissionMonth, e.DateAdjustment, e.InvoiceCode, e.InvoiceLineNumber, e.FreightAdjustmentNumber })
                    .HasName("PK__Test_Fac__B33C3E2120376FC5");

                entity.ToTable("Test_Fact_Commission_Adjustment_Freight_230821", "dbo");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccountManagerCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cdwcity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWCity");

                entity.Property(e => e.Cdwneighborhood)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhood");

                entity.Property(e => e.Cdwstate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWState");

                entity.Property(e => e.CoworkerCodeCreated)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerCodeModified)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.FreightAdjustmentStatusCode)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FreightAdjustmentStatusDescription)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GrossProfitAdjustmentDollarAmount).HasColumnType("money");

                entity.Property(e => e.GrossProfitAdjustmentDollarAmountOriginal).HasColumnType("money");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LineQuantity).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.OrderActionReason)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OrderCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PercentTotalWeightCost).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProgramCreated)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WeightTotal).HasColumnType("decimal(13, 4)");

                entity.Property(e => e.WeightUnit).HasColumnType("decimal(11, 4)");
            });

            modelBuilder.Entity<TestFactCommissionAdjustmentFreight250821>(entity =>
            {
                entity.HasKey(e => new { e.CompanyCode, e.CoworkerCode, e.CommissionMonth, e.DateAdjustment, e.InvoiceCode, e.InvoiceLineNumber, e.FreightAdjustmentNumber })
                    .HasName("PK__Test_Fac__B33C3E2189112F7B");

                entity.ToTable("Test_Fact_Commission_Adjustment_Freight_250821", "dbo");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccountManagerCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cdwcity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWCity");

                entity.Property(e => e.Cdwneighborhood)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhood");

                entity.Property(e => e.Cdwstate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWState");

                entity.Property(e => e.CoworkerCodeCreated)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerCodeModified)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.FreightAdjustmentStatusCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FreightAdjustmentStatusDescription)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GrossProfitAdjustmentDollarAmount).HasColumnType("money");

                entity.Property(e => e.GrossProfitAdjustmentDollarAmountOriginal).HasColumnType("money");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LineQuantity).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.OrderActionReason)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OrderCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PercentTotalWeightCost).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProgramCreated)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WeightTotal).HasColumnType("decimal(13, 4)");

                entity.Property(e => e.WeightUnit).HasColumnType("decimal(11, 4)");
            });

            modelBuilder.Entity<TestFactCommissionAdjustmentFreight270821>(entity =>
            {
                entity.HasKey(e => new { e.CompanyCode, e.CoworkerCode, e.CommissionMonth, e.DateAdjustment, e.InvoiceCode, e.InvoiceLineNumber, e.FreightAdjustmentNumber })
                    .HasName("PK__Test_Fac__B33C3E2142D35A50");

                entity.ToTable("Test_Fact_Commission_Adjustment_Freight_270821", "dbo");

                entity.HasIndex(e => new { e.CompanyCode, e.CoworkerCode, e.CommissionMonth, e.DateAdjustment, e.InvoiceCode, e.InvoiceLineNumber, e.FreightAdjustmentNumber }, "NC_Test");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccountManagerCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cdwcity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWCity");

                entity.Property(e => e.Cdwneighborhood)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhood");

                entity.Property(e => e.Cdwstate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWState");

                entity.Property(e => e.CoworkerCodeCreated)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerCodeModified)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.FreightAdjustmentStatusCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FreightAdjustmentStatusDescription)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GrossProfitAdjustmentDollarAmount).HasColumnType("money");

                entity.Property(e => e.GrossProfitAdjustmentDollarAmountOriginal).HasColumnType("money");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LineQuantity).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.OrderActionReason)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OrderCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PercentTotalWeightCost).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProgramCreated)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WeightTotal).HasColumnType("decimal(13, 4)");

                entity.Property(e => e.WeightUnit).HasColumnType("decimal(11, 4)");
            });

            modelBuilder.Entity<TestFactCommissionAdjustmentFreight300821>(entity =>
            {
                entity.HasKey(e => new { e.CompanyCode, e.CoworkerCode, e.CommissionMonth, e.DateAdjustment, e.InvoiceCode, e.InvoiceLineNumber, e.FreightAdjustmentNumber })
                    .HasName("PK__Test_Fac__B33C3E21E0785672");

                entity.ToTable("Test_Fact_Commission_Adjustment_Freight_300821", "dbo");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AccountManagerCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Cdwcity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWCity");

                entity.Property(e => e.Cdwneighborhood)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWNeighborhood");

                entity.Property(e => e.Cdwstate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CDWState");

                entity.Property(e => e.CoworkerCodeCreated)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CoworkerCodeModified)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.FreightAdjustmentStatusCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FreightAdjustmentStatusDescription)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GrossProfitAdjustmentDollarAmount).HasColumnType("money");

                entity.Property(e => e.GrossProfitAdjustmentDollarAmountOriginal).HasColumnType("money");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LineQuantity).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.OrderActionReason)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OrderCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PercentTotalWeightCost).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ProgramCreated)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WeightTotal).HasColumnType("decimal(13, 4)");

                entity.Property(e => e.WeightUnit).HasColumnType("decimal(11, 4)");
            });

            modelBuilder.Entity<TestFactOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_fact_order", "dbo");

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContractCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConvertedFromQuoteOrderCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByCoworkerCode)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerAddressCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPurchaseOrder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EaccountUserKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LogisticSuspendCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingSourceCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByCoworkerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ModifiedByUserID");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OfferCouponCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDollarAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.OrderLineStatusCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSecondaryCoworkerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSeq).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderSourceCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatusCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderingCoworkerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalContactCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalCustomerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PriceListCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductSoftwareCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductSoftwareOriginalCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuantityAllocated).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QuantityInvoiced).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QuantityOrdered).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QuantityOutStanding).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.ShipMethodCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SladueDateSeq).HasColumnName("SLADueDateSeq");

                entity.Property(e => e.SlatypeDescription)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SLATypeDescription");

                entity.Property(e => e.SuspendCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TotalOrderDollarAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TransactionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WebTransactionOriginCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestFactQuote>(entity =>
            {
                entity.HasKey(e => new { e.QuoteCode, e.QuoteLineNumber, e.QuoteDateInt, e.CompanyCode });

                entity.ToTable("Test_Fact_Quote", "dbo");

                entity.Property(e => e.QuoteCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCountryCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BillToStateCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContractCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByCoworkerCode)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerAddressCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPurchaseOrder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EaccountUserCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.IngramSpecialistCallCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IngramSpecialistSalesImpactCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LogisticSuspendCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MarketingSourceCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MobileDeviceActivationRequestCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByCoworkerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedByUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ModifiedByUserID");

                entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

                entity.Property(e => e.OfferCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OfferCouponCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSecondaryCoworkerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderingCoworkerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalContactCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalCustomerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PriceListCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductSoftwareCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuantityAllocated).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QuantityInvoiced).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QuantityOutStanding).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QuantityQuoted).HasColumnType("decimal(11, 3)");

                entity.Property(e => e.QuoteDollarAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.QuoteOrderLineStatusCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteOrderSourceCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteOrderStatusCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShipMethodCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SladueDateInt)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SLADueDateInt");

                entity.Property(e => e.SlatypeDescription)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SLATypeDescription");

                entity.Property(e => e.SuspendCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TotalQuoteDollarAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TransactionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WebTransactionOriginCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestJobCodeAdl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_JobCodeADLS", "dbo");

                entity.Property(e => e.CdwcityCode).HasColumnName("CDWCityCode");

                entity.Property(e => e.CdwneighborhoodCode).HasColumnName("CDWNeighborhoodCode");

                entity.Property(e => e.CdwneighborhoodLocationCode).HasColumnName("CDWNeighborhoodLocationCode");

                entity.Property(e => e.CdwstateCode).HasColumnName("CDWStateCode");

                entity.Property(e => e.CoworkerGldepartmentCode).HasColumnName("CoworkerGLDepartmentCode");

                entity.Property(e => e.Descr).HasColumnName("DESCR");

                entity.Property(e => e.Descrshort).HasColumnName("DESCRSHORT");

                entity.Property(e => e.Emp05terminationDescription).HasColumnName("EMP05TerminationDescription");

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.Jobcode).HasColumnName("JOBCODE");

                entity.Property(e => e.LosgroupCode).HasColumnName("LOSGroupCode");

                entity.Property(e => e.LosgroupDescription).HasColumnName("LOSGroupDescription");

                entity.Property(e => e.Losmonth).HasColumnName("LOSMonth");

                entity.Property(e => e.LosstartDate)
                    .HasColumnType("date")
                    .HasColumnName("LOSStartDate");

                entity.Property(e => e.ManagerGldepartmentCode).HasColumnName("ManagerGLDepartmentCode");

                entity.Property(e => e.PsgldepartmentCode).HasColumnName("PSGLDepartmentCode");

                entity.Property(e => e.RfiduserId).HasColumnName("RFIDUserID");

                entity.Property(e => e.TerminationDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TestJobcodetbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEST_jobcodetbl", "dbo");

                entity.Property(e => e.CdwcityCode).HasColumnName("CDWCityCode");

                entity.Property(e => e.CdwneighborhoodCode).HasColumnName("CDWNeighborhoodCode");

                entity.Property(e => e.CdwneighborhoodLocationCode).HasColumnName("CDWNeighborhoodLocationCode");

                entity.Property(e => e.CdwstateCode).HasColumnName("CDWStateCode");

                entity.Property(e => e.CoworkerGldepartmentCode).HasColumnName("CoworkerGLDepartmentCode");

                entity.Property(e => e.Descr).HasColumnName("DESCR");

                entity.Property(e => e.Descrshort).HasColumnName("DESCRSHORT");

                entity.Property(e => e.Emp05terminationDescription).HasColumnName("EMP05TerminationDescription");

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.Jobcode).HasColumnName("JOBCODE");

                entity.Property(e => e.LosgroupCode).HasColumnName("LOSGroupCode");

                entity.Property(e => e.LosgroupDescription).HasColumnName("LOSGroupDescription");

                entity.Property(e => e.Losmonth).HasColumnName("LOSMonth");

                entity.Property(e => e.LosstartDate)
                    .HasColumnType("date")
                    .HasColumnName("LOSStartDate");

                entity.Property(e => e.ManagerGldepartmentCode).HasColumnName("ManagerGLDepartmentCode");

                entity.Property(e => e.PsgldepartmentCode).HasColumnName("PSGLDepartmentCode");

                entity.Property(e => e.RfiduserId).HasColumnName("RFIDUserID");

                entity.Property(e => e.TerminationDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TestNetwork123>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_network123", "dbo");

                entity.Property(e => e.NetworkUserId).HasColumnName("NetworkUserID");
            });

            modelBuilder.Entity<TestNetworkAgg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_NetworkAGG", "dbo");

                entity.Property(e => e.NetworkUserId).HasColumnName("NetworkUserID");
            });

            modelBuilder.Entity<TestNetworkCwc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_network_cwc", "dbo");

                entity.Property(e => e.CdwcityCode).HasColumnName("CDWCityCode");

                entity.Property(e => e.CdwneighborhoodCode).HasColumnName("CDWNeighborhoodCode");

                entity.Property(e => e.CdwneighborhoodLocationCode).HasColumnName("CDWNeighborhoodLocationCode");

                entity.Property(e => e.CdwstateCode).HasColumnName("CDWStateCode");

                entity.Property(e => e.CoworkerGldepartmentCode).HasColumnName("CoworkerGLDepartmentCode");

                entity.Property(e => e.Descr).HasColumnName("DESCR");

                entity.Property(e => e.Descrshort).HasColumnName("DESCRSHORT");

                entity.Property(e => e.Emp05terminationDescription).HasColumnName("EMP05TerminationDescription");

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.Jobcode).HasColumnName("JOBCODE");

                entity.Property(e => e.LosgroupCode).HasColumnName("LOSGroupCode");

                entity.Property(e => e.LosgroupDescription).HasColumnName("LOSGroupDescription");

                entity.Property(e => e.Losmonth).HasColumnName("LOSMonth");

                entity.Property(e => e.LosstartDate)
                    .HasColumnType("date")
                    .HasColumnName("LOSStartDate");

                entity.Property(e => e.ManagerGldepartmentCode).HasColumnName("ManagerGLDepartmentCode");

                entity.Property(e => e.NetworkUserId).HasColumnName("NetworkUserID");

                entity.Property(e => e.PsgldepartmentCode).HasColumnName("PSGLDepartmentCode");

                entity.Property(e => e.RfiduserId).HasColumnName("RFIDUserID");

                entity.Property(e => e.TerminationDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TestOep47u>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_OEP47U", "dbo");

                entity.Property(e => e.Dja0tm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DJA0TM");

                entity.Property(e => e.Djabvn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DJABVN");

                entity.Property(e => e.Djadsc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DJADSC");

                entity.Property(e => e.Djartp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DJARTP");

                entity.Property(e => e.Djcono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DJCONO");

                entity.Property(e => e.Djd6dt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DJD6DT");

                entity.Property(e => e.Djpicd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DJPICD");
            });

            modelBuilder.Entity<TestOrderquoteDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_orderquote_Data", "dbo");

                entity.Property(e => e.CompetitorCode)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DealRegistrationStatus)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedCloseDate)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedShipDate)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IsTaskInternational)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.OrderCode)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalInvoiceCode)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalOrderCode)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerTypeId)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("OwnerTypeID");

                entity.Property(e => e.ProbabilityToClosePercent)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteStageCode)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.QuoteStatusCode)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ScrubState)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SolutionSubTypeId)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SolutionSubTypeID");

                entity.Property(e => e.SolutionTypeId)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SolutionTypeID");

                entity.Property(e => e.UpdateDate)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestPlcomplan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_plcomplan", "dbo");

                entity.Property(e => e.AccrualAccount).HasColumnName("accrualAccount");

                entity.Property(e => e.ApplyGoalQualifier).HasColumnName("applyGoalQualifier");

                entity.Property(e => e.CompPlan).HasColumnName("compPlan");

                entity.Property(e => e.CompStatementUsed).HasColumnName("compStatementUsed");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.DrawSubtractedFromPay).HasColumnName("drawSubtractedFromPay");

                entity.Property(e => e.EarnType).HasColumnName("earnType");

                entity.Property(e => e.EffEnd).HasColumnName("EffEnd_");

                entity.Property(e => e.EffStart).HasColumnName("EffStart_");

                entity.Property(e => e.FieldCoverageQualified).HasColumnName("fieldCoverageQualified");

                entity.Property(e => e.FieldSeller).HasColumnName("fieldSeller");

                entity.Property(e => e.FincomUsed).HasColumnName("fincomUsed");

                entity.Property(e => e.ManageNegativePaymentBal).HasColumnName("manageNegativePaymentBal");

                entity.Property(e => e.MonthsInPositionCalc).HasColumnName("monthsInPositionCalc");

                entity.Property(e => e.MonthsToPayAfterTerm).HasColumnName("monthsToPayAfterTerm");

                entity.Property(e => e.RptCreditTypeMapping).HasColumnName("rptCreditTypeMapping");

                entity.Property(e => e.SrvAllocationDesc).HasColumnName("srvAllocationDesc");

                entity.Property(e => e.SuppressAdjEmails).HasColumnName("suppressAdjEmails");

                entity.Property(e => e.SuppressHmstxns).HasColumnName("suppressHMSTxns");

                entity.Property(e => e.SuppressSubscrTxns).HasColumnName("suppressSubscrTxns");

                entity.Property(e => e.WfallowSplit).HasColumnName("WFAllowSplit");
            });

            modelBuilder.Entity<TestPsJobcodeTbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_ps_jobcode_tbl", "dbo");

                entity.Property(e => e.Descr).HasColumnName("DESCR");

                entity.Property(e => e.Descrshort).HasColumnName("DESCRSHORT");

                entity.Property(e => e.Effdt).HasColumnName("EFFDT");

                entity.Property(e => e.Jobcode).HasColumnName("JOBCODE");
            });

            modelBuilder.Entity<TestPscdwj1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Test_PSCDWJ1", "dbo");

                entity.Property(e => e.Action).HasColumnName("ACTION");

                entity.Property(e => e.ActionDt).HasColumnName("ACTION_DT");

                entity.Property(e => e.ActionReason).HasColumnName("ACTION_REASON");

                entity.Property(e => e.Address1).HasColumnName("ADDRESS1");

                entity.Property(e => e.Address2).HasColumnName("ADDRESS2");

                entity.Property(e => e.Birthdate).HasColumnName("BIRTHDATE");

                entity.Property(e => e.BusinessUnit).HasColumnName("BUSINESS_UNIT");

                entity.Property(e => e.CdwAs400Oprid).HasColumnName("CDW_AS400_OPRID");

                entity.Property(e => e.CdwBbPhone).HasColumnName("CDW_BB_PHONE");

                entity.Property(e => e.CdwBcelPhone).HasColumnName("CDW_BCEL_PHONE");

                entity.Property(e => e.CdwBonusType).HasColumnName("CDW_BONUS_TYPE");

                entity.Property(e => e.CdwCellPhone).HasColumnName("CDW_CELL_PHONE");

                entity.Property(e => e.CdwDeptEffdt).HasColumnName("CDW_DEPT_EFFDT");

                entity.Property(e => e.CdwEndTime).HasColumnName("CDW_END_TIME");

                entity.Property(e => e.CdwEthGrpDescr).HasColumnName("CDW_ETH_GRP_DESCR");

                entity.Property(e => e.CdwFltHrsEarned).HasColumnName("CDW_FLT_HRS_EARNED");

                entity.Property(e => e.CdwFltHrsTaken).HasColumnName("CDW_FLT_HRS_TAKEN");

                entity.Property(e => e.CdwHomeAreaCode).HasColumnName("CDW_HOME_AREA_CODE");

                entity.Property(e => e.CdwHomePhone).HasColumnName("CDW_HOME_PHONE");

                entity.Property(e => e.CdwItDeptFlg).HasColumnName("CDW_IT_DEPT_FLG");

                entity.Property(e => e.CdwJobEntryDt).HasColumnName("CDW_JOB_ENTRY_DT");

                entity.Property(e => e.CdwJobcodeEffdt).HasColumnName("CDW_JOBCODE_EFFDT");

                entity.Property(e => e.CdwLoadType).HasColumnName("CDW_LOAD_TYPE");

                entity.Property(e => e.CdwLocationEffdt).HasColumnName("CDW_LOCATION_EFFDT");

                entity.Property(e => e.CdwMgrLvlDesc).HasColumnName("CDW_MGR_LVL_DESC");

                entity.Property(e => e.CdwOffiAreaCode).HasColumnName("CDW_OFFI_AREA_CODE");

                entity.Property(e => e.CdwOffiPhone).HasColumnName("CDW_OFFI_PHONE");

                entity.Property(e => e.CdwPcellPhone).HasColumnName("CDW_PCELL_PHONE");

                entity.Property(e => e.CdwPcnEffdt).HasColumnName("CDW_PCN_EFFDT");

                entity.Property(e => e.CdwPersona).HasColumnName("CDW_PERSONA");

                entity.Property(e => e.CdwPgrAreaCode).HasColumnName("CDW_PGR_AREA_CODE");

                entity.Property(e => e.CdwPgrPhone).HasColumnName("CDW_PGR_PHONE");

                entity.Property(e => e.CdwSickHrsTaken).HasColumnName("CDW_SICK_HRS_TAKEN");

                entity.Property(e => e.CdwSikHrsEarned).HasColumnName("CDW_SIK_HRS_EARNED");

                entity.Property(e => e.CdwStartTime).HasColumnName("CDW_START_TIME");

                entity.Property(e => e.CdwVacHrsEarned).HasColumnName("CDW_VAC_HRS_EARNED");

                entity.Property(e => e.CdwVacHrsTaken).HasColumnName("CDW_VAC_HRS_TAKEN");

                entity.Property(e => e.CdwVendorName).HasColumnName("CDW_VENDOR_NAME");

                entity.Property(e => e.CdwneighborhoodLocationCode).HasColumnName("CDWNeighborhoodLocationCode");

                entity.Property(e => e.City).HasColumnName("CITY");

                entity.Property(e => e.CmpnySeniorityDt).HasColumnName("CMPNY_SENIORITY_DT");

                entity.Property(e => e.Company).HasColumnName("COMPANY");

                entity.Property(e => e.ContractEmplid).HasColumnName("CONTRACT_EMPLID");

                entity.Property(e => e.Countthrowaway).HasColumnName("countthrowaway");

                entity.Property(e => e.DeptDescr).HasColumnName("DEPT_DESCR");

                entity.Property(e => e.DeptEntryDt).HasColumnName("DEPT_ENTRY_DT");

                entity.Property(e => e.Deptid).HasColumnName("DEPTID");

                entity.Property(e => e.DescrPosition).HasColumnName("DESCR_POSITION");

                entity.Property(e => e.Descrshort).HasColumnName("DESCRSHORT");

                entity.Property(e => e.Eeo1code).HasColumnName("EEO1CODE");

                entity.Property(e => e.EeoJobGroup).HasColumnName("EEO_JOB_GROUP");

                entity.Property(e => e.EmailAddr).HasColumnName("EMAIL_ADDR");

                entity.Property(e => e.EmplStatus).HasColumnName("EMPL_STATUS");

                entity.Property(e => e.EmplType).HasColumnName("EMPL_TYPE");

                entity.Property(e => e.Emplid).HasColumnName("EMPLID");

                entity.Property(e => e.EntryDate).HasColumnName("ENTRY_DATE");

                entity.Property(e => e.Estabid).HasColumnName("ESTABID");

                entity.Property(e => e.EthnicGroup).HasColumnName("ETHNIC_GROUP");

                entity.Property(e => e.EthnicGrpCd).HasColumnName("ETHNIC_GRP_CD");

                entity.Property(e => e.Exclude).HasColumnName("EXCLUDE");

                entity.Property(e => e.Extension).HasColumnName("EXTENSION");

                entity.Property(e => e.FirstName).HasColumnName("FIRST_NAME");

                entity.Property(e => e.FlsaStatus).HasColumnName("FLSA_STATUS");

                entity.Property(e => e.Fte).HasColumnName("FTE");

                entity.Property(e => e.FullPartTime).HasColumnName("FULL_PART_TIME");

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.HireDt).HasColumnName("HIRE_DT");

                entity.Property(e => e.HolidaySchedule).HasColumnName("HOLIDAY_SCHEDULE");

                entity.Property(e => e.HrStatus).HasColumnName("HR_STATUS");

                entity.Property(e => e.JobEffdt).HasColumnName("JOB_EFFDT");

                entity.Property(e => e.JobEntryDt).HasColumnName("JOB_ENTRY_DT");

                entity.Property(e => e.JobFamily).HasColumnName("JOB_FAMILY");

                entity.Property(e => e.JobIndicator).HasColumnName("JOB_INDICATOR");

                entity.Property(e => e.Jobcode).HasColumnName("JOBCODE");

                entity.Property(e => e.JobcodeDescr).HasColumnName("JOBCODE_DESCR");

                entity.Property(e => e.LastDateWorked).HasColumnName("LAST_DATE_WORKED");

                entity.Property(e => e.LastHireDt).HasColumnName("LAST_HIRE_DT");

                entity.Property(e => e.LastName).HasColumnName("LAST_NAME");

                entity.Property(e => e.Location).HasColumnName("LOCATION");

                entity.Property(e => e.LocationDescr).HasColumnName("LOCATION_DESCR");

                entity.Property(e => e.LosgroupCode).HasColumnName("LOSGroupCode");

                entity.Property(e => e.LosgroupDescription).HasColumnName("LOSGroupDescription");

                entity.Property(e => e.Losmonth).HasColumnName("LOSMonth");

                entity.Property(e => e.LosstartDate)
                    .HasColumnType("date")
                    .HasColumnName("LOSStartDate");

                entity.Property(e => e.ManagerLevel).HasColumnName("MANAGER_LEVEL");

                entity.Property(e => e.MarStatus).HasColumnName("MAR_STATUS");

                entity.Property(e => e.MiddleName).HasColumnName("MIDDLE_NAME");

                entity.Property(e => e.Name).HasColumnName("NAME");

                entity.Property(e => e.NameDisplay).HasColumnName("NAME_DISPLAY");

                entity.Property(e => e.NamePrefix).HasColumnName("NAME_PREFIX");

                entity.Property(e => e.NationalId).HasColumnName("NATIONAL_ID");

                entity.Property(e => e.NextReviewDt).HasColumnName("NEXT_REVIEW_DT");

                entity.Property(e => e.Node1).HasColumnName("NODE1");

                entity.Property(e => e.Node2).HasColumnName("NODE2");

                entity.Property(e => e.Oprid).HasColumnName("OPRID");

                entity.Property(e => e.ParentNodeName).HasColumnName("PARENT_NODE_NAME");

                entity.Property(e => e.Paygroup).HasColumnName("PAYGROUP");

                entity.Property(e => e.PerOrg).HasColumnName("PER_ORG");

                entity.Property(e => e.PositionEntryDt).HasColumnName("POSITION_ENTRY_DT");

                entity.Property(e => e.PositionNbr).HasColumnName("POSITION_NBR");

                entity.Property(e => e.PrefFirstName).HasColumnName("PREF_FIRST_NAME");

                entity.Property(e => e.RegRegion).HasColumnName("REG_REGION");

                entity.Property(e => e.RegTemp).HasColumnName("REG_TEMP");

                entity.Property(e => e.ReportsTo).HasColumnName("REPORTS_TO");

                entity.Property(e => e.SeniorityPayDt).HasColumnName("SENIORITY_PAY_DT");

                entity.Property(e => e.ServiceDt).HasColumnName("SERVICE_DT");

                entity.Property(e => e.Sex).HasColumnName("SEX");

                entity.Property(e => e.Shift).HasColumnName("SHIFT");

                entity.Property(e => e.Smoker).HasColumnName("SMOKER");

                entity.Property(e => e.State).HasColumnName("STATE");

                entity.Property(e => e.StdHours).HasColumnName("STD_HOURS");

                entity.Property(e => e.SupervisorId).HasColumnName("SUPERVISOR_ID");

                entity.Property(e => e.SupervisorName).HasColumnName("SUPERVISOR_NAME");

                entity.Property(e => e.TaxLocationCd).HasColumnName("TAX_LOCATION_CD");

                entity.Property(e => e.TerminationDate).HasColumnType("date");

                entity.Property(e => e.TerminationDt).HasColumnName("TERMINATION_DT");

                entity.Property(e => e.Title).HasColumnName("TITLE");

                entity.Property(e => e.TreeNode).HasColumnName("TREE_NODE");

                entity.Property(e => e.UnionCoworkerCode).HasColumnName("unionCoworkerCode");

                entity.Property(e => e.WorkersCompCd).HasColumnName("WORKERS_COMP_CD");

                entity.Property(e => e.Zip).HasColumnName("ZIP");
            });

            modelBuilder.Entity<TestSelfjoinemp05andP>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_selfjoinemp05andPS", "dbo");

                entity.Property(e => e.CdwVendorName).HasColumnName("CDW_VENDOR_NAME");

                entity.Property(e => e.CdwneighborhoodLocationCode).HasColumnName("CDWNeighborhoodLocationCode");

                entity.Property(e => e.Emp05terminationDescription).HasColumnName("EMP05TerminationDescription");

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.LosgroupCode).HasColumnName("LOSGroupCode");

                entity.Property(e => e.LosgroupDescription).HasColumnName("LOSGroupDescription");

                entity.Property(e => e.Losmonth).HasColumnName("LOSMonth");

                entity.Property(e => e.LosstartDate)
                    .HasColumnType("date")
                    .HasColumnName("LOSStartDate");

                entity.Property(e => e.ManagerGldepartmentCode).HasColumnName("ManagerGLDepartmentCode");

                entity.Property(e => e.PerOrg).HasColumnName("PER_ORG");

                entity.Property(e => e.PsgldepartmentCode).HasColumnName("PSGLDepartmentCode");

                entity.Property(e => e.ReportsTo).HasColumnName("REPORTS_TO");

                entity.Property(e => e.SupervisorId).HasColumnName("SUPERVISOR_ID");

                entity.Property(e => e.SupervisorName).HasColumnName("SUPERVISOR_NAME");

                entity.Property(e => e.TerminationDate).HasColumnType("date");

                entity.Property(e => e.Tyatnb).HasColumnName("TYATNB");

                entity.Property(e => e.Tybdvn).HasColumnName("TYBDVN");

                entity.Property(e => e.Tyc2tt).HasColumnName("TYC2TT");

                entity.Property(e => e.Tyn6xt).HasColumnName("TYN6XT");

                entity.Property(e => e.Tysrep).HasColumnName("TYSREP");

                entity.Property(e => e.Tytist).HasColumnName("TYTIST");

                entity.Property(e => e.Tyurid).HasColumnName("TYURID");
            });

            modelBuilder.Entity<TestShortTitleToEdwroleMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_ShortTitleToEDWRoleMap", "dbo");

                entity.Property(e => e.C7).HasColumnName("_c7");

                entity.Property(e => e.C8).HasColumnName("_c8");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.EdwRoleType).HasColumnName("edwRoleType");

                entity.Property(e => e.EffEnd).HasColumnName("EffEnd_");

                entity.Property(e => e.EffStart).HasColumnName("EffStart_");

                entity.Property(e => e.Icmplan).HasColumnName("ICMPlan");

                entity.Property(e => e.Prop7).HasColumnName("Prop_7");

                entity.Property(e => e.ShortTitle).HasColumnName("shortTitle");

                entity.Property(e => e.Tcplan).HasColumnName("TCPlan");
            });

            modelBuilder.Entity<TestVwEdwod>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_vwEDWODS", "dbo");

                entity.Property(e => e.AdjInvoiceLineNbr).HasColumnName("adjInvoiceLineNbr");

                entity.Property(e => e.AdjType).HasColumnName("adjType");

                entity.Property(e => e.AtengagementCode).HasColumnName("ATEngagementCode");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.CompDate).HasColumnName("compDate");

                entity.Property(e => e.CompPlan).HasColumnName("compPlan");

                entity.Property(e => e.CreditType).HasColumnName("creditType");

                entity.Property(e => e.CustOnQuote).HasColumnName("custOnQuote");

                entity.Property(e => e.Cwgldept).HasColumnName("CWGLdept");

                entity.Property(e => e.DataSource).HasColumnName("dataSource");

                entity.Property(e => e.Edc).HasColumnName("EDC");

                entity.Property(e => e.EventType).HasColumnName("eventType");

                entity.Property(e => e.Gpcredit).HasColumnName("GPCredit");

                entity.Property(e => e.InvoiceCompany).HasColumnName("invoiceCompany");

                entity.Property(e => e.InvoiceLine).HasColumnName("invoiceLine");

                entity.Property(e => e.InvoiceNbr).HasColumnName("invoiceNbr");

                entity.Property(e => e.LineCost).HasColumnName("lineCost");

                entity.Property(e => e.MsincentiveProgram).HasColumnName("MSIncentiveProgram");

                entity.Property(e => e.PayeeId).HasColumnName("PayeeID");

                entity.Property(e => e.PeriodStart).HasColumnName("periodStart");

                entity.Property(e => e.Segment).HasColumnName("segment");

                entity.Property(e => e.SplitPct).HasColumnName("splitPct");

                entity.Property(e => e.SplitType).HasColumnName("splitType");

                entity.Property(e => e.TxnAssignSeq).HasColumnName("txnAssignSeq");

                entity.Property(e => e.TxnSeq).HasColumnName("txnSeq");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Transactions", "metadata");

                entity.Property(e => e.TransactionCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XrefBidRequestOrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.CompanyCode, e.BidRequestCode, e.BidRequestLineNumber, e.OrderCode, e.OrderLineNumber });

                entity.ToTable("XREF_BidRequest_Order_Detail", "dbo");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OrderCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CreatedByUserID");

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.PurchaseOrderActionCompanyCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XrefDepartmentNodeCoworker>(entity =>
            {
                entity.HasKey(e => e.DepartmentTreeNode);

                entity.ToTable("XREF_DepartmentNode_Coworker", "dbo");

                entity.Property(e => e.DepartmentTreeNode).ValueGeneratedNever();

                entity.Property(e => e.DepartmentCoworkerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentNodeDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.ModifiedByUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ModifiedByUserID");
            });

            modelBuilder.Entity<XrefProductClassification>(entity =>
            {
                entity.HasKey(e => e.ItemCode);

                entity.ToTable("XREF_Product_Classification", "dbo");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.GlaccountClassification)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GLAccountClassification");

                entity.Property(e => e.ItemGroupMajorCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTaxRuleCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTaxRulePercent).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ModifiedByCoworkerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RevenueRecognitionPercent).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SourceModifiedDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.SourceModifiedUserId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SourceModifiedUserID");
            });

            modelBuilder.Entity<XrefSalesLogisticsOrder>(entity =>
            {
                entity.HasKey(e => e.XrefSalesLogisticsOrdersId);

                entity.ToTable("XrefSalesLogisticsOrders", "dbo");

                entity.HasIndex(e => new { e.LogisticsOrderCode, e.SalesOrderCode }, "uq_Logistics_SalesOrderCode")
                    .IsUnique();

                entity.Property(e => e.XrefSalesLogisticsOrdersId).HasColumnName("XrefSalesLogisticsOrdersID");

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.LogisticsOrderCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOrderCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XrefServiceType>(entity =>
            {
                entity.ToTable("XREF_ServiceType", "dbo");

                entity.HasIndex(e => new { e.ServiceTypeCode, e.ItemGroupMajorCode }, "uq_ServiceType_ItemGroupMajor")
                    .IsUnique();

                entity.Property(e => e.XrefServiceTypeId).HasColumnName("XrefServiceTypeID");

                entity.Property(e => e.EdwcreatedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWCreatedDateTime");

                entity.Property(e => e.EdwmodifiedDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDWModifiedDateTime");

                entity.Property(e => e.ItemGroupMajorCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceTypeCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ycnddtarfp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("YCNDDTARFP", "staging");

                entity.Property(e => e.Cnd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@CND");

                entity.Property(e => e.Cnd1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CND");

                entity.Property(e => e.Cndmsid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CNDMSID");

                entity.Property(e => e.Cndtxov)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CNDTXOV");

                entity.Property(e => e.FileGp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@FILE_GP");

                entity.Property(e => e.FileP)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@FILE_P");

                entity.Property(e => e.Gui)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@GUI");

                entity.Property(e => e.Lglopr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("LGLOPR");

                entity.Property(e => e.Mnemon)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("MNEMON");

                entity.Property(e => e.Mnemsid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("MNEMSID");

                entity.Property(e => e.Mnetxov)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("MNETXOV");

                entity.Property(e => e.MsgGp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@MSG_GP");

                entity.Property(e => e.MsgPr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@MSG_PR");

                entity.Property(e => e.Nptapp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NPTAPP");

                entity.Property(e => e.Nptht)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NPTHT");

                entity.Property(e => e.Nptwd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NPTWD");

                entity.Property(e => e.Obj1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@OBJ1");

                entity.Property(e => e.Obj2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@OBJ2");

                entity.Property(e => e.Objatr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OBJATR");

                entity.Property(e => e.Objtyp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OBJTYP");

                entity.Property(e => e.Own)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@OWN");

                entity.Property(e => e.Relopr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RELOPR");

                entity.Property(e => e.TypeGp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TYPE_GP");

                entity.Property(e => e.TypeP)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TYPE_P");
            });

            modelBuilder.Entity<Ycondtarfp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("YCONDTARFP", "staging");

                entity.Property(e => e.Con)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@CON");

                entity.Property(e => e.Con1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CON");

                entity.Property(e => e.Objtyp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OBJTYP");
            });

            modelBuilder.Entity<Yentdtarfp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("YENTDTARFP", "staging");

                entity.Property(e => e.Auxent)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@AUXENT");

                entity.Property(e => e.Dupfldind)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DUPFLDIND");

                entity.Property(e => e.Ent)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@ENT");

                entity.Property(e => e.Entseq)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ENTSEQ");

                entity.Property(e => e.Enttyp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ENTTYP");

                entity.Property(e => e.Expflg)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EXPFLG");

                entity.Property(e => e.Expseq)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EXPSEQ");

                entity.Property(e => e.Fgnkeyind)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FGNKEYIND");

                entity.Property(e => e.Fil)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@FIL");

                entity.Property(e => e.Fld)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@FLD");

                entity.Property(e => e.Frcfldind)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FRCFLDIND");

                entity.Property(e => e.Keynbr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("KEYNBR");

                entity.Property(e => e.Rdrent)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@RDRENT");

                entity.Property(e => e.Rdrtype)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RDRTYPE");

                entity.Property(e => e.Refent)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@REFENT");

                entity.Property(e => e.Reffil)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@REFFIL");

                entity.Property(e => e.Reldef)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@RELDEF");

                entity.Property(e => e.Reldsg)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@RELDSG");

                entity.Property(e => e.Rnmfld)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@RNMFLD");

                entity.Property(e => e.Rnmind)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RNMIND");
            });

            modelBuilder.Entity<Yfildtarfp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("YFILDTARFP", "staging");

                entity.Property(e => e.Docseq)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DOCSEQ");

                entity.Property(e => e.Dstfil)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DSTFIL");

                entity.Property(e => e.Expdte)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EXPDTE");

                entity.Property(e => e.Fil)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@FIL");

                entity.Property(e => e.Fil1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FIL");

                entity.Property(e => e.Filmsid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FILMSID");

                entity.Property(e => e.Filtxov)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FILTXOV");

                entity.Property(e => e.Notfnd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@NOTFND");

                entity.Property(e => e.Objatr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OBJATR");

                entity.Property(e => e.Objtyp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OBJTYP");

                entity.Property(e => e.Olddbs)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OLDDBS");

                entity.Property(e => e.Rcdexs)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@RCDEXS");

                entity.Property(e => e.Reqsyn)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("REQSYN");

                entity.Property(e => e.Rpgpfx)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RPGPFX");

                entity.Property(e => e.Srcmbr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SRCMBR");
            });

            modelBuilder.Entity<Yflddtarfp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("YFLDDTARFP", "staging");

                entity.Property(e => e.Alwblk)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ALWBLK");

                entity.Property(e => e.Cnd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@CND");

                entity.Property(e => e.Colhd1msid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COLHD1MSID");

                entity.Property(e => e.Colhd1txov)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COLHD1TXOV");

                entity.Property(e => e.Colhd2msid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COLHD2MSID");

                entity.Property(e => e.Colhd2txov)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COLHD2TXOV");

                entity.Property(e => e.Colhd3msid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COLHD3MSID");

                entity.Property(e => e.Colhd3txov)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COLHD3TXOV");

                entity.Property(e => e.Colhdg1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COLHDG1");

                entity.Property(e => e.Colhdg2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COLHDG2");

                entity.Property(e => e.Colhdg3)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COLHDG3");

                entity.Property(e => e.Colminlen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COLMINLEN");

                entity.Property(e => e.Ddsvnm)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DDSVNM");

                entity.Property(e => e.Dft)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@DFT");

                entity.Property(e => e.Docseq)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DOCSEQ");

                entity.Property(e => e.Dom)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@DOM");

                entity.Property(e => e.FileGp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@FILE_GP");

                entity.Property(e => e.FileI)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@FILE_I");

                entity.Property(e => e.FileP)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@FILE_P");

                entity.Property(e => e.FileV)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@FILE_V");

                entity.Property(e => e.Fld)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@FLD");

                entity.Property(e => e.Fld1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FLD");

                entity.Property(e => e.Fldmsid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FLDMSID");

                entity.Property(e => e.Fldtxov)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("FLDTXOV");

                entity.Property(e => e.Grpfld)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@GRPFLD");

                entity.Property(e => e.Gui)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@GUI");

                entity.Property(e => e.Intddsvnm)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("INTDDSVNM");

                entity.Property(e => e.Lhshdg)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("LHSHDG");

                entity.Property(e => e.Lhshdgmsid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("LHSHDGMSID");

                entity.Property(e => e.Lhshdgtxov)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("LHSHDGTXOV");

                entity.Property(e => e.Lhsminlen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("LHSMINLEN");

                entity.Property(e => e.MsgGp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@MSG_GP");

                entity.Property(e => e.MsgI)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@MSG_I");

                entity.Property(e => e.MsgPr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@MSG_PR");

                entity.Property(e => e.MsgV)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@MSG_V");

                entity.Property(e => e.Nptapp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NPTAPP");

                entity.Property(e => e.Nptht)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NPTHT");

                entity.Property(e => e.Nptwd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NPTWD");

                entity.Property(e => e.Objatr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OBJATR");

                entity.Property(e => e.Objtyp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OBJTYP");

                entity.Property(e => e.Ocrcnt)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OCRCNT");

                entity.Property(e => e.Oldddsvnm)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("OLDDDSVNM");

                entity.Property(e => e.Rhshdg)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RHSHDG");

                entity.Property(e => e.Rhshdgmsid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RHSHDGMSID");

                entity.Property(e => e.Rhshdgtxov)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RHSHDGTXOV");

                entity.Property(e => e.Rhsminlen)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("RHSMINLEN");

                entity.Property(e => e.Scrmask)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SCRMASK");

                entity.Property(e => e.Txt)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TXT");

                entity.Property(e => e.Txtmsid)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TXTMSID");

                entity.Property(e => e.Txttxov)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TXTTXOV");

                entity.Property(e => e.TypeGp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TYPE_GP");

                entity.Property(e => e.TypeI)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TYPE_I");

                entity.Property(e => e.TypeP)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TYPE_P");

                entity.Property(e => e.TypeV)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("TYPE_V");

                entity.Property(e => e.Valrqd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("@@VALRQD");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
