using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class Chat_Attachment
    {
        public long ChatAttachmentId { get; set; }
        public long InboxId { get; set; }
        public string? AttachmentsUrl { get; set; }
        public long ChatId { get; set; }

        public virtual SYS_Chat Chat { get; set; } = null!;
        public virtual SYS_Inbox Inbox { get; set; } = null!;
    }
}
