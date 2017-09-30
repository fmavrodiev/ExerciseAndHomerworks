using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredients = Console.ReadLine();
            int count = 0;

            while (ingredients != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredients}.");
                ingredients = Console.ReadLine();
                count++;
                if (ingredients == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {count} ingredients.");
                }
            }
        }
    }
}
