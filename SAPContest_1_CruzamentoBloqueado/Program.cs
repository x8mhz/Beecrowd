using System;
using System.Linq;

namespace SAPContest_1_CruzamentoBloqueado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dim1 = Console.ReadLine().Split();
            var dim2 = Console.ReadLine().Split();

            for (int i = 0; i < 2; i++)
            {
                foreach (var item1 in dim1[i])
                {
                    if (Convert.ToInt32(item1) >= 0)
                    {
                        foreach (var item2 in dim2[i])
                        {
                            if (Convert.ToInt32(item2) >= 0)
                            {
                                var x1 = Convert.ToInt32(dim1[1].Replace(" ", ""));
                                var x2 = Convert.ToInt32(dim1[2].Replace(" ", ""));
                                var y1 = Convert.ToInt32(dim2[1].Replace(" ", ""));
                                var y2 = int.Parse(dim2[2].Replace(" ", ""));

                                Console.WriteLine(x1 + x2 + y1 + y2);
                            }
                        }
                    }
                }

            }





        }
    }
}
