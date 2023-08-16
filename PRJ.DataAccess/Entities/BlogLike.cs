using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class BlogLike
    {
        public long BlogLikedId { get; set; }
        public long CommunityFormId { get; set; }
        public bool? IsLiked { get; set; }
        public long PatientId { get; set; }

        public virtual DOC_CommunityForm CommunityForm { get; set; } = null!;
        public virtual SYS_User Patient { get; set; } = null!;
    }
}
