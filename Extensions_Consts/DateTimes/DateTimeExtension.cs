using Consts.DateTimes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions.DateTimes
{
    public static class DateTimeExtension
    {
        public static double ToUnixTimeStamp(this DateTime originalDateTime)
        {
            if (originalDateTime < DateTime.UnixEpoch)
            {
                throw new ArgumentOutOfRangeException(nameof(originalDateTime),"The DateTime to convert is earlier than UnixEpoch");
            }
            return (originalDateTime - DateTime.UnixEpoch).TotalSeconds;
        }
    }
}
