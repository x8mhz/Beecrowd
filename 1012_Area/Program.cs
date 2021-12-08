using System;

namespace _1012_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;

            var values = Console.ReadLine().Split(' ');

            var A = double.Parse(values[0]);
            var B = double.Parse(values[1]);
            var C = double.Parse(values[2]);
            
            // 7.800 = (3.0 * 5.2) / 2
            Console.WriteLine("TRIANGULO: " + ((A * C) / 2).ToString("F3"));
            // 84.949 = 3.14159 * (5.2 * 5.2)
            Console.WriteLine("CIRCULO: " + (pi * (Math.Pow(C, 2))).ToString("F3"));
            // 18.200 = ((3.0 + 4.0) * C) / 2
            Console.WriteLine("TRAPEZIO: " + (((A + B) * C) / 2).ToString("F3"));
            // 16.000 = 4.0 * 4.0
            Console.WriteLine("QUADRADO: " + (Math.Pow(B, 2)).ToString("F3"));
            // 12.000 = 3.0 * 4.0
            Console.WriteLine("RETANGULO: " + (A * B).ToString("F3"));
        }
    }
}
