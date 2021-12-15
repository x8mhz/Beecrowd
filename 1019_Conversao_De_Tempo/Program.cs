using System;

namespace _1019_Conversao_De_Tempo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            // 53 = (140153 % 3600) % 60
            var S = (N % 3600) % 60;
            // 55 = (140153 %) / 06
            var M = (N % 3600) / 60;
            // 38 = 140153 / 3600
            var H = N / 3600;

            Console.WriteLine(H + ":" + M + ":" + S);
        }
    }
}
