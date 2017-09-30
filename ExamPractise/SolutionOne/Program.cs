using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfRetangularTables = int.Parse(Console.ReadLine());
            double lenghtOfRectangularTables = double.Parse(Console.ReadLine());
            double wightOFRectangularTables = double.Parse(Console.ReadLine());

            double coversArea = countOfRetangularTables * (lenghtOfRectangularTables + 2 * 0.30) * (wightOFRectangularTables + 2 * 0.30);
            double smallCoversArea = countOfRetangularTables * (lenghtOfRectangularTables / 2) * (lenghtOfRectangularTables / 2);
            double priceInUSD = coversArea * 7 + smallCoversArea * 9;
            double priceInBGN = priceInUSD * 1.85;
            Console.WriteLine($"{priceInUSD:f2} USD");
            Console.WriteLine($"{priceInBGN:f2} BGN");
        }
    }
}
