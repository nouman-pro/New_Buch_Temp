using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_PatientIllnessHistory
    {
        public long PatientIllnessHistoryId { get; set; }
        public long PatientId { get; set; }
        public string? DiseaseName { get; set; }
        public string? Treatment { get; set; }
        public string? Description { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual PAT_Patient Patient { get; set; } = null!;
    }
}
