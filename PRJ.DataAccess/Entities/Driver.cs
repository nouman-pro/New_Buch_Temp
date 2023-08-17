using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class Driver
    {
        public Driver()
        {
            AmbulanceDetails = new HashSet<AmbulanceDetail>();
            DriverVehicles = new HashSet<DriverVehicle>();
        }

        public int Id { get; set; }
        public string? DriverLicense { get; set; }

        public virtual User IdNavigation { get; set; } = null!;
        public virtual ICollection<AmbulanceDetail> AmbulanceDetails { get; set; }
        public virtual ICollection<DriverVehicle> DriverVehicles { get; set; }
    }
}
