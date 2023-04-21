internal class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = GenerateNumbers();
        Reverse(numbers);
        PrintNumbers(numbers);
    }

    static int[] GenerateNumbers(int n = 10)
    {
        int[] numbers = new int[n];
        for (int i = 0; i < n; ++i)
            numbers[i] = i;
        return numbers;
    }

    static void Reverse(int[] numbers)
    {
        numbers.Reverse().ToArray().CopyTo(numbers, 0);
    }

    static void PrintNumbers(int[] numbers)
    {
        foreach (int x in numbers)
        {
            Console.WriteLine(x);
        }
    }
}