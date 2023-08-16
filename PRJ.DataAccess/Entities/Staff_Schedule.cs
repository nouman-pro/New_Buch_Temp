using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class Staff_Schedule
    {
        public long StaffDayId { get; set; }
        public long StaffId { get; set; }
        public int DayId { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }

        public virtual SYS_Lookup Day { get; set; } = null!;
        public virtual SYS_Staff Staff { get; set; } = null!;
    }
}
