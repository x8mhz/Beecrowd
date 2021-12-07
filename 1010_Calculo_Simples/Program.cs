using System;

namespace _1010_Calculo_Simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var item1 = Console.ReadLine().Split(' ');
            var item2 = Console.ReadLine().Split(' ');

            // 51.40 = (2 * 15.30) + (4 * 5.20) 
            var itemPrice = (int.Parse(item1[1]) * double.Parse(item1[2])) + (int.Parse(item2[1]) * double.Parse(item2[2]));

            Console.WriteLine("VALOR A PAGAR: R$ " + itemPrice.ToString("F2"));
        }
    }
}
