using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SYS_ForgetPassword
    {
        public long LoginId { get; set; }
        public string Code { get; set; } = null!;
        public string? Email { get; set; }

        public virtual SYS_Login Login { get; set; } = null!;
    }
}
