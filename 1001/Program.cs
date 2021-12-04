using System;

namespace _1001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var A = int.Parse(Console.ReadLine());
            var B = int.Parse(Console.ReadLine());

            // 19 = 10 + 9
            var X = A + B;

            Console.WriteLine("X = " + X);
        }
    }
}
