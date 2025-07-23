using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto198.Extensions
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24.0) 
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours ago.";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days ago.";
            }
        }
    }
}
