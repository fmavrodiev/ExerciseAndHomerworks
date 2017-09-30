using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string rowStr = "";
            int i = 0;

            // TOP

            for (; i < n; i++)
            {
                if (i < n - 1)
                {
                    rowStr = new string('.', i) + "*" + new string('.', n - i) + "*" + new string('.', n - i) + "*" + new string('.', i);
                }
                else
                {
                    rowStr = new string('.', i) + "*" + new string('*', n - i) + "*" + new string('*', n - i) + "*" + new string('.', i);

                }

                Console.WriteLine(rowStr);
            }

            // MIDDLE

            rowStr = new string('*', 2 * n + 3);
            Console.WriteLine(rowStr);

            // BOTTOM
            int j = 0;
            for (i = n; i > 0; i--)
            {
                if (i == n)
                {
                    rowStr = new string('.', i - 1) + "*" + new string('*', j + 1) + "*" + new string('*', j + 1) + "*" + new string('.', i - 1);
                }
                else
                {
                    rowStr = new string('.', i - 1) + "*" + new string('.', j + 1) + "*" + new string('.', j + 1) + "*" + new string('.', i - 1);
                }

                Console.WriteLine(rowStr);
                j++;
            }
        }
    }
}
