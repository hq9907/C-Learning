using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.data_types
{
    internal class UnderstandingTypes
    {
        public static void ShowTypesInfo()
        {
            string format = "{0, -8}:   size = {1, -8} min = {2, -40} max = {3, -40}";
            Console.WriteLine(format, "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine(format, "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
            Console.WriteLine(format, "short", sizeof(short), short.MinValue, short.MaxValue);
            Console.WriteLine(format, "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            Console.WriteLine(format, "int", sizeof(int), int.MinValue, int.MaxValue);
            Console.WriteLine(format, "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
            Console.WriteLine(format, "long", sizeof(long), long.MinValue, long.MaxValue);
            Console.WriteLine(format, "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            Console.WriteLine(format, "float", sizeof(float), float.MinValue, float.MaxValue);
            Console.WriteLine(format, "double", sizeof(double), double.MinValue, double.MaxValue);
            Console.WriteLine(format, "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
        }
    }
}
