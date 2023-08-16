using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_PatientSocialHistory
    {
        public long PatientSocialHistoryId { get; set; }
        public bool? IsConsumingTea { get; set; }
        public int? TeaConsumingYears { get; set; }
        public bool? IsConsumingCoffee { get; set; }
        public int? CoffeeConsumingYears { get; set; }
        public bool? IsConsumingCigerattes { get; set; }
        public int? CigeratteConsumingYears { get; set; }
        public bool? IsConsumingVape { get; set; }
        public int? VapeConsumingYears { get; set; }
        public bool? IsConsumingAlcohal { get; set; }
        public int? AlcohalConsumingYears { get; set; }
        public bool? IsConsumingECTA { get; set; }
        public int? ECTAConsumingYears { get; set; }
        public bool? IsConsumingLSD { get; set; }
        public int? LSDConsumingYears { get; set; }
        public bool? IsConsumingCannabis { get; set; }
        public int? CannabisConsumingYears { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long PatientId { get; set; }

        public virtual PAT_Patient Patient { get; set; } = null!;
    }
}
