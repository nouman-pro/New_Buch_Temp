using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_SubscribedBlog
    {
        public long BlogId { get; set; }
        public long PatientId { get; set; }
    }
}
