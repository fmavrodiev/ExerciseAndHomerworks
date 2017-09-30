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
            int numberOfPhotos = int.Parse(Console.ReadLine());
            string typePhotos = Console.ReadLine().ToUpper();
            string orderType = Console.ReadLine().ToLower();

            double price = 0;
            double sum = 0;

            if (typePhotos == "9X13")
            {
                price = 0.16;
                sum = numberOfPhotos * price;
                if (numberOfPhotos >= 50)
                {
                    sum = ((sum * 5) / 100) - sum;
                }
                if (orderType == "online")
                {
                    sum = ((sum * 2) / 100) - sum;
                }
            }
            if (typePhotos == "10X15")
            {
                price = 0.16;
                sum = numberOfPhotos * price;
                if (numberOfPhotos >= 80)
                {
                    sum = ((sum * 3) / 100) - sum;
                }
                if (orderType == "online")
                {
                    sum = ((sum * 2) / 100) - sum;
                }
            }
            if (typePhotos == "13X18")
            {
                price = 0.38;
                sum = numberOfPhotos * price;
                if (numberOfPhotos >= 50 && numberOfPhotos <=100)
                {
                    sum = ((sum * 3) / 100) - sum;
                }
                if (numberOfPhotos > 100)
                {
                    sum = ((sum * 5) / 100) - sum;
                }
                if (orderType == "online")
                {
                    sum = ((sum * 2) / 100) - sum;
                }
            }
            if (typePhotos == "20X30")
            {
                price = 2.90;
                sum = numberOfPhotos * price;
                if (numberOfPhotos >= 10 && numberOfPhotos <=50)
                {
                    sum = ((sum * 7) / 100) - sum;
                }
                if (numberOfPhotos > 50)
                {
                    sum = ((sum * 9) / 100) - sum;
                }
                if (orderType == "online")
                {
                    sum = ((sum * 2) / 100) - sum;
                }
            }
            Console.WriteLine($"{Math.Abs(sum):f2}BGN");
        }
    }
}
