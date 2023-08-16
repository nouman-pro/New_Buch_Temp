using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class DOC_SlotDivision
    {
        public long SlotDivisionId { get; set; }
        public string SlotStartTime { get; set; } = null!;
        public string SlotEndTime { get; set; } = null!;
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? AvailableDayId { get; set; }
        public bool? IsActive { get; set; }

        public virtual DOC_AvailableDay? AvailableDay { get; set; }
    }
}
