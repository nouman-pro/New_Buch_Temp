using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class DOC_EducationDetail
    {
        public long EducationDetailId { get; set; }
        public long DoctorId { get; set; }
        public int EducationTypeId { get; set; }
        public string? DegreeTitle { get; set; }
        public DateTime? EndDate { get; set; }
        public int CountryId { get; set; }
        public string? Institute { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }
        public DateTime? StartDate { get; set; }

        public virtual SYS_City? City { get; set; }
        public virtual DOC_Doctor Doctor { get; set; } = null!;
        public virtual SYS_Lookup EducationType { get; set; } = null!;
        public virtual SYS_State? State { get; set; }
    }
}
