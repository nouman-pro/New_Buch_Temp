using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_PatientLabResult
    {
        public long PatientLabResultId { get; set; }
        public long PatientId { get; set; }
        public string? Title { get; set; }
        public DateTime? TestDate { get; set; }
        public string? Reason { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? LabTestDocumentURL { get; set; }

        public virtual PAT_Patient Patient { get; set; } = null!;
    }
}
