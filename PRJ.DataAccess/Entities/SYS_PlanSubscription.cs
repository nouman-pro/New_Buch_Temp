using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SYS_PlanSubscription
    {
        public long UserSubscriptionId { get; set; }
        public long PlanId { get; set; }
        public long UserId { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsCancalled { get; set; }
        public string? StripeCustomerId { get; set; }
        public string? StripeSubscriptionId { get; set; }
        public bool? IsActive { get; set; }

        public virtual SYS_Plan Plan { get; set; } = null!;
        public virtual SYS_User User { get; set; } = null!;
    }
}
