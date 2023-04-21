
using System;

foreach (int prime in FindPrimesInRange(1, 100))
{
    Console.WriteLine(prime);
}

static int[] FindPrimesInRange(int startNum, int endNum)
{
    List<int> primes = new List<int>();

    for (int i = startNum; i <= endNum; ++i)
    {
        if (IsPrime(i))
        {
            primes.Add(i);
        }
    }
    return primes.ToArray();
}

static bool IsPrime(int num)
{
    if (num < 2)
        return false;
    for (int i = 2; i * i <= num; ++i)
    {
        if (num % i == 0)
        {
            return false;
        }
    }
    return true;
}