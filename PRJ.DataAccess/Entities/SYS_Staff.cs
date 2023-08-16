using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SYS_Staff
    {
        public SYS_Staff()
        {
            Staff_Schedules = new HashSet<Staff_Schedule>();
        }

        public long StaffId { get; set; }
        public double Salary { get; set; }
        public int CurrencyTypeId { get; set; }
        public string? SocialSecurityNumber { get; set; }
        public DateTime? JoiningDate { get; set; }
        public long? SubRoleId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual SYS_Lookup CurrencyType { get; set; } = null!;
        public virtual SYS_User Staff { get; set; } = null!;
        public virtual SYS_Role? SubRole { get; set; }
        public virtual ICollection<Staff_Schedule> Staff_Schedules { get; set; }
    }
}
