int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int[] array2 = new int[array.Length];

for (int i = 0; i < array.Length; ++i)
{
    array2[i] = array[i];
}

foreach (int x in array)
{
    Console.WriteLine(x);
}

foreach (int x in array2)
{
    Console.WriteLine(x);
}

