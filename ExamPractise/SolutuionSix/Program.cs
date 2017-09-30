using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutuionSix
{
    class Program
    {
        static void Main(string[] args)
        {
            int count1lv = int.Parse(Console.ReadLine());
            int count2lv = int.Parse(Console.ReadLine());
            int count5lv = int.Parse(Console.ReadLine());
            int suma = int.Parse(Console.ReadLine());
            for (int i = 0; i <= count1lv; i++)
            {
                for (int j = 0; j <= count2lv; j++)
                {
                    for (int k = 0; k <= count5lv; k++)
                    {
                        if ((i * 1 + j * 2 + k * 5) == suma)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {suma} lv.");
                        }
                    }
                }
            }
        }
    }
}
