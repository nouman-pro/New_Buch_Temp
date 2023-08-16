using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJ.Utility.Stripe.DTOs
{
    public class PlanStripeDTO
    {
        public string ProductId { get; set; }
        public decimal AmountDecimal { get; set; }
        public string Currency { get; set; }
        public string Interval { get; set; }

    }
}
