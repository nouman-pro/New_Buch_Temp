using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_PatientAllergyHistory
    {
        public long PatientAllergylHistoryId { get; set; }
        public long PatientId { get; set; }
        public string? AllergyTo { get; set; }
        public string? Reaction { get; set; }
        public string? Medication { get; set; }
        public string? Notes { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual PAT_Patient Patient { get; set; } = null!;
    }
}
