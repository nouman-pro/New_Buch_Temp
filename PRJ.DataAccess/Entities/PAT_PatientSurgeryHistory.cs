using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_PatientSurgeryHistory
    {
        public long PatientSurgerylHistoryId { get; set; }
        public long PatientId { get; set; }
        public int SurgeryTypeId { get; set; }
        public string? SurgeonName { get; set; }
        public int? SurgeryYear { get; set; }
        public string? Reason { get; set; }
        public string? Notes { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual PAT_Patient Patient { get; set; } = null!;
        public virtual SYS_Lookup SurgeryType { get; set; } = null!;
    }
}
