using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SYS_Language
    {
        public SYS_Language()
        {
            SYS_UserLangs = new HashSet<SYS_UserLang>();
            SYS_UserLanguages = new HashSet<SYS_UserLanguage>();
        }

        public int LanguageId { get; set; }
        public string? Value { get; set; }

        public virtual ICollection<SYS_UserLang> SYS_UserLangs { get; set; }
        public virtual ICollection<SYS_UserLanguage> SYS_UserLanguages { get; set; }
    }
}
