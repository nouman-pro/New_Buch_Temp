using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class SYS_SubSpeciality
    {
        public int SubSpecialityId { get; set; }
        public int SpecialityId { get; set; }
        public string? Value { get; set; }
    }
}
