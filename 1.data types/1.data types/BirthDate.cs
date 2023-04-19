using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.data_types
{
    internal class BirthDate
    {
        public static void ShowAgeAndAnniversary(DateOnly birthDate)
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            int daysOld = today.DayNumber - birthDate.DayNumber;
            int daysToNextAnniversary = 10000 - (daysOld % 10000);
            DateOnly nextAnniversary = today.AddDays(daysToNextAnniversary);

            Console.WriteLine("{0} days old, next anniversary is {1}", daysOld, nextAnniversary);
        }
    }
}
