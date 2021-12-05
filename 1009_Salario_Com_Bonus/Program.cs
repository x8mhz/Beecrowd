using System;

namespace _1009_Salario_Com_Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var seller = Console.ReadLine();
            var salary = double.Parse(Console.ReadLine());
            var totalSellMonthly = double.Parse(Console.ReadLine());

            // 684.54 = (1230.30 * 15) / 100 + 500.00
            salary = (totalSellMonthly * 15) / 100 + salary;

            Console.WriteLine("TOTAL = R$ " + salary.ToString("N2").Replace(",", ""));
        }
    }
}
