using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMigration.Data
{
    public static class Config
    {
        // "Server:{serverURL}; Authentication=Active Directory Managed Identity; Initial Catalog={db};"
        public static string reportingDBConn
           // = "Server:entrep-sqldb-cdw-usncz-dv-svr.database.windows.net; Initial Catalog=entrep-sqldb-cdw-usncz-dv-ReportingDB;";
           = "server=entrep-sqldb-cdw-usncz-dv-svr.database.windows.net;database=entrep-sqldb-cdw-usncz-dv-ReportingDB;";
        public static string primaryDBConn
            // = "Server:entrep-sqldb-cdw-usncz-dv-svr.database.windows.net;     Initial Catalog= entrep-sqldb-cdw-usncz-dv-ReportingDB;";
            // server=usnca-cdw-edw-sql-dev.database.windows.net;database=usnca-cdw-edw-sql-db-primary-dev;Authentication=ActiveDirectoryIntegrated;"
            = "server=usnca-cdw-edw-sql-dev.database.windows.net;database=usnca-cdw-edw-sql-db-primary-dev;";
    }
}
