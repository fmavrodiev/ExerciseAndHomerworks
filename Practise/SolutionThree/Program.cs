using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int frequancy = int.Parse(Console.ReadLine());
            int duration = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.Beep(frequancy, duration);
            }
        }
    }
}
