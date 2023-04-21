using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.data_types
{
    internal class Greeter
    {
        public static void Greet()
        {
            DateTime now = DateTime.Now;

            if (now.Hour < 12)
            {
                Console.WriteLine("Good Morning!");
                return;
            }
            if (now.Hour < 18)
            {
                Console.WriteLine("Good Afternoon!");
                return;
            }
            if (now.Hour < 21)
            {
                Console.WriteLine("Good Evening");
                return;
            }
            Console.WriteLine("Good Night");
        }
    }
}
