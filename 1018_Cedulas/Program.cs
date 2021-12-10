using System;

namespace _1018_Cedulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            /* HARD-MODE:
                   var cem = N / 100;
                   var cinquenta = (N - (cem * 100)) / 50;
                   var vinte = (N - (cem * 100) - (cinquenta * 50)) / 20;
                   var dez = (N - (cem * 100) - (cinquenta * 50) - (vinte * 20)) / 10;
                   var cinco = (N - (cem * 100) - (cinquenta * 50) - (vinte * 20) - (dez * 10)) / 5;
                   var dois = (N - (cem * 100) - (cinquenta * 50) - (vinte * 20) - (dez * 10) - (cinco * 5)) / 2;
                   var um = (N - (cem * 100) - (cinquenta * 50) - (vinte * 20) - (dez * 10) - (cinco * 5) - (dois * 2)) / 1; */

            var cem = N / 100;
            var cinquenta = (N % 100) / 50;
            var vinte = (N % 100 % 50) / 20;
            var dez = (N % 100 % 50 % 20) / 10;
            var cinco = (N % 100 % 50 % 20 % 10) / 5;
            var dois = (N % 100 % 50 % 20 % 10 % 5) / 2;
            var um = (N % 100 % 50 % 20 % 10 % 5 % 2) / 1;

            Console.WriteLine(N);
            Console.WriteLine(cem + " nota(s) de R$ 100,00");
            Console.WriteLine(cinquenta + " nota(s) de R$ 50,00");
            Console.WriteLine(vinte + " nota(s) de R$ 20,00");
            Console.WriteLine(dez + " nota(s) de R$ 10,00");
            Console.WriteLine(cinco + " nota(s) de R$ 5,00");
            Console.WriteLine(dois + " nota(s) de R$ 2,00");
            Console.WriteLine(um + " nota(s) de R$ 1,00");
        }
    }
}
