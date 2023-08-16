using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SYS_Permission
    {
        public long PermissionId { get; set; }
        public long MenuId { get; set; }
        public bool? IsAllowed { get; set; }
        public long SubRoleId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedById { get; set; }
        public bool? IsActive { get; set; }

        public virtual SYS_Menu Menu { get; set; } = null!;
    }
}
