using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SYS_Role
    {
        public SYS_Role()
        {
            SYS_Staffs = new HashSet<SYS_Staff>();
        }

        public long SubRoleId { get; set; }
        public string? SubRole { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedById { get; set; }
        public bool? IsActive { get; set; }
        public int ParentRoleId { get; set; }
        public string? Description { get; set; }

        public virtual SYS_User CreatedBy { get; set; } = null!;
        public virtual SYS_Lookup ParentRole { get; set; } = null!;
        public virtual ICollection<SYS_Staff> SYS_Staffs { get; set; }
    }
}
