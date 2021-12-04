using System;

namespace _1006_Media_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var A = double.Parse(Console.ReadLine());
            var B = double.Parse(Console.ReadLine());
            var C = double.Parse(Console.ReadLine());

            // 6.3 = ((5.0 * 2) + (6.0 * 3) + (7.0 * 5)) / 10
            var MEDIA = ((A * 2) + (B * 3) + (C * 5)) / 10;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("N1"));
        }
    }
}
