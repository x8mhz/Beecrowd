using System;

namespace _1020_Idade_Em_Dias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var idade = int.Parse(Console.ReadLine());

            // 1 = 400 / 365
            var ano = idade / 365;
            // 1 = (400 % 365) / 30
            var mes = (idade % 365) / 30;
            // 5 = (400 % 365) % 30
            var dia = (idade % 365) % 30;

            Console.WriteLine($"{ano} ano(s)");
            Console.WriteLine($"{mes} mes(es)");
            Console.WriteLine($"{dia} dia(s)");
        }
    }
}
