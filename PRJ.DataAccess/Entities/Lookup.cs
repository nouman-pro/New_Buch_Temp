using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class Lookup
    {
        public Lookup()
        {
            AmbulanceDetailStatuses = new HashSet<AmbulanceDetail>();
            AmbulanceDetailTypeOfEmergencies = new HashSet<AmbulanceDetail>();
        }

        public int LookUpId { get; set; }
        public string Value { get; set; } = null!;
        public int Order { get; set; }

        public virtual ICollection<AmbulanceDetail> AmbulanceDetailStatuses { get; set; }
        public virtual ICollection<AmbulanceDetail> AmbulanceDetailTypeOfEmergencies { get; set; }
    }
}
