using System;

namespace _1017_Gasto_De_Combustivel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double kml = 12;

            var t = int.Parse(Console.ReadLine());
            var v = int.Parse(Console.ReadLine());

            // 70.833... = (10 * 85) / 12
            var l = Convert.ToDouble((t * v) / kml);

            Console.WriteLine(l.ToString("F3"));
        }
    }
}
