using System;
using System.Collections.Generic;

#nullable disable

namespace DataMigration.Data.SourceDBModels
{
    public partial class DimensionCalendarDate
    {
        public int DateInt { get; set; }
        public DateTime CalendarDate { get; set; }
        public int ISeriesDateInt { get; set; }
        public int? WeekInt { get; set; }
        public DateTime? CalendarWeek { get; set; }
        public int? MonthInt { get; set; }
        public string CalendarMonth { get; set; }
        public int? QuarterInt { get; set; }
        public string CalendarQuarter { get; set; }
        public int? YearInt { get; set; }
        public int? UsworkingDateInt { get; set; }
        public DateTime? UsworkingDate { get; set; }
        public byte? UsworkingDayOfMonth { get; set; }
        public byte? UstotalWorkingDaysOfMonth { get; set; }
        public byte? UsworkingDayOfQuarter { get; set; }
        public byte? UstotalWorkingDaysOfQuarter { get; set; }
        public int? UsworkingDayOfYear { get; set; }
        public int? UstotalWorkingDaysOfYear { get; set; }
        public int? CanadaWorkingDateInt { get; set; }
        public DateTime? CanadaWorkingDate { get; set; }
        public byte? CanadaWorkingDayOfMonth { get; set; }
        public byte? CanadaTotalWorkingDaysOfMonth { get; set; }
        public byte? CanadaWorkingDayOfQuarter { get; set; }
        public byte? CanadaTotalWorkingDaysOfQuarter { get; set; }
        public short? CanadaWorkingDayOfYear { get; set; }
        public short? CanadaTotalWorkingDaysOfYear { get; set; }
        public int? DaysAgo { get; set; }
        public int? MonthsAgo { get; set; }
        public int? QuartersAgo { get; set; }
        public short? HalfYearsAgo { get; set; }
        public short? YearsAgo { get; set; }
    }
}
