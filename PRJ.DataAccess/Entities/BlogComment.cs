using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class BlogComment
    {
        public BlogComment()
        {
            InverseParent = new HashSet<BlogComment>();
        }

        public long BlogCommentId { get; set; }
        public long? ParentId { get; set; }
        public long PatientId { get; set; }
        public long CommunityFormId { get; set; }
        public string? Comment { get; set; }
        public bool IsBlocked { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedById { get; set; }
        public bool IsLiked { get; set; }

        public virtual DOC_CommunityForm CommunityForm { get; set; } = null!;
        public virtual BlogComment? Parent { get; set; }
        public virtual SYS_User Patient { get; set; } = null!;
        public virtual ICollection<BlogComment> InverseParent { get; set; }
    }
}
