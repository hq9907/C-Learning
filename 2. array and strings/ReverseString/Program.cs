var s = Console.ReadLine();

Reverse1(s);
Reverse2(s);

static void Reverse1(string s)
{
    Console.WriteLine(new string(s.ToCharArray().Reverse().ToArray()));
}
static void Reverse2(string s)
{
    for (int i = s.Length - 1; i >= 0; --i)
    {
        Console.Write(s[i]);
    }
    Console.WriteLine();
}