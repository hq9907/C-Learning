using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.data_types
{
    internal class Counter
    {
        int range = 24, step = 4;
        public Counter() { }

        public void Count()
        {
            for (int i = 1; i <= step; ++i)
            {
                for (int j = 0; j <= range; j += i)
                {
                    Console.Write((j == 0 ? "" : ",") + j);
                }
                Console.WriteLine();
            }
        }
    }
}
