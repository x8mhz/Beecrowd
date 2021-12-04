using System;

namespace _1002__Area_do_Circulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double n = 3.14159;
            var raio = double.Parse(Console.ReadLine());

            // 12.5664 = 3.14159 * (2.00 * 2.00)
            var area = n * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("N4").Replace(",", ""));
        }
    }
}
