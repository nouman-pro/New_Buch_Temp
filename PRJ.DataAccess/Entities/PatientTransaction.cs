using System;
using System.Collections.Generic;

namespace PRJ.DataAccess.Entities
{
    public partial class PatientTransaction
    {
        public long UserTransactionId { get; set; }
        public string? SubscriptionId { get; set; }
        public int? TransactionAmount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? PatientId { get; set; }

        public virtual SYS_User? Patient { get; set; }
    }
}
