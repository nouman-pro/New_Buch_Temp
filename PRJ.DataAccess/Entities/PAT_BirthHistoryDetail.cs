using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_BirthHistoryDetail
    {
        public long BirthHistoryDetailId { get; set; }
        public long PatientId { get; set; }
        public DateTime? MonthYear { get; set; }
        public string? DeliveryPlace { get; set; }
        public int? InfantSexId { get; set; }
        public int? WeightAtBirth { get; set; }
        public int? WeeksAtDelivery { get; set; }
        public int? HrsInLabor { get; set; }
        public int? DeliveryAndAnesthesiaTypeId { get; set; }
        public string? Complication { get; set; }
        public string? ChildName { get; set; }
        public long CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedById { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual SYS_Lookup? DeliveryAndAnesthesiaType { get; set; }
        public virtual SYS_Lookup? InfantSex { get; set; }
        public virtual PAT_Patient Patient { get; set; } = null!;
    }
}
