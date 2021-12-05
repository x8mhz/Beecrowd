using System;

namespace _1008_Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customerNumber = int.Parse(Console.ReadLine());
            var TotalHoursWorked = int.Parse(Console.ReadLine());
            var hourlySalary = double.Parse(Console.ReadLine());

            // 550.00 = 100 * 5.50
            var salary = TotalHoursWorked * hourlySalary;

            Console.WriteLine("NUMBER = " + customerNumber);
            Console.WriteLine("SALARY = U$ " + salary.ToString("N2").Replace(",", ""));
        }
    }
}
