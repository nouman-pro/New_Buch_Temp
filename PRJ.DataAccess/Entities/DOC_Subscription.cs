using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class DOC_Subscription
    {
        public long SubscribeId { get; set; }
        public long DoctorId { get; set; }
        public long PatientId { get; set; }

        public virtual SYS_User Doctor { get; set; } = null!;
        public virtual SYS_User Patient { get; set; } = null!;
    }
}
