using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PAT_AvatarCoordinate
    {
        public long AvatarCoordinateId { get; set; }
        public long AvatarId { get; set; }
        public string? Text { get; set; }

        public virtual PAT_Avatar Avatar { get; set; } = null!;
    }
}
