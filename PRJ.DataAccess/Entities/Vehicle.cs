using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            DriverVehicles = new HashSet<DriverVehicle>();
        }

        public int Id { get; set; }
        public string? VehicleNumber { get; set; }

        public virtual ICollection<DriverVehicle> DriverVehicles { get; set; }
    }
}
