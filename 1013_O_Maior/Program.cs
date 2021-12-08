using System;

namespace _1013_O_Maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var values = Console.ReadLine().Split();

            var A = int.Parse(values[0]);
            var B = int.Parse(values[1]);
            var C = int.Parse(values[2]);

            // 14 = (7 + 14 + abs(7 - 14)) / 2
            //                Absuluto = -7
            var greaterAB = (A + B + Math.Abs(A - B)) / 2;

            // 106 = (14 + 106 + abs(14 - 106)) / 2
            //                   Absuluto = -92
            var greaterThan = (greaterAB + C + Math.Abs(greaterAB - C)) / 2;

            Console.WriteLine(greaterThan + " eh o maior");
        }
    }
}
