using System;

namespace _1005_Media_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var A = double.Parse(Console.ReadLine());
            var B = double.Parse(Console.ReadLine());

            // 6.43182 = ((5.0 * 3.5) + (7.1 * 7.5)) / 11
            var MEDIA = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("N5"));
        }
    }
}
