using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SYS_Login
    {
        public SYS_Login()
        {
            SYS_ForgetPasswords = new HashSet<SYS_ForgetPassword>();
        }

        public long LoginId { get; set; }
        public long UserId { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool? IsActive { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? LastLoginDateTime { get; set; }
        public string OTP { get; set; } = null!;

        public virtual SYS_User User { get; set; } = null!;
        public virtual ICollection<SYS_ForgetPassword> SYS_ForgetPasswords { get; set; }
    }
}
