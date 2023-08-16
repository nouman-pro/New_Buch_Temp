using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SYS_UserLanguage
    {
        public long UserLanguageId { get; set; }
        public long UserId { get; set; }
        public int LanguageId { get; set; }

        public virtual SYS_Language Language { get; set; } = null!;
        public virtual SYS_User User { get; set; } = null!;
    }
}
