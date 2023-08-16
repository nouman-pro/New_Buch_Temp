using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class CommunityFormAttachedFile
    {
        public long BlogImgId { get; set; }
        public long CommunityFormId { get; set; }
        public string? KeyName { get; set; }
        public int? ImgOrder { get; set; }

        public virtual DOC_CommunityForm CommunityForm { get; set; } = null!;
    }
}
