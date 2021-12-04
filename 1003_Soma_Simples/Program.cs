using System;

namespace _1003_Soma_Simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var A = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());

            // 40 = 30 + 10
            var SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);
        }
    }
}
