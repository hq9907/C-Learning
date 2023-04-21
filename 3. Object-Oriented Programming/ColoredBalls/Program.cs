using ColoredBalls;

Ball b1 = new Ball(1, new Color(0, 0, 0));
Ball b2 = new Ball(1, new Color(0, 0, 0));
Ball b3 = new Ball(1, new Color(0, 0, 0));

Ball[] list = { b1, b2, b3 };

foreach (Ball b in list)
{
    b.Throw();
    Console.WriteLine(b.NumberOfThrown());
}

Console.WriteLine();
b2.Pop();

foreach (Ball b in list)
{
    b.Throw();
    Console.WriteLine(b.NumberOfThrown());
}