using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class DOC_AvailableDay
    {
        public DOC_AvailableDay()
        {
            DOC_SlotDivisions = new HashSet<DOC_SlotDivision>();
            PAT_PatientAppointments = new HashSet<PAT_PatientAppointment>();
        }

        public long AvailableDayId { get; set; }
        public int? DayId { get; set; }
        public long? SlotId { get; set; }
        public DateTime? SlotCreationDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool? IsActive { get; set; }

        public virtual SYS_Lookup? Day { get; set; }
        public virtual DOC_Slot? Slot { get; set; }
        public virtual ICollection<DOC_SlotDivision> DOC_SlotDivisions { get; set; }
        public virtual ICollection<PAT_PatientAppointment> PAT_PatientAppointments { get; set; }
    }
}
