﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            if (numberOne < numberTwo)
            {
                for (int i = numberOne; i <= numberTwo; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = numberTwo; i <= numberOne; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
