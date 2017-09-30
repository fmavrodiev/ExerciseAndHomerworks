using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsOut = int.Parse(Console.ReadLine());

            double studioRoom = 0;
            double doubleRoom = 0;
            double suiteRoom = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioRoom = 50;
                    doubleRoom = 65;
                    suiteRoom = 75;
                    if (nightsOut > 7)
                    {
                        studioRoom = studioRoom * 0.95;
                        if (month == "October")
                        {
                            Console.WriteLine($"Studio: {(nightsOut * studioRoom) - studioRoom:f2} lv.");
                            Console.WriteLine($"Double: {nightsOut * doubleRoom:f2} lv.");
                            Console.WriteLine($"Suite: {nightsOut * suiteRoom:f2} lv.");
                            break;
                        }
                    }
                    Console.WriteLine($"Studio: {nightsOut * studioRoom:f2} lv.");
                    Console.WriteLine($"Double: {nightsOut * doubleRoom:f2} lv.");
                    Console.WriteLine($"Suite: {nightsOut * suiteRoom:f2} lv.");
                    break;
                case "June":
                case "September":
                    studioRoom = 60;
                    doubleRoom = 72;
                    suiteRoom = 82;
                    if (month == "September" && nightsOut > 7)
                    {
                        Console.WriteLine($"Studio: {(nightsOut * studioRoom) - studioRoom:f2} lv.");
                        Console.WriteLine($"Double: {nightsOut * doubleRoom:f2} lv.");
                        Console.WriteLine($"Suite: {nightsOut * suiteRoom:f2} lv.");
                        if (nightsOut > 14)
                        {
                            doubleRoom = doubleRoom * 0.90;
                            Console.WriteLine($"Studio: {(nightsOut * studioRoom) - studioRoom:f2} lv.");
                            Console.WriteLine($"Double: {nightsOut * doubleRoom:f2} lv.");
                            Console.WriteLine($"Suite: {nightsOut * suiteRoom:f2} lv.");
                            break;
                        }
                        break;
                    }
                    if (nightsOut > 14)
                    {
                        doubleRoom = doubleRoom * 0.90;
                    }
                    Console.WriteLine($"Studio: {nightsOut * studioRoom:f2} lv.");
                    Console.WriteLine($"Double: {nightsOut * doubleRoom:f2} lv.");
                    Console.WriteLine($"Suite: {nightsOut * suiteRoom:f2} lv.");
                    break;
                case "July":
                case "August":
                case "December":
                    studioRoom = 68;
                    doubleRoom = 77;
                    suiteRoom = 89;
                    if (nightsOut > 14)
                    {
                        suiteRoom = suiteRoom * 0.85;
                    }
                    Console.WriteLine($"Studio: {nightsOut * studioRoom:f2} lv.");
                    Console.WriteLine($"Double: {nightsOut * doubleRoom:f2} lv.");
                    Console.WriteLine($"Suite: {nightsOut * suiteRoom:f2} lv.");
                    break;
            }
        }
    }
}
