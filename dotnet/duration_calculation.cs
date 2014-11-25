using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExplore
{
    public class TimeBlend
    {
        public static void HourCount(DateTime aStart, DateTime aEnd)
        {
            DateTime curr = aStart;
            DateTime prevWorking = DateTime.MinValue;
            TimeSpan ts = new TimeSpan(0);

            int days = 0;

            while (curr < aEnd)
            {
                if ((curr.Hour >= 7 && curr.Hour < 15) && (curr.DayOfWeek != DayOfWeek.Saturday && curr.DayOfWeek != DayOfWeek.Sunday))
                {
                    ts = ts.Add(new TimeSpan(0, 1, 0));
                    if (prevWorking.Day != curr.Day && prevWorking != DateTime.MinValue)
                    {
                        days++;
                    }
                    prevWorking = curr;
                }
                curr = curr.AddMinutes(1);
            }

            Console.WriteLine(
                string.Format("Hours: {0}\r\nDays: {1}", ts.TotalHours, days)
                );
        }
    }
}
