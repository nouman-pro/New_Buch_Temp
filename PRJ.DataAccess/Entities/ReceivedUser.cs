using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class ReceivedUser
    {
        public long ReceivedId { get; set; }
        public long ToUserId { get; set; }
        public long SecureChatId { get; set; }

        public virtual SecureChat SecureChat { get; set; } = null!;
        public virtual SYS_User ToUser { get; set; } = null!;
    }
}
