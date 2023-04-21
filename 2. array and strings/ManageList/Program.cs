List<string> list = new List<string>();

while (true)
{
    Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");

    string input = Console.ReadLine();

    if (input.StartsWith("--"))
    {
        list.Clear();
    }
    else if (input.StartsWith("-"))
    {
        list.Remove(input.Substring(2));
    }
    else if (input.StartsWith("+"))
    {
        list.Add(input.Substring(2));
    }

    foreach (string s in list)
    {
        Console.WriteLine(s);
    }
}

