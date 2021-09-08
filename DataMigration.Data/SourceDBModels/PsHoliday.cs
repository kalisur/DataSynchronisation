using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class PsHoliday
    {
        public string HolidaySchedule { get; set; }
        public string Holiday { get; set; }
        public string Descr { get; set; }
        public string HolidayHrs { get; set; }
        public string HolidayType { get; set; }
        public string HolTimeStart { get; set; }
        public string HolTimeEnd { get; set; }
    }
}
