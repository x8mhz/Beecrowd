using System;

namespace _1011_Esfera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            var r = double.Parse(Console.ReadLine());

            var v = (4 / 3.0) * pi * Math.Pow(r, 3);

            Console.WriteLine("VOLUME = " + v.ToString("F3"));
        }
    }
}
