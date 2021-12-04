using System;

namespace _1007_Diferenca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var A = int.Parse(Console.ReadLine());  
            var B = int.Parse(Console.ReadLine());
            var C = int.Parse(Console.ReadLine());
            var D = int.Parse(Console.ReadLine());

            // -26 = (5 * 6) - (7 * 8)
            var DIFERENCA = (A * B) - (C * D);

            Console.WriteLine("DIFERENCA = " + DIFERENCA);
        }
    }
}
