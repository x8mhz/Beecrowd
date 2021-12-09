using System;

namespace _1014_Consumo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var X = int.Parse(Console.ReadLine());
            var Y = double.Parse(Console.ReadLine());

            //14.286 = 500 / 35.0
            var kml = X / Y;

            Console.WriteLine(kml.ToString("F3") + " km/l");
        }
    }
}
