var arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);

int index = 0, length = 0;

for (int i = 0; i < arr.Length; )
{
    int j = i;
    for (; j < arr.Length && arr[i] == arr[j]; ++j) ;

    if (j - i > length)
    {
        length = j - i;
        index = i;
    }
    i = j;
}

for (int i = index; i < index + length; ++i)
{
    Console.Write(arr[i] + " ");
}