using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SYS_Plan
    {
        public SYS_Plan()
        {
            SYS_PlanSubscriptions = new HashSet<SYS_PlanSubscription>();
        }

        public long PlanId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Amount { get; set; }
        public int? Validity { get; set; }
        public string? PlanFeature { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsActive { get; set; }
        public string? StripePlanId { get; set; }
        public int? NumberOfConsultation { get; set; }
        public int? DurationId { get; set; }
        public string? StripePlanPriceId { get; set; }
        public int? PlanTypeId { get; set; }
        public int? NumberOfFamilyMembers { get; set; }
        public bool IsDeleted { get; set; }

        public virtual SYS_Lookup? Duration { get; set; }
        public virtual SYS_Lookup? PlanType { get; set; }
        public virtual ICollection<SYS_PlanSubscription> SYS_PlanSubscriptions { get; set; }
    }
}
