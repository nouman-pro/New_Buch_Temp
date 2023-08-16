using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_PatientFamilyMember
    {
        public long FamilyMemberId { get; set; }
        public long ParentId { get; set; }
        public bool? IsAdmin { get; set; }
        public int? RelationId { get; set; }
        public long UserId { get; set; }

        public virtual SYS_User Parent { get; set; } = null!;
        public virtual SYS_Lookup? Relation { get; set; }
        public virtual SYS_User User { get; set; } = null!;
    }
}
