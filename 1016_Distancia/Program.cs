using System;

namespace _1016_Distancia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var X_kmh = 60 ;
            var y_kmh = 90;

            // 30km/h = 90km/h - 60km/h
            y_kmh -= X_kmh;

            // 220km/h = (60min * 110km) / 30km/h
            y_kmh = (60 * int.Parse(Console.ReadLine())) / y_kmh;

            Console.WriteLine(y_kmh + " minutos");
        }
    }
}
