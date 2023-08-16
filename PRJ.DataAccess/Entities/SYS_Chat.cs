using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SYS_Chat
    {
        public SYS_Chat()
        {
            Chat_Attachments = new HashSet<Chat_Attachment>();
        }

        public long ChatId { get; set; }
        public long InboxId { get; set; }
        public long FromUserId { get; set; }
        public long ToUserId { get; set; }
        public string? AttachedURL { get; set; }
        public string? Message { get; set; }
        public bool IsRead { get; set; }
        public bool IsArchived { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual SYS_User FromUser { get; set; } = null!;
        public virtual SYS_Inbox Inbox { get; set; } = null!;
        public virtual SYS_User ToUser { get; set; } = null!;
        public virtual ICollection<Chat_Attachment> Chat_Attachments { get; set; }
    }
}
