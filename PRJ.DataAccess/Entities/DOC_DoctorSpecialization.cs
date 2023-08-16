using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class DOC_DoctorSpecialization
    {
        public long DoctorSpecializationId { get; set; }
        public long DoctorId { get; set; }
        public int SpecializationId { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual DOC_Doctor Doctor { get; set; } = null!;
        public virtual SYS_Speciality Specialization { get; set; } = null!;
    }
}
