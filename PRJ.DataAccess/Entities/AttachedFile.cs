using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class AttachedFile
    {
        public long FileId { get; set; }
        public long SecureChatId { get; set; }
        public string? AttachedFileURL { get; set; }

        public virtual SecureChat SecureChat { get; set; } = null!;
    }
}
