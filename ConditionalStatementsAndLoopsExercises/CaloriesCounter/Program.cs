using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfIngredients = int.Parse(Console.ReadLine());

            string chees = "chees";
            string tomato = "tomato sauce";
            string salami = "salami";
            string pepper = "pepper";

            string str = "";

            for (int i = 0; i < countOfIngredients; i++)
            {
                str = Console.ReadLine().ToLower();
            }
        }
    }
}
