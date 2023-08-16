using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SYS_Menu
    {
        public SYS_Menu()
        {
            InverseParent = new HashSet<SYS_Menu>();
            SYS_Permissions = new HashSet<SYS_Permission>();
        }

        public long MenuId { get; set; }
        public string? Name { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedById { get; set; }
        public bool? IsActive { get; set; }
        public long? ParentId { get; set; }

        public virtual SYS_Menu? Parent { get; set; }
        public virtual ICollection<SYS_Menu> InverseParent { get; set; }
        public virtual ICollection<SYS_Permission> SYS_Permissions { get; set; }
    }
}
