using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_MotherExaminationDetail
    {
        public long MotherExaminationDetailId { get; set; }
        public long PatientId { get; set; }
        public DateTime? ExaminationDate { get; set; }
        public string? Mammogram { get; set; }
        public string? BreastExam { get; set; }
        public string? PapSmear { get; set; }
        public string? KindOfContraception { get; set; }
        public int? AgeAtFirstMenses { get; set; }
        public int? MenstrualPeriodId { get; set; }
        public int? AgeAtMenopause { get; set; }
        public string? Notes { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsHotFlashesOrOtherSymptom { get; set; }
        public bool? IsContraceptionUsed { get; set; }
        public int? GynecologicalConditionId { get; set; }

        public virtual SYS_Lookup? GynecologicalCondition { get; set; }
        public virtual SYS_Lookup? MenstrualPeriod { get; set; }
        public virtual PAT_Patient Patient { get; set; } = null!;
    }
}
