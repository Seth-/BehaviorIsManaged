﻿using System;

namespace BiM.Core.Extensions
{
    public static class DateExtensions
    {
        // milliseconds or seconds ??

        public static double DateTimeToUnixTimestamp(this DateTime dateTime)
        {
            return ( dateTime - new DateTime(1970, 1, 1).ToLocalTime() ).TotalMilliseconds;
        }

        public static DateTime UnixTimestampToDateTime(this double unixTimeStamp)
        {
            var dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dtDateTime = dtDateTime.AddMilliseconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public static DateTime UnixTimestampToDateTime(this int unixTimeStamp)
        {
            var dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dtDateTime = dtDateTime.AddMilliseconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
    }
}