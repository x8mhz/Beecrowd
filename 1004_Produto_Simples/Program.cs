using System;

namespace _1004_Produto_Simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var A = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());

            // 27 = 3 * 9
            var PROD = A * B;

            Console.WriteLine("PROD = " + PROD);
        }
    }
}
