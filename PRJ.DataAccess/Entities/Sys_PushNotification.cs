using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class Sys_PushNotification
    {
        public long PushNotificationId { get; set; }
        public long UserId { get; set; }
        public string? DeviceId { get; set; }
        public int DeviceTypeId { get; set; }

        public virtual SYS_Lookup DeviceType { get; set; } = null!;
        public virtual SYS_User User { get; set; } = null!;
    }
}
