using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class DOC_DoctorAward
    {
        public long DoctorAwardId { get; set; }
        public long DoctorId { get; set; }
        public string? Title { get; set; }
        public string? Institute { get; set; }
        public DateTime? AwardDate { get; set; }
        public int? CountryId { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual SYS_Country? Country { get; set; }
        public virtual DOC_Doctor Doctor { get; set; } = null!;
    }
}
