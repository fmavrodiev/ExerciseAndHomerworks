using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string str = "";

            for (int currentRow = 0; currentRow <= number; currentRow++)
            {
                for (int currentCol = 0; currentCol < 1; currentCol++)
                {
                    str = new string (' ', number - currentRow) + new string ('*', currentRow) + " | " + new string('*', currentRow);
                    Console.WriteLine(str);
                }
            }
        }
    }
}
