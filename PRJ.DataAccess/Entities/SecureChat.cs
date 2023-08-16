using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SecureChat
    {
        public SecureChat()
        {
            AttachedFiles = new HashSet<AttachedFile>();
            ReceivedUsers = new HashSet<ReceivedUser>();
        }

        public long SecureChatId { get; set; }
        public long FromUserId { get; set; }
        public string Subject { get; set; } = null!;
        public string Message { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public long CreatedById { get; set; }
        public bool IsDeleted { get; set; }

        public virtual SYS_User FromUser { get; set; } = null!;
        public virtual ICollection<AttachedFile> AttachedFiles { get; set; }
        public virtual ICollection<ReceivedUser> ReceivedUsers { get; set; }
    }
}
