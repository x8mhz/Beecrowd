using System;

namespace _1015_Distancia_Entre_Dois_Pontos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = Console.ReadLine().Split();
            var p2 = Console.ReadLine().Split();

            var x1 = double.Parse(p1[0]);
            var y1 = double.Parse(p1[1]);
            var x2 = double.Parse(p2[0]);
            var y2 = double.Parse(p2[1]);

            var distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine(distance.ToString("F4"));
        }
    }
}
