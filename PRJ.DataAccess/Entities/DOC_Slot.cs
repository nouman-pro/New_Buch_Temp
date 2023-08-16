using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class DOC_Slot
    {
        public DOC_Slot()
        {
            DOC_AvailableDays = new HashSet<DOC_AvailableDay>();
        }

        public long SlotId { get; set; }
        public long? DoctorId { get; set; }
        public int? SlotTypeId { get; set; }
        public int? GapId { get; set; }
        public int? DurationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual SYS_User? Doctor { get; set; }
        public virtual SYS_Lookup? Duration { get; set; }
        public virtual SYS_Lookup? Gap { get; set; }
        public virtual SYS_Lookup? SlotType { get; set; }
        public virtual ICollection<DOC_AvailableDay> DOC_AvailableDays { get; set; }
    }
}
