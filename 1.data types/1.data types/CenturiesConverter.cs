using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.data_types
{
    internal class CenturiesConverter
    {
        public static void Convert()
        {
            long centuries = long.Parse(Console.ReadLine());

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
                centuries, centuries *= 100, centuries *= 365, centuries *= 24, centuries *= 60, centuries *= 60, centuries *= 1000, centuries *= 1000, centuries *= 1000);
        }
    }
}
