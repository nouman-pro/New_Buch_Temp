using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SYS_Inbox
    {
        public SYS_Inbox()
        {
            Chat_Attachments = new HashSet<Chat_Attachment>();
            SYS_Chats = new HashSet<SYS_Chat>();
        }

        public long InboxId { get; set; }
        public long DoctorUserId { get; set; }
        public long PatientUserId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual SYS_User DoctorUser { get; set; } = null!;
        public virtual SYS_User PatientUser { get; set; } = null!;
        public virtual ICollection<Chat_Attachment> Chat_Attachments { get; set; }
        public virtual ICollection<SYS_Chat> SYS_Chats { get; set; }
    }
}
