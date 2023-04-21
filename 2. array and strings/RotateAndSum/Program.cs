var array = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
var k = Convert.ToInt32(Console.ReadLine());
var n = array.Length;

var sum = new int[n];

for (int i = 0; i < n; ++i)
{
    for (int j = -1; j >= -k; --j)
    {
        sum[i] += array[(i + j + n) % n];
    }
}

foreach (int x in sum)
{
    Console.Write(x + " ");
}