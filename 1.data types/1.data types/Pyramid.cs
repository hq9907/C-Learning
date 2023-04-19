using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.data_types
{
    internal class Pyramid
    {
        public static void Print(int h)
        {
            for (int i = 0; i < h; ++i)
            {
                for (int j = 1; j < (h - i); ++j)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i * 2 + 1; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
