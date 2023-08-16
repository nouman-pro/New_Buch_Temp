using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class DOC_CommunityForm
    {
        public DOC_CommunityForm()
        {
            BlogComments = new HashSet<BlogComment>();
            BlogLikes = new HashSet<BlogLike>();
            CommunityFormAttachedFiles = new HashSet<CommunityFormAttachedFile>();
        }

        public long Id { get; set; }
        public long DoctorId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool IsPublish { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedById { get; set; }
        public bool IsBlocked { get; set; }
        public string? ImgURL { get; set; }
        public string? BlockedReason { get; set; }

        public virtual SYS_User Doctor { get; set; } = null!;
        public virtual ICollection<BlogComment> BlogComments { get; set; }
        public virtual ICollection<BlogLike> BlogLikes { get; set; }
        public virtual ICollection<CommunityFormAttachedFile> CommunityFormAttachedFiles { get; set; }
    }
}
