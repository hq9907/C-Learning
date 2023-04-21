var arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

int ans = -1, freq = 0;

foreach (int x in arr)
{
    int f = CountFreq(ref arr, x);
    if (f > freq)
    {
        ans = x;
        freq = f;
    }
}

Console.WriteLine(ans);

static int CountFreq(ref int[] arr, int x)
{
    int cnt = 0;
    foreach (int i in arr)
    {
        if (i == x)
        {
            ++cnt;
        }
    }
    return cnt;
}