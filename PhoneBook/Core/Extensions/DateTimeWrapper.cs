using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace PhoneBook.Core.Extensions
{
    public static class DateTimeWrapper
    {
        public static DateTime ParseClientSideDate(string date)
        {
            return DateTime.ParseExact(
                date.Substring(0, 24),
                "ddd MMM d yyyy HH:mm:ss",
                CultureInfo.InvariantCulture
            );
        }
    }
}