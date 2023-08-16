using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class DOC_DoctorReference
    {
        public long DoctorReferenceId { get; set; }
        public long DoctorId { get; set; }
        public string? ReferenceName { get; set; }
        public int? RelationId { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual DOC_Doctor Doctor { get; set; } = null!;
        public virtual SYS_Lookup? Relation { get; set; }
    }
}
