using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SYS_Medicine
    {
        public SYS_Medicine()
        {
            PAT_PatientCurrentMedications = new HashSet<PAT_PatientCurrentMedication>();
            PAT_PatientMedications = new HashSet<PAT_PatientMedication>();
        }

        public int MedicineId { get; set; }
        public string? Name { get; set; }
        public bool? IsActive { get; set; }
        public long? CreatedById { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<PAT_PatientCurrentMedication> PAT_PatientCurrentMedications { get; set; }
        public virtual ICollection<PAT_PatientMedication> PAT_PatientMedications { get; set; }
    }
}
