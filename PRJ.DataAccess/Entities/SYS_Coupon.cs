using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SYS_Coupon
    {
        public long CouponId { get; set; }
        public string? CouponName { get; set; }
        public string? Description { get; set; }
        public int DiscountTypeId { get; set; }
        public int? DiscountPercentage { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int FrequencyId { get; set; }

        public virtual SYS_Lookup DiscountType { get; set; } = null!;
        public virtual SYS_Lookup Frequency { get; set; } = null!;
    }
}
