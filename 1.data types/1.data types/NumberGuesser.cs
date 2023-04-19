using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.data_types
{
    internal class NumberGuesser
    {
        int range;
        public NumberGuesser(int range)
        {
            this.range = range;
        }

        public void Guess()
        {
            int correctNumber = new Random().Next(3) + 1;
            int guess;

            while (true)
            {
                guess = int.Parse(Console.ReadLine());
                if (guess == correctNumber)
                {
                    Console.WriteLine("Correct!");
                    break;
                }
                else if (guess <= 0 || guess > range)
                {
                    Console.WriteLine("Out of range.");
                }
                else if (guess < correctNumber)
                {
                    Console.WriteLine("Low.");
                }
                else
                {
                    Console.WriteLine("High.");
                }
            }
        }
    }
}
