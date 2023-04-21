for (int i = 1; i <= 10; ++i)
{
    Console.WriteLine(Fibonacci(i));
}

static int Fibonacci(int i)
{
    if (i <= 2)
        return 1;
    else
        return Fibonacci(i - 1) + Fibonacci(i - 2);
}
