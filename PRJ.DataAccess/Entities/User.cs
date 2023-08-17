using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class User
    {
        public int Id { get; set; }
        public string? Pin { get; set; }
        public string? Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        public virtual Driver? Driver { get; set; }
        public virtual Patient? Patient { get; set; }
    }
}
