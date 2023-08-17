using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class AmbulanceDetail
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public int PatientId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int? UrgencyLevelId { get; set; }
        public string? PickupPoint { get; set; }
        public string? DestinationPoint { get; set; }
        public int StatusId { get; set; }
        public int UrgencyId { get; set; }
        public int TypeOfEmergencyId { get; set; }
        public bool IsPatientStable { get; set; }
        public string? SpecialRequirement { get; set; }

        public virtual Driver Driver { get; set; } = null!;
        public virtual Patient Patient { get; set; } = null!;
        public virtual Lookup Status { get; set; } = null!;
        public virtual Lookup TypeOfEmergency { get; set; } = null!;
    }
}
