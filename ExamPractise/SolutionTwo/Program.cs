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
            double dohodVleva = double.Parse(Console.ReadLine());
            double sredenUspeh = double.Parse(Console.ReadLine());
            double minimalnaRabotnaZaplata = double.Parse(Console.ReadLine());

            double socialnaStipendia = Math.Floor((minimalnaRabotnaZaplata / 100) * 35);
            double stipendiaZaOtlichenUspeh = Math.Floor(sredenUspeh * 25);

            if (dohodVleva <= minimalnaRabotnaZaplata && sredenUspeh > 4.5 && sredenUspeh < 5.5)
            {
                Console.WriteLine($"You get a Social scholarship {socialnaStipendia} BGN");
            }
            else if (dohodVleva <= minimalnaRabotnaZaplata && sredenUspeh > 5.5 && socialnaStipendia < stipendiaZaOtlichenUspeh)
            {
                Console.WriteLine($"You get a scholarship for excellent results {stipendiaZaOtlichenUspeh} BGN");
            }
            else if (dohodVleva > minimalnaRabotnaZaplata && sredenUspeh >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {stipendiaZaOtlichenUspeh} BGN");
            }
            else if (dohodVleva <= minimalnaRabotnaZaplata && sredenUspeh > 5.5 && socialnaStipendia > stipendiaZaOtlichenUspeh)
            {
                Console.WriteLine($"You get a Social scholarship {socialnaStipendia} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
