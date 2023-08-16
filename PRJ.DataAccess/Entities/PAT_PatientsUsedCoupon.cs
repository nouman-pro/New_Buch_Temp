using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_PatientsUsedCoupon
    {
        public long CouponId { get; set; }
        public long PatientId { get; set; }
        public int? UsableRemainingCount { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual SYS_Coupon Coupon { get; set; } = null!;
        public virtual PAT_Patient Patient { get; set; } = null!;
    }
}
