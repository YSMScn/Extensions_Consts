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
            return (originalDateTime - DateTimeConst.UnixEpoch).TotalSeconds;
        }
    }
}
