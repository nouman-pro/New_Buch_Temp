using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRJ.Service.Helpers
{
    public static class TimeSpanExtenston
    {
        public static TimeSpan CovnertStringToTimeSpan(string time)
        {
            DateTime timespan = DateTime.Parse(time);
            TimeSpan _time = timespan.TimeOfDay;
            return _time;
        }
    }
}
